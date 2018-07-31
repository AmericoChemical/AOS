'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/11/2014 1:36:09 PM
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
	MustInherit Public Class esViewPackingListCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewPackingListCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewPackingListQuery)
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
            Me.InitQuery(CType(query, esViewPackingListQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewPackingList) As ViewPackingList
			Return CType(MyBase.DetachEntity(entity), ViewPackingList)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewPackingList) As ViewPackingList
			Return CType(MyBase.AttachEntity(entity), ViewPackingList)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewPackingListCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewPackingList
            Get
                Return TryCast(MyBase.Item(index), ViewPackingList)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewPackingList)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewPackingList	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewPackingListQuery
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
												
						Case "LoadItemID"
							Me.str.LoadItemID = CType(value, string)
												
						Case "Expr1"
							Me.str.Expr1 = CType(value, string)
												
						Case "SourceType"
							Me.str.SourceType = CType(value, string)
												
						Case "SourceID"
							Me.str.SourceID = CType(value, string)
												
						Case "ItemType"
							Me.str.ItemType = CType(value, string)
												
						Case "ItemID"
							Me.str.ItemID = CType(value, string)
												
						Case "ItemDescription"
							Me.str.ItemDescription = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "QtyContainers"
							Me.str.QtyContainers = CType(value, string)
												
						Case "TotalVolume"
							Me.str.TotalVolume = CType(value, string)
												
						Case "VolumeUOM"
							Me.str.VolumeUOM = CType(value, string)
												
						Case "TotalWeight"
							Me.str.TotalWeight = CType(value, string)
												
						Case "WeightUOM"
							Me.str.WeightUOM = CType(value, string)
												
						Case "DOTIDNumber"
							Me.str.DOTIDNumber = CType(value, string)
												
						Case "HazmatID"
							Me.str.HazmatID = CType(value, string)
												
						Case "HazmatClass"
							Me.str.HazmatClass = CType(value, string)
												
						Case "HazmatPackageGroup"
							Me.str.HazmatPackageGroup = CType(value, string)
												
						Case "ClassRate"
							Me.str.ClassRate = CType(value, string)
												
						Case "DOTDesc"
							Me.str.DOTDesc = CType(value, string)
												
						Case "HazMatDesc"
							Me.str.HazMatDesc = CType(value, string)
												
						Case "UNLine"
							Me.str.UNLine = CType(value, string)
												
						Case "IsHazardous"
							Me.str.IsHazardous = CType(value, string)
												
						Case "PalletID"
							Me.str.PalletID = CType(value, string)
												
						Case "LoadItemNote"
							Me.str.LoadItemNote = CType(value, string)
												
						Case "Ld1"
							Me.str.Ld1 = CType(value, string)
												
						Case "Ld2"
							Me.str.Ld2 = CType(value, string)
												
						Case "Ld3"
							Me.str.Ld3 = CType(value, string)
												
						Case "Expr2"
							Me.str.Expr2 = CType(value, string)
												
						Case "Expr3"
							Me.str.Expr3 = CType(value, string)
												
						Case "Expr4"
							Me.str.Expr4 = CType(value, string)
												
						Case "Expr5"
							Me.str.Expr5 = CType(value, string)
					
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
						
						Case "LoadItemID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.LoadItemID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Expr1"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Expr1 = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "SourceID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SourceID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "ItemID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ItemID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "QtyContainers"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.QtyContainers = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "TotalVolume"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.TotalVolume = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "TotalWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.TotalWeight = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "HazmatID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.HazmatID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "IsHazardous"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.IsHazardous = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "PalletID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.PalletID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Expr2"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Expr2 = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Expr4"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Expr4 = CType(value, Nullable(Of System.DateTime))
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
		' Maps to viewPackingList.LoadID
		' </summary>
		Public Overridable Property LoadID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewPackingListMetadata.ColumnNames.LoadID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewPackingListMetadata.ColumnNames.LoadID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.LoadStatus
		' </summary>
		Public Overridable Property LoadStatus As System.String
			Get
				Return MyBase.GetSystemString(ViewPackingListMetadata.ColumnNames.LoadStatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPackingListMetadata.ColumnNames.LoadStatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.LoadType
		' </summary>
		Public Overridable Property LoadType As System.String
			Get
				Return MyBase.GetSystemString(ViewPackingListMetadata.ColumnNames.LoadType)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPackingListMetadata.ColumnNames.LoadType, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.PlannedDepartureDate
		' </summary>
		Public Overridable Property PlannedDepartureDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewPackingListMetadata.ColumnNames.PlannedDepartureDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewPackingListMetadata.ColumnNames.PlannedDepartureDate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.ActualShipmentDate
		' </summary>
		Public Overridable Property ActualShipmentDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewPackingListMetadata.ColumnNames.ActualShipmentDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewPackingListMetadata.ColumnNames.ActualShipmentDate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.PlannedDeliveryDate
		' </summary>
		Public Overridable Property PlannedDeliveryDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewPackingListMetadata.ColumnNames.PlannedDeliveryDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewPackingListMetadata.ColumnNames.PlannedDeliveryDate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.ActualDeliveryDate
		' </summary>
		Public Overridable Property ActualDeliveryDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewPackingListMetadata.ColumnNames.ActualDeliveryDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewPackingListMetadata.ColumnNames.ActualDeliveryDate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.OriginType
		' </summary>
		Public Overridable Property OriginType As System.String
			Get
				Return MyBase.GetSystemString(ViewPackingListMetadata.ColumnNames.OriginType)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPackingListMetadata.ColumnNames.OriginType, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.OriginID
		' </summary>
		Public Overridable Property OriginID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewPackingListMetadata.ColumnNames.OriginID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewPackingListMetadata.ColumnNames.OriginID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.OriginName
		' </summary>
		Public Overridable Property OriginName As System.String
			Get
				Return MyBase.GetSystemString(ViewPackingListMetadata.ColumnNames.OriginName)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPackingListMetadata.ColumnNames.OriginName, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.OriginAddress1
		' </summary>
		Public Overridable Property OriginAddress1 As System.String
			Get
				Return MyBase.GetSystemString(ViewPackingListMetadata.ColumnNames.OriginAddress1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPackingListMetadata.ColumnNames.OriginAddress1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.OriginAddress2
		' </summary>
		Public Overridable Property OriginAddress2 As System.String
			Get
				Return MyBase.GetSystemString(ViewPackingListMetadata.ColumnNames.OriginAddress2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPackingListMetadata.ColumnNames.OriginAddress2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.OriginCity
		' </summary>
		Public Overridable Property OriginCity As System.String
			Get
				Return MyBase.GetSystemString(ViewPackingListMetadata.ColumnNames.OriginCity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPackingListMetadata.ColumnNames.OriginCity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.OriginState
		' </summary>
		Public Overridable Property OriginState As System.String
			Get
				Return MyBase.GetSystemString(ViewPackingListMetadata.ColumnNames.OriginState)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPackingListMetadata.ColumnNames.OriginState, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.OriginZip
		' </summary>
		Public Overridable Property OriginZip As System.String
			Get
				Return MyBase.GetSystemString(ViewPackingListMetadata.ColumnNames.OriginZip)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPackingListMetadata.ColumnNames.OriginZip, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.OriginCountry
		' </summary>
		Public Overridable Property OriginCountry As System.String
			Get
				Return MyBase.GetSystemString(ViewPackingListMetadata.ColumnNames.OriginCountry)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPackingListMetadata.ColumnNames.OriginCountry, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.OriginPhone
		' </summary>
		Public Overridable Property OriginPhone As System.String
			Get
				Return MyBase.GetSystemString(ViewPackingListMetadata.ColumnNames.OriginPhone)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPackingListMetadata.ColumnNames.OriginPhone, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.OriginContact
		' </summary>
		Public Overridable Property OriginContact As System.String
			Get
				Return MyBase.GetSystemString(ViewPackingListMetadata.ColumnNames.OriginContact)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPackingListMetadata.ColumnNames.OriginContact, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.PickupHours
		' </summary>
		Public Overridable Property PickupHours As System.String
			Get
				Return MyBase.GetSystemString(ViewPackingListMetadata.ColumnNames.PickupHours)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPackingListMetadata.ColumnNames.PickupHours, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.DestType
		' </summary>
		Public Overridable Property DestType As System.String
			Get
				Return MyBase.GetSystemString(ViewPackingListMetadata.ColumnNames.DestType)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPackingListMetadata.ColumnNames.DestType, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.DestID
		' </summary>
		Public Overridable Property DestID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewPackingListMetadata.ColumnNames.DestID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewPackingListMetadata.ColumnNames.DestID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.DestName
		' </summary>
		Public Overridable Property DestName As System.String
			Get
				Return MyBase.GetSystemString(ViewPackingListMetadata.ColumnNames.DestName)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPackingListMetadata.ColumnNames.DestName, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.DestAddress1
		' </summary>
		Public Overridable Property DestAddress1 As System.String
			Get
				Return MyBase.GetSystemString(ViewPackingListMetadata.ColumnNames.DestAddress1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPackingListMetadata.ColumnNames.DestAddress1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.DestAddress2
		' </summary>
		Public Overridable Property DestAddress2 As System.String
			Get
				Return MyBase.GetSystemString(ViewPackingListMetadata.ColumnNames.DestAddress2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPackingListMetadata.ColumnNames.DestAddress2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.DestCity
		' </summary>
		Public Overridable Property DestCity As System.String
			Get
				Return MyBase.GetSystemString(ViewPackingListMetadata.ColumnNames.DestCity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPackingListMetadata.ColumnNames.DestCity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.DestState
		' </summary>
		Public Overridable Property DestState As System.String
			Get
				Return MyBase.GetSystemString(ViewPackingListMetadata.ColumnNames.DestState)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPackingListMetadata.ColumnNames.DestState, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.DestZip
		' </summary>
		Public Overridable Property DestZip As System.String
			Get
				Return MyBase.GetSystemString(ViewPackingListMetadata.ColumnNames.DestZip)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPackingListMetadata.ColumnNames.DestZip, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.DestCountry
		' </summary>
		Public Overridable Property DestCountry As System.String
			Get
				Return MyBase.GetSystemString(ViewPackingListMetadata.ColumnNames.DestCountry)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPackingListMetadata.ColumnNames.DestCountry, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.DestPhone
		' </summary>
		Public Overridable Property DestPhone As System.String
			Get
				Return MyBase.GetSystemString(ViewPackingListMetadata.ColumnNames.DestPhone)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPackingListMetadata.ColumnNames.DestPhone, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.DestContact
		' </summary>
		Public Overridable Property DestContact As System.String
			Get
				Return MyBase.GetSystemString(ViewPackingListMetadata.ColumnNames.DestContact)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPackingListMetadata.ColumnNames.DestContact, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.DeliveryHours
		' </summary>
		Public Overridable Property DeliveryHours As System.String
			Get
				Return MyBase.GetSystemString(ViewPackingListMetadata.ColumnNames.DeliveryHours)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPackingListMetadata.ColumnNames.DeliveryHours, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.QuoteID
		' </summary>
		Public Overridable Property QuoteID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewPackingListMetadata.ColumnNames.QuoteID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewPackingListMetadata.ColumnNames.QuoteID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.CarrierID
		' </summary>
		Public Overridable Property CarrierID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewPackingListMetadata.ColumnNames.CarrierID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewPackingListMetadata.ColumnNames.CarrierID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.LogisticsID
		' </summary>
		Public Overridable Property LogisticsID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewPackingListMetadata.ColumnNames.LogisticsID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewPackingListMetadata.ColumnNames.LogisticsID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.CarrierProNumber
		' </summary>
		Public Overridable Property CarrierProNumber As System.String
			Get
				Return MyBase.GetSystemString(ViewPackingListMetadata.ColumnNames.CarrierProNumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPackingListMetadata.ColumnNames.CarrierProNumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.FOB
		' </summary>
		Public Overridable Property Fob As System.String
			Get
				Return MyBase.GetSystemString(ViewPackingListMetadata.ColumnNames.Fob)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPackingListMetadata.ColumnNames.Fob, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.BillCustomer
		' </summary>
		Public Overridable Property BillCustomer As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewPackingListMetadata.ColumnNames.BillCustomer)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewPackingListMetadata.ColumnNames.BillCustomer, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.AddToInvoice
		' </summary>
		Public Overridable Property AddToInvoice As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewPackingListMetadata.ColumnNames.AddToInvoice)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewPackingListMetadata.ColumnNames.AddToInvoice, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.LoadNotes
		' </summary>
		Public Overridable Property LoadNotes As System.String
			Get
				Return MyBase.GetSystemString(ViewPackingListMetadata.ColumnNames.LoadNotes)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPackingListMetadata.ColumnNames.LoadNotes, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.CreatedTime
		' </summary>
		Public Overridable Property CreatedTime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewPackingListMetadata.ColumnNames.CreatedTime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewPackingListMetadata.ColumnNames.CreatedTime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.CreatedBy
		' </summary>
		Public Overridable Property CreatedBy As System.String
			Get
				Return MyBase.GetSystemString(ViewPackingListMetadata.ColumnNames.CreatedBy)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPackingListMetadata.ColumnNames.CreatedBy, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.ModifiedTime
		' </summary>
		Public Overridable Property ModifiedTime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewPackingListMetadata.ColumnNames.ModifiedTime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewPackingListMetadata.ColumnNames.ModifiedTime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.ModifiedBy
		' </summary>
		Public Overridable Property ModifiedBy As System.String
			Get
				Return MyBase.GetSystemString(ViewPackingListMetadata.ColumnNames.ModifiedBy)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPackingListMetadata.ColumnNames.ModifiedBy, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.TotalCharged
		' </summary>
		Public Overridable Property TotalCharged As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewPackingListMetadata.ColumnNames.TotalCharged)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewPackingListMetadata.ColumnNames.TotalCharged, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.TotalBilled
		' </summary>
		Public Overridable Property TotalBilled As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewPackingListMetadata.ColumnNames.TotalBilled)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewPackingListMetadata.ColumnNames.TotalBilled, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.TotalContainers
		' </summary>
		Public Overridable Property TotalContainers As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewPackingListMetadata.ColumnNames.TotalContainers)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewPackingListMetadata.ColumnNames.TotalContainers, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.TotalGrossWeight
		' </summary>
		Public Overridable Property TotalGrossWeight As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewPackingListMetadata.ColumnNames.TotalGrossWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewPackingListMetadata.ColumnNames.TotalGrossWeight, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.CarrierName
		' </summary>
		Public Overridable Property CarrierName As System.String
			Get
				Return MyBase.GetSystemString(ViewPackingListMetadata.ColumnNames.CarrierName)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPackingListMetadata.ColumnNames.CarrierName, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.LOGISTICSNAME
		' </summary>
		Public Overridable Property Logisticsname As System.String
			Get
				Return MyBase.GetSystemString(ViewPackingListMetadata.ColumnNames.Logisticsname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPackingListMetadata.ColumnNames.Logisticsname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.ScheduledCarrierID
		' </summary>
		Public Overridable Property ScheduledCarrierID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewPackingListMetadata.ColumnNames.ScheduledCarrierID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewPackingListMetadata.ColumnNames.ScheduledCarrierID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.ScheduledLogisticsID
		' </summary>
		Public Overridable Property ScheduledLogisticsID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewPackingListMetadata.ColumnNames.ScheduledLogisticsID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewPackingListMetadata.ColumnNames.ScheduledLogisticsID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.ScheduledShipmentDate
		' </summary>
		Public Overridable Property ScheduledShipmentDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewPackingListMetadata.ColumnNames.ScheduledShipmentDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewPackingListMetadata.ColumnNames.ScheduledShipmentDate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.ScheduledCarrierName
		' </summary>
		Public Overridable Property ScheduledCarrierName As System.String
			Get
				Return MyBase.GetSystemString(ViewPackingListMetadata.ColumnNames.ScheduledCarrierName)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPackingListMetadata.ColumnNames.ScheduledCarrierName, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.ScheduledLogisticsName
		' </summary>
		Public Overridable Property ScheduledLogisticsName As System.String
			Get
				Return MyBase.GetSystemString(ViewPackingListMetadata.ColumnNames.ScheduledLogisticsName)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPackingListMetadata.ColumnNames.ScheduledLogisticsName, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.CustID
		' </summary>
		Public Overridable Property CustID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewPackingListMetadata.ColumnNames.CustID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewPackingListMetadata.ColumnNames.CustID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.LoadItemID
		' </summary>
		Public Overridable Property LoadItemID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewPackingListMetadata.ColumnNames.LoadItemID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewPackingListMetadata.ColumnNames.LoadItemID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.Expr1
		' </summary>
		Public Overridable Property Expr1 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewPackingListMetadata.ColumnNames.Expr1)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewPackingListMetadata.ColumnNames.Expr1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.SourceType
		' </summary>
		Public Overridable Property SourceType As System.String
			Get
				Return MyBase.GetSystemString(ViewPackingListMetadata.ColumnNames.SourceType)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPackingListMetadata.ColumnNames.SourceType, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.SourceID
		' </summary>
		Public Overridable Property SourceID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewPackingListMetadata.ColumnNames.SourceID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewPackingListMetadata.ColumnNames.SourceID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.ItemType
		' </summary>
		Public Overridable Property ItemType As System.String
			Get
				Return MyBase.GetSystemString(ViewPackingListMetadata.ColumnNames.ItemType)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPackingListMetadata.ColumnNames.ItemType, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.ItemID
		' </summary>
		Public Overridable Property ItemID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewPackingListMetadata.ColumnNames.ItemID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewPackingListMetadata.ColumnNames.ItemID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.ItemDescription
		' </summary>
		Public Overridable Property ItemDescription As System.String
			Get
				Return MyBase.GetSystemString(ViewPackingListMetadata.ColumnNames.ItemDescription)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPackingListMetadata.ColumnNames.ItemDescription, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.Container
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewPackingListMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPackingListMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.QtyContainers
		' </summary>
		Public Overridable Property QtyContainers As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewPackingListMetadata.ColumnNames.QtyContainers)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewPackingListMetadata.ColumnNames.QtyContainers, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.TotalVolume
		' </summary>
		Public Overridable Property TotalVolume As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewPackingListMetadata.ColumnNames.TotalVolume)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewPackingListMetadata.ColumnNames.TotalVolume, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.VolumeUOM
		' </summary>
		Public Overridable Property VolumeUOM As System.String
			Get
				Return MyBase.GetSystemString(ViewPackingListMetadata.ColumnNames.VolumeUOM)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPackingListMetadata.ColumnNames.VolumeUOM, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.TotalWeight
		' </summary>
		Public Overridable Property TotalWeight As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewPackingListMetadata.ColumnNames.TotalWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewPackingListMetadata.ColumnNames.TotalWeight, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.WeightUOM
		' </summary>
		Public Overridable Property WeightUOM As System.String
			Get
				Return MyBase.GetSystemString(ViewPackingListMetadata.ColumnNames.WeightUOM)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPackingListMetadata.ColumnNames.WeightUOM, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.DOTIDNumber
		' </summary>
		Public Overridable Property DOTIDNumber As System.String
			Get
				Return MyBase.GetSystemString(ViewPackingListMetadata.ColumnNames.DOTIDNumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPackingListMetadata.ColumnNames.DOTIDNumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.HazmatID
		' </summary>
		Public Overridable Property HazmatID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewPackingListMetadata.ColumnNames.HazmatID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewPackingListMetadata.ColumnNames.HazmatID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.HazmatClass
		' </summary>
		Public Overridable Property HazmatClass As System.String
			Get
				Return MyBase.GetSystemString(ViewPackingListMetadata.ColumnNames.HazmatClass)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPackingListMetadata.ColumnNames.HazmatClass, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.HazmatPackageGroup
		' </summary>
		Public Overridable Property HazmatPackageGroup As System.String
			Get
				Return MyBase.GetSystemString(ViewPackingListMetadata.ColumnNames.HazmatPackageGroup)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPackingListMetadata.ColumnNames.HazmatPackageGroup, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.ClassRate
		' </summary>
		Public Overridable Property ClassRate As System.String
			Get
				Return MyBase.GetSystemString(ViewPackingListMetadata.ColumnNames.ClassRate)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPackingListMetadata.ColumnNames.ClassRate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.DOTDesc
		' </summary>
		Public Overridable Property DOTDesc As System.String
			Get
				Return MyBase.GetSystemString(ViewPackingListMetadata.ColumnNames.DOTDesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPackingListMetadata.ColumnNames.DOTDesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.HazMatDesc
		' </summary>
		Public Overridable Property HazMatDesc As System.String
			Get
				Return MyBase.GetSystemString(ViewPackingListMetadata.ColumnNames.HazMatDesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPackingListMetadata.ColumnNames.HazMatDesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.UNLine
		' </summary>
		Public Overridable Property UNLine As System.String
			Get
				Return MyBase.GetSystemString(ViewPackingListMetadata.ColumnNames.UNLine)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPackingListMetadata.ColumnNames.UNLine, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.IsHazardous
		' </summary>
		Public Overridable Property IsHazardous As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewPackingListMetadata.ColumnNames.IsHazardous)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewPackingListMetadata.ColumnNames.IsHazardous, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.PalletID
		' </summary>
		Public Overridable Property PalletID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewPackingListMetadata.ColumnNames.PalletID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewPackingListMetadata.ColumnNames.PalletID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.LoadItemNote
		' </summary>
		Public Overridable Property LoadItemNote As System.String
			Get
				Return MyBase.GetSystemString(ViewPackingListMetadata.ColumnNames.LoadItemNote)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPackingListMetadata.ColumnNames.LoadItemNote, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.LD1
		' </summary>
		Public Overridable Property Ld1 As System.String
			Get
				Return MyBase.GetSystemString(ViewPackingListMetadata.ColumnNames.Ld1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPackingListMetadata.ColumnNames.Ld1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.LD2
		' </summary>
		Public Overridable Property Ld2 As System.String
			Get
				Return MyBase.GetSystemString(ViewPackingListMetadata.ColumnNames.Ld2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPackingListMetadata.ColumnNames.Ld2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.LD3
		' </summary>
		Public Overridable Property Ld3 As System.String
			Get
				Return MyBase.GetSystemString(ViewPackingListMetadata.ColumnNames.Ld3)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPackingListMetadata.ColumnNames.Ld3, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.Expr2
		' </summary>
		Public Overridable Property Expr2 As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewPackingListMetadata.ColumnNames.Expr2)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewPackingListMetadata.ColumnNames.Expr2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.Expr3
		' </summary>
		Public Overridable Property Expr3 As System.String
			Get
				Return MyBase.GetSystemString(ViewPackingListMetadata.ColumnNames.Expr3)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPackingListMetadata.ColumnNames.Expr3, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.Expr4
		' </summary>
		Public Overridable Property Expr4 As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewPackingListMetadata.ColumnNames.Expr4)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewPackingListMetadata.ColumnNames.Expr4, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPackingList.Expr5
		' </summary>
		Public Overridable Property Expr5 As System.String
			Get
				Return MyBase.GetSystemString(ViewPackingListMetadata.ColumnNames.Expr5)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPackingListMetadata.ColumnNames.Expr5, value)
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
		
			Public Sub New(ByVal entity As esViewPackingList)
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
		  	
			Public Property LoadItemID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.LoadItemID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LoadItemID = Nothing
					Else
						entity.LoadItemID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Expr1 As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Expr1
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Expr1 = Nothing
					Else
						entity.Expr1 = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property SourceType As System.String 
				Get
					Dim data_ As System.String = entity.SourceType
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SourceType = Nothing
					Else
						entity.SourceType = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SourceID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.SourceID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SourceID = Nothing
					Else
						entity.SourceID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property ItemType As System.String 
				Get
					Dim data_ As System.String = entity.ItemType
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ItemType = Nothing
					Else
						entity.ItemType = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ItemID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.ItemID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ItemID = Nothing
					Else
						entity.ItemID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property ItemDescription As System.String 
				Get
					Dim data_ As System.String = entity.ItemDescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ItemDescription = Nothing
					Else
						entity.ItemDescription = Convert.ToString(Value)
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
		  	
			Public Property QtyContainers As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.QtyContainers
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.QtyContainers = Nothing
					Else
						entity.QtyContainers = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property TotalVolume As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.TotalVolume
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TotalVolume = Nothing
					Else
						entity.TotalVolume = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property VolumeUOM As System.String 
				Get
					Dim data_ As System.String = entity.VolumeUOM
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.VolumeUOM = Nothing
					Else
						entity.VolumeUOM = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property TotalWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.TotalWeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TotalWeight = Nothing
					Else
						entity.TotalWeight = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property WeightUOM As System.String 
				Get
					Dim data_ As System.String = entity.WeightUOM
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.WeightUOM = Nothing
					Else
						entity.WeightUOM = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property DOTIDNumber As System.String 
				Get
					Dim data_ As System.String = entity.DOTIDNumber
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DOTIDNumber = Nothing
					Else
						entity.DOTIDNumber = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property HazmatID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.HazmatID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HazmatID = Nothing
					Else
						entity.HazmatID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property HazmatClass As System.String 
				Get
					Dim data_ As System.String = entity.HazmatClass
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HazmatClass = Nothing
					Else
						entity.HazmatClass = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property HazmatPackageGroup As System.String 
				Get
					Dim data_ As System.String = entity.HazmatPackageGroup
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HazmatPackageGroup = Nothing
					Else
						entity.HazmatPackageGroup = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ClassRate As System.String 
				Get
					Dim data_ As System.String = entity.ClassRate
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ClassRate = Nothing
					Else
						entity.ClassRate = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property DOTDesc As System.String 
				Get
					Dim data_ As System.String = entity.DOTDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DOTDesc = Nothing
					Else
						entity.DOTDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property HazMatDesc As System.String 
				Get
					Dim data_ As System.String = entity.HazMatDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HazMatDesc = Nothing
					Else
						entity.HazMatDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property UNLine As System.String 
				Get
					Dim data_ As System.String = entity.UNLine
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.UNLine = Nothing
					Else
						entity.UNLine = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property IsHazardous As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.IsHazardous
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.IsHazardous = Nothing
					Else
						entity.IsHazardous = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property PalletID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.PalletID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PalletID = Nothing
					Else
						entity.PalletID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property LoadItemNote As System.String 
				Get
					Dim data_ As System.String = entity.LoadItemNote
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LoadItemNote = Nothing
					Else
						entity.LoadItemNote = Convert.ToString(Value)
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
		  	
			Public Property Expr2 As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Expr2
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Expr2 = Nothing
					Else
						entity.Expr2 = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Expr3 As System.String 
				Get
					Dim data_ As System.String = entity.Expr3
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Expr3 = Nothing
					Else
						entity.Expr3 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Expr4 As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Expr4
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Expr4 = Nothing
					Else
						entity.Expr4 = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Expr5 As System.String 
				Get
					Dim data_ As System.String = entity.Expr5
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Expr5 = Nothing
					Else
						entity.Expr5 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewPackingList
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewPackingListQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewPackingList can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewPackingListQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewPackingListMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property LoadID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.LoadID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LoadStatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.LoadStatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LoadType As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.LoadType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PlannedDepartureDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.PlannedDepartureDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ActualShipmentDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.ActualShipmentDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property PlannedDeliveryDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.PlannedDeliveryDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ActualDeliveryDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.ActualDeliveryDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property OriginType As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.OriginType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OriginID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.OriginID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property OriginName As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.OriginName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OriginAddress1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.OriginAddress1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OriginAddress2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.OriginAddress2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OriginCity As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.OriginCity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OriginState As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.OriginState, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OriginZip As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.OriginZip, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OriginCountry As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.OriginCountry, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OriginPhone As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.OriginPhone, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OriginContact As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.OriginContact, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PickupHours As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.PickupHours, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DestType As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.DestType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DestID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.DestID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property DestName As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.DestName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DestAddress1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.DestAddress1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DestAddress2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.DestAddress2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DestCity As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.DestCity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DestState As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.DestState, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DestZip As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.DestZip, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DestCountry As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.DestCountry, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DestPhone As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.DestPhone, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DestContact As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.DestContact, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DeliveryHours As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.DeliveryHours, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property QuoteID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.QuoteID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property CarrierID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.CarrierID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LogisticsID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.LogisticsID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property CarrierProNumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.CarrierProNumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Fob As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.Fob, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BillCustomer As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.BillCustomer, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property AddToInvoice As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.AddToInvoice, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property LoadNotes As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.LoadNotes, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CreatedTime As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.CreatedTime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property CreatedBy As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.CreatedBy, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ModifiedTime As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.ModifiedTime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ModifiedBy As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.ModifiedBy, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TotalCharged As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.TotalCharged, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property TotalBilled As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.TotalBilled, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property TotalContainers As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.TotalContainers, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property TotalGrossWeight As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.TotalGrossWeight, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property CarrierName As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.CarrierName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Logisticsname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.Logisticsname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ScheduledCarrierID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.ScheduledCarrierID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ScheduledLogisticsID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.ScheduledLogisticsID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ScheduledShipmentDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.ScheduledShipmentDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ScheduledCarrierName As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.ScheduledCarrierName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ScheduledLogisticsName As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.ScheduledLogisticsName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CustID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.CustID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LoadItemID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.LoadItemID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Expr1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.Expr1, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property SourceType As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.SourceType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SourceID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.SourceID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ItemType As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.ItemType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ItemID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.ItemID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ItemDescription As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.ItemDescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property QtyContainers As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.QtyContainers, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property TotalVolume As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.TotalVolume, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property VolumeUOM As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.VolumeUOM, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TotalWeight As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.TotalWeight, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property WeightUOM As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.WeightUOM, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DOTIDNumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.DOTIDNumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property HazmatID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.HazmatID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property HazmatClass As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.HazmatClass, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property HazmatPackageGroup As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.HazmatPackageGroup, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ClassRate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.ClassRate, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DOTDesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.DOTDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property HazMatDesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.HazMatDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property UNLine As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.UNLine, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property IsHazardous As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.IsHazardous, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property PalletID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.PalletID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LoadItemNote As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.LoadItemNote, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Ld1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.Ld1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Ld2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.Ld2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Ld3 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.Ld3, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Expr2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.Expr2, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Expr3 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.Expr3, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Expr4 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.Expr4, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Expr5 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPackingListMetadata.ColumnNames.Expr5, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewPackingListCollection")> _
	Partial Public Class ViewPackingListCollection
		Inherits esViewPackingListCollection
		Implements IEnumerable(Of ViewPackingList)
		
        Public Shared Widening Operator CType(ByVal coll As ViewPackingListCollection) As List(Of ViewPackingList)
            Dim list As List(Of ViewPackingList) = New List(Of ViewPackingList)
            Dim emp As ViewPackingList

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewPackingListMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewPackingListQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewPackingList(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewPackingList()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewPackingListQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewPackingListQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewPackingListQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewPackingList 
			Return CType(MyBase.AddNewEntity(), ViewPackingList)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewPackingList) Implements IEnumerable(Of ViewPackingList).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewPackingList)(Me)
        End Function
		
		Private _query As ViewPackingListQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewPackingList' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewPackingList ()")> _
	<Serializable> _
	Partial Public Class ViewPackingList 
		Inherits esViewPackingList

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewPackingListMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewPackingListQuery

			If Me._query Is Nothing Then
				Me._query = New ViewPackingListQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewPackingListQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewPackingListQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewPackingListQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewPackingListQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewPackingListQuery
		inherits esViewPackingListQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewPackingListQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewPackingListMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.LoadID, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.LoadID
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.LoadStatus, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.LoadStatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.LoadType, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.LoadType
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.PlannedDepartureDate, 3, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.PlannedDepartureDate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.ActualShipmentDate, 4, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.ActualShipmentDate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.PlannedDeliveryDate, 5, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.PlannedDeliveryDate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.ActualDeliveryDate, 6, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.ActualDeliveryDate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.OriginType, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.OriginType
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.OriginID, 8, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.OriginID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.OriginName, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.OriginName
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.OriginAddress1, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.OriginAddress1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.OriginAddress2, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.OriginAddress2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.OriginCity, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.OriginCity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.OriginState, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.OriginState
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.OriginZip, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.OriginZip
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.OriginCountry, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.OriginCountry
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.OriginPhone, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.OriginPhone
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.OriginContact, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.OriginContact
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.PickupHours, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.PickupHours
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.DestType, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.DestType
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.DestID, 20, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.DestID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.DestName, 21, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.DestName
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.DestAddress1, 22, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.DestAddress1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.DestAddress2, 23, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.DestAddress2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.DestCity, 24, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.DestCity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.DestState, 25, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.DestState
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.DestZip, 26, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.DestZip
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.DestCountry, 27, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.DestCountry
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.DestPhone, 28, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.DestPhone
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.DestContact, 29, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.DestContact
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.DeliveryHours, 30, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.DeliveryHours
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.QuoteID, 31, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.QuoteID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.CarrierID, 32, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.CarrierID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.LogisticsID, 33, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.LogisticsID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.CarrierProNumber, 34, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.CarrierProNumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.Fob, 35, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.Fob
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.BillCustomer, 36, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.BillCustomer
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.AddToInvoice, 37, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.AddToInvoice
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.LoadNotes, 38, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.LoadNotes
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.CreatedTime, 39, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.CreatedTime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.CreatedBy, 40, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.CreatedBy
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.ModifiedTime, 41, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.ModifiedTime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.ModifiedBy, 42, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.ModifiedBy
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.TotalCharged, 43, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.TotalCharged
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.TotalBilled, 44, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.TotalBilled
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.TotalContainers, 45, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.TotalContainers
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.TotalGrossWeight, 46, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.TotalGrossWeight
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.CarrierName, 47, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.CarrierName
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.Logisticsname, 48, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.Logisticsname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.ScheduledCarrierID, 49, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.ScheduledCarrierID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.ScheduledLogisticsID, 50, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.ScheduledLogisticsID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.ScheduledShipmentDate, 51, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.ScheduledShipmentDate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.ScheduledCarrierName, 52, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.ScheduledCarrierName
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.ScheduledLogisticsName, 53, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.ScheduledLogisticsName
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.CustID, 54, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.CustID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.LoadItemID, 55, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.LoadItemID
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.Expr1, 56, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.Expr1
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.SourceType, 57, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.SourceType
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.SourceID, 58, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.SourceID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.ItemType, 59, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.ItemType
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.ItemID, 60, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.ItemID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.ItemDescription, 61, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.ItemDescription
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.Container, 62, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.QtyContainers, 63, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.QtyContainers
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.TotalVolume, 64, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.TotalVolume
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.VolumeUOM, 65, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.VolumeUOM
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.TotalWeight, 66, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.TotalWeight
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.WeightUOM, 67, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.WeightUOM
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.DOTIDNumber, 68, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.DOTIDNumber
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.HazmatID, 69, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.HazmatID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.HazmatClass, 70, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.HazmatClass
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.HazmatPackageGroup, 71, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.HazmatPackageGroup
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.ClassRate, 72, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.ClassRate
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.DOTDesc, 73, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.DOTDesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.HazMatDesc, 74, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.HazMatDesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.UNLine, 75, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.UNLine
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.IsHazardous, 76, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.IsHazardous
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.PalletID, 77, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.PalletID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.LoadItemNote, 78, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.LoadItemNote
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.Ld1, 79, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.Ld1
			c.CharacterMaxLength = 500
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.Ld2, 80, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.Ld2
			c.CharacterMaxLength = 500
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.Ld3, 81, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.Ld3
			c.CharacterMaxLength = 500
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.Expr2, 82, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.Expr2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.Expr3, 83, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.Expr3
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.Expr4, 84, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.Expr4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPackingListMetadata.ColumnNames.Expr5, 85, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPackingListMetadata.PropertyNames.Expr5
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewPackingListMetadata
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
			 Public Const LoadItemID As String = "LoadItemID"
			 Public Const Expr1 As String = "Expr1"
			 Public Const SourceType As String = "SourceType"
			 Public Const SourceID As String = "SourceID"
			 Public Const ItemType As String = "ItemType"
			 Public Const ItemID As String = "ItemID"
			 Public Const ItemDescription As String = "ItemDescription"
			 Public Const Container As String = "Container"
			 Public Const QtyContainers As String = "QtyContainers"
			 Public Const TotalVolume As String = "TotalVolume"
			 Public Const VolumeUOM As String = "VolumeUOM"
			 Public Const TotalWeight As String = "TotalWeight"
			 Public Const WeightUOM As String = "WeightUOM"
			 Public Const DOTIDNumber As String = "DOTIDNumber"
			 Public Const HazmatID As String = "HazmatID"
			 Public Const HazmatClass As String = "HazmatClass"
			 Public Const HazmatPackageGroup As String = "HazmatPackageGroup"
			 Public Const ClassRate As String = "ClassRate"
			 Public Const DOTDesc As String = "DOTDesc"
			 Public Const HazMatDesc As String = "HazMatDesc"
			 Public Const UNLine As String = "UNLine"
			 Public Const IsHazardous As String = "IsHazardous"
			 Public Const PalletID As String = "PalletID"
			 Public Const LoadItemNote As String = "LoadItemNote"
			 Public Const Ld1 As String = "LD1"
			 Public Const Ld2 As String = "LD2"
			 Public Const Ld3 As String = "LD3"
			 Public Const Expr2 As String = "Expr2"
			 Public Const Expr3 As String = "Expr3"
			 Public Const Expr4 As String = "Expr4"
			 Public Const Expr5 As String = "Expr5"
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
			 Public Const LoadItemID As String = "LoadItemID"
			 Public Const Expr1 As String = "Expr1"
			 Public Const SourceType As String = "SourceType"
			 Public Const SourceID As String = "SourceID"
			 Public Const ItemType As String = "ItemType"
			 Public Const ItemID As String = "ItemID"
			 Public Const ItemDescription As String = "ItemDescription"
			 Public Const Container As String = "Container"
			 Public Const QtyContainers As String = "QtyContainers"
			 Public Const TotalVolume As String = "TotalVolume"
			 Public Const VolumeUOM As String = "VolumeUOM"
			 Public Const TotalWeight As String = "TotalWeight"
			 Public Const WeightUOM As String = "WeightUOM"
			 Public Const DOTIDNumber As String = "DOTIDNumber"
			 Public Const HazmatID As String = "HazmatID"
			 Public Const HazmatClass As String = "HazmatClass"
			 Public Const HazmatPackageGroup As String = "HazmatPackageGroup"
			 Public Const ClassRate As String = "ClassRate"
			 Public Const DOTDesc As String = "DOTDesc"
			 Public Const HazMatDesc As String = "HazMatDesc"
			 Public Const UNLine As String = "UNLine"
			 Public Const IsHazardous As String = "IsHazardous"
			 Public Const PalletID As String = "PalletID"
			 Public Const LoadItemNote As String = "LoadItemNote"
			 Public Const Ld1 As String = "Ld1"
			 Public Const Ld2 As String = "Ld2"
			 Public Const Ld3 As String = "Ld3"
			 Public Const Expr2 As String = "Expr2"
			 Public Const Expr3 As String = "Expr3"
			 Public Const Expr4 As String = "Expr4"
			 Public Const Expr5 As String = "Expr5"
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
            SyncLock GetType(ViewPackingListMetadata)
			
				If ViewPackingListMetadata.mapDelegates Is Nothing Then
					ViewPackingListMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewPackingListMetadata._meta Is Nothing Then
                    ViewPackingListMetadata._meta = New ViewPackingListMetadata()
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
				meta.AddTypeMap("LoadItemID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Expr1", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("SourceType", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("SourceID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ItemType", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ItemID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ItemDescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("QtyContainers", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("TotalVolume", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("VolumeUOM", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("TotalWeight", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("WeightUOM", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("DOTIDNumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("HazmatID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("HazmatClass", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("HazmatPackageGroup", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ClassRate", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("DOTDesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("HazMatDesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("UNLine", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("IsHazardous", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("PalletID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("LoadItemNote", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Ld1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Ld2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Ld3", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Expr2", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Expr3", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Expr4", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Expr5", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewPackingList"
				meta.Destination = "viewPackingList"
				
				meta.spInsert = "proc_viewPackingListInsert"
				meta.spUpdate = "proc_viewPackingListUpdate"
				meta.spDelete = "proc_viewPackingListDelete"
				meta.spLoadAll = "proc_viewPackingListLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewPackingListLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewPackingListMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
