'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/11/2014 1:36:09 PM
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
	MustInherit Public Class esViewLoadWeightByContainerCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewLoadWeightByContainerCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewLoadWeightByContainerQuery)
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
            Me.InitQuery(CType(query, esViewLoadWeightByContainerQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewLoadWeightByContainer) As ViewLoadWeightByContainer
			Return CType(MyBase.DetachEntity(entity), ViewLoadWeightByContainer)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewLoadWeightByContainer) As ViewLoadWeightByContainer
			Return CType(MyBase.AttachEntity(entity), ViewLoadWeightByContainer)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewLoadWeightByContainerCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewLoadWeightByContainer
            Get
                Return TryCast(MyBase.Item(index), ViewLoadWeightByContainer)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewLoadWeightByContainer)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewLoadWeightByContainer	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewLoadWeightByContainerQuery
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
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "GrossWgt"
							Me.str.GrossWgt = CType(value, string)
												
						Case "NumContainers"
							Me.str.NumContainers = CType(value, string)
												
						Case "LoadID"
							Me.str.LoadID = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "GrossWgt"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.GrossWgt = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "NumContainers"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.NumContainers = CType(value, Nullable(Of System.Int32))
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
		' Maps to viewLoadWeightByContainer.Container
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadWeightByContainerMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadWeightByContainerMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadWeightByContainer.GrossWgt
		' </summary>
		Public Overridable Property GrossWgt As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadWeightByContainerMetadata.ColumnNames.GrossWgt)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadWeightByContainerMetadata.ColumnNames.GrossWgt, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadWeightByContainer.NumContainers
		' </summary>
		Public Overridable Property NumContainers As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadWeightByContainerMetadata.ColumnNames.NumContainers)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadWeightByContainerMetadata.ColumnNames.NumContainers, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadWeightByContainer.LoadID
		' </summary>
		Public Overridable Property LoadID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadWeightByContainerMetadata.ColumnNames.LoadID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadWeightByContainerMetadata.ColumnNames.LoadID, value)
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
		
			Public Sub New(ByVal entity As esViewLoadWeightByContainer)
				Me.entity = entity
			End Sub				
		
	
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
		  	
			Public Property GrossWgt As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.GrossWgt
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.GrossWgt = Nothing
					Else
						entity.GrossWgt = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property NumContainers As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.NumContainers
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NumContainers = Nothing
					Else
						entity.NumContainers = Convert.ToInt32(Value)
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
		  

			Private entity As esViewLoadWeightByContainer
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewLoadWeightByContainerQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewLoadWeightByContainer can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewLoadWeightByContainerQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewLoadWeightByContainerMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadWeightByContainerMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property GrossWgt As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadWeightByContainerMetadata.ColumnNames.GrossWgt, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property NumContainers As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadWeightByContainerMetadata.ColumnNames.NumContainers, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LoadID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadWeightByContainerMetadata.ColumnNames.LoadID, esSystemType.Int32)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewLoadWeightByContainerCollection")> _
	Partial Public Class ViewLoadWeightByContainerCollection
		Inherits esViewLoadWeightByContainerCollection
		Implements IEnumerable(Of ViewLoadWeightByContainer)
		
        Public Shared Widening Operator CType(ByVal coll As ViewLoadWeightByContainerCollection) As List(Of ViewLoadWeightByContainer)
            Dim list As List(Of ViewLoadWeightByContainer) = New List(Of ViewLoadWeightByContainer)
            Dim emp As ViewLoadWeightByContainer

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewLoadWeightByContainerMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewLoadWeightByContainerQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewLoadWeightByContainer(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewLoadWeightByContainer()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewLoadWeightByContainerQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewLoadWeightByContainerQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewLoadWeightByContainerQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewLoadWeightByContainer 
			Return CType(MyBase.AddNewEntity(), ViewLoadWeightByContainer)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewLoadWeightByContainer) Implements IEnumerable(Of ViewLoadWeightByContainer).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewLoadWeightByContainer)(Me)
        End Function
		
		Private _query As ViewLoadWeightByContainerQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewLoadWeightByContainer' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewLoadWeightByContainer ()")> _
	<Serializable> _
	Partial Public Class ViewLoadWeightByContainer 
		Inherits esViewLoadWeightByContainer

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewLoadWeightByContainerMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewLoadWeightByContainerQuery

			If Me._query Is Nothing Then
				Me._query = New ViewLoadWeightByContainerQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewLoadWeightByContainerQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewLoadWeightByContainerQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewLoadWeightByContainerQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewLoadWeightByContainerQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewLoadWeightByContainerQuery
		inherits esViewLoadWeightByContainerQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewLoadWeightByContainerQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewLoadWeightByContainerMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewLoadWeightByContainerMetadata.ColumnNames.Container, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadWeightByContainerMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadWeightByContainerMetadata.ColumnNames.GrossWgt, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadWeightByContainerMetadata.PropertyNames.GrossWgt
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadWeightByContainerMetadata.ColumnNames.NumContainers, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadWeightByContainerMetadata.PropertyNames.NumContainers
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadWeightByContainerMetadata.ColumnNames.LoadID, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadWeightByContainerMetadata.PropertyNames.LoadID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewLoadWeightByContainerMetadata
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
			 Public Const Container As String = "Container"
			 Public Const GrossWgt As String = "GrossWgt"
			 Public Const NumContainers As String = "NumContainers"
			 Public Const LoadID As String = "LoadID"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Container As String = "Container"
			 Public Const GrossWgt As String = "GrossWgt"
			 Public Const NumContainers As String = "NumContainers"
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
            SyncLock GetType(ViewLoadWeightByContainerMetadata)
			
				If ViewLoadWeightByContainerMetadata.mapDelegates Is Nothing Then
					ViewLoadWeightByContainerMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewLoadWeightByContainerMetadata._meta Is Nothing Then
                    ViewLoadWeightByContainerMetadata._meta = New ViewLoadWeightByContainerMetadata()
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
				

				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("GrossWgt", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("NumContainers", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("LoadID", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "viewLoadWeightByContainer"
				meta.Destination = "viewLoadWeightByContainer"
				
				meta.spInsert = "proc_viewLoadWeightByContainerInsert"
				meta.spUpdate = "proc_viewLoadWeightByContainerUpdate"
				meta.spDelete = "proc_viewLoadWeightByContainerDelete"
				meta.spLoadAll = "proc_viewLoadWeightByContainerLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewLoadWeightByContainerLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewLoadWeightByContainerMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
