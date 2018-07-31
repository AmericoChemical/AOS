'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/11/2014 1:36:08 PM
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
	MustInherit Public Class esViewInvItemTransactionsCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewInvItemTransactionsCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewInvItemTransactionsQuery)
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
            Me.InitQuery(CType(query, esViewInvItemTransactionsQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewInvItemTransactions) As ViewInvItemTransactions
			Return CType(MyBase.DetachEntity(entity), ViewInvItemTransactions)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewInvItemTransactions) As ViewInvItemTransactions
			Return CType(MyBase.AttachEntity(entity), ViewInvItemTransactions)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewInvItemTransactionsCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewInvItemTransactions
            Get
                Return TryCast(MyBase.Item(index), ViewInvItemTransactions)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewInvItemTransactions)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewInvItemTransactions	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewInvItemTransactionsQuery
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
												
						Case "Invitemnumber"
							Me.str.Invitemnumber = CType(value, string)
												
						Case "Txtime"
							Me.str.Txtime = CType(value, string)
												
						Case "Txwho"
							Me.str.Txwho = CType(value, string)
												
						Case "Txtype"
							Me.str.Txtype = CType(value, string)
												
						Case "Prodordernum"
							Me.str.Prodordernum = CType(value, string)
												
						Case "Unitsused"
							Me.str.Unitsused = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Invitemnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Invitemnumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Txtime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Txtime = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Prodordernum"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Prodordernum = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Unitsused"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Unitsused = CType(value, Nullable(Of System.Decimal))
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
		' Maps to viewInvItemTransactions.INVITEMNUMBER
		' </summary>
		Public Overridable Property Invitemnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewInvItemTransactionsMetadata.ColumnNames.Invitemnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewInvItemTransactionsMetadata.ColumnNames.Invitemnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemTransactions.TXTIME
		' </summary>
		Public Overridable Property Txtime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewInvItemTransactionsMetadata.ColumnNames.Txtime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewInvItemTransactionsMetadata.ColumnNames.Txtime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemTransactions.TXWHO
		' </summary>
		Public Overridable Property Txwho As System.String
			Get
				Return MyBase.GetSystemString(ViewInvItemTransactionsMetadata.ColumnNames.Txwho)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewInvItemTransactionsMetadata.ColumnNames.Txwho, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemTransactions.TXTYPE
		' </summary>
		Public Overridable Property Txtype As System.String
			Get
				Return MyBase.GetSystemString(ViewInvItemTransactionsMetadata.ColumnNames.Txtype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewInvItemTransactionsMetadata.ColumnNames.Txtype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemTransactions.PRODORDERNUM
		' </summary>
		Public Overridable Property Prodordernum As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewInvItemTransactionsMetadata.ColumnNames.Prodordernum)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewInvItemTransactionsMetadata.ColumnNames.Prodordernum, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemTransactions.UNITSUSED
		' </summary>
		Public Overridable Property Unitsused As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewInvItemTransactionsMetadata.ColumnNames.Unitsused)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewInvItemTransactionsMetadata.ColumnNames.Unitsused, value)
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
		
			Public Sub New(ByVal entity As esViewInvItemTransactions)
				Me.entity = entity
			End Sub				
		
	
			Public Property Invitemnumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Invitemnumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Invitemnumber = Nothing
					Else
						entity.Invitemnumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Txtime As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Txtime
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Txtime = Nothing
					Else
						entity.Txtime = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Txwho As System.String 
				Get
					Dim data_ As System.String = entity.Txwho
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Txwho = Nothing
					Else
						entity.Txwho = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Txtype As System.String 
				Get
					Dim data_ As System.String = entity.Txtype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Txtype = Nothing
					Else
						entity.Txtype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Prodordernum As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Prodordernum
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Prodordernum = Nothing
					Else
						entity.Prodordernum = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Unitsused As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Unitsused
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Unitsused = Nothing
					Else
						entity.Unitsused = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewInvItemTransactions
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewInvItemTransactionsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewInvItemTransactions can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewInvItemTransactionsQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewInvItemTransactionsMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Invitemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemTransactionsMetadata.ColumnNames.Invitemnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Txtime As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemTransactionsMetadata.ColumnNames.Txtime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Txwho As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemTransactionsMetadata.ColumnNames.Txwho, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Txtype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemTransactionsMetadata.ColumnNames.Txtype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Prodordernum As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemTransactionsMetadata.ColumnNames.Prodordernum, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Unitsused As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemTransactionsMetadata.ColumnNames.Unitsused, esSystemType.Decimal)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewInvItemTransactionsCollection")> _
	Partial Public Class ViewInvItemTransactionsCollection
		Inherits esViewInvItemTransactionsCollection
		Implements IEnumerable(Of ViewInvItemTransactions)
		
        Public Shared Widening Operator CType(ByVal coll As ViewInvItemTransactionsCollection) As List(Of ViewInvItemTransactions)
            Dim list As List(Of ViewInvItemTransactions) = New List(Of ViewInvItemTransactions)
            Dim emp As ViewInvItemTransactions

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewInvItemTransactionsMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewInvItemTransactionsQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewInvItemTransactions(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewInvItemTransactions()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewInvItemTransactionsQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewInvItemTransactionsQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewInvItemTransactionsQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewInvItemTransactions 
			Return CType(MyBase.AddNewEntity(), ViewInvItemTransactions)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewInvItemTransactions) Implements IEnumerable(Of ViewInvItemTransactions).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewInvItemTransactions)(Me)
        End Function
		
		Private _query As ViewInvItemTransactionsQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewInvItemTransactions' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewInvItemTransactions ()")> _
	<Serializable> _
	Partial Public Class ViewInvItemTransactions 
		Inherits esViewInvItemTransactions

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewInvItemTransactionsMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewInvItemTransactionsQuery

			If Me._query Is Nothing Then
				Me._query = New ViewInvItemTransactionsQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewInvItemTransactionsQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewInvItemTransactionsQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewInvItemTransactionsQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewInvItemTransactionsQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewInvItemTransactionsQuery
		inherits esViewInvItemTransactionsQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewInvItemTransactionsQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewInvItemTransactionsMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewInvItemTransactionsMetadata.ColumnNames.Invitemnumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewInvItemTransactionsMetadata.PropertyNames.Invitemnumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemTransactionsMetadata.ColumnNames.Txtime, 1, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewInvItemTransactionsMetadata.PropertyNames.Txtime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemTransactionsMetadata.ColumnNames.Txwho, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewInvItemTransactionsMetadata.PropertyNames.Txwho
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemTransactionsMetadata.ColumnNames.Txtype, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewInvItemTransactionsMetadata.PropertyNames.Txtype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemTransactionsMetadata.ColumnNames.Prodordernum, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewInvItemTransactionsMetadata.PropertyNames.Prodordernum
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemTransactionsMetadata.ColumnNames.Unitsused, 5, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewInvItemTransactionsMetadata.PropertyNames.Unitsused
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewInvItemTransactionsMetadata
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
			 Public Const Invitemnumber As String = "INVITEMNUMBER"
			 Public Const Txtime As String = "TXTIME"
			 Public Const Txwho As String = "TXWHO"
			 Public Const Txtype As String = "TXTYPE"
			 Public Const Prodordernum As String = "PRODORDERNUM"
			 Public Const Unitsused As String = "UNITSUSED"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Invitemnumber As String = "Invitemnumber"
			 Public Const Txtime As String = "Txtime"
			 Public Const Txwho As String = "Txwho"
			 Public Const Txtype As String = "Txtype"
			 Public Const Prodordernum As String = "Prodordernum"
			 Public Const Unitsused As String = "Unitsused"
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
            SyncLock GetType(ViewInvItemTransactionsMetadata)
			
				If ViewInvItemTransactionsMetadata.mapDelegates Is Nothing Then
					ViewInvItemTransactionsMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewInvItemTransactionsMetadata._meta Is Nothing Then
                    ViewInvItemTransactionsMetadata._meta = New ViewInvItemTransactionsMetadata()
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
				

				meta.AddTypeMap("Invitemnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Txtime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Txwho", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Txtype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Prodordernum", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Unitsused", new esTypeMap("decimal", "System.Decimal"))			
				
				
				 
				meta.Source = "viewInvItemTransactions"
				meta.Destination = "viewInvItemTransactions"
				
				meta.spInsert = "proc_viewInvItemTransactionsInsert"
				meta.spUpdate = "proc_viewInvItemTransactionsUpdate"
				meta.spDelete = "proc_viewInvItemTransactionsDelete"
				meta.spLoadAll = "proc_viewInvItemTransactionsLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewInvItemTransactionsLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewInvItemTransactionsMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
