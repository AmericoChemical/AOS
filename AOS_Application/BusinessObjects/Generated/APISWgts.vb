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
	MustInherit Public Class esAPISWgtsCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "APISWgtsCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esAPISWgtsQuery)
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
            Me.InitQuery(CType(query, esAPISWgtsQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As APISWgts) As APISWgts
			Return CType(MyBase.DetachEntity(entity), APISWgts)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As APISWgts) As APISWgts
			Return CType(MyBase.AttachEntity(entity), APISWgts)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As APISWgtsCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As APISWgts
            Get
                Return TryCast(MyBase.Item(index), APISWgts)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(APISWgts)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esAPISWgts	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esAPISWgtsQuery
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
		
			Dim query As esAPISWgtsQuery = Me.GetDynamicQuery()
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
												
						Case "ProductID"
							Me.str.ProductID = CType(value, string)
												
						Case "ProductDesc"
							Me.str.ProductDesc = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "APISWgt"
							Me.str.APISWgt = CType(value, string)
												
						Case "LabelWgt"
							Me.str.LabelWgt = CType(value, string)
												
						Case "RMWgt"
							Me.str.RMWgt = CType(value, string)
												
						Case "LastShipped"
							Me.str.LastShipped = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "ProductID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.ProductID = CType(value, Nullable(Of System.Double))
							End If
						
						Case "APISWgt"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.APISWgt = CType(value, Nullable(Of System.Double))
							End If
						
						Case "LabelWgt"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.LabelWgt = CType(value, Nullable(Of System.Double))
							End If
						
						Case "RMWgt"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.RMWgt = CType(value, Nullable(Of System.Double))
							End If
						
						Case "LastShipped"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.LastShipped = CType(value, Nullable(Of System.DateTime))
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
		' Maps to APISWgts.ProductID
		' </summary>
		Public Overridable Property ProductID As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(APISWgtsMetadata.ColumnNames.ProductID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(APISWgtsMetadata.ColumnNames.ProductID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APISWgts.ProductDesc
		' </summary>
		Public Overridable Property ProductDesc As System.String
			Get
				Return MyBase.GetSystemString(APISWgtsMetadata.ColumnNames.ProductDesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(APISWgtsMetadata.ColumnNames.ProductDesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APISWgts.Container
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(APISWgtsMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(APISWgtsMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APISWgts.APISWgt
		' </summary>
		Public Overridable Property APISWgt As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(APISWgtsMetadata.ColumnNames.APISWgt)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(APISWgtsMetadata.ColumnNames.APISWgt, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APISWgts.LabelWgt
		' </summary>
		Public Overridable Property LabelWgt As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(APISWgtsMetadata.ColumnNames.LabelWgt)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(APISWgtsMetadata.ColumnNames.LabelWgt, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APISWgts.RMWgt
		' </summary>
		Public Overridable Property RMWgt As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(APISWgtsMetadata.ColumnNames.RMWgt)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(APISWgtsMetadata.ColumnNames.RMWgt, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APISWgts.LastShipped
		' </summary>
		Public Overridable Property LastShipped As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(APISWgtsMetadata.ColumnNames.LastShipped)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(APISWgtsMetadata.ColumnNames.LastShipped, value)
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
		
			Public Sub New(ByVal entity As esAPISWgts)
				Me.entity = entity
			End Sub				
		
	
			Public Property ProductID As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.ProductID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ProductID = Nothing
					Else
						entity.ProductID = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property ProductDesc As System.String 
				Get
					Dim data_ As System.String = entity.ProductDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ProductDesc = Nothing
					Else
						entity.ProductDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Container As System.String 
				Get
					Dim data_ As System.String = entity.Container
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Container = Nothing
					Else
						entity.Container = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property APISWgt As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.APISWgt
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.APISWgt = Nothing
					Else
						entity.APISWgt = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property LabelWgt As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.LabelWgt
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LabelWgt = Nothing
					Else
						entity.LabelWgt = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property RMWgt As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.RMWgt
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RMWgt = Nothing
					Else
						entity.RMWgt = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property LastShipped As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.LastShipped
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LastShipped = Nothing
					Else
						entity.LastShipped = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  

			Private entity As esAPISWgts
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esAPISWgtsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esAPISWgts can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class APISWgts 
		Inherits esAPISWgts
		
	
		
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
	MustInherit Public Class esAPISWgtsQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return APISWgtsMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property ProductID As esQueryItem
			Get
				Return New esQueryItem(Me, APISWgtsMetadata.ColumnNames.ProductID, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property ProductDesc As esQueryItem
			Get
				Return New esQueryItem(Me, APISWgtsMetadata.ColumnNames.ProductDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, APISWgtsMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property APISWgt As esQueryItem
			Get
				Return New esQueryItem(Me, APISWgtsMetadata.ColumnNames.APISWgt, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property LabelWgt As esQueryItem
			Get
				Return New esQueryItem(Me, APISWgtsMetadata.ColumnNames.LabelWgt, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property RMWgt As esQueryItem
			Get
				Return New esQueryItem(Me, APISWgtsMetadata.ColumnNames.RMWgt, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property LastShipped As esQueryItem
			Get
				Return New esQueryItem(Me, APISWgtsMetadata.ColumnNames.LastShipped, esSystemType.DateTime)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("APISWgtsCollection")> _
	Partial Public Class APISWgtsCollection
		Inherits esAPISWgtsCollection
		Implements IEnumerable(Of APISWgts)
		
        Public Shared Widening Operator CType(ByVal coll As APISWgtsCollection) As List(Of APISWgts)
            Dim list As List(Of APISWgts) = New List(Of APISWgts)
            Dim emp As APISWgts

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return APISWgtsMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New APISWgtsQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New APISWgts(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New APISWgts()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As APISWgtsQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New APISWgtsQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As APISWgtsQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As APISWgts 
			Return CType(MyBase.AddNewEntity(), APISWgts)
		End Function

		Public Overloads Function FindByPrimaryKey() As APISWgts
			Return CType(MyBase.FindByPrimaryKey(), APISWgts)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of APISWgts) Implements IEnumerable(Of APISWgts).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of APISWgts)(Me)
        End Function
		
		Private _query As APISWgtsQuery

	End Class
	


	' <summary>
	' Encapsulates the 'APISWgts' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("APISWgts ()")> _
	<Serializable> _
	Partial Public Class APISWgts 
		Inherits esAPISWgts

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return APISWgtsMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esAPISWgtsQuery

			If Me._query Is Nothing Then
				Me._query = New APISWgtsQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As APISWgtsQuery
			Get

				If Me._query Is Nothing then
					Me._query = New APISWgtsQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As APISWgtsQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As APISWgtsQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class APISWgtsQuery
		inherits esAPISWgtsQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "APISWgtsQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class APISWgtsMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(APISWgtsMetadata.ColumnNames.ProductID, 0, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = APISWgtsMetadata.PropertyNames.ProductID
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(APISWgtsMetadata.ColumnNames.ProductDesc, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = APISWgtsMetadata.PropertyNames.ProductDesc
			c.CharacterMaxLength = 255
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(APISWgtsMetadata.ColumnNames.Container, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = APISWgtsMetadata.PropertyNames.Container
			c.CharacterMaxLength = 255
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(APISWgtsMetadata.ColumnNames.APISWgt, 3, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = APISWgtsMetadata.PropertyNames.APISWgt
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(APISWgtsMetadata.ColumnNames.LabelWgt, 4, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = APISWgtsMetadata.PropertyNames.LabelWgt
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(APISWgtsMetadata.ColumnNames.RMWgt, 5, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = APISWgtsMetadata.PropertyNames.RMWgt
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(APISWgtsMetadata.ColumnNames.LastShipped, 6, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = APISWgtsMetadata.PropertyNames.LastShipped
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As APISWgtsMetadata
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
			 Public Const ProductID As String = "ProductID"
			 Public Const ProductDesc As String = "ProductDesc"
			 Public Const Container As String = "Container"
			 Public Const APISWgt As String = "APISWgt"
			 Public Const LabelWgt As String = "LabelWgt"
			 Public Const RMWgt As String = "RMWgt"
			 Public Const LastShipped As String = "LastShipped"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const ProductID As String = "ProductID"
			 Public Const ProductDesc As String = "ProductDesc"
			 Public Const Container As String = "Container"
			 Public Const APISWgt As String = "APISWgt"
			 Public Const LabelWgt As String = "LabelWgt"
			 Public Const RMWgt As String = "RMWgt"
			 Public Const LastShipped As String = "LastShipped"
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
            SyncLock GetType(APISWgtsMetadata)
			
				If APISWgtsMetadata.mapDelegates Is Nothing Then
					APISWgtsMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If APISWgtsMetadata._meta Is Nothing Then
                    APISWgtsMetadata._meta = New APISWgtsMetadata()
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
				

				meta.AddTypeMap("ProductID", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("ProductDesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Container", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("APISWgt", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("LabelWgt", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("RMWgt", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("LastShipped", new esTypeMap("datetime", "System.DateTime"))			
				
				
				 
				meta.Source = "APISWgts"
				meta.Destination = "APISWgts"
				
				meta.spInsert = "proc_APISWgtsInsert"
				meta.spUpdate = "proc_APISWgtsUpdate"
				meta.spDelete = "proc_APISWgtsDelete"
				meta.spLoadAll = "proc_APISWgtsLoadAll"
				meta.spLoadByPrimaryKey = "proc_APISWgtsLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As APISWgtsMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
