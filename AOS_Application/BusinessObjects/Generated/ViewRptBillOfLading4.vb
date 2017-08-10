'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/18/2016 10:12:13 AM
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
	MustInherit Public Class esViewRptBillOfLading4Collection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewRptBillOfLading4Collection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewRptBillOfLading4Query)
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
            Me.InitQuery(CType(query, esViewRptBillOfLading4Query))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewRptBillOfLading4) As ViewRptBillOfLading4
			Return CType(MyBase.DetachEntity(entity), ViewRptBillOfLading4)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewRptBillOfLading4) As ViewRptBillOfLading4
			Return CType(MyBase.AttachEntity(entity), ViewRptBillOfLading4)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewRptBillOfLading4Collection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewRptBillOfLading4
            Get
                Return TryCast(MyBase.Item(index), ViewRptBillOfLading4)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewRptBillOfLading4)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewRptBillOfLading4	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewRptBillOfLading4Query
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
												
						Case "Logisticsid"
							Me.str.Logisticsid = CType(value, string)
												
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
												
						Case "Keepfromfreezing"
							Me.str.Keepfromfreezing = CType(value, string)
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Ld1"
							Me.str.Ld1 = CType(value, string)
												
						Case "Ld2"
							Me.str.Ld2 = CType(value, string)
												
						Case "Ld3"
							Me.str.Ld3 = CType(value, string)
												
						Case "Itemtype"
							Me.str.Itemtype = CType(value, string)
												
						Case "Qtycontainers"
							Me.str.Qtycontainers = CType(value, string)
												
						Case "Totalweight"
							Me.str.Totalweight = CType(value, string)
												
						Case "Logisticsname"
							Me.str.Logisticsname = CType(value, string)
												
						Case "Logisticsaddr1"
							Me.str.Logisticsaddr1 = CType(value, string)
												
						Case "Logisticsaddr2"
							Me.str.Logisticsaddr2 = CType(value, string)
												
						Case "Logisticscsz"
							Me.str.Logisticscsz = CType(value, string)
												
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
												
						Case "Productdesc"
							Me.str.Productdesc = CType(value, string)
												
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
												
						Case "Hazmatid"
							Me.str.Hazmatid = CType(value, string)
												
						Case "Rq"
							Me.str.Rq = CType(value, string)
												
						Case "Isliquid"
							Me.str.Isliquid = CType(value, string)
												
						Case "Unnumber"
							Me.str.Unnumber = CType(value, string)
												
						Case "Hazclassnumber"
							Me.str.Hazclassnumber = CType(value, string)
												
						Case "Packagegroup"
							Me.str.Packagegroup = CType(value, string)
												
						Case "Chemicalid"
							Me.str.Chemicalid = CType(value, string)
												
						Case "Idnumber"
							Me.str.Idnumber = CType(value, string)
												
						Case "Volumeunits"
							Me.str.Volumeunits = CType(value, string)
												
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
												
						Case "ChemHazmatid"
							Me.str.ChemHazmatid = CType(value, string)
												
						Case "Istoxic"
							Me.str.Istoxic = CType(value, string)
												
						Case "Usenonregdot"
							Me.str.Usenonregdot = CType(value, string)
												
						Case "ChemDotdesc"
							Me.str.ChemDotdesc = CType(value, string)
												
						Case "ChemHazmatdesc"
							Me.str.ChemHazmatdesc = CType(value, string)
												
						Case "ChemUnline"
							Me.str.ChemUnline = CType(value, string)
												
						Case "Health"
							Me.str.Health = CType(value, string)
												
						Case "Fire"
							Me.str.Fire = CType(value, string)
												
						Case "Reactivity"
							Me.str.Reactivity = CType(value, string)
												
						Case "Personalprotection"
							Me.str.Personalprotection = CType(value, string)
					
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
						
						Case "Logisticsid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Logisticsid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Keepfromfreezing"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Keepfromfreezing = CType(value, Nullable(Of System.Boolean))
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
						
						Case "Rq"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Rq = CType(value, Nullable(Of System.Boolean))
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
						
						Case "Volumeunits"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Volumeunits = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "ChemUnnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ChemUnnumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "ChemHazmatid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ChemHazmatid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Istoxic"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Istoxic = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Usenonregdot"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Usenonregdot = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Health"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Health = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Fire"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Fire = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Reactivity"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Reactivity = CType(value, Nullable(Of System.Int32))
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
		' Maps to viewRptBillOfLading4.SHIPMENTNUMBER
		' </summary>
		Public Overridable Property Shipmentnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLading4Metadata.ColumnNames.Shipmentnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLading4Metadata.ColumnNames.Shipmentnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.SHIPMENTDATE
		' </summary>
		Public Overridable Property Shipmentdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewRptBillOfLading4Metadata.ColumnNames.Shipmentdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewRptBillOfLading4Metadata.ColumnNames.Shipmentdate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.CUSTID
		' </summary>
		Public Overridable Property Custid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLading4Metadata.ColumnNames.Custid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLading4Metadata.ColumnNames.Custid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.CUSTOMERNAME
		' </summary>
		Public Overridable Property Customername As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Customername)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Customername, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.SHIPFROMID
		' </summary>
		Public Overridable Property Shipfromid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLading4Metadata.ColumnNames.Shipfromid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLading4Metadata.ColumnNames.Shipfromid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.SHIPFROMNAME
		' </summary>
		Public Overridable Property Shipfromname As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Shipfromname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Shipfromname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.SHIPFROMADDRESS1
		' </summary>
		Public Overridable Property Shipfromaddress1 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Shipfromaddress1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Shipfromaddress1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.SHIPFROMADDRESS2
		' </summary>
		Public Overridable Property Shipfromaddress2 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Shipfromaddress2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Shipfromaddress2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.SHIPFROMCITY
		' </summary>
		Public Overridable Property Shipfromcity As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Shipfromcity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Shipfromcity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.SHIPFROMSTATEPROV
		' </summary>
		Public Overridable Property Shipfromstateprov As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Shipfromstateprov)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Shipfromstateprov, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.SHIPFROMPOSTALCODE
		' </summary>
		Public Overridable Property Shipfrompostalcode As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Shipfrompostalcode)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Shipfrompostalcode, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.SHIPFROMCOUNTRY
		' </summary>
		Public Overridable Property Shipfromcountry As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Shipfromcountry)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Shipfromcountry, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.SHIPFROMPHONE
		' </summary>
		Public Overridable Property Shipfromphone As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Shipfromphone)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Shipfromphone, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.SHIPFROMFAX
		' </summary>
		Public Overridable Property Shipfromfax As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Shipfromfax)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Shipfromfax, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.SHIPFROMCONTACT
		' </summary>
		Public Overridable Property Shipfromcontact As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Shipfromcontact)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Shipfromcontact, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.SHIPTOID
		' </summary>
		Public Overridable Property Shiptoid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLading4Metadata.ColumnNames.Shiptoid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLading4Metadata.ColumnNames.Shiptoid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.SHIPTONAME
		' </summary>
		Public Overridable Property Shiptoname As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Shiptoname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Shiptoname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.SHIPTOADDRESS1
		' </summary>
		Public Overridable Property Shiptoaddress1 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Shiptoaddress1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Shiptoaddress1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.SHIPTOADDRESS2
		' </summary>
		Public Overridable Property Shiptoaddress2 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Shiptoaddress2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Shiptoaddress2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.SHIPTOCITY
		' </summary>
		Public Overridable Property Shiptocity As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Shiptocity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Shiptocity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.SHIPTOSTATEPROV
		' </summary>
		Public Overridable Property Shiptostateprov As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Shiptostateprov)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Shiptostateprov, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.SHIPTOPOSTALCODE
		' </summary>
		Public Overridable Property Shiptopostalcode As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Shiptopostalcode)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Shiptopostalcode, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.SHIPTOCOUNTRY
		' </summary>
		Public Overridable Property Shiptocountry As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Shiptocountry)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Shiptocountry, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.SHIPTOPHONE
		' </summary>
		Public Overridable Property Shiptophone As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Shiptophone)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Shiptophone, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.CARRIERID
		' </summary>
		Public Overridable Property Carrierid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLading4Metadata.ColumnNames.Carrierid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLading4Metadata.ColumnNames.Carrierid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.FREIGHTCARRIER
		' </summary>
		Public Overridable Property Freightcarrier As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Freightcarrier)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Freightcarrier, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.FOB
		' </summary>
		Public Overridable Property Fob As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Fob)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Fob, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.CUSTOMERPO
		' </summary>
		Public Overridable Property Customerpo As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Customerpo)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Customerpo, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.PLACARDSREQUIRED
		' </summary>
		Public Overridable Property Placardsrequired As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Placardsrequired)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Placardsrequired, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.PLACARDSSUPPLIED
		' </summary>
		Public Overridable Property Placardssupplied As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Placardssupplied)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Placardssupplied, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.LOGISTICSID
		' </summary>
		Public Overridable Property Logisticsid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLading4Metadata.ColumnNames.Logisticsid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLading4Metadata.ColumnNames.Logisticsid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.COMMENTS
		' </summary>
		Public Overridable Property Comments As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Comments)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Comments, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.SHIPTOLINE1
		' </summary>
		Public Overridable Property Shiptoline1 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Shiptoline1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Shiptoline1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.SHIPTOLINE2
		' </summary>
		Public Overridable Property Shiptoline2 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Shiptoline2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Shiptoline2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.SHIPTOLINE3
		' </summary>
		Public Overridable Property Shiptoline3 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Shiptoline3)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Shiptoline3, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.SHIPTOLINE4
		' </summary>
		Public Overridable Property Shiptoline4 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Shiptoline4)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Shiptoline4, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.SHIPFROMLINE1
		' </summary>
		Public Overridable Property Shipfromline1 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Shipfromline1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Shipfromline1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.SHIPFROMLINE2
		' </summary>
		Public Overridable Property Shipfromline2 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Shipfromline2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Shipfromline2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.SHIPFROMLINE3
		' </summary>
		Public Overridable Property Shipfromline3 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Shipfromline3)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Shipfromline3, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.SHIPFROMLINE4
		' </summary>
		Public Overridable Property Shipfromline4 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Shipfromline4)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Shipfromline4, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.KEEPFROMFREEZING
		' </summary>
		Public Overridable Property Keepfromfreezing As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewRptBillOfLading4Metadata.ColumnNames.Keepfromfreezing)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewRptBillOfLading4Metadata.ColumnNames.Keepfromfreezing, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLading4Metadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLading4Metadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.LD1
		' </summary>
		Public Overridable Property Ld1 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Ld1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Ld1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.LD2
		' </summary>
		Public Overridable Property Ld2 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Ld2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Ld2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.LD3
		' </summary>
		Public Overridable Property Ld3 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Ld3)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Ld3, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.ITEMTYPE
		' </summary>
		Public Overridable Property Itemtype As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Itemtype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Itemtype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.QTYCONTAINERS
		' </summary>
		Public Overridable Property Qtycontainers As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLading4Metadata.ColumnNames.Qtycontainers)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLading4Metadata.ColumnNames.Qtycontainers, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.TOTALWEIGHT
		' </summary>
		Public Overridable Property Totalweight As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLading4Metadata.ColumnNames.Totalweight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLading4Metadata.ColumnNames.Totalweight, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.LOGISTICSNAME
		' </summary>
		Public Overridable Property Logisticsname As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Logisticsname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Logisticsname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.LOGISTICSADDR1
		' </summary>
		Public Overridable Property Logisticsaddr1 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Logisticsaddr1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Logisticsaddr1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.LOGISTICSADDR2
		' </summary>
		Public Overridable Property Logisticsaddr2 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Logisticsaddr2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Logisticsaddr2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.LOGISTICSCSZ
		' </summary>
		Public Overridable Property Logisticscsz As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Logisticscsz)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Logisticscsz, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.LOGISTICSCITY
		' </summary>
		Public Overridable Property Logisticscity As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Logisticscity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Logisticscity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.LOGISTICSSTATE
		' </summary>
		Public Overridable Property Logisticsstate As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Logisticsstate)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Logisticsstate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.LOGISTICSZIP
		' </summary>
		Public Overridable Property Logisticszip As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Logisticszip)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Logisticszip, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.LOGISTICSPHONE
		' </summary>
		Public Overridable Property Logisticsphone As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Logisticsphone)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Logisticsphone, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.LOGISTICSCONTACT
		' </summary>
		Public Overridable Property Logisticscontact As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Logisticscontact)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Logisticscontact, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.STDWEIGHT
		' </summary>
		Public Overridable Property Stdweight As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLading4Metadata.ColumnNames.Stdweight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLading4Metadata.ColumnNames.Stdweight, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.STDGALLONS
		' </summary>
		Public Overridable Property Stdgallons As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLading4Metadata.ColumnNames.Stdgallons)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLading4Metadata.ColumnNames.Stdgallons, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.DOTDESC
		' </summary>
		Public Overridable Property Dotdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Dotdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Dotdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.HAZMATDESC
		' </summary>
		Public Overridable Property Hazmatdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Hazmatdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Hazmatdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.UNLINE
		' </summary>
		Public Overridable Property Unline As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Unline)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Unline, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.CLASSRATE
		' </summary>
		Public Overridable Property Classrate As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Classrate)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Classrate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.HAZMATID
		' </summary>
		Public Overridable Property Hazmatid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLading4Metadata.ColumnNames.Hazmatid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLading4Metadata.ColumnNames.Hazmatid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.RQ
		' </summary>
		Public Overridable Property Rq As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewRptBillOfLading4Metadata.ColumnNames.Rq)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewRptBillOfLading4Metadata.ColumnNames.Rq, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.ISLIQUID
		' </summary>
		Public Overridable Property Isliquid As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewRptBillOfLading4Metadata.ColumnNames.Isliquid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewRptBillOfLading4Metadata.ColumnNames.Isliquid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.UNNUMBER
		' </summary>
		Public Overridable Property Unnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLading4Metadata.ColumnNames.Unnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLading4Metadata.ColumnNames.Unnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.HAZCLASSNUMBER
		' </summary>
		Public Overridable Property Hazclassnumber As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Hazclassnumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Hazclassnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.PACKAGEGROUP
		' </summary>
		Public Overridable Property Packagegroup As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Packagegroup)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Packagegroup, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.CHEMICALID
		' </summary>
		Public Overridable Property Chemicalid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLading4Metadata.ColumnNames.Chemicalid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLading4Metadata.ColumnNames.Chemicalid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.IDNUMBER
		' </summary>
		Public Overridable Property Idnumber As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Idnumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Idnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.VOLUMEUNITS
		' </summary>
		Public Overridable Property Volumeunits As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptBillOfLading4Metadata.ColumnNames.Volumeunits)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptBillOfLading4Metadata.ColumnNames.Volumeunits, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.CHEM_UNNUMBER
		' </summary>
		Public Overridable Property ChemUnnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLading4Metadata.ColumnNames.ChemUnnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLading4Metadata.ColumnNames.ChemUnnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.CHEM_HAZCLASSNUMBER
		' </summary>
		Public Overridable Property ChemHazclassnumber As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.ChemHazclassnumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.ChemHazclassnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.CHEM_PACKAGEGROUP
		' </summary>
		Public Overridable Property ChemPackagegroup As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.ChemPackagegroup)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.ChemPackagegroup, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.CHEM_IDNUMBER
		' </summary>
		Public Overridable Property ChemIdnumber As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.ChemIdnumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.ChemIdnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.CHEM_LINE1
		' </summary>
		Public Overridable Property ChemLine1 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.ChemLine1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.ChemLine1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.CHEM_HAZMATID
		' </summary>
		Public Overridable Property ChemHazmatid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLading4Metadata.ColumnNames.ChemHazmatid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLading4Metadata.ColumnNames.ChemHazmatid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.ISTOXIC
		' </summary>
		Public Overridable Property Istoxic As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewRptBillOfLading4Metadata.ColumnNames.Istoxic)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewRptBillOfLading4Metadata.ColumnNames.Istoxic, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.USENONREGDOT
		' </summary>
		Public Overridable Property Usenonregdot As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewRptBillOfLading4Metadata.ColumnNames.Usenonregdot)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewRptBillOfLading4Metadata.ColumnNames.Usenonregdot, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.CHEM_DOTDESC
		' </summary>
		Public Overridable Property ChemDotdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.ChemDotdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.ChemDotdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.CHEM_HAZMATDESC
		' </summary>
		Public Overridable Property ChemHazmatdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.ChemHazmatdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.ChemHazmatdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.CHEM_UNLINE
		' </summary>
		Public Overridable Property ChemUnline As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.ChemUnline)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.ChemUnline, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.HEALTH
		' </summary>
		Public Overridable Property Health As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLading4Metadata.ColumnNames.Health)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLading4Metadata.ColumnNames.Health, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.FIRE
		' </summary>
		Public Overridable Property Fire As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLading4Metadata.ColumnNames.Fire)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLading4Metadata.ColumnNames.Fire, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.REACTIVITY
		' </summary>
		Public Overridable Property Reactivity As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLading4Metadata.ColumnNames.Reactivity)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLading4Metadata.ColumnNames.Reactivity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading4.PERSONALPROTECTION
		' </summary>
		Public Overridable Property Personalprotection As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Personalprotection)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading4Metadata.ColumnNames.Personalprotection, value)
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
		
			Public Sub New(ByVal entity As esViewRptBillOfLading4)
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
		  	
			Public Property Volumeunits As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Volumeunits
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Volumeunits = Nothing
					Else
						entity.Volumeunits = Convert.ToDecimal(Value)
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
		  	
			Public Property Usenonregdot As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Usenonregdot
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Usenonregdot = Nothing
					Else
						entity.Usenonregdot = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property ChemDotdesc As System.String 
				Get
					Dim data_ As System.String = entity.ChemDotdesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ChemDotdesc = Nothing
					Else
						entity.ChemDotdesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ChemHazmatdesc As System.String 
				Get
					Dim data_ As System.String = entity.ChemHazmatdesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ChemHazmatdesc = Nothing
					Else
						entity.ChemHazmatdesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ChemUnline As System.String 
				Get
					Dim data_ As System.String = entity.ChemUnline
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ChemUnline = Nothing
					Else
						entity.ChemUnline = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Health As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Health
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Health = Nothing
					Else
						entity.Health = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Fire As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Fire
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Fire = Nothing
					Else
						entity.Fire = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Reactivity As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Reactivity
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Reactivity = Nothing
					Else
						entity.Reactivity = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Personalprotection As System.String 
				Get
					Dim data_ As System.String = entity.Personalprotection
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Personalprotection = Nothing
					Else
						entity.Personalprotection = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewRptBillOfLading4
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewRptBillOfLading4Query)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewRptBillOfLading4 can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewRptBillOfLading4Query 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRptBillOfLading4Metadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Shipmentnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Shipmentnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Shipmentdate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Shipmentdate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Custid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Custid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Customername As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Customername, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipfromid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Shipfromid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Shipfromname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Shipfromname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipfromaddress1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Shipfromaddress1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipfromaddress2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Shipfromaddress2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipfromcity As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Shipfromcity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipfromstateprov As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Shipfromstateprov, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipfrompostalcode As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Shipfrompostalcode, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipfromcountry As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Shipfromcountry, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipfromphone As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Shipfromphone, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipfromfax As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Shipfromfax, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipfromcontact As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Shipfromcontact, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shiptoid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Shiptoid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Shiptoname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Shiptoname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shiptoaddress1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Shiptoaddress1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shiptoaddress2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Shiptoaddress2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shiptocity As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Shiptocity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shiptostateprov As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Shiptostateprov, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shiptopostalcode As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Shiptopostalcode, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shiptocountry As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Shiptocountry, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shiptophone As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Shiptophone, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Carrierid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Carrierid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Freightcarrier As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Freightcarrier, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Fob As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Fob, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Customerpo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Customerpo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Placardsrequired As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Placardsrequired, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Placardssupplied As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Placardssupplied, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Logisticsid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Logisticsid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Comments As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Comments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shiptoline1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Shiptoline1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shiptoline2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Shiptoline2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shiptoline3 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Shiptoline3, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shiptoline4 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Shiptoline4, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipfromline1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Shipfromline1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipfromline2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Shipfromline2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipfromline3 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Shipfromline3, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipfromline4 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Shipfromline4, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Keepfromfreezing As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Keepfromfreezing, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Ld1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Ld1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Ld2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Ld2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Ld3 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Ld3, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Itemtype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Itemtype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Qtycontainers As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Qtycontainers, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Totalweight As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Totalweight, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Logisticsname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Logisticsname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Logisticsaddr1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Logisticsaddr1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Logisticsaddr2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Logisticsaddr2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Logisticscsz As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Logisticscsz, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Logisticscity As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Logisticscity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Logisticsstate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Logisticsstate, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Logisticszip As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Logisticszip, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Logisticsphone As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Logisticsphone, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Logisticscontact As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Logisticscontact, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Stdweight As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Stdweight, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Stdgallons As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Stdgallons, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Dotdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Dotdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Hazmatdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Hazmatdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Unline As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Unline, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Classrate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Classrate, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Hazmatid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Hazmatid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Rq As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Rq, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Isliquid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Isliquid, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Unnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Unnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Hazclassnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Hazclassnumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Packagegroup As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Packagegroup, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Chemicalid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Chemicalid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Idnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Idnumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Volumeunits As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Volumeunits, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property ChemUnnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.ChemUnnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ChemHazclassnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.ChemHazclassnumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ChemPackagegroup As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.ChemPackagegroup, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ChemIdnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.ChemIdnumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ChemLine1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.ChemLine1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ChemHazmatid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.ChemHazmatid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Istoxic As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Istoxic, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Usenonregdot As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Usenonregdot, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property ChemDotdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.ChemDotdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ChemHazmatdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.ChemHazmatdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ChemUnline As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.ChemUnline, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Health As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Health, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Fire As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Fire, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Reactivity As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Reactivity, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Personalprotection As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading4Metadata.ColumnNames.Personalprotection, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewRptBillOfLading4Collection")> _
	Partial Public Class ViewRptBillOfLading4Collection
		Inherits esViewRptBillOfLading4Collection
		Implements IEnumerable(Of ViewRptBillOfLading4)
		
        Public Shared Widening Operator CType(ByVal coll As ViewRptBillOfLading4Collection) As List(Of ViewRptBillOfLading4)
            Dim list As List(Of ViewRptBillOfLading4) = New List(Of ViewRptBillOfLading4)
            Dim emp As ViewRptBillOfLading4

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRptBillOfLading4Metadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewRptBillOfLading4Query()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewRptBillOfLading4(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewRptBillOfLading4()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewRptBillOfLading4Query 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewRptBillOfLading4Query()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRptBillOfLading4Query) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewRptBillOfLading4 
			Return CType(MyBase.AddNewEntity(), ViewRptBillOfLading4)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewRptBillOfLading4) Implements IEnumerable(Of ViewRptBillOfLading4).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewRptBillOfLading4)(Me)
        End Function
		
		Private _query As ViewRptBillOfLading4Query

	End Class
	


	' <summary>
	' Encapsulates the 'viewRptBillOfLading4' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewRptBillOfLading4 ()")> _
	<Serializable> _
	Partial Public Class ViewRptBillOfLading4 
		Inherits esViewRptBillOfLading4

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewRptBillOfLading4Metadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewRptBillOfLading4Query

			If Me._query Is Nothing Then
				Me._query = New ViewRptBillOfLading4Query()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewRptBillOfLading4Query
			Get

				If Me._query Is Nothing then
					Me._query = New ViewRptBillOfLading4Query()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRptBillOfLading4Query) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewRptBillOfLading4Query

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewRptBillOfLading4Query
		inherits esViewRptBillOfLading4Query
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewRptBillOfLading4Query"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewRptBillOfLading4Metadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Shipmentnumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Shipmentnumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Shipmentdate, 1, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Shipmentdate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Custid, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Custid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Customername, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Customername
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Shipfromid, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Shipfromid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Shipfromname, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Shipfromname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Shipfromaddress1, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Shipfromaddress1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Shipfromaddress2, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Shipfromaddress2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Shipfromcity, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Shipfromcity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Shipfromstateprov, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Shipfromstateprov
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Shipfrompostalcode, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Shipfrompostalcode
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Shipfromcountry, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Shipfromcountry
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Shipfromphone, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Shipfromphone
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Shipfromfax, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Shipfromfax
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Shipfromcontact, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Shipfromcontact
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Shiptoid, 15, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Shiptoid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Shiptoname, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Shiptoname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Shiptoaddress1, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Shiptoaddress1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Shiptoaddress2, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Shiptoaddress2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Shiptocity, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Shiptocity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Shiptostateprov, 20, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Shiptostateprov
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Shiptopostalcode, 21, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Shiptopostalcode
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Shiptocountry, 22, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Shiptocountry
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Shiptophone, 23, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Shiptophone
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Carrierid, 24, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Carrierid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Freightcarrier, 25, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Freightcarrier
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Fob, 26, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Fob
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Customerpo, 27, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Customerpo
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Placardsrequired, 28, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Placardsrequired
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Placardssupplied, 29, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Placardssupplied
			c.CharacterMaxLength = 3
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Logisticsid, 30, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Logisticsid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Comments, 31, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Comments
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Shiptoline1, 32, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Shiptoline1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Shiptoline2, 33, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Shiptoline2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Shiptoline3, 34, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Shiptoline3
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Shiptoline4, 35, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Shiptoline4
			c.CharacterMaxLength = 128
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Shipfromline1, 36, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Shipfromline1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Shipfromline2, 37, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Shipfromline2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Shipfromline3, 38, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Shipfromline3
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Shipfromline4, 39, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Shipfromline4
			c.CharacterMaxLength = 128
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Keepfromfreezing, 40, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Keepfromfreezing
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Productid, 41, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Productid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Ld1, 42, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Ld1
			c.CharacterMaxLength = 500
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Ld2, 43, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Ld2
			c.CharacterMaxLength = 500
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Ld3, 44, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Ld3
			c.CharacterMaxLength = 500
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Itemtype, 45, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Itemtype
			c.CharacterMaxLength = 1
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Qtycontainers, 46, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Qtycontainers
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Totalweight, 47, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Totalweight
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Logisticsname, 48, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Logisticsname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Logisticsaddr1, 49, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Logisticsaddr1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Logisticsaddr2, 50, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Logisticsaddr2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Logisticscsz, 51, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Logisticscsz
			c.CharacterMaxLength = 66
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Logisticscity, 52, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Logisticscity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Logisticsstate, 53, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Logisticsstate
			c.CharacterMaxLength = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Logisticszip, 54, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Logisticszip
			c.CharacterMaxLength = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Logisticsphone, 55, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Logisticsphone
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Logisticscontact, 56, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Logisticscontact
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Productdesc, 57, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Stdweight, 58, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Stdweight
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Stdgallons, 59, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Stdgallons
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Container, 60, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Dotdesc, 61, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Dotdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Hazmatdesc, 62, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Hazmatdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Unline, 63, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Unline
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Classrate, 64, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Classrate
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Hazmatid, 65, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Hazmatid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Rq, 66, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Rq
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Isliquid, 67, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Isliquid
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Unnumber, 68, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Unnumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Hazclassnumber, 69, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Hazclassnumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Packagegroup, 70, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Packagegroup
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Chemicalid, 71, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Chemicalid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Idnumber, 72, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Idnumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Volumeunits, 73, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Volumeunits
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.ChemUnnumber, 74, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.ChemUnnumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.ChemHazclassnumber, 75, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.ChemHazclassnumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.ChemPackagegroup, 76, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.ChemPackagegroup
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.ChemIdnumber, 77, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.ChemIdnumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.ChemLine1, 78, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.ChemLine1
			c.CharacterMaxLength = 401
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.ChemHazmatid, 79, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.ChemHazmatid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Istoxic, 80, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Istoxic
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Usenonregdot, 81, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Usenonregdot
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.ChemDotdesc, 82, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.ChemDotdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.ChemHazmatdesc, 83, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.ChemHazmatdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.ChemUnline, 84, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.ChemUnline
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Health, 85, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Health
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Fire, 86, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Fire
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Reactivity, 87, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Reactivity
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading4Metadata.ColumnNames.Personalprotection, 88, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading4Metadata.PropertyNames.Personalprotection
			c.CharacterMaxLength = 3
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewRptBillOfLading4Metadata
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
			 Public Const Logisticsid As String = "LOGISTICSID"
			 Public Const Comments As String = "COMMENTS"
			 Public Const Shiptoline1 As String = "SHIPTOLINE1"
			 Public Const Shiptoline2 As String = "SHIPTOLINE2"
			 Public Const Shiptoline3 As String = "SHIPTOLINE3"
			 Public Const Shiptoline4 As String = "SHIPTOLINE4"
			 Public Const Shipfromline1 As String = "SHIPFROMLINE1"
			 Public Const Shipfromline2 As String = "SHIPFROMLINE2"
			 Public Const Shipfromline3 As String = "SHIPFROMLINE3"
			 Public Const Shipfromline4 As String = "SHIPFROMLINE4"
			 Public Const Keepfromfreezing As String = "KEEPFROMFREEZING"
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Ld1 As String = "LD1"
			 Public Const Ld2 As String = "LD2"
			 Public Const Ld3 As String = "LD3"
			 Public Const Itemtype As String = "ITEMTYPE"
			 Public Const Qtycontainers As String = "QTYCONTAINERS"
			 Public Const Totalweight As String = "TOTALWEIGHT"
			 Public Const Logisticsname As String = "LOGISTICSNAME"
			 Public Const Logisticsaddr1 As String = "LOGISTICSADDR1"
			 Public Const Logisticsaddr2 As String = "LOGISTICSADDR2"
			 Public Const Logisticscsz As String = "LOGISTICSCSZ"
			 Public Const Logisticscity As String = "LOGISTICSCITY"
			 Public Const Logisticsstate As String = "LOGISTICSSTATE"
			 Public Const Logisticszip As String = "LOGISTICSZIP"
			 Public Const Logisticsphone As String = "LOGISTICSPHONE"
			 Public Const Logisticscontact As String = "LOGISTICSCONTACT"
			 Public Const Productdesc As String = "PRODUCTDESC"
			 Public Const Stdweight As String = "STDWEIGHT"
			 Public Const Stdgallons As String = "STDGALLONS"
			 Public Const Container As String = "CONTAINER"
			 Public Const Dotdesc As String = "DOTDESC"
			 Public Const Hazmatdesc As String = "HAZMATDESC"
			 Public Const Unline As String = "UNLINE"
			 Public Const Classrate As String = "CLASSRATE"
			 Public Const Hazmatid As String = "HAZMATID"
			 Public Const Rq As String = "RQ"
			 Public Const Isliquid As String = "ISLIQUID"
			 Public Const Unnumber As String = "UNNUMBER"
			 Public Const Hazclassnumber As String = "HAZCLASSNUMBER"
			 Public Const Packagegroup As String = "PACKAGEGROUP"
			 Public Const Chemicalid As String = "CHEMICALID"
			 Public Const Idnumber As String = "IDNUMBER"
			 Public Const Volumeunits As String = "VOLUMEUNITS"
			 Public Const ChemUnnumber As String = "CHEM_UNNUMBER"
			 Public Const ChemHazclassnumber As String = "CHEM_HAZCLASSNUMBER"
			 Public Const ChemPackagegroup As String = "CHEM_PACKAGEGROUP"
			 Public Const ChemIdnumber As String = "CHEM_IDNUMBER"
			 Public Const ChemLine1 As String = "CHEM_LINE1"
			 Public Const ChemHazmatid As String = "CHEM_HAZMATID"
			 Public Const Istoxic As String = "ISTOXIC"
			 Public Const Usenonregdot As String = "USENONREGDOT"
			 Public Const ChemDotdesc As String = "CHEM_DOTDESC"
			 Public Const ChemHazmatdesc As String = "CHEM_HAZMATDESC"
			 Public Const ChemUnline As String = "CHEM_UNLINE"
			 Public Const Health As String = "HEALTH"
			 Public Const Fire As String = "FIRE"
			 Public Const Reactivity As String = "REACTIVITY"
			 Public Const Personalprotection As String = "PERSONALPROTECTION"
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
			 Public Const Logisticsid As String = "Logisticsid"
			 Public Const Comments As String = "Comments"
			 Public Const Shiptoline1 As String = "Shiptoline1"
			 Public Const Shiptoline2 As String = "Shiptoline2"
			 Public Const Shiptoline3 As String = "Shiptoline3"
			 Public Const Shiptoline4 As String = "Shiptoline4"
			 Public Const Shipfromline1 As String = "Shipfromline1"
			 Public Const Shipfromline2 As String = "Shipfromline2"
			 Public Const Shipfromline3 As String = "Shipfromline3"
			 Public Const Shipfromline4 As String = "Shipfromline4"
			 Public Const Keepfromfreezing As String = "Keepfromfreezing"
			 Public Const Productid As String = "Productid"
			 Public Const Ld1 As String = "Ld1"
			 Public Const Ld2 As String = "Ld2"
			 Public Const Ld3 As String = "Ld3"
			 Public Const Itemtype As String = "Itemtype"
			 Public Const Qtycontainers As String = "Qtycontainers"
			 Public Const Totalweight As String = "Totalweight"
			 Public Const Logisticsname As String = "Logisticsname"
			 Public Const Logisticsaddr1 As String = "Logisticsaddr1"
			 Public Const Logisticsaddr2 As String = "Logisticsaddr2"
			 Public Const Logisticscsz As String = "Logisticscsz"
			 Public Const Logisticscity As String = "Logisticscity"
			 Public Const Logisticsstate As String = "Logisticsstate"
			 Public Const Logisticszip As String = "Logisticszip"
			 Public Const Logisticsphone As String = "Logisticsphone"
			 Public Const Logisticscontact As String = "Logisticscontact"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const Stdweight As String = "Stdweight"
			 Public Const Stdgallons As String = "Stdgallons"
			 Public Const Container As String = "Container"
			 Public Const Dotdesc As String = "Dotdesc"
			 Public Const Hazmatdesc As String = "Hazmatdesc"
			 Public Const Unline As String = "Unline"
			 Public Const Classrate As String = "Classrate"
			 Public Const Hazmatid As String = "Hazmatid"
			 Public Const Rq As String = "Rq"
			 Public Const Isliquid As String = "Isliquid"
			 Public Const Unnumber As String = "Unnumber"
			 Public Const Hazclassnumber As String = "Hazclassnumber"
			 Public Const Packagegroup As String = "Packagegroup"
			 Public Const Chemicalid As String = "Chemicalid"
			 Public Const Idnumber As String = "Idnumber"
			 Public Const Volumeunits As String = "Volumeunits"
			 Public Const ChemUnnumber As String = "ChemUnnumber"
			 Public Const ChemHazclassnumber As String = "ChemHazclassnumber"
			 Public Const ChemPackagegroup As String = "ChemPackagegroup"
			 Public Const ChemIdnumber As String = "ChemIdnumber"
			 Public Const ChemLine1 As String = "ChemLine1"
			 Public Const ChemHazmatid As String = "ChemHazmatid"
			 Public Const Istoxic As String = "Istoxic"
			 Public Const Usenonregdot As String = "Usenonregdot"
			 Public Const ChemDotdesc As String = "ChemDotdesc"
			 Public Const ChemHazmatdesc As String = "ChemHazmatdesc"
			 Public Const ChemUnline As String = "ChemUnline"
			 Public Const Health As String = "Health"
			 Public Const Fire As String = "Fire"
			 Public Const Reactivity As String = "Reactivity"
			 Public Const Personalprotection As String = "Personalprotection"
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
            SyncLock GetType(ViewRptBillOfLading4Metadata)
			
				If ViewRptBillOfLading4Metadata.mapDelegates Is Nothing Then
					ViewRptBillOfLading4Metadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewRptBillOfLading4Metadata._meta Is Nothing Then
                    ViewRptBillOfLading4Metadata._meta = New ViewRptBillOfLading4Metadata()
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
				meta.AddTypeMap("Logisticsid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Comments", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shiptoline1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shiptoline2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shiptoline3", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shiptoline4", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipfromline1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipfromline2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipfromline3", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipfromline4", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Keepfromfreezing", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Productid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Ld1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Ld2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Ld3", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Itemtype", new esTypeMap("nchar", "System.String"))
				meta.AddTypeMap("Qtycontainers", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Totalweight", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Logisticsname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Logisticsaddr1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Logisticsaddr2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Logisticscsz", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Logisticscity", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Logisticsstate", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Logisticszip", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Logisticsphone", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Logisticscontact", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Productdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Stdweight", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Stdgallons", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Dotdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Hazmatdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Unline", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Classrate", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Hazmatid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Rq", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Isliquid", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Unnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Hazclassnumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Packagegroup", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Chemicalid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Idnumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Volumeunits", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("ChemUnnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ChemHazclassnumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ChemPackagegroup", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ChemIdnumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ChemLine1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ChemHazmatid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Istoxic", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Usenonregdot", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("ChemDotdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ChemHazmatdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ChemUnline", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Health", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Fire", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Reactivity", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Personalprotection", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewRptBillOfLading4"
				meta.Destination = "viewRptBillOfLading4"
				
				meta.spInsert = "proc_viewRptBillOfLading4Insert"
				meta.spUpdate = "proc_viewRptBillOfLading4Update"
				meta.spDelete = "proc_viewRptBillOfLading4Delete"
				meta.spLoadAll = "proc_viewRptBillOfLading4LoadAll"
				meta.spLoadByPrimaryKey = "proc_viewRptBillOfLading4LoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewRptBillOfLading4Metadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
