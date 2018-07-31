'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 5/12/2015 2:08:59 PM
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
	MustInherit Public Class esViewRelabelOrderItemCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewRelabelOrderItemCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewRelabelOrderItemQuery)
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
            Me.InitQuery(CType(query, esViewRelabelOrderItemQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewRelabelOrderItem) As ViewRelabelOrderItem
			Return CType(MyBase.DetachEntity(entity), ViewRelabelOrderItem)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewRelabelOrderItem) As ViewRelabelOrderItem
			Return CType(MyBase.AttachEntity(entity), ViewRelabelOrderItem)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewRelabelOrderItemCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewRelabelOrderItem
            Get
                Return TryCast(MyBase.Item(index), ViewRelabelOrderItem)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewRelabelOrderItem)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewRelabelOrderItem	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewRelabelOrderItemQuery
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
												
						Case "Itemid"
							Me.str.Itemid = CType(value, string)
												
						Case "Itemdesc"
							Me.str.Itemdesc = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "Invitemnum"
							Me.str.Invitemnum = CType(value, string)
												
						Case "Workorderitemnumber"
							Me.str.Workorderitemnumber = CType(value, string)
												
						Case "Sourcetype"
							Me.str.Sourcetype = CType(value, string)
												
						Case "Sourcedoc"
							Me.str.Sourcedoc = CType(value, string)
												
						Case "Relabelorderitemstatus"
							Me.str.Relabelorderitemstatus = CType(value, string)
												
						Case "Relabelorderitemnumber"
							Me.str.Relabelorderitemnumber = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Relabelordernumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Relabelordernumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Itemid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Itemid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Invitemnum"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Invitemnum = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Workorderitemnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Workorderitemnumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Sourcedoc"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Sourcedoc = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Relabelorderitemnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Relabelorderitemnumber = CType(value, Nullable(Of System.Int32))
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
		' Maps to viewRelabelOrderItem.RELABELORDERNUMBER
		' </summary>
		Public Overridable Property Relabelordernumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRelabelOrderItemMetadata.ColumnNames.Relabelordernumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRelabelOrderItemMetadata.ColumnNames.Relabelordernumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRelabelOrderItem.ITEMID
		' </summary>
		Public Overridable Property Itemid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRelabelOrderItemMetadata.ColumnNames.Itemid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRelabelOrderItemMetadata.ColumnNames.Itemid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRelabelOrderItem.ITEMDESC
		' </summary>
		Public Overridable Property Itemdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewRelabelOrderItemMetadata.ColumnNames.Itemdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRelabelOrderItemMetadata.ColumnNames.Itemdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRelabelOrderItem.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewRelabelOrderItemMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRelabelOrderItemMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRelabelOrderItem.INVITEMNUM
		' </summary>
		Public Overridable Property Invitemnum As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRelabelOrderItemMetadata.ColumnNames.Invitemnum)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRelabelOrderItemMetadata.ColumnNames.Invitemnum, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRelabelOrderItem.WORKORDERITEMNUMBER
		' </summary>
		Public Overridable Property Workorderitemnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRelabelOrderItemMetadata.ColumnNames.Workorderitemnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRelabelOrderItemMetadata.ColumnNames.Workorderitemnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRelabelOrderItem.SOURCETYPE
		' </summary>
		Public Overridable Property Sourcetype As System.String
			Get
				Return MyBase.GetSystemString(ViewRelabelOrderItemMetadata.ColumnNames.Sourcetype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRelabelOrderItemMetadata.ColumnNames.Sourcetype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRelabelOrderItem.SOURCEDOC
		' </summary>
		Public Overridable Property Sourcedoc As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRelabelOrderItemMetadata.ColumnNames.Sourcedoc)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRelabelOrderItemMetadata.ColumnNames.Sourcedoc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRelabelOrderItem.RELABELORDERITEMSTATUS
		' </summary>
		Public Overridable Property Relabelorderitemstatus As System.String
			Get
				Return MyBase.GetSystemString(ViewRelabelOrderItemMetadata.ColumnNames.Relabelorderitemstatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRelabelOrderItemMetadata.ColumnNames.Relabelorderitemstatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRelabelOrderItem.RELABELORDERITEMNUMBER
		' </summary>
		Public Overridable Property Relabelorderitemnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRelabelOrderItemMetadata.ColumnNames.Relabelorderitemnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRelabelOrderItemMetadata.ColumnNames.Relabelorderitemnumber, value)
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
		
			Public Sub New(ByVal entity As esViewRelabelOrderItem)
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
		  	
			Public Property Invitemnum As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Invitemnum
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Invitemnum = Nothing
					Else
						entity.Invitemnum = Convert.ToInt32(Value)
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
		  	
			Public Property Sourcedoc As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Sourcedoc
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Sourcedoc = Nothing
					Else
						entity.Sourcedoc = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Relabelorderitemstatus As System.String 
				Get
					Dim data_ As System.String = entity.Relabelorderitemstatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Relabelorderitemstatus = Nothing
					Else
						entity.Relabelorderitemstatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Relabelorderitemnumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Relabelorderitemnumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Relabelorderitemnumber = Nothing
					Else
						entity.Relabelorderitemnumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewRelabelOrderItem
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewRelabelOrderItemQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewRelabelOrderItem can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewRelabelOrderItemQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRelabelOrderItemMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Relabelordernumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRelabelOrderItemMetadata.ColumnNames.Relabelordernumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Itemid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRelabelOrderItemMetadata.ColumnNames.Itemid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Itemdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRelabelOrderItemMetadata.ColumnNames.Itemdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRelabelOrderItemMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Invitemnum As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRelabelOrderItemMetadata.ColumnNames.Invitemnum, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Workorderitemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRelabelOrderItemMetadata.ColumnNames.Workorderitemnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Sourcetype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRelabelOrderItemMetadata.ColumnNames.Sourcetype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Sourcedoc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRelabelOrderItemMetadata.ColumnNames.Sourcedoc, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Relabelorderitemstatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRelabelOrderItemMetadata.ColumnNames.Relabelorderitemstatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Relabelorderitemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRelabelOrderItemMetadata.ColumnNames.Relabelorderitemnumber, esSystemType.Int32)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewRelabelOrderItemCollection")> _
	Partial Public Class ViewRelabelOrderItemCollection
		Inherits esViewRelabelOrderItemCollection
		Implements IEnumerable(Of ViewRelabelOrderItem)
		
        Public Shared Widening Operator CType(ByVal coll As ViewRelabelOrderItemCollection) As List(Of ViewRelabelOrderItem)
            Dim list As List(Of ViewRelabelOrderItem) = New List(Of ViewRelabelOrderItem)
            Dim emp As ViewRelabelOrderItem

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRelabelOrderItemMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewRelabelOrderItemQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewRelabelOrderItem(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewRelabelOrderItem()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewRelabelOrderItemQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewRelabelOrderItemQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRelabelOrderItemQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewRelabelOrderItem 
			Return CType(MyBase.AddNewEntity(), ViewRelabelOrderItem)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewRelabelOrderItem) Implements IEnumerable(Of ViewRelabelOrderItem).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewRelabelOrderItem)(Me)
        End Function
		
		Private _query As ViewRelabelOrderItemQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewRelabelOrderItem' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewRelabelOrderItem ()")> _
	<Serializable> _
	Partial Public Class ViewRelabelOrderItem 
		Inherits esViewRelabelOrderItem

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewRelabelOrderItemMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewRelabelOrderItemQuery

			If Me._query Is Nothing Then
				Me._query = New ViewRelabelOrderItemQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewRelabelOrderItemQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewRelabelOrderItemQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRelabelOrderItemQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewRelabelOrderItemQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewRelabelOrderItemQuery
		inherits esViewRelabelOrderItemQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewRelabelOrderItemQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewRelabelOrderItemMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewRelabelOrderItemMetadata.ColumnNames.Relabelordernumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRelabelOrderItemMetadata.PropertyNames.Relabelordernumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRelabelOrderItemMetadata.ColumnNames.Itemid, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRelabelOrderItemMetadata.PropertyNames.Itemid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRelabelOrderItemMetadata.ColumnNames.Itemdesc, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRelabelOrderItemMetadata.PropertyNames.Itemdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRelabelOrderItemMetadata.ColumnNames.Container, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRelabelOrderItemMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRelabelOrderItemMetadata.ColumnNames.Invitemnum, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRelabelOrderItemMetadata.PropertyNames.Invitemnum
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRelabelOrderItemMetadata.ColumnNames.Workorderitemnumber, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRelabelOrderItemMetadata.PropertyNames.Workorderitemnumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRelabelOrderItemMetadata.ColumnNames.Sourcetype, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRelabelOrderItemMetadata.PropertyNames.Sourcetype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRelabelOrderItemMetadata.ColumnNames.Sourcedoc, 7, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRelabelOrderItemMetadata.PropertyNames.Sourcedoc
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRelabelOrderItemMetadata.ColumnNames.Relabelorderitemstatus, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRelabelOrderItemMetadata.PropertyNames.Relabelorderitemstatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRelabelOrderItemMetadata.ColumnNames.Relabelorderitemnumber, 9, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRelabelOrderItemMetadata.PropertyNames.Relabelorderitemnumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewRelabelOrderItemMetadata
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
			 Public Const Itemid As String = "ITEMID"
			 Public Const Itemdesc As String = "ITEMDESC"
			 Public Const Container As String = "CONTAINER"
			 Public Const Invitemnum As String = "INVITEMNUM"
			 Public Const Workorderitemnumber As String = "WORKORDERITEMNUMBER"
			 Public Const Sourcetype As String = "SOURCETYPE"
			 Public Const Sourcedoc As String = "SOURCEDOC"
			 Public Const Relabelorderitemstatus As String = "RELABELORDERITEMSTATUS"
			 Public Const Relabelorderitemnumber As String = "RELABELORDERITEMNUMBER"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Relabelordernumber As String = "Relabelordernumber"
			 Public Const Itemid As String = "Itemid"
			 Public Const Itemdesc As String = "Itemdesc"
			 Public Const Container As String = "Container"
			 Public Const Invitemnum As String = "Invitemnum"
			 Public Const Workorderitemnumber As String = "Workorderitemnumber"
			 Public Const Sourcetype As String = "Sourcetype"
			 Public Const Sourcedoc As String = "Sourcedoc"
			 Public Const Relabelorderitemstatus As String = "Relabelorderitemstatus"
			 Public Const Relabelorderitemnumber As String = "Relabelorderitemnumber"
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
            SyncLock GetType(ViewRelabelOrderItemMetadata)
			
				If ViewRelabelOrderItemMetadata.mapDelegates Is Nothing Then
					ViewRelabelOrderItemMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewRelabelOrderItemMetadata._meta Is Nothing Then
                    ViewRelabelOrderItemMetadata._meta = New ViewRelabelOrderItemMetadata()
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
				meta.AddTypeMap("Itemid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Itemdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Invitemnum", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Workorderitemnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Sourcetype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Sourcedoc", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Relabelorderitemstatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Relabelorderitemnumber", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "viewRelabelOrderItem"
				meta.Destination = "viewRelabelOrderItem"
				
				meta.spInsert = "proc_viewRelabelOrderItemInsert"
				meta.spUpdate = "proc_viewRelabelOrderItemUpdate"
				meta.spDelete = "proc_viewRelabelOrderItemDelete"
				meta.spLoadAll = "proc_viewRelabelOrderItemLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewRelabelOrderItemLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewRelabelOrderItemMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
