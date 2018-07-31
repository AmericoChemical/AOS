'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 3/13/2014 9:33:05 AM
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
	MustInherit Public Class esLoadapbatchCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "LoadapbatchCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esLoadapbatchQuery)
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
            Me.InitQuery(CType(query, esLoadapbatchQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Loadapbatch) As Loadapbatch
			Return CType(MyBase.DetachEntity(entity), Loadapbatch)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Loadapbatch) As Loadapbatch
			Return CType(MyBase.AttachEntity(entity), Loadapbatch)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As LoadapbatchCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Loadapbatch
            Get
                Return TryCast(MyBase.Item(index), Loadapbatch)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Loadapbatch)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esLoadapbatch	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esLoadapbatchQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal aPBatchID As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(aPBatchID)
			Else
				Return LoadByPrimaryKeyStoredProcedure(aPBatchID)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal aPBatchID As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(aPBatchID)
			Else
				Return LoadByPrimaryKeyStoredProcedure(aPBatchID)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal aPBatchID As System.Int32) As Boolean
		
			Dim query As esLoadapbatchQuery = Me.GetDynamicQuery()
			query.Where(query.APBatchID.Equal(aPBatchID))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal aPBatchID As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("APBatchID", aPBatchID)
			
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
												
						Case "APBatchID"
							Me.str.APBatchID = CType(value, string)
												
						Case "APBatchDate"
							Me.str.APBatchDate = CType(value, string)
												
						Case "CreatedBy"
							Me.str.CreatedBy = CType(value, string)
												
						Case "BatchStatus"
							Me.str.BatchStatus = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "APBatchID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.APBatchID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "APBatchDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.APBatchDate = CType(value, Nullable(Of System.DateTime))
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
		' Maps to LOADAPBATCH.APBatchID
		' </summary>
		Public Overridable Property APBatchID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(LoadapbatchMetadata.ColumnNames.APBatchID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(LoadapbatchMetadata.ColumnNames.APBatchID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADAPBATCH.APBatchDate
		' </summary>
		Public Overridable Property APBatchDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(LoadapbatchMetadata.ColumnNames.APBatchDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(LoadapbatchMetadata.ColumnNames.APBatchDate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADAPBATCH.CreatedBy
		' </summary>
		Public Overridable Property CreatedBy As System.String
			Get
				Return MyBase.GetSystemString(LoadapbatchMetadata.ColumnNames.CreatedBy)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LoadapbatchMetadata.ColumnNames.CreatedBy, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADAPBATCH.BatchStatus
		' </summary>
		Public Overridable Property BatchStatus As System.String
			Get
				Return MyBase.GetSystemString(LoadapbatchMetadata.ColumnNames.BatchStatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LoadapbatchMetadata.ColumnNames.BatchStatus, value)
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
		
			Public Sub New(ByVal entity As esLoadapbatch)
				Me.entity = entity
			End Sub				
		
	
			Public Property APBatchID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.APBatchID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.APBatchID = Nothing
					Else
						entity.APBatchID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property APBatchDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.APBatchDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.APBatchDate = Nothing
					Else
						entity.APBatchDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property CreatedBy As System.String 
				Get
					Dim data_ As System.String = entity.CreatedBy
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CreatedBy = Nothing
					Else
						entity.CreatedBy = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BatchStatus As System.String 
				Get
					Dim data_ As System.String = entity.BatchStatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BatchStatus = Nothing
					Else
						entity.BatchStatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esLoadapbatch
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esLoadapbatchQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esLoadapbatch can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Loadapbatch 
		Inherits esLoadapbatch
		
	
		
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
	MustInherit Public Class esLoadapbatchQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return LoadapbatchMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property APBatchID As esQueryItem
			Get
				Return New esQueryItem(Me, LoadapbatchMetadata.ColumnNames.APBatchID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property APBatchDate As esQueryItem
			Get
				Return New esQueryItem(Me, LoadapbatchMetadata.ColumnNames.APBatchDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property CreatedBy As esQueryItem
			Get
				Return New esQueryItem(Me, LoadapbatchMetadata.ColumnNames.CreatedBy, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BatchStatus As esQueryItem
			Get
				Return New esQueryItem(Me, LoadapbatchMetadata.ColumnNames.BatchStatus, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("LoadapbatchCollection")> _
	Partial Public Class LoadapbatchCollection
		Inherits esLoadapbatchCollection
		Implements IEnumerable(Of Loadapbatch)
		
        Public Shared Widening Operator CType(ByVal coll As LoadapbatchCollection) As List(Of Loadapbatch)
            Dim list As List(Of Loadapbatch) = New List(Of Loadapbatch)
            Dim emp As Loadapbatch

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return LoadapbatchMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New LoadapbatchQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Loadapbatch(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Loadapbatch()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As LoadapbatchQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New LoadapbatchQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As LoadapbatchQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Loadapbatch 
			Return CType(MyBase.AddNewEntity(), Loadapbatch)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal aPBatchID As System.Int32) As Loadapbatch
			Return CType(MyBase.FindByPrimaryKey(aPBatchID), Loadapbatch)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Loadapbatch) Implements IEnumerable(Of Loadapbatch).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Loadapbatch)(Me)
        End Function
		
		Private _query As LoadapbatchQuery

	End Class
	


	' <summary>
	' Encapsulates the 'LOADAPBATCH' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Loadapbatch ({APBatchID.Value})")> _
	<Serializable> _
	Partial Public Class Loadapbatch 
		Inherits esLoadapbatch

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return LoadapbatchMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esLoadapbatchQuery

			If Me._query Is Nothing Then
				Me._query = New LoadapbatchQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As LoadapbatchQuery
			Get

				If Me._query Is Nothing then
					Me._query = New LoadapbatchQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As LoadapbatchQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As LoadapbatchQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class LoadapbatchQuery
		inherits esLoadapbatchQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "LoadapbatchQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class LoadapbatchMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(LoadapbatchMetadata.ColumnNames.APBatchID, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = LoadapbatchMetadata.PropertyNames.APBatchID
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(LoadapbatchMetadata.ColumnNames.APBatchDate, 1, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = LoadapbatchMetadata.PropertyNames.APBatchDate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoadapbatchMetadata.ColumnNames.CreatedBy, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = LoadapbatchMetadata.PropertyNames.CreatedBy
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoadapbatchMetadata.ColumnNames.BatchStatus, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = LoadapbatchMetadata.PropertyNames.BatchStatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As LoadapbatchMetadata
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
			 Public Const APBatchID As String = "APBatchID"
			 Public Const APBatchDate As String = "APBatchDate"
			 Public Const CreatedBy As String = "CreatedBy"
			 Public Const BatchStatus As String = "BatchStatus"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const APBatchID As String = "APBatchID"
			 Public Const APBatchDate As String = "APBatchDate"
			 Public Const CreatedBy As String = "CreatedBy"
			 Public Const BatchStatus As String = "BatchStatus"
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
            SyncLock GetType(LoadapbatchMetadata)
			
				If LoadapbatchMetadata.mapDelegates Is Nothing Then
					LoadapbatchMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If LoadapbatchMetadata._meta Is Nothing Then
                    LoadapbatchMetadata._meta = New LoadapbatchMetadata()
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
				

				meta.AddTypeMap("APBatchID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("APBatchDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("CreatedBy", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("BatchStatus", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "LOADAPBATCH"
				meta.Destination = "LOADAPBATCH"
				
				meta.spInsert = "proc_LOADAPBATCHInsert"
				meta.spUpdate = "proc_LOADAPBATCHUpdate"
				meta.spDelete = "proc_LOADAPBATCHDelete"
				meta.spLoadAll = "proc_LOADAPBATCHLoadAll"
				meta.spLoadByPrimaryKey = "proc_LOADAPBATCHLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As LoadapbatchMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
