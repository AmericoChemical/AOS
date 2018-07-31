'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 4/16/2015 10:13:34 PM
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
	MustInherit Public Class esViewRelabelOrderCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewRelabelOrderCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewRelabelOrderQuery)
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
            Me.InitQuery(CType(query, esViewRelabelOrderQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewRelabelOrder) As ViewRelabelOrder
			Return CType(MyBase.DetachEntity(entity), ViewRelabelOrder)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewRelabelOrder) As ViewRelabelOrder
			Return CType(MyBase.AttachEntity(entity), ViewRelabelOrder)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewRelabelOrderCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewRelabelOrder
            Get
                Return TryCast(MyBase.Item(index), ViewRelabelOrder)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewRelabelOrder)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewRelabelOrder	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewRelabelOrderQuery
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
												
						Case "Relabelordernumber"
							Me.str.Relabelordernumber = CType(value, string)
												
						Case "Relabelorderdate"
							Me.str.Relabelorderdate = CType(value, string)
												
						Case "Qty"
							Me.str.Qty = CType(value, string)
												
						Case "Itemid"
							Me.str.Itemid = CType(value, string)
												
						Case "Itemdesc"
							Me.str.Itemdesc = CType(value, string)
												
						Case "Uom"
							Me.str.Uom = CType(value, string)
												
						Case "Neededby"
							Me.str.Neededby = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "Workordernumber"
							Me.str.Workordernumber = CType(value, string)
												
						Case "Relabelorderstatus"
							Me.str.Relabelorderstatus = CType(value, string)
												
						Case "Custname"
							Me.str.Custname = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Relabelordernumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Relabelordernumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Relabelorderdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Relabelorderdate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Qty"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Qty = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Itemid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Itemid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Neededby"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Neededby = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Workordernumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Workordernumber = CType(value, Nullable(Of System.Int32))
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
		' Maps to viewRelabelOrder.RELABELORDERNUMBER
		' </summary>
		Public Overridable Property Relabelordernumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRelabelOrderMetadata.ColumnNames.Relabelordernumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRelabelOrderMetadata.ColumnNames.Relabelordernumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRelabelOrder.RELABELORDERDATE
		' </summary>
		Public Overridable Property Relabelorderdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewRelabelOrderMetadata.ColumnNames.Relabelorderdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewRelabelOrderMetadata.ColumnNames.Relabelorderdate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRelabelOrder.QTY
		' </summary>
		Public Overridable Property Qty As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRelabelOrderMetadata.ColumnNames.Qty)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRelabelOrderMetadata.ColumnNames.Qty, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRelabelOrder.ITEMID
		' </summary>
		Public Overridable Property Itemid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRelabelOrderMetadata.ColumnNames.Itemid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRelabelOrderMetadata.ColumnNames.Itemid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRelabelOrder.ITEMDESC
		' </summary>
		Public Overridable Property Itemdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewRelabelOrderMetadata.ColumnNames.Itemdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRelabelOrderMetadata.ColumnNames.Itemdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRelabelOrder.UOM
		' </summary>
		Public Overridable Property Uom As System.String
			Get
				Return MyBase.GetSystemString(ViewRelabelOrderMetadata.ColumnNames.Uom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRelabelOrderMetadata.ColumnNames.Uom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRelabelOrder.NEEDEDBY
		' </summary>
		Public Overridable Property Neededby As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewRelabelOrderMetadata.ColumnNames.Neededby)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewRelabelOrderMetadata.ColumnNames.Neededby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRelabelOrder.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewRelabelOrderMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRelabelOrderMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRelabelOrder.WORKORDERNUMBER
		' </summary>
		Public Overridable Property Workordernumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRelabelOrderMetadata.ColumnNames.Workordernumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRelabelOrderMetadata.ColumnNames.Workordernumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRelabelOrder.RELABELORDERSTATUS
		' </summary>
		Public Overridable Property Relabelorderstatus As System.String
			Get
				Return MyBase.GetSystemString(ViewRelabelOrderMetadata.ColumnNames.Relabelorderstatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRelabelOrderMetadata.ColumnNames.Relabelorderstatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRelabelOrder.CUSTNAME
		' </summary>
		Public Overridable Property Custname As System.String
			Get
				Return MyBase.GetSystemString(ViewRelabelOrderMetadata.ColumnNames.Custname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRelabelOrderMetadata.ColumnNames.Custname, value)
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
		
			Public Sub New(ByVal entity As esViewRelabelOrder)
				Me.entity = entity
			End Sub				
		
	
			Public Property Relabelordernumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Relabelordernumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Relabelordernumber = Nothing
					Else
						entity.Relabelordernumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Relabelorderdate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Relabelorderdate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Relabelorderdate = Nothing
					Else
						entity.Relabelorderdate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Qty As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Qty
					
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
						entity.Qty = Convert.ToInt32(Value)
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
		  	
			Public Property Itemdesc As System.String 
				Get
					Dim data_ As System.String = entity.Itemdesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Itemdesc = Nothing
					Else
						entity.Itemdesc = Convert.ToString(Value)
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
		  	
			Public Property Neededby As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Neededby
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Neededby = Nothing
					Else
						entity.Neededby = Convert.ToDateTime(Value)
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
		  	
			Public Property Relabelorderstatus As System.String 
				Get
					Dim data_ As System.String = entity.Relabelorderstatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Relabelorderstatus = Nothing
					Else
						entity.Relabelorderstatus = Convert.ToString(Value)
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
		  

			Private entity As esViewRelabelOrder
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewRelabelOrderQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewRelabelOrder can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewRelabelOrderQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRelabelOrderMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Relabelordernumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRelabelOrderMetadata.ColumnNames.Relabelordernumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Relabelorderdate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRelabelOrderMetadata.ColumnNames.Relabelorderdate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Qty As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRelabelOrderMetadata.ColumnNames.Qty, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Itemid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRelabelOrderMetadata.ColumnNames.Itemid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Itemdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRelabelOrderMetadata.ColumnNames.Itemdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Uom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRelabelOrderMetadata.ColumnNames.Uom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Neededby As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRelabelOrderMetadata.ColumnNames.Neededby, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRelabelOrderMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Workordernumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRelabelOrderMetadata.ColumnNames.Workordernumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Relabelorderstatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRelabelOrderMetadata.ColumnNames.Relabelorderstatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Custname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRelabelOrderMetadata.ColumnNames.Custname, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewRelabelOrderCollection")> _
	Partial Public Class ViewRelabelOrderCollection
		Inherits esViewRelabelOrderCollection
		Implements IEnumerable(Of ViewRelabelOrder)
		
        Public Shared Widening Operator CType(ByVal coll As ViewRelabelOrderCollection) As List(Of ViewRelabelOrder)
            Dim list As List(Of ViewRelabelOrder) = New List(Of ViewRelabelOrder)
            Dim emp As ViewRelabelOrder

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRelabelOrderMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewRelabelOrderQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewRelabelOrder(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewRelabelOrder()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewRelabelOrderQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewRelabelOrderQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRelabelOrderQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewRelabelOrder 
			Return CType(MyBase.AddNewEntity(), ViewRelabelOrder)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewRelabelOrder) Implements IEnumerable(Of ViewRelabelOrder).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewRelabelOrder)(Me)
        End Function
		
		Private _query As ViewRelabelOrderQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewRelabelOrder' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewRelabelOrder ()")> _
	<Serializable> _
	Partial Public Class ViewRelabelOrder 
		Inherits esViewRelabelOrder

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewRelabelOrderMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewRelabelOrderQuery

			If Me._query Is Nothing Then
				Me._query = New ViewRelabelOrderQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewRelabelOrderQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewRelabelOrderQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRelabelOrderQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewRelabelOrderQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewRelabelOrderQuery
		inherits esViewRelabelOrderQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewRelabelOrderQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewRelabelOrderMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewRelabelOrderMetadata.ColumnNames.Relabelordernumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRelabelOrderMetadata.PropertyNames.Relabelordernumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRelabelOrderMetadata.ColumnNames.Relabelorderdate, 1, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewRelabelOrderMetadata.PropertyNames.Relabelorderdate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRelabelOrderMetadata.ColumnNames.Qty, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRelabelOrderMetadata.PropertyNames.Qty
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRelabelOrderMetadata.ColumnNames.Itemid, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRelabelOrderMetadata.PropertyNames.Itemid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRelabelOrderMetadata.ColumnNames.Itemdesc, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRelabelOrderMetadata.PropertyNames.Itemdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRelabelOrderMetadata.ColumnNames.Uom, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRelabelOrderMetadata.PropertyNames.Uom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRelabelOrderMetadata.ColumnNames.Neededby, 6, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewRelabelOrderMetadata.PropertyNames.Neededby
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRelabelOrderMetadata.ColumnNames.Container, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRelabelOrderMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRelabelOrderMetadata.ColumnNames.Workordernumber, 8, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRelabelOrderMetadata.PropertyNames.Workordernumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRelabelOrderMetadata.ColumnNames.Relabelorderstatus, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRelabelOrderMetadata.PropertyNames.Relabelorderstatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRelabelOrderMetadata.ColumnNames.Custname, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRelabelOrderMetadata.PropertyNames.Custname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewRelabelOrderMetadata
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
			 Public Const Relabelordernumber As String = "RELABELORDERNUMBER"
			 Public Const Relabelorderdate As String = "RELABELORDERDATE"
			 Public Const Qty As String = "QTY"
			 Public Const Itemid As String = "ITEMID"
			 Public Const Itemdesc As String = "ITEMDESC"
			 Public Const Uom As String = "UOM"
			 Public Const Neededby As String = "NEEDEDBY"
			 Public Const Container As String = "CONTAINER"
			 Public Const Workordernumber As String = "WORKORDERNUMBER"
			 Public Const Relabelorderstatus As String = "RELABELORDERSTATUS"
			 Public Const Custname As String = "CUSTNAME"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Relabelordernumber As String = "Relabelordernumber"
			 Public Const Relabelorderdate As String = "Relabelorderdate"
			 Public Const Qty As String = "Qty"
			 Public Const Itemid As String = "Itemid"
			 Public Const Itemdesc As String = "Itemdesc"
			 Public Const Uom As String = "Uom"
			 Public Const Neededby As String = "Neededby"
			 Public Const Container As String = "Container"
			 Public Const Workordernumber As String = "Workordernumber"
			 Public Const Relabelorderstatus As String = "Relabelorderstatus"
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
            SyncLock GetType(ViewRelabelOrderMetadata)
			
				If ViewRelabelOrderMetadata.mapDelegates Is Nothing Then
					ViewRelabelOrderMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewRelabelOrderMetadata._meta Is Nothing Then
                    ViewRelabelOrderMetadata._meta = New ViewRelabelOrderMetadata()
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
				

				meta.AddTypeMap("Relabelordernumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Relabelorderdate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Qty", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Itemid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Itemdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Uom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Neededby", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Workordernumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Relabelorderstatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Custname", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewRelabelOrder"
				meta.Destination = "viewRelabelOrder"
				
				meta.spInsert = "proc_viewRelabelOrderInsert"
				meta.spUpdate = "proc_viewRelabelOrderUpdate"
				meta.spDelete = "proc_viewRelabelOrderDelete"
				meta.spLoadAll = "proc_viewRelabelOrderLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewRelabelOrderLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewRelabelOrderMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
