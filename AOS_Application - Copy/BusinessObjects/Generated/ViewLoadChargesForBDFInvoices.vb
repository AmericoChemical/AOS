'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 3/18/2014 1:00:08 AM
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
	MustInherit Public Class esViewLoadChargesForBDFInvoicesCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewLoadChargesForBDFInvoicesCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewLoadChargesForBDFInvoicesQuery)
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
            Me.InitQuery(CType(query, esViewLoadChargesForBDFInvoicesQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewLoadChargesForBDFInvoices) As ViewLoadChargesForBDFInvoices
			Return CType(MyBase.DetachEntity(entity), ViewLoadChargesForBDFInvoices)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewLoadChargesForBDFInvoices) As ViewLoadChargesForBDFInvoices
			Return CType(MyBase.AttachEntity(entity), ViewLoadChargesForBDFInvoices)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewLoadChargesForBDFInvoicesCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewLoadChargesForBDFInvoices
            Get
                Return TryCast(MyBase.Item(index), ViewLoadChargesForBDFInvoices)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewLoadChargesForBDFInvoices)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewLoadChargesForBDFInvoices	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewLoadChargesForBDFInvoicesQuery
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
												
						Case "LoadChargeID"
							Me.str.LoadChargeID = CType(value, string)
												
						Case "LoadID"
							Me.str.LoadID = CType(value, string)
												
						Case "CarrierID"
							Me.str.CarrierID = CType(value, string)
												
						Case "LogisticsProviderID"
							Me.str.LogisticsProviderID = CType(value, string)
												
						Case "CarrierCharges"
							Me.str.CarrierCharges = CType(value, string)
												
						Case "ChargeType"
							Me.str.ChargeType = CType(value, string)
												
						Case "ChargeDate"
							Me.str.ChargeDate = CType(value, string)
												
						Case "LoadChargeStatus"
							Me.str.LoadChargeStatus = CType(value, string)
												
						Case "ChargeNote"
							Me.str.ChargeNote = CType(value, string)
												
						Case "FreightInvoiceNumber"
							Me.str.FreightInvoiceNumber = CType(value, string)
												
						Case "FreightInvoiceDate"
							Me.str.FreightInvoiceDate = CType(value, string)
												
						Case "FreightVendorID"
							Me.str.FreightVendorID = CType(value, string)
												
						Case "APBatchID"
							Me.str.APBatchID = CType(value, string)
												
						Case "LoadStatus"
							Me.str.LoadStatus = CType(value, string)
												
						Case "LoadType"
							Me.str.LoadType = CType(value, string)
												
						Case "PlannedDepartureDate"
							Me.str.PlannedDepartureDate = CType(value, string)
												
						Case "ScheduledShipmentDate"
							Me.str.ScheduledShipmentDate = CType(value, string)
												
						Case "ActualShipmentDate"
							Me.str.ActualShipmentDate = CType(value, string)
												
						Case "CarrierProNumber"
							Me.str.CarrierProNumber = CType(value, string)
												
						Case "Fob"
							Me.str.Fob = CType(value, string)
												
						Case "BillCustomer"
							Me.str.BillCustomer = CType(value, string)
												
						Case "AddToInvoice"
							Me.str.AddToInvoice = CType(value, string)
												
						Case "LogisticsID"
							Me.str.LogisticsID = CType(value, string)
												
						Case "ScheduledCarrierID"
							Me.str.ScheduledCarrierID = CType(value, string)
												
						Case "Workordernumber"
							Me.str.Workordernumber = CType(value, string)
												
						Case "Custname"
							Me.str.Custname = CType(value, string)
												
						Case "Customerpo"
							Me.str.Customerpo = CType(value, string)
												
						Case "Totalbillings"
							Me.str.Totalbillings = CType(value, string)
												
						Case "CarrierName"
							Me.str.CarrierName = CType(value, string)
												
						Case "OriginName"
							Me.str.OriginName = CType(value, string)
												
						Case "OriginAddress1"
							Me.str.OriginAddress1 = CType(value, string)
												
						Case "OriginAddress2"
							Me.str.OriginAddress2 = CType(value, string)
												
						Case "OriginCity"
							Me.str.OriginCity = CType(value, string)
												
						Case "OriginState"
							Me.str.OriginState = CType(value, string)
												
						Case "OriginZip"
							Me.str.OriginZip = CType(value, string)
												
						Case "OriginCountry"
							Me.str.OriginCountry = CType(value, string)
												
						Case "OriginPhone"
							Me.str.OriginPhone = CType(value, string)
												
						Case "OriginContact"
							Me.str.OriginContact = CType(value, string)
												
						Case "DestName"
							Me.str.DestName = CType(value, string)
												
						Case "DestAddress1"
							Me.str.DestAddress1 = CType(value, string)
												
						Case "DestAddress2"
							Me.str.DestAddress2 = CType(value, string)
												
						Case "DestCity"
							Me.str.DestCity = CType(value, string)
												
						Case "DestState"
							Me.str.DestState = CType(value, string)
												
						Case "DestZip"
							Me.str.DestZip = CType(value, string)
												
						Case "DestCountry"
							Me.str.DestCountry = CType(value, string)
												
						Case "DestPhone"
							Me.str.DestPhone = CType(value, string)
												
						Case "DestContact"
							Me.str.DestContact = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "LoadChargeID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.LoadChargeID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "LoadID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.LoadID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "CarrierID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.CarrierID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "LogisticsProviderID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.LogisticsProviderID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "CarrierCharges"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.CarrierCharges = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "ChargeDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.ChargeDate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "FreightInvoiceDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.FreightInvoiceDate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "FreightVendorID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.FreightVendorID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "APBatchID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.APBatchID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "PlannedDepartureDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.PlannedDepartureDate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "ScheduledShipmentDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.ScheduledShipmentDate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "ActualShipmentDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.ActualShipmentDate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "BillCustomer"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.BillCustomer = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "AddToInvoice"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.AddToInvoice = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "LogisticsID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.LogisticsID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "ScheduledCarrierID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ScheduledCarrierID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Workordernumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Workordernumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Totalbillings"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Totalbillings = CType(value, Nullable(Of System.Decimal))
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
		' Maps to viewLoadChargesForBDFInvoices.LoadChargeID
		' </summary>
		Public Overridable Property LoadChargeID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.LoadChargeID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.LoadChargeID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDFInvoices.LoadID
		' </summary>
		Public Overridable Property LoadID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.LoadID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.LoadID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDFInvoices.CarrierID
		' </summary>
		Public Overridable Property CarrierID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.CarrierID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.CarrierID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDFInvoices.LogisticsProviderID
		' </summary>
		Public Overridable Property LogisticsProviderID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.LogisticsProviderID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.LogisticsProviderID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDFInvoices.CarrierCharges
		' </summary>
		Public Overridable Property CarrierCharges As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.CarrierCharges)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.CarrierCharges, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDFInvoices.ChargeType
		' </summary>
		Public Overridable Property ChargeType As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.ChargeType)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.ChargeType, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDFInvoices.ChargeDate
		' </summary>
		Public Overridable Property ChargeDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.ChargeDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.ChargeDate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDFInvoices.LoadChargeStatus
		' </summary>
		Public Overridable Property LoadChargeStatus As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.LoadChargeStatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.LoadChargeStatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDFInvoices.ChargeNote
		' </summary>
		Public Overridable Property ChargeNote As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.ChargeNote)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.ChargeNote, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDFInvoices.FreightInvoiceNumber
		' </summary>
		Public Overridable Property FreightInvoiceNumber As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.FreightInvoiceNumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.FreightInvoiceNumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDFInvoices.FreightInvoiceDate
		' </summary>
		Public Overridable Property FreightInvoiceDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.FreightInvoiceDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.FreightInvoiceDate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDFInvoices.FreightVendorID
		' </summary>
		Public Overridable Property FreightVendorID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.FreightVendorID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.FreightVendorID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDFInvoices.APBatchID
		' </summary>
		Public Overridable Property APBatchID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.APBatchID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.APBatchID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDFInvoices.LoadStatus
		' </summary>
		Public Overridable Property LoadStatus As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.LoadStatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.LoadStatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDFInvoices.LoadType
		' </summary>
		Public Overridable Property LoadType As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.LoadType)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.LoadType, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDFInvoices.PlannedDepartureDate
		' </summary>
		Public Overridable Property PlannedDepartureDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.PlannedDepartureDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.PlannedDepartureDate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDFInvoices.ScheduledShipmentDate
		' </summary>
		Public Overridable Property ScheduledShipmentDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.ScheduledShipmentDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.ScheduledShipmentDate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDFInvoices.ActualShipmentDate
		' </summary>
		Public Overridable Property ActualShipmentDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.ActualShipmentDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.ActualShipmentDate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDFInvoices.CarrierProNumber
		' </summary>
		Public Overridable Property CarrierProNumber As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.CarrierProNumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.CarrierProNumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDFInvoices.FOB
		' </summary>
		Public Overridable Property Fob As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.Fob)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.Fob, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDFInvoices.BillCustomer
		' </summary>
		Public Overridable Property BillCustomer As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.BillCustomer)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.BillCustomer, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDFInvoices.AddToInvoice
		' </summary>
		Public Overridable Property AddToInvoice As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.AddToInvoice)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.AddToInvoice, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDFInvoices.LogisticsID
		' </summary>
		Public Overridable Property LogisticsID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.LogisticsID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.LogisticsID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDFInvoices.ScheduledCarrierID
		' </summary>
		Public Overridable Property ScheduledCarrierID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.ScheduledCarrierID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.ScheduledCarrierID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDFInvoices.WORKORDERNUMBER
		' </summary>
		Public Overridable Property Workordernumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.Workordernumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.Workordernumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDFInvoices.CUSTNAME
		' </summary>
		Public Overridable Property Custname As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.Custname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.Custname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDFInvoices.CUSTOMERPO
		' </summary>
		Public Overridable Property Customerpo As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.Customerpo)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.Customerpo, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDFInvoices.TOTALBILLINGS
		' </summary>
		Public Overridable Property Totalbillings As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.Totalbillings)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.Totalbillings, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDFInvoices.CarrierName
		' </summary>
		Public Overridable Property CarrierName As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.CarrierName)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.CarrierName, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDFInvoices.OriginName
		' </summary>
		Public Overridable Property OriginName As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.OriginName)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.OriginName, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDFInvoices.OriginAddress1
		' </summary>
		Public Overridable Property OriginAddress1 As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.OriginAddress1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.OriginAddress1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDFInvoices.OriginAddress2
		' </summary>
		Public Overridable Property OriginAddress2 As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.OriginAddress2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.OriginAddress2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDFInvoices.OriginCity
		' </summary>
		Public Overridable Property OriginCity As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.OriginCity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.OriginCity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDFInvoices.OriginState
		' </summary>
		Public Overridable Property OriginState As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.OriginState)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.OriginState, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDFInvoices.OriginZip
		' </summary>
		Public Overridable Property OriginZip As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.OriginZip)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.OriginZip, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDFInvoices.OriginCountry
		' </summary>
		Public Overridable Property OriginCountry As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.OriginCountry)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.OriginCountry, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDFInvoices.OriginPhone
		' </summary>
		Public Overridable Property OriginPhone As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.OriginPhone)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.OriginPhone, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDFInvoices.OriginContact
		' </summary>
		Public Overridable Property OriginContact As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.OriginContact)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.OriginContact, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDFInvoices.DestName
		' </summary>
		Public Overridable Property DestName As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.DestName)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.DestName, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDFInvoices.DestAddress1
		' </summary>
		Public Overridable Property DestAddress1 As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.DestAddress1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.DestAddress1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDFInvoices.DestAddress2
		' </summary>
		Public Overridable Property DestAddress2 As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.DestAddress2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.DestAddress2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDFInvoices.DestCity
		' </summary>
		Public Overridable Property DestCity As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.DestCity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.DestCity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDFInvoices.DestState
		' </summary>
		Public Overridable Property DestState As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.DestState)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.DestState, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDFInvoices.DestZip
		' </summary>
		Public Overridable Property DestZip As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.DestZip)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.DestZip, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDFInvoices.DestCountry
		' </summary>
		Public Overridable Property DestCountry As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.DestCountry)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.DestCountry, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDFInvoices.DestPhone
		' </summary>
		Public Overridable Property DestPhone As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.DestPhone)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.DestPhone, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDFInvoices.DestContact
		' </summary>
		Public Overridable Property DestContact As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.DestContact)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.DestContact, value)
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
		
			Public Sub New(ByVal entity As esViewLoadChargesForBDFInvoices)
				Me.entity = entity
			End Sub				
		
	
			Public Property LoadChargeID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.LoadChargeID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LoadChargeID = Nothing
					Else
						entity.LoadChargeID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property LoadID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.LoadID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LoadID = Nothing
					Else
						entity.LoadID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property CarrierID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.CarrierID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CarrierID = Nothing
					Else
						entity.CarrierID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property LogisticsProviderID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.LogisticsProviderID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LogisticsProviderID = Nothing
					Else
						entity.LogisticsProviderID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property CarrierCharges As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.CarrierCharges
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CarrierCharges = Nothing
					Else
						entity.CarrierCharges = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property ChargeType As System.String 
				Get
					Dim data_ As System.String = entity.ChargeType
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ChargeType = Nothing
					Else
						entity.ChargeType = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ChargeDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.ChargeDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ChargeDate = Nothing
					Else
						entity.ChargeDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property LoadChargeStatus As System.String 
				Get
					Dim data_ As System.String = entity.LoadChargeStatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LoadChargeStatus = Nothing
					Else
						entity.LoadChargeStatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ChargeNote As System.String 
				Get
					Dim data_ As System.String = entity.ChargeNote
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ChargeNote = Nothing
					Else
						entity.ChargeNote = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FreightInvoiceNumber As System.String 
				Get
					Dim data_ As System.String = entity.FreightInvoiceNumber
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FreightInvoiceNumber = Nothing
					Else
						entity.FreightInvoiceNumber = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FreightInvoiceDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.FreightInvoiceDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FreightInvoiceDate = Nothing
					Else
						entity.FreightInvoiceDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property FreightVendorID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.FreightVendorID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FreightVendorID = Nothing
					Else
						entity.FreightVendorID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property APBatchID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.APBatchID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.APBatchID = Nothing
					Else
						entity.APBatchID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property LoadStatus As System.String 
				Get
					Dim data_ As System.String = entity.LoadStatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LoadStatus = Nothing
					Else
						entity.LoadStatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property LoadType As System.String 
				Get
					Dim data_ As System.String = entity.LoadType
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LoadType = Nothing
					Else
						entity.LoadType = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PlannedDepartureDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.PlannedDepartureDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PlannedDepartureDate = Nothing
					Else
						entity.PlannedDepartureDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property ScheduledShipmentDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.ScheduledShipmentDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ScheduledShipmentDate = Nothing
					Else
						entity.ScheduledShipmentDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property ActualShipmentDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.ActualShipmentDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ActualShipmentDate = Nothing
					Else
						entity.ActualShipmentDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property CarrierProNumber As System.String 
				Get
					Dim data_ As System.String = entity.CarrierProNumber
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CarrierProNumber = Nothing
					Else
						entity.CarrierProNumber = Convert.ToString(Value)
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
		  	
			Public Property BillCustomer As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.BillCustomer
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BillCustomer = Nothing
					Else
						entity.BillCustomer = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property AddToInvoice As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.AddToInvoice
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AddToInvoice = Nothing
					Else
						entity.AddToInvoice = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property LogisticsID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.LogisticsID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LogisticsID = Nothing
					Else
						entity.LogisticsID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property ScheduledCarrierID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.ScheduledCarrierID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ScheduledCarrierID = Nothing
					Else
						entity.ScheduledCarrierID = Convert.ToInt32(Value)
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
		  	
			Public Property Totalbillings As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Totalbillings
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Totalbillings = Nothing
					Else
						entity.Totalbillings = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property CarrierName As System.String 
				Get
					Dim data_ As System.String = entity.CarrierName
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CarrierName = Nothing
					Else
						entity.CarrierName = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property OriginName As System.String 
				Get
					Dim data_ As System.String = entity.OriginName
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OriginName = Nothing
					Else
						entity.OriginName = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property OriginAddress1 As System.String 
				Get
					Dim data_ As System.String = entity.OriginAddress1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OriginAddress1 = Nothing
					Else
						entity.OriginAddress1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property OriginAddress2 As System.String 
				Get
					Dim data_ As System.String = entity.OriginAddress2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OriginAddress2 = Nothing
					Else
						entity.OriginAddress2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property OriginCity As System.String 
				Get
					Dim data_ As System.String = entity.OriginCity
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OriginCity = Nothing
					Else
						entity.OriginCity = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property OriginState As System.String 
				Get
					Dim data_ As System.String = entity.OriginState
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OriginState = Nothing
					Else
						entity.OriginState = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property OriginZip As System.String 
				Get
					Dim data_ As System.String = entity.OriginZip
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OriginZip = Nothing
					Else
						entity.OriginZip = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property OriginCountry As System.String 
				Get
					Dim data_ As System.String = entity.OriginCountry
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OriginCountry = Nothing
					Else
						entity.OriginCountry = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property OriginPhone As System.String 
				Get
					Dim data_ As System.String = entity.OriginPhone
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OriginPhone = Nothing
					Else
						entity.OriginPhone = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property OriginContact As System.String 
				Get
					Dim data_ As System.String = entity.OriginContact
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OriginContact = Nothing
					Else
						entity.OriginContact = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property DestName As System.String 
				Get
					Dim data_ As System.String = entity.DestName
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DestName = Nothing
					Else
						entity.DestName = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property DestAddress1 As System.String 
				Get
					Dim data_ As System.String = entity.DestAddress1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DestAddress1 = Nothing
					Else
						entity.DestAddress1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property DestAddress2 As System.String 
				Get
					Dim data_ As System.String = entity.DestAddress2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DestAddress2 = Nothing
					Else
						entity.DestAddress2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property DestCity As System.String 
				Get
					Dim data_ As System.String = entity.DestCity
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DestCity = Nothing
					Else
						entity.DestCity = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property DestState As System.String 
				Get
					Dim data_ As System.String = entity.DestState
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DestState = Nothing
					Else
						entity.DestState = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property DestZip As System.String 
				Get
					Dim data_ As System.String = entity.DestZip
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DestZip = Nothing
					Else
						entity.DestZip = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property DestCountry As System.String 
				Get
					Dim data_ As System.String = entity.DestCountry
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DestCountry = Nothing
					Else
						entity.DestCountry = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property DestPhone As System.String 
				Get
					Dim data_ As System.String = entity.DestPhone
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DestPhone = Nothing
					Else
						entity.DestPhone = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property DestContact As System.String 
				Get
					Dim data_ As System.String = entity.DestContact
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DestContact = Nothing
					Else
						entity.DestContact = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewLoadChargesForBDFInvoices
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewLoadChargesForBDFInvoicesQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewLoadChargesForBDFInvoices can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewLoadChargesForBDFInvoicesQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewLoadChargesForBDFInvoicesMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property LoadChargeID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.LoadChargeID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LoadID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.LoadID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property CarrierID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.CarrierID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LogisticsProviderID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.LogisticsProviderID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property CarrierCharges As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.CarrierCharges, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property ChargeType As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.ChargeType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ChargeDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.ChargeDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property LoadChargeStatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.LoadChargeStatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ChargeNote As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.ChargeNote, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FreightInvoiceNumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.FreightInvoiceNumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FreightInvoiceDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.FreightInvoiceDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property FreightVendorID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.FreightVendorID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property APBatchID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.APBatchID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LoadStatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.LoadStatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LoadType As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.LoadType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PlannedDepartureDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.PlannedDepartureDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ScheduledShipmentDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.ScheduledShipmentDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ActualShipmentDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.ActualShipmentDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property CarrierProNumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.CarrierProNumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Fob As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.Fob, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BillCustomer As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.BillCustomer, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property AddToInvoice As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.AddToInvoice, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property LogisticsID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.LogisticsID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ScheduledCarrierID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.ScheduledCarrierID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Workordernumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.Workordernumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Custname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.Custname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Customerpo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.Customerpo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Totalbillings As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.Totalbillings, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property CarrierName As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.CarrierName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OriginName As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.OriginName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OriginAddress1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.OriginAddress1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OriginAddress2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.OriginAddress2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OriginCity As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.OriginCity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OriginState As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.OriginState, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OriginZip As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.OriginZip, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OriginCountry As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.OriginCountry, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OriginPhone As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.OriginPhone, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OriginContact As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.OriginContact, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DestName As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.DestName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DestAddress1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.DestAddress1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DestAddress2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.DestAddress2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DestCity As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.DestCity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DestState As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.DestState, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DestZip As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.DestZip, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DestCountry As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.DestCountry, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DestPhone As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.DestPhone, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DestContact As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.DestContact, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewLoadChargesForBDFInvoicesCollection")> _
	Partial Public Class ViewLoadChargesForBDFInvoicesCollection
		Inherits esViewLoadChargesForBDFInvoicesCollection
		Implements IEnumerable(Of ViewLoadChargesForBDFInvoices)
		
        Public Shared Widening Operator CType(ByVal coll As ViewLoadChargesForBDFInvoicesCollection) As List(Of ViewLoadChargesForBDFInvoices)
            Dim list As List(Of ViewLoadChargesForBDFInvoices) = New List(Of ViewLoadChargesForBDFInvoices)
            Dim emp As ViewLoadChargesForBDFInvoices

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewLoadChargesForBDFInvoicesMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewLoadChargesForBDFInvoicesQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewLoadChargesForBDFInvoices(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewLoadChargesForBDFInvoices()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewLoadChargesForBDFInvoicesQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewLoadChargesForBDFInvoicesQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewLoadChargesForBDFInvoicesQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewLoadChargesForBDFInvoices 
			Return CType(MyBase.AddNewEntity(), ViewLoadChargesForBDFInvoices)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewLoadChargesForBDFInvoices) Implements IEnumerable(Of ViewLoadChargesForBDFInvoices).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewLoadChargesForBDFInvoices)(Me)
        End Function
		
		Private _query As ViewLoadChargesForBDFInvoicesQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewLoadChargesForBDFInvoices' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewLoadChargesForBDFInvoices ()")> _
	<Serializable> _
	Partial Public Class ViewLoadChargesForBDFInvoices 
		Inherits esViewLoadChargesForBDFInvoices

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewLoadChargesForBDFInvoicesMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewLoadChargesForBDFInvoicesQuery

			If Me._query Is Nothing Then
				Me._query = New ViewLoadChargesForBDFInvoicesQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewLoadChargesForBDFInvoicesQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewLoadChargesForBDFInvoicesQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewLoadChargesForBDFInvoicesQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewLoadChargesForBDFInvoicesQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewLoadChargesForBDFInvoicesQuery
		inherits esViewLoadChargesForBDFInvoicesQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewLoadChargesForBDFInvoicesQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewLoadChargesForBDFInvoicesMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.LoadChargeID, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadChargesForBDFInvoicesMetadata.PropertyNames.LoadChargeID
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.LoadID, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadChargesForBDFInvoicesMetadata.PropertyNames.LoadID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.CarrierID, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadChargesForBDFInvoicesMetadata.PropertyNames.CarrierID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.LogisticsProviderID, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadChargesForBDFInvoicesMetadata.PropertyNames.LogisticsProviderID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.CarrierCharges, 4, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewLoadChargesForBDFInvoicesMetadata.PropertyNames.CarrierCharges
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.ChargeType, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadChargesForBDFInvoicesMetadata.PropertyNames.ChargeType
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.ChargeDate, 6, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewLoadChargesForBDFInvoicesMetadata.PropertyNames.ChargeDate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.LoadChargeStatus, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadChargesForBDFInvoicesMetadata.PropertyNames.LoadChargeStatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.ChargeNote, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadChargesForBDFInvoicesMetadata.PropertyNames.ChargeNote
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.FreightInvoiceNumber, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadChargesForBDFInvoicesMetadata.PropertyNames.FreightInvoiceNumber
			c.CharacterMaxLength = 30
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.FreightInvoiceDate, 10, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewLoadChargesForBDFInvoicesMetadata.PropertyNames.FreightInvoiceDate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.FreightVendorID, 11, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadChargesForBDFInvoicesMetadata.PropertyNames.FreightVendorID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.APBatchID, 12, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadChargesForBDFInvoicesMetadata.PropertyNames.APBatchID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.LoadStatus, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadChargesForBDFInvoicesMetadata.PropertyNames.LoadStatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.LoadType, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadChargesForBDFInvoicesMetadata.PropertyNames.LoadType
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.PlannedDepartureDate, 15, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewLoadChargesForBDFInvoicesMetadata.PropertyNames.PlannedDepartureDate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.ScheduledShipmentDate, 16, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewLoadChargesForBDFInvoicesMetadata.PropertyNames.ScheduledShipmentDate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.ActualShipmentDate, 17, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewLoadChargesForBDFInvoicesMetadata.PropertyNames.ActualShipmentDate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.CarrierProNumber, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadChargesForBDFInvoicesMetadata.PropertyNames.CarrierProNumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.Fob, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadChargesForBDFInvoicesMetadata.PropertyNames.Fob
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.BillCustomer, 20, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewLoadChargesForBDFInvoicesMetadata.PropertyNames.BillCustomer
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.AddToInvoice, 21, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewLoadChargesForBDFInvoicesMetadata.PropertyNames.AddToInvoice
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.LogisticsID, 22, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadChargesForBDFInvoicesMetadata.PropertyNames.LogisticsID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.ScheduledCarrierID, 23, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadChargesForBDFInvoicesMetadata.PropertyNames.ScheduledCarrierID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.Workordernumber, 24, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadChargesForBDFInvoicesMetadata.PropertyNames.Workordernumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.Custname, 25, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadChargesForBDFInvoicesMetadata.PropertyNames.Custname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.Customerpo, 26, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadChargesForBDFInvoicesMetadata.PropertyNames.Customerpo
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.Totalbillings, 27, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewLoadChargesForBDFInvoicesMetadata.PropertyNames.Totalbillings
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.CarrierName, 28, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadChargesForBDFInvoicesMetadata.PropertyNames.CarrierName
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.OriginName, 29, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadChargesForBDFInvoicesMetadata.PropertyNames.OriginName
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.OriginAddress1, 30, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadChargesForBDFInvoicesMetadata.PropertyNames.OriginAddress1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.OriginAddress2, 31, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadChargesForBDFInvoicesMetadata.PropertyNames.OriginAddress2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.OriginCity, 32, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadChargesForBDFInvoicesMetadata.PropertyNames.OriginCity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.OriginState, 33, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadChargesForBDFInvoicesMetadata.PropertyNames.OriginState
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.OriginZip, 34, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadChargesForBDFInvoicesMetadata.PropertyNames.OriginZip
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.OriginCountry, 35, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadChargesForBDFInvoicesMetadata.PropertyNames.OriginCountry
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.OriginPhone, 36, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadChargesForBDFInvoicesMetadata.PropertyNames.OriginPhone
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.OriginContact, 37, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadChargesForBDFInvoicesMetadata.PropertyNames.OriginContact
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.DestName, 38, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadChargesForBDFInvoicesMetadata.PropertyNames.DestName
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.DestAddress1, 39, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadChargesForBDFInvoicesMetadata.PropertyNames.DestAddress1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.DestAddress2, 40, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadChargesForBDFInvoicesMetadata.PropertyNames.DestAddress2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.DestCity, 41, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadChargesForBDFInvoicesMetadata.PropertyNames.DestCity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.DestState, 42, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadChargesForBDFInvoicesMetadata.PropertyNames.DestState
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.DestZip, 43, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadChargesForBDFInvoicesMetadata.PropertyNames.DestZip
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.DestCountry, 44, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadChargesForBDFInvoicesMetadata.PropertyNames.DestCountry
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.DestPhone, 45, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadChargesForBDFInvoicesMetadata.PropertyNames.DestPhone
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFInvoicesMetadata.ColumnNames.DestContact, 46, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadChargesForBDFInvoicesMetadata.PropertyNames.DestContact
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewLoadChargesForBDFInvoicesMetadata
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
			 Public Const LoadChargeID As String = "LoadChargeID"
			 Public Const LoadID As String = "LoadID"
			 Public Const CarrierID As String = "CarrierID"
			 Public Const LogisticsProviderID As String = "LogisticsProviderID"
			 Public Const CarrierCharges As String = "CarrierCharges"
			 Public Const ChargeType As String = "ChargeType"
			 Public Const ChargeDate As String = "ChargeDate"
			 Public Const LoadChargeStatus As String = "LoadChargeStatus"
			 Public Const ChargeNote As String = "ChargeNote"
			 Public Const FreightInvoiceNumber As String = "FreightInvoiceNumber"
			 Public Const FreightInvoiceDate As String = "FreightInvoiceDate"
			 Public Const FreightVendorID As String = "FreightVendorID"
			 Public Const APBatchID As String = "APBatchID"
			 Public Const LoadStatus As String = "LoadStatus"
			 Public Const LoadType As String = "LoadType"
			 Public Const PlannedDepartureDate As String = "PlannedDepartureDate"
			 Public Const ScheduledShipmentDate As String = "ScheduledShipmentDate"
			 Public Const ActualShipmentDate As String = "ActualShipmentDate"
			 Public Const CarrierProNumber As String = "CarrierProNumber"
			 Public Const Fob As String = "FOB"
			 Public Const BillCustomer As String = "BillCustomer"
			 Public Const AddToInvoice As String = "AddToInvoice"
			 Public Const LogisticsID As String = "LogisticsID"
			 Public Const ScheduledCarrierID As String = "ScheduledCarrierID"
			 Public Const Workordernumber As String = "WORKORDERNUMBER"
			 Public Const Custname As String = "CUSTNAME"
			 Public Const Customerpo As String = "CUSTOMERPO"
			 Public Const Totalbillings As String = "TOTALBILLINGS"
			 Public Const CarrierName As String = "CarrierName"
			 Public Const OriginName As String = "OriginName"
			 Public Const OriginAddress1 As String = "OriginAddress1"
			 Public Const OriginAddress2 As String = "OriginAddress2"
			 Public Const OriginCity As String = "OriginCity"
			 Public Const OriginState As String = "OriginState"
			 Public Const OriginZip As String = "OriginZip"
			 Public Const OriginCountry As String = "OriginCountry"
			 Public Const OriginPhone As String = "OriginPhone"
			 Public Const OriginContact As String = "OriginContact"
			 Public Const DestName As String = "DestName"
			 Public Const DestAddress1 As String = "DestAddress1"
			 Public Const DestAddress2 As String = "DestAddress2"
			 Public Const DestCity As String = "DestCity"
			 Public Const DestState As String = "DestState"
			 Public Const DestZip As String = "DestZip"
			 Public Const DestCountry As String = "DestCountry"
			 Public Const DestPhone As String = "DestPhone"
			 Public Const DestContact As String = "DestContact"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const LoadChargeID As String = "LoadChargeID"
			 Public Const LoadID As String = "LoadID"
			 Public Const CarrierID As String = "CarrierID"
			 Public Const LogisticsProviderID As String = "LogisticsProviderID"
			 Public Const CarrierCharges As String = "CarrierCharges"
			 Public Const ChargeType As String = "ChargeType"
			 Public Const ChargeDate As String = "ChargeDate"
			 Public Const LoadChargeStatus As String = "LoadChargeStatus"
			 Public Const ChargeNote As String = "ChargeNote"
			 Public Const FreightInvoiceNumber As String = "FreightInvoiceNumber"
			 Public Const FreightInvoiceDate As String = "FreightInvoiceDate"
			 Public Const FreightVendorID As String = "FreightVendorID"
			 Public Const APBatchID As String = "APBatchID"
			 Public Const LoadStatus As String = "LoadStatus"
			 Public Const LoadType As String = "LoadType"
			 Public Const PlannedDepartureDate As String = "PlannedDepartureDate"
			 Public Const ScheduledShipmentDate As String = "ScheduledShipmentDate"
			 Public Const ActualShipmentDate As String = "ActualShipmentDate"
			 Public Const CarrierProNumber As String = "CarrierProNumber"
			 Public Const Fob As String = "Fob"
			 Public Const BillCustomer As String = "BillCustomer"
			 Public Const AddToInvoice As String = "AddToInvoice"
			 Public Const LogisticsID As String = "LogisticsID"
			 Public Const ScheduledCarrierID As String = "ScheduledCarrierID"
			 Public Const Workordernumber As String = "Workordernumber"
			 Public Const Custname As String = "Custname"
			 Public Const Customerpo As String = "Customerpo"
			 Public Const Totalbillings As String = "Totalbillings"
			 Public Const CarrierName As String = "CarrierName"
			 Public Const OriginName As String = "OriginName"
			 Public Const OriginAddress1 As String = "OriginAddress1"
			 Public Const OriginAddress2 As String = "OriginAddress2"
			 Public Const OriginCity As String = "OriginCity"
			 Public Const OriginState As String = "OriginState"
			 Public Const OriginZip As String = "OriginZip"
			 Public Const OriginCountry As String = "OriginCountry"
			 Public Const OriginPhone As String = "OriginPhone"
			 Public Const OriginContact As String = "OriginContact"
			 Public Const DestName As String = "DestName"
			 Public Const DestAddress1 As String = "DestAddress1"
			 Public Const DestAddress2 As String = "DestAddress2"
			 Public Const DestCity As String = "DestCity"
			 Public Const DestState As String = "DestState"
			 Public Const DestZip As String = "DestZip"
			 Public Const DestCountry As String = "DestCountry"
			 Public Const DestPhone As String = "DestPhone"
			 Public Const DestContact As String = "DestContact"
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
            SyncLock GetType(ViewLoadChargesForBDFInvoicesMetadata)
			
				If ViewLoadChargesForBDFInvoicesMetadata.mapDelegates Is Nothing Then
					ViewLoadChargesForBDFInvoicesMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewLoadChargesForBDFInvoicesMetadata._meta Is Nothing Then
                    ViewLoadChargesForBDFInvoicesMetadata._meta = New ViewLoadChargesForBDFInvoicesMetadata()
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
				

				meta.AddTypeMap("LoadChargeID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("LoadID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("CarrierID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("LogisticsProviderID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("CarrierCharges", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("ChargeType", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ChargeDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("LoadChargeStatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ChargeNote", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("FreightInvoiceNumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("FreightInvoiceDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("FreightVendorID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("APBatchID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("LoadStatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("LoadType", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("PlannedDepartureDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("ScheduledShipmentDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("ActualShipmentDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("CarrierProNumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Fob", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("BillCustomer", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("AddToInvoice", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("LogisticsID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ScheduledCarrierID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Workordernumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Custname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Customerpo", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Totalbillings", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("CarrierName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("OriginName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("OriginAddress1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("OriginAddress2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("OriginCity", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("OriginState", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("OriginZip", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("OriginCountry", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("OriginPhone", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("OriginContact", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("DestName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("DestAddress1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("DestAddress2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("DestCity", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("DestState", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("DestZip", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("DestCountry", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("DestPhone", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("DestContact", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewLoadChargesForBDFInvoices"
				meta.Destination = "viewLoadChargesForBDFInvoices"
				
				meta.spInsert = "proc_viewLoadChargesForBDFInvoicesInsert"
				meta.spUpdate = "proc_viewLoadChargesForBDFInvoicesUpdate"
				meta.spDelete = "proc_viewLoadChargesForBDFInvoicesDelete"
				meta.spLoadAll = "proc_viewLoadChargesForBDFInvoicesLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewLoadChargesForBDFInvoicesLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewLoadChargesForBDFInvoicesMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
