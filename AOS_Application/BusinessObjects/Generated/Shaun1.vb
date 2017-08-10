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
	MustInherit Public Class esShaun1Collection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "Shaun1Collection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esShaun1Query)
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
            Me.InitQuery(CType(query, esShaun1Query))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Shaun1) As Shaun1
			Return CType(MyBase.DetachEntity(entity), Shaun1)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Shaun1) As Shaun1
			Return CType(MyBase.AttachEntity(entity), Shaun1)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As Shaun1Collection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Shaun1
            Get
                Return TryCast(MyBase.Item(index), Shaun1)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Shaun1)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esShaun1	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esShaun1Query
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey() As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic()
			Else
				Return LoadByPrimaryKeyStoredProcedure()
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic()
			Else
				Return LoadByPrimaryKeyStoredProcedure()
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic() As Boolean
		
			Dim query As esShaun1Query = Me.GetDynamicQuery()
			query.Where()
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure() As Boolean
		
			Dim parms As esParameters = New esParameters()

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
												
						Case "Proditemnum"
							Me.str.Proditemnum = CType(value, string)
												
						Case "Prodordernum"
							Me.str.Prodordernum = CType(value, string)
												
						Case "Materialid"
							Me.str.Materialid = CType(value, string)
												
						Case "Apisnum"
							Me.str.Apisnum = CType(value, string)
												
						Case "Uom"
							Me.str.Uom = CType(value, string)
												
						Case "Qty"
							Me.str.Qty = CType(value, string)
												
						Case "Iscomplete"
							Me.str.Iscomplete = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Proditemnum"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Proditemnum = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Prodordernum"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Prodordernum = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Materialid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Materialid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Apisnum"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Apisnum = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Qty"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Qty = CType(value, Nullable(Of System.Double))
							End If
						
						Case "Iscomplete"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Iscomplete = CType(value, Nullable(Of System.Boolean))
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
		' Maps to shaun1.PRODITEMNUM
		' </summary>
		Public Overridable Property Proditemnum As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(Shaun1Metadata.ColumnNames.Proditemnum)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(Shaun1Metadata.ColumnNames.Proditemnum, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to shaun1.PRODORDERNUM
		' </summary>
		Public Overridable Property Prodordernum As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(Shaun1Metadata.ColumnNames.Prodordernum)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(Shaun1Metadata.ColumnNames.Prodordernum, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to shaun1.MATERIALID
		' </summary>
		Public Overridable Property Materialid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(Shaun1Metadata.ColumnNames.Materialid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(Shaun1Metadata.ColumnNames.Materialid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to shaun1.APISNUM
		' </summary>
		Public Overridable Property Apisnum As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(Shaun1Metadata.ColumnNames.Apisnum)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(Shaun1Metadata.ColumnNames.Apisnum, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to shaun1.UOM
		' </summary>
		Public Overridable Property Uom As System.String
			Get
				Return MyBase.GetSystemString(Shaun1Metadata.ColumnNames.Uom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(Shaun1Metadata.ColumnNames.Uom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to shaun1.QTY
		' </summary>
		Public Overridable Property Qty As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(Shaun1Metadata.ColumnNames.Qty)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(Shaun1Metadata.ColumnNames.Qty, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to shaun1.ISCOMPLETE
		' </summary>
		Public Overridable Property Iscomplete As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(Shaun1Metadata.ColumnNames.Iscomplete)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(Shaun1Metadata.ColumnNames.Iscomplete, value)
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
		
			Public Sub New(ByVal entity As esShaun1)
				Me.entity = entity
			End Sub				
		
	
			Public Property Proditemnum As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Proditemnum
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Proditemnum = Nothing
					Else
						entity.Proditemnum = Convert.ToInt32(Value)
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
		  	
			Public Property Materialid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Materialid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Materialid = Nothing
					Else
						entity.Materialid = Convert.ToInt32(Value)
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
		  	
			Public Property Uom As System.String 
				Get
					Dim data_ As System.String = entity.Uom
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Uom = Nothing
					Else
						entity.Uom = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Qty As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Qty
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qty = Nothing
					Else
						entity.Qty = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property Iscomplete As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Iscomplete
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Iscomplete = Nothing
					Else
						entity.Iscomplete = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  

			Private entity As esShaun1
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esShaun1Query)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esShaun1 can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Shaun1 
		Inherits esShaun1
		
	
		
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
	MustInherit Public Class esShaun1Query 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return Shaun1Metadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Proditemnum As esQueryItem
			Get
				Return New esQueryItem(Me, Shaun1Metadata.ColumnNames.Proditemnum, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Prodordernum As esQueryItem
			Get
				Return New esQueryItem(Me, Shaun1Metadata.ColumnNames.Prodordernum, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Materialid As esQueryItem
			Get
				Return New esQueryItem(Me, Shaun1Metadata.ColumnNames.Materialid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Apisnum As esQueryItem
			Get
				Return New esQueryItem(Me, Shaun1Metadata.ColumnNames.Apisnum, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Uom As esQueryItem
			Get
				Return New esQueryItem(Me, Shaun1Metadata.ColumnNames.Uom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Qty As esQueryItem
			Get
				Return New esQueryItem(Me, Shaun1Metadata.ColumnNames.Qty, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Iscomplete As esQueryItem
			Get
				Return New esQueryItem(Me, Shaun1Metadata.ColumnNames.Iscomplete, esSystemType.Boolean)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("Shaun1Collection")> _
	Partial Public Class Shaun1Collection
		Inherits esShaun1Collection
		Implements IEnumerable(Of Shaun1)
		
        Public Shared Widening Operator CType(ByVal coll As Shaun1Collection) As List(Of Shaun1)
            Dim list As List(Of Shaun1) = New List(Of Shaun1)
            Dim emp As Shaun1

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return Shaun1Metadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New Shaun1Query()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Shaun1(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Shaun1()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As Shaun1Query 
			Get
				If Me._query Is Nothing Then
					Me._query = New Shaun1Query()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As Shaun1Query) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Shaun1 
			Return CType(MyBase.AddNewEntity(), Shaun1)
		End Function

		Public Overloads Function FindByPrimaryKey() As Shaun1
			Return CType(MyBase.FindByPrimaryKey(), Shaun1)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Shaun1) Implements IEnumerable(Of Shaun1).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Shaun1)(Me)
        End Function
		
		Private _query As Shaun1Query

	End Class
	


	' <summary>
	' Encapsulates the 'shaun1' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Shaun1 ()")> _
	<Serializable> _
	Partial Public Class Shaun1 
		Inherits esShaun1

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return Shaun1Metadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esShaun1Query

			If Me._query Is Nothing Then
				Me._query = New Shaun1Query()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As Shaun1Query
			Get

				If Me._query Is Nothing then
					Me._query = New Shaun1Query()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As Shaun1Query) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As Shaun1Query

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class Shaun1Query
		inherits esShaun1Query
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "Shaun1Query"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class Shaun1Metadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(Shaun1Metadata.ColumnNames.Proditemnum, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = Shaun1Metadata.PropertyNames.Proditemnum
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(Shaun1Metadata.ColumnNames.Prodordernum, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = Shaun1Metadata.PropertyNames.Prodordernum
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(Shaun1Metadata.ColumnNames.Materialid, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = Shaun1Metadata.PropertyNames.Materialid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(Shaun1Metadata.ColumnNames.Apisnum, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = Shaun1Metadata.PropertyNames.Apisnum
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(Shaun1Metadata.ColumnNames.Uom, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = Shaun1Metadata.PropertyNames.Uom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(Shaun1Metadata.ColumnNames.Qty, 5, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = Shaun1Metadata.PropertyNames.Qty
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(Shaun1Metadata.ColumnNames.Iscomplete, 6, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = Shaun1Metadata.PropertyNames.Iscomplete
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As Shaun1Metadata
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
			 Public Const Proditemnum As String = "PRODITEMNUM"
			 Public Const Prodordernum As String = "PRODORDERNUM"
			 Public Const Materialid As String = "MATERIALID"
			 Public Const Apisnum As String = "APISNUM"
			 Public Const Uom As String = "UOM"
			 Public Const Qty As String = "QTY"
			 Public Const Iscomplete As String = "ISCOMPLETE"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Proditemnum As String = "Proditemnum"
			 Public Const Prodordernum As String = "Prodordernum"
			 Public Const Materialid As String = "Materialid"
			 Public Const Apisnum As String = "Apisnum"
			 Public Const Uom As String = "Uom"
			 Public Const Qty As String = "Qty"
			 Public Const Iscomplete As String = "Iscomplete"
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
            SyncLock GetType(Shaun1Metadata)
			
				If Shaun1Metadata.mapDelegates Is Nothing Then
					Shaun1Metadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If Shaun1Metadata._meta Is Nothing Then
                    Shaun1Metadata._meta = New Shaun1Metadata()
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
				

				meta.AddTypeMap("Proditemnum", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Prodordernum", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Materialid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Apisnum", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Uom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Qty", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Iscomplete", new esTypeMap("bit", "System.Boolean"))			
				
				
				 
				meta.Source = "shaun1"
				meta.Destination = "shaun1"
				
				meta.spInsert = "proc_shaun1Insert"
				meta.spUpdate = "proc_shaun1Update"
				meta.spDelete = "proc_shaun1Delete"
				meta.spLoadAll = "proc_shaun1LoadAll"
				meta.spLoadByPrimaryKey = "proc_shaun1LoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As Shaun1Metadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
