'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/8/2016 10:43:40 AM
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
	MustInherit Public Class esViewWOEmailRelabelInventoryCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewWOEmailRelabelInventoryCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewWOEmailRelabelInventoryQuery)
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
            Me.InitQuery(CType(query, esViewWOEmailRelabelInventoryQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewWOEmailRelabelInventory) As ViewWOEmailRelabelInventory
			Return CType(MyBase.DetachEntity(entity), ViewWOEmailRelabelInventory)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewWOEmailRelabelInventory) As ViewWOEmailRelabelInventory
			Return CType(MyBase.AttachEntity(entity), ViewWOEmailRelabelInventory)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewWOEmailRelabelInventoryCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewWOEmailRelabelInventory
            Get
                Return TryCast(MyBase.Item(index), ViewWOEmailRelabelInventory)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewWOEmailRelabelInventory)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewWOEmailRelabelInventory	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewWOEmailRelabelInventoryQuery
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
												
						Case "Rlblproductid"
							Me.str.Rlblproductid = CType(value, string)
												
						Case "Qavail"
							Me.str.Qavail = CType(value, string)
												
						Case "Qpend"
							Me.str.Qpend = CType(value, string)
												
						Case "Qtest"
							Me.str.Qtest = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Workordernumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Workordernumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Rlblproductid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Rlblproductid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Qavail"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Qavail = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Qpend"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Qpend = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Qtest"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Qtest = CType(value, Nullable(Of System.Int32))
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
		' Maps to viewWOEmailRelabelInventory.WORKORDERNUMBER
		' </summary>
		Public Overridable Property Workordernumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewWOEmailRelabelInventoryMetadata.ColumnNames.Workordernumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewWOEmailRelabelInventoryMetadata.ColumnNames.Workordernumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWOEmailRelabelInventory.RLBLPRODUCTID
		' </summary>
		Public Overridable Property Rlblproductid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewWOEmailRelabelInventoryMetadata.ColumnNames.Rlblproductid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewWOEmailRelabelInventoryMetadata.ColumnNames.Rlblproductid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWOEmailRelabelInventory.QAVAIL
		' </summary>
		Public Overridable Property Qavail As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewWOEmailRelabelInventoryMetadata.ColumnNames.Qavail)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewWOEmailRelabelInventoryMetadata.ColumnNames.Qavail, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWOEmailRelabelInventory.QPEND
		' </summary>
		Public Overridable Property Qpend As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewWOEmailRelabelInventoryMetadata.ColumnNames.Qpend)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewWOEmailRelabelInventoryMetadata.ColumnNames.Qpend, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWOEmailRelabelInventory.QTEST
		' </summary>
		Public Overridable Property Qtest As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewWOEmailRelabelInventoryMetadata.ColumnNames.Qtest)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewWOEmailRelabelInventoryMetadata.ColumnNames.Qtest, value)
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
		
			Public Sub New(ByVal entity As esViewWOEmailRelabelInventory)
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
		  	
			Public Property Rlblproductid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Rlblproductid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Rlblproductid = Nothing
					Else
						entity.Rlblproductid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Qavail As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Qavail
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qavail = Nothing
					Else
						entity.Qavail = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Qpend As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Qpend
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qpend = Nothing
					Else
						entity.Qpend = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Qtest As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Qtest
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qtest = Nothing
					Else
						entity.Qtest = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewWOEmailRelabelInventory
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewWOEmailRelabelInventoryQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewWOEmailRelabelInventory can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewWOEmailRelabelInventoryQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewWOEmailRelabelInventoryMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Workordernumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWOEmailRelabelInventoryMetadata.ColumnNames.Workordernumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Rlblproductid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWOEmailRelabelInventoryMetadata.ColumnNames.Rlblproductid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Qavail As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWOEmailRelabelInventoryMetadata.ColumnNames.Qavail, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Qpend As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWOEmailRelabelInventoryMetadata.ColumnNames.Qpend, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Qtest As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWOEmailRelabelInventoryMetadata.ColumnNames.Qtest, esSystemType.Int32)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewWOEmailRelabelInventoryCollection")> _
	Partial Public Class ViewWOEmailRelabelInventoryCollection
		Inherits esViewWOEmailRelabelInventoryCollection
		Implements IEnumerable(Of ViewWOEmailRelabelInventory)
		
        Public Shared Widening Operator CType(ByVal coll As ViewWOEmailRelabelInventoryCollection) As List(Of ViewWOEmailRelabelInventory)
            Dim list As List(Of ViewWOEmailRelabelInventory) = New List(Of ViewWOEmailRelabelInventory)
            Dim emp As ViewWOEmailRelabelInventory

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewWOEmailRelabelInventoryMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewWOEmailRelabelInventoryQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewWOEmailRelabelInventory(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewWOEmailRelabelInventory()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewWOEmailRelabelInventoryQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewWOEmailRelabelInventoryQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewWOEmailRelabelInventoryQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewWOEmailRelabelInventory 
			Return CType(MyBase.AddNewEntity(), ViewWOEmailRelabelInventory)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewWOEmailRelabelInventory) Implements IEnumerable(Of ViewWOEmailRelabelInventory).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewWOEmailRelabelInventory)(Me)
        End Function
		
		Private _query As ViewWOEmailRelabelInventoryQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewWOEmailRelabelInventory' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewWOEmailRelabelInventory ()")> _
	<Serializable> _
	Partial Public Class ViewWOEmailRelabelInventory 
		Inherits esViewWOEmailRelabelInventory

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewWOEmailRelabelInventoryMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewWOEmailRelabelInventoryQuery

			If Me._query Is Nothing Then
				Me._query = New ViewWOEmailRelabelInventoryQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewWOEmailRelabelInventoryQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewWOEmailRelabelInventoryQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewWOEmailRelabelInventoryQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewWOEmailRelabelInventoryQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewWOEmailRelabelInventoryQuery
		inherits esViewWOEmailRelabelInventoryQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewWOEmailRelabelInventoryQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewWOEmailRelabelInventoryMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewWOEmailRelabelInventoryMetadata.ColumnNames.Workordernumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewWOEmailRelabelInventoryMetadata.PropertyNames.Workordernumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWOEmailRelabelInventoryMetadata.ColumnNames.Rlblproductid, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewWOEmailRelabelInventoryMetadata.PropertyNames.Rlblproductid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWOEmailRelabelInventoryMetadata.ColumnNames.Qavail, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewWOEmailRelabelInventoryMetadata.PropertyNames.Qavail
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWOEmailRelabelInventoryMetadata.ColumnNames.Qpend, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewWOEmailRelabelInventoryMetadata.PropertyNames.Qpend
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWOEmailRelabelInventoryMetadata.ColumnNames.Qtest, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewWOEmailRelabelInventoryMetadata.PropertyNames.Qtest
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewWOEmailRelabelInventoryMetadata
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
			 Public Const Rlblproductid As String = "RLBLPRODUCTID"
			 Public Const Qavail As String = "QAVAIL"
			 Public Const Qpend As String = "QPEND"
			 Public Const Qtest As String = "QTEST"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Workordernumber As String = "Workordernumber"
			 Public Const Rlblproductid As String = "Rlblproductid"
			 Public Const Qavail As String = "Qavail"
			 Public Const Qpend As String = "Qpend"
			 Public Const Qtest As String = "Qtest"
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
            SyncLock GetType(ViewWOEmailRelabelInventoryMetadata)
			
				If ViewWOEmailRelabelInventoryMetadata.mapDelegates Is Nothing Then
					ViewWOEmailRelabelInventoryMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewWOEmailRelabelInventoryMetadata._meta Is Nothing Then
                    ViewWOEmailRelabelInventoryMetadata._meta = New ViewWOEmailRelabelInventoryMetadata()
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
				meta.AddTypeMap("Rlblproductid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Qavail", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Qpend", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Qtest", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "viewWOEmailRelabelInventory"
				meta.Destination = "viewWOEmailRelabelInventory"
				
				meta.spInsert = "proc_viewWOEmailRelabelInventoryInsert"
				meta.spUpdate = "proc_viewWOEmailRelabelInventoryUpdate"
				meta.spDelete = "proc_viewWOEmailRelabelInventoryDelete"
				meta.spLoadAll = "proc_viewWOEmailRelabelInventoryLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewWOEmailRelabelInventoryLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewWOEmailRelabelInventoryMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
