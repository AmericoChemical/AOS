'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 4/6/2015 7:55:57 PM
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
	MustInherit Public Class esViewWorkOrderItemsScreenCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewWorkOrderItemsScreenCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewWorkOrderItemsScreenQuery)
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
            Me.InitQuery(CType(query, esViewWorkOrderItemsScreenQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewWorkOrderItemsScreen) As ViewWorkOrderItemsScreen
			Return CType(MyBase.DetachEntity(entity), ViewWorkOrderItemsScreen)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewWorkOrderItemsScreen) As ViewWorkOrderItemsScreen
			Return CType(MyBase.AttachEntity(entity), ViewWorkOrderItemsScreen)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewWorkOrderItemsScreenCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewWorkOrderItemsScreen
            Get
                Return TryCast(MyBase.Item(index), ViewWorkOrderItemsScreen)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewWorkOrderItemsScreen)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewWorkOrderItemsScreen	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewWorkOrderItemsScreenQuery
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
												
						Case "Invitemnumber"
							Me.str.Invitemnumber = CType(value, string)
												
						Case "Itemcomments"
							Me.str.Itemcomments = CType(value, string)
												
						Case "Lotnumber"
							Me.str.Lotnumber = CType(value, string)
												
						Case "Warehouselocation"
							Me.str.Warehouselocation = CType(value, string)
												
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
												
						Case "Sourcetype"
							Me.str.Sourcetype = CType(value, string)
												
						Case "Sourcedocument"
							Me.str.Sourcedocument = CType(value, string)
												
						Case "Sourcestatus"
							Me.str.Sourcestatus = CType(value, string)
												
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
												
						Case "DOTIDNumber"
							Me.str.DOTIDNumber = CType(value, string)
												
						Case "Hazmatid"
							Me.str.Hazmatid = CType(value, string)
												
						Case "Hazmatclass"
							Me.str.Hazmatclass = CType(value, string)
												
						Case "Hazmatpackagegroup"
							Me.str.Hazmatpackagegroup = CType(value, string)
												
						Case "Classrate"
							Me.str.Classrate = CType(value, string)
												
						Case "Dotdesc"
							Me.str.Dotdesc = CType(value, string)
												
						Case "Hazmatdesc"
							Me.str.Hazmatdesc = CType(value, string)
												
						Case "Unline"
							Me.str.Unline = CType(value, string)
												
						Case "Ishazardous"
							Me.str.Ishazardous = CType(value, string)
												
						Case "Itemnotes"
							Me.str.Itemnotes = CType(value, string)
												
						Case "Createdtime"
							Me.str.Createdtime = CType(value, string)
												
						Case "Createdby"
							Me.str.Createdby = CType(value, string)
												
						Case "Modifiedtime"
							Me.str.Modifiedtime = CType(value, string)
												
						Case "Modifiedby"
							Me.str.Modifiedby = CType(value, string)
												
						Case "Ld1"
							Me.str.Ld1 = CType(value, string)
												
						Case "Ld2"
							Me.str.Ld2 = CType(value, string)
												
						Case "Ld3"
							Me.str.Ld3 = CType(value, string)
												
						Case "Custitemid"
							Me.str.Custitemid = CType(value, string)
												
						Case "Itemstatus"
							Me.str.Itemstatus = CType(value, string)
												
						Case "Standardunitcost"
							Me.str.Standardunitcost = CType(value, string)
												
						Case "Unitprice"
							Me.str.Unitprice = CType(value, string)
												
						Case "Priceunits"
							Me.str.Priceunits = CType(value, string)
												
						Case "Priceuom"
							Me.str.Priceuom = CType(value, string)
												
						Case "Standardcostunits"
							Me.str.Standardcostunits = CType(value, string)
												
						Case "Standardcostuom"
							Me.str.Standardcostuom = CType(value, string)
												
						Case "Actualcostunits"
							Me.str.Actualcostunits = CType(value, string)
												
						Case "Actualcostuom"
							Me.str.Actualcostuom = CType(value, string)
												
						Case "Extprice"
							Me.str.Extprice = CType(value, string)
												
						Case "Extcost"
							Me.str.Extcost = CType(value, string)
												
						Case "Actualunitcost"
							Me.str.Actualunitcost = CType(value, string)
												
						Case "Extprofit"
							Me.str.Extprofit = CType(value, string)
												
						Case "Available"
							Me.str.Available = CType(value, string)
												
						Case "Expectedindate"
							Me.str.Expectedindate = CType(value, string)
												
						Case "Dateneeded"
							Me.str.Dateneeded = CType(value, string)
												
						Case "Estimatedcompletiondate"
							Me.str.Estimatedcompletiondate = CType(value, string)
												
						Case "Neededby"
							Me.str.Neededby = CType(value, string)
					
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
						
						Case "Invitemnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Invitemnumber = CType(value, Nullable(Of System.Int32))
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
						
						Case "Sourcedocument"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Sourcedocument = CType(value, Nullable(Of System.Int32))
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
						
						Case "Hazmatid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Hazmatid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Ishazardous"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Ishazardous = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Createdtime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Createdtime = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Modifiedtime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Modifiedtime = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Standardunitcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Standardunitcost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Unitprice"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Unitprice = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Priceunits"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Priceunits = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Standardcostunits"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Standardcostunits = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Actualcostunits"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Actualcostunits = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Extprice"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Extprice = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Extcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Extcost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Actualunitcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Actualunitcost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Extprofit"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Extprofit = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Available"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Available = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Expectedindate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Expectedindate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Dateneeded"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Dateneeded = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Estimatedcompletiondate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Estimatedcompletiondate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Neededby"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Neededby = CType(value, Nullable(Of System.DateTime))
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
		' Maps to viewWorkOrderItemsScreen.WORKORDERITEMNUMBER
		' </summary>
		Public Overridable Property Workorderitemnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewWorkOrderItemsScreenMetadata.ColumnNames.Workorderitemnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewWorkOrderItemsScreenMetadata.ColumnNames.Workorderitemnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.WORKORDERNUMBER
		' </summary>
		Public Overridable Property Workordernumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewWorkOrderItemsScreenMetadata.ColumnNames.Workordernumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewWorkOrderItemsScreenMetadata.ColumnNames.Workordernumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.ITEMTYPE
		' </summary>
		Public Overridable Property Itemtype As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Itemtype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Itemtype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.ITEMID
		' </summary>
		Public Overridable Property Itemid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewWorkOrderItemsScreenMetadata.ColumnNames.Itemid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewWorkOrderItemsScreenMetadata.ColumnNames.Itemid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.ITEMDESCRIPTION
		' </summary>
		Public Overridable Property Itemdescription As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Itemdescription)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Itemdescription, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewWorkOrderItemsScreenMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewWorkOrderItemsScreenMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.QTY
		' </summary>
		Public Overridable Property Qty As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewWorkOrderItemsScreenMetadata.ColumnNames.Qty)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewWorkOrderItemsScreenMetadata.ColumnNames.Qty, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.INVITEMNUMBER
		' </summary>
		Public Overridable Property Invitemnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewWorkOrderItemsScreenMetadata.ColumnNames.Invitemnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewWorkOrderItemsScreenMetadata.ColumnNames.Invitemnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.ITEMCOMMENTS
		' </summary>
		Public Overridable Property Itemcomments As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Itemcomments)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Itemcomments, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.LOTNUMBER
		' </summary>
		Public Overridable Property Lotnumber As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Lotnumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Lotnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.WAREHOUSELOCATION
		' </summary>
		Public Overridable Property Warehouselocation As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Warehouselocation)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Warehouselocation, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.BILLABLE
		' </summary>
		Public Overridable Property Billable As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewWorkOrderItemsScreenMetadata.ColumnNames.Billable)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewWorkOrderItemsScreenMetadata.ColumnNames.Billable, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.UNITCOST
		' </summary>
		Public Overridable Property Unitcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewWorkOrderItemsScreenMetadata.ColumnNames.Unitcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewWorkOrderItemsScreenMetadata.ColumnNames.Unitcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.ITEMPRICE
		' </summary>
		Public Overridable Property Itemprice As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewWorkOrderItemsScreenMetadata.ColumnNames.Itemprice)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewWorkOrderItemsScreenMetadata.ColumnNames.Itemprice, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.ITEMPROFIT
		' </summary>
		Public Overridable Property Itemprofit As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewWorkOrderItemsScreenMetadata.ColumnNames.Itemprofit)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewWorkOrderItemsScreenMetadata.ColumnNames.Itemprofit, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.UNITORCONTAINER
		' </summary>
		Public Overridable Property Unitorcontainer As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Unitorcontainer)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Unitorcontainer, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.UNITS
		' </summary>
		Public Overridable Property Units As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewWorkOrderItemsScreenMetadata.ColumnNames.Units)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewWorkOrderItemsScreenMetadata.ColumnNames.Units, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.UOM
		' </summary>
		Public Overridable Property Uom As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Uom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Uom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.SOURCETYPE
		' </summary>
		Public Overridable Property Sourcetype As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Sourcetype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Sourcetype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.SOURCEDOCUMENT
		' </summary>
		Public Overridable Property Sourcedocument As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewWorkOrderItemsScreenMetadata.ColumnNames.Sourcedocument)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewWorkOrderItemsScreenMetadata.ColumnNames.Sourcedocument, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.SOURCESTATUS
		' </summary>
		Public Overridable Property Sourcestatus As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Sourcestatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Sourcestatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.WORKORDERITEMSTATUS
		' </summary>
		Public Overridable Property Workorderitemstatus As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Workorderitemstatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Workorderitemstatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.CUSTOMERPO
		' </summary>
		Public Overridable Property Customerpo As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Customerpo)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Customerpo, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.SHIPMENTITEMNUMBER
		' </summary>
		Public Overridable Property Shipmentitemnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewWorkOrderItemsScreenMetadata.ColumnNames.Shipmentitemnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewWorkOrderItemsScreenMetadata.ColumnNames.Shipmentitemnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.INVOICEITEMNUMBER
		' </summary>
		Public Overridable Property Invoiceitemnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewWorkOrderItemsScreenMetadata.ColumnNames.Invoiceitemnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewWorkOrderItemsScreenMetadata.ColumnNames.Invoiceitemnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.TOTALVOLUME
		' </summary>
		Public Overridable Property Totalvolume As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewWorkOrderItemsScreenMetadata.ColumnNames.Totalvolume)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewWorkOrderItemsScreenMetadata.ColumnNames.Totalvolume, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.VOLUMEUOM
		' </summary>
		Public Overridable Property Volumeuom As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Volumeuom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Volumeuom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.TOTALWEIGHT
		' </summary>
		Public Overridable Property Totalweight As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewWorkOrderItemsScreenMetadata.ColumnNames.Totalweight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewWorkOrderItemsScreenMetadata.ColumnNames.Totalweight, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.WEIGHTUOM
		' </summary>
		Public Overridable Property Weightuom As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Weightuom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Weightuom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.DOTIDNumber
		' </summary>
		Public Overridable Property DOTIDNumber As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.DOTIDNumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.DOTIDNumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.HAZMATID
		' </summary>
		Public Overridable Property Hazmatid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewWorkOrderItemsScreenMetadata.ColumnNames.Hazmatid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewWorkOrderItemsScreenMetadata.ColumnNames.Hazmatid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.HAZMATCLASS
		' </summary>
		Public Overridable Property Hazmatclass As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Hazmatclass)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Hazmatclass, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.HAZMATPACKAGEGROUP
		' </summary>
		Public Overridable Property Hazmatpackagegroup As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Hazmatpackagegroup)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Hazmatpackagegroup, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.CLASSRATE
		' </summary>
		Public Overridable Property Classrate As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Classrate)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Classrate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.DOTDESC
		' </summary>
		Public Overridable Property Dotdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Dotdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Dotdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.HAZMATDESC
		' </summary>
		Public Overridable Property Hazmatdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Hazmatdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Hazmatdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.UNLINE
		' </summary>
		Public Overridable Property Unline As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Unline)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Unline, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.ISHAZARDOUS
		' </summary>
		Public Overridable Property Ishazardous As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewWorkOrderItemsScreenMetadata.ColumnNames.Ishazardous)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewWorkOrderItemsScreenMetadata.ColumnNames.Ishazardous, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.ITEMNOTES
		' </summary>
		Public Overridable Property Itemnotes As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Itemnotes)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Itemnotes, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.CREATEDTIME
		' </summary>
		Public Overridable Property Createdtime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewWorkOrderItemsScreenMetadata.ColumnNames.Createdtime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewWorkOrderItemsScreenMetadata.ColumnNames.Createdtime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.CREATEDBY
		' </summary>
		Public Overridable Property Createdby As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Createdby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Createdby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.MODIFIEDTIME
		' </summary>
		Public Overridable Property Modifiedtime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewWorkOrderItemsScreenMetadata.ColumnNames.Modifiedtime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewWorkOrderItemsScreenMetadata.ColumnNames.Modifiedtime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.MODIFIEDBY
		' </summary>
		Public Overridable Property Modifiedby As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Modifiedby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Modifiedby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.LD1
		' </summary>
		Public Overridable Property Ld1 As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Ld1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Ld1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.LD2
		' </summary>
		Public Overridable Property Ld2 As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Ld2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Ld2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.LD3
		' </summary>
		Public Overridable Property Ld3 As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Ld3)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Ld3, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.CUSTITEMID
		' </summary>
		Public Overridable Property Custitemid As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Custitemid)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Custitemid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.ITEMSTATUS
		' </summary>
		Public Overridable Property Itemstatus As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Itemstatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Itemstatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.STANDARDUNITCOST
		' </summary>
		Public Overridable Property Standardunitcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewWorkOrderItemsScreenMetadata.ColumnNames.Standardunitcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewWorkOrderItemsScreenMetadata.ColumnNames.Standardunitcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.UNITPRICE
		' </summary>
		Public Overridable Property Unitprice As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewWorkOrderItemsScreenMetadata.ColumnNames.Unitprice)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewWorkOrderItemsScreenMetadata.ColumnNames.Unitprice, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.PRICEUNITS
		' </summary>
		Public Overridable Property Priceunits As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewWorkOrderItemsScreenMetadata.ColumnNames.Priceunits)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewWorkOrderItemsScreenMetadata.ColumnNames.Priceunits, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.PRICEUOM
		' </summary>
		Public Overridable Property Priceuom As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Priceuom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Priceuom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.STANDARDCOSTUNITS
		' </summary>
		Public Overridable Property Standardcostunits As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewWorkOrderItemsScreenMetadata.ColumnNames.Standardcostunits)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewWorkOrderItemsScreenMetadata.ColumnNames.Standardcostunits, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.STANDARDCOSTUOM
		' </summary>
		Public Overridable Property Standardcostuom As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Standardcostuom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Standardcostuom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.ACTUALCOSTUNITS
		' </summary>
		Public Overridable Property Actualcostunits As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewWorkOrderItemsScreenMetadata.ColumnNames.Actualcostunits)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewWorkOrderItemsScreenMetadata.ColumnNames.Actualcostunits, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.ACTUALCOSTUOM
		' </summary>
		Public Overridable Property Actualcostuom As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Actualcostuom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderItemsScreenMetadata.ColumnNames.Actualcostuom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.EXTPRICE
		' </summary>
		Public Overridable Property Extprice As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewWorkOrderItemsScreenMetadata.ColumnNames.Extprice)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewWorkOrderItemsScreenMetadata.ColumnNames.Extprice, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.EXTCOST
		' </summary>
		Public Overridable Property Extcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewWorkOrderItemsScreenMetadata.ColumnNames.Extcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewWorkOrderItemsScreenMetadata.ColumnNames.Extcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.ACTUALUNITCOST
		' </summary>
		Public Overridable Property Actualunitcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewWorkOrderItemsScreenMetadata.ColumnNames.Actualunitcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewWorkOrderItemsScreenMetadata.ColumnNames.Actualunitcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.EXTPROFIT
		' </summary>
		Public Overridable Property Extprofit As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewWorkOrderItemsScreenMetadata.ColumnNames.Extprofit)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewWorkOrderItemsScreenMetadata.ColumnNames.Extprofit, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.AVAILABLE
		' </summary>
		Public Overridable Property Available As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewWorkOrderItemsScreenMetadata.ColumnNames.Available)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewWorkOrderItemsScreenMetadata.ColumnNames.Available, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.EXPECTEDINDATE
		' </summary>
		Public Overridable Property Expectedindate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewWorkOrderItemsScreenMetadata.ColumnNames.Expectedindate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewWorkOrderItemsScreenMetadata.ColumnNames.Expectedindate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.DATENEEDED
		' </summary>
		Public Overridable Property Dateneeded As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewWorkOrderItemsScreenMetadata.ColumnNames.Dateneeded)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewWorkOrderItemsScreenMetadata.ColumnNames.Dateneeded, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.ESTIMATEDCOMPLETIONDATE
		' </summary>
		Public Overridable Property Estimatedcompletiondate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewWorkOrderItemsScreenMetadata.ColumnNames.Estimatedcompletiondate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewWorkOrderItemsScreenMetadata.ColumnNames.Estimatedcompletiondate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsScreen.NEEDEDBY
		' </summary>
		Public Overridable Property Neededby As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewWorkOrderItemsScreenMetadata.ColumnNames.Neededby)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewWorkOrderItemsScreenMetadata.ColumnNames.Neededby, value)
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
		
			Public Sub New(ByVal entity As esViewWorkOrderItemsScreen)
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
		  	
			Public Property Sourcestatus As System.String 
				Get
					Dim data_ As System.String = entity.Sourcestatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Sourcestatus = Nothing
					Else
						entity.Sourcestatus = Convert.ToString(Value)
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
		  	
			Public Property DOTIDNumber As System.String 
				Get
					Dim data_ As System.String = entity.DOTIDNumber
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DOTIDNumber = Nothing
					Else
						entity.DOTIDNumber = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Hazmatid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Hazmatid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Hazmatid = Nothing
					Else
						entity.Hazmatid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Hazmatclass As System.String 
				Get
					Dim data_ As System.String = entity.Hazmatclass
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Hazmatclass = Nothing
					Else
						entity.Hazmatclass = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Hazmatpackagegroup As System.String 
				Get
					Dim data_ As System.String = entity.Hazmatpackagegroup
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Hazmatpackagegroup = Nothing
					Else
						entity.Hazmatpackagegroup = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Classrate As System.String 
				Get
					Dim data_ As System.String = entity.Classrate
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Classrate = Nothing
					Else
						entity.Classrate = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Dotdesc As System.String 
				Get
					Dim data_ As System.String = entity.Dotdesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Dotdesc = Nothing
					Else
						entity.Dotdesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Hazmatdesc As System.String 
				Get
					Dim data_ As System.String = entity.Hazmatdesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Hazmatdesc = Nothing
					Else
						entity.Hazmatdesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Unline As System.String 
				Get
					Dim data_ As System.String = entity.Unline
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Unline = Nothing
					Else
						entity.Unline = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Ishazardous As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Ishazardous
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Ishazardous = Nothing
					Else
						entity.Ishazardous = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property Itemnotes As System.String 
				Get
					Dim data_ As System.String = entity.Itemnotes
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Itemnotes = Nothing
					Else
						entity.Itemnotes = Convert.ToString(Value)
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
		  	
			Public Property Ld1 As System.String 
				Get
					Dim data_ As System.String = entity.Ld1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Ld1 = Nothing
					Else
						entity.Ld1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Ld2 As System.String 
				Get
					Dim data_ As System.String = entity.Ld2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Ld2 = Nothing
					Else
						entity.Ld2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Ld3 As System.String 
				Get
					Dim data_ As System.String = entity.Ld3
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Ld3 = Nothing
					Else
						entity.Ld3 = Convert.ToString(Value)
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
		  	
			Public Property Available As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Available
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Available = Nothing
					Else
						entity.Available = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Expectedindate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Expectedindate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Expectedindate = Nothing
					Else
						entity.Expectedindate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Dateneeded As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Dateneeded
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Dateneeded = Nothing
					Else
						entity.Dateneeded = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Estimatedcompletiondate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Estimatedcompletiondate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Estimatedcompletiondate = Nothing
					Else
						entity.Estimatedcompletiondate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Neededby As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Neededby
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Neededby = Nothing
					Else
						entity.Neededby = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewWorkOrderItemsScreen
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewWorkOrderItemsScreenQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewWorkOrderItemsScreen can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewWorkOrderItemsScreenQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewWorkOrderItemsScreenMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Workorderitemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Workorderitemnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Workordernumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Workordernumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Itemtype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Itemtype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Itemid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Itemid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Itemdescription As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Itemdescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Qty As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Qty, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Invitemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Invitemnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Itemcomments As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Itemcomments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Lotnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Lotnumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Warehouselocation As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Warehouselocation, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Billable As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Billable, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Unitcost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Unitcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Itemprice As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Itemprice, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Itemprofit As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Itemprofit, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Unitorcontainer As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Unitorcontainer, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Units As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Units, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Uom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Uom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Sourcetype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Sourcetype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Sourcedocument As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Sourcedocument, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Sourcestatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Sourcestatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Workorderitemstatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Workorderitemstatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Customerpo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Customerpo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipmentitemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Shipmentitemnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Invoiceitemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Invoiceitemnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Totalvolume As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Totalvolume, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Volumeuom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Volumeuom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Totalweight As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Totalweight, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Weightuom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Weightuom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DOTIDNumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.DOTIDNumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Hazmatid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Hazmatid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Hazmatclass As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Hazmatclass, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Hazmatpackagegroup As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Hazmatpackagegroup, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Classrate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Classrate, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Dotdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Dotdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Hazmatdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Hazmatdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Unline As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Unline, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Ishazardous As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Ishazardous, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Itemnotes As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Itemnotes, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Createdtime As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Createdtime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Createdby As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Createdby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Modifiedtime As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Modifiedtime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Modifiedby As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Modifiedby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Ld1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Ld1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Ld2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Ld2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Ld3 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Ld3, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Custitemid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Custitemid, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Itemstatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Itemstatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Standardunitcost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Standardunitcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Unitprice As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Unitprice, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Priceunits As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Priceunits, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Priceuom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Priceuom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Standardcostunits As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Standardcostunits, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Standardcostuom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Standardcostuom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Actualcostunits As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Actualcostunits, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Actualcostuom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Actualcostuom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Extprice As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Extprice, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Extcost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Extcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Actualunitcost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Actualunitcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Extprofit As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Extprofit, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Available As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Available, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Expectedindate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Expectedindate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Dateneeded As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Dateneeded, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Estimatedcompletiondate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Estimatedcompletiondate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Neededby As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsScreenMetadata.ColumnNames.Neededby, esSystemType.DateTime)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewWorkOrderItemsScreenCollection")> _
	Partial Public Class ViewWorkOrderItemsScreenCollection
		Inherits esViewWorkOrderItemsScreenCollection
		Implements IEnumerable(Of ViewWorkOrderItemsScreen)
		
        Public Shared Widening Operator CType(ByVal coll As ViewWorkOrderItemsScreenCollection) As List(Of ViewWorkOrderItemsScreen)
            Dim list As List(Of ViewWorkOrderItemsScreen) = New List(Of ViewWorkOrderItemsScreen)
            Dim emp As ViewWorkOrderItemsScreen

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewWorkOrderItemsScreenMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewWorkOrderItemsScreenQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewWorkOrderItemsScreen(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewWorkOrderItemsScreen()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewWorkOrderItemsScreenQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewWorkOrderItemsScreenQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewWorkOrderItemsScreenQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewWorkOrderItemsScreen 
			Return CType(MyBase.AddNewEntity(), ViewWorkOrderItemsScreen)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewWorkOrderItemsScreen) Implements IEnumerable(Of ViewWorkOrderItemsScreen).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewWorkOrderItemsScreen)(Me)
        End Function
		
		Private _query As ViewWorkOrderItemsScreenQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewWorkOrderItemsScreen' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewWorkOrderItemsScreen ()")> _
	<Serializable> _
	Partial Public Class ViewWorkOrderItemsScreen 
		Inherits esViewWorkOrderItemsScreen

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewWorkOrderItemsScreenMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewWorkOrderItemsScreenQuery

			If Me._query Is Nothing Then
				Me._query = New ViewWorkOrderItemsScreenQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewWorkOrderItemsScreenQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewWorkOrderItemsScreenQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewWorkOrderItemsScreenQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewWorkOrderItemsScreenQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewWorkOrderItemsScreenQuery
		inherits esViewWorkOrderItemsScreenQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewWorkOrderItemsScreenQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewWorkOrderItemsScreenMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Workorderitemnumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Workorderitemnumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Workordernumber, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Workordernumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Itemtype, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Itemtype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Itemid, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Itemid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Itemdescription, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Itemdescription
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Productid, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Productdesc, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Container, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Qty, 8, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Qty
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Invitemnumber, 9, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Invitemnumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Itemcomments, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Itemcomments
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Lotnumber, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Lotnumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Warehouselocation, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Warehouselocation
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Billable, 13, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Billable
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Unitcost, 14, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Unitcost
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Itemprice, 15, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Itemprice
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Itemprofit, 16, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Itemprofit
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Unitorcontainer, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Unitorcontainer
			c.CharacterMaxLength = 1
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Units, 18, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Units
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Uom, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Uom
			c.CharacterMaxLength = 8
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Sourcetype, 20, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Sourcetype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Sourcedocument, 21, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Sourcedocument
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Sourcestatus, 22, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Sourcestatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Workorderitemstatus, 23, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Workorderitemstatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Customerpo, 24, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Customerpo
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Shipmentitemnumber, 25, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Shipmentitemnumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Invoiceitemnumber, 26, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Invoiceitemnumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Totalvolume, 27, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Totalvolume
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Volumeuom, 28, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Volumeuom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Totalweight, 29, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Totalweight
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Weightuom, 30, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Weightuom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.DOTIDNumber, 31, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.DOTIDNumber
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Hazmatid, 32, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Hazmatid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Hazmatclass, 33, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Hazmatclass
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Hazmatpackagegroup, 34, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Hazmatpackagegroup
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Classrate, 35, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Classrate
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Dotdesc, 36, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Dotdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Hazmatdesc, 37, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Hazmatdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Unline, 38, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Unline
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Ishazardous, 39, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Ishazardous
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Itemnotes, 40, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Itemnotes
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Createdtime, 41, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Createdtime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Createdby, 42, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Createdby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Modifiedtime, 43, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Modifiedtime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Modifiedby, 44, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Modifiedby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Ld1, 45, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Ld1
			c.CharacterMaxLength = 500
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Ld2, 46, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Ld2
			c.CharacterMaxLength = 500
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Ld3, 47, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Ld3
			c.CharacterMaxLength = 500
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Custitemid, 48, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Custitemid
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Itemstatus, 49, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Itemstatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Standardunitcost, 50, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Standardunitcost
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Unitprice, 51, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Unitprice
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Priceunits, 52, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Priceunits
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Priceuom, 53, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Priceuom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Standardcostunits, 54, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Standardcostunits
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Standardcostuom, 55, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Standardcostuom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Actualcostunits, 56, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Actualcostunits
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Actualcostuom, 57, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Actualcostuom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Extprice, 58, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Extprice
			c.NumericPrecision = 38
			c.NumericScale = 6
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Extcost, 59, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Extcost
			c.NumericPrecision = 38
			c.NumericScale = 6
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Actualunitcost, 60, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Actualunitcost
			c.NumericPrecision = 18
			c.NumericScale = 4
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Extprofit, 61, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Extprofit
			c.NumericPrecision = 38
			c.NumericScale = 6
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Available, 62, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Available
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Expectedindate, 63, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Expectedindate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Dateneeded, 64, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Dateneeded
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Estimatedcompletiondate, 65, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Estimatedcompletiondate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsScreenMetadata.ColumnNames.Neededby, 66, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewWorkOrderItemsScreenMetadata.PropertyNames.Neededby
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewWorkOrderItemsScreenMetadata
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
			 Public Const Invitemnumber As String = "INVITEMNUMBER"
			 Public Const Itemcomments As String = "ITEMCOMMENTS"
			 Public Const Lotnumber As String = "LOTNUMBER"
			 Public Const Warehouselocation As String = "WAREHOUSELOCATION"
			 Public Const Billable As String = "BILLABLE"
			 Public Const Unitcost As String = "UNITCOST"
			 Public Const Itemprice As String = "ITEMPRICE"
			 Public Const Itemprofit As String = "ITEMPROFIT"
			 Public Const Unitorcontainer As String = "UNITORCONTAINER"
			 Public Const Units As String = "UNITS"
			 Public Const Uom As String = "UOM"
			 Public Const Sourcetype As String = "SOURCETYPE"
			 Public Const Sourcedocument As String = "SOURCEDOCUMENT"
			 Public Const Sourcestatus As String = "SOURCESTATUS"
			 Public Const Workorderitemstatus As String = "WORKORDERITEMSTATUS"
			 Public Const Customerpo As String = "CUSTOMERPO"
			 Public Const Shipmentitemnumber As String = "SHIPMENTITEMNUMBER"
			 Public Const Invoiceitemnumber As String = "INVOICEITEMNUMBER"
			 Public Const Totalvolume As String = "TOTALVOLUME"
			 Public Const Volumeuom As String = "VOLUMEUOM"
			 Public Const Totalweight As String = "TOTALWEIGHT"
			 Public Const Weightuom As String = "WEIGHTUOM"
			 Public Const DOTIDNumber As String = "DOTIDNumber"
			 Public Const Hazmatid As String = "HAZMATID"
			 Public Const Hazmatclass As String = "HAZMATCLASS"
			 Public Const Hazmatpackagegroup As String = "HAZMATPACKAGEGROUP"
			 Public Const Classrate As String = "CLASSRATE"
			 Public Const Dotdesc As String = "DOTDESC"
			 Public Const Hazmatdesc As String = "HAZMATDESC"
			 Public Const Unline As String = "UNLINE"
			 Public Const Ishazardous As String = "ISHAZARDOUS"
			 Public Const Itemnotes As String = "ITEMNOTES"
			 Public Const Createdtime As String = "CREATEDTIME"
			 Public Const Createdby As String = "CREATEDBY"
			 Public Const Modifiedtime As String = "MODIFIEDTIME"
			 Public Const Modifiedby As String = "MODIFIEDBY"
			 Public Const Ld1 As String = "LD1"
			 Public Const Ld2 As String = "LD2"
			 Public Const Ld3 As String = "LD3"
			 Public Const Custitemid As String = "CUSTITEMID"
			 Public Const Itemstatus As String = "ITEMSTATUS"
			 Public Const Standardunitcost As String = "STANDARDUNITCOST"
			 Public Const Unitprice As String = "UNITPRICE"
			 Public Const Priceunits As String = "PRICEUNITS"
			 Public Const Priceuom As String = "PRICEUOM"
			 Public Const Standardcostunits As String = "STANDARDCOSTUNITS"
			 Public Const Standardcostuom As String = "STANDARDCOSTUOM"
			 Public Const Actualcostunits As String = "ACTUALCOSTUNITS"
			 Public Const Actualcostuom As String = "ACTUALCOSTUOM"
			 Public Const Extprice As String = "EXTPRICE"
			 Public Const Extcost As String = "EXTCOST"
			 Public Const Actualunitcost As String = "ACTUALUNITCOST"
			 Public Const Extprofit As String = "EXTPROFIT"
			 Public Const Available As String = "AVAILABLE"
			 Public Const Expectedindate As String = "EXPECTEDINDATE"
			 Public Const Dateneeded As String = "DATENEEDED"
			 Public Const Estimatedcompletiondate As String = "ESTIMATEDCOMPLETIONDATE"
			 Public Const Neededby As String = "NEEDEDBY"
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
			 Public Const Invitemnumber As String = "Invitemnumber"
			 Public Const Itemcomments As String = "Itemcomments"
			 Public Const Lotnumber As String = "Lotnumber"
			 Public Const Warehouselocation As String = "Warehouselocation"
			 Public Const Billable As String = "Billable"
			 Public Const Unitcost As String = "Unitcost"
			 Public Const Itemprice As String = "Itemprice"
			 Public Const Itemprofit As String = "Itemprofit"
			 Public Const Unitorcontainer As String = "Unitorcontainer"
			 Public Const Units As String = "Units"
			 Public Const Uom As String = "Uom"
			 Public Const Sourcetype As String = "Sourcetype"
			 Public Const Sourcedocument As String = "Sourcedocument"
			 Public Const Sourcestatus As String = "Sourcestatus"
			 Public Const Workorderitemstatus As String = "Workorderitemstatus"
			 Public Const Customerpo As String = "Customerpo"
			 Public Const Shipmentitemnumber As String = "Shipmentitemnumber"
			 Public Const Invoiceitemnumber As String = "Invoiceitemnumber"
			 Public Const Totalvolume As String = "Totalvolume"
			 Public Const Volumeuom As String = "Volumeuom"
			 Public Const Totalweight As String = "Totalweight"
			 Public Const Weightuom As String = "Weightuom"
			 Public Const DOTIDNumber As String = "DOTIDNumber"
			 Public Const Hazmatid As String = "Hazmatid"
			 Public Const Hazmatclass As String = "Hazmatclass"
			 Public Const Hazmatpackagegroup As String = "Hazmatpackagegroup"
			 Public Const Classrate As String = "Classrate"
			 Public Const Dotdesc As String = "Dotdesc"
			 Public Const Hazmatdesc As String = "Hazmatdesc"
			 Public Const Unline As String = "Unline"
			 Public Const Ishazardous As String = "Ishazardous"
			 Public Const Itemnotes As String = "Itemnotes"
			 Public Const Createdtime As String = "Createdtime"
			 Public Const Createdby As String = "Createdby"
			 Public Const Modifiedtime As String = "Modifiedtime"
			 Public Const Modifiedby As String = "Modifiedby"
			 Public Const Ld1 As String = "Ld1"
			 Public Const Ld2 As String = "Ld2"
			 Public Const Ld3 As String = "Ld3"
			 Public Const Custitemid As String = "Custitemid"
			 Public Const Itemstatus As String = "Itemstatus"
			 Public Const Standardunitcost As String = "Standardunitcost"
			 Public Const Unitprice As String = "Unitprice"
			 Public Const Priceunits As String = "Priceunits"
			 Public Const Priceuom As String = "Priceuom"
			 Public Const Standardcostunits As String = "Standardcostunits"
			 Public Const Standardcostuom As String = "Standardcostuom"
			 Public Const Actualcostunits As String = "Actualcostunits"
			 Public Const Actualcostuom As String = "Actualcostuom"
			 Public Const Extprice As String = "Extprice"
			 Public Const Extcost As String = "Extcost"
			 Public Const Actualunitcost As String = "Actualunitcost"
			 Public Const Extprofit As String = "Extprofit"
			 Public Const Available As String = "Available"
			 Public Const Expectedindate As String = "Expectedindate"
			 Public Const Dateneeded As String = "Dateneeded"
			 Public Const Estimatedcompletiondate As String = "Estimatedcompletiondate"
			 Public Const Neededby As String = "Neededby"
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
            SyncLock GetType(ViewWorkOrderItemsScreenMetadata)
			
				If ViewWorkOrderItemsScreenMetadata.mapDelegates Is Nothing Then
					ViewWorkOrderItemsScreenMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewWorkOrderItemsScreenMetadata._meta Is Nothing Then
                    ViewWorkOrderItemsScreenMetadata._meta = New ViewWorkOrderItemsScreenMetadata()
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
				meta.AddTypeMap("Invitemnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Itemcomments", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Lotnumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Warehouselocation", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Billable", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Unitcost", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Itemprice", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Itemprofit", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Unitorcontainer", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Units", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Uom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Sourcetype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Sourcedocument", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Sourcestatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Workorderitemstatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Customerpo", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipmentitemnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Invoiceitemnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Totalvolume", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Volumeuom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Totalweight", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Weightuom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("DOTIDNumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Hazmatid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Hazmatclass", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Hazmatpackagegroup", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Classrate", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Dotdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Hazmatdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Unline", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Ishazardous", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Itemnotes", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Createdtime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Createdby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Modifiedtime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Modifiedby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Ld1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Ld2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Ld3", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Custitemid", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Itemstatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Standardunitcost", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Unitprice", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Priceunits", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Priceuom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Standardcostunits", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Standardcostuom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Actualcostunits", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Actualcostuom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Extprice", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Extcost", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Actualunitcost", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Extprofit", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Available", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Expectedindate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Dateneeded", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Estimatedcompletiondate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Neededby", new esTypeMap("datetime", "System.DateTime"))			
				
				
				 
				meta.Source = "viewWorkOrderItemsScreen"
				meta.Destination = "viewWorkOrderItemsScreen"
				
				meta.spInsert = "proc_viewWorkOrderItemsScreenInsert"
				meta.spUpdate = "proc_viewWorkOrderItemsScreenUpdate"
				meta.spDelete = "proc_viewWorkOrderItemsScreenDelete"
				meta.spLoadAll = "proc_viewWorkOrderItemsScreenLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewWorkOrderItemsScreenLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewWorkOrderItemsScreenMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
