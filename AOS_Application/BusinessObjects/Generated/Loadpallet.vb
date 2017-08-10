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
	MustInherit Public Class esLoadpalletCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "LoadpalletCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esLoadpalletQuery)
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
            Me.InitQuery(CType(query, esLoadpalletQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Loadpallet) As Loadpallet
			Return CType(MyBase.DetachEntity(entity), Loadpallet)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Loadpallet) As Loadpallet
			Return CType(MyBase.AttachEntity(entity), Loadpallet)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As LoadpalletCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Loadpallet
            Get
                Return TryCast(MyBase.Item(index), Loadpallet)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Loadpallet)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esLoadpallet	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esLoadpalletQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal palletid As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(palletid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(palletid)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal palletid As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(palletid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(palletid)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal palletid As System.Int32) As Boolean
		
			Dim query As esLoadpalletQuery = Me.GetDynamicQuery()
			query.Where(query.Palletid.Equal(palletid))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal palletid As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("PALLETID", palletid)
			
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
												
						Case "Palletid"
							Me.str.Palletid = CType(value, string)
												
						Case "Loadid"
							Me.str.Loadid = CType(value, string)
												
						Case "Pallettype"
							Me.str.Pallettype = CType(value, string)
												
						Case "Palletweight"
							Me.str.Palletweight = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Palletid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Palletid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Loadid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Loadid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Palletweight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Palletweight = CType(value, Nullable(Of System.Int32))
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
		' Maps to LOADPALLET.PALLETID
		' </summary>
		Public Overridable Property Palletid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(LoadpalletMetadata.ColumnNames.Palletid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(LoadpalletMetadata.ColumnNames.Palletid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADPALLET.LOADID
		' </summary>
		Public Overridable Property Loadid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(LoadpalletMetadata.ColumnNames.Loadid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(LoadpalletMetadata.ColumnNames.Loadid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADPALLET.PALLETTYPE
		' </summary>
		Public Overridable Property Pallettype As System.String
			Get
				Return MyBase.GetSystemString(LoadpalletMetadata.ColumnNames.Pallettype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LoadpalletMetadata.ColumnNames.Pallettype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADPALLET.PALLETWEIGHT
		' </summary>
		Public Overridable Property Palletweight As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(LoadpalletMetadata.ColumnNames.Palletweight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(LoadpalletMetadata.ColumnNames.Palletweight, value)
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
		
			Public Sub New(ByVal entity As esLoadpallet)
				Me.entity = entity
			End Sub				
		
	
			Public Property Palletid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Palletid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Palletid = Nothing
					Else
						entity.Palletid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Loadid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Loadid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Loadid = Nothing
					Else
						entity.Loadid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Pallettype As System.String 
				Get
					Dim data_ As System.String = entity.Pallettype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Pallettype = Nothing
					Else
						entity.Pallettype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Palletweight As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Palletweight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Palletweight = Nothing
					Else
						entity.Palletweight = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esLoadpallet
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esLoadpalletQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esLoadpallet can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Loadpallet 
		Inherits esLoadpallet
		
	
		
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
	MustInherit Public Class esLoadpalletQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return LoadpalletMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Palletid As esQueryItem
			Get
				Return New esQueryItem(Me, LoadpalletMetadata.ColumnNames.Palletid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Loadid As esQueryItem
			Get
				Return New esQueryItem(Me, LoadpalletMetadata.ColumnNames.Loadid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Pallettype As esQueryItem
			Get
				Return New esQueryItem(Me, LoadpalletMetadata.ColumnNames.Pallettype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Palletweight As esQueryItem
			Get
				Return New esQueryItem(Me, LoadpalletMetadata.ColumnNames.Palletweight, esSystemType.Int32)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("LoadpalletCollection")> _
	Partial Public Class LoadpalletCollection
		Inherits esLoadpalletCollection
		Implements IEnumerable(Of Loadpallet)
		
        Public Shared Widening Operator CType(ByVal coll As LoadpalletCollection) As List(Of Loadpallet)
            Dim list As List(Of Loadpallet) = New List(Of Loadpallet)
            Dim emp As Loadpallet

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return LoadpalletMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New LoadpalletQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Loadpallet(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Loadpallet()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As LoadpalletQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New LoadpalletQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As LoadpalletQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Loadpallet 
			Return CType(MyBase.AddNewEntity(), Loadpallet)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal palletid As System.Int32) As Loadpallet
			Return CType(MyBase.FindByPrimaryKey(palletid), Loadpallet)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Loadpallet) Implements IEnumerable(Of Loadpallet).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Loadpallet)(Me)
        End Function
		
		Private _query As LoadpalletQuery

	End Class
	


	' <summary>
	' Encapsulates the 'LOADPALLET' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Loadpallet ({Palletid.Value})")> _
	<Serializable> _
	Partial Public Class Loadpallet 
		Inherits esLoadpallet

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return LoadpalletMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esLoadpalletQuery

			If Me._query Is Nothing Then
				Me._query = New LoadpalletQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As LoadpalletQuery
			Get

				If Me._query Is Nothing then
					Me._query = New LoadpalletQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As LoadpalletQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As LoadpalletQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class LoadpalletQuery
		inherits esLoadpalletQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "LoadpalletQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class LoadpalletMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(LoadpalletMetadata.ColumnNames.Palletid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = LoadpalletMetadata.PropertyNames.Palletid
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(LoadpalletMetadata.ColumnNames.Loadid, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = LoadpalletMetadata.PropertyNames.Loadid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoadpalletMetadata.ColumnNames.Pallettype, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = LoadpalletMetadata.PropertyNames.Pallettype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoadpalletMetadata.ColumnNames.Palletweight, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = LoadpalletMetadata.PropertyNames.Palletweight
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As LoadpalletMetadata
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
			 Public Const Palletid As String = "PALLETID"
			 Public Const Loadid As String = "LOADID"
			 Public Const Pallettype As String = "PALLETTYPE"
			 Public Const Palletweight As String = "PALLETWEIGHT"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Palletid As String = "Palletid"
			 Public Const Loadid As String = "Loadid"
			 Public Const Pallettype As String = "Pallettype"
			 Public Const Palletweight As String = "Palletweight"
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
            SyncLock GetType(LoadpalletMetadata)
			
				If LoadpalletMetadata.mapDelegates Is Nothing Then
					LoadpalletMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If LoadpalletMetadata._meta Is Nothing Then
                    LoadpalletMetadata._meta = New LoadpalletMetadata()
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
				

				meta.AddTypeMap("Palletid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Loadid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Pallettype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Palletweight", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "LOADPALLET"
				meta.Destination = "LOADPALLET"
				
				meta.spInsert = "proc_LOADPALLETInsert"
				meta.spUpdate = "proc_LOADPALLETUpdate"
				meta.spDelete = "proc_LOADPALLETDelete"
				meta.spLoadAll = "proc_LOADPALLETLoadAll"
				meta.spLoadByPrimaryKey = "proc_LOADPALLETLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As LoadpalletMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
