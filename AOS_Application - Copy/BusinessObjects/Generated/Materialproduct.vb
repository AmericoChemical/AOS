'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 11/13/2014 4:44:28 PM
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
	MustInherit Public Class esMaterialproductCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "MaterialproductCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esMaterialproductQuery)
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
            Me.InitQuery(CType(query, esMaterialproductQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Materialproduct) As Materialproduct
			Return CType(MyBase.DetachEntity(entity), Materialproduct)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Materialproduct) As Materialproduct
			Return CType(MyBase.AttachEntity(entity), Materialproduct)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As MaterialproductCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Materialproduct
            Get
                Return TryCast(MyBase.Item(index), Materialproduct)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Materialproduct)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esMaterialproduct	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esMaterialproductQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal mpid As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(mpid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(mpid)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal mpid As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(mpid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(mpid)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal mpid As System.Int32) As Boolean
		
			Dim query As esMaterialproductQuery = Me.GetDynamicQuery()
			query.Where(query.Mpid.Equal(mpid))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal mpid As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("MPID", mpid)
			
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
												
						Case "Mpid"
							Me.str.Mpid = CType(value, string)
												
						Case "Materialid"
							Me.str.Materialid = CType(value, string)
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Mpnote"
							Me.str.Mpnote = CType(value, string)
												
						Case "Priority"
							Me.str.Priority = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Mpid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Mpid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Materialid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Materialid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Priority"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Priority = CType(value, Nullable(Of System.Int32))
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
		' Maps to MATERIALPRODUCT.MPID
		' </summary>
		Public Overridable Property Mpid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(MaterialproductMetadata.ColumnNames.Mpid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(MaterialproductMetadata.ColumnNames.Mpid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to MATERIALPRODUCT.MATERIALID
		' </summary>
		Public Overridable Property Materialid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(MaterialproductMetadata.ColumnNames.Materialid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(MaterialproductMetadata.ColumnNames.Materialid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to MATERIALPRODUCT.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(MaterialproductMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(MaterialproductMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to MATERIALPRODUCT.MPNOTE
		' </summary>
		Public Overridable Property Mpnote As System.String
			Get
				Return MyBase.GetSystemString(MaterialproductMetadata.ColumnNames.Mpnote)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(MaterialproductMetadata.ColumnNames.Mpnote, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to MATERIALPRODUCT.PRIORITY
		' </summary>
		Public Overridable Property Priority As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(MaterialproductMetadata.ColumnNames.Priority)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(MaterialproductMetadata.ColumnNames.Priority, value)
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
		
			Public Sub New(ByVal entity As esMaterialproduct)
				Me.entity = entity
			End Sub				
		
	
			Public Property Mpid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Mpid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Mpid = Nothing
					Else
						entity.Mpid = Convert.ToInt32(Value)
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
		  	
			Public Property Productid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Productid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Productid = Nothing
					Else
						entity.Productid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Mpnote As System.String 
				Get
					Dim data_ As System.String = entity.Mpnote
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Mpnote = Nothing
					Else
						entity.Mpnote = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Priority As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Priority
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Priority = Nothing
					Else
						entity.Priority = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esMaterialproduct
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esMaterialproductQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esMaterialproduct can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Materialproduct 
		Inherits esMaterialproduct
		
	
		
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
	MustInherit Public Class esMaterialproductQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return MaterialproductMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Mpid As esQueryItem
			Get
				Return New esQueryItem(Me, MaterialproductMetadata.ColumnNames.Mpid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Materialid As esQueryItem
			Get
				Return New esQueryItem(Me, MaterialproductMetadata.ColumnNames.Materialid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, MaterialproductMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Mpnote As esQueryItem
			Get
				Return New esQueryItem(Me, MaterialproductMetadata.ColumnNames.Mpnote, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Priority As esQueryItem
			Get
				Return New esQueryItem(Me, MaterialproductMetadata.ColumnNames.Priority, esSystemType.Int32)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("MaterialproductCollection")> _
	Partial Public Class MaterialproductCollection
		Inherits esMaterialproductCollection
		Implements IEnumerable(Of Materialproduct)
		
        Public Shared Widening Operator CType(ByVal coll As MaterialproductCollection) As List(Of Materialproduct)
            Dim list As List(Of Materialproduct) = New List(Of Materialproduct)
            Dim emp As Materialproduct

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return MaterialproductMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New MaterialproductQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Materialproduct(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Materialproduct()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As MaterialproductQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New MaterialproductQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As MaterialproductQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Materialproduct 
			Return CType(MyBase.AddNewEntity(), Materialproduct)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal mpid As System.Int32) As Materialproduct
			Return CType(MyBase.FindByPrimaryKey(mpid), Materialproduct)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Materialproduct) Implements IEnumerable(Of Materialproduct).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Materialproduct)(Me)
        End Function
		
		Private _query As MaterialproductQuery

	End Class
	


	' <summary>
	' Encapsulates the 'MATERIALPRODUCT' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Materialproduct ({Mpid.Value})")> _
	<Serializable> _
	Partial Public Class Materialproduct 
		Inherits esMaterialproduct

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return MaterialproductMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esMaterialproductQuery

			If Me._query Is Nothing Then
				Me._query = New MaterialproductQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As MaterialproductQuery
			Get

				If Me._query Is Nothing then
					Me._query = New MaterialproductQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As MaterialproductQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As MaterialproductQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class MaterialproductQuery
		inherits esMaterialproductQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "MaterialproductQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class MaterialproductMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(MaterialproductMetadata.ColumnNames.Mpid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = MaterialproductMetadata.PropertyNames.Mpid
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(MaterialproductMetadata.ColumnNames.Materialid, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = MaterialproductMetadata.PropertyNames.Materialid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(MaterialproductMetadata.ColumnNames.Productid, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = MaterialproductMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(MaterialproductMetadata.ColumnNames.Mpnote, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = MaterialproductMetadata.PropertyNames.Mpnote
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(MaterialproductMetadata.ColumnNames.Priority, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = MaterialproductMetadata.PropertyNames.Priority
			c.NumericPrecision = 10
			c.HasDefault = True
			c.Default = "((0))"
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As MaterialproductMetadata
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
			 Public Const Mpid As String = "MPID"
			 Public Const Materialid As String = "MATERIALID"
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Mpnote As String = "MPNOTE"
			 Public Const Priority As String = "PRIORITY"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Mpid As String = "Mpid"
			 Public Const Materialid As String = "Materialid"
			 Public Const Productid As String = "Productid"
			 Public Const Mpnote As String = "Mpnote"
			 Public Const Priority As String = "Priority"
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
            SyncLock GetType(MaterialproductMetadata)
			
				If MaterialproductMetadata.mapDelegates Is Nothing Then
					MaterialproductMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If MaterialproductMetadata._meta Is Nothing Then
                    MaterialproductMetadata._meta = New MaterialproductMetadata()
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
				

				meta.AddTypeMap("Mpid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Materialid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Mpnote", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Priority", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "MATERIALPRODUCT"
				meta.Destination = "MATERIALPRODUCT"
				
				meta.spInsert = "proc_MATERIALPRODUCTInsert"
				meta.spUpdate = "proc_MATERIALPRODUCTUpdate"
				meta.spDelete = "proc_MATERIALPRODUCTDelete"
				meta.spLoadAll = "proc_MATERIALPRODUCTLoadAll"
				meta.spLoadByPrimaryKey = "proc_MATERIALPRODUCTLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As MaterialproductMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
