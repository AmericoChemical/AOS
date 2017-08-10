'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 3/12/2014 2:03:13 PM
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
	MustInherit Public Class esViewLoadChargesForBDFCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewLoadChargesForBDFCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewLoadChargesForBDFQuery)
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
            Me.InitQuery(CType(query, esViewLoadChargesForBDFQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewLoadChargesForBDF) As ViewLoadChargesForBDF
			Return CType(MyBase.DetachEntity(entity), ViewLoadChargesForBDF)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewLoadChargesForBDF) As ViewLoadChargesForBDF
			Return CType(MyBase.AttachEntity(entity), ViewLoadChargesForBDF)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewLoadChargesForBDFCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewLoadChargesForBDF
            Get
                Return TryCast(MyBase.Item(index), ViewLoadChargesForBDF)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewLoadChargesForBDF)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewLoadChargesForBDF	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewLoadChargesForBDFQuery
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
		' Maps to viewLoadChargesForBDF.LoadChargeID
		' </summary>
		Public Overridable Property LoadChargeID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadChargesForBDFMetadata.ColumnNames.LoadChargeID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadChargesForBDFMetadata.ColumnNames.LoadChargeID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDF.LoadID
		' </summary>
		Public Overridable Property LoadID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadChargesForBDFMetadata.ColumnNames.LoadID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadChargesForBDFMetadata.ColumnNames.LoadID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDF.CarrierID
		' </summary>
		Public Overridable Property CarrierID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadChargesForBDFMetadata.ColumnNames.CarrierID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadChargesForBDFMetadata.ColumnNames.CarrierID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDF.LogisticsProviderID
		' </summary>
		Public Overridable Property LogisticsProviderID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadChargesForBDFMetadata.ColumnNames.LogisticsProviderID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadChargesForBDFMetadata.ColumnNames.LogisticsProviderID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDF.CarrierCharges
		' </summary>
		Public Overridable Property CarrierCharges As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewLoadChargesForBDFMetadata.ColumnNames.CarrierCharges)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewLoadChargesForBDFMetadata.ColumnNames.CarrierCharges, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDF.ChargeType
		' </summary>
		Public Overridable Property ChargeType As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadChargesForBDFMetadata.ColumnNames.ChargeType)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadChargesForBDFMetadata.ColumnNames.ChargeType, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDF.ChargeDate
		' </summary>
		Public Overridable Property ChargeDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewLoadChargesForBDFMetadata.ColumnNames.ChargeDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewLoadChargesForBDFMetadata.ColumnNames.ChargeDate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDF.LoadChargeStatus
		' </summary>
		Public Overridable Property LoadChargeStatus As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadChargesForBDFMetadata.ColumnNames.LoadChargeStatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadChargesForBDFMetadata.ColumnNames.LoadChargeStatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDF.ChargeNote
		' </summary>
		Public Overridable Property ChargeNote As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadChargesForBDFMetadata.ColumnNames.ChargeNote)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadChargesForBDFMetadata.ColumnNames.ChargeNote, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDF.FreightInvoiceNumber
		' </summary>
		Public Overridable Property FreightInvoiceNumber As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadChargesForBDFMetadata.ColumnNames.FreightInvoiceNumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadChargesForBDFMetadata.ColumnNames.FreightInvoiceNumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDF.FreightInvoiceDate
		' </summary>
		Public Overridable Property FreightInvoiceDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewLoadChargesForBDFMetadata.ColumnNames.FreightInvoiceDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewLoadChargesForBDFMetadata.ColumnNames.FreightInvoiceDate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDF.FreightVendorID
		' </summary>
		Public Overridable Property FreightVendorID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadChargesForBDFMetadata.ColumnNames.FreightVendorID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadChargesForBDFMetadata.ColumnNames.FreightVendorID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDF.APBatchID
		' </summary>
		Public Overridable Property APBatchID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadChargesForBDFMetadata.ColumnNames.APBatchID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadChargesForBDFMetadata.ColumnNames.APBatchID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDF.LoadStatus
		' </summary>
		Public Overridable Property LoadStatus As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadChargesForBDFMetadata.ColumnNames.LoadStatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadChargesForBDFMetadata.ColumnNames.LoadStatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDF.LoadType
		' </summary>
		Public Overridable Property LoadType As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadChargesForBDFMetadata.ColumnNames.LoadType)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadChargesForBDFMetadata.ColumnNames.LoadType, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDF.PlannedDepartureDate
		' </summary>
		Public Overridable Property PlannedDepartureDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewLoadChargesForBDFMetadata.ColumnNames.PlannedDepartureDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewLoadChargesForBDFMetadata.ColumnNames.PlannedDepartureDate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDF.ScheduledShipmentDate
		' </summary>
		Public Overridable Property ScheduledShipmentDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewLoadChargesForBDFMetadata.ColumnNames.ScheduledShipmentDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewLoadChargesForBDFMetadata.ColumnNames.ScheduledShipmentDate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDF.ActualShipmentDate
		' </summary>
		Public Overridable Property ActualShipmentDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewLoadChargesForBDFMetadata.ColumnNames.ActualShipmentDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewLoadChargesForBDFMetadata.ColumnNames.ActualShipmentDate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDF.CarrierProNumber
		' </summary>
		Public Overridable Property CarrierProNumber As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadChargesForBDFMetadata.ColumnNames.CarrierProNumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadChargesForBDFMetadata.ColumnNames.CarrierProNumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDF.FOB
		' </summary>
		Public Overridable Property Fob As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadChargesForBDFMetadata.ColumnNames.Fob)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadChargesForBDFMetadata.ColumnNames.Fob, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDF.BillCustomer
		' </summary>
		Public Overridable Property BillCustomer As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewLoadChargesForBDFMetadata.ColumnNames.BillCustomer)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewLoadChargesForBDFMetadata.ColumnNames.BillCustomer, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDF.AddToInvoice
		' </summary>
		Public Overridable Property AddToInvoice As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewLoadChargesForBDFMetadata.ColumnNames.AddToInvoice)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewLoadChargesForBDFMetadata.ColumnNames.AddToInvoice, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDF.LogisticsID
		' </summary>
		Public Overridable Property LogisticsID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadChargesForBDFMetadata.ColumnNames.LogisticsID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadChargesForBDFMetadata.ColumnNames.LogisticsID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDF.ScheduledCarrierID
		' </summary>
		Public Overridable Property ScheduledCarrierID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadChargesForBDFMetadata.ColumnNames.ScheduledCarrierID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadChargesForBDFMetadata.ColumnNames.ScheduledCarrierID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDF.WORKORDERNUMBER
		' </summary>
		Public Overridable Property Workordernumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadChargesForBDFMetadata.ColumnNames.Workordernumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadChargesForBDFMetadata.ColumnNames.Workordernumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDF.CUSTNAME
		' </summary>
		Public Overridable Property Custname As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadChargesForBDFMetadata.ColumnNames.Custname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadChargesForBDFMetadata.ColumnNames.Custname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDF.CUSTOMERPO
		' </summary>
		Public Overridable Property Customerpo As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadChargesForBDFMetadata.ColumnNames.Customerpo)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadChargesForBDFMetadata.ColumnNames.Customerpo, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDF.TOTALBILLINGS
		' </summary>
		Public Overridable Property Totalbillings As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewLoadChargesForBDFMetadata.ColumnNames.Totalbillings)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewLoadChargesForBDFMetadata.ColumnNames.Totalbillings, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesForBDF.CarrierName
		' </summary>
		Public Overridable Property CarrierName As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadChargesForBDFMetadata.ColumnNames.CarrierName)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadChargesForBDFMetadata.ColumnNames.CarrierName, value)
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
		
			Public Sub New(ByVal entity As esViewLoadChargesForBDF)
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
		  

			Private entity As esViewLoadChargesForBDF
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewLoadChargesForBDFQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewLoadChargesForBDF can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewLoadChargesForBDFQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewLoadChargesForBDFMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property LoadChargeID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFMetadata.ColumnNames.LoadChargeID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LoadID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFMetadata.ColumnNames.LoadID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property CarrierID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFMetadata.ColumnNames.CarrierID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LogisticsProviderID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFMetadata.ColumnNames.LogisticsProviderID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property CarrierCharges As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFMetadata.ColumnNames.CarrierCharges, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property ChargeType As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFMetadata.ColumnNames.ChargeType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ChargeDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFMetadata.ColumnNames.ChargeDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property LoadChargeStatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFMetadata.ColumnNames.LoadChargeStatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ChargeNote As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFMetadata.ColumnNames.ChargeNote, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FreightInvoiceNumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFMetadata.ColumnNames.FreightInvoiceNumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FreightInvoiceDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFMetadata.ColumnNames.FreightInvoiceDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property FreightVendorID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFMetadata.ColumnNames.FreightVendorID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property APBatchID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFMetadata.ColumnNames.APBatchID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LoadStatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFMetadata.ColumnNames.LoadStatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LoadType As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFMetadata.ColumnNames.LoadType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PlannedDepartureDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFMetadata.ColumnNames.PlannedDepartureDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ScheduledShipmentDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFMetadata.ColumnNames.ScheduledShipmentDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ActualShipmentDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFMetadata.ColumnNames.ActualShipmentDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property CarrierProNumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFMetadata.ColumnNames.CarrierProNumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Fob As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFMetadata.ColumnNames.Fob, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BillCustomer As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFMetadata.ColumnNames.BillCustomer, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property AddToInvoice As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFMetadata.ColumnNames.AddToInvoice, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property LogisticsID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFMetadata.ColumnNames.LogisticsID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ScheduledCarrierID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFMetadata.ColumnNames.ScheduledCarrierID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Workordernumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFMetadata.ColumnNames.Workordernumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Custname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFMetadata.ColumnNames.Custname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Customerpo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFMetadata.ColumnNames.Customerpo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Totalbillings As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFMetadata.ColumnNames.Totalbillings, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property CarrierName As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesForBDFMetadata.ColumnNames.CarrierName, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewLoadChargesForBDFCollection")> _
	Partial Public Class ViewLoadChargesForBDFCollection
		Inherits esViewLoadChargesForBDFCollection
		Implements IEnumerable(Of ViewLoadChargesForBDF)
		
        Public Shared Widening Operator CType(ByVal coll As ViewLoadChargesForBDFCollection) As List(Of ViewLoadChargesForBDF)
            Dim list As List(Of ViewLoadChargesForBDF) = New List(Of ViewLoadChargesForBDF)
            Dim emp As ViewLoadChargesForBDF

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewLoadChargesForBDFMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewLoadChargesForBDFQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewLoadChargesForBDF(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewLoadChargesForBDF()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewLoadChargesForBDFQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewLoadChargesForBDFQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewLoadChargesForBDFQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewLoadChargesForBDF 
			Return CType(MyBase.AddNewEntity(), ViewLoadChargesForBDF)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewLoadChargesForBDF) Implements IEnumerable(Of ViewLoadChargesForBDF).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewLoadChargesForBDF)(Me)
        End Function
		
		Private _query As ViewLoadChargesForBDFQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewLoadChargesForBDF' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewLoadChargesForBDF ()")> _
	<Serializable> _
	Partial Public Class ViewLoadChargesForBDF 
		Inherits esViewLoadChargesForBDF

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewLoadChargesForBDFMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewLoadChargesForBDFQuery

			If Me._query Is Nothing Then
				Me._query = New ViewLoadChargesForBDFQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewLoadChargesForBDFQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewLoadChargesForBDFQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewLoadChargesForBDFQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewLoadChargesForBDFQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewLoadChargesForBDFQuery
		inherits esViewLoadChargesForBDFQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewLoadChargesForBDFQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewLoadChargesForBDFMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewLoadChargesForBDFMetadata.ColumnNames.LoadChargeID, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadChargesForBDFMetadata.PropertyNames.LoadChargeID
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFMetadata.ColumnNames.LoadID, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadChargesForBDFMetadata.PropertyNames.LoadID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFMetadata.ColumnNames.CarrierID, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadChargesForBDFMetadata.PropertyNames.CarrierID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFMetadata.ColumnNames.LogisticsProviderID, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadChargesForBDFMetadata.PropertyNames.LogisticsProviderID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFMetadata.ColumnNames.CarrierCharges, 4, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewLoadChargesForBDFMetadata.PropertyNames.CarrierCharges
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFMetadata.ColumnNames.ChargeType, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadChargesForBDFMetadata.PropertyNames.ChargeType
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFMetadata.ColumnNames.ChargeDate, 6, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewLoadChargesForBDFMetadata.PropertyNames.ChargeDate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFMetadata.ColumnNames.LoadChargeStatus, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadChargesForBDFMetadata.PropertyNames.LoadChargeStatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFMetadata.ColumnNames.ChargeNote, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadChargesForBDFMetadata.PropertyNames.ChargeNote
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFMetadata.ColumnNames.FreightInvoiceNumber, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadChargesForBDFMetadata.PropertyNames.FreightInvoiceNumber
			c.CharacterMaxLength = 30
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFMetadata.ColumnNames.FreightInvoiceDate, 10, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewLoadChargesForBDFMetadata.PropertyNames.FreightInvoiceDate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFMetadata.ColumnNames.FreightVendorID, 11, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadChargesForBDFMetadata.PropertyNames.FreightVendorID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFMetadata.ColumnNames.APBatchID, 12, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadChargesForBDFMetadata.PropertyNames.APBatchID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFMetadata.ColumnNames.LoadStatus, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadChargesForBDFMetadata.PropertyNames.LoadStatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFMetadata.ColumnNames.LoadType, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadChargesForBDFMetadata.PropertyNames.LoadType
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFMetadata.ColumnNames.PlannedDepartureDate, 15, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewLoadChargesForBDFMetadata.PropertyNames.PlannedDepartureDate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFMetadata.ColumnNames.ScheduledShipmentDate, 16, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewLoadChargesForBDFMetadata.PropertyNames.ScheduledShipmentDate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFMetadata.ColumnNames.ActualShipmentDate, 17, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewLoadChargesForBDFMetadata.PropertyNames.ActualShipmentDate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFMetadata.ColumnNames.CarrierProNumber, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadChargesForBDFMetadata.PropertyNames.CarrierProNumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFMetadata.ColumnNames.Fob, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadChargesForBDFMetadata.PropertyNames.Fob
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFMetadata.ColumnNames.BillCustomer, 20, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewLoadChargesForBDFMetadata.PropertyNames.BillCustomer
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFMetadata.ColumnNames.AddToInvoice, 21, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewLoadChargesForBDFMetadata.PropertyNames.AddToInvoice
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFMetadata.ColumnNames.LogisticsID, 22, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadChargesForBDFMetadata.PropertyNames.LogisticsID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFMetadata.ColumnNames.ScheduledCarrierID, 23, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadChargesForBDFMetadata.PropertyNames.ScheduledCarrierID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFMetadata.ColumnNames.Workordernumber, 24, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadChargesForBDFMetadata.PropertyNames.Workordernumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFMetadata.ColumnNames.Custname, 25, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadChargesForBDFMetadata.PropertyNames.Custname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFMetadata.ColumnNames.Customerpo, 26, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadChargesForBDFMetadata.PropertyNames.Customerpo
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFMetadata.ColumnNames.Totalbillings, 27, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewLoadChargesForBDFMetadata.PropertyNames.Totalbillings
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesForBDFMetadata.ColumnNames.CarrierName, 28, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadChargesForBDFMetadata.PropertyNames.CarrierName
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewLoadChargesForBDFMetadata
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
            SyncLock GetType(ViewLoadChargesForBDFMetadata)
			
				If ViewLoadChargesForBDFMetadata.mapDelegates Is Nothing Then
					ViewLoadChargesForBDFMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewLoadChargesForBDFMetadata._meta Is Nothing Then
                    ViewLoadChargesForBDFMetadata._meta = New ViewLoadChargesForBDFMetadata()
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
				
				
				 
				meta.Source = "viewLoadChargesForBDF"
				meta.Destination = "viewLoadChargesForBDF"
				
				meta.spInsert = "proc_viewLoadChargesForBDFInsert"
				meta.spUpdate = "proc_viewLoadChargesForBDFUpdate"
				meta.spDelete = "proc_viewLoadChargesForBDFDelete"
				meta.spLoadAll = "proc_viewLoadChargesForBDFLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewLoadChargesForBDFLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewLoadChargesForBDFMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
