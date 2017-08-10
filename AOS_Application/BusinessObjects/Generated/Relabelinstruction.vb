'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 4/23/2015 9:56:09 PM
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
	MustInherit Public Class esRelabelinstructionCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "RelabelinstructionCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esRelabelinstructionQuery)
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
            Me.InitQuery(CType(query, esRelabelinstructionQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Relabelinstruction) As Relabelinstruction
			Return CType(MyBase.DetachEntity(entity), Relabelinstruction)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Relabelinstruction) As Relabelinstruction
			Return CType(MyBase.AttachEntity(entity), Relabelinstruction)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As RelabelinstructionCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Relabelinstruction
            Get
                Return TryCast(MyBase.Item(index), Relabelinstruction)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Relabelinstruction)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esRelabelinstruction	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esRelabelinstructionQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal relabelinstructionnumber As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(relabelinstructionnumber)
			Else
				Return LoadByPrimaryKeyStoredProcedure(relabelinstructionnumber)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal relabelinstructionnumber As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(relabelinstructionnumber)
			Else
				Return LoadByPrimaryKeyStoredProcedure(relabelinstructionnumber)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal relabelinstructionnumber As System.Int32) As Boolean
		
			Dim query As esRelabelinstructionQuery = Me.GetDynamicQuery()
			query.Where(query.Relabelinstructionnumber.Equal(relabelinstructionnumber))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal relabelinstructionnumber As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("RELABELINSTRUCTIONNUMBER", relabelinstructionnumber)
			
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
												
						Case "Relabelinstructionnumber"
							Me.str.Relabelinstructionnumber = CType(value, string)
												
						Case "Sequence"
							Me.str.Sequence = CType(value, string)
												
						Case "Relabelinstruction"
							Me.str.Relabelinstruction = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Relabelinstructionnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Relabelinstructionnumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Sequence"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Sequence = CType(value, Nullable(Of System.Int32))
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
		' Maps to RELABELINSTRUCTION.RELABELINSTRUCTIONNUMBER
		' </summary>
		Public Overridable Property Relabelinstructionnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(RelabelinstructionMetadata.ColumnNames.Relabelinstructionnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(RelabelinstructionMetadata.ColumnNames.Relabelinstructionnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RELABELINSTRUCTION.SEQUENCE
		' </summary>
		Public Overridable Property Sequence As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(RelabelinstructionMetadata.ColumnNames.Sequence)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(RelabelinstructionMetadata.ColumnNames.Sequence, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RELABELINSTRUCTION.RELABELINSTRUCTION
		' </summary>
		Public Overridable Property Relabelinstruction As System.String
			Get
				Return MyBase.GetSystemString(RelabelinstructionMetadata.ColumnNames.Relabelinstruction)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(RelabelinstructionMetadata.ColumnNames.Relabelinstruction, value)
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
		
			Public Sub New(ByVal entity As esRelabelinstruction)
				Me.entity = entity
			End Sub				
		
	
			Public Property Relabelinstructionnumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Relabelinstructionnumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Relabelinstructionnumber = Nothing
					Else
						entity.Relabelinstructionnumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Sequence As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Sequence
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Sequence = Nothing
					Else
						entity.Sequence = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Relabelinstruction As System.String 
				Get
					Dim data_ As System.String = entity.Relabelinstruction
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Relabelinstruction = Nothing
					Else
						entity.Relabelinstruction = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esRelabelinstruction
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esRelabelinstructionQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esRelabelinstruction can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Relabelinstruction 
		Inherits esRelabelinstruction
		
	
		
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
	MustInherit Public Class esRelabelinstructionQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return RelabelinstructionMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Relabelinstructionnumber As esQueryItem
			Get
				Return New esQueryItem(Me, RelabelinstructionMetadata.ColumnNames.Relabelinstructionnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Sequence As esQueryItem
			Get
				Return New esQueryItem(Me, RelabelinstructionMetadata.ColumnNames.Sequence, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Relabelinstruction As esQueryItem
			Get
				Return New esQueryItem(Me, RelabelinstructionMetadata.ColumnNames.Relabelinstruction, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("RelabelinstructionCollection")> _
	Partial Public Class RelabelinstructionCollection
		Inherits esRelabelinstructionCollection
		Implements IEnumerable(Of Relabelinstruction)
		
        Public Shared Widening Operator CType(ByVal coll As RelabelinstructionCollection) As List(Of Relabelinstruction)
            Dim list As List(Of Relabelinstruction) = New List(Of Relabelinstruction)
            Dim emp As Relabelinstruction

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return RelabelinstructionMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New RelabelinstructionQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Relabelinstruction(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Relabelinstruction()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As RelabelinstructionQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New RelabelinstructionQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As RelabelinstructionQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Relabelinstruction 
			Return CType(MyBase.AddNewEntity(), Relabelinstruction)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal relabelinstructionnumber As System.Int32) As Relabelinstruction
			Return CType(MyBase.FindByPrimaryKey(relabelinstructionnumber), Relabelinstruction)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Relabelinstruction) Implements IEnumerable(Of Relabelinstruction).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Relabelinstruction)(Me)
        End Function
		
		Private _query As RelabelinstructionQuery

	End Class
	


	' <summary>
	' Encapsulates the 'RELABELINSTRUCTION' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Relabelinstruction ({Relabelinstructionnumber.Value})")> _
	<Serializable> _
	Partial Public Class Relabelinstruction 
		Inherits esRelabelinstruction

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return RelabelinstructionMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esRelabelinstructionQuery

			If Me._query Is Nothing Then
				Me._query = New RelabelinstructionQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As RelabelinstructionQuery
			Get

				If Me._query Is Nothing then
					Me._query = New RelabelinstructionQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As RelabelinstructionQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As RelabelinstructionQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class RelabelinstructionQuery
		inherits esRelabelinstructionQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "RelabelinstructionQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class RelabelinstructionMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(RelabelinstructionMetadata.ColumnNames.Relabelinstructionnumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = RelabelinstructionMetadata.PropertyNames.Relabelinstructionnumber
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(RelabelinstructionMetadata.ColumnNames.Sequence, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = RelabelinstructionMetadata.PropertyNames.Sequence
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(RelabelinstructionMetadata.ColumnNames.Relabelinstruction, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = RelabelinstructionMetadata.PropertyNames.Relabelinstruction
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As RelabelinstructionMetadata
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
			 Public Const Relabelinstructionnumber As String = "RELABELINSTRUCTIONNUMBER"
			 Public Const Sequence As String = "SEQUENCE"
			 Public Const Relabelinstruction As String = "RELABELINSTRUCTION"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Relabelinstructionnumber As String = "Relabelinstructionnumber"
			 Public Const Sequence As String = "Sequence"
			 Public Const Relabelinstruction As String = "Relabelinstruction"
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
            SyncLock GetType(RelabelinstructionMetadata)
			
				If RelabelinstructionMetadata.mapDelegates Is Nothing Then
					RelabelinstructionMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If RelabelinstructionMetadata._meta Is Nothing Then
                    RelabelinstructionMetadata._meta = New RelabelinstructionMetadata()
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
				

				meta.AddTypeMap("Relabelinstructionnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Sequence", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Relabelinstruction", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "RELABELINSTRUCTION"
				meta.Destination = "RELABELINSTRUCTION"
				
				meta.spInsert = "proc_RELABELINSTRUCTIONInsert"
				meta.spUpdate = "proc_RELABELINSTRUCTIONUpdate"
				meta.spDelete = "proc_RELABELINSTRUCTIONDelete"
				meta.spLoadAll = "proc_RELABELINSTRUCTIONLoadAll"
				meta.spLoadByPrimaryKey = "proc_RELABELINSTRUCTIONLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As RelabelinstructionMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
