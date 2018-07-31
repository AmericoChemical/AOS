'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 8/18/2014 8:19:49 PM
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
	MustInherit Public Class esViewAuditPermissionsCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewAuditPermissionsCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewAuditPermissionsQuery)
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
            Me.InitQuery(CType(query, esViewAuditPermissionsQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewAuditPermissions) As ViewAuditPermissions
			Return CType(MyBase.DetachEntity(entity), ViewAuditPermissions)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewAuditPermissions) As ViewAuditPermissions
			Return CType(MyBase.AttachEntity(entity), ViewAuditPermissions)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewAuditPermissionsCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewAuditPermissions
            Get
                Return TryCast(MyBase.Item(index), ViewAuditPermissions)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewAuditPermissions)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewAuditPermissions	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewAuditPermissionsQuery
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
												
						Case "Auditpermissionsid"
							Me.str.Auditpermissionsid = CType(value, string)
												
						Case "Userlogin"
							Me.str.Userlogin = CType(value, string)
												
						Case "Auditcategory"
							Me.str.Auditcategory = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Auditpermissionsid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Auditpermissionsid = CType(value, Nullable(Of System.Int32))
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
		' Maps to viewAuditPermissions.AUDITPERMISSIONSID
		' </summary>
		Public Overridable Property Auditpermissionsid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewAuditPermissionsMetadata.ColumnNames.Auditpermissionsid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewAuditPermissionsMetadata.ColumnNames.Auditpermissionsid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAuditPermissions.USERLOGIN
		' </summary>
		Public Overridable Property Userlogin As System.String
			Get
				Return MyBase.GetSystemString(ViewAuditPermissionsMetadata.ColumnNames.Userlogin)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewAuditPermissionsMetadata.ColumnNames.Userlogin, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAuditPermissions.AUDITCATEGORY
		' </summary>
		Public Overridable Property Auditcategory As System.String
			Get
				Return MyBase.GetSystemString(ViewAuditPermissionsMetadata.ColumnNames.Auditcategory)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewAuditPermissionsMetadata.ColumnNames.Auditcategory, value)
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
		
			Public Sub New(ByVal entity As esViewAuditPermissions)
				Me.entity = entity
			End Sub				
		
	
			Public Property Auditpermissionsid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Auditpermissionsid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Auditpermissionsid = Nothing
					Else
						entity.Auditpermissionsid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Userlogin As System.String 
				Get
					Dim data_ As System.String = entity.Userlogin
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Userlogin = Nothing
					Else
						entity.Userlogin = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Auditcategory As System.String 
				Get
					Dim data_ As System.String = entity.Auditcategory
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Auditcategory = Nothing
					Else
						entity.Auditcategory = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewAuditPermissions
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewAuditPermissionsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewAuditPermissions can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewAuditPermissionsQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewAuditPermissionsMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Auditpermissionsid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAuditPermissionsMetadata.ColumnNames.Auditpermissionsid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Userlogin As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAuditPermissionsMetadata.ColumnNames.Userlogin, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Auditcategory As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAuditPermissionsMetadata.ColumnNames.Auditcategory, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewAuditPermissionsCollection")> _
	Partial Public Class ViewAuditPermissionsCollection
		Inherits esViewAuditPermissionsCollection
		Implements IEnumerable(Of ViewAuditPermissions)
		
        Public Shared Widening Operator CType(ByVal coll As ViewAuditPermissionsCollection) As List(Of ViewAuditPermissions)
            Dim list As List(Of ViewAuditPermissions) = New List(Of ViewAuditPermissions)
            Dim emp As ViewAuditPermissions

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewAuditPermissionsMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewAuditPermissionsQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewAuditPermissions(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewAuditPermissions()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewAuditPermissionsQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewAuditPermissionsQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewAuditPermissionsQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewAuditPermissions 
			Return CType(MyBase.AddNewEntity(), ViewAuditPermissions)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewAuditPermissions) Implements IEnumerable(Of ViewAuditPermissions).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewAuditPermissions)(Me)
        End Function
		
		Private _query As ViewAuditPermissionsQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewAuditPermissions' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewAuditPermissions ()")> _
	<Serializable> _
	Partial Public Class ViewAuditPermissions 
		Inherits esViewAuditPermissions

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewAuditPermissionsMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewAuditPermissionsQuery

			If Me._query Is Nothing Then
				Me._query = New ViewAuditPermissionsQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewAuditPermissionsQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewAuditPermissionsQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewAuditPermissionsQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewAuditPermissionsQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewAuditPermissionsQuery
		inherits esViewAuditPermissionsQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewAuditPermissionsQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewAuditPermissionsMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewAuditPermissionsMetadata.ColumnNames.Auditpermissionsid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewAuditPermissionsMetadata.PropertyNames.Auditpermissionsid
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAuditPermissionsMetadata.ColumnNames.Userlogin, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewAuditPermissionsMetadata.PropertyNames.Userlogin
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAuditPermissionsMetadata.ColumnNames.Auditcategory, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewAuditPermissionsMetadata.PropertyNames.Auditcategory
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewAuditPermissionsMetadata
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
			 Public Const Auditpermissionsid As String = "AUDITPERMISSIONSID"
			 Public Const Userlogin As String = "USERLOGIN"
			 Public Const Auditcategory As String = "AUDITCATEGORY"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Auditpermissionsid As String = "Auditpermissionsid"
			 Public Const Userlogin As String = "Userlogin"
			 Public Const Auditcategory As String = "Auditcategory"
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
            SyncLock GetType(ViewAuditPermissionsMetadata)
			
				If ViewAuditPermissionsMetadata.mapDelegates Is Nothing Then
					ViewAuditPermissionsMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewAuditPermissionsMetadata._meta Is Nothing Then
                    ViewAuditPermissionsMetadata._meta = New ViewAuditPermissionsMetadata()
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
				

				meta.AddTypeMap("Auditpermissionsid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Userlogin", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Auditcategory", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewAuditPermissions"
				meta.Destination = "viewAuditPermissions"
				
				meta.spInsert = "proc_viewAuditPermissionsInsert"
				meta.spUpdate = "proc_viewAuditPermissionsUpdate"
				meta.spDelete = "proc_viewAuditPermissionsDelete"
				meta.spLoadAll = "proc_viewAuditPermissionsLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewAuditPermissionsLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewAuditPermissionsMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
