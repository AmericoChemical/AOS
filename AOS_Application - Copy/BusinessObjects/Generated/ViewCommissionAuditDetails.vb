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
	MustInherit Public Class esViewCommissionAuditDetailsCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewCommissionAuditDetailsCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewCommissionAuditDetailsQuery)
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
            Me.InitQuery(CType(query, esViewCommissionAuditDetailsQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewCommissionAuditDetails) As ViewCommissionAuditDetails
			Return CType(MyBase.DetachEntity(entity), ViewCommissionAuditDetails)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewCommissionAuditDetails) As ViewCommissionAuditDetails
			Return CType(MyBase.AttachEntity(entity), ViewCommissionAuditDetails)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewCommissionAuditDetailsCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewCommissionAuditDetails
            Get
                Return TryCast(MyBase.Item(index), ViewCommissionAuditDetails)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewCommissionAuditDetails)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewCommissionAuditDetails	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewCommissionAuditDetailsQuery
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
												
						Case "Invoicenumber"
							Me.str.Invoicenumber = CType(value, string)
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Productdesc"
							Me.str.Productdesc = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "Quantity"
							Me.str.Quantity = CType(value, string)
												
						Case "Itemprice"
							Me.str.Itemprice = CType(value, string)
												
						Case "Units"
							Me.str.Units = CType(value, string)
												
						Case "Extprice"
							Me.str.Extprice = CType(value, string)
												
						Case "Extcost"
							Me.str.Extcost = CType(value, string)
												
						Case "Grossprofit"
							Me.str.Grossprofit = CType(value, string)
												
						Case "CustID"
							Me.str.CustID = CType(value, string)
												
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
												
						Case "Invoicedate"
							Me.str.Invoicedate = CType(value, string)
												
						Case "Customerpo"
							Me.str.Customerpo = CType(value, string)
												
						Case "Subtotal"
							Me.str.Subtotal = CType(value, string)
												
						Case "Salestax"
							Me.str.Salestax = CType(value, string)
												
						Case "Total"
							Me.str.Total = CType(value, string)
												
						Case "Invoicestatus"
							Me.str.Invoicestatus = CType(value, string)
												
						Case "Modifyby"
							Me.str.Modifyby = CType(value, string)
												
						Case "Modifytime"
							Me.str.Modifytime = CType(value, string)
												
						Case "Custname"
							Me.str.Custname = CType(value, string)
												
						Case "Custshipcity"
							Me.str.Custshipcity = CType(value, string)
												
						Case "Custshipstateprov"
							Me.str.Custshipstateprov = CType(value, string)
												
						Case "Invoiceitemnumber"
							Me.str.Invoiceitemnumber = CType(value, string)
												
						Case "Workorderitemnumber"
							Me.str.Workorderitemnumber = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Invoicenumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Invoicenumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Quantity"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Quantity = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Itemprice"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Itemprice = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Units"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Units = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Extprice"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Extprice = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Extcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Extcost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Grossprofit"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Grossprofit = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "CustID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.CustID = CType(value, Nullable(Of System.Int32))
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
						
						Case "Invoicedate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Invoicedate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Subtotal"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Subtotal = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Salestax"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Salestax = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Total"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Total = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Modifytime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Modifytime = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Invoiceitemnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Invoiceitemnumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Workorderitemnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Workorderitemnumber = CType(value, Nullable(Of System.Int32))
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
		' Maps to viewCommissionAuditDetails.INVOICENUMBER
		' </summary>
		Public Overridable Property Invoicenumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCommissionAuditDetailsMetadata.ColumnNames.Invoicenumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCommissionAuditDetailsMetadata.ColumnNames.Invoicenumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditDetails.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCommissionAuditDetailsMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCommissionAuditDetailsMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditDetails.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewCommissionAuditDetailsMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCommissionAuditDetailsMetadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditDetails.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewCommissionAuditDetailsMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCommissionAuditDetailsMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditDetails.QUANTITY
		' </summary>
		Public Overridable Property Quantity As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCommissionAuditDetailsMetadata.ColumnNames.Quantity)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCommissionAuditDetailsMetadata.ColumnNames.Quantity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditDetails.ITEMPRICE
		' </summary>
		Public Overridable Property Itemprice As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCommissionAuditDetailsMetadata.ColumnNames.Itemprice)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCommissionAuditDetailsMetadata.ColumnNames.Itemprice, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditDetails.UNITS
		' </summary>
		Public Overridable Property Units As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCommissionAuditDetailsMetadata.ColumnNames.Units)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCommissionAuditDetailsMetadata.ColumnNames.Units, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditDetails.EXTPRICE
		' </summary>
		Public Overridable Property Extprice As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCommissionAuditDetailsMetadata.ColumnNames.Extprice)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCommissionAuditDetailsMetadata.ColumnNames.Extprice, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditDetails.EXTCOST
		' </summary>
		Public Overridable Property Extcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCommissionAuditDetailsMetadata.ColumnNames.Extcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCommissionAuditDetailsMetadata.ColumnNames.Extcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditDetails.GROSSPROFIT
		' </summary>
		Public Overridable Property Grossprofit As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCommissionAuditDetailsMetadata.ColumnNames.Grossprofit)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCommissionAuditDetailsMetadata.ColumnNames.Grossprofit, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditDetails.CustID
		' </summary>
		Public Overridable Property CustID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCommissionAuditDetailsMetadata.ColumnNames.CustID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCommissionAuditDetailsMetadata.ColumnNames.CustID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditDetails.SalespersonID
		' </summary>
		Public Overridable Property SalespersonID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCommissionAuditDetailsMetadata.ColumnNames.SalespersonID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCommissionAuditDetailsMetadata.ColumnNames.SalespersonID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditDetails.SALESPERSONFULLNAME
		' </summary>
		Public Overridable Property Salespersonfullname As System.String
			Get
				Return MyBase.GetSystemString(ViewCommissionAuditDetailsMetadata.ColumnNames.Salespersonfullname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCommissionAuditDetailsMetadata.ColumnNames.Salespersonfullname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditDetails.CommissionRate
		' </summary>
		Public Overridable Property CommissionRate As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCommissionAuditDetailsMetadata.ColumnNames.CommissionRate)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewCommissionAuditDetailsMetadata.ColumnNames.CommissionRate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditDetails.ExcRate
		' </summary>
		Public Overridable Property ExcRate As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCommissionAuditDetailsMetadata.ColumnNames.ExcRate)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewCommissionAuditDetailsMetadata.ColumnNames.ExcRate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditDetails.CommRate
		' </summary>
		Public Overridable Property CommRate As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCommissionAuditDetailsMetadata.ColumnNames.CommRate)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewCommissionAuditDetailsMetadata.ColumnNames.CommRate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditDetails.CommissionType
		' </summary>
		Public Overridable Property CommissionType As System.String
			Get
				Return MyBase.GetSystemString(ViewCommissionAuditDetailsMetadata.ColumnNames.CommissionType)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCommissionAuditDetailsMetadata.ColumnNames.CommissionType, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditDetails.CommissionAmt
		' </summary>
		Public Overridable Property CommissionAmt As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCommissionAuditDetailsMetadata.ColumnNames.CommissionAmt)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewCommissionAuditDetailsMetadata.ColumnNames.CommissionAmt, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditDetails.INVOICEDATE
		' </summary>
		Public Overridable Property Invoicedate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCommissionAuditDetailsMetadata.ColumnNames.Invoicedate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewCommissionAuditDetailsMetadata.ColumnNames.Invoicedate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditDetails.CUSTOMERPO
		' </summary>
		Public Overridable Property Customerpo As System.String
			Get
				Return MyBase.GetSystemString(ViewCommissionAuditDetailsMetadata.ColumnNames.Customerpo)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCommissionAuditDetailsMetadata.ColumnNames.Customerpo, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditDetails.SUBTOTAL
		' </summary>
		Public Overridable Property Subtotal As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCommissionAuditDetailsMetadata.ColumnNames.Subtotal)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCommissionAuditDetailsMetadata.ColumnNames.Subtotal, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditDetails.SALESTAX
		' </summary>
		Public Overridable Property Salestax As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCommissionAuditDetailsMetadata.ColumnNames.Salestax)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCommissionAuditDetailsMetadata.ColumnNames.Salestax, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditDetails.TOTAL
		' </summary>
		Public Overridable Property Total As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCommissionAuditDetailsMetadata.ColumnNames.Total)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCommissionAuditDetailsMetadata.ColumnNames.Total, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditDetails.INVOICESTATUS
		' </summary>
		Public Overridable Property Invoicestatus As System.String
			Get
				Return MyBase.GetSystemString(ViewCommissionAuditDetailsMetadata.ColumnNames.Invoicestatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCommissionAuditDetailsMetadata.ColumnNames.Invoicestatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditDetails.MODIFYBY
		' </summary>
		Public Overridable Property Modifyby As System.String
			Get
				Return MyBase.GetSystemString(ViewCommissionAuditDetailsMetadata.ColumnNames.Modifyby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCommissionAuditDetailsMetadata.ColumnNames.Modifyby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditDetails.MODIFYTIME
		' </summary>
		Public Overridable Property Modifytime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewCommissionAuditDetailsMetadata.ColumnNames.Modifytime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewCommissionAuditDetailsMetadata.ColumnNames.Modifytime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditDetails.CUSTNAME
		' </summary>
		Public Overridable Property Custname As System.String
			Get
				Return MyBase.GetSystemString(ViewCommissionAuditDetailsMetadata.ColumnNames.Custname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCommissionAuditDetailsMetadata.ColumnNames.Custname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditDetails.CUSTSHIPCITY
		' </summary>
		Public Overridable Property Custshipcity As System.String
			Get
				Return MyBase.GetSystemString(ViewCommissionAuditDetailsMetadata.ColumnNames.Custshipcity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCommissionAuditDetailsMetadata.ColumnNames.Custshipcity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditDetails.CUSTSHIPSTATEPROV
		' </summary>
		Public Overridable Property Custshipstateprov As System.String
			Get
				Return MyBase.GetSystemString(ViewCommissionAuditDetailsMetadata.ColumnNames.Custshipstateprov)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCommissionAuditDetailsMetadata.ColumnNames.Custshipstateprov, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditDetails.INVOICEITEMNUMBER
		' </summary>
		Public Overridable Property Invoiceitemnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCommissionAuditDetailsMetadata.ColumnNames.Invoiceitemnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCommissionAuditDetailsMetadata.ColumnNames.Invoiceitemnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAuditDetails.WORKORDERITEMNUMBER
		' </summary>
		Public Overridable Property Workorderitemnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCommissionAuditDetailsMetadata.ColumnNames.Workorderitemnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCommissionAuditDetailsMetadata.ColumnNames.Workorderitemnumber, value)
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
		
			Public Sub New(ByVal entity As esViewCommissionAuditDetails)
				Me.entity = entity
			End Sub				
		
	
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
		  	
			Public Property Quantity As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Quantity
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Quantity = Nothing
					Else
						entity.Quantity = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Itemprice As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Itemprice
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Itemprice = Nothing
					Else
						entity.Itemprice = Convert.ToDecimal(Value)
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
		  	
			Public Property CustID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.CustID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CustID = Nothing
					Else
						entity.CustID = Convert.ToInt32(Value)
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
		  	
			Public Property Invoicedate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Invoicedate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Invoicedate = Nothing
					Else
						entity.Invoicedate = Convert.ToDateTime(Value)
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
		  	
			Public Property Salestax As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Salestax
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Salestax = Nothing
					Else
						entity.Salestax = Convert.ToDecimal(Value)
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
		  	
			Public Property Invoicestatus As System.String 
				Get
					Dim data_ As System.String = entity.Invoicestatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Invoicestatus = Nothing
					Else
						entity.Invoicestatus = Convert.ToString(Value)
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
		  

			Private entity As esViewCommissionAuditDetails
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewCommissionAuditDetailsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewCommissionAuditDetails can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewCommissionAuditDetailsQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCommissionAuditDetailsMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Invoicenumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditDetailsMetadata.ColumnNames.Invoicenumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditDetailsMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditDetailsMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditDetailsMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Quantity As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditDetailsMetadata.ColumnNames.Quantity, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Itemprice As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditDetailsMetadata.ColumnNames.Itemprice, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Units As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditDetailsMetadata.ColumnNames.Units, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Extprice As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditDetailsMetadata.ColumnNames.Extprice, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Extcost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditDetailsMetadata.ColumnNames.Extcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Grossprofit As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditDetailsMetadata.ColumnNames.Grossprofit, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property CustID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditDetailsMetadata.ColumnNames.CustID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property SalespersonID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditDetailsMetadata.ColumnNames.SalespersonID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Salespersonfullname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditDetailsMetadata.ColumnNames.Salespersonfullname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CommissionRate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditDetailsMetadata.ColumnNames.CommissionRate, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property ExcRate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditDetailsMetadata.ColumnNames.ExcRate, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property CommRate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditDetailsMetadata.ColumnNames.CommRate, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property CommissionType As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditDetailsMetadata.ColumnNames.CommissionType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CommissionAmt As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditDetailsMetadata.ColumnNames.CommissionAmt, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Invoicedate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditDetailsMetadata.ColumnNames.Invoicedate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Customerpo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditDetailsMetadata.ColumnNames.Customerpo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Subtotal As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditDetailsMetadata.ColumnNames.Subtotal, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Salestax As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditDetailsMetadata.ColumnNames.Salestax, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Total As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditDetailsMetadata.ColumnNames.Total, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Invoicestatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditDetailsMetadata.ColumnNames.Invoicestatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Modifyby As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditDetailsMetadata.ColumnNames.Modifyby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Modifytime As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditDetailsMetadata.ColumnNames.Modifytime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Custname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditDetailsMetadata.ColumnNames.Custname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Custshipcity As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditDetailsMetadata.ColumnNames.Custshipcity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Custshipstateprov As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditDetailsMetadata.ColumnNames.Custshipstateprov, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Invoiceitemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditDetailsMetadata.ColumnNames.Invoiceitemnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Workorderitemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditDetailsMetadata.ColumnNames.Workorderitemnumber, esSystemType.Int32)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewCommissionAuditDetailsCollection")> _
	Partial Public Class ViewCommissionAuditDetailsCollection
		Inherits esViewCommissionAuditDetailsCollection
		Implements IEnumerable(Of ViewCommissionAuditDetails)
		
        Public Shared Widening Operator CType(ByVal coll As ViewCommissionAuditDetailsCollection) As List(Of ViewCommissionAuditDetails)
            Dim list As List(Of ViewCommissionAuditDetails) = New List(Of ViewCommissionAuditDetails)
            Dim emp As ViewCommissionAuditDetails

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCommissionAuditDetailsMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewCommissionAuditDetailsQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewCommissionAuditDetails(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewCommissionAuditDetails()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewCommissionAuditDetailsQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewCommissionAuditDetailsQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewCommissionAuditDetailsQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewCommissionAuditDetails 
			Return CType(MyBase.AddNewEntity(), ViewCommissionAuditDetails)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewCommissionAuditDetails) Implements IEnumerable(Of ViewCommissionAuditDetails).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewCommissionAuditDetails)(Me)
        End Function
		
		Private _query As ViewCommissionAuditDetailsQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewCommissionAuditDetails' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewCommissionAuditDetails ()")> _
	<Serializable> _
	Partial Public Class ViewCommissionAuditDetails 
		Inherits esViewCommissionAuditDetails

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewCommissionAuditDetailsMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewCommissionAuditDetailsQuery

			If Me._query Is Nothing Then
				Me._query = New ViewCommissionAuditDetailsQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewCommissionAuditDetailsQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewCommissionAuditDetailsQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewCommissionAuditDetailsQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewCommissionAuditDetailsQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewCommissionAuditDetailsQuery
		inherits esViewCommissionAuditDetailsQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewCommissionAuditDetailsQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewCommissionAuditDetailsMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCommissionAuditDetailsMetadata.ColumnNames.Invoicenumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCommissionAuditDetailsMetadata.PropertyNames.Invoicenumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditDetailsMetadata.ColumnNames.Productid, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCommissionAuditDetailsMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditDetailsMetadata.ColumnNames.Productdesc, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCommissionAuditDetailsMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditDetailsMetadata.ColumnNames.Container, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCommissionAuditDetailsMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditDetailsMetadata.ColumnNames.Quantity, 4, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCommissionAuditDetailsMetadata.PropertyNames.Quantity
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditDetailsMetadata.ColumnNames.Itemprice, 5, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCommissionAuditDetailsMetadata.PropertyNames.Itemprice
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditDetailsMetadata.ColumnNames.Units, 6, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCommissionAuditDetailsMetadata.PropertyNames.Units
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditDetailsMetadata.ColumnNames.Extprice, 7, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCommissionAuditDetailsMetadata.PropertyNames.Extprice
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditDetailsMetadata.ColumnNames.Extcost, 8, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCommissionAuditDetailsMetadata.PropertyNames.Extcost
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditDetailsMetadata.ColumnNames.Grossprofit, 9, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCommissionAuditDetailsMetadata.PropertyNames.Grossprofit
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditDetailsMetadata.ColumnNames.CustID, 10, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCommissionAuditDetailsMetadata.PropertyNames.CustID
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditDetailsMetadata.ColumnNames.SalespersonID, 11, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCommissionAuditDetailsMetadata.PropertyNames.SalespersonID
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditDetailsMetadata.ColumnNames.Salespersonfullname, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCommissionAuditDetailsMetadata.PropertyNames.Salespersonfullname
			c.CharacterMaxLength = 101
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditDetailsMetadata.ColumnNames.CommissionRate, 13, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCommissionAuditDetailsMetadata.PropertyNames.CommissionRate
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditDetailsMetadata.ColumnNames.ExcRate, 14, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCommissionAuditDetailsMetadata.PropertyNames.ExcRate
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditDetailsMetadata.ColumnNames.CommRate, 15, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCommissionAuditDetailsMetadata.PropertyNames.CommRate
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditDetailsMetadata.ColumnNames.CommissionType, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCommissionAuditDetailsMetadata.PropertyNames.CommissionType
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditDetailsMetadata.ColumnNames.CommissionAmt, 17, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCommissionAuditDetailsMetadata.PropertyNames.CommissionAmt
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditDetailsMetadata.ColumnNames.Invoicedate, 18, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCommissionAuditDetailsMetadata.PropertyNames.Invoicedate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditDetailsMetadata.ColumnNames.Customerpo, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCommissionAuditDetailsMetadata.PropertyNames.Customerpo
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditDetailsMetadata.ColumnNames.Subtotal, 20, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCommissionAuditDetailsMetadata.PropertyNames.Subtotal
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditDetailsMetadata.ColumnNames.Salestax, 21, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCommissionAuditDetailsMetadata.PropertyNames.Salestax
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditDetailsMetadata.ColumnNames.Total, 22, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCommissionAuditDetailsMetadata.PropertyNames.Total
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditDetailsMetadata.ColumnNames.Invoicestatus, 23, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCommissionAuditDetailsMetadata.PropertyNames.Invoicestatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditDetailsMetadata.ColumnNames.Modifyby, 24, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCommissionAuditDetailsMetadata.PropertyNames.Modifyby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditDetailsMetadata.ColumnNames.Modifytime, 25, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewCommissionAuditDetailsMetadata.PropertyNames.Modifytime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditDetailsMetadata.ColumnNames.Custname, 26, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCommissionAuditDetailsMetadata.PropertyNames.Custname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditDetailsMetadata.ColumnNames.Custshipcity, 27, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCommissionAuditDetailsMetadata.PropertyNames.Custshipcity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditDetailsMetadata.ColumnNames.Custshipstateprov, 28, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCommissionAuditDetailsMetadata.PropertyNames.Custshipstateprov
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditDetailsMetadata.ColumnNames.Invoiceitemnumber, 29, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCommissionAuditDetailsMetadata.PropertyNames.Invoiceitemnumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditDetailsMetadata.ColumnNames.Workorderitemnumber, 30, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCommissionAuditDetailsMetadata.PropertyNames.Workorderitemnumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewCommissionAuditDetailsMetadata
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
			 Public Const Invoicenumber As String = "INVOICENUMBER"
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Productdesc As String = "PRODUCTDESC"
			 Public Const Container As String = "CONTAINER"
			 Public Const Quantity As String = "QUANTITY"
			 Public Const Itemprice As String = "ITEMPRICE"
			 Public Const Units As String = "UNITS"
			 Public Const Extprice As String = "EXTPRICE"
			 Public Const Extcost As String = "EXTCOST"
			 Public Const Grossprofit As String = "GROSSPROFIT"
			 Public Const CustID As String = "CustID"
			 Public Const SalespersonID As String = "SalespersonID"
			 Public Const Salespersonfullname As String = "SALESPERSONFULLNAME"
			 Public Const CommissionRate As String = "CommissionRate"
			 Public Const ExcRate As String = "ExcRate"
			 Public Const CommRate As String = "CommRate"
			 Public Const CommissionType As String = "CommissionType"
			 Public Const CommissionAmt As String = "CommissionAmt"
			 Public Const Invoicedate As String = "INVOICEDATE"
			 Public Const Customerpo As String = "CUSTOMERPO"
			 Public Const Subtotal As String = "SUBTOTAL"
			 Public Const Salestax As String = "SALESTAX"
			 Public Const Total As String = "TOTAL"
			 Public Const Invoicestatus As String = "INVOICESTATUS"
			 Public Const Modifyby As String = "MODIFYBY"
			 Public Const Modifytime As String = "MODIFYTIME"
			 Public Const Custname As String = "CUSTNAME"
			 Public Const Custshipcity As String = "CUSTSHIPCITY"
			 Public Const Custshipstateprov As String = "CUSTSHIPSTATEPROV"
			 Public Const Invoiceitemnumber As String = "INVOICEITEMNUMBER"
			 Public Const Workorderitemnumber As String = "WORKORDERITEMNUMBER"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Invoicenumber As String = "Invoicenumber"
			 Public Const Productid As String = "Productid"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const Container As String = "Container"
			 Public Const Quantity As String = "Quantity"
			 Public Const Itemprice As String = "Itemprice"
			 Public Const Units As String = "Units"
			 Public Const Extprice As String = "Extprice"
			 Public Const Extcost As String = "Extcost"
			 Public Const Grossprofit As String = "Grossprofit"
			 Public Const CustID As String = "CustID"
			 Public Const SalespersonID As String = "SalespersonID"
			 Public Const Salespersonfullname As String = "Salespersonfullname"
			 Public Const CommissionRate As String = "CommissionRate"
			 Public Const ExcRate As String = "ExcRate"
			 Public Const CommRate As String = "CommRate"
			 Public Const CommissionType As String = "CommissionType"
			 Public Const CommissionAmt As String = "CommissionAmt"
			 Public Const Invoicedate As String = "Invoicedate"
			 Public Const Customerpo As String = "Customerpo"
			 Public Const Subtotal As String = "Subtotal"
			 Public Const Salestax As String = "Salestax"
			 Public Const Total As String = "Total"
			 Public Const Invoicestatus As String = "Invoicestatus"
			 Public Const Modifyby As String = "Modifyby"
			 Public Const Modifytime As String = "Modifytime"
			 Public Const Custname As String = "Custname"
			 Public Const Custshipcity As String = "Custshipcity"
			 Public Const Custshipstateprov As String = "Custshipstateprov"
			 Public Const Invoiceitemnumber As String = "Invoiceitemnumber"
			 Public Const Workorderitemnumber As String = "Workorderitemnumber"
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
            SyncLock GetType(ViewCommissionAuditDetailsMetadata)
			
				If ViewCommissionAuditDetailsMetadata.mapDelegates Is Nothing Then
					ViewCommissionAuditDetailsMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewCommissionAuditDetailsMetadata._meta Is Nothing Then
                    ViewCommissionAuditDetailsMetadata._meta = New ViewCommissionAuditDetailsMetadata()
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
				

				meta.AddTypeMap("Invoicenumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Quantity", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Itemprice", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Units", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Extprice", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Extcost", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Grossprofit", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("CustID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("SalespersonID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Salespersonfullname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CommissionRate", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("ExcRate", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("CommRate", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("CommissionType", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CommissionAmt", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Invoicedate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Customerpo", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Subtotal", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Salestax", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Total", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Invoicestatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Modifyby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Modifytime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Custname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Custshipcity", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Custshipstateprov", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Invoiceitemnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Workorderitemnumber", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "viewCommissionAuditDetails"
				meta.Destination = "viewCommissionAuditDetails"
				
				meta.spInsert = "proc_viewCommissionAuditDetailsInsert"
				meta.spUpdate = "proc_viewCommissionAuditDetailsUpdate"
				meta.spDelete = "proc_viewCommissionAuditDetailsDelete"
				meta.spLoadAll = "proc_viewCommissionAuditDetailsLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCommissionAuditDetailsLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewCommissionAuditDetailsMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
