'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 10/18/2018 12:05:09 PM
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
	MustInherit Public Class esViewProductFulfillmentCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewProductFulfillmentCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewProductFulfillmentQuery)
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
            Me.InitQuery(CType(query, esViewProductFulfillmentQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewProductFulfillment) As ViewProductFulfillment
			Return CType(MyBase.DetachEntity(entity), ViewProductFulfillment)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewProductFulfillment) As ViewProductFulfillment
			Return CType(MyBase.AttachEntity(entity), ViewProductFulfillment)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewProductFulfillmentCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewProductFulfillment
            Get
                Return TryCast(MyBase.Item(index), ViewProductFulfillment)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewProductFulfillment)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewProductFulfillment	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewProductFulfillmentQuery
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
												
						Case "Fulfillmenttype"
							Me.str.Fulfillmenttype = CType(value, string)
												
						Case "Priority"
							Me.str.Priority = CType(value, string)
												
						Case "Associatedproductid"
							Me.str.Associatedproductid = CType(value, string)
												
						Case "Associatedproduct"
							Me.str.Associatedproduct = CType(value, string)
												
						Case "Fulfillmentplanid"
							Me.str.Fulfillmentplanid = CType(value, string)
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Kitid"
							Me.str.Kitid = CType(value, string)
												
						Case "Stdlaborhrs"
							Me.str.Stdlaborhrs = CType(value, string)
												
						Case "Associatedproductcontainer"
							Me.str.Associatedproductcontainer = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Priority"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Priority = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Associatedproductid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Associatedproductid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Fulfillmentplanid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Fulfillmentplanid = CType(value, Nullable(Of System.Int32))
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
		' Maps to viewProductFulfillment.FULFILLMENTTYPE
		' </summary>
		Public Overridable Property Fulfillmenttype As System.String
			Get
				Return MyBase.GetSystemString(ViewProductFulfillmentMetadata.ColumnNames.Fulfillmenttype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductFulfillmentMetadata.ColumnNames.Fulfillmenttype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductFulfillment.PRIORITY
		' </summary>
		Public Overridable Property Priority As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductFulfillmentMetadata.ColumnNames.Priority)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductFulfillmentMetadata.ColumnNames.Priority, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductFulfillment.ASSOCIATEDPRODUCTID
		' </summary>
		Public Overridable Property Associatedproductid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductFulfillmentMetadata.ColumnNames.Associatedproductid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductFulfillmentMetadata.ColumnNames.Associatedproductid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductFulfillment.ASSOCIATEDPRODUCT
		' </summary>
		Public Overridable Property Associatedproduct As System.String
			Get
				Return MyBase.GetSystemString(ViewProductFulfillmentMetadata.ColumnNames.Associatedproduct)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductFulfillmentMetadata.ColumnNames.Associatedproduct, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductFulfillment.FULFILLMENTPLANID
		' </summary>
		Public Overridable Property Fulfillmentplanid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductFulfillmentMetadata.ColumnNames.Fulfillmentplanid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductFulfillmentMetadata.ColumnNames.Fulfillmentplanid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductFulfillment.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductFulfillmentMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductFulfillmentMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductFulfillment.KITID
		' </summary>
		Public Overridable Property Kitid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductFulfillmentMetadata.ColumnNames.Kitid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductFulfillmentMetadata.ColumnNames.Kitid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductFulfillment.STDLABORHRS
		' </summary>
		Public Overridable Property Stdlaborhrs As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewProductFulfillmentMetadata.ColumnNames.Stdlaborhrs)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewProductFulfillmentMetadata.ColumnNames.Stdlaborhrs, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductFulfillment.ASSOCIATEDPRODUCTCONTAINER
		' </summary>
		Public Overridable Property Associatedproductcontainer As System.String
			Get
				Return MyBase.GetSystemString(ViewProductFulfillmentMetadata.ColumnNames.Associatedproductcontainer)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductFulfillmentMetadata.ColumnNames.Associatedproductcontainer, value)
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
		
			Public Sub New(ByVal entity As esViewProductFulfillment)
				Me.entity = entity
			End Sub				
		
	
			Public Property Fulfillmenttype As System.String 
				Get
					Dim data_ As System.String = entity.Fulfillmenttype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Fulfillmenttype = Nothing
					Else
						entity.Fulfillmenttype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Priority As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Priority
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Priority = Nothing
					Else
						entity.Priority = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Associatedproductid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Associatedproductid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Associatedproductid = Nothing
					Else
						entity.Associatedproductid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Associatedproduct As System.String 
				Get
					Dim data_ As System.String = entity.Associatedproduct
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Associatedproduct = Nothing
					Else
						entity.Associatedproduct = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
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
		  	
			Public Property Associatedproductcontainer As System.String 
				Get
					Dim data_ As System.String = entity.Associatedproductcontainer
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Associatedproductcontainer = Nothing
					Else
						entity.Associatedproductcontainer = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewProductFulfillment
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewProductFulfillmentQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewProductFulfillment can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewProductFulfillmentQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewProductFulfillmentMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Fulfillmenttype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductFulfillmentMetadata.ColumnNames.Fulfillmenttype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Priority As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductFulfillmentMetadata.ColumnNames.Priority, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Associatedproductid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductFulfillmentMetadata.ColumnNames.Associatedproductid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Associatedproduct As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductFulfillmentMetadata.ColumnNames.Associatedproduct, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Fulfillmentplanid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductFulfillmentMetadata.ColumnNames.Fulfillmentplanid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductFulfillmentMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Kitid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductFulfillmentMetadata.ColumnNames.Kitid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Stdlaborhrs As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductFulfillmentMetadata.ColumnNames.Stdlaborhrs, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Associatedproductcontainer As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductFulfillmentMetadata.ColumnNames.Associatedproductcontainer, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewProductFulfillmentCollection")> _
	Partial Public Class ViewProductFulfillmentCollection
		Inherits esViewProductFulfillmentCollection
		Implements IEnumerable(Of ViewProductFulfillment)
		
        Public Shared Widening Operator CType(ByVal coll As ViewProductFulfillmentCollection) As List(Of ViewProductFulfillment)
            Dim list As List(Of ViewProductFulfillment) = New List(Of ViewProductFulfillment)
            Dim emp As ViewProductFulfillment

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewProductFulfillmentMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewProductFulfillmentQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewProductFulfillment(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewProductFulfillment()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewProductFulfillmentQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewProductFulfillmentQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewProductFulfillmentQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewProductFulfillment 
			Return CType(MyBase.AddNewEntity(), ViewProductFulfillment)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewProductFulfillment) Implements IEnumerable(Of ViewProductFulfillment).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewProductFulfillment)(Me)
        End Function
		
		Private _query As ViewProductFulfillmentQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewProductFulfillment' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewProductFulfillment ()")> _
	<Serializable> _
	Partial Public Class ViewProductFulfillment 
		Inherits esViewProductFulfillment

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewProductFulfillmentMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewProductFulfillmentQuery

			If Me._query Is Nothing Then
				Me._query = New ViewProductFulfillmentQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewProductFulfillmentQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewProductFulfillmentQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewProductFulfillmentQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewProductFulfillmentQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewProductFulfillmentQuery
		inherits esViewProductFulfillmentQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewProductFulfillmentQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewProductFulfillmentMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewProductFulfillmentMetadata.ColumnNames.Fulfillmenttype, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductFulfillmentMetadata.PropertyNames.Fulfillmenttype
			c.CharacterMaxLength = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductFulfillmentMetadata.ColumnNames.Priority, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductFulfillmentMetadata.PropertyNames.Priority
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductFulfillmentMetadata.ColumnNames.Associatedproductid, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductFulfillmentMetadata.PropertyNames.Associatedproductid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductFulfillmentMetadata.ColumnNames.Associatedproduct, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductFulfillmentMetadata.PropertyNames.Associatedproduct
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductFulfillmentMetadata.ColumnNames.Fulfillmentplanid, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductFulfillmentMetadata.PropertyNames.Fulfillmentplanid
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductFulfillmentMetadata.ColumnNames.Productid, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductFulfillmentMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductFulfillmentMetadata.ColumnNames.Kitid, 6, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductFulfillmentMetadata.PropertyNames.Kitid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductFulfillmentMetadata.ColumnNames.Stdlaborhrs, 7, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewProductFulfillmentMetadata.PropertyNames.Stdlaborhrs
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductFulfillmentMetadata.ColumnNames.Associatedproductcontainer, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductFulfillmentMetadata.PropertyNames.Associatedproductcontainer
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewProductFulfillmentMetadata
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
			 Public Const Fulfillmenttype As String = "FULFILLMENTTYPE"
			 Public Const Priority As String = "PRIORITY"
			 Public Const Associatedproductid As String = "ASSOCIATEDPRODUCTID"
			 Public Const Associatedproduct As String = "ASSOCIATEDPRODUCT"
			 Public Const Fulfillmentplanid As String = "FULFILLMENTPLANID"
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Kitid As String = "KITID"
			 Public Const Stdlaborhrs As String = "STDLABORHRS"
			 Public Const Associatedproductcontainer As String = "ASSOCIATEDPRODUCTCONTAINER"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Fulfillmenttype As String = "Fulfillmenttype"
			 Public Const Priority As String = "Priority"
			 Public Const Associatedproductid As String = "Associatedproductid"
			 Public Const Associatedproduct As String = "Associatedproduct"
			 Public Const Fulfillmentplanid As String = "Fulfillmentplanid"
			 Public Const Productid As String = "Productid"
			 Public Const Kitid As String = "Kitid"
			 Public Const Stdlaborhrs As String = "Stdlaborhrs"
			 Public Const Associatedproductcontainer As String = "Associatedproductcontainer"
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
            SyncLock GetType(ViewProductFulfillmentMetadata)
			
				If ViewProductFulfillmentMetadata.mapDelegates Is Nothing Then
					ViewProductFulfillmentMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewProductFulfillmentMetadata._meta Is Nothing Then
                    ViewProductFulfillmentMetadata._meta = New ViewProductFulfillmentMetadata()
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
				

				meta.AddTypeMap("Fulfillmenttype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Priority", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Associatedproductid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Associatedproduct", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Fulfillmentplanid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Kitid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Stdlaborhrs", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Associatedproductcontainer", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewProductFulfillment"
				meta.Destination = "viewProductFulfillment"
				
				meta.spInsert = "proc_viewProductFulfillmentInsert"
				meta.spUpdate = "proc_viewProductFulfillmentUpdate"
				meta.spDelete = "proc_viewProductFulfillmentDelete"
				meta.spLoadAll = "proc_viewProductFulfillmentLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewProductFulfillmentLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewProductFulfillmentMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
