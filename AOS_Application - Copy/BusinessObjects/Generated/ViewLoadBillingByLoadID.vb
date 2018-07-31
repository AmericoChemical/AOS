'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/11/2014 1:36:08 PM
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
	MustInherit Public Class esViewLoadBillingByLoadIDCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewLoadBillingByLoadIDCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewLoadBillingByLoadIDQuery)
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
            Me.InitQuery(CType(query, esViewLoadBillingByLoadIDQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewLoadBillingByLoadID) As ViewLoadBillingByLoadID
			Return CType(MyBase.DetachEntity(entity), ViewLoadBillingByLoadID)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewLoadBillingByLoadID) As ViewLoadBillingByLoadID
			Return CType(MyBase.AttachEntity(entity), ViewLoadBillingByLoadID)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewLoadBillingByLoadIDCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewLoadBillingByLoadID
            Get
                Return TryCast(MyBase.Item(index), ViewLoadBillingByLoadID)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewLoadBillingByLoadID)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewLoadBillingByLoadID	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewLoadBillingByLoadIDQuery
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
												
						Case "Loadbillingid"
							Me.str.Loadbillingid = CType(value, string)
												
						Case "Loadid"
							Me.str.Loadid = CType(value, string)
												
						Case "CustomerID"
							Me.str.CustomerID = CType(value, string)
												
						Case "Custname"
							Me.str.Custname = CType(value, string)
												
						Case "CustomerPO"
							Me.str.CustomerPO = CType(value, string)
												
						Case "BilledAmount"
							Me.str.BilledAmount = CType(value, string)
												
						Case "BillingDate"
							Me.str.BillingDate = CType(value, string)
												
						Case "CreatedBy"
							Me.str.CreatedBy = CType(value, string)
												
						Case "InvoiceNumber"
							Me.str.InvoiceNumber = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Loadbillingid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Loadbillingid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Loadid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Loadid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "CustomerID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.CustomerID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "BilledAmount"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.BilledAmount = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "BillingDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.BillingDate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "InvoiceNumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.InvoiceNumber = CType(value, Nullable(Of System.Int32))
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
		' Maps to viewLoadBillingByLoadID.LOADBILLINGID
		' </summary>
		Public Overridable Property Loadbillingid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadBillingByLoadIDMetadata.ColumnNames.Loadbillingid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadBillingByLoadIDMetadata.ColumnNames.Loadbillingid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadBillingByLoadID.LOADID
		' </summary>
		Public Overridable Property Loadid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadBillingByLoadIDMetadata.ColumnNames.Loadid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadBillingByLoadIDMetadata.ColumnNames.Loadid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadBillingByLoadID.CustomerID
		' </summary>
		Public Overridable Property CustomerID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadBillingByLoadIDMetadata.ColumnNames.CustomerID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadBillingByLoadIDMetadata.ColumnNames.CustomerID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadBillingByLoadID.CUSTNAME
		' </summary>
		Public Overridable Property Custname As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadBillingByLoadIDMetadata.ColumnNames.Custname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadBillingByLoadIDMetadata.ColumnNames.Custname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadBillingByLoadID.CustomerPO
		' </summary>
		Public Overridable Property CustomerPO As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadBillingByLoadIDMetadata.ColumnNames.CustomerPO)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadBillingByLoadIDMetadata.ColumnNames.CustomerPO, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadBillingByLoadID.BilledAmount
		' </summary>
		Public Overridable Property BilledAmount As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewLoadBillingByLoadIDMetadata.ColumnNames.BilledAmount)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewLoadBillingByLoadIDMetadata.ColumnNames.BilledAmount, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadBillingByLoadID.BillingDate
		' </summary>
		Public Overridable Property BillingDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewLoadBillingByLoadIDMetadata.ColumnNames.BillingDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewLoadBillingByLoadIDMetadata.ColumnNames.BillingDate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadBillingByLoadID.CreatedBy
		' </summary>
		Public Overridable Property CreatedBy As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadBillingByLoadIDMetadata.ColumnNames.CreatedBy)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadBillingByLoadIDMetadata.ColumnNames.CreatedBy, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadBillingByLoadID.InvoiceNumber
		' </summary>
		Public Overridable Property InvoiceNumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadBillingByLoadIDMetadata.ColumnNames.InvoiceNumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadBillingByLoadIDMetadata.ColumnNames.InvoiceNumber, value)
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
		
			Public Sub New(ByVal entity As esViewLoadBillingByLoadID)
				Me.entity = entity
			End Sub				
		
	
			Public Property Loadbillingid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Loadbillingid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Loadbillingid = Nothing
					Else
						entity.Loadbillingid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Loadid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Loadid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Loadid = Nothing
					Else
						entity.Loadid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property CustomerID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.CustomerID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CustomerID = Nothing
					Else
						entity.CustomerID = Convert.ToInt32(Value)
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
		  	
			Public Property CustomerPO As System.String 
				Get
					Dim data_ As System.String = entity.CustomerPO
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CustomerPO = Nothing
					Else
						entity.CustomerPO = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BilledAmount As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.BilledAmount
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BilledAmount = Nothing
					Else
						entity.BilledAmount = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property BillingDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.BillingDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BillingDate = Nothing
					Else
						entity.BillingDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property CreatedBy As System.String 
				Get
					Dim data_ As System.String = entity.CreatedBy
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CreatedBy = Nothing
					Else
						entity.CreatedBy = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property InvoiceNumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.InvoiceNumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.InvoiceNumber = Nothing
					Else
						entity.InvoiceNumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewLoadBillingByLoadID
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewLoadBillingByLoadIDQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewLoadBillingByLoadID can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewLoadBillingByLoadIDQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewLoadBillingByLoadIDMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Loadbillingid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadBillingByLoadIDMetadata.ColumnNames.Loadbillingid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Loadid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadBillingByLoadIDMetadata.ColumnNames.Loadid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property CustomerID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadBillingByLoadIDMetadata.ColumnNames.CustomerID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Custname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadBillingByLoadIDMetadata.ColumnNames.Custname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CustomerPO As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadBillingByLoadIDMetadata.ColumnNames.CustomerPO, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BilledAmount As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadBillingByLoadIDMetadata.ColumnNames.BilledAmount, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property BillingDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadBillingByLoadIDMetadata.ColumnNames.BillingDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property CreatedBy As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadBillingByLoadIDMetadata.ColumnNames.CreatedBy, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property InvoiceNumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadBillingByLoadIDMetadata.ColumnNames.InvoiceNumber, esSystemType.Int32)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewLoadBillingByLoadIDCollection")> _
	Partial Public Class ViewLoadBillingByLoadIDCollection
		Inherits esViewLoadBillingByLoadIDCollection
		Implements IEnumerable(Of ViewLoadBillingByLoadID)
		
        Public Shared Widening Operator CType(ByVal coll As ViewLoadBillingByLoadIDCollection) As List(Of ViewLoadBillingByLoadID)
            Dim list As List(Of ViewLoadBillingByLoadID) = New List(Of ViewLoadBillingByLoadID)
            Dim emp As ViewLoadBillingByLoadID

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewLoadBillingByLoadIDMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewLoadBillingByLoadIDQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewLoadBillingByLoadID(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewLoadBillingByLoadID()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewLoadBillingByLoadIDQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewLoadBillingByLoadIDQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewLoadBillingByLoadIDQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewLoadBillingByLoadID 
			Return CType(MyBase.AddNewEntity(), ViewLoadBillingByLoadID)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewLoadBillingByLoadID) Implements IEnumerable(Of ViewLoadBillingByLoadID).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewLoadBillingByLoadID)(Me)
        End Function
		
		Private _query As ViewLoadBillingByLoadIDQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewLoadBillingByLoadID' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewLoadBillingByLoadID ()")> _
	<Serializable> _
	Partial Public Class ViewLoadBillingByLoadID 
		Inherits esViewLoadBillingByLoadID

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewLoadBillingByLoadIDMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewLoadBillingByLoadIDQuery

			If Me._query Is Nothing Then
				Me._query = New ViewLoadBillingByLoadIDQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewLoadBillingByLoadIDQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewLoadBillingByLoadIDQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewLoadBillingByLoadIDQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewLoadBillingByLoadIDQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewLoadBillingByLoadIDQuery
		inherits esViewLoadBillingByLoadIDQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewLoadBillingByLoadIDQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewLoadBillingByLoadIDMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewLoadBillingByLoadIDMetadata.ColumnNames.Loadbillingid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadBillingByLoadIDMetadata.PropertyNames.Loadbillingid
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadBillingByLoadIDMetadata.ColumnNames.Loadid, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadBillingByLoadIDMetadata.PropertyNames.Loadid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadBillingByLoadIDMetadata.ColumnNames.CustomerID, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadBillingByLoadIDMetadata.PropertyNames.CustomerID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadBillingByLoadIDMetadata.ColumnNames.Custname, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadBillingByLoadIDMetadata.PropertyNames.Custname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadBillingByLoadIDMetadata.ColumnNames.CustomerPO, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadBillingByLoadIDMetadata.PropertyNames.CustomerPO
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadBillingByLoadIDMetadata.ColumnNames.BilledAmount, 5, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewLoadBillingByLoadIDMetadata.PropertyNames.BilledAmount
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadBillingByLoadIDMetadata.ColumnNames.BillingDate, 6, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewLoadBillingByLoadIDMetadata.PropertyNames.BillingDate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadBillingByLoadIDMetadata.ColumnNames.CreatedBy, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadBillingByLoadIDMetadata.PropertyNames.CreatedBy
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadBillingByLoadIDMetadata.ColumnNames.InvoiceNumber, 8, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadBillingByLoadIDMetadata.PropertyNames.InvoiceNumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewLoadBillingByLoadIDMetadata
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
			 Public Const Loadbillingid As String = "LOADBILLINGID"
			 Public Const Loadid As String = "LOADID"
			 Public Const CustomerID As String = "CustomerID"
			 Public Const Custname As String = "CUSTNAME"
			 Public Const CustomerPO As String = "CustomerPO"
			 Public Const BilledAmount As String = "BilledAmount"
			 Public Const BillingDate As String = "BillingDate"
			 Public Const CreatedBy As String = "CreatedBy"
			 Public Const InvoiceNumber As String = "InvoiceNumber"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Loadbillingid As String = "Loadbillingid"
			 Public Const Loadid As String = "Loadid"
			 Public Const CustomerID As String = "CustomerID"
			 Public Const Custname As String = "Custname"
			 Public Const CustomerPO As String = "CustomerPO"
			 Public Const BilledAmount As String = "BilledAmount"
			 Public Const BillingDate As String = "BillingDate"
			 Public Const CreatedBy As String = "CreatedBy"
			 Public Const InvoiceNumber As String = "InvoiceNumber"
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
            SyncLock GetType(ViewLoadBillingByLoadIDMetadata)
			
				If ViewLoadBillingByLoadIDMetadata.mapDelegates Is Nothing Then
					ViewLoadBillingByLoadIDMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewLoadBillingByLoadIDMetadata._meta Is Nothing Then
                    ViewLoadBillingByLoadIDMetadata._meta = New ViewLoadBillingByLoadIDMetadata()
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
				

				meta.AddTypeMap("Loadbillingid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Loadid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("CustomerID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Custname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CustomerPO", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("BilledAmount", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("BillingDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("CreatedBy", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("InvoiceNumber", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "viewLoadBillingByLoadID"
				meta.Destination = "viewLoadBillingByLoadID"
				
				meta.spInsert = "proc_viewLoadBillingByLoadIDInsert"
				meta.spUpdate = "proc_viewLoadBillingByLoadIDUpdate"
				meta.spDelete = "proc_viewLoadBillingByLoadIDDelete"
				meta.spLoadAll = "proc_viewLoadBillingByLoadIDLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewLoadBillingByLoadIDLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewLoadBillingByLoadIDMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
