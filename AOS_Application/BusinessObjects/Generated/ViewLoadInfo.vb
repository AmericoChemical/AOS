'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/23/2018 12:07:19 PM
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
	MustInherit Public Class esViewLoadInfoCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewLoadInfoCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewLoadInfoQuery)
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
            Me.InitQuery(CType(query, esViewLoadInfoQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewLoadInfo) As ViewLoadInfo
			Return CType(MyBase.DetachEntity(entity), ViewLoadInfo)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewLoadInfo) As ViewLoadInfo
			Return CType(MyBase.AttachEntity(entity), ViewLoadInfo)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewLoadInfoCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewLoadInfo
            Get
                Return TryCast(MyBase.Item(index), ViewLoadInfo)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewLoadInfo)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewLoadInfo	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewLoadInfoQuery
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
												
						Case "LoadID"
							Me.str.LoadID = CType(value, string)
												
						Case "LoadStatus"
							Me.str.LoadStatus = CType(value, string)
												
						Case "LoadType"
							Me.str.LoadType = CType(value, string)
												
						Case "PlannedDepartureDate"
							Me.str.PlannedDepartureDate = CType(value, string)
												
						Case "ActualShipmentDate"
							Me.str.ActualShipmentDate = CType(value, string)
												
						Case "PlannedDeliveryDate"
							Me.str.PlannedDeliveryDate = CType(value, string)
												
						Case "ActualDeliveryDate"
							Me.str.ActualDeliveryDate = CType(value, string)
												
						Case "OriginType"
							Me.str.OriginType = CType(value, string)
												
						Case "OriginID"
							Me.str.OriginID = CType(value, string)
												
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
												
						Case "PickupHours"
							Me.str.PickupHours = CType(value, string)
												
						Case "DestType"
							Me.str.DestType = CType(value, string)
												
						Case "DestID"
							Me.str.DestID = CType(value, string)
												
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
												
						Case "DeliveryHours"
							Me.str.DeliveryHours = CType(value, string)
												
						Case "QuoteID"
							Me.str.QuoteID = CType(value, string)
												
						Case "CarrierID"
							Me.str.CarrierID = CType(value, string)
												
						Case "LogisticsID"
							Me.str.LogisticsID = CType(value, string)
												
						Case "CarrierProNumber"
							Me.str.CarrierProNumber = CType(value, string)
												
						Case "Fob"
							Me.str.Fob = CType(value, string)
												
						Case "BillCustomer"
							Me.str.BillCustomer = CType(value, string)
												
						Case "AddToInvoice"
							Me.str.AddToInvoice = CType(value, string)
												
						Case "LoadNotes"
							Me.str.LoadNotes = CType(value, string)
												
						Case "CreatedTime"
							Me.str.CreatedTime = CType(value, string)
												
						Case "CreatedBy"
							Me.str.CreatedBy = CType(value, string)
												
						Case "ModifiedTime"
							Me.str.ModifiedTime = CType(value, string)
												
						Case "ModifiedBy"
							Me.str.ModifiedBy = CType(value, string)
												
						Case "TotalCharged"
							Me.str.TotalCharged = CType(value, string)
												
						Case "TotalBilled"
							Me.str.TotalBilled = CType(value, string)
												
						Case "TotalContainers"
							Me.str.TotalContainers = CType(value, string)
												
						Case "TotalGrossWeight"
							Me.str.TotalGrossWeight = CType(value, string)
												
						Case "CarrierName"
							Me.str.CarrierName = CType(value, string)
												
						Case "Logisticsname"
							Me.str.Logisticsname = CType(value, string)
												
						Case "ScheduledCarrierID"
							Me.str.ScheduledCarrierID = CType(value, string)
												
						Case "ScheduledLogisticsID"
							Me.str.ScheduledLogisticsID = CType(value, string)
												
						Case "ScheduledShipmentDate"
							Me.str.ScheduledShipmentDate = CType(value, string)
												
						Case "ScheduledCarrierName"
							Me.str.ScheduledCarrierName = CType(value, string)
												
						Case "ScheduledLogisticsName"
							Me.str.ScheduledLogisticsName = CType(value, string)
												
						Case "CustID"
							Me.str.CustID = CType(value, string)
												
						Case "Transportationnotes"
							Me.str.Transportationnotes = CType(value, string)
												
						Case "Billofladingnotes"
							Me.str.Billofladingnotes = CType(value, string)
												
						Case "TotalSkids"
							Me.str.TotalSkids = CType(value, string)
												
						Case "FreezeProtectFlag"
							Me.str.FreezeProtectFlag = CType(value, string)
												
						Case "Custname"
							Me.str.Custname = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "LoadID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.LoadID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "PlannedDepartureDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.PlannedDepartureDate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "ActualShipmentDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.ActualShipmentDate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "PlannedDeliveryDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.PlannedDeliveryDate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "ActualDeliveryDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.ActualDeliveryDate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "OriginID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.OriginID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "DestID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.DestID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "QuoteID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.QuoteID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "CarrierID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.CarrierID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "LogisticsID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.LogisticsID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "BillCustomer"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.BillCustomer = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "AddToInvoice"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.AddToInvoice = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "CreatedTime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.CreatedTime = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "ModifiedTime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.ModifiedTime = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "TotalCharged"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.TotalCharged = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "TotalBilled"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.TotalBilled = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "TotalContainers"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.TotalContainers = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "TotalGrossWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.TotalGrossWeight = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "ScheduledCarrierID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ScheduledCarrierID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "ScheduledLogisticsID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ScheduledLogisticsID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "ScheduledShipmentDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.ScheduledShipmentDate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "CustID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.CustID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "TotalSkids"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.TotalSkids = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "FreezeProtectFlag"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.FreezeProtectFlag = CType(value, Nullable(Of System.Boolean))
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
		' Maps to viewLoadInfo.LoadID
		' </summary>
		Public Overridable Property LoadID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadInfoMetadata.ColumnNames.LoadID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadInfoMetadata.ColumnNames.LoadID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.LoadStatus
		' </summary>
		Public Overridable Property LoadStatus As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadInfoMetadata.ColumnNames.LoadStatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadInfoMetadata.ColumnNames.LoadStatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.LoadType
		' </summary>
		Public Overridable Property LoadType As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadInfoMetadata.ColumnNames.LoadType)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadInfoMetadata.ColumnNames.LoadType, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.PlannedDepartureDate
		' </summary>
		Public Overridable Property PlannedDepartureDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewLoadInfoMetadata.ColumnNames.PlannedDepartureDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewLoadInfoMetadata.ColumnNames.PlannedDepartureDate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.ActualShipmentDate
		' </summary>
		Public Overridable Property ActualShipmentDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewLoadInfoMetadata.ColumnNames.ActualShipmentDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewLoadInfoMetadata.ColumnNames.ActualShipmentDate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.PlannedDeliveryDate
		' </summary>
		Public Overridable Property PlannedDeliveryDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewLoadInfoMetadata.ColumnNames.PlannedDeliveryDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewLoadInfoMetadata.ColumnNames.PlannedDeliveryDate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.ActualDeliveryDate
		' </summary>
		Public Overridable Property ActualDeliveryDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewLoadInfoMetadata.ColumnNames.ActualDeliveryDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewLoadInfoMetadata.ColumnNames.ActualDeliveryDate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.OriginType
		' </summary>
		Public Overridable Property OriginType As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadInfoMetadata.ColumnNames.OriginType)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadInfoMetadata.ColumnNames.OriginType, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.OriginID
		' </summary>
		Public Overridable Property OriginID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadInfoMetadata.ColumnNames.OriginID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadInfoMetadata.ColumnNames.OriginID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.OriginName
		' </summary>
		Public Overridable Property OriginName As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadInfoMetadata.ColumnNames.OriginName)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadInfoMetadata.ColumnNames.OriginName, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.OriginAddress1
		' </summary>
		Public Overridable Property OriginAddress1 As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadInfoMetadata.ColumnNames.OriginAddress1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadInfoMetadata.ColumnNames.OriginAddress1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.OriginAddress2
		' </summary>
		Public Overridable Property OriginAddress2 As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadInfoMetadata.ColumnNames.OriginAddress2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadInfoMetadata.ColumnNames.OriginAddress2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.OriginCity
		' </summary>
		Public Overridable Property OriginCity As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadInfoMetadata.ColumnNames.OriginCity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadInfoMetadata.ColumnNames.OriginCity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.OriginState
		' </summary>
		Public Overridable Property OriginState As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadInfoMetadata.ColumnNames.OriginState)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadInfoMetadata.ColumnNames.OriginState, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.OriginZip
		' </summary>
		Public Overridable Property OriginZip As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadInfoMetadata.ColumnNames.OriginZip)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadInfoMetadata.ColumnNames.OriginZip, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.OriginCountry
		' </summary>
		Public Overridable Property OriginCountry As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadInfoMetadata.ColumnNames.OriginCountry)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadInfoMetadata.ColumnNames.OriginCountry, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.OriginPhone
		' </summary>
		Public Overridable Property OriginPhone As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadInfoMetadata.ColumnNames.OriginPhone)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadInfoMetadata.ColumnNames.OriginPhone, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.OriginContact
		' </summary>
		Public Overridable Property OriginContact As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadInfoMetadata.ColumnNames.OriginContact)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadInfoMetadata.ColumnNames.OriginContact, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.PickupHours
		' </summary>
		Public Overridable Property PickupHours As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadInfoMetadata.ColumnNames.PickupHours)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadInfoMetadata.ColumnNames.PickupHours, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.DestType
		' </summary>
		Public Overridable Property DestType As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadInfoMetadata.ColumnNames.DestType)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadInfoMetadata.ColumnNames.DestType, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.DestID
		' </summary>
		Public Overridable Property DestID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadInfoMetadata.ColumnNames.DestID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadInfoMetadata.ColumnNames.DestID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.DestName
		' </summary>
		Public Overridable Property DestName As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadInfoMetadata.ColumnNames.DestName)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadInfoMetadata.ColumnNames.DestName, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.DestAddress1
		' </summary>
		Public Overridable Property DestAddress1 As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadInfoMetadata.ColumnNames.DestAddress1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadInfoMetadata.ColumnNames.DestAddress1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.DestAddress2
		' </summary>
		Public Overridable Property DestAddress2 As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadInfoMetadata.ColumnNames.DestAddress2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadInfoMetadata.ColumnNames.DestAddress2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.DestCity
		' </summary>
		Public Overridable Property DestCity As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadInfoMetadata.ColumnNames.DestCity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadInfoMetadata.ColumnNames.DestCity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.DestState
		' </summary>
		Public Overridable Property DestState As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadInfoMetadata.ColumnNames.DestState)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadInfoMetadata.ColumnNames.DestState, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.DestZip
		' </summary>
		Public Overridable Property DestZip As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadInfoMetadata.ColumnNames.DestZip)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadInfoMetadata.ColumnNames.DestZip, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.DestCountry
		' </summary>
		Public Overridable Property DestCountry As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadInfoMetadata.ColumnNames.DestCountry)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadInfoMetadata.ColumnNames.DestCountry, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.DestPhone
		' </summary>
		Public Overridable Property DestPhone As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadInfoMetadata.ColumnNames.DestPhone)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadInfoMetadata.ColumnNames.DestPhone, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.DestContact
		' </summary>
		Public Overridable Property DestContact As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadInfoMetadata.ColumnNames.DestContact)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadInfoMetadata.ColumnNames.DestContact, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.DeliveryHours
		' </summary>
		Public Overridable Property DeliveryHours As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadInfoMetadata.ColumnNames.DeliveryHours)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadInfoMetadata.ColumnNames.DeliveryHours, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.QuoteID
		' </summary>
		Public Overridable Property QuoteID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadInfoMetadata.ColumnNames.QuoteID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadInfoMetadata.ColumnNames.QuoteID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.CarrierID
		' </summary>
		Public Overridable Property CarrierID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadInfoMetadata.ColumnNames.CarrierID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadInfoMetadata.ColumnNames.CarrierID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.LogisticsID
		' </summary>
		Public Overridable Property LogisticsID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadInfoMetadata.ColumnNames.LogisticsID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadInfoMetadata.ColumnNames.LogisticsID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.CarrierProNumber
		' </summary>
		Public Overridable Property CarrierProNumber As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadInfoMetadata.ColumnNames.CarrierProNumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadInfoMetadata.ColumnNames.CarrierProNumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.FOB
		' </summary>
		Public Overridable Property Fob As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadInfoMetadata.ColumnNames.Fob)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadInfoMetadata.ColumnNames.Fob, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.BillCustomer
		' </summary>
		Public Overridable Property BillCustomer As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewLoadInfoMetadata.ColumnNames.BillCustomer)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewLoadInfoMetadata.ColumnNames.BillCustomer, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.AddToInvoice
		' </summary>
		Public Overridable Property AddToInvoice As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewLoadInfoMetadata.ColumnNames.AddToInvoice)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewLoadInfoMetadata.ColumnNames.AddToInvoice, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.LoadNotes
		' </summary>
		Public Overridable Property LoadNotes As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadInfoMetadata.ColumnNames.LoadNotes)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadInfoMetadata.ColumnNames.LoadNotes, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.CreatedTime
		' </summary>
		Public Overridable Property CreatedTime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewLoadInfoMetadata.ColumnNames.CreatedTime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewLoadInfoMetadata.ColumnNames.CreatedTime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.CreatedBy
		' </summary>
		Public Overridable Property CreatedBy As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadInfoMetadata.ColumnNames.CreatedBy)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadInfoMetadata.ColumnNames.CreatedBy, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.ModifiedTime
		' </summary>
		Public Overridable Property ModifiedTime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewLoadInfoMetadata.ColumnNames.ModifiedTime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewLoadInfoMetadata.ColumnNames.ModifiedTime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.ModifiedBy
		' </summary>
		Public Overridable Property ModifiedBy As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadInfoMetadata.ColumnNames.ModifiedBy)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadInfoMetadata.ColumnNames.ModifiedBy, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.TotalCharged
		' </summary>
		Public Overridable Property TotalCharged As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewLoadInfoMetadata.ColumnNames.TotalCharged)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewLoadInfoMetadata.ColumnNames.TotalCharged, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.TotalBilled
		' </summary>
		Public Overridable Property TotalBilled As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewLoadInfoMetadata.ColumnNames.TotalBilled)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewLoadInfoMetadata.ColumnNames.TotalBilled, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.TotalContainers
		' </summary>
		Public Overridable Property TotalContainers As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadInfoMetadata.ColumnNames.TotalContainers)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadInfoMetadata.ColumnNames.TotalContainers, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.TotalGrossWeight
		' </summary>
		Public Overridable Property TotalGrossWeight As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadInfoMetadata.ColumnNames.TotalGrossWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadInfoMetadata.ColumnNames.TotalGrossWeight, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.CarrierName
		' </summary>
		Public Overridable Property CarrierName As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadInfoMetadata.ColumnNames.CarrierName)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadInfoMetadata.ColumnNames.CarrierName, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.LOGISTICSNAME
		' </summary>
		Public Overridable Property Logisticsname As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadInfoMetadata.ColumnNames.Logisticsname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadInfoMetadata.ColumnNames.Logisticsname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.ScheduledCarrierID
		' </summary>
		Public Overridable Property ScheduledCarrierID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadInfoMetadata.ColumnNames.ScheduledCarrierID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadInfoMetadata.ColumnNames.ScheduledCarrierID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.ScheduledLogisticsID
		' </summary>
		Public Overridable Property ScheduledLogisticsID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadInfoMetadata.ColumnNames.ScheduledLogisticsID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadInfoMetadata.ColumnNames.ScheduledLogisticsID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.ScheduledShipmentDate
		' </summary>
		Public Overridable Property ScheduledShipmentDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewLoadInfoMetadata.ColumnNames.ScheduledShipmentDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewLoadInfoMetadata.ColumnNames.ScheduledShipmentDate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.ScheduledCarrierName
		' </summary>
		Public Overridable Property ScheduledCarrierName As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadInfoMetadata.ColumnNames.ScheduledCarrierName)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadInfoMetadata.ColumnNames.ScheduledCarrierName, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.ScheduledLogisticsName
		' </summary>
		Public Overridable Property ScheduledLogisticsName As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadInfoMetadata.ColumnNames.ScheduledLogisticsName)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadInfoMetadata.ColumnNames.ScheduledLogisticsName, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.CustID
		' </summary>
		Public Overridable Property CustID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadInfoMetadata.ColumnNames.CustID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadInfoMetadata.ColumnNames.CustID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.TRANSPORTATIONNOTES
		' </summary>
		Public Overridable Property Transportationnotes As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadInfoMetadata.ColumnNames.Transportationnotes)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadInfoMetadata.ColumnNames.Transportationnotes, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.BILLOFLADINGNOTES
		' </summary>
		Public Overridable Property Billofladingnotes As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadInfoMetadata.ColumnNames.Billofladingnotes)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadInfoMetadata.ColumnNames.Billofladingnotes, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.TotalSkids
		' </summary>
		Public Overridable Property TotalSkids As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadInfoMetadata.ColumnNames.TotalSkids)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadInfoMetadata.ColumnNames.TotalSkids, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.FreezeProtectFlag
		' </summary>
		Public Overridable Property FreezeProtectFlag As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewLoadInfoMetadata.ColumnNames.FreezeProtectFlag)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewLoadInfoMetadata.ColumnNames.FreezeProtectFlag, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadInfo.CUSTNAME
		' </summary>
		Public Overridable Property Custname As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadInfoMetadata.ColumnNames.Custname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadInfoMetadata.ColumnNames.Custname, value)
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
		
			Public Sub New(ByVal entity As esViewLoadInfo)
				Me.entity = entity
			End Sub				
		
	
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
		  	
			Public Property PlannedDeliveryDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.PlannedDeliveryDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PlannedDeliveryDate = Nothing
					Else
						entity.PlannedDeliveryDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property ActualDeliveryDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.ActualDeliveryDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ActualDeliveryDate = Nothing
					Else
						entity.ActualDeliveryDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property OriginType As System.String 
				Get
					Dim data_ As System.String = entity.OriginType
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OriginType = Nothing
					Else
						entity.OriginType = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property OriginID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.OriginID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OriginID = Nothing
					Else
						entity.OriginID = Convert.ToInt32(Value)
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
		  	
			Public Property PickupHours As System.String 
				Get
					Dim data_ As System.String = entity.PickupHours
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PickupHours = Nothing
					Else
						entity.PickupHours = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property DestType As System.String 
				Get
					Dim data_ As System.String = entity.DestType
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DestType = Nothing
					Else
						entity.DestType = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property DestID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.DestID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DestID = Nothing
					Else
						entity.DestID = Convert.ToInt32(Value)
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
		  	
			Public Property DeliveryHours As System.String 
				Get
					Dim data_ As System.String = entity.DeliveryHours
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DeliveryHours = Nothing
					Else
						entity.DeliveryHours = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property QuoteID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.QuoteID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.QuoteID = Nothing
					Else
						entity.QuoteID = Convert.ToInt32(Value)
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
		  	
			Public Property LoadNotes As System.String 
				Get
					Dim data_ As System.String = entity.LoadNotes
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LoadNotes = Nothing
					Else
						entity.LoadNotes = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CreatedTime As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.CreatedTime
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CreatedTime = Nothing
					Else
						entity.CreatedTime = Convert.ToDateTime(Value)
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
		  	
			Public Property ModifiedTime As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.ModifiedTime
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ModifiedTime = Nothing
					Else
						entity.ModifiedTime = Convert.ToDateTime(Value)
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
		  	
			Public Property TotalCharged As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.TotalCharged
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TotalCharged = Nothing
					Else
						entity.TotalCharged = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property TotalBilled As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.TotalBilled
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TotalBilled = Nothing
					Else
						entity.TotalBilled = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property TotalContainers As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.TotalContainers
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TotalContainers = Nothing
					Else
						entity.TotalContainers = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property TotalGrossWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.TotalGrossWeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TotalGrossWeight = Nothing
					Else
						entity.TotalGrossWeight = Convert.ToInt32(Value)
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
		  	
			Public Property ScheduledLogisticsID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.ScheduledLogisticsID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ScheduledLogisticsID = Nothing
					Else
						entity.ScheduledLogisticsID = Convert.ToInt32(Value)
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
		  	
			Public Property ScheduledCarrierName As System.String 
				Get
					Dim data_ As System.String = entity.ScheduledCarrierName
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ScheduledCarrierName = Nothing
					Else
						entity.ScheduledCarrierName = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ScheduledLogisticsName As System.String 
				Get
					Dim data_ As System.String = entity.ScheduledLogisticsName
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ScheduledLogisticsName = Nothing
					Else
						entity.ScheduledLogisticsName = Convert.ToString(Value)
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
		  	
			Public Property TotalSkids As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.TotalSkids
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TotalSkids = Nothing
					Else
						entity.TotalSkids = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property FreezeProtectFlag As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.FreezeProtectFlag
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FreezeProtectFlag = Nothing
					Else
						entity.FreezeProtectFlag = Convert.ToBoolean(Value)
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
		  

			Private entity As esViewLoadInfo
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewLoadInfoQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewLoadInfo can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewLoadInfoQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewLoadInfoMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property LoadID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.LoadID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LoadStatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.LoadStatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LoadType As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.LoadType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PlannedDepartureDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.PlannedDepartureDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ActualShipmentDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.ActualShipmentDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property PlannedDeliveryDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.PlannedDeliveryDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ActualDeliveryDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.ActualDeliveryDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property OriginType As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.OriginType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OriginID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.OriginID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property OriginName As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.OriginName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OriginAddress1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.OriginAddress1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OriginAddress2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.OriginAddress2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OriginCity As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.OriginCity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OriginState As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.OriginState, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OriginZip As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.OriginZip, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OriginCountry As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.OriginCountry, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OriginPhone As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.OriginPhone, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OriginContact As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.OriginContact, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PickupHours As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.PickupHours, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DestType As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.DestType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DestID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.DestID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property DestName As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.DestName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DestAddress1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.DestAddress1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DestAddress2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.DestAddress2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DestCity As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.DestCity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DestState As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.DestState, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DestZip As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.DestZip, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DestCountry As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.DestCountry, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DestPhone As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.DestPhone, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DestContact As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.DestContact, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DeliveryHours As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.DeliveryHours, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property QuoteID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.QuoteID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property CarrierID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.CarrierID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LogisticsID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.LogisticsID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property CarrierProNumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.CarrierProNumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Fob As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.Fob, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BillCustomer As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.BillCustomer, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property AddToInvoice As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.AddToInvoice, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property LoadNotes As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.LoadNotes, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CreatedTime As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.CreatedTime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property CreatedBy As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.CreatedBy, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ModifiedTime As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.ModifiedTime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ModifiedBy As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.ModifiedBy, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TotalCharged As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.TotalCharged, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property TotalBilled As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.TotalBilled, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property TotalContainers As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.TotalContainers, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property TotalGrossWeight As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.TotalGrossWeight, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property CarrierName As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.CarrierName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Logisticsname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.Logisticsname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ScheduledCarrierID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.ScheduledCarrierID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ScheduledLogisticsID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.ScheduledLogisticsID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ScheduledShipmentDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.ScheduledShipmentDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ScheduledCarrierName As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.ScheduledCarrierName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ScheduledLogisticsName As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.ScheduledLogisticsName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CustID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.CustID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Transportationnotes As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.Transportationnotes, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Billofladingnotes As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.Billofladingnotes, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TotalSkids As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.TotalSkids, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FreezeProtectFlag As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.FreezeProtectFlag, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Custname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadInfoMetadata.ColumnNames.Custname, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewLoadInfoCollection")> _
	Partial Public Class ViewLoadInfoCollection
		Inherits esViewLoadInfoCollection
		Implements IEnumerable(Of ViewLoadInfo)
		
        Public Shared Widening Operator CType(ByVal coll As ViewLoadInfoCollection) As List(Of ViewLoadInfo)
            Dim list As List(Of ViewLoadInfo) = New List(Of ViewLoadInfo)
            Dim emp As ViewLoadInfo

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewLoadInfoMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewLoadInfoQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewLoadInfo(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewLoadInfo()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewLoadInfoQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewLoadInfoQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewLoadInfoQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewLoadInfo 
			Return CType(MyBase.AddNewEntity(), ViewLoadInfo)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewLoadInfo) Implements IEnumerable(Of ViewLoadInfo).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewLoadInfo)(Me)
        End Function
		
		Private _query As ViewLoadInfoQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewLoadInfo' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewLoadInfo ()")> _
	<Serializable> _
	Partial Public Class ViewLoadInfo 
		Inherits esViewLoadInfo

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewLoadInfoMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewLoadInfoQuery

			If Me._query Is Nothing Then
				Me._query = New ViewLoadInfoQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewLoadInfoQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewLoadInfoQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewLoadInfoQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewLoadInfoQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewLoadInfoQuery
		inherits esViewLoadInfoQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewLoadInfoQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewLoadInfoMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.LoadID, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.LoadID
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.LoadStatus, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.LoadStatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.LoadType, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.LoadType
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.PlannedDepartureDate, 3, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.PlannedDepartureDate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.ActualShipmentDate, 4, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.ActualShipmentDate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.PlannedDeliveryDate, 5, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.PlannedDeliveryDate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.ActualDeliveryDate, 6, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.ActualDeliveryDate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.OriginType, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.OriginType
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.OriginID, 8, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.OriginID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.OriginName, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.OriginName
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.OriginAddress1, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.OriginAddress1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.OriginAddress2, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.OriginAddress2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.OriginCity, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.OriginCity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.OriginState, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.OriginState
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.OriginZip, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.OriginZip
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.OriginCountry, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.OriginCountry
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.OriginPhone, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.OriginPhone
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.OriginContact, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.OriginContact
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.PickupHours, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.PickupHours
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.DestType, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.DestType
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.DestID, 20, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.DestID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.DestName, 21, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.DestName
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.DestAddress1, 22, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.DestAddress1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.DestAddress2, 23, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.DestAddress2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.DestCity, 24, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.DestCity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.DestState, 25, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.DestState
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.DestZip, 26, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.DestZip
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.DestCountry, 27, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.DestCountry
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.DestPhone, 28, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.DestPhone
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.DestContact, 29, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.DestContact
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.DeliveryHours, 30, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.DeliveryHours
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.QuoteID, 31, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.QuoteID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.CarrierID, 32, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.CarrierID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.LogisticsID, 33, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.LogisticsID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.CarrierProNumber, 34, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.CarrierProNumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.Fob, 35, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.Fob
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.BillCustomer, 36, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.BillCustomer
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.AddToInvoice, 37, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.AddToInvoice
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.LoadNotes, 38, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.LoadNotes
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.CreatedTime, 39, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.CreatedTime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.CreatedBy, 40, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.CreatedBy
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.ModifiedTime, 41, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.ModifiedTime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.ModifiedBy, 42, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.ModifiedBy
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.TotalCharged, 43, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.TotalCharged
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.TotalBilled, 44, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.TotalBilled
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.TotalContainers, 45, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.TotalContainers
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.TotalGrossWeight, 46, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.TotalGrossWeight
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.CarrierName, 47, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.CarrierName
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.Logisticsname, 48, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.Logisticsname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.ScheduledCarrierID, 49, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.ScheduledCarrierID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.ScheduledLogisticsID, 50, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.ScheduledLogisticsID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.ScheduledShipmentDate, 51, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.ScheduledShipmentDate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.ScheduledCarrierName, 52, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.ScheduledCarrierName
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.ScheduledLogisticsName, 53, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.ScheduledLogisticsName
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.CustID, 54, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.CustID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.Transportationnotes, 55, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.Transportationnotes
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.Billofladingnotes, 56, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.Billofladingnotes
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.TotalSkids, 57, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.TotalSkids
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.FreezeProtectFlag, 58, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.FreezeProtectFlag
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadInfoMetadata.ColumnNames.Custname, 59, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadInfoMetadata.PropertyNames.Custname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewLoadInfoMetadata
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
			 Public Const LoadID As String = "LoadID"
			 Public Const LoadStatus As String = "LoadStatus"
			 Public Const LoadType As String = "LoadType"
			 Public Const PlannedDepartureDate As String = "PlannedDepartureDate"
			 Public Const ActualShipmentDate As String = "ActualShipmentDate"
			 Public Const PlannedDeliveryDate As String = "PlannedDeliveryDate"
			 Public Const ActualDeliveryDate As String = "ActualDeliveryDate"
			 Public Const OriginType As String = "OriginType"
			 Public Const OriginID As String = "OriginID"
			 Public Const OriginName As String = "OriginName"
			 Public Const OriginAddress1 As String = "OriginAddress1"
			 Public Const OriginAddress2 As String = "OriginAddress2"
			 Public Const OriginCity As String = "OriginCity"
			 Public Const OriginState As String = "OriginState"
			 Public Const OriginZip As String = "OriginZip"
			 Public Const OriginCountry As String = "OriginCountry"
			 Public Const OriginPhone As String = "OriginPhone"
			 Public Const OriginContact As String = "OriginContact"
			 Public Const PickupHours As String = "PickupHours"
			 Public Const DestType As String = "DestType"
			 Public Const DestID As String = "DestID"
			 Public Const DestName As String = "DestName"
			 Public Const DestAddress1 As String = "DestAddress1"
			 Public Const DestAddress2 As String = "DestAddress2"
			 Public Const DestCity As String = "DestCity"
			 Public Const DestState As String = "DestState"
			 Public Const DestZip As String = "DestZip"
			 Public Const DestCountry As String = "DestCountry"
			 Public Const DestPhone As String = "DestPhone"
			 Public Const DestContact As String = "DestContact"
			 Public Const DeliveryHours As String = "DeliveryHours"
			 Public Const QuoteID As String = "QuoteID"
			 Public Const CarrierID As String = "CarrierID"
			 Public Const LogisticsID As String = "LogisticsID"
			 Public Const CarrierProNumber As String = "CarrierProNumber"
			 Public Const Fob As String = "FOB"
			 Public Const BillCustomer As String = "BillCustomer"
			 Public Const AddToInvoice As String = "AddToInvoice"
			 Public Const LoadNotes As String = "LoadNotes"
			 Public Const CreatedTime As String = "CreatedTime"
			 Public Const CreatedBy As String = "CreatedBy"
			 Public Const ModifiedTime As String = "ModifiedTime"
			 Public Const ModifiedBy As String = "ModifiedBy"
			 Public Const TotalCharged As String = "TotalCharged"
			 Public Const TotalBilled As String = "TotalBilled"
			 Public Const TotalContainers As String = "TotalContainers"
			 Public Const TotalGrossWeight As String = "TotalGrossWeight"
			 Public Const CarrierName As String = "CarrierName"
			 Public Const Logisticsname As String = "LOGISTICSNAME"
			 Public Const ScheduledCarrierID As String = "ScheduledCarrierID"
			 Public Const ScheduledLogisticsID As String = "ScheduledLogisticsID"
			 Public Const ScheduledShipmentDate As String = "ScheduledShipmentDate"
			 Public Const ScheduledCarrierName As String = "ScheduledCarrierName"
			 Public Const ScheduledLogisticsName As String = "ScheduledLogisticsName"
			 Public Const CustID As String = "CustID"
			 Public Const Transportationnotes As String = "TRANSPORTATIONNOTES"
			 Public Const Billofladingnotes As String = "BILLOFLADINGNOTES"
			 Public Const TotalSkids As String = "TotalSkids"
			 Public Const FreezeProtectFlag As String = "FreezeProtectFlag"
			 Public Const Custname As String = "CUSTNAME"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const LoadID As String = "LoadID"
			 Public Const LoadStatus As String = "LoadStatus"
			 Public Const LoadType As String = "LoadType"
			 Public Const PlannedDepartureDate As String = "PlannedDepartureDate"
			 Public Const ActualShipmentDate As String = "ActualShipmentDate"
			 Public Const PlannedDeliveryDate As String = "PlannedDeliveryDate"
			 Public Const ActualDeliveryDate As String = "ActualDeliveryDate"
			 Public Const OriginType As String = "OriginType"
			 Public Const OriginID As String = "OriginID"
			 Public Const OriginName As String = "OriginName"
			 Public Const OriginAddress1 As String = "OriginAddress1"
			 Public Const OriginAddress2 As String = "OriginAddress2"
			 Public Const OriginCity As String = "OriginCity"
			 Public Const OriginState As String = "OriginState"
			 Public Const OriginZip As String = "OriginZip"
			 Public Const OriginCountry As String = "OriginCountry"
			 Public Const OriginPhone As String = "OriginPhone"
			 Public Const OriginContact As String = "OriginContact"
			 Public Const PickupHours As String = "PickupHours"
			 Public Const DestType As String = "DestType"
			 Public Const DestID As String = "DestID"
			 Public Const DestName As String = "DestName"
			 Public Const DestAddress1 As String = "DestAddress1"
			 Public Const DestAddress2 As String = "DestAddress2"
			 Public Const DestCity As String = "DestCity"
			 Public Const DestState As String = "DestState"
			 Public Const DestZip As String = "DestZip"
			 Public Const DestCountry As String = "DestCountry"
			 Public Const DestPhone As String = "DestPhone"
			 Public Const DestContact As String = "DestContact"
			 Public Const DeliveryHours As String = "DeliveryHours"
			 Public Const QuoteID As String = "QuoteID"
			 Public Const CarrierID As String = "CarrierID"
			 Public Const LogisticsID As String = "LogisticsID"
			 Public Const CarrierProNumber As String = "CarrierProNumber"
			 Public Const Fob As String = "Fob"
			 Public Const BillCustomer As String = "BillCustomer"
			 Public Const AddToInvoice As String = "AddToInvoice"
			 Public Const LoadNotes As String = "LoadNotes"
			 Public Const CreatedTime As String = "CreatedTime"
			 Public Const CreatedBy As String = "CreatedBy"
			 Public Const ModifiedTime As String = "ModifiedTime"
			 Public Const ModifiedBy As String = "ModifiedBy"
			 Public Const TotalCharged As String = "TotalCharged"
			 Public Const TotalBilled As String = "TotalBilled"
			 Public Const TotalContainers As String = "TotalContainers"
			 Public Const TotalGrossWeight As String = "TotalGrossWeight"
			 Public Const CarrierName As String = "CarrierName"
			 Public Const Logisticsname As String = "Logisticsname"
			 Public Const ScheduledCarrierID As String = "ScheduledCarrierID"
			 Public Const ScheduledLogisticsID As String = "ScheduledLogisticsID"
			 Public Const ScheduledShipmentDate As String = "ScheduledShipmentDate"
			 Public Const ScheduledCarrierName As String = "ScheduledCarrierName"
			 Public Const ScheduledLogisticsName As String = "ScheduledLogisticsName"
			 Public Const CustID As String = "CustID"
			 Public Const Transportationnotes As String = "Transportationnotes"
			 Public Const Billofladingnotes As String = "Billofladingnotes"
			 Public Const TotalSkids As String = "TotalSkids"
			 Public Const FreezeProtectFlag As String = "FreezeProtectFlag"
			 Public Const Custname As String = "Custname"
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
            SyncLock GetType(ViewLoadInfoMetadata)
			
				If ViewLoadInfoMetadata.mapDelegates Is Nothing Then
					ViewLoadInfoMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewLoadInfoMetadata._meta Is Nothing Then
                    ViewLoadInfoMetadata._meta = New ViewLoadInfoMetadata()
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
				

				meta.AddTypeMap("LoadID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("LoadStatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("LoadType", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("PlannedDepartureDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("ActualShipmentDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("PlannedDeliveryDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("ActualDeliveryDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("OriginType", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("OriginID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("OriginName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("OriginAddress1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("OriginAddress2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("OriginCity", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("OriginState", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("OriginZip", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("OriginCountry", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("OriginPhone", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("OriginContact", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("PickupHours", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("DestType", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("DestID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("DestName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("DestAddress1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("DestAddress2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("DestCity", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("DestState", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("DestZip", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("DestCountry", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("DestPhone", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("DestContact", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("DeliveryHours", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("QuoteID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("CarrierID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("LogisticsID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("CarrierProNumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Fob", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("BillCustomer", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("AddToInvoice", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("LoadNotes", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CreatedTime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("CreatedBy", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ModifiedTime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("ModifiedBy", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("TotalCharged", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("TotalBilled", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("TotalContainers", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("TotalGrossWeight", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("CarrierName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Logisticsname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ScheduledCarrierID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ScheduledLogisticsID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ScheduledShipmentDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("ScheduledCarrierName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ScheduledLogisticsName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CustID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Transportationnotes", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Billofladingnotes", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("TotalSkids", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("FreezeProtectFlag", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Custname", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewLoadInfo"
				meta.Destination = "viewLoadInfo"
				
				meta.spInsert = "proc_viewLoadInfoInsert"
				meta.spUpdate = "proc_viewLoadInfoUpdate"
				meta.spDelete = "proc_viewLoadInfoDelete"
				meta.spLoadAll = "proc_viewLoadInfoLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewLoadInfoLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewLoadInfoMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
