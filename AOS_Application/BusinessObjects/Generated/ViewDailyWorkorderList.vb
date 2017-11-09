'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 11/3/2017 1:07:00 PM
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
	MustInherit Public Class esViewDailyWorkorderListCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewDailyWorkorderListCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewDailyWorkorderListQuery)
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
            Me.InitQuery(CType(query, esViewDailyWorkorderListQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewDailyWorkorderList) As ViewDailyWorkorderList
			Return CType(MyBase.DetachEntity(entity), ViewDailyWorkorderList)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewDailyWorkorderList) As ViewDailyWorkorderList
			Return CType(MyBase.AttachEntity(entity), ViewDailyWorkorderList)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewDailyWorkorderListCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewDailyWorkorderList
            Get
                Return TryCast(MyBase.Item(index), ViewDailyWorkorderList)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewDailyWorkorderList)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewDailyWorkorderList	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewDailyWorkorderListQuery
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
												
						Case "Custname"
							Me.str.Custname = CType(value, string)
												
						Case "Deliverydate"
							Me.str.Deliverydate = CType(value, string)
												
						Case "Totalqty"
							Me.str.Totalqty = CType(value, string)
												
						Case "Itemid"
							Me.str.Itemid = CType(value, string)
												
						Case "Itemdescription"
							Me.str.Itemdescription = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Workordernumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Workordernumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Workorderdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Workorderdate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Deliverydate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Deliverydate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Totalqty"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Totalqty = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Itemid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Itemid = CType(value, Nullable(Of System.Int32))
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
		' Maps to viewDailyWorkorderList.WORKORDERNUMBER
		' </summary>
		Public Overridable Property Workordernumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewDailyWorkorderListMetadata.ColumnNames.Workordernumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewDailyWorkorderListMetadata.ColumnNames.Workordernumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewDailyWorkorderList.WORKORDERDATE
		' </summary>
		Public Overridable Property Workorderdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewDailyWorkorderListMetadata.ColumnNames.Workorderdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewDailyWorkorderListMetadata.ColumnNames.Workorderdate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewDailyWorkorderList.CUSTNAME
		' </summary>
		Public Overridable Property Custname As System.String
			Get
				Return MyBase.GetSystemString(ViewDailyWorkorderListMetadata.ColumnNames.Custname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewDailyWorkorderListMetadata.ColumnNames.Custname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewDailyWorkorderList.DELIVERYDATE
		' </summary>
		Public Overridable Property Deliverydate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewDailyWorkorderListMetadata.ColumnNames.Deliverydate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewDailyWorkorderListMetadata.ColumnNames.Deliverydate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewDailyWorkorderList.TOTALQTY
		' </summary>
		Public Overridable Property Totalqty As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewDailyWorkorderListMetadata.ColumnNames.Totalqty)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewDailyWorkorderListMetadata.ColumnNames.Totalqty, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewDailyWorkorderList.ITEMID
		' </summary>
		Public Overridable Property Itemid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewDailyWorkorderListMetadata.ColumnNames.Itemid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewDailyWorkorderListMetadata.ColumnNames.Itemid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewDailyWorkorderList.ITEMDESCRIPTION
		' </summary>
		Public Overridable Property Itemdescription As System.String
			Get
				Return MyBase.GetSystemString(ViewDailyWorkorderListMetadata.ColumnNames.Itemdescription)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewDailyWorkorderListMetadata.ColumnNames.Itemdescription, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewDailyWorkorderList.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewDailyWorkorderListMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewDailyWorkorderListMetadata.ColumnNames.Container, value)
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
		
			Public Sub New(ByVal entity As esViewDailyWorkorderList)
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
		  	
			Public Property Totalqty As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Totalqty
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Totalqty = Nothing
					Else
						entity.Totalqty = Convert.ToDecimal(Value)
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
		  

			Private entity As esViewDailyWorkorderList
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewDailyWorkorderListQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewDailyWorkorderList can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewDailyWorkorderListQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewDailyWorkorderListMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Workordernumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewDailyWorkorderListMetadata.ColumnNames.Workordernumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Workorderdate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewDailyWorkorderListMetadata.ColumnNames.Workorderdate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Custname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewDailyWorkorderListMetadata.ColumnNames.Custname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Deliverydate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewDailyWorkorderListMetadata.ColumnNames.Deliverydate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Totalqty As esQueryItem
			Get
				Return New esQueryItem(Me, ViewDailyWorkorderListMetadata.ColumnNames.Totalqty, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Itemid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewDailyWorkorderListMetadata.ColumnNames.Itemid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Itemdescription As esQueryItem
			Get
				Return New esQueryItem(Me, ViewDailyWorkorderListMetadata.ColumnNames.Itemdescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewDailyWorkorderListMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewDailyWorkorderListCollection")> _
	Partial Public Class ViewDailyWorkorderListCollection
		Inherits esViewDailyWorkorderListCollection
		Implements IEnumerable(Of ViewDailyWorkorderList)
		
        Public Shared Widening Operator CType(ByVal coll As ViewDailyWorkorderListCollection) As List(Of ViewDailyWorkorderList)
            Dim list As List(Of ViewDailyWorkorderList) = New List(Of ViewDailyWorkorderList)
            Dim emp As ViewDailyWorkorderList

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewDailyWorkorderListMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewDailyWorkorderListQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewDailyWorkorderList(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewDailyWorkorderList()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewDailyWorkorderListQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewDailyWorkorderListQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewDailyWorkorderListQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewDailyWorkorderList 
			Return CType(MyBase.AddNewEntity(), ViewDailyWorkorderList)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewDailyWorkorderList) Implements IEnumerable(Of ViewDailyWorkorderList).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewDailyWorkorderList)(Me)
        End Function
		
		Private _query As ViewDailyWorkorderListQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewDailyWorkorderList' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewDailyWorkorderList ()")> _
	<Serializable> _
	Partial Public Class ViewDailyWorkorderList 
		Inherits esViewDailyWorkorderList

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewDailyWorkorderListMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewDailyWorkorderListQuery

			If Me._query Is Nothing Then
				Me._query = New ViewDailyWorkorderListQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewDailyWorkorderListQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewDailyWorkorderListQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewDailyWorkorderListQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewDailyWorkorderListQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewDailyWorkorderListQuery
		inherits esViewDailyWorkorderListQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewDailyWorkorderListQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewDailyWorkorderListMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewDailyWorkorderListMetadata.ColumnNames.Workordernumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewDailyWorkorderListMetadata.PropertyNames.Workordernumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewDailyWorkorderListMetadata.ColumnNames.Workorderdate, 1, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewDailyWorkorderListMetadata.PropertyNames.Workorderdate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewDailyWorkorderListMetadata.ColumnNames.Custname, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewDailyWorkorderListMetadata.PropertyNames.Custname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewDailyWorkorderListMetadata.ColumnNames.Deliverydate, 3, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewDailyWorkorderListMetadata.PropertyNames.Deliverydate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewDailyWorkorderListMetadata.ColumnNames.Totalqty, 4, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewDailyWorkorderListMetadata.PropertyNames.Totalqty
			c.NumericPrecision = 38
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewDailyWorkorderListMetadata.ColumnNames.Itemid, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewDailyWorkorderListMetadata.PropertyNames.Itemid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewDailyWorkorderListMetadata.ColumnNames.Itemdescription, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewDailyWorkorderListMetadata.PropertyNames.Itemdescription
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewDailyWorkorderListMetadata.ColumnNames.Container, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewDailyWorkorderListMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewDailyWorkorderListMetadata
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
			 Public Const Custname As String = "CUSTNAME"
			 Public Const Deliverydate As String = "DELIVERYDATE"
			 Public Const Totalqty As String = "TOTALQTY"
			 Public Const Itemid As String = "ITEMID"
			 Public Const Itemdescription As String = "ITEMDESCRIPTION"
			 Public Const Container As String = "CONTAINER"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Workordernumber As String = "Workordernumber"
			 Public Const Workorderdate As String = "Workorderdate"
			 Public Const Custname As String = "Custname"
			 Public Const Deliverydate As String = "Deliverydate"
			 Public Const Totalqty As String = "Totalqty"
			 Public Const Itemid As String = "Itemid"
			 Public Const Itemdescription As String = "Itemdescription"
			 Public Const Container As String = "Container"
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
            SyncLock GetType(ViewDailyWorkorderListMetadata)
			
				If ViewDailyWorkorderListMetadata.mapDelegates Is Nothing Then
					ViewDailyWorkorderListMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewDailyWorkorderListMetadata._meta Is Nothing Then
                    ViewDailyWorkorderListMetadata._meta = New ViewDailyWorkorderListMetadata()
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
				meta.AddTypeMap("Workorderdate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Custname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Deliverydate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Totalqty", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Itemid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Itemdescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewDailyWorkorderList"
				meta.Destination = "viewDailyWorkorderList"
				
				meta.spInsert = "proc_viewDailyWorkorderListInsert"
				meta.spUpdate = "proc_viewDailyWorkorderListUpdate"
				meta.spDelete = "proc_viewDailyWorkorderListDelete"
				meta.spLoadAll = "proc_viewDailyWorkorderListLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewDailyWorkorderListLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewDailyWorkorderListMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
