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
	MustInherit Public Class esApishistoryCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ApishistoryCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esApishistoryQuery)
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
            Me.InitQuery(CType(query, esApishistoryQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Apishistory) As Apishistory
			Return CType(MyBase.DetachEntity(entity), Apishistory)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Apishistory) As Apishistory
			Return CType(MyBase.AttachEntity(entity), Apishistory)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ApishistoryCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Apishistory
            Get
                Return TryCast(MyBase.Item(index), Apishistory)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Apishistory)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esApishistory	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esApishistoryQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal apischangeid As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(apischangeid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(apischangeid)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal apischangeid As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(apischangeid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(apischangeid)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal apischangeid As System.Int32) As Boolean
		
			Dim query As esApishistoryQuery = Me.GetDynamicQuery()
			query.Where(query.Apischangeid.Equal(apischangeid))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal apischangeid As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("APISCHANGEID", apischangeid)
			
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
												
						Case "Apischangeid"
							Me.str.Apischangeid = CType(value, string)
												
						Case "Apisnum"
							Me.str.Apisnum = CType(value, string)
												
						Case "Changedate"
							Me.str.Changedate = CType(value, string)
												
						Case "Whochanged"
							Me.str.Whochanged = CType(value, string)
												
						Case "Reasonforchange"
							Me.str.Reasonforchange = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Apischangeid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Apischangeid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Apisnum"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Apisnum = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Changedate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Changedate = CType(value, Nullable(Of System.DateTime))
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
		' Maps to APISHISTORY.APISCHANGEID
		' </summary>
		Public Overridable Property Apischangeid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ApishistoryMetadata.ColumnNames.Apischangeid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ApishistoryMetadata.ColumnNames.Apischangeid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APISHISTORY.APISNUM
		' </summary>
		Public Overridable Property Apisnum As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ApishistoryMetadata.ColumnNames.Apisnum)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ApishistoryMetadata.ColumnNames.Apisnum, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APISHISTORY.CHANGEDATE
		' </summary>
		Public Overridable Property Changedate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ApishistoryMetadata.ColumnNames.Changedate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ApishistoryMetadata.ColumnNames.Changedate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APISHISTORY.WHOCHANGED
		' </summary>
		Public Overridable Property Whochanged As System.String
			Get
				Return MyBase.GetSystemString(ApishistoryMetadata.ColumnNames.Whochanged)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ApishistoryMetadata.ColumnNames.Whochanged, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APISHISTORY.REASONFORCHANGE
		' </summary>
		Public Overridable Property Reasonforchange As System.String
			Get
				Return MyBase.GetSystemString(ApishistoryMetadata.ColumnNames.Reasonforchange)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ApishistoryMetadata.ColumnNames.Reasonforchange, value)
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
		
			Public Sub New(ByVal entity As esApishistory)
				Me.entity = entity
			End Sub				
		
	
			Public Property Apischangeid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Apischangeid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Apischangeid = Nothing
					Else
						entity.Apischangeid = Convert.ToInt32(Value)
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
		  	
			Public Property Changedate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Changedate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Changedate = Nothing
					Else
						entity.Changedate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Whochanged As System.String 
				Get
					Dim data_ As System.String = entity.Whochanged
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Whochanged = Nothing
					Else
						entity.Whochanged = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Reasonforchange As System.String 
				Get
					Dim data_ As System.String = entity.Reasonforchange
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Reasonforchange = Nothing
					Else
						entity.Reasonforchange = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esApishistory
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esApishistoryQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esApishistory can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Apishistory 
		Inherits esApishistory
		
	
		
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
	MustInherit Public Class esApishistoryQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ApishistoryMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Apischangeid As esQueryItem
			Get
				Return New esQueryItem(Me, ApishistoryMetadata.ColumnNames.Apischangeid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Apisnum As esQueryItem
			Get
				Return New esQueryItem(Me, ApishistoryMetadata.ColumnNames.Apisnum, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Changedate As esQueryItem
			Get
				Return New esQueryItem(Me, ApishistoryMetadata.ColumnNames.Changedate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Whochanged As esQueryItem
			Get
				Return New esQueryItem(Me, ApishistoryMetadata.ColumnNames.Whochanged, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Reasonforchange As esQueryItem
			Get
				Return New esQueryItem(Me, ApishistoryMetadata.ColumnNames.Reasonforchange, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ApishistoryCollection")> _
	Partial Public Class ApishistoryCollection
		Inherits esApishistoryCollection
		Implements IEnumerable(Of Apishistory)
		
        Public Shared Widening Operator CType(ByVal coll As ApishistoryCollection) As List(Of Apishistory)
            Dim list As List(Of Apishistory) = New List(Of Apishistory)
            Dim emp As Apishistory

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ApishistoryMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ApishistoryQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Apishistory(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Apishistory()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As ApishistoryQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ApishistoryQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ApishistoryQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Apishistory 
			Return CType(MyBase.AddNewEntity(), Apishistory)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal apischangeid As System.Int32) As Apishistory
			Return CType(MyBase.FindByPrimaryKey(apischangeid), Apishistory)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Apishistory) Implements IEnumerable(Of Apishistory).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Apishistory)(Me)
        End Function
		
		Private _query As ApishistoryQuery

	End Class
	


	' <summary>
	' Encapsulates the 'APISHISTORY' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Apishistory ({Apischangeid.Value})")> _
	<Serializable> _
	Partial Public Class Apishistory 
		Inherits esApishistory

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ApishistoryMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esApishistoryQuery

			If Me._query Is Nothing Then
				Me._query = New ApishistoryQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ApishistoryQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ApishistoryQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ApishistoryQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ApishistoryQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ApishistoryQuery
		inherits esApishistoryQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ApishistoryQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ApishistoryMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ApishistoryMetadata.ColumnNames.Apischangeid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ApishistoryMetadata.PropertyNames.Apischangeid
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ApishistoryMetadata.ColumnNames.Apisnum, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ApishistoryMetadata.PropertyNames.Apisnum
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ApishistoryMetadata.ColumnNames.Changedate, 2, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ApishistoryMetadata.PropertyNames.Changedate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ApishistoryMetadata.ColumnNames.Whochanged, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ApishistoryMetadata.PropertyNames.Whochanged
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ApishistoryMetadata.ColumnNames.Reasonforchange, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ApishistoryMetadata.PropertyNames.Reasonforchange
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ApishistoryMetadata
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
			 Public Const Apischangeid As String = "APISCHANGEID"
			 Public Const Apisnum As String = "APISNUM"
			 Public Const Changedate As String = "CHANGEDATE"
			 Public Const Whochanged As String = "WHOCHANGED"
			 Public Const Reasonforchange As String = "REASONFORCHANGE"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Apischangeid As String = "Apischangeid"
			 Public Const Apisnum As String = "Apisnum"
			 Public Const Changedate As String = "Changedate"
			 Public Const Whochanged As String = "Whochanged"
			 Public Const Reasonforchange As String = "Reasonforchange"
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
            SyncLock GetType(ApishistoryMetadata)
			
				If ApishistoryMetadata.mapDelegates Is Nothing Then
					ApishistoryMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ApishistoryMetadata._meta Is Nothing Then
                    ApishistoryMetadata._meta = New ApishistoryMetadata()
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
				

				meta.AddTypeMap("Apischangeid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Apisnum", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Changedate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Whochanged", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Reasonforchange", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "APISHISTORY"
				meta.Destination = "APISHISTORY"
				
				meta.spInsert = "proc_APISHISTORYInsert"
				meta.spUpdate = "proc_APISHISTORYUpdate"
				meta.spDelete = "proc_APISHISTORYDelete"
				meta.spLoadAll = "proc_APISHISTORYLoadAll"
				meta.spLoadByPrimaryKey = "proc_APISHISTORYLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ApishistoryMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
