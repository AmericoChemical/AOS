'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/24/2016 7:06:08 PM
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
	MustInherit Public Class esViewRptBillOfLading2Collection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewRptBillOfLading2Collection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewRptBillOfLading2Query)
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
            Me.InitQuery(CType(query, esViewRptBillOfLading2Query))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewRptBillOfLading2) As ViewRptBillOfLading2
			Return CType(MyBase.DetachEntity(entity), ViewRptBillOfLading2)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewRptBillOfLading2) As ViewRptBillOfLading2
			Return CType(MyBase.AttachEntity(entity), ViewRptBillOfLading2)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewRptBillOfLading2Collection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewRptBillOfLading2
            Get
                Return TryCast(MyBase.Item(index), ViewRptBillOfLading2)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewRptBillOfLading2)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewRptBillOfLading2	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewRptBillOfLading2Query
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
												
						Case "Custid"
							Me.str.Custid = CType(value, string)
												
						Case "Customername"
							Me.str.Customername = CType(value, string)
												
						Case "Shipfromid"
							Me.str.Shipfromid = CType(value, string)
												
						Case "Shipfromname"
							Me.str.Shipfromname = CType(value, string)
												
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
												
						Case "Shiptoid"
							Me.str.Shiptoid = CType(value, string)
												
						Case "Shiptoname"
							Me.str.Shiptoname = CType(value, string)
												
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
												
						Case "Shiptophone"
							Me.str.Shiptophone = CType(value, string)
												
						Case "Carrierid"
							Me.str.Carrierid = CType(value, string)
												
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
												
						Case "Logisticscity"
							Me.str.Logisticscity = CType(value, string)
												
						Case "Logisticsstate"
							Me.str.Logisticsstate = CType(value, string)
												
						Case "Logisticszip"
							Me.str.Logisticszip = CType(value, string)
												
						Case "Logisticsphone"
							Me.str.Logisticsphone = CType(value, string)
												
						Case "Logisticscontact"
							Me.str.Logisticscontact = CType(value, string)
												
						Case "Hazclassnumber"
							Me.str.Hazclassnumber = CType(value, string)
												
						Case "Packagegroup"
							Me.str.Packagegroup = CType(value, string)
												
						Case "Chemicalid"
							Me.str.Chemicalid = CType(value, string)
												
						Case "Expr1"
							Me.str.Expr1 = CType(value, string)
												
						Case "Idnumber"
							Me.str.Idnumber = CType(value, string)
												
						Case "Istoxic"
							Me.str.Istoxic = CType(value, string)
												
						Case "Keepfromfreezing"
							Me.str.Keepfromfreezing = CType(value, string)
												
						Case "Rq"
							Me.str.Rq = CType(value, string)
												
						Case "ChemUnnumber"
							Me.str.ChemUnnumber = CType(value, string)
												
						Case "ChemHazclassnumber"
							Me.str.ChemHazclassnumber = CType(value, string)
												
						Case "ChemPackagegroup"
							Me.str.ChemPackagegroup = CType(value, string)
												
						Case "ChemIdnumber"
							Me.str.ChemIdnumber = CType(value, string)
												
						Case "ChemLine1"
							Me.str.ChemLine1 = CType(value, string)
												
						Case "Itemtype"
							Me.str.Itemtype = CType(value, string)
												
						Case "ChemHazmatid"
							Me.str.ChemHazmatid = CType(value, string)
					
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
						
						Case "Custid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Custid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Shipfromid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Shipfromid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Shiptoid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Shiptoid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Carrierid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Carrierid = CType(value, Nullable(Of System.Int32))
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
						
						Case "Chemicalid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Chemicalid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Istoxic"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Istoxic = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Keepfromfreezing"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Keepfromfreezing = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Rq"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Rq = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "ChemUnnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ChemUnnumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "ChemHazmatid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ChemHazmatid = CType(value, Nullable(Of System.Int32))
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
		' Maps to viewRptBillOfLading2.SHIPMENTNUMBER
		' </summary>
		Public Overridable Property Shipmentnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLading2Metadata.ColumnNames.Shipmentnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLading2Metadata.ColumnNames.Shipmentnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.SHIPMENTDATE
		' </summary>
		Public Overridable Property Shipmentdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewRptBillOfLading2Metadata.ColumnNames.Shipmentdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewRptBillOfLading2Metadata.ColumnNames.Shipmentdate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.CUSTID
		' </summary>
		Public Overridable Property Custid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLading2Metadata.ColumnNames.Custid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLading2Metadata.ColumnNames.Custid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.CUSTOMERNAME
		' </summary>
		Public Overridable Property Customername As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Customername)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Customername, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.SHIPFROMID
		' </summary>
		Public Overridable Property Shipfromid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLading2Metadata.ColumnNames.Shipfromid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLading2Metadata.ColumnNames.Shipfromid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.SHIPFROMNAME
		' </summary>
		Public Overridable Property Shipfromname As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Shipfromname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Shipfromname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.SHIPFROMADDRESS1
		' </summary>
		Public Overridable Property Shipfromaddress1 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Shipfromaddress1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Shipfromaddress1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.SHIPFROMADDRESS2
		' </summary>
		Public Overridable Property Shipfromaddress2 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Shipfromaddress2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Shipfromaddress2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.SHIPFROMCITY
		' </summary>
		Public Overridable Property Shipfromcity As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Shipfromcity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Shipfromcity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.SHIPFROMSTATEPROV
		' </summary>
		Public Overridable Property Shipfromstateprov As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Shipfromstateprov)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Shipfromstateprov, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.SHIPFROMPOSTALCODE
		' </summary>
		Public Overridable Property Shipfrompostalcode As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Shipfrompostalcode)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Shipfrompostalcode, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.SHIPFROMCOUNTRY
		' </summary>
		Public Overridable Property Shipfromcountry As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Shipfromcountry)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Shipfromcountry, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.SHIPFROMPHONE
		' </summary>
		Public Overridable Property Shipfromphone As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Shipfromphone)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Shipfromphone, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.SHIPFROMFAX
		' </summary>
		Public Overridable Property Shipfromfax As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Shipfromfax)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Shipfromfax, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.SHIPFROMCONTACT
		' </summary>
		Public Overridable Property Shipfromcontact As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Shipfromcontact)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Shipfromcontact, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.SHIPTOID
		' </summary>
		Public Overridable Property Shiptoid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLading2Metadata.ColumnNames.Shiptoid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLading2Metadata.ColumnNames.Shiptoid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.SHIPTONAME
		' </summary>
		Public Overridable Property Shiptoname As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Shiptoname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Shiptoname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.SHIPTOADDRESS1
		' </summary>
		Public Overridable Property Shiptoaddress1 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Shiptoaddress1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Shiptoaddress1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.SHIPTOADDRESS2
		' </summary>
		Public Overridable Property Shiptoaddress2 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Shiptoaddress2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Shiptoaddress2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.SHIPTOCITY
		' </summary>
		Public Overridable Property Shiptocity As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Shiptocity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Shiptocity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.SHIPTOSTATEPROV
		' </summary>
		Public Overridable Property Shiptostateprov As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Shiptostateprov)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Shiptostateprov, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.SHIPTOPOSTALCODE
		' </summary>
		Public Overridable Property Shiptopostalcode As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Shiptopostalcode)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Shiptopostalcode, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.SHIPTOCOUNTRY
		' </summary>
		Public Overridable Property Shiptocountry As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Shiptocountry)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Shiptocountry, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.SHIPTOPHONE
		' </summary>
		Public Overridable Property Shiptophone As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Shiptophone)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Shiptophone, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.CARRIERID
		' </summary>
		Public Overridable Property Carrierid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLading2Metadata.ColumnNames.Carrierid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLading2Metadata.ColumnNames.Carrierid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.FREIGHTCARRIER
		' </summary>
		Public Overridable Property Freightcarrier As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Freightcarrier)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Freightcarrier, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.FOB
		' </summary>
		Public Overridable Property Fob As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Fob)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Fob, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.CUSTOMERPO
		' </summary>
		Public Overridable Property Customerpo As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Customerpo)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Customerpo, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.PLACARDSREQUIRED
		' </summary>
		Public Overridable Property Placardsrequired As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Placardsrequired)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Placardsrequired, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.PLACARDSSUPPLIED
		' </summary>
		Public Overridable Property Placardssupplied As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Placardssupplied)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Placardssupplied, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLading2Metadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLading2Metadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.QTYCONTAINERS
		' </summary>
		Public Overridable Property Qtycontainers As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLading2Metadata.ColumnNames.Qtycontainers)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLading2Metadata.ColumnNames.Qtycontainers, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.TOTALWEIGHT
		' </summary>
		Public Overridable Property Totalweight As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLading2Metadata.ColumnNames.Totalweight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLading2Metadata.ColumnNames.Totalweight, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.STDWEIGHT
		' </summary>
		Public Overridable Property Stdweight As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLading2Metadata.ColumnNames.Stdweight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLading2Metadata.ColumnNames.Stdweight, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.STDGALLONS
		' </summary>
		Public Overridable Property Stdgallons As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLading2Metadata.ColumnNames.Stdgallons)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLading2Metadata.ColumnNames.Stdgallons, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.DOTDESC
		' </summary>
		Public Overridable Property Dotdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Dotdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Dotdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.HAZMATDESC
		' </summary>
		Public Overridable Property Hazmatdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Hazmatdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Hazmatdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.UNLINE
		' </summary>
		Public Overridable Property Unline As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Unline)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Unline, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.CLASSRATE
		' </summary>
		Public Overridable Property Classrate As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Classrate)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Classrate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.LD1
		' </summary>
		Public Overridable Property Ld1 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Ld1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Ld1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.LD2
		' </summary>
		Public Overridable Property Ld2 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Ld2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Ld2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.LD3
		' </summary>
		Public Overridable Property Ld3 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Ld3)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Ld3, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.HAZMATID
		' </summary>
		Public Overridable Property Hazmatid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLading2Metadata.ColumnNames.Hazmatid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLading2Metadata.ColumnNames.Hazmatid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.LOGISTICSID
		' </summary>
		Public Overridable Property Logisticsid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLading2Metadata.ColumnNames.Logisticsid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLading2Metadata.ColumnNames.Logisticsid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.LOGISTICSNAME
		' </summary>
		Public Overridable Property Logisticsname As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Logisticsname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Logisticsname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.LOGISTICSADDR1
		' </summary>
		Public Overridable Property Logisticsaddr1 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Logisticsaddr1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Logisticsaddr1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.LOGISTICSADDR2
		' </summary>
		Public Overridable Property Logisticsaddr2 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Logisticsaddr2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Logisticsaddr2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.LOGISTICSCSZ
		' </summary>
		Public Overridable Property Logisticscsz As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Logisticscsz)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Logisticscsz, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.ISLIQUID
		' </summary>
		Public Overridable Property Isliquid As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewRptBillOfLading2Metadata.ColumnNames.Isliquid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewRptBillOfLading2Metadata.ColumnNames.Isliquid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.COMMENTS
		' </summary>
		Public Overridable Property Comments As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Comments)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Comments, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.SHIPTOLINE1
		' </summary>
		Public Overridable Property Shiptoline1 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Shiptoline1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Shiptoline1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.SHIPTOLINE2
		' </summary>
		Public Overridable Property Shiptoline2 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Shiptoline2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Shiptoline2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.SHIPTOLINE3
		' </summary>
		Public Overridable Property Shiptoline3 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Shiptoline3)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Shiptoline3, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.SHIPTOLINE4
		' </summary>
		Public Overridable Property Shiptoline4 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Shiptoline4)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Shiptoline4, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.SHIPFROMLINE1
		' </summary>
		Public Overridable Property Shipfromline1 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Shipfromline1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Shipfromline1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.SHIPFROMLINE2
		' </summary>
		Public Overridable Property Shipfromline2 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Shipfromline2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Shipfromline2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.SHIPFROMLINE3
		' </summary>
		Public Overridable Property Shipfromline3 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Shipfromline3)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Shipfromline3, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.SHIPFROMLINE4
		' </summary>
		Public Overridable Property Shipfromline4 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Shipfromline4)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Shipfromline4, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.UNNUMBER
		' </summary>
		Public Overridable Property Unnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLading2Metadata.ColumnNames.Unnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLading2Metadata.ColumnNames.Unnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.LOGISTICSCITY
		' </summary>
		Public Overridable Property Logisticscity As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Logisticscity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Logisticscity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.LOGISTICSSTATE
		' </summary>
		Public Overridable Property Logisticsstate As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Logisticsstate)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Logisticsstate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.LOGISTICSZIP
		' </summary>
		Public Overridable Property Logisticszip As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Logisticszip)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Logisticszip, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.LOGISTICSPHONE
		' </summary>
		Public Overridable Property Logisticsphone As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Logisticsphone)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Logisticsphone, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.LOGISTICSCONTACT
		' </summary>
		Public Overridable Property Logisticscontact As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Logisticscontact)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Logisticscontact, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.HAZCLASSNUMBER
		' </summary>
		Public Overridable Property Hazclassnumber As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Hazclassnumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Hazclassnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.PACKAGEGROUP
		' </summary>
		Public Overridable Property Packagegroup As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Packagegroup)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Packagegroup, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.CHEMICALID
		' </summary>
		Public Overridable Property Chemicalid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLading2Metadata.ColumnNames.Chemicalid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLading2Metadata.ColumnNames.Chemicalid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.Expr1
		' </summary>
		Public Overridable Property Expr1 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Expr1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Expr1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.IDNUMBER
		' </summary>
		Public Overridable Property Idnumber As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Idnumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Idnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.ISTOXIC
		' </summary>
		Public Overridable Property Istoxic As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewRptBillOfLading2Metadata.ColumnNames.Istoxic)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewRptBillOfLading2Metadata.ColumnNames.Istoxic, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.KEEPFROMFREEZING
		' </summary>
		Public Overridable Property Keepfromfreezing As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewRptBillOfLading2Metadata.ColumnNames.Keepfromfreezing)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewRptBillOfLading2Metadata.ColumnNames.Keepfromfreezing, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.RQ
		' </summary>
		Public Overridable Property Rq As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewRptBillOfLading2Metadata.ColumnNames.Rq)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewRptBillOfLading2Metadata.ColumnNames.Rq, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.CHEM_UNNUMBER
		' </summary>
		Public Overridable Property ChemUnnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLading2Metadata.ColumnNames.ChemUnnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLading2Metadata.ColumnNames.ChemUnnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.CHEM_HAZCLASSNUMBER
		' </summary>
		Public Overridable Property ChemHazclassnumber As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.ChemHazclassnumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.ChemHazclassnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.CHEM_PACKAGEGROUP
		' </summary>
		Public Overridable Property ChemPackagegroup As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.ChemPackagegroup)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.ChemPackagegroup, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.CHEM_IDNUMBER
		' </summary>
		Public Overridable Property ChemIdnumber As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.ChemIdnumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.ChemIdnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.CHEM_LINE1
		' </summary>
		Public Overridable Property ChemLine1 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.ChemLine1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.ChemLine1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.ITEMTYPE
		' </summary>
		Public Overridable Property Itemtype As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Itemtype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading2Metadata.ColumnNames.Itemtype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading2.CHEM_HAZMATID
		' </summary>
		Public Overridable Property ChemHazmatid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLading2Metadata.ColumnNames.ChemHazmatid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLading2Metadata.ColumnNames.ChemHazmatid, value)
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
		
			Public Sub New(ByVal entity As esViewRptBillOfLading2)
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
		  	
			Public Property Shipfromid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Shipfromid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipfromid = Nothing
					Else
						entity.Shipfromid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shipfromname As System.String 
				Get
					Dim data_ As System.String = entity.Shipfromname
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipfromname = Nothing
					Else
						entity.Shipfromname = Convert.ToString(Value)
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
		  	
			Public Property Shiptoid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Shiptoid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shiptoid = Nothing
					Else
						entity.Shiptoid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shiptoname As System.String 
				Get
					Dim data_ As System.String = entity.Shiptoname
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shiptoname = Nothing
					Else
						entity.Shiptoname = Convert.ToString(Value)
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
		  	
			Public Property Shiptophone As System.String 
				Get
					Dim data_ As System.String = entity.Shiptophone
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shiptophone = Nothing
					Else
						entity.Shiptophone = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Carrierid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Carrierid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Carrierid = Nothing
					Else
						entity.Carrierid = Convert.ToInt32(Value)
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
		  	
			Public Property Logisticscity As System.String 
				Get
					Dim data_ As System.String = entity.Logisticscity
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Logisticscity = Nothing
					Else
						entity.Logisticscity = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Logisticsstate As System.String 
				Get
					Dim data_ As System.String = entity.Logisticsstate
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Logisticsstate = Nothing
					Else
						entity.Logisticsstate = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Logisticszip As System.String 
				Get
					Dim data_ As System.String = entity.Logisticszip
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Logisticszip = Nothing
					Else
						entity.Logisticszip = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Logisticsphone As System.String 
				Get
					Dim data_ As System.String = entity.Logisticsphone
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Logisticsphone = Nothing
					Else
						entity.Logisticsphone = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Logisticscontact As System.String 
				Get
					Dim data_ As System.String = entity.Logisticscontact
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Logisticscontact = Nothing
					Else
						entity.Logisticscontact = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Hazclassnumber As System.String 
				Get
					Dim data_ As System.String = entity.Hazclassnumber
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Hazclassnumber = Nothing
					Else
						entity.Hazclassnumber = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Packagegroup As System.String 
				Get
					Dim data_ As System.String = entity.Packagegroup
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Packagegroup = Nothing
					Else
						entity.Packagegroup = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Chemicalid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Chemicalid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Chemicalid = Nothing
					Else
						entity.Chemicalid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Expr1 As System.String 
				Get
					Dim data_ As System.String = entity.Expr1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Expr1 = Nothing
					Else
						entity.Expr1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Idnumber As System.String 
				Get
					Dim data_ As System.String = entity.Idnumber
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Idnumber = Nothing
					Else
						entity.Idnumber = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Istoxic As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Istoxic
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Istoxic = Nothing
					Else
						entity.Istoxic = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property Keepfromfreezing As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Keepfromfreezing
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Keepfromfreezing = Nothing
					Else
						entity.Keepfromfreezing = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property Rq As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Rq
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Rq = Nothing
					Else
						entity.Rq = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property ChemUnnumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.ChemUnnumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ChemUnnumber = Nothing
					Else
						entity.ChemUnnumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property ChemHazclassnumber As System.String 
				Get
					Dim data_ As System.String = entity.ChemHazclassnumber
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ChemHazclassnumber = Nothing
					Else
						entity.ChemHazclassnumber = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ChemPackagegroup As System.String 
				Get
					Dim data_ As System.String = entity.ChemPackagegroup
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ChemPackagegroup = Nothing
					Else
						entity.ChemPackagegroup = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ChemIdnumber As System.String 
				Get
					Dim data_ As System.String = entity.ChemIdnumber
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ChemIdnumber = Nothing
					Else
						entity.ChemIdnumber = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ChemLine1 As System.String 
				Get
					Dim data_ As System.String = entity.ChemLine1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ChemLine1 = Nothing
					Else
						entity.ChemLine1 = Convert.ToString(Value)
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
		  	
			Public Property ChemHazmatid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.ChemHazmatid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ChemHazmatid = Nothing
					Else
						entity.ChemHazmatid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewRptBillOfLading2
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewRptBillOfLading2Query)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewRptBillOfLading2 can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewRptBillOfLading2Query 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRptBillOfLading2Metadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Shipmentnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Shipmentnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Shipmentdate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Shipmentdate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Custid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Custid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Customername As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Customername, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipfromid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Shipfromid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Shipfromname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Shipfromname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipfromaddress1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Shipfromaddress1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipfromaddress2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Shipfromaddress2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipfromcity As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Shipfromcity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipfromstateprov As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Shipfromstateprov, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipfrompostalcode As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Shipfrompostalcode, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipfromcountry As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Shipfromcountry, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipfromphone As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Shipfromphone, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipfromfax As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Shipfromfax, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipfromcontact As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Shipfromcontact, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shiptoid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Shiptoid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Shiptoname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Shiptoname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shiptoaddress1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Shiptoaddress1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shiptoaddress2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Shiptoaddress2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shiptocity As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Shiptocity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shiptostateprov As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Shiptostateprov, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shiptopostalcode As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Shiptopostalcode, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shiptocountry As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Shiptocountry, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shiptophone As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Shiptophone, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Carrierid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Carrierid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Freightcarrier As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Freightcarrier, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Fob As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Fob, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Customerpo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Customerpo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Placardsrequired As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Placardsrequired, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Placardssupplied As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Placardssupplied, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Qtycontainers As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Qtycontainers, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Totalweight As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Totalweight, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Stdweight As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Stdweight, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Stdgallons As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Stdgallons, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Dotdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Dotdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Hazmatdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Hazmatdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Unline As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Unline, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Classrate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Classrate, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Ld1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Ld1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Ld2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Ld2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Ld3 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Ld3, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Hazmatid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Hazmatid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Logisticsid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Logisticsid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Logisticsname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Logisticsname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Logisticsaddr1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Logisticsaddr1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Logisticsaddr2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Logisticsaddr2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Logisticscsz As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Logisticscsz, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Isliquid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Isliquid, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Comments As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Comments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shiptoline1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Shiptoline1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shiptoline2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Shiptoline2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shiptoline3 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Shiptoline3, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shiptoline4 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Shiptoline4, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipfromline1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Shipfromline1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipfromline2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Shipfromline2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipfromline3 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Shipfromline3, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipfromline4 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Shipfromline4, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Unnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Unnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Logisticscity As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Logisticscity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Logisticsstate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Logisticsstate, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Logisticszip As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Logisticszip, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Logisticsphone As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Logisticsphone, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Logisticscontact As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Logisticscontact, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Hazclassnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Hazclassnumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Packagegroup As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Packagegroup, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Chemicalid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Chemicalid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Expr1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Expr1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Idnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Idnumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Istoxic As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Istoxic, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Keepfromfreezing As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Keepfromfreezing, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Rq As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Rq, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property ChemUnnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.ChemUnnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ChemHazclassnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.ChemHazclassnumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ChemPackagegroup As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.ChemPackagegroup, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ChemIdnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.ChemIdnumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ChemLine1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.ChemLine1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Itemtype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.Itemtype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ChemHazmatid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading2Metadata.ColumnNames.ChemHazmatid, esSystemType.Int32)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewRptBillOfLading2Collection")> _
	Partial Public Class ViewRptBillOfLading2Collection
		Inherits esViewRptBillOfLading2Collection
		Implements IEnumerable(Of ViewRptBillOfLading2)
		
        Public Shared Widening Operator CType(ByVal coll As ViewRptBillOfLading2Collection) As List(Of ViewRptBillOfLading2)
            Dim list As List(Of ViewRptBillOfLading2) = New List(Of ViewRptBillOfLading2)
            Dim emp As ViewRptBillOfLading2

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRptBillOfLading2Metadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewRptBillOfLading2Query()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewRptBillOfLading2(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewRptBillOfLading2()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewRptBillOfLading2Query 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewRptBillOfLading2Query()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRptBillOfLading2Query) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewRptBillOfLading2 
			Return CType(MyBase.AddNewEntity(), ViewRptBillOfLading2)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewRptBillOfLading2) Implements IEnumerable(Of ViewRptBillOfLading2).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewRptBillOfLading2)(Me)
        End Function
		
		Private _query As ViewRptBillOfLading2Query

	End Class
	


	' <summary>
	' Encapsulates the 'viewRptBillOfLading2' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewRptBillOfLading2 ()")> _
	<Serializable> _
	Partial Public Class ViewRptBillOfLading2 
		Inherits esViewRptBillOfLading2

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewRptBillOfLading2Metadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewRptBillOfLading2Query

			If Me._query Is Nothing Then
				Me._query = New ViewRptBillOfLading2Query()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewRptBillOfLading2Query
			Get

				If Me._query Is Nothing then
					Me._query = New ViewRptBillOfLading2Query()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRptBillOfLading2Query) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewRptBillOfLading2Query

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewRptBillOfLading2Query
		inherits esViewRptBillOfLading2Query
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewRptBillOfLading2Query"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewRptBillOfLading2Metadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Shipmentnumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Shipmentnumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Shipmentdate, 1, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Shipmentdate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Custid, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Custid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Customername, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Customername
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Shipfromid, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Shipfromid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Shipfromname, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Shipfromname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Shipfromaddress1, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Shipfromaddress1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Shipfromaddress2, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Shipfromaddress2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Shipfromcity, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Shipfromcity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Shipfromstateprov, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Shipfromstateprov
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Shipfrompostalcode, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Shipfrompostalcode
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Shipfromcountry, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Shipfromcountry
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Shipfromphone, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Shipfromphone
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Shipfromfax, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Shipfromfax
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Shipfromcontact, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Shipfromcontact
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Shiptoid, 15, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Shiptoid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Shiptoname, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Shiptoname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Shiptoaddress1, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Shiptoaddress1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Shiptoaddress2, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Shiptoaddress2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Shiptocity, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Shiptocity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Shiptostateprov, 20, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Shiptostateprov
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Shiptopostalcode, 21, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Shiptopostalcode
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Shiptocountry, 22, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Shiptocountry
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Shiptophone, 23, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Shiptophone
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Carrierid, 24, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Carrierid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Freightcarrier, 25, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Freightcarrier
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Fob, 26, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Fob
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Customerpo, 27, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Customerpo
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Placardsrequired, 28, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Placardsrequired
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Placardssupplied, 29, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Placardssupplied
			c.CharacterMaxLength = 3
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Productid, 30, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Productid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Productdesc, 31, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Qtycontainers, 32, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Qtycontainers
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Totalweight, 33, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Totalweight
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Stdweight, 34, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Stdweight
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Stdgallons, 35, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Stdgallons
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Container, 36, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Dotdesc, 37, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Dotdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Hazmatdesc, 38, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Hazmatdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Unline, 39, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Unline
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Classrate, 40, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Classrate
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Ld1, 41, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Ld1
			c.CharacterMaxLength = 500
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Ld2, 42, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Ld2
			c.CharacterMaxLength = 500
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Ld3, 43, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Ld3
			c.CharacterMaxLength = 500
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Hazmatid, 44, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Hazmatid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Logisticsid, 45, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Logisticsid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Logisticsname, 46, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Logisticsname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Logisticsaddr1, 47, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Logisticsaddr1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Logisticsaddr2, 48, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Logisticsaddr2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Logisticscsz, 49, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Logisticscsz
			c.CharacterMaxLength = 66
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Isliquid, 50, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Isliquid
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Comments, 51, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Comments
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Shiptoline1, 52, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Shiptoline1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Shiptoline2, 53, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Shiptoline2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Shiptoline3, 54, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Shiptoline3
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Shiptoline4, 55, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Shiptoline4
			c.CharacterMaxLength = 128
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Shipfromline1, 56, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Shipfromline1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Shipfromline2, 57, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Shipfromline2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Shipfromline3, 58, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Shipfromline3
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Shipfromline4, 59, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Shipfromline4
			c.CharacterMaxLength = 128
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Unnumber, 60, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Unnumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Logisticscity, 61, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Logisticscity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Logisticsstate, 62, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Logisticsstate
			c.CharacterMaxLength = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Logisticszip, 63, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Logisticszip
			c.CharacterMaxLength = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Logisticsphone, 64, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Logisticsphone
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Logisticscontact, 65, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Logisticscontact
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Hazclassnumber, 66, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Hazclassnumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Packagegroup, 67, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Packagegroup
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Chemicalid, 68, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Chemicalid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Expr1, 69, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Expr1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Idnumber, 70, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Idnumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Istoxic, 71, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Istoxic
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Keepfromfreezing, 72, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Keepfromfreezing
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Rq, 73, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Rq
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.ChemUnnumber, 74, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.ChemUnnumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.ChemHazclassnumber, 75, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.ChemHazclassnumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.ChemPackagegroup, 76, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.ChemPackagegroup
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.ChemIdnumber, 77, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.ChemIdnumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.ChemLine1, 78, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.ChemLine1
			c.CharacterMaxLength = 401
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.Itemtype, 79, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.Itemtype
			c.CharacterMaxLength = 1
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading2Metadata.ColumnNames.ChemHazmatid, 80, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLading2Metadata.PropertyNames.ChemHazmatid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewRptBillOfLading2Metadata
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
			 Public Const Custid As String = "CUSTID"
			 Public Const Customername As String = "CUSTOMERNAME"
			 Public Const Shipfromid As String = "SHIPFROMID"
			 Public Const Shipfromname As String = "SHIPFROMNAME"
			 Public Const Shipfromaddress1 As String = "SHIPFROMADDRESS1"
			 Public Const Shipfromaddress2 As String = "SHIPFROMADDRESS2"
			 Public Const Shipfromcity As String = "SHIPFROMCITY"
			 Public Const Shipfromstateprov As String = "SHIPFROMSTATEPROV"
			 Public Const Shipfrompostalcode As String = "SHIPFROMPOSTALCODE"
			 Public Const Shipfromcountry As String = "SHIPFROMCOUNTRY"
			 Public Const Shipfromphone As String = "SHIPFROMPHONE"
			 Public Const Shipfromfax As String = "SHIPFROMFAX"
			 Public Const Shipfromcontact As String = "SHIPFROMCONTACT"
			 Public Const Shiptoid As String = "SHIPTOID"
			 Public Const Shiptoname As String = "SHIPTONAME"
			 Public Const Shiptoaddress1 As String = "SHIPTOADDRESS1"
			 Public Const Shiptoaddress2 As String = "SHIPTOADDRESS2"
			 Public Const Shiptocity As String = "SHIPTOCITY"
			 Public Const Shiptostateprov As String = "SHIPTOSTATEPROV"
			 Public Const Shiptopostalcode As String = "SHIPTOPOSTALCODE"
			 Public Const Shiptocountry As String = "SHIPTOCOUNTRY"
			 Public Const Shiptophone As String = "SHIPTOPHONE"
			 Public Const Carrierid As String = "CARRIERID"
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
			 Public Const Logisticscity As String = "LOGISTICSCITY"
			 Public Const Logisticsstate As String = "LOGISTICSSTATE"
			 Public Const Logisticszip As String = "LOGISTICSZIP"
			 Public Const Logisticsphone As String = "LOGISTICSPHONE"
			 Public Const Logisticscontact As String = "LOGISTICSCONTACT"
			 Public Const Hazclassnumber As String = "HAZCLASSNUMBER"
			 Public Const Packagegroup As String = "PACKAGEGROUP"
			 Public Const Chemicalid As String = "CHEMICALID"
			 Public Const Expr1 As String = "Expr1"
			 Public Const Idnumber As String = "IDNUMBER"
			 Public Const Istoxic As String = "ISTOXIC"
			 Public Const Keepfromfreezing As String = "KEEPFROMFREEZING"
			 Public Const Rq As String = "RQ"
			 Public Const ChemUnnumber As String = "CHEM_UNNUMBER"
			 Public Const ChemHazclassnumber As String = "CHEM_HAZCLASSNUMBER"
			 Public Const ChemPackagegroup As String = "CHEM_PACKAGEGROUP"
			 Public Const ChemIdnumber As String = "CHEM_IDNUMBER"
			 Public Const ChemLine1 As String = "CHEM_LINE1"
			 Public Const Itemtype As String = "ITEMTYPE"
			 Public Const ChemHazmatid As String = "CHEM_HAZMATID"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Shipmentnumber As String = "Shipmentnumber"
			 Public Const Shipmentdate As String = "Shipmentdate"
			 Public Const Custid As String = "Custid"
			 Public Const Customername As String = "Customername"
			 Public Const Shipfromid As String = "Shipfromid"
			 Public Const Shipfromname As String = "Shipfromname"
			 Public Const Shipfromaddress1 As String = "Shipfromaddress1"
			 Public Const Shipfromaddress2 As String = "Shipfromaddress2"
			 Public Const Shipfromcity As String = "Shipfromcity"
			 Public Const Shipfromstateprov As String = "Shipfromstateprov"
			 Public Const Shipfrompostalcode As String = "Shipfrompostalcode"
			 Public Const Shipfromcountry As String = "Shipfromcountry"
			 Public Const Shipfromphone As String = "Shipfromphone"
			 Public Const Shipfromfax As String = "Shipfromfax"
			 Public Const Shipfromcontact As String = "Shipfromcontact"
			 Public Const Shiptoid As String = "Shiptoid"
			 Public Const Shiptoname As String = "Shiptoname"
			 Public Const Shiptoaddress1 As String = "Shiptoaddress1"
			 Public Const Shiptoaddress2 As String = "Shiptoaddress2"
			 Public Const Shiptocity As String = "Shiptocity"
			 Public Const Shiptostateprov As String = "Shiptostateprov"
			 Public Const Shiptopostalcode As String = "Shiptopostalcode"
			 Public Const Shiptocountry As String = "Shiptocountry"
			 Public Const Shiptophone As String = "Shiptophone"
			 Public Const Carrierid As String = "Carrierid"
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
			 Public Const Logisticscity As String = "Logisticscity"
			 Public Const Logisticsstate As String = "Logisticsstate"
			 Public Const Logisticszip As String = "Logisticszip"
			 Public Const Logisticsphone As String = "Logisticsphone"
			 Public Const Logisticscontact As String = "Logisticscontact"
			 Public Const Hazclassnumber As String = "Hazclassnumber"
			 Public Const Packagegroup As String = "Packagegroup"
			 Public Const Chemicalid As String = "Chemicalid"
			 Public Const Expr1 As String = "Expr1"
			 Public Const Idnumber As String = "Idnumber"
			 Public Const Istoxic As String = "Istoxic"
			 Public Const Keepfromfreezing As String = "Keepfromfreezing"
			 Public Const Rq As String = "Rq"
			 Public Const ChemUnnumber As String = "ChemUnnumber"
			 Public Const ChemHazclassnumber As String = "ChemHazclassnumber"
			 Public Const ChemPackagegroup As String = "ChemPackagegroup"
			 Public Const ChemIdnumber As String = "ChemIdnumber"
			 Public Const ChemLine1 As String = "ChemLine1"
			 Public Const Itemtype As String = "Itemtype"
			 Public Const ChemHazmatid As String = "ChemHazmatid"
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
            SyncLock GetType(ViewRptBillOfLading2Metadata)
			
				If ViewRptBillOfLading2Metadata.mapDelegates Is Nothing Then
					ViewRptBillOfLading2Metadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewRptBillOfLading2Metadata._meta Is Nothing Then
                    ViewRptBillOfLading2Metadata._meta = New ViewRptBillOfLading2Metadata()
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
				meta.AddTypeMap("Custid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Customername", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipfromid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Shipfromname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipfromaddress1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipfromaddress2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipfromcity", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipfromstateprov", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipfrompostalcode", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipfromcountry", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipfromphone", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipfromfax", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipfromcontact", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shiptoid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Shiptoname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shiptoaddress1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shiptoaddress2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shiptocity", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shiptostateprov", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shiptopostalcode", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shiptocountry", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shiptophone", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Carrierid", new esTypeMap("int", "System.Int32"))
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
				meta.AddTypeMap("Logisticscity", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Logisticsstate", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Logisticszip", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Logisticsphone", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Logisticscontact", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Hazclassnumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Packagegroup", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Chemicalid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Expr1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Idnumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Istoxic", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Keepfromfreezing", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Rq", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("ChemUnnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ChemHazclassnumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ChemPackagegroup", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ChemIdnumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ChemLine1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Itemtype", new esTypeMap("nchar", "System.String"))
				meta.AddTypeMap("ChemHazmatid", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "viewRptBillOfLading2"
				meta.Destination = "viewRptBillOfLading2"
				
				meta.spInsert = "proc_viewRptBillOfLading2Insert"
				meta.spUpdate = "proc_viewRptBillOfLading2Update"
				meta.spDelete = "proc_viewRptBillOfLading2Delete"
				meta.spLoadAll = "proc_viewRptBillOfLading2LoadAll"
				meta.spLoadByPrimaryKey = "proc_viewRptBillOfLading2LoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewRptBillOfLading2Metadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
