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
	MustInherit Public Class esProdtimeCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ProdtimeCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esProdtimeQuery)
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
            Me.InitQuery(CType(query, esProdtimeQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Prodtime) As Prodtime
			Return CType(MyBase.DetachEntity(entity), Prodtime)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Prodtime) As Prodtime
			Return CType(MyBase.AttachEntity(entity), Prodtime)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ProdtimeCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Prodtime
            Get
                Return TryCast(MyBase.Item(index), Prodtime)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Prodtime)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esProdtime	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esProdtimeQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal recID As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(recID)
			Else
				Return LoadByPrimaryKeyStoredProcedure(recID)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal recID As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(recID)
			Else
				Return LoadByPrimaryKeyStoredProcedure(recID)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal recID As System.Int32) As Boolean
		
			Dim query As esProdtimeQuery = Me.GetDynamicQuery()
			query.Where(query.RecID.Equal(recID))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal recID As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("RecID", recID)
			
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
												
						Case "RecID"
							Me.str.RecID = CType(value, string)
												
						Case "ProdOrderNum"
							Me.str.ProdOrderNum = CType(value, string)
												
						Case "Who"
							Me.str.Who = CType(value, string)
												
						Case "Starttime"
							Me.str.Starttime = CType(value, string)
												
						Case "Endtime"
							Me.str.Endtime = CType(value, string)
												
						Case "LaborHrs"
							Me.str.LaborHrs = CType(value, string)
												
						Case "Completed"
							Me.str.Completed = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "RecID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.RecID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "ProdOrderNum"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ProdOrderNum = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Starttime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Starttime = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Endtime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Endtime = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "LaborHrs"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.LaborHrs = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Completed"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Completed = CType(value, Nullable(Of System.Boolean))
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
		' Maps to PRODTIME.RecID
		' </summary>
		Public Overridable Property RecID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ProdtimeMetadata.ColumnNames.RecID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ProdtimeMetadata.ColumnNames.RecID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODTIME.ProdOrderNum
		' </summary>
		Public Overridable Property ProdOrderNum As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ProdtimeMetadata.ColumnNames.ProdOrderNum)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ProdtimeMetadata.ColumnNames.ProdOrderNum, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODTIME.Who
		' </summary>
		Public Overridable Property Who As System.String
			Get
				Return MyBase.GetSystemString(ProdtimeMetadata.ColumnNames.Who)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ProdtimeMetadata.ColumnNames.Who, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODTIME.Starttime
		' </summary>
		Public Overridable Property Starttime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ProdtimeMetadata.ColumnNames.Starttime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ProdtimeMetadata.ColumnNames.Starttime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODTIME.Endtime
		' </summary>
		Public Overridable Property Endtime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ProdtimeMetadata.ColumnNames.Endtime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ProdtimeMetadata.ColumnNames.Endtime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODTIME.LaborHrs
		' </summary>
		Public Overridable Property LaborHrs As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ProdtimeMetadata.ColumnNames.LaborHrs)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ProdtimeMetadata.ColumnNames.LaborHrs, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODTIME.Completed
		' </summary>
		Public Overridable Property Completed As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ProdtimeMetadata.ColumnNames.Completed)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ProdtimeMetadata.ColumnNames.Completed, value)
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
		
			Public Sub New(ByVal entity As esProdtime)
				Me.entity = entity
			End Sub				
		
	
			Public Property RecID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.RecID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RecID = Nothing
					Else
						entity.RecID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property ProdOrderNum As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.ProdOrderNum
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ProdOrderNum = Nothing
					Else
						entity.ProdOrderNum = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Who As System.String 
				Get
					Dim data_ As System.String = entity.Who
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Who = Nothing
					Else
						entity.Who = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Starttime As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Starttime
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Starttime = Nothing
					Else
						entity.Starttime = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Endtime As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Endtime
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Endtime = Nothing
					Else
						entity.Endtime = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property LaborHrs As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.LaborHrs
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LaborHrs = Nothing
					Else
						entity.LaborHrs = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Completed As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Completed
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Completed = Nothing
					Else
						entity.Completed = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  

			Private entity As esProdtime
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esProdtimeQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esProdtime can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Prodtime 
		Inherits esProdtime
		
	
		
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
	MustInherit Public Class esProdtimeQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ProdtimeMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property RecID As esQueryItem
			Get
				Return New esQueryItem(Me, ProdtimeMetadata.ColumnNames.RecID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ProdOrderNum As esQueryItem
			Get
				Return New esQueryItem(Me, ProdtimeMetadata.ColumnNames.ProdOrderNum, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Who As esQueryItem
			Get
				Return New esQueryItem(Me, ProdtimeMetadata.ColumnNames.Who, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Starttime As esQueryItem
			Get
				Return New esQueryItem(Me, ProdtimeMetadata.ColumnNames.Starttime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Endtime As esQueryItem
			Get
				Return New esQueryItem(Me, ProdtimeMetadata.ColumnNames.Endtime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property LaborHrs As esQueryItem
			Get
				Return New esQueryItem(Me, ProdtimeMetadata.ColumnNames.LaborHrs, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Completed As esQueryItem
			Get
				Return New esQueryItem(Me, ProdtimeMetadata.ColumnNames.Completed, esSystemType.Boolean)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ProdtimeCollection")> _
	Partial Public Class ProdtimeCollection
		Inherits esProdtimeCollection
		Implements IEnumerable(Of Prodtime)
		
        Public Shared Widening Operator CType(ByVal coll As ProdtimeCollection) As List(Of Prodtime)
            Dim list As List(Of Prodtime) = New List(Of Prodtime)
            Dim emp As Prodtime

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ProdtimeMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ProdtimeQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Prodtime(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Prodtime()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As ProdtimeQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ProdtimeQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ProdtimeQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Prodtime 
			Return CType(MyBase.AddNewEntity(), Prodtime)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal recID As System.Int32) As Prodtime
			Return CType(MyBase.FindByPrimaryKey(recID), Prodtime)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Prodtime) Implements IEnumerable(Of Prodtime).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Prodtime)(Me)
        End Function
		
		Private _query As ProdtimeQuery

	End Class
	


	' <summary>
	' Encapsulates the 'PRODTIME' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Prodtime ({RecID.Value})")> _
	<Serializable> _
	Partial Public Class Prodtime 
		Inherits esProdtime

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ProdtimeMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esProdtimeQuery

			If Me._query Is Nothing Then
				Me._query = New ProdtimeQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ProdtimeQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ProdtimeQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ProdtimeQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ProdtimeQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ProdtimeQuery
		inherits esProdtimeQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ProdtimeQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ProdtimeMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ProdtimeMetadata.ColumnNames.RecID, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ProdtimeMetadata.PropertyNames.RecID
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ProdtimeMetadata.ColumnNames.ProdOrderNum, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ProdtimeMetadata.PropertyNames.ProdOrderNum
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ProdtimeMetadata.ColumnNames.Who, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ProdtimeMetadata.PropertyNames.Who
			c.CharacterMaxLength = 50
			_columns.Add(c)
				
			c = New esColumnMetadata(ProdtimeMetadata.ColumnNames.Starttime, 3, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ProdtimeMetadata.PropertyNames.Starttime
			_columns.Add(c)
				
			c = New esColumnMetadata(ProdtimeMetadata.ColumnNames.Endtime, 4, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ProdtimeMetadata.PropertyNames.Endtime
			_columns.Add(c)
				
			c = New esColumnMetadata(ProdtimeMetadata.ColumnNames.LaborHrs, 5, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ProdtimeMetadata.PropertyNames.LaborHrs
			c.NumericPrecision = 18
			c.NumericScale = 2
			_columns.Add(c)
				
			c = New esColumnMetadata(ProdtimeMetadata.ColumnNames.Completed, 6, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ProdtimeMetadata.PropertyNames.Completed
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ProdtimeMetadata
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
			 Public Const RecID As String = "RecID"
			 Public Const ProdOrderNum As String = "ProdOrderNum"
			 Public Const Who As String = "Who"
			 Public Const Starttime As String = "Starttime"
			 Public Const Endtime As String = "Endtime"
			 Public Const LaborHrs As String = "LaborHrs"
			 Public Const Completed As String = "Completed"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const RecID As String = "RecID"
			 Public Const ProdOrderNum As String = "ProdOrderNum"
			 Public Const Who As String = "Who"
			 Public Const Starttime As String = "Starttime"
			 Public Const Endtime As String = "Endtime"
			 Public Const LaborHrs As String = "LaborHrs"
			 Public Const Completed As String = "Completed"
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
            SyncLock GetType(ProdtimeMetadata)
			
				If ProdtimeMetadata.mapDelegates Is Nothing Then
					ProdtimeMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ProdtimeMetadata._meta Is Nothing Then
                    ProdtimeMetadata._meta = New ProdtimeMetadata()
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
				

				meta.AddTypeMap("RecID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ProdOrderNum", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Who", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Starttime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Endtime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("LaborHrs", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Completed", new esTypeMap("bit", "System.Boolean"))			
				
				
				 
				meta.Source = "PRODTIME"
				meta.Destination = "PRODTIME"
				
				meta.spInsert = "proc_PRODTIMEInsert"
				meta.spUpdate = "proc_PRODTIMEUpdate"
				meta.spDelete = "proc_PRODTIMEDelete"
				meta.spLoadAll = "proc_PRODTIMELoadAll"
				meta.spLoadByPrimaryKey = "proc_PRODTIMELoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ProdtimeMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
