'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 4/15/2014 10:44:05 AM
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
	MustInherit Public Class esListBillingtypeCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ListBillingtypeCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esListBillingtypeQuery)
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
            Me.InitQuery(CType(query, esListBillingtypeQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ListBillingtype) As ListBillingtype
			Return CType(MyBase.DetachEntity(entity), ListBillingtype)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ListBillingtype) As ListBillingtype
			Return CType(MyBase.AttachEntity(entity), ListBillingtype)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ListBillingtypeCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ListBillingtype
            Get
                Return TryCast(MyBase.Item(index), ListBillingtype)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ListBillingtype)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esListBillingtype	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esListBillingtypeQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal billingtype As System.String) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(billingtype)
			Else
				Return LoadByPrimaryKeyStoredProcedure(billingtype)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal billingtype As System.String) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(billingtype)
			Else
				Return LoadByPrimaryKeyStoredProcedure(billingtype)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal billingtype As System.String) As Boolean
		
			Dim query As esListBillingtypeQuery = Me.GetDynamicQuery()
			query.Where(query.Billingtype.Equal(billingtype))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal billingtype As System.String) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("BILLINGTYPE", billingtype)
			
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
												
						Case "Billingtype"
							Me.str.Billingtype = CType(value, string)
												
						Case "Sortsequence"
							Me.str.Sortsequence = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Sortsequence"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Sortsequence = CType(value, Nullable(Of System.Int32))
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
		' Maps to LIST_BILLINGTYPE.BILLINGTYPE
		' </summary>
		Public Overridable Property Billingtype As System.String
			Get
				Return MyBase.GetSystemString(ListBillingtypeMetadata.ColumnNames.Billingtype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ListBillingtypeMetadata.ColumnNames.Billingtype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LIST_BILLINGTYPE.SORTSEQUENCE
		' </summary>
		Public Overridable Property Sortsequence As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ListBillingtypeMetadata.ColumnNames.Sortsequence)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ListBillingtypeMetadata.ColumnNames.Sortsequence, value)
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
		
			Public Sub New(ByVal entity As esListBillingtype)
				Me.entity = entity
			End Sub				
		
	
			Public Property Billingtype As System.String 
				Get
					Dim data_ As System.String = entity.Billingtype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Billingtype = Nothing
					Else
						entity.Billingtype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Sortsequence As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Sortsequence
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Sortsequence = Nothing
					Else
						entity.Sortsequence = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esListBillingtype
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esListBillingtypeQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esListBillingtype can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class ListBillingtype 
		Inherits esListBillingtype
		
	
		
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
	MustInherit Public Class esListBillingtypeQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ListBillingtypeMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Billingtype As esQueryItem
			Get
				Return New esQueryItem(Me, ListBillingtypeMetadata.ColumnNames.Billingtype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Sortsequence As esQueryItem
			Get
				Return New esQueryItem(Me, ListBillingtypeMetadata.ColumnNames.Sortsequence, esSystemType.Int32)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ListBillingtypeCollection")> _
	Partial Public Class ListBillingtypeCollection
		Inherits esListBillingtypeCollection
		Implements IEnumerable(Of ListBillingtype)
		
        Public Shared Widening Operator CType(ByVal coll As ListBillingtypeCollection) As List(Of ListBillingtype)
            Dim list As List(Of ListBillingtype) = New List(Of ListBillingtype)
            Dim emp As ListBillingtype

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ListBillingtypeMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ListBillingtypeQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ListBillingtype(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ListBillingtype()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As ListBillingtypeQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ListBillingtypeQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ListBillingtypeQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ListBillingtype 
			Return CType(MyBase.AddNewEntity(), ListBillingtype)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal billingtype As System.String) As ListBillingtype
			Return CType(MyBase.FindByPrimaryKey(billingtype), ListBillingtype)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ListBillingtype) Implements IEnumerable(Of ListBillingtype).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ListBillingtype)(Me)
        End Function
		
		Private _query As ListBillingtypeQuery

	End Class
	


	' <summary>
	' Encapsulates the 'LIST_BILLINGTYPE' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ListBillingtype ({Billingtype})")> _
	<Serializable> _
	Partial Public Class ListBillingtype 
		Inherits esListBillingtype

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ListBillingtypeMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esListBillingtypeQuery

			If Me._query Is Nothing Then
				Me._query = New ListBillingtypeQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ListBillingtypeQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ListBillingtypeQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ListBillingtypeQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ListBillingtypeQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ListBillingtypeQuery
		inherits esListBillingtypeQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ListBillingtypeQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ListBillingtypeMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ListBillingtypeMetadata.ColumnNames.Billingtype, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = ListBillingtypeMetadata.PropertyNames.Billingtype
			c.IsInPrimaryKey = True
			c.CharacterMaxLength = 50
			_columns.Add(c)
				
			c = New esColumnMetadata(ListBillingtypeMetadata.ColumnNames.Sortsequence, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ListBillingtypeMetadata.PropertyNames.Sortsequence
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ListBillingtypeMetadata
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
			 Public Const Billingtype As String = "BILLINGTYPE"
			 Public Const Sortsequence As String = "SORTSEQUENCE"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Billingtype As String = "Billingtype"
			 Public Const Sortsequence As String = "Sortsequence"
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
            SyncLock GetType(ListBillingtypeMetadata)
			
				If ListBillingtypeMetadata.mapDelegates Is Nothing Then
					ListBillingtypeMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ListBillingtypeMetadata._meta Is Nothing Then
                    ListBillingtypeMetadata._meta = New ListBillingtypeMetadata()
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
				

				meta.AddTypeMap("Billingtype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Sortsequence", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "LIST_BILLINGTYPE"
				meta.Destination = "LIST_BILLINGTYPE"
				
				meta.spInsert = "proc_LIST_BILLINGTYPEInsert"
				meta.spUpdate = "proc_LIST_BILLINGTYPEUpdate"
				meta.spDelete = "proc_LIST_BILLINGTYPEDelete"
				meta.spLoadAll = "proc_LIST_BILLINGTYPELoadAll"
				meta.spLoadByPrimaryKey = "proc_LIST_BILLINGTYPELoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ListBillingtypeMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
