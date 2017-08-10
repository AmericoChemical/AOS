'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 11/20/2014 11:20:47 PM
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
	MustInherit Public Class esListCosttypeCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ListCosttypeCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esListCosttypeQuery)
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
            Me.InitQuery(CType(query, esListCosttypeQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ListCosttype) As ListCosttype
			Return CType(MyBase.DetachEntity(entity), ListCosttype)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ListCosttype) As ListCosttype
			Return CType(MyBase.AttachEntity(entity), ListCosttype)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ListCosttypeCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ListCosttype
            Get
                Return TryCast(MyBase.Item(index), ListCosttype)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ListCosttype)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esListCosttype	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esListCosttypeQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal recID As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(recID)
			Else
				Return LoadByPrimaryKeyStoredProcedure(recID)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal recID As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(recID)
			Else
				Return LoadByPrimaryKeyStoredProcedure(recID)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal recID As System.Int32) As Boolean
		
			Dim query As esListCosttypeQuery = Me.GetDynamicQuery()
			query.Where(query.RecID.Equal(recID))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal recID As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("RecID", recID)
			
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
												
						Case "RecID"
							Me.str.RecID = CType(value, string)
												
						Case "Costtype"
							Me.str.Costtype = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "RecID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RecID = CType(value, Nullable(Of System.Int32))
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
		' Maps to LIST_COSTTYPE.RecID
		' </summary>
		Public Overridable Property RecID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ListCosttypeMetadata.ColumnNames.RecID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ListCosttypeMetadata.ColumnNames.RecID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LIST_COSTTYPE.COSTTYPE
		' </summary>
		Public Overridable Property Costtype As System.String
			Get
				Return MyBase.GetSystemString(ListCosttypeMetadata.ColumnNames.Costtype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ListCosttypeMetadata.ColumnNames.Costtype, value)
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
		
			Public Sub New(ByVal entity As esListCosttype)
				Me.entity = entity
			End Sub				
		
	
			Public Property RecID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.RecID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RecID = Nothing
					Else
						entity.RecID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Costtype As System.String 
				Get
					Dim data_ As System.String = entity.Costtype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Costtype = Nothing
					Else
						entity.Costtype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esListCosttype
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esListCosttypeQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esListCosttype can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class ListCosttype 
		Inherits esListCosttype
		
	
		
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
	MustInherit Public Class esListCosttypeQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ListCosttypeMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property RecID As esQueryItem
			Get
				Return New esQueryItem(Me, ListCosttypeMetadata.ColumnNames.RecID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Costtype As esQueryItem
			Get
				Return New esQueryItem(Me, ListCosttypeMetadata.ColumnNames.Costtype, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ListCosttypeCollection")> _
	Partial Public Class ListCosttypeCollection
		Inherits esListCosttypeCollection
		Implements IEnumerable(Of ListCosttype)
		
        Public Shared Widening Operator CType(ByVal coll As ListCosttypeCollection) As List(Of ListCosttype)
            Dim list As List(Of ListCosttype) = New List(Of ListCosttype)
            Dim emp As ListCosttype

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ListCosttypeMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ListCosttypeQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ListCosttype(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ListCosttype()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As ListCosttypeQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ListCosttypeQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ListCosttypeQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ListCosttype 
			Return CType(MyBase.AddNewEntity(), ListCosttype)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal recID As System.Int32) As ListCosttype
			Return CType(MyBase.FindByPrimaryKey(recID), ListCosttype)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ListCosttype) Implements IEnumerable(Of ListCosttype).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ListCosttype)(Me)
        End Function
		
		Private _query As ListCosttypeQuery

	End Class
	


	' <summary>
	' Encapsulates the 'LIST_COSTTYPE' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ListCosttype ({RecID.Value})")> _
	<Serializable> _
	Partial Public Class ListCosttype 
		Inherits esListCosttype

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ListCosttypeMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esListCosttypeQuery

			If Me._query Is Nothing Then
				Me._query = New ListCosttypeQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ListCosttypeQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ListCosttypeQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ListCosttypeQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ListCosttypeQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ListCosttypeQuery
		inherits esListCosttypeQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ListCosttypeQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ListCosttypeMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ListCosttypeMetadata.ColumnNames.RecID, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ListCosttypeMetadata.PropertyNames.RecID
			c.IsInPrimaryKey = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ListCosttypeMetadata.ColumnNames.Costtype, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ListCosttypeMetadata.PropertyNames.Costtype
			c.CharacterMaxLength = 10
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ListCosttypeMetadata
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
			 Public Const RecID As String = "RecID"
			 Public Const Costtype As String = "COSTTYPE"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const RecID As String = "RecID"
			 Public Const Costtype As String = "Costtype"
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
            SyncLock GetType(ListCosttypeMetadata)
			
				If ListCosttypeMetadata.mapDelegates Is Nothing Then
					ListCosttypeMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ListCosttypeMetadata._meta Is Nothing Then
                    ListCosttypeMetadata._meta = New ListCosttypeMetadata()
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
				

				meta.AddTypeMap("RecID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Costtype", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "LIST_COSTTYPE"
				meta.Destination = "LIST_COSTTYPE"
				
				meta.spInsert = "proc_LIST_COSTTYPEInsert"
				meta.spUpdate = "proc_LIST_COSTTYPEUpdate"
				meta.spDelete = "proc_LIST_COSTTYPEDelete"
				meta.spLoadAll = "proc_LIST_COSTTYPELoadAll"
				meta.spLoadByPrimaryKey = "proc_LIST_COSTTYPELoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ListCosttypeMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
