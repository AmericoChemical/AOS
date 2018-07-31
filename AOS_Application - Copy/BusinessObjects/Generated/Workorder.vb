'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 12/10/2016 10:36:03 AM
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
	MustInherit Public Class esWorkorderCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "WorkorderCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esWorkorderQuery)
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
            Me.InitQuery(CType(query, esWorkorderQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Workorder) As Workorder
			Return CType(MyBase.DetachEntity(entity), Workorder)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Workorder) As Workorder
			Return CType(MyBase.AttachEntity(entity), Workorder)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As WorkorderCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Workorder
            Get
                Return TryCast(MyBase.Item(index), Workorder)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Workorder)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esWorkorder	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esWorkorderQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal workordernumber As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(workordernumber)
			Else
				Return LoadByPrimaryKeyStoredProcedure(workordernumber)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal workordernumber As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(workordernumber)
			Else
				Return LoadByPrimaryKeyStoredProcedure(workordernumber)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal workordernumber As System.Int32) As Boolean
		
			Dim query As esWorkorderQuery = Me.GetDynamicQuery()
			query.Where(query.Workordernumber.Equal(workordernumber))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal workordernumber As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("WORKORDERNUMBER", workordernumber)
			
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
												
						Case "Workordernumber"
							Me.str.Workordernumber = CType(value, string)
												
						Case "Custid"
							Me.str.Custid = CType(value, string)
												
						Case "Billaddress1"
							Me.str.Billaddress1 = CType(value, string)
												
						Case "Billaddress2"
							Me.str.Billaddress2 = CType(value, string)
												
						Case "Billcity"
							Me.str.Billcity = CType(value, string)
												
						Case "Billstateprov"
							Me.str.Billstateprov = CType(value, string)
												
						Case "Billpostalcode"
							Me.str.Billpostalcode = CType(value, string)
												
						Case "Billcountry"
							Me.str.Billcountry = CType(value, string)
												
						Case "Billphone"
							Me.str.Billphone = CType(value, string)
												
						Case "Billfax"
							Me.str.Billfax = CType(value, string)
												
						Case "Billcontact"
							Me.str.Billcontact = CType(value, string)
												
						Case "Shipaddress1"
							Me.str.Shipaddress1 = CType(value, string)
												
						Case "Shipaddress2"
							Me.str.Shipaddress2 = CType(value, string)
												
						Case "Shipcity"
							Me.str.Shipcity = CType(value, string)
												
						Case "Shipstateprov"
							Me.str.Shipstateprov = CType(value, string)
												
						Case "Shippostalcode"
							Me.str.Shippostalcode = CType(value, string)
												
						Case "Shipcountry"
							Me.str.Shipcountry = CType(value, string)
												
						Case "Shipcontact"
							Me.str.Shipcontact = CType(value, string)
												
						Case "Freightcarrier"
							Me.str.Freightcarrier = CType(value, string)
												
						Case "Fob"
							Me.str.Fob = CType(value, string)
												
						Case "Customerpo"
							Me.str.Customerpo = CType(value, string)
												
						Case "Orderterms"
							Me.str.Orderterms = CType(value, string)
												
						Case "Deliverydate"
							Me.str.Deliverydate = CType(value, string)
												
						Case "Plannedshipdate"
							Me.str.Plannedshipdate = CType(value, string)
												
						Case "Howreceived"
							Me.str.Howreceived = CType(value, string)
												
						Case "Orderstatus"
							Me.str.Orderstatus = CType(value, string)
												
						Case "Ordernotes"
							Me.str.Ordernotes = CType(value, string)
												
						Case "Workorderdate"
							Me.str.Workorderdate = CType(value, string)
												
						Case "Preparedby"
							Me.str.Preparedby = CType(value, string)
												
						Case "Suppliercompany"
							Me.str.Suppliercompany = CType(value, string)
												
						Case "Subtotal"
							Me.str.Subtotal = CType(value, string)
												
						Case "Logisticsid"
							Me.str.Logisticsid = CType(value, string)
												
						Case "Createdby"
							Me.str.Createdby = CType(value, string)
												
						Case "Createdtime"
							Me.str.Createdtime = CType(value, string)
												
						Case "Modifyby"
							Me.str.Modifyby = CType(value, string)
												
						Case "Modifytime"
							Me.str.Modifytime = CType(value, string)
												
						Case "Shipphone"
							Me.str.Shipphone = CType(value, string)
												
						Case "Shipemail"
							Me.str.Shipemail = CType(value, string)
												
						Case "Carrierid"
							Me.str.Carrierid = CType(value, string)
												
						Case "Workordertype"
							Me.str.Workordertype = CType(value, string)
												
						Case "Onhold"
							Me.str.Onhold = CType(value, string)
												
						Case "Onholdreason"
							Me.str.Onholdreason = CType(value, string)
												
						Case "Freightcharges"
							Me.str.Freightcharges = CType(value, string)
												
						Case "Freightbillable"
							Me.str.Freightbillable = CType(value, string)
												
						Case "Freightbillcustomer"
							Me.str.Freightbillcustomer = CType(value, string)
												
						Case "Freightoninvoice"
							Me.str.Freightoninvoice = CType(value, string)
												
						Case "Vendorid"
							Me.str.Vendorid = CType(value, string)
												
						Case "Billingtype"
							Me.str.Billingtype = CType(value, string)
												
						Case "Transporttype"
							Me.str.Transporttype = CType(value, string)
												
						Case "Ordertype"
							Me.str.Ordertype = CType(value, string)
												
						Case "Salespersonid"
							Me.str.Salespersonid = CType(value, string)
												
						Case "Prodfulfillmentnotes"
							Me.str.Prodfulfillmentnotes = CType(value, string)
												
						Case "Transportationnotes"
							Me.str.Transportationnotes = CType(value, string)
												
						Case "Billofladingnotes"
							Me.str.Billofladingnotes = CType(value, string)
												
						Case "Accountingnotes"
							Me.str.Accountingnotes = CType(value, string)
												
						Case "Orsoonerflag"
							Me.str.Orsoonerflag = CType(value, string)
												
						Case "Freezeprotectflag"
							Me.str.Freezeprotectflag = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Workordernumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Workordernumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Custid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Custid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Deliverydate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Deliverydate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Plannedshipdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Plannedshipdate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Workorderdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Workorderdate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Subtotal"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Subtotal = CType(value, Nullable(Of System.Decimal))
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
						
						Case "Carrierid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Carrierid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Onhold"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Onhold = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Freightcharges"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Freightcharges = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Freightbillable"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Freightbillable = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Freightbillcustomer"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Freightbillcustomer = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Freightoninvoice"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Freightoninvoice = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Vendorid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Vendorid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Salespersonid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Salespersonid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Orsoonerflag"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Orsoonerflag = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Freezeprotectflag"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Freezeprotectflag = CType(value, Nullable(Of System.Boolean))
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
		' Maps to WORKORDER.WORKORDERNUMBER
		' </summary>
		Public Overridable Property Workordernumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(WorkorderMetadata.ColumnNames.Workordernumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(WorkorderMetadata.ColumnNames.Workordernumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDER.CUSTID
		' </summary>
		Public Overridable Property Custid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(WorkorderMetadata.ColumnNames.Custid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(WorkorderMetadata.ColumnNames.Custid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDER.BILLADDRESS1
		' </summary>
		Public Overridable Property Billaddress1 As System.String
			Get
				Return MyBase.GetSystemString(WorkorderMetadata.ColumnNames.Billaddress1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(WorkorderMetadata.ColumnNames.Billaddress1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDER.BILLADDRESS2
		' </summary>
		Public Overridable Property Billaddress2 As System.String
			Get
				Return MyBase.GetSystemString(WorkorderMetadata.ColumnNames.Billaddress2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(WorkorderMetadata.ColumnNames.Billaddress2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDER.BILLCITY
		' </summary>
		Public Overridable Property Billcity As System.String
			Get
				Return MyBase.GetSystemString(WorkorderMetadata.ColumnNames.Billcity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(WorkorderMetadata.ColumnNames.Billcity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDER.BILLSTATEPROV
		' </summary>
		Public Overridable Property Billstateprov As System.String
			Get
				Return MyBase.GetSystemString(WorkorderMetadata.ColumnNames.Billstateprov)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(WorkorderMetadata.ColumnNames.Billstateprov, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDER.BILLPOSTALCODE
		' </summary>
		Public Overridable Property Billpostalcode As System.String
			Get
				Return MyBase.GetSystemString(WorkorderMetadata.ColumnNames.Billpostalcode)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(WorkorderMetadata.ColumnNames.Billpostalcode, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDER.BILLCOUNTRY
		' </summary>
		Public Overridable Property Billcountry As System.String
			Get
				Return MyBase.GetSystemString(WorkorderMetadata.ColumnNames.Billcountry)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(WorkorderMetadata.ColumnNames.Billcountry, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDER.BILLPHONE
		' </summary>
		Public Overridable Property Billphone As System.String
			Get
				Return MyBase.GetSystemString(WorkorderMetadata.ColumnNames.Billphone)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(WorkorderMetadata.ColumnNames.Billphone, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDER.BILLFAX
		' </summary>
		Public Overridable Property Billfax As System.String
			Get
				Return MyBase.GetSystemString(WorkorderMetadata.ColumnNames.Billfax)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(WorkorderMetadata.ColumnNames.Billfax, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDER.BILLCONTACT
		' </summary>
		Public Overridable Property Billcontact As System.String
			Get
				Return MyBase.GetSystemString(WorkorderMetadata.ColumnNames.Billcontact)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(WorkorderMetadata.ColumnNames.Billcontact, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDER.SHIPADDRESS1
		' </summary>
		Public Overridable Property Shipaddress1 As System.String
			Get
				Return MyBase.GetSystemString(WorkorderMetadata.ColumnNames.Shipaddress1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(WorkorderMetadata.ColumnNames.Shipaddress1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDER.SHIPADDRESS2
		' </summary>
		Public Overridable Property Shipaddress2 As System.String
			Get
				Return MyBase.GetSystemString(WorkorderMetadata.ColumnNames.Shipaddress2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(WorkorderMetadata.ColumnNames.Shipaddress2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDER.SHIPCITY
		' </summary>
		Public Overridable Property Shipcity As System.String
			Get
				Return MyBase.GetSystemString(WorkorderMetadata.ColumnNames.Shipcity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(WorkorderMetadata.ColumnNames.Shipcity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDER.SHIPSTATEPROV
		' </summary>
		Public Overridable Property Shipstateprov As System.String
			Get
				Return MyBase.GetSystemString(WorkorderMetadata.ColumnNames.Shipstateprov)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(WorkorderMetadata.ColumnNames.Shipstateprov, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDER.SHIPPOSTALCODE
		' </summary>
		Public Overridable Property Shippostalcode As System.String
			Get
				Return MyBase.GetSystemString(WorkorderMetadata.ColumnNames.Shippostalcode)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(WorkorderMetadata.ColumnNames.Shippostalcode, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDER.SHIPCOUNTRY
		' </summary>
		Public Overridable Property Shipcountry As System.String
			Get
				Return MyBase.GetSystemString(WorkorderMetadata.ColumnNames.Shipcountry)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(WorkorderMetadata.ColumnNames.Shipcountry, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDER.SHIPCONTACT
		' </summary>
		Public Overridable Property Shipcontact As System.String
			Get
				Return MyBase.GetSystemString(WorkorderMetadata.ColumnNames.Shipcontact)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(WorkorderMetadata.ColumnNames.Shipcontact, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDER.FREIGHTCARRIER
		' </summary>
		Public Overridable Property Freightcarrier As System.String
			Get
				Return MyBase.GetSystemString(WorkorderMetadata.ColumnNames.Freightcarrier)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(WorkorderMetadata.ColumnNames.Freightcarrier, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDER.FOB
		' </summary>
		Public Overridable Property Fob As System.String
			Get
				Return MyBase.GetSystemString(WorkorderMetadata.ColumnNames.Fob)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(WorkorderMetadata.ColumnNames.Fob, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDER.CUSTOMERPO
		' </summary>
		Public Overridable Property Customerpo As System.String
			Get
				Return MyBase.GetSystemString(WorkorderMetadata.ColumnNames.Customerpo)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(WorkorderMetadata.ColumnNames.Customerpo, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDER.ORDERTERMS
		' </summary>
		Public Overridable Property Orderterms As System.String
			Get
				Return MyBase.GetSystemString(WorkorderMetadata.ColumnNames.Orderterms)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(WorkorderMetadata.ColumnNames.Orderterms, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDER.DELIVERYDATE
		' </summary>
		Public Overridable Property Deliverydate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(WorkorderMetadata.ColumnNames.Deliverydate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(WorkorderMetadata.ColumnNames.Deliverydate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDER.PLANNEDSHIPDATE
		' </summary>
		Public Overridable Property Plannedshipdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(WorkorderMetadata.ColumnNames.Plannedshipdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(WorkorderMetadata.ColumnNames.Plannedshipdate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDER.HOWRECEIVED
		' </summary>
		Public Overridable Property Howreceived As System.String
			Get
				Return MyBase.GetSystemString(WorkorderMetadata.ColumnNames.Howreceived)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(WorkorderMetadata.ColumnNames.Howreceived, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDER.ORDERSTATUS
		' </summary>
		Public Overridable Property Orderstatus As System.String
			Get
				Return MyBase.GetSystemString(WorkorderMetadata.ColumnNames.Orderstatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(WorkorderMetadata.ColumnNames.Orderstatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDER.ORDERNOTES
		' </summary>
		Public Overridable Property Ordernotes As System.String
			Get
				Return MyBase.GetSystemString(WorkorderMetadata.ColumnNames.Ordernotes)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(WorkorderMetadata.ColumnNames.Ordernotes, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDER.WORKORDERDATE
		' </summary>
		Public Overridable Property Workorderdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(WorkorderMetadata.ColumnNames.Workorderdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(WorkorderMetadata.ColumnNames.Workorderdate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDER.PREPAREDBY
		' </summary>
		Public Overridable Property Preparedby As System.String
			Get
				Return MyBase.GetSystemString(WorkorderMetadata.ColumnNames.Preparedby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(WorkorderMetadata.ColumnNames.Preparedby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDER.SUPPLIERCOMPANY
		' </summary>
		Public Overridable Property Suppliercompany As System.String
			Get
				Return MyBase.GetSystemString(WorkorderMetadata.ColumnNames.Suppliercompany)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(WorkorderMetadata.ColumnNames.Suppliercompany, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDER.SUBTOTAL
		' </summary>
		Public Overridable Property Subtotal As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(WorkorderMetadata.ColumnNames.Subtotal)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(WorkorderMetadata.ColumnNames.Subtotal, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDER.LOGISTICSID
		' </summary>
		Public Overridable Property Logisticsid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(WorkorderMetadata.ColumnNames.Logisticsid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(WorkorderMetadata.ColumnNames.Logisticsid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDER.CREATEDBY
		' </summary>
		Public Overridable Property Createdby As System.String
			Get
				Return MyBase.GetSystemString(WorkorderMetadata.ColumnNames.Createdby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(WorkorderMetadata.ColumnNames.Createdby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDER.CREATEDTIME
		' </summary>
		Public Overridable Property Createdtime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(WorkorderMetadata.ColumnNames.Createdtime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(WorkorderMetadata.ColumnNames.Createdtime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDER.MODIFYBY
		' </summary>
		Public Overridable Property Modifyby As System.String
			Get
				Return MyBase.GetSystemString(WorkorderMetadata.ColumnNames.Modifyby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(WorkorderMetadata.ColumnNames.Modifyby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDER.MODIFYTIME
		' </summary>
		Public Overridable Property Modifytime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(WorkorderMetadata.ColumnNames.Modifytime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(WorkorderMetadata.ColumnNames.Modifytime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDER.SHIPPHONE
		' </summary>
		Public Overridable Property Shipphone As System.String
			Get
				Return MyBase.GetSystemString(WorkorderMetadata.ColumnNames.Shipphone)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(WorkorderMetadata.ColumnNames.Shipphone, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDER.SHIPEMAIL
		' </summary>
		Public Overridable Property Shipemail As System.String
			Get
				Return MyBase.GetSystemString(WorkorderMetadata.ColumnNames.Shipemail)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(WorkorderMetadata.ColumnNames.Shipemail, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDER.CARRIERID
		' </summary>
		Public Overridable Property Carrierid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(WorkorderMetadata.ColumnNames.Carrierid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(WorkorderMetadata.ColumnNames.Carrierid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDER.WORKORDERTYPE
		' </summary>
		Public Overridable Property Workordertype As System.String
			Get
				Return MyBase.GetSystemString(WorkorderMetadata.ColumnNames.Workordertype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(WorkorderMetadata.ColumnNames.Workordertype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDER.ONHOLD
		' </summary>
		Public Overridable Property Onhold As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(WorkorderMetadata.ColumnNames.Onhold)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(WorkorderMetadata.ColumnNames.Onhold, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDER.ONHOLDREASON
		' </summary>
		Public Overridable Property Onholdreason As System.String
			Get
				Return MyBase.GetSystemString(WorkorderMetadata.ColumnNames.Onholdreason)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(WorkorderMetadata.ColumnNames.Onholdreason, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDER.FREIGHTCHARGES
		' </summary>
		Public Overridable Property Freightcharges As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(WorkorderMetadata.ColumnNames.Freightcharges)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(WorkorderMetadata.ColumnNames.Freightcharges, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDER.FREIGHTBILLABLE
		' </summary>
		Public Overridable Property Freightbillable As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(WorkorderMetadata.ColumnNames.Freightbillable)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(WorkorderMetadata.ColumnNames.Freightbillable, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDER.FREIGHTBILLCUSTOMER
		' </summary>
		Public Overridable Property Freightbillcustomer As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(WorkorderMetadata.ColumnNames.Freightbillcustomer)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(WorkorderMetadata.ColumnNames.Freightbillcustomer, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDER.FREIGHTONINVOICE
		' </summary>
		Public Overridable Property Freightoninvoice As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(WorkorderMetadata.ColumnNames.Freightoninvoice)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(WorkorderMetadata.ColumnNames.Freightoninvoice, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDER.VENDORID
		' </summary>
		Public Overridable Property Vendorid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(WorkorderMetadata.ColumnNames.Vendorid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(WorkorderMetadata.ColumnNames.Vendorid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDER.BILLINGTYPE
		' </summary>
		Public Overridable Property Billingtype As System.String
			Get
				Return MyBase.GetSystemString(WorkorderMetadata.ColumnNames.Billingtype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(WorkorderMetadata.ColumnNames.Billingtype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDER.TRANSPORTTYPE
		' </summary>
		Public Overridable Property Transporttype As System.String
			Get
				Return MyBase.GetSystemString(WorkorderMetadata.ColumnNames.Transporttype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(WorkorderMetadata.ColumnNames.Transporttype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDER.ORDERTYPE
		' </summary>
		Public Overridable Property Ordertype As System.String
			Get
				Return MyBase.GetSystemString(WorkorderMetadata.ColumnNames.Ordertype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(WorkorderMetadata.ColumnNames.Ordertype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDER.SALESPERSONID
		' </summary>
		Public Overridable Property Salespersonid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(WorkorderMetadata.ColumnNames.Salespersonid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(WorkorderMetadata.ColumnNames.Salespersonid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDER.PRODFULFILLMENTNOTES
		' </summary>
		Public Overridable Property Prodfulfillmentnotes As System.String
			Get
				Return MyBase.GetSystemString(WorkorderMetadata.ColumnNames.Prodfulfillmentnotes)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(WorkorderMetadata.ColumnNames.Prodfulfillmentnotes, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDER.TRANSPORTATIONNOTES
		' </summary>
		Public Overridable Property Transportationnotes As System.String
			Get
				Return MyBase.GetSystemString(WorkorderMetadata.ColumnNames.Transportationnotes)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(WorkorderMetadata.ColumnNames.Transportationnotes, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDER.BILLOFLADINGNOTES
		' </summary>
		Public Overridable Property Billofladingnotes As System.String
			Get
				Return MyBase.GetSystemString(WorkorderMetadata.ColumnNames.Billofladingnotes)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(WorkorderMetadata.ColumnNames.Billofladingnotes, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDER.ACCOUNTINGNOTES
		' </summary>
		Public Overridable Property Accountingnotes As System.String
			Get
				Return MyBase.GetSystemString(WorkorderMetadata.ColumnNames.Accountingnotes)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(WorkorderMetadata.ColumnNames.Accountingnotes, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDER.ORSOONERFLAG
		' </summary>
		Public Overridable Property Orsoonerflag As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(WorkorderMetadata.ColumnNames.Orsoonerflag)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(WorkorderMetadata.ColumnNames.Orsoonerflag, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDER.FREEZEPROTECTFLAG
		' </summary>
		Public Overridable Property Freezeprotectflag As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(WorkorderMetadata.ColumnNames.Freezeprotectflag)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(WorkorderMetadata.ColumnNames.Freezeprotectflag, value)
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
		
			Public Sub New(ByVal entity As esWorkorder)
				Me.entity = entity
			End Sub				
		
	
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
		  	
			Public Property Billaddress1 As System.String 
				Get
					Dim data_ As System.String = entity.Billaddress1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Billaddress1 = Nothing
					Else
						entity.Billaddress1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Billaddress2 As System.String 
				Get
					Dim data_ As System.String = entity.Billaddress2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Billaddress2 = Nothing
					Else
						entity.Billaddress2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Billcity As System.String 
				Get
					Dim data_ As System.String = entity.Billcity
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Billcity = Nothing
					Else
						entity.Billcity = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Billstateprov As System.String 
				Get
					Dim data_ As System.String = entity.Billstateprov
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Billstateprov = Nothing
					Else
						entity.Billstateprov = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Billpostalcode As System.String 
				Get
					Dim data_ As System.String = entity.Billpostalcode
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Billpostalcode = Nothing
					Else
						entity.Billpostalcode = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Billcountry As System.String 
				Get
					Dim data_ As System.String = entity.Billcountry
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Billcountry = Nothing
					Else
						entity.Billcountry = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Billphone As System.String 
				Get
					Dim data_ As System.String = entity.Billphone
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Billphone = Nothing
					Else
						entity.Billphone = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Billfax As System.String 
				Get
					Dim data_ As System.String = entity.Billfax
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Billfax = Nothing
					Else
						entity.Billfax = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Billcontact As System.String 
				Get
					Dim data_ As System.String = entity.Billcontact
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Billcontact = Nothing
					Else
						entity.Billcontact = Convert.ToString(Value)
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
		  	
			Public Property Shipstateprov As System.String 
				Get
					Dim data_ As System.String = entity.Shipstateprov
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipstateprov = Nothing
					Else
						entity.Shipstateprov = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shippostalcode As System.String 
				Get
					Dim data_ As System.String = entity.Shippostalcode
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shippostalcode = Nothing
					Else
						entity.Shippostalcode = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shipcountry As System.String 
				Get
					Dim data_ As System.String = entity.Shipcountry
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipcountry = Nothing
					Else
						entity.Shipcountry = Convert.ToString(Value)
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
		  	
			Public Property Orderterms As System.String 
				Get
					Dim data_ As System.String = entity.Orderterms
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Orderterms = Nothing
					Else
						entity.Orderterms = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Deliverydate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Deliverydate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Deliverydate = Nothing
					Else
						entity.Deliverydate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Plannedshipdate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Plannedshipdate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Plannedshipdate = Nothing
					Else
						entity.Plannedshipdate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Howreceived As System.String 
				Get
					Dim data_ As System.String = entity.Howreceived
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Howreceived = Nothing
					Else
						entity.Howreceived = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Orderstatus As System.String 
				Get
					Dim data_ As System.String = entity.Orderstatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Orderstatus = Nothing
					Else
						entity.Orderstatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Ordernotes As System.String 
				Get
					Dim data_ As System.String = entity.Ordernotes
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Ordernotes = Nothing
					Else
						entity.Ordernotes = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Workorderdate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Workorderdate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Workorderdate = Nothing
					Else
						entity.Workorderdate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Preparedby As System.String 
				Get
					Dim data_ As System.String = entity.Preparedby
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Preparedby = Nothing
					Else
						entity.Preparedby = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Suppliercompany As System.String 
				Get
					Dim data_ As System.String = entity.Suppliercompany
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Suppliercompany = Nothing
					Else
						entity.Suppliercompany = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Subtotal As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Subtotal
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Subtotal = Nothing
					Else
						entity.Subtotal = Convert.ToDecimal(Value)
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
		  	
			Public Property Shipemail As System.String 
				Get
					Dim data_ As System.String = entity.Shipemail
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipemail = Nothing
					Else
						entity.Shipemail = Convert.ToString(Value)
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
		  	
			Public Property Workordertype As System.String 
				Get
					Dim data_ As System.String = entity.Workordertype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Workordertype = Nothing
					Else
						entity.Workordertype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Onhold As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Onhold
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Onhold = Nothing
					Else
						entity.Onhold = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property Onholdreason As System.String 
				Get
					Dim data_ As System.String = entity.Onholdreason
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Onholdreason = Nothing
					Else
						entity.Onholdreason = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Freightcharges As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Freightcharges
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Freightcharges = Nothing
					Else
						entity.Freightcharges = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Freightbillable As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Freightbillable
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Freightbillable = Nothing
					Else
						entity.Freightbillable = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Freightbillcustomer As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Freightbillcustomer
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Freightbillcustomer = Nothing
					Else
						entity.Freightbillcustomer = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property Freightoninvoice As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Freightoninvoice
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Freightoninvoice = Nothing
					Else
						entity.Freightoninvoice = Convert.ToBoolean(Value)
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
		  	
			Public Property Billingtype As System.String 
				Get
					Dim data_ As System.String = entity.Billingtype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Billingtype = Nothing
					Else
						entity.Billingtype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Transporttype As System.String 
				Get
					Dim data_ As System.String = entity.Transporttype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Transporttype = Nothing
					Else
						entity.Transporttype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Ordertype As System.String 
				Get
					Dim data_ As System.String = entity.Ordertype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Ordertype = Nothing
					Else
						entity.Ordertype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Salespersonid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Salespersonid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Salespersonid = Nothing
					Else
						entity.Salespersonid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Prodfulfillmentnotes As System.String 
				Get
					Dim data_ As System.String = entity.Prodfulfillmentnotes
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Prodfulfillmentnotes = Nothing
					Else
						entity.Prodfulfillmentnotes = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Transportationnotes As System.String 
				Get
					Dim data_ As System.String = entity.Transportationnotes
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Transportationnotes = Nothing
					Else
						entity.Transportationnotes = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Billofladingnotes As System.String 
				Get
					Dim data_ As System.String = entity.Billofladingnotes
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Billofladingnotes = Nothing
					Else
						entity.Billofladingnotes = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Accountingnotes As System.String 
				Get
					Dim data_ As System.String = entity.Accountingnotes
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Accountingnotes = Nothing
					Else
						entity.Accountingnotes = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Orsoonerflag As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Orsoonerflag
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Orsoonerflag = Nothing
					Else
						entity.Orsoonerflag = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property Freezeprotectflag As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Freezeprotectflag
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Freezeprotectflag = Nothing
					Else
						entity.Freezeprotectflag = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  

			Private entity As esWorkorder
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esWorkorderQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esWorkorder can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Workorder 
		Inherits esWorkorder
		
	
		
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
	MustInherit Public Class esWorkorderQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return WorkorderMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Workordernumber As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Workordernumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Custid As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Custid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Billaddress1 As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Billaddress1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Billaddress2 As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Billaddress2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Billcity As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Billcity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Billstateprov As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Billstateprov, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Billpostalcode As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Billpostalcode, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Billcountry As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Billcountry, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Billphone As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Billphone, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Billfax As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Billfax, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Billcontact As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Billcontact, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipaddress1 As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Shipaddress1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipaddress2 As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Shipaddress2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipcity As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Shipcity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipstateprov As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Shipstateprov, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shippostalcode As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Shippostalcode, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipcountry As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Shipcountry, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipcontact As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Shipcontact, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Freightcarrier As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Freightcarrier, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Fob As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Fob, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Customerpo As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Customerpo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Orderterms As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Orderterms, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Deliverydate As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Deliverydate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Plannedshipdate As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Plannedshipdate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Howreceived As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Howreceived, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Orderstatus As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Orderstatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Ordernotes As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Ordernotes, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Workorderdate As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Workorderdate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Preparedby As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Preparedby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Suppliercompany As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Suppliercompany, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Subtotal As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Subtotal, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Logisticsid As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Logisticsid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Createdby As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Createdby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Createdtime As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Createdtime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Modifyby As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Modifyby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Modifytime As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Modifytime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Shipphone As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Shipphone, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipemail As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Shipemail, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Carrierid As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Carrierid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Workordertype As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Workordertype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Onhold As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Onhold, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Onholdreason As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Onholdreason, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Freightcharges As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Freightcharges, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Freightbillable As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Freightbillable, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Freightbillcustomer As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Freightbillcustomer, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Freightoninvoice As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Freightoninvoice, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Vendorid As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Vendorid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Billingtype As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Billingtype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Transporttype As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Transporttype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Ordertype As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Ordertype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Salespersonid As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Salespersonid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Prodfulfillmentnotes As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Prodfulfillmentnotes, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Transportationnotes As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Transportationnotes, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Billofladingnotes As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Billofladingnotes, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Accountingnotes As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Accountingnotes, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Orsoonerflag As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Orsoonerflag, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Freezeprotectflag As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderMetadata.ColumnNames.Freezeprotectflag, esSystemType.Boolean)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("WorkorderCollection")> _
	Partial Public Class WorkorderCollection
		Inherits esWorkorderCollection
		Implements IEnumerable(Of Workorder)
		
        Public Shared Widening Operator CType(ByVal coll As WorkorderCollection) As List(Of Workorder)
            Dim list As List(Of Workorder) = New List(Of Workorder)
            Dim emp As Workorder

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return WorkorderMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New WorkorderQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Workorder(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Workorder()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As WorkorderQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New WorkorderQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As WorkorderQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Workorder 
			Return CType(MyBase.AddNewEntity(), Workorder)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal workordernumber As System.Int32) As Workorder
			Return CType(MyBase.FindByPrimaryKey(workordernumber), Workorder)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Workorder) Implements IEnumerable(Of Workorder).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Workorder)(Me)
        End Function
		
		Private _query As WorkorderQuery

	End Class
	


	' <summary>
	' Encapsulates the 'WORKORDER' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Workorder ({Workordernumber.Value})")> _
	<Serializable> _
	Partial Public Class Workorder 
		Inherits esWorkorder

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return WorkorderMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esWorkorderQuery

			If Me._query Is Nothing Then
				Me._query = New WorkorderQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As WorkorderQuery
			Get

				If Me._query Is Nothing then
					Me._query = New WorkorderQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As WorkorderQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As WorkorderQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class WorkorderQuery
		inherits esWorkorderQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "WorkorderQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class WorkorderMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Workordernumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Workordernumber
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Custid, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Custid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Billaddress1, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Billaddress1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Billaddress2, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Billaddress2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Billcity, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Billcity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Billstateprov, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Billstateprov
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Billpostalcode, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Billpostalcode
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Billcountry, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Billcountry
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Billphone, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Billphone
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Billfax, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Billfax
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Billcontact, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Billcontact
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Shipaddress1, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Shipaddress1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Shipaddress2, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Shipaddress2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Shipcity, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Shipcity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Shipstateprov, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Shipstateprov
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Shippostalcode, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Shippostalcode
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Shipcountry, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Shipcountry
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Shipcontact, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Shipcontact
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Freightcarrier, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Freightcarrier
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Fob, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Fob
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Customerpo, 20, GetType(System.String), esSystemType.String)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Customerpo
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Orderterms, 21, GetType(System.String), esSystemType.String)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Orderterms
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Deliverydate, 22, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Deliverydate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Plannedshipdate, 23, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Plannedshipdate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Howreceived, 24, GetType(System.String), esSystemType.String)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Howreceived
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Orderstatus, 25, GetType(System.String), esSystemType.String)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Orderstatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Ordernotes, 26, GetType(System.String), esSystemType.String)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Ordernotes
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Workorderdate, 27, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Workorderdate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Preparedby, 28, GetType(System.String), esSystemType.String)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Preparedby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Suppliercompany, 29, GetType(System.String), esSystemType.String)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Suppliercompany
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Subtotal, 30, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Subtotal
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Logisticsid, 31, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Logisticsid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Createdby, 32, GetType(System.String), esSystemType.String)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Createdby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Createdtime, 33, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Createdtime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Modifyby, 34, GetType(System.String), esSystemType.String)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Modifyby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Modifytime, 35, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Modifytime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Shipphone, 36, GetType(System.String), esSystemType.String)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Shipphone
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Shipemail, 37, GetType(System.String), esSystemType.String)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Shipemail
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Carrierid, 38, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Carrierid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Workordertype, 39, GetType(System.String), esSystemType.String)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Workordertype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Onhold, 40, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Onhold
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Onholdreason, 41, GetType(System.String), esSystemType.String)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Onholdreason
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Freightcharges, 42, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Freightcharges
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Freightbillable, 43, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Freightbillable
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Freightbillcustomer, 44, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Freightbillcustomer
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Freightoninvoice, 45, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Freightoninvoice
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Vendorid, 46, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Vendorid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Billingtype, 47, GetType(System.String), esSystemType.String)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Billingtype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Transporttype, 48, GetType(System.String), esSystemType.String)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Transporttype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Ordertype, 49, GetType(System.String), esSystemType.String)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Ordertype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Salespersonid, 50, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Salespersonid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Prodfulfillmentnotes, 51, GetType(System.String), esSystemType.String)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Prodfulfillmentnotes
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Transportationnotes, 52, GetType(System.String), esSystemType.String)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Transportationnotes
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Billofladingnotes, 53, GetType(System.String), esSystemType.String)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Billofladingnotes
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Accountingnotes, 54, GetType(System.String), esSystemType.String)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Accountingnotes
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Orsoonerflag, 55, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Orsoonerflag
			c.HasDefault = True
			c.Default = "((1))"
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderMetadata.ColumnNames.Freezeprotectflag, 56, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = WorkorderMetadata.PropertyNames.Freezeprotectflag
			c.HasDefault = True
			c.Default = "((0))"
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As WorkorderMetadata
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
			 Public Const Workordernumber As String = "WORKORDERNUMBER"
			 Public Const Custid As String = "CUSTID"
			 Public Const Billaddress1 As String = "BILLADDRESS1"
			 Public Const Billaddress2 As String = "BILLADDRESS2"
			 Public Const Billcity As String = "BILLCITY"
			 Public Const Billstateprov As String = "BILLSTATEPROV"
			 Public Const Billpostalcode As String = "BILLPOSTALCODE"
			 Public Const Billcountry As String = "BILLCOUNTRY"
			 Public Const Billphone As String = "BILLPHONE"
			 Public Const Billfax As String = "BILLFAX"
			 Public Const Billcontact As String = "BILLCONTACT"
			 Public Const Shipaddress1 As String = "SHIPADDRESS1"
			 Public Const Shipaddress2 As String = "SHIPADDRESS2"
			 Public Const Shipcity As String = "SHIPCITY"
			 Public Const Shipstateprov As String = "SHIPSTATEPROV"
			 Public Const Shippostalcode As String = "SHIPPOSTALCODE"
			 Public Const Shipcountry As String = "SHIPCOUNTRY"
			 Public Const Shipcontact As String = "SHIPCONTACT"
			 Public Const Freightcarrier As String = "FREIGHTCARRIER"
			 Public Const Fob As String = "FOB"
			 Public Const Customerpo As String = "CUSTOMERPO"
			 Public Const Orderterms As String = "ORDERTERMS"
			 Public Const Deliverydate As String = "DELIVERYDATE"
			 Public Const Plannedshipdate As String = "PLANNEDSHIPDATE"
			 Public Const Howreceived As String = "HOWRECEIVED"
			 Public Const Orderstatus As String = "ORDERSTATUS"
			 Public Const Ordernotes As String = "ORDERNOTES"
			 Public Const Workorderdate As String = "WORKORDERDATE"
			 Public Const Preparedby As String = "PREPAREDBY"
			 Public Const Suppliercompany As String = "SUPPLIERCOMPANY"
			 Public Const Subtotal As String = "SUBTOTAL"
			 Public Const Logisticsid As String = "LOGISTICSID"
			 Public Const Createdby As String = "CREATEDBY"
			 Public Const Createdtime As String = "CREATEDTIME"
			 Public Const Modifyby As String = "MODIFYBY"
			 Public Const Modifytime As String = "MODIFYTIME"
			 Public Const Shipphone As String = "SHIPPHONE"
			 Public Const Shipemail As String = "SHIPEMAIL"
			 Public Const Carrierid As String = "CARRIERID"
			 Public Const Workordertype As String = "WORKORDERTYPE"
			 Public Const Onhold As String = "ONHOLD"
			 Public Const Onholdreason As String = "ONHOLDREASON"
			 Public Const Freightcharges As String = "FREIGHTCHARGES"
			 Public Const Freightbillable As String = "FREIGHTBILLABLE"
			 Public Const Freightbillcustomer As String = "FREIGHTBILLCUSTOMER"
			 Public Const Freightoninvoice As String = "FREIGHTONINVOICE"
			 Public Const Vendorid As String = "VENDORID"
			 Public Const Billingtype As String = "BILLINGTYPE"
			 Public Const Transporttype As String = "TRANSPORTTYPE"
			 Public Const Ordertype As String = "ORDERTYPE"
			 Public Const Salespersonid As String = "SALESPERSONID"
			 Public Const Prodfulfillmentnotes As String = "PRODFULFILLMENTNOTES"
			 Public Const Transportationnotes As String = "TRANSPORTATIONNOTES"
			 Public Const Billofladingnotes As String = "BILLOFLADINGNOTES"
			 Public Const Accountingnotes As String = "ACCOUNTINGNOTES"
			 Public Const Orsoonerflag As String = "ORSOONERFLAG"
			 Public Const Freezeprotectflag As String = "FREEZEPROTECTFLAG"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Workordernumber As String = "Workordernumber"
			 Public Const Custid As String = "Custid"
			 Public Const Billaddress1 As String = "Billaddress1"
			 Public Const Billaddress2 As String = "Billaddress2"
			 Public Const Billcity As String = "Billcity"
			 Public Const Billstateprov As String = "Billstateprov"
			 Public Const Billpostalcode As String = "Billpostalcode"
			 Public Const Billcountry As String = "Billcountry"
			 Public Const Billphone As String = "Billphone"
			 Public Const Billfax As String = "Billfax"
			 Public Const Billcontact As String = "Billcontact"
			 Public Const Shipaddress1 As String = "Shipaddress1"
			 Public Const Shipaddress2 As String = "Shipaddress2"
			 Public Const Shipcity As String = "Shipcity"
			 Public Const Shipstateprov As String = "Shipstateprov"
			 Public Const Shippostalcode As String = "Shippostalcode"
			 Public Const Shipcountry As String = "Shipcountry"
			 Public Const Shipcontact As String = "Shipcontact"
			 Public Const Freightcarrier As String = "Freightcarrier"
			 Public Const Fob As String = "Fob"
			 Public Const Customerpo As String = "Customerpo"
			 Public Const Orderterms As String = "Orderterms"
			 Public Const Deliverydate As String = "Deliverydate"
			 Public Const Plannedshipdate As String = "Plannedshipdate"
			 Public Const Howreceived As String = "Howreceived"
			 Public Const Orderstatus As String = "Orderstatus"
			 Public Const Ordernotes As String = "Ordernotes"
			 Public Const Workorderdate As String = "Workorderdate"
			 Public Const Preparedby As String = "Preparedby"
			 Public Const Suppliercompany As String = "Suppliercompany"
			 Public Const Subtotal As String = "Subtotal"
			 Public Const Logisticsid As String = "Logisticsid"
			 Public Const Createdby As String = "Createdby"
			 Public Const Createdtime As String = "Createdtime"
			 Public Const Modifyby As String = "Modifyby"
			 Public Const Modifytime As String = "Modifytime"
			 Public Const Shipphone As String = "Shipphone"
			 Public Const Shipemail As String = "Shipemail"
			 Public Const Carrierid As String = "Carrierid"
			 Public Const Workordertype As String = "Workordertype"
			 Public Const Onhold As String = "Onhold"
			 Public Const Onholdreason As String = "Onholdreason"
			 Public Const Freightcharges As String = "Freightcharges"
			 Public Const Freightbillable As String = "Freightbillable"
			 Public Const Freightbillcustomer As String = "Freightbillcustomer"
			 Public Const Freightoninvoice As String = "Freightoninvoice"
			 Public Const Vendorid As String = "Vendorid"
			 Public Const Billingtype As String = "Billingtype"
			 Public Const Transporttype As String = "Transporttype"
			 Public Const Ordertype As String = "Ordertype"
			 Public Const Salespersonid As String = "Salespersonid"
			 Public Const Prodfulfillmentnotes As String = "Prodfulfillmentnotes"
			 Public Const Transportationnotes As String = "Transportationnotes"
			 Public Const Billofladingnotes As String = "Billofladingnotes"
			 Public Const Accountingnotes As String = "Accountingnotes"
			 Public Const Orsoonerflag As String = "Orsoonerflag"
			 Public Const Freezeprotectflag As String = "Freezeprotectflag"
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
            SyncLock GetType(WorkorderMetadata)
			
				If WorkorderMetadata.mapDelegates Is Nothing Then
					WorkorderMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If WorkorderMetadata._meta Is Nothing Then
                    WorkorderMetadata._meta = New WorkorderMetadata()
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
				

				meta.AddTypeMap("Workordernumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Custid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Billaddress1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Billaddress2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Billcity", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Billstateprov", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Billpostalcode", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Billcountry", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Billphone", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Billfax", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Billcontact", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipaddress1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipaddress2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipcity", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipstateprov", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shippostalcode", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipcountry", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipcontact", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Freightcarrier", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Fob", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Customerpo", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Orderterms", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Deliverydate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Plannedshipdate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Howreceived", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Orderstatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Ordernotes", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Workorderdate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Preparedby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Suppliercompany", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Subtotal", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Logisticsid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Createdby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Createdtime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Modifyby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Modifytime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Shipphone", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipemail", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Carrierid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Workordertype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Onhold", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Onholdreason", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Freightcharges", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Freightbillable", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Freightbillcustomer", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Freightoninvoice", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Vendorid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Billingtype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Transporttype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Ordertype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Salespersonid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Prodfulfillmentnotes", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Transportationnotes", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Billofladingnotes", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Accountingnotes", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Orsoonerflag", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Freezeprotectflag", new esTypeMap("bit", "System.Boolean"))			
				
				
				 
				meta.Source = "WORKORDER"
				meta.Destination = "WORKORDER"
				
				meta.spInsert = "proc_WORKORDERInsert"
				meta.spUpdate = "proc_WORKORDERUpdate"
				meta.spDelete = "proc_WORKORDERDelete"
				meta.spLoadAll = "proc_WORKORDERLoadAll"
				meta.spLoadByPrimaryKey = "proc_WORKORDERLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As WorkorderMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
