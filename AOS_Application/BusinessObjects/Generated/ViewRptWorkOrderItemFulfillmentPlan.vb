'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 4/2/2015 3:14:17 PM
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
	MustInherit Public Class esViewRptWorkOrderItemFulfillmentPlanCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewRptWorkOrderItemFulfillmentPlanCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewRptWorkOrderItemFulfillmentPlanQuery)
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
            Me.InitQuery(CType(query, esViewRptWorkOrderItemFulfillmentPlanQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewRptWorkOrderItemFulfillmentPlan) As ViewRptWorkOrderItemFulfillmentPlan
			Return CType(MyBase.DetachEntity(entity), ViewRptWorkOrderItemFulfillmentPlan)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewRptWorkOrderItemFulfillmentPlan) As ViewRptWorkOrderItemFulfillmentPlan
			Return CType(MyBase.AttachEntity(entity), ViewRptWorkOrderItemFulfillmentPlan)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewRptWorkOrderItemFulfillmentPlanCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewRptWorkOrderItemFulfillmentPlan
            Get
                Return TryCast(MyBase.Item(index), ViewRptWorkOrderItemFulfillmentPlan)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewRptWorkOrderItemFulfillmentPlan)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewRptWorkOrderItemFulfillmentPlan	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewRptWorkOrderItemFulfillmentPlanQuery
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
												
						Case "Workordernumber"
							Me.str.Workordernumber = CType(value, string)
												
						Case "Workorderitemnumber"
							Me.str.Workorderitemnumber = CType(value, string)
												
						Case "Itemtype"
							Me.str.Itemtype = CType(value, string)
												
						Case "Qty"
							Me.str.Qty = CType(value, string)
												
						Case "Unitorcontainer"
							Me.str.Unitorcontainer = CType(value, string)
												
						Case "Uom"
							Me.str.Uom = CType(value, string)
												
						Case "Itemid"
							Me.str.Itemid = CType(value, string)
												
						Case "Itemdescription"
							Me.str.Itemdescription = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "Sourcetype"
							Me.str.Sourcetype = CType(value, string)
												
						Case "Sourcedocument"
							Me.str.Sourcedocument = CType(value, string)
												
						Case "Invitemnumber"
							Me.str.Invitemnumber = CType(value, string)
												
						Case "ExceptedDate"
							Me.str.ExceptedDate = CType(value, string)
												
						Case "Sourcestatus"
							Me.str.Sourcestatus = CType(value, string)
												
						Case "Available"
							Me.str.Available = CType(value, string)
												
						Case "Plannedshipdate"
							Me.str.Plannedshipdate = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Workordernumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Workordernumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Workorderitemnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Workorderitemnumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Qty"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Qty = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Itemid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Itemid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Sourcedocument"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Sourcedocument = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Invitemnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Invitemnumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "ExceptedDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.ExceptedDate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Available"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Available = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Plannedshipdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Plannedshipdate = CType(value, Nullable(Of System.DateTime))
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
		' Maps to viewRptWorkOrderItemFulfillmentPlan.WORKORDERNUMBER
		' </summary>
		Public Overridable Property Workordernumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Workordernumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Workordernumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrderItemFulfillmentPlan.WORKORDERITEMNUMBER
		' </summary>
		Public Overridable Property Workorderitemnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Workorderitemnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Workorderitemnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrderItemFulfillmentPlan.ITEMTYPE
		' </summary>
		Public Overridable Property Itemtype As System.String
			Get
				Return MyBase.GetSystemString(ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Itemtype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Itemtype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrderItemFulfillmentPlan.QTY
		' </summary>
		Public Overridable Property Qty As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Qty)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Qty, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrderItemFulfillmentPlan.UNITORCONTAINER
		' </summary>
		Public Overridable Property Unitorcontainer As System.String
			Get
				Return MyBase.GetSystemString(ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Unitorcontainer)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Unitorcontainer, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrderItemFulfillmentPlan.UOM
		' </summary>
		Public Overridable Property Uom As System.String
			Get
				Return MyBase.GetSystemString(ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Uom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Uom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrderItemFulfillmentPlan.ITEMID
		' </summary>
		Public Overridable Property Itemid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Itemid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Itemid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrderItemFulfillmentPlan.ITEMDESCRIPTION
		' </summary>
		Public Overridable Property Itemdescription As System.String
			Get
				Return MyBase.GetSystemString(ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Itemdescription)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Itemdescription, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrderItemFulfillmentPlan.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrderItemFulfillmentPlan.SOURCETYPE
		' </summary>
		Public Overridable Property Sourcetype As System.String
			Get
				Return MyBase.GetSystemString(ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Sourcetype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Sourcetype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrderItemFulfillmentPlan.SOURCEDOCUMENT
		' </summary>
		Public Overridable Property Sourcedocument As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Sourcedocument)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Sourcedocument, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrderItemFulfillmentPlan.INVITEMNUMBER
		' </summary>
		Public Overridable Property Invitemnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Invitemnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Invitemnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrderItemFulfillmentPlan.ExceptedDate
		' </summary>
		Public Overridable Property ExceptedDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.ExceptedDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.ExceptedDate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrderItemFulfillmentPlan.SOURCESTATUS
		' </summary>
		Public Overridable Property Sourcestatus As System.String
			Get
				Return MyBase.GetSystemString(ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Sourcestatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Sourcestatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrderItemFulfillmentPlan.Available
		' </summary>
		Public Overridable Property Available As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Available)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Available, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrderItemFulfillmentPlan.PLANNEDSHIPDATE
		' </summary>
		Public Overridable Property Plannedshipdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Plannedshipdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Plannedshipdate, value)
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
		
			Public Sub New(ByVal entity As esViewRptWorkOrderItemFulfillmentPlan)
				Me.entity = entity
			End Sub				
		
	
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
		  	
			Public Property Itemtype As System.String 
				Get
					Dim data_ As System.String = entity.Itemtype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Itemtype = Nothing
					Else
						entity.Itemtype = Convert.ToString(Value)
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
		  	
			Public Property Uom As System.String 
				Get
					Dim data_ As System.String = entity.Uom
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Uom = Nothing
					Else
						entity.Uom = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Itemid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Itemid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Itemid = Nothing
					Else
						entity.Itemid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Itemdescription As System.String 
				Get
					Dim data_ As System.String = entity.Itemdescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Itemdescription = Nothing
					Else
						entity.Itemdescription = Convert.ToString(Value)
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
		  	
			Public Property Sourcetype As System.String 
				Get
					Dim data_ As System.String = entity.Sourcetype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Sourcetype = Nothing
					Else
						entity.Sourcetype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Sourcedocument As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Sourcedocument
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Sourcedocument = Nothing
					Else
						entity.Sourcedocument = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Invitemnumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Invitemnumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Invitemnumber = Nothing
					Else
						entity.Invitemnumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property ExceptedDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.ExceptedDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ExceptedDate = Nothing
					Else
						entity.ExceptedDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Sourcestatus As System.String 
				Get
					Dim data_ As System.String = entity.Sourcestatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Sourcestatus = Nothing
					Else
						entity.Sourcestatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Available As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Available
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Available = Nothing
					Else
						entity.Available = Convert.ToDateTime(Value)
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
		  

			Private entity As esViewRptWorkOrderItemFulfillmentPlan
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewRptWorkOrderItemFulfillmentPlanQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewRptWorkOrderItemFulfillmentPlan can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewRptWorkOrderItemFulfillmentPlanQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRptWorkOrderItemFulfillmentPlanMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Workordernumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Workordernumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Workorderitemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Workorderitemnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Itemtype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Itemtype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Qty As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Qty, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Unitorcontainer As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Unitorcontainer, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Uom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Uom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Itemid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Itemid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Itemdescription As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Itemdescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Sourcetype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Sourcetype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Sourcedocument As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Sourcedocument, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Invitemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Invitemnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ExceptedDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.ExceptedDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Sourcestatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Sourcestatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Available As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Available, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Plannedshipdate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Plannedshipdate, esSystemType.DateTime)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewRptWorkOrderItemFulfillmentPlanCollection")> _
	Partial Public Class ViewRptWorkOrderItemFulfillmentPlanCollection
		Inherits esViewRptWorkOrderItemFulfillmentPlanCollection
		Implements IEnumerable(Of ViewRptWorkOrderItemFulfillmentPlan)
		
        Public Shared Widening Operator CType(ByVal coll As ViewRptWorkOrderItemFulfillmentPlanCollection) As List(Of ViewRptWorkOrderItemFulfillmentPlan)
            Dim list As List(Of ViewRptWorkOrderItemFulfillmentPlan) = New List(Of ViewRptWorkOrderItemFulfillmentPlan)
            Dim emp As ViewRptWorkOrderItemFulfillmentPlan

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRptWorkOrderItemFulfillmentPlanMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewRptWorkOrderItemFulfillmentPlanQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewRptWorkOrderItemFulfillmentPlan(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewRptWorkOrderItemFulfillmentPlan()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewRptWorkOrderItemFulfillmentPlanQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewRptWorkOrderItemFulfillmentPlanQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRptWorkOrderItemFulfillmentPlanQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewRptWorkOrderItemFulfillmentPlan 
			Return CType(MyBase.AddNewEntity(), ViewRptWorkOrderItemFulfillmentPlan)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewRptWorkOrderItemFulfillmentPlan) Implements IEnumerable(Of ViewRptWorkOrderItemFulfillmentPlan).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewRptWorkOrderItemFulfillmentPlan)(Me)
        End Function
		
		Private _query As ViewRptWorkOrderItemFulfillmentPlanQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewRptWorkOrderItemFulfillmentPlan' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewRptWorkOrderItemFulfillmentPlan ()")> _
	<Serializable> _
	Partial Public Class ViewRptWorkOrderItemFulfillmentPlan 
		Inherits esViewRptWorkOrderItemFulfillmentPlan

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewRptWorkOrderItemFulfillmentPlanMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewRptWorkOrderItemFulfillmentPlanQuery

			If Me._query Is Nothing Then
				Me._query = New ViewRptWorkOrderItemFulfillmentPlanQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewRptWorkOrderItemFulfillmentPlanQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewRptWorkOrderItemFulfillmentPlanQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRptWorkOrderItemFulfillmentPlanQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewRptWorkOrderItemFulfillmentPlanQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewRptWorkOrderItemFulfillmentPlanQuery
		inherits esViewRptWorkOrderItemFulfillmentPlanQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewRptWorkOrderItemFulfillmentPlanQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewRptWorkOrderItemFulfillmentPlanMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Workordernumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptWorkOrderItemFulfillmentPlanMetadata.PropertyNames.Workordernumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Workorderitemnumber, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptWorkOrderItemFulfillmentPlanMetadata.PropertyNames.Workorderitemnumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Itemtype, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptWorkOrderItemFulfillmentPlanMetadata.PropertyNames.Itemtype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Qty, 3, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptWorkOrderItemFulfillmentPlanMetadata.PropertyNames.Qty
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Unitorcontainer, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptWorkOrderItemFulfillmentPlanMetadata.PropertyNames.Unitorcontainer
			c.CharacterMaxLength = 1
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Uom, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptWorkOrderItemFulfillmentPlanMetadata.PropertyNames.Uom
			c.CharacterMaxLength = 8
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Itemid, 6, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptWorkOrderItemFulfillmentPlanMetadata.PropertyNames.Itemid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Itemdescription, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptWorkOrderItemFulfillmentPlanMetadata.PropertyNames.Itemdescription
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Container, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptWorkOrderItemFulfillmentPlanMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Sourcetype, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptWorkOrderItemFulfillmentPlanMetadata.PropertyNames.Sourcetype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Sourcedocument, 10, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptWorkOrderItemFulfillmentPlanMetadata.PropertyNames.Sourcedocument
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Invitemnumber, 11, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptWorkOrderItemFulfillmentPlanMetadata.PropertyNames.Invitemnumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.ExceptedDate, 12, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewRptWorkOrderItemFulfillmentPlanMetadata.PropertyNames.ExceptedDate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Sourcestatus, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptWorkOrderItemFulfillmentPlanMetadata.PropertyNames.Sourcestatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Available, 14, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewRptWorkOrderItemFulfillmentPlanMetadata.PropertyNames.Available
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderItemFulfillmentPlanMetadata.ColumnNames.Plannedshipdate, 15, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewRptWorkOrderItemFulfillmentPlanMetadata.PropertyNames.Plannedshipdate
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewRptWorkOrderItemFulfillmentPlanMetadata
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
			 Public Const Workordernumber As String = "WORKORDERNUMBER"
			 Public Const Workorderitemnumber As String = "WORKORDERITEMNUMBER"
			 Public Const Itemtype As String = "ITEMTYPE"
			 Public Const Qty As String = "QTY"
			 Public Const Unitorcontainer As String = "UNITORCONTAINER"
			 Public Const Uom As String = "UOM"
			 Public Const Itemid As String = "ITEMID"
			 Public Const Itemdescription As String = "ITEMDESCRIPTION"
			 Public Const Container As String = "CONTAINER"
			 Public Const Sourcetype As String = "SOURCETYPE"
			 Public Const Sourcedocument As String = "SOURCEDOCUMENT"
			 Public Const Invitemnumber As String = "INVITEMNUMBER"
			 Public Const ExceptedDate As String = "ExceptedDate"
			 Public Const Sourcestatus As String = "SOURCESTATUS"
			 Public Const Available As String = "Available"
			 Public Const Plannedshipdate As String = "PLANNEDSHIPDATE"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Workordernumber As String = "Workordernumber"
			 Public Const Workorderitemnumber As String = "Workorderitemnumber"
			 Public Const Itemtype As String = "Itemtype"
			 Public Const Qty As String = "Qty"
			 Public Const Unitorcontainer As String = "Unitorcontainer"
			 Public Const Uom As String = "Uom"
			 Public Const Itemid As String = "Itemid"
			 Public Const Itemdescription As String = "Itemdescription"
			 Public Const Container As String = "Container"
			 Public Const Sourcetype As String = "Sourcetype"
			 Public Const Sourcedocument As String = "Sourcedocument"
			 Public Const Invitemnumber As String = "Invitemnumber"
			 Public Const ExceptedDate As String = "ExceptedDate"
			 Public Const Sourcestatus As String = "Sourcestatus"
			 Public Const Available As String = "Available"
			 Public Const Plannedshipdate As String = "Plannedshipdate"
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
            SyncLock GetType(ViewRptWorkOrderItemFulfillmentPlanMetadata)
			
				If ViewRptWorkOrderItemFulfillmentPlanMetadata.mapDelegates Is Nothing Then
					ViewRptWorkOrderItemFulfillmentPlanMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewRptWorkOrderItemFulfillmentPlanMetadata._meta Is Nothing Then
                    ViewRptWorkOrderItemFulfillmentPlanMetadata._meta = New ViewRptWorkOrderItemFulfillmentPlanMetadata()
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
				

				meta.AddTypeMap("Workordernumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Workorderitemnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Itemtype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Qty", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Unitorcontainer", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Uom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Itemid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Itemdescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Sourcetype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Sourcedocument", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Invitemnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ExceptedDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Sourcestatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Available", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Plannedshipdate", new esTypeMap("datetime", "System.DateTime"))			
				
				
				 
				meta.Source = "viewRptWorkOrderItemFulfillmentPlan"
				meta.Destination = "viewRptWorkOrderItemFulfillmentPlan"
				
				meta.spInsert = "proc_viewRptWorkOrderItemFulfillmentPlanInsert"
				meta.spUpdate = "proc_viewRptWorkOrderItemFulfillmentPlanUpdate"
				meta.spDelete = "proc_viewRptWorkOrderItemFulfillmentPlanDelete"
				meta.spLoadAll = "proc_viewRptWorkOrderItemFulfillmentPlanLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewRptWorkOrderItemFulfillmentPlanLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewRptWorkOrderItemFulfillmentPlanMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
