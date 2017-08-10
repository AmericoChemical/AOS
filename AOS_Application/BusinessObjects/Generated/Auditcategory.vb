'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 8/21/2014 3:54:12 PM
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
	MustInherit Public Class esAuditcategoryCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "AuditcategoryCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esAuditcategoryQuery)
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
            Me.InitQuery(CType(query, esAuditcategoryQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Auditcategory) As Auditcategory
			Return CType(MyBase.DetachEntity(entity), Auditcategory)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Auditcategory) As Auditcategory
			Return CType(MyBase.AttachEntity(entity), Auditcategory)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As AuditcategoryCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Auditcategory
            Get
                Return TryCast(MyBase.Item(index), Auditcategory)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Auditcategory)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esAuditcategory	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esAuditcategoryQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal auditcategoryid As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(auditcategoryid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(auditcategoryid)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal auditcategoryid As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(auditcategoryid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(auditcategoryid)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal auditcategoryid As System.Int32) As Boolean
		
			Dim query As esAuditcategoryQuery = Me.GetDynamicQuery()
			query.Where(query.Auditcategoryid.Equal(auditcategoryid))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal auditcategoryid As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("AUDITCATEGORYID", auditcategoryid)
			
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
												
						Case "Auditcategoryid"
							Me.str.Auditcategoryid = CType(value, string)
												
						Case "Auditcategory"
							Me.str.Auditcategory = CType(value, string)
												
						Case "Auditformname"
							Me.str.Auditformname = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Auditcategoryid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Auditcategoryid = CType(value, Nullable(Of System.Int32))
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
		' Maps to AUDITCATEGORY.AUDITCATEGORYID
		' </summary>
		Public Overridable Property Auditcategoryid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(AuditcategoryMetadata.ColumnNames.Auditcategoryid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(AuditcategoryMetadata.ColumnNames.Auditcategoryid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to AUDITCATEGORY.AUDITCATEGORY
		' </summary>
		Public Overridable Property Auditcategory As System.String
			Get
				Return MyBase.GetSystemString(AuditcategoryMetadata.ColumnNames.Auditcategory)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(AuditcategoryMetadata.ColumnNames.Auditcategory, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to AUDITCATEGORY.AUDITFORMNAME
		' </summary>
		Public Overridable Property Auditformname As System.String
			Get
				Return MyBase.GetSystemString(AuditcategoryMetadata.ColumnNames.Auditformname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(AuditcategoryMetadata.ColumnNames.Auditformname, value)
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
		
			Public Sub New(ByVal entity As esAuditcategory)
				Me.entity = entity
			End Sub				
		
	
			Public Property Auditcategoryid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Auditcategoryid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Auditcategoryid = Nothing
					Else
						entity.Auditcategoryid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Auditcategory As System.String 
				Get
					Dim data_ As System.String = entity.Auditcategory
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Auditcategory = Nothing
					Else
						entity.Auditcategory = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Auditformname As System.String 
				Get
					Dim data_ As System.String = entity.Auditformname
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Auditformname = Nothing
					Else
						entity.Auditformname = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esAuditcategory
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esAuditcategoryQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esAuditcategory can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Auditcategory 
		Inherits esAuditcategory
		
	
		
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
	MustInherit Public Class esAuditcategoryQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return AuditcategoryMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Auditcategoryid As esQueryItem
			Get
				Return New esQueryItem(Me, AuditcategoryMetadata.ColumnNames.Auditcategoryid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Auditcategory As esQueryItem
			Get
				Return New esQueryItem(Me, AuditcategoryMetadata.ColumnNames.Auditcategory, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Auditformname As esQueryItem
			Get
				Return New esQueryItem(Me, AuditcategoryMetadata.ColumnNames.Auditformname, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("AuditcategoryCollection")> _
	Partial Public Class AuditcategoryCollection
		Inherits esAuditcategoryCollection
		Implements IEnumerable(Of Auditcategory)
		
        Public Shared Widening Operator CType(ByVal coll As AuditcategoryCollection) As List(Of Auditcategory)
            Dim list As List(Of Auditcategory) = New List(Of Auditcategory)
            Dim emp As Auditcategory

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return AuditcategoryMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New AuditcategoryQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Auditcategory(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Auditcategory()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As AuditcategoryQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New AuditcategoryQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As AuditcategoryQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Auditcategory 
			Return CType(MyBase.AddNewEntity(), Auditcategory)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal auditcategoryid As System.Int32) As Auditcategory
			Return CType(MyBase.FindByPrimaryKey(auditcategoryid), Auditcategory)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Auditcategory) Implements IEnumerable(Of Auditcategory).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Auditcategory)(Me)
        End Function
		
		Private _query As AuditcategoryQuery

	End Class
	


	' <summary>
	' Encapsulates the 'AUDITCATEGORY' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Auditcategory ({Auditcategoryid.Value})")> _
	<Serializable> _
	Partial Public Class Auditcategory 
		Inherits esAuditcategory

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return AuditcategoryMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esAuditcategoryQuery

			If Me._query Is Nothing Then
				Me._query = New AuditcategoryQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As AuditcategoryQuery
			Get

				If Me._query Is Nothing then
					Me._query = New AuditcategoryQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As AuditcategoryQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As AuditcategoryQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class AuditcategoryQuery
		inherits esAuditcategoryQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "AuditcategoryQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class AuditcategoryMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(AuditcategoryMetadata.ColumnNames.Auditcategoryid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = AuditcategoryMetadata.PropertyNames.Auditcategoryid
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(AuditcategoryMetadata.ColumnNames.Auditcategory, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = AuditcategoryMetadata.PropertyNames.Auditcategory
			c.CharacterMaxLength = 255
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(AuditcategoryMetadata.ColumnNames.Auditformname, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = AuditcategoryMetadata.PropertyNames.Auditformname
			c.CharacterMaxLength = 255
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As AuditcategoryMetadata
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
			 Public Const Auditcategoryid As String = "AUDITCATEGORYID"
			 Public Const Auditcategory As String = "AUDITCATEGORY"
			 Public Const Auditformname As String = "AUDITFORMNAME"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Auditcategoryid As String = "Auditcategoryid"
			 Public Const Auditcategory As String = "Auditcategory"
			 Public Const Auditformname As String = "Auditformname"
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
            SyncLock GetType(AuditcategoryMetadata)
			
				If AuditcategoryMetadata.mapDelegates Is Nothing Then
					AuditcategoryMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If AuditcategoryMetadata._meta Is Nothing Then
                    AuditcategoryMetadata._meta = New AuditcategoryMetadata()
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
				

				meta.AddTypeMap("Auditcategoryid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Auditcategory", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Auditformname", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "AUDITCATEGORY"
				meta.Destination = "AUDITCATEGORY"
				
				meta.spInsert = "proc_AUDITCATEGORYInsert"
				meta.spUpdate = "proc_AUDITCATEGORYUpdate"
				meta.spDelete = "proc_AUDITCATEGORYDelete"
				meta.spLoadAll = "proc_AUDITCATEGORYLoadAll"
				meta.spLoadByPrimaryKey = "proc_AUDITCATEGORYLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As AuditcategoryMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
