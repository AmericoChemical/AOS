'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 9/29/2017 2:18:06 PM
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
	MustInherit Public Class esViewRawMaterialOnOrderCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewRawMaterialOnOrderCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewRawMaterialOnOrderQuery)
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
            Me.InitQuery(CType(query, esViewRawMaterialOnOrderQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewRawMaterialOnOrder) As ViewRawMaterialOnOrder
			Return CType(MyBase.DetachEntity(entity), ViewRawMaterialOnOrder)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewRawMaterialOnOrder) As ViewRawMaterialOnOrder
			Return CType(MyBase.AttachEntity(entity), ViewRawMaterialOnOrder)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewRawMaterialOnOrderCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewRawMaterialOnOrder
            Get
                Return TryCast(MyBase.Item(index), ViewRawMaterialOnOrder)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewRawMaterialOnOrder)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewRawMaterialOnOrder	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewRawMaterialOnOrderQuery
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
												
						Case "Materialid"
							Me.str.Materialid = CType(value, string)
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Productdesc"
							Me.str.Productdesc = CType(value, string)
												
						Case "AvailDate"
							Me.str.AvailDate = CType(value, string)
												
						Case "Qty"
							Me.str.Qty = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Materialid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Materialid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "AvailDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.AvailDate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Qty"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Qty = CType(value, Nullable(Of System.Decimal))
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
		' Maps to viewRawMaterialOnOrder.MATERIALID
		' </summary>
		Public Overridable Property Materialid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRawMaterialOnOrderMetadata.ColumnNames.Materialid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRawMaterialOnOrderMetadata.ColumnNames.Materialid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRawMaterialOnOrder.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRawMaterialOnOrderMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRawMaterialOnOrderMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRawMaterialOnOrder.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewRawMaterialOnOrderMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRawMaterialOnOrderMetadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRawMaterialOnOrder.AvailDate
		' </summary>
		Public Overridable Property AvailDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewRawMaterialOnOrderMetadata.ColumnNames.AvailDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewRawMaterialOnOrderMetadata.ColumnNames.AvailDate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRawMaterialOnOrder.Qty
		' </summary>
		Public Overridable Property Qty As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRawMaterialOnOrderMetadata.ColumnNames.Qty)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRawMaterialOnOrderMetadata.ColumnNames.Qty, value)
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
		
			Public Sub New(ByVal entity As esViewRawMaterialOnOrder)
				Me.entity = entity
			End Sub				
		
	
			Public Property Materialid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Materialid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Materialid = Nothing
					Else
						entity.Materialid = Convert.ToInt32(Value)
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
		  	
			Public Property Productdesc As System.String 
				Get
					Dim data_ As System.String = entity.Productdesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Productdesc = Nothing
					Else
						entity.Productdesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property AvailDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.AvailDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AvailDate = Nothing
					Else
						entity.AvailDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Qty As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Qty
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qty = Nothing
					Else
						entity.Qty = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewRawMaterialOnOrder
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewRawMaterialOnOrderQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewRawMaterialOnOrder can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewRawMaterialOnOrderQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRawMaterialOnOrderMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Materialid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRawMaterialOnOrderMetadata.ColumnNames.Materialid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRawMaterialOnOrderMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRawMaterialOnOrderMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property AvailDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRawMaterialOnOrderMetadata.ColumnNames.AvailDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Qty As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRawMaterialOnOrderMetadata.ColumnNames.Qty, esSystemType.Decimal)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewRawMaterialOnOrderCollection")> _
	Partial Public Class ViewRawMaterialOnOrderCollection
		Inherits esViewRawMaterialOnOrderCollection
		Implements IEnumerable(Of ViewRawMaterialOnOrder)
		
        Public Shared Widening Operator CType(ByVal coll As ViewRawMaterialOnOrderCollection) As List(Of ViewRawMaterialOnOrder)
            Dim list As List(Of ViewRawMaterialOnOrder) = New List(Of ViewRawMaterialOnOrder)
            Dim emp As ViewRawMaterialOnOrder

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRawMaterialOnOrderMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewRawMaterialOnOrderQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewRawMaterialOnOrder(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewRawMaterialOnOrder()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewRawMaterialOnOrderQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewRawMaterialOnOrderQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRawMaterialOnOrderQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewRawMaterialOnOrder 
			Return CType(MyBase.AddNewEntity(), ViewRawMaterialOnOrder)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewRawMaterialOnOrder) Implements IEnumerable(Of ViewRawMaterialOnOrder).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewRawMaterialOnOrder)(Me)
        End Function
		
		Private _query As ViewRawMaterialOnOrderQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewRawMaterialOnOrder' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewRawMaterialOnOrder ()")> _
	<Serializable> _
	Partial Public Class ViewRawMaterialOnOrder 
		Inherits esViewRawMaterialOnOrder

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewRawMaterialOnOrderMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewRawMaterialOnOrderQuery

			If Me._query Is Nothing Then
				Me._query = New ViewRawMaterialOnOrderQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewRawMaterialOnOrderQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewRawMaterialOnOrderQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRawMaterialOnOrderQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewRawMaterialOnOrderQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewRawMaterialOnOrderQuery
		inherits esViewRawMaterialOnOrderQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewRawMaterialOnOrderQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewRawMaterialOnOrderMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewRawMaterialOnOrderMetadata.ColumnNames.Materialid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRawMaterialOnOrderMetadata.PropertyNames.Materialid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRawMaterialOnOrderMetadata.ColumnNames.Productid, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRawMaterialOnOrderMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRawMaterialOnOrderMetadata.ColumnNames.Productdesc, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRawMaterialOnOrderMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRawMaterialOnOrderMetadata.ColumnNames.AvailDate, 3, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewRawMaterialOnOrderMetadata.PropertyNames.AvailDate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRawMaterialOnOrderMetadata.ColumnNames.Qty, 4, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRawMaterialOnOrderMetadata.PropertyNames.Qty
			c.NumericPrecision = 38
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewRawMaterialOnOrderMetadata
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
			 Public Const Materialid As String = "MATERIALID"
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Productdesc As String = "PRODUCTDESC"
			 Public Const AvailDate As String = "AvailDate"
			 Public Const Qty As String = "Qty"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Materialid As String = "Materialid"
			 Public Const Productid As String = "Productid"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const AvailDate As String = "AvailDate"
			 Public Const Qty As String = "Qty"
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
            SyncLock GetType(ViewRawMaterialOnOrderMetadata)
			
				If ViewRawMaterialOnOrderMetadata.mapDelegates Is Nothing Then
					ViewRawMaterialOnOrderMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewRawMaterialOnOrderMetadata._meta Is Nothing Then
                    ViewRawMaterialOnOrderMetadata._meta = New ViewRawMaterialOnOrderMetadata()
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
				

				meta.AddTypeMap("Materialid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("AvailDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Qty", new esTypeMap("decimal", "System.Decimal"))			
				
				
				 
				meta.Source = "viewRawMaterialOnOrder"
				meta.Destination = "viewRawMaterialOnOrder"
				
				meta.spInsert = "proc_viewRawMaterialOnOrderInsert"
				meta.spUpdate = "proc_viewRawMaterialOnOrderUpdate"
				meta.spDelete = "proc_viewRawMaterialOnOrderDelete"
				meta.spLoadAll = "proc_viewRawMaterialOnOrderLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewRawMaterialOnOrderLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewRawMaterialOnOrderMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
