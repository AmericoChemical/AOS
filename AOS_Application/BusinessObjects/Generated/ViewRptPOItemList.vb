'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/11/2014 1:36:10 PM
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
	MustInherit Public Class esViewRptPOItemListCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewRptPOItemListCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewRptPOItemListQuery)
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
            Me.InitQuery(CType(query, esViewRptPOItemListQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewRptPOItemList) As ViewRptPOItemList
			Return CType(MyBase.DetachEntity(entity), ViewRptPOItemList)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewRptPOItemList) As ViewRptPOItemList
			Return CType(MyBase.AttachEntity(entity), ViewRptPOItemList)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewRptPOItemListCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewRptPOItemList
            Get
                Return TryCast(MyBase.Item(index), ViewRptPOItemList)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewRptPOItemList)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewRptPOItemList	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewRptPOItemListQuery
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
												
						Case "Poitemnumber"
							Me.str.Poitemnumber = CType(value, string)
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Productdesc"
							Me.str.Productdesc = CType(value, string)
												
						Case "Qtyordered"
							Me.str.Qtyordered = CType(value, string)
												
						Case "Qtyreleased"
							Me.str.Qtyreleased = CType(value, string)
												
						Case "Qtyreceived"
							Me.str.Qtyreceived = CType(value, string)
												
						Case "Qtycanceled"
							Me.str.Qtycanceled = CType(value, string)
												
						Case "Vendoritemnumber"
							Me.str.Vendoritemnumber = CType(value, string)
												
						Case "Unitcost"
							Me.str.Unitcost = CType(value, string)
												
						Case "Extcost"
							Me.str.Extcost = CType(value, string)
												
						Case "Uom"
							Me.str.Uom = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "Unitorcontainer"
							Me.str.Unitorcontainer = CType(value, string)
												
						Case "Units"
							Me.str.Units = CType(value, string)
												
						Case "Vendorid"
							Me.str.Vendorid = CType(value, string)
												
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
												
						Case "Expecteddelivery"
							Me.str.Expecteddelivery = CType(value, string)
												
						Case "COAText"
							Me.str.COAText = CType(value, string)
												
						Case "Shipcsz"
							Me.str.Shipcsz = CType(value, string)
												
						Case "Vendorcsz"
							Me.str.Vendorcsz = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Ponumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Ponumber = CType(value, Nullable(Of System.Int32))
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
						
						Case "Poitemnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Poitemnumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Qtyordered"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Qtyordered = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Qtyreleased"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Qtyreleased = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Qtyreceived"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Qtyreceived = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Qtycanceled"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Qtycanceled = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Unitcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Unitcost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Extcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Extcost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Units"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Units = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Vendorid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Vendorid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Expecteddelivery"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Expecteddelivery = CType(value, Nullable(Of System.DateTime))
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
		' Maps to viewRptPOItemList.PONUMBER
		' </summary>
		Public Overridable Property Ponumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptPOItemListMetadata.ColumnNames.Ponumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptPOItemListMetadata.ColumnNames.Ponumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOItemList.PODATE
		' </summary>
		Public Overridable Property Podate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewRptPOItemListMetadata.ColumnNames.Podate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewRptPOItemListMetadata.ColumnNames.Podate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOItemList.POTYPE
		' </summary>
		Public Overridable Property Potype As System.String
			Get
				Return MyBase.GetSystemString(ViewRptPOItemListMetadata.ColumnNames.Potype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptPOItemListMetadata.ColumnNames.Potype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOItemList.POTERMS
		' </summary>
		Public Overridable Property Poterms As System.String
			Get
				Return MyBase.GetSystemString(ViewRptPOItemListMetadata.ColumnNames.Poterms)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptPOItemListMetadata.ColumnNames.Poterms, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOItemList.POSTATUS
		' </summary>
		Public Overridable Property Postatus As System.String
			Get
				Return MyBase.GetSystemString(ViewRptPOItemListMetadata.ColumnNames.Postatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptPOItemListMetadata.ColumnNames.Postatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOItemList.CHANGEABLEPONUMBER
		' </summary>
		Public Overridable Property Changeableponumber As System.String
			Get
				Return MyBase.GetSystemString(ViewRptPOItemListMetadata.ColumnNames.Changeableponumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptPOItemListMetadata.ColumnNames.Changeableponumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOItemList.SHIPNAME
		' </summary>
		Public Overridable Property Shipname As System.String
			Get
				Return MyBase.GetSystemString(ViewRptPOItemListMetadata.ColumnNames.Shipname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptPOItemListMetadata.ColumnNames.Shipname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOItemList.SHIPADDRESS1
		' </summary>
		Public Overridable Property Shipaddress1 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptPOItemListMetadata.ColumnNames.Shipaddress1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptPOItemListMetadata.ColumnNames.Shipaddress1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOItemList.SHIPADDRESS2
		' </summary>
		Public Overridable Property Shipaddress2 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptPOItemListMetadata.ColumnNames.Shipaddress2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptPOItemListMetadata.ColumnNames.Shipaddress2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOItemList.SHIPCITY
		' </summary>
		Public Overridable Property Shipcity As System.String
			Get
				Return MyBase.GetSystemString(ViewRptPOItemListMetadata.ColumnNames.Shipcity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptPOItemListMetadata.ColumnNames.Shipcity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOItemList.SHIPSTATE
		' </summary>
		Public Overridable Property Shipstate As System.String
			Get
				Return MyBase.GetSystemString(ViewRptPOItemListMetadata.ColumnNames.Shipstate)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptPOItemListMetadata.ColumnNames.Shipstate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOItemList.SHIPZIP
		' </summary>
		Public Overridable Property Shipzip As System.String
			Get
				Return MyBase.GetSystemString(ViewRptPOItemListMetadata.ColumnNames.Shipzip)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptPOItemListMetadata.ColumnNames.Shipzip, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOItemList.SHIPCONTACT
		' </summary>
		Public Overridable Property Shipcontact As System.String
			Get
				Return MyBase.GetSystemString(ViewRptPOItemListMetadata.ColumnNames.Shipcontact)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptPOItemListMetadata.ColumnNames.Shipcontact, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOItemList.SHIPPHONE
		' </summary>
		Public Overridable Property Shipphone As System.String
			Get
				Return MyBase.GetSystemString(ViewRptPOItemListMetadata.ColumnNames.Shipphone)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptPOItemListMetadata.ColumnNames.Shipphone, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOItemList.POSUBTOTAL
		' </summary>
		Public Overridable Property Posubtotal As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptPOItemListMetadata.ColumnNames.Posubtotal)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptPOItemListMetadata.ColumnNames.Posubtotal, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOItemList.POSALESTAX
		' </summary>
		Public Overridable Property Posalestax As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptPOItemListMetadata.ColumnNames.Posalestax)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptPOItemListMetadata.ColumnNames.Posalestax, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOItemList.POFREIGHTIN
		' </summary>
		Public Overridable Property Pofreightin As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptPOItemListMetadata.ColumnNames.Pofreightin)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptPOItemListMetadata.ColumnNames.Pofreightin, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOItemList.POTOTAL
		' </summary>
		Public Overridable Property Pototal As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptPOItemListMetadata.ColumnNames.Pototal)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptPOItemListMetadata.ColumnNames.Pototal, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOItemList.INSTRUCTIONS
		' </summary>
		Public Overridable Property Instructions As System.String
			Get
				Return MyBase.GetSystemString(ViewRptPOItemListMetadata.ColumnNames.Instructions)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptPOItemListMetadata.ColumnNames.Instructions, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOItemList.POITEMNUMBER
		' </summary>
		Public Overridable Property Poitemnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptPOItemListMetadata.ColumnNames.Poitemnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptPOItemListMetadata.ColumnNames.Poitemnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOItemList.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptPOItemListMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptPOItemListMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOItemList.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewRptPOItemListMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptPOItemListMetadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOItemList.QTYORDERED
		' </summary>
		Public Overridable Property Qtyordered As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptPOItemListMetadata.ColumnNames.Qtyordered)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptPOItemListMetadata.ColumnNames.Qtyordered, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOItemList.QTYRELEASED
		' </summary>
		Public Overridable Property Qtyreleased As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptPOItemListMetadata.ColumnNames.Qtyreleased)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptPOItemListMetadata.ColumnNames.Qtyreleased, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOItemList.QTYRECEIVED
		' </summary>
		Public Overridable Property Qtyreceived As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptPOItemListMetadata.ColumnNames.Qtyreceived)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptPOItemListMetadata.ColumnNames.Qtyreceived, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOItemList.QTYCANCELED
		' </summary>
		Public Overridable Property Qtycanceled As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptPOItemListMetadata.ColumnNames.Qtycanceled)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptPOItemListMetadata.ColumnNames.Qtycanceled, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOItemList.VENDORITEMNUMBER
		' </summary>
		Public Overridable Property Vendoritemnumber As System.String
			Get
				Return MyBase.GetSystemString(ViewRptPOItemListMetadata.ColumnNames.Vendoritemnumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptPOItemListMetadata.ColumnNames.Vendoritemnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOItemList.UNITCOST
		' </summary>
		Public Overridable Property Unitcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptPOItemListMetadata.ColumnNames.Unitcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptPOItemListMetadata.ColumnNames.Unitcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOItemList.EXTCOST
		' </summary>
		Public Overridable Property Extcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptPOItemListMetadata.ColumnNames.Extcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptPOItemListMetadata.ColumnNames.Extcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOItemList.UOM
		' </summary>
		Public Overridable Property Uom As System.String
			Get
				Return MyBase.GetSystemString(ViewRptPOItemListMetadata.ColumnNames.Uom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptPOItemListMetadata.ColumnNames.Uom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOItemList.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewRptPOItemListMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptPOItemListMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOItemList.UNITORCONTAINER
		' </summary>
		Public Overridable Property Unitorcontainer As System.String
			Get
				Return MyBase.GetSystemString(ViewRptPOItemListMetadata.ColumnNames.Unitorcontainer)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptPOItemListMetadata.ColumnNames.Unitorcontainer, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOItemList.UNITS
		' </summary>
		Public Overridable Property Units As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptPOItemListMetadata.ColumnNames.Units)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptPOItemListMetadata.ColumnNames.Units, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOItemList.VENDORID
		' </summary>
		Public Overridable Property Vendorid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptPOItemListMetadata.ColumnNames.Vendorid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptPOItemListMetadata.ColumnNames.Vendorid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOItemList.VENDORNAME
		' </summary>
		Public Overridable Property Vendorname As System.String
			Get
				Return MyBase.GetSystemString(ViewRptPOItemListMetadata.ColumnNames.Vendorname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptPOItemListMetadata.ColumnNames.Vendorname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOItemList.VENDORADDRESS1
		' </summary>
		Public Overridable Property Vendoraddress1 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptPOItemListMetadata.ColumnNames.Vendoraddress1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptPOItemListMetadata.ColumnNames.Vendoraddress1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOItemList.VENDORADDRESS2
		' </summary>
		Public Overridable Property Vendoraddress2 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptPOItemListMetadata.ColumnNames.Vendoraddress2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptPOItemListMetadata.ColumnNames.Vendoraddress2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOItemList.VENDORCITY
		' </summary>
		Public Overridable Property Vendorcity As System.String
			Get
				Return MyBase.GetSystemString(ViewRptPOItemListMetadata.ColumnNames.Vendorcity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptPOItemListMetadata.ColumnNames.Vendorcity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOItemList.VENDORSTATE
		' </summary>
		Public Overridable Property Vendorstate As System.String
			Get
				Return MyBase.GetSystemString(ViewRptPOItemListMetadata.ColumnNames.Vendorstate)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptPOItemListMetadata.ColumnNames.Vendorstate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOItemList.VENDORZIP
		' </summary>
		Public Overridable Property Vendorzip As System.String
			Get
				Return MyBase.GetSystemString(ViewRptPOItemListMetadata.ColumnNames.Vendorzip)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptPOItemListMetadata.ColumnNames.Vendorzip, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOItemList.VENDORPHONE
		' </summary>
		Public Overridable Property Vendorphone As System.String
			Get
				Return MyBase.GetSystemString(ViewRptPOItemListMetadata.ColumnNames.Vendorphone)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptPOItemListMetadata.ColumnNames.Vendorphone, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOItemList.VENDORFAX
		' </summary>
		Public Overridable Property Vendorfax As System.String
			Get
				Return MyBase.GetSystemString(ViewRptPOItemListMetadata.ColumnNames.Vendorfax)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptPOItemListMetadata.ColumnNames.Vendorfax, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOItemList.VENDORCONTACT
		' </summary>
		Public Overridable Property Vendorcontact As System.String
			Get
				Return MyBase.GetSystemString(ViewRptPOItemListMetadata.ColumnNames.Vendorcontact)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptPOItemListMetadata.ColumnNames.Vendorcontact, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOItemList.VENDOREMAIL
		' </summary>
		Public Overridable Property Vendoremail As System.String
			Get
				Return MyBase.GetSystemString(ViewRptPOItemListMetadata.ColumnNames.Vendoremail)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptPOItemListMetadata.ColumnNames.Vendoremail, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOItemList.VENDORURL
		' </summary>
		Public Overridable Property Vendorurl As System.String
			Get
				Return MyBase.GetSystemString(ViewRptPOItemListMetadata.ColumnNames.Vendorurl)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptPOItemListMetadata.ColumnNames.Vendorurl, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOItemList.VENDORACCTNUMBER
		' </summary>
		Public Overridable Property Vendoracctnumber As System.String
			Get
				Return MyBase.GetSystemString(ViewRptPOItemListMetadata.ColumnNames.Vendoracctnumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptPOItemListMetadata.ColumnNames.Vendoracctnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOItemList.TERMS
		' </summary>
		Public Overridable Property Terms As System.String
			Get
				Return MyBase.GetSystemString(ViewRptPOItemListMetadata.ColumnNames.Terms)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptPOItemListMetadata.ColumnNames.Terms, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOItemList.CompanyName
		' </summary>
		Public Overridable Property CompanyName As System.String
			Get
				Return MyBase.GetSystemString(ViewRptPOItemListMetadata.ColumnNames.CompanyName)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptPOItemListMetadata.ColumnNames.CompanyName, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOItemList.CompanyAddress
		' </summary>
		Public Overridable Property CompanyAddress As System.String
			Get
				Return MyBase.GetSystemString(ViewRptPOItemListMetadata.ColumnNames.CompanyAddress)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptPOItemListMetadata.ColumnNames.CompanyAddress, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOItemList.CSZ
		' </summary>
		Public Overridable Property Csz As System.String
			Get
				Return MyBase.GetSystemString(ViewRptPOItemListMetadata.ColumnNames.Csz)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptPOItemListMetadata.ColumnNames.Csz, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOItemList.EXPECTEDDELIVERY
		' </summary>
		Public Overridable Property Expecteddelivery As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewRptPOItemListMetadata.ColumnNames.Expecteddelivery)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewRptPOItemListMetadata.ColumnNames.Expecteddelivery, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOItemList.COAText
		' </summary>
		Public Overridable Property COAText As System.String
			Get
				Return MyBase.GetSystemString(ViewRptPOItemListMetadata.ColumnNames.COAText)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptPOItemListMetadata.ColumnNames.COAText, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOItemList.SHIPCSZ
		' </summary>
		Public Overridable Property Shipcsz As System.String
			Get
				Return MyBase.GetSystemString(ViewRptPOItemListMetadata.ColumnNames.Shipcsz)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptPOItemListMetadata.ColumnNames.Shipcsz, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOItemList.VENDORCSZ
		' </summary>
		Public Overridable Property Vendorcsz As System.String
			Get
				Return MyBase.GetSystemString(ViewRptPOItemListMetadata.ColumnNames.Vendorcsz)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptPOItemListMetadata.ColumnNames.Vendorcsz, value)
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
		
			Public Sub New(ByVal entity As esViewRptPOItemList)
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
		  	
			Public Property Poitemnumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Poitemnumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Poitemnumber = Nothing
					Else
						entity.Poitemnumber = Convert.ToInt32(Value)
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
		  	
			Public Property Qtyreleased As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Qtyreleased
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qtyreleased = Nothing
					Else
						entity.Qtyreleased = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Qtyreceived As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Qtyreceived
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qtyreceived = Nothing
					Else
						entity.Qtyreceived = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Qtycanceled As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Qtycanceled
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qtycanceled = Nothing
					Else
						entity.Qtycanceled = Convert.ToDecimal(Value)
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
		  	
			Public Property Expecteddelivery As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Expecteddelivery
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Expecteddelivery = Nothing
					Else
						entity.Expecteddelivery = Convert.ToDateTime(Value)
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
		  

			Private entity As esViewRptPOItemList
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewRptPOItemListQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewRptPOItemList can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewRptPOItemListQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRptPOItemListMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Ponumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOItemListMetadata.ColumnNames.Ponumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Podate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOItemListMetadata.ColumnNames.Podate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Potype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOItemListMetadata.ColumnNames.Potype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Poterms As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOItemListMetadata.ColumnNames.Poterms, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Postatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOItemListMetadata.ColumnNames.Postatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Changeableponumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOItemListMetadata.ColumnNames.Changeableponumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOItemListMetadata.ColumnNames.Shipname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipaddress1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOItemListMetadata.ColumnNames.Shipaddress1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipaddress2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOItemListMetadata.ColumnNames.Shipaddress2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipcity As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOItemListMetadata.ColumnNames.Shipcity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipstate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOItemListMetadata.ColumnNames.Shipstate, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipzip As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOItemListMetadata.ColumnNames.Shipzip, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipcontact As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOItemListMetadata.ColumnNames.Shipcontact, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipphone As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOItemListMetadata.ColumnNames.Shipphone, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Posubtotal As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOItemListMetadata.ColumnNames.Posubtotal, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Posalestax As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOItemListMetadata.ColumnNames.Posalestax, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Pofreightin As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOItemListMetadata.ColumnNames.Pofreightin, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Pototal As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOItemListMetadata.ColumnNames.Pototal, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Instructions As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOItemListMetadata.ColumnNames.Instructions, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Poitemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOItemListMetadata.ColumnNames.Poitemnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOItemListMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOItemListMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Qtyordered As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOItemListMetadata.ColumnNames.Qtyordered, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Qtyreleased As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOItemListMetadata.ColumnNames.Qtyreleased, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Qtyreceived As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOItemListMetadata.ColumnNames.Qtyreceived, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Qtycanceled As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOItemListMetadata.ColumnNames.Qtycanceled, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Vendoritemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOItemListMetadata.ColumnNames.Vendoritemnumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Unitcost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOItemListMetadata.ColumnNames.Unitcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Extcost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOItemListMetadata.ColumnNames.Extcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Uom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOItemListMetadata.ColumnNames.Uom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOItemListMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Unitorcontainer As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOItemListMetadata.ColumnNames.Unitorcontainer, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Units As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOItemListMetadata.ColumnNames.Units, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Vendorid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOItemListMetadata.ColumnNames.Vendorid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Vendorname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOItemListMetadata.ColumnNames.Vendorname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Vendoraddress1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOItemListMetadata.ColumnNames.Vendoraddress1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Vendoraddress2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOItemListMetadata.ColumnNames.Vendoraddress2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Vendorcity As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOItemListMetadata.ColumnNames.Vendorcity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Vendorstate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOItemListMetadata.ColumnNames.Vendorstate, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Vendorzip As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOItemListMetadata.ColumnNames.Vendorzip, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Vendorphone As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOItemListMetadata.ColumnNames.Vendorphone, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Vendorfax As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOItemListMetadata.ColumnNames.Vendorfax, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Vendorcontact As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOItemListMetadata.ColumnNames.Vendorcontact, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Vendoremail As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOItemListMetadata.ColumnNames.Vendoremail, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Vendorurl As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOItemListMetadata.ColumnNames.Vendorurl, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Vendoracctnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOItemListMetadata.ColumnNames.Vendoracctnumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Terms As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOItemListMetadata.ColumnNames.Terms, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CompanyName As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOItemListMetadata.ColumnNames.CompanyName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CompanyAddress As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOItemListMetadata.ColumnNames.CompanyAddress, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Csz As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOItemListMetadata.ColumnNames.Csz, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Expecteddelivery As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOItemListMetadata.ColumnNames.Expecteddelivery, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property COAText As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOItemListMetadata.ColumnNames.COAText, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipcsz As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOItemListMetadata.ColumnNames.Shipcsz, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Vendorcsz As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOItemListMetadata.ColumnNames.Vendorcsz, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewRptPOItemListCollection")> _
	Partial Public Class ViewRptPOItemListCollection
		Inherits esViewRptPOItemListCollection
		Implements IEnumerable(Of ViewRptPOItemList)
		
        Public Shared Widening Operator CType(ByVal coll As ViewRptPOItemListCollection) As List(Of ViewRptPOItemList)
            Dim list As List(Of ViewRptPOItemList) = New List(Of ViewRptPOItemList)
            Dim emp As ViewRptPOItemList

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRptPOItemListMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewRptPOItemListQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewRptPOItemList(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewRptPOItemList()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewRptPOItemListQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewRptPOItemListQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRptPOItemListQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewRptPOItemList 
			Return CType(MyBase.AddNewEntity(), ViewRptPOItemList)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewRptPOItemList) Implements IEnumerable(Of ViewRptPOItemList).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewRptPOItemList)(Me)
        End Function
		
		Private _query As ViewRptPOItemListQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewRptPOItemList' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewRptPOItemList ()")> _
	<Serializable> _
	Partial Public Class ViewRptPOItemList 
		Inherits esViewRptPOItemList

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewRptPOItemListMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewRptPOItemListQuery

			If Me._query Is Nothing Then
				Me._query = New ViewRptPOItemListQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewRptPOItemListQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewRptPOItemListQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRptPOItemListQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewRptPOItemListQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewRptPOItemListQuery
		inherits esViewRptPOItemListQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewRptPOItemListQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewRptPOItemListMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewRptPOItemListMetadata.ColumnNames.Ponumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptPOItemListMetadata.PropertyNames.Ponumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOItemListMetadata.ColumnNames.Podate, 1, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewRptPOItemListMetadata.PropertyNames.Podate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOItemListMetadata.ColumnNames.Potype, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptPOItemListMetadata.PropertyNames.Potype
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOItemListMetadata.ColumnNames.Poterms, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptPOItemListMetadata.PropertyNames.Poterms
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOItemListMetadata.ColumnNames.Postatus, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptPOItemListMetadata.PropertyNames.Postatus
			c.CharacterMaxLength = 15
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOItemListMetadata.ColumnNames.Changeableponumber, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptPOItemListMetadata.PropertyNames.Changeableponumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOItemListMetadata.ColumnNames.Shipname, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptPOItemListMetadata.PropertyNames.Shipname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOItemListMetadata.ColumnNames.Shipaddress1, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptPOItemListMetadata.PropertyNames.Shipaddress1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOItemListMetadata.ColumnNames.Shipaddress2, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptPOItemListMetadata.PropertyNames.Shipaddress2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOItemListMetadata.ColumnNames.Shipcity, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptPOItemListMetadata.PropertyNames.Shipcity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOItemListMetadata.ColumnNames.Shipstate, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptPOItemListMetadata.PropertyNames.Shipstate
			c.CharacterMaxLength = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOItemListMetadata.ColumnNames.Shipzip, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptPOItemListMetadata.PropertyNames.Shipzip
			c.CharacterMaxLength = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOItemListMetadata.ColumnNames.Shipcontact, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptPOItemListMetadata.PropertyNames.Shipcontact
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOItemListMetadata.ColumnNames.Shipphone, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptPOItemListMetadata.PropertyNames.Shipphone
			c.CharacterMaxLength = 20
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOItemListMetadata.ColumnNames.Posubtotal, 14, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptPOItemListMetadata.PropertyNames.Posubtotal
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOItemListMetadata.ColumnNames.Posalestax, 15, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptPOItemListMetadata.PropertyNames.Posalestax
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOItemListMetadata.ColumnNames.Pofreightin, 16, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptPOItemListMetadata.PropertyNames.Pofreightin
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOItemListMetadata.ColumnNames.Pototal, 17, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptPOItemListMetadata.PropertyNames.Pototal
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOItemListMetadata.ColumnNames.Instructions, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptPOItemListMetadata.PropertyNames.Instructions
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOItemListMetadata.ColumnNames.Poitemnumber, 19, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptPOItemListMetadata.PropertyNames.Poitemnumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOItemListMetadata.ColumnNames.Productid, 20, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptPOItemListMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOItemListMetadata.ColumnNames.Productdesc, 21, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptPOItemListMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 150
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOItemListMetadata.ColumnNames.Qtyordered, 22, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptPOItemListMetadata.PropertyNames.Qtyordered
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOItemListMetadata.ColumnNames.Qtyreleased, 23, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptPOItemListMetadata.PropertyNames.Qtyreleased
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOItemListMetadata.ColumnNames.Qtyreceived, 24, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptPOItemListMetadata.PropertyNames.Qtyreceived
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOItemListMetadata.ColumnNames.Qtycanceled, 25, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptPOItemListMetadata.PropertyNames.Qtycanceled
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOItemListMetadata.ColumnNames.Vendoritemnumber, 26, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptPOItemListMetadata.PropertyNames.Vendoritemnumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOItemListMetadata.ColumnNames.Unitcost, 27, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptPOItemListMetadata.PropertyNames.Unitcost
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOItemListMetadata.ColumnNames.Extcost, 28, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptPOItemListMetadata.PropertyNames.Extcost
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOItemListMetadata.ColumnNames.Uom, 29, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptPOItemListMetadata.PropertyNames.Uom
			c.CharacterMaxLength = 8
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOItemListMetadata.ColumnNames.Container, 30, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptPOItemListMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOItemListMetadata.ColumnNames.Unitorcontainer, 31, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptPOItemListMetadata.PropertyNames.Unitorcontainer
			c.CharacterMaxLength = 1
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOItemListMetadata.ColumnNames.Units, 32, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptPOItemListMetadata.PropertyNames.Units
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOItemListMetadata.ColumnNames.Vendorid, 33, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptPOItemListMetadata.PropertyNames.Vendorid
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOItemListMetadata.ColumnNames.Vendorname, 34, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptPOItemListMetadata.PropertyNames.Vendorname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOItemListMetadata.ColumnNames.Vendoraddress1, 35, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptPOItemListMetadata.PropertyNames.Vendoraddress1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOItemListMetadata.ColumnNames.Vendoraddress2, 36, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptPOItemListMetadata.PropertyNames.Vendoraddress2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOItemListMetadata.ColumnNames.Vendorcity, 37, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptPOItemListMetadata.PropertyNames.Vendorcity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOItemListMetadata.ColumnNames.Vendorstate, 38, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptPOItemListMetadata.PropertyNames.Vendorstate
			c.CharacterMaxLength = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOItemListMetadata.ColumnNames.Vendorzip, 39, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptPOItemListMetadata.PropertyNames.Vendorzip
			c.CharacterMaxLength = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOItemListMetadata.ColumnNames.Vendorphone, 40, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptPOItemListMetadata.PropertyNames.Vendorphone
			c.CharacterMaxLength = 20
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOItemListMetadata.ColumnNames.Vendorfax, 41, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptPOItemListMetadata.PropertyNames.Vendorfax
			c.CharacterMaxLength = 20
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOItemListMetadata.ColumnNames.Vendorcontact, 42, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptPOItemListMetadata.PropertyNames.Vendorcontact
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOItemListMetadata.ColumnNames.Vendoremail, 43, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptPOItemListMetadata.PropertyNames.Vendoremail
			c.CharacterMaxLength = 100
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOItemListMetadata.ColumnNames.Vendorurl, 44, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptPOItemListMetadata.PropertyNames.Vendorurl
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOItemListMetadata.ColumnNames.Vendoracctnumber, 45, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptPOItemListMetadata.PropertyNames.Vendoracctnumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOItemListMetadata.ColumnNames.Terms, 46, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptPOItemListMetadata.PropertyNames.Terms
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOItemListMetadata.ColumnNames.CompanyName, 47, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptPOItemListMetadata.PropertyNames.CompanyName
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOItemListMetadata.ColumnNames.CompanyAddress, 48, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptPOItemListMetadata.PropertyNames.CompanyAddress
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOItemListMetadata.ColumnNames.Csz, 49, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptPOItemListMetadata.PropertyNames.Csz
			c.CharacterMaxLength = 106
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOItemListMetadata.ColumnNames.Expecteddelivery, 50, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewRptPOItemListMetadata.PropertyNames.Expecteddelivery
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOItemListMetadata.ColumnNames.COAText, 51, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptPOItemListMetadata.PropertyNames.COAText
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOItemListMetadata.ColumnNames.Shipcsz, 52, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptPOItemListMetadata.PropertyNames.Shipcsz
			c.CharacterMaxLength = 66
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOItemListMetadata.ColumnNames.Vendorcsz, 53, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptPOItemListMetadata.PropertyNames.Vendorcsz
			c.CharacterMaxLength = 66
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewRptPOItemListMetadata
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
			 Public Const Poitemnumber As String = "POITEMNUMBER"
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Productdesc As String = "PRODUCTDESC"
			 Public Const Qtyordered As String = "QTYORDERED"
			 Public Const Qtyreleased As String = "QTYRELEASED"
			 Public Const Qtyreceived As String = "QTYRECEIVED"
			 Public Const Qtycanceled As String = "QTYCANCELED"
			 Public Const Vendoritemnumber As String = "VENDORITEMNUMBER"
			 Public Const Unitcost As String = "UNITCOST"
			 Public Const Extcost As String = "EXTCOST"
			 Public Const Uom As String = "UOM"
			 Public Const Container As String = "CONTAINER"
			 Public Const Unitorcontainer As String = "UNITORCONTAINER"
			 Public Const Units As String = "UNITS"
			 Public Const Vendorid As String = "VENDORID"
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
			 Public Const Expecteddelivery As String = "EXPECTEDDELIVERY"
			 Public Const COAText As String = "COAText"
			 Public Const Shipcsz As String = "SHIPCSZ"
			 Public Const Vendorcsz As String = "VENDORCSZ"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Ponumber As String = "Ponumber"
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
			 Public Const Poitemnumber As String = "Poitemnumber"
			 Public Const Productid As String = "Productid"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const Qtyordered As String = "Qtyordered"
			 Public Const Qtyreleased As String = "Qtyreleased"
			 Public Const Qtyreceived As String = "Qtyreceived"
			 Public Const Qtycanceled As String = "Qtycanceled"
			 Public Const Vendoritemnumber As String = "Vendoritemnumber"
			 Public Const Unitcost As String = "Unitcost"
			 Public Const Extcost As String = "Extcost"
			 Public Const Uom As String = "Uom"
			 Public Const Container As String = "Container"
			 Public Const Unitorcontainer As String = "Unitorcontainer"
			 Public Const Units As String = "Units"
			 Public Const Vendorid As String = "Vendorid"
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
			 Public Const Expecteddelivery As String = "Expecteddelivery"
			 Public Const COAText As String = "COAText"
			 Public Const Shipcsz As String = "Shipcsz"
			 Public Const Vendorcsz As String = "Vendorcsz"
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
            SyncLock GetType(ViewRptPOItemListMetadata)
			
				If ViewRptPOItemListMetadata.mapDelegates Is Nothing Then
					ViewRptPOItemListMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewRptPOItemListMetadata._meta Is Nothing Then
                    ViewRptPOItemListMetadata._meta = New ViewRptPOItemListMetadata()
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
				meta.AddTypeMap("Posubtotal", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Posalestax", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Pofreightin", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Pototal", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Instructions", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Poitemnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Qtyordered", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Qtyreleased", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Qtyreceived", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Qtycanceled", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Vendoritemnumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Unitcost", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Extcost", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Uom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Unitorcontainer", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Units", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Vendorid", new esTypeMap("int", "System.Int32"))
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
				meta.AddTypeMap("Expecteddelivery", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("COAText", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipcsz", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Vendorcsz", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewRptPOItemList"
				meta.Destination = "viewRptPOItemList"
				
				meta.spInsert = "proc_viewRptPOItemListInsert"
				meta.spUpdate = "proc_viewRptPOItemListUpdate"
				meta.spDelete = "proc_viewRptPOItemListDelete"
				meta.spLoadAll = "proc_viewRptPOItemListLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewRptPOItemListLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewRptPOItemListMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
