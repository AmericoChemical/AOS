'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/26/2016 8:58:04 AM
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
	MustInherit Public Class esViewWorkOrderGrossWeightCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewWorkOrderGrossWeightCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewWorkOrderGrossWeightQuery)
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
            Me.InitQuery(CType(query, esViewWorkOrderGrossWeightQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewWorkOrderGrossWeight) As ViewWorkOrderGrossWeight
			Return CType(MyBase.DetachEntity(entity), ViewWorkOrderGrossWeight)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewWorkOrderGrossWeight) As ViewWorkOrderGrossWeight
			Return CType(MyBase.AttachEntity(entity), ViewWorkOrderGrossWeight)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewWorkOrderGrossWeightCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewWorkOrderGrossWeight
            Get
                Return TryCast(MyBase.Item(index), ViewWorkOrderGrossWeight)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewWorkOrderGrossWeight)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewWorkOrderGrossWeight	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewWorkOrderGrossWeightQuery
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
												
						Case "Workordernumber"
							Me.str.Workordernumber = CType(value, string)
												
						Case "GrossWeight"
							Me.str.GrossWeight = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Workordernumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Workordernumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "GrossWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.GrossWeight = CType(value, Nullable(Of System.Decimal))
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
		' Maps to viewWorkOrderGrossWeight.WORKORDERNUMBER
		' </summary>
		Public Overridable Property Workordernumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewWorkOrderGrossWeightMetadata.ColumnNames.Workordernumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewWorkOrderGrossWeightMetadata.ColumnNames.Workordernumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderGrossWeight.GrossWeight
		' </summary>
		Public Overridable Property GrossWeight As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewWorkOrderGrossWeightMetadata.ColumnNames.GrossWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewWorkOrderGrossWeightMetadata.ColumnNames.GrossWeight, value)
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
		
			Public Sub New(ByVal entity As esViewWorkOrderGrossWeight)
				Me.entity = entity
			End Sub				
		
	
			Public Property Workordernumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Workordernumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Workordernumber = Nothing
					Else
						entity.Workordernumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property GrossWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.GrossWeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.GrossWeight = Nothing
					Else
						entity.GrossWeight = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewWorkOrderGrossWeight
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewWorkOrderGrossWeightQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewWorkOrderGrossWeight can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewWorkOrderGrossWeightQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewWorkOrderGrossWeightMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Workordernumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderGrossWeightMetadata.ColumnNames.Workordernumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property GrossWeight As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderGrossWeightMetadata.ColumnNames.GrossWeight, esSystemType.Decimal)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewWorkOrderGrossWeightCollection")> _
	Partial Public Class ViewWorkOrderGrossWeightCollection
		Inherits esViewWorkOrderGrossWeightCollection
		Implements IEnumerable(Of ViewWorkOrderGrossWeight)
		
        Public Shared Widening Operator CType(ByVal coll As ViewWorkOrderGrossWeightCollection) As List(Of ViewWorkOrderGrossWeight)
            Dim list As List(Of ViewWorkOrderGrossWeight) = New List(Of ViewWorkOrderGrossWeight)
            Dim emp As ViewWorkOrderGrossWeight

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewWorkOrderGrossWeightMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewWorkOrderGrossWeightQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewWorkOrderGrossWeight(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewWorkOrderGrossWeight()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewWorkOrderGrossWeightQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewWorkOrderGrossWeightQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewWorkOrderGrossWeightQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewWorkOrderGrossWeight 
			Return CType(MyBase.AddNewEntity(), ViewWorkOrderGrossWeight)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewWorkOrderGrossWeight) Implements IEnumerable(Of ViewWorkOrderGrossWeight).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewWorkOrderGrossWeight)(Me)
        End Function
		
		Private _query As ViewWorkOrderGrossWeightQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewWorkOrderGrossWeight' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewWorkOrderGrossWeight ()")> _
	<Serializable> _
	Partial Public Class ViewWorkOrderGrossWeight 
		Inherits esViewWorkOrderGrossWeight

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewWorkOrderGrossWeightMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewWorkOrderGrossWeightQuery

			If Me._query Is Nothing Then
				Me._query = New ViewWorkOrderGrossWeightQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewWorkOrderGrossWeightQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewWorkOrderGrossWeightQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewWorkOrderGrossWeightQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewWorkOrderGrossWeightQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewWorkOrderGrossWeightQuery
		inherits esViewWorkOrderGrossWeightQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewWorkOrderGrossWeightQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewWorkOrderGrossWeightMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewWorkOrderGrossWeightMetadata.ColumnNames.Workordernumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewWorkOrderGrossWeightMetadata.PropertyNames.Workordernumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderGrossWeightMetadata.ColumnNames.GrossWeight, 1, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewWorkOrderGrossWeightMetadata.PropertyNames.GrossWeight
			c.NumericPrecision = 38
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewWorkOrderGrossWeightMetadata
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
			 Public Const Workordernumber As String = "WORKORDERNUMBER"
			 Public Const GrossWeight As String = "GrossWeight"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Workordernumber As String = "Workordernumber"
			 Public Const GrossWeight As String = "GrossWeight"
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
            SyncLock GetType(ViewWorkOrderGrossWeightMetadata)
			
				If ViewWorkOrderGrossWeightMetadata.mapDelegates Is Nothing Then
					ViewWorkOrderGrossWeightMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewWorkOrderGrossWeightMetadata._meta Is Nothing Then
                    ViewWorkOrderGrossWeightMetadata._meta = New ViewWorkOrderGrossWeightMetadata()
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
				

				meta.AddTypeMap("Workordernumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("GrossWeight", new esTypeMap("numeric", "System.Decimal"))			
				
				
				 
				meta.Source = "viewWorkOrderGrossWeight"
				meta.Destination = "viewWorkOrderGrossWeight"
				
				meta.spInsert = "proc_viewWorkOrderGrossWeightInsert"
				meta.spUpdate = "proc_viewWorkOrderGrossWeightUpdate"
				meta.spDelete = "proc_viewWorkOrderGrossWeightDelete"
				meta.spLoadAll = "proc_viewWorkOrderGrossWeightLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewWorkOrderGrossWeightLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewWorkOrderGrossWeightMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
