'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 10/31/2017 9:17:15 AM
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
	MustInherit Public Class esInvoicehistoryheaderCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "InvoicehistoryheaderCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esInvoicehistoryheaderQuery)
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
            Me.InitQuery(CType(query, esInvoicehistoryheaderQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Invoicehistoryheader) As Invoicehistoryheader
			Return CType(MyBase.DetachEntity(entity), Invoicehistoryheader)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Invoicehistoryheader) As Invoicehistoryheader
			Return CType(MyBase.AttachEntity(entity), Invoicehistoryheader)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As InvoicehistoryheaderCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Invoicehistoryheader
            Get
                Return TryCast(MyBase.Item(index), Invoicehistoryheader)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Invoicehistoryheader)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esInvoicehistoryheader	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esInvoicehistoryheaderQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal invoicehistoryid As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(invoicehistoryid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(invoicehistoryid)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal invoicehistoryid As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(invoicehistoryid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(invoicehistoryid)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal invoicehistoryid As System.Int32) As Boolean
		
			Dim query As esInvoicehistoryheaderQuery = Me.GetDynamicQuery()
			query.Where(query.Invoicehistoryid.Equal(invoicehistoryid))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal invoicehistoryid As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("INVOICEHISTORYID", invoicehistoryid)
			
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
												
						Case "Invoicehistoryid"
							Me.str.Invoicehistoryid = CType(value, string)
												
						Case "Invoicenumber"
							Me.str.Invoicenumber = CType(value, string)
												
						Case "Changetype"
							Me.str.Changetype = CType(value, string)
												
						Case "Changereason"
							Me.str.Changereason = CType(value, string)
												
						Case "Changeddate"
							Me.str.Changeddate = CType(value, string)
												
						Case "Changedby"
							Me.str.Changedby = CType(value, string)
												
						Case "Changecommitted"
							Me.str.Changecommitted = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Invoicehistoryid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Invoicehistoryid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Invoicenumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Invoicenumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Changeddate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Changeddate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Changecommitted"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Changecommitted = CType(value, Nullable(Of System.Boolean))
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
		' Maps to INVOICEHISTORYHEADER.INVOICEHISTORYID
		' </summary>
		Public Overridable Property Invoicehistoryid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(InvoicehistoryheaderMetadata.ColumnNames.Invoicehistoryid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(InvoicehistoryheaderMetadata.ColumnNames.Invoicehistoryid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORYHEADER.INVOICENUMBER
		' </summary>
		Public Overridable Property Invoicenumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(InvoicehistoryheaderMetadata.ColumnNames.Invoicenumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(InvoicehistoryheaderMetadata.ColumnNames.Invoicenumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORYHEADER.CHANGETYPE
		' </summary>
		Public Overridable Property Changetype As System.String
			Get
				Return MyBase.GetSystemString(InvoicehistoryheaderMetadata.ColumnNames.Changetype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(InvoicehistoryheaderMetadata.ColumnNames.Changetype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORYHEADER.CHANGEREASON
		' </summary>
		Public Overridable Property Changereason As System.String
			Get
				Return MyBase.GetSystemString(InvoicehistoryheaderMetadata.ColumnNames.Changereason)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(InvoicehistoryheaderMetadata.ColumnNames.Changereason, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORYHEADER.CHANGEDDATE
		' </summary>
		Public Overridable Property Changeddate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(InvoicehistoryheaderMetadata.ColumnNames.Changeddate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(InvoicehistoryheaderMetadata.ColumnNames.Changeddate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORYHEADER.CHANGEDBY
		' </summary>
		Public Overridable Property Changedby As System.String
			Get
				Return MyBase.GetSystemString(InvoicehistoryheaderMetadata.ColumnNames.Changedby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(InvoicehistoryheaderMetadata.ColumnNames.Changedby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVOICEHISTORYHEADER.CHANGECOMMITTED
		' </summary>
		Public Overridable Property Changecommitted As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(InvoicehistoryheaderMetadata.ColumnNames.Changecommitted)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(InvoicehistoryheaderMetadata.ColumnNames.Changecommitted, value)
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
		
			Public Sub New(ByVal entity As esInvoicehistoryheader)
				Me.entity = entity
			End Sub				
		
	
			Public Property Invoicehistoryid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Invoicehistoryid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Invoicehistoryid = Nothing
					Else
						entity.Invoicehistoryid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Invoicenumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Invoicenumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Invoicenumber = Nothing
					Else
						entity.Invoicenumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Changetype As System.String 
				Get
					Dim data_ As System.String = entity.Changetype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Changetype = Nothing
					Else
						entity.Changetype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Changereason As System.String 
				Get
					Dim data_ As System.String = entity.Changereason
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Changereason = Nothing
					Else
						entity.Changereason = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Changeddate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Changeddate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Changeddate = Nothing
					Else
						entity.Changeddate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Changedby As System.String 
				Get
					Dim data_ As System.String = entity.Changedby
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Changedby = Nothing
					Else
						entity.Changedby = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Changecommitted As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Changecommitted
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Changecommitted = Nothing
					Else
						entity.Changecommitted = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  

			Private entity As esInvoicehistoryheader
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esInvoicehistoryheaderQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esInvoicehistoryheader can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Invoicehistoryheader 
		Inherits esInvoicehistoryheader
		
	
		
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
	MustInherit Public Class esInvoicehistoryheaderQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return InvoicehistoryheaderMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Invoicehistoryid As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryheaderMetadata.ColumnNames.Invoicehistoryid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Invoicenumber As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryheaderMetadata.ColumnNames.Invoicenumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Changetype As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryheaderMetadata.ColumnNames.Changetype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Changereason As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryheaderMetadata.ColumnNames.Changereason, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Changeddate As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryheaderMetadata.ColumnNames.Changeddate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Changedby As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryheaderMetadata.ColumnNames.Changedby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Changecommitted As esQueryItem
			Get
				Return New esQueryItem(Me, InvoicehistoryheaderMetadata.ColumnNames.Changecommitted, esSystemType.Boolean)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("InvoicehistoryheaderCollection")> _
	Partial Public Class InvoicehistoryheaderCollection
		Inherits esInvoicehistoryheaderCollection
		Implements IEnumerable(Of Invoicehistoryheader)
		
        Public Shared Widening Operator CType(ByVal coll As InvoicehistoryheaderCollection) As List(Of Invoicehistoryheader)
            Dim list As List(Of Invoicehistoryheader) = New List(Of Invoicehistoryheader)
            Dim emp As Invoicehistoryheader

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return InvoicehistoryheaderMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New InvoicehistoryheaderQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Invoicehistoryheader(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Invoicehistoryheader()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As InvoicehistoryheaderQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New InvoicehistoryheaderQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As InvoicehistoryheaderQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Invoicehistoryheader 
			Return CType(MyBase.AddNewEntity(), Invoicehistoryheader)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal invoicehistoryid As System.Int32) As Invoicehistoryheader
			Return CType(MyBase.FindByPrimaryKey(invoicehistoryid), Invoicehistoryheader)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Invoicehistoryheader) Implements IEnumerable(Of Invoicehistoryheader).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Invoicehistoryheader)(Me)
        End Function
		
		Private _query As InvoicehistoryheaderQuery

	End Class
	


	' <summary>
	' Encapsulates the 'INVOICEHISTORYHEADER' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Invoicehistoryheader ({Invoicehistoryid.Value})")> _
	<Serializable> _
	Partial Public Class Invoicehistoryheader 
		Inherits esInvoicehistoryheader

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return InvoicehistoryheaderMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esInvoicehistoryheaderQuery

			If Me._query Is Nothing Then
				Me._query = New InvoicehistoryheaderQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As InvoicehistoryheaderQuery
			Get

				If Me._query Is Nothing then
					Me._query = New InvoicehistoryheaderQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As InvoicehistoryheaderQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As InvoicehistoryheaderQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class InvoicehistoryheaderQuery
		inherits esInvoicehistoryheaderQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "InvoicehistoryheaderQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class InvoicehistoryheaderMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(InvoicehistoryheaderMetadata.ColumnNames.Invoicehistoryid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = InvoicehistoryheaderMetadata.PropertyNames.Invoicehistoryid
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryheaderMetadata.ColumnNames.Invoicenumber, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = InvoicehistoryheaderMetadata.PropertyNames.Invoicenumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryheaderMetadata.ColumnNames.Changetype, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = InvoicehistoryheaderMetadata.PropertyNames.Changetype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryheaderMetadata.ColumnNames.Changereason, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = InvoicehistoryheaderMetadata.PropertyNames.Changereason
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryheaderMetadata.ColumnNames.Changeddate, 4, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = InvoicehistoryheaderMetadata.PropertyNames.Changeddate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryheaderMetadata.ColumnNames.Changedby, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = InvoicehistoryheaderMetadata.PropertyNames.Changedby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvoicehistoryheaderMetadata.ColumnNames.Changecommitted, 6, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = InvoicehistoryheaderMetadata.PropertyNames.Changecommitted
			c.HasDefault = True
			c.Default = "((0))"
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As InvoicehistoryheaderMetadata
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
			 Public Const Invoicehistoryid As String = "INVOICEHISTORYID"
			 Public Const Invoicenumber As String = "INVOICENUMBER"
			 Public Const Changetype As String = "CHANGETYPE"
			 Public Const Changereason As String = "CHANGEREASON"
			 Public Const Changeddate As String = "CHANGEDDATE"
			 Public Const Changedby As String = "CHANGEDBY"
			 Public Const Changecommitted As String = "CHANGECOMMITTED"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Invoicehistoryid As String = "Invoicehistoryid"
			 Public Const Invoicenumber As String = "Invoicenumber"
			 Public Const Changetype As String = "Changetype"
			 Public Const Changereason As String = "Changereason"
			 Public Const Changeddate As String = "Changeddate"
			 Public Const Changedby As String = "Changedby"
			 Public Const Changecommitted As String = "Changecommitted"
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
            SyncLock GetType(InvoicehistoryheaderMetadata)
			
				If InvoicehistoryheaderMetadata.mapDelegates Is Nothing Then
					InvoicehistoryheaderMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If InvoicehistoryheaderMetadata._meta Is Nothing Then
                    InvoicehistoryheaderMetadata._meta = New InvoicehistoryheaderMetadata()
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
				

				meta.AddTypeMap("Invoicehistoryid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Invoicenumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Changetype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Changereason", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Changeddate", new esTypeMap("smalldatetime", "System.DateTime"))
				meta.AddTypeMap("Changedby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Changecommitted", new esTypeMap("bit", "System.Boolean"))			
				
				
				 
				meta.Source = "INVOICEHISTORYHEADER"
				meta.Destination = "INVOICEHISTORYHEADER"
				
				meta.spInsert = "proc_INVOICEHISTORYHEADERInsert"
				meta.spUpdate = "proc_INVOICEHISTORYHEADERUpdate"
				meta.spDelete = "proc_INVOICEHISTORYHEADERDelete"
				meta.spLoadAll = "proc_INVOICEHISTORYHEADERLoadAll"
				meta.spLoadByPrimaryKey = "proc_INVOICEHISTORYHEADERLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As InvoicehistoryheaderMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
