'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/11/2014 1:43:56 PM
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
	MustInherit Public Class esInvtxCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "InvtxCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esInvtxQuery)
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
            Me.InitQuery(CType(query, esInvtxQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Invtx) As Invtx
			Return CType(MyBase.DetachEntity(entity), Invtx)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Invtx) As Invtx
			Return CType(MyBase.AttachEntity(entity), Invtx)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As InvtxCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Invtx
            Get
                Return TryCast(MyBase.Item(index), Invtx)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Invtx)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esInvtx	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esInvtxQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal txid As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(txid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(txid)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal txid As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(txid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(txid)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal txid As System.Int32) As Boolean
		
			Dim query As esInvtxQuery = Me.GetDynamicQuery()
			query.Where(query.Txid.Equal(txid))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal txid As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("TXID", txid)
			
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
												
						Case "Txid"
							Me.str.Txid = CType(value, string)
												
						Case "Txtime"
							Me.str.Txtime = CType(value, string)
												
						Case "Txwho"
							Me.str.Txwho = CType(value, string)
												
						Case "Txtype"
							Me.str.Txtype = CType(value, string)
												
						Case "Txdocid"
							Me.str.Txdocid = CType(value, string)
												
						Case "Invitemnumber"
							Me.str.Invitemnumber = CType(value, string)
												
						Case "Unitsused"
							Me.str.Unitsused = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Txid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Txid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Txtime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Txtime = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Txdocid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Txdocid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Invitemnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Invitemnumber = CType(value, Nullable(Of System.Int32))
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
		' Maps to INVTX.TXID
		' </summary>
		Public Overridable Property Txid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(InvtxMetadata.ColumnNames.Txid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(InvtxMetadata.ColumnNames.Txid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVTX.TXTIME
		' </summary>
		Public Overridable Property Txtime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(InvtxMetadata.ColumnNames.Txtime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(InvtxMetadata.ColumnNames.Txtime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVTX.TXWHO
		' </summary>
		Public Overridable Property Txwho As System.String
			Get
				Return MyBase.GetSystemString(InvtxMetadata.ColumnNames.Txwho)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(InvtxMetadata.ColumnNames.Txwho, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVTX.TXTYPE
		' </summary>
		Public Overridable Property Txtype As System.String
			Get
				Return MyBase.GetSystemString(InvtxMetadata.ColumnNames.Txtype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(InvtxMetadata.ColumnNames.Txtype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVTX.TXDOCID
		' </summary>
		Public Overridable Property Txdocid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(InvtxMetadata.ColumnNames.Txdocid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(InvtxMetadata.ColumnNames.Txdocid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVTX.INVITEMNUMBER
		' </summary>
		Public Overridable Property Invitemnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(InvtxMetadata.ColumnNames.Invitemnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(InvtxMetadata.ColumnNames.Invitemnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVTX.UNITSUSED
		' </summary>
		Public Overridable Property Unitsused As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(InvtxMetadata.ColumnNames.Unitsused)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(InvtxMetadata.ColumnNames.Unitsused, value)
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
		
			Public Sub New(ByVal entity As esInvtx)
				Me.entity = entity
			End Sub				
		
	
			Public Property Txid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Txid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Txid = Nothing
					Else
						entity.Txid = Convert.ToInt32(Value)
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
		  	
			Public Property Txdocid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Txdocid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Txdocid = Nothing
					Else
						entity.Txdocid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
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
		  

			Private entity As esInvtx
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esInvtxQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esInvtx can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Invtx 
		Inherits esInvtx
		
	
		
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
	MustInherit Public Class esInvtxQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return InvtxMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Txid As esQueryItem
			Get
				Return New esQueryItem(Me, InvtxMetadata.ColumnNames.Txid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Txtime As esQueryItem
			Get
				Return New esQueryItem(Me, InvtxMetadata.ColumnNames.Txtime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Txwho As esQueryItem
			Get
				Return New esQueryItem(Me, InvtxMetadata.ColumnNames.Txwho, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Txtype As esQueryItem
			Get
				Return New esQueryItem(Me, InvtxMetadata.ColumnNames.Txtype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Txdocid As esQueryItem
			Get
				Return New esQueryItem(Me, InvtxMetadata.ColumnNames.Txdocid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Invitemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, InvtxMetadata.ColumnNames.Invitemnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Unitsused As esQueryItem
			Get
				Return New esQueryItem(Me, InvtxMetadata.ColumnNames.Unitsused, esSystemType.Decimal)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("InvtxCollection")> _
	Partial Public Class InvtxCollection
		Inherits esInvtxCollection
		Implements IEnumerable(Of Invtx)
		
        Public Shared Widening Operator CType(ByVal coll As InvtxCollection) As List(Of Invtx)
            Dim list As List(Of Invtx) = New List(Of Invtx)
            Dim emp As Invtx

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return InvtxMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New InvtxQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Invtx(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Invtx()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As InvtxQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New InvtxQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As InvtxQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Invtx 
			Return CType(MyBase.AddNewEntity(), Invtx)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal txid As System.Int32) As Invtx
			Return CType(MyBase.FindByPrimaryKey(txid), Invtx)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Invtx) Implements IEnumerable(Of Invtx).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Invtx)(Me)
        End Function
		
		Private _query As InvtxQuery

	End Class
	


	' <summary>
	' Encapsulates the 'INVTX' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Invtx ({Txid.Value})")> _
	<Serializable> _
	Partial Public Class Invtx 
		Inherits esInvtx

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return InvtxMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esInvtxQuery

			If Me._query Is Nothing Then
				Me._query = New InvtxQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As InvtxQuery
			Get

				If Me._query Is Nothing then
					Me._query = New InvtxQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As InvtxQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As InvtxQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class InvtxQuery
		inherits esInvtxQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "InvtxQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class InvtxMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(InvtxMetadata.ColumnNames.Txid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = InvtxMetadata.PropertyNames.Txid
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(InvtxMetadata.ColumnNames.Txtime, 1, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = InvtxMetadata.PropertyNames.Txtime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvtxMetadata.ColumnNames.Txwho, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = InvtxMetadata.PropertyNames.Txwho
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvtxMetadata.ColumnNames.Txtype, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = InvtxMetadata.PropertyNames.Txtype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvtxMetadata.ColumnNames.Txdocid, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = InvtxMetadata.PropertyNames.Txdocid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvtxMetadata.ColumnNames.Invitemnumber, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = InvtxMetadata.PropertyNames.Invitemnumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvtxMetadata.ColumnNames.Unitsused, 6, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = InvtxMetadata.PropertyNames.Unitsused
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As InvtxMetadata
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
			 Public Const Txid As String = "TXID"
			 Public Const Txtime As String = "TXTIME"
			 Public Const Txwho As String = "TXWHO"
			 Public Const Txtype As String = "TXTYPE"
			 Public Const Txdocid As String = "TXDOCID"
			 Public Const Invitemnumber As String = "INVITEMNUMBER"
			 Public Const Unitsused As String = "UNITSUSED"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Txid As String = "Txid"
			 Public Const Txtime As String = "Txtime"
			 Public Const Txwho As String = "Txwho"
			 Public Const Txtype As String = "Txtype"
			 Public Const Txdocid As String = "Txdocid"
			 Public Const Invitemnumber As String = "Invitemnumber"
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
            SyncLock GetType(InvtxMetadata)
			
				If InvtxMetadata.mapDelegates Is Nothing Then
					InvtxMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If InvtxMetadata._meta Is Nothing Then
                    InvtxMetadata._meta = New InvtxMetadata()
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
				

				meta.AddTypeMap("Txid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Txtime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Txwho", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Txtype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Txdocid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Invitemnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Unitsused", new esTypeMap("decimal", "System.Decimal"))			
				
				
				 
				meta.Source = "INVTX"
				meta.Destination = "INVTX"
				
				meta.spInsert = "proc_INVTXInsert"
				meta.spUpdate = "proc_INVTXUpdate"
				meta.spDelete = "proc_INVTXDelete"
				meta.spLoadAll = "proc_INVTXLoadAll"
				meta.spLoadByPrimaryKey = "proc_INVTXLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As InvtxMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
