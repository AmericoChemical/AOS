'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 4/12/2016 8:56:21 AM
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
	MustInherit Public Class esViewApisItemTotalsCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewApisItemTotalsCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewApisItemTotalsQuery)
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
            Me.InitQuery(CType(query, esViewApisItemTotalsQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewApisItemTotals) As ViewApisItemTotals
			Return CType(MyBase.DetachEntity(entity), ViewApisItemTotals)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewApisItemTotals) As ViewApisItemTotals
			Return CType(MyBase.AttachEntity(entity), ViewApisItemTotals)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewApisItemTotalsCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewApisItemTotals
            Get
                Return TryCast(MyBase.Item(index), ViewApisItemTotals)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewApisItemTotals)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewApisItemTotals	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewApisItemTotalsQuery
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
												
						Case "Apisnum"
							Me.str.Apisnum = CType(value, string)
												
						Case "Volume"
							Me.str.Volume = CType(value, string)
												
						Case "Weight"
							Me.str.Weight = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Apisnum"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Apisnum = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Volume"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Volume = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Weight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Weight = CType(value, Nullable(Of System.Decimal))
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
		' Maps to viewApisItemTotals.APISNUM
		' </summary>
		Public Overridable Property Apisnum As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewApisItemTotalsMetadata.ColumnNames.Apisnum)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewApisItemTotalsMetadata.ColumnNames.Apisnum, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewApisItemTotals.VOLUME
		' </summary>
		Public Overridable Property Volume As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewApisItemTotalsMetadata.ColumnNames.Volume)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewApisItemTotalsMetadata.ColumnNames.Volume, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewApisItemTotals.WEIGHT
		' </summary>
		Public Overridable Property Weight As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewApisItemTotalsMetadata.ColumnNames.Weight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewApisItemTotalsMetadata.ColumnNames.Weight, value)
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
		
			Public Sub New(ByVal entity As esViewApisItemTotals)
				Me.entity = entity
			End Sub				
		
	
			Public Property Apisnum As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Apisnum
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Apisnum = Nothing
					Else
						entity.Apisnum = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Volume As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Volume
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Volume = Nothing
					Else
						entity.Volume = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Weight As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Weight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Weight = Nothing
					Else
						entity.Weight = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewApisItemTotals
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewApisItemTotalsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewApisItemTotals can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewApisItemTotalsQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewApisItemTotalsMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Apisnum As esQueryItem
			Get
				Return New esQueryItem(Me, ViewApisItemTotalsMetadata.ColumnNames.Apisnum, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Volume As esQueryItem
			Get
				Return New esQueryItem(Me, ViewApisItemTotalsMetadata.ColumnNames.Volume, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Weight As esQueryItem
			Get
				Return New esQueryItem(Me, ViewApisItemTotalsMetadata.ColumnNames.Weight, esSystemType.Decimal)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewApisItemTotalsCollection")> _
	Partial Public Class ViewApisItemTotalsCollection
		Inherits esViewApisItemTotalsCollection
		Implements IEnumerable(Of ViewApisItemTotals)
		
        Public Shared Widening Operator CType(ByVal coll As ViewApisItemTotalsCollection) As List(Of ViewApisItemTotals)
            Dim list As List(Of ViewApisItemTotals) = New List(Of ViewApisItemTotals)
            Dim emp As ViewApisItemTotals

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewApisItemTotalsMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewApisItemTotalsQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewApisItemTotals(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewApisItemTotals()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewApisItemTotalsQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewApisItemTotalsQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewApisItemTotalsQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewApisItemTotals 
			Return CType(MyBase.AddNewEntity(), ViewApisItemTotals)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewApisItemTotals) Implements IEnumerable(Of ViewApisItemTotals).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewApisItemTotals)(Me)
        End Function
		
		Private _query As ViewApisItemTotalsQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewApisItemTotals' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewApisItemTotals ()")> _
	<Serializable> _
	Partial Public Class ViewApisItemTotals 
		Inherits esViewApisItemTotals

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewApisItemTotalsMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewApisItemTotalsQuery

			If Me._query Is Nothing Then
				Me._query = New ViewApisItemTotalsQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewApisItemTotalsQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewApisItemTotalsQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewApisItemTotalsQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewApisItemTotalsQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewApisItemTotalsQuery
		inherits esViewApisItemTotalsQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewApisItemTotalsQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewApisItemTotalsMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewApisItemTotalsMetadata.ColumnNames.Apisnum, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewApisItemTotalsMetadata.PropertyNames.Apisnum
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewApisItemTotalsMetadata.ColumnNames.Volume, 1, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewApisItemTotalsMetadata.PropertyNames.Volume
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewApisItemTotalsMetadata.ColumnNames.Weight, 2, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewApisItemTotalsMetadata.PropertyNames.Weight
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewApisItemTotalsMetadata
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
			 Public Const Apisnum As String = "APISNUM"
			 Public Const Volume As String = "VOLUME"
			 Public Const Weight As String = "WEIGHT"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Apisnum As String = "Apisnum"
			 Public Const Volume As String = "Volume"
			 Public Const Weight As String = "Weight"
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
            SyncLock GetType(ViewApisItemTotalsMetadata)
			
				If ViewApisItemTotalsMetadata.mapDelegates Is Nothing Then
					ViewApisItemTotalsMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewApisItemTotalsMetadata._meta Is Nothing Then
                    ViewApisItemTotalsMetadata._meta = New ViewApisItemTotalsMetadata()
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
				

				meta.AddTypeMap("Apisnum", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Volume", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Weight", new esTypeMap("decimal", "System.Decimal"))			
				
				
				 
				meta.Source = "viewApisItemTotals"
				meta.Destination = "viewApisItemTotals"
				
				meta.spInsert = "proc_viewApisItemTotalsInsert"
				meta.spUpdate = "proc_viewApisItemTotalsUpdate"
				meta.spDelete = "proc_viewApisItemTotalsDelete"
				meta.spLoadAll = "proc_viewApisItemTotalsLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewApisItemTotalsLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewApisItemTotalsMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
