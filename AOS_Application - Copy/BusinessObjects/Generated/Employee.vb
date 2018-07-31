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
	MustInherit Public Class esEmployeeCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "EmployeeCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esEmployeeQuery)
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
            Me.InitQuery(CType(query, esEmployeeQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Employee) As Employee
			Return CType(MyBase.DetachEntity(entity), Employee)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Employee) As Employee
			Return CType(MyBase.AttachEntity(entity), Employee)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As EmployeeCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Employee
            Get
                Return TryCast(MyBase.Item(index), Employee)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Employee)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esEmployee	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esEmployeeQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal employeeID As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(employeeID)
			Else
				Return LoadByPrimaryKeyStoredProcedure(employeeID)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal employeeID As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(employeeID)
			Else
				Return LoadByPrimaryKeyStoredProcedure(employeeID)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal employeeID As System.Int32) As Boolean
		
			Dim query As esEmployeeQuery = Me.GetDynamicQuery()
			query.Where(query.EmployeeID.Equal(employeeID))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal employeeID As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("EmployeeID", employeeID)
			
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
												
						Case "EmployeeID"
							Me.str.EmployeeID = CType(value, string)
												
						Case "EmployeeName"
							Me.str.EmployeeName = CType(value, string)
												
						Case "IsActive"
							Me.str.IsActive = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "EmployeeID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.EmployeeID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "IsActive"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.IsActive = CType(value, Nullable(Of System.Boolean))
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
		' Maps to EMPLOYEE.EmployeeID
		' </summary>
		Public Overridable Property EmployeeID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(EmployeeMetadata.ColumnNames.EmployeeID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(EmployeeMetadata.ColumnNames.EmployeeID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to EMPLOYEE.EmployeeName
		' </summary>
		Public Overridable Property EmployeeName As System.String
			Get
				Return MyBase.GetSystemString(EmployeeMetadata.ColumnNames.EmployeeName)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(EmployeeMetadata.ColumnNames.EmployeeName, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to EMPLOYEE.IsActive
		' </summary>
		Public Overridable Property IsActive As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(EmployeeMetadata.ColumnNames.IsActive)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(EmployeeMetadata.ColumnNames.IsActive, value)
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
		
			Public Sub New(ByVal entity As esEmployee)
				Me.entity = entity
			End Sub				
		
	
			Public Property EmployeeID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.EmployeeID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EmployeeID = Nothing
					Else
						entity.EmployeeID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property EmployeeName As System.String 
				Get
					Dim data_ As System.String = entity.EmployeeName
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EmployeeName = Nothing
					Else
						entity.EmployeeName = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property IsActive As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.IsActive
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.IsActive = Nothing
					Else
						entity.IsActive = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  

			Private entity As esEmployee
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esEmployeeQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esEmployee can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Employee 
		Inherits esEmployee
		
	
		
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
	MustInherit Public Class esEmployeeQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return EmployeeMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property EmployeeID As esQueryItem
			Get
				Return New esQueryItem(Me, EmployeeMetadata.ColumnNames.EmployeeID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property EmployeeName As esQueryItem
			Get
				Return New esQueryItem(Me, EmployeeMetadata.ColumnNames.EmployeeName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property IsActive As esQueryItem
			Get
				Return New esQueryItem(Me, EmployeeMetadata.ColumnNames.IsActive, esSystemType.Boolean)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("EmployeeCollection")> _
	Partial Public Class EmployeeCollection
		Inherits esEmployeeCollection
		Implements IEnumerable(Of Employee)
		
        Public Shared Widening Operator CType(ByVal coll As EmployeeCollection) As List(Of Employee)
            Dim list As List(Of Employee) = New List(Of Employee)
            Dim emp As Employee

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return EmployeeMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New EmployeeQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Employee(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Employee()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As EmployeeQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New EmployeeQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As EmployeeQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Employee 
			Return CType(MyBase.AddNewEntity(), Employee)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal employeeID As System.Int32) As Employee
			Return CType(MyBase.FindByPrimaryKey(employeeID), Employee)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Employee) Implements IEnumerable(Of Employee).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Employee)(Me)
        End Function
		
		Private _query As EmployeeQuery

	End Class
	


	' <summary>
	' Encapsulates the 'EMPLOYEE' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Employee ({EmployeeID.Value})")> _
	<Serializable> _
	Partial Public Class Employee 
		Inherits esEmployee

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return EmployeeMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esEmployeeQuery

			If Me._query Is Nothing Then
				Me._query = New EmployeeQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As EmployeeQuery
			Get

				If Me._query Is Nothing then
					Me._query = New EmployeeQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As EmployeeQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As EmployeeQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class EmployeeQuery
		inherits esEmployeeQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "EmployeeQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class EmployeeMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(EmployeeMetadata.ColumnNames.EmployeeID, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = EmployeeMetadata.PropertyNames.EmployeeID
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(EmployeeMetadata.ColumnNames.EmployeeName, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = EmployeeMetadata.PropertyNames.EmployeeName
			c.CharacterMaxLength = 50
			_columns.Add(c)
				
			c = New esColumnMetadata(EmployeeMetadata.ColumnNames.IsActive, 2, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = EmployeeMetadata.PropertyNames.IsActive
			c.HasDefault = True
			c.Default = "((1))"
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As EmployeeMetadata
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
			 Public Const EmployeeID As String = "EmployeeID"
			 Public Const EmployeeName As String = "EmployeeName"
			 Public Const IsActive As String = "IsActive"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const EmployeeID As String = "EmployeeID"
			 Public Const EmployeeName As String = "EmployeeName"
			 Public Const IsActive As String = "IsActive"
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
            SyncLock GetType(EmployeeMetadata)
			
				If EmployeeMetadata.mapDelegates Is Nothing Then
					EmployeeMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If EmployeeMetadata._meta Is Nothing Then
                    EmployeeMetadata._meta = New EmployeeMetadata()
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
				

				meta.AddTypeMap("EmployeeID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("EmployeeName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("IsActive", new esTypeMap("bit", "System.Boolean"))			
				
				
				 
				meta.Source = "EMPLOYEE"
				meta.Destination = "EMPLOYEE"
				
				meta.spInsert = "proc_EMPLOYEEInsert"
				meta.spUpdate = "proc_EMPLOYEEUpdate"
				meta.spDelete = "proc_EMPLOYEEDelete"
				meta.spLoadAll = "proc_EMPLOYEELoadAll"
				meta.spLoadByPrimaryKey = "proc_EMPLOYEELoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As EmployeeMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
