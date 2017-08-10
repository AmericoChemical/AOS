'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 4/7/2017 3:25:37 PM
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
	MustInherit Public Class esViewProductBuyersListCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewProductBuyersListCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewProductBuyersListQuery)
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
            Me.InitQuery(CType(query, esViewProductBuyersListQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewProductBuyersList) As ViewProductBuyersList
			Return CType(MyBase.DetachEntity(entity), ViewProductBuyersList)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewProductBuyersList) As ViewProductBuyersList
			Return CType(MyBase.AttachEntity(entity), ViewProductBuyersList)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewProductBuyersListCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewProductBuyersList
            Get
                Return TryCast(MyBase.Item(index), ViewProductBuyersList)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewProductBuyersList)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewProductBuyersList	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewProductBuyersListQuery
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
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Productdesc"
							Me.str.Productdesc = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "Custid"
							Me.str.Custid = CType(value, string)
												
						Case "Volumeprice"
							Me.str.Volumeprice = CType(value, string)
												
						Case "Volumeuom"
							Me.str.Volumeuom = CType(value, string)
												
						Case "Weightprice"
							Me.str.Weightprice = CType(value, string)
												
						Case "Weightuom"
							Me.str.Weightuom = CType(value, string)
												
						Case "Priceliststatus"
							Me.str.Priceliststatus = CType(value, string)
												
						Case "Custname"
							Me.str.Custname = CType(value, string)
												
						Case "Lastpurchased"
							Me.str.Lastpurchased = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Custid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Custid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Volumeprice"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Volumeprice = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Weightprice"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Weightprice = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Lastpurchased"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Lastpurchased = CType(value, Nullable(Of System.DateTime))
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
		' Maps to viewProductBuyersList.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductBuyersListMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductBuyersListMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductBuyersList.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewProductBuyersListMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductBuyersListMetadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductBuyersList.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewProductBuyersListMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductBuyersListMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductBuyersList.CUSTID
		' </summary>
		Public Overridable Property Custid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductBuyersListMetadata.ColumnNames.Custid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductBuyersListMetadata.ColumnNames.Custid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductBuyersList.VOLUMEPRICE
		' </summary>
		Public Overridable Property Volumeprice As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewProductBuyersListMetadata.ColumnNames.Volumeprice)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewProductBuyersListMetadata.ColumnNames.Volumeprice, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductBuyersList.VOLUMEUOM
		' </summary>
		Public Overridable Property Volumeuom As System.String
			Get
				Return MyBase.GetSystemString(ViewProductBuyersListMetadata.ColumnNames.Volumeuom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductBuyersListMetadata.ColumnNames.Volumeuom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductBuyersList.WEIGHTPRICE
		' </summary>
		Public Overridable Property Weightprice As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewProductBuyersListMetadata.ColumnNames.Weightprice)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewProductBuyersListMetadata.ColumnNames.Weightprice, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductBuyersList.WEIGHTUOM
		' </summary>
		Public Overridable Property Weightuom As System.String
			Get
				Return MyBase.GetSystemString(ViewProductBuyersListMetadata.ColumnNames.Weightuom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductBuyersListMetadata.ColumnNames.Weightuom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductBuyersList.PRICELISTSTATUS
		' </summary>
		Public Overridable Property Priceliststatus As System.String
			Get
				Return MyBase.GetSystemString(ViewProductBuyersListMetadata.ColumnNames.Priceliststatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductBuyersListMetadata.ColumnNames.Priceliststatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductBuyersList.CUSTNAME
		' </summary>
		Public Overridable Property Custname As System.String
			Get
				Return MyBase.GetSystemString(ViewProductBuyersListMetadata.ColumnNames.Custname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductBuyersListMetadata.ColumnNames.Custname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductBuyersList.LASTPURCHASED
		' </summary>
		Public Overridable Property Lastpurchased As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewProductBuyersListMetadata.ColumnNames.Lastpurchased)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewProductBuyersListMetadata.ColumnNames.Lastpurchased, value)
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
		
			Public Sub New(ByVal entity As esViewProductBuyersList)
				Me.entity = entity
			End Sub				
		
	
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
		  	
			Public Property Custid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Custid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Custid = Nothing
					Else
						entity.Custid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Volumeprice As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Volumeprice
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Volumeprice = Nothing
					Else
						entity.Volumeprice = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Volumeuom As System.String 
				Get
					Dim data_ As System.String = entity.Volumeuom
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Volumeuom = Nothing
					Else
						entity.Volumeuom = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Weightprice As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Weightprice
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Weightprice = Nothing
					Else
						entity.Weightprice = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Weightuom As System.String 
				Get
					Dim data_ As System.String = entity.Weightuom
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Weightuom = Nothing
					Else
						entity.Weightuom = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Priceliststatus As System.String 
				Get
					Dim data_ As System.String = entity.Priceliststatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Priceliststatus = Nothing
					Else
						entity.Priceliststatus = Convert.ToString(Value)
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
		  	
			Public Property Lastpurchased As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Lastpurchased
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Lastpurchased = Nothing
					Else
						entity.Lastpurchased = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewProductBuyersList
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewProductBuyersListQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewProductBuyersList can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewProductBuyersListQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewProductBuyersListMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductBuyersListMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductBuyersListMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductBuyersListMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Custid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductBuyersListMetadata.ColumnNames.Custid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Volumeprice As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductBuyersListMetadata.ColumnNames.Volumeprice, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Volumeuom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductBuyersListMetadata.ColumnNames.Volumeuom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Weightprice As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductBuyersListMetadata.ColumnNames.Weightprice, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Weightuom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductBuyersListMetadata.ColumnNames.Weightuom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Priceliststatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductBuyersListMetadata.ColumnNames.Priceliststatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Custname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductBuyersListMetadata.ColumnNames.Custname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Lastpurchased As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductBuyersListMetadata.ColumnNames.Lastpurchased, esSystemType.DateTime)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewProductBuyersListCollection")> _
	Partial Public Class ViewProductBuyersListCollection
		Inherits esViewProductBuyersListCollection
		Implements IEnumerable(Of ViewProductBuyersList)
		
        Public Shared Widening Operator CType(ByVal coll As ViewProductBuyersListCollection) As List(Of ViewProductBuyersList)
            Dim list As List(Of ViewProductBuyersList) = New List(Of ViewProductBuyersList)
            Dim emp As ViewProductBuyersList

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewProductBuyersListMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewProductBuyersListQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewProductBuyersList(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewProductBuyersList()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewProductBuyersListQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewProductBuyersListQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewProductBuyersListQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewProductBuyersList 
			Return CType(MyBase.AddNewEntity(), ViewProductBuyersList)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewProductBuyersList) Implements IEnumerable(Of ViewProductBuyersList).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewProductBuyersList)(Me)
        End Function
		
		Private _query As ViewProductBuyersListQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewProductBuyersList' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewProductBuyersList ()")> _
	<Serializable> _
	Partial Public Class ViewProductBuyersList 
		Inherits esViewProductBuyersList

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewProductBuyersListMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewProductBuyersListQuery

			If Me._query Is Nothing Then
				Me._query = New ViewProductBuyersListQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewProductBuyersListQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewProductBuyersListQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewProductBuyersListQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewProductBuyersListQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewProductBuyersListQuery
		inherits esViewProductBuyersListQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewProductBuyersListQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewProductBuyersListMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewProductBuyersListMetadata.ColumnNames.Productid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductBuyersListMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductBuyersListMetadata.ColumnNames.Productdesc, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductBuyersListMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductBuyersListMetadata.ColumnNames.Container, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductBuyersListMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductBuyersListMetadata.ColumnNames.Custid, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductBuyersListMetadata.PropertyNames.Custid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductBuyersListMetadata.ColumnNames.Volumeprice, 4, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewProductBuyersListMetadata.PropertyNames.Volumeprice
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductBuyersListMetadata.ColumnNames.Volumeuom, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductBuyersListMetadata.PropertyNames.Volumeuom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductBuyersListMetadata.ColumnNames.Weightprice, 6, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewProductBuyersListMetadata.PropertyNames.Weightprice
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductBuyersListMetadata.ColumnNames.Weightuom, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductBuyersListMetadata.PropertyNames.Weightuom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductBuyersListMetadata.ColumnNames.Priceliststatus, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductBuyersListMetadata.PropertyNames.Priceliststatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductBuyersListMetadata.ColumnNames.Custname, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductBuyersListMetadata.PropertyNames.Custname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductBuyersListMetadata.ColumnNames.Lastpurchased, 10, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewProductBuyersListMetadata.PropertyNames.Lastpurchased
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewProductBuyersListMetadata
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
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Productdesc As String = "PRODUCTDESC"
			 Public Const Container As String = "CONTAINER"
			 Public Const Custid As String = "CUSTID"
			 Public Const Volumeprice As String = "VOLUMEPRICE"
			 Public Const Volumeuom As String = "VOLUMEUOM"
			 Public Const Weightprice As String = "WEIGHTPRICE"
			 Public Const Weightuom As String = "WEIGHTUOM"
			 Public Const Priceliststatus As String = "PRICELISTSTATUS"
			 Public Const Custname As String = "CUSTNAME"
			 Public Const Lastpurchased As String = "LASTPURCHASED"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Productid As String = "Productid"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const Container As String = "Container"
			 Public Const Custid As String = "Custid"
			 Public Const Volumeprice As String = "Volumeprice"
			 Public Const Volumeuom As String = "Volumeuom"
			 Public Const Weightprice As String = "Weightprice"
			 Public Const Weightuom As String = "Weightuom"
			 Public Const Priceliststatus As String = "Priceliststatus"
			 Public Const Custname As String = "Custname"
			 Public Const Lastpurchased As String = "Lastpurchased"
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
            SyncLock GetType(ViewProductBuyersListMetadata)
			
				If ViewProductBuyersListMetadata.mapDelegates Is Nothing Then
					ViewProductBuyersListMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewProductBuyersListMetadata._meta Is Nothing Then
                    ViewProductBuyersListMetadata._meta = New ViewProductBuyersListMetadata()
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
				

				meta.AddTypeMap("Productid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Custid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Volumeprice", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Volumeuom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Weightprice", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Weightuom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Priceliststatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Custname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Lastpurchased", new esTypeMap("datetime", "System.DateTime"))			
				
				
				 
				meta.Source = "viewProductBuyersList"
				meta.Destination = "viewProductBuyersList"
				
				meta.spInsert = "proc_viewProductBuyersListInsert"
				meta.spUpdate = "proc_viewProductBuyersListUpdate"
				meta.spDelete = "proc_viewProductBuyersListDelete"
				meta.spLoadAll = "proc_viewProductBuyersListLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewProductBuyersListLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewProductBuyersListMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
