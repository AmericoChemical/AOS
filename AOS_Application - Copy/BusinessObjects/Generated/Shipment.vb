'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/12/2015 1:09:17 PM
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
	MustInherit Public Class esShipmentCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ShipmentCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esShipmentQuery)
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
            Me.InitQuery(CType(query, esShipmentQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Shipment) As Shipment
			Return CType(MyBase.DetachEntity(entity), Shipment)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Shipment) As Shipment
			Return CType(MyBase.AttachEntity(entity), Shipment)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ShipmentCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Shipment
            Get
                Return TryCast(MyBase.Item(index), Shipment)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Shipment)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esShipment	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esShipmentQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal shipmentnumber As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(shipmentnumber)
			Else
				Return LoadByPrimaryKeyStoredProcedure(shipmentnumber)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal shipmentnumber As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(shipmentnumber)
			Else
				Return LoadByPrimaryKeyStoredProcedure(shipmentnumber)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal shipmentnumber As System.Int32) As Boolean
		
			Dim query As esShipmentQuery = Me.GetDynamicQuery()
			query.Where(query.Shipmentnumber.Equal(shipmentnumber))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal shipmentnumber As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("SHIPMENTNUMBER", shipmentnumber)
			
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
												
						Case "Shiptocontact"
							Me.str.Shiptocontact = CType(value, string)
												
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
												
						Case "Shipmentstatus"
							Me.str.Shipmentstatus = CType(value, string)
												
						Case "Logisticsid"
							Me.str.Logisticsid = CType(value, string)
												
						Case "Comments"
							Me.str.Comments = CType(value, string)
												
						Case "Createdby"
							Me.str.Createdby = CType(value, string)
												
						Case "Createdtime"
							Me.str.Createdtime = CType(value, string)
												
						Case "Modifyby"
							Me.str.Modifyby = CType(value, string)
												
						Case "Modifytime"
							Me.str.Modifytime = CType(value, string)
												
						Case "Keepfromfreezing"
							Me.str.Keepfromfreezing = CType(value, string)
					
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
						
						Case "Createdtime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Createdtime = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Modifytime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Modifytime = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Keepfromfreezing"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Keepfromfreezing = CType(value, Nullable(Of System.Boolean))
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
		' Maps to SHIPMENT.SHIPMENTNUMBER
		' </summary>
		Public Overridable Property Shipmentnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ShipmentMetadata.ColumnNames.Shipmentnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ShipmentMetadata.ColumnNames.Shipmentnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENT.SHIPMENTDATE
		' </summary>
		Public Overridable Property Shipmentdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ShipmentMetadata.ColumnNames.Shipmentdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ShipmentMetadata.ColumnNames.Shipmentdate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENT.WORKORDERNUMBER
		' </summary>
		Public Overridable Property Workordernumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ShipmentMetadata.ColumnNames.Workordernumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ShipmentMetadata.ColumnNames.Workordernumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENT.CUSTID
		' </summary>
		Public Overridable Property Custid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ShipmentMetadata.ColumnNames.Custid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ShipmentMetadata.ColumnNames.Custid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENT.CUSTOMERNAME
		' </summary>
		Public Overridable Property Customername As System.String
			Get
				Return MyBase.GetSystemString(ShipmentMetadata.ColumnNames.Customername)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ShipmentMetadata.ColumnNames.Customername, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENT.SHIPFROMID
		' </summary>
		Public Overridable Property Shipfromid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ShipmentMetadata.ColumnNames.Shipfromid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ShipmentMetadata.ColumnNames.Shipfromid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENT.SHIPFROMNAME
		' </summary>
		Public Overridable Property Shipfromname As System.String
			Get
				Return MyBase.GetSystemString(ShipmentMetadata.ColumnNames.Shipfromname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ShipmentMetadata.ColumnNames.Shipfromname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENT.SHIPFROMADDRESS1
		' </summary>
		Public Overridable Property Shipfromaddress1 As System.String
			Get
				Return MyBase.GetSystemString(ShipmentMetadata.ColumnNames.Shipfromaddress1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ShipmentMetadata.ColumnNames.Shipfromaddress1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENT.SHIPFROMADDRESS2
		' </summary>
		Public Overridable Property Shipfromaddress2 As System.String
			Get
				Return MyBase.GetSystemString(ShipmentMetadata.ColumnNames.Shipfromaddress2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ShipmentMetadata.ColumnNames.Shipfromaddress2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENT.SHIPFROMCITY
		' </summary>
		Public Overridable Property Shipfromcity As System.String
			Get
				Return MyBase.GetSystemString(ShipmentMetadata.ColumnNames.Shipfromcity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ShipmentMetadata.ColumnNames.Shipfromcity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENT.SHIPFROMSTATEPROV
		' </summary>
		Public Overridable Property Shipfromstateprov As System.String
			Get
				Return MyBase.GetSystemString(ShipmentMetadata.ColumnNames.Shipfromstateprov)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ShipmentMetadata.ColumnNames.Shipfromstateprov, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENT.SHIPFROMPOSTALCODE
		' </summary>
		Public Overridable Property Shipfrompostalcode As System.String
			Get
				Return MyBase.GetSystemString(ShipmentMetadata.ColumnNames.Shipfrompostalcode)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ShipmentMetadata.ColumnNames.Shipfrompostalcode, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENT.SHIPFROMCOUNTRY
		' </summary>
		Public Overridable Property Shipfromcountry As System.String
			Get
				Return MyBase.GetSystemString(ShipmentMetadata.ColumnNames.Shipfromcountry)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ShipmentMetadata.ColumnNames.Shipfromcountry, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENT.SHIPFROMPHONE
		' </summary>
		Public Overridable Property Shipfromphone As System.String
			Get
				Return MyBase.GetSystemString(ShipmentMetadata.ColumnNames.Shipfromphone)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ShipmentMetadata.ColumnNames.Shipfromphone, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENT.SHIPFROMFAX
		' </summary>
		Public Overridable Property Shipfromfax As System.String
			Get
				Return MyBase.GetSystemString(ShipmentMetadata.ColumnNames.Shipfromfax)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ShipmentMetadata.ColumnNames.Shipfromfax, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENT.SHIPFROMCONTACT
		' </summary>
		Public Overridable Property Shipfromcontact As System.String
			Get
				Return MyBase.GetSystemString(ShipmentMetadata.ColumnNames.Shipfromcontact)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ShipmentMetadata.ColumnNames.Shipfromcontact, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENT.SHIPTOID
		' </summary>
		Public Overridable Property Shiptoid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ShipmentMetadata.ColumnNames.Shiptoid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ShipmentMetadata.ColumnNames.Shiptoid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENT.SHIPTONAME
		' </summary>
		Public Overridable Property Shiptoname As System.String
			Get
				Return MyBase.GetSystemString(ShipmentMetadata.ColumnNames.Shiptoname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ShipmentMetadata.ColumnNames.Shiptoname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENT.SHIPTOADDRESS1
		' </summary>
		Public Overridable Property Shiptoaddress1 As System.String
			Get
				Return MyBase.GetSystemString(ShipmentMetadata.ColumnNames.Shiptoaddress1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ShipmentMetadata.ColumnNames.Shiptoaddress1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENT.SHIPTOADDRESS2
		' </summary>
		Public Overridable Property Shiptoaddress2 As System.String
			Get
				Return MyBase.GetSystemString(ShipmentMetadata.ColumnNames.Shiptoaddress2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ShipmentMetadata.ColumnNames.Shiptoaddress2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENT.SHIPTOCITY
		' </summary>
		Public Overridable Property Shiptocity As System.String
			Get
				Return MyBase.GetSystemString(ShipmentMetadata.ColumnNames.Shiptocity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ShipmentMetadata.ColumnNames.Shiptocity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENT.SHIPTOSTATEPROV
		' </summary>
		Public Overridable Property Shiptostateprov As System.String
			Get
				Return MyBase.GetSystemString(ShipmentMetadata.ColumnNames.Shiptostateprov)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ShipmentMetadata.ColumnNames.Shiptostateprov, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENT.SHIPTOPOSTALCODE
		' </summary>
		Public Overridable Property Shiptopostalcode As System.String
			Get
				Return MyBase.GetSystemString(ShipmentMetadata.ColumnNames.Shiptopostalcode)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ShipmentMetadata.ColumnNames.Shiptopostalcode, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENT.SHIPTOCOUNTRY
		' </summary>
		Public Overridable Property Shiptocountry As System.String
			Get
				Return MyBase.GetSystemString(ShipmentMetadata.ColumnNames.Shiptocountry)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ShipmentMetadata.ColumnNames.Shiptocountry, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENT.SHIPTOCONTACT
		' </summary>
		Public Overridable Property Shiptocontact As System.String
			Get
				Return MyBase.GetSystemString(ShipmentMetadata.ColumnNames.Shiptocontact)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ShipmentMetadata.ColumnNames.Shiptocontact, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENT.SHIPTOPHONE
		' </summary>
		Public Overridable Property Shiptophone As System.String
			Get
				Return MyBase.GetSystemString(ShipmentMetadata.ColumnNames.Shiptophone)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ShipmentMetadata.ColumnNames.Shiptophone, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENT.CARRIERID
		' </summary>
		Public Overridable Property Carrierid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ShipmentMetadata.ColumnNames.Carrierid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ShipmentMetadata.ColumnNames.Carrierid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENT.FREIGHTCARRIER
		' </summary>
		Public Overridable Property Freightcarrier As System.String
			Get
				Return MyBase.GetSystemString(ShipmentMetadata.ColumnNames.Freightcarrier)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ShipmentMetadata.ColumnNames.Freightcarrier, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENT.FOB
		' </summary>
		Public Overridable Property Fob As System.String
			Get
				Return MyBase.GetSystemString(ShipmentMetadata.ColumnNames.Fob)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ShipmentMetadata.ColumnNames.Fob, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENT.CUSTOMERPO
		' </summary>
		Public Overridable Property Customerpo As System.String
			Get
				Return MyBase.GetSystemString(ShipmentMetadata.ColumnNames.Customerpo)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ShipmentMetadata.ColumnNames.Customerpo, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENT.PLACARDSREQUIRED
		' </summary>
		Public Overridable Property Placardsrequired As System.String
			Get
				Return MyBase.GetSystemString(ShipmentMetadata.ColumnNames.Placardsrequired)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ShipmentMetadata.ColumnNames.Placardsrequired, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENT.PLACARDSSUPPLIED
		' </summary>
		Public Overridable Property Placardssupplied As System.String
			Get
				Return MyBase.GetSystemString(ShipmentMetadata.ColumnNames.Placardssupplied)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ShipmentMetadata.ColumnNames.Placardssupplied, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENT.SHIPMENTSTATUS
		' </summary>
		Public Overridable Property Shipmentstatus As System.String
			Get
				Return MyBase.GetSystemString(ShipmentMetadata.ColumnNames.Shipmentstatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ShipmentMetadata.ColumnNames.Shipmentstatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENT.LOGISTICSID
		' </summary>
		Public Overridable Property Logisticsid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ShipmentMetadata.ColumnNames.Logisticsid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ShipmentMetadata.ColumnNames.Logisticsid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENT.COMMENTS
		' </summary>
		Public Overridable Property Comments As System.String
			Get
				Return MyBase.GetSystemString(ShipmentMetadata.ColumnNames.Comments)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ShipmentMetadata.ColumnNames.Comments, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENT.CREATEDBY
		' </summary>
		Public Overridable Property Createdby As System.String
			Get
				Return MyBase.GetSystemString(ShipmentMetadata.ColumnNames.Createdby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ShipmentMetadata.ColumnNames.Createdby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENT.CREATEDTIME
		' </summary>
		Public Overridable Property Createdtime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ShipmentMetadata.ColumnNames.Createdtime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ShipmentMetadata.ColumnNames.Createdtime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENT.MODIFYBY
		' </summary>
		Public Overridable Property Modifyby As System.String
			Get
				Return MyBase.GetSystemString(ShipmentMetadata.ColumnNames.Modifyby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ShipmentMetadata.ColumnNames.Modifyby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENT.MODIFYTIME
		' </summary>
		Public Overridable Property Modifytime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ShipmentMetadata.ColumnNames.Modifytime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ShipmentMetadata.ColumnNames.Modifytime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENT.KEEPFROMFREEZING
		' </summary>
		Public Overridable Property Keepfromfreezing As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ShipmentMetadata.ColumnNames.Keepfromfreezing)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ShipmentMetadata.ColumnNames.Keepfromfreezing, value)
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
		
			Public Sub New(ByVal entity As esShipment)
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
		  	
			Public Property Shipmentstatus As System.String 
				Get
					Dim data_ As System.String = entity.Shipmentstatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipmentstatus = Nothing
					Else
						entity.Shipmentstatus = Convert.ToString(Value)
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
		  	
			Public Property Modifyby As System.String 
				Get
					Dim data_ As System.String = entity.Modifyby
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Modifyby = Nothing
					Else
						entity.Modifyby = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Modifytime As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Modifytime
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Modifytime = Nothing
					Else
						entity.Modifytime = Convert.ToDateTime(Value)
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
		  

			Private entity As esShipment
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esShipmentQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esShipment can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Shipment 
		Inherits esShipment
		
	
		
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
	MustInherit Public Class esShipmentQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ShipmentMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Shipmentnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentMetadata.ColumnNames.Shipmentnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Shipmentdate As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentMetadata.ColumnNames.Shipmentdate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Workordernumber As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentMetadata.ColumnNames.Workordernumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Custid As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentMetadata.ColumnNames.Custid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Customername As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentMetadata.ColumnNames.Customername, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipfromid As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentMetadata.ColumnNames.Shipfromid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Shipfromname As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentMetadata.ColumnNames.Shipfromname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipfromaddress1 As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentMetadata.ColumnNames.Shipfromaddress1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipfromaddress2 As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentMetadata.ColumnNames.Shipfromaddress2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipfromcity As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentMetadata.ColumnNames.Shipfromcity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipfromstateprov As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentMetadata.ColumnNames.Shipfromstateprov, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipfrompostalcode As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentMetadata.ColumnNames.Shipfrompostalcode, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipfromcountry As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentMetadata.ColumnNames.Shipfromcountry, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipfromphone As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentMetadata.ColumnNames.Shipfromphone, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipfromfax As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentMetadata.ColumnNames.Shipfromfax, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipfromcontact As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentMetadata.ColumnNames.Shipfromcontact, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shiptoid As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentMetadata.ColumnNames.Shiptoid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Shiptoname As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentMetadata.ColumnNames.Shiptoname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shiptoaddress1 As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentMetadata.ColumnNames.Shiptoaddress1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shiptoaddress2 As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentMetadata.ColumnNames.Shiptoaddress2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shiptocity As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentMetadata.ColumnNames.Shiptocity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shiptostateprov As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentMetadata.ColumnNames.Shiptostateprov, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shiptopostalcode As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentMetadata.ColumnNames.Shiptopostalcode, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shiptocountry As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentMetadata.ColumnNames.Shiptocountry, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shiptocontact As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentMetadata.ColumnNames.Shiptocontact, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shiptophone As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentMetadata.ColumnNames.Shiptophone, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Carrierid As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentMetadata.ColumnNames.Carrierid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Freightcarrier As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentMetadata.ColumnNames.Freightcarrier, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Fob As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentMetadata.ColumnNames.Fob, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Customerpo As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentMetadata.ColumnNames.Customerpo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Placardsrequired As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentMetadata.ColumnNames.Placardsrequired, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Placardssupplied As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentMetadata.ColumnNames.Placardssupplied, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipmentstatus As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentMetadata.ColumnNames.Shipmentstatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Logisticsid As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentMetadata.ColumnNames.Logisticsid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Comments As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentMetadata.ColumnNames.Comments, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Createdby As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentMetadata.ColumnNames.Createdby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Createdtime As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentMetadata.ColumnNames.Createdtime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Modifyby As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentMetadata.ColumnNames.Modifyby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Modifytime As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentMetadata.ColumnNames.Modifytime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Keepfromfreezing As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentMetadata.ColumnNames.Keepfromfreezing, esSystemType.Boolean)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ShipmentCollection")> _
	Partial Public Class ShipmentCollection
		Inherits esShipmentCollection
		Implements IEnumerable(Of Shipment)
		
        Public Shared Widening Operator CType(ByVal coll As ShipmentCollection) As List(Of Shipment)
            Dim list As List(Of Shipment) = New List(Of Shipment)
            Dim emp As Shipment

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ShipmentMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ShipmentQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Shipment(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Shipment()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As ShipmentQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ShipmentQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ShipmentQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Shipment 
			Return CType(MyBase.AddNewEntity(), Shipment)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal shipmentnumber As System.Int32) As Shipment
			Return CType(MyBase.FindByPrimaryKey(shipmentnumber), Shipment)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Shipment) Implements IEnumerable(Of Shipment).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Shipment)(Me)
        End Function
		
		Private _query As ShipmentQuery

	End Class
	


	' <summary>
	' Encapsulates the 'SHIPMENT' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Shipment ({Shipmentnumber.Value})")> _
	<Serializable> _
	Partial Public Class Shipment 
		Inherits esShipment

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ShipmentMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esShipmentQuery

			If Me._query Is Nothing Then
				Me._query = New ShipmentQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ShipmentQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ShipmentQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ShipmentQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ShipmentQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ShipmentQuery
		inherits esShipmentQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ShipmentQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ShipmentMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ShipmentMetadata.ColumnNames.Shipmentnumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ShipmentMetadata.PropertyNames.Shipmentnumber
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentMetadata.ColumnNames.Shipmentdate, 1, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ShipmentMetadata.PropertyNames.Shipmentdate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentMetadata.ColumnNames.Workordernumber, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ShipmentMetadata.PropertyNames.Workordernumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentMetadata.ColumnNames.Custid, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ShipmentMetadata.PropertyNames.Custid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentMetadata.ColumnNames.Customername, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ShipmentMetadata.PropertyNames.Customername
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentMetadata.ColumnNames.Shipfromid, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ShipmentMetadata.PropertyNames.Shipfromid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentMetadata.ColumnNames.Shipfromname, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ShipmentMetadata.PropertyNames.Shipfromname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentMetadata.ColumnNames.Shipfromaddress1, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ShipmentMetadata.PropertyNames.Shipfromaddress1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentMetadata.ColumnNames.Shipfromaddress2, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ShipmentMetadata.PropertyNames.Shipfromaddress2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentMetadata.ColumnNames.Shipfromcity, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ShipmentMetadata.PropertyNames.Shipfromcity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentMetadata.ColumnNames.Shipfromstateprov, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ShipmentMetadata.PropertyNames.Shipfromstateprov
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentMetadata.ColumnNames.Shipfrompostalcode, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = ShipmentMetadata.PropertyNames.Shipfrompostalcode
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentMetadata.ColumnNames.Shipfromcountry, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = ShipmentMetadata.PropertyNames.Shipfromcountry
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentMetadata.ColumnNames.Shipfromphone, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = ShipmentMetadata.PropertyNames.Shipfromphone
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentMetadata.ColumnNames.Shipfromfax, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = ShipmentMetadata.PropertyNames.Shipfromfax
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentMetadata.ColumnNames.Shipfromcontact, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = ShipmentMetadata.PropertyNames.Shipfromcontact
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentMetadata.ColumnNames.Shiptoid, 16, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ShipmentMetadata.PropertyNames.Shiptoid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentMetadata.ColumnNames.Shiptoname, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = ShipmentMetadata.PropertyNames.Shiptoname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentMetadata.ColumnNames.Shiptoaddress1, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = ShipmentMetadata.PropertyNames.Shiptoaddress1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentMetadata.ColumnNames.Shiptoaddress2, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = ShipmentMetadata.PropertyNames.Shiptoaddress2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentMetadata.ColumnNames.Shiptocity, 20, GetType(System.String), esSystemType.String)	
			c.PropertyName = ShipmentMetadata.PropertyNames.Shiptocity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentMetadata.ColumnNames.Shiptostateprov, 21, GetType(System.String), esSystemType.String)	
			c.PropertyName = ShipmentMetadata.PropertyNames.Shiptostateprov
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentMetadata.ColumnNames.Shiptopostalcode, 22, GetType(System.String), esSystemType.String)	
			c.PropertyName = ShipmentMetadata.PropertyNames.Shiptopostalcode
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentMetadata.ColumnNames.Shiptocountry, 23, GetType(System.String), esSystemType.String)	
			c.PropertyName = ShipmentMetadata.PropertyNames.Shiptocountry
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentMetadata.ColumnNames.Shiptocontact, 24, GetType(System.String), esSystemType.String)	
			c.PropertyName = ShipmentMetadata.PropertyNames.Shiptocontact
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentMetadata.ColumnNames.Shiptophone, 25, GetType(System.String), esSystemType.String)	
			c.PropertyName = ShipmentMetadata.PropertyNames.Shiptophone
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentMetadata.ColumnNames.Carrierid, 26, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ShipmentMetadata.PropertyNames.Carrierid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentMetadata.ColumnNames.Freightcarrier, 27, GetType(System.String), esSystemType.String)	
			c.PropertyName = ShipmentMetadata.PropertyNames.Freightcarrier
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentMetadata.ColumnNames.Fob, 28, GetType(System.String), esSystemType.String)	
			c.PropertyName = ShipmentMetadata.PropertyNames.Fob
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentMetadata.ColumnNames.Customerpo, 29, GetType(System.String), esSystemType.String)	
			c.PropertyName = ShipmentMetadata.PropertyNames.Customerpo
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentMetadata.ColumnNames.Placardsrequired, 30, GetType(System.String), esSystemType.String)	
			c.PropertyName = ShipmentMetadata.PropertyNames.Placardsrequired
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentMetadata.ColumnNames.Placardssupplied, 31, GetType(System.String), esSystemType.String)	
			c.PropertyName = ShipmentMetadata.PropertyNames.Placardssupplied
			c.CharacterMaxLength = 3
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentMetadata.ColumnNames.Shipmentstatus, 32, GetType(System.String), esSystemType.String)	
			c.PropertyName = ShipmentMetadata.PropertyNames.Shipmentstatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentMetadata.ColumnNames.Logisticsid, 33, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ShipmentMetadata.PropertyNames.Logisticsid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentMetadata.ColumnNames.Comments, 34, GetType(System.String), esSystemType.String)	
			c.PropertyName = ShipmentMetadata.PropertyNames.Comments
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentMetadata.ColumnNames.Createdby, 35, GetType(System.String), esSystemType.String)	
			c.PropertyName = ShipmentMetadata.PropertyNames.Createdby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentMetadata.ColumnNames.Createdtime, 36, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ShipmentMetadata.PropertyNames.Createdtime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentMetadata.ColumnNames.Modifyby, 37, GetType(System.String), esSystemType.String)	
			c.PropertyName = ShipmentMetadata.PropertyNames.Modifyby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentMetadata.ColumnNames.Modifytime, 38, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ShipmentMetadata.PropertyNames.Modifytime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentMetadata.ColumnNames.Keepfromfreezing, 39, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ShipmentMetadata.PropertyNames.Keepfromfreezing
			c.HasDefault = True
			c.Default = "((0))"
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ShipmentMetadata
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
			 Public Const Shiptocontact As String = "SHIPTOCONTACT"
			 Public Const Shiptophone As String = "SHIPTOPHONE"
			 Public Const Carrierid As String = "CARRIERID"
			 Public Const Freightcarrier As String = "FREIGHTCARRIER"
			 Public Const Fob As String = "FOB"
			 Public Const Customerpo As String = "CUSTOMERPO"
			 Public Const Placardsrequired As String = "PLACARDSREQUIRED"
			 Public Const Placardssupplied As String = "PLACARDSSUPPLIED"
			 Public Const Shipmentstatus As String = "SHIPMENTSTATUS"
			 Public Const Logisticsid As String = "LOGISTICSID"
			 Public Const Comments As String = "COMMENTS"
			 Public Const Createdby As String = "CREATEDBY"
			 Public Const Createdtime As String = "CREATEDTIME"
			 Public Const Modifyby As String = "MODIFYBY"
			 Public Const Modifytime As String = "MODIFYTIME"
			 Public Const Keepfromfreezing As String = "KEEPFROMFREEZING"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Shipmentnumber As String = "Shipmentnumber"
			 Public Const Shipmentdate As String = "Shipmentdate"
			 Public Const Workordernumber As String = "Workordernumber"
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
			 Public Const Shiptocontact As String = "Shiptocontact"
			 Public Const Shiptophone As String = "Shiptophone"
			 Public Const Carrierid As String = "Carrierid"
			 Public Const Freightcarrier As String = "Freightcarrier"
			 Public Const Fob As String = "Fob"
			 Public Const Customerpo As String = "Customerpo"
			 Public Const Placardsrequired As String = "Placardsrequired"
			 Public Const Placardssupplied As String = "Placardssupplied"
			 Public Const Shipmentstatus As String = "Shipmentstatus"
			 Public Const Logisticsid As String = "Logisticsid"
			 Public Const Comments As String = "Comments"
			 Public Const Createdby As String = "Createdby"
			 Public Const Createdtime As String = "Createdtime"
			 Public Const Modifyby As String = "Modifyby"
			 Public Const Modifytime As String = "Modifytime"
			 Public Const Keepfromfreezing As String = "Keepfromfreezing"
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
            SyncLock GetType(ShipmentMetadata)
			
				If ShipmentMetadata.mapDelegates Is Nothing Then
					ShipmentMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ShipmentMetadata._meta Is Nothing Then
                    ShipmentMetadata._meta = New ShipmentMetadata()
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
				meta.AddTypeMap("Shiptocontact", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shiptophone", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Carrierid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Freightcarrier", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Fob", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Customerpo", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Placardsrequired", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Placardssupplied", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipmentstatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Logisticsid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Comments", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Createdby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Createdtime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Modifyby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Modifytime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Keepfromfreezing", new esTypeMap("bit", "System.Boolean"))			
				
				
				 
				meta.Source = "SHIPMENT"
				meta.Destination = "SHIPMENT"
				
				meta.spInsert = "proc_SHIPMENTInsert"
				meta.spUpdate = "proc_SHIPMENTUpdate"
				meta.spDelete = "proc_SHIPMENTDelete"
				meta.spLoadAll = "proc_SHIPMENTLoadAll"
				meta.spLoadByPrimaryKey = "proc_SHIPMENTLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ShipmentMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
