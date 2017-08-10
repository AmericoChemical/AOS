'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/11/2014 1:43:55 PM
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
	MustInherit Public Class esApisprocedureCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ApisprocedureCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esApisprocedureQuery)
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
            Me.InitQuery(CType(query, esApisprocedureQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Apisprocedure) As Apisprocedure
			Return CType(MyBase.DetachEntity(entity), Apisprocedure)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Apisprocedure) As Apisprocedure
			Return CType(MyBase.AttachEntity(entity), Apisprocedure)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ApisprocedureCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Apisprocedure
            Get
                Return TryCast(MyBase.Item(index), Apisprocedure)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Apisprocedure)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esApisprocedure	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esApisprocedureQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal apisprocnum As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(apisprocnum)
			Else
				Return LoadByPrimaryKeyStoredProcedure(apisprocnum)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal apisprocnum As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(apisprocnum)
			Else
				Return LoadByPrimaryKeyStoredProcedure(apisprocnum)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal apisprocnum As System.Int32) As Boolean
		
			Dim query As esApisprocedureQuery = Me.GetDynamicQuery()
			query.Where(query.Apisprocnum.Equal(apisprocnum))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal apisprocnum As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("APISPROCNUM", apisprocnum)
			
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
												
						Case "Apisprocnum"
							Me.str.Apisprocnum = CType(value, string)
												
						Case "Apisnum"
							Me.str.Apisnum = CType(value, string)
												
						Case "Sequence"
							Me.str.Sequence = CType(value, string)
												
						Case "Apisprocedure"
							Me.str.Apisprocedure = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Apisprocnum"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Apisprocnum = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Apisnum"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Apisnum = CType(value, Nullable(Of System.Int32))
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
		' Maps to APISPROCEDURE.APISPROCNUM
		' </summary>
		Public Overridable Property Apisprocnum As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ApisprocedureMetadata.ColumnNames.Apisprocnum)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ApisprocedureMetadata.ColumnNames.Apisprocnum, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APISPROCEDURE.APISNUM
		' </summary>
		Public Overridable Property Apisnum As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ApisprocedureMetadata.ColumnNames.Apisnum)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ApisprocedureMetadata.ColumnNames.Apisnum, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APISPROCEDURE.SEQUENCE
		' </summary>
		Public Overridable Property Sequence As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ApisprocedureMetadata.ColumnNames.Sequence)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ApisprocedureMetadata.ColumnNames.Sequence, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APISPROCEDURE.APISPROCEDURE
		' </summary>
		Public Overridable Property Apisprocedure As System.String
			Get
				Return MyBase.GetSystemString(ApisprocedureMetadata.ColumnNames.Apisprocedure)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ApisprocedureMetadata.ColumnNames.Apisprocedure, value)
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
		
			Public Sub New(ByVal entity As esApisprocedure)
				Me.entity = entity
			End Sub				
		
	
			Public Property Apisprocnum As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Apisprocnum
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Apisprocnum = Nothing
					Else
						entity.Apisprocnum = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Apisnum As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Apisnum
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Apisnum = Nothing
					Else
						entity.Apisnum = Convert.ToInt32(Value)
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
		  	
			Public Property Apisprocedure As System.String 
				Get
					Dim data_ As System.String = entity.Apisprocedure
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Apisprocedure = Nothing
					Else
						entity.Apisprocedure = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esApisprocedure
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esApisprocedureQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esApisprocedure can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Apisprocedure 
		Inherits esApisprocedure
		
	
		
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
	MustInherit Public Class esApisprocedureQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ApisprocedureMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Apisprocnum As esQueryItem
			Get
				Return New esQueryItem(Me, ApisprocedureMetadata.ColumnNames.Apisprocnum, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Apisnum As esQueryItem
			Get
				Return New esQueryItem(Me, ApisprocedureMetadata.ColumnNames.Apisnum, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Sequence As esQueryItem
			Get
				Return New esQueryItem(Me, ApisprocedureMetadata.ColumnNames.Sequence, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Apisprocedure As esQueryItem
			Get
				Return New esQueryItem(Me, ApisprocedureMetadata.ColumnNames.Apisprocedure, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ApisprocedureCollection")> _
	Partial Public Class ApisprocedureCollection
		Inherits esApisprocedureCollection
		Implements IEnumerable(Of Apisprocedure)
		
        Public Shared Widening Operator CType(ByVal coll As ApisprocedureCollection) As List(Of Apisprocedure)
            Dim list As List(Of Apisprocedure) = New List(Of Apisprocedure)
            Dim emp As Apisprocedure

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ApisprocedureMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ApisprocedureQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Apisprocedure(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Apisprocedure()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As ApisprocedureQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ApisprocedureQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ApisprocedureQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Apisprocedure 
			Return CType(MyBase.AddNewEntity(), Apisprocedure)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal apisprocnum As System.Int32) As Apisprocedure
			Return CType(MyBase.FindByPrimaryKey(apisprocnum), Apisprocedure)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Apisprocedure) Implements IEnumerable(Of Apisprocedure).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Apisprocedure)(Me)
        End Function
		
		Private _query As ApisprocedureQuery

	End Class
	


	' <summary>
	' Encapsulates the 'APISPROCEDURE' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Apisprocedure ({Apisprocnum.Value})")> _
	<Serializable> _
	Partial Public Class Apisprocedure 
		Inherits esApisprocedure

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ApisprocedureMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esApisprocedureQuery

			If Me._query Is Nothing Then
				Me._query = New ApisprocedureQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ApisprocedureQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ApisprocedureQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ApisprocedureQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ApisprocedureQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ApisprocedureQuery
		inherits esApisprocedureQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ApisprocedureQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ApisprocedureMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ApisprocedureMetadata.ColumnNames.Apisprocnum, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ApisprocedureMetadata.PropertyNames.Apisprocnum
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ApisprocedureMetadata.ColumnNames.Apisnum, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ApisprocedureMetadata.PropertyNames.Apisnum
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ApisprocedureMetadata.ColumnNames.Sequence, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ApisprocedureMetadata.PropertyNames.Sequence
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ApisprocedureMetadata.ColumnNames.Apisprocedure, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ApisprocedureMetadata.PropertyNames.Apisprocedure
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ApisprocedureMetadata
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
			 Public Const Apisprocnum As String = "APISPROCNUM"
			 Public Const Apisnum As String = "APISNUM"
			 Public Const Sequence As String = "SEQUENCE"
			 Public Const Apisprocedure As String = "APISPROCEDURE"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Apisprocnum As String = "Apisprocnum"
			 Public Const Apisnum As String = "Apisnum"
			 Public Const Sequence As String = "Sequence"
			 Public Const Apisprocedure As String = "Apisprocedure"
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
            SyncLock GetType(ApisprocedureMetadata)
			
				If ApisprocedureMetadata.mapDelegates Is Nothing Then
					ApisprocedureMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ApisprocedureMetadata._meta Is Nothing Then
                    ApisprocedureMetadata._meta = New ApisprocedureMetadata()
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
				

				meta.AddTypeMap("Apisprocnum", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Apisnum", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Sequence", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Apisprocedure", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "APISPROCEDURE"
				meta.Destination = "APISPROCEDURE"
				
				meta.spInsert = "proc_APISPROCEDUREInsert"
				meta.spUpdate = "proc_APISPROCEDUREUpdate"
				meta.spDelete = "proc_APISPROCEDUREDelete"
				meta.spLoadAll = "proc_APISPROCEDURELoadAll"
				meta.spLoadByPrimaryKey = "proc_APISPROCEDURELoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ApisprocedureMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
