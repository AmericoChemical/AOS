'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/18/2016 2:29:26 PM
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
	MustInherit Public Class esViewRptDirectPurchaseOrders2Collection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewRptDirectPurchaseOrders2Collection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewRptDirectPurchaseOrders2Query)
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
            Me.InitQuery(CType(query, esViewRptDirectPurchaseOrders2Query))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewRptDirectPurchaseOrders2) As ViewRptDirectPurchaseOrders2
			Return CType(MyBase.DetachEntity(entity), ViewRptDirectPurchaseOrders2)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewRptDirectPurchaseOrders2) As ViewRptDirectPurchaseOrders2
			Return CType(MyBase.AttachEntity(entity), ViewRptDirectPurchaseOrders2)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewRptDirectPurchaseOrders2Collection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewRptDirectPurchaseOrders2
            Get
                Return TryCast(MyBase.Item(index), ViewRptDirectPurchaseOrders2)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewRptDirectPurchaseOrders2)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewRptDirectPurchaseOrders2	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewRptDirectPurchaseOrders2Query
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
												
						Case "Ponumber"
							Me.str.Ponumber = CType(value, string)
												
						Case "Vendorid"
							Me.str.Vendorid = CType(value, string)
												
						Case "Podate"
							Me.str.Podate = CType(value, string)
												
						Case "Potype"
							Me.str.Potype = CType(value, string)
												
						Case "Poterms"
							Me.str.Poterms = CType(value, string)
												
						Case "Postatus"
							Me.str.Postatus = CType(value, string)
												
						Case "Changeableponumber"
							Me.str.Changeableponumber = CType(value, string)
												
						Case "Shipname"
							Me.str.Shipname = CType(value, string)
												
						Case "Shipaddress1"
							Me.str.Shipaddress1 = CType(value, string)
												
						Case "Shipaddress2"
							Me.str.Shipaddress2 = CType(value, string)
												
						Case "Shipcity"
							Me.str.Shipcity = CType(value, string)
												
						Case "Shipstate"
							Me.str.Shipstate = CType(value, string)
												
						Case "Shipzip"
							Me.str.Shipzip = CType(value, string)
												
						Case "Shipcontact"
							Me.str.Shipcontact = CType(value, string)
												
						Case "Shipphone"
							Me.str.Shipphone = CType(value, string)
												
						Case "Posubtotal"
							Me.str.Posubtotal = CType(value, string)
												
						Case "Posalestax"
							Me.str.Posalestax = CType(value, string)
												
						Case "Pofreightin"
							Me.str.Pofreightin = CType(value, string)
												
						Case "Pototal"
							Me.str.Pototal = CType(value, string)
												
						Case "Instructions"
							Me.str.Instructions = CType(value, string)
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Productdesc"
							Me.str.Productdesc = CType(value, string)
												
						Case "Vendoritemnumber"
							Me.str.Vendoritemnumber = CType(value, string)
												
						Case "Qtyordered"
							Me.str.Qtyordered = CType(value, string)
												
						Case "Unitcost"
							Me.str.Unitcost = CType(value, string)
												
						Case "Extprice"
							Me.str.Extprice = CType(value, string)
												
						Case "Uom"
							Me.str.Uom = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "Unitorcontainer"
							Me.str.Unitorcontainer = CType(value, string)
												
						Case "Units"
							Me.str.Units = CType(value, string)
												
						Case "Vendorname"
							Me.str.Vendorname = CType(value, string)
												
						Case "Vendoraddress1"
							Me.str.Vendoraddress1 = CType(value, string)
												
						Case "Vendoraddress2"
							Me.str.Vendoraddress2 = CType(value, string)
												
						Case "Vendorcity"
							Me.str.Vendorcity = CType(value, string)
												
						Case "Vendorstate"
							Me.str.Vendorstate = CType(value, string)
												
						Case "Vendorzip"
							Me.str.Vendorzip = CType(value, string)
												
						Case "Vendorphone"
							Me.str.Vendorphone = CType(value, string)
												
						Case "Vendorfax"
							Me.str.Vendorfax = CType(value, string)
												
						Case "Vendorcontact"
							Me.str.Vendorcontact = CType(value, string)
												
						Case "Vendoremail"
							Me.str.Vendoremail = CType(value, string)
												
						Case "Vendorurl"
							Me.str.Vendorurl = CType(value, string)
												
						Case "Vendoracctnumber"
							Me.str.Vendoracctnumber = CType(value, string)
												
						Case "Terms"
							Me.str.Terms = CType(value, string)
												
						Case "CompanyName"
							Me.str.CompanyName = CType(value, string)
												
						Case "CompanyAddress"
							Me.str.CompanyAddress = CType(value, string)
												
						Case "Csz"
							Me.str.Csz = CType(value, string)
												
						Case "Expectedindate"
							Me.str.Expectedindate = CType(value, string)
												
						Case "COAText"
							Me.str.COAText = CType(value, string)
												
						Case "Shipcsz"
							Me.str.Shipcsz = CType(value, string)
												
						Case "Vendorcsz"
							Me.str.Vendorcsz = CType(value, string)
												
						Case "Itemcustomerpo"
							Me.str.Itemcustomerpo = CType(value, string)
												
						Case "Purchasingnotes"
							Me.str.Purchasingnotes = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Ponumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Ponumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Vendorid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Vendorid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Podate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Podate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Posubtotal"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Posubtotal = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Posalestax"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Posalestax = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Pofreightin"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Pofreightin = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Pototal"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Pototal = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Qtyordered"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Qtyordered = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Unitcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Unitcost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Extprice"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Extprice = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Units"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Units = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Expectedindate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Expectedindate = CType(value, Nullable(Of System.DateTime))
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
		' Maps to viewRptDirectPurchaseOrders2.PONUMBER
		' </summary>
		Public Overridable Property Ponumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Ponumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Ponumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptDirectPurchaseOrders2.VENDORID
		' </summary>
		Public Overridable Property Vendorid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendorid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendorid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptDirectPurchaseOrders2.PODATE
		' </summary>
		Public Overridable Property Podate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Podate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Podate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptDirectPurchaseOrders2.POTYPE
		' </summary>
		Public Overridable Property Potype As System.String
			Get
				Return MyBase.GetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Potype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Potype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptDirectPurchaseOrders2.POTERMS
		' </summary>
		Public Overridable Property Poterms As System.String
			Get
				Return MyBase.GetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Poterms)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Poterms, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptDirectPurchaseOrders2.POSTATUS
		' </summary>
		Public Overridable Property Postatus As System.String
			Get
				Return MyBase.GetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Postatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Postatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptDirectPurchaseOrders2.CHANGEABLEPONUMBER
		' </summary>
		Public Overridable Property Changeableponumber As System.String
			Get
				Return MyBase.GetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Changeableponumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Changeableponumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptDirectPurchaseOrders2.SHIPNAME
		' </summary>
		Public Overridable Property Shipname As System.String
			Get
				Return MyBase.GetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Shipname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Shipname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptDirectPurchaseOrders2.SHIPADDRESS1
		' </summary>
		Public Overridable Property Shipaddress1 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Shipaddress1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Shipaddress1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptDirectPurchaseOrders2.SHIPADDRESS2
		' </summary>
		Public Overridable Property Shipaddress2 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Shipaddress2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Shipaddress2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptDirectPurchaseOrders2.SHIPCITY
		' </summary>
		Public Overridable Property Shipcity As System.String
			Get
				Return MyBase.GetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Shipcity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Shipcity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptDirectPurchaseOrders2.SHIPSTATE
		' </summary>
		Public Overridable Property Shipstate As System.String
			Get
				Return MyBase.GetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Shipstate)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Shipstate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptDirectPurchaseOrders2.SHIPZIP
		' </summary>
		Public Overridable Property Shipzip As System.String
			Get
				Return MyBase.GetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Shipzip)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Shipzip, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptDirectPurchaseOrders2.SHIPCONTACT
		' </summary>
		Public Overridable Property Shipcontact As System.String
			Get
				Return MyBase.GetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Shipcontact)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Shipcontact, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptDirectPurchaseOrders2.SHIPPHONE
		' </summary>
		Public Overridable Property Shipphone As System.String
			Get
				Return MyBase.GetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Shipphone)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Shipphone, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptDirectPurchaseOrders2.POSUBTOTAL
		' </summary>
		Public Overridable Property Posubtotal As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Posubtotal)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Posubtotal, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptDirectPurchaseOrders2.POSALESTAX
		' </summary>
		Public Overridable Property Posalestax As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Posalestax)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Posalestax, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptDirectPurchaseOrders2.POFREIGHTIN
		' </summary>
		Public Overridable Property Pofreightin As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Pofreightin)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Pofreightin, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptDirectPurchaseOrders2.POTOTAL
		' </summary>
		Public Overridable Property Pototal As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Pototal)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Pototal, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptDirectPurchaseOrders2.INSTRUCTIONS
		' </summary>
		Public Overridable Property Instructions As System.String
			Get
				Return MyBase.GetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Instructions)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Instructions, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptDirectPurchaseOrders2.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptDirectPurchaseOrders2.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptDirectPurchaseOrders2.VENDORITEMNUMBER
		' </summary>
		Public Overridable Property Vendoritemnumber As System.String
			Get
				Return MyBase.GetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendoritemnumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendoritemnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptDirectPurchaseOrders2.QTYORDERED
		' </summary>
		Public Overridable Property Qtyordered As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Qtyordered)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Qtyordered, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptDirectPurchaseOrders2.UNITCOST
		' </summary>
		Public Overridable Property Unitcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Unitcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Unitcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptDirectPurchaseOrders2.EXTPRICE
		' </summary>
		Public Overridable Property Extprice As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Extprice)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Extprice, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptDirectPurchaseOrders2.UOM
		' </summary>
		Public Overridable Property Uom As System.String
			Get
				Return MyBase.GetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Uom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Uom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptDirectPurchaseOrders2.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptDirectPurchaseOrders2.UNITORCONTAINER
		' </summary>
		Public Overridable Property Unitorcontainer As System.String
			Get
				Return MyBase.GetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Unitorcontainer)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Unitorcontainer, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptDirectPurchaseOrders2.UNITS
		' </summary>
		Public Overridable Property Units As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Units)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Units, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptDirectPurchaseOrders2.VENDORNAME
		' </summary>
		Public Overridable Property Vendorname As System.String
			Get
				Return MyBase.GetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendorname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendorname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptDirectPurchaseOrders2.VENDORADDRESS1
		' </summary>
		Public Overridable Property Vendoraddress1 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendoraddress1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendoraddress1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptDirectPurchaseOrders2.VENDORADDRESS2
		' </summary>
		Public Overridable Property Vendoraddress2 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendoraddress2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendoraddress2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptDirectPurchaseOrders2.VENDORCITY
		' </summary>
		Public Overridable Property Vendorcity As System.String
			Get
				Return MyBase.GetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendorcity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendorcity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptDirectPurchaseOrders2.VENDORSTATE
		' </summary>
		Public Overridable Property Vendorstate As System.String
			Get
				Return MyBase.GetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendorstate)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendorstate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptDirectPurchaseOrders2.VENDORZIP
		' </summary>
		Public Overridable Property Vendorzip As System.String
			Get
				Return MyBase.GetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendorzip)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendorzip, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptDirectPurchaseOrders2.VENDORPHONE
		' </summary>
		Public Overridable Property Vendorphone As System.String
			Get
				Return MyBase.GetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendorphone)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendorphone, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptDirectPurchaseOrders2.VENDORFAX
		' </summary>
		Public Overridable Property Vendorfax As System.String
			Get
				Return MyBase.GetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendorfax)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendorfax, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptDirectPurchaseOrders2.VENDORCONTACT
		' </summary>
		Public Overridable Property Vendorcontact As System.String
			Get
				Return MyBase.GetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendorcontact)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendorcontact, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptDirectPurchaseOrders2.VENDOREMAIL
		' </summary>
		Public Overridable Property Vendoremail As System.String
			Get
				Return MyBase.GetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendoremail)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendoremail, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptDirectPurchaseOrders2.VENDORURL
		' </summary>
		Public Overridable Property Vendorurl As System.String
			Get
				Return MyBase.GetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendorurl)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendorurl, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptDirectPurchaseOrders2.VENDORACCTNUMBER
		' </summary>
		Public Overridable Property Vendoracctnumber As System.String
			Get
				Return MyBase.GetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendoracctnumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendoracctnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptDirectPurchaseOrders2.TERMS
		' </summary>
		Public Overridable Property Terms As System.String
			Get
				Return MyBase.GetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Terms)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Terms, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptDirectPurchaseOrders2.CompanyName
		' </summary>
		Public Overridable Property CompanyName As System.String
			Get
				Return MyBase.GetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.CompanyName)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.CompanyName, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptDirectPurchaseOrders2.CompanyAddress
		' </summary>
		Public Overridable Property CompanyAddress As System.String
			Get
				Return MyBase.GetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.CompanyAddress)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.CompanyAddress, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptDirectPurchaseOrders2.CSZ
		' </summary>
		Public Overridable Property Csz As System.String
			Get
				Return MyBase.GetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Csz)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Csz, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptDirectPurchaseOrders2.EXPECTEDINDATE
		' </summary>
		Public Overridable Property Expectedindate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Expectedindate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Expectedindate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptDirectPurchaseOrders2.COAText
		' </summary>
		Public Overridable Property COAText As System.String
			Get
				Return MyBase.GetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.COAText)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.COAText, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptDirectPurchaseOrders2.SHIPCSZ
		' </summary>
		Public Overridable Property Shipcsz As System.String
			Get
				Return MyBase.GetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Shipcsz)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Shipcsz, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptDirectPurchaseOrders2.VENDORCSZ
		' </summary>
		Public Overridable Property Vendorcsz As System.String
			Get
				Return MyBase.GetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendorcsz)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendorcsz, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptDirectPurchaseOrders2.ITEMCUSTOMERPO
		' </summary>
		Public Overridable Property Itemcustomerpo As System.String
			Get
				Return MyBase.GetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Itemcustomerpo)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Itemcustomerpo, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptDirectPurchaseOrders2.PURCHASINGNOTES
		' </summary>
		Public Overridable Property Purchasingnotes As System.String
			Get
				Return MyBase.GetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Purchasingnotes)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Purchasingnotes, value)
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
		
			Public Sub New(ByVal entity As esViewRptDirectPurchaseOrders2)
				Me.entity = entity
			End Sub				
		
	
			Public Property Ponumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Ponumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Ponumber = Nothing
					Else
						entity.Ponumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Vendorid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Vendorid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Vendorid = Nothing
					Else
						entity.Vendorid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Podate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Podate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Podate = Nothing
					Else
						entity.Podate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Potype As System.String 
				Get
					Dim data_ As System.String = entity.Potype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Potype = Nothing
					Else
						entity.Potype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Poterms As System.String 
				Get
					Dim data_ As System.String = entity.Poterms
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Poterms = Nothing
					Else
						entity.Poterms = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Postatus As System.String 
				Get
					Dim data_ As System.String = entity.Postatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Postatus = Nothing
					Else
						entity.Postatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Changeableponumber As System.String 
				Get
					Dim data_ As System.String = entity.Changeableponumber
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Changeableponumber = Nothing
					Else
						entity.Changeableponumber = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shipname As System.String 
				Get
					Dim data_ As System.String = entity.Shipname
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipname = Nothing
					Else
						entity.Shipname = Convert.ToString(Value)
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
		  	
			Public Property Shipstate As System.String 
				Get
					Dim data_ As System.String = entity.Shipstate
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipstate = Nothing
					Else
						entity.Shipstate = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shipzip As System.String 
				Get
					Dim data_ As System.String = entity.Shipzip
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipzip = Nothing
					Else
						entity.Shipzip = Convert.ToString(Value)
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
		  	
			Public Property Shipphone As System.String 
				Get
					Dim data_ As System.String = entity.Shipphone
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipphone = Nothing
					Else
						entity.Shipphone = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Posubtotal As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Posubtotal
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Posubtotal = Nothing
					Else
						entity.Posubtotal = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Posalestax As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Posalestax
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Posalestax = Nothing
					Else
						entity.Posalestax = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Pofreightin As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Pofreightin
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Pofreightin = Nothing
					Else
						entity.Pofreightin = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Pototal As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Pototal
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Pototal = Nothing
					Else
						entity.Pototal = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Instructions As System.String 
				Get
					Dim data_ As System.String = entity.Instructions
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Instructions = Nothing
					Else
						entity.Instructions = Convert.ToString(Value)
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
		  	
			Public Property Vendoritemnumber As System.String 
				Get
					Dim data_ As System.String = entity.Vendoritemnumber
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Vendoritemnumber = Nothing
					Else
						entity.Vendoritemnumber = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Qtyordered As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Qtyordered
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qtyordered = Nothing
					Else
						entity.Qtyordered = Convert.ToDecimal(Value)
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
					Dim data_ As Nullable(Of System.Decimal) = entity.Units
					
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
						entity.Units = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Vendorname As System.String 
				Get
					Dim data_ As System.String = entity.Vendorname
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Vendorname = Nothing
					Else
						entity.Vendorname = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Vendoraddress1 As System.String 
				Get
					Dim data_ As System.String = entity.Vendoraddress1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Vendoraddress1 = Nothing
					Else
						entity.Vendoraddress1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Vendoraddress2 As System.String 
				Get
					Dim data_ As System.String = entity.Vendoraddress2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Vendoraddress2 = Nothing
					Else
						entity.Vendoraddress2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Vendorcity As System.String 
				Get
					Dim data_ As System.String = entity.Vendorcity
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Vendorcity = Nothing
					Else
						entity.Vendorcity = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Vendorstate As System.String 
				Get
					Dim data_ As System.String = entity.Vendorstate
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Vendorstate = Nothing
					Else
						entity.Vendorstate = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Vendorzip As System.String 
				Get
					Dim data_ As System.String = entity.Vendorzip
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Vendorzip = Nothing
					Else
						entity.Vendorzip = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Vendorphone As System.String 
				Get
					Dim data_ As System.String = entity.Vendorphone
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Vendorphone = Nothing
					Else
						entity.Vendorphone = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Vendorfax As System.String 
				Get
					Dim data_ As System.String = entity.Vendorfax
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Vendorfax = Nothing
					Else
						entity.Vendorfax = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Vendorcontact As System.String 
				Get
					Dim data_ As System.String = entity.Vendorcontact
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Vendorcontact = Nothing
					Else
						entity.Vendorcontact = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Vendoremail As System.String 
				Get
					Dim data_ As System.String = entity.Vendoremail
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Vendoremail = Nothing
					Else
						entity.Vendoremail = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Vendorurl As System.String 
				Get
					Dim data_ As System.String = entity.Vendorurl
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Vendorurl = Nothing
					Else
						entity.Vendorurl = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Vendoracctnumber As System.String 
				Get
					Dim data_ As System.String = entity.Vendoracctnumber
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Vendoracctnumber = Nothing
					Else
						entity.Vendoracctnumber = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Terms As System.String 
				Get
					Dim data_ As System.String = entity.Terms
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Terms = Nothing
					Else
						entity.Terms = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CompanyName As System.String 
				Get
					Dim data_ As System.String = entity.CompanyName
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CompanyName = Nothing
					Else
						entity.CompanyName = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CompanyAddress As System.String 
				Get
					Dim data_ As System.String = entity.CompanyAddress
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CompanyAddress = Nothing
					Else
						entity.CompanyAddress = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Csz As System.String 
				Get
					Dim data_ As System.String = entity.Csz
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Csz = Nothing
					Else
						entity.Csz = Convert.ToString(Value)
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
		  	
			Public Property COAText As System.String 
				Get
					Dim data_ As System.String = entity.COAText
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.COAText = Nothing
					Else
						entity.COAText = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shipcsz As System.String 
				Get
					Dim data_ As System.String = entity.Shipcsz
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipcsz = Nothing
					Else
						entity.Shipcsz = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Vendorcsz As System.String 
				Get
					Dim data_ As System.String = entity.Vendorcsz
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Vendorcsz = Nothing
					Else
						entity.Vendorcsz = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Itemcustomerpo As System.String 
				Get
					Dim data_ As System.String = entity.Itemcustomerpo
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Itemcustomerpo = Nothing
					Else
						entity.Itemcustomerpo = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Purchasingnotes As System.String 
				Get
					Dim data_ As System.String = entity.Purchasingnotes
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Purchasingnotes = Nothing
					Else
						entity.Purchasingnotes = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewRptDirectPurchaseOrders2
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewRptDirectPurchaseOrders2Query)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewRptDirectPurchaseOrders2 can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewRptDirectPurchaseOrders2Query 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRptDirectPurchaseOrders2Metadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Ponumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Ponumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Vendorid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendorid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Podate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Podate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Potype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Potype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Poterms As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Poterms, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Postatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Postatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Changeableponumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Changeableponumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Shipname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipaddress1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Shipaddress1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipaddress2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Shipaddress2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipcity As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Shipcity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipstate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Shipstate, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipzip As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Shipzip, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipcontact As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Shipcontact, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipphone As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Shipphone, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Posubtotal As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Posubtotal, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Posalestax As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Posalestax, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Pofreightin As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Pofreightin, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Pototal As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Pototal, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Instructions As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Instructions, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Vendoritemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendoritemnumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Qtyordered As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Qtyordered, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Unitcost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Unitcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Extprice As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Extprice, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Uom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Uom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Unitorcontainer As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Unitorcontainer, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Units As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Units, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Vendorname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendorname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Vendoraddress1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendoraddress1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Vendoraddress2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendoraddress2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Vendorcity As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendorcity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Vendorstate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendorstate, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Vendorzip As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendorzip, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Vendorphone As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendorphone, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Vendorfax As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendorfax, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Vendorcontact As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendorcontact, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Vendoremail As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendoremail, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Vendorurl As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendorurl, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Vendoracctnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendoracctnumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Terms As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Terms, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CompanyName As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptDirectPurchaseOrders2Metadata.ColumnNames.CompanyName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CompanyAddress As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptDirectPurchaseOrders2Metadata.ColumnNames.CompanyAddress, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Csz As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Csz, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Expectedindate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Expectedindate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property COAText As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptDirectPurchaseOrders2Metadata.ColumnNames.COAText, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipcsz As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Shipcsz, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Vendorcsz As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendorcsz, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Itemcustomerpo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Itemcustomerpo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Purchasingnotes As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Purchasingnotes, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewRptDirectPurchaseOrders2Collection")> _
	Partial Public Class ViewRptDirectPurchaseOrders2Collection
		Inherits esViewRptDirectPurchaseOrders2Collection
		Implements IEnumerable(Of ViewRptDirectPurchaseOrders2)
		
        Public Shared Widening Operator CType(ByVal coll As ViewRptDirectPurchaseOrders2Collection) As List(Of ViewRptDirectPurchaseOrders2)
            Dim list As List(Of ViewRptDirectPurchaseOrders2) = New List(Of ViewRptDirectPurchaseOrders2)
            Dim emp As ViewRptDirectPurchaseOrders2

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRptDirectPurchaseOrders2Metadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewRptDirectPurchaseOrders2Query()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewRptDirectPurchaseOrders2(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewRptDirectPurchaseOrders2()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewRptDirectPurchaseOrders2Query 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewRptDirectPurchaseOrders2Query()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRptDirectPurchaseOrders2Query) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewRptDirectPurchaseOrders2 
			Return CType(MyBase.AddNewEntity(), ViewRptDirectPurchaseOrders2)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewRptDirectPurchaseOrders2) Implements IEnumerable(Of ViewRptDirectPurchaseOrders2).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewRptDirectPurchaseOrders2)(Me)
        End Function
		
		Private _query As ViewRptDirectPurchaseOrders2Query

	End Class
	


	' <summary>
	' Encapsulates the 'viewRptDirectPurchaseOrders2' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewRptDirectPurchaseOrders2 ()")> _
	<Serializable> _
	Partial Public Class ViewRptDirectPurchaseOrders2 
		Inherits esViewRptDirectPurchaseOrders2

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewRptDirectPurchaseOrders2Metadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewRptDirectPurchaseOrders2Query

			If Me._query Is Nothing Then
				Me._query = New ViewRptDirectPurchaseOrders2Query()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewRptDirectPurchaseOrders2Query
			Get

				If Me._query Is Nothing then
					Me._query = New ViewRptDirectPurchaseOrders2Query()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRptDirectPurchaseOrders2Query) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewRptDirectPurchaseOrders2Query

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewRptDirectPurchaseOrders2Query
		inherits esViewRptDirectPurchaseOrders2Query
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewRptDirectPurchaseOrders2Query"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewRptDirectPurchaseOrders2Metadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Ponumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptDirectPurchaseOrders2Metadata.PropertyNames.Ponumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendorid, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptDirectPurchaseOrders2Metadata.PropertyNames.Vendorid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Podate, 2, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewRptDirectPurchaseOrders2Metadata.PropertyNames.Podate
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Potype, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptDirectPurchaseOrders2Metadata.PropertyNames.Potype
			c.CharacterMaxLength = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Poterms, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptDirectPurchaseOrders2Metadata.PropertyNames.Poterms
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Postatus, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptDirectPurchaseOrders2Metadata.PropertyNames.Postatus
			c.CharacterMaxLength = 50
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Changeableponumber, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptDirectPurchaseOrders2Metadata.PropertyNames.Changeableponumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Shipname, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptDirectPurchaseOrders2Metadata.PropertyNames.Shipname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Shipaddress1, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptDirectPurchaseOrders2Metadata.PropertyNames.Shipaddress1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Shipaddress2, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptDirectPurchaseOrders2Metadata.PropertyNames.Shipaddress2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Shipcity, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptDirectPurchaseOrders2Metadata.PropertyNames.Shipcity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Shipstate, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptDirectPurchaseOrders2Metadata.PropertyNames.Shipstate
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Shipzip, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptDirectPurchaseOrders2Metadata.PropertyNames.Shipzip
			c.CharacterMaxLength = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Shipcontact, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptDirectPurchaseOrders2Metadata.PropertyNames.Shipcontact
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Shipphone, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptDirectPurchaseOrders2Metadata.PropertyNames.Shipphone
			c.CharacterMaxLength = 20
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Posubtotal, 15, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptDirectPurchaseOrders2Metadata.PropertyNames.Posubtotal
			c.NumericPrecision = 18
			c.NumericScale = 4
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Posalestax, 16, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptDirectPurchaseOrders2Metadata.PropertyNames.Posalestax
			c.NumericPrecision = 18
			c.NumericScale = 4
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Pofreightin, 17, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptDirectPurchaseOrders2Metadata.PropertyNames.Pofreightin
			c.NumericPrecision = 18
			c.NumericScale = 4
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Pototal, 18, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptDirectPurchaseOrders2Metadata.PropertyNames.Pototal
			c.NumericPrecision = 18
			c.NumericScale = 4
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Instructions, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptDirectPurchaseOrders2Metadata.PropertyNames.Instructions
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Productid, 20, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptDirectPurchaseOrders2Metadata.PropertyNames.Productid
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Productdesc, 21, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptDirectPurchaseOrders2Metadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendoritemnumber, 22, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptDirectPurchaseOrders2Metadata.PropertyNames.Vendoritemnumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Qtyordered, 23, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptDirectPurchaseOrders2Metadata.PropertyNames.Qtyordered
			c.NumericPrecision = 38
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Unitcost, 24, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptDirectPurchaseOrders2Metadata.PropertyNames.Unitcost
			c.NumericPrecision = 29
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Extprice, 25, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptDirectPurchaseOrders2Metadata.PropertyNames.Extprice
			c.NumericPrecision = 38
			c.NumericScale = 6
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Uom, 26, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptDirectPurchaseOrders2Metadata.PropertyNames.Uom
			c.CharacterMaxLength = 8
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Container, 27, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptDirectPurchaseOrders2Metadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Unitorcontainer, 28, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptDirectPurchaseOrders2Metadata.PropertyNames.Unitorcontainer
			c.CharacterMaxLength = 1
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Units, 29, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptDirectPurchaseOrders2Metadata.PropertyNames.Units
			c.NumericPrecision = 38
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendorname, 30, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptDirectPurchaseOrders2Metadata.PropertyNames.Vendorname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendoraddress1, 31, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptDirectPurchaseOrders2Metadata.PropertyNames.Vendoraddress1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendoraddress2, 32, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptDirectPurchaseOrders2Metadata.PropertyNames.Vendoraddress2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendorcity, 33, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptDirectPurchaseOrders2Metadata.PropertyNames.Vendorcity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendorstate, 34, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptDirectPurchaseOrders2Metadata.PropertyNames.Vendorstate
			c.CharacterMaxLength = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendorzip, 35, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptDirectPurchaseOrders2Metadata.PropertyNames.Vendorzip
			c.CharacterMaxLength = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendorphone, 36, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptDirectPurchaseOrders2Metadata.PropertyNames.Vendorphone
			c.CharacterMaxLength = 20
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendorfax, 37, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptDirectPurchaseOrders2Metadata.PropertyNames.Vendorfax
			c.CharacterMaxLength = 20
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendorcontact, 38, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptDirectPurchaseOrders2Metadata.PropertyNames.Vendorcontact
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendoremail, 39, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptDirectPurchaseOrders2Metadata.PropertyNames.Vendoremail
			c.CharacterMaxLength = 100
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendorurl, 40, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptDirectPurchaseOrders2Metadata.PropertyNames.Vendorurl
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendoracctnumber, 41, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptDirectPurchaseOrders2Metadata.PropertyNames.Vendoracctnumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Terms, 42, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptDirectPurchaseOrders2Metadata.PropertyNames.Terms
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.CompanyName, 43, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptDirectPurchaseOrders2Metadata.PropertyNames.CompanyName
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.CompanyAddress, 44, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptDirectPurchaseOrders2Metadata.PropertyNames.CompanyAddress
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Csz, 45, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptDirectPurchaseOrders2Metadata.PropertyNames.Csz
			c.CharacterMaxLength = 106
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Expectedindate, 46, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewRptDirectPurchaseOrders2Metadata.PropertyNames.Expectedindate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.COAText, 47, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptDirectPurchaseOrders2Metadata.PropertyNames.COAText
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Shipcsz, 48, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptDirectPurchaseOrders2Metadata.PropertyNames.Shipcsz
			c.CharacterMaxLength = 114
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Vendorcsz, 49, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptDirectPurchaseOrders2Metadata.PropertyNames.Vendorcsz
			c.CharacterMaxLength = 66
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Itemcustomerpo, 50, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptDirectPurchaseOrders2Metadata.PropertyNames.Itemcustomerpo
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptDirectPurchaseOrders2Metadata.ColumnNames.Purchasingnotes, 51, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptDirectPurchaseOrders2Metadata.PropertyNames.Purchasingnotes
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewRptDirectPurchaseOrders2Metadata
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
			 Public Const Ponumber As String = "PONUMBER"
			 Public Const Vendorid As String = "VENDORID"
			 Public Const Podate As String = "PODATE"
			 Public Const Potype As String = "POTYPE"
			 Public Const Poterms As String = "POTERMS"
			 Public Const Postatus As String = "POSTATUS"
			 Public Const Changeableponumber As String = "CHANGEABLEPONUMBER"
			 Public Const Shipname As String = "SHIPNAME"
			 Public Const Shipaddress1 As String = "SHIPADDRESS1"
			 Public Const Shipaddress2 As String = "SHIPADDRESS2"
			 Public Const Shipcity As String = "SHIPCITY"
			 Public Const Shipstate As String = "SHIPSTATE"
			 Public Const Shipzip As String = "SHIPZIP"
			 Public Const Shipcontact As String = "SHIPCONTACT"
			 Public Const Shipphone As String = "SHIPPHONE"
			 Public Const Posubtotal As String = "POSUBTOTAL"
			 Public Const Posalestax As String = "POSALESTAX"
			 Public Const Pofreightin As String = "POFREIGHTIN"
			 Public Const Pototal As String = "POTOTAL"
			 Public Const Instructions As String = "INSTRUCTIONS"
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Productdesc As String = "PRODUCTDESC"
			 Public Const Vendoritemnumber As String = "VENDORITEMNUMBER"
			 Public Const Qtyordered As String = "QTYORDERED"
			 Public Const Unitcost As String = "UNITCOST"
			 Public Const Extprice As String = "EXTPRICE"
			 Public Const Uom As String = "UOM"
			 Public Const Container As String = "CONTAINER"
			 Public Const Unitorcontainer As String = "UNITORCONTAINER"
			 Public Const Units As String = "UNITS"
			 Public Const Vendorname As String = "VENDORNAME"
			 Public Const Vendoraddress1 As String = "VENDORADDRESS1"
			 Public Const Vendoraddress2 As String = "VENDORADDRESS2"
			 Public Const Vendorcity As String = "VENDORCITY"
			 Public Const Vendorstate As String = "VENDORSTATE"
			 Public Const Vendorzip As String = "VENDORZIP"
			 Public Const Vendorphone As String = "VENDORPHONE"
			 Public Const Vendorfax As String = "VENDORFAX"
			 Public Const Vendorcontact As String = "VENDORCONTACT"
			 Public Const Vendoremail As String = "VENDOREMAIL"
			 Public Const Vendorurl As String = "VENDORURL"
			 Public Const Vendoracctnumber As String = "VENDORACCTNUMBER"
			 Public Const Terms As String = "TERMS"
			 Public Const CompanyName As String = "CompanyName"
			 Public Const CompanyAddress As String = "CompanyAddress"
			 Public Const Csz As String = "CSZ"
			 Public Const Expectedindate As String = "EXPECTEDINDATE"
			 Public Const COAText As String = "COAText"
			 Public Const Shipcsz As String = "SHIPCSZ"
			 Public Const Vendorcsz As String = "VENDORCSZ"
			 Public Const Itemcustomerpo As String = "ITEMCUSTOMERPO"
			 Public Const Purchasingnotes As String = "PURCHASINGNOTES"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Ponumber As String = "Ponumber"
			 Public Const Vendorid As String = "Vendorid"
			 Public Const Podate As String = "Podate"
			 Public Const Potype As String = "Potype"
			 Public Const Poterms As String = "Poterms"
			 Public Const Postatus As String = "Postatus"
			 Public Const Changeableponumber As String = "Changeableponumber"
			 Public Const Shipname As String = "Shipname"
			 Public Const Shipaddress1 As String = "Shipaddress1"
			 Public Const Shipaddress2 As String = "Shipaddress2"
			 Public Const Shipcity As String = "Shipcity"
			 Public Const Shipstate As String = "Shipstate"
			 Public Const Shipzip As String = "Shipzip"
			 Public Const Shipcontact As String = "Shipcontact"
			 Public Const Shipphone As String = "Shipphone"
			 Public Const Posubtotal As String = "Posubtotal"
			 Public Const Posalestax As String = "Posalestax"
			 Public Const Pofreightin As String = "Pofreightin"
			 Public Const Pototal As String = "Pototal"
			 Public Const Instructions As String = "Instructions"
			 Public Const Productid As String = "Productid"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const Vendoritemnumber As String = "Vendoritemnumber"
			 Public Const Qtyordered As String = "Qtyordered"
			 Public Const Unitcost As String = "Unitcost"
			 Public Const Extprice As String = "Extprice"
			 Public Const Uom As String = "Uom"
			 Public Const Container As String = "Container"
			 Public Const Unitorcontainer As String = "Unitorcontainer"
			 Public Const Units As String = "Units"
			 Public Const Vendorname As String = "Vendorname"
			 Public Const Vendoraddress1 As String = "Vendoraddress1"
			 Public Const Vendoraddress2 As String = "Vendoraddress2"
			 Public Const Vendorcity As String = "Vendorcity"
			 Public Const Vendorstate As String = "Vendorstate"
			 Public Const Vendorzip As String = "Vendorzip"
			 Public Const Vendorphone As String = "Vendorphone"
			 Public Const Vendorfax As String = "Vendorfax"
			 Public Const Vendorcontact As String = "Vendorcontact"
			 Public Const Vendoremail As String = "Vendoremail"
			 Public Const Vendorurl As String = "Vendorurl"
			 Public Const Vendoracctnumber As String = "Vendoracctnumber"
			 Public Const Terms As String = "Terms"
			 Public Const CompanyName As String = "CompanyName"
			 Public Const CompanyAddress As String = "CompanyAddress"
			 Public Const Csz As String = "Csz"
			 Public Const Expectedindate As String = "Expectedindate"
			 Public Const COAText As String = "COAText"
			 Public Const Shipcsz As String = "Shipcsz"
			 Public Const Vendorcsz As String = "Vendorcsz"
			 Public Const Itemcustomerpo As String = "Itemcustomerpo"
			 Public Const Purchasingnotes As String = "Purchasingnotes"
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
            SyncLock GetType(ViewRptDirectPurchaseOrders2Metadata)
			
				If ViewRptDirectPurchaseOrders2Metadata.mapDelegates Is Nothing Then
					ViewRptDirectPurchaseOrders2Metadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewRptDirectPurchaseOrders2Metadata._meta Is Nothing Then
                    ViewRptDirectPurchaseOrders2Metadata._meta = New ViewRptDirectPurchaseOrders2Metadata()
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
				

				meta.AddTypeMap("Ponumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Vendorid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Podate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Potype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Poterms", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Postatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Changeableponumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipaddress1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipaddress2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipcity", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipstate", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipzip", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipcontact", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipphone", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Posubtotal", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Posalestax", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Pofreightin", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Pototal", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Instructions", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Productid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Vendoritemnumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Qtyordered", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Unitcost", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Extprice", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Uom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Unitorcontainer", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Units", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Vendorname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Vendoraddress1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Vendoraddress2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Vendorcity", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Vendorstate", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Vendorzip", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Vendorphone", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Vendorfax", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Vendorcontact", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Vendoremail", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Vendorurl", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Vendoracctnumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Terms", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CompanyName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CompanyAddress", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Csz", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Expectedindate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("COAText", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipcsz", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Vendorcsz", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Itemcustomerpo", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Purchasingnotes", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewRptDirectPurchaseOrders2"
				meta.Destination = "viewRptDirectPurchaseOrders2"
				
				meta.spInsert = "proc_viewRptDirectPurchaseOrders2Insert"
				meta.spUpdate = "proc_viewRptDirectPurchaseOrders2Update"
				meta.spDelete = "proc_viewRptDirectPurchaseOrders2Delete"
				meta.spLoadAll = "proc_viewRptDirectPurchaseOrders2LoadAll"
				meta.spLoadByPrimaryKey = "proc_viewRptDirectPurchaseOrders2LoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewRptDirectPurchaseOrders2Metadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
