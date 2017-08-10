'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/11/2014 1:43:56 PM
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
	MustInherit Public Class esListChemappearanceCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ListChemappearanceCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esListChemappearanceQuery)
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
            Me.InitQuery(CType(query, esListChemappearanceQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ListChemappearance) As ListChemappearance
			Return CType(MyBase.DetachEntity(entity), ListChemappearance)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ListChemappearance) As ListChemappearance
			Return CType(MyBase.AttachEntity(entity), ListChemappearance)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ListChemappearanceCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ListChemappearance
            Get
                Return TryCast(MyBase.Item(index), ListChemappearance)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ListChemappearance)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esListChemappearance	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esListChemappearanceQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal appearance As System.String) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(appearance)
			Else
				Return LoadByPrimaryKeyStoredProcedure(appearance)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal appearance As System.String) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(appearance)
			Else
				Return LoadByPrimaryKeyStoredProcedure(appearance)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal appearance As System.String) As Boolean
		
			Dim query As esListChemappearanceQuery = Me.GetDynamicQuery()
			query.Where(query.Appearance.Equal(appearance))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal appearance As System.String) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("APPEARANCE", appearance)
			
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
												
						Case "Appearance"
							Me.str.Appearance = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
					
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
		' Maps to LIST_CHEMAPPEARANCE.APPEARANCE
		' </summary>
		Public Overridable Property Appearance As System.String
			Get
				Return MyBase.GetSystemString(ListChemappearanceMetadata.ColumnNames.Appearance)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ListChemappearanceMetadata.ColumnNames.Appearance, value)
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
		
			Public Sub New(ByVal entity As esListChemappearance)
				Me.entity = entity
			End Sub				
		
	
			Public Property Appearance As System.String 
				Get
					Dim data_ As System.String = entity.Appearance
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Appearance = Nothing
					Else
						entity.Appearance = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esListChemappearance
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esListChemappearanceQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esListChemappearance can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class ListChemappearance 
		Inherits esListChemappearance
		
	
		
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
	MustInherit Public Class esListChemappearanceQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ListChemappearanceMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Appearance As esQueryItem
			Get
				Return New esQueryItem(Me, ListChemappearanceMetadata.ColumnNames.Appearance, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ListChemappearanceCollection")> _
	Partial Public Class ListChemappearanceCollection
		Inherits esListChemappearanceCollection
		Implements IEnumerable(Of ListChemappearance)
		
        Public Shared Widening Operator CType(ByVal coll As ListChemappearanceCollection) As List(Of ListChemappearance)
            Dim list As List(Of ListChemappearance) = New List(Of ListChemappearance)
            Dim emp As ListChemappearance

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ListChemappearanceMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ListChemappearanceQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ListChemappearance(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ListChemappearance()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As ListChemappearanceQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ListChemappearanceQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ListChemappearanceQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ListChemappearance 
			Return CType(MyBase.AddNewEntity(), ListChemappearance)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal appearance As System.String) As ListChemappearance
			Return CType(MyBase.FindByPrimaryKey(appearance), ListChemappearance)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ListChemappearance) Implements IEnumerable(Of ListChemappearance).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ListChemappearance)(Me)
        End Function
		
		Private _query As ListChemappearanceQuery

	End Class
	


	' <summary>
	' Encapsulates the 'LIST_CHEMAPPEARANCE' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ListChemappearance ({Appearance})")> _
	<Serializable> _
	Partial Public Class ListChemappearance 
		Inherits esListChemappearance

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ListChemappearanceMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esListChemappearanceQuery

			If Me._query Is Nothing Then
				Me._query = New ListChemappearanceQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ListChemappearanceQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ListChemappearanceQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ListChemappearanceQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ListChemappearanceQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ListChemappearanceQuery
		inherits esListChemappearanceQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ListChemappearanceQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ListChemappearanceMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ListChemappearanceMetadata.ColumnNames.Appearance, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = ListChemappearanceMetadata.PropertyNames.Appearance
			c.IsInPrimaryKey = True
			c.CharacterMaxLength = 50
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ListChemappearanceMetadata
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
			 Public Const Appearance As String = "APPEARANCE"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Appearance As String = "Appearance"
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
            SyncLock GetType(ListChemappearanceMetadata)
			
				If ListChemappearanceMetadata.mapDelegates Is Nothing Then
					ListChemappearanceMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ListChemappearanceMetadata._meta Is Nothing Then
                    ListChemappearanceMetadata._meta = New ListChemappearanceMetadata()
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
				

				meta.AddTypeMap("Appearance", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "LIST_CHEMAPPEARANCE"
				meta.Destination = "LIST_CHEMAPPEARANCE"
				
				meta.spInsert = "proc_LIST_CHEMAPPEARANCEInsert"
				meta.spUpdate = "proc_LIST_CHEMAPPEARANCEUpdate"
				meta.spDelete = "proc_LIST_CHEMAPPEARANCEDelete"
				meta.spLoadAll = "proc_LIST_CHEMAPPEARANCELoadAll"
				meta.spLoadByPrimaryKey = "proc_LIST_CHEMAPPEARANCELoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ListChemappearanceMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
