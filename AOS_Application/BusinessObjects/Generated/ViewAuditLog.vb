'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 9/5/2014 10:21:24 AM
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
	MustInherit Public Class esViewAuditLogCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewAuditLogCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewAuditLogQuery)
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
            Me.InitQuery(CType(query, esViewAuditLogQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewAuditLog) As ViewAuditLog
			Return CType(MyBase.DetachEntity(entity), ViewAuditLog)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewAuditLog) As ViewAuditLog
			Return CType(MyBase.AttachEntity(entity), ViewAuditLog)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewAuditLogCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewAuditLog
            Get
                Return TryCast(MyBase.Item(index), ViewAuditLog)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewAuditLog)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewAuditLog	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewAuditLogQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		
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
												
						Case "Auditcategory"
							Me.str.Auditcategory = CType(value, string)
												
						Case "Description"
							Me.str.Description = CType(value, string)
												
						Case "Resolution"
							Me.str.Resolution = CType(value, string)
												
						Case "Occurrence"
							Me.str.Occurrence = CType(value, string)
												
						Case "Occurrenceby"
							Me.str.Occurrenceby = CType(value, string)
												
						Case "Resolved"
							Me.str.Resolved = CType(value, string)
												
						Case "Resolvedby"
							Me.str.Resolvedby = CType(value, string)
												
						Case "Status"
							Me.str.Status = CType(value, string)
												
						Case "Type"
							Me.str.Type = CType(value, string)
												
						Case "Auditlogid"
							Me.str.Auditlogid = CType(value, string)
												
						Case "Masterrecordid"
							Me.str.Masterrecordid = CType(value, string)
												
						Case "Auditreason"
							Me.str.Auditreason = CType(value, string)
												
						Case "Userid"
							Me.str.Userid = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Occurrence"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Occurrence = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Resolved"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Resolved = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Auditlogid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Auditlogid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Masterrecordid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Masterrecordid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Userid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Userid = CType(value, Nullable(Of System.Int32))
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
		' Maps to viewAuditLog.AUDITCATEGORY
		' </summary>
		Public Overridable Property Auditcategory As System.String
			Get
				Return MyBase.GetSystemString(ViewAuditLogMetadata.ColumnNames.Auditcategory)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewAuditLogMetadata.ColumnNames.Auditcategory, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAuditLog.DESCRIPTION
		' </summary>
		Public Overridable Property Description As System.String
			Get
				Return MyBase.GetSystemString(ViewAuditLogMetadata.ColumnNames.Description)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewAuditLogMetadata.ColumnNames.Description, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAuditLog.RESOLUTION
		' </summary>
		Public Overridable Property Resolution As System.String
			Get
				Return MyBase.GetSystemString(ViewAuditLogMetadata.ColumnNames.Resolution)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewAuditLogMetadata.ColumnNames.Resolution, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAuditLog.OCCURRENCE
		' </summary>
		Public Overridable Property Occurrence As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewAuditLogMetadata.ColumnNames.Occurrence)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewAuditLogMetadata.ColumnNames.Occurrence, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAuditLog.OCCURRENCEBY
		' </summary>
		Public Overridable Property Occurrenceby As System.String
			Get
				Return MyBase.GetSystemString(ViewAuditLogMetadata.ColumnNames.Occurrenceby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewAuditLogMetadata.ColumnNames.Occurrenceby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAuditLog.RESOLVED
		' </summary>
		Public Overridable Property Resolved As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewAuditLogMetadata.ColumnNames.Resolved)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewAuditLogMetadata.ColumnNames.Resolved, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAuditLog.RESOLVEDBY
		' </summary>
		Public Overridable Property Resolvedby As System.String
			Get
				Return MyBase.GetSystemString(ViewAuditLogMetadata.ColumnNames.Resolvedby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewAuditLogMetadata.ColumnNames.Resolvedby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAuditLog.STATUS
		' </summary>
		Public Overridable Property Status As System.String
			Get
				Return MyBase.GetSystemString(ViewAuditLogMetadata.ColumnNames.Status)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewAuditLogMetadata.ColumnNames.Status, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAuditLog.TYPE
		' </summary>
		Public Overridable Property Type As System.String
			Get
				Return MyBase.GetSystemString(ViewAuditLogMetadata.ColumnNames.Type)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewAuditLogMetadata.ColumnNames.Type, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAuditLog.AUDITLOGID
		' </summary>
		Public Overridable Property Auditlogid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewAuditLogMetadata.ColumnNames.Auditlogid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewAuditLogMetadata.ColumnNames.Auditlogid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAuditLog.MASTERRECORDID
		' </summary>
		Public Overridable Property Masterrecordid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewAuditLogMetadata.ColumnNames.Masterrecordid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewAuditLogMetadata.ColumnNames.Masterrecordid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAuditLog.AUDITREASON
		' </summary>
		Public Overridable Property Auditreason As System.String
			Get
				Return MyBase.GetSystemString(ViewAuditLogMetadata.ColumnNames.Auditreason)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewAuditLogMetadata.ColumnNames.Auditreason, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAuditLog.USERID
		' </summary>
		Public Overridable Property Userid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewAuditLogMetadata.ColumnNames.Userid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewAuditLogMetadata.ColumnNames.Userid, value)
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
		
			Public Sub New(ByVal entity As esViewAuditLog)
				Me.entity = entity
			End Sub				
		
	
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
		  	
			Public Property Description As System.String 
				Get
					Dim data_ As System.String = entity.Description
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Description = Nothing
					Else
						entity.Description = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Resolution As System.String 
				Get
					Dim data_ As System.String = entity.Resolution
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Resolution = Nothing
					Else
						entity.Resolution = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Occurrence As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Occurrence
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Occurrence = Nothing
					Else
						entity.Occurrence = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Occurrenceby As System.String 
				Get
					Dim data_ As System.String = entity.Occurrenceby
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Occurrenceby = Nothing
					Else
						entity.Occurrenceby = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Resolved As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Resolved
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Resolved = Nothing
					Else
						entity.Resolved = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Resolvedby As System.String 
				Get
					Dim data_ As System.String = entity.Resolvedby
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Resolvedby = Nothing
					Else
						entity.Resolvedby = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Status As System.String 
				Get
					Dim data_ As System.String = entity.Status
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Status = Nothing
					Else
						entity.Status = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Type As System.String 
				Get
					Dim data_ As System.String = entity.Type
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Type = Nothing
					Else
						entity.Type = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Auditlogid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Auditlogid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Auditlogid = Nothing
					Else
						entity.Auditlogid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Masterrecordid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Masterrecordid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Masterrecordid = Nothing
					Else
						entity.Masterrecordid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Auditreason As System.String 
				Get
					Dim data_ As System.String = entity.Auditreason
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Auditreason = Nothing
					Else
						entity.Auditreason = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Userid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Userid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Userid = Nothing
					Else
						entity.Userid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewAuditLog
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewAuditLogQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewAuditLog can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewAuditLogQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewAuditLogMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Auditcategory As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAuditLogMetadata.ColumnNames.Auditcategory, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Description As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAuditLogMetadata.ColumnNames.Description, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Resolution As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAuditLogMetadata.ColumnNames.Resolution, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Occurrence As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAuditLogMetadata.ColumnNames.Occurrence, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Occurrenceby As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAuditLogMetadata.ColumnNames.Occurrenceby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Resolved As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAuditLogMetadata.ColumnNames.Resolved, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Resolvedby As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAuditLogMetadata.ColumnNames.Resolvedby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Status As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAuditLogMetadata.ColumnNames.Status, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Type As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAuditLogMetadata.ColumnNames.Type, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Auditlogid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAuditLogMetadata.ColumnNames.Auditlogid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Masterrecordid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAuditLogMetadata.ColumnNames.Masterrecordid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Auditreason As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAuditLogMetadata.ColumnNames.Auditreason, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Userid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAuditLogMetadata.ColumnNames.Userid, esSystemType.Int32)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewAuditLogCollection")> _
	Partial Public Class ViewAuditLogCollection
		Inherits esViewAuditLogCollection
		Implements IEnumerable(Of ViewAuditLog)
		
        Public Shared Widening Operator CType(ByVal coll As ViewAuditLogCollection) As List(Of ViewAuditLog)
            Dim list As List(Of ViewAuditLog) = New List(Of ViewAuditLog)
            Dim emp As ViewAuditLog

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewAuditLogMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewAuditLogQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewAuditLog(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewAuditLog()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewAuditLogQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewAuditLogQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewAuditLogQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewAuditLog 
			Return CType(MyBase.AddNewEntity(), ViewAuditLog)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewAuditLog) Implements IEnumerable(Of ViewAuditLog).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewAuditLog)(Me)
        End Function
		
		Private _query As ViewAuditLogQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewAuditLog' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewAuditLog ()")> _
	<Serializable> _
	Partial Public Class ViewAuditLog 
		Inherits esViewAuditLog

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewAuditLogMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewAuditLogQuery

			If Me._query Is Nothing Then
				Me._query = New ViewAuditLogQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewAuditLogQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewAuditLogQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewAuditLogQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewAuditLogQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewAuditLogQuery
		inherits esViewAuditLogQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewAuditLogQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewAuditLogMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewAuditLogMetadata.ColumnNames.Auditcategory, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewAuditLogMetadata.PropertyNames.Auditcategory
			c.CharacterMaxLength = 255
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAuditLogMetadata.ColumnNames.Description, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewAuditLogMetadata.PropertyNames.Description
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAuditLogMetadata.ColumnNames.Resolution, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewAuditLogMetadata.PropertyNames.Resolution
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAuditLogMetadata.ColumnNames.Occurrence, 3, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewAuditLogMetadata.PropertyNames.Occurrence
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAuditLogMetadata.ColumnNames.Occurrenceby, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewAuditLogMetadata.PropertyNames.Occurrenceby
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAuditLogMetadata.ColumnNames.Resolved, 5, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewAuditLogMetadata.PropertyNames.Resolved
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAuditLogMetadata.ColumnNames.Resolvedby, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewAuditLogMetadata.PropertyNames.Resolvedby
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAuditLogMetadata.ColumnNames.Status, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewAuditLogMetadata.PropertyNames.Status
			c.CharacterMaxLength = 20
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAuditLogMetadata.ColumnNames.Type, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewAuditLogMetadata.PropertyNames.Type
			c.CharacterMaxLength = 20
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAuditLogMetadata.ColumnNames.Auditlogid, 9, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewAuditLogMetadata.PropertyNames.Auditlogid
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAuditLogMetadata.ColumnNames.Masterrecordid, 10, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewAuditLogMetadata.PropertyNames.Masterrecordid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAuditLogMetadata.ColumnNames.Auditreason, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewAuditLogMetadata.PropertyNames.Auditreason
			c.CharacterMaxLength = 2000
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAuditLogMetadata.ColumnNames.Userid, 12, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewAuditLogMetadata.PropertyNames.Userid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewAuditLogMetadata
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
			 Public Const Auditcategory As String = "AUDITCATEGORY"
			 Public Const Description As String = "DESCRIPTION"
			 Public Const Resolution As String = "RESOLUTION"
			 Public Const Occurrence As String = "OCCURRENCE"
			 Public Const Occurrenceby As String = "OCCURRENCEBY"
			 Public Const Resolved As String = "RESOLVED"
			 Public Const Resolvedby As String = "RESOLVEDBY"
			 Public Const Status As String = "STATUS"
			 Public Const Type As String = "TYPE"
			 Public Const Auditlogid As String = "AUDITLOGID"
			 Public Const Masterrecordid As String = "MASTERRECORDID"
			 Public Const Auditreason As String = "AUDITREASON"
			 Public Const Userid As String = "USERID"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Auditcategory As String = "Auditcategory"
			 Public Const Description As String = "Description"
			 Public Const Resolution As String = "Resolution"
			 Public Const Occurrence As String = "Occurrence"
			 Public Const Occurrenceby As String = "Occurrenceby"
			 Public Const Resolved As String = "Resolved"
			 Public Const Resolvedby As String = "Resolvedby"
			 Public Const Status As String = "Status"
			 Public Const Type As String = "Type"
			 Public Const Auditlogid As String = "Auditlogid"
			 Public Const Masterrecordid As String = "Masterrecordid"
			 Public Const Auditreason As String = "Auditreason"
			 Public Const Userid As String = "Userid"
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
            SyncLock GetType(ViewAuditLogMetadata)
			
				If ViewAuditLogMetadata.mapDelegates Is Nothing Then
					ViewAuditLogMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewAuditLogMetadata._meta Is Nothing Then
                    ViewAuditLogMetadata._meta = New ViewAuditLogMetadata()
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
				

				meta.AddTypeMap("Auditcategory", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Description", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Resolution", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Occurrence", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Occurrenceby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Resolved", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Resolvedby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Status", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Type", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Auditlogid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Masterrecordid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Auditreason", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Userid", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "viewAuditLog"
				meta.Destination = "viewAuditLog"
				
				meta.spInsert = "proc_viewAuditLogInsert"
				meta.spUpdate = "proc_viewAuditLogUpdate"
				meta.spDelete = "proc_viewAuditLogDelete"
				meta.spLoadAll = "proc_viewAuditLogLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewAuditLogLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewAuditLogMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
