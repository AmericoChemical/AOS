'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 9/11/2015 2:45:57 PM
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
	MustInherit Public Class esListContainertypeCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ListContainertypeCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esListContainertypeQuery)
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
            Me.InitQuery(CType(query, esListContainertypeQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ListContainertype) As ListContainertype
			Return CType(MyBase.DetachEntity(entity), ListContainertype)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ListContainertype) As ListContainertype
			Return CType(MyBase.AttachEntity(entity), ListContainertype)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ListContainertypeCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ListContainertype
            Get
                Return TryCast(MyBase.Item(index), ListContainertype)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ListContainertype)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esListContainertype	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esListContainertypeQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal recid As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(recid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(recid)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal recid As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(recid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(recid)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal recid As System.Int32) As Boolean
		
			Dim query As esListContainertypeQuery = Me.GetDynamicQuery()
			query.Where(query.Recid.Equal(recid))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal recid As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("RECID", recid)
			
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
												
						Case "Recid"
							Me.str.Recid = CType(value, string)
												
						Case "Containertype"
							Me.str.Containertype = CType(value, string)
												
						Case "Tareweight"
							Me.str.Tareweight = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Recid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Recid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Tareweight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Tareweight = CType(value, Nullable(Of System.Decimal))
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
		' Maps to LIST_CONTAINERTYPE.RECID
		' </summary>
		Public Overridable Property Recid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ListContainertypeMetadata.ColumnNames.Recid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ListContainertypeMetadata.ColumnNames.Recid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LIST_CONTAINERTYPE.CONTAINERTYPE
		' </summary>
		Public Overridable Property Containertype As System.String
			Get
				Return MyBase.GetSystemString(ListContainertypeMetadata.ColumnNames.Containertype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ListContainertypeMetadata.ColumnNames.Containertype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LIST_CONTAINERTYPE.TAREWEIGHT
		' </summary>
		Public Overridable Property Tareweight As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ListContainertypeMetadata.ColumnNames.Tareweight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ListContainertypeMetadata.ColumnNames.Tareweight, value)
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
		
			Public Sub New(ByVal entity As esListContainertype)
				Me.entity = entity
			End Sub				
		
	
			Public Property Recid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Recid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Recid = Nothing
					Else
						entity.Recid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Containertype As System.String 
				Get
					Dim data_ As System.String = entity.Containertype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Containertype = Nothing
					Else
						entity.Containertype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Tareweight As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Tareweight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Tareweight = Nothing
					Else
						entity.Tareweight = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  

			Private entity As esListContainertype
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esListContainertypeQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esListContainertype can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class ListContainertype 
		Inherits esListContainertype
		
	
		
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
	MustInherit Public Class esListContainertypeQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ListContainertypeMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Recid As esQueryItem
			Get
				Return New esQueryItem(Me, ListContainertypeMetadata.ColumnNames.Recid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Containertype As esQueryItem
			Get
				Return New esQueryItem(Me, ListContainertypeMetadata.ColumnNames.Containertype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Tareweight As esQueryItem
			Get
				Return New esQueryItem(Me, ListContainertypeMetadata.ColumnNames.Tareweight, esSystemType.Decimal)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ListContainertypeCollection")> _
	Partial Public Class ListContainertypeCollection
		Inherits esListContainertypeCollection
		Implements IEnumerable(Of ListContainertype)
		
        Public Shared Widening Operator CType(ByVal coll As ListContainertypeCollection) As List(Of ListContainertype)
            Dim list As List(Of ListContainertype) = New List(Of ListContainertype)
            Dim emp As ListContainertype

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ListContainertypeMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ListContainertypeQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ListContainertype(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ListContainertype()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As ListContainertypeQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ListContainertypeQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ListContainertypeQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ListContainertype 
			Return CType(MyBase.AddNewEntity(), ListContainertype)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal recid As System.Int32) As ListContainertype
			Return CType(MyBase.FindByPrimaryKey(recid), ListContainertype)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ListContainertype) Implements IEnumerable(Of ListContainertype).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ListContainertype)(Me)
        End Function
		
		Private _query As ListContainertypeQuery

	End Class
	


	' <summary>
	' Encapsulates the 'LIST_CONTAINERTYPE' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ListContainertype ({Recid.Value})")> _
	<Serializable> _
	Partial Public Class ListContainertype 
		Inherits esListContainertype

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ListContainertypeMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esListContainertypeQuery

			If Me._query Is Nothing Then
				Me._query = New ListContainertypeQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ListContainertypeQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ListContainertypeQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ListContainertypeQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ListContainertypeQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ListContainertypeQuery
		inherits esListContainertypeQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ListContainertypeQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ListContainertypeMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ListContainertypeMetadata.ColumnNames.Recid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ListContainertypeMetadata.PropertyNames.Recid
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ListContainertypeMetadata.ColumnNames.Containertype, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ListContainertypeMetadata.PropertyNames.Containertype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ListContainertypeMetadata.ColumnNames.Tareweight, 2, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ListContainertypeMetadata.PropertyNames.Tareweight
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ListContainertypeMetadata
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
			 Public Const Recid As String = "RECID"
			 Public Const Containertype As String = "CONTAINERTYPE"
			 Public Const Tareweight As String = "TAREWEIGHT"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Recid As String = "Recid"
			 Public Const Containertype As String = "Containertype"
			 Public Const Tareweight As String = "Tareweight"
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
            SyncLock GetType(ListContainertypeMetadata)
			
				If ListContainertypeMetadata.mapDelegates Is Nothing Then
					ListContainertypeMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ListContainertypeMetadata._meta Is Nothing Then
                    ListContainertypeMetadata._meta = New ListContainertypeMetadata()
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
				

				meta.AddTypeMap("Recid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Containertype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Tareweight", new esTypeMap("decimal", "System.Decimal"))			
				
				
				 
				meta.Source = "LIST_CONTAINERTYPE"
				meta.Destination = "LIST_CONTAINERTYPE"
				
				meta.spInsert = "proc_LIST_CONTAINERTYPEInsert"
				meta.spUpdate = "proc_LIST_CONTAINERTYPEUpdate"
				meta.spDelete = "proc_LIST_CONTAINERTYPEDelete"
				meta.spLoadAll = "proc_LIST_CONTAINERTYPELoadAll"
				meta.spLoadByPrimaryKey = "proc_LIST_CONTAINERTYPELoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ListContainertypeMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
