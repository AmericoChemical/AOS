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
	MustInherit Public Class esViewWorkOrderItemsOnLoadCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewWorkOrderItemsOnLoadCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewWorkOrderItemsOnLoadQuery)
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
            Me.InitQuery(CType(query, esViewWorkOrderItemsOnLoadQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewWorkOrderItemsOnLoad) As ViewWorkOrderItemsOnLoad
			Return CType(MyBase.DetachEntity(entity), ViewWorkOrderItemsOnLoad)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewWorkOrderItemsOnLoad) As ViewWorkOrderItemsOnLoad
			Return CType(MyBase.AttachEntity(entity), ViewWorkOrderItemsOnLoad)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewWorkOrderItemsOnLoadCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewWorkOrderItemsOnLoad
            Get
                Return TryCast(MyBase.Item(index), ViewWorkOrderItemsOnLoad)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewWorkOrderItemsOnLoad)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewWorkOrderItemsOnLoad	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewWorkOrderItemsOnLoadQuery
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
												
						Case "LoadID"
							Me.str.LoadID = CType(value, string)
					
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
						
						Case "LoadID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.LoadID = CType(value, Nullable(Of System.Int32))
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
		' Maps to viewWorkOrderItemsOnLoad.WORKORDERITEMNUMBER
		' </summary>
		Public Overridable Property Workorderitemnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewWorkOrderItemsOnLoadMetadata.ColumnNames.Workorderitemnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewWorkOrderItemsOnLoadMetadata.ColumnNames.Workorderitemnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsOnLoad.WORKORDERNUMBER
		' </summary>
		Public Overridable Property Workordernumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewWorkOrderItemsOnLoadMetadata.ColumnNames.Workordernumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewWorkOrderItemsOnLoadMetadata.ColumnNames.Workordernumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderItemsOnLoad.LoadID
		' </summary>
		Public Overridable Property LoadID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewWorkOrderItemsOnLoadMetadata.ColumnNames.LoadID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewWorkOrderItemsOnLoadMetadata.ColumnNames.LoadID, value)
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
		
			Public Sub New(ByVal entity As esViewWorkOrderItemsOnLoad)
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
		  

			Private entity As esViewWorkOrderItemsOnLoad
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewWorkOrderItemsOnLoadQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewWorkOrderItemsOnLoad can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewWorkOrderItemsOnLoadQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewWorkOrderItemsOnLoadMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Workorderitemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsOnLoadMetadata.ColumnNames.Workorderitemnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Workordernumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsOnLoadMetadata.ColumnNames.Workordernumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LoadID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderItemsOnLoadMetadata.ColumnNames.LoadID, esSystemType.Int32)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewWorkOrderItemsOnLoadCollection")> _
	Partial Public Class ViewWorkOrderItemsOnLoadCollection
		Inherits esViewWorkOrderItemsOnLoadCollection
		Implements IEnumerable(Of ViewWorkOrderItemsOnLoad)
		
        Public Shared Widening Operator CType(ByVal coll As ViewWorkOrderItemsOnLoadCollection) As List(Of ViewWorkOrderItemsOnLoad)
            Dim list As List(Of ViewWorkOrderItemsOnLoad) = New List(Of ViewWorkOrderItemsOnLoad)
            Dim emp As ViewWorkOrderItemsOnLoad

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewWorkOrderItemsOnLoadMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewWorkOrderItemsOnLoadQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewWorkOrderItemsOnLoad(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewWorkOrderItemsOnLoad()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewWorkOrderItemsOnLoadQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewWorkOrderItemsOnLoadQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewWorkOrderItemsOnLoadQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewWorkOrderItemsOnLoad 
			Return CType(MyBase.AddNewEntity(), ViewWorkOrderItemsOnLoad)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewWorkOrderItemsOnLoad) Implements IEnumerable(Of ViewWorkOrderItemsOnLoad).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewWorkOrderItemsOnLoad)(Me)
        End Function
		
		Private _query As ViewWorkOrderItemsOnLoadQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewWorkOrderItemsOnLoad' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewWorkOrderItemsOnLoad ()")> _
	<Serializable> _
	Partial Public Class ViewWorkOrderItemsOnLoad 
		Inherits esViewWorkOrderItemsOnLoad

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewWorkOrderItemsOnLoadMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewWorkOrderItemsOnLoadQuery

			If Me._query Is Nothing Then
				Me._query = New ViewWorkOrderItemsOnLoadQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewWorkOrderItemsOnLoadQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewWorkOrderItemsOnLoadQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewWorkOrderItemsOnLoadQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewWorkOrderItemsOnLoadQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewWorkOrderItemsOnLoadQuery
		inherits esViewWorkOrderItemsOnLoadQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewWorkOrderItemsOnLoadQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewWorkOrderItemsOnLoadMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewWorkOrderItemsOnLoadMetadata.ColumnNames.Workorderitemnumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewWorkOrderItemsOnLoadMetadata.PropertyNames.Workorderitemnumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsOnLoadMetadata.ColumnNames.Workordernumber, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewWorkOrderItemsOnLoadMetadata.PropertyNames.Workordernumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderItemsOnLoadMetadata.ColumnNames.LoadID, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewWorkOrderItemsOnLoadMetadata.PropertyNames.LoadID
			c.NumericPrecision = 10
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewWorkOrderItemsOnLoadMetadata
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
			 Public Const LoadID As String = "LoadID"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Workorderitemnumber As String = "Workorderitemnumber"
			 Public Const Workordernumber As String = "Workordernumber"
			 Public Const LoadID As String = "LoadID"
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
            SyncLock GetType(ViewWorkOrderItemsOnLoadMetadata)
			
				If ViewWorkOrderItemsOnLoadMetadata.mapDelegates Is Nothing Then
					ViewWorkOrderItemsOnLoadMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewWorkOrderItemsOnLoadMetadata._meta Is Nothing Then
                    ViewWorkOrderItemsOnLoadMetadata._meta = New ViewWorkOrderItemsOnLoadMetadata()
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
				meta.AddTypeMap("LoadID", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "viewWorkOrderItemsOnLoad"
				meta.Destination = "viewWorkOrderItemsOnLoad"
				
				meta.spInsert = "proc_viewWorkOrderItemsOnLoadInsert"
				meta.spUpdate = "proc_viewWorkOrderItemsOnLoadUpdate"
				meta.spDelete = "proc_viewWorkOrderItemsOnLoadDelete"
				meta.spLoadAll = "proc_viewWorkOrderItemsOnLoadLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewWorkOrderItemsOnLoadLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewWorkOrderItemsOnLoadMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
