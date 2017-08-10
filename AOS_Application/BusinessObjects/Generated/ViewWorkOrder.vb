'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 4/21/2017 8:07:36 AM
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
	MustInherit Public Class esViewWorkOrderCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewWorkOrderCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewWorkOrderQuery)
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
            Me.InitQuery(CType(query, esViewWorkOrderQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewWorkOrder) As ViewWorkOrder
			Return CType(MyBase.DetachEntity(entity), ViewWorkOrder)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewWorkOrder) As ViewWorkOrder
			Return CType(MyBase.AttachEntity(entity), ViewWorkOrder)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewWorkOrderCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewWorkOrder
            Get
                Return TryCast(MyBase.Item(index), ViewWorkOrder)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewWorkOrder)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewWorkOrder	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewWorkOrderQuery
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
												
						Case "Custid"
							Me.str.Custid = CType(value, string)
												
						Case "Custname"
							Me.str.Custname = CType(value, string)
												
						Case "Customerpo"
							Me.str.Customerpo = CType(value, string)
												
						Case "Plannedshipdate"
							Me.str.Plannedshipdate = CType(value, string)
												
						Case "Deliverydate"
							Me.str.Deliverydate = CType(value, string)
												
						Case "Orderstatus"
							Me.str.Orderstatus = CType(value, string)
												
						Case "Workorderdate"
							Me.str.Workorderdate = CType(value, string)
												
						Case "Workordertype"
							Me.str.Workordertype = CType(value, string)
												
						Case "Ordertype"
							Me.str.Ordertype = CType(value, string)
												
						Case "Billingtype"
							Me.str.Billingtype = CType(value, string)
												
						Case "Transporttype"
							Me.str.Transporttype = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Workordernumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Workordernumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Custid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Custid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Plannedshipdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Plannedshipdate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Deliverydate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Deliverydate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Workorderdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Workorderdate = CType(value, Nullable(Of System.DateTime))
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
		' Maps to viewWorkOrder.WORKORDERNUMBER
		' </summary>
		Public Overridable Property Workordernumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewWorkOrderMetadata.ColumnNames.Workordernumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewWorkOrderMetadata.ColumnNames.Workordernumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrder.CUSTID
		' </summary>
		Public Overridable Property Custid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewWorkOrderMetadata.ColumnNames.Custid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewWorkOrderMetadata.ColumnNames.Custid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrder.CUSTNAME
		' </summary>
		Public Overridable Property Custname As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderMetadata.ColumnNames.Custname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderMetadata.ColumnNames.Custname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrder.CUSTOMERPO
		' </summary>
		Public Overridable Property Customerpo As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderMetadata.ColumnNames.Customerpo)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderMetadata.ColumnNames.Customerpo, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrder.PLANNEDSHIPDATE
		' </summary>
		Public Overridable Property Plannedshipdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewWorkOrderMetadata.ColumnNames.Plannedshipdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewWorkOrderMetadata.ColumnNames.Plannedshipdate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrder.DELIVERYDATE
		' </summary>
		Public Overridable Property Deliverydate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewWorkOrderMetadata.ColumnNames.Deliverydate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewWorkOrderMetadata.ColumnNames.Deliverydate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrder.ORDERSTATUS
		' </summary>
		Public Overridable Property Orderstatus As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderMetadata.ColumnNames.Orderstatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderMetadata.ColumnNames.Orderstatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrder.WORKORDERDATE
		' </summary>
		Public Overridable Property Workorderdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewWorkOrderMetadata.ColumnNames.Workorderdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewWorkOrderMetadata.ColumnNames.Workorderdate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrder.WORKORDERTYPE
		' </summary>
		Public Overridable Property Workordertype As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderMetadata.ColumnNames.Workordertype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderMetadata.ColumnNames.Workordertype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrder.ORDERTYPE
		' </summary>
		Public Overridable Property Ordertype As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderMetadata.ColumnNames.Ordertype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderMetadata.ColumnNames.Ordertype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrder.BILLINGTYPE
		' </summary>
		Public Overridable Property Billingtype As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderMetadata.ColumnNames.Billingtype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderMetadata.ColumnNames.Billingtype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrder.TRANSPORTTYPE
		' </summary>
		Public Overridable Property Transporttype As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderMetadata.ColumnNames.Transporttype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderMetadata.ColumnNames.Transporttype, value)
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
		
			Public Sub New(ByVal entity As esViewWorkOrder)
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
		  	
			Public Property Custid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Custid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Custid = Nothing
					Else
						entity.Custid = Convert.ToInt32(Value)
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
		  	
			Public Property Workorderdate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Workorderdate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Workorderdate = Nothing
					Else
						entity.Workorderdate = Convert.ToDateTime(Value)
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
		  	
			Public Property Ordertype As System.String 
				Get
					Dim data_ As System.String = entity.Ordertype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Ordertype = Nothing
					Else
						entity.Ordertype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Billingtype As System.String 
				Get
					Dim data_ As System.String = entity.Billingtype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Billingtype = Nothing
					Else
						entity.Billingtype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Transporttype As System.String 
				Get
					Dim data_ As System.String = entity.Transporttype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Transporttype = Nothing
					Else
						entity.Transporttype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewWorkOrder
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewWorkOrderQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewWorkOrder can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewWorkOrderQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewWorkOrderMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Workordernumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderMetadata.ColumnNames.Workordernumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Custid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderMetadata.ColumnNames.Custid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Custname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderMetadata.ColumnNames.Custname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Customerpo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderMetadata.ColumnNames.Customerpo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Plannedshipdate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderMetadata.ColumnNames.Plannedshipdate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Deliverydate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderMetadata.ColumnNames.Deliverydate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Orderstatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderMetadata.ColumnNames.Orderstatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Workorderdate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderMetadata.ColumnNames.Workorderdate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Workordertype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderMetadata.ColumnNames.Workordertype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Ordertype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderMetadata.ColumnNames.Ordertype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Billingtype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderMetadata.ColumnNames.Billingtype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Transporttype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderMetadata.ColumnNames.Transporttype, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewWorkOrderCollection")> _
	Partial Public Class ViewWorkOrderCollection
		Inherits esViewWorkOrderCollection
		Implements IEnumerable(Of ViewWorkOrder)
		
        Public Shared Widening Operator CType(ByVal coll As ViewWorkOrderCollection) As List(Of ViewWorkOrder)
            Dim list As List(Of ViewWorkOrder) = New List(Of ViewWorkOrder)
            Dim emp As ViewWorkOrder

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewWorkOrderMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewWorkOrderQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewWorkOrder(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewWorkOrder()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewWorkOrderQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewWorkOrderQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewWorkOrderQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewWorkOrder 
			Return CType(MyBase.AddNewEntity(), ViewWorkOrder)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewWorkOrder) Implements IEnumerable(Of ViewWorkOrder).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewWorkOrder)(Me)
        End Function
		
		Private _query As ViewWorkOrderQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewWorkOrder' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewWorkOrder ()")> _
	<Serializable> _
	Partial Public Class ViewWorkOrder 
		Inherits esViewWorkOrder

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewWorkOrderMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewWorkOrderQuery

			If Me._query Is Nothing Then
				Me._query = New ViewWorkOrderQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewWorkOrderQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewWorkOrderQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewWorkOrderQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewWorkOrderQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewWorkOrderQuery
		inherits esViewWorkOrderQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewWorkOrderQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewWorkOrderMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewWorkOrderMetadata.ColumnNames.Workordernumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewWorkOrderMetadata.PropertyNames.Workordernumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderMetadata.ColumnNames.Custid, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewWorkOrderMetadata.PropertyNames.Custid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderMetadata.ColumnNames.Custname, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderMetadata.PropertyNames.Custname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderMetadata.ColumnNames.Customerpo, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderMetadata.PropertyNames.Customerpo
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderMetadata.ColumnNames.Plannedshipdate, 4, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewWorkOrderMetadata.PropertyNames.Plannedshipdate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderMetadata.ColumnNames.Deliverydate, 5, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewWorkOrderMetadata.PropertyNames.Deliverydate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderMetadata.ColumnNames.Orderstatus, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderMetadata.PropertyNames.Orderstatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderMetadata.ColumnNames.Workorderdate, 7, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewWorkOrderMetadata.PropertyNames.Workorderdate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderMetadata.ColumnNames.Workordertype, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderMetadata.PropertyNames.Workordertype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderMetadata.ColumnNames.Ordertype, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderMetadata.PropertyNames.Ordertype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderMetadata.ColumnNames.Billingtype, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderMetadata.PropertyNames.Billingtype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderMetadata.ColumnNames.Transporttype, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderMetadata.PropertyNames.Transporttype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewWorkOrderMetadata
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
			 Public Const Custid As String = "CUSTID"
			 Public Const Custname As String = "CUSTNAME"
			 Public Const Customerpo As String = "CUSTOMERPO"
			 Public Const Plannedshipdate As String = "PLANNEDSHIPDATE"
			 Public Const Deliverydate As String = "DELIVERYDATE"
			 Public Const Orderstatus As String = "ORDERSTATUS"
			 Public Const Workorderdate As String = "WORKORDERDATE"
			 Public Const Workordertype As String = "WORKORDERTYPE"
			 Public Const Ordertype As String = "ORDERTYPE"
			 Public Const Billingtype As String = "BILLINGTYPE"
			 Public Const Transporttype As String = "TRANSPORTTYPE"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Workordernumber As String = "Workordernumber"
			 Public Const Custid As String = "Custid"
			 Public Const Custname As String = "Custname"
			 Public Const Customerpo As String = "Customerpo"
			 Public Const Plannedshipdate As String = "Plannedshipdate"
			 Public Const Deliverydate As String = "Deliverydate"
			 Public Const Orderstatus As String = "Orderstatus"
			 Public Const Workorderdate As String = "Workorderdate"
			 Public Const Workordertype As String = "Workordertype"
			 Public Const Ordertype As String = "Ordertype"
			 Public Const Billingtype As String = "Billingtype"
			 Public Const Transporttype As String = "Transporttype"
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
            SyncLock GetType(ViewWorkOrderMetadata)
			
				If ViewWorkOrderMetadata.mapDelegates Is Nothing Then
					ViewWorkOrderMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewWorkOrderMetadata._meta Is Nothing Then
                    ViewWorkOrderMetadata._meta = New ViewWorkOrderMetadata()
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
				meta.AddTypeMap("Custid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Custname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Customerpo", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Plannedshipdate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Deliverydate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Orderstatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Workorderdate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Workordertype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Ordertype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Billingtype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Transporttype", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewWorkOrder"
				meta.Destination = "viewWorkOrder"
				
				meta.spInsert = "proc_viewWorkOrderInsert"
				meta.spUpdate = "proc_viewWorkOrderUpdate"
				meta.spDelete = "proc_viewWorkOrderDelete"
				meta.spLoadAll = "proc_viewWorkOrderLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewWorkOrderLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewWorkOrderMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
