'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/25/2014 3:55:20 PM
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
	MustInherit Public Class esAppfunctionCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "AppfunctionCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esAppfunctionQuery)
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
            Me.InitQuery(CType(query, esAppfunctionQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Appfunction) As Appfunction
			Return CType(MyBase.DetachEntity(entity), Appfunction)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Appfunction) As Appfunction
			Return CType(MyBase.AttachEntity(entity), Appfunction)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As AppfunctionCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Appfunction
            Get
                Return TryCast(MyBase.Item(index), Appfunction)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Appfunction)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esAppfunction	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esAppfunctionQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal appfunctionid As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(appfunctionid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(appfunctionid)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal appfunctionid As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(appfunctionid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(appfunctionid)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal appfunctionid As System.Int32) As Boolean
		
			Dim query As esAppfunctionQuery = Me.GetDynamicQuery()
			query.Where(query.Appfunctionid.Equal(appfunctionid))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal appfunctionid As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("APPFUNCTIONID", appfunctionid)
			
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
												
						Case "Appfunctionid"
							Me.str.Appfunctionid = CType(value, string)
												
						Case "Appfunctionname"
							Me.str.Appfunctionname = CType(value, string)
												
						Case "Appfunctiondesc"
							Me.str.Appfunctiondesc = CType(value, string)
												
						Case "Dateadded"
							Me.str.Dateadded = CType(value, string)
												
						Case "Dateupdated"
							Me.str.Dateupdated = CType(value, string)
												
						Case "Appgroupid"
							Me.str.Appgroupid = CType(value, string)
												
						Case "Permittedbydefault"
							Me.str.Permittedbydefault = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
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
						
						Case "Appgroupid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Appgroupid = CType(value, Nullable(Of System.Int32))
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
		' Maps to APPFUNCTION.APPFUNCTIONID
		' </summary>
		Public Overridable Property Appfunctionid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(AppfunctionMetadata.ColumnNames.Appfunctionid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(AppfunctionMetadata.ColumnNames.Appfunctionid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APPFUNCTION.APPFUNCTIONNAME
		' </summary>
		Public Overridable Property Appfunctionname As System.String
			Get
				Return MyBase.GetSystemString(AppfunctionMetadata.ColumnNames.Appfunctionname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(AppfunctionMetadata.ColumnNames.Appfunctionname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APPFUNCTION.APPFUNCTIONDESC
		' </summary>
		Public Overridable Property Appfunctiondesc As System.String
			Get
				Return MyBase.GetSystemString(AppfunctionMetadata.ColumnNames.Appfunctiondesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(AppfunctionMetadata.ColumnNames.Appfunctiondesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APPFUNCTION.DATEADDED
		' </summary>
		Public Overridable Property Dateadded As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(AppfunctionMetadata.ColumnNames.Dateadded)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(AppfunctionMetadata.ColumnNames.Dateadded, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APPFUNCTION.DATEUPDATED
		' </summary>
		Public Overridable Property Dateupdated As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(AppfunctionMetadata.ColumnNames.Dateupdated)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(AppfunctionMetadata.ColumnNames.Dateupdated, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APPFUNCTION.APPGROUPID
		' </summary>
		Public Overridable Property Appgroupid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(AppfunctionMetadata.ColumnNames.Appgroupid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(AppfunctionMetadata.ColumnNames.Appgroupid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APPFUNCTION.PERMITTEDBYDEFAULT
		' </summary>
		Public Overridable Property Permittedbydefault As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(AppfunctionMetadata.ColumnNames.Permittedbydefault)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(AppfunctionMetadata.ColumnNames.Permittedbydefault, value)
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
		
			Public Sub New(ByVal entity As esAppfunction)
				Me.entity = entity
			End Sub				
		
	
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
		  	
			Public Property Appfunctionname As System.String 
				Get
					Dim data_ As System.String = entity.Appfunctionname
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Appfunctionname = Nothing
					Else
						entity.Appfunctionname = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Appfunctiondesc As System.String 
				Get
					Dim data_ As System.String = entity.Appfunctiondesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Appfunctiondesc = Nothing
					Else
						entity.Appfunctiondesc = Convert.ToString(Value)
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
		  

			Private entity As esAppfunction
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esAppfunctionQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esAppfunction can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Appfunction 
		Inherits esAppfunction
		
	
		
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
	MustInherit Public Class esAppfunctionQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return AppfunctionMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Appfunctionid As esQueryItem
			Get
				Return New esQueryItem(Me, AppfunctionMetadata.ColumnNames.Appfunctionid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Appfunctionname As esQueryItem
			Get
				Return New esQueryItem(Me, AppfunctionMetadata.ColumnNames.Appfunctionname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Appfunctiondesc As esQueryItem
			Get
				Return New esQueryItem(Me, AppfunctionMetadata.ColumnNames.Appfunctiondesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Dateadded As esQueryItem
			Get
				Return New esQueryItem(Me, AppfunctionMetadata.ColumnNames.Dateadded, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Dateupdated As esQueryItem
			Get
				Return New esQueryItem(Me, AppfunctionMetadata.ColumnNames.Dateupdated, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Appgroupid As esQueryItem
			Get
				Return New esQueryItem(Me, AppfunctionMetadata.ColumnNames.Appgroupid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Permittedbydefault As esQueryItem
			Get
				Return New esQueryItem(Me, AppfunctionMetadata.ColumnNames.Permittedbydefault, esSystemType.Boolean)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("AppfunctionCollection")> _
	Partial Public Class AppfunctionCollection
		Inherits esAppfunctionCollection
		Implements IEnumerable(Of Appfunction)
		
        Public Shared Widening Operator CType(ByVal coll As AppfunctionCollection) As List(Of Appfunction)
            Dim list As List(Of Appfunction) = New List(Of Appfunction)
            Dim emp As Appfunction

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return AppfunctionMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New AppfunctionQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Appfunction(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Appfunction()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As AppfunctionQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New AppfunctionQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As AppfunctionQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Appfunction 
			Return CType(MyBase.AddNewEntity(), Appfunction)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal appfunctionid As System.Int32) As Appfunction
			Return CType(MyBase.FindByPrimaryKey(appfunctionid), Appfunction)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Appfunction) Implements IEnumerable(Of Appfunction).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Appfunction)(Me)
        End Function
		
		Private _query As AppfunctionQuery

	End Class
	


	' <summary>
	' Encapsulates the 'APPFUNCTION' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Appfunction ({Appfunctionid.Value})")> _
	<Serializable> _
	Partial Public Class Appfunction 
		Inherits esAppfunction

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return AppfunctionMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esAppfunctionQuery

			If Me._query Is Nothing Then
				Me._query = New AppfunctionQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As AppfunctionQuery
			Get

				If Me._query Is Nothing then
					Me._query = New AppfunctionQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As AppfunctionQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As AppfunctionQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class AppfunctionQuery
		inherits esAppfunctionQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "AppfunctionQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class AppfunctionMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(AppfunctionMetadata.ColumnNames.Appfunctionid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = AppfunctionMetadata.PropertyNames.Appfunctionid
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(AppfunctionMetadata.ColumnNames.Appfunctionname, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = AppfunctionMetadata.PropertyNames.Appfunctionname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(AppfunctionMetadata.ColumnNames.Appfunctiondesc, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = AppfunctionMetadata.PropertyNames.Appfunctiondesc
			c.CharacterMaxLength = 100
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(AppfunctionMetadata.ColumnNames.Dateadded, 3, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = AppfunctionMetadata.PropertyNames.Dateadded
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(AppfunctionMetadata.ColumnNames.Dateupdated, 4, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = AppfunctionMetadata.PropertyNames.Dateupdated
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(AppfunctionMetadata.ColumnNames.Appgroupid, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = AppfunctionMetadata.PropertyNames.Appgroupid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(AppfunctionMetadata.ColumnNames.Permittedbydefault, 6, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = AppfunctionMetadata.PropertyNames.Permittedbydefault
			c.HasDefault = True
			c.Default = "((0))"
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As AppfunctionMetadata
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
			 Public Const Appfunctionid As String = "APPFUNCTIONID"
			 Public Const Appfunctionname As String = "APPFUNCTIONNAME"
			 Public Const Appfunctiondesc As String = "APPFUNCTIONDESC"
			 Public Const Dateadded As String = "DATEADDED"
			 Public Const Dateupdated As String = "DATEUPDATED"
			 Public Const Appgroupid As String = "APPGROUPID"
			 Public Const Permittedbydefault As String = "PERMITTEDBYDEFAULT"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Appfunctionid As String = "Appfunctionid"
			 Public Const Appfunctionname As String = "Appfunctionname"
			 Public Const Appfunctiondesc As String = "Appfunctiondesc"
			 Public Const Dateadded As String = "Dateadded"
			 Public Const Dateupdated As String = "Dateupdated"
			 Public Const Appgroupid As String = "Appgroupid"
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
            SyncLock GetType(AppfunctionMetadata)
			
				If AppfunctionMetadata.mapDelegates Is Nothing Then
					AppfunctionMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If AppfunctionMetadata._meta Is Nothing Then
                    AppfunctionMetadata._meta = New AppfunctionMetadata()
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
				

				meta.AddTypeMap("Appfunctionid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Appfunctionname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Appfunctiondesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Dateadded", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Dateupdated", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Appgroupid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Permittedbydefault", new esTypeMap("bit", "System.Boolean"))			
				
				
				 
				meta.Source = "APPFUNCTION"
				meta.Destination = "APPFUNCTION"
				
				meta.spInsert = "proc_APPFUNCTIONInsert"
				meta.spUpdate = "proc_APPFUNCTIONUpdate"
				meta.spDelete = "proc_APPFUNCTIONDelete"
				meta.spLoadAll = "proc_APPFUNCTIONLoadAll"
				meta.spLoadByPrimaryKey = "proc_APPFUNCTIONLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As AppfunctionMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
