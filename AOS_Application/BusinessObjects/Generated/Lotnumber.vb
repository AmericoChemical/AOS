'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/11/2014 1:43:57 PM
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
	MustInherit Public Class esLotnumberCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "LotnumberCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esLotnumberQuery)
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
            Me.InitQuery(CType(query, esLotnumberQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Lotnumber) As Lotnumber
			Return CType(MyBase.DetachEntity(entity), Lotnumber)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Lotnumber) As Lotnumber
			Return CType(MyBase.AttachEntity(entity), Lotnumber)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As LotnumberCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Lotnumber
            Get
                Return TryCast(MyBase.Item(index), Lotnumber)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Lotnumber)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esLotnumber	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esLotnumberQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal batchkey As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(batchkey)
			Else
				Return LoadByPrimaryKeyStoredProcedure(batchkey)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal batchkey As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(batchkey)
			Else
				Return LoadByPrimaryKeyStoredProcedure(batchkey)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal batchkey As System.Int32) As Boolean
		
			Dim query As esLotnumberQuery = Me.GetDynamicQuery()
			query.Where(query.Batchkey.Equal(batchkey))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal batchkey As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("BATCHKEY", batchkey)
			
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
												
						Case "Batchkey"
							Me.str.Batchkey = CType(value, string)
												
						Case "Createdtime"
							Me.str.Createdtime = CType(value, string)
												
						Case "Createdby"
							Me.str.Createdby = CType(value, string)
												
						Case "Warehouseid"
							Me.str.Warehouseid = CType(value, string)
												
						Case "Receivernumber"
							Me.str.Receivernumber = CType(value, string)
												
						Case "Lotnumber"
							Me.str.Lotnumber = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Batchkey"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Batchkey = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Createdtime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Createdtime = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Warehouseid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Warehouseid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Receivernumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Receivernumber = CType(value, Nullable(Of System.Int32))
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
		' Maps to LOTNUMBER.BATCHKEY
		' </summary>
		Public Overridable Property Batchkey As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(LotnumberMetadata.ColumnNames.Batchkey)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(LotnumberMetadata.ColumnNames.Batchkey, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOTNUMBER.CREATEDTIME
		' </summary>
		Public Overridable Property Createdtime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(LotnumberMetadata.ColumnNames.Createdtime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(LotnumberMetadata.ColumnNames.Createdtime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOTNUMBER.CREATEDBY
		' </summary>
		Public Overridable Property Createdby As System.String
			Get
				Return MyBase.GetSystemString(LotnumberMetadata.ColumnNames.Createdby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LotnumberMetadata.ColumnNames.Createdby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOTNUMBER.WAREHOUSEID
		' </summary>
		Public Overridable Property Warehouseid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(LotnumberMetadata.ColumnNames.Warehouseid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(LotnumberMetadata.ColumnNames.Warehouseid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOTNUMBER.RECEIVERNUMBER
		' </summary>
		Public Overridable Property Receivernumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(LotnumberMetadata.ColumnNames.Receivernumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(LotnumberMetadata.ColumnNames.Receivernumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOTNUMBER.LOTNUMBER
		' </summary>
		Public Overridable Property Lotnumber As System.String
			Get
				Return MyBase.GetSystemString(LotnumberMetadata.ColumnNames.Lotnumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LotnumberMetadata.ColumnNames.Lotnumber, value)
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
		
			Public Sub New(ByVal entity As esLotnumber)
				Me.entity = entity
			End Sub				
		
	
			Public Property Batchkey As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Batchkey
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Batchkey = Nothing
					Else
						entity.Batchkey = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Createdtime As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Createdtime
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Createdtime = Nothing
					Else
						entity.Createdtime = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Createdby As System.String 
				Get
					Dim data_ As System.String = entity.Createdby
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Createdby = Nothing
					Else
						entity.Createdby = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Warehouseid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Warehouseid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Warehouseid = Nothing
					Else
						entity.Warehouseid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Receivernumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Receivernumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Receivernumber = Nothing
					Else
						entity.Receivernumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Lotnumber As System.String 
				Get
					Dim data_ As System.String = entity.Lotnumber
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Lotnumber = Nothing
					Else
						entity.Lotnumber = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esLotnumber
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esLotnumberQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esLotnumber can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Lotnumber 
		Inherits esLotnumber
		
	
		
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
	MustInherit Public Class esLotnumberQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return LotnumberMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Batchkey As esQueryItem
			Get
				Return New esQueryItem(Me, LotnumberMetadata.ColumnNames.Batchkey, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Createdtime As esQueryItem
			Get
				Return New esQueryItem(Me, LotnumberMetadata.ColumnNames.Createdtime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Createdby As esQueryItem
			Get
				Return New esQueryItem(Me, LotnumberMetadata.ColumnNames.Createdby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Warehouseid As esQueryItem
			Get
				Return New esQueryItem(Me, LotnumberMetadata.ColumnNames.Warehouseid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Receivernumber As esQueryItem
			Get
				Return New esQueryItem(Me, LotnumberMetadata.ColumnNames.Receivernumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Lotnumber As esQueryItem
			Get
				Return New esQueryItem(Me, LotnumberMetadata.ColumnNames.Lotnumber, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("LotnumberCollection")> _
	Partial Public Class LotnumberCollection
		Inherits esLotnumberCollection
		Implements IEnumerable(Of Lotnumber)
		
        Public Shared Widening Operator CType(ByVal coll As LotnumberCollection) As List(Of Lotnumber)
            Dim list As List(Of Lotnumber) = New List(Of Lotnumber)
            Dim emp As Lotnumber

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return LotnumberMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New LotnumberQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Lotnumber(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Lotnumber()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As LotnumberQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New LotnumberQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As LotnumberQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Lotnumber 
			Return CType(MyBase.AddNewEntity(), Lotnumber)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal batchkey As System.Int32) As Lotnumber
			Return CType(MyBase.FindByPrimaryKey(batchkey), Lotnumber)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Lotnumber) Implements IEnumerable(Of Lotnumber).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Lotnumber)(Me)
        End Function
		
		Private _query As LotnumberQuery

	End Class
	


	' <summary>
	' Encapsulates the 'LOTNUMBER' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Lotnumber ({Batchkey.Value})")> _
	<Serializable> _
	Partial Public Class Lotnumber 
		Inherits esLotnumber

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return LotnumberMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esLotnumberQuery

			If Me._query Is Nothing Then
				Me._query = New LotnumberQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As LotnumberQuery
			Get

				If Me._query Is Nothing then
					Me._query = New LotnumberQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As LotnumberQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As LotnumberQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class LotnumberQuery
		inherits esLotnumberQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "LotnumberQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class LotnumberMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(LotnumberMetadata.ColumnNames.Batchkey, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = LotnumberMetadata.PropertyNames.Batchkey
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(LotnumberMetadata.ColumnNames.Createdtime, 1, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = LotnumberMetadata.PropertyNames.Createdtime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LotnumberMetadata.ColumnNames.Createdby, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = LotnumberMetadata.PropertyNames.Createdby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LotnumberMetadata.ColumnNames.Warehouseid, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = LotnumberMetadata.PropertyNames.Warehouseid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LotnumberMetadata.ColumnNames.Receivernumber, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = LotnumberMetadata.PropertyNames.Receivernumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LotnumberMetadata.ColumnNames.Lotnumber, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = LotnumberMetadata.PropertyNames.Lotnumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As LotnumberMetadata
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
			 Public Const Batchkey As String = "BATCHKEY"
			 Public Const Createdtime As String = "CREATEDTIME"
			 Public Const Createdby As String = "CREATEDBY"
			 Public Const Warehouseid As String = "WAREHOUSEID"
			 Public Const Receivernumber As String = "RECEIVERNUMBER"
			 Public Const Lotnumber As String = "LOTNUMBER"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Batchkey As String = "Batchkey"
			 Public Const Createdtime As String = "Createdtime"
			 Public Const Createdby As String = "Createdby"
			 Public Const Warehouseid As String = "Warehouseid"
			 Public Const Receivernumber As String = "Receivernumber"
			 Public Const Lotnumber As String = "Lotnumber"
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
            SyncLock GetType(LotnumberMetadata)
			
				If LotnumberMetadata.mapDelegates Is Nothing Then
					LotnumberMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If LotnumberMetadata._meta Is Nothing Then
                    LotnumberMetadata._meta = New LotnumberMetadata()
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
				

				meta.AddTypeMap("Batchkey", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Createdtime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Createdby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Warehouseid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Receivernumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Lotnumber", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "LOTNUMBER"
				meta.Destination = "LOTNUMBER"
				
				meta.spInsert = "proc_LOTNUMBERInsert"
				meta.spUpdate = "proc_LOTNUMBERUpdate"
				meta.spDelete = "proc_LOTNUMBERDelete"
				meta.spLoadAll = "proc_LOTNUMBERLoadAll"
				meta.spLoadByPrimaryKey = "proc_LOTNUMBERLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As LotnumberMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
