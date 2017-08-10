'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/12/2014 12:42:13 PM
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
	MustInherit Public Class esViewRptInvoiceHistoryCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewRptInvoiceHistoryCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewRptInvoiceHistoryQuery)
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
            Me.InitQuery(CType(query, esViewRptInvoiceHistoryQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewRptInvoiceHistory) As ViewRptInvoiceHistory
			Return CType(MyBase.DetachEntity(entity), ViewRptInvoiceHistory)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewRptInvoiceHistory) As ViewRptInvoiceHistory
			Return CType(MyBase.AttachEntity(entity), ViewRptInvoiceHistory)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewRptInvoiceHistoryCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewRptInvoiceHistory
            Get
                Return TryCast(MyBase.Item(index), ViewRptInvoiceHistory)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewRptInvoiceHistory)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewRptInvoiceHistory	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewRptInvoiceHistoryQuery
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
												
						Case "Invoicenumber"
							Me.str.Invoicenumber = CType(value, string)
												
						Case "Invoicedate"
							Me.str.Invoicedate = CType(value, string)
												
						Case "Subtotal"
							Me.str.Subtotal = CType(value, string)
												
						Case "Salestax"
							Me.str.Salestax = CType(value, string)
												
						Case "Total"
							Me.str.Total = CType(value, string)
												
						Case "Custname"
							Me.str.Custname = CType(value, string)
												
						Case "Customerpo"
							Me.str.Customerpo = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Invoicenumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Invoicenumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Invoicedate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Invoicedate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Subtotal"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Subtotal = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Salestax"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Salestax = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Total"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Total = CType(value, Nullable(Of System.Decimal))
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
		' Maps to viewRptInvoiceHistory.INVOICENUMBER
		' </summary>
		Public Overridable Property Invoicenumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptInvoiceHistoryMetadata.ColumnNames.Invoicenumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptInvoiceHistoryMetadata.ColumnNames.Invoicenumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInvoiceHistory.INVOICEDATE
		' </summary>
		Public Overridable Property Invoicedate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewRptInvoiceHistoryMetadata.ColumnNames.Invoicedate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewRptInvoiceHistoryMetadata.ColumnNames.Invoicedate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInvoiceHistory.SUBTOTAL
		' </summary>
		Public Overridable Property Subtotal As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptInvoiceHistoryMetadata.ColumnNames.Subtotal)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptInvoiceHistoryMetadata.ColumnNames.Subtotal, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInvoiceHistory.SALESTAX
		' </summary>
		Public Overridable Property Salestax As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptInvoiceHistoryMetadata.ColumnNames.Salestax)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptInvoiceHistoryMetadata.ColumnNames.Salestax, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInvoiceHistory.TOTAL
		' </summary>
		Public Overridable Property Total As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptInvoiceHistoryMetadata.ColumnNames.Total)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptInvoiceHistoryMetadata.ColumnNames.Total, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInvoiceHistory.CUSTNAME
		' </summary>
		Public Overridable Property Custname As System.String
			Get
				Return MyBase.GetSystemString(ViewRptInvoiceHistoryMetadata.ColumnNames.Custname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptInvoiceHistoryMetadata.ColumnNames.Custname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInvoiceHistory.CUSTOMERPO
		' </summary>
		Public Overridable Property Customerpo As System.String
			Get
				Return MyBase.GetSystemString(ViewRptInvoiceHistoryMetadata.ColumnNames.Customerpo)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptInvoiceHistoryMetadata.ColumnNames.Customerpo, value)
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
		
			Public Sub New(ByVal entity As esViewRptInvoiceHistory)
				Me.entity = entity
			End Sub				
		
	
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
		  	
			Public Property Invoicedate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Invoicedate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Invoicedate = Nothing
					Else
						entity.Invoicedate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Subtotal As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Subtotal
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Subtotal = Nothing
					Else
						entity.Subtotal = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Salestax As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Salestax
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Salestax = Nothing
					Else
						entity.Salestax = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Total As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Total
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Total = Nothing
					Else
						entity.Total = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Custname As System.String 
				Get
					Dim data_ As System.String = entity.Custname
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Custname = Nothing
					Else
						entity.Custname = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Customerpo As System.String 
				Get
					Dim data_ As System.String = entity.Customerpo
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Customerpo = Nothing
					Else
						entity.Customerpo = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewRptInvoiceHistory
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewRptInvoiceHistoryQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewRptInvoiceHistory can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewRptInvoiceHistoryQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRptInvoiceHistoryMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Invoicenumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoiceHistoryMetadata.ColumnNames.Invoicenumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Invoicedate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoiceHistoryMetadata.ColumnNames.Invoicedate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Subtotal As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoiceHistoryMetadata.ColumnNames.Subtotal, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Salestax As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoiceHistoryMetadata.ColumnNames.Salestax, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Total As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoiceHistoryMetadata.ColumnNames.Total, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Custname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoiceHistoryMetadata.ColumnNames.Custname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Customerpo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInvoiceHistoryMetadata.ColumnNames.Customerpo, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewRptInvoiceHistoryCollection")> _
	Partial Public Class ViewRptInvoiceHistoryCollection
		Inherits esViewRptInvoiceHistoryCollection
		Implements IEnumerable(Of ViewRptInvoiceHistory)
		
        Public Shared Widening Operator CType(ByVal coll As ViewRptInvoiceHistoryCollection) As List(Of ViewRptInvoiceHistory)
            Dim list As List(Of ViewRptInvoiceHistory) = New List(Of ViewRptInvoiceHistory)
            Dim emp As ViewRptInvoiceHistory

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRptInvoiceHistoryMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewRptInvoiceHistoryQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewRptInvoiceHistory(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewRptInvoiceHistory()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewRptInvoiceHistoryQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewRptInvoiceHistoryQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRptInvoiceHistoryQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewRptInvoiceHistory 
			Return CType(MyBase.AddNewEntity(), ViewRptInvoiceHistory)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewRptInvoiceHistory) Implements IEnumerable(Of ViewRptInvoiceHistory).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewRptInvoiceHistory)(Me)
        End Function
		
		Private _query As ViewRptInvoiceHistoryQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewRptInvoiceHistory' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewRptInvoiceHistory ()")> _
	<Serializable> _
	Partial Public Class ViewRptInvoiceHistory 
		Inherits esViewRptInvoiceHistory

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewRptInvoiceHistoryMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewRptInvoiceHistoryQuery

			If Me._query Is Nothing Then
				Me._query = New ViewRptInvoiceHistoryQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewRptInvoiceHistoryQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewRptInvoiceHistoryQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRptInvoiceHistoryQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewRptInvoiceHistoryQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewRptInvoiceHistoryQuery
		inherits esViewRptInvoiceHistoryQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewRptInvoiceHistoryQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewRptInvoiceHistoryMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewRptInvoiceHistoryMetadata.ColumnNames.Invoicenumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptInvoiceHistoryMetadata.PropertyNames.Invoicenumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInvoiceHistoryMetadata.ColumnNames.Invoicedate, 1, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewRptInvoiceHistoryMetadata.PropertyNames.Invoicedate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInvoiceHistoryMetadata.ColumnNames.Subtotal, 2, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptInvoiceHistoryMetadata.PropertyNames.Subtotal
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInvoiceHistoryMetadata.ColumnNames.Salestax, 3, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptInvoiceHistoryMetadata.PropertyNames.Salestax
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInvoiceHistoryMetadata.ColumnNames.Total, 4, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptInvoiceHistoryMetadata.PropertyNames.Total
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInvoiceHistoryMetadata.ColumnNames.Custname, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptInvoiceHistoryMetadata.PropertyNames.Custname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInvoiceHistoryMetadata.ColumnNames.Customerpo, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptInvoiceHistoryMetadata.PropertyNames.Customerpo
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewRptInvoiceHistoryMetadata
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
			 Public Const Invoicenumber As String = "INVOICENUMBER"
			 Public Const Invoicedate As String = "INVOICEDATE"
			 Public Const Subtotal As String = "SUBTOTAL"
			 Public Const Salestax As String = "SALESTAX"
			 Public Const Total As String = "TOTAL"
			 Public Const Custname As String = "CUSTNAME"
			 Public Const Customerpo As String = "CUSTOMERPO"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Invoicenumber As String = "Invoicenumber"
			 Public Const Invoicedate As String = "Invoicedate"
			 Public Const Subtotal As String = "Subtotal"
			 Public Const Salestax As String = "Salestax"
			 Public Const Total As String = "Total"
			 Public Const Custname As String = "Custname"
			 Public Const Customerpo As String = "Customerpo"
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
            SyncLock GetType(ViewRptInvoiceHistoryMetadata)
			
				If ViewRptInvoiceHistoryMetadata.mapDelegates Is Nothing Then
					ViewRptInvoiceHistoryMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewRptInvoiceHistoryMetadata._meta Is Nothing Then
                    ViewRptInvoiceHistoryMetadata._meta = New ViewRptInvoiceHistoryMetadata()
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
				

				meta.AddTypeMap("Invoicenumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Invoicedate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Subtotal", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Salestax", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Total", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Custname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Customerpo", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewRptInvoiceHistory"
				meta.Destination = "viewRptInvoiceHistory"
				
				meta.spInsert = "proc_viewRptInvoiceHistoryInsert"
				meta.spUpdate = "proc_viewRptInvoiceHistoryUpdate"
				meta.spDelete = "proc_viewRptInvoiceHistoryDelete"
				meta.spLoadAll = "proc_viewRptInvoiceHistoryLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewRptInvoiceHistoryLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewRptInvoiceHistoryMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
