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
	MustInherit Public Class esNoteCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "NoteCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esNoteQuery)
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
            Me.InitQuery(CType(query, esNoteQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Note) As Note
			Return CType(MyBase.DetachEntity(entity), Note)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Note) As Note
			Return CType(MyBase.AttachEntity(entity), Note)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As NoteCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Note
            Get
                Return TryCast(MyBase.Item(index), Note)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Note)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esNote	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esNoteQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal noteKey As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(noteKey)
			Else
				Return LoadByPrimaryKeyStoredProcedure(noteKey)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal noteKey As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(noteKey)
			Else
				Return LoadByPrimaryKeyStoredProcedure(noteKey)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal noteKey As System.Int32) As Boolean
		
			Dim query As esNoteQuery = Me.GetDynamicQuery()
			query.Where(query.NoteKey.Equal(noteKey))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal noteKey As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("NoteKey", noteKey)
			
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
												
						Case "NoteKey"
							Me.str.NoteKey = CType(value, string)
												
						Case "LinkType"
							Me.str.LinkType = CType(value, string)
												
						Case "LinkKey"
							Me.str.LinkKey = CType(value, string)
												
						Case "SourceType"
							Me.str.SourceType = CType(value, string)
												
						Case "SourceKey"
							Me.str.SourceKey = CType(value, string)
												
						Case "NoteText"
							Me.str.NoteText = CType(value, string)
												
						Case "CreateTime"
							Me.str.CreateTime = CType(value, string)
												
						Case "CreateBy"
							Me.str.CreateBy = CType(value, string)
												
						Case "ModifyTime"
							Me.str.ModifyTime = CType(value, string)
												
						Case "ModifyBy"
							Me.str.ModifyBy = CType(value, string)
												
						Case "IsDeleted"
							Me.str.IsDeleted = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "NoteKey"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.NoteKey = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "LinkKey"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.LinkKey = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "SourceKey"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SourceKey = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "CreateTime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.CreateTime = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "ModifyTime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.ModifyTime = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "IsDeleted"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.IsDeleted = CType(value, Nullable(Of System.Boolean))
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
		' Maps to NOTE.NoteKey
		' </summary>
		Public Overridable Property NoteKey As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(NoteMetadata.ColumnNames.NoteKey)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(NoteMetadata.ColumnNames.NoteKey, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to NOTE.LinkType
		' </summary>
		Public Overridable Property LinkType As System.String
			Get
				Return MyBase.GetSystemString(NoteMetadata.ColumnNames.LinkType)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(NoteMetadata.ColumnNames.LinkType, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to NOTE.LinkKey
		' </summary>
		Public Overridable Property LinkKey As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(NoteMetadata.ColumnNames.LinkKey)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(NoteMetadata.ColumnNames.LinkKey, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to NOTE.SourceType
		' </summary>
		Public Overridable Property SourceType As System.String
			Get
				Return MyBase.GetSystemString(NoteMetadata.ColumnNames.SourceType)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(NoteMetadata.ColumnNames.SourceType, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to NOTE.SourceKey
		' </summary>
		Public Overridable Property SourceKey As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(NoteMetadata.ColumnNames.SourceKey)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(NoteMetadata.ColumnNames.SourceKey, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to NOTE.NoteText
		' </summary>
		Public Overridable Property NoteText As System.String
			Get
				Return MyBase.GetSystemString(NoteMetadata.ColumnNames.NoteText)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(NoteMetadata.ColumnNames.NoteText, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to NOTE.CreateTime
		' </summary>
		Public Overridable Property CreateTime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(NoteMetadata.ColumnNames.CreateTime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(NoteMetadata.ColumnNames.CreateTime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to NOTE.CreateBy
		' </summary>
		Public Overridable Property CreateBy As System.String
			Get
				Return MyBase.GetSystemString(NoteMetadata.ColumnNames.CreateBy)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(NoteMetadata.ColumnNames.CreateBy, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to NOTE.ModifyTime
		' </summary>
		Public Overridable Property ModifyTime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(NoteMetadata.ColumnNames.ModifyTime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(NoteMetadata.ColumnNames.ModifyTime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to NOTE.ModifyBy
		' </summary>
		Public Overridable Property ModifyBy As System.String
			Get
				Return MyBase.GetSystemString(NoteMetadata.ColumnNames.ModifyBy)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(NoteMetadata.ColumnNames.ModifyBy, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to NOTE.IsDeleted
		' </summary>
		Public Overridable Property IsDeleted As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(NoteMetadata.ColumnNames.IsDeleted)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(NoteMetadata.ColumnNames.IsDeleted, value)
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
		
			Public Sub New(ByVal entity As esNote)
				Me.entity = entity
			End Sub				
		
	
			Public Property NoteKey As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.NoteKey
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NoteKey = Nothing
					Else
						entity.NoteKey = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property LinkType As System.String 
				Get
					Dim data_ As System.String = entity.LinkType
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LinkType = Nothing
					Else
						entity.LinkType = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property LinkKey As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.LinkKey
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LinkKey = Nothing
					Else
						entity.LinkKey = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property SourceType As System.String 
				Get
					Dim data_ As System.String = entity.SourceType
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SourceType = Nothing
					Else
						entity.SourceType = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SourceKey As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.SourceKey
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SourceKey = Nothing
					Else
						entity.SourceKey = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property NoteText As System.String 
				Get
					Dim data_ As System.String = entity.NoteText
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NoteText = Nothing
					Else
						entity.NoteText = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CreateTime As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.CreateTime
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CreateTime = Nothing
					Else
						entity.CreateTime = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property CreateBy As System.String 
				Get
					Dim data_ As System.String = entity.CreateBy
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CreateBy = Nothing
					Else
						entity.CreateBy = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ModifyTime As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.ModifyTime
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ModifyTime = Nothing
					Else
						entity.ModifyTime = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property ModifyBy As System.String 
				Get
					Dim data_ As System.String = entity.ModifyBy
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ModifyBy = Nothing
					Else
						entity.ModifyBy = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property IsDeleted As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.IsDeleted
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.IsDeleted = Nothing
					Else
						entity.IsDeleted = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  

			Private entity As esNote
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esNoteQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esNote can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Note 
		Inherits esNote
		
	
		
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
	MustInherit Public Class esNoteQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return NoteMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property NoteKey As esQueryItem
			Get
				Return New esQueryItem(Me, NoteMetadata.ColumnNames.NoteKey, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LinkType As esQueryItem
			Get
				Return New esQueryItem(Me, NoteMetadata.ColumnNames.LinkType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LinkKey As esQueryItem
			Get
				Return New esQueryItem(Me, NoteMetadata.ColumnNames.LinkKey, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property SourceType As esQueryItem
			Get
				Return New esQueryItem(Me, NoteMetadata.ColumnNames.SourceType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SourceKey As esQueryItem
			Get
				Return New esQueryItem(Me, NoteMetadata.ColumnNames.SourceKey, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property NoteText As esQueryItem
			Get
				Return New esQueryItem(Me, NoteMetadata.ColumnNames.NoteText, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CreateTime As esQueryItem
			Get
				Return New esQueryItem(Me, NoteMetadata.ColumnNames.CreateTime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property CreateBy As esQueryItem
			Get
				Return New esQueryItem(Me, NoteMetadata.ColumnNames.CreateBy, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ModifyTime As esQueryItem
			Get
				Return New esQueryItem(Me, NoteMetadata.ColumnNames.ModifyTime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ModifyBy As esQueryItem
			Get
				Return New esQueryItem(Me, NoteMetadata.ColumnNames.ModifyBy, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property IsDeleted As esQueryItem
			Get
				Return New esQueryItem(Me, NoteMetadata.ColumnNames.IsDeleted, esSystemType.Boolean)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("NoteCollection")> _
	Partial Public Class NoteCollection
		Inherits esNoteCollection
		Implements IEnumerable(Of Note)
		
        Public Shared Widening Operator CType(ByVal coll As NoteCollection) As List(Of Note)
            Dim list As List(Of Note) = New List(Of Note)
            Dim emp As Note

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return NoteMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New NoteQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Note(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Note()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As NoteQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New NoteQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As NoteQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Note 
			Return CType(MyBase.AddNewEntity(), Note)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal noteKey As System.Int32) As Note
			Return CType(MyBase.FindByPrimaryKey(noteKey), Note)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Note) Implements IEnumerable(Of Note).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Note)(Me)
        End Function
		
		Private _query As NoteQuery

	End Class
	


	' <summary>
	' Encapsulates the 'NOTE' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Note ({NoteKey.Value})")> _
	<Serializable> _
	Partial Public Class Note 
		Inherits esNote

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return NoteMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esNoteQuery

			If Me._query Is Nothing Then
				Me._query = New NoteQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As NoteQuery
			Get

				If Me._query Is Nothing then
					Me._query = New NoteQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As NoteQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As NoteQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class NoteQuery
		inherits esNoteQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "NoteQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class NoteMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(NoteMetadata.ColumnNames.NoteKey, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = NoteMetadata.PropertyNames.NoteKey
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(NoteMetadata.ColumnNames.LinkType, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = NoteMetadata.PropertyNames.LinkType
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(NoteMetadata.ColumnNames.LinkKey, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = NoteMetadata.PropertyNames.LinkKey
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(NoteMetadata.ColumnNames.SourceType, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = NoteMetadata.PropertyNames.SourceType
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(NoteMetadata.ColumnNames.SourceKey, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = NoteMetadata.PropertyNames.SourceKey
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(NoteMetadata.ColumnNames.NoteText, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = NoteMetadata.PropertyNames.NoteText
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(NoteMetadata.ColumnNames.CreateTime, 6, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = NoteMetadata.PropertyNames.CreateTime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(NoteMetadata.ColumnNames.CreateBy, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = NoteMetadata.PropertyNames.CreateBy
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(NoteMetadata.ColumnNames.ModifyTime, 8, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = NoteMetadata.PropertyNames.ModifyTime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(NoteMetadata.ColumnNames.ModifyBy, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = NoteMetadata.PropertyNames.ModifyBy
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(NoteMetadata.ColumnNames.IsDeleted, 10, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = NoteMetadata.PropertyNames.IsDeleted
			c.HasDefault = True
			c.Default = "((0))"
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As NoteMetadata
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
			 Public Const NoteKey As String = "NoteKey"
			 Public Const LinkType As String = "LinkType"
			 Public Const LinkKey As String = "LinkKey"
			 Public Const SourceType As String = "SourceType"
			 Public Const SourceKey As String = "SourceKey"
			 Public Const NoteText As String = "NoteText"
			 Public Const CreateTime As String = "CreateTime"
			 Public Const CreateBy As String = "CreateBy"
			 Public Const ModifyTime As String = "ModifyTime"
			 Public Const ModifyBy As String = "ModifyBy"
			 Public Const IsDeleted As String = "IsDeleted"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const NoteKey As String = "NoteKey"
			 Public Const LinkType As String = "LinkType"
			 Public Const LinkKey As String = "LinkKey"
			 Public Const SourceType As String = "SourceType"
			 Public Const SourceKey As String = "SourceKey"
			 Public Const NoteText As String = "NoteText"
			 Public Const CreateTime As String = "CreateTime"
			 Public Const CreateBy As String = "CreateBy"
			 Public Const ModifyTime As String = "ModifyTime"
			 Public Const ModifyBy As String = "ModifyBy"
			 Public Const IsDeleted As String = "IsDeleted"
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
            SyncLock GetType(NoteMetadata)
			
				If NoteMetadata.mapDelegates Is Nothing Then
					NoteMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If NoteMetadata._meta Is Nothing Then
                    NoteMetadata._meta = New NoteMetadata()
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
				

				meta.AddTypeMap("NoteKey", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("LinkType", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("LinkKey", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("SourceType", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("SourceKey", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("NoteText", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CreateTime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("CreateBy", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ModifyTime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("ModifyBy", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("IsDeleted", new esTypeMap("bit", "System.Boolean"))			
				
				
				 
				meta.Source = "NOTE"
				meta.Destination = "NOTE"
				
				meta.spInsert = "proc_NOTEInsert"
				meta.spUpdate = "proc_NOTEUpdate"
				meta.spDelete = "proc_NOTEDelete"
				meta.spLoadAll = "proc_NOTELoadAll"
				meta.spLoadByPrimaryKey = "proc_NOTELoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As NoteMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
