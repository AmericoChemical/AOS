'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 3/18/2014 12:58:48 PM
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
	MustInherit Public Class esBDFInvoiceCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "BDFInvoiceCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esBDFInvoiceQuery)
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
            Me.InitQuery(CType(query, esBDFInvoiceQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As BDFInvoice) As BDFInvoice
			Return CType(MyBase.DetachEntity(entity), BDFInvoice)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As BDFInvoice) As BDFInvoice
			Return CType(MyBase.AttachEntity(entity), BDFInvoice)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As BDFInvoiceCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As BDFInvoice
            Get
                Return TryCast(MyBase.Item(index), BDFInvoice)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(BDFInvoice)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esBDFInvoice	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esBDFInvoiceQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal bDFInvoiceNumber As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(bDFInvoiceNumber)
			Else
				Return LoadByPrimaryKeyStoredProcedure(bDFInvoiceNumber)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal bDFInvoiceNumber As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(bDFInvoiceNumber)
			Else
				Return LoadByPrimaryKeyStoredProcedure(bDFInvoiceNumber)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal bDFInvoiceNumber As System.Int32) As Boolean
		
			Dim query As esBDFInvoiceQuery = Me.GetDynamicQuery()
			query.Where(query.BDFInvoiceNumber.Equal(bDFInvoiceNumber))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal bDFInvoiceNumber As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("BDFInvoiceNumber", bDFInvoiceNumber)
			
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
												
						Case "BDFInvoiceNumber"
							Me.str.BDFInvoiceNumber = CType(value, string)
												
						Case "InvoiceDate"
							Me.str.InvoiceDate = CType(value, string)
												
						Case "Consigneename"
							Me.str.Consigneename = CType(value, string)
												
						Case "Consigneeaddress1"
							Me.str.Consigneeaddress1 = CType(value, string)
												
						Case "Consigneeaddress2"
							Me.str.Consigneeaddress2 = CType(value, string)
												
						Case "Consigneecity"
							Me.str.Consigneecity = CType(value, string)
												
						Case "Consigneestateprov"
							Me.str.Consigneestateprov = CType(value, string)
												
						Case "Consigneepostalcode"
							Me.str.Consigneepostalcode = CType(value, string)
												
						Case "Consigneecountry"
							Me.str.Consigneecountry = CType(value, string)
												
						Case "Consigneephone"
							Me.str.Consigneephone = CType(value, string)
												
						Case "Consigneefax"
							Me.str.Consigneefax = CType(value, string)
												
						Case "Consigneecontact"
							Me.str.Consigneecontact = CType(value, string)
												
						Case "Shippername"
							Me.str.Shippername = CType(value, string)
												
						Case "Shipperaddress1"
							Me.str.Shipperaddress1 = CType(value, string)
												
						Case "Shipperaddress2"
							Me.str.Shipperaddress2 = CType(value, string)
												
						Case "Shippercity"
							Me.str.Shippercity = CType(value, string)
												
						Case "Shipperstateprov"
							Me.str.Shipperstateprov = CType(value, string)
												
						Case "Shipperpostalcode"
							Me.str.Shipperpostalcode = CType(value, string)
												
						Case "Shippercountry"
							Me.str.Shippercountry = CType(value, string)
												
						Case "Shipperphone"
							Me.str.Shipperphone = CType(value, string)
												
						Case "Shipperfax"
							Me.str.Shipperfax = CType(value, string)
												
						Case "Shippercontact"
							Me.str.Shippercontact = CType(value, string)
												
						Case "Shipmentdate"
							Me.str.Shipmentdate = CType(value, string)
												
						Case "Freightcarrier"
							Me.str.Freightcarrier = CType(value, string)
												
						Case "Loadinfo"
							Me.str.Loadinfo = CType(value, string)
												
						Case "Taxable"
							Me.str.Taxable = CType(value, string)
												
						Case "InvoiceStatus"
							Me.str.InvoiceStatus = CType(value, string)
												
						Case "SubTotal"
							Me.str.SubTotal = CType(value, string)
												
						Case "SalesTax"
							Me.str.SalesTax = CType(value, string)
												
						Case "Total"
							Me.str.Total = CType(value, string)
												
						Case "Remarks"
							Me.str.Remarks = CType(value, string)
												
						Case "CreatedBy"
							Me.str.CreatedBy = CType(value, string)
												
						Case "CreatedTimeStamp"
							Me.str.CreatedTimeStamp = CType(value, string)
												
						Case "ModifiedBy"
							Me.str.ModifiedBy = CType(value, string)
												
						Case "ModifiedTimeStamp"
							Me.str.ModifiedTimeStamp = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "BDFInvoiceNumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.BDFInvoiceNumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "InvoiceDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.InvoiceDate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Shipmentdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Shipmentdate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Taxable"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Taxable = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "SubTotal"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.SubTotal = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "SalesTax"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.SalesTax = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Total"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Total = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "CreatedTimeStamp"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.CreatedTimeStamp = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "ModifiedTimeStamp"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.ModifiedTimeStamp = CType(value, Nullable(Of System.DateTime))
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
		' Maps to BDFInvoice.BDFInvoiceNumber
		' </summary>
		Public Overridable Property BDFInvoiceNumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(BDFInvoiceMetadata.ColumnNames.BDFInvoiceNumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(BDFInvoiceMetadata.ColumnNames.BDFInvoiceNumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to BDFInvoice.InvoiceDate
		' </summary>
		Public Overridable Property InvoiceDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(BDFInvoiceMetadata.ColumnNames.InvoiceDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(BDFInvoiceMetadata.ColumnNames.InvoiceDate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to BDFInvoice.CONSIGNEENAME
		' </summary>
		Public Overridable Property Consigneename As System.String
			Get
				Return MyBase.GetSystemString(BDFInvoiceMetadata.ColumnNames.Consigneename)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(BDFInvoiceMetadata.ColumnNames.Consigneename, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to BDFInvoice.CONSIGNEEADDRESS1
		' </summary>
		Public Overridable Property Consigneeaddress1 As System.String
			Get
				Return MyBase.GetSystemString(BDFInvoiceMetadata.ColumnNames.Consigneeaddress1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(BDFInvoiceMetadata.ColumnNames.Consigneeaddress1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to BDFInvoice.CONSIGNEEADDRESS2
		' </summary>
		Public Overridable Property Consigneeaddress2 As System.String
			Get
				Return MyBase.GetSystemString(BDFInvoiceMetadata.ColumnNames.Consigneeaddress2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(BDFInvoiceMetadata.ColumnNames.Consigneeaddress2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to BDFInvoice.CONSIGNEECITY
		' </summary>
		Public Overridable Property Consigneecity As System.String
			Get
				Return MyBase.GetSystemString(BDFInvoiceMetadata.ColumnNames.Consigneecity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(BDFInvoiceMetadata.ColumnNames.Consigneecity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to BDFInvoice.CONSIGNEESTATEPROV
		' </summary>
		Public Overridable Property Consigneestateprov As System.String
			Get
				Return MyBase.GetSystemString(BDFInvoiceMetadata.ColumnNames.Consigneestateprov)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(BDFInvoiceMetadata.ColumnNames.Consigneestateprov, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to BDFInvoice.CONSIGNEEPOSTALCODE
		' </summary>
		Public Overridable Property Consigneepostalcode As System.String
			Get
				Return MyBase.GetSystemString(BDFInvoiceMetadata.ColumnNames.Consigneepostalcode)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(BDFInvoiceMetadata.ColumnNames.Consigneepostalcode, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to BDFInvoice.CONSIGNEECOUNTRY
		' </summary>
		Public Overridable Property Consigneecountry As System.String
			Get
				Return MyBase.GetSystemString(BDFInvoiceMetadata.ColumnNames.Consigneecountry)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(BDFInvoiceMetadata.ColumnNames.Consigneecountry, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to BDFInvoice.CONSIGNEEPHONE
		' </summary>
		Public Overridable Property Consigneephone As System.String
			Get
				Return MyBase.GetSystemString(BDFInvoiceMetadata.ColumnNames.Consigneephone)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(BDFInvoiceMetadata.ColumnNames.Consigneephone, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to BDFInvoice.CONSIGNEEFAX
		' </summary>
		Public Overridable Property Consigneefax As System.String
			Get
				Return MyBase.GetSystemString(BDFInvoiceMetadata.ColumnNames.Consigneefax)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(BDFInvoiceMetadata.ColumnNames.Consigneefax, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to BDFInvoice.CONSIGNEECONTACT
		' </summary>
		Public Overridable Property Consigneecontact As System.String
			Get
				Return MyBase.GetSystemString(BDFInvoiceMetadata.ColumnNames.Consigneecontact)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(BDFInvoiceMetadata.ColumnNames.Consigneecontact, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to BDFInvoice.SHIPPERNAME
		' </summary>
		Public Overridable Property Shippername As System.String
			Get
				Return MyBase.GetSystemString(BDFInvoiceMetadata.ColumnNames.Shippername)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(BDFInvoiceMetadata.ColumnNames.Shippername, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to BDFInvoice.SHIPPERADDRESS1
		' </summary>
		Public Overridable Property Shipperaddress1 As System.String
			Get
				Return MyBase.GetSystemString(BDFInvoiceMetadata.ColumnNames.Shipperaddress1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(BDFInvoiceMetadata.ColumnNames.Shipperaddress1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to BDFInvoice.SHIPPERADDRESS2
		' </summary>
		Public Overridable Property Shipperaddress2 As System.String
			Get
				Return MyBase.GetSystemString(BDFInvoiceMetadata.ColumnNames.Shipperaddress2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(BDFInvoiceMetadata.ColumnNames.Shipperaddress2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to BDFInvoice.SHIPPERCITY
		' </summary>
		Public Overridable Property Shippercity As System.String
			Get
				Return MyBase.GetSystemString(BDFInvoiceMetadata.ColumnNames.Shippercity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(BDFInvoiceMetadata.ColumnNames.Shippercity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to BDFInvoice.SHIPPERSTATEPROV
		' </summary>
		Public Overridable Property Shipperstateprov As System.String
			Get
				Return MyBase.GetSystemString(BDFInvoiceMetadata.ColumnNames.Shipperstateprov)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(BDFInvoiceMetadata.ColumnNames.Shipperstateprov, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to BDFInvoice.SHIPPERPOSTALCODE
		' </summary>
		Public Overridable Property Shipperpostalcode As System.String
			Get
				Return MyBase.GetSystemString(BDFInvoiceMetadata.ColumnNames.Shipperpostalcode)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(BDFInvoiceMetadata.ColumnNames.Shipperpostalcode, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to BDFInvoice.SHIPPERCOUNTRY
		' </summary>
		Public Overridable Property Shippercountry As System.String
			Get
				Return MyBase.GetSystemString(BDFInvoiceMetadata.ColumnNames.Shippercountry)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(BDFInvoiceMetadata.ColumnNames.Shippercountry, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to BDFInvoice.SHIPPERPHONE
		' </summary>
		Public Overridable Property Shipperphone As System.String
			Get
				Return MyBase.GetSystemString(BDFInvoiceMetadata.ColumnNames.Shipperphone)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(BDFInvoiceMetadata.ColumnNames.Shipperphone, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to BDFInvoice.SHIPPERFAX
		' </summary>
		Public Overridable Property Shipperfax As System.String
			Get
				Return MyBase.GetSystemString(BDFInvoiceMetadata.ColumnNames.Shipperfax)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(BDFInvoiceMetadata.ColumnNames.Shipperfax, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to BDFInvoice.SHIPPERCONTACT
		' </summary>
		Public Overridable Property Shippercontact As System.String
			Get
				Return MyBase.GetSystemString(BDFInvoiceMetadata.ColumnNames.Shippercontact)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(BDFInvoiceMetadata.ColumnNames.Shippercontact, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to BDFInvoice.SHIPMENTDATE
		' </summary>
		Public Overridable Property Shipmentdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(BDFInvoiceMetadata.ColumnNames.Shipmentdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(BDFInvoiceMetadata.ColumnNames.Shipmentdate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to BDFInvoice.FREIGHTCARRIER
		' </summary>
		Public Overridable Property Freightcarrier As System.String
			Get
				Return MyBase.GetSystemString(BDFInvoiceMetadata.ColumnNames.Freightcarrier)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(BDFInvoiceMetadata.ColumnNames.Freightcarrier, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to BDFInvoice.LOADINFO
		' </summary>
		Public Overridable Property Loadinfo As System.String
			Get
				Return MyBase.GetSystemString(BDFInvoiceMetadata.ColumnNames.Loadinfo)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(BDFInvoiceMetadata.ColumnNames.Loadinfo, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to BDFInvoice.Taxable
		' </summary>
		Public Overridable Property Taxable As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(BDFInvoiceMetadata.ColumnNames.Taxable)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(BDFInvoiceMetadata.ColumnNames.Taxable, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to BDFInvoice.InvoiceStatus
		' </summary>
		Public Overridable Property InvoiceStatus As System.String
			Get
				Return MyBase.GetSystemString(BDFInvoiceMetadata.ColumnNames.InvoiceStatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(BDFInvoiceMetadata.ColumnNames.InvoiceStatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to BDFInvoice.SubTotal
		' </summary>
		Public Overridable Property SubTotal As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(BDFInvoiceMetadata.ColumnNames.SubTotal)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(BDFInvoiceMetadata.ColumnNames.SubTotal, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to BDFInvoice.SalesTax
		' </summary>
		Public Overridable Property SalesTax As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(BDFInvoiceMetadata.ColumnNames.SalesTax)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(BDFInvoiceMetadata.ColumnNames.SalesTax, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to BDFInvoice.Total
		' </summary>
		Public Overridable Property Total As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(BDFInvoiceMetadata.ColumnNames.Total)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(BDFInvoiceMetadata.ColumnNames.Total, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to BDFInvoice.Remarks
		' </summary>
		Public Overridable Property Remarks As System.String
			Get
				Return MyBase.GetSystemString(BDFInvoiceMetadata.ColumnNames.Remarks)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(BDFInvoiceMetadata.ColumnNames.Remarks, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to BDFInvoice.CreatedBy
		' </summary>
		Public Overridable Property CreatedBy As System.String
			Get
				Return MyBase.GetSystemString(BDFInvoiceMetadata.ColumnNames.CreatedBy)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(BDFInvoiceMetadata.ColumnNames.CreatedBy, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to BDFInvoice.CreatedTimeStamp
		' </summary>
		Public Overridable Property CreatedTimeStamp As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(BDFInvoiceMetadata.ColumnNames.CreatedTimeStamp)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(BDFInvoiceMetadata.ColumnNames.CreatedTimeStamp, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to BDFInvoice.ModifiedBy
		' </summary>
		Public Overridable Property ModifiedBy As System.String
			Get
				Return MyBase.GetSystemString(BDFInvoiceMetadata.ColumnNames.ModifiedBy)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(BDFInvoiceMetadata.ColumnNames.ModifiedBy, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to BDFInvoice.ModifiedTimeStamp
		' </summary>
		Public Overridable Property ModifiedTimeStamp As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(BDFInvoiceMetadata.ColumnNames.ModifiedTimeStamp)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(BDFInvoiceMetadata.ColumnNames.ModifiedTimeStamp, value)
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
		
			Public Sub New(ByVal entity As esBDFInvoice)
				Me.entity = entity
			End Sub				
		
	
			Public Property BDFInvoiceNumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.BDFInvoiceNumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BDFInvoiceNumber = Nothing
					Else
						entity.BDFInvoiceNumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property InvoiceDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.InvoiceDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.InvoiceDate = Nothing
					Else
						entity.InvoiceDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Consigneename As System.String 
				Get
					Dim data_ As System.String = entity.Consigneename
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Consigneename = Nothing
					Else
						entity.Consigneename = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Consigneeaddress1 As System.String 
				Get
					Dim data_ As System.String = entity.Consigneeaddress1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Consigneeaddress1 = Nothing
					Else
						entity.Consigneeaddress1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Consigneeaddress2 As System.String 
				Get
					Dim data_ As System.String = entity.Consigneeaddress2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Consigneeaddress2 = Nothing
					Else
						entity.Consigneeaddress2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Consigneecity As System.String 
				Get
					Dim data_ As System.String = entity.Consigneecity
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Consigneecity = Nothing
					Else
						entity.Consigneecity = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Consigneestateprov As System.String 
				Get
					Dim data_ As System.String = entity.Consigneestateprov
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Consigneestateprov = Nothing
					Else
						entity.Consigneestateprov = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Consigneepostalcode As System.String 
				Get
					Dim data_ As System.String = entity.Consigneepostalcode
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Consigneepostalcode = Nothing
					Else
						entity.Consigneepostalcode = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Consigneecountry As System.String 
				Get
					Dim data_ As System.String = entity.Consigneecountry
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Consigneecountry = Nothing
					Else
						entity.Consigneecountry = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Consigneephone As System.String 
				Get
					Dim data_ As System.String = entity.Consigneephone
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Consigneephone = Nothing
					Else
						entity.Consigneephone = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Consigneefax As System.String 
				Get
					Dim data_ As System.String = entity.Consigneefax
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Consigneefax = Nothing
					Else
						entity.Consigneefax = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Consigneecontact As System.String 
				Get
					Dim data_ As System.String = entity.Consigneecontact
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Consigneecontact = Nothing
					Else
						entity.Consigneecontact = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shippername As System.String 
				Get
					Dim data_ As System.String = entity.Shippername
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shippername = Nothing
					Else
						entity.Shippername = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shipperaddress1 As System.String 
				Get
					Dim data_ As System.String = entity.Shipperaddress1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipperaddress1 = Nothing
					Else
						entity.Shipperaddress1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shipperaddress2 As System.String 
				Get
					Dim data_ As System.String = entity.Shipperaddress2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipperaddress2 = Nothing
					Else
						entity.Shipperaddress2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shippercity As System.String 
				Get
					Dim data_ As System.String = entity.Shippercity
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shippercity = Nothing
					Else
						entity.Shippercity = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shipperstateprov As System.String 
				Get
					Dim data_ As System.String = entity.Shipperstateprov
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipperstateprov = Nothing
					Else
						entity.Shipperstateprov = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shipperpostalcode As System.String 
				Get
					Dim data_ As System.String = entity.Shipperpostalcode
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipperpostalcode = Nothing
					Else
						entity.Shipperpostalcode = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shippercountry As System.String 
				Get
					Dim data_ As System.String = entity.Shippercountry
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shippercountry = Nothing
					Else
						entity.Shippercountry = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shipperphone As System.String 
				Get
					Dim data_ As System.String = entity.Shipperphone
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipperphone = Nothing
					Else
						entity.Shipperphone = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shipperfax As System.String 
				Get
					Dim data_ As System.String = entity.Shipperfax
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipperfax = Nothing
					Else
						entity.Shipperfax = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shippercontact As System.String 
				Get
					Dim data_ As System.String = entity.Shippercontact
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shippercontact = Nothing
					Else
						entity.Shippercontact = Convert.ToString(Value)
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
		  	
			Public Property Loadinfo As System.String 
				Get
					Dim data_ As System.String = entity.Loadinfo
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Loadinfo = Nothing
					Else
						entity.Loadinfo = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Taxable As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Taxable
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Taxable = Nothing
					Else
						entity.Taxable = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property InvoiceStatus As System.String 
				Get
					Dim data_ As System.String = entity.InvoiceStatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.InvoiceStatus = Nothing
					Else
						entity.InvoiceStatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SubTotal As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.SubTotal
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SubTotal = Nothing
					Else
						entity.SubTotal = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property SalesTax As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.SalesTax
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SalesTax = Nothing
					Else
						entity.SalesTax = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Total As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Total
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Total = Nothing
					Else
						entity.Total = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Remarks As System.String 
				Get
					Dim data_ As System.String = entity.Remarks
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Remarks = Nothing
					Else
						entity.Remarks = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CreatedBy As System.String 
				Get
					Dim data_ As System.String = entity.CreatedBy
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CreatedBy = Nothing
					Else
						entity.CreatedBy = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CreatedTimeStamp As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.CreatedTimeStamp
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CreatedTimeStamp = Nothing
					Else
						entity.CreatedTimeStamp = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property ModifiedBy As System.String 
				Get
					Dim data_ As System.String = entity.ModifiedBy
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ModifiedBy = Nothing
					Else
						entity.ModifiedBy = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ModifiedTimeStamp As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.ModifiedTimeStamp
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ModifiedTimeStamp = Nothing
					Else
						entity.ModifiedTimeStamp = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  

			Private entity As esBDFInvoice
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esBDFInvoiceQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esBDFInvoice can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class BDFInvoice 
		Inherits esBDFInvoice
		
	
		
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
	MustInherit Public Class esBDFInvoiceQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return BDFInvoiceMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property BDFInvoiceNumber As esQueryItem
			Get
				Return New esQueryItem(Me, BDFInvoiceMetadata.ColumnNames.BDFInvoiceNumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property InvoiceDate As esQueryItem
			Get
				Return New esQueryItem(Me, BDFInvoiceMetadata.ColumnNames.InvoiceDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Consigneename As esQueryItem
			Get
				Return New esQueryItem(Me, BDFInvoiceMetadata.ColumnNames.Consigneename, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Consigneeaddress1 As esQueryItem
			Get
				Return New esQueryItem(Me, BDFInvoiceMetadata.ColumnNames.Consigneeaddress1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Consigneeaddress2 As esQueryItem
			Get
				Return New esQueryItem(Me, BDFInvoiceMetadata.ColumnNames.Consigneeaddress2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Consigneecity As esQueryItem
			Get
				Return New esQueryItem(Me, BDFInvoiceMetadata.ColumnNames.Consigneecity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Consigneestateprov As esQueryItem
			Get
				Return New esQueryItem(Me, BDFInvoiceMetadata.ColumnNames.Consigneestateprov, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Consigneepostalcode As esQueryItem
			Get
				Return New esQueryItem(Me, BDFInvoiceMetadata.ColumnNames.Consigneepostalcode, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Consigneecountry As esQueryItem
			Get
				Return New esQueryItem(Me, BDFInvoiceMetadata.ColumnNames.Consigneecountry, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Consigneephone As esQueryItem
			Get
				Return New esQueryItem(Me, BDFInvoiceMetadata.ColumnNames.Consigneephone, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Consigneefax As esQueryItem
			Get
				Return New esQueryItem(Me, BDFInvoiceMetadata.ColumnNames.Consigneefax, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Consigneecontact As esQueryItem
			Get
				Return New esQueryItem(Me, BDFInvoiceMetadata.ColumnNames.Consigneecontact, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shippername As esQueryItem
			Get
				Return New esQueryItem(Me, BDFInvoiceMetadata.ColumnNames.Shippername, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipperaddress1 As esQueryItem
			Get
				Return New esQueryItem(Me, BDFInvoiceMetadata.ColumnNames.Shipperaddress1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipperaddress2 As esQueryItem
			Get
				Return New esQueryItem(Me, BDFInvoiceMetadata.ColumnNames.Shipperaddress2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shippercity As esQueryItem
			Get
				Return New esQueryItem(Me, BDFInvoiceMetadata.ColumnNames.Shippercity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipperstateprov As esQueryItem
			Get
				Return New esQueryItem(Me, BDFInvoiceMetadata.ColumnNames.Shipperstateprov, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipperpostalcode As esQueryItem
			Get
				Return New esQueryItem(Me, BDFInvoiceMetadata.ColumnNames.Shipperpostalcode, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shippercountry As esQueryItem
			Get
				Return New esQueryItem(Me, BDFInvoiceMetadata.ColumnNames.Shippercountry, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipperphone As esQueryItem
			Get
				Return New esQueryItem(Me, BDFInvoiceMetadata.ColumnNames.Shipperphone, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipperfax As esQueryItem
			Get
				Return New esQueryItem(Me, BDFInvoiceMetadata.ColumnNames.Shipperfax, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shippercontact As esQueryItem
			Get
				Return New esQueryItem(Me, BDFInvoiceMetadata.ColumnNames.Shippercontact, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipmentdate As esQueryItem
			Get
				Return New esQueryItem(Me, BDFInvoiceMetadata.ColumnNames.Shipmentdate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Freightcarrier As esQueryItem
			Get
				Return New esQueryItem(Me, BDFInvoiceMetadata.ColumnNames.Freightcarrier, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Loadinfo As esQueryItem
			Get
				Return New esQueryItem(Me, BDFInvoiceMetadata.ColumnNames.Loadinfo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Taxable As esQueryItem
			Get
				Return New esQueryItem(Me, BDFInvoiceMetadata.ColumnNames.Taxable, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property InvoiceStatus As esQueryItem
			Get
				Return New esQueryItem(Me, BDFInvoiceMetadata.ColumnNames.InvoiceStatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SubTotal As esQueryItem
			Get
				Return New esQueryItem(Me, BDFInvoiceMetadata.ColumnNames.SubTotal, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property SalesTax As esQueryItem
			Get
				Return New esQueryItem(Me, BDFInvoiceMetadata.ColumnNames.SalesTax, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Total As esQueryItem
			Get
				Return New esQueryItem(Me, BDFInvoiceMetadata.ColumnNames.Total, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Remarks As esQueryItem
			Get
				Return New esQueryItem(Me, BDFInvoiceMetadata.ColumnNames.Remarks, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CreatedBy As esQueryItem
			Get
				Return New esQueryItem(Me, BDFInvoiceMetadata.ColumnNames.CreatedBy, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CreatedTimeStamp As esQueryItem
			Get
				Return New esQueryItem(Me, BDFInvoiceMetadata.ColumnNames.CreatedTimeStamp, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ModifiedBy As esQueryItem
			Get
				Return New esQueryItem(Me, BDFInvoiceMetadata.ColumnNames.ModifiedBy, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ModifiedTimeStamp As esQueryItem
			Get
				Return New esQueryItem(Me, BDFInvoiceMetadata.ColumnNames.ModifiedTimeStamp, esSystemType.DateTime)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("BDFInvoiceCollection")> _
	Partial Public Class BDFInvoiceCollection
		Inherits esBDFInvoiceCollection
		Implements IEnumerable(Of BDFInvoice)
		
        Public Shared Widening Operator CType(ByVal coll As BDFInvoiceCollection) As List(Of BDFInvoice)
            Dim list As List(Of BDFInvoice) = New List(Of BDFInvoice)
            Dim emp As BDFInvoice

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return BDFInvoiceMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New BDFInvoiceQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New BDFInvoice(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New BDFInvoice()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As BDFInvoiceQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New BDFInvoiceQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As BDFInvoiceQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As BDFInvoice 
			Return CType(MyBase.AddNewEntity(), BDFInvoice)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal bDFInvoiceNumber As System.Int32) As BDFInvoice
			Return CType(MyBase.FindByPrimaryKey(bDFInvoiceNumber), BDFInvoice)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of BDFInvoice) Implements IEnumerable(Of BDFInvoice).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of BDFInvoice)(Me)
        End Function
		
		Private _query As BDFInvoiceQuery

	End Class
	


	' <summary>
	' Encapsulates the 'BDFInvoice' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("BDFInvoice ({BDFInvoiceNumber.Value})")> _
	<Serializable> _
	Partial Public Class BDFInvoice 
		Inherits esBDFInvoice

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return BDFInvoiceMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esBDFInvoiceQuery

			If Me._query Is Nothing Then
				Me._query = New BDFInvoiceQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As BDFInvoiceQuery
			Get

				If Me._query Is Nothing then
					Me._query = New BDFInvoiceQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As BDFInvoiceQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As BDFInvoiceQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class BDFInvoiceQuery
		inherits esBDFInvoiceQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "BDFInvoiceQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class BDFInvoiceMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(BDFInvoiceMetadata.ColumnNames.BDFInvoiceNumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = BDFInvoiceMetadata.PropertyNames.BDFInvoiceNumber
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(BDFInvoiceMetadata.ColumnNames.InvoiceDate, 1, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = BDFInvoiceMetadata.PropertyNames.InvoiceDate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(BDFInvoiceMetadata.ColumnNames.Consigneename, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = BDFInvoiceMetadata.PropertyNames.Consigneename
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(BDFInvoiceMetadata.ColumnNames.Consigneeaddress1, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = BDFInvoiceMetadata.PropertyNames.Consigneeaddress1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(BDFInvoiceMetadata.ColumnNames.Consigneeaddress2, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = BDFInvoiceMetadata.PropertyNames.Consigneeaddress2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(BDFInvoiceMetadata.ColumnNames.Consigneecity, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = BDFInvoiceMetadata.PropertyNames.Consigneecity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(BDFInvoiceMetadata.ColumnNames.Consigneestateprov, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = BDFInvoiceMetadata.PropertyNames.Consigneestateprov
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(BDFInvoiceMetadata.ColumnNames.Consigneepostalcode, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = BDFInvoiceMetadata.PropertyNames.Consigneepostalcode
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(BDFInvoiceMetadata.ColumnNames.Consigneecountry, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = BDFInvoiceMetadata.PropertyNames.Consigneecountry
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(BDFInvoiceMetadata.ColumnNames.Consigneephone, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = BDFInvoiceMetadata.PropertyNames.Consigneephone
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(BDFInvoiceMetadata.ColumnNames.Consigneefax, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = BDFInvoiceMetadata.PropertyNames.Consigneefax
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(BDFInvoiceMetadata.ColumnNames.Consigneecontact, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = BDFInvoiceMetadata.PropertyNames.Consigneecontact
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(BDFInvoiceMetadata.ColumnNames.Shippername, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = BDFInvoiceMetadata.PropertyNames.Shippername
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(BDFInvoiceMetadata.ColumnNames.Shipperaddress1, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = BDFInvoiceMetadata.PropertyNames.Shipperaddress1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(BDFInvoiceMetadata.ColumnNames.Shipperaddress2, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = BDFInvoiceMetadata.PropertyNames.Shipperaddress2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(BDFInvoiceMetadata.ColumnNames.Shippercity, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = BDFInvoiceMetadata.PropertyNames.Shippercity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(BDFInvoiceMetadata.ColumnNames.Shipperstateprov, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = BDFInvoiceMetadata.PropertyNames.Shipperstateprov
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(BDFInvoiceMetadata.ColumnNames.Shipperpostalcode, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = BDFInvoiceMetadata.PropertyNames.Shipperpostalcode
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(BDFInvoiceMetadata.ColumnNames.Shippercountry, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = BDFInvoiceMetadata.PropertyNames.Shippercountry
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(BDFInvoiceMetadata.ColumnNames.Shipperphone, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = BDFInvoiceMetadata.PropertyNames.Shipperphone
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(BDFInvoiceMetadata.ColumnNames.Shipperfax, 20, GetType(System.String), esSystemType.String)	
			c.PropertyName = BDFInvoiceMetadata.PropertyNames.Shipperfax
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(BDFInvoiceMetadata.ColumnNames.Shippercontact, 21, GetType(System.String), esSystemType.String)	
			c.PropertyName = BDFInvoiceMetadata.PropertyNames.Shippercontact
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(BDFInvoiceMetadata.ColumnNames.Shipmentdate, 22, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = BDFInvoiceMetadata.PropertyNames.Shipmentdate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(BDFInvoiceMetadata.ColumnNames.Freightcarrier, 23, GetType(System.String), esSystemType.String)	
			c.PropertyName = BDFInvoiceMetadata.PropertyNames.Freightcarrier
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(BDFInvoiceMetadata.ColumnNames.Loadinfo, 24, GetType(System.String), esSystemType.String)	
			c.PropertyName = BDFInvoiceMetadata.PropertyNames.Loadinfo
			c.CharacterMaxLength = 100
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(BDFInvoiceMetadata.ColumnNames.Taxable, 25, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = BDFInvoiceMetadata.PropertyNames.Taxable
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(BDFInvoiceMetadata.ColumnNames.InvoiceStatus, 26, GetType(System.String), esSystemType.String)	
			c.PropertyName = BDFInvoiceMetadata.PropertyNames.InvoiceStatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(BDFInvoiceMetadata.ColumnNames.SubTotal, 27, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = BDFInvoiceMetadata.PropertyNames.SubTotal
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(BDFInvoiceMetadata.ColumnNames.SalesTax, 28, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = BDFInvoiceMetadata.PropertyNames.SalesTax
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(BDFInvoiceMetadata.ColumnNames.Total, 29, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = BDFInvoiceMetadata.PropertyNames.Total
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(BDFInvoiceMetadata.ColumnNames.Remarks, 30, GetType(System.String), esSystemType.String)	
			c.PropertyName = BDFInvoiceMetadata.PropertyNames.Remarks
			c.CharacterMaxLength = 300
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(BDFInvoiceMetadata.ColumnNames.CreatedBy, 31, GetType(System.String), esSystemType.String)	
			c.PropertyName = BDFInvoiceMetadata.PropertyNames.CreatedBy
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(BDFInvoiceMetadata.ColumnNames.CreatedTimeStamp, 32, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = BDFInvoiceMetadata.PropertyNames.CreatedTimeStamp
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(BDFInvoiceMetadata.ColumnNames.ModifiedBy, 33, GetType(System.String), esSystemType.String)	
			c.PropertyName = BDFInvoiceMetadata.PropertyNames.ModifiedBy
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(BDFInvoiceMetadata.ColumnNames.ModifiedTimeStamp, 34, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = BDFInvoiceMetadata.PropertyNames.ModifiedTimeStamp
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As BDFInvoiceMetadata
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
			 Public Const BDFInvoiceNumber As String = "BDFInvoiceNumber"
			 Public Const InvoiceDate As String = "InvoiceDate"
			 Public Const Consigneename As String = "CONSIGNEENAME"
			 Public Const Consigneeaddress1 As String = "CONSIGNEEADDRESS1"
			 Public Const Consigneeaddress2 As String = "CONSIGNEEADDRESS2"
			 Public Const Consigneecity As String = "CONSIGNEECITY"
			 Public Const Consigneestateprov As String = "CONSIGNEESTATEPROV"
			 Public Const Consigneepostalcode As String = "CONSIGNEEPOSTALCODE"
			 Public Const Consigneecountry As String = "CONSIGNEECOUNTRY"
			 Public Const Consigneephone As String = "CONSIGNEEPHONE"
			 Public Const Consigneefax As String = "CONSIGNEEFAX"
			 Public Const Consigneecontact As String = "CONSIGNEECONTACT"
			 Public Const Shippername As String = "SHIPPERNAME"
			 Public Const Shipperaddress1 As String = "SHIPPERADDRESS1"
			 Public Const Shipperaddress2 As String = "SHIPPERADDRESS2"
			 Public Const Shippercity As String = "SHIPPERCITY"
			 Public Const Shipperstateprov As String = "SHIPPERSTATEPROV"
			 Public Const Shipperpostalcode As String = "SHIPPERPOSTALCODE"
			 Public Const Shippercountry As String = "SHIPPERCOUNTRY"
			 Public Const Shipperphone As String = "SHIPPERPHONE"
			 Public Const Shipperfax As String = "SHIPPERFAX"
			 Public Const Shippercontact As String = "SHIPPERCONTACT"
			 Public Const Shipmentdate As String = "SHIPMENTDATE"
			 Public Const Freightcarrier As String = "FREIGHTCARRIER"
			 Public Const Loadinfo As String = "LOADINFO"
			 Public Const Taxable As String = "Taxable"
			 Public Const InvoiceStatus As String = "InvoiceStatus"
			 Public Const SubTotal As String = "SubTotal"
			 Public Const SalesTax As String = "SalesTax"
			 Public Const Total As String = "Total"
			 Public Const Remarks As String = "Remarks"
			 Public Const CreatedBy As String = "CreatedBy"
			 Public Const CreatedTimeStamp As String = "CreatedTimeStamp"
			 Public Const ModifiedBy As String = "ModifiedBy"
			 Public Const ModifiedTimeStamp As String = "ModifiedTimeStamp"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const BDFInvoiceNumber As String = "BDFInvoiceNumber"
			 Public Const InvoiceDate As String = "InvoiceDate"
			 Public Const Consigneename As String = "Consigneename"
			 Public Const Consigneeaddress1 As String = "Consigneeaddress1"
			 Public Const Consigneeaddress2 As String = "Consigneeaddress2"
			 Public Const Consigneecity As String = "Consigneecity"
			 Public Const Consigneestateprov As String = "Consigneestateprov"
			 Public Const Consigneepostalcode As String = "Consigneepostalcode"
			 Public Const Consigneecountry As String = "Consigneecountry"
			 Public Const Consigneephone As String = "Consigneephone"
			 Public Const Consigneefax As String = "Consigneefax"
			 Public Const Consigneecontact As String = "Consigneecontact"
			 Public Const Shippername As String = "Shippername"
			 Public Const Shipperaddress1 As String = "Shipperaddress1"
			 Public Const Shipperaddress2 As String = "Shipperaddress2"
			 Public Const Shippercity As String = "Shippercity"
			 Public Const Shipperstateprov As String = "Shipperstateprov"
			 Public Const Shipperpostalcode As String = "Shipperpostalcode"
			 Public Const Shippercountry As String = "Shippercountry"
			 Public Const Shipperphone As String = "Shipperphone"
			 Public Const Shipperfax As String = "Shipperfax"
			 Public Const Shippercontact As String = "Shippercontact"
			 Public Const Shipmentdate As String = "Shipmentdate"
			 Public Const Freightcarrier As String = "Freightcarrier"
			 Public Const Loadinfo As String = "Loadinfo"
			 Public Const Taxable As String = "Taxable"
			 Public Const InvoiceStatus As String = "InvoiceStatus"
			 Public Const SubTotal As String = "SubTotal"
			 Public Const SalesTax As String = "SalesTax"
			 Public Const Total As String = "Total"
			 Public Const Remarks As String = "Remarks"
			 Public Const CreatedBy As String = "CreatedBy"
			 Public Const CreatedTimeStamp As String = "CreatedTimeStamp"
			 Public Const ModifiedBy As String = "ModifiedBy"
			 Public Const ModifiedTimeStamp As String = "ModifiedTimeStamp"
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
            SyncLock GetType(BDFInvoiceMetadata)
			
				If BDFInvoiceMetadata.mapDelegates Is Nothing Then
					BDFInvoiceMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If BDFInvoiceMetadata._meta Is Nothing Then
                    BDFInvoiceMetadata._meta = New BDFInvoiceMetadata()
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
				

				meta.AddTypeMap("BDFInvoiceNumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("InvoiceDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Consigneename", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Consigneeaddress1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Consigneeaddress2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Consigneecity", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Consigneestateprov", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Consigneepostalcode", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Consigneecountry", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Consigneephone", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Consigneefax", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Consigneecontact", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shippername", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipperaddress1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipperaddress2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shippercity", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipperstateprov", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipperpostalcode", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shippercountry", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipperphone", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipperfax", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shippercontact", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipmentdate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Freightcarrier", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Loadinfo", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Taxable", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("InvoiceStatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("SubTotal", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("SalesTax", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Total", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Remarks", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CreatedBy", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CreatedTimeStamp", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("ModifiedBy", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ModifiedTimeStamp", new esTypeMap("datetime", "System.DateTime"))			
				
				
				 
				meta.Source = "BDFInvoice"
				meta.Destination = "BDFInvoice"
				
				meta.spInsert = "proc_BDFInvoiceInsert"
				meta.spUpdate = "proc_BDFInvoiceUpdate"
				meta.spDelete = "proc_BDFInvoiceDelete"
				meta.spLoadAll = "proc_BDFInvoiceLoadAll"
				meta.spLoadByPrimaryKey = "proc_BDFInvoiceLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As BDFInvoiceMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
