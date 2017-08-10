'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 03-03-2015 12:58:29
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
	MustInherit Public Class esViewWorkOrderAvailableSourceStatusCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewWorkOrderAvailableSourceStatusCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewWorkOrderAvailableSourceStatusQuery)
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
            Me.InitQuery(CType(query, esViewWorkOrderAvailableSourceStatusQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewWorkOrderAvailableSourceStatus) As ViewWorkOrderAvailableSourceStatus
			Return CType(MyBase.DetachEntity(entity), ViewWorkOrderAvailableSourceStatus)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewWorkOrderAvailableSourceStatus) As ViewWorkOrderAvailableSourceStatus
			Return CType(MyBase.AttachEntity(entity), ViewWorkOrderAvailableSourceStatus)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewWorkOrderAvailableSourceStatusCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewWorkOrderAvailableSourceStatus
            Get
                Return TryCast(MyBase.Item(index), ViewWorkOrderAvailableSourceStatus)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewWorkOrderAvailableSourceStatus)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewWorkOrderAvailableSourceStatus	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewWorkOrderAvailableSourceStatusQuery
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
												
						Case "Workorderitemnumber"
							Me.str.Workorderitemnumber = CType(value, string)
												
						Case "ExceptedDate"
							Me.str.ExceptedDate = CType(value, string)
												
						Case "Expectedindate"
							Me.str.Expectedindate = CType(value, string)
												
						Case "Dateneeded"
							Me.str.Dateneeded = CType(value, string)
												
						Case "Sourcestatus"
							Me.str.Sourcestatus = CType(value, string)
												
						Case "Available"
							Me.str.Available = CType(value, string)
												
						Case "Estimatedcompletiondate"
							Me.str.Estimatedcompletiondate = CType(value, string)
												
						Case "Neededby"
							Me.str.Neededby = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Workorderitemnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Workorderitemnumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "ExceptedDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.ExceptedDate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Expectedindate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Expectedindate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Dateneeded"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Dateneeded = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Available"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Available = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Estimatedcompletiondate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Estimatedcompletiondate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Neededby"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Neededby = CType(value, Nullable(Of System.DateTime))
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
		' Maps to viewWorkOrderAvailableSourceStatus.WORKORDERITEMNUMBER
		' </summary>
		Public Overridable Property Workorderitemnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewWorkOrderAvailableSourceStatusMetadata.ColumnNames.Workorderitemnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewWorkOrderAvailableSourceStatusMetadata.ColumnNames.Workorderitemnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderAvailableSourceStatus.ExceptedDate
		' </summary>
		Public Overridable Property ExceptedDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewWorkOrderAvailableSourceStatusMetadata.ColumnNames.ExceptedDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewWorkOrderAvailableSourceStatusMetadata.ColumnNames.ExceptedDate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderAvailableSourceStatus.EXPECTEDINDATE
		' </summary>
		Public Overridable Property Expectedindate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewWorkOrderAvailableSourceStatusMetadata.ColumnNames.Expectedindate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewWorkOrderAvailableSourceStatusMetadata.ColumnNames.Expectedindate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderAvailableSourceStatus.DATENEEDED
		' </summary>
		Public Overridable Property Dateneeded As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewWorkOrderAvailableSourceStatusMetadata.ColumnNames.Dateneeded)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewWorkOrderAvailableSourceStatusMetadata.ColumnNames.Dateneeded, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderAvailableSourceStatus.SOURCESTATUS
		' </summary>
		Public Overridable Property Sourcestatus As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderAvailableSourceStatusMetadata.ColumnNames.Sourcestatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderAvailableSourceStatusMetadata.ColumnNames.Sourcestatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderAvailableSourceStatus.Available
		' </summary>
		Public Overridable Property Available As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewWorkOrderAvailableSourceStatusMetadata.ColumnNames.Available)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewWorkOrderAvailableSourceStatusMetadata.ColumnNames.Available, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderAvailableSourceStatus.ESTIMATEDCOMPLETIONDATE
		' </summary>
		Public Overridable Property Estimatedcompletiondate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewWorkOrderAvailableSourceStatusMetadata.ColumnNames.Estimatedcompletiondate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewWorkOrderAvailableSourceStatusMetadata.ColumnNames.Estimatedcompletiondate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderAvailableSourceStatus.NEEDEDBY
		' </summary>
		Public Overridable Property Neededby As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewWorkOrderAvailableSourceStatusMetadata.ColumnNames.Neededby)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewWorkOrderAvailableSourceStatusMetadata.ColumnNames.Neededby, value)
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
		
			Public Sub New(ByVal entity As esViewWorkOrderAvailableSourceStatus)
				Me.entity = entity
			End Sub				
		
	
			Public Property Workorderitemnumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Workorderitemnumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Workorderitemnumber = Nothing
					Else
						entity.Workorderitemnumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property ExceptedDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.ExceptedDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ExceptedDate = Nothing
					Else
						entity.ExceptedDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Expectedindate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Expectedindate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Expectedindate = Nothing
					Else
						entity.Expectedindate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Dateneeded As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Dateneeded
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Dateneeded = Nothing
					Else
						entity.Dateneeded = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Sourcestatus As System.String 
				Get
					Dim data_ As System.String = entity.Sourcestatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Sourcestatus = Nothing
					Else
						entity.Sourcestatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Available As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Available
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Available = Nothing
					Else
						entity.Available = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Estimatedcompletiondate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Estimatedcompletiondate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Estimatedcompletiondate = Nothing
					Else
						entity.Estimatedcompletiondate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Neededby As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Neededby
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Neededby = Nothing
					Else
						entity.Neededby = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewWorkOrderAvailableSourceStatus
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewWorkOrderAvailableSourceStatusQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewWorkOrderAvailableSourceStatus can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewWorkOrderAvailableSourceStatusQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewWorkOrderAvailableSourceStatusMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Workorderitemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderAvailableSourceStatusMetadata.ColumnNames.Workorderitemnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ExceptedDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderAvailableSourceStatusMetadata.ColumnNames.ExceptedDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Expectedindate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderAvailableSourceStatusMetadata.ColumnNames.Expectedindate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Dateneeded As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderAvailableSourceStatusMetadata.ColumnNames.Dateneeded, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Sourcestatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderAvailableSourceStatusMetadata.ColumnNames.Sourcestatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Available As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderAvailableSourceStatusMetadata.ColumnNames.Available, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Estimatedcompletiondate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderAvailableSourceStatusMetadata.ColumnNames.Estimatedcompletiondate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Neededby As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderAvailableSourceStatusMetadata.ColumnNames.Neededby, esSystemType.DateTime)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewWorkOrderAvailableSourceStatusCollection")> _
	Partial Public Class ViewWorkOrderAvailableSourceStatusCollection
		Inherits esViewWorkOrderAvailableSourceStatusCollection
		Implements IEnumerable(Of ViewWorkOrderAvailableSourceStatus)
		
        Public Shared Widening Operator CType(ByVal coll As ViewWorkOrderAvailableSourceStatusCollection) As List(Of ViewWorkOrderAvailableSourceStatus)
            Dim list As List(Of ViewWorkOrderAvailableSourceStatus) = New List(Of ViewWorkOrderAvailableSourceStatus)
            Dim emp As ViewWorkOrderAvailableSourceStatus

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewWorkOrderAvailableSourceStatusMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewWorkOrderAvailableSourceStatusQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewWorkOrderAvailableSourceStatus(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewWorkOrderAvailableSourceStatus()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewWorkOrderAvailableSourceStatusQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewWorkOrderAvailableSourceStatusQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewWorkOrderAvailableSourceStatusQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewWorkOrderAvailableSourceStatus 
			Return CType(MyBase.AddNewEntity(), ViewWorkOrderAvailableSourceStatus)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewWorkOrderAvailableSourceStatus) Implements IEnumerable(Of ViewWorkOrderAvailableSourceStatus).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewWorkOrderAvailableSourceStatus)(Me)
        End Function
		
		Private _query As ViewWorkOrderAvailableSourceStatusQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewWorkOrderAvailableSourceStatus' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewWorkOrderAvailableSourceStatus ()")> _
	<Serializable> _
	Partial Public Class ViewWorkOrderAvailableSourceStatus 
		Inherits esViewWorkOrderAvailableSourceStatus

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewWorkOrderAvailableSourceStatusMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewWorkOrderAvailableSourceStatusQuery

			If Me._query Is Nothing Then
				Me._query = New ViewWorkOrderAvailableSourceStatusQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewWorkOrderAvailableSourceStatusQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewWorkOrderAvailableSourceStatusQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewWorkOrderAvailableSourceStatusQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewWorkOrderAvailableSourceStatusQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewWorkOrderAvailableSourceStatusQuery
		inherits esViewWorkOrderAvailableSourceStatusQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewWorkOrderAvailableSourceStatusQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewWorkOrderAvailableSourceStatusMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewWorkOrderAvailableSourceStatusMetadata.ColumnNames.Workorderitemnumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewWorkOrderAvailableSourceStatusMetadata.PropertyNames.Workorderitemnumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderAvailableSourceStatusMetadata.ColumnNames.ExceptedDate, 1, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewWorkOrderAvailableSourceStatusMetadata.PropertyNames.ExceptedDate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderAvailableSourceStatusMetadata.ColumnNames.Expectedindate, 2, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewWorkOrderAvailableSourceStatusMetadata.PropertyNames.Expectedindate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderAvailableSourceStatusMetadata.ColumnNames.Dateneeded, 3, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewWorkOrderAvailableSourceStatusMetadata.PropertyNames.Dateneeded
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderAvailableSourceStatusMetadata.ColumnNames.Sourcestatus, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderAvailableSourceStatusMetadata.PropertyNames.Sourcestatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderAvailableSourceStatusMetadata.ColumnNames.Available, 5, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewWorkOrderAvailableSourceStatusMetadata.PropertyNames.Available
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderAvailableSourceStatusMetadata.ColumnNames.Estimatedcompletiondate, 6, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewWorkOrderAvailableSourceStatusMetadata.PropertyNames.Estimatedcompletiondate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderAvailableSourceStatusMetadata.ColumnNames.Neededby, 7, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewWorkOrderAvailableSourceStatusMetadata.PropertyNames.Neededby
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewWorkOrderAvailableSourceStatusMetadata
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
			 Public Const Workorderitemnumber As String = "WORKORDERITEMNUMBER"
			 Public Const ExceptedDate As String = "ExceptedDate"
			 Public Const Expectedindate As String = "EXPECTEDINDATE"
			 Public Const Dateneeded As String = "DATENEEDED"
			 Public Const Sourcestatus As String = "SOURCESTATUS"
			 Public Const Available As String = "Available"
			 Public Const Estimatedcompletiondate As String = "ESTIMATEDCOMPLETIONDATE"
			 Public Const Neededby As String = "NEEDEDBY"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Workorderitemnumber As String = "Workorderitemnumber"
			 Public Const ExceptedDate As String = "ExceptedDate"
			 Public Const Expectedindate As String = "Expectedindate"
			 Public Const Dateneeded As String = "Dateneeded"
			 Public Const Sourcestatus As String = "Sourcestatus"
			 Public Const Available As String = "Available"
			 Public Const Estimatedcompletiondate As String = "Estimatedcompletiondate"
			 Public Const Neededby As String = "Neededby"
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
            SyncLock GetType(ViewWorkOrderAvailableSourceStatusMetadata)
			
				If ViewWorkOrderAvailableSourceStatusMetadata.mapDelegates Is Nothing Then
					ViewWorkOrderAvailableSourceStatusMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewWorkOrderAvailableSourceStatusMetadata._meta Is Nothing Then
                    ViewWorkOrderAvailableSourceStatusMetadata._meta = New ViewWorkOrderAvailableSourceStatusMetadata()
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
				

				meta.AddTypeMap("Workorderitemnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ExceptedDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Expectedindate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Dateneeded", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Sourcestatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Available", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Estimatedcompletiondate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Neededby", new esTypeMap("datetime", "System.DateTime"))			
				
				
				 
				meta.Source = "viewWorkOrderAvailableSourceStatus"
				meta.Destination = "viewWorkOrderAvailableSourceStatus"
				
				meta.spInsert = "proc_viewWorkOrderAvailableSourceStatusInsert"
				meta.spUpdate = "proc_viewWorkOrderAvailableSourceStatusUpdate"
				meta.spDelete = "proc_viewWorkOrderAvailableSourceStatusDelete"
				meta.spLoadAll = "proc_viewWorkOrderAvailableSourceStatusLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewWorkOrderAvailableSourceStatusLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewWorkOrderAvailableSourceStatusMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
