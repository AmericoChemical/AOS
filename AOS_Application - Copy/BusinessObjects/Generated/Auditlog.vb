'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 9/4/2014 9:01:50 PM
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
	MustInherit Public Class esAuditlogCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "AuditlogCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esAuditlogQuery)
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
            Me.InitQuery(CType(query, esAuditlogQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Auditlog) As Auditlog
			Return CType(MyBase.DetachEntity(entity), Auditlog)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Auditlog) As Auditlog
			Return CType(MyBase.AttachEntity(entity), Auditlog)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As AuditlogCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Auditlog
            Get
                Return TryCast(MyBase.Item(index), Auditlog)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Auditlog)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esAuditlog	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esAuditlogQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal auditlogid As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(auditlogid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(auditlogid)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal auditlogid As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(auditlogid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(auditlogid)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal auditlogid As System.Int32) As Boolean
		
			Dim query As esAuditlogQuery = Me.GetDynamicQuery()
			query.Where(query.Auditlogid.Equal(auditlogid))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal auditlogid As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("AUDITLOGID", auditlogid)
			
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
												
						Case "Auditlogid"
							Me.str.Auditlogid = CType(value, string)
												
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
												
						Case "Masterrecordid"
							Me.str.Masterrecordid = CType(value, string)
												
						Case "Auditreason"
							Me.str.Auditreason = CType(value, string)
												
						Case "Auditcategoryid"
							Me.str.Auditcategoryid = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Auditlogid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Auditlogid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Occurrence"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Occurrence = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Resolved"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Resolved = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Masterrecordid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Masterrecordid = CType(value, Nullable(Of System.Int32))
							End If
						
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
		' Maps to AUDITLOG.AUDITLOGID
		' </summary>
		Public Overridable Property Auditlogid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(AuditlogMetadata.ColumnNames.Auditlogid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(AuditlogMetadata.ColumnNames.Auditlogid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to AUDITLOG.DESCRIPTION
		' </summary>
		Public Overridable Property Description As System.String
			Get
				Return MyBase.GetSystemString(AuditlogMetadata.ColumnNames.Description)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(AuditlogMetadata.ColumnNames.Description, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to AUDITLOG.RESOLUTION
		' </summary>
		Public Overridable Property Resolution As System.String
			Get
				Return MyBase.GetSystemString(AuditlogMetadata.ColumnNames.Resolution)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(AuditlogMetadata.ColumnNames.Resolution, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to AUDITLOG.OCCURRENCE
		' </summary>
		Public Overridable Property Occurrence As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(AuditlogMetadata.ColumnNames.Occurrence)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(AuditlogMetadata.ColumnNames.Occurrence, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to AUDITLOG.OCCURRENCEBY
		' </summary>
		Public Overridable Property Occurrenceby As System.String
			Get
				Return MyBase.GetSystemString(AuditlogMetadata.ColumnNames.Occurrenceby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(AuditlogMetadata.ColumnNames.Occurrenceby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to AUDITLOG.RESOLVED
		' </summary>
		Public Overridable Property Resolved As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(AuditlogMetadata.ColumnNames.Resolved)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(AuditlogMetadata.ColumnNames.Resolved, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to AUDITLOG.RESOLVEDBY
		' </summary>
		Public Overridable Property Resolvedby As System.String
			Get
				Return MyBase.GetSystemString(AuditlogMetadata.ColumnNames.Resolvedby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(AuditlogMetadata.ColumnNames.Resolvedby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to AUDITLOG.STATUS
		' </summary>
		Public Overridable Property Status As System.String
			Get
				Return MyBase.GetSystemString(AuditlogMetadata.ColumnNames.Status)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(AuditlogMetadata.ColumnNames.Status, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to AUDITLOG.TYPE
		' </summary>
		Public Overridable Property Type As System.String
			Get
				Return MyBase.GetSystemString(AuditlogMetadata.ColumnNames.Type)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(AuditlogMetadata.ColumnNames.Type, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to AUDITLOG.MASTERRECORDID
		' </summary>
		Public Overridable Property Masterrecordid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(AuditlogMetadata.ColumnNames.Masterrecordid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(AuditlogMetadata.ColumnNames.Masterrecordid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to AUDITLOG.AUDITREASON
		' </summary>
		Public Overridable Property Auditreason As System.String
			Get
				Return MyBase.GetSystemString(AuditlogMetadata.ColumnNames.Auditreason)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(AuditlogMetadata.ColumnNames.Auditreason, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to AUDITLOG.AUDITCATEGORYID
		' </summary>
		Public Overridable Property Auditcategoryid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(AuditlogMetadata.ColumnNames.Auditcategoryid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(AuditlogMetadata.ColumnNames.Auditcategoryid, value)
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
		
			Public Sub New(ByVal entity As esAuditlog)
				Me.entity = entity
			End Sub				
		
	
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
		  

			Private entity As esAuditlog
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esAuditlogQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esAuditlog can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Auditlog 
		Inherits esAuditlog
		
	
		
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
	MustInherit Public Class esAuditlogQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return AuditlogMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Auditlogid As esQueryItem
			Get
				Return New esQueryItem(Me, AuditlogMetadata.ColumnNames.Auditlogid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Description As esQueryItem
			Get
				Return New esQueryItem(Me, AuditlogMetadata.ColumnNames.Description, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Resolution As esQueryItem
			Get
				Return New esQueryItem(Me, AuditlogMetadata.ColumnNames.Resolution, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Occurrence As esQueryItem
			Get
				Return New esQueryItem(Me, AuditlogMetadata.ColumnNames.Occurrence, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Occurrenceby As esQueryItem
			Get
				Return New esQueryItem(Me, AuditlogMetadata.ColumnNames.Occurrenceby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Resolved As esQueryItem
			Get
				Return New esQueryItem(Me, AuditlogMetadata.ColumnNames.Resolved, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Resolvedby As esQueryItem
			Get
				Return New esQueryItem(Me, AuditlogMetadata.ColumnNames.Resolvedby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Status As esQueryItem
			Get
				Return New esQueryItem(Me, AuditlogMetadata.ColumnNames.Status, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Type As esQueryItem
			Get
				Return New esQueryItem(Me, AuditlogMetadata.ColumnNames.Type, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Masterrecordid As esQueryItem
			Get
				Return New esQueryItem(Me, AuditlogMetadata.ColumnNames.Masterrecordid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Auditreason As esQueryItem
			Get
				Return New esQueryItem(Me, AuditlogMetadata.ColumnNames.Auditreason, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Auditcategoryid As esQueryItem
			Get
				Return New esQueryItem(Me, AuditlogMetadata.ColumnNames.Auditcategoryid, esSystemType.Int32)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("AuditlogCollection")> _
	Partial Public Class AuditlogCollection
		Inherits esAuditlogCollection
		Implements IEnumerable(Of Auditlog)
		
        Public Shared Widening Operator CType(ByVal coll As AuditlogCollection) As List(Of Auditlog)
            Dim list As List(Of Auditlog) = New List(Of Auditlog)
            Dim emp As Auditlog

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return AuditlogMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New AuditlogQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Auditlog(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Auditlog()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As AuditlogQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New AuditlogQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As AuditlogQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Auditlog 
			Return CType(MyBase.AddNewEntity(), Auditlog)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal auditlogid As System.Int32) As Auditlog
			Return CType(MyBase.FindByPrimaryKey(auditlogid), Auditlog)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Auditlog) Implements IEnumerable(Of Auditlog).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Auditlog)(Me)
        End Function
		
		Private _query As AuditlogQuery

	End Class
	


	' <summary>
	' Encapsulates the 'AUDITLOG' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Auditlog ({Auditlogid.Value})")> _
	<Serializable> _
	Partial Public Class Auditlog 
		Inherits esAuditlog

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return AuditlogMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esAuditlogQuery

			If Me._query Is Nothing Then
				Me._query = New AuditlogQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As AuditlogQuery
			Get

				If Me._query Is Nothing then
					Me._query = New AuditlogQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As AuditlogQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As AuditlogQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class AuditlogQuery
		inherits esAuditlogQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "AuditlogQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class AuditlogMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(AuditlogMetadata.ColumnNames.Auditlogid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = AuditlogMetadata.PropertyNames.Auditlogid
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(AuditlogMetadata.ColumnNames.Description, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = AuditlogMetadata.PropertyNames.Description
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(AuditlogMetadata.ColumnNames.Resolution, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = AuditlogMetadata.PropertyNames.Resolution
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(AuditlogMetadata.ColumnNames.Occurrence, 3, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = AuditlogMetadata.PropertyNames.Occurrence
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(AuditlogMetadata.ColumnNames.Occurrenceby, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = AuditlogMetadata.PropertyNames.Occurrenceby
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(AuditlogMetadata.ColumnNames.Resolved, 5, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = AuditlogMetadata.PropertyNames.Resolved
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(AuditlogMetadata.ColumnNames.Resolvedby, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = AuditlogMetadata.PropertyNames.Resolvedby
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(AuditlogMetadata.ColumnNames.Status, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = AuditlogMetadata.PropertyNames.Status
			c.CharacterMaxLength = 20
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(AuditlogMetadata.ColumnNames.Type, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = AuditlogMetadata.PropertyNames.Type
			c.CharacterMaxLength = 20
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(AuditlogMetadata.ColumnNames.Masterrecordid, 9, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = AuditlogMetadata.PropertyNames.Masterrecordid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(AuditlogMetadata.ColumnNames.Auditreason, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = AuditlogMetadata.PropertyNames.Auditreason
			c.CharacterMaxLength = 2000
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(AuditlogMetadata.ColumnNames.Auditcategoryid, 11, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = AuditlogMetadata.PropertyNames.Auditcategoryid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As AuditlogMetadata
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
			 Public Const Auditlogid As String = "AUDITLOGID"
			 Public Const Description As String = "DESCRIPTION"
			 Public Const Resolution As String = "RESOLUTION"
			 Public Const Occurrence As String = "OCCURRENCE"
			 Public Const Occurrenceby As String = "OCCURRENCEBY"
			 Public Const Resolved As String = "RESOLVED"
			 Public Const Resolvedby As String = "RESOLVEDBY"
			 Public Const Status As String = "STATUS"
			 Public Const Type As String = "TYPE"
			 Public Const Masterrecordid As String = "MASTERRECORDID"
			 Public Const Auditreason As String = "AUDITREASON"
			 Public Const Auditcategoryid As String = "AUDITCATEGORYID"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Auditlogid As String = "Auditlogid"
			 Public Const Description As String = "Description"
			 Public Const Resolution As String = "Resolution"
			 Public Const Occurrence As String = "Occurrence"
			 Public Const Occurrenceby As String = "Occurrenceby"
			 Public Const Resolved As String = "Resolved"
			 Public Const Resolvedby As String = "Resolvedby"
			 Public Const Status As String = "Status"
			 Public Const Type As String = "Type"
			 Public Const Masterrecordid As String = "Masterrecordid"
			 Public Const Auditreason As String = "Auditreason"
			 Public Const Auditcategoryid As String = "Auditcategoryid"
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
            SyncLock GetType(AuditlogMetadata)
			
				If AuditlogMetadata.mapDelegates Is Nothing Then
					AuditlogMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If AuditlogMetadata._meta Is Nothing Then
                    AuditlogMetadata._meta = New AuditlogMetadata()
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
				

				meta.AddTypeMap("Auditlogid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Description", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Resolution", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Occurrence", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Occurrenceby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Resolved", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Resolvedby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Status", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Type", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Masterrecordid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Auditreason", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Auditcategoryid", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "AUDITLOG"
				meta.Destination = "AUDITLOG"
				
				meta.spInsert = "proc_AUDITLOGInsert"
				meta.spUpdate = "proc_AUDITLOGUpdate"
				meta.spDelete = "proc_AUDITLOGDelete"
				meta.spLoadAll = "proc_AUDITLOGLoadAll"
				meta.spLoadByPrimaryKey = "proc_AUDITLOGLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As AuditlogMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
