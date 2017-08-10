'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/24/2015 9:26:40 AM
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
	MustInherit Public Class esRptSalesinvoicedataCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "RptSalesinvoicedataCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esRptSalesinvoicedataQuery)
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
            Me.InitQuery(CType(query, esRptSalesinvoicedataQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As RptSalesinvoicedata) As RptSalesinvoicedata
			Return CType(MyBase.DetachEntity(entity), RptSalesinvoicedata)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As RptSalesinvoicedata) As RptSalesinvoicedata
			Return CType(MyBase.AttachEntity(entity), RptSalesinvoicedata)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As RptSalesinvoicedataCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As RptSalesinvoicedata
            Get
                Return TryCast(MyBase.Item(index), RptSalesinvoicedata)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(RptSalesinvoicedata)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esRptSalesinvoicedata	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esRptSalesinvoicedataQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal invoiceNumber As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(invoiceNumber)
			Else
				Return LoadByPrimaryKeyStoredProcedure(invoiceNumber)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal invoiceNumber As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(invoiceNumber)
			Else
				Return LoadByPrimaryKeyStoredProcedure(invoiceNumber)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal invoiceNumber As System.Int32) As Boolean
		
			Dim query As esRptSalesinvoicedataQuery = Me.GetDynamicQuery()
			query.Where(query.InvoiceNumber.Equal(invoiceNumber))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal invoiceNumber As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("InvoiceNumber", invoiceNumber)
			
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
												
						Case "InvoiceNumber"
							Me.str.InvoiceNumber = CType(value, string)
												
						Case "InvoiceDate"
							Me.str.InvoiceDate = CType(value, string)
												
						Case "CustID"
							Me.str.CustID = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "InvoiceNumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.InvoiceNumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "InvoiceDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.InvoiceDate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "CustID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.CustID = CType(value, Nullable(Of System.Int32))
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
		' Maps to RPT_SALESINVOICEDATA.InvoiceNumber
		' </summary>
		Public Overridable Property InvoiceNumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(RptSalesinvoicedataMetadata.ColumnNames.InvoiceNumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(RptSalesinvoicedataMetadata.ColumnNames.InvoiceNumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RPT_SALESINVOICEDATA.InvoiceDate
		' </summary>
		Public Overridable Property InvoiceDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(RptSalesinvoicedataMetadata.ColumnNames.InvoiceDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(RptSalesinvoicedataMetadata.ColumnNames.InvoiceDate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RPT_SALESINVOICEDATA.CustID
		' </summary>
		Public Overridable Property CustID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(RptSalesinvoicedataMetadata.ColumnNames.CustID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(RptSalesinvoicedataMetadata.ColumnNames.CustID, value)
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
		
			Public Sub New(ByVal entity As esRptSalesinvoicedata)
				Me.entity = entity
			End Sub				
		
	
			Public Property InvoiceNumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.InvoiceNumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.InvoiceNumber = Nothing
					Else
						entity.InvoiceNumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property InvoiceDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.InvoiceDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.InvoiceDate = Nothing
					Else
						entity.InvoiceDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property CustID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.CustID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CustID = Nothing
					Else
						entity.CustID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esRptSalesinvoicedata
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esRptSalesinvoicedataQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esRptSalesinvoicedata can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class RptSalesinvoicedata 
		Inherits esRptSalesinvoicedata
		
	
		
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
	MustInherit Public Class esRptSalesinvoicedataQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return RptSalesinvoicedataMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property InvoiceNumber As esQueryItem
			Get
				Return New esQueryItem(Me, RptSalesinvoicedataMetadata.ColumnNames.InvoiceNumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property InvoiceDate As esQueryItem
			Get
				Return New esQueryItem(Me, RptSalesinvoicedataMetadata.ColumnNames.InvoiceDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property CustID As esQueryItem
			Get
				Return New esQueryItem(Me, RptSalesinvoicedataMetadata.ColumnNames.CustID, esSystemType.Int32)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("RptSalesinvoicedataCollection")> _
	Partial Public Class RptSalesinvoicedataCollection
		Inherits esRptSalesinvoicedataCollection
		Implements IEnumerable(Of RptSalesinvoicedata)
		
        Public Shared Widening Operator CType(ByVal coll As RptSalesinvoicedataCollection) As List(Of RptSalesinvoicedata)
            Dim list As List(Of RptSalesinvoicedata) = New List(Of RptSalesinvoicedata)
            Dim emp As RptSalesinvoicedata

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return RptSalesinvoicedataMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New RptSalesinvoicedataQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New RptSalesinvoicedata(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New RptSalesinvoicedata()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As RptSalesinvoicedataQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New RptSalesinvoicedataQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As RptSalesinvoicedataQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As RptSalesinvoicedata 
			Return CType(MyBase.AddNewEntity(), RptSalesinvoicedata)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal invoiceNumber As System.Int32) As RptSalesinvoicedata
			Return CType(MyBase.FindByPrimaryKey(invoiceNumber), RptSalesinvoicedata)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of RptSalesinvoicedata) Implements IEnumerable(Of RptSalesinvoicedata).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of RptSalesinvoicedata)(Me)
        End Function
		
		Private _query As RptSalesinvoicedataQuery

	End Class
	


	' <summary>
	' Encapsulates the 'RPT_SALESINVOICEDATA' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("RptSalesinvoicedata ({InvoiceNumber.Value})")> _
	<Serializable> _
	Partial Public Class RptSalesinvoicedata 
		Inherits esRptSalesinvoicedata

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return RptSalesinvoicedataMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esRptSalesinvoicedataQuery

			If Me._query Is Nothing Then
				Me._query = New RptSalesinvoicedataQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As RptSalesinvoicedataQuery
			Get

				If Me._query Is Nothing then
					Me._query = New RptSalesinvoicedataQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As RptSalesinvoicedataQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As RptSalesinvoicedataQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class RptSalesinvoicedataQuery
		inherits esRptSalesinvoicedataQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "RptSalesinvoicedataQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class RptSalesinvoicedataMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(RptSalesinvoicedataMetadata.ColumnNames.InvoiceNumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = RptSalesinvoicedataMetadata.PropertyNames.InvoiceNumber
			c.IsInPrimaryKey = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(RptSalesinvoicedataMetadata.ColumnNames.InvoiceDate, 1, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = RptSalesinvoicedataMetadata.PropertyNames.InvoiceDate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(RptSalesinvoicedataMetadata.ColumnNames.CustID, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = RptSalesinvoicedataMetadata.PropertyNames.CustID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As RptSalesinvoicedataMetadata
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
			 Public Const InvoiceNumber As String = "InvoiceNumber"
			 Public Const InvoiceDate As String = "InvoiceDate"
			 Public Const CustID As String = "CustID"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const InvoiceNumber As String = "InvoiceNumber"
			 Public Const InvoiceDate As String = "InvoiceDate"
			 Public Const CustID As String = "CustID"
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
            SyncLock GetType(RptSalesinvoicedataMetadata)
			
				If RptSalesinvoicedataMetadata.mapDelegates Is Nothing Then
					RptSalesinvoicedataMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If RptSalesinvoicedataMetadata._meta Is Nothing Then
                    RptSalesinvoicedataMetadata._meta = New RptSalesinvoicedataMetadata()
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
				

				meta.AddTypeMap("InvoiceNumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("InvoiceDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("CustID", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "RPT_SALESINVOICEDATA"
				meta.Destination = "RPT_SALESINVOICEDATA"
				
				meta.spInsert = "proc_RPT_SALESINVOICEDATAInsert"
				meta.spUpdate = "proc_RPT_SALESINVOICEDATAUpdate"
				meta.spDelete = "proc_RPT_SALESINVOICEDATADelete"
				meta.spLoadAll = "proc_RPT_SALESINVOICEDATALoadAll"
				meta.spLoadByPrimaryKey = "proc_RPT_SALESINVOICEDATALoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As RptSalesinvoicedataMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
