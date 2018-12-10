'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 12/10/2018 12:04:43 PM
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
	MustInherit Public Class esViewLoadSummaryCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewLoadSummaryCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewLoadSummaryQuery)
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
            Me.InitQuery(CType(query, esViewLoadSummaryQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewLoadSummary) As ViewLoadSummary
			Return CType(MyBase.DetachEntity(entity), ViewLoadSummary)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewLoadSummary) As ViewLoadSummary
			Return CType(MyBase.AttachEntity(entity), ViewLoadSummary)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewLoadSummaryCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewLoadSummary
            Get
                Return TryCast(MyBase.Item(index), ViewLoadSummary)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewLoadSummary)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewLoadSummary	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewLoadSummaryQuery
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
												
						Case "PlannedDeliveryDate"
							Me.str.PlannedDeliveryDate = CType(value, string)
												
						Case "OriginType"
							Me.str.OriginType = CType(value, string)
												
						Case "OriginName"
							Me.str.OriginName = CType(value, string)
												
						Case "OriginCity"
							Me.str.OriginCity = CType(value, string)
												
						Case "OriginState"
							Me.str.OriginState = CType(value, string)
												
						Case "DestType"
							Me.str.DestType = CType(value, string)
												
						Case "DestName"
							Me.str.DestName = CType(value, string)
												
						Case "DestCity"
							Me.str.DestCity = CType(value, string)
												
						Case "DestState"
							Me.str.DestState = CType(value, string)
												
						Case "CarrierID"
							Me.str.CarrierID = CType(value, string)
												
						Case "CarrierName"
							Me.str.CarrierName = CType(value, string)
												
						Case "Pallets"
							Me.str.Pallets = CType(value, string)
												
						Case "GrossWt"
							Me.str.GrossWt = CType(value, string)
												
						Case "WorkOrderNumbers"
							Me.str.WorkOrderNumbers = CType(value, string)
												
						Case "ScheduledCarrierID"
							Me.str.ScheduledCarrierID = CType(value, string)
												
						Case "ScheduledLogisticsID"
							Me.str.ScheduledLogisticsID = CType(value, string)
												
						Case "ScheduledShipmentDate"
							Me.str.ScheduledShipmentDate = CType(value, string)
												
						Case "CarrierProNumber"
							Me.str.CarrierProNumber = CType(value, string)
												
						Case "ActualShipmentDate"
							Me.str.ActualShipmentDate = CType(value, string)
												
						Case "ActualDeliveryDate"
							Me.str.ActualDeliveryDate = CType(value, string)
												
						Case "ScheduledCarrierName"
							Me.str.ScheduledCarrierName = CType(value, string)
												
						Case "ScheduledCarrierPhone"
							Me.str.ScheduledCarrierPhone = CType(value, string)
												
						Case "TotalSkids"
							Me.str.TotalSkids = CType(value, string)
												
						Case "Freezeprotectflag"
							Me.str.Freezeprotectflag = CType(value, string)
												
						Case "WorkOrderStatus"
							Me.str.WorkOrderStatus = CType(value, string)
												
						Case "OrSoonerFlag"
							Me.str.OrSoonerFlag = CType(value, string)
					
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
						
						Case "PlannedDeliveryDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.PlannedDeliveryDate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "CarrierID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.CarrierID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Pallets"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Pallets = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "GrossWt"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.GrossWt = CType(value, Nullable(Of System.Int32))
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
						
						Case "ActualShipmentDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.ActualShipmentDate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "ActualDeliveryDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.ActualDeliveryDate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "TotalSkids"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.TotalSkids = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Freezeprotectflag"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Freezeprotectflag = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "OrSoonerFlag"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.OrSoonerFlag = CType(value, Nullable(Of System.Boolean))
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
		' Maps to viewLoadSummary.LoadID
		' </summary>
		Public Overridable Property LoadID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadSummaryMetadata.ColumnNames.LoadID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadSummaryMetadata.ColumnNames.LoadID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadSummary.LoadStatus
		' </summary>
		Public Overridable Property LoadStatus As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadSummaryMetadata.ColumnNames.LoadStatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadSummaryMetadata.ColumnNames.LoadStatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadSummary.LoadType
		' </summary>
		Public Overridable Property LoadType As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadSummaryMetadata.ColumnNames.LoadType)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadSummaryMetadata.ColumnNames.LoadType, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadSummary.PlannedDepartureDate
		' </summary>
		Public Overridable Property PlannedDepartureDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewLoadSummaryMetadata.ColumnNames.PlannedDepartureDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewLoadSummaryMetadata.ColumnNames.PlannedDepartureDate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadSummary.PlannedDeliveryDate
		' </summary>
		Public Overridable Property PlannedDeliveryDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewLoadSummaryMetadata.ColumnNames.PlannedDeliveryDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewLoadSummaryMetadata.ColumnNames.PlannedDeliveryDate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadSummary.OriginType
		' </summary>
		Public Overridable Property OriginType As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadSummaryMetadata.ColumnNames.OriginType)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadSummaryMetadata.ColumnNames.OriginType, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadSummary.OriginName
		' </summary>
		Public Overridable Property OriginName As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadSummaryMetadata.ColumnNames.OriginName)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadSummaryMetadata.ColumnNames.OriginName, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadSummary.OriginCity
		' </summary>
		Public Overridable Property OriginCity As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadSummaryMetadata.ColumnNames.OriginCity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadSummaryMetadata.ColumnNames.OriginCity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadSummary.OriginState
		' </summary>
		Public Overridable Property OriginState As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadSummaryMetadata.ColumnNames.OriginState)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadSummaryMetadata.ColumnNames.OriginState, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadSummary.DestType
		' </summary>
		Public Overridable Property DestType As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadSummaryMetadata.ColumnNames.DestType)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadSummaryMetadata.ColumnNames.DestType, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadSummary.DestName
		' </summary>
		Public Overridable Property DestName As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadSummaryMetadata.ColumnNames.DestName)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadSummaryMetadata.ColumnNames.DestName, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadSummary.DestCity
		' </summary>
		Public Overridable Property DestCity As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadSummaryMetadata.ColumnNames.DestCity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadSummaryMetadata.ColumnNames.DestCity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadSummary.DestState
		' </summary>
		Public Overridable Property DestState As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadSummaryMetadata.ColumnNames.DestState)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadSummaryMetadata.ColumnNames.DestState, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadSummary.CarrierID
		' </summary>
		Public Overridable Property CarrierID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadSummaryMetadata.ColumnNames.CarrierID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadSummaryMetadata.ColumnNames.CarrierID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadSummary.CarrierName
		' </summary>
		Public Overridable Property CarrierName As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadSummaryMetadata.ColumnNames.CarrierName)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadSummaryMetadata.ColumnNames.CarrierName, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadSummary.Pallets
		' </summary>
		Public Overridable Property Pallets As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadSummaryMetadata.ColumnNames.Pallets)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadSummaryMetadata.ColumnNames.Pallets, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadSummary.GrossWt
		' </summary>
		Public Overridable Property GrossWt As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadSummaryMetadata.ColumnNames.GrossWt)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadSummaryMetadata.ColumnNames.GrossWt, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadSummary.WorkOrderNumbers
		' </summary>
		Public Overridable Property WorkOrderNumbers As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadSummaryMetadata.ColumnNames.WorkOrderNumbers)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadSummaryMetadata.ColumnNames.WorkOrderNumbers, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadSummary.ScheduledCarrierID
		' </summary>
		Public Overridable Property ScheduledCarrierID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadSummaryMetadata.ColumnNames.ScheduledCarrierID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadSummaryMetadata.ColumnNames.ScheduledCarrierID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadSummary.ScheduledLogisticsID
		' </summary>
		Public Overridable Property ScheduledLogisticsID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadSummaryMetadata.ColumnNames.ScheduledLogisticsID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadSummaryMetadata.ColumnNames.ScheduledLogisticsID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadSummary.ScheduledShipmentDate
		' </summary>
		Public Overridable Property ScheduledShipmentDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewLoadSummaryMetadata.ColumnNames.ScheduledShipmentDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewLoadSummaryMetadata.ColumnNames.ScheduledShipmentDate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadSummary.CarrierProNumber
		' </summary>
		Public Overridable Property CarrierProNumber As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadSummaryMetadata.ColumnNames.CarrierProNumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadSummaryMetadata.ColumnNames.CarrierProNumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadSummary.ActualShipmentDate
		' </summary>
		Public Overridable Property ActualShipmentDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewLoadSummaryMetadata.ColumnNames.ActualShipmentDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewLoadSummaryMetadata.ColumnNames.ActualShipmentDate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadSummary.ActualDeliveryDate
		' </summary>
		Public Overridable Property ActualDeliveryDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewLoadSummaryMetadata.ColumnNames.ActualDeliveryDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewLoadSummaryMetadata.ColumnNames.ActualDeliveryDate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadSummary.ScheduledCarrierName
		' </summary>
		Public Overridable Property ScheduledCarrierName As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadSummaryMetadata.ColumnNames.ScheduledCarrierName)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadSummaryMetadata.ColumnNames.ScheduledCarrierName, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadSummary.ScheduledCarrierPhone
		' </summary>
		Public Overridable Property ScheduledCarrierPhone As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadSummaryMetadata.ColumnNames.ScheduledCarrierPhone)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadSummaryMetadata.ColumnNames.ScheduledCarrierPhone, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadSummary.TotalSkids
		' </summary>
		Public Overridable Property TotalSkids As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadSummaryMetadata.ColumnNames.TotalSkids)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadSummaryMetadata.ColumnNames.TotalSkids, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadSummary.FREEZEPROTECTFLAG
		' </summary>
		Public Overridable Property Freezeprotectflag As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewLoadSummaryMetadata.ColumnNames.Freezeprotectflag)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewLoadSummaryMetadata.ColumnNames.Freezeprotectflag, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadSummary.WorkOrderStatus
		' </summary>
		Public Overridable Property WorkOrderStatus As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadSummaryMetadata.ColumnNames.WorkOrderStatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadSummaryMetadata.ColumnNames.WorkOrderStatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadSummary.OrSoonerFlag
		' </summary>
		Public Overridable Property OrSoonerFlag As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewLoadSummaryMetadata.ColumnNames.OrSoonerFlag)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewLoadSummaryMetadata.ColumnNames.OrSoonerFlag, value)
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
		
			Public Sub New(ByVal entity As esViewLoadSummary)
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
		  	
			Public Property Pallets As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Pallets
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Pallets = Nothing
					Else
						entity.Pallets = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property GrossWt As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.GrossWt
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.GrossWt = Nothing
					Else
						entity.GrossWt = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property WorkOrderNumbers As System.String 
				Get
					Dim data_ As System.String = entity.WorkOrderNumbers
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.WorkOrderNumbers = Nothing
					Else
						entity.WorkOrderNumbers = Convert.ToString(Value)
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
		  	
			Public Property ScheduledCarrierPhone As System.String 
				Get
					Dim data_ As System.String = entity.ScheduledCarrierPhone
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ScheduledCarrierPhone = Nothing
					Else
						entity.ScheduledCarrierPhone = Convert.ToString(Value)
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
		  	
			Public Property WorkOrderStatus As System.String 
				Get
					Dim data_ As System.String = entity.WorkOrderStatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.WorkOrderStatus = Nothing
					Else
						entity.WorkOrderStatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property OrSoonerFlag As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.OrSoonerFlag
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OrSoonerFlag = Nothing
					Else
						entity.OrSoonerFlag = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewLoadSummary
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewLoadSummaryQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewLoadSummary can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewLoadSummaryQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewLoadSummaryMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property LoadID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadSummaryMetadata.ColumnNames.LoadID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LoadStatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadSummaryMetadata.ColumnNames.LoadStatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LoadType As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadSummaryMetadata.ColumnNames.LoadType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PlannedDepartureDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadSummaryMetadata.ColumnNames.PlannedDepartureDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property PlannedDeliveryDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadSummaryMetadata.ColumnNames.PlannedDeliveryDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property OriginType As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadSummaryMetadata.ColumnNames.OriginType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OriginName As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadSummaryMetadata.ColumnNames.OriginName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OriginCity As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadSummaryMetadata.ColumnNames.OriginCity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OriginState As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadSummaryMetadata.ColumnNames.OriginState, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DestType As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadSummaryMetadata.ColumnNames.DestType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DestName As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadSummaryMetadata.ColumnNames.DestName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DestCity As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadSummaryMetadata.ColumnNames.DestCity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DestState As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadSummaryMetadata.ColumnNames.DestState, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CarrierID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadSummaryMetadata.ColumnNames.CarrierID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property CarrierName As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadSummaryMetadata.ColumnNames.CarrierName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Pallets As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadSummaryMetadata.ColumnNames.Pallets, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property GrossWt As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadSummaryMetadata.ColumnNames.GrossWt, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property WorkOrderNumbers As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadSummaryMetadata.ColumnNames.WorkOrderNumbers, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ScheduledCarrierID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadSummaryMetadata.ColumnNames.ScheduledCarrierID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ScheduledLogisticsID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadSummaryMetadata.ColumnNames.ScheduledLogisticsID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ScheduledShipmentDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadSummaryMetadata.ColumnNames.ScheduledShipmentDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property CarrierProNumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadSummaryMetadata.ColumnNames.CarrierProNumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ActualShipmentDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadSummaryMetadata.ColumnNames.ActualShipmentDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ActualDeliveryDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadSummaryMetadata.ColumnNames.ActualDeliveryDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ScheduledCarrierName As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadSummaryMetadata.ColumnNames.ScheduledCarrierName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ScheduledCarrierPhone As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadSummaryMetadata.ColumnNames.ScheduledCarrierPhone, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TotalSkids As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadSummaryMetadata.ColumnNames.TotalSkids, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Freezeprotectflag As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadSummaryMetadata.ColumnNames.Freezeprotectflag, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property WorkOrderStatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadSummaryMetadata.ColumnNames.WorkOrderStatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OrSoonerFlag As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadSummaryMetadata.ColumnNames.OrSoonerFlag, esSystemType.Boolean)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewLoadSummaryCollection")> _
	Partial Public Class ViewLoadSummaryCollection
		Inherits esViewLoadSummaryCollection
		Implements IEnumerable(Of ViewLoadSummary)
		
        Public Shared Widening Operator CType(ByVal coll As ViewLoadSummaryCollection) As List(Of ViewLoadSummary)
            Dim list As List(Of ViewLoadSummary) = New List(Of ViewLoadSummary)
            Dim emp As ViewLoadSummary

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewLoadSummaryMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewLoadSummaryQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewLoadSummary(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewLoadSummary()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewLoadSummaryQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewLoadSummaryQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewLoadSummaryQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewLoadSummary 
			Return CType(MyBase.AddNewEntity(), ViewLoadSummary)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewLoadSummary) Implements IEnumerable(Of ViewLoadSummary).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewLoadSummary)(Me)
        End Function
		
		Private _query As ViewLoadSummaryQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewLoadSummary' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewLoadSummary ()")> _
	<Serializable> _
	Partial Public Class ViewLoadSummary 
		Inherits esViewLoadSummary

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewLoadSummaryMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewLoadSummaryQuery

			If Me._query Is Nothing Then
				Me._query = New ViewLoadSummaryQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewLoadSummaryQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewLoadSummaryQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewLoadSummaryQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewLoadSummaryQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewLoadSummaryQuery
		inherits esViewLoadSummaryQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewLoadSummaryQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewLoadSummaryMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewLoadSummaryMetadata.ColumnNames.LoadID, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadSummaryMetadata.PropertyNames.LoadID
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadSummaryMetadata.ColumnNames.LoadStatus, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadSummaryMetadata.PropertyNames.LoadStatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadSummaryMetadata.ColumnNames.LoadType, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadSummaryMetadata.PropertyNames.LoadType
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadSummaryMetadata.ColumnNames.PlannedDepartureDate, 3, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewLoadSummaryMetadata.PropertyNames.PlannedDepartureDate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadSummaryMetadata.ColumnNames.PlannedDeliveryDate, 4, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewLoadSummaryMetadata.PropertyNames.PlannedDeliveryDate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadSummaryMetadata.ColumnNames.OriginType, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadSummaryMetadata.PropertyNames.OriginType
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadSummaryMetadata.ColumnNames.OriginName, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadSummaryMetadata.PropertyNames.OriginName
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadSummaryMetadata.ColumnNames.OriginCity, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadSummaryMetadata.PropertyNames.OriginCity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadSummaryMetadata.ColumnNames.OriginState, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadSummaryMetadata.PropertyNames.OriginState
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadSummaryMetadata.ColumnNames.DestType, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadSummaryMetadata.PropertyNames.DestType
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadSummaryMetadata.ColumnNames.DestName, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadSummaryMetadata.PropertyNames.DestName
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadSummaryMetadata.ColumnNames.DestCity, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadSummaryMetadata.PropertyNames.DestCity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadSummaryMetadata.ColumnNames.DestState, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadSummaryMetadata.PropertyNames.DestState
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadSummaryMetadata.ColumnNames.CarrierID, 13, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadSummaryMetadata.PropertyNames.CarrierID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadSummaryMetadata.ColumnNames.CarrierName, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadSummaryMetadata.PropertyNames.CarrierName
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadSummaryMetadata.ColumnNames.Pallets, 15, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadSummaryMetadata.PropertyNames.Pallets
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadSummaryMetadata.ColumnNames.GrossWt, 16, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadSummaryMetadata.PropertyNames.GrossWt
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadSummaryMetadata.ColumnNames.WorkOrderNumbers, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadSummaryMetadata.PropertyNames.WorkOrderNumbers
			c.CharacterMaxLength = 1
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadSummaryMetadata.ColumnNames.ScheduledCarrierID, 18, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadSummaryMetadata.PropertyNames.ScheduledCarrierID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadSummaryMetadata.ColumnNames.ScheduledLogisticsID, 19, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadSummaryMetadata.PropertyNames.ScheduledLogisticsID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadSummaryMetadata.ColumnNames.ScheduledShipmentDate, 20, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewLoadSummaryMetadata.PropertyNames.ScheduledShipmentDate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadSummaryMetadata.ColumnNames.CarrierProNumber, 21, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadSummaryMetadata.PropertyNames.CarrierProNumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadSummaryMetadata.ColumnNames.ActualShipmentDate, 22, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewLoadSummaryMetadata.PropertyNames.ActualShipmentDate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadSummaryMetadata.ColumnNames.ActualDeliveryDate, 23, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewLoadSummaryMetadata.PropertyNames.ActualDeliveryDate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadSummaryMetadata.ColumnNames.ScheduledCarrierName, 24, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadSummaryMetadata.PropertyNames.ScheduledCarrierName
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadSummaryMetadata.ColumnNames.ScheduledCarrierPhone, 25, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadSummaryMetadata.PropertyNames.ScheduledCarrierPhone
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadSummaryMetadata.ColumnNames.TotalSkids, 26, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadSummaryMetadata.PropertyNames.TotalSkids
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadSummaryMetadata.ColumnNames.Freezeprotectflag, 27, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewLoadSummaryMetadata.PropertyNames.Freezeprotectflag
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadSummaryMetadata.ColumnNames.WorkOrderStatus, 28, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadSummaryMetadata.PropertyNames.WorkOrderStatus
			c.CharacterMaxLength = 1
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadSummaryMetadata.ColumnNames.OrSoonerFlag, 29, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewLoadSummaryMetadata.PropertyNames.OrSoonerFlag
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewLoadSummaryMetadata
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
			 Public Const PlannedDeliveryDate As String = "PlannedDeliveryDate"
			 Public Const OriginType As String = "OriginType"
			 Public Const OriginName As String = "OriginName"
			 Public Const OriginCity As String = "OriginCity"
			 Public Const OriginState As String = "OriginState"
			 Public Const DestType As String = "DestType"
			 Public Const DestName As String = "DestName"
			 Public Const DestCity As String = "DestCity"
			 Public Const DestState As String = "DestState"
			 Public Const CarrierID As String = "CarrierID"
			 Public Const CarrierName As String = "CarrierName"
			 Public Const Pallets As String = "Pallets"
			 Public Const GrossWt As String = "GrossWt"
			 Public Const WorkOrderNumbers As String = "WorkOrderNumbers"
			 Public Const ScheduledCarrierID As String = "ScheduledCarrierID"
			 Public Const ScheduledLogisticsID As String = "ScheduledLogisticsID"
			 Public Const ScheduledShipmentDate As String = "ScheduledShipmentDate"
			 Public Const CarrierProNumber As String = "CarrierProNumber"
			 Public Const ActualShipmentDate As String = "ActualShipmentDate"
			 Public Const ActualDeliveryDate As String = "ActualDeliveryDate"
			 Public Const ScheduledCarrierName As String = "ScheduledCarrierName"
			 Public Const ScheduledCarrierPhone As String = "ScheduledCarrierPhone"
			 Public Const TotalSkids As String = "TotalSkids"
			 Public Const Freezeprotectflag As String = "FREEZEPROTECTFLAG"
			 Public Const WorkOrderStatus As String = "WorkOrderStatus"
			 Public Const OrSoonerFlag As String = "OrSoonerFlag"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const LoadID As String = "LoadID"
			 Public Const LoadStatus As String = "LoadStatus"
			 Public Const LoadType As String = "LoadType"
			 Public Const PlannedDepartureDate As String = "PlannedDepartureDate"
			 Public Const PlannedDeliveryDate As String = "PlannedDeliveryDate"
			 Public Const OriginType As String = "OriginType"
			 Public Const OriginName As String = "OriginName"
			 Public Const OriginCity As String = "OriginCity"
			 Public Const OriginState As String = "OriginState"
			 Public Const DestType As String = "DestType"
			 Public Const DestName As String = "DestName"
			 Public Const DestCity As String = "DestCity"
			 Public Const DestState As String = "DestState"
			 Public Const CarrierID As String = "CarrierID"
			 Public Const CarrierName As String = "CarrierName"
			 Public Const Pallets As String = "Pallets"
			 Public Const GrossWt As String = "GrossWt"
			 Public Const WorkOrderNumbers As String = "WorkOrderNumbers"
			 Public Const ScheduledCarrierID As String = "ScheduledCarrierID"
			 Public Const ScheduledLogisticsID As String = "ScheduledLogisticsID"
			 Public Const ScheduledShipmentDate As String = "ScheduledShipmentDate"
			 Public Const CarrierProNumber As String = "CarrierProNumber"
			 Public Const ActualShipmentDate As String = "ActualShipmentDate"
			 Public Const ActualDeliveryDate As String = "ActualDeliveryDate"
			 Public Const ScheduledCarrierName As String = "ScheduledCarrierName"
			 Public Const ScheduledCarrierPhone As String = "ScheduledCarrierPhone"
			 Public Const TotalSkids As String = "TotalSkids"
			 Public Const Freezeprotectflag As String = "Freezeprotectflag"
			 Public Const WorkOrderStatus As String = "WorkOrderStatus"
			 Public Const OrSoonerFlag As String = "OrSoonerFlag"
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
            SyncLock GetType(ViewLoadSummaryMetadata)
			
				If ViewLoadSummaryMetadata.mapDelegates Is Nothing Then
					ViewLoadSummaryMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewLoadSummaryMetadata._meta Is Nothing Then
                    ViewLoadSummaryMetadata._meta = New ViewLoadSummaryMetadata()
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
				meta.AddTypeMap("PlannedDeliveryDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("OriginType", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("OriginName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("OriginCity", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("OriginState", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("DestType", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("DestName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("DestCity", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("DestState", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CarrierID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("CarrierName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Pallets", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("GrossWt", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("WorkOrderNumbers", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ScheduledCarrierID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ScheduledLogisticsID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ScheduledShipmentDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("CarrierProNumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ActualShipmentDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("ActualDeliveryDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("ScheduledCarrierName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ScheduledCarrierPhone", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("TotalSkids", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Freezeprotectflag", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("WorkOrderStatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("OrSoonerFlag", new esTypeMap("bit", "System.Boolean"))			
				
				
				 
				meta.Source = "viewLoadSummary"
				meta.Destination = "viewLoadSummary"
				
				meta.spInsert = "proc_viewLoadSummaryInsert"
				meta.spUpdate = "proc_viewLoadSummaryUpdate"
				meta.spDelete = "proc_viewLoadSummaryDelete"
				meta.spLoadAll = "proc_viewLoadSummaryLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewLoadSummaryLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewLoadSummaryMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
