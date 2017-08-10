'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/2/2015 9:20:58 PM
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
	MustInherit Public Class esViewRptWorkOrderFulfillmentPlanCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewRptWorkOrderFulfillmentPlanCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewRptWorkOrderFulfillmentPlanQuery)
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
            Me.InitQuery(CType(query, esViewRptWorkOrderFulfillmentPlanQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewRptWorkOrderFulfillmentPlan) As ViewRptWorkOrderFulfillmentPlan
			Return CType(MyBase.DetachEntity(entity), ViewRptWorkOrderFulfillmentPlan)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewRptWorkOrderFulfillmentPlan) As ViewRptWorkOrderFulfillmentPlan
			Return CType(MyBase.AttachEntity(entity), ViewRptWorkOrderFulfillmentPlan)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewRptWorkOrderFulfillmentPlanCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewRptWorkOrderFulfillmentPlan
            Get
                Return TryCast(MyBase.Item(index), ViewRptWorkOrderFulfillmentPlan)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewRptWorkOrderFulfillmentPlan)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewRptWorkOrderFulfillmentPlan	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewRptWorkOrderFulfillmentPlanQuery
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
												
						Case "Workorderdate"
							Me.str.Workorderdate = CType(value, string)
												
						Case "Customer"
							Me.str.Customer = CType(value, string)
												
						Case "Plannedshipdate"
							Me.str.Plannedshipdate = CType(value, string)
												
						Case "Deliverydate"
							Me.str.Deliverydate = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Workordernumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Workordernumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Plannedshipdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Plannedshipdate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Deliverydate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Deliverydate = CType(value, Nullable(Of System.DateTime))
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
		' Maps to viewRptWorkOrderFulfillmentPlan.WORKORDERNUMBER
		' </summary>
		Public Overridable Property Workordernumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptWorkOrderFulfillmentPlanMetadata.ColumnNames.Workordernumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptWorkOrderFulfillmentPlanMetadata.ColumnNames.Workordernumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrderFulfillmentPlan.WORKORDERDATE
		' </summary>
		Public Overridable Property Workorderdate As System.String
			Get
				Return MyBase.GetSystemString(ViewRptWorkOrderFulfillmentPlanMetadata.ColumnNames.Workorderdate)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptWorkOrderFulfillmentPlanMetadata.ColumnNames.Workorderdate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrderFulfillmentPlan.CUSTOMER
		' </summary>
		Public Overridable Property Customer As System.String
			Get
				Return MyBase.GetSystemString(ViewRptWorkOrderFulfillmentPlanMetadata.ColumnNames.Customer)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptWorkOrderFulfillmentPlanMetadata.ColumnNames.Customer, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrderFulfillmentPlan.PLANNEDSHIPDATE
		' </summary>
		Public Overridable Property Plannedshipdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewRptWorkOrderFulfillmentPlanMetadata.ColumnNames.Plannedshipdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewRptWorkOrderFulfillmentPlanMetadata.ColumnNames.Plannedshipdate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptWorkOrderFulfillmentPlan.DELIVERYDATE
		' </summary>
		Public Overridable Property Deliverydate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewRptWorkOrderFulfillmentPlanMetadata.ColumnNames.Deliverydate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewRptWorkOrderFulfillmentPlanMetadata.ColumnNames.Deliverydate, value)
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
		
			Public Sub New(ByVal entity As esViewRptWorkOrderFulfillmentPlan)
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
		  	
			Public Property Workorderdate As System.String 
				Get
					Dim data_ As System.String = entity.Workorderdate
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Workorderdate = Nothing
					Else
						entity.Workorderdate = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Customer As System.String 
				Get
					Dim data_ As System.String = entity.Customer
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Customer = Nothing
					Else
						entity.Customer = Convert.ToString(Value)
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
		  

			Private entity As esViewRptWorkOrderFulfillmentPlan
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewRptWorkOrderFulfillmentPlanQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewRptWorkOrderFulfillmentPlan can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewRptWorkOrderFulfillmentPlanQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRptWorkOrderFulfillmentPlanMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Workordernumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderFulfillmentPlanMetadata.ColumnNames.Workordernumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Workorderdate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderFulfillmentPlanMetadata.ColumnNames.Workorderdate, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Customer As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderFulfillmentPlanMetadata.ColumnNames.Customer, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Plannedshipdate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderFulfillmentPlanMetadata.ColumnNames.Plannedshipdate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Deliverydate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptWorkOrderFulfillmentPlanMetadata.ColumnNames.Deliverydate, esSystemType.DateTime)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewRptWorkOrderFulfillmentPlanCollection")> _
	Partial Public Class ViewRptWorkOrderFulfillmentPlanCollection
		Inherits esViewRptWorkOrderFulfillmentPlanCollection
		Implements IEnumerable(Of ViewRptWorkOrderFulfillmentPlan)
		
        Public Shared Widening Operator CType(ByVal coll As ViewRptWorkOrderFulfillmentPlanCollection) As List(Of ViewRptWorkOrderFulfillmentPlan)
            Dim list As List(Of ViewRptWorkOrderFulfillmentPlan) = New List(Of ViewRptWorkOrderFulfillmentPlan)
            Dim emp As ViewRptWorkOrderFulfillmentPlan

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRptWorkOrderFulfillmentPlanMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewRptWorkOrderFulfillmentPlanQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewRptWorkOrderFulfillmentPlan(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewRptWorkOrderFulfillmentPlan()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewRptWorkOrderFulfillmentPlanQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewRptWorkOrderFulfillmentPlanQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRptWorkOrderFulfillmentPlanQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewRptWorkOrderFulfillmentPlan 
			Return CType(MyBase.AddNewEntity(), ViewRptWorkOrderFulfillmentPlan)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewRptWorkOrderFulfillmentPlan) Implements IEnumerable(Of ViewRptWorkOrderFulfillmentPlan).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewRptWorkOrderFulfillmentPlan)(Me)
        End Function
		
		Private _query As ViewRptWorkOrderFulfillmentPlanQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewRptWorkOrderFulfillmentPlan' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewRptWorkOrderFulfillmentPlan ()")> _
	<Serializable> _
	Partial Public Class ViewRptWorkOrderFulfillmentPlan 
		Inherits esViewRptWorkOrderFulfillmentPlan

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewRptWorkOrderFulfillmentPlanMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewRptWorkOrderFulfillmentPlanQuery

			If Me._query Is Nothing Then
				Me._query = New ViewRptWorkOrderFulfillmentPlanQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewRptWorkOrderFulfillmentPlanQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewRptWorkOrderFulfillmentPlanQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRptWorkOrderFulfillmentPlanQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewRptWorkOrderFulfillmentPlanQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewRptWorkOrderFulfillmentPlanQuery
		inherits esViewRptWorkOrderFulfillmentPlanQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewRptWorkOrderFulfillmentPlanQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewRptWorkOrderFulfillmentPlanMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewRptWorkOrderFulfillmentPlanMetadata.ColumnNames.Workordernumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptWorkOrderFulfillmentPlanMetadata.PropertyNames.Workordernumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderFulfillmentPlanMetadata.ColumnNames.Workorderdate, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptWorkOrderFulfillmentPlanMetadata.PropertyNames.Workorderdate
			c.CharacterMaxLength = 169
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderFulfillmentPlanMetadata.ColumnNames.Customer, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptWorkOrderFulfillmentPlanMetadata.PropertyNames.Customer
			c.CharacterMaxLength = 187
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderFulfillmentPlanMetadata.ColumnNames.Plannedshipdate, 3, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewRptWorkOrderFulfillmentPlanMetadata.PropertyNames.Plannedshipdate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptWorkOrderFulfillmentPlanMetadata.ColumnNames.Deliverydate, 4, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewRptWorkOrderFulfillmentPlanMetadata.PropertyNames.Deliverydate
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewRptWorkOrderFulfillmentPlanMetadata
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
			 Public Const Workorderdate As String = "WORKORDERDATE"
			 Public Const Customer As String = "CUSTOMER"
			 Public Const Plannedshipdate As String = "PLANNEDSHIPDATE"
			 Public Const Deliverydate As String = "DELIVERYDATE"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Workordernumber As String = "Workordernumber"
			 Public Const Workorderdate As String = "Workorderdate"
			 Public Const Customer As String = "Customer"
			 Public Const Plannedshipdate As String = "Plannedshipdate"
			 Public Const Deliverydate As String = "Deliverydate"
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
            SyncLock GetType(ViewRptWorkOrderFulfillmentPlanMetadata)
			
				If ViewRptWorkOrderFulfillmentPlanMetadata.mapDelegates Is Nothing Then
					ViewRptWorkOrderFulfillmentPlanMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewRptWorkOrderFulfillmentPlanMetadata._meta Is Nothing Then
                    ViewRptWorkOrderFulfillmentPlanMetadata._meta = New ViewRptWorkOrderFulfillmentPlanMetadata()
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
				meta.AddTypeMap("Workorderdate", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Customer", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Plannedshipdate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Deliverydate", new esTypeMap("datetime", "System.DateTime"))			
				
				
				 
				meta.Source = "viewRptWorkOrderFulfillmentPlan"
				meta.Destination = "viewRptWorkOrderFulfillmentPlan"
				
				meta.spInsert = "proc_viewRptWorkOrderFulfillmentPlanInsert"
				meta.spUpdate = "proc_viewRptWorkOrderFulfillmentPlanUpdate"
				meta.spDelete = "proc_viewRptWorkOrderFulfillmentPlanDelete"
				meta.spLoadAll = "proc_viewRptWorkOrderFulfillmentPlanLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewRptWorkOrderFulfillmentPlanLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewRptWorkOrderFulfillmentPlanMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
