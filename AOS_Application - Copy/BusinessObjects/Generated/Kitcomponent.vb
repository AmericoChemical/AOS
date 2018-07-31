'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 9/11/2014 12:00:53 PM
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
	MustInherit Public Class esKitcomponentCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "KitcomponentCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esKitcomponentQuery)
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
            Me.InitQuery(CType(query, esKitcomponentQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Kitcomponent) As Kitcomponent
			Return CType(MyBase.DetachEntity(entity), Kitcomponent)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Kitcomponent) As Kitcomponent
			Return CType(MyBase.AttachEntity(entity), Kitcomponent)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As KitcomponentCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Kitcomponent
            Get
                Return TryCast(MyBase.Item(index), Kitcomponent)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Kitcomponent)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esKitcomponent	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esKitcomponentQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal kitcomponentid As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(kitcomponentid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(kitcomponentid)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal kitcomponentid As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(kitcomponentid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(kitcomponentid)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal kitcomponentid As System.Int32) As Boolean
		
			Dim query As esKitcomponentQuery = Me.GetDynamicQuery()
			query.Where(query.Kitcomponentid.Equal(kitcomponentid))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal kitcomponentid As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("KITCOMPONENTID", kitcomponentid)
			
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
												
						Case "Kitcomponentid"
							Me.str.Kitcomponentid = CType(value, string)
												
						Case "Kitid"
							Me.str.Kitid = CType(value, string)
												
						Case "Componentid"
							Me.str.Componentid = CType(value, string)
												
						Case "Componentqty"
							Me.str.Componentqty = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Kitcomponentid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Kitcomponentid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Kitid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Kitid = CType(value, Nullable(Of System.Double))
							End If
						
						Case "Componentid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Componentid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Componentqty"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Componentqty = CType(value, Nullable(Of System.Double))
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
		' Maps to KITCOMPONENT.KITCOMPONENTID
		' </summary>
		Public Overridable Property Kitcomponentid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(KitcomponentMetadata.ColumnNames.Kitcomponentid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(KitcomponentMetadata.ColumnNames.Kitcomponentid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to KITCOMPONENT.KITID
		' </summary>
		Public Overridable Property Kitid As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(KitcomponentMetadata.ColumnNames.Kitid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(KitcomponentMetadata.ColumnNames.Kitid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to KITCOMPONENT.COMPONENTID
		' </summary>
		Public Overridable Property Componentid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(KitcomponentMetadata.ColumnNames.Componentid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(KitcomponentMetadata.ColumnNames.Componentid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to KITCOMPONENT.COMPONENTQTY
		' </summary>
		Public Overridable Property Componentqty As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(KitcomponentMetadata.ColumnNames.Componentqty)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(KitcomponentMetadata.ColumnNames.Componentqty, value)
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
		
			Public Sub New(ByVal entity As esKitcomponent)
				Me.entity = entity
			End Sub				
		
	
			Public Property Kitcomponentid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Kitcomponentid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Kitcomponentid = Nothing
					Else
						entity.Kitcomponentid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Kitid As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Kitid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Kitid = Nothing
					Else
						entity.Kitid = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property Componentid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Componentid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Componentid = Nothing
					Else
						entity.Componentid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Componentqty As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Componentqty
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Componentqty = Nothing
					Else
						entity.Componentqty = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  

			Private entity As esKitcomponent
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esKitcomponentQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esKitcomponent can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Kitcomponent 
		Inherits esKitcomponent
		
	
		
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
	MustInherit Public Class esKitcomponentQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return KitcomponentMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Kitcomponentid As esQueryItem
			Get
				Return New esQueryItem(Me, KitcomponentMetadata.ColumnNames.Kitcomponentid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Kitid As esQueryItem
			Get
				Return New esQueryItem(Me, KitcomponentMetadata.ColumnNames.Kitid, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Componentid As esQueryItem
			Get
				Return New esQueryItem(Me, KitcomponentMetadata.ColumnNames.Componentid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Componentqty As esQueryItem
			Get
				Return New esQueryItem(Me, KitcomponentMetadata.ColumnNames.Componentqty, esSystemType.Double)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("KitcomponentCollection")> _
	Partial Public Class KitcomponentCollection
		Inherits esKitcomponentCollection
		Implements IEnumerable(Of Kitcomponent)
		
        Public Shared Widening Operator CType(ByVal coll As KitcomponentCollection) As List(Of Kitcomponent)
            Dim list As List(Of Kitcomponent) = New List(Of Kitcomponent)
            Dim emp As Kitcomponent

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return KitcomponentMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New KitcomponentQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Kitcomponent(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Kitcomponent()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As KitcomponentQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New KitcomponentQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As KitcomponentQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Kitcomponent 
			Return CType(MyBase.AddNewEntity(), Kitcomponent)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal kitcomponentid As System.Int32) As Kitcomponent
			Return CType(MyBase.FindByPrimaryKey(kitcomponentid), Kitcomponent)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Kitcomponent) Implements IEnumerable(Of Kitcomponent).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Kitcomponent)(Me)
        End Function
		
		Private _query As KitcomponentQuery

	End Class
	


	' <summary>
	' Encapsulates the 'KITCOMPONENT' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Kitcomponent ({Kitcomponentid.Value})")> _
	<Serializable> _
	Partial Public Class Kitcomponent 
		Inherits esKitcomponent

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return KitcomponentMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esKitcomponentQuery

			If Me._query Is Nothing Then
				Me._query = New KitcomponentQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As KitcomponentQuery
			Get

				If Me._query Is Nothing then
					Me._query = New KitcomponentQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As KitcomponentQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As KitcomponentQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class KitcomponentQuery
		inherits esKitcomponentQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "KitcomponentQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class KitcomponentMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(KitcomponentMetadata.ColumnNames.Kitcomponentid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = KitcomponentMetadata.PropertyNames.Kitcomponentid
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(KitcomponentMetadata.ColumnNames.Kitid, 1, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = KitcomponentMetadata.PropertyNames.Kitid
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(KitcomponentMetadata.ColumnNames.Componentid, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = KitcomponentMetadata.PropertyNames.Componentid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(KitcomponentMetadata.ColumnNames.Componentqty, 3, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = KitcomponentMetadata.PropertyNames.Componentqty
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As KitcomponentMetadata
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
			 Public Const Kitcomponentid As String = "KITCOMPONENTID"
			 Public Const Kitid As String = "KITID"
			 Public Const Componentid As String = "COMPONENTID"
			 Public Const Componentqty As String = "COMPONENTQTY"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Kitcomponentid As String = "Kitcomponentid"
			 Public Const Kitid As String = "Kitid"
			 Public Const Componentid As String = "Componentid"
			 Public Const Componentqty As String = "Componentqty"
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
            SyncLock GetType(KitcomponentMetadata)
			
				If KitcomponentMetadata.mapDelegates Is Nothing Then
					KitcomponentMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If KitcomponentMetadata._meta Is Nothing Then
                    KitcomponentMetadata._meta = New KitcomponentMetadata()
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
				

				meta.AddTypeMap("Kitcomponentid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Kitid", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Componentid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Componentqty", new esTypeMap("float", "System.Double"))			
				
				
				 
				meta.Source = "KITCOMPONENT"
				meta.Destination = "KITCOMPONENT"
				
				meta.spInsert = "proc_KITCOMPONENTInsert"
				meta.spUpdate = "proc_KITCOMPONENTUpdate"
				meta.spDelete = "proc_KITCOMPONENTDelete"
				meta.spLoadAll = "proc_KITCOMPONENTLoadAll"
				meta.spLoadByPrimaryKey = "proc_KITCOMPONENTLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As KitcomponentMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
