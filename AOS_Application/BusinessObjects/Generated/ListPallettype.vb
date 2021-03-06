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
	MustInherit Public Class esListPallettypeCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ListPallettypeCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esListPallettypeQuery)
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
            Me.InitQuery(CType(query, esListPallettypeQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ListPallettype) As ListPallettype
			Return CType(MyBase.DetachEntity(entity), ListPallettype)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ListPallettype) As ListPallettype
			Return CType(MyBase.AttachEntity(entity), ListPallettype)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ListPallettypeCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ListPallettype
            Get
                Return TryCast(MyBase.Item(index), ListPallettype)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ListPallettype)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esListPallettype	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esListPallettypeQuery
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
		
			Dim query As esListPallettypeQuery = Me.GetDynamicQuery()
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
												
						Case "Pallettype"
							Me.str.Pallettype = CType(value, string)
												
						Case "Palletweight"
							Me.str.Palletweight = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Recid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Recid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Palletweight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Palletweight = CType(value, Nullable(Of System.Int32))
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
		' Maps to LIST_PALLETTYPE.RECID
		' </summary>
		Public Overridable Property Recid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ListPallettypeMetadata.ColumnNames.Recid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ListPallettypeMetadata.ColumnNames.Recid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LIST_PALLETTYPE.PALLETTYPE
		' </summary>
		Public Overridable Property Pallettype As System.String
			Get
				Return MyBase.GetSystemString(ListPallettypeMetadata.ColumnNames.Pallettype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ListPallettypeMetadata.ColumnNames.Pallettype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LIST_PALLETTYPE.PALLETWEIGHT
		' </summary>
		Public Overridable Property Palletweight As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ListPallettypeMetadata.ColumnNames.Palletweight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ListPallettypeMetadata.ColumnNames.Palletweight, value)
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
		
			Public Sub New(ByVal entity As esListPallettype)
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
		  	
			Public Property Pallettype As System.String 
				Get
					Dim data_ As System.String = entity.Pallettype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Pallettype = Nothing
					Else
						entity.Pallettype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Palletweight As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Palletweight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Palletweight = Nothing
					Else
						entity.Palletweight = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esListPallettype
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esListPallettypeQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esListPallettype can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class ListPallettype 
		Inherits esListPallettype
		
	
		
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
	MustInherit Public Class esListPallettypeQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ListPallettypeMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Recid As esQueryItem
			Get
				Return New esQueryItem(Me, ListPallettypeMetadata.ColumnNames.Recid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Pallettype As esQueryItem
			Get
				Return New esQueryItem(Me, ListPallettypeMetadata.ColumnNames.Pallettype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Palletweight As esQueryItem
			Get
				Return New esQueryItem(Me, ListPallettypeMetadata.ColumnNames.Palletweight, esSystemType.Int32)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ListPallettypeCollection")> _
	Partial Public Class ListPallettypeCollection
		Inherits esListPallettypeCollection
		Implements IEnumerable(Of ListPallettype)
		
        Public Shared Widening Operator CType(ByVal coll As ListPallettypeCollection) As List(Of ListPallettype)
            Dim list As List(Of ListPallettype) = New List(Of ListPallettype)
            Dim emp As ListPallettype

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ListPallettypeMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ListPallettypeQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ListPallettype(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ListPallettype()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As ListPallettypeQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ListPallettypeQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ListPallettypeQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ListPallettype 
			Return CType(MyBase.AddNewEntity(), ListPallettype)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal recid As System.Int32) As ListPallettype
			Return CType(MyBase.FindByPrimaryKey(recid), ListPallettype)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ListPallettype) Implements IEnumerable(Of ListPallettype).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ListPallettype)(Me)
        End Function
		
		Private _query As ListPallettypeQuery

	End Class
	


	' <summary>
	' Encapsulates the 'LIST_PALLETTYPE' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ListPallettype ({Recid.Value})")> _
	<Serializable> _
	Partial Public Class ListPallettype 
		Inherits esListPallettype

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ListPallettypeMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esListPallettypeQuery

			If Me._query Is Nothing Then
				Me._query = New ListPallettypeQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ListPallettypeQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ListPallettypeQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ListPallettypeQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ListPallettypeQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ListPallettypeQuery
		inherits esListPallettypeQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ListPallettypeQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ListPallettypeMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ListPallettypeMetadata.ColumnNames.Recid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ListPallettypeMetadata.PropertyNames.Recid
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ListPallettypeMetadata.ColumnNames.Pallettype, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ListPallettypeMetadata.PropertyNames.Pallettype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ListPallettypeMetadata.ColumnNames.Palletweight, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ListPallettypeMetadata.PropertyNames.Palletweight
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ListPallettypeMetadata
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
			 Public Const Pallettype As String = "PALLETTYPE"
			 Public Const Palletweight As String = "PALLETWEIGHT"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Recid As String = "Recid"
			 Public Const Pallettype As String = "Pallettype"
			 Public Const Palletweight As String = "Palletweight"
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
            SyncLock GetType(ListPallettypeMetadata)
			
				If ListPallettypeMetadata.mapDelegates Is Nothing Then
					ListPallettypeMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ListPallettypeMetadata._meta Is Nothing Then
                    ListPallettypeMetadata._meta = New ListPallettypeMetadata()
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
				meta.AddTypeMap("Pallettype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Palletweight", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "LIST_PALLETTYPE"
				meta.Destination = "LIST_PALLETTYPE"
				
				meta.spInsert = "proc_LIST_PALLETTYPEInsert"
				meta.spUpdate = "proc_LIST_PALLETTYPEUpdate"
				meta.spDelete = "proc_LIST_PALLETTYPEDelete"
				meta.spLoadAll = "proc_LIST_PALLETTYPELoadAll"
				meta.spLoadByPrimaryKey = "proc_LIST_PALLETTYPELoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ListPallettypeMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
