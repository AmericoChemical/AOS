'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/11/2014 1:43:55 PM
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
	MustInherit Public Class esAppuserpermissionCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "AppuserpermissionCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esAppuserpermissionQuery)
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
            Me.InitQuery(CType(query, esAppuserpermissionQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Appuserpermission) As Appuserpermission
			Return CType(MyBase.DetachEntity(entity), Appuserpermission)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Appuserpermission) As Appuserpermission
			Return CType(MyBase.AttachEntity(entity), Appuserpermission)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As AppuserpermissionCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Appuserpermission
            Get
                Return TryCast(MyBase.Item(index), Appuserpermission)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Appuserpermission)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esAppuserpermission	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esAppuserpermissionQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal appuserpermissionid As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(appuserpermissionid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(appuserpermissionid)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal appuserpermissionid As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(appuserpermissionid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(appuserpermissionid)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal appuserpermissionid As System.Int32) As Boolean
		
			Dim query As esAppuserpermissionQuery = Me.GetDynamicQuery()
			query.Where(query.Appuserpermissionid.Equal(appuserpermissionid))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal appuserpermissionid As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("APPUSERPERMISSIONID", appuserpermissionid)
			
			Return Me.Load(esQueryType.StoredProcedure, Me.es.spLoadByPrimaryKey, parms)
			
		End Function
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
												
						Case "Appuserpermissionid"
							Me.str.Appuserpermissionid = CType(value, string)
												
						Case "Appuserid"
							Me.str.Appuserid = CType(value, string)
												
						Case "Appfunctionid"
							Me.str.Appfunctionid = CType(value, string)
												
						Case "Dateadded"
							Me.str.Dateadded = CType(value, string)
												
						Case "Dateupdated"
							Me.str.Dateupdated = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Appuserpermissionid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Appuserpermissionid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Appuserid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Appuserid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Appfunctionid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Appfunctionid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Dateadded"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Dateadded = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Dateupdated"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Dateupdated = CType(value, Nullable(Of System.DateTime))
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
		' Maps to APPUSERPERMISSION.APPUSERPERMISSIONID
		' </summary>
		Public Overridable Property Appuserpermissionid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(AppuserpermissionMetadata.ColumnNames.Appuserpermissionid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(AppuserpermissionMetadata.ColumnNames.Appuserpermissionid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APPUSERPERMISSION.APPUSERID
		' </summary>
		Public Overridable Property Appuserid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(AppuserpermissionMetadata.ColumnNames.Appuserid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(AppuserpermissionMetadata.ColumnNames.Appuserid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APPUSERPERMISSION.APPFUNCTIONID
		' </summary>
		Public Overridable Property Appfunctionid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(AppuserpermissionMetadata.ColumnNames.Appfunctionid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(AppuserpermissionMetadata.ColumnNames.Appfunctionid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APPUSERPERMISSION.DATEADDED
		' </summary>
		Public Overridable Property Dateadded As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(AppuserpermissionMetadata.ColumnNames.Dateadded)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(AppuserpermissionMetadata.ColumnNames.Dateadded, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APPUSERPERMISSION.DATEUPDATED
		' </summary>
		Public Overridable Property Dateupdated As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(AppuserpermissionMetadata.ColumnNames.Dateupdated)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(AppuserpermissionMetadata.ColumnNames.Dateupdated, value)
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
		
			Public Sub New(ByVal entity As esAppuserpermission)
				Me.entity = entity
			End Sub				
		
	
			Public Property Appuserpermissionid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Appuserpermissionid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Appuserpermissionid = Nothing
					Else
						entity.Appuserpermissionid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Appuserid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Appuserid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Appuserid = Nothing
					Else
						entity.Appuserid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Appfunctionid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Appfunctionid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Appfunctionid = Nothing
					Else
						entity.Appfunctionid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Dateadded As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Dateadded
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Dateadded = Nothing
					Else
						entity.Dateadded = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Dateupdated As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Dateupdated
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Dateupdated = Nothing
					Else
						entity.Dateupdated = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  

			Private entity As esAppuserpermission
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esAppuserpermissionQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esAppuserpermission can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Appuserpermission 
		Inherits esAppuserpermission
		
	
		
		''' <summary>
		''' Used internally by the entity's hierarchical properties.
		''' </summary>
        Protected Overrides Function GetHierarchicalProperties() As List(Of esPropertyDescriptor)
        
            Dim props As New List(Of esPropertyDescriptor)
			

            Return props
			
        End Function	
		
		''' <summary>
		''' Used internally for retrieving AutoIncrementing keys
		''' during hierarchical PreSave.
		''' </summary>
		Protected Overrides Sub ApplyPreSaveKeys()
		
		End Sub
		
		''' <summary>
		''' Used internally for retrieving AutoIncrementing keys
		''' during hierarchical PostSave.
		''' </summary>
		Protected Overrides Sub ApplyPostSaveKeys()
		
		End Sub
		
		''' <summary>
		''' Used internally for retrieving AutoIncrementing keys
		''' during hierarchical PostOneSave.
		''' </summary>
		Protected Overrides Sub ApplyPostOneSaveKeys()
		
		End Sub
	End Class
	


	<Serializable> _
	MustInherit Public Class esAppuserpermissionQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return AppuserpermissionMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Appuserpermissionid As esQueryItem
			Get
				Return New esQueryItem(Me, AppuserpermissionMetadata.ColumnNames.Appuserpermissionid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Appuserid As esQueryItem
			Get
				Return New esQueryItem(Me, AppuserpermissionMetadata.ColumnNames.Appuserid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Appfunctionid As esQueryItem
			Get
				Return New esQueryItem(Me, AppuserpermissionMetadata.ColumnNames.Appfunctionid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Dateadded As esQueryItem
			Get
				Return New esQueryItem(Me, AppuserpermissionMetadata.ColumnNames.Dateadded, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Dateupdated As esQueryItem
			Get
				Return New esQueryItem(Me, AppuserpermissionMetadata.ColumnNames.Dateupdated, esSystemType.DateTime)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("AppuserpermissionCollection")> _
	Partial Public Class AppuserpermissionCollection
		Inherits esAppuserpermissionCollection
		Implements IEnumerable(Of Appuserpermission)
		
        Public Shared Widening Operator CType(ByVal coll As AppuserpermissionCollection) As List(Of Appuserpermission)
            Dim list As List(Of Appuserpermission) = New List(Of Appuserpermission)
            Dim emp As Appuserpermission

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return AppuserpermissionMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New AppuserpermissionQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Appuserpermission(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Appuserpermission()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As AppuserpermissionQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New AppuserpermissionQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As AppuserpermissionQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Appuserpermission 
			Return CType(MyBase.AddNewEntity(), Appuserpermission)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal appuserpermissionid As System.Int32) As Appuserpermission
			Return CType(MyBase.FindByPrimaryKey(appuserpermissionid), Appuserpermission)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Appuserpermission) Implements IEnumerable(Of Appuserpermission).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Appuserpermission)(Me)
        End Function
		
		Private _query As AppuserpermissionQuery

	End Class
	


	' <summary>
	' Encapsulates the 'APPUSERPERMISSION' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Appuserpermission ({Appuserpermissionid.Value})")> _
	<Serializable> _
	Partial Public Class Appuserpermission 
		Inherits esAppuserpermission

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return AppuserpermissionMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esAppuserpermissionQuery

			If Me._query Is Nothing Then
				Me._query = New AppuserpermissionQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As AppuserpermissionQuery
			Get

				If Me._query Is Nothing then
					Me._query = New AppuserpermissionQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As AppuserpermissionQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As AppuserpermissionQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class AppuserpermissionQuery
		inherits esAppuserpermissionQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "AppuserpermissionQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class AppuserpermissionMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(AppuserpermissionMetadata.ColumnNames.Appuserpermissionid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = AppuserpermissionMetadata.PropertyNames.Appuserpermissionid
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(AppuserpermissionMetadata.ColumnNames.Appuserid, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = AppuserpermissionMetadata.PropertyNames.Appuserid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(AppuserpermissionMetadata.ColumnNames.Appfunctionid, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = AppuserpermissionMetadata.PropertyNames.Appfunctionid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(AppuserpermissionMetadata.ColumnNames.Dateadded, 3, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = AppuserpermissionMetadata.PropertyNames.Dateadded
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(AppuserpermissionMetadata.ColumnNames.Dateupdated, 4, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = AppuserpermissionMetadata.PropertyNames.Dateupdated
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As AppuserpermissionMetadata
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
			 Public Const Appuserpermissionid As String = "APPUSERPERMISSIONID"
			 Public Const Appuserid As String = "APPUSERID"
			 Public Const Appfunctionid As String = "APPFUNCTIONID"
			 Public Const Dateadded As String = "DATEADDED"
			 Public Const Dateupdated As String = "DATEUPDATED"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Appuserpermissionid As String = "Appuserpermissionid"
			 Public Const Appuserid As String = "Appuserid"
			 Public Const Appfunctionid As String = "Appfunctionid"
			 Public Const Dateadded As String = "Dateadded"
			 Public Const Dateupdated As String = "Dateupdated"
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
            SyncLock GetType(AppuserpermissionMetadata)
			
				If AppuserpermissionMetadata.mapDelegates Is Nothing Then
					AppuserpermissionMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If AppuserpermissionMetadata._meta Is Nothing Then
                    AppuserpermissionMetadata._meta = New AppuserpermissionMetadata()
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
				

				meta.AddTypeMap("Appuserpermissionid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Appuserid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Appfunctionid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Dateadded", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Dateupdated", new esTypeMap("datetime", "System.DateTime"))			
				
				
				 
				meta.Source = "APPUSERPERMISSION"
				meta.Destination = "APPUSERPERMISSION"
				
				meta.spInsert = "proc_APPUSERPERMISSIONInsert"
				meta.spUpdate = "proc_APPUSERPERMISSIONUpdate"
				meta.spDelete = "proc_APPUSERPERMISSIONDelete"
				meta.spLoadAll = "proc_APPUSERPERMISSIONLoadAll"
				meta.spLoadByPrimaryKey = "proc_APPUSERPERMISSIONLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As AppuserpermissionMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
