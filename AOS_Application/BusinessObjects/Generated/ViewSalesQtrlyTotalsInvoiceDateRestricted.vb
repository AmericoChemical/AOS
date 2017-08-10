'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/24/2015 12:58:25 PM
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
	MustInherit Public Class esViewSalesQtrlyTotalsInvoiceDateRestrictedCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewSalesQtrlyTotalsInvoiceDateRestrictedCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewSalesQtrlyTotalsInvoiceDateRestrictedQuery)
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
            Me.InitQuery(CType(query, esViewSalesQtrlyTotalsInvoiceDateRestrictedQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewSalesQtrlyTotalsInvoiceDateRestricted) As ViewSalesQtrlyTotalsInvoiceDateRestricted
			Return CType(MyBase.DetachEntity(entity), ViewSalesQtrlyTotalsInvoiceDateRestricted)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewSalesQtrlyTotalsInvoiceDateRestricted) As ViewSalesQtrlyTotalsInvoiceDateRestricted
			Return CType(MyBase.AttachEntity(entity), ViewSalesQtrlyTotalsInvoiceDateRestricted)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewSalesQtrlyTotalsInvoiceDateRestrictedCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewSalesQtrlyTotalsInvoiceDateRestricted
            Get
                Return TryCast(MyBase.Item(index), ViewSalesQtrlyTotalsInvoiceDateRestricted)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewSalesQtrlyTotalsInvoiceDateRestricted)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewSalesQtrlyTotalsInvoiceDateRestricted	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewSalesQtrlyTotalsInvoiceDateRestrictedQuery
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
												
						Case "SalesID1"
							Me.str.SalesID1 = CType(value, string)
												
						Case "SName1"
							Me.str.SName1 = CType(value, string)
												
						Case "Saleslevel"
							Me.str.Saleslevel = CType(value, string)
												
						Case "Salesbycustomerreport"
							Me.str.Salesbycustomerreport = CType(value, string)
												
						Case "Year"
							Me.str.Year = CType(value, string)
												
						Case "Qtr1"
							Me.str.Qtr1 = CType(value, string)
												
						Case "Qtr2"
							Me.str.Qtr2 = CType(value, string)
												
						Case "Qtr3"
							Me.str.Qtr3 = CType(value, string)
												
						Case "Qtr4"
							Me.str.Qtr4 = CType(value, string)
												
						Case "Ytd"
							Me.str.Ytd = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "SalesID1"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SalesID1 = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Saleslevel"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Saleslevel = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Salesbycustomerreport"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Salesbycustomerreport = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Year"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Year = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Qtr1"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Qtr1 = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Qtr2"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Qtr2 = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Qtr3"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Qtr3 = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Qtr4"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Qtr4 = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Ytd"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Ytd = CType(value, Nullable(Of System.Decimal))
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
		' Maps to viewSalesQtrlyTotalsInvoiceDateRestricted.SalesID1
		' </summary>
		Public Overridable Property SalesID1 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata.ColumnNames.SalesID1)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata.ColumnNames.SalesID1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewSalesQtrlyTotalsInvoiceDateRestricted.SName1
		' </summary>
		Public Overridable Property SName1 As System.String
			Get
				Return MyBase.GetSystemString(ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata.ColumnNames.SName1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata.ColumnNames.SName1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewSalesQtrlyTotalsInvoiceDateRestricted.SALESLEVEL
		' </summary>
		Public Overridable Property Saleslevel As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata.ColumnNames.Saleslevel)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata.ColumnNames.Saleslevel, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewSalesQtrlyTotalsInvoiceDateRestricted.SALESBYCUSTOMERREPORT
		' </summary>
		Public Overridable Property Salesbycustomerreport As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata.ColumnNames.Salesbycustomerreport)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata.ColumnNames.Salesbycustomerreport, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewSalesQtrlyTotalsInvoiceDateRestricted.YEAR
		' </summary>
		Public Overridable Property Year As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata.ColumnNames.Year)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata.ColumnNames.Year, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewSalesQtrlyTotalsInvoiceDateRestricted.Qtr1
		' </summary>
		Public Overridable Property Qtr1 As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata.ColumnNames.Qtr1)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata.ColumnNames.Qtr1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewSalesQtrlyTotalsInvoiceDateRestricted.Qtr2
		' </summary>
		Public Overridable Property Qtr2 As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata.ColumnNames.Qtr2)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata.ColumnNames.Qtr2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewSalesQtrlyTotalsInvoiceDateRestricted.Qtr3
		' </summary>
		Public Overridable Property Qtr3 As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata.ColumnNames.Qtr3)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata.ColumnNames.Qtr3, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewSalesQtrlyTotalsInvoiceDateRestricted.Qtr4
		' </summary>
		Public Overridable Property Qtr4 As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata.ColumnNames.Qtr4)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata.ColumnNames.Qtr4, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewSalesQtrlyTotalsInvoiceDateRestricted.YTD
		' </summary>
		Public Overridable Property Ytd As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata.ColumnNames.Ytd)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata.ColumnNames.Ytd, value)
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
		
			Public Sub New(ByVal entity As esViewSalesQtrlyTotalsInvoiceDateRestricted)
				Me.entity = entity
			End Sub				
		
	
			Public Property SalesID1 As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.SalesID1
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SalesID1 = Nothing
					Else
						entity.SalesID1 = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property SName1 As System.String 
				Get
					Dim data_ As System.String = entity.SName1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SName1 = Nothing
					Else
						entity.SName1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Saleslevel As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Saleslevel
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Saleslevel = Nothing
					Else
						entity.Saleslevel = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Salesbycustomerreport As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Salesbycustomerreport
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Salesbycustomerreport = Nothing
					Else
						entity.Salesbycustomerreport = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property Year As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Year
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Year = Nothing
					Else
						entity.Year = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Qtr1 As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Qtr1
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qtr1 = Nothing
					Else
						entity.Qtr1 = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Qtr2 As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Qtr2
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qtr2 = Nothing
					Else
						entity.Qtr2 = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Qtr3 As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Qtr3
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qtr3 = Nothing
					Else
						entity.Qtr3 = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Qtr4 As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Qtr4
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qtr4 = Nothing
					Else
						entity.Qtr4 = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Ytd As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Ytd
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Ytd = Nothing
					Else
						entity.Ytd = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewSalesQtrlyTotalsInvoiceDateRestricted
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewSalesQtrlyTotalsInvoiceDateRestrictedQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewSalesQtrlyTotalsInvoiceDateRestricted can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewSalesQtrlyTotalsInvoiceDateRestrictedQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property SalesID1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata.ColumnNames.SalesID1, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property SName1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata.ColumnNames.SName1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Saleslevel As esQueryItem
			Get
				Return New esQueryItem(Me, ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata.ColumnNames.Saleslevel, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Salesbycustomerreport As esQueryItem
			Get
				Return New esQueryItem(Me, ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata.ColumnNames.Salesbycustomerreport, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Year As esQueryItem
			Get
				Return New esQueryItem(Me, ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata.ColumnNames.Year, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Qtr1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata.ColumnNames.Qtr1, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Qtr2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata.ColumnNames.Qtr2, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Qtr3 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata.ColumnNames.Qtr3, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Qtr4 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata.ColumnNames.Qtr4, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Ytd As esQueryItem
			Get
				Return New esQueryItem(Me, ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata.ColumnNames.Ytd, esSystemType.Decimal)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewSalesQtrlyTotalsInvoiceDateRestrictedCollection")> _
	Partial Public Class ViewSalesQtrlyTotalsInvoiceDateRestrictedCollection
		Inherits esViewSalesQtrlyTotalsInvoiceDateRestrictedCollection
		Implements IEnumerable(Of ViewSalesQtrlyTotalsInvoiceDateRestricted)
		
        Public Shared Widening Operator CType(ByVal coll As ViewSalesQtrlyTotalsInvoiceDateRestrictedCollection) As List(Of ViewSalesQtrlyTotalsInvoiceDateRestricted)
            Dim list As List(Of ViewSalesQtrlyTotalsInvoiceDateRestricted) = New List(Of ViewSalesQtrlyTotalsInvoiceDateRestricted)
            Dim emp As ViewSalesQtrlyTotalsInvoiceDateRestricted

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewSalesQtrlyTotalsInvoiceDateRestrictedQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewSalesQtrlyTotalsInvoiceDateRestricted(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewSalesQtrlyTotalsInvoiceDateRestricted()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewSalesQtrlyTotalsInvoiceDateRestrictedQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewSalesQtrlyTotalsInvoiceDateRestrictedQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewSalesQtrlyTotalsInvoiceDateRestrictedQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewSalesQtrlyTotalsInvoiceDateRestricted 
			Return CType(MyBase.AddNewEntity(), ViewSalesQtrlyTotalsInvoiceDateRestricted)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewSalesQtrlyTotalsInvoiceDateRestricted) Implements IEnumerable(Of ViewSalesQtrlyTotalsInvoiceDateRestricted).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewSalesQtrlyTotalsInvoiceDateRestricted)(Me)
        End Function
		
		Private _query As ViewSalesQtrlyTotalsInvoiceDateRestrictedQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewSalesQtrlyTotalsInvoiceDateRestricted' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewSalesQtrlyTotalsInvoiceDateRestricted ()")> _
	<Serializable> _
	Partial Public Class ViewSalesQtrlyTotalsInvoiceDateRestricted 
		Inherits esViewSalesQtrlyTotalsInvoiceDateRestricted

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewSalesQtrlyTotalsInvoiceDateRestrictedQuery

			If Me._query Is Nothing Then
				Me._query = New ViewSalesQtrlyTotalsInvoiceDateRestrictedQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewSalesQtrlyTotalsInvoiceDateRestrictedQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewSalesQtrlyTotalsInvoiceDateRestrictedQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewSalesQtrlyTotalsInvoiceDateRestrictedQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewSalesQtrlyTotalsInvoiceDateRestrictedQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewSalesQtrlyTotalsInvoiceDateRestrictedQuery
		inherits esViewSalesQtrlyTotalsInvoiceDateRestrictedQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewSalesQtrlyTotalsInvoiceDateRestrictedQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata.ColumnNames.SalesID1, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata.PropertyNames.SalesID1
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata.ColumnNames.SName1, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata.PropertyNames.SName1
			c.CharacterMaxLength = 101
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata.ColumnNames.Saleslevel, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata.PropertyNames.Saleslevel
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata.ColumnNames.Salesbycustomerreport, 3, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata.PropertyNames.Salesbycustomerreport
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata.ColumnNames.Year, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata.PropertyNames.Year
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata.ColumnNames.Qtr1, 5, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata.PropertyNames.Qtr1
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata.ColumnNames.Qtr2, 6, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata.PropertyNames.Qtr2
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata.ColumnNames.Qtr3, 7, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata.PropertyNames.Qtr3
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata.ColumnNames.Qtr4, 8, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata.PropertyNames.Qtr4
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata.ColumnNames.Ytd, 9, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata.PropertyNames.Ytd
			c.NumericPrecision = 38
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata
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
			 Public Const SalesID1 As String = "SalesID1"
			 Public Const SName1 As String = "SName1"
			 Public Const Saleslevel As String = "SALESLEVEL"
			 Public Const Salesbycustomerreport As String = "SALESBYCUSTOMERREPORT"
			 Public Const Year As String = "YEAR"
			 Public Const Qtr1 As String = "Qtr1"
			 Public Const Qtr2 As String = "Qtr2"
			 Public Const Qtr3 As String = "Qtr3"
			 Public Const Qtr4 As String = "Qtr4"
			 Public Const Ytd As String = "YTD"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const SalesID1 As String = "SalesID1"
			 Public Const SName1 As String = "SName1"
			 Public Const Saleslevel As String = "Saleslevel"
			 Public Const Salesbycustomerreport As String = "Salesbycustomerreport"
			 Public Const Year As String = "Year"
			 Public Const Qtr1 As String = "Qtr1"
			 Public Const Qtr2 As String = "Qtr2"
			 Public Const Qtr3 As String = "Qtr3"
			 Public Const Qtr4 As String = "Qtr4"
			 Public Const Ytd As String = "Ytd"
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
            SyncLock GetType(ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata)
			
				If ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata.mapDelegates Is Nothing Then
					ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata._meta Is Nothing Then
                    ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata._meta = New ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata()
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
				

				meta.AddTypeMap("SalesID1", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("SName1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Saleslevel", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Salesbycustomerreport", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Year", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Qtr1", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Qtr2", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Qtr3", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Qtr4", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Ytd", new esTypeMap("decimal", "System.Decimal"))			
				
				
				 
				meta.Source = "viewSalesQtrlyTotalsInvoiceDateRestricted"
				meta.Destination = "viewSalesQtrlyTotalsInvoiceDateRestricted"
				
				meta.spInsert = "proc_viewSalesQtrlyTotalsInvoiceDateRestrictedInsert"
				meta.spUpdate = "proc_viewSalesQtrlyTotalsInvoiceDateRestrictedUpdate"
				meta.spDelete = "proc_viewSalesQtrlyTotalsInvoiceDateRestrictedDelete"
				meta.spLoadAll = "proc_viewSalesQtrlyTotalsInvoiceDateRestrictedLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewSalesQtrlyTotalsInvoiceDateRestrictedLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewSalesQtrlyTotalsInvoiceDateRestrictedMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
