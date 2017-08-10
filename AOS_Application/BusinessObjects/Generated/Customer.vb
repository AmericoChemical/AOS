'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 6/10/2014 12:12:21 PM
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
	MustInherit Public Class esCustomerCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "CustomerCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esCustomerQuery)
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
            Me.InitQuery(CType(query, esCustomerQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Customer) As Customer
			Return CType(MyBase.DetachEntity(entity), Customer)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Customer) As Customer
			Return CType(MyBase.AttachEntity(entity), Customer)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As CustomerCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Customer
            Get
                Return TryCast(MyBase.Item(index), Customer)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Customer)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esCustomer	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esCustomerQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal custid As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(custid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(custid)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal custid As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(custid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(custid)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal custid As System.Int32) As Boolean
		
			Dim query As esCustomerQuery = Me.GetDynamicQuery()
			query.Where(query.Custid.Equal(custid))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal custid As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("CUSTID", custid)
			
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
												
						Case "Custid"
							Me.str.Custid = CType(value, string)
												
						Case "Custname"
							Me.str.Custname = CType(value, string)
												
						Case "Custbilladdress1"
							Me.str.Custbilladdress1 = CType(value, string)
												
						Case "Custbilladdress2"
							Me.str.Custbilladdress2 = CType(value, string)
												
						Case "Custbillcity"
							Me.str.Custbillcity = CType(value, string)
												
						Case "Custbillstateprov"
							Me.str.Custbillstateprov = CType(value, string)
												
						Case "Custbillpostalcode"
							Me.str.Custbillpostalcode = CType(value, string)
												
						Case "Custbillcountry"
							Me.str.Custbillcountry = CType(value, string)
												
						Case "Custphone"
							Me.str.Custphone = CType(value, string)
												
						Case "Custfax"
							Me.str.Custfax = CType(value, string)
												
						Case "Custbillcontact"
							Me.str.Custbillcontact = CType(value, string)
												
						Case "Custshipaddress1"
							Me.str.Custshipaddress1 = CType(value, string)
												
						Case "Custshipaddress2"
							Me.str.Custshipaddress2 = CType(value, string)
												
						Case "Custshipcity"
							Me.str.Custshipcity = CType(value, string)
												
						Case "Custshipstateprov"
							Me.str.Custshipstateprov = CType(value, string)
												
						Case "Custshippostalcode"
							Me.str.Custshippostalcode = CType(value, string)
												
						Case "Custshipcountry"
							Me.str.Custshipcountry = CType(value, string)
												
						Case "Custshipcontact"
							Me.str.Custshipcontact = CType(value, string)
												
						Case "Freightcarrier1"
							Me.str.Freightcarrier1 = CType(value, string)
												
						Case "Freightcarrier2"
							Me.str.Freightcarrier2 = CType(value, string)
												
						Case "Fob"
							Me.str.Fob = CType(value, string)
												
						Case "Custnotes"
							Me.str.Custnotes = CType(value, string)
												
						Case "Taxexempt"
							Me.str.Taxexempt = CType(value, string)
												
						Case "Createdby"
							Me.str.Createdby = CType(value, string)
												
						Case "Createdtime"
							Me.str.Createdtime = CType(value, string)
												
						Case "Modifyby"
							Me.str.Modifyby = CType(value, string)
												
						Case "Modifytime"
							Me.str.Modifytime = CType(value, string)
												
						Case "Isactive"
							Me.str.Isactive = CType(value, string)
												
						Case "Carrierid"
							Me.str.Carrierid = CType(value, string)
												
						Case "Logisticsid"
							Me.str.Logisticsid = CType(value, string)
												
						Case "Bulkcarrierid"
							Me.str.Bulkcarrierid = CType(value, string)
												
						Case "Salespersonid"
							Me.str.Salespersonid = CType(value, string)
												
						Case "Freightbillcustomer"
							Me.str.Freightbillcustomer = CType(value, string)
												
						Case "Freightoninvoice"
							Me.str.Freightoninvoice = CType(value, string)
												
						Case "Ordernote"
							Me.str.Ordernote = CType(value, string)
												
						Case "Shipmentnote"
							Me.str.Shipmentnote = CType(value, string)
												
						Case "Invoicenote"
							Me.str.Invoicenote = CType(value, string)
												
						Case "Custemail"
							Me.str.Custemail = CType(value, string)
												
						Case "Needpackinglist"
							Me.str.Needpackinglist = CType(value, string)
												
						Case "Salesbycustomerreport"
							Me.str.Salesbycustomerreport = CType(value, string)
												
						Case "Secondarysalespersonid"
							Me.str.Secondarysalespersonid = CType(value, string)
												
						Case "Trendanalysisreport"
							Me.str.Trendanalysisreport = CType(value, string)
												
						Case "Accounttype"
							Me.str.Accounttype = CType(value, string)
												
						Case "Accountstatus"
							Me.str.Accountstatus = CType(value, string)
												
						Case "Prodfulfillmentnotes"
							Me.str.Prodfulfillmentnotes = CType(value, string)
												
						Case "Transportationnotes"
							Me.str.Transportationnotes = CType(value, string)
												
						Case "Billofladingnotes"
							Me.str.Billofladingnotes = CType(value, string)
												
						Case "Accountingnotes"
							Me.str.Accountingnotes = CType(value, string)
												
						Case "Isconsignment"
							Me.str.Isconsignment = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Custid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Custid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Createdtime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Createdtime = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Modifytime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Modifytime = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Isactive"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Isactive = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Carrierid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Carrierid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Logisticsid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Logisticsid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Bulkcarrierid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Bulkcarrierid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Salespersonid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Salespersonid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Freightbillcustomer"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Freightbillcustomer = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Freightoninvoice"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Freightoninvoice = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Needpackinglist"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Needpackinglist = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Salesbycustomerreport"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Salesbycustomerreport = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Secondarysalespersonid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Secondarysalespersonid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Trendanalysisreport"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Trendanalysisreport = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Isconsignment"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Isconsignment = CType(value, Nullable(Of System.Boolean))
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
		' Maps to CUSTOMER.CUSTID
		' </summary>
		Public Overridable Property Custid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(CustomerMetadata.ColumnNames.Custid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(CustomerMetadata.ColumnNames.Custid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CUSTOMER.CUSTNAME
		' </summary>
		Public Overridable Property Custname As System.String
			Get
				Return MyBase.GetSystemString(CustomerMetadata.ColumnNames.Custname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CustomerMetadata.ColumnNames.Custname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CUSTOMER.CUSTBILLADDRESS1
		' </summary>
		Public Overridable Property Custbilladdress1 As System.String
			Get
				Return MyBase.GetSystemString(CustomerMetadata.ColumnNames.Custbilladdress1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CustomerMetadata.ColumnNames.Custbilladdress1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CUSTOMER.CUSTBILLADDRESS2
		' </summary>
		Public Overridable Property Custbilladdress2 As System.String
			Get
				Return MyBase.GetSystemString(CustomerMetadata.ColumnNames.Custbilladdress2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CustomerMetadata.ColumnNames.Custbilladdress2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CUSTOMER.CUSTBILLCITY
		' </summary>
		Public Overridable Property Custbillcity As System.String
			Get
				Return MyBase.GetSystemString(CustomerMetadata.ColumnNames.Custbillcity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CustomerMetadata.ColumnNames.Custbillcity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CUSTOMER.CUSTBILLSTATEPROV
		' </summary>
		Public Overridable Property Custbillstateprov As System.String
			Get
				Return MyBase.GetSystemString(CustomerMetadata.ColumnNames.Custbillstateprov)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CustomerMetadata.ColumnNames.Custbillstateprov, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CUSTOMER.CUSTBILLPOSTALCODE
		' </summary>
		Public Overridable Property Custbillpostalcode As System.String
			Get
				Return MyBase.GetSystemString(CustomerMetadata.ColumnNames.Custbillpostalcode)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CustomerMetadata.ColumnNames.Custbillpostalcode, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CUSTOMER.CUSTBILLCOUNTRY
		' </summary>
		Public Overridable Property Custbillcountry As System.String
			Get
				Return MyBase.GetSystemString(CustomerMetadata.ColumnNames.Custbillcountry)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CustomerMetadata.ColumnNames.Custbillcountry, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CUSTOMER.CUSTPHONE
		' </summary>
		Public Overridable Property Custphone As System.String
			Get
				Return MyBase.GetSystemString(CustomerMetadata.ColumnNames.Custphone)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CustomerMetadata.ColumnNames.Custphone, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CUSTOMER.CUSTFAX
		' </summary>
		Public Overridable Property Custfax As System.String
			Get
				Return MyBase.GetSystemString(CustomerMetadata.ColumnNames.Custfax)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CustomerMetadata.ColumnNames.Custfax, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CUSTOMER.CUSTBILLCONTACT
		' </summary>
		Public Overridable Property Custbillcontact As System.String
			Get
				Return MyBase.GetSystemString(CustomerMetadata.ColumnNames.Custbillcontact)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CustomerMetadata.ColumnNames.Custbillcontact, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CUSTOMER.CUSTSHIPADDRESS1
		' </summary>
		Public Overridable Property Custshipaddress1 As System.String
			Get
				Return MyBase.GetSystemString(CustomerMetadata.ColumnNames.Custshipaddress1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CustomerMetadata.ColumnNames.Custshipaddress1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CUSTOMER.CUSTSHIPADDRESS2
		' </summary>
		Public Overridable Property Custshipaddress2 As System.String
			Get
				Return MyBase.GetSystemString(CustomerMetadata.ColumnNames.Custshipaddress2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CustomerMetadata.ColumnNames.Custshipaddress2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CUSTOMER.CUSTSHIPCITY
		' </summary>
		Public Overridable Property Custshipcity As System.String
			Get
				Return MyBase.GetSystemString(CustomerMetadata.ColumnNames.Custshipcity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CustomerMetadata.ColumnNames.Custshipcity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CUSTOMER.CUSTSHIPSTATEPROV
		' </summary>
		Public Overridable Property Custshipstateprov As System.String
			Get
				Return MyBase.GetSystemString(CustomerMetadata.ColumnNames.Custshipstateprov)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CustomerMetadata.ColumnNames.Custshipstateprov, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CUSTOMER.CUSTSHIPPOSTALCODE
		' </summary>
		Public Overridable Property Custshippostalcode As System.String
			Get
				Return MyBase.GetSystemString(CustomerMetadata.ColumnNames.Custshippostalcode)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CustomerMetadata.ColumnNames.Custshippostalcode, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CUSTOMER.CUSTSHIPCOUNTRY
		' </summary>
		Public Overridable Property Custshipcountry As System.String
			Get
				Return MyBase.GetSystemString(CustomerMetadata.ColumnNames.Custshipcountry)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CustomerMetadata.ColumnNames.Custshipcountry, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CUSTOMER.CUSTSHIPCONTACT
		' </summary>
		Public Overridable Property Custshipcontact As System.String
			Get
				Return MyBase.GetSystemString(CustomerMetadata.ColumnNames.Custshipcontact)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CustomerMetadata.ColumnNames.Custshipcontact, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CUSTOMER.FREIGHTCARRIER1
		' </summary>
		Public Overridable Property Freightcarrier1 As System.String
			Get
				Return MyBase.GetSystemString(CustomerMetadata.ColumnNames.Freightcarrier1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CustomerMetadata.ColumnNames.Freightcarrier1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CUSTOMER.FREIGHTCARRIER2
		' </summary>
		Public Overridable Property Freightcarrier2 As System.String
			Get
				Return MyBase.GetSystemString(CustomerMetadata.ColumnNames.Freightcarrier2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CustomerMetadata.ColumnNames.Freightcarrier2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CUSTOMER.FOB
		' </summary>
		Public Overridable Property Fob As System.String
			Get
				Return MyBase.GetSystemString(CustomerMetadata.ColumnNames.Fob)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CustomerMetadata.ColumnNames.Fob, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CUSTOMER.CUSTNOTES
		' </summary>
		Public Overridable Property Custnotes As System.String
			Get
				Return MyBase.GetSystemString(CustomerMetadata.ColumnNames.Custnotes)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CustomerMetadata.ColumnNames.Custnotes, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CUSTOMER.TAXEXEMPT
		' </summary>
		Public Overridable Property Taxexempt As System.String
			Get
				Return MyBase.GetSystemString(CustomerMetadata.ColumnNames.Taxexempt)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CustomerMetadata.ColumnNames.Taxexempt, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CUSTOMER.CREATEDBY
		' </summary>
		Public Overridable Property Createdby As System.String
			Get
				Return MyBase.GetSystemString(CustomerMetadata.ColumnNames.Createdby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CustomerMetadata.ColumnNames.Createdby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CUSTOMER.CREATEDTIME
		' </summary>
		Public Overridable Property Createdtime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(CustomerMetadata.ColumnNames.Createdtime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(CustomerMetadata.ColumnNames.Createdtime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CUSTOMER.MODIFYBY
		' </summary>
		Public Overridable Property Modifyby As System.String
			Get
				Return MyBase.GetSystemString(CustomerMetadata.ColumnNames.Modifyby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CustomerMetadata.ColumnNames.Modifyby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CUSTOMER.MODIFYTIME
		' </summary>
		Public Overridable Property Modifytime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(CustomerMetadata.ColumnNames.Modifytime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(CustomerMetadata.ColumnNames.Modifytime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CUSTOMER.ISACTIVE
		' </summary>
		Public Overridable Property Isactive As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(CustomerMetadata.ColumnNames.Isactive)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(CustomerMetadata.ColumnNames.Isactive, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CUSTOMER.CARRIERID
		' </summary>
		Public Overridable Property Carrierid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(CustomerMetadata.ColumnNames.Carrierid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(CustomerMetadata.ColumnNames.Carrierid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CUSTOMER.LOGISTICSID
		' </summary>
		Public Overridable Property Logisticsid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(CustomerMetadata.ColumnNames.Logisticsid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(CustomerMetadata.ColumnNames.Logisticsid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CUSTOMER.BULKCARRIERID
		' </summary>
		Public Overridable Property Bulkcarrierid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(CustomerMetadata.ColumnNames.Bulkcarrierid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(CustomerMetadata.ColumnNames.Bulkcarrierid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CUSTOMER.SALESPERSONID
		' </summary>
		Public Overridable Property Salespersonid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(CustomerMetadata.ColumnNames.Salespersonid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(CustomerMetadata.ColumnNames.Salespersonid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CUSTOMER.FREIGHTBILLCUSTOMER
		' </summary>
		Public Overridable Property Freightbillcustomer As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(CustomerMetadata.ColumnNames.Freightbillcustomer)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(CustomerMetadata.ColumnNames.Freightbillcustomer, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CUSTOMER.FREIGHTONINVOICE
		' </summary>
		Public Overridable Property Freightoninvoice As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(CustomerMetadata.ColumnNames.Freightoninvoice)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(CustomerMetadata.ColumnNames.Freightoninvoice, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CUSTOMER.ORDERNOTE
		' </summary>
		Public Overridable Property Ordernote As System.String
			Get
				Return MyBase.GetSystemString(CustomerMetadata.ColumnNames.Ordernote)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CustomerMetadata.ColumnNames.Ordernote, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CUSTOMER.SHIPMENTNOTE
		' </summary>
		Public Overridable Property Shipmentnote As System.String
			Get
				Return MyBase.GetSystemString(CustomerMetadata.ColumnNames.Shipmentnote)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CustomerMetadata.ColumnNames.Shipmentnote, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CUSTOMER.INVOICENOTE
		' </summary>
		Public Overridable Property Invoicenote As System.String
			Get
				Return MyBase.GetSystemString(CustomerMetadata.ColumnNames.Invoicenote)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CustomerMetadata.ColumnNames.Invoicenote, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CUSTOMER.CUSTEMAIL
		' </summary>
		Public Overridable Property Custemail As System.String
			Get
				Return MyBase.GetSystemString(CustomerMetadata.ColumnNames.Custemail)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CustomerMetadata.ColumnNames.Custemail, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CUSTOMER.NEEDPACKINGLIST
		' </summary>
		Public Overridable Property Needpackinglist As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(CustomerMetadata.ColumnNames.Needpackinglist)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(CustomerMetadata.ColumnNames.Needpackinglist, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CUSTOMER.SALESBYCUSTOMERREPORT
		' </summary>
		Public Overridable Property Salesbycustomerreport As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(CustomerMetadata.ColumnNames.Salesbycustomerreport)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(CustomerMetadata.ColumnNames.Salesbycustomerreport, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CUSTOMER.SECONDARYSALESPERSONID
		' </summary>
		Public Overridable Property Secondarysalespersonid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(CustomerMetadata.ColumnNames.Secondarysalespersonid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(CustomerMetadata.ColumnNames.Secondarysalespersonid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CUSTOMER.TRENDANALYSISREPORT
		' </summary>
		Public Overridable Property Trendanalysisreport As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(CustomerMetadata.ColumnNames.Trendanalysisreport)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(CustomerMetadata.ColumnNames.Trendanalysisreport, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CUSTOMER.ACCOUNTTYPE
		' </summary>
		Public Overridable Property Accounttype As System.String
			Get
				Return MyBase.GetSystemString(CustomerMetadata.ColumnNames.Accounttype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CustomerMetadata.ColumnNames.Accounttype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CUSTOMER.ACCOUNTSTATUS
		' </summary>
		Public Overridable Property Accountstatus As System.String
			Get
				Return MyBase.GetSystemString(CustomerMetadata.ColumnNames.Accountstatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CustomerMetadata.ColumnNames.Accountstatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CUSTOMER.PRODFULFILLMENTNOTES
		' </summary>
		Public Overridable Property Prodfulfillmentnotes As System.String
			Get
				Return MyBase.GetSystemString(CustomerMetadata.ColumnNames.Prodfulfillmentnotes)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CustomerMetadata.ColumnNames.Prodfulfillmentnotes, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CUSTOMER.TRANSPORTATIONNOTES
		' </summary>
		Public Overridable Property Transportationnotes As System.String
			Get
				Return MyBase.GetSystemString(CustomerMetadata.ColumnNames.Transportationnotes)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CustomerMetadata.ColumnNames.Transportationnotes, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CUSTOMER.BILLOFLADINGNOTES
		' </summary>
		Public Overridable Property Billofladingnotes As System.String
			Get
				Return MyBase.GetSystemString(CustomerMetadata.ColumnNames.Billofladingnotes)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CustomerMetadata.ColumnNames.Billofladingnotes, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CUSTOMER.ACCOUNTINGNOTES
		' </summary>
		Public Overridable Property Accountingnotes As System.String
			Get
				Return MyBase.GetSystemString(CustomerMetadata.ColumnNames.Accountingnotes)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CustomerMetadata.ColumnNames.Accountingnotes, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CUSTOMER.ISCONSIGNMENT
		' </summary>
		Public Overridable Property Isconsignment As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(CustomerMetadata.ColumnNames.Isconsignment)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(CustomerMetadata.ColumnNames.Isconsignment, value)
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
		
			Public Sub New(ByVal entity As esCustomer)
				Me.entity = entity
			End Sub				
		
	
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
		  	
			Public Property Custname As System.String 
				Get
					Dim data_ As System.String = entity.Custname
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Custname = Nothing
					Else
						entity.Custname = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Custbilladdress1 As System.String 
				Get
					Dim data_ As System.String = entity.Custbilladdress1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Custbilladdress1 = Nothing
					Else
						entity.Custbilladdress1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Custbilladdress2 As System.String 
				Get
					Dim data_ As System.String = entity.Custbilladdress2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Custbilladdress2 = Nothing
					Else
						entity.Custbilladdress2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Custbillcity As System.String 
				Get
					Dim data_ As System.String = entity.Custbillcity
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Custbillcity = Nothing
					Else
						entity.Custbillcity = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Custbillstateprov As System.String 
				Get
					Dim data_ As System.String = entity.Custbillstateprov
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Custbillstateprov = Nothing
					Else
						entity.Custbillstateprov = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Custbillpostalcode As System.String 
				Get
					Dim data_ As System.String = entity.Custbillpostalcode
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Custbillpostalcode = Nothing
					Else
						entity.Custbillpostalcode = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Custbillcountry As System.String 
				Get
					Dim data_ As System.String = entity.Custbillcountry
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Custbillcountry = Nothing
					Else
						entity.Custbillcountry = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Custphone As System.String 
				Get
					Dim data_ As System.String = entity.Custphone
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Custphone = Nothing
					Else
						entity.Custphone = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Custfax As System.String 
				Get
					Dim data_ As System.String = entity.Custfax
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Custfax = Nothing
					Else
						entity.Custfax = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Custbillcontact As System.String 
				Get
					Dim data_ As System.String = entity.Custbillcontact
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Custbillcontact = Nothing
					Else
						entity.Custbillcontact = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Custshipaddress1 As System.String 
				Get
					Dim data_ As System.String = entity.Custshipaddress1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Custshipaddress1 = Nothing
					Else
						entity.Custshipaddress1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Custshipaddress2 As System.String 
				Get
					Dim data_ As System.String = entity.Custshipaddress2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Custshipaddress2 = Nothing
					Else
						entity.Custshipaddress2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Custshipcity As System.String 
				Get
					Dim data_ As System.String = entity.Custshipcity
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Custshipcity = Nothing
					Else
						entity.Custshipcity = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Custshipstateprov As System.String 
				Get
					Dim data_ As System.String = entity.Custshipstateprov
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Custshipstateprov = Nothing
					Else
						entity.Custshipstateprov = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Custshippostalcode As System.String 
				Get
					Dim data_ As System.String = entity.Custshippostalcode
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Custshippostalcode = Nothing
					Else
						entity.Custshippostalcode = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Custshipcountry As System.String 
				Get
					Dim data_ As System.String = entity.Custshipcountry
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Custshipcountry = Nothing
					Else
						entity.Custshipcountry = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Custshipcontact As System.String 
				Get
					Dim data_ As System.String = entity.Custshipcontact
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Custshipcontact = Nothing
					Else
						entity.Custshipcontact = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Freightcarrier1 As System.String 
				Get
					Dim data_ As System.String = entity.Freightcarrier1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Freightcarrier1 = Nothing
					Else
						entity.Freightcarrier1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Freightcarrier2 As System.String 
				Get
					Dim data_ As System.String = entity.Freightcarrier2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Freightcarrier2 = Nothing
					Else
						entity.Freightcarrier2 = Convert.ToString(Value)
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
		  	
			Public Property Custnotes As System.String 
				Get
					Dim data_ As System.String = entity.Custnotes
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Custnotes = Nothing
					Else
						entity.Custnotes = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Taxexempt As System.String 
				Get
					Dim data_ As System.String = entity.Taxexempt
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Taxexempt = Nothing
					Else
						entity.Taxexempt = Convert.ToString(Value)
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
		  	
			Public Property Isactive As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Isactive
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Isactive = Nothing
					Else
						entity.Isactive = Convert.ToBoolean(Value)
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
		  	
			Public Property Bulkcarrierid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Bulkcarrierid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Bulkcarrierid = Nothing
					Else
						entity.Bulkcarrierid = Convert.ToInt32(Value)
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
		  	
			Public Property Ordernote As System.String 
				Get
					Dim data_ As System.String = entity.Ordernote
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Ordernote = Nothing
					Else
						entity.Ordernote = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shipmentnote As System.String 
				Get
					Dim data_ As System.String = entity.Shipmentnote
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipmentnote = Nothing
					Else
						entity.Shipmentnote = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Invoicenote As System.String 
				Get
					Dim data_ As System.String = entity.Invoicenote
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Invoicenote = Nothing
					Else
						entity.Invoicenote = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Custemail As System.String 
				Get
					Dim data_ As System.String = entity.Custemail
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Custemail = Nothing
					Else
						entity.Custemail = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Needpackinglist As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Needpackinglist
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Needpackinglist = Nothing
					Else
						entity.Needpackinglist = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property Salesbycustomerreport As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Salesbycustomerreport
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Salesbycustomerreport = Nothing
					Else
						entity.Salesbycustomerreport = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property Secondarysalespersonid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Secondarysalespersonid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Secondarysalespersonid = Nothing
					Else
						entity.Secondarysalespersonid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Trendanalysisreport As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Trendanalysisreport
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Trendanalysisreport = Nothing
					Else
						entity.Trendanalysisreport = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property Accounttype As System.String 
				Get
					Dim data_ As System.String = entity.Accounttype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Accounttype = Nothing
					Else
						entity.Accounttype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Accountstatus As System.String 
				Get
					Dim data_ As System.String = entity.Accountstatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Accountstatus = Nothing
					Else
						entity.Accountstatus = Convert.ToString(Value)
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
		  	
			Public Property Isconsignment As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Isconsignment
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Isconsignment = Nothing
					Else
						entity.Isconsignment = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  

			Private entity As esCustomer
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esCustomerQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esCustomer can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Customer 
		Inherits esCustomer
		
	
		
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
	MustInherit Public Class esCustomerQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return CustomerMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Custid As esQueryItem
			Get
				Return New esQueryItem(Me, CustomerMetadata.ColumnNames.Custid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Custname As esQueryItem
			Get
				Return New esQueryItem(Me, CustomerMetadata.ColumnNames.Custname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Custbilladdress1 As esQueryItem
			Get
				Return New esQueryItem(Me, CustomerMetadata.ColumnNames.Custbilladdress1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Custbilladdress2 As esQueryItem
			Get
				Return New esQueryItem(Me, CustomerMetadata.ColumnNames.Custbilladdress2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Custbillcity As esQueryItem
			Get
				Return New esQueryItem(Me, CustomerMetadata.ColumnNames.Custbillcity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Custbillstateprov As esQueryItem
			Get
				Return New esQueryItem(Me, CustomerMetadata.ColumnNames.Custbillstateprov, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Custbillpostalcode As esQueryItem
			Get
				Return New esQueryItem(Me, CustomerMetadata.ColumnNames.Custbillpostalcode, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Custbillcountry As esQueryItem
			Get
				Return New esQueryItem(Me, CustomerMetadata.ColumnNames.Custbillcountry, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Custphone As esQueryItem
			Get
				Return New esQueryItem(Me, CustomerMetadata.ColumnNames.Custphone, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Custfax As esQueryItem
			Get
				Return New esQueryItem(Me, CustomerMetadata.ColumnNames.Custfax, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Custbillcontact As esQueryItem
			Get
				Return New esQueryItem(Me, CustomerMetadata.ColumnNames.Custbillcontact, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Custshipaddress1 As esQueryItem
			Get
				Return New esQueryItem(Me, CustomerMetadata.ColumnNames.Custshipaddress1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Custshipaddress2 As esQueryItem
			Get
				Return New esQueryItem(Me, CustomerMetadata.ColumnNames.Custshipaddress2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Custshipcity As esQueryItem
			Get
				Return New esQueryItem(Me, CustomerMetadata.ColumnNames.Custshipcity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Custshipstateprov As esQueryItem
			Get
				Return New esQueryItem(Me, CustomerMetadata.ColumnNames.Custshipstateprov, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Custshippostalcode As esQueryItem
			Get
				Return New esQueryItem(Me, CustomerMetadata.ColumnNames.Custshippostalcode, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Custshipcountry As esQueryItem
			Get
				Return New esQueryItem(Me, CustomerMetadata.ColumnNames.Custshipcountry, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Custshipcontact As esQueryItem
			Get
				Return New esQueryItem(Me, CustomerMetadata.ColumnNames.Custshipcontact, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Freightcarrier1 As esQueryItem
			Get
				Return New esQueryItem(Me, CustomerMetadata.ColumnNames.Freightcarrier1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Freightcarrier2 As esQueryItem
			Get
				Return New esQueryItem(Me, CustomerMetadata.ColumnNames.Freightcarrier2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Fob As esQueryItem
			Get
				Return New esQueryItem(Me, CustomerMetadata.ColumnNames.Fob, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Custnotes As esQueryItem
			Get
				Return New esQueryItem(Me, CustomerMetadata.ColumnNames.Custnotes, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Taxexempt As esQueryItem
			Get
				Return New esQueryItem(Me, CustomerMetadata.ColumnNames.Taxexempt, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Createdby As esQueryItem
			Get
				Return New esQueryItem(Me, CustomerMetadata.ColumnNames.Createdby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Createdtime As esQueryItem
			Get
				Return New esQueryItem(Me, CustomerMetadata.ColumnNames.Createdtime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Modifyby As esQueryItem
			Get
				Return New esQueryItem(Me, CustomerMetadata.ColumnNames.Modifyby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Modifytime As esQueryItem
			Get
				Return New esQueryItem(Me, CustomerMetadata.ColumnNames.Modifytime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Isactive As esQueryItem
			Get
				Return New esQueryItem(Me, CustomerMetadata.ColumnNames.Isactive, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Carrierid As esQueryItem
			Get
				Return New esQueryItem(Me, CustomerMetadata.ColumnNames.Carrierid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Logisticsid As esQueryItem
			Get
				Return New esQueryItem(Me, CustomerMetadata.ColumnNames.Logisticsid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Bulkcarrierid As esQueryItem
			Get
				Return New esQueryItem(Me, CustomerMetadata.ColumnNames.Bulkcarrierid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Salespersonid As esQueryItem
			Get
				Return New esQueryItem(Me, CustomerMetadata.ColumnNames.Salespersonid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Freightbillcustomer As esQueryItem
			Get
				Return New esQueryItem(Me, CustomerMetadata.ColumnNames.Freightbillcustomer, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Freightoninvoice As esQueryItem
			Get
				Return New esQueryItem(Me, CustomerMetadata.ColumnNames.Freightoninvoice, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Ordernote As esQueryItem
			Get
				Return New esQueryItem(Me, CustomerMetadata.ColumnNames.Ordernote, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipmentnote As esQueryItem
			Get
				Return New esQueryItem(Me, CustomerMetadata.ColumnNames.Shipmentnote, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Invoicenote As esQueryItem
			Get
				Return New esQueryItem(Me, CustomerMetadata.ColumnNames.Invoicenote, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Custemail As esQueryItem
			Get
				Return New esQueryItem(Me, CustomerMetadata.ColumnNames.Custemail, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Needpackinglist As esQueryItem
			Get
				Return New esQueryItem(Me, CustomerMetadata.ColumnNames.Needpackinglist, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Salesbycustomerreport As esQueryItem
			Get
				Return New esQueryItem(Me, CustomerMetadata.ColumnNames.Salesbycustomerreport, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Secondarysalespersonid As esQueryItem
			Get
				Return New esQueryItem(Me, CustomerMetadata.ColumnNames.Secondarysalespersonid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Trendanalysisreport As esQueryItem
			Get
				Return New esQueryItem(Me, CustomerMetadata.ColumnNames.Trendanalysisreport, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Accounttype As esQueryItem
			Get
				Return New esQueryItem(Me, CustomerMetadata.ColumnNames.Accounttype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Accountstatus As esQueryItem
			Get
				Return New esQueryItem(Me, CustomerMetadata.ColumnNames.Accountstatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Prodfulfillmentnotes As esQueryItem
			Get
				Return New esQueryItem(Me, CustomerMetadata.ColumnNames.Prodfulfillmentnotes, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Transportationnotes As esQueryItem
			Get
				Return New esQueryItem(Me, CustomerMetadata.ColumnNames.Transportationnotes, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Billofladingnotes As esQueryItem
			Get
				Return New esQueryItem(Me, CustomerMetadata.ColumnNames.Billofladingnotes, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Accountingnotes As esQueryItem
			Get
				Return New esQueryItem(Me, CustomerMetadata.ColumnNames.Accountingnotes, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Isconsignment As esQueryItem
			Get
				Return New esQueryItem(Me, CustomerMetadata.ColumnNames.Isconsignment, esSystemType.Boolean)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("CustomerCollection")> _
	Partial Public Class CustomerCollection
		Inherits esCustomerCollection
		Implements IEnumerable(Of Customer)
		
        Public Shared Widening Operator CType(ByVal coll As CustomerCollection) As List(Of Customer)
            Dim list As List(Of Customer) = New List(Of Customer)
            Dim emp As Customer

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return CustomerMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New CustomerQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Customer(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Customer()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As CustomerQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New CustomerQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As CustomerQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Customer 
			Return CType(MyBase.AddNewEntity(), Customer)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal custid As System.Int32) As Customer
			Return CType(MyBase.FindByPrimaryKey(custid), Customer)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Customer) Implements IEnumerable(Of Customer).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Customer)(Me)
        End Function
		
		Private _query As CustomerQuery

	End Class
	


	' <summary>
	' Encapsulates the 'CUSTOMER' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Customer ({Custid.Value})")> _
	<Serializable> _
	Partial Public Class Customer 
		Inherits esCustomer

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return CustomerMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esCustomerQuery

			If Me._query Is Nothing Then
				Me._query = New CustomerQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As CustomerQuery
			Get

				If Me._query Is Nothing then
					Me._query = New CustomerQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As CustomerQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As CustomerQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class CustomerQuery
		inherits esCustomerQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "CustomerQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class CustomerMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(CustomerMetadata.ColumnNames.Custid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = CustomerMetadata.PropertyNames.Custid
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(CustomerMetadata.ColumnNames.Custname, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = CustomerMetadata.PropertyNames.Custname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CustomerMetadata.ColumnNames.Custbilladdress1, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = CustomerMetadata.PropertyNames.Custbilladdress1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CustomerMetadata.ColumnNames.Custbilladdress2, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = CustomerMetadata.PropertyNames.Custbilladdress2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CustomerMetadata.ColumnNames.Custbillcity, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = CustomerMetadata.PropertyNames.Custbillcity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CustomerMetadata.ColumnNames.Custbillstateprov, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = CustomerMetadata.PropertyNames.Custbillstateprov
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CustomerMetadata.ColumnNames.Custbillpostalcode, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = CustomerMetadata.PropertyNames.Custbillpostalcode
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CustomerMetadata.ColumnNames.Custbillcountry, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = CustomerMetadata.PropertyNames.Custbillcountry
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CustomerMetadata.ColumnNames.Custphone, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = CustomerMetadata.PropertyNames.Custphone
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CustomerMetadata.ColumnNames.Custfax, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = CustomerMetadata.PropertyNames.Custfax
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CustomerMetadata.ColumnNames.Custbillcontact, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = CustomerMetadata.PropertyNames.Custbillcontact
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CustomerMetadata.ColumnNames.Custshipaddress1, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = CustomerMetadata.PropertyNames.Custshipaddress1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CustomerMetadata.ColumnNames.Custshipaddress2, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = CustomerMetadata.PropertyNames.Custshipaddress2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CustomerMetadata.ColumnNames.Custshipcity, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = CustomerMetadata.PropertyNames.Custshipcity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CustomerMetadata.ColumnNames.Custshipstateprov, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = CustomerMetadata.PropertyNames.Custshipstateprov
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CustomerMetadata.ColumnNames.Custshippostalcode, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = CustomerMetadata.PropertyNames.Custshippostalcode
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CustomerMetadata.ColumnNames.Custshipcountry, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = CustomerMetadata.PropertyNames.Custshipcountry
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CustomerMetadata.ColumnNames.Custshipcontact, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = CustomerMetadata.PropertyNames.Custshipcontact
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CustomerMetadata.ColumnNames.Freightcarrier1, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = CustomerMetadata.PropertyNames.Freightcarrier1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CustomerMetadata.ColumnNames.Freightcarrier2, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = CustomerMetadata.PropertyNames.Freightcarrier2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CustomerMetadata.ColumnNames.Fob, 20, GetType(System.String), esSystemType.String)	
			c.PropertyName = CustomerMetadata.PropertyNames.Fob
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CustomerMetadata.ColumnNames.Custnotes, 21, GetType(System.String), esSystemType.String)	
			c.PropertyName = CustomerMetadata.PropertyNames.Custnotes
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CustomerMetadata.ColumnNames.Taxexempt, 22, GetType(System.String), esSystemType.String)	
			c.PropertyName = CustomerMetadata.PropertyNames.Taxexempt
			c.CharacterMaxLength = 1
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CustomerMetadata.ColumnNames.Createdby, 23, GetType(System.String), esSystemType.String)	
			c.PropertyName = CustomerMetadata.PropertyNames.Createdby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CustomerMetadata.ColumnNames.Createdtime, 24, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = CustomerMetadata.PropertyNames.Createdtime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CustomerMetadata.ColumnNames.Modifyby, 25, GetType(System.String), esSystemType.String)	
			c.PropertyName = CustomerMetadata.PropertyNames.Modifyby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CustomerMetadata.ColumnNames.Modifytime, 26, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = CustomerMetadata.PropertyNames.Modifytime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CustomerMetadata.ColumnNames.Isactive, 27, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = CustomerMetadata.PropertyNames.Isactive
			c.HasDefault = True
			c.Default = "((1))"
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CustomerMetadata.ColumnNames.Carrierid, 28, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = CustomerMetadata.PropertyNames.Carrierid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CustomerMetadata.ColumnNames.Logisticsid, 29, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = CustomerMetadata.PropertyNames.Logisticsid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CustomerMetadata.ColumnNames.Bulkcarrierid, 30, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = CustomerMetadata.PropertyNames.Bulkcarrierid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CustomerMetadata.ColumnNames.Salespersonid, 31, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = CustomerMetadata.PropertyNames.Salespersonid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CustomerMetadata.ColumnNames.Freightbillcustomer, 32, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = CustomerMetadata.PropertyNames.Freightbillcustomer
			c.HasDefault = True
			c.Default = "((0))"
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CustomerMetadata.ColumnNames.Freightoninvoice, 33, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = CustomerMetadata.PropertyNames.Freightoninvoice
			c.HasDefault = True
			c.Default = "((0))"
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CustomerMetadata.ColumnNames.Ordernote, 34, GetType(System.String), esSystemType.String)	
			c.PropertyName = CustomerMetadata.PropertyNames.Ordernote
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CustomerMetadata.ColumnNames.Shipmentnote, 35, GetType(System.String), esSystemType.String)	
			c.PropertyName = CustomerMetadata.PropertyNames.Shipmentnote
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CustomerMetadata.ColumnNames.Invoicenote, 36, GetType(System.String), esSystemType.String)	
			c.PropertyName = CustomerMetadata.PropertyNames.Invoicenote
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CustomerMetadata.ColumnNames.Custemail, 37, GetType(System.String), esSystemType.String)	
			c.PropertyName = CustomerMetadata.PropertyNames.Custemail
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CustomerMetadata.ColumnNames.Needpackinglist, 38, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = CustomerMetadata.PropertyNames.Needpackinglist
			c.HasDefault = True
			c.Default = "((1))"
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CustomerMetadata.ColumnNames.Salesbycustomerreport, 39, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = CustomerMetadata.PropertyNames.Salesbycustomerreport
			c.HasDefault = True
			c.Default = "((1))"
			_columns.Add(c)
				
			c = New esColumnMetadata(CustomerMetadata.ColumnNames.Secondarysalespersonid, 40, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = CustomerMetadata.PropertyNames.Secondarysalespersonid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CustomerMetadata.ColumnNames.Trendanalysisreport, 41, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = CustomerMetadata.PropertyNames.Trendanalysisreport
			c.HasDefault = True
			c.Default = "((1))"
			_columns.Add(c)
				
			c = New esColumnMetadata(CustomerMetadata.ColumnNames.Accounttype, 42, GetType(System.String), esSystemType.String)	
			c.PropertyName = CustomerMetadata.PropertyNames.Accounttype
			c.CharacterMaxLength = 50
			c.HasDefault = True
			c.Default = "('REGULAR')"
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CustomerMetadata.ColumnNames.Accountstatus, 43, GetType(System.String), esSystemType.String)	
			c.PropertyName = CustomerMetadata.PropertyNames.Accountstatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CustomerMetadata.ColumnNames.Prodfulfillmentnotes, 44, GetType(System.String), esSystemType.String)	
			c.PropertyName = CustomerMetadata.PropertyNames.Prodfulfillmentnotes
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CustomerMetadata.ColumnNames.Transportationnotes, 45, GetType(System.String), esSystemType.String)	
			c.PropertyName = CustomerMetadata.PropertyNames.Transportationnotes
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CustomerMetadata.ColumnNames.Billofladingnotes, 46, GetType(System.String), esSystemType.String)	
			c.PropertyName = CustomerMetadata.PropertyNames.Billofladingnotes
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CustomerMetadata.ColumnNames.Accountingnotes, 47, GetType(System.String), esSystemType.String)	
			c.PropertyName = CustomerMetadata.PropertyNames.Accountingnotes
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CustomerMetadata.ColumnNames.Isconsignment, 48, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = CustomerMetadata.PropertyNames.Isconsignment
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As CustomerMetadata
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
			 Public Const Custid As String = "CUSTID"
			 Public Const Custname As String = "CUSTNAME"
			 Public Const Custbilladdress1 As String = "CUSTBILLADDRESS1"
			 Public Const Custbilladdress2 As String = "CUSTBILLADDRESS2"
			 Public Const Custbillcity As String = "CUSTBILLCITY"
			 Public Const Custbillstateprov As String = "CUSTBILLSTATEPROV"
			 Public Const Custbillpostalcode As String = "CUSTBILLPOSTALCODE"
			 Public Const Custbillcountry As String = "CUSTBILLCOUNTRY"
			 Public Const Custphone As String = "CUSTPHONE"
			 Public Const Custfax As String = "CUSTFAX"
			 Public Const Custbillcontact As String = "CUSTBILLCONTACT"
			 Public Const Custshipaddress1 As String = "CUSTSHIPADDRESS1"
			 Public Const Custshipaddress2 As String = "CUSTSHIPADDRESS2"
			 Public Const Custshipcity As String = "CUSTSHIPCITY"
			 Public Const Custshipstateprov As String = "CUSTSHIPSTATEPROV"
			 Public Const Custshippostalcode As String = "CUSTSHIPPOSTALCODE"
			 Public Const Custshipcountry As String = "CUSTSHIPCOUNTRY"
			 Public Const Custshipcontact As String = "CUSTSHIPCONTACT"
			 Public Const Freightcarrier1 As String = "FREIGHTCARRIER1"
			 Public Const Freightcarrier2 As String = "FREIGHTCARRIER2"
			 Public Const Fob As String = "FOB"
			 Public Const Custnotes As String = "CUSTNOTES"
			 Public Const Taxexempt As String = "TAXEXEMPT"
			 Public Const Createdby As String = "CREATEDBY"
			 Public Const Createdtime As String = "CREATEDTIME"
			 Public Const Modifyby As String = "MODIFYBY"
			 Public Const Modifytime As String = "MODIFYTIME"
			 Public Const Isactive As String = "ISACTIVE"
			 Public Const Carrierid As String = "CARRIERID"
			 Public Const Logisticsid As String = "LOGISTICSID"
			 Public Const Bulkcarrierid As String = "BULKCARRIERID"
			 Public Const Salespersonid As String = "SALESPERSONID"
			 Public Const Freightbillcustomer As String = "FREIGHTBILLCUSTOMER"
			 Public Const Freightoninvoice As String = "FREIGHTONINVOICE"
			 Public Const Ordernote As String = "ORDERNOTE"
			 Public Const Shipmentnote As String = "SHIPMENTNOTE"
			 Public Const Invoicenote As String = "INVOICENOTE"
			 Public Const Custemail As String = "CUSTEMAIL"
			 Public Const Needpackinglist As String = "NEEDPACKINGLIST"
			 Public Const Salesbycustomerreport As String = "SALESBYCUSTOMERREPORT"
			 Public Const Secondarysalespersonid As String = "SECONDARYSALESPERSONID"
			 Public Const Trendanalysisreport As String = "TRENDANALYSISREPORT"
			 Public Const Accounttype As String = "ACCOUNTTYPE"
			 Public Const Accountstatus As String = "ACCOUNTSTATUS"
			 Public Const Prodfulfillmentnotes As String = "PRODFULFILLMENTNOTES"
			 Public Const Transportationnotes As String = "TRANSPORTATIONNOTES"
			 Public Const Billofladingnotes As String = "BILLOFLADINGNOTES"
			 Public Const Accountingnotes As String = "ACCOUNTINGNOTES"
			 Public Const Isconsignment As String = "ISCONSIGNMENT"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Custid As String = "Custid"
			 Public Const Custname As String = "Custname"
			 Public Const Custbilladdress1 As String = "Custbilladdress1"
			 Public Const Custbilladdress2 As String = "Custbilladdress2"
			 Public Const Custbillcity As String = "Custbillcity"
			 Public Const Custbillstateprov As String = "Custbillstateprov"
			 Public Const Custbillpostalcode As String = "Custbillpostalcode"
			 Public Const Custbillcountry As String = "Custbillcountry"
			 Public Const Custphone As String = "Custphone"
			 Public Const Custfax As String = "Custfax"
			 Public Const Custbillcontact As String = "Custbillcontact"
			 Public Const Custshipaddress1 As String = "Custshipaddress1"
			 Public Const Custshipaddress2 As String = "Custshipaddress2"
			 Public Const Custshipcity As String = "Custshipcity"
			 Public Const Custshipstateprov As String = "Custshipstateprov"
			 Public Const Custshippostalcode As String = "Custshippostalcode"
			 Public Const Custshipcountry As String = "Custshipcountry"
			 Public Const Custshipcontact As String = "Custshipcontact"
			 Public Const Freightcarrier1 As String = "Freightcarrier1"
			 Public Const Freightcarrier2 As String = "Freightcarrier2"
			 Public Const Fob As String = "Fob"
			 Public Const Custnotes As String = "Custnotes"
			 Public Const Taxexempt As String = "Taxexempt"
			 Public Const Createdby As String = "Createdby"
			 Public Const Createdtime As String = "Createdtime"
			 Public Const Modifyby As String = "Modifyby"
			 Public Const Modifytime As String = "Modifytime"
			 Public Const Isactive As String = "Isactive"
			 Public Const Carrierid As String = "Carrierid"
			 Public Const Logisticsid As String = "Logisticsid"
			 Public Const Bulkcarrierid As String = "Bulkcarrierid"
			 Public Const Salespersonid As String = "Salespersonid"
			 Public Const Freightbillcustomer As String = "Freightbillcustomer"
			 Public Const Freightoninvoice As String = "Freightoninvoice"
			 Public Const Ordernote As String = "Ordernote"
			 Public Const Shipmentnote As String = "Shipmentnote"
			 Public Const Invoicenote As String = "Invoicenote"
			 Public Const Custemail As String = "Custemail"
			 Public Const Needpackinglist As String = "Needpackinglist"
			 Public Const Salesbycustomerreport As String = "Salesbycustomerreport"
			 Public Const Secondarysalespersonid As String = "Secondarysalespersonid"
			 Public Const Trendanalysisreport As String = "Trendanalysisreport"
			 Public Const Accounttype As String = "Accounttype"
			 Public Const Accountstatus As String = "Accountstatus"
			 Public Const Prodfulfillmentnotes As String = "Prodfulfillmentnotes"
			 Public Const Transportationnotes As String = "Transportationnotes"
			 Public Const Billofladingnotes As String = "Billofladingnotes"
			 Public Const Accountingnotes As String = "Accountingnotes"
			 Public Const Isconsignment As String = "Isconsignment"
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
            SyncLock GetType(CustomerMetadata)
			
				If CustomerMetadata.mapDelegates Is Nothing Then
					CustomerMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If CustomerMetadata._meta Is Nothing Then
                    CustomerMetadata._meta = New CustomerMetadata()
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
				

				meta.AddTypeMap("Custid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Custname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Custbilladdress1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Custbilladdress2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Custbillcity", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Custbillstateprov", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Custbillpostalcode", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Custbillcountry", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Custphone", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Custfax", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Custbillcontact", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Custshipaddress1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Custshipaddress2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Custshipcity", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Custshipstateprov", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Custshippostalcode", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Custshipcountry", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Custshipcontact", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Freightcarrier1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Freightcarrier2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Fob", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Custnotes", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Taxexempt", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Createdby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Createdtime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Modifyby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Modifytime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Isactive", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Carrierid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Logisticsid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Bulkcarrierid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Salespersonid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Freightbillcustomer", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Freightoninvoice", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Ordernote", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipmentnote", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Invoicenote", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Custemail", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Needpackinglist", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Salesbycustomerreport", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Secondarysalespersonid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Trendanalysisreport", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Accounttype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Accountstatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Prodfulfillmentnotes", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Transportationnotes", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Billofladingnotes", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Accountingnotes", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Isconsignment", new esTypeMap("bit", "System.Boolean"))			
				
				
				 
				meta.Source = "CUSTOMER"
				meta.Destination = "CUSTOMER"
				
				meta.spInsert = "proc_CUSTOMERInsert"
				meta.spUpdate = "proc_CUSTOMERUpdate"
				meta.spDelete = "proc_CUSTOMERDelete"
				meta.spLoadAll = "proc_CUSTOMERLoadAll"
				meta.spLoadByPrimaryKey = "proc_CUSTOMERLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As CustomerMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
