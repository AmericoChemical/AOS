'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 5/14/2015 10:55:06 AM
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
	MustInherit Public Class esViewInvItemsFromRelabeledItemsCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewInvItemsFromRelabeledItemsCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewInvItemsFromRelabeledItemsQuery)
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
            Me.InitQuery(CType(query, esViewInvItemsFromRelabeledItemsQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewInvItemsFromRelabeledItems) As ViewInvItemsFromRelabeledItems
			Return CType(MyBase.DetachEntity(entity), ViewInvItemsFromRelabeledItems)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewInvItemsFromRelabeledItems) As ViewInvItemsFromRelabeledItems
			Return CType(MyBase.AttachEntity(entity), ViewInvItemsFromRelabeledItems)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewInvItemsFromRelabeledItemsCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewInvItemsFromRelabeledItems
            Get
                Return TryCast(MyBase.Item(index), ViewInvItemsFromRelabeledItems)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewInvItemsFromRelabeledItems)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewInvItemsFromRelabeledItems	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewInvItemsFromRelabeledItemsQuery
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
												
						Case "Invitemnumber"
							Me.str.Invitemnumber = CType(value, string)
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Productdesc"
							Me.str.Productdesc = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "Lotnumber"
							Me.str.Lotnumber = CType(value, string)
												
						Case "Receiveddate"
							Me.str.Receiveddate = CType(value, string)
												
						Case "Workordernum"
							Me.str.Workordernum = CType(value, string)
												
						Case "Origitemnum"
							Me.str.Origitemnum = CType(value, string)
												
						Case "Allocateddocument"
							Me.str.Allocateddocument = CType(value, string)
												
						Case "Allocatedtype"
							Me.str.Allocatedtype = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Invitemnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Invitemnumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Receiveddate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Receiveddate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Origitemnum"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Origitemnum = CType(value, Nullable(Of System.Int32))
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
		' Maps to viewInvItemsFromRelabeledItems.INVITEMNUMBER
		' </summary>
		Public Overridable Property Invitemnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewInvItemsFromRelabeledItemsMetadata.ColumnNames.Invitemnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewInvItemsFromRelabeledItemsMetadata.ColumnNames.Invitemnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemsFromRelabeledItems.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewInvItemsFromRelabeledItemsMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewInvItemsFromRelabeledItemsMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemsFromRelabeledItems.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewInvItemsFromRelabeledItemsMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewInvItemsFromRelabeledItemsMetadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemsFromRelabeledItems.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewInvItemsFromRelabeledItemsMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewInvItemsFromRelabeledItemsMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemsFromRelabeledItems.LOTNUMBER
		' </summary>
		Public Overridable Property Lotnumber As System.String
			Get
				Return MyBase.GetSystemString(ViewInvItemsFromRelabeledItemsMetadata.ColumnNames.Lotnumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewInvItemsFromRelabeledItemsMetadata.ColumnNames.Lotnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemsFromRelabeledItems.RECEIVEDDATE
		' </summary>
		Public Overridable Property Receiveddate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewInvItemsFromRelabeledItemsMetadata.ColumnNames.Receiveddate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewInvItemsFromRelabeledItemsMetadata.ColumnNames.Receiveddate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemsFromRelabeledItems.WORKORDERNUM
		' </summary>
		Public Overridable Property Workordernum As System.String
			Get
				Return MyBase.GetSystemString(ViewInvItemsFromRelabeledItemsMetadata.ColumnNames.Workordernum)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewInvItemsFromRelabeledItemsMetadata.ColumnNames.Workordernum, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemsFromRelabeledItems.ORIGITEMNUM
		' </summary>
		Public Overridable Property Origitemnum As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewInvItemsFromRelabeledItemsMetadata.ColumnNames.Origitemnum)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewInvItemsFromRelabeledItemsMetadata.ColumnNames.Origitemnum, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemsFromRelabeledItems.ALLOCATEDDOCUMENT
		' </summary>
		Public Overridable Property Allocateddocument As System.String
			Get
				Return MyBase.GetSystemString(ViewInvItemsFromRelabeledItemsMetadata.ColumnNames.Allocateddocument)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewInvItemsFromRelabeledItemsMetadata.ColumnNames.Allocateddocument, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemsFromRelabeledItems.ALLOCATEDTYPE
		' </summary>
		Public Overridable Property Allocatedtype As System.String
			Get
				Return MyBase.GetSystemString(ViewInvItemsFromRelabeledItemsMetadata.ColumnNames.Allocatedtype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewInvItemsFromRelabeledItemsMetadata.ColumnNames.Allocatedtype, value)
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
		
			Public Sub New(ByVal entity As esViewInvItemsFromRelabeledItems)
				Me.entity = entity
			End Sub				
		
	
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
		  	
			Public Property Lotnumber As System.String 
				Get
					Dim data_ As System.String = entity.Lotnumber
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Lotnumber = Nothing
					Else
						entity.Lotnumber = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Receiveddate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Receiveddate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Receiveddate = Nothing
					Else
						entity.Receiveddate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Workordernum As System.String 
				Get
					Dim data_ As System.String = entity.Workordernum
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Workordernum = Nothing
					Else
						entity.Workordernum = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Origitemnum As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Origitemnum
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Origitemnum = Nothing
					Else
						entity.Origitemnum = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Allocateddocument As System.String 
				Get
					Dim data_ As System.String = entity.Allocateddocument
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Allocateddocument = Nothing
					Else
						entity.Allocateddocument = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Allocatedtype As System.String 
				Get
					Dim data_ As System.String = entity.Allocatedtype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Allocatedtype = Nothing
					Else
						entity.Allocatedtype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewInvItemsFromRelabeledItems
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewInvItemsFromRelabeledItemsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewInvItemsFromRelabeledItems can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewInvItemsFromRelabeledItemsQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewInvItemsFromRelabeledItemsMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Invitemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemsFromRelabeledItemsMetadata.ColumnNames.Invitemnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemsFromRelabeledItemsMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemsFromRelabeledItemsMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemsFromRelabeledItemsMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Lotnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemsFromRelabeledItemsMetadata.ColumnNames.Lotnumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Receiveddate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemsFromRelabeledItemsMetadata.ColumnNames.Receiveddate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Workordernum As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemsFromRelabeledItemsMetadata.ColumnNames.Workordernum, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Origitemnum As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemsFromRelabeledItemsMetadata.ColumnNames.Origitemnum, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Allocateddocument As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemsFromRelabeledItemsMetadata.ColumnNames.Allocateddocument, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Allocatedtype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemsFromRelabeledItemsMetadata.ColumnNames.Allocatedtype, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewInvItemsFromRelabeledItemsCollection")> _
	Partial Public Class ViewInvItemsFromRelabeledItemsCollection
		Inherits esViewInvItemsFromRelabeledItemsCollection
		Implements IEnumerable(Of ViewInvItemsFromRelabeledItems)
		
        Public Shared Widening Operator CType(ByVal coll As ViewInvItemsFromRelabeledItemsCollection) As List(Of ViewInvItemsFromRelabeledItems)
            Dim list As List(Of ViewInvItemsFromRelabeledItems) = New List(Of ViewInvItemsFromRelabeledItems)
            Dim emp As ViewInvItemsFromRelabeledItems

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewInvItemsFromRelabeledItemsMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewInvItemsFromRelabeledItemsQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewInvItemsFromRelabeledItems(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewInvItemsFromRelabeledItems()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewInvItemsFromRelabeledItemsQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewInvItemsFromRelabeledItemsQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewInvItemsFromRelabeledItemsQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewInvItemsFromRelabeledItems 
			Return CType(MyBase.AddNewEntity(), ViewInvItemsFromRelabeledItems)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewInvItemsFromRelabeledItems) Implements IEnumerable(Of ViewInvItemsFromRelabeledItems).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewInvItemsFromRelabeledItems)(Me)
        End Function
		
		Private _query As ViewInvItemsFromRelabeledItemsQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewInvItemsFromRelabeledItems' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewInvItemsFromRelabeledItems ()")> _
	<Serializable> _
	Partial Public Class ViewInvItemsFromRelabeledItems 
		Inherits esViewInvItemsFromRelabeledItems

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewInvItemsFromRelabeledItemsMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewInvItemsFromRelabeledItemsQuery

			If Me._query Is Nothing Then
				Me._query = New ViewInvItemsFromRelabeledItemsQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewInvItemsFromRelabeledItemsQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewInvItemsFromRelabeledItemsQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewInvItemsFromRelabeledItemsQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewInvItemsFromRelabeledItemsQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewInvItemsFromRelabeledItemsQuery
		inherits esViewInvItemsFromRelabeledItemsQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewInvItemsFromRelabeledItemsQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewInvItemsFromRelabeledItemsMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewInvItemsFromRelabeledItemsMetadata.ColumnNames.Invitemnumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewInvItemsFromRelabeledItemsMetadata.PropertyNames.Invitemnumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemsFromRelabeledItemsMetadata.ColumnNames.Productid, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewInvItemsFromRelabeledItemsMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemsFromRelabeledItemsMetadata.ColumnNames.Productdesc, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewInvItemsFromRelabeledItemsMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemsFromRelabeledItemsMetadata.ColumnNames.Container, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewInvItemsFromRelabeledItemsMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemsFromRelabeledItemsMetadata.ColumnNames.Lotnumber, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewInvItemsFromRelabeledItemsMetadata.PropertyNames.Lotnumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemsFromRelabeledItemsMetadata.ColumnNames.Receiveddate, 5, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewInvItemsFromRelabeledItemsMetadata.PropertyNames.Receiveddate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemsFromRelabeledItemsMetadata.ColumnNames.Workordernum, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewInvItemsFromRelabeledItemsMetadata.PropertyNames.Workordernum
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemsFromRelabeledItemsMetadata.ColumnNames.Origitemnum, 7, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewInvItemsFromRelabeledItemsMetadata.PropertyNames.Origitemnum
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemsFromRelabeledItemsMetadata.ColumnNames.Allocateddocument, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewInvItemsFromRelabeledItemsMetadata.PropertyNames.Allocateddocument
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemsFromRelabeledItemsMetadata.ColumnNames.Allocatedtype, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewInvItemsFromRelabeledItemsMetadata.PropertyNames.Allocatedtype
			c.CharacterMaxLength = 15
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewInvItemsFromRelabeledItemsMetadata
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
			 Public Const Invitemnumber As String = "INVITEMNUMBER"
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Productdesc As String = "PRODUCTDESC"
			 Public Const Container As String = "CONTAINER"
			 Public Const Lotnumber As String = "LOTNUMBER"
			 Public Const Receiveddate As String = "RECEIVEDDATE"
			 Public Const Workordernum As String = "WORKORDERNUM"
			 Public Const Origitemnum As String = "ORIGITEMNUM"
			 Public Const Allocateddocument As String = "ALLOCATEDDOCUMENT"
			 Public Const Allocatedtype As String = "ALLOCATEDTYPE"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Invitemnumber As String = "Invitemnumber"
			 Public Const Productid As String = "Productid"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const Container As String = "Container"
			 Public Const Lotnumber As String = "Lotnumber"
			 Public Const Receiveddate As String = "Receiveddate"
			 Public Const Workordernum As String = "Workordernum"
			 Public Const Origitemnum As String = "Origitemnum"
			 Public Const Allocateddocument As String = "Allocateddocument"
			 Public Const Allocatedtype As String = "Allocatedtype"
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
            SyncLock GetType(ViewInvItemsFromRelabeledItemsMetadata)
			
				If ViewInvItemsFromRelabeledItemsMetadata.mapDelegates Is Nothing Then
					ViewInvItemsFromRelabeledItemsMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewInvItemsFromRelabeledItemsMetadata._meta Is Nothing Then
                    ViewInvItemsFromRelabeledItemsMetadata._meta = New ViewInvItemsFromRelabeledItemsMetadata()
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
				

				meta.AddTypeMap("Invitemnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Lotnumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Receiveddate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Workordernum", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Origitemnum", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Allocateddocument", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Allocatedtype", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewInvItemsFromRelabeledItems"
				meta.Destination = "viewInvItemsFromRelabeledItems"
				
				meta.spInsert = "proc_viewInvItemsFromRelabeledItemsInsert"
				meta.spUpdate = "proc_viewInvItemsFromRelabeledItemsUpdate"
				meta.spDelete = "proc_viewInvItemsFromRelabeledItemsDelete"
				meta.spLoadAll = "proc_viewInvItemsFromRelabeledItemsLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewInvItemsFromRelabeledItemsLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewInvItemsFromRelabeledItemsMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
