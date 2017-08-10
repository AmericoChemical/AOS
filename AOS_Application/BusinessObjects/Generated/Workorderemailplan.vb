'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/5/2015 5:20:08 PM
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
	MustInherit Public Class esWorkorderemailplanCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "WorkorderemailplanCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esWorkorderemailplanQuery)
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
            Me.InitQuery(CType(query, esWorkorderemailplanQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Workorderemailplan) As Workorderemailplan
			Return CType(MyBase.DetachEntity(entity), Workorderemailplan)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Workorderemailplan) As Workorderemailplan
			Return CType(MyBase.AttachEntity(entity), Workorderemailplan)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As WorkorderemailplanCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Workorderemailplan
            Get
                Return TryCast(MyBase.Item(index), Workorderemailplan)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Workorderemailplan)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esWorkorderemailplan	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esWorkorderemailplanQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal workorderemailplanid As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(workorderemailplanid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(workorderemailplanid)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal workorderemailplanid As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(workorderemailplanid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(workorderemailplanid)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal workorderemailplanid As System.Int32) As Boolean
		
			Dim query As esWorkorderemailplanQuery = Me.GetDynamicQuery()
			query.Where(query.Workorderemailplanid.Equal(workorderemailplanid))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal workorderemailplanid As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("WORKORDEREMAILPLANID", workorderemailplanid)
			
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
												
						Case "Workorderemailplanid"
							Me.str.Workorderemailplanid = CType(value, string)
												
						Case "Toemailid"
							Me.str.Toemailid = CType(value, string)
												
						Case "Subjecttext"
							Me.str.Subjecttext = CType(value, string)
												
						Case "Bodytext"
							Me.str.Bodytext = CType(value, string)
												
						Case "Createdby"
							Me.str.Createdby = CType(value, string)
												
						Case "Createdtime"
							Me.str.Createdtime = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Workorderemailplanid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Workorderemailplanid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Createdtime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Createdtime = CType(value, Nullable(Of System.DateTime))
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
		' Maps to WORKORDEREMAILPLAN.WORKORDEREMAILPLANID
		' </summary>
		Public Overridable Property Workorderemailplanid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(WorkorderemailplanMetadata.ColumnNames.Workorderemailplanid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(WorkorderemailplanMetadata.ColumnNames.Workorderemailplanid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDEREMAILPLAN.TOEMAILID
		' </summary>
		Public Overridable Property Toemailid As System.String
			Get
				Return MyBase.GetSystemString(WorkorderemailplanMetadata.ColumnNames.Toemailid)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(WorkorderemailplanMetadata.ColumnNames.Toemailid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDEREMAILPLAN.SUBJECTTEXT
		' </summary>
		Public Overridable Property Subjecttext As System.String
			Get
				Return MyBase.GetSystemString(WorkorderemailplanMetadata.ColumnNames.Subjecttext)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(WorkorderemailplanMetadata.ColumnNames.Subjecttext, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDEREMAILPLAN.BODYTEXT
		' </summary>
		Public Overridable Property Bodytext As System.String
			Get
				Return MyBase.GetSystemString(WorkorderemailplanMetadata.ColumnNames.Bodytext)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(WorkorderemailplanMetadata.ColumnNames.Bodytext, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDEREMAILPLAN.CREATEDBY
		' </summary>
		Public Overridable Property Createdby As System.String
			Get
				Return MyBase.GetSystemString(WorkorderemailplanMetadata.ColumnNames.Createdby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(WorkorderemailplanMetadata.ColumnNames.Createdby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to WORKORDEREMAILPLAN.CREATEDTIME
		' </summary>
		Public Overridable Property Createdtime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(WorkorderemailplanMetadata.ColumnNames.Createdtime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(WorkorderemailplanMetadata.ColumnNames.Createdtime, value)
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
		
			Public Sub New(ByVal entity As esWorkorderemailplan)
				Me.entity = entity
			End Sub				
		
	
			Public Property Workorderemailplanid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Workorderemailplanid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Workorderemailplanid = Nothing
					Else
						entity.Workorderemailplanid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Toemailid As System.String 
				Get
					Dim data_ As System.String = entity.Toemailid
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Toemailid = Nothing
					Else
						entity.Toemailid = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Subjecttext As System.String 
				Get
					Dim data_ As System.String = entity.Subjecttext
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Subjecttext = Nothing
					Else
						entity.Subjecttext = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Bodytext As System.String 
				Get
					Dim data_ As System.String = entity.Bodytext
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Bodytext = Nothing
					Else
						entity.Bodytext = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Createdby As System.String 
				Get
					Dim data_ As System.String = entity.Createdby
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Createdby = Nothing
					Else
						entity.Createdby = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Createdtime As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Createdtime
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Createdtime = Nothing
					Else
						entity.Createdtime = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  

			Private entity As esWorkorderemailplan
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esWorkorderemailplanQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esWorkorderemailplan can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Workorderemailplan 
		Inherits esWorkorderemailplan
		
	
		
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
	MustInherit Public Class esWorkorderemailplanQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return WorkorderemailplanMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Workorderemailplanid As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderemailplanMetadata.ColumnNames.Workorderemailplanid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Toemailid As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderemailplanMetadata.ColumnNames.Toemailid, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Subjecttext As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderemailplanMetadata.ColumnNames.Subjecttext, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Bodytext As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderemailplanMetadata.ColumnNames.Bodytext, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Createdby As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderemailplanMetadata.ColumnNames.Createdby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Createdtime As esQueryItem
			Get
				Return New esQueryItem(Me, WorkorderemailplanMetadata.ColumnNames.Createdtime, esSystemType.DateTime)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("WorkorderemailplanCollection")> _
	Partial Public Class WorkorderemailplanCollection
		Inherits esWorkorderemailplanCollection
		Implements IEnumerable(Of Workorderemailplan)
		
        Public Shared Widening Operator CType(ByVal coll As WorkorderemailplanCollection) As List(Of Workorderemailplan)
            Dim list As List(Of Workorderemailplan) = New List(Of Workorderemailplan)
            Dim emp As Workorderemailplan

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return WorkorderemailplanMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New WorkorderemailplanQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Workorderemailplan(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Workorderemailplan()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As WorkorderemailplanQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New WorkorderemailplanQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As WorkorderemailplanQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Workorderemailplan 
			Return CType(MyBase.AddNewEntity(), Workorderemailplan)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal workorderemailplanid As System.Int32) As Workorderemailplan
			Return CType(MyBase.FindByPrimaryKey(workorderemailplanid), Workorderemailplan)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Workorderemailplan) Implements IEnumerable(Of Workorderemailplan).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Workorderemailplan)(Me)
        End Function
		
		Private _query As WorkorderemailplanQuery

	End Class
	


	' <summary>
	' Encapsulates the 'WORKORDEREMAILPLAN' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Workorderemailplan ({Workorderemailplanid.Value})")> _
	<Serializable> _
	Partial Public Class Workorderemailplan 
		Inherits esWorkorderemailplan

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return WorkorderemailplanMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esWorkorderemailplanQuery

			If Me._query Is Nothing Then
				Me._query = New WorkorderemailplanQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As WorkorderemailplanQuery
			Get

				If Me._query Is Nothing then
					Me._query = New WorkorderemailplanQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As WorkorderemailplanQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As WorkorderemailplanQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class WorkorderemailplanQuery
		inherits esWorkorderemailplanQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "WorkorderemailplanQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class WorkorderemailplanMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(WorkorderemailplanMetadata.ColumnNames.Workorderemailplanid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = WorkorderemailplanMetadata.PropertyNames.Workorderemailplanid
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderemailplanMetadata.ColumnNames.Toemailid, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = WorkorderemailplanMetadata.PropertyNames.Toemailid
			c.CharacterMaxLength = 250
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderemailplanMetadata.ColumnNames.Subjecttext, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = WorkorderemailplanMetadata.PropertyNames.Subjecttext
			c.CharacterMaxLength = 250
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderemailplanMetadata.ColumnNames.Bodytext, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = WorkorderemailplanMetadata.PropertyNames.Bodytext
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderemailplanMetadata.ColumnNames.Createdby, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = WorkorderemailplanMetadata.PropertyNames.Createdby
			c.CharacterMaxLength = 50
			_columns.Add(c)
				
			c = New esColumnMetadata(WorkorderemailplanMetadata.ColumnNames.Createdtime, 5, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = WorkorderemailplanMetadata.PropertyNames.Createdtime
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As WorkorderemailplanMetadata
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
			 Public Const Workorderemailplanid As String = "WORKORDEREMAILPLANID"
			 Public Const Toemailid As String = "TOEMAILID"
			 Public Const Subjecttext As String = "SUBJECTTEXT"
			 Public Const Bodytext As String = "BODYTEXT"
			 Public Const Createdby As String = "CREATEDBY"
			 Public Const Createdtime As String = "CREATEDTIME"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Workorderemailplanid As String = "Workorderemailplanid"
			 Public Const Toemailid As String = "Toemailid"
			 Public Const Subjecttext As String = "Subjecttext"
			 Public Const Bodytext As String = "Bodytext"
			 Public Const Createdby As String = "Createdby"
			 Public Const Createdtime As String = "Createdtime"
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
            SyncLock GetType(WorkorderemailplanMetadata)
			
				If WorkorderemailplanMetadata.mapDelegates Is Nothing Then
					WorkorderemailplanMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If WorkorderemailplanMetadata._meta Is Nothing Then
                    WorkorderemailplanMetadata._meta = New WorkorderemailplanMetadata()
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
				

				meta.AddTypeMap("Workorderemailplanid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Toemailid", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Subjecttext", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Bodytext", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Createdby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Createdtime", new esTypeMap("datetime", "System.DateTime"))			
				
				
				 
				meta.Source = "WORKORDEREMAILPLAN"
				meta.Destination = "WORKORDEREMAILPLAN"
				
				meta.spInsert = "proc_WORKORDEREMAILPLANInsert"
				meta.spUpdate = "proc_WORKORDEREMAILPLANUpdate"
				meta.spDelete = "proc_WORKORDEREMAILPLANDelete"
				meta.spLoadAll = "proc_WORKORDEREMAILPLANLoadAll"
				meta.spLoadByPrimaryKey = "proc_WORKORDEREMAILPLANLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As WorkorderemailplanMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
