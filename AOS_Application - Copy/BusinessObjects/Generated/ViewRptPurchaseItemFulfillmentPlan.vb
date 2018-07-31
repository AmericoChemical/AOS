'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 12/31/2014 9:10:10 PM
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
	MustInherit Public Class esViewRptPurchaseItemFulfillmentPlanCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewRptPurchaseItemFulfillmentPlanCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewRptPurchaseItemFulfillmentPlanQuery)
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
            Me.InitQuery(CType(query, esViewRptPurchaseItemFulfillmentPlanQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewRptPurchaseItemFulfillmentPlan) As ViewRptPurchaseItemFulfillmentPlan
			Return CType(MyBase.DetachEntity(entity), ViewRptPurchaseItemFulfillmentPlan)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewRptPurchaseItemFulfillmentPlan) As ViewRptPurchaseItemFulfillmentPlan
			Return CType(MyBase.AttachEntity(entity), ViewRptPurchaseItemFulfillmentPlan)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewRptPurchaseItemFulfillmentPlanCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewRptPurchaseItemFulfillmentPlan
            Get
                Return TryCast(MyBase.Item(index), ViewRptPurchaseItemFulfillmentPlan)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewRptPurchaseItemFulfillmentPlan)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewRptPurchaseItemFulfillmentPlan	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewRptPurchaseItemFulfillmentPlanQuery
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
												
						Case "Purchaseitemid"
							Me.str.Purchaseitemid = CType(value, string)
												
						Case "Itemtype"
							Me.str.Itemtype = CType(value, string)
												
						Case "Qty"
							Me.str.Qty = CType(value, string)
												
						Case "Unitorcontainer"
							Me.str.Unitorcontainer = CType(value, string)
												
						Case "Itemid"
							Me.str.Itemid = CType(value, string)
												
						Case "Itemdescription"
							Me.str.Itemdescription = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "Sourcetype"
							Me.str.Sourcetype = CType(value, string)
												
						Case "Vendorname"
							Me.str.Vendorname = CType(value, string)
												
						Case "Purchasenumber"
							Me.str.Purchasenumber = CType(value, string)
												
						Case "Dateneeded"
							Me.str.Dateneeded = CType(value, string)
												
						Case "Purchaseitemstatus"
							Me.str.Purchaseitemstatus = CType(value, string)
												
						Case "Expectedindate"
							Me.str.Expectedindate = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Workordernumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Workordernumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Purchaseitemid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Purchaseitemid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Qty"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Qty = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Itemid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Itemid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Purchasenumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Purchasenumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Dateneeded"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Dateneeded = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Expectedindate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Expectedindate = CType(value, Nullable(Of System.DateTime))
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
		' Maps to viewRptPurchaseItemFulfillmentPlan.WORKORDERNUMBER
		' </summary>
		Public Overridable Property Workordernumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptPurchaseItemFulfillmentPlanMetadata.ColumnNames.Workordernumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptPurchaseItemFulfillmentPlanMetadata.ColumnNames.Workordernumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPurchaseItemFulfillmentPlan.PURCHASEITEMID
		' </summary>
		Public Overridable Property Purchaseitemid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptPurchaseItemFulfillmentPlanMetadata.ColumnNames.Purchaseitemid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptPurchaseItemFulfillmentPlanMetadata.ColumnNames.Purchaseitemid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPurchaseItemFulfillmentPlan.ITEMTYPE
		' </summary>
		Public Overridable Property Itemtype As System.String
			Get
				Return MyBase.GetSystemString(ViewRptPurchaseItemFulfillmentPlanMetadata.ColumnNames.Itemtype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptPurchaseItemFulfillmentPlanMetadata.ColumnNames.Itemtype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPurchaseItemFulfillmentPlan.QTY
		' </summary>
		Public Overridable Property Qty As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptPurchaseItemFulfillmentPlanMetadata.ColumnNames.Qty)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptPurchaseItemFulfillmentPlanMetadata.ColumnNames.Qty, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPurchaseItemFulfillmentPlan.UNITORCONTAINER
		' </summary>
		Public Overridable Property Unitorcontainer As System.String
			Get
				Return MyBase.GetSystemString(ViewRptPurchaseItemFulfillmentPlanMetadata.ColumnNames.Unitorcontainer)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptPurchaseItemFulfillmentPlanMetadata.ColumnNames.Unitorcontainer, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPurchaseItemFulfillmentPlan.ITEMID
		' </summary>
		Public Overridable Property Itemid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptPurchaseItemFulfillmentPlanMetadata.ColumnNames.Itemid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptPurchaseItemFulfillmentPlanMetadata.ColumnNames.Itemid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPurchaseItemFulfillmentPlan.ITEMDESCRIPTION
		' </summary>
		Public Overridable Property Itemdescription As System.String
			Get
				Return MyBase.GetSystemString(ViewRptPurchaseItemFulfillmentPlanMetadata.ColumnNames.Itemdescription)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptPurchaseItemFulfillmentPlanMetadata.ColumnNames.Itemdescription, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPurchaseItemFulfillmentPlan.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewRptPurchaseItemFulfillmentPlanMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptPurchaseItemFulfillmentPlanMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPurchaseItemFulfillmentPlan.SOURCETYPE
		' </summary>
		Public Overridable Property Sourcetype As System.String
			Get
				Return MyBase.GetSystemString(ViewRptPurchaseItemFulfillmentPlanMetadata.ColumnNames.Sourcetype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptPurchaseItemFulfillmentPlanMetadata.ColumnNames.Sourcetype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPurchaseItemFulfillmentPlan.VENDORNAME
		' </summary>
		Public Overridable Property Vendorname As System.String
			Get
				Return MyBase.GetSystemString(ViewRptPurchaseItemFulfillmentPlanMetadata.ColumnNames.Vendorname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptPurchaseItemFulfillmentPlanMetadata.ColumnNames.Vendorname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPurchaseItemFulfillmentPlan.PURCHASENUMBER
		' </summary>
		Public Overridable Property Purchasenumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptPurchaseItemFulfillmentPlanMetadata.ColumnNames.Purchasenumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptPurchaseItemFulfillmentPlanMetadata.ColumnNames.Purchasenumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPurchaseItemFulfillmentPlan.DATENEEDED
		' </summary>
		Public Overridable Property Dateneeded As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewRptPurchaseItemFulfillmentPlanMetadata.ColumnNames.Dateneeded)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewRptPurchaseItemFulfillmentPlanMetadata.ColumnNames.Dateneeded, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPurchaseItemFulfillmentPlan.PURCHASEITEMSTATUS
		' </summary>
		Public Overridable Property Purchaseitemstatus As System.String
			Get
				Return MyBase.GetSystemString(ViewRptPurchaseItemFulfillmentPlanMetadata.ColumnNames.Purchaseitemstatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptPurchaseItemFulfillmentPlanMetadata.ColumnNames.Purchaseitemstatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPurchaseItemFulfillmentPlan.EXPECTEDINDATE
		' </summary>
		Public Overridable Property Expectedindate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewRptPurchaseItemFulfillmentPlanMetadata.ColumnNames.Expectedindate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewRptPurchaseItemFulfillmentPlanMetadata.ColumnNames.Expectedindate, value)
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
		
			Public Sub New(ByVal entity As esViewRptPurchaseItemFulfillmentPlan)
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
		  	
			Public Property Purchaseitemid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Purchaseitemid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Purchaseitemid = Nothing
					Else
						entity.Purchaseitemid = Convert.ToInt32(Value)
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
		  	
			Public Property Vendorname As System.String 
				Get
					Dim data_ As System.String = entity.Vendorname
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Vendorname = Nothing
					Else
						entity.Vendorname = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Purchasenumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Purchasenumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Purchasenumber = Nothing
					Else
						entity.Purchasenumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Dateneeded As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Dateneeded
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Dateneeded = Nothing
					Else
						entity.Dateneeded = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Purchaseitemstatus As System.String 
				Get
					Dim data_ As System.String = entity.Purchaseitemstatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Purchaseitemstatus = Nothing
					Else
						entity.Purchaseitemstatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Expectedindate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Expectedindate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Expectedindate = Nothing
					Else
						entity.Expectedindate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewRptPurchaseItemFulfillmentPlan
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewRptPurchaseItemFulfillmentPlanQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewRptPurchaseItemFulfillmentPlan can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewRptPurchaseItemFulfillmentPlanQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRptPurchaseItemFulfillmentPlanMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Workordernumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPurchaseItemFulfillmentPlanMetadata.ColumnNames.Workordernumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Purchaseitemid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPurchaseItemFulfillmentPlanMetadata.ColumnNames.Purchaseitemid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Itemtype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPurchaseItemFulfillmentPlanMetadata.ColumnNames.Itemtype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Qty As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPurchaseItemFulfillmentPlanMetadata.ColumnNames.Qty, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Unitorcontainer As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPurchaseItemFulfillmentPlanMetadata.ColumnNames.Unitorcontainer, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Itemid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPurchaseItemFulfillmentPlanMetadata.ColumnNames.Itemid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Itemdescription As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPurchaseItemFulfillmentPlanMetadata.ColumnNames.Itemdescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPurchaseItemFulfillmentPlanMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Sourcetype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPurchaseItemFulfillmentPlanMetadata.ColumnNames.Sourcetype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Vendorname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPurchaseItemFulfillmentPlanMetadata.ColumnNames.Vendorname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Purchasenumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPurchaseItemFulfillmentPlanMetadata.ColumnNames.Purchasenumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Dateneeded As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPurchaseItemFulfillmentPlanMetadata.ColumnNames.Dateneeded, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Purchaseitemstatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPurchaseItemFulfillmentPlanMetadata.ColumnNames.Purchaseitemstatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Expectedindate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPurchaseItemFulfillmentPlanMetadata.ColumnNames.Expectedindate, esSystemType.DateTime)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewRptPurchaseItemFulfillmentPlanCollection")> _
	Partial Public Class ViewRptPurchaseItemFulfillmentPlanCollection
		Inherits esViewRptPurchaseItemFulfillmentPlanCollection
		Implements IEnumerable(Of ViewRptPurchaseItemFulfillmentPlan)
		
        Public Shared Widening Operator CType(ByVal coll As ViewRptPurchaseItemFulfillmentPlanCollection) As List(Of ViewRptPurchaseItemFulfillmentPlan)
            Dim list As List(Of ViewRptPurchaseItemFulfillmentPlan) = New List(Of ViewRptPurchaseItemFulfillmentPlan)
            Dim emp As ViewRptPurchaseItemFulfillmentPlan

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRptPurchaseItemFulfillmentPlanMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewRptPurchaseItemFulfillmentPlanQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewRptPurchaseItemFulfillmentPlan(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewRptPurchaseItemFulfillmentPlan()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewRptPurchaseItemFulfillmentPlanQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewRptPurchaseItemFulfillmentPlanQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRptPurchaseItemFulfillmentPlanQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewRptPurchaseItemFulfillmentPlan 
			Return CType(MyBase.AddNewEntity(), ViewRptPurchaseItemFulfillmentPlan)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewRptPurchaseItemFulfillmentPlan) Implements IEnumerable(Of ViewRptPurchaseItemFulfillmentPlan).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewRptPurchaseItemFulfillmentPlan)(Me)
        End Function
		
		Private _query As ViewRptPurchaseItemFulfillmentPlanQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewRptPurchaseItemFulfillmentPlan' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewRptPurchaseItemFulfillmentPlan ()")> _
	<Serializable> _
	Partial Public Class ViewRptPurchaseItemFulfillmentPlan 
		Inherits esViewRptPurchaseItemFulfillmentPlan

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewRptPurchaseItemFulfillmentPlanMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewRptPurchaseItemFulfillmentPlanQuery

			If Me._query Is Nothing Then
				Me._query = New ViewRptPurchaseItemFulfillmentPlanQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewRptPurchaseItemFulfillmentPlanQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewRptPurchaseItemFulfillmentPlanQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRptPurchaseItemFulfillmentPlanQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewRptPurchaseItemFulfillmentPlanQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewRptPurchaseItemFulfillmentPlanQuery
		inherits esViewRptPurchaseItemFulfillmentPlanQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewRptPurchaseItemFulfillmentPlanQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewRptPurchaseItemFulfillmentPlanMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewRptPurchaseItemFulfillmentPlanMetadata.ColumnNames.Workordernumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptPurchaseItemFulfillmentPlanMetadata.PropertyNames.Workordernumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPurchaseItemFulfillmentPlanMetadata.ColumnNames.Purchaseitemid, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptPurchaseItemFulfillmentPlanMetadata.PropertyNames.Purchaseitemid
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPurchaseItemFulfillmentPlanMetadata.ColumnNames.Itemtype, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptPurchaseItemFulfillmentPlanMetadata.PropertyNames.Itemtype
			c.CharacterMaxLength = 50
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPurchaseItemFulfillmentPlanMetadata.ColumnNames.Qty, 3, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptPurchaseItemFulfillmentPlanMetadata.PropertyNames.Qty
			c.NumericPrecision = 18
			c.NumericScale = 4
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPurchaseItemFulfillmentPlanMetadata.ColumnNames.Unitorcontainer, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptPurchaseItemFulfillmentPlanMetadata.PropertyNames.Unitorcontainer
			c.CharacterMaxLength = 1
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPurchaseItemFulfillmentPlanMetadata.ColumnNames.Itemid, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptPurchaseItemFulfillmentPlanMetadata.PropertyNames.Itemid
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPurchaseItemFulfillmentPlanMetadata.ColumnNames.Itemdescription, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptPurchaseItemFulfillmentPlanMetadata.PropertyNames.Itemdescription
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPurchaseItemFulfillmentPlanMetadata.ColumnNames.Container, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptPurchaseItemFulfillmentPlanMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPurchaseItemFulfillmentPlanMetadata.ColumnNames.Sourcetype, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptPurchaseItemFulfillmentPlanMetadata.PropertyNames.Sourcetype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPurchaseItemFulfillmentPlanMetadata.ColumnNames.Vendorname, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptPurchaseItemFulfillmentPlanMetadata.PropertyNames.Vendorname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPurchaseItemFulfillmentPlanMetadata.ColumnNames.Purchasenumber, 10, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptPurchaseItemFulfillmentPlanMetadata.PropertyNames.Purchasenumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPurchaseItemFulfillmentPlanMetadata.ColumnNames.Dateneeded, 11, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewRptPurchaseItemFulfillmentPlanMetadata.PropertyNames.Dateneeded
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPurchaseItemFulfillmentPlanMetadata.ColumnNames.Purchaseitemstatus, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptPurchaseItemFulfillmentPlanMetadata.PropertyNames.Purchaseitemstatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPurchaseItemFulfillmentPlanMetadata.ColumnNames.Expectedindate, 13, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewRptPurchaseItemFulfillmentPlanMetadata.PropertyNames.Expectedindate
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewRptPurchaseItemFulfillmentPlanMetadata
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
			 Public Const Purchaseitemid As String = "PURCHASEITEMID"
			 Public Const Itemtype As String = "ITEMTYPE"
			 Public Const Qty As String = "QTY"
			 Public Const Unitorcontainer As String = "UNITORCONTAINER"
			 Public Const Itemid As String = "ITEMID"
			 Public Const Itemdescription As String = "ITEMDESCRIPTION"
			 Public Const Container As String = "CONTAINER"
			 Public Const Sourcetype As String = "SOURCETYPE"
			 Public Const Vendorname As String = "VENDORNAME"
			 Public Const Purchasenumber As String = "PURCHASENUMBER"
			 Public Const Dateneeded As String = "DATENEEDED"
			 Public Const Purchaseitemstatus As String = "PURCHASEITEMSTATUS"
			 Public Const Expectedindate As String = "EXPECTEDINDATE"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Workordernumber As String = "Workordernumber"
			 Public Const Purchaseitemid As String = "Purchaseitemid"
			 Public Const Itemtype As String = "Itemtype"
			 Public Const Qty As String = "Qty"
			 Public Const Unitorcontainer As String = "Unitorcontainer"
			 Public Const Itemid As String = "Itemid"
			 Public Const Itemdescription As String = "Itemdescription"
			 Public Const Container As String = "Container"
			 Public Const Sourcetype As String = "Sourcetype"
			 Public Const Vendorname As String = "Vendorname"
			 Public Const Purchasenumber As String = "Purchasenumber"
			 Public Const Dateneeded As String = "Dateneeded"
			 Public Const Purchaseitemstatus As String = "Purchaseitemstatus"
			 Public Const Expectedindate As String = "Expectedindate"
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
            SyncLock GetType(ViewRptPurchaseItemFulfillmentPlanMetadata)
			
				If ViewRptPurchaseItemFulfillmentPlanMetadata.mapDelegates Is Nothing Then
					ViewRptPurchaseItemFulfillmentPlanMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewRptPurchaseItemFulfillmentPlanMetadata._meta Is Nothing Then
                    ViewRptPurchaseItemFulfillmentPlanMetadata._meta = New ViewRptPurchaseItemFulfillmentPlanMetadata()
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
				meta.AddTypeMap("Purchaseitemid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Itemtype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Qty", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Unitorcontainer", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Itemid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Itemdescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Sourcetype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Vendorname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Purchasenumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Dateneeded", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Purchaseitemstatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Expectedindate", new esTypeMap("datetime", "System.DateTime"))			
				
				
				 
				meta.Source = "viewRptPurchaseItemFulfillmentPlan"
				meta.Destination = "viewRptPurchaseItemFulfillmentPlan"
				
				meta.spInsert = "proc_viewRptPurchaseItemFulfillmentPlanInsert"
				meta.spUpdate = "proc_viewRptPurchaseItemFulfillmentPlanUpdate"
				meta.spDelete = "proc_viewRptPurchaseItemFulfillmentPlanDelete"
				meta.spLoadAll = "proc_viewRptPurchaseItemFulfillmentPlanLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewRptPurchaseItemFulfillmentPlanLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewRptPurchaseItemFulfillmentPlanMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
