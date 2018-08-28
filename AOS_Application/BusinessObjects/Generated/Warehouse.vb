'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 8/28/2018 1:46:41 PM
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
	MustInherit Public Class esWarehouseCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "WarehouseCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esWarehouseQuery)
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
            Me.InitQuery(CType(query, esWarehouseQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Warehouse) As Warehouse
			Return CType(MyBase.DetachEntity(entity), Warehouse)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Warehouse) As Warehouse
			Return CType(MyBase.AttachEntity(entity), Warehouse)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As WarehouseCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Warehouse
            Get
                Return TryCast(MyBase.Item(index), Warehouse)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Warehouse)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esWarehouse	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esWarehouseQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal warehouseid As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(warehouseid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(warehouseid)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal warehouseid As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(warehouseid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(warehouseid)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal warehouseid As System.Int32) As Boolean
		
			Dim query As esWarehouseQuery = Me.GetDynamicQuery()
			query.Where(query.Warehouseid.Equal(warehouseid))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal warehouseid As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("WAREHOUSEID", warehouseid)
			
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
												
						Case "Warehouseid"
							Me.str.Warehouseid = CType(value, string)
												
						Case "Warehousename"
							Me.str.Warehousename = CType(value, string)
												
						Case "Consigneename"
							Me.str.Consigneename = CType(value, string)
												
						Case "Warehouseaddress"
							Me.str.Warehouseaddress = CType(value, string)
												
						Case "Warehousecity"
							Me.str.Warehousecity = CType(value, string)
												
						Case "Warehousestate"
							Me.str.Warehousestate = CType(value, string)
												
						Case "Warehousezipcode"
							Me.str.Warehousezipcode = CType(value, string)
												
						Case "Warehousephone"
							Me.str.Warehousephone = CType(value, string)
												
						Case "Warehouseshortname"
							Me.str.Warehouseshortname = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Warehouseid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Warehouseid = CType(value, Nullable(Of System.Int32))
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
		' Maps to WAREHOUSE.WAREHOUSEID
		' </summary>
		Public Overridable Property Warehouseid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(WarehouseMetadata.ColumnNames.Warehouseid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(WarehouseMetadata.ColumnNames.Warehouseid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WAREHOUSE.WAREHOUSENAME
		' </summary>
		Public Overridable Property Warehousename As System.String
			Get
				Return MyBase.GetSystemString(WarehouseMetadata.ColumnNames.Warehousename)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(WarehouseMetadata.ColumnNames.Warehousename, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WAREHOUSE.CONSIGNEENAME
		' </summary>
		Public Overridable Property Consigneename As System.String
			Get
				Return MyBase.GetSystemString(WarehouseMetadata.ColumnNames.Consigneename)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(WarehouseMetadata.ColumnNames.Consigneename, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WAREHOUSE.WAREHOUSEADDRESS
		' </summary>
		Public Overridable Property Warehouseaddress As System.String
			Get
				Return MyBase.GetSystemString(WarehouseMetadata.ColumnNames.Warehouseaddress)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(WarehouseMetadata.ColumnNames.Warehouseaddress, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WAREHOUSE.WAREHOUSECITY
		' </summary>
		Public Overridable Property Warehousecity As System.String
			Get
				Return MyBase.GetSystemString(WarehouseMetadata.ColumnNames.Warehousecity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(WarehouseMetadata.ColumnNames.Warehousecity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WAREHOUSE.WAREHOUSESTATE
		' </summary>
		Public Overridable Property Warehousestate As System.String
			Get
				Return MyBase.GetSystemString(WarehouseMetadata.ColumnNames.Warehousestate)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(WarehouseMetadata.ColumnNames.Warehousestate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WAREHOUSE.WAREHOUSEZIPCODE
		' </summary>
		Public Overridable Property Warehousezipcode As System.String
			Get
				Return MyBase.GetSystemString(WarehouseMetadata.ColumnNames.Warehousezipcode)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(WarehouseMetadata.ColumnNames.Warehousezipcode, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WAREHOUSE.WAREHOUSEPHONE
		' </summary>
		Public Overridable Property Warehousephone As System.String
			Get
				Return MyBase.GetSystemString(WarehouseMetadata.ColumnNames.Warehousephone)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(WarehouseMetadata.ColumnNames.Warehousephone, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WAREHOUSE.WAREHOUSESHORTNAME
		' </summary>
		Public Overridable Property Warehouseshortname As System.String
			Get
				Return MyBase.GetSystemString(WarehouseMetadata.ColumnNames.Warehouseshortname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(WarehouseMetadata.ColumnNames.Warehouseshortname, value)
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
		
			Public Sub New(ByVal entity As esWarehouse)
				Me.entity = entity
			End Sub				
		
	
			Public Property Warehouseid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Warehouseid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Warehouseid = Nothing
					Else
						entity.Warehouseid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Warehousename As System.String 
				Get
					Dim data_ As System.String = entity.Warehousename
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Warehousename = Nothing
					Else
						entity.Warehousename = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Consigneename As System.String 
				Get
					Dim data_ As System.String = entity.Consigneename
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Consigneename = Nothing
					Else
						entity.Consigneename = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Warehouseaddress As System.String 
				Get
					Dim data_ As System.String = entity.Warehouseaddress
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Warehouseaddress = Nothing
					Else
						entity.Warehouseaddress = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Warehousecity As System.String 
				Get
					Dim data_ As System.String = entity.Warehousecity
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Warehousecity = Nothing
					Else
						entity.Warehousecity = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Warehousestate As System.String 
				Get
					Dim data_ As System.String = entity.Warehousestate
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Warehousestate = Nothing
					Else
						entity.Warehousestate = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Warehousezipcode As System.String 
				Get
					Dim data_ As System.String = entity.Warehousezipcode
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Warehousezipcode = Nothing
					Else
						entity.Warehousezipcode = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Warehousephone As System.String 
				Get
					Dim data_ As System.String = entity.Warehousephone
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Warehousephone = Nothing
					Else
						entity.Warehousephone = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Warehouseshortname As System.String 
				Get
					Dim data_ As System.String = entity.Warehouseshortname
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Warehouseshortname = Nothing
					Else
						entity.Warehouseshortname = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esWarehouse
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esWarehouseQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esWarehouse can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Warehouse 
		Inherits esWarehouse
		
	
		
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
	MustInherit Public Class esWarehouseQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return WarehouseMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Warehouseid As esQueryItem
			Get
				Return New esQueryItem(Me, WarehouseMetadata.ColumnNames.Warehouseid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Warehousename As esQueryItem
			Get
				Return New esQueryItem(Me, WarehouseMetadata.ColumnNames.Warehousename, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Consigneename As esQueryItem
			Get
				Return New esQueryItem(Me, WarehouseMetadata.ColumnNames.Consigneename, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Warehouseaddress As esQueryItem
			Get
				Return New esQueryItem(Me, WarehouseMetadata.ColumnNames.Warehouseaddress, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Warehousecity As esQueryItem
			Get
				Return New esQueryItem(Me, WarehouseMetadata.ColumnNames.Warehousecity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Warehousestate As esQueryItem
			Get
				Return New esQueryItem(Me, WarehouseMetadata.ColumnNames.Warehousestate, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Warehousezipcode As esQueryItem
			Get
				Return New esQueryItem(Me, WarehouseMetadata.ColumnNames.Warehousezipcode, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Warehousephone As esQueryItem
			Get
				Return New esQueryItem(Me, WarehouseMetadata.ColumnNames.Warehousephone, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Warehouseshortname As esQueryItem
			Get
				Return New esQueryItem(Me, WarehouseMetadata.ColumnNames.Warehouseshortname, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("WarehouseCollection")> _
	Partial Public Class WarehouseCollection
		Inherits esWarehouseCollection
		Implements IEnumerable(Of Warehouse)
		
        Public Shared Widening Operator CType(ByVal coll As WarehouseCollection) As List(Of Warehouse)
            Dim list As List(Of Warehouse) = New List(Of Warehouse)
            Dim emp As Warehouse

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return WarehouseMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New WarehouseQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Warehouse(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Warehouse()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As WarehouseQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New WarehouseQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As WarehouseQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Warehouse 
			Return CType(MyBase.AddNewEntity(), Warehouse)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal warehouseid As System.Int32) As Warehouse
			Return CType(MyBase.FindByPrimaryKey(warehouseid), Warehouse)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Warehouse) Implements IEnumerable(Of Warehouse).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Warehouse)(Me)
        End Function
		
		Private _query As WarehouseQuery

	End Class
	


	' <summary>
	' Encapsulates the 'WAREHOUSE' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Warehouse ({Warehouseid.Value})")> _
	<Serializable> _
	Partial Public Class Warehouse 
		Inherits esWarehouse

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return WarehouseMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esWarehouseQuery

			If Me._query Is Nothing Then
				Me._query = New WarehouseQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As WarehouseQuery
			Get

				If Me._query Is Nothing then
					Me._query = New WarehouseQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As WarehouseQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As WarehouseQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class WarehouseQuery
		inherits esWarehouseQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "WarehouseQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class WarehouseMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(WarehouseMetadata.ColumnNames.Warehouseid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = WarehouseMetadata.PropertyNames.Warehouseid
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(WarehouseMetadata.ColumnNames.Warehousename, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = WarehouseMetadata.PropertyNames.Warehousename
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WarehouseMetadata.ColumnNames.Consigneename, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = WarehouseMetadata.PropertyNames.Consigneename
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WarehouseMetadata.ColumnNames.Warehouseaddress, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = WarehouseMetadata.PropertyNames.Warehouseaddress
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WarehouseMetadata.ColumnNames.Warehousecity, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = WarehouseMetadata.PropertyNames.Warehousecity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WarehouseMetadata.ColumnNames.Warehousestate, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = WarehouseMetadata.PropertyNames.Warehousestate
			c.CharacterMaxLength = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WarehouseMetadata.ColumnNames.Warehousezipcode, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = WarehouseMetadata.PropertyNames.Warehousezipcode
			c.CharacterMaxLength = 5
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WarehouseMetadata.ColumnNames.Warehousephone, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = WarehouseMetadata.PropertyNames.Warehousephone
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WarehouseMetadata.ColumnNames.Warehouseshortname, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = WarehouseMetadata.PropertyNames.Warehouseshortname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As WarehouseMetadata
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
			 Public Const Warehouseid As String = "WAREHOUSEID"
			 Public Const Warehousename As String = "WAREHOUSENAME"
			 Public Const Consigneename As String = "CONSIGNEENAME"
			 Public Const Warehouseaddress As String = "WAREHOUSEADDRESS"
			 Public Const Warehousecity As String = "WAREHOUSECITY"
			 Public Const Warehousestate As String = "WAREHOUSESTATE"
			 Public Const Warehousezipcode As String = "WAREHOUSEZIPCODE"
			 Public Const Warehousephone As String = "WAREHOUSEPHONE"
			 Public Const Warehouseshortname As String = "WAREHOUSESHORTNAME"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Warehouseid As String = "Warehouseid"
			 Public Const Warehousename As String = "Warehousename"
			 Public Const Consigneename As String = "Consigneename"
			 Public Const Warehouseaddress As String = "Warehouseaddress"
			 Public Const Warehousecity As String = "Warehousecity"
			 Public Const Warehousestate As String = "Warehousestate"
			 Public Const Warehousezipcode As String = "Warehousezipcode"
			 Public Const Warehousephone As String = "Warehousephone"
			 Public Const Warehouseshortname As String = "Warehouseshortname"
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
            SyncLock GetType(WarehouseMetadata)
			
				If WarehouseMetadata.mapDelegates Is Nothing Then
					WarehouseMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If WarehouseMetadata._meta Is Nothing Then
                    WarehouseMetadata._meta = New WarehouseMetadata()
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
				

				meta.AddTypeMap("Warehouseid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Warehousename", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Consigneename", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Warehouseaddress", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Warehousecity", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Warehousestate", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Warehousezipcode", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Warehousephone", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Warehouseshortname", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "WAREHOUSE"
				meta.Destination = "WAREHOUSE"
				
				meta.spInsert = "proc_WAREHOUSEInsert"
				meta.spUpdate = "proc_WAREHOUSEUpdate"
				meta.spDelete = "proc_WAREHOUSEDelete"
				meta.spLoadAll = "proc_WAREHOUSELoadAll"
				meta.spLoadByPrimaryKey = "proc_WAREHOUSELoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As WarehouseMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
