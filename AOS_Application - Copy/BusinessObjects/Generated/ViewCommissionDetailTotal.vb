'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 3/21/2017 7:40:50 AM
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
	MustInherit Public Class esViewCommissionDetailTotalCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewCommissionDetailTotalCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewCommissionDetailTotalQuery)
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
            Me.InitQuery(CType(query, esViewCommissionDetailTotalQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewCommissionDetailTotal) As ViewCommissionDetailTotal
			Return CType(MyBase.DetachEntity(entity), ViewCommissionDetailTotal)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewCommissionDetailTotal) As ViewCommissionDetailTotal
			Return CType(MyBase.AttachEntity(entity), ViewCommissionDetailTotal)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewCommissionDetailTotalCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewCommissionDetailTotal
            Get
                Return TryCast(MyBase.Item(index), ViewCommissionDetailTotal)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewCommissionDetailTotal)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewCommissionDetailTotal	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewCommissionDetailTotalQuery
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
												
						Case "TotalCommissionAmount"
							Me.str.TotalCommissionAmount = CType(value, string)
												
						Case "Salespersonid"
							Me.str.Salespersonid = CType(value, string)
												
						Case "Commissionstatus"
							Me.str.Commissionstatus = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "TotalCommissionAmount"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.TotalCommissionAmount = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Salespersonid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Salespersonid = CType(value, Nullable(Of System.Int32))
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
		' Maps to viewCommissionDetailTotal.TotalCommissionAmount
		' </summary>
		Public Overridable Property TotalCommissionAmount As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCommissionDetailTotalMetadata.ColumnNames.TotalCommissionAmount)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCommissionDetailTotalMetadata.ColumnNames.TotalCommissionAmount, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionDetailTotal.SALESPERSONID
		' </summary>
		Public Overridable Property Salespersonid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCommissionDetailTotalMetadata.ColumnNames.Salespersonid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCommissionDetailTotalMetadata.ColumnNames.Salespersonid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionDetailTotal.COMMISSIONSTATUS
		' </summary>
		Public Overridable Property Commissionstatus As System.String
			Get
				Return MyBase.GetSystemString(ViewCommissionDetailTotalMetadata.ColumnNames.Commissionstatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCommissionDetailTotalMetadata.ColumnNames.Commissionstatus, value)
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
		
			Public Sub New(ByVal entity As esViewCommissionDetailTotal)
				Me.entity = entity
			End Sub				
		
	
			Public Property TotalCommissionAmount As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.TotalCommissionAmount
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TotalCommissionAmount = Nothing
					Else
						entity.TotalCommissionAmount = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
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
		  	
			Public Property Commissionstatus As System.String 
				Get
					Dim data_ As System.String = entity.Commissionstatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Commissionstatus = Nothing
					Else
						entity.Commissionstatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewCommissionDetailTotal
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewCommissionDetailTotalQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewCommissionDetailTotal can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewCommissionDetailTotalQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCommissionDetailTotalMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property TotalCommissionAmount As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionDetailTotalMetadata.ColumnNames.TotalCommissionAmount, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Salespersonid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionDetailTotalMetadata.ColumnNames.Salespersonid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Commissionstatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionDetailTotalMetadata.ColumnNames.Commissionstatus, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewCommissionDetailTotalCollection")> _
	Partial Public Class ViewCommissionDetailTotalCollection
		Inherits esViewCommissionDetailTotalCollection
		Implements IEnumerable(Of ViewCommissionDetailTotal)
		
        Public Shared Widening Operator CType(ByVal coll As ViewCommissionDetailTotalCollection) As List(Of ViewCommissionDetailTotal)
            Dim list As List(Of ViewCommissionDetailTotal) = New List(Of ViewCommissionDetailTotal)
            Dim emp As ViewCommissionDetailTotal

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCommissionDetailTotalMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewCommissionDetailTotalQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewCommissionDetailTotal(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewCommissionDetailTotal()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewCommissionDetailTotalQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewCommissionDetailTotalQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewCommissionDetailTotalQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewCommissionDetailTotal 
			Return CType(MyBase.AddNewEntity(), ViewCommissionDetailTotal)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewCommissionDetailTotal) Implements IEnumerable(Of ViewCommissionDetailTotal).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewCommissionDetailTotal)(Me)
        End Function
		
		Private _query As ViewCommissionDetailTotalQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewCommissionDetailTotal' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewCommissionDetailTotal ()")> _
	<Serializable> _
	Partial Public Class ViewCommissionDetailTotal 
		Inherits esViewCommissionDetailTotal

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewCommissionDetailTotalMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewCommissionDetailTotalQuery

			If Me._query Is Nothing Then
				Me._query = New ViewCommissionDetailTotalQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewCommissionDetailTotalQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewCommissionDetailTotalQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewCommissionDetailTotalQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewCommissionDetailTotalQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewCommissionDetailTotalQuery
		inherits esViewCommissionDetailTotalQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewCommissionDetailTotalQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewCommissionDetailTotalMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCommissionDetailTotalMetadata.ColumnNames.TotalCommissionAmount, 0, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCommissionDetailTotalMetadata.PropertyNames.TotalCommissionAmount
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionDetailTotalMetadata.ColumnNames.Salespersonid, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCommissionDetailTotalMetadata.PropertyNames.Salespersonid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionDetailTotalMetadata.ColumnNames.Commissionstatus, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCommissionDetailTotalMetadata.PropertyNames.Commissionstatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewCommissionDetailTotalMetadata
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
			 Public Const TotalCommissionAmount As String = "TotalCommissionAmount"
			 Public Const Salespersonid As String = "SALESPERSONID"
			 Public Const Commissionstatus As String = "COMMISSIONSTATUS"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const TotalCommissionAmount As String = "TotalCommissionAmount"
			 Public Const Salespersonid As String = "Salespersonid"
			 Public Const Commissionstatus As String = "Commissionstatus"
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
            SyncLock GetType(ViewCommissionDetailTotalMetadata)
			
				If ViewCommissionDetailTotalMetadata.mapDelegates Is Nothing Then
					ViewCommissionDetailTotalMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewCommissionDetailTotalMetadata._meta Is Nothing Then
                    ViewCommissionDetailTotalMetadata._meta = New ViewCommissionDetailTotalMetadata()
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
				

				meta.AddTypeMap("TotalCommissionAmount", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Salespersonid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Commissionstatus", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewCommissionDetailTotal"
				meta.Destination = "viewCommissionDetailTotal"
				
				meta.spInsert = "proc_viewCommissionDetailTotalInsert"
				meta.spUpdate = "proc_viewCommissionDetailTotalUpdate"
				meta.spDelete = "proc_viewCommissionDetailTotalDelete"
				meta.spLoadAll = "proc_viewCommissionDetailTotalLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCommissionDetailTotalLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewCommissionDetailTotalMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
