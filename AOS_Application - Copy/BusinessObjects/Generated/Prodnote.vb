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
	MustInherit Public Class esProdnoteCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ProdnoteCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esProdnoteQuery)
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
            Me.InitQuery(CType(query, esProdnoteQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Prodnote) As Prodnote
			Return CType(MyBase.DetachEntity(entity), Prodnote)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Prodnote) As Prodnote
			Return CType(MyBase.AttachEntity(entity), Prodnote)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ProdnoteCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Prodnote
            Get
                Return TryCast(MyBase.Item(index), Prodnote)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Prodnote)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esProdnote	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esProdnoteQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal prodnotenum As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(prodnotenum)
			Else
				Return LoadByPrimaryKeyStoredProcedure(prodnotenum)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal prodnotenum As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(prodnotenum)
			Else
				Return LoadByPrimaryKeyStoredProcedure(prodnotenum)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal prodnotenum As System.Int32) As Boolean
		
			Dim query As esProdnoteQuery = Me.GetDynamicQuery()
			query.Where(query.Prodnotenum.Equal(prodnotenum))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal prodnotenum As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("PRODNOTENUM", prodnotenum)
			
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
												
						Case "Prodnotenum"
							Me.str.Prodnotenum = CType(value, string)
												
						Case "Prodordernum"
							Me.str.Prodordernum = CType(value, string)
												
						Case "Sequence"
							Me.str.Sequence = CType(value, string)
												
						Case "Prodnote"
							Me.str.Prodnote = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Prodnotenum"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Prodnotenum = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Prodordernum"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Prodordernum = CType(value, Nullable(Of System.Int32))
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
		' Maps to PRODNOTE.PRODNOTENUM
		' </summary>
		Public Overridable Property Prodnotenum As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ProdnoteMetadata.ColumnNames.Prodnotenum)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ProdnoteMetadata.ColumnNames.Prodnotenum, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODNOTE.PRODORDERNUM
		' </summary>
		Public Overridable Property Prodordernum As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ProdnoteMetadata.ColumnNames.Prodordernum)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ProdnoteMetadata.ColumnNames.Prodordernum, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODNOTE.SEQUENCE
		' </summary>
		Public Overridable Property Sequence As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ProdnoteMetadata.ColumnNames.Sequence)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ProdnoteMetadata.ColumnNames.Sequence, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODNOTE.PRODNOTE
		' </summary>
		Public Overridable Property Prodnote As System.String
			Get
				Return MyBase.GetSystemString(ProdnoteMetadata.ColumnNames.Prodnote)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ProdnoteMetadata.ColumnNames.Prodnote, value)
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
		
			Public Sub New(ByVal entity As esProdnote)
				Me.entity = entity
			End Sub				
		
	
			Public Property Prodnotenum As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Prodnotenum
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Prodnotenum = Nothing
					Else
						entity.Prodnotenum = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Prodordernum As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Prodordernum
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Prodordernum = Nothing
					Else
						entity.Prodordernum = Convert.ToInt32(Value)
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
		  	
			Public Property Prodnote As System.String 
				Get
					Dim data_ As System.String = entity.Prodnote
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Prodnote = Nothing
					Else
						entity.Prodnote = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esProdnote
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esProdnoteQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esProdnote can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Prodnote 
		Inherits esProdnote
		
	
		
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
	MustInherit Public Class esProdnoteQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ProdnoteMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Prodnotenum As esQueryItem
			Get
				Return New esQueryItem(Me, ProdnoteMetadata.ColumnNames.Prodnotenum, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Prodordernum As esQueryItem
			Get
				Return New esQueryItem(Me, ProdnoteMetadata.ColumnNames.Prodordernum, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Sequence As esQueryItem
			Get
				Return New esQueryItem(Me, ProdnoteMetadata.ColumnNames.Sequence, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Prodnote As esQueryItem
			Get
				Return New esQueryItem(Me, ProdnoteMetadata.ColumnNames.Prodnote, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ProdnoteCollection")> _
	Partial Public Class ProdnoteCollection
		Inherits esProdnoteCollection
		Implements IEnumerable(Of Prodnote)
		
        Public Shared Widening Operator CType(ByVal coll As ProdnoteCollection) As List(Of Prodnote)
            Dim list As List(Of Prodnote) = New List(Of Prodnote)
            Dim emp As Prodnote

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ProdnoteMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ProdnoteQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Prodnote(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Prodnote()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As ProdnoteQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ProdnoteQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ProdnoteQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Prodnote 
			Return CType(MyBase.AddNewEntity(), Prodnote)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal prodnotenum As System.Int32) As Prodnote
			Return CType(MyBase.FindByPrimaryKey(prodnotenum), Prodnote)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Prodnote) Implements IEnumerable(Of Prodnote).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Prodnote)(Me)
        End Function
		
		Private _query As ProdnoteQuery

	End Class
	


	' <summary>
	' Encapsulates the 'PRODNOTE' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Prodnote ({Prodnotenum.Value})")> _
	<Serializable> _
	Partial Public Class Prodnote 
		Inherits esProdnote

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ProdnoteMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esProdnoteQuery

			If Me._query Is Nothing Then
				Me._query = New ProdnoteQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ProdnoteQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ProdnoteQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ProdnoteQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ProdnoteQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ProdnoteQuery
		inherits esProdnoteQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ProdnoteQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ProdnoteMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ProdnoteMetadata.ColumnNames.Prodnotenum, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ProdnoteMetadata.PropertyNames.Prodnotenum
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ProdnoteMetadata.ColumnNames.Prodordernum, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ProdnoteMetadata.PropertyNames.Prodordernum
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProdnoteMetadata.ColumnNames.Sequence, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ProdnoteMetadata.PropertyNames.Sequence
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProdnoteMetadata.ColumnNames.Prodnote, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ProdnoteMetadata.PropertyNames.Prodnote
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ProdnoteMetadata
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
			 Public Const Prodnotenum As String = "PRODNOTENUM"
			 Public Const Prodordernum As String = "PRODORDERNUM"
			 Public Const Sequence As String = "SEQUENCE"
			 Public Const Prodnote As String = "PRODNOTE"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Prodnotenum As String = "Prodnotenum"
			 Public Const Prodordernum As String = "Prodordernum"
			 Public Const Sequence As String = "Sequence"
			 Public Const Prodnote As String = "Prodnote"
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
            SyncLock GetType(ProdnoteMetadata)
			
				If ProdnoteMetadata.mapDelegates Is Nothing Then
					ProdnoteMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ProdnoteMetadata._meta Is Nothing Then
                    ProdnoteMetadata._meta = New ProdnoteMetadata()
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
				

				meta.AddTypeMap("Prodnotenum", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Prodordernum", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Sequence", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Prodnote", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "PRODNOTE"
				meta.Destination = "PRODNOTE"
				
				meta.spInsert = "proc_PRODNOTEInsert"
				meta.spUpdate = "proc_PRODNOTEUpdate"
				meta.spDelete = "proc_PRODNOTEDelete"
				meta.spLoadAll = "proc_PRODNOTELoadAll"
				meta.spLoadByPrimaryKey = "proc_PRODNOTELoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ProdnoteMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
