'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 7/17/2015 10:10:07 AM
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
	MustInherit Public Class esViewAPISMaterialStatusCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewAPISMaterialStatusCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewAPISMaterialStatusQuery)
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
            Me.InitQuery(CType(query, esViewAPISMaterialStatusQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewAPISMaterialStatus) As ViewAPISMaterialStatus
			Return CType(MyBase.DetachEntity(entity), ViewAPISMaterialStatus)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewAPISMaterialStatus) As ViewAPISMaterialStatus
			Return CType(MyBase.AttachEntity(entity), ViewAPISMaterialStatus)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewAPISMaterialStatusCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewAPISMaterialStatus
            Get
                Return TryCast(MyBase.Item(index), ViewAPISMaterialStatus)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewAPISMaterialStatus)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewAPISMaterialStatus	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewAPISMaterialStatusQuery
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
												
						Case "Materialid"
							Me.str.Materialid = CType(value, string)
												
						Case "Apisnum"
							Me.str.Apisnum = CType(value, string)
												
						Case "Apisstatus"
							Me.str.Apisstatus = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Materialid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Materialid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Apisnum"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Apisnum = CType(value, Nullable(Of System.Int32))
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
		' Maps to viewAPISMaterialStatus.MATERIALID
		' </summary>
		Public Overridable Property Materialid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewAPISMaterialStatusMetadata.ColumnNames.Materialid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewAPISMaterialStatusMetadata.ColumnNames.Materialid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAPISMaterialStatus.APISNUM
		' </summary>
		Public Overridable Property Apisnum As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewAPISMaterialStatusMetadata.ColumnNames.Apisnum)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewAPISMaterialStatusMetadata.ColumnNames.Apisnum, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAPISMaterialStatus.APISSTATUS
		' </summary>
		Public Overridable Property Apisstatus As System.String
			Get
				Return MyBase.GetSystemString(ViewAPISMaterialStatusMetadata.ColumnNames.Apisstatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewAPISMaterialStatusMetadata.ColumnNames.Apisstatus, value)
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
		
			Public Sub New(ByVal entity As esViewAPISMaterialStatus)
				Me.entity = entity
			End Sub				
		
	
			Public Property Materialid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Materialid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Materialid = Nothing
					Else
						entity.Materialid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Apisnum As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Apisnum
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Apisnum = Nothing
					Else
						entity.Apisnum = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Apisstatus As System.String 
				Get
					Dim data_ As System.String = entity.Apisstatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Apisstatus = Nothing
					Else
						entity.Apisstatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewAPISMaterialStatus
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewAPISMaterialStatusQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewAPISMaterialStatus can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewAPISMaterialStatusQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewAPISMaterialStatusMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Materialid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAPISMaterialStatusMetadata.ColumnNames.Materialid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Apisnum As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAPISMaterialStatusMetadata.ColumnNames.Apisnum, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Apisstatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAPISMaterialStatusMetadata.ColumnNames.Apisstatus, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewAPISMaterialStatusCollection")> _
	Partial Public Class ViewAPISMaterialStatusCollection
		Inherits esViewAPISMaterialStatusCollection
		Implements IEnumerable(Of ViewAPISMaterialStatus)
		
        Public Shared Widening Operator CType(ByVal coll As ViewAPISMaterialStatusCollection) As List(Of ViewAPISMaterialStatus)
            Dim list As List(Of ViewAPISMaterialStatus) = New List(Of ViewAPISMaterialStatus)
            Dim emp As ViewAPISMaterialStatus

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewAPISMaterialStatusMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewAPISMaterialStatusQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewAPISMaterialStatus(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewAPISMaterialStatus()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewAPISMaterialStatusQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewAPISMaterialStatusQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewAPISMaterialStatusQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewAPISMaterialStatus 
			Return CType(MyBase.AddNewEntity(), ViewAPISMaterialStatus)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewAPISMaterialStatus) Implements IEnumerable(Of ViewAPISMaterialStatus).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewAPISMaterialStatus)(Me)
        End Function
		
		Private _query As ViewAPISMaterialStatusQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewAPISMaterialStatus' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewAPISMaterialStatus ()")> _
	<Serializable> _
	Partial Public Class ViewAPISMaterialStatus 
		Inherits esViewAPISMaterialStatus

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewAPISMaterialStatusMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewAPISMaterialStatusQuery

			If Me._query Is Nothing Then
				Me._query = New ViewAPISMaterialStatusQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewAPISMaterialStatusQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewAPISMaterialStatusQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewAPISMaterialStatusQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewAPISMaterialStatusQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewAPISMaterialStatusQuery
		inherits esViewAPISMaterialStatusQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewAPISMaterialStatusQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewAPISMaterialStatusMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewAPISMaterialStatusMetadata.ColumnNames.Materialid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewAPISMaterialStatusMetadata.PropertyNames.Materialid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAPISMaterialStatusMetadata.ColumnNames.Apisnum, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewAPISMaterialStatusMetadata.PropertyNames.Apisnum
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAPISMaterialStatusMetadata.ColumnNames.Apisstatus, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewAPISMaterialStatusMetadata.PropertyNames.Apisstatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewAPISMaterialStatusMetadata
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
			 Public Const Materialid As String = "MATERIALID"
			 Public Const Apisnum As String = "APISNUM"
			 Public Const Apisstatus As String = "APISSTATUS"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Materialid As String = "Materialid"
			 Public Const Apisnum As String = "Apisnum"
			 Public Const Apisstatus As String = "Apisstatus"
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
            SyncLock GetType(ViewAPISMaterialStatusMetadata)
			
				If ViewAPISMaterialStatusMetadata.mapDelegates Is Nothing Then
					ViewAPISMaterialStatusMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewAPISMaterialStatusMetadata._meta Is Nothing Then
                    ViewAPISMaterialStatusMetadata._meta = New ViewAPISMaterialStatusMetadata()
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
				

				meta.AddTypeMap("Materialid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Apisnum", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Apisstatus", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewAPISMaterialStatus"
				meta.Destination = "viewAPISMaterialStatus"
				
				meta.spInsert = "proc_viewAPISMaterialStatusInsert"
				meta.spUpdate = "proc_viewAPISMaterialStatusUpdate"
				meta.spDelete = "proc_viewAPISMaterialStatusDelete"
				meta.spLoadAll = "proc_viewAPISMaterialStatusLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewAPISMaterialStatusLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewAPISMaterialStatusMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
