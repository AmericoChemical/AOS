'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/11/2014 1:36:11 PM
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
	MustInherit Public Class esViewWorkOrderLoadItemLinkCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewWorkOrderLoadItemLinkCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewWorkOrderLoadItemLinkQuery)
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
            Me.InitQuery(CType(query, esViewWorkOrderLoadItemLinkQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewWorkOrderLoadItemLink) As ViewWorkOrderLoadItemLink
			Return CType(MyBase.DetachEntity(entity), ViewWorkOrderLoadItemLink)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewWorkOrderLoadItemLink) As ViewWorkOrderLoadItemLink
			Return CType(MyBase.AttachEntity(entity), ViewWorkOrderLoadItemLink)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewWorkOrderLoadItemLinkCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewWorkOrderLoadItemLink
            Get
                Return TryCast(MyBase.Item(index), ViewWorkOrderLoadItemLink)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewWorkOrderLoadItemLink)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewWorkOrderLoadItemLink	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewWorkOrderLoadItemLinkQuery
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
												
						Case "Workorderitemnumber"
							Me.str.Workorderitemnumber = CType(value, string)
												
						Case "Workordernumber"
							Me.str.Workordernumber = CType(value, string)
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Productdesc"
							Me.str.Productdesc = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "Qty"
							Me.str.Qty = CType(value, string)
												
						Case "Unitorcontainer"
							Me.str.Unitorcontainer = CType(value, string)
												
						Case "Customerpo"
							Me.str.Customerpo = CType(value, string)
												
						Case "LoadItemID"
							Me.str.LoadItemID = CType(value, string)
												
						Case "LoadID"
							Me.str.LoadID = CType(value, string)
												
						Case "SourceType"
							Me.str.SourceType = CType(value, string)
												
						Case "SourceID"
							Me.str.SourceID = CType(value, string)
												
						Case "Fob"
							Me.str.Fob = CType(value, string)
												
						Case "Deliverydate"
							Me.str.Deliverydate = CType(value, string)
												
						Case "Plannedshipdate"
							Me.str.Plannedshipdate = CType(value, string)
												
						Case "Orderstatus"
							Me.str.Orderstatus = CType(value, string)
												
						Case "Carrierid"
							Me.str.Carrierid = CType(value, string)
												
						Case "Workordertype"
							Me.str.Workordertype = CType(value, string)
												
						Case "Onhold"
							Me.str.Onhold = CType(value, string)
												
						Case "Freightcharges"
							Me.str.Freightcharges = CType(value, string)
												
						Case "Freightbillable"
							Me.str.Freightbillable = CType(value, string)
												
						Case "Freightbillcustomer"
							Me.str.Freightbillcustomer = CType(value, string)
												
						Case "Freightoninvoice"
							Me.str.Freightoninvoice = CType(value, string)
												
						Case "LoadStatus"
							Me.str.LoadStatus = CType(value, string)
												
						Case "LoadType"
							Me.str.LoadType = CType(value, string)
												
						Case "PlannedDepartureDate"
							Me.str.PlannedDepartureDate = CType(value, string)
												
						Case "PlannedDeliveryDate"
							Me.str.PlannedDeliveryDate = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Workorderitemnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Workorderitemnumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Workordernumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Workordernumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Qty"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Qty = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "LoadItemID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.LoadItemID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "LoadID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.LoadID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "SourceID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SourceID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Deliverydate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Deliverydate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Plannedshipdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Plannedshipdate = CType(value, Nullable(Of System.DateTime))
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
						
						Case "PlannedDepartureDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.PlannedDepartureDate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "PlannedDeliveryDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.PlannedDeliveryDate = CType(value, Nullable(Of System.DateTime))
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
		' Maps to viewWorkOrderLoadItemLink.WORKORDERITEMNUMBER
		' </summary>
		Public Overridable Property Workorderitemnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Workorderitemnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Workorderitemnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderLoadItemLink.WORKORDERNUMBER
		' </summary>
		Public Overridable Property Workordernumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Workordernumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Workordernumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderLoadItemLink.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderLoadItemLink.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderLoadItemLink.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderLoadItemLink.QTY
		' </summary>
		Public Overridable Property Qty As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Qty)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Qty, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderLoadItemLink.UNITORCONTAINER
		' </summary>
		Public Overridable Property Unitorcontainer As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Unitorcontainer)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Unitorcontainer, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderLoadItemLink.CUSTOMERPO
		' </summary>
		Public Overridable Property Customerpo As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Customerpo)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Customerpo, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderLoadItemLink.LoadItemID
		' </summary>
		Public Overridable Property LoadItemID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.LoadItemID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.LoadItemID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderLoadItemLink.LoadID
		' </summary>
		Public Overridable Property LoadID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.LoadID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.LoadID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderLoadItemLink.SourceType
		' </summary>
		Public Overridable Property SourceType As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.SourceType)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.SourceType, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderLoadItemLink.SourceID
		' </summary>
		Public Overridable Property SourceID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.SourceID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.SourceID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderLoadItemLink.FOB
		' </summary>
		Public Overridable Property Fob As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Fob)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Fob, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderLoadItemLink.DELIVERYDATE
		' </summary>
		Public Overridable Property Deliverydate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Deliverydate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Deliverydate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderLoadItemLink.PLANNEDSHIPDATE
		' </summary>
		Public Overridable Property Plannedshipdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Plannedshipdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Plannedshipdate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderLoadItemLink.ORDERSTATUS
		' </summary>
		Public Overridable Property Orderstatus As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Orderstatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Orderstatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderLoadItemLink.CARRIERID
		' </summary>
		Public Overridable Property Carrierid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Carrierid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Carrierid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderLoadItemLink.WORKORDERTYPE
		' </summary>
		Public Overridable Property Workordertype As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Workordertype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Workordertype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderLoadItemLink.ONHOLD
		' </summary>
		Public Overridable Property Onhold As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Onhold)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Onhold, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderLoadItemLink.FREIGHTCHARGES
		' </summary>
		Public Overridable Property Freightcharges As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Freightcharges)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Freightcharges, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderLoadItemLink.FREIGHTBILLABLE
		' </summary>
		Public Overridable Property Freightbillable As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Freightbillable)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Freightbillable, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderLoadItemLink.FREIGHTBILLCUSTOMER
		' </summary>
		Public Overridable Property Freightbillcustomer As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Freightbillcustomer)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Freightbillcustomer, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderLoadItemLink.FREIGHTONINVOICE
		' </summary>
		Public Overridable Property Freightoninvoice As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Freightoninvoice)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Freightoninvoice, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderLoadItemLink.LoadStatus
		' </summary>
		Public Overridable Property LoadStatus As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.LoadStatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.LoadStatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderLoadItemLink.LoadType
		' </summary>
		Public Overridable Property LoadType As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.LoadType)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.LoadType, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderLoadItemLink.PlannedDepartureDate
		' </summary>
		Public Overridable Property PlannedDepartureDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.PlannedDepartureDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.PlannedDepartureDate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderLoadItemLink.PlannedDeliveryDate
		' </summary>
		Public Overridable Property PlannedDeliveryDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.PlannedDeliveryDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.PlannedDeliveryDate, value)
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
		
			Public Sub New(ByVal entity As esViewWorkOrderLoadItemLink)
				Me.entity = entity
			End Sub				
		
	
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
		  	
			Public Property Qty As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Qty
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qty = Nothing
					Else
						entity.Qty = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Unitorcontainer As System.String 
				Get
					Dim data_ As System.String = entity.Unitorcontainer
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Unitorcontainer = Nothing
					Else
						entity.Unitorcontainer = Convert.ToString(Value)
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
		  

			Private entity As esViewWorkOrderLoadItemLink
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewWorkOrderLoadItemLinkQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewWorkOrderLoadItemLink can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewWorkOrderLoadItemLinkQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewWorkOrderLoadItemLinkMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Workorderitemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Workorderitemnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Workordernumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Workordernumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Qty As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Qty, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Unitorcontainer As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Unitorcontainer, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Customerpo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Customerpo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LoadItemID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderLoadItemLinkMetadata.ColumnNames.LoadItemID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LoadID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderLoadItemLinkMetadata.ColumnNames.LoadID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property SourceType As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderLoadItemLinkMetadata.ColumnNames.SourceType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SourceID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderLoadItemLinkMetadata.ColumnNames.SourceID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Fob As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Fob, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Deliverydate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Deliverydate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Plannedshipdate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Plannedshipdate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Orderstatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Orderstatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Carrierid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Carrierid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Workordertype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Workordertype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Onhold As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Onhold, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Freightcharges As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Freightcharges, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Freightbillable As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Freightbillable, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Freightbillcustomer As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Freightbillcustomer, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Freightoninvoice As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Freightoninvoice, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property LoadStatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderLoadItemLinkMetadata.ColumnNames.LoadStatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LoadType As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderLoadItemLinkMetadata.ColumnNames.LoadType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PlannedDepartureDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderLoadItemLinkMetadata.ColumnNames.PlannedDepartureDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property PlannedDeliveryDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderLoadItemLinkMetadata.ColumnNames.PlannedDeliveryDate, esSystemType.DateTime)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewWorkOrderLoadItemLinkCollection")> _
	Partial Public Class ViewWorkOrderLoadItemLinkCollection
		Inherits esViewWorkOrderLoadItemLinkCollection
		Implements IEnumerable(Of ViewWorkOrderLoadItemLink)
		
        Public Shared Widening Operator CType(ByVal coll As ViewWorkOrderLoadItemLinkCollection) As List(Of ViewWorkOrderLoadItemLink)
            Dim list As List(Of ViewWorkOrderLoadItemLink) = New List(Of ViewWorkOrderLoadItemLink)
            Dim emp As ViewWorkOrderLoadItemLink

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewWorkOrderLoadItemLinkMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewWorkOrderLoadItemLinkQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewWorkOrderLoadItemLink(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewWorkOrderLoadItemLink()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewWorkOrderLoadItemLinkQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewWorkOrderLoadItemLinkQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewWorkOrderLoadItemLinkQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewWorkOrderLoadItemLink 
			Return CType(MyBase.AddNewEntity(), ViewWorkOrderLoadItemLink)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewWorkOrderLoadItemLink) Implements IEnumerable(Of ViewWorkOrderLoadItemLink).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewWorkOrderLoadItemLink)(Me)
        End Function
		
		Private _query As ViewWorkOrderLoadItemLinkQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewWorkOrderLoadItemLink' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewWorkOrderLoadItemLink ()")> _
	<Serializable> _
	Partial Public Class ViewWorkOrderLoadItemLink 
		Inherits esViewWorkOrderLoadItemLink

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewWorkOrderLoadItemLinkMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewWorkOrderLoadItemLinkQuery

			If Me._query Is Nothing Then
				Me._query = New ViewWorkOrderLoadItemLinkQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewWorkOrderLoadItemLinkQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewWorkOrderLoadItemLinkQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewWorkOrderLoadItemLinkQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewWorkOrderLoadItemLinkQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewWorkOrderLoadItemLinkQuery
		inherits esViewWorkOrderLoadItemLinkQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewWorkOrderLoadItemLinkQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewWorkOrderLoadItemLinkMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Workorderitemnumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewWorkOrderLoadItemLinkMetadata.PropertyNames.Workorderitemnumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Workordernumber, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewWorkOrderLoadItemLinkMetadata.PropertyNames.Workordernumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Productid, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewWorkOrderLoadItemLinkMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Productdesc, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderLoadItemLinkMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Container, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderLoadItemLinkMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Qty, 5, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewWorkOrderLoadItemLinkMetadata.PropertyNames.Qty
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Unitorcontainer, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderLoadItemLinkMetadata.PropertyNames.Unitorcontainer
			c.CharacterMaxLength = 1
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Customerpo, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderLoadItemLinkMetadata.PropertyNames.Customerpo
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.LoadItemID, 8, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewWorkOrderLoadItemLinkMetadata.PropertyNames.LoadItemID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.LoadID, 9, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewWorkOrderLoadItemLinkMetadata.PropertyNames.LoadID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.SourceType, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderLoadItemLinkMetadata.PropertyNames.SourceType
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.SourceID, 11, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewWorkOrderLoadItemLinkMetadata.PropertyNames.SourceID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Fob, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderLoadItemLinkMetadata.PropertyNames.Fob
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Deliverydate, 13, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewWorkOrderLoadItemLinkMetadata.PropertyNames.Deliverydate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Plannedshipdate, 14, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewWorkOrderLoadItemLinkMetadata.PropertyNames.Plannedshipdate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Orderstatus, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderLoadItemLinkMetadata.PropertyNames.Orderstatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Carrierid, 16, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewWorkOrderLoadItemLinkMetadata.PropertyNames.Carrierid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Workordertype, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderLoadItemLinkMetadata.PropertyNames.Workordertype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Onhold, 18, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewWorkOrderLoadItemLinkMetadata.PropertyNames.Onhold
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Freightcharges, 19, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewWorkOrderLoadItemLinkMetadata.PropertyNames.Freightcharges
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Freightbillable, 20, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewWorkOrderLoadItemLinkMetadata.PropertyNames.Freightbillable
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Freightbillcustomer, 21, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewWorkOrderLoadItemLinkMetadata.PropertyNames.Freightbillcustomer
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.Freightoninvoice, 22, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewWorkOrderLoadItemLinkMetadata.PropertyNames.Freightoninvoice
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.LoadStatus, 23, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderLoadItemLinkMetadata.PropertyNames.LoadStatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.LoadType, 24, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderLoadItemLinkMetadata.PropertyNames.LoadType
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.PlannedDepartureDate, 25, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewWorkOrderLoadItemLinkMetadata.PropertyNames.PlannedDepartureDate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderLoadItemLinkMetadata.ColumnNames.PlannedDeliveryDate, 26, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewWorkOrderLoadItemLinkMetadata.PropertyNames.PlannedDeliveryDate
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewWorkOrderLoadItemLinkMetadata
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
			 Public Const Workorderitemnumber As String = "WORKORDERITEMNUMBER"
			 Public Const Workordernumber As String = "WORKORDERNUMBER"
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Productdesc As String = "PRODUCTDESC"
			 Public Const Container As String = "CONTAINER"
			 Public Const Qty As String = "QTY"
			 Public Const Unitorcontainer As String = "UNITORCONTAINER"
			 Public Const Customerpo As String = "CUSTOMERPO"
			 Public Const LoadItemID As String = "LoadItemID"
			 Public Const LoadID As String = "LoadID"
			 Public Const SourceType As String = "SourceType"
			 Public Const SourceID As String = "SourceID"
			 Public Const Fob As String = "FOB"
			 Public Const Deliverydate As String = "DELIVERYDATE"
			 Public Const Plannedshipdate As String = "PLANNEDSHIPDATE"
			 Public Const Orderstatus As String = "ORDERSTATUS"
			 Public Const Carrierid As String = "CARRIERID"
			 Public Const Workordertype As String = "WORKORDERTYPE"
			 Public Const Onhold As String = "ONHOLD"
			 Public Const Freightcharges As String = "FREIGHTCHARGES"
			 Public Const Freightbillable As String = "FREIGHTBILLABLE"
			 Public Const Freightbillcustomer As String = "FREIGHTBILLCUSTOMER"
			 Public Const Freightoninvoice As String = "FREIGHTONINVOICE"
			 Public Const LoadStatus As String = "LoadStatus"
			 Public Const LoadType As String = "LoadType"
			 Public Const PlannedDepartureDate As String = "PlannedDepartureDate"
			 Public Const PlannedDeliveryDate As String = "PlannedDeliveryDate"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Workorderitemnumber As String = "Workorderitemnumber"
			 Public Const Workordernumber As String = "Workordernumber"
			 Public Const Productid As String = "Productid"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const Container As String = "Container"
			 Public Const Qty As String = "Qty"
			 Public Const Unitorcontainer As String = "Unitorcontainer"
			 Public Const Customerpo As String = "Customerpo"
			 Public Const LoadItemID As String = "LoadItemID"
			 Public Const LoadID As String = "LoadID"
			 Public Const SourceType As String = "SourceType"
			 Public Const SourceID As String = "SourceID"
			 Public Const Fob As String = "Fob"
			 Public Const Deliverydate As String = "Deliverydate"
			 Public Const Plannedshipdate As String = "Plannedshipdate"
			 Public Const Orderstatus As String = "Orderstatus"
			 Public Const Carrierid As String = "Carrierid"
			 Public Const Workordertype As String = "Workordertype"
			 Public Const Onhold As String = "Onhold"
			 Public Const Freightcharges As String = "Freightcharges"
			 Public Const Freightbillable As String = "Freightbillable"
			 Public Const Freightbillcustomer As String = "Freightbillcustomer"
			 Public Const Freightoninvoice As String = "Freightoninvoice"
			 Public Const LoadStatus As String = "LoadStatus"
			 Public Const LoadType As String = "LoadType"
			 Public Const PlannedDepartureDate As String = "PlannedDepartureDate"
			 Public Const PlannedDeliveryDate As String = "PlannedDeliveryDate"
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
            SyncLock GetType(ViewWorkOrderLoadItemLinkMetadata)
			
				If ViewWorkOrderLoadItemLinkMetadata.mapDelegates Is Nothing Then
					ViewWorkOrderLoadItemLinkMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewWorkOrderLoadItemLinkMetadata._meta Is Nothing Then
                    ViewWorkOrderLoadItemLinkMetadata._meta = New ViewWorkOrderLoadItemLinkMetadata()
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
				

				meta.AddTypeMap("Workorderitemnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Workordernumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Qty", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Unitorcontainer", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Customerpo", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("LoadItemID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("LoadID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("SourceType", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("SourceID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Fob", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Deliverydate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Plannedshipdate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Orderstatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Carrierid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Workordertype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Onhold", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Freightcharges", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Freightbillable", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Freightbillcustomer", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Freightoninvoice", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("LoadStatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("LoadType", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("PlannedDepartureDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("PlannedDeliveryDate", new esTypeMap("datetime", "System.DateTime"))			
				
				
				 
				meta.Source = "viewWorkOrderLoadItemLink"
				meta.Destination = "viewWorkOrderLoadItemLink"
				
				meta.spInsert = "proc_viewWorkOrderLoadItemLinkInsert"
				meta.spUpdate = "proc_viewWorkOrderLoadItemLinkUpdate"
				meta.spDelete = "proc_viewWorkOrderLoadItemLinkDelete"
				meta.spLoadAll = "proc_viewWorkOrderLoadItemLinkLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewWorkOrderLoadItemLinkLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewWorkOrderLoadItemLinkMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
