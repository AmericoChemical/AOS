'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 7/25/2014 8:42:49 PM
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
	MustInherit Public Class esKitCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "KitCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esKitQuery)
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
            Me.InitQuery(CType(query, esKitQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Kit) As Kit
			Return CType(MyBase.DetachEntity(entity), Kit)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Kit) As Kit
			Return CType(MyBase.AttachEntity(entity), Kit)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As KitCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Kit
            Get
                Return TryCast(MyBase.Item(index), Kit)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Kit)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esKit	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esKitQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal kitid As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(kitid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(kitid)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal kitid As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(kitid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(kitid)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal kitid As System.Int32) As Boolean
		
			Dim query As esKitQuery = Me.GetDynamicQuery()
			query.Where(query.Kitid.Equal(kitid))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal kitid As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("KITID", kitid)
			
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
												
						Case "Kitid"
							Me.str.Kitid = CType(value, string)
												
						Case "Kitname"
							Me.str.Kitname = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Kitid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Kitid = CType(value, Nullable(Of System.Int32))
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
		' Maps to KIT.KITID
		' </summary>
		Public Overridable Property Kitid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(KitMetadata.ColumnNames.Kitid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(KitMetadata.ColumnNames.Kitid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to KIT.KITNAME
		' </summary>
		Public Overridable Property Kitname As System.String
			Get
				Return MyBase.GetSystemString(KitMetadata.ColumnNames.Kitname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(KitMetadata.ColumnNames.Kitname, value)
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
		
			Public Sub New(ByVal entity As esKit)
				Me.entity = entity
			End Sub				
		
	
			Public Property Kitid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Kitid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Kitid = Nothing
					Else
						entity.Kitid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Kitname As System.String 
				Get
					Dim data_ As System.String = entity.Kitname
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Kitname = Nothing
					Else
						entity.Kitname = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esKit
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esKitQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esKit can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Kit 
		Inherits esKit
		
	
		
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
	MustInherit Public Class esKitQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return KitMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Kitid As esQueryItem
			Get
				Return New esQueryItem(Me, KitMetadata.ColumnNames.Kitid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Kitname As esQueryItem
			Get
				Return New esQueryItem(Me, KitMetadata.ColumnNames.Kitname, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("KitCollection")> _
	Partial Public Class KitCollection
		Inherits esKitCollection
		Implements IEnumerable(Of Kit)
		
        Public Shared Widening Operator CType(ByVal coll As KitCollection) As List(Of Kit)
            Dim list As List(Of Kit) = New List(Of Kit)
            Dim emp As Kit

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return KitMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New KitQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Kit(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Kit()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As KitQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New KitQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As KitQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Kit 
			Return CType(MyBase.AddNewEntity(), Kit)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal kitid As System.Int32) As Kit
			Return CType(MyBase.FindByPrimaryKey(kitid), Kit)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Kit) Implements IEnumerable(Of Kit).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Kit)(Me)
        End Function
		
		Private _query As KitQuery

	End Class
	


	' <summary>
	' Encapsulates the 'KIT' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Kit ({Kitid.Value})")> _
	<Serializable> _
	Partial Public Class Kit 
		Inherits esKit

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return KitMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esKitQuery

			If Me._query Is Nothing Then
				Me._query = New KitQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
#End Region

		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As KitQuery
			Get

				If Me._query Is Nothing then
					Me._query = New KitQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As KitQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As KitQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class KitQuery
		inherits esKitQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "KitQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class KitMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(KitMetadata.ColumnNames.Kitid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = KitMetadata.PropertyNames.Kitid
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(KitMetadata.ColumnNames.Kitname, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = KitMetadata.PropertyNames.Kitname
			c.CharacterMaxLength = 100
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As KitMetadata
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
			 Public Const Kitid As String = "KITID"
			 Public Const Kitname As String = "KITNAME"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Kitid As String = "Kitid"
			 Public Const Kitname As String = "Kitname"
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
            SyncLock GetType(KitMetadata)
			
				If KitMetadata.mapDelegates Is Nothing Then
					KitMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If KitMetadata._meta Is Nothing Then
                    KitMetadata._meta = New KitMetadata()
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
				

				meta.AddTypeMap("Kitid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Kitname", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "KIT"
				meta.Destination = "KIT"
				
				meta.spInsert = "proc_KITInsert"
				meta.spUpdate = "proc_KITUpdate"
				meta.spDelete = "proc_KITDelete"
				meta.spLoadAll = "proc_KITLoadAll"
				meta.spLoadByPrimaryKey = "proc_KITLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As KitMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
