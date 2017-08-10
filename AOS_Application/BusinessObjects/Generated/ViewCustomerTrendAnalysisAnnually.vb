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
	MustInherit Public Class esViewCustomerTrendAnalysisAnnuallyCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewCustomerTrendAnalysisAnnuallyCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewCustomerTrendAnalysisAnnuallyQuery)
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
            Me.InitQuery(CType(query, esViewCustomerTrendAnalysisAnnuallyQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewCustomerTrendAnalysisAnnually) As ViewCustomerTrendAnalysisAnnually
			Return CType(MyBase.DetachEntity(entity), ViewCustomerTrendAnalysisAnnually)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewCustomerTrendAnalysisAnnually) As ViewCustomerTrendAnalysisAnnually
			Return CType(MyBase.AttachEntity(entity), ViewCustomerTrendAnalysisAnnually)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewCustomerTrendAnalysisAnnuallyCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewCustomerTrendAnalysisAnnually
            Get
                Return TryCast(MyBase.Item(index), ViewCustomerTrendAnalysisAnnually)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewCustomerTrendAnalysisAnnually)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewCustomerTrendAnalysisAnnually	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewCustomerTrendAnalysisAnnuallyQuery
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
												
						Case "Ytd2009"
							Me.str.Ytd2009 = CType(value, string)
												
						Case "Ytd2010"
							Me.str.Ytd2010 = CType(value, string)
												
						Case "Ytd2011"
							Me.str.Ytd2011 = CType(value, string)
												
						Case "Ytd2012"
							Me.str.Ytd2012 = CType(value, string)
												
						Case "Ytd2013"
							Me.str.Ytd2013 = CType(value, string)
												
						Case "Ytd2014"
							Me.str.Ytd2014 = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "CustID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.CustID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Ytd2009"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Ytd2009 = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Ytd2010"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Ytd2010 = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Ytd2011"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Ytd2011 = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Ytd2012"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Ytd2012 = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Ytd2013"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Ytd2013 = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Ytd2014"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Ytd2014 = CType(value, Nullable(Of System.Decimal))
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
		' Maps to viewCustomerTrendAnalysisAnnually.CustID
		' </summary>
		Public Overridable Property CustID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCustomerTrendAnalysisAnnuallyMetadata.ColumnNames.CustID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCustomerTrendAnalysisAnnuallyMetadata.ColumnNames.CustID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerTrendAnalysisAnnually.YTD2009
		' </summary>
		Public Overridable Property Ytd2009 As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCustomerTrendAnalysisAnnuallyMetadata.ColumnNames.Ytd2009)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCustomerTrendAnalysisAnnuallyMetadata.ColumnNames.Ytd2009, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerTrendAnalysisAnnually.YTD2010
		' </summary>
		Public Overridable Property Ytd2010 As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCustomerTrendAnalysisAnnuallyMetadata.ColumnNames.Ytd2010)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCustomerTrendAnalysisAnnuallyMetadata.ColumnNames.Ytd2010, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerTrendAnalysisAnnually.YTD2011
		' </summary>
		Public Overridable Property Ytd2011 As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCustomerTrendAnalysisAnnuallyMetadata.ColumnNames.Ytd2011)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCustomerTrendAnalysisAnnuallyMetadata.ColumnNames.Ytd2011, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerTrendAnalysisAnnually.YTD2012
		' </summary>
		Public Overridable Property Ytd2012 As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCustomerTrendAnalysisAnnuallyMetadata.ColumnNames.Ytd2012)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCustomerTrendAnalysisAnnuallyMetadata.ColumnNames.Ytd2012, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerTrendAnalysisAnnually.YTD2013
		' </summary>
		Public Overridable Property Ytd2013 As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCustomerTrendAnalysisAnnuallyMetadata.ColumnNames.Ytd2013)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCustomerTrendAnalysisAnnuallyMetadata.ColumnNames.Ytd2013, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerTrendAnalysisAnnually.YTD2014
		' </summary>
		Public Overridable Property Ytd2014 As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCustomerTrendAnalysisAnnuallyMetadata.ColumnNames.Ytd2014)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCustomerTrendAnalysisAnnuallyMetadata.ColumnNames.Ytd2014, value)
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
		
			Public Sub New(ByVal entity As esViewCustomerTrendAnalysisAnnually)
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
		  	
			Public Property Ytd2009 As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Ytd2009
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Ytd2009 = Nothing
					Else
						entity.Ytd2009 = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Ytd2010 As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Ytd2010
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Ytd2010 = Nothing
					Else
						entity.Ytd2010 = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Ytd2011 As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Ytd2011
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Ytd2011 = Nothing
					Else
						entity.Ytd2011 = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Ytd2012 As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Ytd2012
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Ytd2012 = Nothing
					Else
						entity.Ytd2012 = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Ytd2013 As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Ytd2013
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Ytd2013 = Nothing
					Else
						entity.Ytd2013 = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Ytd2014 As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Ytd2014
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Ytd2014 = Nothing
					Else
						entity.Ytd2014 = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewCustomerTrendAnalysisAnnually
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewCustomerTrendAnalysisAnnuallyQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewCustomerTrendAnalysisAnnually can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewCustomerTrendAnalysisAnnuallyQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCustomerTrendAnalysisAnnuallyMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property CustID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerTrendAnalysisAnnuallyMetadata.ColumnNames.CustID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Ytd2009 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerTrendAnalysisAnnuallyMetadata.ColumnNames.Ytd2009, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Ytd2010 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerTrendAnalysisAnnuallyMetadata.ColumnNames.Ytd2010, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Ytd2011 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerTrendAnalysisAnnuallyMetadata.ColumnNames.Ytd2011, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Ytd2012 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerTrendAnalysisAnnuallyMetadata.ColumnNames.Ytd2012, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Ytd2013 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerTrendAnalysisAnnuallyMetadata.ColumnNames.Ytd2013, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Ytd2014 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerTrendAnalysisAnnuallyMetadata.ColumnNames.Ytd2014, esSystemType.Decimal)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewCustomerTrendAnalysisAnnuallyCollection")> _
	Partial Public Class ViewCustomerTrendAnalysisAnnuallyCollection
		Inherits esViewCustomerTrendAnalysisAnnuallyCollection
		Implements IEnumerable(Of ViewCustomerTrendAnalysisAnnually)
		
        Public Shared Widening Operator CType(ByVal coll As ViewCustomerTrendAnalysisAnnuallyCollection) As List(Of ViewCustomerTrendAnalysisAnnually)
            Dim list As List(Of ViewCustomerTrendAnalysisAnnually) = New List(Of ViewCustomerTrendAnalysisAnnually)
            Dim emp As ViewCustomerTrendAnalysisAnnually

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCustomerTrendAnalysisAnnuallyMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewCustomerTrendAnalysisAnnuallyQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewCustomerTrendAnalysisAnnually(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewCustomerTrendAnalysisAnnually()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewCustomerTrendAnalysisAnnuallyQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewCustomerTrendAnalysisAnnuallyQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewCustomerTrendAnalysisAnnuallyQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewCustomerTrendAnalysisAnnually 
			Return CType(MyBase.AddNewEntity(), ViewCustomerTrendAnalysisAnnually)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewCustomerTrendAnalysisAnnually) Implements IEnumerable(Of ViewCustomerTrendAnalysisAnnually).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewCustomerTrendAnalysisAnnually)(Me)
        End Function
		
		Private _query As ViewCustomerTrendAnalysisAnnuallyQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewCustomerTrendAnalysisAnnually' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewCustomerTrendAnalysisAnnually ()")> _
	<Serializable> _
	Partial Public Class ViewCustomerTrendAnalysisAnnually 
		Inherits esViewCustomerTrendAnalysisAnnually

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewCustomerTrendAnalysisAnnuallyMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewCustomerTrendAnalysisAnnuallyQuery

			If Me._query Is Nothing Then
				Me._query = New ViewCustomerTrendAnalysisAnnuallyQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewCustomerTrendAnalysisAnnuallyQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewCustomerTrendAnalysisAnnuallyQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewCustomerTrendAnalysisAnnuallyQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewCustomerTrendAnalysisAnnuallyQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewCustomerTrendAnalysisAnnuallyQuery
		inherits esViewCustomerTrendAnalysisAnnuallyQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewCustomerTrendAnalysisAnnuallyQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewCustomerTrendAnalysisAnnuallyMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCustomerTrendAnalysisAnnuallyMetadata.ColumnNames.CustID, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCustomerTrendAnalysisAnnuallyMetadata.PropertyNames.CustID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerTrendAnalysisAnnuallyMetadata.ColumnNames.Ytd2009, 1, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCustomerTrendAnalysisAnnuallyMetadata.PropertyNames.Ytd2009
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerTrendAnalysisAnnuallyMetadata.ColumnNames.Ytd2010, 2, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCustomerTrendAnalysisAnnuallyMetadata.PropertyNames.Ytd2010
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerTrendAnalysisAnnuallyMetadata.ColumnNames.Ytd2011, 3, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCustomerTrendAnalysisAnnuallyMetadata.PropertyNames.Ytd2011
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerTrendAnalysisAnnuallyMetadata.ColumnNames.Ytd2012, 4, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCustomerTrendAnalysisAnnuallyMetadata.PropertyNames.Ytd2012
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerTrendAnalysisAnnuallyMetadata.ColumnNames.Ytd2013, 5, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCustomerTrendAnalysisAnnuallyMetadata.PropertyNames.Ytd2013
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerTrendAnalysisAnnuallyMetadata.ColumnNames.Ytd2014, 6, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCustomerTrendAnalysisAnnuallyMetadata.PropertyNames.Ytd2014
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewCustomerTrendAnalysisAnnuallyMetadata
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
			 Public Const Ytd2009 As String = "YTD2009"
			 Public Const Ytd2010 As String = "YTD2010"
			 Public Const Ytd2011 As String = "YTD2011"
			 Public Const Ytd2012 As String = "YTD2012"
			 Public Const Ytd2013 As String = "YTD2013"
			 Public Const Ytd2014 As String = "YTD2014"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const CustID As String = "CustID"
			 Public Const Ytd2009 As String = "Ytd2009"
			 Public Const Ytd2010 As String = "Ytd2010"
			 Public Const Ytd2011 As String = "Ytd2011"
			 Public Const Ytd2012 As String = "Ytd2012"
			 Public Const Ytd2013 As String = "Ytd2013"
			 Public Const Ytd2014 As String = "Ytd2014"
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
            SyncLock GetType(ViewCustomerTrendAnalysisAnnuallyMetadata)
			
				If ViewCustomerTrendAnalysisAnnuallyMetadata.mapDelegates Is Nothing Then
					ViewCustomerTrendAnalysisAnnuallyMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewCustomerTrendAnalysisAnnuallyMetadata._meta Is Nothing Then
                    ViewCustomerTrendAnalysisAnnuallyMetadata._meta = New ViewCustomerTrendAnalysisAnnuallyMetadata()
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
				meta.AddTypeMap("Ytd2009", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Ytd2010", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Ytd2011", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Ytd2012", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Ytd2013", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Ytd2014", new esTypeMap("decimal", "System.Decimal"))			
				
				
				 
				meta.Source = "viewCustomerTrendAnalysisAnnually"
				meta.Destination = "viewCustomerTrendAnalysisAnnually"
				
				meta.spInsert = "proc_viewCustomerTrendAnalysisAnnuallyInsert"
				meta.spUpdate = "proc_viewCustomerTrendAnalysisAnnuallyUpdate"
				meta.spDelete = "proc_viewCustomerTrendAnalysisAnnuallyDelete"
				meta.spLoadAll = "proc_viewCustomerTrendAnalysisAnnuallyLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCustomerTrendAnalysisAnnuallyLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewCustomerTrendAnalysisAnnuallyMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
