'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 5/9/2016 9:32:46 AM
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
	MustInherit Public Class esViewCostingApisMaterialStdCostCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewCostingApisMaterialStdCostCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewCostingApisMaterialStdCostQuery)
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
            Me.InitQuery(CType(query, esViewCostingApisMaterialStdCostQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewCostingApisMaterialStdCost) As ViewCostingApisMaterialStdCost
			Return CType(MyBase.DetachEntity(entity), ViewCostingApisMaterialStdCost)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewCostingApisMaterialStdCost) As ViewCostingApisMaterialStdCost
			Return CType(MyBase.AttachEntity(entity), ViewCostingApisMaterialStdCost)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewCostingApisMaterialStdCostCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewCostingApisMaterialStdCost
            Get
                Return TryCast(MyBase.Item(index), ViewCostingApisMaterialStdCost)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewCostingApisMaterialStdCost)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewCostingApisMaterialStdCost	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewCostingApisMaterialStdCostQuery
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
												
						Case "Materialid"
							Me.str.Materialid = CType(value, string)
												
						Case "Qtyunits"
							Me.str.Qtyunits = CType(value, string)
												
						Case "Weightuom"
							Me.str.Weightuom = CType(value, string)
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Stdunitcost"
							Me.str.Stdunitcost = CType(value, string)
												
						Case "Matcost"
							Me.str.Matcost = CType(value, string)
												
						Case "Productdesc"
							Me.str.Productdesc = CType(value, string)
												
						Case "Materialdesc"
							Me.str.Materialdesc = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Apisnum"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Apisnum = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Materialid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Materialid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Qtyunits"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Qtyunits = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Stdunitcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Stdunitcost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Matcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Matcost = CType(value, Nullable(Of System.Decimal))
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
		' Maps to viewCostingApisMaterialStdCost.APISNUM
		' </summary>
		Public Overridable Property Apisnum As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCostingApisMaterialStdCostMetadata.ColumnNames.Apisnum)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCostingApisMaterialStdCostMetadata.ColumnNames.Apisnum, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCostingApisMaterialStdCost.MATERIALID
		' </summary>
		Public Overridable Property Materialid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCostingApisMaterialStdCostMetadata.ColumnNames.Materialid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCostingApisMaterialStdCostMetadata.ColumnNames.Materialid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCostingApisMaterialStdCost.QTYUNITS
		' </summary>
		Public Overridable Property Qtyunits As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCostingApisMaterialStdCostMetadata.ColumnNames.Qtyunits)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCostingApisMaterialStdCostMetadata.ColumnNames.Qtyunits, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCostingApisMaterialStdCost.WEIGHTUOM
		' </summary>
		Public Overridable Property Weightuom As System.String
			Get
				Return MyBase.GetSystemString(ViewCostingApisMaterialStdCostMetadata.ColumnNames.Weightuom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCostingApisMaterialStdCostMetadata.ColumnNames.Weightuom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCostingApisMaterialStdCost.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCostingApisMaterialStdCostMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCostingApisMaterialStdCostMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCostingApisMaterialStdCost.STDUNITCOST
		' </summary>
		Public Overridable Property Stdunitcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCostingApisMaterialStdCostMetadata.ColumnNames.Stdunitcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCostingApisMaterialStdCostMetadata.ColumnNames.Stdunitcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCostingApisMaterialStdCost.MATCOST
		' </summary>
		Public Overridable Property Matcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCostingApisMaterialStdCostMetadata.ColumnNames.Matcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCostingApisMaterialStdCostMetadata.ColumnNames.Matcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCostingApisMaterialStdCost.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewCostingApisMaterialStdCostMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCostingApisMaterialStdCostMetadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCostingApisMaterialStdCost.MATERIALDESC
		' </summary>
		Public Overridable Property Materialdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewCostingApisMaterialStdCostMetadata.ColumnNames.Materialdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCostingApisMaterialStdCostMetadata.ColumnNames.Materialdesc, value)
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
		
			Public Sub New(ByVal entity As esViewCostingApisMaterialStdCost)
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
		  	
			Public Property Qtyunits As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Qtyunits
					
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
						entity.Qtyunits = Convert.ToDecimal(Value)
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
		  	
			Public Property Stdunitcost As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Stdunitcost
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Stdunitcost = Nothing
					Else
						entity.Stdunitcost = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Matcost As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Matcost
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Matcost = Nothing
					Else
						entity.Matcost = Convert.ToDecimal(Value)
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
		  

			Private entity As esViewCostingApisMaterialStdCost
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewCostingApisMaterialStdCostQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewCostingApisMaterialStdCost can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewCostingApisMaterialStdCostQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCostingApisMaterialStdCostMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Apisnum As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCostingApisMaterialStdCostMetadata.ColumnNames.Apisnum, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Materialid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCostingApisMaterialStdCostMetadata.ColumnNames.Materialid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Qtyunits As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCostingApisMaterialStdCostMetadata.ColumnNames.Qtyunits, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Weightuom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCostingApisMaterialStdCostMetadata.ColumnNames.Weightuom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCostingApisMaterialStdCostMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Stdunitcost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCostingApisMaterialStdCostMetadata.ColumnNames.Stdunitcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Matcost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCostingApisMaterialStdCostMetadata.ColumnNames.Matcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCostingApisMaterialStdCostMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Materialdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCostingApisMaterialStdCostMetadata.ColumnNames.Materialdesc, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewCostingApisMaterialStdCostCollection")> _
	Partial Public Class ViewCostingApisMaterialStdCostCollection
		Inherits esViewCostingApisMaterialStdCostCollection
		Implements IEnumerable(Of ViewCostingApisMaterialStdCost)
		
        Public Shared Widening Operator CType(ByVal coll As ViewCostingApisMaterialStdCostCollection) As List(Of ViewCostingApisMaterialStdCost)
            Dim list As List(Of ViewCostingApisMaterialStdCost) = New List(Of ViewCostingApisMaterialStdCost)
            Dim emp As ViewCostingApisMaterialStdCost

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCostingApisMaterialStdCostMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewCostingApisMaterialStdCostQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewCostingApisMaterialStdCost(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewCostingApisMaterialStdCost()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewCostingApisMaterialStdCostQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewCostingApisMaterialStdCostQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewCostingApisMaterialStdCostQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewCostingApisMaterialStdCost 
			Return CType(MyBase.AddNewEntity(), ViewCostingApisMaterialStdCost)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewCostingApisMaterialStdCost) Implements IEnumerable(Of ViewCostingApisMaterialStdCost).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewCostingApisMaterialStdCost)(Me)
        End Function
		
		Private _query As ViewCostingApisMaterialStdCostQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewCostingApisMaterialStdCost' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewCostingApisMaterialStdCost ()")> _
	<Serializable> _
	Partial Public Class ViewCostingApisMaterialStdCost 
		Inherits esViewCostingApisMaterialStdCost

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewCostingApisMaterialStdCostMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewCostingApisMaterialStdCostQuery

			If Me._query Is Nothing Then
				Me._query = New ViewCostingApisMaterialStdCostQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewCostingApisMaterialStdCostQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewCostingApisMaterialStdCostQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewCostingApisMaterialStdCostQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewCostingApisMaterialStdCostQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewCostingApisMaterialStdCostQuery
		inherits esViewCostingApisMaterialStdCostQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewCostingApisMaterialStdCostQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewCostingApisMaterialStdCostMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCostingApisMaterialStdCostMetadata.ColumnNames.Apisnum, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCostingApisMaterialStdCostMetadata.PropertyNames.Apisnum
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCostingApisMaterialStdCostMetadata.ColumnNames.Materialid, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCostingApisMaterialStdCostMetadata.PropertyNames.Materialid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCostingApisMaterialStdCostMetadata.ColumnNames.Qtyunits, 2, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCostingApisMaterialStdCostMetadata.PropertyNames.Qtyunits
			c.NumericPrecision = 18
			c.NumericScale = 2
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCostingApisMaterialStdCostMetadata.ColumnNames.Weightuom, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCostingApisMaterialStdCostMetadata.PropertyNames.Weightuom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCostingApisMaterialStdCostMetadata.ColumnNames.Productid, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCostingApisMaterialStdCostMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCostingApisMaterialStdCostMetadata.ColumnNames.Stdunitcost, 5, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCostingApisMaterialStdCostMetadata.PropertyNames.Stdunitcost
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCostingApisMaterialStdCostMetadata.ColumnNames.Matcost, 6, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCostingApisMaterialStdCostMetadata.PropertyNames.Matcost
			c.NumericPrecision = 37
			c.NumericScale = 6
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCostingApisMaterialStdCostMetadata.ColumnNames.Productdesc, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCostingApisMaterialStdCostMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCostingApisMaterialStdCostMetadata.ColumnNames.Materialdesc, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCostingApisMaterialStdCostMetadata.PropertyNames.Materialdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewCostingApisMaterialStdCostMetadata
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
			 Public Const Materialid As String = "MATERIALID"
			 Public Const Qtyunits As String = "QTYUNITS"
			 Public Const Weightuom As String = "WEIGHTUOM"
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Stdunitcost As String = "STDUNITCOST"
			 Public Const Matcost As String = "MATCOST"
			 Public Const Productdesc As String = "PRODUCTDESC"
			 Public Const Materialdesc As String = "MATERIALDESC"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Apisnum As String = "Apisnum"
			 Public Const Materialid As String = "Materialid"
			 Public Const Qtyunits As String = "Qtyunits"
			 Public Const Weightuom As String = "Weightuom"
			 Public Const Productid As String = "Productid"
			 Public Const Stdunitcost As String = "Stdunitcost"
			 Public Const Matcost As String = "Matcost"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const Materialdesc As String = "Materialdesc"
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
            SyncLock GetType(ViewCostingApisMaterialStdCostMetadata)
			
				If ViewCostingApisMaterialStdCostMetadata.mapDelegates Is Nothing Then
					ViewCostingApisMaterialStdCostMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewCostingApisMaterialStdCostMetadata._meta Is Nothing Then
                    ViewCostingApisMaterialStdCostMetadata._meta = New ViewCostingApisMaterialStdCostMetadata()
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
				meta.AddTypeMap("Materialid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Qtyunits", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Weightuom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Productid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Stdunitcost", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Matcost", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Productdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Materialdesc", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewCostingApisMaterialStdCost"
				meta.Destination = "viewCostingApisMaterialStdCost"
				
				meta.spInsert = "proc_viewCostingApisMaterialStdCostInsert"
				meta.spUpdate = "proc_viewCostingApisMaterialStdCostUpdate"
				meta.spDelete = "proc_viewCostingApisMaterialStdCostDelete"
				meta.spLoadAll = "proc_viewCostingApisMaterialStdCostLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCostingApisMaterialStdCostLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewCostingApisMaterialStdCostMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
