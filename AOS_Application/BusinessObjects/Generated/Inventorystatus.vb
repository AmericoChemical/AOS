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
	MustInherit Public Class esInventorystatusCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "InventorystatusCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esInventorystatusQuery)
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
            Me.InitQuery(CType(query, esInventorystatusQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Inventorystatus) As Inventorystatus
			Return CType(MyBase.DetachEntity(entity), Inventorystatus)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Inventorystatus) As Inventorystatus
			Return CType(MyBase.AttachEntity(entity), Inventorystatus)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As InventorystatusCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Inventorystatus
            Get
                Return TryCast(MyBase.Item(index), Inventorystatus)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Inventorystatus)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esInventorystatus	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esInventorystatusQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal inventorystatus As System.String) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(inventorystatus)
			Else
				Return LoadByPrimaryKeyStoredProcedure(inventorystatus)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal inventorystatus As System.String) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(inventorystatus)
			Else
				Return LoadByPrimaryKeyStoredProcedure(inventorystatus)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal inventorystatus As System.String) As Boolean
		
			Dim query As esInventorystatusQuery = Me.GetDynamicQuery()
			query.Where(query.Inventorystatus.Equal(inventorystatus))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal inventorystatus As System.String) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("INVENTORYSTATUS", inventorystatus)
			
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
												
						Case "Inventorystatus"
							Me.str.Inventorystatus = CType(value, string)
					
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
		' Maps to INVENTORYSTATUS.INVENTORYSTATUS
		' </summary>
		Public Overridable Property Inventorystatus As System.String
			Get
				Return MyBase.GetSystemString(InventorystatusMetadata.ColumnNames.Inventorystatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(InventorystatusMetadata.ColumnNames.Inventorystatus, value)
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
		
			Public Sub New(ByVal entity As esInventorystatus)
				Me.entity = entity
			End Sub				
		
	
			Public Property Inventorystatus As System.String 
				Get
					Dim data_ As System.String = entity.Inventorystatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Inventorystatus = Nothing
					Else
						entity.Inventorystatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esInventorystatus
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esInventorystatusQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esInventorystatus can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Inventorystatus 
		Inherits esInventorystatus
		
	
		
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
	MustInherit Public Class esInventorystatusQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return InventorystatusMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Inventorystatus As esQueryItem
			Get
				Return New esQueryItem(Me, InventorystatusMetadata.ColumnNames.Inventorystatus, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("InventorystatusCollection")> _
	Partial Public Class InventorystatusCollection
		Inherits esInventorystatusCollection
		Implements IEnumerable(Of Inventorystatus)
		
        Public Shared Widening Operator CType(ByVal coll As InventorystatusCollection) As List(Of Inventorystatus)
            Dim list As List(Of Inventorystatus) = New List(Of Inventorystatus)
            Dim emp As Inventorystatus

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return InventorystatusMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New InventorystatusQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Inventorystatus(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Inventorystatus()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As InventorystatusQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New InventorystatusQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As InventorystatusQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Inventorystatus 
			Return CType(MyBase.AddNewEntity(), Inventorystatus)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal inventorystatus As System.String) As Inventorystatus
			Return CType(MyBase.FindByPrimaryKey(inventorystatus), Inventorystatus)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Inventorystatus) Implements IEnumerable(Of Inventorystatus).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Inventorystatus)(Me)
        End Function
		
		Private _query As InventorystatusQuery

	End Class
	


	' <summary>
	' Encapsulates the 'INVENTORYSTATUS' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Inventorystatus ({Inventorystatus})")> _
	<Serializable> _
	Partial Public Class Inventorystatus 
		Inherits esInventorystatus

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return InventorystatusMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esInventorystatusQuery

			If Me._query Is Nothing Then
				Me._query = New InventorystatusQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As InventorystatusQuery
			Get

				If Me._query Is Nothing then
					Me._query = New InventorystatusQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As InventorystatusQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As InventorystatusQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class InventorystatusQuery
		inherits esInventorystatusQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "InventorystatusQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class InventorystatusMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(InventorystatusMetadata.ColumnNames.Inventorystatus, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = InventorystatusMetadata.PropertyNames.Inventorystatus
			c.IsInPrimaryKey = True
			c.CharacterMaxLength = 50
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As InventorystatusMetadata
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
			 Public Const Inventorystatus As String = "INVENTORYSTATUS"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Inventorystatus As String = "Inventorystatus"
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
            SyncLock GetType(InventorystatusMetadata)
			
				If InventorystatusMetadata.mapDelegates Is Nothing Then
					InventorystatusMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If InventorystatusMetadata._meta Is Nothing Then
                    InventorystatusMetadata._meta = New InventorystatusMetadata()
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
				

				meta.AddTypeMap("Inventorystatus", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "INVENTORYSTATUS"
				meta.Destination = "INVENTORYSTATUS"
				
				meta.spInsert = "proc_INVENTORYSTATUSInsert"
				meta.spUpdate = "proc_INVENTORYSTATUSUpdate"
				meta.spDelete = "proc_INVENTORYSTATUSDelete"
				meta.spLoadAll = "proc_INVENTORYSTATUSLoadAll"
				meta.spLoadByPrimaryKey = "proc_INVENTORYSTATUSLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As InventorystatusMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
