'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/5/2015 2:58:15 PM
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
	MustInherit Public Class esViewRMAvailableByProductCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewRMAvailableByProductCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewRMAvailableByProductQuery)
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
            Me.InitQuery(CType(query, esViewRMAvailableByProductQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewRMAvailableByProduct) As ViewRMAvailableByProduct
			Return CType(MyBase.DetachEntity(entity), ViewRMAvailableByProduct)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewRMAvailableByProduct) As ViewRMAvailableByProduct
			Return CType(MyBase.AttachEntity(entity), ViewRMAvailableByProduct)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewRMAvailableByProductCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewRMAvailableByProduct
            Get
                Return TryCast(MyBase.Item(index), ViewRMAvailableByProduct)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewRMAvailableByProduct)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewRMAvailableByProduct	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewRMAvailableByProductQuery
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
												
						Case "Totalavailable"
							Me.str.Totalavailable = CType(value, string)
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Totalavailable"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Totalavailable = CType(value, Nullable(Of System.Double))
							End If
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
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
		' Maps to viewRMAvailableByProduct.TOTALAVAILABLE
		' </summary>
		Public Overridable Property Totalavailable As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewRMAvailableByProductMetadata.ColumnNames.Totalavailable)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewRMAvailableByProductMetadata.ColumnNames.Totalavailable, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRMAvailableByProduct.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRMAvailableByProductMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRMAvailableByProductMetadata.ColumnNames.Productid, value)
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
		
			Public Sub New(ByVal entity As esViewRMAvailableByProduct)
				Me.entity = entity
			End Sub				
		
	
			Public Property Totalavailable As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Totalavailable
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Totalavailable = Nothing
					Else
						entity.Totalavailable = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property Productid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Productid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Productid = Nothing
					Else
						entity.Productid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewRMAvailableByProduct
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewRMAvailableByProductQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewRMAvailableByProduct can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewRMAvailableByProductQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRMAvailableByProductMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Totalavailable As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRMAvailableByProductMetadata.ColumnNames.Totalavailable, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRMAvailableByProductMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewRMAvailableByProductCollection")> _
	Partial Public Class ViewRMAvailableByProductCollection
		Inherits esViewRMAvailableByProductCollection
		Implements IEnumerable(Of ViewRMAvailableByProduct)
		
        Public Shared Widening Operator CType(ByVal coll As ViewRMAvailableByProductCollection) As List(Of ViewRMAvailableByProduct)
            Dim list As List(Of ViewRMAvailableByProduct) = New List(Of ViewRMAvailableByProduct)
            Dim emp As ViewRMAvailableByProduct

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRMAvailableByProductMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewRMAvailableByProductQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewRMAvailableByProduct(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewRMAvailableByProduct()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewRMAvailableByProductQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewRMAvailableByProductQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRMAvailableByProductQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewRMAvailableByProduct 
			Return CType(MyBase.AddNewEntity(), ViewRMAvailableByProduct)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewRMAvailableByProduct) Implements IEnumerable(Of ViewRMAvailableByProduct).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewRMAvailableByProduct)(Me)
        End Function
		
		Private _query As ViewRMAvailableByProductQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewRMAvailableByProduct' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewRMAvailableByProduct ()")> _
	<Serializable> _
	Partial Public Class ViewRMAvailableByProduct 
		Inherits esViewRMAvailableByProduct

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewRMAvailableByProductMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewRMAvailableByProductQuery

			If Me._query Is Nothing Then
				Me._query = New ViewRMAvailableByProductQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewRMAvailableByProductQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewRMAvailableByProductQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRMAvailableByProductQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewRMAvailableByProductQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewRMAvailableByProductQuery
		inherits esViewRMAvailableByProductQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewRMAvailableByProductQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewRMAvailableByProductMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewRMAvailableByProductMetadata.ColumnNames.Totalavailable, 0, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewRMAvailableByProductMetadata.PropertyNames.Totalavailable
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRMAvailableByProductMetadata.ColumnNames.Productid, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRMAvailableByProductMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewRMAvailableByProductMetadata
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
			 Public Const Totalavailable As String = "TOTALAVAILABLE"
			 Public Const Productid As String = "PRODUCTID"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Totalavailable As String = "Totalavailable"
			 Public Const Productid As String = "Productid"
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
            SyncLock GetType(ViewRMAvailableByProductMetadata)
			
				If ViewRMAvailableByProductMetadata.mapDelegates Is Nothing Then
					ViewRMAvailableByProductMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewRMAvailableByProductMetadata._meta Is Nothing Then
                    ViewRMAvailableByProductMetadata._meta = New ViewRMAvailableByProductMetadata()
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
				

				meta.AddTypeMap("Totalavailable", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Productid", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "viewRMAvailableByProduct"
				meta.Destination = "viewRMAvailableByProduct"
				
				meta.spInsert = "proc_viewRMAvailableByProductInsert"
				meta.spUpdate = "proc_viewRMAvailableByProductUpdate"
				meta.spDelete = "proc_viewRMAvailableByProductDelete"
				meta.spLoadAll = "proc_viewRMAvailableByProductLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewRMAvailableByProductLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewRMAvailableByProductMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
