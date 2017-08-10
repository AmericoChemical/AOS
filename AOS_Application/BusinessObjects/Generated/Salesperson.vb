'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 4/15/2014 3:41:16 PM
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
	MustInherit Public Class esSalespersonCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "SalespersonCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esSalespersonQuery)
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
            Me.InitQuery(CType(query, esSalespersonQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Salesperson) As Salesperson
			Return CType(MyBase.DetachEntity(entity), Salesperson)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Salesperson) As Salesperson
			Return CType(MyBase.AttachEntity(entity), Salesperson)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As SalespersonCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Salesperson
            Get
                Return TryCast(MyBase.Item(index), Salesperson)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Salesperson)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esSalesperson	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esSalespersonQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal salespersonid As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(salespersonid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(salespersonid)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal salespersonid As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(salespersonid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(salespersonid)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal salespersonid As System.Int32) As Boolean
		
			Dim query As esSalespersonQuery = Me.GetDynamicQuery()
			query.Where(query.Salespersonid.Equal(salespersonid))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal salespersonid As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("SALESPERSONID", salespersonid)
			
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
												
						Case "Salespersonid"
							Me.str.Salespersonid = CType(value, string)
												
						Case "Salespersonfirstname"
							Me.str.Salespersonfirstname = CType(value, string)
												
						Case "Salespersonlastname"
							Me.str.Salespersonlastname = CType(value, string)
												
						Case "Salespersontitle"
							Me.str.Salespersontitle = CType(value, string)
												
						Case "Salespersonfullname"
							Me.str.Salespersonfullname = CType(value, string)
												
						Case "Status"
							Me.str.Status = CType(value, string)
												
						Case "Saleslevel"
							Me.str.Saleslevel = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Salespersonid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Salespersonid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Saleslevel"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Saleslevel = CType(value, Nullable(Of System.Int32))
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
		' Maps to SALESPERSON.SALESPERSONID
		' </summary>
		Public Overridable Property Salespersonid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(SalespersonMetadata.ColumnNames.Salespersonid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(SalespersonMetadata.ColumnNames.Salespersonid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SALESPERSON.SALESPERSONFIRSTNAME
		' </summary>
		Public Overridable Property Salespersonfirstname As System.String
			Get
				Return MyBase.GetSystemString(SalespersonMetadata.ColumnNames.Salespersonfirstname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(SalespersonMetadata.ColumnNames.Salespersonfirstname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SALESPERSON.SALESPERSONLASTNAME
		' </summary>
		Public Overridable Property Salespersonlastname As System.String
			Get
				Return MyBase.GetSystemString(SalespersonMetadata.ColumnNames.Salespersonlastname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(SalespersonMetadata.ColumnNames.Salespersonlastname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SALESPERSON.SALESPERSONTITLE
		' </summary>
		Public Overridable Property Salespersontitle As System.String
			Get
				Return MyBase.GetSystemString(SalespersonMetadata.ColumnNames.Salespersontitle)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(SalespersonMetadata.ColumnNames.Salespersontitle, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SALESPERSON.SALESPERSONFULLNAME
		' </summary>
		Public Overridable Property Salespersonfullname As System.String
			Get
				Return MyBase.GetSystemString(SalespersonMetadata.ColumnNames.Salespersonfullname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(SalespersonMetadata.ColumnNames.Salespersonfullname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SALESPERSON.STATUS
		' </summary>
		Public Overridable Property Status As System.String
			Get
				Return MyBase.GetSystemString(SalespersonMetadata.ColumnNames.Status)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(SalespersonMetadata.ColumnNames.Status, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SALESPERSON.SALESLEVEL
		' </summary>
		Public Overridable Property Saleslevel As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(SalespersonMetadata.ColumnNames.Saleslevel)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(SalespersonMetadata.ColumnNames.Saleslevel, value)
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
		
			Public Sub New(ByVal entity As esSalesperson)
				Me.entity = entity
			End Sub				
		
	
			Public Property Salespersonid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Salespersonid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Salespersonid = Nothing
					Else
						entity.Salespersonid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Salespersonfirstname As System.String 
				Get
					Dim data_ As System.String = entity.Salespersonfirstname
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Salespersonfirstname = Nothing
					Else
						entity.Salespersonfirstname = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Salespersonlastname As System.String 
				Get
					Dim data_ As System.String = entity.Salespersonlastname
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Salespersonlastname = Nothing
					Else
						entity.Salespersonlastname = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Salespersontitle As System.String 
				Get
					Dim data_ As System.String = entity.Salespersontitle
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Salespersontitle = Nothing
					Else
						entity.Salespersontitle = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Salespersonfullname As System.String 
				Get
					Dim data_ As System.String = entity.Salespersonfullname
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Salespersonfullname = Nothing
					Else
						entity.Salespersonfullname = Convert.ToString(Value)
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
		  	
			Public Property Saleslevel As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Saleslevel
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Saleslevel = Nothing
					Else
						entity.Saleslevel = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esSalesperson
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esSalespersonQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esSalesperson can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Salesperson 
		Inherits esSalesperson
		
	
		
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
	MustInherit Public Class esSalespersonQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return SalespersonMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Salespersonid As esQueryItem
			Get
				Return New esQueryItem(Me, SalespersonMetadata.ColumnNames.Salespersonid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Salespersonfirstname As esQueryItem
			Get
				Return New esQueryItem(Me, SalespersonMetadata.ColumnNames.Salespersonfirstname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Salespersonlastname As esQueryItem
			Get
				Return New esQueryItem(Me, SalespersonMetadata.ColumnNames.Salespersonlastname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Salespersontitle As esQueryItem
			Get
				Return New esQueryItem(Me, SalespersonMetadata.ColumnNames.Salespersontitle, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Salespersonfullname As esQueryItem
			Get
				Return New esQueryItem(Me, SalespersonMetadata.ColumnNames.Salespersonfullname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Status As esQueryItem
			Get
				Return New esQueryItem(Me, SalespersonMetadata.ColumnNames.Status, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Saleslevel As esQueryItem
			Get
				Return New esQueryItem(Me, SalespersonMetadata.ColumnNames.Saleslevel, esSystemType.Int32)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("SalespersonCollection")> _
	Partial Public Class SalespersonCollection
		Inherits esSalespersonCollection
		Implements IEnumerable(Of Salesperson)
		
        Public Shared Widening Operator CType(ByVal coll As SalespersonCollection) As List(Of Salesperson)
            Dim list As List(Of Salesperson) = New List(Of Salesperson)
            Dim emp As Salesperson

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return SalespersonMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New SalespersonQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Salesperson(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Salesperson()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As SalespersonQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New SalespersonQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As SalespersonQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Salesperson 
			Return CType(MyBase.AddNewEntity(), Salesperson)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal salespersonid As System.Int32) As Salesperson
			Return CType(MyBase.FindByPrimaryKey(salespersonid), Salesperson)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Salesperson) Implements IEnumerable(Of Salesperson).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Salesperson)(Me)
        End Function
		
		Private _query As SalespersonQuery

	End Class
	


	' <summary>
	' Encapsulates the 'SALESPERSON' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Salesperson ({Salespersonid.Value})")> _
	<Serializable> _
	Partial Public Class Salesperson 
		Inherits esSalesperson

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return SalespersonMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esSalespersonQuery

			If Me._query Is Nothing Then
				Me._query = New SalespersonQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As SalespersonQuery
			Get

				If Me._query Is Nothing then
					Me._query = New SalespersonQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As SalespersonQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As SalespersonQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class SalespersonQuery
		inherits esSalespersonQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "SalespersonQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class SalespersonMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(SalespersonMetadata.ColumnNames.Salespersonid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = SalespersonMetadata.PropertyNames.Salespersonid
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(SalespersonMetadata.ColumnNames.Salespersonfirstname, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = SalespersonMetadata.PropertyNames.Salespersonfirstname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(SalespersonMetadata.ColumnNames.Salespersonlastname, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = SalespersonMetadata.PropertyNames.Salespersonlastname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(SalespersonMetadata.ColumnNames.Salespersontitle, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = SalespersonMetadata.PropertyNames.Salespersontitle
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(SalespersonMetadata.ColumnNames.Salespersonfullname, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = SalespersonMetadata.PropertyNames.Salespersonfullname
			c.CharacterMaxLength = 101
			c.IsNullable = True
			c.IsComputed = True
			_columns.Add(c)
				
			c = New esColumnMetadata(SalespersonMetadata.ColumnNames.Status, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = SalespersonMetadata.PropertyNames.Status
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(SalespersonMetadata.ColumnNames.Saleslevel, 6, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = SalespersonMetadata.PropertyNames.Saleslevel
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As SalespersonMetadata
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
			 Public Const Salespersonid As String = "SALESPERSONID"
			 Public Const Salespersonfirstname As String = "SALESPERSONFIRSTNAME"
			 Public Const Salespersonlastname As String = "SALESPERSONLASTNAME"
			 Public Const Salespersontitle As String = "SALESPERSONTITLE"
			 Public Const Salespersonfullname As String = "SALESPERSONFULLNAME"
			 Public Const Status As String = "STATUS"
			 Public Const Saleslevel As String = "SALESLEVEL"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Salespersonid As String = "Salespersonid"
			 Public Const Salespersonfirstname As String = "Salespersonfirstname"
			 Public Const Salespersonlastname As String = "Salespersonlastname"
			 Public Const Salespersontitle As String = "Salespersontitle"
			 Public Const Salespersonfullname As String = "Salespersonfullname"
			 Public Const Status As String = "Status"
			 Public Const Saleslevel As String = "Saleslevel"
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
            SyncLock GetType(SalespersonMetadata)
			
				If SalespersonMetadata.mapDelegates Is Nothing Then
					SalespersonMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If SalespersonMetadata._meta Is Nothing Then
                    SalespersonMetadata._meta = New SalespersonMetadata()
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
				

				meta.AddTypeMap("Salespersonid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Salespersonfirstname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Salespersonlastname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Salespersontitle", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Salespersonfullname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Status", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Saleslevel", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "SALESPERSON"
				meta.Destination = "SALESPERSON"
				
				meta.spInsert = "proc_SALESPERSONInsert"
				meta.spUpdate = "proc_SALESPERSONUpdate"
				meta.spDelete = "proc_SALESPERSONDelete"
				meta.spLoadAll = "proc_SALESPERSONLoadAll"
				meta.spLoadByPrimaryKey = "proc_SALESPERSONLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As SalespersonMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
