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
	MustInherit Public Class esViewRptBillOfLadingCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewRptBillOfLadingCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewRptBillOfLadingQuery)
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
            Me.InitQuery(CType(query, esViewRptBillOfLadingQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewRptBillOfLading) As ViewRptBillOfLading
			Return CType(MyBase.DetachEntity(entity), ViewRptBillOfLading)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewRptBillOfLading) As ViewRptBillOfLading
			Return CType(MyBase.AttachEntity(entity), ViewRptBillOfLading)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewRptBillOfLadingCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewRptBillOfLading
            Get
                Return TryCast(MyBase.Item(index), ViewRptBillOfLading)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewRptBillOfLading)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewRptBillOfLading	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewRptBillOfLadingQuery
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
												
						Case "Shipmentnumber"
							Me.str.Shipmentnumber = CType(value, string)
												
						Case "Shipmentdate"
							Me.str.Shipmentdate = CType(value, string)
												
						Case "Workordernumber"
							Me.str.Workordernumber = CType(value, string)
												
						Case "Custid"
							Me.str.Custid = CType(value, string)
												
						Case "Customername"
							Me.str.Customername = CType(value, string)
												
						Case "Shipfromaddress1"
							Me.str.Shipfromaddress1 = CType(value, string)
												
						Case "Shipfromaddress2"
							Me.str.Shipfromaddress2 = CType(value, string)
												
						Case "Shipfromcity"
							Me.str.Shipfromcity = CType(value, string)
												
						Case "Shipfromstateprov"
							Me.str.Shipfromstateprov = CType(value, string)
												
						Case "Shipfrompostalcode"
							Me.str.Shipfrompostalcode = CType(value, string)
												
						Case "Shipfromcountry"
							Me.str.Shipfromcountry = CType(value, string)
												
						Case "Shipfromphone"
							Me.str.Shipfromphone = CType(value, string)
												
						Case "Shipfromfax"
							Me.str.Shipfromfax = CType(value, string)
												
						Case "Shipfromcontact"
							Me.str.Shipfromcontact = CType(value, string)
												
						Case "Shiptoaddress1"
							Me.str.Shiptoaddress1 = CType(value, string)
												
						Case "Shiptoaddress2"
							Me.str.Shiptoaddress2 = CType(value, string)
												
						Case "Shiptocity"
							Me.str.Shiptocity = CType(value, string)
												
						Case "Shiptostateprov"
							Me.str.Shiptostateprov = CType(value, string)
												
						Case "Shiptopostalcode"
							Me.str.Shiptopostalcode = CType(value, string)
												
						Case "Shiptocountry"
							Me.str.Shiptocountry = CType(value, string)
												
						Case "Shiptocontact"
							Me.str.Shiptocontact = CType(value, string)
												
						Case "Freightcarrier"
							Me.str.Freightcarrier = CType(value, string)
												
						Case "Fob"
							Me.str.Fob = CType(value, string)
												
						Case "Customerpo"
							Me.str.Customerpo = CType(value, string)
												
						Case "Placardsrequired"
							Me.str.Placardsrequired = CType(value, string)
												
						Case "Placardssupplied"
							Me.str.Placardssupplied = CType(value, string)
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Productdesc"
							Me.str.Productdesc = CType(value, string)
												
						Case "Qtycontainers"
							Me.str.Qtycontainers = CType(value, string)
												
						Case "Totalweight"
							Me.str.Totalweight = CType(value, string)
												
						Case "Stdweight"
							Me.str.Stdweight = CType(value, string)
												
						Case "Stdgallons"
							Me.str.Stdgallons = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "Dotdesc"
							Me.str.Dotdesc = CType(value, string)
												
						Case "Hazmatdesc"
							Me.str.Hazmatdesc = CType(value, string)
												
						Case "Unline"
							Me.str.Unline = CType(value, string)
												
						Case "Classrate"
							Me.str.Classrate = CType(value, string)
												
						Case "Ld1"
							Me.str.Ld1 = CType(value, string)
												
						Case "Ld2"
							Me.str.Ld2 = CType(value, string)
												
						Case "Ld3"
							Me.str.Ld3 = CType(value, string)
												
						Case "Hazmatid"
							Me.str.Hazmatid = CType(value, string)
												
						Case "Logisticsid"
							Me.str.Logisticsid = CType(value, string)
												
						Case "Logisticsname"
							Me.str.Logisticsname = CType(value, string)
												
						Case "Logisticsaddr1"
							Me.str.Logisticsaddr1 = CType(value, string)
												
						Case "Logisticsaddr2"
							Me.str.Logisticsaddr2 = CType(value, string)
												
						Case "Logisticscsz"
							Me.str.Logisticscsz = CType(value, string)
												
						Case "Isliquid"
							Me.str.Isliquid = CType(value, string)
												
						Case "Comments"
							Me.str.Comments = CType(value, string)
												
						Case "Shiptoline1"
							Me.str.Shiptoline1 = CType(value, string)
												
						Case "Shiptoline2"
							Me.str.Shiptoline2 = CType(value, string)
												
						Case "Shiptoline3"
							Me.str.Shiptoline3 = CType(value, string)
												
						Case "Shiptoline4"
							Me.str.Shiptoline4 = CType(value, string)
												
						Case "Shipfromline1"
							Me.str.Shipfromline1 = CType(value, string)
												
						Case "Shipfromline2"
							Me.str.Shipfromline2 = CType(value, string)
												
						Case "Shipfromline3"
							Me.str.Shipfromline3 = CType(value, string)
												
						Case "Shipfromline4"
							Me.str.Shipfromline4 = CType(value, string)
												
						Case "Unnumber"
							Me.str.Unnumber = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Shipmentnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Shipmentnumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Shipmentdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Shipmentdate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Workordernumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Workordernumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Custid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Custid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Qtycontainers"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Qtycontainers = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Totalweight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Totalweight = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Stdweight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Stdweight = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Stdgallons"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Stdgallons = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Hazmatid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Hazmatid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Logisticsid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Logisticsid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Isliquid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Isliquid = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Unnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Unnumber = CType(value, Nullable(Of System.Int32))
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
		' Maps to viewRptBillOfLading.SHIPMENTNUMBER
		' </summary>
		Public Overridable Property Shipmentnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLadingMetadata.ColumnNames.Shipmentnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLadingMetadata.ColumnNames.Shipmentnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading.SHIPMENTDATE
		' </summary>
		Public Overridable Property Shipmentdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewRptBillOfLadingMetadata.ColumnNames.Shipmentdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewRptBillOfLadingMetadata.ColumnNames.Shipmentdate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading.WORKORDERNUMBER
		' </summary>
		Public Overridable Property Workordernumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLadingMetadata.ColumnNames.Workordernumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLadingMetadata.ColumnNames.Workordernumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading.CUSTID
		' </summary>
		Public Overridable Property Custid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLadingMetadata.ColumnNames.Custid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLadingMetadata.ColumnNames.Custid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading.CUSTOMERNAME
		' </summary>
		Public Overridable Property Customername As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Customername)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Customername, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading.SHIPFROMADDRESS1
		' </summary>
		Public Overridable Property Shipfromaddress1 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Shipfromaddress1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Shipfromaddress1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading.SHIPFROMADDRESS2
		' </summary>
		Public Overridable Property Shipfromaddress2 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Shipfromaddress2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Shipfromaddress2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading.SHIPFROMCITY
		' </summary>
		Public Overridable Property Shipfromcity As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Shipfromcity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Shipfromcity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading.SHIPFROMSTATEPROV
		' </summary>
		Public Overridable Property Shipfromstateprov As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Shipfromstateprov)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Shipfromstateprov, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading.SHIPFROMPOSTALCODE
		' </summary>
		Public Overridable Property Shipfrompostalcode As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Shipfrompostalcode)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Shipfrompostalcode, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading.SHIPFROMCOUNTRY
		' </summary>
		Public Overridable Property Shipfromcountry As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Shipfromcountry)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Shipfromcountry, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading.SHIPFROMPHONE
		' </summary>
		Public Overridable Property Shipfromphone As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Shipfromphone)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Shipfromphone, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading.SHIPFROMFAX
		' </summary>
		Public Overridable Property Shipfromfax As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Shipfromfax)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Shipfromfax, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading.SHIPFROMCONTACT
		' </summary>
		Public Overridable Property Shipfromcontact As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Shipfromcontact)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Shipfromcontact, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading.SHIPTOADDRESS1
		' </summary>
		Public Overridable Property Shiptoaddress1 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Shiptoaddress1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Shiptoaddress1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading.SHIPTOADDRESS2
		' </summary>
		Public Overridable Property Shiptoaddress2 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Shiptoaddress2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Shiptoaddress2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading.SHIPTOCITY
		' </summary>
		Public Overridable Property Shiptocity As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Shiptocity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Shiptocity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading.SHIPTOSTATEPROV
		' </summary>
		Public Overridable Property Shiptostateprov As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Shiptostateprov)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Shiptostateprov, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading.SHIPTOPOSTALCODE
		' </summary>
		Public Overridable Property Shiptopostalcode As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Shiptopostalcode)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Shiptopostalcode, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading.SHIPTOCOUNTRY
		' </summary>
		Public Overridable Property Shiptocountry As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Shiptocountry)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Shiptocountry, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading.SHIPTOCONTACT
		' </summary>
		Public Overridable Property Shiptocontact As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Shiptocontact)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Shiptocontact, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading.FREIGHTCARRIER
		' </summary>
		Public Overridable Property Freightcarrier As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Freightcarrier)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Freightcarrier, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading.FOB
		' </summary>
		Public Overridable Property Fob As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Fob)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Fob, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading.CUSTOMERPO
		' </summary>
		Public Overridable Property Customerpo As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Customerpo)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Customerpo, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading.PLACARDSREQUIRED
		' </summary>
		Public Overridable Property Placardsrequired As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Placardsrequired)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Placardsrequired, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading.PLACARDSSUPPLIED
		' </summary>
		Public Overridable Property Placardssupplied As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Placardssupplied)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Placardssupplied, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLadingMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLadingMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading.QTYCONTAINERS
		' </summary>
		Public Overridable Property Qtycontainers As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLadingMetadata.ColumnNames.Qtycontainers)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLadingMetadata.ColumnNames.Qtycontainers, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading.TOTALWEIGHT
		' </summary>
		Public Overridable Property Totalweight As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLadingMetadata.ColumnNames.Totalweight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLadingMetadata.ColumnNames.Totalweight, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading.STDWEIGHT
		' </summary>
		Public Overridable Property Stdweight As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLadingMetadata.ColumnNames.Stdweight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLadingMetadata.ColumnNames.Stdweight, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading.STDGALLONS
		' </summary>
		Public Overridable Property Stdgallons As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLadingMetadata.ColumnNames.Stdgallons)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLadingMetadata.ColumnNames.Stdgallons, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading.DOTDESC
		' </summary>
		Public Overridable Property Dotdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Dotdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Dotdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading.HAZMATDESC
		' </summary>
		Public Overridable Property Hazmatdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Hazmatdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Hazmatdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading.UNLINE
		' </summary>
		Public Overridable Property Unline As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Unline)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Unline, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading.CLASSRATE
		' </summary>
		Public Overridable Property Classrate As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Classrate)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Classrate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading.LD1
		' </summary>
		Public Overridable Property Ld1 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Ld1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Ld1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading.LD2
		' </summary>
		Public Overridable Property Ld2 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Ld2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Ld2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading.LD3
		' </summary>
		Public Overridable Property Ld3 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Ld3)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Ld3, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading.HAZMATID
		' </summary>
		Public Overridable Property Hazmatid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLadingMetadata.ColumnNames.Hazmatid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLadingMetadata.ColumnNames.Hazmatid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading.LOGISTICSID
		' </summary>
		Public Overridable Property Logisticsid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLadingMetadata.ColumnNames.Logisticsid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLadingMetadata.ColumnNames.Logisticsid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading.LOGISTICSNAME
		' </summary>
		Public Overridable Property Logisticsname As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Logisticsname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Logisticsname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading.LOGISTICSADDR1
		' </summary>
		Public Overridable Property Logisticsaddr1 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Logisticsaddr1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Logisticsaddr1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading.LOGISTICSADDR2
		' </summary>
		Public Overridable Property Logisticsaddr2 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Logisticsaddr2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Logisticsaddr2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading.LOGISTICSCSZ
		' </summary>
		Public Overridable Property Logisticscsz As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Logisticscsz)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Logisticscsz, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading.ISLIQUID
		' </summary>
		Public Overridable Property Isliquid As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewRptBillOfLadingMetadata.ColumnNames.Isliquid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewRptBillOfLadingMetadata.ColumnNames.Isliquid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading.COMMENTS
		' </summary>
		Public Overridable Property Comments As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Comments)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Comments, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading.SHIPTOLINE1
		' </summary>
		Public Overridable Property Shiptoline1 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Shiptoline1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Shiptoline1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading.SHIPTOLINE2
		' </summary>
		Public Overridable Property Shiptoline2 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Shiptoline2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Shiptoline2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading.SHIPTOLINE3
		' </summary>
		Public Overridable Property Shiptoline3 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Shiptoline3)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Shiptoline3, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading.SHIPTOLINE4
		' </summary>
		Public Overridable Property Shiptoline4 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Shiptoline4)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Shiptoline4, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading.SHIPFROMLINE1
		' </summary>
		Public Overridable Property Shipfromline1 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Shipfromline1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Shipfromline1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading.SHIPFROMLINE2
		' </summary>
		Public Overridable Property Shipfromline2 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Shipfromline2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Shipfromline2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading.SHIPFROMLINE3
		' </summary>
		Public Overridable Property Shipfromline3 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Shipfromline3)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Shipfromline3, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading.SHIPFROMLINE4
		' </summary>
		Public Overridable Property Shipfromline4 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Shipfromline4)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLadingMetadata.ColumnNames.Shipfromline4, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading.UNNUMBER
		' </summary>
		Public Overridable Property Unnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLadingMetadata.ColumnNames.Unnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLadingMetadata.ColumnNames.Unnumber, value)
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
		
			Public Sub New(ByVal entity As esViewRptBillOfLading)
				Me.entity = entity
			End Sub				
		
	
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
		  	
			Public Property Customername As System.String 
				Get
					Dim data_ As System.String = entity.Customername
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Customername = Nothing
					Else
						entity.Customername = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shipfromaddress1 As System.String 
				Get
					Dim data_ As System.String = entity.Shipfromaddress1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipfromaddress1 = Nothing
					Else
						entity.Shipfromaddress1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shipfromaddress2 As System.String 
				Get
					Dim data_ As System.String = entity.Shipfromaddress2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipfromaddress2 = Nothing
					Else
						entity.Shipfromaddress2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shipfromcity As System.String 
				Get
					Dim data_ As System.String = entity.Shipfromcity
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipfromcity = Nothing
					Else
						entity.Shipfromcity = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shipfromstateprov As System.String 
				Get
					Dim data_ As System.String = entity.Shipfromstateprov
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipfromstateprov = Nothing
					Else
						entity.Shipfromstateprov = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shipfrompostalcode As System.String 
				Get
					Dim data_ As System.String = entity.Shipfrompostalcode
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipfrompostalcode = Nothing
					Else
						entity.Shipfrompostalcode = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shipfromcountry As System.String 
				Get
					Dim data_ As System.String = entity.Shipfromcountry
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipfromcountry = Nothing
					Else
						entity.Shipfromcountry = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shipfromphone As System.String 
				Get
					Dim data_ As System.String = entity.Shipfromphone
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipfromphone = Nothing
					Else
						entity.Shipfromphone = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shipfromfax As System.String 
				Get
					Dim data_ As System.String = entity.Shipfromfax
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipfromfax = Nothing
					Else
						entity.Shipfromfax = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shipfromcontact As System.String 
				Get
					Dim data_ As System.String = entity.Shipfromcontact
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipfromcontact = Nothing
					Else
						entity.Shipfromcontact = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shiptoaddress1 As System.String 
				Get
					Dim data_ As System.String = entity.Shiptoaddress1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shiptoaddress1 = Nothing
					Else
						entity.Shiptoaddress1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shiptoaddress2 As System.String 
				Get
					Dim data_ As System.String = entity.Shiptoaddress2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shiptoaddress2 = Nothing
					Else
						entity.Shiptoaddress2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shiptocity As System.String 
				Get
					Dim data_ As System.String = entity.Shiptocity
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shiptocity = Nothing
					Else
						entity.Shiptocity = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shiptostateprov As System.String 
				Get
					Dim data_ As System.String = entity.Shiptostateprov
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shiptostateprov = Nothing
					Else
						entity.Shiptostateprov = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shiptopostalcode As System.String 
				Get
					Dim data_ As System.String = entity.Shiptopostalcode
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shiptopostalcode = Nothing
					Else
						entity.Shiptopostalcode = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shiptocountry As System.String 
				Get
					Dim data_ As System.String = entity.Shiptocountry
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shiptocountry = Nothing
					Else
						entity.Shiptocountry = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shiptocontact As System.String 
				Get
					Dim data_ As System.String = entity.Shiptocontact
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shiptocontact = Nothing
					Else
						entity.Shiptocontact = Convert.ToString(Value)
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
		  	
			Public Property Placardsrequired As System.String 
				Get
					Dim data_ As System.String = entity.Placardsrequired
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Placardsrequired = Nothing
					Else
						entity.Placardsrequired = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Placardssupplied As System.String 
				Get
					Dim data_ As System.String = entity.Placardssupplied
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Placardssupplied = Nothing
					Else
						entity.Placardssupplied = Convert.ToString(Value)
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
		  	
			Public Property Qtycontainers As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Qtycontainers
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qtycontainers = Nothing
					Else
						entity.Qtycontainers = Convert.ToInt32(Value)
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
		  	
			Public Property Stdweight As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Stdweight
					
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
						entity.Stdweight = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Stdgallons As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Stdgallons
					
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
						entity.Stdgallons = Convert.ToInt32(Value)
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
		  	
			Public Property Logisticsaddr1 As System.String 
				Get
					Dim data_ As System.String = entity.Logisticsaddr1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Logisticsaddr1 = Nothing
					Else
						entity.Logisticsaddr1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Logisticsaddr2 As System.String 
				Get
					Dim data_ As System.String = entity.Logisticsaddr2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Logisticsaddr2 = Nothing
					Else
						entity.Logisticsaddr2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Logisticscsz As System.String 
				Get
					Dim data_ As System.String = entity.Logisticscsz
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Logisticscsz = Nothing
					Else
						entity.Logisticscsz = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Isliquid As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Isliquid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Isliquid = Nothing
					Else
						entity.Isliquid = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property Comments As System.String 
				Get
					Dim data_ As System.String = entity.Comments
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Comments = Nothing
					Else
						entity.Comments = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shiptoline1 As System.String 
				Get
					Dim data_ As System.String = entity.Shiptoline1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shiptoline1 = Nothing
					Else
						entity.Shiptoline1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shiptoline2 As System.String 
				Get
					Dim data_ As System.String = entity.Shiptoline2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shiptoline2 = Nothing
					Else
						entity.Shiptoline2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shiptoline3 As System.String 
				Get
					Dim data_ As System.String = entity.Shiptoline3
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shiptoline3 = Nothing
					Else
						entity.Shiptoline3 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shiptoline4 As System.String 
				Get
					Dim data_ As System.String = entity.Shiptoline4
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shiptoline4 = Nothing
					Else
						entity.Shiptoline4 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shipfromline1 As System.String 
				Get
					Dim data_ As System.String = entity.Shipfromline1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipfromline1 = Nothing
					Else
						entity.Shipfromline1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shipfromline2 As System.String 
				Get
					Dim data_ As System.String = entity.Shipfromline2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipfromline2 = Nothing
					Else
						entity.Shipfromline2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shipfromline3 As System.String 
				Get
					Dim data_ As System.String = entity.Shipfromline3
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipfromline3 = Nothing
					Else
						entity.Shipfromline3 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shipfromline4 As System.String 
				Get
					Dim data_ As System.String = entity.Shipfromline4
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipfromline4 = Nothing
					Else
						entity.Shipfromline4 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Unnumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Unnumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Unnumber = Nothing
					Else
						entity.Unnumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewRptBillOfLading
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewRptBillOfLadingQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewRptBillOfLading can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewRptBillOfLadingQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRptBillOfLadingMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Shipmentnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Shipmentnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Shipmentdate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Shipmentdate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Workordernumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Workordernumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Custid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Custid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Customername As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Customername, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipfromaddress1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Shipfromaddress1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipfromaddress2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Shipfromaddress2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipfromcity As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Shipfromcity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipfromstateprov As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Shipfromstateprov, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipfrompostalcode As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Shipfrompostalcode, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipfromcountry As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Shipfromcountry, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipfromphone As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Shipfromphone, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipfromfax As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Shipfromfax, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipfromcontact As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Shipfromcontact, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shiptoaddress1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Shiptoaddress1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shiptoaddress2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Shiptoaddress2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shiptocity As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Shiptocity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shiptostateprov As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Shiptostateprov, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shiptopostalcode As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Shiptopostalcode, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shiptocountry As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Shiptocountry, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shiptocontact As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Shiptocontact, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Freightcarrier As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Freightcarrier, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Fob As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Fob, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Customerpo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Customerpo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Placardsrequired As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Placardsrequired, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Placardssupplied As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Placardssupplied, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Qtycontainers As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Qtycontainers, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Totalweight As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Totalweight, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Stdweight As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Stdweight, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Stdgallons As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Stdgallons, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Dotdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Dotdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Hazmatdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Hazmatdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Unline As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Unline, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Classrate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Classrate, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Ld1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Ld1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Ld2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Ld2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Ld3 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Ld3, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Hazmatid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Hazmatid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Logisticsid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Logisticsid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Logisticsname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Logisticsname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Logisticsaddr1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Logisticsaddr1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Logisticsaddr2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Logisticsaddr2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Logisticscsz As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Logisticscsz, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Isliquid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Isliquid, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Comments As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Comments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shiptoline1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Shiptoline1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shiptoline2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Shiptoline2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shiptoline3 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Shiptoline3, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shiptoline4 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Shiptoline4, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipfromline1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Shipfromline1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipfromline2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Shipfromline2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipfromline3 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Shipfromline3, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipfromline4 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Shipfromline4, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Unnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingMetadata.ColumnNames.Unnumber, esSystemType.Int32)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewRptBillOfLadingCollection")> _
	Partial Public Class ViewRptBillOfLadingCollection
		Inherits esViewRptBillOfLadingCollection
		Implements IEnumerable(Of ViewRptBillOfLading)
		
        Public Shared Widening Operator CType(ByVal coll As ViewRptBillOfLadingCollection) As List(Of ViewRptBillOfLading)
            Dim list As List(Of ViewRptBillOfLading) = New List(Of ViewRptBillOfLading)
            Dim emp As ViewRptBillOfLading

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRptBillOfLadingMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewRptBillOfLadingQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewRptBillOfLading(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewRptBillOfLading()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewRptBillOfLadingQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewRptBillOfLadingQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRptBillOfLadingQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewRptBillOfLading 
			Return CType(MyBase.AddNewEntity(), ViewRptBillOfLading)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewRptBillOfLading) Implements IEnumerable(Of ViewRptBillOfLading).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewRptBillOfLading)(Me)
        End Function
		
		Private _query As ViewRptBillOfLadingQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewRptBillOfLading' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewRptBillOfLading ()")> _
	<Serializable> _
	Partial Public Class ViewRptBillOfLading 
		Inherits esViewRptBillOfLading

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewRptBillOfLadingMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewRptBillOfLadingQuery

			If Me._query Is Nothing Then
				Me._query = New ViewRptBillOfLadingQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewRptBillOfLadingQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewRptBillOfLadingQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRptBillOfLadingQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewRptBillOfLadingQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewRptBillOfLadingQuery
		inherits esViewRptBillOfLadingQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewRptBillOfLadingQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewRptBillOfLadingMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Shipmentnumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Shipmentnumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Shipmentdate, 1, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Shipmentdate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Workordernumber, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Workordernumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Custid, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Custid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Customername, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Customername
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Shipfromaddress1, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Shipfromaddress1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Shipfromaddress2, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Shipfromaddress2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Shipfromcity, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Shipfromcity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Shipfromstateprov, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Shipfromstateprov
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Shipfrompostalcode, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Shipfrompostalcode
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Shipfromcountry, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Shipfromcountry
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Shipfromphone, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Shipfromphone
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Shipfromfax, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Shipfromfax
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Shipfromcontact, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Shipfromcontact
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Shiptoaddress1, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Shiptoaddress1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Shiptoaddress2, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Shiptoaddress2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Shiptocity, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Shiptocity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Shiptostateprov, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Shiptostateprov
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Shiptopostalcode, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Shiptopostalcode
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Shiptocountry, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Shiptocountry
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Shiptocontact, 20, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Shiptocontact
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Freightcarrier, 21, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Freightcarrier
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Fob, 22, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Fob
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Customerpo, 23, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Customerpo
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Placardsrequired, 24, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Placardsrequired
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Placardssupplied, 25, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Placardssupplied
			c.CharacterMaxLength = 3
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Productid, 26, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Productdesc, 27, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Qtycontainers, 28, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Qtycontainers
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Totalweight, 29, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Totalweight
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Stdweight, 30, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Stdweight
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Stdgallons, 31, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Stdgallons
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Container, 32, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Dotdesc, 33, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Dotdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Hazmatdesc, 34, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Hazmatdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Unline, 35, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Unline
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Classrate, 36, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Classrate
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Ld1, 37, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Ld1
			c.CharacterMaxLength = 500
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Ld2, 38, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Ld2
			c.CharacterMaxLength = 500
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Ld3, 39, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Ld3
			c.CharacterMaxLength = 500
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Hazmatid, 40, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Hazmatid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Logisticsid, 41, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Logisticsid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Logisticsname, 42, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Logisticsname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Logisticsaddr1, 43, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Logisticsaddr1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Logisticsaddr2, 44, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Logisticsaddr2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Logisticscsz, 45, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Logisticscsz
			c.CharacterMaxLength = 66
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Isliquid, 46, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Isliquid
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Comments, 47, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Comments
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Shiptoline1, 48, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Shiptoline1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Shiptoline2, 49, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Shiptoline2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Shiptoline3, 50, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Shiptoline3
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Shiptoline4, 51, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Shiptoline4
			c.CharacterMaxLength = 128
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Shipfromline1, 52, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Shipfromline1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Shipfromline2, 53, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Shipfromline2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Shipfromline3, 54, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Shipfromline3
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Shipfromline4, 55, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Shipfromline4
			c.CharacterMaxLength = 128
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingMetadata.ColumnNames.Unnumber, 56, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLadingMetadata.PropertyNames.Unnumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewRptBillOfLadingMetadata
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
			 Public Const Shipmentnumber As String = "SHIPMENTNUMBER"
			 Public Const Shipmentdate As String = "SHIPMENTDATE"
			 Public Const Workordernumber As String = "WORKORDERNUMBER"
			 Public Const Custid As String = "CUSTID"
			 Public Const Customername As String = "CUSTOMERNAME"
			 Public Const Shipfromaddress1 As String = "SHIPFROMADDRESS1"
			 Public Const Shipfromaddress2 As String = "SHIPFROMADDRESS2"
			 Public Const Shipfromcity As String = "SHIPFROMCITY"
			 Public Const Shipfromstateprov As String = "SHIPFROMSTATEPROV"
			 Public Const Shipfrompostalcode As String = "SHIPFROMPOSTALCODE"
			 Public Const Shipfromcountry As String = "SHIPFROMCOUNTRY"
			 Public Const Shipfromphone As String = "SHIPFROMPHONE"
			 Public Const Shipfromfax As String = "SHIPFROMFAX"
			 Public Const Shipfromcontact As String = "SHIPFROMCONTACT"
			 Public Const Shiptoaddress1 As String = "SHIPTOADDRESS1"
			 Public Const Shiptoaddress2 As String = "SHIPTOADDRESS2"
			 Public Const Shiptocity As String = "SHIPTOCITY"
			 Public Const Shiptostateprov As String = "SHIPTOSTATEPROV"
			 Public Const Shiptopostalcode As String = "SHIPTOPOSTALCODE"
			 Public Const Shiptocountry As String = "SHIPTOCOUNTRY"
			 Public Const Shiptocontact As String = "SHIPTOCONTACT"
			 Public Const Freightcarrier As String = "FREIGHTCARRIER"
			 Public Const Fob As String = "FOB"
			 Public Const Customerpo As String = "CUSTOMERPO"
			 Public Const Placardsrequired As String = "PLACARDSREQUIRED"
			 Public Const Placardssupplied As String = "PLACARDSSUPPLIED"
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Productdesc As String = "PRODUCTDESC"
			 Public Const Qtycontainers As String = "QTYCONTAINERS"
			 Public Const Totalweight As String = "TOTALWEIGHT"
			 Public Const Stdweight As String = "STDWEIGHT"
			 Public Const Stdgallons As String = "STDGALLONS"
			 Public Const Container As String = "CONTAINER"
			 Public Const Dotdesc As String = "DOTDESC"
			 Public Const Hazmatdesc As String = "HAZMATDESC"
			 Public Const Unline As String = "UNLINE"
			 Public Const Classrate As String = "CLASSRATE"
			 Public Const Ld1 As String = "LD1"
			 Public Const Ld2 As String = "LD2"
			 Public Const Ld3 As String = "LD3"
			 Public Const Hazmatid As String = "HAZMATID"
			 Public Const Logisticsid As String = "LOGISTICSID"
			 Public Const Logisticsname As String = "LOGISTICSNAME"
			 Public Const Logisticsaddr1 As String = "LOGISTICSADDR1"
			 Public Const Logisticsaddr2 As String = "LOGISTICSADDR2"
			 Public Const Logisticscsz As String = "LOGISTICSCSZ"
			 Public Const Isliquid As String = "ISLIQUID"
			 Public Const Comments As String = "COMMENTS"
			 Public Const Shiptoline1 As String = "SHIPTOLINE1"
			 Public Const Shiptoline2 As String = "SHIPTOLINE2"
			 Public Const Shiptoline3 As String = "SHIPTOLINE3"
			 Public Const Shiptoline4 As String = "SHIPTOLINE4"
			 Public Const Shipfromline1 As String = "SHIPFROMLINE1"
			 Public Const Shipfromline2 As String = "SHIPFROMLINE2"
			 Public Const Shipfromline3 As String = "SHIPFROMLINE3"
			 Public Const Shipfromline4 As String = "SHIPFROMLINE4"
			 Public Const Unnumber As String = "UNNUMBER"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Shipmentnumber As String = "Shipmentnumber"
			 Public Const Shipmentdate As String = "Shipmentdate"
			 Public Const Workordernumber As String = "Workordernumber"
			 Public Const Custid As String = "Custid"
			 Public Const Customername As String = "Customername"
			 Public Const Shipfromaddress1 As String = "Shipfromaddress1"
			 Public Const Shipfromaddress2 As String = "Shipfromaddress2"
			 Public Const Shipfromcity As String = "Shipfromcity"
			 Public Const Shipfromstateprov As String = "Shipfromstateprov"
			 Public Const Shipfrompostalcode As String = "Shipfrompostalcode"
			 Public Const Shipfromcountry As String = "Shipfromcountry"
			 Public Const Shipfromphone As String = "Shipfromphone"
			 Public Const Shipfromfax As String = "Shipfromfax"
			 Public Const Shipfromcontact As String = "Shipfromcontact"
			 Public Const Shiptoaddress1 As String = "Shiptoaddress1"
			 Public Const Shiptoaddress2 As String = "Shiptoaddress2"
			 Public Const Shiptocity As String = "Shiptocity"
			 Public Const Shiptostateprov As String = "Shiptostateprov"
			 Public Const Shiptopostalcode As String = "Shiptopostalcode"
			 Public Const Shiptocountry As String = "Shiptocountry"
			 Public Const Shiptocontact As String = "Shiptocontact"
			 Public Const Freightcarrier As String = "Freightcarrier"
			 Public Const Fob As String = "Fob"
			 Public Const Customerpo As String = "Customerpo"
			 Public Const Placardsrequired As String = "Placardsrequired"
			 Public Const Placardssupplied As String = "Placardssupplied"
			 Public Const Productid As String = "Productid"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const Qtycontainers As String = "Qtycontainers"
			 Public Const Totalweight As String = "Totalweight"
			 Public Const Stdweight As String = "Stdweight"
			 Public Const Stdgallons As String = "Stdgallons"
			 Public Const Container As String = "Container"
			 Public Const Dotdesc As String = "Dotdesc"
			 Public Const Hazmatdesc As String = "Hazmatdesc"
			 Public Const Unline As String = "Unline"
			 Public Const Classrate As String = "Classrate"
			 Public Const Ld1 As String = "Ld1"
			 Public Const Ld2 As String = "Ld2"
			 Public Const Ld3 As String = "Ld3"
			 Public Const Hazmatid As String = "Hazmatid"
			 Public Const Logisticsid As String = "Logisticsid"
			 Public Const Logisticsname As String = "Logisticsname"
			 Public Const Logisticsaddr1 As String = "Logisticsaddr1"
			 Public Const Logisticsaddr2 As String = "Logisticsaddr2"
			 Public Const Logisticscsz As String = "Logisticscsz"
			 Public Const Isliquid As String = "Isliquid"
			 Public Const Comments As String = "Comments"
			 Public Const Shiptoline1 As String = "Shiptoline1"
			 Public Const Shiptoline2 As String = "Shiptoline2"
			 Public Const Shiptoline3 As String = "Shiptoline3"
			 Public Const Shiptoline4 As String = "Shiptoline4"
			 Public Const Shipfromline1 As String = "Shipfromline1"
			 Public Const Shipfromline2 As String = "Shipfromline2"
			 Public Const Shipfromline3 As String = "Shipfromline3"
			 Public Const Shipfromline4 As String = "Shipfromline4"
			 Public Const Unnumber As String = "Unnumber"
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
            SyncLock GetType(ViewRptBillOfLadingMetadata)
			
				If ViewRptBillOfLadingMetadata.mapDelegates Is Nothing Then
					ViewRptBillOfLadingMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewRptBillOfLadingMetadata._meta Is Nothing Then
                    ViewRptBillOfLadingMetadata._meta = New ViewRptBillOfLadingMetadata()
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
				

				meta.AddTypeMap("Shipmentnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Shipmentdate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Workordernumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Custid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Customername", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipfromaddress1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipfromaddress2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipfromcity", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipfromstateprov", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipfrompostalcode", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipfromcountry", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipfromphone", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipfromfax", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipfromcontact", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shiptoaddress1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shiptoaddress2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shiptocity", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shiptostateprov", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shiptopostalcode", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shiptocountry", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shiptocontact", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Freightcarrier", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Fob", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Customerpo", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Placardsrequired", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Placardssupplied", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Productid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Qtycontainers", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Totalweight", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Stdweight", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Stdgallons", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Dotdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Hazmatdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Unline", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Classrate", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Ld1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Ld2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Ld3", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Hazmatid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Logisticsid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Logisticsname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Logisticsaddr1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Logisticsaddr2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Logisticscsz", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Isliquid", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Comments", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shiptoline1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shiptoline2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shiptoline3", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shiptoline4", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipfromline1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipfromline2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipfromline3", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipfromline4", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Unnumber", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "viewRptBillOfLading"
				meta.Destination = "viewRptBillOfLading"
				
				meta.spInsert = "proc_viewRptBillOfLadingInsert"
				meta.spUpdate = "proc_viewRptBillOfLadingUpdate"
				meta.spDelete = "proc_viewRptBillOfLadingDelete"
				meta.spLoadAll = "proc_viewRptBillOfLadingLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewRptBillOfLadingLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewRptBillOfLadingMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
