'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/19/2016 1:26:03 PM
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
	MustInherit Public Class esViewRptBillOfLading5Collection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewRptBillOfLading5Collection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewRptBillOfLading5Query)
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
            Me.InitQuery(CType(query, esViewRptBillOfLading5Query))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewRptBillOfLading5) As ViewRptBillOfLading5
			Return CType(MyBase.DetachEntity(entity), ViewRptBillOfLading5)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewRptBillOfLading5) As ViewRptBillOfLading5
			Return CType(MyBase.AttachEntity(entity), ViewRptBillOfLading5)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewRptBillOfLading5Collection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewRptBillOfLading5
            Get
                Return TryCast(MyBase.Item(index), ViewRptBillOfLading5)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewRptBillOfLading5)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewRptBillOfLading5	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewRptBillOfLading5Query
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
												
						Case "CustID"
							Me.str.CustID = CType(value, string)
												
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
												
						Case "OriginCSZ"
							Me.str.OriginCSZ = CType(value, string)
												
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
												
						Case "DestCSZ"
							Me.str.DestCSZ = CType(value, string)
												
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
												
						Case "TotalWeight"
							Me.str.TotalWeight = CType(value, string)
												
						Case "WeightUOM"
							Me.str.WeightUOM = CType(value, string)
												
						Case "ClassRate"
							Me.str.ClassRate = CType(value, string)
												
						Case "IsHazardous"
							Me.str.IsHazardous = CType(value, string)
												
						Case "PalletID"
							Me.str.PalletID = CType(value, string)
												
						Case "TareWeight"
							Me.str.TareWeight = CType(value, string)
												
						Case "SchedCarrierName"
							Me.str.SchedCarrierName = CType(value, string)
												
						Case "SchedCarrierAddress1"
							Me.str.SchedCarrierAddress1 = CType(value, string)
												
						Case "SchedCarrierAddress2"
							Me.str.SchedCarrierAddress2 = CType(value, string)
												
						Case "SchedCarrierCity"
							Me.str.SchedCarrierCity = CType(value, string)
												
						Case "SchedCarrierState"
							Me.str.SchedCarrierState = CType(value, string)
												
						Case "SchedCarrierZipCode"
							Me.str.SchedCarrierZipCode = CType(value, string)
												
						Case "SchedCarrierPhone"
							Me.str.SchedCarrierPhone = CType(value, string)
												
						Case "SchedCarrierContactName"
							Me.str.SchedCarrierContactName = CType(value, string)
												
						Case "SchedCarrierFAX"
							Me.str.SchedCarrierFAX = CType(value, string)
												
						Case "SchedCarrierContactEmail"
							Me.str.SchedCarrierContactEmail = CType(value, string)
												
						Case "ReqCarrierName"
							Me.str.ReqCarrierName = CType(value, string)
												
						Case "ReqCarrierAddress1"
							Me.str.ReqCarrierAddress1 = CType(value, string)
												
						Case "ReqCarrierAddress2"
							Me.str.ReqCarrierAddress2 = CType(value, string)
												
						Case "ReqCarrierCity"
							Me.str.ReqCarrierCity = CType(value, string)
												
						Case "ReqCarrierState"
							Me.str.ReqCarrierState = CType(value, string)
												
						Case "ReqCarrierZipcode"
							Me.str.ReqCarrierZipcode = CType(value, string)
												
						Case "ReqCarrierPhone"
							Me.str.ReqCarrierPhone = CType(value, string)
												
						Case "ReqCarrierFAX"
							Me.str.ReqCarrierFAX = CType(value, string)
												
						Case "ReqCarrierContactName"
							Me.str.ReqCarrierContactName = CType(value, string)
												
						Case "ReqCarrierContactEmail"
							Me.str.ReqCarrierContactEmail = CType(value, string)
												
						Case "SchedLogisticsName"
							Me.str.SchedLogisticsName = CType(value, string)
												
						Case "SchedLogisticsAddress1"
							Me.str.SchedLogisticsAddress1 = CType(value, string)
												
						Case "SchedLogisticsAddress2"
							Me.str.SchedLogisticsAddress2 = CType(value, string)
												
						Case "SchedLogisticsCity"
							Me.str.SchedLogisticsCity = CType(value, string)
												
						Case "SchedLogisticsState"
							Me.str.SchedLogisticsState = CType(value, string)
												
						Case "SchedLogisticsZipcode"
							Me.str.SchedLogisticsZipcode = CType(value, string)
												
						Case "SchedLogisticsCSZ"
							Me.str.SchedLogisticsCSZ = CType(value, string)
												
						Case "SchedLogisticsPhone"
							Me.str.SchedLogisticsPhone = CType(value, string)
												
						Case "SchedLogisticsFAX"
							Me.str.SchedLogisticsFAX = CType(value, string)
												
						Case "SchedLogisticsContact"
							Me.str.SchedLogisticsContact = CType(value, string)
												
						Case "SchedLogisticsEmail"
							Me.str.SchedLogisticsEmail = CType(value, string)
												
						Case "ReqLogisticsName"
							Me.str.ReqLogisticsName = CType(value, string)
												
						Case "ReqLogisticsAddress1"
							Me.str.ReqLogisticsAddress1 = CType(value, string)
												
						Case "ReqLogisticsAddress2"
							Me.str.ReqLogisticsAddress2 = CType(value, string)
												
						Case "ReqLogisticsCity"
							Me.str.ReqLogisticsCity = CType(value, string)
												
						Case "ReqLogisticsState"
							Me.str.ReqLogisticsState = CType(value, string)
												
						Case "ReqLogisticsZipcode"
							Me.str.ReqLogisticsZipcode = CType(value, string)
												
						Case "ReqLogisticsPhone"
							Me.str.ReqLogisticsPhone = CType(value, string)
												
						Case "ReqLogisticsFAX"
							Me.str.ReqLogisticsFAX = CType(value, string)
												
						Case "ReqLogisticsContact"
							Me.str.ReqLogisticsContact = CType(value, string)
												
						Case "ReqLogisticsEmail"
							Me.str.ReqLogisticsEmail = CType(value, string)
												
						Case "Isliquid"
							Me.str.Isliquid = CType(value, string)
												
						Case "Chemicalid"
							Me.str.Chemicalid = CType(value, string)
												
						Case "Istoxic"
							Me.str.Istoxic = CType(value, string)
												
						Case "Stdweight"
							Me.str.Stdweight = CType(value, string)
												
						Case "Stdgallons"
							Me.str.Stdgallons = CType(value, string)
												
						Case "ProdWgtUOM"
							Me.str.ProdWgtUOM = CType(value, string)
												
						Case "ProdWgtUnits"
							Me.str.ProdWgtUnits = CType(value, string)
												
						Case "ProdVolUOM"
							Me.str.ProdVolUOM = CType(value, string)
												
						Case "ProdVolUnits"
							Me.str.ProdVolUnits = CType(value, string)
												
						Case "Customerproductcode"
							Me.str.Customerproductcode = CType(value, string)
												
						Case "CarrierQuoteNumber"
							Me.str.CarrierQuoteNumber = CType(value, string)
												
						Case "Dotdesc"
							Me.str.Dotdesc = CType(value, string)
												
						Case "Hazmatdesc"
							Me.str.Hazmatdesc = CType(value, string)
												
						Case "Hazclassnumber"
							Me.str.Hazclassnumber = CType(value, string)
												
						Case "Packagegroup"
							Me.str.Packagegroup = CType(value, string)
												
						Case "Idnumber"
							Me.str.Idnumber = CType(value, string)
												
						Case "Rq"
							Me.str.Rq = CType(value, string)
												
						Case "Hazmatid"
							Me.str.Hazmatid = CType(value, string)
					
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
						
						Case "CustID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.CustID = CType(value, Nullable(Of System.Int32))
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
						
						Case "ItemID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ItemID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "QtyContainers"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.QtyContainers = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "TotalWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.TotalWeight = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "IsHazardous"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.IsHazardous = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "PalletID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.PalletID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "TareWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.TareWeight = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Isliquid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Isliquid = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Chemicalid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Chemicalid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Istoxic"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Istoxic = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Stdweight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Stdweight = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Stdgallons"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Stdgallons = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "ProdWgtUnits"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.ProdWgtUnits = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "ProdVolUnits"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.ProdVolUnits = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Rq"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Rq = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Hazmatid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Hazmatid = CType(value, Nullable(Of System.Int32))
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
		' Maps to viewRptBillOfLading5.LoadID
		' </summary>
		Public Overridable Property LoadID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLading5Metadata.ColumnNames.LoadID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLading5Metadata.ColumnNames.LoadID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.LoadStatus
		' </summary>
		Public Overridable Property LoadStatus As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.LoadStatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.LoadStatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.LoadType
		' </summary>
		Public Overridable Property LoadType As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.LoadType)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.LoadType, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.PlannedDepartureDate
		' </summary>
		Public Overridable Property PlannedDepartureDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewRptBillOfLading5Metadata.ColumnNames.PlannedDepartureDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewRptBillOfLading5Metadata.ColumnNames.PlannedDepartureDate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.ActualShipmentDate
		' </summary>
		Public Overridable Property ActualShipmentDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewRptBillOfLading5Metadata.ColumnNames.ActualShipmentDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewRptBillOfLading5Metadata.ColumnNames.ActualShipmentDate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.CustID
		' </summary>
		Public Overridable Property CustID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLading5Metadata.ColumnNames.CustID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLading5Metadata.ColumnNames.CustID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.PlannedDeliveryDate
		' </summary>
		Public Overridable Property PlannedDeliveryDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewRptBillOfLading5Metadata.ColumnNames.PlannedDeliveryDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewRptBillOfLading5Metadata.ColumnNames.PlannedDeliveryDate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.ActualDeliveryDate
		' </summary>
		Public Overridable Property ActualDeliveryDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewRptBillOfLading5Metadata.ColumnNames.ActualDeliveryDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewRptBillOfLading5Metadata.ColumnNames.ActualDeliveryDate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.OriginType
		' </summary>
		Public Overridable Property OriginType As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.OriginType)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.OriginType, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.OriginID
		' </summary>
		Public Overridable Property OriginID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLading5Metadata.ColumnNames.OriginID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLading5Metadata.ColumnNames.OriginID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.OriginName
		' </summary>
		Public Overridable Property OriginName As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.OriginName)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.OriginName, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.OriginAddress1
		' </summary>
		Public Overridable Property OriginAddress1 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.OriginAddress1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.OriginAddress1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.OriginAddress2
		' </summary>
		Public Overridable Property OriginAddress2 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.OriginAddress2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.OriginAddress2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.OriginCity
		' </summary>
		Public Overridable Property OriginCity As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.OriginCity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.OriginCity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.OriginState
		' </summary>
		Public Overridable Property OriginState As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.OriginState)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.OriginState, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.OriginZip
		' </summary>
		Public Overridable Property OriginZip As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.OriginZip)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.OriginZip, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.OriginCSZ
		' </summary>
		Public Overridable Property OriginCSZ As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.OriginCSZ)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.OriginCSZ, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.OriginCountry
		' </summary>
		Public Overridable Property OriginCountry As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.OriginCountry)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.OriginCountry, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.OriginPhone
		' </summary>
		Public Overridable Property OriginPhone As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.OriginPhone)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.OriginPhone, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.OriginContact
		' </summary>
		Public Overridable Property OriginContact As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.OriginContact)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.OriginContact, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.PickupHours
		' </summary>
		Public Overridable Property PickupHours As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.PickupHours)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.PickupHours, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.DestType
		' </summary>
		Public Overridable Property DestType As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.DestType)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.DestType, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.DestID
		' </summary>
		Public Overridable Property DestID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLading5Metadata.ColumnNames.DestID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLading5Metadata.ColumnNames.DestID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.DestName
		' </summary>
		Public Overridable Property DestName As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.DestName)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.DestName, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.DestAddress1
		' </summary>
		Public Overridable Property DestAddress1 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.DestAddress1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.DestAddress1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.DestAddress2
		' </summary>
		Public Overridable Property DestAddress2 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.DestAddress2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.DestAddress2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.DestCity
		' </summary>
		Public Overridable Property DestCity As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.DestCity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.DestCity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.DestState
		' </summary>
		Public Overridable Property DestState As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.DestState)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.DestState, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.DestZip
		' </summary>
		Public Overridable Property DestZip As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.DestZip)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.DestZip, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.DestCSZ
		' </summary>
		Public Overridable Property DestCSZ As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.DestCSZ)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.DestCSZ, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.DestCountry
		' </summary>
		Public Overridable Property DestCountry As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.DestCountry)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.DestCountry, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.DestPhone
		' </summary>
		Public Overridable Property DestPhone As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.DestPhone)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.DestPhone, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.DestContact
		' </summary>
		Public Overridable Property DestContact As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.DestContact)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.DestContact, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.DeliveryHours
		' </summary>
		Public Overridable Property DeliveryHours As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.DeliveryHours)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.DeliveryHours, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.QuoteID
		' </summary>
		Public Overridable Property QuoteID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLading5Metadata.ColumnNames.QuoteID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLading5Metadata.ColumnNames.QuoteID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.CarrierID
		' </summary>
		Public Overridable Property CarrierID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLading5Metadata.ColumnNames.CarrierID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLading5Metadata.ColumnNames.CarrierID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.LogisticsID
		' </summary>
		Public Overridable Property LogisticsID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLading5Metadata.ColumnNames.LogisticsID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLading5Metadata.ColumnNames.LogisticsID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.CarrierProNumber
		' </summary>
		Public Overridable Property CarrierProNumber As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.CarrierProNumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.CarrierProNumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.FOB
		' </summary>
		Public Overridable Property Fob As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.Fob)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.Fob, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.BillCustomer
		' </summary>
		Public Overridable Property BillCustomer As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewRptBillOfLading5Metadata.ColumnNames.BillCustomer)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewRptBillOfLading5Metadata.ColumnNames.BillCustomer, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.AddToInvoice
		' </summary>
		Public Overridable Property AddToInvoice As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewRptBillOfLading5Metadata.ColumnNames.AddToInvoice)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewRptBillOfLading5Metadata.ColumnNames.AddToInvoice, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.LoadNotes
		' </summary>
		Public Overridable Property LoadNotes As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.LoadNotes)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.LoadNotes, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.CreatedTime
		' </summary>
		Public Overridable Property CreatedTime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewRptBillOfLading5Metadata.ColumnNames.CreatedTime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewRptBillOfLading5Metadata.ColumnNames.CreatedTime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.CreatedBy
		' </summary>
		Public Overridable Property CreatedBy As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.CreatedBy)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.CreatedBy, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.ModifiedTime
		' </summary>
		Public Overridable Property ModifiedTime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewRptBillOfLading5Metadata.ColumnNames.ModifiedTime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewRptBillOfLading5Metadata.ColumnNames.ModifiedTime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.ModifiedBy
		' </summary>
		Public Overridable Property ModifiedBy As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.ModifiedBy)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.ModifiedBy, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.TotalCharged
		' </summary>
		Public Overridable Property TotalCharged As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptBillOfLading5Metadata.ColumnNames.TotalCharged)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptBillOfLading5Metadata.ColumnNames.TotalCharged, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.TotalBilled
		' </summary>
		Public Overridable Property TotalBilled As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptBillOfLading5Metadata.ColumnNames.TotalBilled)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptBillOfLading5Metadata.ColumnNames.TotalBilled, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.TotalContainers
		' </summary>
		Public Overridable Property TotalContainers As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLading5Metadata.ColumnNames.TotalContainers)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLading5Metadata.ColumnNames.TotalContainers, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.TotalGrossWeight
		' </summary>
		Public Overridable Property TotalGrossWeight As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLading5Metadata.ColumnNames.TotalGrossWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLading5Metadata.ColumnNames.TotalGrossWeight, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.CarrierName
		' </summary>
		Public Overridable Property CarrierName As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.CarrierName)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.CarrierName, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.LOGISTICSNAME
		' </summary>
		Public Overridable Property Logisticsname As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.Logisticsname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.Logisticsname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.ScheduledCarrierID
		' </summary>
		Public Overridable Property ScheduledCarrierID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLading5Metadata.ColumnNames.ScheduledCarrierID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLading5Metadata.ColumnNames.ScheduledCarrierID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.ScheduledLogisticsID
		' </summary>
		Public Overridable Property ScheduledLogisticsID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLading5Metadata.ColumnNames.ScheduledLogisticsID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLading5Metadata.ColumnNames.ScheduledLogisticsID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.ScheduledShipmentDate
		' </summary>
		Public Overridable Property ScheduledShipmentDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewRptBillOfLading5Metadata.ColumnNames.ScheduledShipmentDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewRptBillOfLading5Metadata.ColumnNames.ScheduledShipmentDate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.ScheduledCarrierName
		' </summary>
		Public Overridable Property ScheduledCarrierName As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.ScheduledCarrierName)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.ScheduledCarrierName, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.ScheduledLogisticsName
		' </summary>
		Public Overridable Property ScheduledLogisticsName As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.ScheduledLogisticsName)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.ScheduledLogisticsName, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.ItemType
		' </summary>
		Public Overridable Property ItemType As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.ItemType)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.ItemType, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.ItemID
		' </summary>
		Public Overridable Property ItemID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLading5Metadata.ColumnNames.ItemID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLading5Metadata.ColumnNames.ItemID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.ItemDescription
		' </summary>
		Public Overridable Property ItemDescription As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.ItemDescription)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.ItemDescription, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.Container
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.QtyContainers
		' </summary>
		Public Overridable Property QtyContainers As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLading5Metadata.ColumnNames.QtyContainers)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLading5Metadata.ColumnNames.QtyContainers, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.TotalWeight
		' </summary>
		Public Overridable Property TotalWeight As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLading5Metadata.ColumnNames.TotalWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLading5Metadata.ColumnNames.TotalWeight, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.WeightUOM
		' </summary>
		Public Overridable Property WeightUOM As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.WeightUOM)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.WeightUOM, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.ClassRate
		' </summary>
		Public Overridable Property ClassRate As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.ClassRate)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.ClassRate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.IsHazardous
		' </summary>
		Public Overridable Property IsHazardous As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewRptBillOfLading5Metadata.ColumnNames.IsHazardous)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewRptBillOfLading5Metadata.ColumnNames.IsHazardous, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.PalletID
		' </summary>
		Public Overridable Property PalletID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLading5Metadata.ColumnNames.PalletID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLading5Metadata.ColumnNames.PalletID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.TareWeight
		' </summary>
		Public Overridable Property TareWeight As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLading5Metadata.ColumnNames.TareWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLading5Metadata.ColumnNames.TareWeight, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.SchedCarrierName
		' </summary>
		Public Overridable Property SchedCarrierName As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.SchedCarrierName)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.SchedCarrierName, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.SchedCarrierAddress1
		' </summary>
		Public Overridable Property SchedCarrierAddress1 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.SchedCarrierAddress1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.SchedCarrierAddress1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.SchedCarrierAddress2
		' </summary>
		Public Overridable Property SchedCarrierAddress2 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.SchedCarrierAddress2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.SchedCarrierAddress2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.SchedCarrierCity
		' </summary>
		Public Overridable Property SchedCarrierCity As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.SchedCarrierCity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.SchedCarrierCity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.SchedCarrierState
		' </summary>
		Public Overridable Property SchedCarrierState As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.SchedCarrierState)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.SchedCarrierState, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.SchedCarrierZipCode
		' </summary>
		Public Overridable Property SchedCarrierZipCode As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.SchedCarrierZipCode)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.SchedCarrierZipCode, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.SchedCarrierPhone
		' </summary>
		Public Overridable Property SchedCarrierPhone As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.SchedCarrierPhone)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.SchedCarrierPhone, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.SchedCarrierContactName
		' </summary>
		Public Overridable Property SchedCarrierContactName As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.SchedCarrierContactName)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.SchedCarrierContactName, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.SchedCarrierFAX
		' </summary>
		Public Overridable Property SchedCarrierFAX As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.SchedCarrierFAX)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.SchedCarrierFAX, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.SchedCarrierContactEmail
		' </summary>
		Public Overridable Property SchedCarrierContactEmail As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.SchedCarrierContactEmail)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.SchedCarrierContactEmail, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.ReqCarrierName
		' </summary>
		Public Overridable Property ReqCarrierName As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.ReqCarrierName)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.ReqCarrierName, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.ReqCarrierAddress1
		' </summary>
		Public Overridable Property ReqCarrierAddress1 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.ReqCarrierAddress1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.ReqCarrierAddress1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.ReqCarrierAddress2
		' </summary>
		Public Overridable Property ReqCarrierAddress2 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.ReqCarrierAddress2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.ReqCarrierAddress2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.ReqCarrierCity
		' </summary>
		Public Overridable Property ReqCarrierCity As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.ReqCarrierCity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.ReqCarrierCity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.ReqCarrierState
		' </summary>
		Public Overridable Property ReqCarrierState As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.ReqCarrierState)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.ReqCarrierState, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.ReqCarrierZipcode
		' </summary>
		Public Overridable Property ReqCarrierZipcode As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.ReqCarrierZipcode)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.ReqCarrierZipcode, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.ReqCarrierPhone
		' </summary>
		Public Overridable Property ReqCarrierPhone As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.ReqCarrierPhone)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.ReqCarrierPhone, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.ReqCarrierFAX
		' </summary>
		Public Overridable Property ReqCarrierFAX As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.ReqCarrierFAX)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.ReqCarrierFAX, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.ReqCarrierContactName
		' </summary>
		Public Overridable Property ReqCarrierContactName As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.ReqCarrierContactName)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.ReqCarrierContactName, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.ReqCarrierContactEmail
		' </summary>
		Public Overridable Property ReqCarrierContactEmail As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.ReqCarrierContactEmail)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.ReqCarrierContactEmail, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.SchedLogisticsName
		' </summary>
		Public Overridable Property SchedLogisticsName As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.SchedLogisticsName)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.SchedLogisticsName, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.SchedLogisticsAddress1
		' </summary>
		Public Overridable Property SchedLogisticsAddress1 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.SchedLogisticsAddress1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.SchedLogisticsAddress1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.SchedLogisticsAddress2
		' </summary>
		Public Overridable Property SchedLogisticsAddress2 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.SchedLogisticsAddress2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.SchedLogisticsAddress2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.SchedLogisticsCity
		' </summary>
		Public Overridable Property SchedLogisticsCity As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.SchedLogisticsCity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.SchedLogisticsCity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.SchedLogisticsState
		' </summary>
		Public Overridable Property SchedLogisticsState As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.SchedLogisticsState)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.SchedLogisticsState, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.SchedLogisticsZipcode
		' </summary>
		Public Overridable Property SchedLogisticsZipcode As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.SchedLogisticsZipcode)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.SchedLogisticsZipcode, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.SchedLogisticsCSZ
		' </summary>
		Public Overridable Property SchedLogisticsCSZ As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.SchedLogisticsCSZ)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.SchedLogisticsCSZ, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.SchedLogisticsPhone
		' </summary>
		Public Overridable Property SchedLogisticsPhone As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.SchedLogisticsPhone)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.SchedLogisticsPhone, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.SchedLogisticsFAX
		' </summary>
		Public Overridable Property SchedLogisticsFAX As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.SchedLogisticsFAX)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.SchedLogisticsFAX, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.SchedLogisticsContact
		' </summary>
		Public Overridable Property SchedLogisticsContact As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.SchedLogisticsContact)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.SchedLogisticsContact, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.SchedLogisticsEmail
		' </summary>
		Public Overridable Property SchedLogisticsEmail As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.SchedLogisticsEmail)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.SchedLogisticsEmail, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.ReqLogisticsName
		' </summary>
		Public Overridable Property ReqLogisticsName As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.ReqLogisticsName)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.ReqLogisticsName, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.ReqLogisticsAddress1
		' </summary>
		Public Overridable Property ReqLogisticsAddress1 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.ReqLogisticsAddress1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.ReqLogisticsAddress1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.ReqLogisticsAddress2
		' </summary>
		Public Overridable Property ReqLogisticsAddress2 As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.ReqLogisticsAddress2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.ReqLogisticsAddress2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.ReqLogisticsCity
		' </summary>
		Public Overridable Property ReqLogisticsCity As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.ReqLogisticsCity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.ReqLogisticsCity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.ReqLogisticsState
		' </summary>
		Public Overridable Property ReqLogisticsState As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.ReqLogisticsState)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.ReqLogisticsState, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.ReqLogisticsZipcode
		' </summary>
		Public Overridable Property ReqLogisticsZipcode As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.ReqLogisticsZipcode)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.ReqLogisticsZipcode, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.ReqLogisticsPhone
		' </summary>
		Public Overridable Property ReqLogisticsPhone As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.ReqLogisticsPhone)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.ReqLogisticsPhone, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.ReqLogisticsFAX
		' </summary>
		Public Overridable Property ReqLogisticsFAX As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.ReqLogisticsFAX)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.ReqLogisticsFAX, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.ReqLogisticsContact
		' </summary>
		Public Overridable Property ReqLogisticsContact As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.ReqLogisticsContact)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.ReqLogisticsContact, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.ReqLogisticsEmail
		' </summary>
		Public Overridable Property ReqLogisticsEmail As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.ReqLogisticsEmail)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.ReqLogisticsEmail, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.ISLIQUID
		' </summary>
		Public Overridable Property Isliquid As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewRptBillOfLading5Metadata.ColumnNames.Isliquid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewRptBillOfLading5Metadata.ColumnNames.Isliquid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.CHEMICALID
		' </summary>
		Public Overridable Property Chemicalid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLading5Metadata.ColumnNames.Chemicalid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLading5Metadata.ColumnNames.Chemicalid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.ISTOXIC
		' </summary>
		Public Overridable Property Istoxic As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewRptBillOfLading5Metadata.ColumnNames.Istoxic)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewRptBillOfLading5Metadata.ColumnNames.Istoxic, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.STDWEIGHT
		' </summary>
		Public Overridable Property Stdweight As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLading5Metadata.ColumnNames.Stdweight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLading5Metadata.ColumnNames.Stdweight, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.STDGALLONS
		' </summary>
		Public Overridable Property Stdgallons As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLading5Metadata.ColumnNames.Stdgallons)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLading5Metadata.ColumnNames.Stdgallons, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.ProdWgtUOM
		' </summary>
		Public Overridable Property ProdWgtUOM As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.ProdWgtUOM)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.ProdWgtUOM, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.ProdWgtUnits
		' </summary>
		Public Overridable Property ProdWgtUnits As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptBillOfLading5Metadata.ColumnNames.ProdWgtUnits)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptBillOfLading5Metadata.ColumnNames.ProdWgtUnits, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.ProdVolUOM
		' </summary>
		Public Overridable Property ProdVolUOM As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.ProdVolUOM)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.ProdVolUOM, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.ProdVolUnits
		' </summary>
		Public Overridable Property ProdVolUnits As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptBillOfLading5Metadata.ColumnNames.ProdVolUnits)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptBillOfLading5Metadata.ColumnNames.ProdVolUnits, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.CUSTOMERPRODUCTCODE
		' </summary>
		Public Overridable Property Customerproductcode As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.Customerproductcode)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.Customerproductcode, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.CarrierQuoteNumber
		' </summary>
		Public Overridable Property CarrierQuoteNumber As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.CarrierQuoteNumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.CarrierQuoteNumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.DOTDESC
		' </summary>
		Public Overridable Property Dotdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.Dotdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.Dotdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.HAZMATDESC
		' </summary>
		Public Overridable Property Hazmatdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.Hazmatdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.Hazmatdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.HAZCLASSNUMBER
		' </summary>
		Public Overridable Property Hazclassnumber As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.Hazclassnumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.Hazclassnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.PACKAGEGROUP
		' </summary>
		Public Overridable Property Packagegroup As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.Packagegroup)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.Packagegroup, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.IDNUMBER
		' </summary>
		Public Overridable Property Idnumber As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.Idnumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLading5Metadata.ColumnNames.Idnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.RQ
		' </summary>
		Public Overridable Property Rq As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewRptBillOfLading5Metadata.ColumnNames.Rq)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewRptBillOfLading5Metadata.ColumnNames.Rq, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading5.HAZMATID
		' </summary>
		Public Overridable Property Hazmatid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLading5Metadata.ColumnNames.Hazmatid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLading5Metadata.ColumnNames.Hazmatid, value)
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
		
			Public Sub New(ByVal entity As esViewRptBillOfLading5)
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
		  	
			Public Property OriginCSZ As System.String 
				Get
					Dim data_ As System.String = entity.OriginCSZ
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OriginCSZ = Nothing
					Else
						entity.OriginCSZ = Convert.ToString(Value)
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
		  	
			Public Property DestCSZ As System.String 
				Get
					Dim data_ As System.String = entity.DestCSZ
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DestCSZ = Nothing
					Else
						entity.DestCSZ = Convert.ToString(Value)
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
		  	
			Public Property TareWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.TareWeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TareWeight = Nothing
					Else
						entity.TareWeight = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property SchedCarrierName As System.String 
				Get
					Dim data_ As System.String = entity.SchedCarrierName
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SchedCarrierName = Nothing
					Else
						entity.SchedCarrierName = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SchedCarrierAddress1 As System.String 
				Get
					Dim data_ As System.String = entity.SchedCarrierAddress1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SchedCarrierAddress1 = Nothing
					Else
						entity.SchedCarrierAddress1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SchedCarrierAddress2 As System.String 
				Get
					Dim data_ As System.String = entity.SchedCarrierAddress2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SchedCarrierAddress2 = Nothing
					Else
						entity.SchedCarrierAddress2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SchedCarrierCity As System.String 
				Get
					Dim data_ As System.String = entity.SchedCarrierCity
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SchedCarrierCity = Nothing
					Else
						entity.SchedCarrierCity = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SchedCarrierState As System.String 
				Get
					Dim data_ As System.String = entity.SchedCarrierState
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SchedCarrierState = Nothing
					Else
						entity.SchedCarrierState = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SchedCarrierZipCode As System.String 
				Get
					Dim data_ As System.String = entity.SchedCarrierZipCode
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SchedCarrierZipCode = Nothing
					Else
						entity.SchedCarrierZipCode = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SchedCarrierPhone As System.String 
				Get
					Dim data_ As System.String = entity.SchedCarrierPhone
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SchedCarrierPhone = Nothing
					Else
						entity.SchedCarrierPhone = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SchedCarrierContactName As System.String 
				Get
					Dim data_ As System.String = entity.SchedCarrierContactName
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SchedCarrierContactName = Nothing
					Else
						entity.SchedCarrierContactName = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SchedCarrierFAX As System.String 
				Get
					Dim data_ As System.String = entity.SchedCarrierFAX
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SchedCarrierFAX = Nothing
					Else
						entity.SchedCarrierFAX = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SchedCarrierContactEmail As System.String 
				Get
					Dim data_ As System.String = entity.SchedCarrierContactEmail
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SchedCarrierContactEmail = Nothing
					Else
						entity.SchedCarrierContactEmail = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ReqCarrierName As System.String 
				Get
					Dim data_ As System.String = entity.ReqCarrierName
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ReqCarrierName = Nothing
					Else
						entity.ReqCarrierName = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ReqCarrierAddress1 As System.String 
				Get
					Dim data_ As System.String = entity.ReqCarrierAddress1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ReqCarrierAddress1 = Nothing
					Else
						entity.ReqCarrierAddress1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ReqCarrierAddress2 As System.String 
				Get
					Dim data_ As System.String = entity.ReqCarrierAddress2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ReqCarrierAddress2 = Nothing
					Else
						entity.ReqCarrierAddress2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ReqCarrierCity As System.String 
				Get
					Dim data_ As System.String = entity.ReqCarrierCity
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ReqCarrierCity = Nothing
					Else
						entity.ReqCarrierCity = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ReqCarrierState As System.String 
				Get
					Dim data_ As System.String = entity.ReqCarrierState
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ReqCarrierState = Nothing
					Else
						entity.ReqCarrierState = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ReqCarrierZipcode As System.String 
				Get
					Dim data_ As System.String = entity.ReqCarrierZipcode
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ReqCarrierZipcode = Nothing
					Else
						entity.ReqCarrierZipcode = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ReqCarrierPhone As System.String 
				Get
					Dim data_ As System.String = entity.ReqCarrierPhone
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ReqCarrierPhone = Nothing
					Else
						entity.ReqCarrierPhone = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ReqCarrierFAX As System.String 
				Get
					Dim data_ As System.String = entity.ReqCarrierFAX
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ReqCarrierFAX = Nothing
					Else
						entity.ReqCarrierFAX = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ReqCarrierContactName As System.String 
				Get
					Dim data_ As System.String = entity.ReqCarrierContactName
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ReqCarrierContactName = Nothing
					Else
						entity.ReqCarrierContactName = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ReqCarrierContactEmail As System.String 
				Get
					Dim data_ As System.String = entity.ReqCarrierContactEmail
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ReqCarrierContactEmail = Nothing
					Else
						entity.ReqCarrierContactEmail = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SchedLogisticsName As System.String 
				Get
					Dim data_ As System.String = entity.SchedLogisticsName
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SchedLogisticsName = Nothing
					Else
						entity.SchedLogisticsName = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SchedLogisticsAddress1 As System.String 
				Get
					Dim data_ As System.String = entity.SchedLogisticsAddress1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SchedLogisticsAddress1 = Nothing
					Else
						entity.SchedLogisticsAddress1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SchedLogisticsAddress2 As System.String 
				Get
					Dim data_ As System.String = entity.SchedLogisticsAddress2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SchedLogisticsAddress2 = Nothing
					Else
						entity.SchedLogisticsAddress2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SchedLogisticsCity As System.String 
				Get
					Dim data_ As System.String = entity.SchedLogisticsCity
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SchedLogisticsCity = Nothing
					Else
						entity.SchedLogisticsCity = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SchedLogisticsState As System.String 
				Get
					Dim data_ As System.String = entity.SchedLogisticsState
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SchedLogisticsState = Nothing
					Else
						entity.SchedLogisticsState = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SchedLogisticsZipcode As System.String 
				Get
					Dim data_ As System.String = entity.SchedLogisticsZipcode
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SchedLogisticsZipcode = Nothing
					Else
						entity.SchedLogisticsZipcode = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SchedLogisticsCSZ As System.String 
				Get
					Dim data_ As System.String = entity.SchedLogisticsCSZ
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SchedLogisticsCSZ = Nothing
					Else
						entity.SchedLogisticsCSZ = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SchedLogisticsPhone As System.String 
				Get
					Dim data_ As System.String = entity.SchedLogisticsPhone
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SchedLogisticsPhone = Nothing
					Else
						entity.SchedLogisticsPhone = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SchedLogisticsFAX As System.String 
				Get
					Dim data_ As System.String = entity.SchedLogisticsFAX
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SchedLogisticsFAX = Nothing
					Else
						entity.SchedLogisticsFAX = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SchedLogisticsContact As System.String 
				Get
					Dim data_ As System.String = entity.SchedLogisticsContact
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SchedLogisticsContact = Nothing
					Else
						entity.SchedLogisticsContact = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SchedLogisticsEmail As System.String 
				Get
					Dim data_ As System.String = entity.SchedLogisticsEmail
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SchedLogisticsEmail = Nothing
					Else
						entity.SchedLogisticsEmail = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ReqLogisticsName As System.String 
				Get
					Dim data_ As System.String = entity.ReqLogisticsName
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ReqLogisticsName = Nothing
					Else
						entity.ReqLogisticsName = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ReqLogisticsAddress1 As System.String 
				Get
					Dim data_ As System.String = entity.ReqLogisticsAddress1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ReqLogisticsAddress1 = Nothing
					Else
						entity.ReqLogisticsAddress1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ReqLogisticsAddress2 As System.String 
				Get
					Dim data_ As System.String = entity.ReqLogisticsAddress2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ReqLogisticsAddress2 = Nothing
					Else
						entity.ReqLogisticsAddress2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ReqLogisticsCity As System.String 
				Get
					Dim data_ As System.String = entity.ReqLogisticsCity
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ReqLogisticsCity = Nothing
					Else
						entity.ReqLogisticsCity = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ReqLogisticsState As System.String 
				Get
					Dim data_ As System.String = entity.ReqLogisticsState
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ReqLogisticsState = Nothing
					Else
						entity.ReqLogisticsState = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ReqLogisticsZipcode As System.String 
				Get
					Dim data_ As System.String = entity.ReqLogisticsZipcode
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ReqLogisticsZipcode = Nothing
					Else
						entity.ReqLogisticsZipcode = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ReqLogisticsPhone As System.String 
				Get
					Dim data_ As System.String = entity.ReqLogisticsPhone
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ReqLogisticsPhone = Nothing
					Else
						entity.ReqLogisticsPhone = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ReqLogisticsFAX As System.String 
				Get
					Dim data_ As System.String = entity.ReqLogisticsFAX
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ReqLogisticsFAX = Nothing
					Else
						entity.ReqLogisticsFAX = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ReqLogisticsContact As System.String 
				Get
					Dim data_ As System.String = entity.ReqLogisticsContact
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ReqLogisticsContact = Nothing
					Else
						entity.ReqLogisticsContact = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ReqLogisticsEmail As System.String 
				Get
					Dim data_ As System.String = entity.ReqLogisticsEmail
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ReqLogisticsEmail = Nothing
					Else
						entity.ReqLogisticsEmail = Convert.ToString(Value)
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
		  	
			Public Property ProdWgtUOM As System.String 
				Get
					Dim data_ As System.String = entity.ProdWgtUOM
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ProdWgtUOM = Nothing
					Else
						entity.ProdWgtUOM = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ProdWgtUnits As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.ProdWgtUnits
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ProdWgtUnits = Nothing
					Else
						entity.ProdWgtUnits = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property ProdVolUOM As System.String 
				Get
					Dim data_ As System.String = entity.ProdVolUOM
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ProdVolUOM = Nothing
					Else
						entity.ProdVolUOM = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ProdVolUnits As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.ProdVolUnits
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ProdVolUnits = Nothing
					Else
						entity.ProdVolUnits = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Customerproductcode As System.String 
				Get
					Dim data_ As System.String = entity.Customerproductcode
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Customerproductcode = Nothing
					Else
						entity.Customerproductcode = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CarrierQuoteNumber As System.String 
				Get
					Dim data_ As System.String = entity.CarrierQuoteNumber
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CarrierQuoteNumber = Nothing
					Else
						entity.CarrierQuoteNumber = Convert.ToString(Value)
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
		  

			Private entity As esViewRptBillOfLading5
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewRptBillOfLading5Query)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewRptBillOfLading5 can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewRptBillOfLading5Query 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRptBillOfLading5Metadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property LoadID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.LoadID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LoadStatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.LoadStatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LoadType As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.LoadType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PlannedDepartureDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.PlannedDepartureDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ActualShipmentDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.ActualShipmentDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property CustID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.CustID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property PlannedDeliveryDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.PlannedDeliveryDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ActualDeliveryDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.ActualDeliveryDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property OriginType As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.OriginType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OriginID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.OriginID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property OriginName As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.OriginName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OriginAddress1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.OriginAddress1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OriginAddress2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.OriginAddress2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OriginCity As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.OriginCity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OriginState As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.OriginState, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OriginZip As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.OriginZip, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OriginCSZ As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.OriginCSZ, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OriginCountry As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.OriginCountry, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OriginPhone As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.OriginPhone, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OriginContact As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.OriginContact, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PickupHours As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.PickupHours, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DestType As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.DestType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DestID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.DestID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property DestName As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.DestName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DestAddress1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.DestAddress1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DestAddress2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.DestAddress2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DestCity As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.DestCity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DestState As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.DestState, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DestZip As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.DestZip, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DestCSZ As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.DestCSZ, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DestCountry As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.DestCountry, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DestPhone As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.DestPhone, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DestContact As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.DestContact, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DeliveryHours As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.DeliveryHours, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property QuoteID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.QuoteID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property CarrierID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.CarrierID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LogisticsID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.LogisticsID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property CarrierProNumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.CarrierProNumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Fob As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.Fob, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BillCustomer As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.BillCustomer, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property AddToInvoice As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.AddToInvoice, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property LoadNotes As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.LoadNotes, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CreatedTime As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.CreatedTime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property CreatedBy As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.CreatedBy, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ModifiedTime As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.ModifiedTime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ModifiedBy As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.ModifiedBy, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TotalCharged As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.TotalCharged, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property TotalBilled As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.TotalBilled, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property TotalContainers As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.TotalContainers, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property TotalGrossWeight As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.TotalGrossWeight, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property CarrierName As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.CarrierName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Logisticsname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.Logisticsname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ScheduledCarrierID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.ScheduledCarrierID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ScheduledLogisticsID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.ScheduledLogisticsID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ScheduledShipmentDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.ScheduledShipmentDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ScheduledCarrierName As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.ScheduledCarrierName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ScheduledLogisticsName As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.ScheduledLogisticsName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ItemType As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.ItemType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ItemID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.ItemID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ItemDescription As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.ItemDescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property QtyContainers As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.QtyContainers, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property TotalWeight As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.TotalWeight, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property WeightUOM As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.WeightUOM, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ClassRate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.ClassRate, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property IsHazardous As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.IsHazardous, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property PalletID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.PalletID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property TareWeight As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.TareWeight, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property SchedCarrierName As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.SchedCarrierName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SchedCarrierAddress1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.SchedCarrierAddress1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SchedCarrierAddress2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.SchedCarrierAddress2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SchedCarrierCity As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.SchedCarrierCity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SchedCarrierState As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.SchedCarrierState, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SchedCarrierZipCode As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.SchedCarrierZipCode, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SchedCarrierPhone As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.SchedCarrierPhone, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SchedCarrierContactName As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.SchedCarrierContactName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SchedCarrierFAX As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.SchedCarrierFAX, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SchedCarrierContactEmail As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.SchedCarrierContactEmail, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ReqCarrierName As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.ReqCarrierName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ReqCarrierAddress1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.ReqCarrierAddress1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ReqCarrierAddress2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.ReqCarrierAddress2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ReqCarrierCity As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.ReqCarrierCity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ReqCarrierState As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.ReqCarrierState, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ReqCarrierZipcode As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.ReqCarrierZipcode, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ReqCarrierPhone As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.ReqCarrierPhone, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ReqCarrierFAX As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.ReqCarrierFAX, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ReqCarrierContactName As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.ReqCarrierContactName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ReqCarrierContactEmail As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.ReqCarrierContactEmail, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SchedLogisticsName As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.SchedLogisticsName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SchedLogisticsAddress1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.SchedLogisticsAddress1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SchedLogisticsAddress2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.SchedLogisticsAddress2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SchedLogisticsCity As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.SchedLogisticsCity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SchedLogisticsState As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.SchedLogisticsState, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SchedLogisticsZipcode As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.SchedLogisticsZipcode, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SchedLogisticsCSZ As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.SchedLogisticsCSZ, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SchedLogisticsPhone As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.SchedLogisticsPhone, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SchedLogisticsFAX As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.SchedLogisticsFAX, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SchedLogisticsContact As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.SchedLogisticsContact, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SchedLogisticsEmail As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.SchedLogisticsEmail, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ReqLogisticsName As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.ReqLogisticsName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ReqLogisticsAddress1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.ReqLogisticsAddress1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ReqLogisticsAddress2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.ReqLogisticsAddress2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ReqLogisticsCity As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.ReqLogisticsCity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ReqLogisticsState As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.ReqLogisticsState, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ReqLogisticsZipcode As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.ReqLogisticsZipcode, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ReqLogisticsPhone As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.ReqLogisticsPhone, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ReqLogisticsFAX As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.ReqLogisticsFAX, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ReqLogisticsContact As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.ReqLogisticsContact, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ReqLogisticsEmail As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.ReqLogisticsEmail, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Isliquid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.Isliquid, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Chemicalid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.Chemicalid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Istoxic As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.Istoxic, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Stdweight As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.Stdweight, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Stdgallons As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.Stdgallons, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ProdWgtUOM As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.ProdWgtUOM, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ProdWgtUnits As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.ProdWgtUnits, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property ProdVolUOM As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.ProdVolUOM, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ProdVolUnits As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.ProdVolUnits, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Customerproductcode As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.Customerproductcode, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CarrierQuoteNumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.CarrierQuoteNumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Dotdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.Dotdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Hazmatdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.Hazmatdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Hazclassnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.Hazclassnumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Packagegroup As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.Packagegroup, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Idnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.Idnumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Rq As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.Rq, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Hazmatid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLading5Metadata.ColumnNames.Hazmatid, esSystemType.Int32)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewRptBillOfLading5Collection")> _
	Partial Public Class ViewRptBillOfLading5Collection
		Inherits esViewRptBillOfLading5Collection
		Implements IEnumerable(Of ViewRptBillOfLading5)
		
        Public Shared Widening Operator CType(ByVal coll As ViewRptBillOfLading5Collection) As List(Of ViewRptBillOfLading5)
            Dim list As List(Of ViewRptBillOfLading5) = New List(Of ViewRptBillOfLading5)
            Dim emp As ViewRptBillOfLading5

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRptBillOfLading5Metadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewRptBillOfLading5Query()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewRptBillOfLading5(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewRptBillOfLading5()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewRptBillOfLading5Query 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewRptBillOfLading5Query()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRptBillOfLading5Query) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewRptBillOfLading5 
			Return CType(MyBase.AddNewEntity(), ViewRptBillOfLading5)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewRptBillOfLading5) Implements IEnumerable(Of ViewRptBillOfLading5).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewRptBillOfLading5)(Me)
        End Function
		
		Private _query As ViewRptBillOfLading5Query

	End Class
	


	' <summary>
	' Encapsulates the 'viewRptBillOfLading5' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewRptBillOfLading5 ()")> _
	<Serializable> _
	Partial Public Class ViewRptBillOfLading5 
		Inherits esViewRptBillOfLading5

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewRptBillOfLading5Metadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewRptBillOfLading5Query

			If Me._query Is Nothing Then
				Me._query = New ViewRptBillOfLading5Query()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewRptBillOfLading5Query
			Get

				If Me._query Is Nothing then
					Me._query = New ViewRptBillOfLading5Query()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRptBillOfLading5Query) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewRptBillOfLading5Query

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewRptBillOfLading5Query
		inherits esViewRptBillOfLading5Query
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewRptBillOfLading5Query"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewRptBillOfLading5Metadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.LoadID, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.LoadID
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.LoadStatus, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.LoadStatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.LoadType, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.LoadType
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.PlannedDepartureDate, 3, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.PlannedDepartureDate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.ActualShipmentDate, 4, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.ActualShipmentDate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.CustID, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.CustID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.PlannedDeliveryDate, 6, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.PlannedDeliveryDate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.ActualDeliveryDate, 7, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.ActualDeliveryDate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.OriginType, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.OriginType
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.OriginID, 9, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.OriginID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.OriginName, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.OriginName
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.OriginAddress1, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.OriginAddress1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.OriginAddress2, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.OriginAddress2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.OriginCity, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.OriginCity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.OriginState, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.OriginState
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.OriginZip, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.OriginZip
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.OriginCSZ, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.OriginCSZ
			c.CharacterMaxLength = 128
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.OriginCountry, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.OriginCountry
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.OriginPhone, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.OriginPhone
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.OriginContact, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.OriginContact
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.PickupHours, 20, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.PickupHours
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.DestType, 21, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.DestType
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.DestID, 22, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.DestID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.DestName, 23, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.DestName
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.DestAddress1, 24, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.DestAddress1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.DestAddress2, 25, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.DestAddress2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.DestCity, 26, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.DestCity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.DestState, 27, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.DestState
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.DestZip, 28, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.DestZip
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.DestCSZ, 29, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.DestCSZ
			c.CharacterMaxLength = 128
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.DestCountry, 30, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.DestCountry
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.DestPhone, 31, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.DestPhone
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.DestContact, 32, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.DestContact
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.DeliveryHours, 33, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.DeliveryHours
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.QuoteID, 34, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.QuoteID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.CarrierID, 35, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.CarrierID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.LogisticsID, 36, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.LogisticsID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.CarrierProNumber, 37, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.CarrierProNumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.Fob, 38, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.Fob
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.BillCustomer, 39, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.BillCustomer
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.AddToInvoice, 40, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.AddToInvoice
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.LoadNotes, 41, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.LoadNotes
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.CreatedTime, 42, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.CreatedTime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.CreatedBy, 43, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.CreatedBy
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.ModifiedTime, 44, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.ModifiedTime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.ModifiedBy, 45, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.ModifiedBy
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.TotalCharged, 46, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.TotalCharged
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.TotalBilled, 47, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.TotalBilled
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.TotalContainers, 48, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.TotalContainers
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.TotalGrossWeight, 49, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.TotalGrossWeight
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.CarrierName, 50, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.CarrierName
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.Logisticsname, 51, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.Logisticsname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.ScheduledCarrierID, 52, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.ScheduledCarrierID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.ScheduledLogisticsID, 53, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.ScheduledLogisticsID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.ScheduledShipmentDate, 54, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.ScheduledShipmentDate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.ScheduledCarrierName, 55, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.ScheduledCarrierName
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.ScheduledLogisticsName, 56, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.ScheduledLogisticsName
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.ItemType, 57, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.ItemType
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.ItemID, 58, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.ItemID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.ItemDescription, 59, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.ItemDescription
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.Container, 60, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.QtyContainers, 61, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.QtyContainers
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.TotalWeight, 62, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.TotalWeight
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.WeightUOM, 63, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.WeightUOM
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.ClassRate, 64, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.ClassRate
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.IsHazardous, 65, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.IsHazardous
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.PalletID, 66, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.PalletID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.TareWeight, 67, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.TareWeight
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.SchedCarrierName, 68, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.SchedCarrierName
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.SchedCarrierAddress1, 69, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.SchedCarrierAddress1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.SchedCarrierAddress2, 70, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.SchedCarrierAddress2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.SchedCarrierCity, 71, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.SchedCarrierCity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.SchedCarrierState, 72, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.SchedCarrierState
			c.CharacterMaxLength = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.SchedCarrierZipCode, 73, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.SchedCarrierZipCode
			c.CharacterMaxLength = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.SchedCarrierPhone, 74, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.SchedCarrierPhone
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.SchedCarrierContactName, 75, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.SchedCarrierContactName
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.SchedCarrierFAX, 76, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.SchedCarrierFAX
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.SchedCarrierContactEmail, 77, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.SchedCarrierContactEmail
			c.CharacterMaxLength = 100
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.ReqCarrierName, 78, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.ReqCarrierName
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.ReqCarrierAddress1, 79, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.ReqCarrierAddress1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.ReqCarrierAddress2, 80, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.ReqCarrierAddress2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.ReqCarrierCity, 81, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.ReqCarrierCity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.ReqCarrierState, 82, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.ReqCarrierState
			c.CharacterMaxLength = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.ReqCarrierZipcode, 83, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.ReqCarrierZipcode
			c.CharacterMaxLength = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.ReqCarrierPhone, 84, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.ReqCarrierPhone
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.ReqCarrierFAX, 85, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.ReqCarrierFAX
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.ReqCarrierContactName, 86, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.ReqCarrierContactName
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.ReqCarrierContactEmail, 87, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.ReqCarrierContactEmail
			c.CharacterMaxLength = 100
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.SchedLogisticsName, 88, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.SchedLogisticsName
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.SchedLogisticsAddress1, 89, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.SchedLogisticsAddress1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.SchedLogisticsAddress2, 90, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.SchedLogisticsAddress2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.SchedLogisticsCity, 91, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.SchedLogisticsCity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.SchedLogisticsState, 92, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.SchedLogisticsState
			c.CharacterMaxLength = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.SchedLogisticsZipcode, 93, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.SchedLogisticsZipcode
			c.CharacterMaxLength = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.SchedLogisticsCSZ, 94, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.SchedLogisticsCSZ
			c.CharacterMaxLength = 66
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.SchedLogisticsPhone, 95, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.SchedLogisticsPhone
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.SchedLogisticsFAX, 96, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.SchedLogisticsFAX
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.SchedLogisticsContact, 97, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.SchedLogisticsContact
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.SchedLogisticsEmail, 98, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.SchedLogisticsEmail
			c.CharacterMaxLength = 100
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.ReqLogisticsName, 99, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.ReqLogisticsName
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.ReqLogisticsAddress1, 100, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.ReqLogisticsAddress1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.ReqLogisticsAddress2, 101, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.ReqLogisticsAddress2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.ReqLogisticsCity, 102, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.ReqLogisticsCity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.ReqLogisticsState, 103, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.ReqLogisticsState
			c.CharacterMaxLength = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.ReqLogisticsZipcode, 104, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.ReqLogisticsZipcode
			c.CharacterMaxLength = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.ReqLogisticsPhone, 105, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.ReqLogisticsPhone
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.ReqLogisticsFAX, 106, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.ReqLogisticsFAX
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.ReqLogisticsContact, 107, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.ReqLogisticsContact
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.ReqLogisticsEmail, 108, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.ReqLogisticsEmail
			c.CharacterMaxLength = 100
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.Isliquid, 109, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.Isliquid
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.Chemicalid, 110, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.Chemicalid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.Istoxic, 111, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.Istoxic
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.Stdweight, 112, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.Stdweight
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.Stdgallons, 113, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.Stdgallons
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.ProdWgtUOM, 114, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.ProdWgtUOM
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.ProdWgtUnits, 115, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.ProdWgtUnits
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.ProdVolUOM, 116, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.ProdVolUOM
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.ProdVolUnits, 117, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.ProdVolUnits
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.Customerproductcode, 118, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.Customerproductcode
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.CarrierQuoteNumber, 119, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.CarrierQuoteNumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.Dotdesc, 120, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.Dotdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.Hazmatdesc, 121, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.Hazmatdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.Hazclassnumber, 122, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.Hazclassnumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.Packagegroup, 123, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.Packagegroup
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.Idnumber, 124, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.Idnumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.Rq, 125, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.Rq
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLading5Metadata.ColumnNames.Hazmatid, 126, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLading5Metadata.PropertyNames.Hazmatid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewRptBillOfLading5Metadata
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
			 Public Const CustID As String = "CustID"
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
			 Public Const OriginCSZ As String = "OriginCSZ"
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
			 Public Const DestCSZ As String = "DestCSZ"
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
			 Public Const ItemType As String = "ItemType"
			 Public Const ItemID As String = "ItemID"
			 Public Const ItemDescription As String = "ItemDescription"
			 Public Const Container As String = "Container"
			 Public Const QtyContainers As String = "QtyContainers"
			 Public Const TotalWeight As String = "TotalWeight"
			 Public Const WeightUOM As String = "WeightUOM"
			 Public Const ClassRate As String = "ClassRate"
			 Public Const IsHazardous As String = "IsHazardous"
			 Public Const PalletID As String = "PalletID"
			 Public Const TareWeight As String = "TareWeight"
			 Public Const SchedCarrierName As String = "SchedCarrierName"
			 Public Const SchedCarrierAddress1 As String = "SchedCarrierAddress1"
			 Public Const SchedCarrierAddress2 As String = "SchedCarrierAddress2"
			 Public Const SchedCarrierCity As String = "SchedCarrierCity"
			 Public Const SchedCarrierState As String = "SchedCarrierState"
			 Public Const SchedCarrierZipCode As String = "SchedCarrierZipCode"
			 Public Const SchedCarrierPhone As String = "SchedCarrierPhone"
			 Public Const SchedCarrierContactName As String = "SchedCarrierContactName"
			 Public Const SchedCarrierFAX As String = "SchedCarrierFAX"
			 Public Const SchedCarrierContactEmail As String = "SchedCarrierContactEmail"
			 Public Const ReqCarrierName As String = "ReqCarrierName"
			 Public Const ReqCarrierAddress1 As String = "ReqCarrierAddress1"
			 Public Const ReqCarrierAddress2 As String = "ReqCarrierAddress2"
			 Public Const ReqCarrierCity As String = "ReqCarrierCity"
			 Public Const ReqCarrierState As String = "ReqCarrierState"
			 Public Const ReqCarrierZipcode As String = "ReqCarrierZipcode"
			 Public Const ReqCarrierPhone As String = "ReqCarrierPhone"
			 Public Const ReqCarrierFAX As String = "ReqCarrierFAX"
			 Public Const ReqCarrierContactName As String = "ReqCarrierContactName"
			 Public Const ReqCarrierContactEmail As String = "ReqCarrierContactEmail"
			 Public Const SchedLogisticsName As String = "SchedLogisticsName"
			 Public Const SchedLogisticsAddress1 As String = "SchedLogisticsAddress1"
			 Public Const SchedLogisticsAddress2 As String = "SchedLogisticsAddress2"
			 Public Const SchedLogisticsCity As String = "SchedLogisticsCity"
			 Public Const SchedLogisticsState As String = "SchedLogisticsState"
			 Public Const SchedLogisticsZipcode As String = "SchedLogisticsZipcode"
			 Public Const SchedLogisticsCSZ As String = "SchedLogisticsCSZ"
			 Public Const SchedLogisticsPhone As String = "SchedLogisticsPhone"
			 Public Const SchedLogisticsFAX As String = "SchedLogisticsFAX"
			 Public Const SchedLogisticsContact As String = "SchedLogisticsContact"
			 Public Const SchedLogisticsEmail As String = "SchedLogisticsEmail"
			 Public Const ReqLogisticsName As String = "ReqLogisticsName"
			 Public Const ReqLogisticsAddress1 As String = "ReqLogisticsAddress1"
			 Public Const ReqLogisticsAddress2 As String = "ReqLogisticsAddress2"
			 Public Const ReqLogisticsCity As String = "ReqLogisticsCity"
			 Public Const ReqLogisticsState As String = "ReqLogisticsState"
			 Public Const ReqLogisticsZipcode As String = "ReqLogisticsZipcode"
			 Public Const ReqLogisticsPhone As String = "ReqLogisticsPhone"
			 Public Const ReqLogisticsFAX As String = "ReqLogisticsFAX"
			 Public Const ReqLogisticsContact As String = "ReqLogisticsContact"
			 Public Const ReqLogisticsEmail As String = "ReqLogisticsEmail"
			 Public Const Isliquid As String = "ISLIQUID"
			 Public Const Chemicalid As String = "CHEMICALID"
			 Public Const Istoxic As String = "ISTOXIC"
			 Public Const Stdweight As String = "STDWEIGHT"
			 Public Const Stdgallons As String = "STDGALLONS"
			 Public Const ProdWgtUOM As String = "ProdWgtUOM"
			 Public Const ProdWgtUnits As String = "ProdWgtUnits"
			 Public Const ProdVolUOM As String = "ProdVolUOM"
			 Public Const ProdVolUnits As String = "ProdVolUnits"
			 Public Const Customerproductcode As String = "CUSTOMERPRODUCTCODE"
			 Public Const CarrierQuoteNumber As String = "CarrierQuoteNumber"
			 Public Const Dotdesc As String = "DOTDESC"
			 Public Const Hazmatdesc As String = "HAZMATDESC"
			 Public Const Hazclassnumber As String = "HAZCLASSNUMBER"
			 Public Const Packagegroup As String = "PACKAGEGROUP"
			 Public Const Idnumber As String = "IDNUMBER"
			 Public Const Rq As String = "RQ"
			 Public Const Hazmatid As String = "HAZMATID"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const LoadID As String = "LoadID"
			 Public Const LoadStatus As String = "LoadStatus"
			 Public Const LoadType As String = "LoadType"
			 Public Const PlannedDepartureDate As String = "PlannedDepartureDate"
			 Public Const ActualShipmentDate As String = "ActualShipmentDate"
			 Public Const CustID As String = "CustID"
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
			 Public Const OriginCSZ As String = "OriginCSZ"
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
			 Public Const DestCSZ As String = "DestCSZ"
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
			 Public Const ItemType As String = "ItemType"
			 Public Const ItemID As String = "ItemID"
			 Public Const ItemDescription As String = "ItemDescription"
			 Public Const Container As String = "Container"
			 Public Const QtyContainers As String = "QtyContainers"
			 Public Const TotalWeight As String = "TotalWeight"
			 Public Const WeightUOM As String = "WeightUOM"
			 Public Const ClassRate As String = "ClassRate"
			 Public Const IsHazardous As String = "IsHazardous"
			 Public Const PalletID As String = "PalletID"
			 Public Const TareWeight As String = "TareWeight"
			 Public Const SchedCarrierName As String = "SchedCarrierName"
			 Public Const SchedCarrierAddress1 As String = "SchedCarrierAddress1"
			 Public Const SchedCarrierAddress2 As String = "SchedCarrierAddress2"
			 Public Const SchedCarrierCity As String = "SchedCarrierCity"
			 Public Const SchedCarrierState As String = "SchedCarrierState"
			 Public Const SchedCarrierZipCode As String = "SchedCarrierZipCode"
			 Public Const SchedCarrierPhone As String = "SchedCarrierPhone"
			 Public Const SchedCarrierContactName As String = "SchedCarrierContactName"
			 Public Const SchedCarrierFAX As String = "SchedCarrierFAX"
			 Public Const SchedCarrierContactEmail As String = "SchedCarrierContactEmail"
			 Public Const ReqCarrierName As String = "ReqCarrierName"
			 Public Const ReqCarrierAddress1 As String = "ReqCarrierAddress1"
			 Public Const ReqCarrierAddress2 As String = "ReqCarrierAddress2"
			 Public Const ReqCarrierCity As String = "ReqCarrierCity"
			 Public Const ReqCarrierState As String = "ReqCarrierState"
			 Public Const ReqCarrierZipcode As String = "ReqCarrierZipcode"
			 Public Const ReqCarrierPhone As String = "ReqCarrierPhone"
			 Public Const ReqCarrierFAX As String = "ReqCarrierFAX"
			 Public Const ReqCarrierContactName As String = "ReqCarrierContactName"
			 Public Const ReqCarrierContactEmail As String = "ReqCarrierContactEmail"
			 Public Const SchedLogisticsName As String = "SchedLogisticsName"
			 Public Const SchedLogisticsAddress1 As String = "SchedLogisticsAddress1"
			 Public Const SchedLogisticsAddress2 As String = "SchedLogisticsAddress2"
			 Public Const SchedLogisticsCity As String = "SchedLogisticsCity"
			 Public Const SchedLogisticsState As String = "SchedLogisticsState"
			 Public Const SchedLogisticsZipcode As String = "SchedLogisticsZipcode"
			 Public Const SchedLogisticsCSZ As String = "SchedLogisticsCSZ"
			 Public Const SchedLogisticsPhone As String = "SchedLogisticsPhone"
			 Public Const SchedLogisticsFAX As String = "SchedLogisticsFAX"
			 Public Const SchedLogisticsContact As String = "SchedLogisticsContact"
			 Public Const SchedLogisticsEmail As String = "SchedLogisticsEmail"
			 Public Const ReqLogisticsName As String = "ReqLogisticsName"
			 Public Const ReqLogisticsAddress1 As String = "ReqLogisticsAddress1"
			 Public Const ReqLogisticsAddress2 As String = "ReqLogisticsAddress2"
			 Public Const ReqLogisticsCity As String = "ReqLogisticsCity"
			 Public Const ReqLogisticsState As String = "ReqLogisticsState"
			 Public Const ReqLogisticsZipcode As String = "ReqLogisticsZipcode"
			 Public Const ReqLogisticsPhone As String = "ReqLogisticsPhone"
			 Public Const ReqLogisticsFAX As String = "ReqLogisticsFAX"
			 Public Const ReqLogisticsContact As String = "ReqLogisticsContact"
			 Public Const ReqLogisticsEmail As String = "ReqLogisticsEmail"
			 Public Const Isliquid As String = "Isliquid"
			 Public Const Chemicalid As String = "Chemicalid"
			 Public Const Istoxic As String = "Istoxic"
			 Public Const Stdweight As String = "Stdweight"
			 Public Const Stdgallons As String = "Stdgallons"
			 Public Const ProdWgtUOM As String = "ProdWgtUOM"
			 Public Const ProdWgtUnits As String = "ProdWgtUnits"
			 Public Const ProdVolUOM As String = "ProdVolUOM"
			 Public Const ProdVolUnits As String = "ProdVolUnits"
			 Public Const Customerproductcode As String = "Customerproductcode"
			 Public Const CarrierQuoteNumber As String = "CarrierQuoteNumber"
			 Public Const Dotdesc As String = "Dotdesc"
			 Public Const Hazmatdesc As String = "Hazmatdesc"
			 Public Const Hazclassnumber As String = "Hazclassnumber"
			 Public Const Packagegroup As String = "Packagegroup"
			 Public Const Idnumber As String = "Idnumber"
			 Public Const Rq As String = "Rq"
			 Public Const Hazmatid As String = "Hazmatid"
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
            SyncLock GetType(ViewRptBillOfLading5Metadata)
			
				If ViewRptBillOfLading5Metadata.mapDelegates Is Nothing Then
					ViewRptBillOfLading5Metadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewRptBillOfLading5Metadata._meta Is Nothing Then
                    ViewRptBillOfLading5Metadata._meta = New ViewRptBillOfLading5Metadata()
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
				meta.AddTypeMap("CustID", new esTypeMap("int", "System.Int32"))
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
				meta.AddTypeMap("OriginCSZ", new esTypeMap("varchar", "System.String"))
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
				meta.AddTypeMap("DestCSZ", new esTypeMap("varchar", "System.String"))
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
				meta.AddTypeMap("ItemType", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ItemID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ItemDescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("QtyContainers", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("TotalWeight", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("WeightUOM", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ClassRate", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("IsHazardous", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("PalletID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("TareWeight", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("SchedCarrierName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("SchedCarrierAddress1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("SchedCarrierAddress2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("SchedCarrierCity", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("SchedCarrierState", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("SchedCarrierZipCode", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("SchedCarrierPhone", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("SchedCarrierContactName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("SchedCarrierFAX", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("SchedCarrierContactEmail", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ReqCarrierName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ReqCarrierAddress1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ReqCarrierAddress2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ReqCarrierCity", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ReqCarrierState", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ReqCarrierZipcode", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ReqCarrierPhone", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ReqCarrierFAX", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ReqCarrierContactName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ReqCarrierContactEmail", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("SchedLogisticsName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("SchedLogisticsAddress1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("SchedLogisticsAddress2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("SchedLogisticsCity", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("SchedLogisticsState", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("SchedLogisticsZipcode", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("SchedLogisticsCSZ", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("SchedLogisticsPhone", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("SchedLogisticsFAX", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("SchedLogisticsContact", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("SchedLogisticsEmail", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ReqLogisticsName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ReqLogisticsAddress1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ReqLogisticsAddress2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ReqLogisticsCity", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ReqLogisticsState", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ReqLogisticsZipcode", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ReqLogisticsPhone", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ReqLogisticsFAX", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ReqLogisticsContact", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ReqLogisticsEmail", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Isliquid", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Chemicalid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Istoxic", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Stdweight", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Stdgallons", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ProdWgtUOM", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ProdWgtUnits", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("ProdVolUOM", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ProdVolUnits", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Customerproductcode", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CarrierQuoteNumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Dotdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Hazmatdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Hazclassnumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Packagegroup", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Idnumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Rq", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Hazmatid", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "viewRptBillOfLading5"
				meta.Destination = "viewRptBillOfLading5"
				
				meta.spInsert = "proc_viewRptBillOfLading5Insert"
				meta.spUpdate = "proc_viewRptBillOfLading5Update"
				meta.spDelete = "proc_viewRptBillOfLading5Delete"
				meta.spLoadAll = "proc_viewRptBillOfLading5LoadAll"
				meta.spLoadByPrimaryKey = "proc_viewRptBillOfLading5LoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewRptBillOfLading5Metadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
