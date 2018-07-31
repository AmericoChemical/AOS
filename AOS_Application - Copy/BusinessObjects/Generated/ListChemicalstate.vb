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
	MustInherit Public Class esListChemicalstateCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ListChemicalstateCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esListChemicalstateQuery)
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
            Me.InitQuery(CType(query, esListChemicalstateQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ListChemicalstate) As ListChemicalstate
			Return CType(MyBase.DetachEntity(entity), ListChemicalstate)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ListChemicalstate) As ListChemicalstate
			Return CType(MyBase.AttachEntity(entity), ListChemicalstate)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ListChemicalstateCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ListChemicalstate
            Get
                Return TryCast(MyBase.Item(index), ListChemicalstate)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ListChemicalstate)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esListChemicalstate	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esListChemicalstateQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal chemicalstate As System.String) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(chemicalstate)
			Else
				Return LoadByPrimaryKeyStoredProcedure(chemicalstate)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal chemicalstate As System.String) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(chemicalstate)
			Else
				Return LoadByPrimaryKeyStoredProcedure(chemicalstate)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal chemicalstate As System.String) As Boolean
		
			Dim query As esListChemicalstateQuery = Me.GetDynamicQuery()
			query.Where(query.Chemicalstate.Equal(chemicalstate))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal chemicalstate As System.String) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("CHEMICALSTATE", chemicalstate)
			
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
												
						Case "Chemicalstate"
							Me.str.Chemicalstate = CType(value, string)
					
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
		' Maps to LIST_CHEMICALSTATE.CHEMICALSTATE
		' </summary>
		Public Overridable Property Chemicalstate As System.String
			Get
				Return MyBase.GetSystemString(ListChemicalstateMetadata.ColumnNames.Chemicalstate)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ListChemicalstateMetadata.ColumnNames.Chemicalstate, value)
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
		
			Public Sub New(ByVal entity As esListChemicalstate)
				Me.entity = entity
			End Sub				
		
	
			Public Property Chemicalstate As System.String 
				Get
					Dim data_ As System.String = entity.Chemicalstate
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Chemicalstate = Nothing
					Else
						entity.Chemicalstate = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esListChemicalstate
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esListChemicalstateQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esListChemicalstate can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class ListChemicalstate 
		Inherits esListChemicalstate
		
	
		
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
	MustInherit Public Class esListChemicalstateQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ListChemicalstateMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Chemicalstate As esQueryItem
			Get
				Return New esQueryItem(Me, ListChemicalstateMetadata.ColumnNames.Chemicalstate, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ListChemicalstateCollection")> _
	Partial Public Class ListChemicalstateCollection
		Inherits esListChemicalstateCollection
		Implements IEnumerable(Of ListChemicalstate)
		
        Public Shared Widening Operator CType(ByVal coll As ListChemicalstateCollection) As List(Of ListChemicalstate)
            Dim list As List(Of ListChemicalstate) = New List(Of ListChemicalstate)
            Dim emp As ListChemicalstate

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ListChemicalstateMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ListChemicalstateQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ListChemicalstate(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ListChemicalstate()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As ListChemicalstateQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ListChemicalstateQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ListChemicalstateQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ListChemicalstate 
			Return CType(MyBase.AddNewEntity(), ListChemicalstate)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal chemicalstate As System.String) As ListChemicalstate
			Return CType(MyBase.FindByPrimaryKey(chemicalstate), ListChemicalstate)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ListChemicalstate) Implements IEnumerable(Of ListChemicalstate).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ListChemicalstate)(Me)
        End Function
		
		Private _query As ListChemicalstateQuery

	End Class
	


	' <summary>
	' Encapsulates the 'LIST_CHEMICALSTATE' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ListChemicalstate ({Chemicalstate})")> _
	<Serializable> _
	Partial Public Class ListChemicalstate 
		Inherits esListChemicalstate

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ListChemicalstateMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esListChemicalstateQuery

			If Me._query Is Nothing Then
				Me._query = New ListChemicalstateQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ListChemicalstateQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ListChemicalstateQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ListChemicalstateQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ListChemicalstateQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ListChemicalstateQuery
		inherits esListChemicalstateQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ListChemicalstateQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ListChemicalstateMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ListChemicalstateMetadata.ColumnNames.Chemicalstate, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = ListChemicalstateMetadata.PropertyNames.Chemicalstate
			c.IsInPrimaryKey = True
			c.CharacterMaxLength = 50
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ListChemicalstateMetadata
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
			 Public Const Chemicalstate As String = "CHEMICALSTATE"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Chemicalstate As String = "Chemicalstate"
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
            SyncLock GetType(ListChemicalstateMetadata)
			
				If ListChemicalstateMetadata.mapDelegates Is Nothing Then
					ListChemicalstateMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ListChemicalstateMetadata._meta Is Nothing Then
                    ListChemicalstateMetadata._meta = New ListChemicalstateMetadata()
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
				

				meta.AddTypeMap("Chemicalstate", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "LIST_CHEMICALSTATE"
				meta.Destination = "LIST_CHEMICALSTATE"
				
				meta.spInsert = "proc_LIST_CHEMICALSTATEInsert"
				meta.spUpdate = "proc_LIST_CHEMICALSTATEUpdate"
				meta.spDelete = "proc_LIST_CHEMICALSTATEDelete"
				meta.spLoadAll = "proc_LIST_CHEMICALSTATELoadAll"
				meta.spLoadByPrimaryKey = "proc_LIST_CHEMICALSTATELoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ListChemicalstateMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
