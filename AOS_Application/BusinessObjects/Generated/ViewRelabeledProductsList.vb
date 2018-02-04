'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/25/2018 8:08:42 AM
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
	MustInherit Public Class esViewRelabeledProductsListCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewRelabeledProductsListCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewRelabeledProductsListQuery)
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
            Me.InitQuery(CType(query, esViewRelabeledProductsListQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewRelabeledProductsList) As ViewRelabeledProductsList
			Return CType(MyBase.DetachEntity(entity), ViewRelabeledProductsList)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewRelabeledProductsList) As ViewRelabeledProductsList
			Return CType(MyBase.AttachEntity(entity), ViewRelabeledProductsList)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewRelabeledProductsListCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewRelabeledProductsList
            Get
                Return TryCast(MyBase.Item(index), ViewRelabeledProductsList)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewRelabeledProductsList)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewRelabeledProductsList	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewRelabeledProductsListQuery
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
												
						Case "Fulfillmentplanid"
							Me.str.Fulfillmentplanid = CType(value, string)
												
						Case "Rlblid"
							Me.str.Rlblid = CType(value, string)
												
						Case "Rlbldesc"
							Me.str.Rlbldesc = CType(value, string)
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Productdesc"
							Me.str.Productdesc = CType(value, string)
												
						Case "Kitid"
							Me.str.Kitid = CType(value, string)
												
						Case "Stdlaborhrs"
							Me.str.Stdlaborhrs = CType(value, string)
												
						Case "Rlblcontainer"
							Me.str.Rlblcontainer = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Fulfillmentplanid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Fulfillmentplanid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Rlblid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Rlblid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Kitid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Kitid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Stdlaborhrs"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Stdlaborhrs = CType(value, Nullable(Of System.Decimal))
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
		' Maps to viewRelabeledProductsList.FULFILLMENTPLANID
		' </summary>
		Public Overridable Property Fulfillmentplanid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRelabeledProductsListMetadata.ColumnNames.Fulfillmentplanid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRelabeledProductsListMetadata.ColumnNames.Fulfillmentplanid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRelabeledProductsList.RLBLID
		' </summary>
		Public Overridable Property Rlblid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRelabeledProductsListMetadata.ColumnNames.Rlblid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRelabeledProductsListMetadata.ColumnNames.Rlblid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRelabeledProductsList.RLBLDESC
		' </summary>
		Public Overridable Property Rlbldesc As System.String
			Get
				Return MyBase.GetSystemString(ViewRelabeledProductsListMetadata.ColumnNames.Rlbldesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRelabeledProductsListMetadata.ColumnNames.Rlbldesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRelabeledProductsList.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRelabeledProductsListMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRelabeledProductsListMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRelabeledProductsList.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewRelabeledProductsListMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRelabeledProductsListMetadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRelabeledProductsList.KITID
		' </summary>
		Public Overridable Property Kitid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRelabeledProductsListMetadata.ColumnNames.Kitid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRelabeledProductsListMetadata.ColumnNames.Kitid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRelabeledProductsList.STDLABORHRS
		' </summary>
		Public Overridable Property Stdlaborhrs As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRelabeledProductsListMetadata.ColumnNames.Stdlaborhrs)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRelabeledProductsListMetadata.ColumnNames.Stdlaborhrs, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRelabeledProductsList.RLBLCONTAINER
		' </summary>
		Public Overridable Property Rlblcontainer As System.String
			Get
				Return MyBase.GetSystemString(ViewRelabeledProductsListMetadata.ColumnNames.Rlblcontainer)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRelabeledProductsListMetadata.ColumnNames.Rlblcontainer, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRelabeledProductsList.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewRelabeledProductsListMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRelabeledProductsListMetadata.ColumnNames.Container, value)
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
		
			Public Sub New(ByVal entity As esViewRelabeledProductsList)
				Me.entity = entity
			End Sub				
		
	
			Public Property Fulfillmentplanid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Fulfillmentplanid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Fulfillmentplanid = Nothing
					Else
						entity.Fulfillmentplanid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Rlblid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Rlblid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Rlblid = Nothing
					Else
						entity.Rlblid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Rlbldesc As System.String 
				Get
					Dim data_ As System.String = entity.Rlbldesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Rlbldesc = Nothing
					Else
						entity.Rlbldesc = Convert.ToString(Value)
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
		  	
			Public Property Kitid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Kitid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Kitid = Nothing
					Else
						entity.Kitid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Stdlaborhrs As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Stdlaborhrs
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Stdlaborhrs = Nothing
					Else
						entity.Stdlaborhrs = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Rlblcontainer As System.String 
				Get
					Dim data_ As System.String = entity.Rlblcontainer
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Rlblcontainer = Nothing
					Else
						entity.Rlblcontainer = Convert.ToString(Value)
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
		  

			Private entity As esViewRelabeledProductsList
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewRelabeledProductsListQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewRelabeledProductsList can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewRelabeledProductsListQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRelabeledProductsListMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Fulfillmentplanid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRelabeledProductsListMetadata.ColumnNames.Fulfillmentplanid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Rlblid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRelabeledProductsListMetadata.ColumnNames.Rlblid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Rlbldesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRelabeledProductsListMetadata.ColumnNames.Rlbldesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRelabeledProductsListMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRelabeledProductsListMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Kitid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRelabeledProductsListMetadata.ColumnNames.Kitid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Stdlaborhrs As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRelabeledProductsListMetadata.ColumnNames.Stdlaborhrs, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Rlblcontainer As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRelabeledProductsListMetadata.ColumnNames.Rlblcontainer, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRelabeledProductsListMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewRelabeledProductsListCollection")> _
	Partial Public Class ViewRelabeledProductsListCollection
		Inherits esViewRelabeledProductsListCollection
		Implements IEnumerable(Of ViewRelabeledProductsList)
		
        Public Shared Widening Operator CType(ByVal coll As ViewRelabeledProductsListCollection) As List(Of ViewRelabeledProductsList)
            Dim list As List(Of ViewRelabeledProductsList) = New List(Of ViewRelabeledProductsList)
            Dim emp As ViewRelabeledProductsList

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRelabeledProductsListMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewRelabeledProductsListQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewRelabeledProductsList(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewRelabeledProductsList()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewRelabeledProductsListQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewRelabeledProductsListQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRelabeledProductsListQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewRelabeledProductsList 
			Return CType(MyBase.AddNewEntity(), ViewRelabeledProductsList)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewRelabeledProductsList) Implements IEnumerable(Of ViewRelabeledProductsList).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewRelabeledProductsList)(Me)
        End Function
		
		Private _query As ViewRelabeledProductsListQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewRelabeledProductsList' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewRelabeledProductsList ()")> _
	<Serializable> _
	Partial Public Class ViewRelabeledProductsList 
		Inherits esViewRelabeledProductsList

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewRelabeledProductsListMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewRelabeledProductsListQuery

			If Me._query Is Nothing Then
				Me._query = New ViewRelabeledProductsListQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewRelabeledProductsListQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewRelabeledProductsListQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRelabeledProductsListQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewRelabeledProductsListQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewRelabeledProductsListQuery
		inherits esViewRelabeledProductsListQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewRelabeledProductsListQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewRelabeledProductsListMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewRelabeledProductsListMetadata.ColumnNames.Fulfillmentplanid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRelabeledProductsListMetadata.PropertyNames.Fulfillmentplanid
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRelabeledProductsListMetadata.ColumnNames.Rlblid, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRelabeledProductsListMetadata.PropertyNames.Rlblid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRelabeledProductsListMetadata.ColumnNames.Rlbldesc, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRelabeledProductsListMetadata.PropertyNames.Rlbldesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRelabeledProductsListMetadata.ColumnNames.Productid, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRelabeledProductsListMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRelabeledProductsListMetadata.ColumnNames.Productdesc, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRelabeledProductsListMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRelabeledProductsListMetadata.ColumnNames.Kitid, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRelabeledProductsListMetadata.PropertyNames.Kitid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRelabeledProductsListMetadata.ColumnNames.Stdlaborhrs, 6, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRelabeledProductsListMetadata.PropertyNames.Stdlaborhrs
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRelabeledProductsListMetadata.ColumnNames.Rlblcontainer, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRelabeledProductsListMetadata.PropertyNames.Rlblcontainer
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRelabeledProductsListMetadata.ColumnNames.Container, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRelabeledProductsListMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewRelabeledProductsListMetadata
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
			 Public Const Fulfillmentplanid As String = "FULFILLMENTPLANID"
			 Public Const Rlblid As String = "RLBLID"
			 Public Const Rlbldesc As String = "RLBLDESC"
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Productdesc As String = "PRODUCTDESC"
			 Public Const Kitid As String = "KITID"
			 Public Const Stdlaborhrs As String = "STDLABORHRS"
			 Public Const Rlblcontainer As String = "RLBLCONTAINER"
			 Public Const Container As String = "CONTAINER"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Fulfillmentplanid As String = "Fulfillmentplanid"
			 Public Const Rlblid As String = "Rlblid"
			 Public Const Rlbldesc As String = "Rlbldesc"
			 Public Const Productid As String = "Productid"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const Kitid As String = "Kitid"
			 Public Const Stdlaborhrs As String = "Stdlaborhrs"
			 Public Const Rlblcontainer As String = "Rlblcontainer"
			 Public Const Container As String = "Container"
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
            SyncLock GetType(ViewRelabeledProductsListMetadata)
			
				If ViewRelabeledProductsListMetadata.mapDelegates Is Nothing Then
					ViewRelabeledProductsListMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewRelabeledProductsListMetadata._meta Is Nothing Then
                    ViewRelabeledProductsListMetadata._meta = New ViewRelabeledProductsListMetadata()
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
				

				meta.AddTypeMap("Fulfillmentplanid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Rlblid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Rlbldesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Productid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Kitid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Stdlaborhrs", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Rlblcontainer", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewRelabeledProductsList"
				meta.Destination = "viewRelabeledProductsList"
				
				meta.spInsert = "proc_viewRelabeledProductsListInsert"
				meta.spUpdate = "proc_viewRelabeledProductsListUpdate"
				meta.spDelete = "proc_viewRelabeledProductsListDelete"
				meta.spLoadAll = "proc_viewRelabeledProductsListLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewRelabeledProductsListLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewRelabeledProductsListMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
