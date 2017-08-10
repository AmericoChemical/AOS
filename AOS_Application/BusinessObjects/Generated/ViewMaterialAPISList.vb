'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 7/24/2017 8:47:10 AM
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
	MustInherit Public Class esViewMaterialAPISListCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewMaterialAPISListCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewMaterialAPISListQuery)
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
            Me.InitQuery(CType(query, esViewMaterialAPISListQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewMaterialAPISList) As ViewMaterialAPISList
			Return CType(MyBase.DetachEntity(entity), ViewMaterialAPISList)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewMaterialAPISList) As ViewMaterialAPISList
			Return CType(MyBase.AttachEntity(entity), ViewMaterialAPISList)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewMaterialAPISListCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewMaterialAPISList
            Get
                Return TryCast(MyBase.Item(index), ViewMaterialAPISList)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewMaterialAPISList)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewMaterialAPISList	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewMaterialAPISListQuery
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
												
						Case "Materialdesc"
							Me.str.Materialdesc = CType(value, string)
												
						Case "Apisnum"
							Me.str.Apisnum = CType(value, string)
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Productdesc"
							Me.str.Productdesc = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "Qtyunits"
							Me.str.Qtyunits = CType(value, string)
												
						Case "Uom"
							Me.str.Uom = CType(value, string)
												
						Case "Apisstatus"
							Me.str.Apisstatus = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Materialid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Materialid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Apisnum"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Apisnum = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Qtyunits"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Qtyunits = CType(value, Nullable(Of System.Double))
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
		' Maps to viewMaterialAPISList.MATERIALID
		' </summary>
		Public Overridable Property Materialid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewMaterialAPISListMetadata.ColumnNames.Materialid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewMaterialAPISListMetadata.ColumnNames.Materialid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewMaterialAPISList.MATERIALDESC
		' </summary>
		Public Overridable Property Materialdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewMaterialAPISListMetadata.ColumnNames.Materialdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewMaterialAPISListMetadata.ColumnNames.Materialdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewMaterialAPISList.APISNUM
		' </summary>
		Public Overridable Property Apisnum As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewMaterialAPISListMetadata.ColumnNames.Apisnum)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewMaterialAPISListMetadata.ColumnNames.Apisnum, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewMaterialAPISList.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewMaterialAPISListMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewMaterialAPISListMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewMaterialAPISList.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewMaterialAPISListMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewMaterialAPISListMetadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewMaterialAPISList.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewMaterialAPISListMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewMaterialAPISListMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewMaterialAPISList.QTYUNITS
		' </summary>
		Public Overridable Property Qtyunits As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewMaterialAPISListMetadata.ColumnNames.Qtyunits)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewMaterialAPISListMetadata.ColumnNames.Qtyunits, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewMaterialAPISList.UOM
		' </summary>
		Public Overridable Property Uom As System.String
			Get
				Return MyBase.GetSystemString(ViewMaterialAPISListMetadata.ColumnNames.Uom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewMaterialAPISListMetadata.ColumnNames.Uom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewMaterialAPISList.APISSTATUS
		' </summary>
		Public Overridable Property Apisstatus As System.String
			Get
				Return MyBase.GetSystemString(ViewMaterialAPISListMetadata.ColumnNames.Apisstatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewMaterialAPISListMetadata.ColumnNames.Apisstatus, value)
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
		
			Public Sub New(ByVal entity As esViewMaterialAPISList)
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
		  	
			Public Property Materialdesc As System.String 
				Get
					Dim data_ As System.String = entity.Materialdesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Materialdesc = Nothing
					Else
						entity.Materialdesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
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
		  	
			Public Property Container As System.String 
				Get
					Dim data_ As System.String = entity.Container
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Container = Nothing
					Else
						entity.Container = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Qtyunits As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Qtyunits
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qtyunits = Nothing
					Else
						entity.Qtyunits = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property Uom As System.String 
				Get
					Dim data_ As System.String = entity.Uom
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Uom = Nothing
					Else
						entity.Uom = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Apisstatus As System.String 
				Get
					Dim data_ As System.String = entity.Apisstatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Apisstatus = Nothing
					Else
						entity.Apisstatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewMaterialAPISList
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewMaterialAPISListQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewMaterialAPISList can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewMaterialAPISListQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewMaterialAPISListMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Materialid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialAPISListMetadata.ColumnNames.Materialid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Materialdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialAPISListMetadata.ColumnNames.Materialdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Apisnum As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialAPISListMetadata.ColumnNames.Apisnum, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialAPISListMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialAPISListMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialAPISListMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Qtyunits As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialAPISListMetadata.ColumnNames.Qtyunits, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Uom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialAPISListMetadata.ColumnNames.Uom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Apisstatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialAPISListMetadata.ColumnNames.Apisstatus, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewMaterialAPISListCollection")> _
	Partial Public Class ViewMaterialAPISListCollection
		Inherits esViewMaterialAPISListCollection
		Implements IEnumerable(Of ViewMaterialAPISList)
		
        Public Shared Widening Operator CType(ByVal coll As ViewMaterialAPISListCollection) As List(Of ViewMaterialAPISList)
            Dim list As List(Of ViewMaterialAPISList) = New List(Of ViewMaterialAPISList)
            Dim emp As ViewMaterialAPISList

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewMaterialAPISListMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewMaterialAPISListQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewMaterialAPISList(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewMaterialAPISList()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewMaterialAPISListQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewMaterialAPISListQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewMaterialAPISListQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewMaterialAPISList 
			Return CType(MyBase.AddNewEntity(), ViewMaterialAPISList)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewMaterialAPISList) Implements IEnumerable(Of ViewMaterialAPISList).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewMaterialAPISList)(Me)
        End Function
		
		Private _query As ViewMaterialAPISListQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewMaterialAPISList' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewMaterialAPISList ()")> _
	<Serializable> _
	Partial Public Class ViewMaterialAPISList 
		Inherits esViewMaterialAPISList

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewMaterialAPISListMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewMaterialAPISListQuery

			If Me._query Is Nothing Then
				Me._query = New ViewMaterialAPISListQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewMaterialAPISListQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewMaterialAPISListQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewMaterialAPISListQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewMaterialAPISListQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewMaterialAPISListQuery
		inherits esViewMaterialAPISListQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewMaterialAPISListQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewMaterialAPISListMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewMaterialAPISListMetadata.ColumnNames.Materialid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewMaterialAPISListMetadata.PropertyNames.Materialid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewMaterialAPISListMetadata.ColumnNames.Materialdesc, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewMaterialAPISListMetadata.PropertyNames.Materialdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewMaterialAPISListMetadata.ColumnNames.Apisnum, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewMaterialAPISListMetadata.PropertyNames.Apisnum
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewMaterialAPISListMetadata.ColumnNames.Productid, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewMaterialAPISListMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewMaterialAPISListMetadata.ColumnNames.Productdesc, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewMaterialAPISListMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewMaterialAPISListMetadata.ColumnNames.Container, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewMaterialAPISListMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewMaterialAPISListMetadata.ColumnNames.Qtyunits, 6, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewMaterialAPISListMetadata.PropertyNames.Qtyunits
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewMaterialAPISListMetadata.ColumnNames.Uom, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewMaterialAPISListMetadata.PropertyNames.Uom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewMaterialAPISListMetadata.ColumnNames.Apisstatus, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewMaterialAPISListMetadata.PropertyNames.Apisstatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewMaterialAPISListMetadata
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
			 Public Const Materialdesc As String = "MATERIALDESC"
			 Public Const Apisnum As String = "APISNUM"
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Productdesc As String = "PRODUCTDESC"
			 Public Const Container As String = "CONTAINER"
			 Public Const Qtyunits As String = "QTYUNITS"
			 Public Const Uom As String = "UOM"
			 Public Const Apisstatus As String = "APISSTATUS"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Materialid As String = "Materialid"
			 Public Const Materialdesc As String = "Materialdesc"
			 Public Const Apisnum As String = "Apisnum"
			 Public Const Productid As String = "Productid"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const Container As String = "Container"
			 Public Const Qtyunits As String = "Qtyunits"
			 Public Const Uom As String = "Uom"
			 Public Const Apisstatus As String = "Apisstatus"
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
            SyncLock GetType(ViewMaterialAPISListMetadata)
			
				If ViewMaterialAPISListMetadata.mapDelegates Is Nothing Then
					ViewMaterialAPISListMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewMaterialAPISListMetadata._meta Is Nothing Then
                    ViewMaterialAPISListMetadata._meta = New ViewMaterialAPISListMetadata()
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
				meta.AddTypeMap("Materialdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Apisnum", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Qtyunits", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Uom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Apisstatus", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewMaterialAPISList"
				meta.Destination = "viewMaterialAPISList"
				
				meta.spInsert = "proc_viewMaterialAPISListInsert"
				meta.spUpdate = "proc_viewMaterialAPISListUpdate"
				meta.spDelete = "proc_viewMaterialAPISListDelete"
				meta.spLoadAll = "proc_viewMaterialAPISListLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewMaterialAPISListLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewMaterialAPISListMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
