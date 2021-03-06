'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 9/4/2014 6:52:59 PM
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
	MustInherit Public Class esAuditruleCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "AuditruleCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esAuditruleQuery)
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
            Me.InitQuery(CType(query, esAuditruleQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Auditrule) As Auditrule
			Return CType(MyBase.DetachEntity(entity), Auditrule)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Auditrule) As Auditrule
			Return CType(MyBase.AttachEntity(entity), Auditrule)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As AuditruleCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Auditrule
            Get
                Return TryCast(MyBase.Item(index), Auditrule)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Auditrule)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esAuditrule	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esAuditruleQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal auditruleid As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(auditruleid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(auditruleid)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal auditruleid As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(auditruleid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(auditruleid)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal auditruleid As System.Int32) As Boolean
		
			Dim query As esAuditruleQuery = Me.GetDynamicQuery()
			query.Where(query.Auditruleid.Equal(auditruleid))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal auditruleid As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("AUDITRULEID", auditruleid)
			
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
												
						Case "Auditruleid"
							Me.str.Auditruleid = CType(value, string)
												
						Case "Auditcategoryid"
							Me.str.Auditcategoryid = CType(value, string)
												
						Case "Messagedesc"
							Me.str.Messagedesc = CType(value, string)
												
						Case "Messagetitle"
							Me.str.Messagetitle = CType(value, string)
												
						Case "Messagetype"
							Me.str.Messagetype = CType(value, string)
												
						Case "Messagebuttontype"
							Me.str.Messagebuttontype = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Auditruleid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Auditruleid = CType(value, Nullable(Of System.Int32))
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
		' Maps to AUDITRULE.AUDITRULEID
		' </summary>
		Public Overridable Property Auditruleid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(AuditruleMetadata.ColumnNames.Auditruleid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(AuditruleMetadata.ColumnNames.Auditruleid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to AUDITRULE.AUDITCATEGORYID
		' </summary>
		Public Overridable Property Auditcategoryid As System.String
			Get
				Return MyBase.GetSystemString(AuditruleMetadata.ColumnNames.Auditcategoryid)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(AuditruleMetadata.ColumnNames.Auditcategoryid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to AUDITRULE.MESSAGEDESC
		' </summary>
		Public Overridable Property Messagedesc As System.String
			Get
				Return MyBase.GetSystemString(AuditruleMetadata.ColumnNames.Messagedesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(AuditruleMetadata.ColumnNames.Messagedesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to AUDITRULE.MESSAGETITLE
		' </summary>
		Public Overridable Property Messagetitle As System.String
			Get
				Return MyBase.GetSystemString(AuditruleMetadata.ColumnNames.Messagetitle)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(AuditruleMetadata.ColumnNames.Messagetitle, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to AUDITRULE.MESSAGETYPE
		' </summary>
		Public Overridable Property Messagetype As System.String
			Get
				Return MyBase.GetSystemString(AuditruleMetadata.ColumnNames.Messagetype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(AuditruleMetadata.ColumnNames.Messagetype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to AUDITRULE.MESSAGEBUTTONTYPE
		' </summary>
		Public Overridable Property Messagebuttontype As System.String
			Get
				Return MyBase.GetSystemString(AuditruleMetadata.ColumnNames.Messagebuttontype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(AuditruleMetadata.ColumnNames.Messagebuttontype, value)
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
		
			Public Sub New(ByVal entity As esAuditrule)
				Me.entity = entity
			End Sub				
		
	
			Public Property Auditruleid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Auditruleid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Auditruleid = Nothing
					Else
						entity.Auditruleid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Auditcategoryid As System.String 
				Get
					Dim data_ As System.String = entity.Auditcategoryid
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Auditcategoryid = Nothing
					Else
						entity.Auditcategoryid = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Messagedesc As System.String 
				Get
					Dim data_ As System.String = entity.Messagedesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Messagedesc = Nothing
					Else
						entity.Messagedesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Messagetitle As System.String 
				Get
					Dim data_ As System.String = entity.Messagetitle
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Messagetitle = Nothing
					Else
						entity.Messagetitle = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Messagetype As System.String 
				Get
					Dim data_ As System.String = entity.Messagetype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Messagetype = Nothing
					Else
						entity.Messagetype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Messagebuttontype As System.String 
				Get
					Dim data_ As System.String = entity.Messagebuttontype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Messagebuttontype = Nothing
					Else
						entity.Messagebuttontype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esAuditrule
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esAuditruleQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esAuditrule can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Auditrule 
		Inherits esAuditrule
		
	
		
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
	MustInherit Public Class esAuditruleQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return AuditruleMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Auditruleid As esQueryItem
			Get
				Return New esQueryItem(Me, AuditruleMetadata.ColumnNames.Auditruleid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Auditcategoryid As esQueryItem
			Get
				Return New esQueryItem(Me, AuditruleMetadata.ColumnNames.Auditcategoryid, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Messagedesc As esQueryItem
			Get
				Return New esQueryItem(Me, AuditruleMetadata.ColumnNames.Messagedesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Messagetitle As esQueryItem
			Get
				Return New esQueryItem(Me, AuditruleMetadata.ColumnNames.Messagetitle, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Messagetype As esQueryItem
			Get
				Return New esQueryItem(Me, AuditruleMetadata.ColumnNames.Messagetype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Messagebuttontype As esQueryItem
			Get
				Return New esQueryItem(Me, AuditruleMetadata.ColumnNames.Messagebuttontype, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("AuditruleCollection")> _
	Partial Public Class AuditruleCollection
		Inherits esAuditruleCollection
		Implements IEnumerable(Of Auditrule)
		
        Public Shared Widening Operator CType(ByVal coll As AuditruleCollection) As List(Of Auditrule)
            Dim list As List(Of Auditrule) = New List(Of Auditrule)
            Dim emp As Auditrule

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return AuditruleMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New AuditruleQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Auditrule(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Auditrule()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As AuditruleQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New AuditruleQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As AuditruleQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Auditrule 
			Return CType(MyBase.AddNewEntity(), Auditrule)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal auditruleid As System.Int32) As Auditrule
			Return CType(MyBase.FindByPrimaryKey(auditruleid), Auditrule)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Auditrule) Implements IEnumerable(Of Auditrule).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Auditrule)(Me)
        End Function
		
		Private _query As AuditruleQuery

	End Class
	


	' <summary>
	' Encapsulates the 'AUDITRULE' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Auditrule ({Auditruleid.Value})")> _
	<Serializable> _
	Partial Public Class Auditrule 
		Inherits esAuditrule

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return AuditruleMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esAuditruleQuery

			If Me._query Is Nothing Then
				Me._query = New AuditruleQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As AuditruleQuery
			Get

				If Me._query Is Nothing then
					Me._query = New AuditruleQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As AuditruleQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As AuditruleQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class AuditruleQuery
		inherits esAuditruleQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "AuditruleQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class AuditruleMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(AuditruleMetadata.ColumnNames.Auditruleid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = AuditruleMetadata.PropertyNames.Auditruleid
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(AuditruleMetadata.ColumnNames.Auditcategoryid, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = AuditruleMetadata.PropertyNames.Auditcategoryid
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(AuditruleMetadata.ColumnNames.Messagedesc, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = AuditruleMetadata.PropertyNames.Messagedesc
			c.CharacterMaxLength = 2000
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(AuditruleMetadata.ColumnNames.Messagetitle, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = AuditruleMetadata.PropertyNames.Messagetitle
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(AuditruleMetadata.ColumnNames.Messagetype, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = AuditruleMetadata.PropertyNames.Messagetype
			c.CharacterMaxLength = 20
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(AuditruleMetadata.ColumnNames.Messagebuttontype, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = AuditruleMetadata.PropertyNames.Messagebuttontype
			c.CharacterMaxLength = 20
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As AuditruleMetadata
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
			 Public Const Auditruleid As String = "AUDITRULEID"
			 Public Const Auditcategoryid As String = "AUDITCATEGORYID"
			 Public Const Messagedesc As String = "MESSAGEDESC"
			 Public Const Messagetitle As String = "MESSAGETITLE"
			 Public Const Messagetype As String = "MESSAGETYPE"
			 Public Const Messagebuttontype As String = "MESSAGEBUTTONTYPE"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Auditruleid As String = "Auditruleid"
			 Public Const Auditcategoryid As String = "Auditcategoryid"
			 Public Const Messagedesc As String = "Messagedesc"
			 Public Const Messagetitle As String = "Messagetitle"
			 Public Const Messagetype As String = "Messagetype"
			 Public Const Messagebuttontype As String = "Messagebuttontype"
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
            SyncLock GetType(AuditruleMetadata)
			
				If AuditruleMetadata.mapDelegates Is Nothing Then
					AuditruleMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If AuditruleMetadata._meta Is Nothing Then
                    AuditruleMetadata._meta = New AuditruleMetadata()
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
				

				meta.AddTypeMap("Auditruleid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Auditcategoryid", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Messagedesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Messagetitle", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Messagetype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Messagebuttontype", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "AUDITRULE"
				meta.Destination = "AUDITRULE"
				
				meta.spInsert = "proc_AUDITRULEInsert"
				meta.spUpdate = "proc_AUDITRULEUpdate"
				meta.spDelete = "proc_AUDITRULEDelete"
				meta.spLoadAll = "proc_AUDITRULELoadAll"
				meta.spLoadByPrimaryKey = "proc_AUDITRULELoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As AuditruleMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
