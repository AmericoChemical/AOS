'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 7/24/2017 8:30:35 AM
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
	MustInherit Public Class esViewAPISProductsCostChangesCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewAPISProductsCostChangesCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewAPISProductsCostChangesQuery)
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
            Me.InitQuery(CType(query, esViewAPISProductsCostChangesQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewAPISProductsCostChanges) As ViewAPISProductsCostChanges
			Return CType(MyBase.DetachEntity(entity), ViewAPISProductsCostChanges)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewAPISProductsCostChanges) As ViewAPISProductsCostChanges
			Return CType(MyBase.AttachEntity(entity), ViewAPISProductsCostChanges)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewAPISProductsCostChangesCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewAPISProductsCostChanges
            Get
                Return TryCast(MyBase.Item(index), ViewAPISProductsCostChanges)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewAPISProductsCostChanges)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewAPISProductsCostChanges	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewAPISProductsCostChangesQuery
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
												
						Case "Oldvolcost"
							Me.str.Oldvolcost = CType(value, string)
												
						Case "Volumeunits"
							Me.str.Volumeunits = CType(value, string)
												
						Case "Oldwgtcost"
							Me.str.Oldwgtcost = CType(value, string)
												
						Case "Weightunits"
							Me.str.Weightunits = CType(value, string)
												
						Case "Newwgtcost"
							Me.str.Newwgtcost = CType(value, string)
												
						Case "Newvolcost"
							Me.str.Newvolcost = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Oldvolcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Oldvolcost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Volumeunits"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Volumeunits = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Oldwgtcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Oldwgtcost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Weightunits"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Weightunits = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Newwgtcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Newwgtcost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Newvolcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Newvolcost = CType(value, Nullable(Of System.Decimal))
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
		' Maps to viewAPISProductsCostChanges.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewAPISProductsCostChangesMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewAPISProductsCostChangesMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAPISProductsCostChanges.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewAPISProductsCostChangesMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewAPISProductsCostChangesMetadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAPISProductsCostChanges.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewAPISProductsCostChangesMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewAPISProductsCostChangesMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAPISProductsCostChanges.OLDVOLCOST
		' </summary>
		Public Overridable Property Oldvolcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewAPISProductsCostChangesMetadata.ColumnNames.Oldvolcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewAPISProductsCostChangesMetadata.ColumnNames.Oldvolcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAPISProductsCostChanges.VOLUMEUNITS
		' </summary>
		Public Overridable Property Volumeunits As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewAPISProductsCostChangesMetadata.ColumnNames.Volumeunits)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewAPISProductsCostChangesMetadata.ColumnNames.Volumeunits, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAPISProductsCostChanges.OLDWGTCOST
		' </summary>
		Public Overridable Property Oldwgtcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewAPISProductsCostChangesMetadata.ColumnNames.Oldwgtcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewAPISProductsCostChangesMetadata.ColumnNames.Oldwgtcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAPISProductsCostChanges.WEIGHTUNITS
		' </summary>
		Public Overridable Property Weightunits As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewAPISProductsCostChangesMetadata.ColumnNames.Weightunits)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewAPISProductsCostChangesMetadata.ColumnNames.Weightunits, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAPISProductsCostChanges.NEWWGTCOST
		' </summary>
		Public Overridable Property Newwgtcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewAPISProductsCostChangesMetadata.ColumnNames.Newwgtcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewAPISProductsCostChangesMetadata.ColumnNames.Newwgtcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAPISProductsCostChanges.NEWVOLCOST
		' </summary>
		Public Overridable Property Newvolcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewAPISProductsCostChangesMetadata.ColumnNames.Newvolcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewAPISProductsCostChangesMetadata.ColumnNames.Newvolcost, value)
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
		
			Public Sub New(ByVal entity As esViewAPISProductsCostChanges)
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
		  	
			Public Property Oldvolcost As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Oldvolcost
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Oldvolcost = Nothing
					Else
						entity.Oldvolcost = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Volumeunits As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Volumeunits
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Volumeunits = Nothing
					Else
						entity.Volumeunits = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Oldwgtcost As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Oldwgtcost
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Oldwgtcost = Nothing
					Else
						entity.Oldwgtcost = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Weightunits As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Weightunits
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Weightunits = Nothing
					Else
						entity.Weightunits = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Newwgtcost As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Newwgtcost
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Newwgtcost = Nothing
					Else
						entity.Newwgtcost = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Newvolcost As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Newvolcost
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Newvolcost = Nothing
					Else
						entity.Newvolcost = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewAPISProductsCostChanges
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewAPISProductsCostChangesQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewAPISProductsCostChanges can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewAPISProductsCostChangesQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewAPISProductsCostChangesMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAPISProductsCostChangesMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAPISProductsCostChangesMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAPISProductsCostChangesMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Oldvolcost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAPISProductsCostChangesMetadata.ColumnNames.Oldvolcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Volumeunits As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAPISProductsCostChangesMetadata.ColumnNames.Volumeunits, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Oldwgtcost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAPISProductsCostChangesMetadata.ColumnNames.Oldwgtcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Weightunits As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAPISProductsCostChangesMetadata.ColumnNames.Weightunits, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Newwgtcost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAPISProductsCostChangesMetadata.ColumnNames.Newwgtcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Newvolcost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAPISProductsCostChangesMetadata.ColumnNames.Newvolcost, esSystemType.Decimal)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewAPISProductsCostChangesCollection")> _
	Partial Public Class ViewAPISProductsCostChangesCollection
		Inherits esViewAPISProductsCostChangesCollection
		Implements IEnumerable(Of ViewAPISProductsCostChanges)
		
        Public Shared Widening Operator CType(ByVal coll As ViewAPISProductsCostChangesCollection) As List(Of ViewAPISProductsCostChanges)
            Dim list As List(Of ViewAPISProductsCostChanges) = New List(Of ViewAPISProductsCostChanges)
            Dim emp As ViewAPISProductsCostChanges

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewAPISProductsCostChangesMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewAPISProductsCostChangesQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewAPISProductsCostChanges(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewAPISProductsCostChanges()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewAPISProductsCostChangesQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewAPISProductsCostChangesQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewAPISProductsCostChangesQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewAPISProductsCostChanges 
			Return CType(MyBase.AddNewEntity(), ViewAPISProductsCostChanges)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewAPISProductsCostChanges) Implements IEnumerable(Of ViewAPISProductsCostChanges).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewAPISProductsCostChanges)(Me)
        End Function
		
		Private _query As ViewAPISProductsCostChangesQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewAPISProductsCostChanges' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewAPISProductsCostChanges ()")> _
	<Serializable> _
	Partial Public Class ViewAPISProductsCostChanges 
		Inherits esViewAPISProductsCostChanges

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewAPISProductsCostChangesMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewAPISProductsCostChangesQuery

			If Me._query Is Nothing Then
				Me._query = New ViewAPISProductsCostChangesQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewAPISProductsCostChangesQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewAPISProductsCostChangesQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewAPISProductsCostChangesQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewAPISProductsCostChangesQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewAPISProductsCostChangesQuery
		inherits esViewAPISProductsCostChangesQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewAPISProductsCostChangesQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewAPISProductsCostChangesMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewAPISProductsCostChangesMetadata.ColumnNames.Productid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewAPISProductsCostChangesMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAPISProductsCostChangesMetadata.ColumnNames.Productdesc, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewAPISProductsCostChangesMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAPISProductsCostChangesMetadata.ColumnNames.Container, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewAPISProductsCostChangesMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAPISProductsCostChangesMetadata.ColumnNames.Oldvolcost, 3, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewAPISProductsCostChangesMetadata.PropertyNames.Oldvolcost
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAPISProductsCostChangesMetadata.ColumnNames.Volumeunits, 4, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewAPISProductsCostChangesMetadata.PropertyNames.Volumeunits
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAPISProductsCostChangesMetadata.ColumnNames.Oldwgtcost, 5, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewAPISProductsCostChangesMetadata.PropertyNames.Oldwgtcost
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAPISProductsCostChangesMetadata.ColumnNames.Weightunits, 6, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewAPISProductsCostChangesMetadata.PropertyNames.Weightunits
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAPISProductsCostChangesMetadata.ColumnNames.Newwgtcost, 7, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewAPISProductsCostChangesMetadata.PropertyNames.Newwgtcost
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAPISProductsCostChangesMetadata.ColumnNames.Newvolcost, 8, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewAPISProductsCostChangesMetadata.PropertyNames.Newvolcost
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewAPISProductsCostChangesMetadata
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
			 Public Const Oldvolcost As String = "OLDVOLCOST"
			 Public Const Volumeunits As String = "VOLUMEUNITS"
			 Public Const Oldwgtcost As String = "OLDWGTCOST"
			 Public Const Weightunits As String = "WEIGHTUNITS"
			 Public Const Newwgtcost As String = "NEWWGTCOST"
			 Public Const Newvolcost As String = "NEWVOLCOST"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Productid As String = "Productid"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const Container As String = "Container"
			 Public Const Oldvolcost As String = "Oldvolcost"
			 Public Const Volumeunits As String = "Volumeunits"
			 Public Const Oldwgtcost As String = "Oldwgtcost"
			 Public Const Weightunits As String = "Weightunits"
			 Public Const Newwgtcost As String = "Newwgtcost"
			 Public Const Newvolcost As String = "Newvolcost"
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
            SyncLock GetType(ViewAPISProductsCostChangesMetadata)
			
				If ViewAPISProductsCostChangesMetadata.mapDelegates Is Nothing Then
					ViewAPISProductsCostChangesMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewAPISProductsCostChangesMetadata._meta Is Nothing Then
                    ViewAPISProductsCostChangesMetadata._meta = New ViewAPISProductsCostChangesMetadata()
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
				meta.AddTypeMap("Oldvolcost", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Volumeunits", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Oldwgtcost", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Weightunits", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Newwgtcost", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Newvolcost", new esTypeMap("decimal", "System.Decimal"))			
				
				
				 
				meta.Source = "viewAPISProductsCostChanges"
				meta.Destination = "viewAPISProductsCostChanges"
				
				meta.spInsert = "proc_viewAPISProductsCostChangesInsert"
				meta.spUpdate = "proc_viewAPISProductsCostChangesUpdate"
				meta.spDelete = "proc_viewAPISProductsCostChangesDelete"
				meta.spLoadAll = "proc_viewAPISProductsCostChangesLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewAPISProductsCostChangesLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewAPISProductsCostChangesMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
