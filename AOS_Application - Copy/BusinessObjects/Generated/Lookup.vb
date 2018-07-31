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
	MustInherit Public Class esLookupCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "LookupCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esLookupQuery)
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
            Me.InitQuery(CType(query, esLookupQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Lookup) As Lookup
			Return CType(MyBase.DetachEntity(entity), Lookup)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Lookup) As Lookup
			Return CType(MyBase.AttachEntity(entity), Lookup)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As LookupCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Lookup
            Get
                Return TryCast(MyBase.Item(index), Lookup)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Lookup)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esLookup	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esLookupQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal lookupID As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(lookupID)
			Else
				Return LoadByPrimaryKeyStoredProcedure(lookupID)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal lookupID As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(lookupID)
			Else
				Return LoadByPrimaryKeyStoredProcedure(lookupID)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal lookupID As System.Int32) As Boolean
		
			Dim query As esLookupQuery = Me.GetDynamicQuery()
			query.Where(query.LookupID.Equal(lookupID))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal lookupID As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("LookupID", lookupID)
			
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
												
						Case "LookupID"
							Me.str.LookupID = CType(value, string)
												
						Case "LookupGroup"
							Me.str.LookupGroup = CType(value, string)
												
						Case "LookUpValue"
							Me.str.LookUpValue = CType(value, string)
												
						Case "LookupDesc"
							Me.str.LookupDesc = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "LookupID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.LookupID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "LookUpValue"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.LookUpValue = CType(value, Nullable(Of System.Int32))
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
		' Maps to LOOKUP.LookupID
		' </summary>
		Public Overridable Property LookupID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(LookupMetadata.ColumnNames.LookupID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(LookupMetadata.ColumnNames.LookupID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOOKUP.LookupGroup
		' </summary>
		Public Overridable Property LookupGroup As System.String
			Get
				Return MyBase.GetSystemString(LookupMetadata.ColumnNames.LookupGroup)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LookupMetadata.ColumnNames.LookupGroup, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOOKUP.LookUpValue
		' </summary>
		Public Overridable Property LookUpValue As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(LookupMetadata.ColumnNames.LookUpValue)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(LookupMetadata.ColumnNames.LookUpValue, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOOKUP.LookupDesc
		' </summary>
		Public Overridable Property LookupDesc As System.String
			Get
				Return MyBase.GetSystemString(LookupMetadata.ColumnNames.LookupDesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LookupMetadata.ColumnNames.LookupDesc, value)
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
		
			Public Sub New(ByVal entity As esLookup)
				Me.entity = entity
			End Sub				
		
	
			Public Property LookupID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.LookupID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LookupID = Nothing
					Else
						entity.LookupID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property LookupGroup As System.String 
				Get
					Dim data_ As System.String = entity.LookupGroup
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LookupGroup = Nothing
					Else
						entity.LookupGroup = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property LookUpValue As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.LookUpValue
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LookUpValue = Nothing
					Else
						entity.LookUpValue = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property LookupDesc As System.String 
				Get
					Dim data_ As System.String = entity.LookupDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LookupDesc = Nothing
					Else
						entity.LookupDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esLookup
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esLookupQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esLookup can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Lookup 
		Inherits esLookup
		
	
		
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
	MustInherit Public Class esLookupQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return LookupMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property LookupID As esQueryItem
			Get
				Return New esQueryItem(Me, LookupMetadata.ColumnNames.LookupID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LookupGroup As esQueryItem
			Get
				Return New esQueryItem(Me, LookupMetadata.ColumnNames.LookupGroup, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LookUpValue As esQueryItem
			Get
				Return New esQueryItem(Me, LookupMetadata.ColumnNames.LookUpValue, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LookupDesc As esQueryItem
			Get
				Return New esQueryItem(Me, LookupMetadata.ColumnNames.LookupDesc, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("LookupCollection")> _
	Partial Public Class LookupCollection
		Inherits esLookupCollection
		Implements IEnumerable(Of Lookup)
		
        Public Shared Widening Operator CType(ByVal coll As LookupCollection) As List(Of Lookup)
            Dim list As List(Of Lookup) = New List(Of Lookup)
            Dim emp As Lookup

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return LookupMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New LookupQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Lookup(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Lookup()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As LookupQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New LookupQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As LookupQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Lookup 
			Return CType(MyBase.AddNewEntity(), Lookup)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal lookupID As System.Int32) As Lookup
			Return CType(MyBase.FindByPrimaryKey(lookupID), Lookup)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Lookup) Implements IEnumerable(Of Lookup).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Lookup)(Me)
        End Function
		
		Private _query As LookupQuery

	End Class
	


	' <summary>
	' Encapsulates the 'LOOKUP' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Lookup ({LookupID.Value})")> _
	<Serializable> _
	Partial Public Class Lookup 
		Inherits esLookup

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return LookupMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esLookupQuery

			If Me._query Is Nothing Then
				Me._query = New LookupQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As LookupQuery
			Get

				If Me._query Is Nothing then
					Me._query = New LookupQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As LookupQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As LookupQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class LookupQuery
		inherits esLookupQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "LookupQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class LookupMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(LookupMetadata.ColumnNames.LookupID, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = LookupMetadata.PropertyNames.LookupID
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(LookupMetadata.ColumnNames.LookupGroup, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = LookupMetadata.PropertyNames.LookupGroup
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LookupMetadata.ColumnNames.LookUpValue, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = LookupMetadata.PropertyNames.LookUpValue
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LookupMetadata.ColumnNames.LookupDesc, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = LookupMetadata.PropertyNames.LookupDesc
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As LookupMetadata
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
			 Public Const LookupID As String = "LookupID"
			 Public Const LookupGroup As String = "LookupGroup"
			 Public Const LookUpValue As String = "LookUpValue"
			 Public Const LookupDesc As String = "LookupDesc"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const LookupID As String = "LookupID"
			 Public Const LookupGroup As String = "LookupGroup"
			 Public Const LookUpValue As String = "LookUpValue"
			 Public Const LookupDesc As String = "LookupDesc"
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
            SyncLock GetType(LookupMetadata)
			
				If LookupMetadata.mapDelegates Is Nothing Then
					LookupMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If LookupMetadata._meta Is Nothing Then
                    LookupMetadata._meta = New LookupMetadata()
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
				

				meta.AddTypeMap("LookupID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("LookupGroup", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("LookUpValue", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("LookupDesc", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "LOOKUP"
				meta.Destination = "LOOKUP"
				
				meta.spInsert = "proc_LOOKUPInsert"
				meta.spUpdate = "proc_LOOKUPUpdate"
				meta.spDelete = "proc_LOOKUPDelete"
				meta.spLoadAll = "proc_LOOKUPLoadAll"
				meta.spLoadByPrimaryKey = "proc_LOOKUPLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As LookupMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
