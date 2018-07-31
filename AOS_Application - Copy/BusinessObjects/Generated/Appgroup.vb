'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/25/2014 3:55:21 PM
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
	MustInherit Public Class esAppgroupCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "AppgroupCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esAppgroupQuery)
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
            Me.InitQuery(CType(query, esAppgroupQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Appgroup) As Appgroup
			Return CType(MyBase.DetachEntity(entity), Appgroup)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Appgroup) As Appgroup
			Return CType(MyBase.AttachEntity(entity), Appgroup)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As AppgroupCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Appgroup
            Get
                Return TryCast(MyBase.Item(index), Appgroup)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Appgroup)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esAppgroup	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esAppgroupQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal appgroupid As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(appgroupid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(appgroupid)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal appgroupid As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(appgroupid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(appgroupid)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal appgroupid As System.Int32) As Boolean
		
			Dim query As esAppgroupQuery = Me.GetDynamicQuery()
			query.Where(query.Appgroupid.Equal(appgroupid))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal appgroupid As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("APPGROUPID", appgroupid)
			
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
												
						Case "Appgroupid"
							Me.str.Appgroupid = CType(value, string)
												
						Case "Appgroupname"
							Me.str.Appgroupname = CType(value, string)
												
						Case "Appgroupdesc"
							Me.str.Appgroupdesc = CType(value, string)
												
						Case "Dateadded"
							Me.str.Dateadded = CType(value, string)
												
						Case "Dateupdated"
							Me.str.Dateupdated = CType(value, string)
												
						Case "Appmenuid"
							Me.str.Appmenuid = CType(value, string)
												
						Case "Permittedbydefault"
							Me.str.Permittedbydefault = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Appgroupid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Appgroupid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Dateadded"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Dateadded = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Dateupdated"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Dateupdated = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Appmenuid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Appmenuid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Permittedbydefault"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Permittedbydefault = CType(value, Nullable(Of System.Boolean))
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
		' Maps to APPGROUP.APPGROUPID
		' </summary>
		Public Overridable Property Appgroupid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(AppgroupMetadata.ColumnNames.Appgroupid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(AppgroupMetadata.ColumnNames.Appgroupid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APPGROUP.APPGROUPNAME
		' </summary>
		Public Overridable Property Appgroupname As System.String
			Get
				Return MyBase.GetSystemString(AppgroupMetadata.ColumnNames.Appgroupname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(AppgroupMetadata.ColumnNames.Appgroupname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APPGROUP.APPGROUPDESC
		' </summary>
		Public Overridable Property Appgroupdesc As System.String
			Get
				Return MyBase.GetSystemString(AppgroupMetadata.ColumnNames.Appgroupdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(AppgroupMetadata.ColumnNames.Appgroupdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APPGROUP.DATEADDED
		' </summary>
		Public Overridable Property Dateadded As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(AppgroupMetadata.ColumnNames.Dateadded)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(AppgroupMetadata.ColumnNames.Dateadded, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APPGROUP.DATEUPDATED
		' </summary>
		Public Overridable Property Dateupdated As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(AppgroupMetadata.ColumnNames.Dateupdated)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(AppgroupMetadata.ColumnNames.Dateupdated, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APPGROUP.APPMENUID
		' </summary>
		Public Overridable Property Appmenuid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(AppgroupMetadata.ColumnNames.Appmenuid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(AppgroupMetadata.ColumnNames.Appmenuid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APPGROUP.PERMITTEDBYDEFAULT
		' </summary>
		Public Overridable Property Permittedbydefault As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(AppgroupMetadata.ColumnNames.Permittedbydefault)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(AppgroupMetadata.ColumnNames.Permittedbydefault, value)
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
		
			Public Sub New(ByVal entity As esAppgroup)
				Me.entity = entity
			End Sub				
		
	
			Public Property Appgroupid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Appgroupid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Appgroupid = Nothing
					Else
						entity.Appgroupid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Appgroupname As System.String 
				Get
					Dim data_ As System.String = entity.Appgroupname
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Appgroupname = Nothing
					Else
						entity.Appgroupname = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Appgroupdesc As System.String 
				Get
					Dim data_ As System.String = entity.Appgroupdesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Appgroupdesc = Nothing
					Else
						entity.Appgroupdesc = Convert.ToString(Value)
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
		  	
			Public Property Appmenuid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Appmenuid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Appmenuid = Nothing
					Else
						entity.Appmenuid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Permittedbydefault As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Permittedbydefault
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Permittedbydefault = Nothing
					Else
						entity.Permittedbydefault = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  

			Private entity As esAppgroup
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esAppgroupQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esAppgroup can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Appgroup 
		Inherits esAppgroup
		
	
		
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
	MustInherit Public Class esAppgroupQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return AppgroupMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Appgroupid As esQueryItem
			Get
				Return New esQueryItem(Me, AppgroupMetadata.ColumnNames.Appgroupid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Appgroupname As esQueryItem
			Get
				Return New esQueryItem(Me, AppgroupMetadata.ColumnNames.Appgroupname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Appgroupdesc As esQueryItem
			Get
				Return New esQueryItem(Me, AppgroupMetadata.ColumnNames.Appgroupdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Dateadded As esQueryItem
			Get
				Return New esQueryItem(Me, AppgroupMetadata.ColumnNames.Dateadded, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Dateupdated As esQueryItem
			Get
				Return New esQueryItem(Me, AppgroupMetadata.ColumnNames.Dateupdated, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Appmenuid As esQueryItem
			Get
				Return New esQueryItem(Me, AppgroupMetadata.ColumnNames.Appmenuid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Permittedbydefault As esQueryItem
			Get
				Return New esQueryItem(Me, AppgroupMetadata.ColumnNames.Permittedbydefault, esSystemType.Boolean)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("AppgroupCollection")> _
	Partial Public Class AppgroupCollection
		Inherits esAppgroupCollection
		Implements IEnumerable(Of Appgroup)
		
        Public Shared Widening Operator CType(ByVal coll As AppgroupCollection) As List(Of Appgroup)
            Dim list As List(Of Appgroup) = New List(Of Appgroup)
            Dim emp As Appgroup

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return AppgroupMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New AppgroupQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Appgroup(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Appgroup()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As AppgroupQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New AppgroupQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As AppgroupQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Appgroup 
			Return CType(MyBase.AddNewEntity(), Appgroup)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal appgroupid As System.Int32) As Appgroup
			Return CType(MyBase.FindByPrimaryKey(appgroupid), Appgroup)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Appgroup) Implements IEnumerable(Of Appgroup).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Appgroup)(Me)
        End Function
		
		Private _query As AppgroupQuery

	End Class
	


	' <summary>
	' Encapsulates the 'APPGROUP' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Appgroup ({Appgroupid.Value})")> _
	<Serializable> _
	Partial Public Class Appgroup 
		Inherits esAppgroup

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return AppgroupMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esAppgroupQuery

			If Me._query Is Nothing Then
				Me._query = New AppgroupQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As AppgroupQuery
			Get

				If Me._query Is Nothing then
					Me._query = New AppgroupQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As AppgroupQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As AppgroupQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class AppgroupQuery
		inherits esAppgroupQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "AppgroupQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class AppgroupMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(AppgroupMetadata.ColumnNames.Appgroupid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = AppgroupMetadata.PropertyNames.Appgroupid
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(AppgroupMetadata.ColumnNames.Appgroupname, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = AppgroupMetadata.PropertyNames.Appgroupname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(AppgroupMetadata.ColumnNames.Appgroupdesc, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = AppgroupMetadata.PropertyNames.Appgroupdesc
			c.CharacterMaxLength = 100
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(AppgroupMetadata.ColumnNames.Dateadded, 3, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = AppgroupMetadata.PropertyNames.Dateadded
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(AppgroupMetadata.ColumnNames.Dateupdated, 4, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = AppgroupMetadata.PropertyNames.Dateupdated
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(AppgroupMetadata.ColumnNames.Appmenuid, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = AppgroupMetadata.PropertyNames.Appmenuid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(AppgroupMetadata.ColumnNames.Permittedbydefault, 6, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = AppgroupMetadata.PropertyNames.Permittedbydefault
			c.HasDefault = True
			c.Default = "((0))"
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As AppgroupMetadata
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
			 Public Const Appgroupid As String = "APPGROUPID"
			 Public Const Appgroupname As String = "APPGROUPNAME"
			 Public Const Appgroupdesc As String = "APPGROUPDESC"
			 Public Const Dateadded As String = "DATEADDED"
			 Public Const Dateupdated As String = "DATEUPDATED"
			 Public Const Appmenuid As String = "APPMENUID"
			 Public Const Permittedbydefault As String = "PERMITTEDBYDEFAULT"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Appgroupid As String = "Appgroupid"
			 Public Const Appgroupname As String = "Appgroupname"
			 Public Const Appgroupdesc As String = "Appgroupdesc"
			 Public Const Dateadded As String = "Dateadded"
			 Public Const Dateupdated As String = "Dateupdated"
			 Public Const Appmenuid As String = "Appmenuid"
			 Public Const Permittedbydefault As String = "Permittedbydefault"
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
            SyncLock GetType(AppgroupMetadata)
			
				If AppgroupMetadata.mapDelegates Is Nothing Then
					AppgroupMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If AppgroupMetadata._meta Is Nothing Then
                    AppgroupMetadata._meta = New AppgroupMetadata()
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
				

				meta.AddTypeMap("Appgroupid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Appgroupname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Appgroupdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Dateadded", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Dateupdated", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Appmenuid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Permittedbydefault", new esTypeMap("bit", "System.Boolean"))			
				
				
				 
				meta.Source = "APPGROUP"
				meta.Destination = "APPGROUP"
				
				meta.spInsert = "proc_APPGROUPInsert"
				meta.spUpdate = "proc_APPGROUPUpdate"
				meta.spDelete = "proc_APPGROUPDelete"
				meta.spLoadAll = "proc_APPGROUPLoadAll"
				meta.spLoadByPrimaryKey = "proc_APPGROUPLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As AppgroupMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
