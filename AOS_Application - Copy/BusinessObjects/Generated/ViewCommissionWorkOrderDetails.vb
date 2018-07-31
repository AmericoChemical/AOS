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
	MustInherit Public Class esViewCommissionWorkOrderDetailsCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewCommissionWorkOrderDetailsCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewCommissionWorkOrderDetailsQuery)
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
            Me.InitQuery(CType(query, esViewCommissionWorkOrderDetailsQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewCommissionWorkOrderDetails) As ViewCommissionWorkOrderDetails
			Return CType(MyBase.DetachEntity(entity), ViewCommissionWorkOrderDetails)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewCommissionWorkOrderDetails) As ViewCommissionWorkOrderDetails
			Return CType(MyBase.AttachEntity(entity), ViewCommissionWorkOrderDetails)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewCommissionWorkOrderDetailsCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewCommissionWorkOrderDetails
            Get
                Return TryCast(MyBase.Item(index), ViewCommissionWorkOrderDetails)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewCommissionWorkOrderDetails)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewCommissionWorkOrderDetails	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewCommissionWorkOrderDetailsQuery
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
												
						Case "Unitcost"
							Me.str.Unitcost = CType(value, string)
												
						Case "Unitorcontainer"
							Me.str.Unitorcontainer = CType(value, string)
												
						Case "Units"
							Me.str.Units = CType(value, string)
												
						Case "Uom"
							Me.str.Uom = CType(value, string)
												
						Case "Invoiceitemnumber"
							Me.str.Invoiceitemnumber = CType(value, string)
												
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
												
						Case "WExtprice"
							Me.str.WExtprice = CType(value, string)
												
						Case "WExtcost"
							Me.str.WExtcost = CType(value, string)
												
						Case "WGrossprofit"
							Me.str.WGrossprofit = CType(value, string)
												
						Case "WCommissionamt"
							Me.str.WCommissionamt = CType(value, string)
												
						Case "Invoicenumber"
							Me.str.Invoicenumber = CType(value, string)
												
						Case "Invqty"
							Me.str.Invqty = CType(value, string)
												
						Case "Invprice"
							Me.str.Invprice = CType(value, string)
												
						Case "Invunits"
							Me.str.Invunits = CType(value, string)
												
						Case "Invextprice"
							Me.str.Invextprice = CType(value, string)
												
						Case "Extcost"
							Me.str.Extcost = CType(value, string)
												
						Case "Grossprofit"
							Me.str.Grossprofit = CType(value, string)
												
						Case "SalespersonID"
							Me.str.SalespersonID = CType(value, string)
												
						Case "Salespersonfullname"
							Me.str.Salespersonfullname = CType(value, string)
												
						Case "CommissionRate"
							Me.str.CommissionRate = CType(value, string)
												
						Case "ExcRate"
							Me.str.ExcRate = CType(value, string)
												
						Case "CommRate"
							Me.str.CommRate = CType(value, string)
												
						Case "CommissionType"
							Me.str.CommissionType = CType(value, string)
												
						Case "CommissionAmt"
							Me.str.CommissionAmt = CType(value, string)
												
						Case "Priceunits"
							Me.str.Priceunits = CType(value, string)
					
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
						
						Case "Unitcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Unitcost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Units"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Units = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Invoiceitemnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Invoiceitemnumber = CType(value, Nullable(Of System.Int32))
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
						
						Case "WExtprice"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.WExtprice = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "WExtcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.WExtcost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "WGrossprofit"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.WGrossprofit = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "WCommissionamt"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.WCommissionamt = CType(value, Nullable(Of System.Double))
							End If
						
						Case "Invoicenumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Invoicenumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Invqty"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Invqty = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Invprice"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Invprice = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Invunits"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Invunits = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Invextprice"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Invextprice = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Extcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Extcost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Grossprofit"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Grossprofit = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "SalespersonID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SalespersonID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "CommissionRate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.CommissionRate = CType(value, Nullable(Of System.Double))
							End If
						
						Case "ExcRate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.ExcRate = CType(value, Nullable(Of System.Double))
							End If
						
						Case "CommRate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.CommRate = CType(value, Nullable(Of System.Double))
							End If
						
						Case "CommissionAmt"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.CommissionAmt = CType(value, Nullable(Of System.Double))
							End If
						
						Case "Priceunits"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Priceunits = CType(value, Nullable(Of System.Decimal))
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
		' Maps to viewCommissionWorkOrderDetails.WORKORDERITEMNUMBER
		' </summary>
		Public Overridable Property Workorderitemnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Workorderitemnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Workorderitemnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionWorkOrderDetails.WORKORDERNUMBER
		' </summary>
		Public Overridable Property Workordernumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Workordernumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Workordernumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionWorkOrderDetails.ITEMTYPE
		' </summary>
		Public Overridable Property Itemtype As System.String
			Get
				Return MyBase.GetSystemString(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Itemtype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Itemtype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionWorkOrderDetails.ITEMID
		' </summary>
		Public Overridable Property Itemid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Itemid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Itemid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionWorkOrderDetails.ITEMDESCRIPTION
		' </summary>
		Public Overridable Property Itemdescription As System.String
			Get
				Return MyBase.GetSystemString(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Itemdescription)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Itemdescription, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionWorkOrderDetails.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionWorkOrderDetails.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionWorkOrderDetails.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionWorkOrderDetails.QTY
		' </summary>
		Public Overridable Property Qty As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Qty)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Qty, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionWorkOrderDetails.UNITCOST
		' </summary>
		Public Overridable Property Unitcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Unitcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Unitcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionWorkOrderDetails.UNITORCONTAINER
		' </summary>
		Public Overridable Property Unitorcontainer As System.String
			Get
				Return MyBase.GetSystemString(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Unitorcontainer)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Unitorcontainer, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionWorkOrderDetails.UNITS
		' </summary>
		Public Overridable Property Units As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Units)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Units, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionWorkOrderDetails.UOM
		' </summary>
		Public Overridable Property Uom As System.String
			Get
				Return MyBase.GetSystemString(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Uom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Uom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionWorkOrderDetails.INVOICEITEMNUMBER
		' </summary>
		Public Overridable Property Invoiceitemnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Invoiceitemnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Invoiceitemnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionWorkOrderDetails.PRICEUOM
		' </summary>
		Public Overridable Property Priceuom As System.String
			Get
				Return MyBase.GetSystemString(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Priceuom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Priceuom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionWorkOrderDetails.UNITPRICE
		' </summary>
		Public Overridable Property Unitprice As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Unitprice)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Unitprice, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionWorkOrderDetails.STANDARDCOSTUNITS
		' </summary>
		Public Overridable Property Standardcostunits As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Standardcostunits)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Standardcostunits, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionWorkOrderDetails.STANDARDCOSTUOM
		' </summary>
		Public Overridable Property Standardcostuom As System.String
			Get
				Return MyBase.GetSystemString(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Standardcostuom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Standardcostuom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionWorkOrderDetails.STANDARDUNITCOST
		' </summary>
		Public Overridable Property Standardunitcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Standardunitcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Standardunitcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionWorkOrderDetails.W_EXTPRICE
		' </summary>
		Public Overridable Property WExtprice As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.WExtprice)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.WExtprice, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionWorkOrderDetails.W_EXTCOST
		' </summary>
		Public Overridable Property WExtcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.WExtcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.WExtcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionWorkOrderDetails.W_GROSSPROFIT
		' </summary>
		Public Overridable Property WGrossprofit As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.WGrossprofit)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.WGrossprofit, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionWorkOrderDetails.W_COMMISSIONAMT
		' </summary>
		Public Overridable Property WCommissionamt As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.WCommissionamt)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.WCommissionamt, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionWorkOrderDetails.INVOICENUMBER
		' </summary>
		Public Overridable Property Invoicenumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Invoicenumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Invoicenumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionWorkOrderDetails.INVQTY
		' </summary>
		Public Overridable Property Invqty As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Invqty)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Invqty, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionWorkOrderDetails.INVPRICE
		' </summary>
		Public Overridable Property Invprice As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Invprice)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Invprice, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionWorkOrderDetails.INVUNITS
		' </summary>
		Public Overridable Property Invunits As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Invunits)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Invunits, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionWorkOrderDetails.INVEXTPRICE
		' </summary>
		Public Overridable Property Invextprice As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Invextprice)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Invextprice, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionWorkOrderDetails.EXTCOST
		' </summary>
		Public Overridable Property Extcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Extcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Extcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionWorkOrderDetails.GROSSPROFIT
		' </summary>
		Public Overridable Property Grossprofit As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Grossprofit)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Grossprofit, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionWorkOrderDetails.SalespersonID
		' </summary>
		Public Overridable Property SalespersonID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.SalespersonID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.SalespersonID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionWorkOrderDetails.SALESPERSONFULLNAME
		' </summary>
		Public Overridable Property Salespersonfullname As System.String
			Get
				Return MyBase.GetSystemString(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Salespersonfullname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Salespersonfullname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionWorkOrderDetails.CommissionRate
		' </summary>
		Public Overridable Property CommissionRate As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.CommissionRate)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.CommissionRate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionWorkOrderDetails.ExcRate
		' </summary>
		Public Overridable Property ExcRate As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.ExcRate)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.ExcRate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionWorkOrderDetails.CommRate
		' </summary>
		Public Overridable Property CommRate As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.CommRate)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.CommRate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionWorkOrderDetails.CommissionType
		' </summary>
		Public Overridable Property CommissionType As System.String
			Get
				Return MyBase.GetSystemString(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.CommissionType)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.CommissionType, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionWorkOrderDetails.CommissionAmt
		' </summary>
		Public Overridable Property CommissionAmt As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.CommissionAmt)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.CommissionAmt, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionWorkOrderDetails.PRICEUNITS
		' </summary>
		Public Overridable Property Priceunits As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Priceunits)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Priceunits, value)
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
		
			Public Sub New(ByVal entity As esViewCommissionWorkOrderDetails)
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
		  	
			Public Property WExtprice As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.WExtprice
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.WExtprice = Nothing
					Else
						entity.WExtprice = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property WExtcost As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.WExtcost
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.WExtcost = Nothing
					Else
						entity.WExtcost = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property WGrossprofit As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.WGrossprofit
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.WGrossprofit = Nothing
					Else
						entity.WGrossprofit = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property WCommissionamt As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.WCommissionamt
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.WCommissionamt = Nothing
					Else
						entity.WCommissionamt = Convert.ToDouble(Value)
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
		  	
			Public Property Invqty As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Invqty
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Invqty = Nothing
					Else
						entity.Invqty = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Invprice As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Invprice
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Invprice = Nothing
					Else
						entity.Invprice = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Invunits As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Invunits
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Invunits = Nothing
					Else
						entity.Invunits = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Invextprice As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Invextprice
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Invextprice = Nothing
					Else
						entity.Invextprice = Convert.ToDecimal(Value)
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
		  	
			Public Property SalespersonID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.SalespersonID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SalespersonID = Nothing
					Else
						entity.SalespersonID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Salespersonfullname As System.String 
				Get
					Dim data_ As System.String = entity.Salespersonfullname
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Salespersonfullname = Nothing
					Else
						entity.Salespersonfullname = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CommissionRate As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.CommissionRate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CommissionRate = Nothing
					Else
						entity.CommissionRate = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property ExcRate As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.ExcRate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ExcRate = Nothing
					Else
						entity.ExcRate = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property CommRate As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.CommRate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CommRate = Nothing
					Else
						entity.CommRate = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property CommissionType As System.String 
				Get
					Dim data_ As System.String = entity.CommissionType
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CommissionType = Nothing
					Else
						entity.CommissionType = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CommissionAmt As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.CommissionAmt
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CommissionAmt = Nothing
					Else
						entity.CommissionAmt = Convert.ToDouble(Value)
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
		  

			Private entity As esViewCommissionWorkOrderDetails
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewCommissionWorkOrderDetailsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewCommissionWorkOrderDetails can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewCommissionWorkOrderDetailsQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCommissionWorkOrderDetailsMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Workorderitemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Workorderitemnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Workordernumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Workordernumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Itemtype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Itemtype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Itemid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Itemid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Itemdescription As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Itemdescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Qty As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Qty, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Unitcost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Unitcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Unitorcontainer As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Unitorcontainer, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Units As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Units, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Uom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Uom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Invoiceitemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Invoiceitemnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Priceuom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Priceuom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Unitprice As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Unitprice, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Standardcostunits As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Standardcostunits, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Standardcostuom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Standardcostuom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Standardunitcost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Standardunitcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property WExtprice As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionWorkOrderDetailsMetadata.ColumnNames.WExtprice, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property WExtcost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionWorkOrderDetailsMetadata.ColumnNames.WExtcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property WGrossprofit As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionWorkOrderDetailsMetadata.ColumnNames.WGrossprofit, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property WCommissionamt As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionWorkOrderDetailsMetadata.ColumnNames.WCommissionamt, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Invoicenumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Invoicenumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Invqty As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Invqty, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Invprice As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Invprice, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Invunits As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Invunits, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Invextprice As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Invextprice, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Extcost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Extcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Grossprofit As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Grossprofit, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property SalespersonID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionWorkOrderDetailsMetadata.ColumnNames.SalespersonID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Salespersonfullname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Salespersonfullname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CommissionRate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionWorkOrderDetailsMetadata.ColumnNames.CommissionRate, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property ExcRate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionWorkOrderDetailsMetadata.ColumnNames.ExcRate, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property CommRate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionWorkOrderDetailsMetadata.ColumnNames.CommRate, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property CommissionType As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionWorkOrderDetailsMetadata.ColumnNames.CommissionType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CommissionAmt As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionWorkOrderDetailsMetadata.ColumnNames.CommissionAmt, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Priceunits As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Priceunits, esSystemType.Decimal)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewCommissionWorkOrderDetailsCollection")> _
	Partial Public Class ViewCommissionWorkOrderDetailsCollection
		Inherits esViewCommissionWorkOrderDetailsCollection
		Implements IEnumerable(Of ViewCommissionWorkOrderDetails)
		
        Public Shared Widening Operator CType(ByVal coll As ViewCommissionWorkOrderDetailsCollection) As List(Of ViewCommissionWorkOrderDetails)
            Dim list As List(Of ViewCommissionWorkOrderDetails) = New List(Of ViewCommissionWorkOrderDetails)
            Dim emp As ViewCommissionWorkOrderDetails

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCommissionWorkOrderDetailsMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewCommissionWorkOrderDetailsQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewCommissionWorkOrderDetails(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewCommissionWorkOrderDetails()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewCommissionWorkOrderDetailsQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewCommissionWorkOrderDetailsQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewCommissionWorkOrderDetailsQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewCommissionWorkOrderDetails 
			Return CType(MyBase.AddNewEntity(), ViewCommissionWorkOrderDetails)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewCommissionWorkOrderDetails) Implements IEnumerable(Of ViewCommissionWorkOrderDetails).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewCommissionWorkOrderDetails)(Me)
        End Function
		
		Private _query As ViewCommissionWorkOrderDetailsQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewCommissionWorkOrderDetails' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewCommissionWorkOrderDetails ()")> _
	<Serializable> _
	Partial Public Class ViewCommissionWorkOrderDetails 
		Inherits esViewCommissionWorkOrderDetails

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewCommissionWorkOrderDetailsMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewCommissionWorkOrderDetailsQuery

			If Me._query Is Nothing Then
				Me._query = New ViewCommissionWorkOrderDetailsQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewCommissionWorkOrderDetailsQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewCommissionWorkOrderDetailsQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewCommissionWorkOrderDetailsQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewCommissionWorkOrderDetailsQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewCommissionWorkOrderDetailsQuery
		inherits esViewCommissionWorkOrderDetailsQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewCommissionWorkOrderDetailsQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewCommissionWorkOrderDetailsMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Workorderitemnumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCommissionWorkOrderDetailsMetadata.PropertyNames.Workorderitemnumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Workordernumber, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCommissionWorkOrderDetailsMetadata.PropertyNames.Workordernumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Itemtype, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCommissionWorkOrderDetailsMetadata.PropertyNames.Itemtype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Itemid, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCommissionWorkOrderDetailsMetadata.PropertyNames.Itemid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Itemdescription, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCommissionWorkOrderDetailsMetadata.PropertyNames.Itemdescription
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Productid, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCommissionWorkOrderDetailsMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Productdesc, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCommissionWorkOrderDetailsMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Container, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCommissionWorkOrderDetailsMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Qty, 8, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCommissionWorkOrderDetailsMetadata.PropertyNames.Qty
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Unitcost, 9, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCommissionWorkOrderDetailsMetadata.PropertyNames.Unitcost
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Unitorcontainer, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCommissionWorkOrderDetailsMetadata.PropertyNames.Unitorcontainer
			c.CharacterMaxLength = 1
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Units, 11, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCommissionWorkOrderDetailsMetadata.PropertyNames.Units
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Uom, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCommissionWorkOrderDetailsMetadata.PropertyNames.Uom
			c.CharacterMaxLength = 8
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Invoiceitemnumber, 13, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCommissionWorkOrderDetailsMetadata.PropertyNames.Invoiceitemnumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Priceuom, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCommissionWorkOrderDetailsMetadata.PropertyNames.Priceuom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Unitprice, 15, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCommissionWorkOrderDetailsMetadata.PropertyNames.Unitprice
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Standardcostunits, 16, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCommissionWorkOrderDetailsMetadata.PropertyNames.Standardcostunits
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Standardcostuom, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCommissionWorkOrderDetailsMetadata.PropertyNames.Standardcostuom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Standardunitcost, 18, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCommissionWorkOrderDetailsMetadata.PropertyNames.Standardunitcost
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.WExtprice, 19, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCommissionWorkOrderDetailsMetadata.PropertyNames.WExtprice
			c.NumericPrecision = 38
			c.NumericScale = 6
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.WExtcost, 20, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCommissionWorkOrderDetailsMetadata.PropertyNames.WExtcost
			c.NumericPrecision = 38
			c.NumericScale = 6
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.WGrossprofit, 21, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCommissionWorkOrderDetailsMetadata.PropertyNames.WGrossprofit
			c.NumericPrecision = 38
			c.NumericScale = 6
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.WCommissionamt, 22, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCommissionWorkOrderDetailsMetadata.PropertyNames.WCommissionamt
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Invoicenumber, 23, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCommissionWorkOrderDetailsMetadata.PropertyNames.Invoicenumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Invqty, 24, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCommissionWorkOrderDetailsMetadata.PropertyNames.Invqty
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Invprice, 25, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCommissionWorkOrderDetailsMetadata.PropertyNames.Invprice
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Invunits, 26, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCommissionWorkOrderDetailsMetadata.PropertyNames.Invunits
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Invextprice, 27, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCommissionWorkOrderDetailsMetadata.PropertyNames.Invextprice
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Extcost, 28, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCommissionWorkOrderDetailsMetadata.PropertyNames.Extcost
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Grossprofit, 29, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCommissionWorkOrderDetailsMetadata.PropertyNames.Grossprofit
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.SalespersonID, 30, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCommissionWorkOrderDetailsMetadata.PropertyNames.SalespersonID
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Salespersonfullname, 31, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCommissionWorkOrderDetailsMetadata.PropertyNames.Salespersonfullname
			c.CharacterMaxLength = 101
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.CommissionRate, 32, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCommissionWorkOrderDetailsMetadata.PropertyNames.CommissionRate
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.ExcRate, 33, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCommissionWorkOrderDetailsMetadata.PropertyNames.ExcRate
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.CommRate, 34, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCommissionWorkOrderDetailsMetadata.PropertyNames.CommRate
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.CommissionType, 35, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCommissionWorkOrderDetailsMetadata.PropertyNames.CommissionType
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.CommissionAmt, 36, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCommissionWorkOrderDetailsMetadata.PropertyNames.CommissionAmt
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionWorkOrderDetailsMetadata.ColumnNames.Priceunits, 37, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCommissionWorkOrderDetailsMetadata.PropertyNames.Priceunits
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewCommissionWorkOrderDetailsMetadata
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
			 Public Const Unitcost As String = "UNITCOST"
			 Public Const Unitorcontainer As String = "UNITORCONTAINER"
			 Public Const Units As String = "UNITS"
			 Public Const Uom As String = "UOM"
			 Public Const Invoiceitemnumber As String = "INVOICEITEMNUMBER"
			 Public Const Priceuom As String = "PRICEUOM"
			 Public Const Unitprice As String = "UNITPRICE"
			 Public Const Standardcostunits As String = "STANDARDCOSTUNITS"
			 Public Const Standardcostuom As String = "STANDARDCOSTUOM"
			 Public Const Standardunitcost As String = "STANDARDUNITCOST"
			 Public Const WExtprice As String = "W_EXTPRICE"
			 Public Const WExtcost As String = "W_EXTCOST"
			 Public Const WGrossprofit As String = "W_GROSSPROFIT"
			 Public Const WCommissionamt As String = "W_COMMISSIONAMT"
			 Public Const Invoicenumber As String = "INVOICENUMBER"
			 Public Const Invqty As String = "INVQTY"
			 Public Const Invprice As String = "INVPRICE"
			 Public Const Invunits As String = "INVUNITS"
			 Public Const Invextprice As String = "INVEXTPRICE"
			 Public Const Extcost As String = "EXTCOST"
			 Public Const Grossprofit As String = "GROSSPROFIT"
			 Public Const SalespersonID As String = "SalespersonID"
			 Public Const Salespersonfullname As String = "SALESPERSONFULLNAME"
			 Public Const CommissionRate As String = "CommissionRate"
			 Public Const ExcRate As String = "ExcRate"
			 Public Const CommRate As String = "CommRate"
			 Public Const CommissionType As String = "CommissionType"
			 Public Const CommissionAmt As String = "CommissionAmt"
			 Public Const Priceunits As String = "PRICEUNITS"
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
			 Public Const Unitcost As String = "Unitcost"
			 Public Const Unitorcontainer As String = "Unitorcontainer"
			 Public Const Units As String = "Units"
			 Public Const Uom As String = "Uom"
			 Public Const Invoiceitemnumber As String = "Invoiceitemnumber"
			 Public Const Priceuom As String = "Priceuom"
			 Public Const Unitprice As String = "Unitprice"
			 Public Const Standardcostunits As String = "Standardcostunits"
			 Public Const Standardcostuom As String = "Standardcostuom"
			 Public Const Standardunitcost As String = "Standardunitcost"
			 Public Const WExtprice As String = "WExtprice"
			 Public Const WExtcost As String = "WExtcost"
			 Public Const WGrossprofit As String = "WGrossprofit"
			 Public Const WCommissionamt As String = "WCommissionamt"
			 Public Const Invoicenumber As String = "Invoicenumber"
			 Public Const Invqty As String = "Invqty"
			 Public Const Invprice As String = "Invprice"
			 Public Const Invunits As String = "Invunits"
			 Public Const Invextprice As String = "Invextprice"
			 Public Const Extcost As String = "Extcost"
			 Public Const Grossprofit As String = "Grossprofit"
			 Public Const SalespersonID As String = "SalespersonID"
			 Public Const Salespersonfullname As String = "Salespersonfullname"
			 Public Const CommissionRate As String = "CommissionRate"
			 Public Const ExcRate As String = "ExcRate"
			 Public Const CommRate As String = "CommRate"
			 Public Const CommissionType As String = "CommissionType"
			 Public Const CommissionAmt As String = "CommissionAmt"
			 Public Const Priceunits As String = "Priceunits"
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
            SyncLock GetType(ViewCommissionWorkOrderDetailsMetadata)
			
				If ViewCommissionWorkOrderDetailsMetadata.mapDelegates Is Nothing Then
					ViewCommissionWorkOrderDetailsMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewCommissionWorkOrderDetailsMetadata._meta Is Nothing Then
                    ViewCommissionWorkOrderDetailsMetadata._meta = New ViewCommissionWorkOrderDetailsMetadata()
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
				meta.AddTypeMap("Unitcost", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Unitorcontainer", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Units", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Uom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Invoiceitemnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Priceuom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Unitprice", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Standardcostunits", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Standardcostuom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Standardunitcost", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("WExtprice", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("WExtcost", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("WGrossprofit", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("WCommissionamt", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Invoicenumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Invqty", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Invprice", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Invunits", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Invextprice", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Extcost", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Grossprofit", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("SalespersonID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Salespersonfullname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CommissionRate", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("ExcRate", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("CommRate", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("CommissionType", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CommissionAmt", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Priceunits", new esTypeMap("decimal", "System.Decimal"))			
				
				
				 
				meta.Source = "viewCommissionWorkOrderDetails"
				meta.Destination = "viewCommissionWorkOrderDetails"
				
				meta.spInsert = "proc_viewCommissionWorkOrderDetailsInsert"
				meta.spUpdate = "proc_viewCommissionWorkOrderDetailsUpdate"
				meta.spDelete = "proc_viewCommissionWorkOrderDetailsDelete"
				meta.spLoadAll = "proc_viewCommissionWorkOrderDetailsLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCommissionWorkOrderDetailsLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewCommissionWorkOrderDetailsMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
