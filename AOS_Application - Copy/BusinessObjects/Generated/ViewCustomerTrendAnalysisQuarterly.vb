'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 3/27/2014 7:47:43 AM
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
	MustInherit Public Class esViewCustomerTrendAnalysisQuarterlyCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewCustomerTrendAnalysisQuarterlyCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewCustomerTrendAnalysisQuarterlyQuery)
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
            Me.InitQuery(CType(query, esViewCustomerTrendAnalysisQuarterlyQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewCustomerTrendAnalysisQuarterly) As ViewCustomerTrendAnalysisQuarterly
			Return CType(MyBase.DetachEntity(entity), ViewCustomerTrendAnalysisQuarterly)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewCustomerTrendAnalysisQuarterly) As ViewCustomerTrendAnalysisQuarterly
			Return CType(MyBase.AttachEntity(entity), ViewCustomerTrendAnalysisQuarterly)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewCustomerTrendAnalysisQuarterlyCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewCustomerTrendAnalysisQuarterly
            Get
                Return TryCast(MyBase.Item(index), ViewCustomerTrendAnalysisQuarterly)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewCustomerTrendAnalysisQuarterly)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewCustomerTrendAnalysisQuarterly	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewCustomerTrendAnalysisQuarterlyQuery
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
												
						Case "CustID"
							Me.str.CustID = CType(value, string)
												
						Case "Qtr"
							Me.str.Qtr = CType(value, string)
												
						Case "Y2009"
							Me.str.Y2009 = CType(value, string)
												
						Case "Y2010"
							Me.str.Y2010 = CType(value, string)
												
						Case "Y2011"
							Me.str.Y2011 = CType(value, string)
												
						Case "Y2012"
							Me.str.Y2012 = CType(value, string)
												
						Case "Y2013"
							Me.str.Y2013 = CType(value, string)
												
						Case "Y2014"
							Me.str.Y2014 = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "CustID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.CustID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Qtr"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Qtr = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Y2009"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Y2009 = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Y2010"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Y2010 = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Y2011"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Y2011 = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Y2012"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Y2012 = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Y2013"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Y2013 = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Y2014"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Y2014 = CType(value, Nullable(Of System.Decimal))
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
		' Maps to viewCustomerTrendAnalysisQuarterly.CustID
		' </summary>
		Public Overridable Property CustID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCustomerTrendAnalysisQuarterlyMetadata.ColumnNames.CustID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCustomerTrendAnalysisQuarterlyMetadata.ColumnNames.CustID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerTrendAnalysisQuarterly.Qtr
		' </summary>
		Public Overridable Property Qtr As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCustomerTrendAnalysisQuarterlyMetadata.ColumnNames.Qtr)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCustomerTrendAnalysisQuarterlyMetadata.ColumnNames.Qtr, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerTrendAnalysisQuarterly.Y2009
		' </summary>
		Public Overridable Property Y2009 As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCustomerTrendAnalysisQuarterlyMetadata.ColumnNames.Y2009)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCustomerTrendAnalysisQuarterlyMetadata.ColumnNames.Y2009, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerTrendAnalysisQuarterly.Y2010
		' </summary>
		Public Overridable Property Y2010 As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCustomerTrendAnalysisQuarterlyMetadata.ColumnNames.Y2010)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCustomerTrendAnalysisQuarterlyMetadata.ColumnNames.Y2010, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerTrendAnalysisQuarterly.Y2011
		' </summary>
		Public Overridable Property Y2011 As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCustomerTrendAnalysisQuarterlyMetadata.ColumnNames.Y2011)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCustomerTrendAnalysisQuarterlyMetadata.ColumnNames.Y2011, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerTrendAnalysisQuarterly.Y2012
		' </summary>
		Public Overridable Property Y2012 As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCustomerTrendAnalysisQuarterlyMetadata.ColumnNames.Y2012)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCustomerTrendAnalysisQuarterlyMetadata.ColumnNames.Y2012, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerTrendAnalysisQuarterly.Y2013
		' </summary>
		Public Overridable Property Y2013 As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCustomerTrendAnalysisQuarterlyMetadata.ColumnNames.Y2013)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCustomerTrendAnalysisQuarterlyMetadata.ColumnNames.Y2013, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerTrendAnalysisQuarterly.Y2014
		' </summary>
		Public Overridable Property Y2014 As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCustomerTrendAnalysisQuarterlyMetadata.ColumnNames.Y2014)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCustomerTrendAnalysisQuarterlyMetadata.ColumnNames.Y2014, value)
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
		
			Public Sub New(ByVal entity As esViewCustomerTrendAnalysisQuarterly)
				Me.entity = entity
			End Sub				
		
	
			Public Property CustID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.CustID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CustID = Nothing
					Else
						entity.CustID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Qtr As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Qtr
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qtr = Nothing
					Else
						entity.Qtr = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Y2009 As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Y2009
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Y2009 = Nothing
					Else
						entity.Y2009 = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Y2010 As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Y2010
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Y2010 = Nothing
					Else
						entity.Y2010 = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Y2011 As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Y2011
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Y2011 = Nothing
					Else
						entity.Y2011 = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Y2012 As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Y2012
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Y2012 = Nothing
					Else
						entity.Y2012 = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Y2013 As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Y2013
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Y2013 = Nothing
					Else
						entity.Y2013 = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Y2014 As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Y2014
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Y2014 = Nothing
					Else
						entity.Y2014 = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewCustomerTrendAnalysisQuarterly
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewCustomerTrendAnalysisQuarterlyQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewCustomerTrendAnalysisQuarterly can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewCustomerTrendAnalysisQuarterlyQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCustomerTrendAnalysisQuarterlyMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property CustID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerTrendAnalysisQuarterlyMetadata.ColumnNames.CustID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Qtr As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerTrendAnalysisQuarterlyMetadata.ColumnNames.Qtr, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Y2009 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerTrendAnalysisQuarterlyMetadata.ColumnNames.Y2009, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Y2010 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerTrendAnalysisQuarterlyMetadata.ColumnNames.Y2010, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Y2011 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerTrendAnalysisQuarterlyMetadata.ColumnNames.Y2011, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Y2012 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerTrendAnalysisQuarterlyMetadata.ColumnNames.Y2012, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Y2013 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerTrendAnalysisQuarterlyMetadata.ColumnNames.Y2013, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Y2014 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerTrendAnalysisQuarterlyMetadata.ColumnNames.Y2014, esSystemType.Decimal)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewCustomerTrendAnalysisQuarterlyCollection")> _
	Partial Public Class ViewCustomerTrendAnalysisQuarterlyCollection
		Inherits esViewCustomerTrendAnalysisQuarterlyCollection
		Implements IEnumerable(Of ViewCustomerTrendAnalysisQuarterly)
		
        Public Shared Widening Operator CType(ByVal coll As ViewCustomerTrendAnalysisQuarterlyCollection) As List(Of ViewCustomerTrendAnalysisQuarterly)
            Dim list As List(Of ViewCustomerTrendAnalysisQuarterly) = New List(Of ViewCustomerTrendAnalysisQuarterly)
            Dim emp As ViewCustomerTrendAnalysisQuarterly

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCustomerTrendAnalysisQuarterlyMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewCustomerTrendAnalysisQuarterlyQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewCustomerTrendAnalysisQuarterly(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewCustomerTrendAnalysisQuarterly()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewCustomerTrendAnalysisQuarterlyQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewCustomerTrendAnalysisQuarterlyQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewCustomerTrendAnalysisQuarterlyQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewCustomerTrendAnalysisQuarterly 
			Return CType(MyBase.AddNewEntity(), ViewCustomerTrendAnalysisQuarterly)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewCustomerTrendAnalysisQuarterly) Implements IEnumerable(Of ViewCustomerTrendAnalysisQuarterly).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewCustomerTrendAnalysisQuarterly)(Me)
        End Function
		
		Private _query As ViewCustomerTrendAnalysisQuarterlyQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewCustomerTrendAnalysisQuarterly' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewCustomerTrendAnalysisQuarterly ()")> _
	<Serializable> _
	Partial Public Class ViewCustomerTrendAnalysisQuarterly 
		Inherits esViewCustomerTrendAnalysisQuarterly

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewCustomerTrendAnalysisQuarterlyMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewCustomerTrendAnalysisQuarterlyQuery

			If Me._query Is Nothing Then
				Me._query = New ViewCustomerTrendAnalysisQuarterlyQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewCustomerTrendAnalysisQuarterlyQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewCustomerTrendAnalysisQuarterlyQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewCustomerTrendAnalysisQuarterlyQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewCustomerTrendAnalysisQuarterlyQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewCustomerTrendAnalysisQuarterlyQuery
		inherits esViewCustomerTrendAnalysisQuarterlyQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewCustomerTrendAnalysisQuarterlyQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewCustomerTrendAnalysisQuarterlyMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCustomerTrendAnalysisQuarterlyMetadata.ColumnNames.CustID, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCustomerTrendAnalysisQuarterlyMetadata.PropertyNames.CustID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerTrendAnalysisQuarterlyMetadata.ColumnNames.Qtr, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCustomerTrendAnalysisQuarterlyMetadata.PropertyNames.Qtr
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerTrendAnalysisQuarterlyMetadata.ColumnNames.Y2009, 2, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCustomerTrendAnalysisQuarterlyMetadata.PropertyNames.Y2009
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerTrendAnalysisQuarterlyMetadata.ColumnNames.Y2010, 3, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCustomerTrendAnalysisQuarterlyMetadata.PropertyNames.Y2010
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerTrendAnalysisQuarterlyMetadata.ColumnNames.Y2011, 4, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCustomerTrendAnalysisQuarterlyMetadata.PropertyNames.Y2011
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerTrendAnalysisQuarterlyMetadata.ColumnNames.Y2012, 5, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCustomerTrendAnalysisQuarterlyMetadata.PropertyNames.Y2012
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerTrendAnalysisQuarterlyMetadata.ColumnNames.Y2013, 6, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCustomerTrendAnalysisQuarterlyMetadata.PropertyNames.Y2013
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerTrendAnalysisQuarterlyMetadata.ColumnNames.Y2014, 7, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCustomerTrendAnalysisQuarterlyMetadata.PropertyNames.Y2014
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewCustomerTrendAnalysisQuarterlyMetadata
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
			 Public Const CustID As String = "CustID"
			 Public Const Qtr As String = "Qtr"
			 Public Const Y2009 As String = "Y2009"
			 Public Const Y2010 As String = "Y2010"
			 Public Const Y2011 As String = "Y2011"
			 Public Const Y2012 As String = "Y2012"
			 Public Const Y2013 As String = "Y2013"
			 Public Const Y2014 As String = "Y2014"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const CustID As String = "CustID"
			 Public Const Qtr As String = "Qtr"
			 Public Const Y2009 As String = "Y2009"
			 Public Const Y2010 As String = "Y2010"
			 Public Const Y2011 As String = "Y2011"
			 Public Const Y2012 As String = "Y2012"
			 Public Const Y2013 As String = "Y2013"
			 Public Const Y2014 As String = "Y2014"
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
            SyncLock GetType(ViewCustomerTrendAnalysisQuarterlyMetadata)
			
				If ViewCustomerTrendAnalysisQuarterlyMetadata.mapDelegates Is Nothing Then
					ViewCustomerTrendAnalysisQuarterlyMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewCustomerTrendAnalysisQuarterlyMetadata._meta Is Nothing Then
                    ViewCustomerTrendAnalysisQuarterlyMetadata._meta = New ViewCustomerTrendAnalysisQuarterlyMetadata()
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
				

				meta.AddTypeMap("CustID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Qtr", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Y2009", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Y2010", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Y2011", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Y2012", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Y2013", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Y2014", new esTypeMap("decimal", "System.Decimal"))			
				
				
				 
				meta.Source = "viewCustomerTrendAnalysisQuarterly"
				meta.Destination = "viewCustomerTrendAnalysisQuarterly"
				
				meta.spInsert = "proc_viewCustomerTrendAnalysisQuarterlyInsert"
				meta.spUpdate = "proc_viewCustomerTrendAnalysisQuarterlyUpdate"
				meta.spDelete = "proc_viewCustomerTrendAnalysisQuarterlyDelete"
				meta.spLoadAll = "proc_viewCustomerTrendAnalysisQuarterlyLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCustomerTrendAnalysisQuarterlyLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewCustomerTrendAnalysisQuarterlyMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
