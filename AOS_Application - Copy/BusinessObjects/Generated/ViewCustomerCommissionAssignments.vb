'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 12/12/2017 10:58:20 AM
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
	MustInherit Public Class esViewCustomerCommissionAssignmentsCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewCustomerCommissionAssignmentsCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewCustomerCommissionAssignmentsQuery)
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
            Me.InitQuery(CType(query, esViewCustomerCommissionAssignmentsQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewCustomerCommissionAssignments) As ViewCustomerCommissionAssignments
			Return CType(MyBase.DetachEntity(entity), ViewCustomerCommissionAssignments)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewCustomerCommissionAssignments) As ViewCustomerCommissionAssignments
			Return CType(MyBase.AttachEntity(entity), ViewCustomerCommissionAssignments)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewCustomerCommissionAssignmentsCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewCustomerCommissionAssignments
            Get
                Return TryCast(MyBase.Item(index), ViewCustomerCommissionAssignments)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewCustomerCommissionAssignments)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewCustomerCommissionAssignments	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewCustomerCommissionAssignmentsQuery
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
												
						Case "Custid"
							Me.str.Custid = CType(value, string)
												
						Case "Custname"
							Me.str.Custname = CType(value, string)
												
						Case "City"
							Me.str.City = CType(value, string)
												
						Case "State"
							Me.str.State = CType(value, string)
												
						Case "SalespersonID"
							Me.str.SalespersonID = CType(value, string)
												
						Case "Salespersonfullname"
							Me.str.Salespersonfullname = CType(value, string)
												
						Case "Defaultrate"
							Me.str.Defaultrate = CType(value, string)
												
						Case "Commtype"
							Me.str.Commtype = CType(value, string)
												
						Case "ProductID"
							Me.str.ProductID = CType(value, string)
												
						Case "Productdesc"
							Me.str.Productdesc = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "Exceptionrate"
							Me.str.Exceptionrate = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Custid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Custid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "SalespersonID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SalespersonID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Defaultrate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Defaultrate = CType(value, Nullable(Of System.Double))
							End If
						
						Case "ProductID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ProductID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Exceptionrate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Exceptionrate = CType(value, Nullable(Of System.Double))
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
		' Maps to viewCustomerCommissionAssignments.CUSTID
		' </summary>
		Public Overridable Property Custid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCustomerCommissionAssignmentsMetadata.ColumnNames.Custid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCustomerCommissionAssignmentsMetadata.ColumnNames.Custid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerCommissionAssignments.CUSTNAME
		' </summary>
		Public Overridable Property Custname As System.String
			Get
				Return MyBase.GetSystemString(ViewCustomerCommissionAssignmentsMetadata.ColumnNames.Custname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCustomerCommissionAssignmentsMetadata.ColumnNames.Custname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerCommissionAssignments.CITY
		' </summary>
		Public Overridable Property City As System.String
			Get
				Return MyBase.GetSystemString(ViewCustomerCommissionAssignmentsMetadata.ColumnNames.City)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCustomerCommissionAssignmentsMetadata.ColumnNames.City, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerCommissionAssignments.STATE
		' </summary>
		Public Overridable Property State As System.String
			Get
				Return MyBase.GetSystemString(ViewCustomerCommissionAssignmentsMetadata.ColumnNames.State)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCustomerCommissionAssignmentsMetadata.ColumnNames.State, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerCommissionAssignments.SalespersonID
		' </summary>
		Public Overridable Property SalespersonID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCustomerCommissionAssignmentsMetadata.ColumnNames.SalespersonID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCustomerCommissionAssignmentsMetadata.ColumnNames.SalespersonID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerCommissionAssignments.SALESPERSONFULLNAME
		' </summary>
		Public Overridable Property Salespersonfullname As System.String
			Get
				Return MyBase.GetSystemString(ViewCustomerCommissionAssignmentsMetadata.ColumnNames.Salespersonfullname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCustomerCommissionAssignmentsMetadata.ColumnNames.Salespersonfullname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerCommissionAssignments.DEFAULTRATE
		' </summary>
		Public Overridable Property Defaultrate As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCustomerCommissionAssignmentsMetadata.ColumnNames.Defaultrate)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewCustomerCommissionAssignmentsMetadata.ColumnNames.Defaultrate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerCommissionAssignments.COMMTYPE
		' </summary>
		Public Overridable Property Commtype As System.String
			Get
				Return MyBase.GetSystemString(ViewCustomerCommissionAssignmentsMetadata.ColumnNames.Commtype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCustomerCommissionAssignmentsMetadata.ColumnNames.Commtype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerCommissionAssignments.ProductID
		' </summary>
		Public Overridable Property ProductID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCustomerCommissionAssignmentsMetadata.ColumnNames.ProductID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCustomerCommissionAssignmentsMetadata.ColumnNames.ProductID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerCommissionAssignments.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewCustomerCommissionAssignmentsMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCustomerCommissionAssignmentsMetadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerCommissionAssignments.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewCustomerCommissionAssignmentsMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCustomerCommissionAssignmentsMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerCommissionAssignments.EXCEPTIONRATE
		' </summary>
		Public Overridable Property Exceptionrate As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCustomerCommissionAssignmentsMetadata.ColumnNames.Exceptionrate)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewCustomerCommissionAssignmentsMetadata.ColumnNames.Exceptionrate, value)
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
		
			Public Sub New(ByVal entity As esViewCustomerCommissionAssignments)
				Me.entity = entity
			End Sub				
		
	
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
		  	
			Public Property City As System.String 
				Get
					Dim data_ As System.String = entity.City
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.City = Nothing
					Else
						entity.City = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property State As System.String 
				Get
					Dim data_ As System.String = entity.State
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.State = Nothing
					Else
						entity.State = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property SalespersonID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.SalespersonID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SalespersonID = Nothing
					Else
						entity.SalespersonID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Salespersonfullname As System.String 
				Get
					Dim data_ As System.String = entity.Salespersonfullname
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Salespersonfullname = Nothing
					Else
						entity.Salespersonfullname = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Defaultrate As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Defaultrate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Defaultrate = Nothing
					Else
						entity.Defaultrate = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property Commtype As System.String 
				Get
					Dim data_ As System.String = entity.Commtype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Commtype = Nothing
					Else
						entity.Commtype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ProductID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.ProductID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ProductID = Nothing
					Else
						entity.ProductID = Convert.ToInt32(Value)
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
		  	
			Public Property Exceptionrate As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Exceptionrate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Exceptionrate = Nothing
					Else
						entity.Exceptionrate = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewCustomerCommissionAssignments
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewCustomerCommissionAssignmentsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewCustomerCommissionAssignments can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewCustomerCommissionAssignmentsQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCustomerCommissionAssignmentsMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Custid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerCommissionAssignmentsMetadata.ColumnNames.Custid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Custname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerCommissionAssignmentsMetadata.ColumnNames.Custname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property City As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerCommissionAssignmentsMetadata.ColumnNames.City, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property State As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerCommissionAssignmentsMetadata.ColumnNames.State, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property SalespersonID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerCommissionAssignmentsMetadata.ColumnNames.SalespersonID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Salespersonfullname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerCommissionAssignmentsMetadata.ColumnNames.Salespersonfullname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Defaultrate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerCommissionAssignmentsMetadata.ColumnNames.Defaultrate, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Commtype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerCommissionAssignmentsMetadata.ColumnNames.Commtype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ProductID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerCommissionAssignmentsMetadata.ColumnNames.ProductID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerCommissionAssignmentsMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerCommissionAssignmentsMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Exceptionrate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerCommissionAssignmentsMetadata.ColumnNames.Exceptionrate, esSystemType.Double)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewCustomerCommissionAssignmentsCollection")> _
	Partial Public Class ViewCustomerCommissionAssignmentsCollection
		Inherits esViewCustomerCommissionAssignmentsCollection
		Implements IEnumerable(Of ViewCustomerCommissionAssignments)
		
        Public Shared Widening Operator CType(ByVal coll As ViewCustomerCommissionAssignmentsCollection) As List(Of ViewCustomerCommissionAssignments)
            Dim list As List(Of ViewCustomerCommissionAssignments) = New List(Of ViewCustomerCommissionAssignments)
            Dim emp As ViewCustomerCommissionAssignments

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCustomerCommissionAssignmentsMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewCustomerCommissionAssignmentsQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewCustomerCommissionAssignments(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewCustomerCommissionAssignments()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewCustomerCommissionAssignmentsQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewCustomerCommissionAssignmentsQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewCustomerCommissionAssignmentsQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewCustomerCommissionAssignments 
			Return CType(MyBase.AddNewEntity(), ViewCustomerCommissionAssignments)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewCustomerCommissionAssignments) Implements IEnumerable(Of ViewCustomerCommissionAssignments).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewCustomerCommissionAssignments)(Me)
        End Function
		
		Private _query As ViewCustomerCommissionAssignmentsQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewCustomerCommissionAssignments' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewCustomerCommissionAssignments ()")> _
	<Serializable> _
	Partial Public Class ViewCustomerCommissionAssignments 
		Inherits esViewCustomerCommissionAssignments

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewCustomerCommissionAssignmentsMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewCustomerCommissionAssignmentsQuery

			If Me._query Is Nothing Then
				Me._query = New ViewCustomerCommissionAssignmentsQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewCustomerCommissionAssignmentsQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewCustomerCommissionAssignmentsQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewCustomerCommissionAssignmentsQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewCustomerCommissionAssignmentsQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewCustomerCommissionAssignmentsQuery
		inherits esViewCustomerCommissionAssignmentsQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewCustomerCommissionAssignmentsQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewCustomerCommissionAssignmentsMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCustomerCommissionAssignmentsMetadata.ColumnNames.Custid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCustomerCommissionAssignmentsMetadata.PropertyNames.Custid
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerCommissionAssignmentsMetadata.ColumnNames.Custname, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCustomerCommissionAssignmentsMetadata.PropertyNames.Custname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerCommissionAssignmentsMetadata.ColumnNames.City, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCustomerCommissionAssignmentsMetadata.PropertyNames.City
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerCommissionAssignmentsMetadata.ColumnNames.State, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCustomerCommissionAssignmentsMetadata.PropertyNames.State
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerCommissionAssignmentsMetadata.ColumnNames.SalespersonID, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCustomerCommissionAssignmentsMetadata.PropertyNames.SalespersonID
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerCommissionAssignmentsMetadata.ColumnNames.Salespersonfullname, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCustomerCommissionAssignmentsMetadata.PropertyNames.Salespersonfullname
			c.CharacterMaxLength = 101
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerCommissionAssignmentsMetadata.ColumnNames.Defaultrate, 6, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCustomerCommissionAssignmentsMetadata.PropertyNames.Defaultrate
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerCommissionAssignmentsMetadata.ColumnNames.Commtype, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCustomerCommissionAssignmentsMetadata.PropertyNames.Commtype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerCommissionAssignmentsMetadata.ColumnNames.ProductID, 8, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCustomerCommissionAssignmentsMetadata.PropertyNames.ProductID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerCommissionAssignmentsMetadata.ColumnNames.Productdesc, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCustomerCommissionAssignmentsMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerCommissionAssignmentsMetadata.ColumnNames.Container, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCustomerCommissionAssignmentsMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerCommissionAssignmentsMetadata.ColumnNames.Exceptionrate, 11, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCustomerCommissionAssignmentsMetadata.PropertyNames.Exceptionrate
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewCustomerCommissionAssignmentsMetadata
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
			 Public Const Custid As String = "CUSTID"
			 Public Const Custname As String = "CUSTNAME"
			 Public Const City As String = "CITY"
			 Public Const State As String = "STATE"
			 Public Const SalespersonID As String = "SalespersonID"
			 Public Const Salespersonfullname As String = "SALESPERSONFULLNAME"
			 Public Const Defaultrate As String = "DEFAULTRATE"
			 Public Const Commtype As String = "COMMTYPE"
			 Public Const ProductID As String = "ProductID"
			 Public Const Productdesc As String = "PRODUCTDESC"
			 Public Const Container As String = "CONTAINER"
			 Public Const Exceptionrate As String = "EXCEPTIONRATE"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Custid As String = "Custid"
			 Public Const Custname As String = "Custname"
			 Public Const City As String = "City"
			 Public Const State As String = "State"
			 Public Const SalespersonID As String = "SalespersonID"
			 Public Const Salespersonfullname As String = "Salespersonfullname"
			 Public Const Defaultrate As String = "Defaultrate"
			 Public Const Commtype As String = "Commtype"
			 Public Const ProductID As String = "ProductID"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const Container As String = "Container"
			 Public Const Exceptionrate As String = "Exceptionrate"
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
            SyncLock GetType(ViewCustomerCommissionAssignmentsMetadata)
			
				If ViewCustomerCommissionAssignmentsMetadata.mapDelegates Is Nothing Then
					ViewCustomerCommissionAssignmentsMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewCustomerCommissionAssignmentsMetadata._meta Is Nothing Then
                    ViewCustomerCommissionAssignmentsMetadata._meta = New ViewCustomerCommissionAssignmentsMetadata()
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
				

				meta.AddTypeMap("Custid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Custname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("City", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("State", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("SalespersonID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Salespersonfullname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Defaultrate", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Commtype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ProductID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Exceptionrate", new esTypeMap("float", "System.Double"))			
				
				
				 
				meta.Source = "viewCustomerCommissionAssignments"
				meta.Destination = "viewCustomerCommissionAssignments"
				
				meta.spInsert = "proc_viewCustomerCommissionAssignmentsInsert"
				meta.spUpdate = "proc_viewCustomerCommissionAssignmentsUpdate"
				meta.spDelete = "proc_viewCustomerCommissionAssignmentsDelete"
				meta.spLoadAll = "proc_viewCustomerCommissionAssignmentsLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCustomerCommissionAssignmentsLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewCustomerCommissionAssignmentsMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
