'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 7/25/2017 3:26:34 PM
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
	MustInherit Public Class esViewMaterialAvailableContainersCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewMaterialAvailableContainersCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewMaterialAvailableContainersQuery)
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
            Me.InitQuery(CType(query, esViewMaterialAvailableContainersQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewMaterialAvailableContainers) As ViewMaterialAvailableContainers
			Return CType(MyBase.DetachEntity(entity), ViewMaterialAvailableContainers)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewMaterialAvailableContainers) As ViewMaterialAvailableContainers
			Return CType(MyBase.AttachEntity(entity), ViewMaterialAvailableContainers)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewMaterialAvailableContainersCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewMaterialAvailableContainers
            Get
                Return TryCast(MyBase.Item(index), ViewMaterialAvailableContainers)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewMaterialAvailableContainers)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewMaterialAvailableContainers	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewMaterialAvailableContainersQuery
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
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "Priority"
							Me.str.Priority = CType(value, string)
												
						Case "Qavail"
							Me.str.Qavail = CType(value, string)
												
						Case "Qpend"
							Me.str.Qpend = CType(value, string)
												
						Case "Qprod"
							Me.str.Qprod = CType(value, string)
												
						Case "Qtest"
							Me.str.Qtest = CType(value, string)
												
						Case "Qhold"
							Me.str.Qhold = CType(value, string)
					
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
						
						Case "Priority"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Priority = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Qavail"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Qavail = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Qpend"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Qpend = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Qprod"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Qprod = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Qtest"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Qtest = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Qhold"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Qhold = CType(value, Nullable(Of System.Int32))
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
		' Maps to viewMaterialAvailableContainers.MATERIALID
		' </summary>
		Public Overridable Property Materialid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewMaterialAvailableContainersMetadata.ColumnNames.Materialid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewMaterialAvailableContainersMetadata.ColumnNames.Materialid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewMaterialAvailableContainers.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewMaterialAvailableContainersMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewMaterialAvailableContainersMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewMaterialAvailableContainers.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewMaterialAvailableContainersMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewMaterialAvailableContainersMetadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewMaterialAvailableContainers.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewMaterialAvailableContainersMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewMaterialAvailableContainersMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewMaterialAvailableContainers.PRIORITY
		' </summary>
		Public Overridable Property Priority As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewMaterialAvailableContainersMetadata.ColumnNames.Priority)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewMaterialAvailableContainersMetadata.ColumnNames.Priority, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewMaterialAvailableContainers.QAVAIL
		' </summary>
		Public Overridable Property Qavail As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewMaterialAvailableContainersMetadata.ColumnNames.Qavail)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewMaterialAvailableContainersMetadata.ColumnNames.Qavail, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewMaterialAvailableContainers.QPEND
		' </summary>
		Public Overridable Property Qpend As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewMaterialAvailableContainersMetadata.ColumnNames.Qpend)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewMaterialAvailableContainersMetadata.ColumnNames.Qpend, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewMaterialAvailableContainers.QPROD
		' </summary>
		Public Overridable Property Qprod As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewMaterialAvailableContainersMetadata.ColumnNames.Qprod)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewMaterialAvailableContainersMetadata.ColumnNames.Qprod, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewMaterialAvailableContainers.QTEST
		' </summary>
		Public Overridable Property Qtest As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewMaterialAvailableContainersMetadata.ColumnNames.Qtest)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewMaterialAvailableContainersMetadata.ColumnNames.Qtest, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewMaterialAvailableContainers.QHOLD
		' </summary>
		Public Overridable Property Qhold As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewMaterialAvailableContainersMetadata.ColumnNames.Qhold)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewMaterialAvailableContainersMetadata.ColumnNames.Qhold, value)
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
		
			Public Sub New(ByVal entity As esViewMaterialAvailableContainers)
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
		  	
			Public Property Qavail As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Qavail
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qavail = Nothing
					Else
						entity.Qavail = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Qpend As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Qpend
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qpend = Nothing
					Else
						entity.Qpend = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Qprod As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Qprod
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qprod = Nothing
					Else
						entity.Qprod = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Qtest As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Qtest
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qtest = Nothing
					Else
						entity.Qtest = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Qhold As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Qhold
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qhold = Nothing
					Else
						entity.Qhold = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewMaterialAvailableContainers
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewMaterialAvailableContainersQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewMaterialAvailableContainers can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewMaterialAvailableContainersQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewMaterialAvailableContainersMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Materialid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialAvailableContainersMetadata.ColumnNames.Materialid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialAvailableContainersMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialAvailableContainersMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialAvailableContainersMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Priority As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialAvailableContainersMetadata.ColumnNames.Priority, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Qavail As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialAvailableContainersMetadata.ColumnNames.Qavail, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Qpend As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialAvailableContainersMetadata.ColumnNames.Qpend, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Qprod As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialAvailableContainersMetadata.ColumnNames.Qprod, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Qtest As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialAvailableContainersMetadata.ColumnNames.Qtest, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Qhold As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialAvailableContainersMetadata.ColumnNames.Qhold, esSystemType.Int32)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewMaterialAvailableContainersCollection")> _
	Partial Public Class ViewMaterialAvailableContainersCollection
		Inherits esViewMaterialAvailableContainersCollection
		Implements IEnumerable(Of ViewMaterialAvailableContainers)
		
        Public Shared Widening Operator CType(ByVal coll As ViewMaterialAvailableContainersCollection) As List(Of ViewMaterialAvailableContainers)
            Dim list As List(Of ViewMaterialAvailableContainers) = New List(Of ViewMaterialAvailableContainers)
            Dim emp As ViewMaterialAvailableContainers

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewMaterialAvailableContainersMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewMaterialAvailableContainersQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewMaterialAvailableContainers(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewMaterialAvailableContainers()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewMaterialAvailableContainersQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewMaterialAvailableContainersQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewMaterialAvailableContainersQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewMaterialAvailableContainers 
			Return CType(MyBase.AddNewEntity(), ViewMaterialAvailableContainers)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewMaterialAvailableContainers) Implements IEnumerable(Of ViewMaterialAvailableContainers).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewMaterialAvailableContainers)(Me)
        End Function
		
		Private _query As ViewMaterialAvailableContainersQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewMaterialAvailableContainers' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewMaterialAvailableContainers ()")> _
	<Serializable> _
	Partial Public Class ViewMaterialAvailableContainers 
		Inherits esViewMaterialAvailableContainers

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewMaterialAvailableContainersMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewMaterialAvailableContainersQuery

			If Me._query Is Nothing Then
				Me._query = New ViewMaterialAvailableContainersQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewMaterialAvailableContainersQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewMaterialAvailableContainersQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewMaterialAvailableContainersQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewMaterialAvailableContainersQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewMaterialAvailableContainersQuery
		inherits esViewMaterialAvailableContainersQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewMaterialAvailableContainersQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewMaterialAvailableContainersMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewMaterialAvailableContainersMetadata.ColumnNames.Materialid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewMaterialAvailableContainersMetadata.PropertyNames.Materialid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewMaterialAvailableContainersMetadata.ColumnNames.Productid, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewMaterialAvailableContainersMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewMaterialAvailableContainersMetadata.ColumnNames.Productdesc, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewMaterialAvailableContainersMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewMaterialAvailableContainersMetadata.ColumnNames.Container, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewMaterialAvailableContainersMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewMaterialAvailableContainersMetadata.ColumnNames.Priority, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewMaterialAvailableContainersMetadata.PropertyNames.Priority
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewMaterialAvailableContainersMetadata.ColumnNames.Qavail, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewMaterialAvailableContainersMetadata.PropertyNames.Qavail
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewMaterialAvailableContainersMetadata.ColumnNames.Qpend, 6, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewMaterialAvailableContainersMetadata.PropertyNames.Qpend
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewMaterialAvailableContainersMetadata.ColumnNames.Qprod, 7, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewMaterialAvailableContainersMetadata.PropertyNames.Qprod
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewMaterialAvailableContainersMetadata.ColumnNames.Qtest, 8, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewMaterialAvailableContainersMetadata.PropertyNames.Qtest
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewMaterialAvailableContainersMetadata.ColumnNames.Qhold, 9, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewMaterialAvailableContainersMetadata.PropertyNames.Qhold
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewMaterialAvailableContainersMetadata
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
			 Public Const Container As String = "CONTAINER"
			 Public Const Priority As String = "PRIORITY"
			 Public Const Qavail As String = "QAVAIL"
			 Public Const Qpend As String = "QPEND"
			 Public Const Qprod As String = "QPROD"
			 Public Const Qtest As String = "QTEST"
			 Public Const Qhold As String = "QHOLD"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Materialid As String = "Materialid"
			 Public Const Productid As String = "Productid"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const Container As String = "Container"
			 Public Const Priority As String = "Priority"
			 Public Const Qavail As String = "Qavail"
			 Public Const Qpend As String = "Qpend"
			 Public Const Qprod As String = "Qprod"
			 Public Const Qtest As String = "Qtest"
			 Public Const Qhold As String = "Qhold"
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
            SyncLock GetType(ViewMaterialAvailableContainersMetadata)
			
				If ViewMaterialAvailableContainersMetadata.mapDelegates Is Nothing Then
					ViewMaterialAvailableContainersMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewMaterialAvailableContainersMetadata._meta Is Nothing Then
                    ViewMaterialAvailableContainersMetadata._meta = New ViewMaterialAvailableContainersMetadata()
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
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Priority", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Qavail", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Qpend", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Qprod", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Qtest", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Qhold", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "viewMaterialAvailableContainers"
				meta.Destination = "viewMaterialAvailableContainers"
				
				meta.spInsert = "proc_viewMaterialAvailableContainersInsert"
				meta.spUpdate = "proc_viewMaterialAvailableContainersUpdate"
				meta.spDelete = "proc_viewMaterialAvailableContainersDelete"
				meta.spLoadAll = "proc_viewMaterialAvailableContainersLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewMaterialAvailableContainersLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewMaterialAvailableContainersMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
