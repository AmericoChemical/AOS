'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 11/10/2014 9:51:14 PM
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
	MustInherit Public Class esViewWorkOrderProductAPISCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewWorkOrderProductAPISCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewWorkOrderProductAPISQuery)
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
            Me.InitQuery(CType(query, esViewWorkOrderProductAPISQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewWorkOrderProductAPIS) As ViewWorkOrderProductAPIS
			Return CType(MyBase.DetachEntity(entity), ViewWorkOrderProductAPIS)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewWorkOrderProductAPIS) As ViewWorkOrderProductAPIS
			Return CType(MyBase.AttachEntity(entity), ViewWorkOrderProductAPIS)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewWorkOrderProductAPISCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewWorkOrderProductAPIS
            Get
                Return TryCast(MyBase.Item(index), ViewWorkOrderProductAPIS)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewWorkOrderProductAPIS)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewWorkOrderProductAPIS	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewWorkOrderProductAPISQuery
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
												
						Case "Workordernumber"
							Me.str.Workordernumber = CType(value, string)
												
						Case "Custid"
							Me.str.Custid = CType(value, string)
												
						Case "Custname"
							Me.str.Custname = CType(value, string)
												
						Case "Qty"
							Me.str.Qty = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Productdesc"
							Me.str.Productdesc = CType(value, string)
												
						Case "Workordernumberno"
							Me.str.Workordernumberno = CType(value, string)
												
						Case "Cusname"
							Me.str.Cusname = CType(value, string)
												
						Case "Productdescription"
							Me.str.Productdescription = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Workordernumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Workordernumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Custid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Custid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Qty"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Qty = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
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
		' Maps to viewWorkOrderProductAPIS.WORKORDERNUMBER
		' </summary>
		Public Overridable Property Workordernumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewWorkOrderProductAPISMetadata.ColumnNames.Workordernumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewWorkOrderProductAPISMetadata.ColumnNames.Workordernumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderProductAPIS.CUSTID
		' </summary>
		Public Overridable Property Custid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewWorkOrderProductAPISMetadata.ColumnNames.Custid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewWorkOrderProductAPISMetadata.ColumnNames.Custid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderProductAPIS.CUSTNAME
		' </summary>
		Public Overridable Property Custname As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderProductAPISMetadata.ColumnNames.Custname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderProductAPISMetadata.ColumnNames.Custname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderProductAPIS.QTY
		' </summary>
		Public Overridable Property Qty As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewWorkOrderProductAPISMetadata.ColumnNames.Qty)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewWorkOrderProductAPISMetadata.ColumnNames.Qty, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderProductAPIS.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderProductAPISMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderProductAPISMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderProductAPIS.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewWorkOrderProductAPISMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewWorkOrderProductAPISMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderProductAPIS.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderProductAPISMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderProductAPISMetadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderProductAPIS.WORKORDERNUMBERNO
		' </summary>
		Public Overridable Property Workordernumberno As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderProductAPISMetadata.ColumnNames.Workordernumberno)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderProductAPISMetadata.ColumnNames.Workordernumberno, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderProductAPIS.CUSNAME
		' </summary>
		Public Overridable Property Cusname As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderProductAPISMetadata.ColumnNames.Cusname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderProductAPISMetadata.ColumnNames.Cusname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrderProductAPIS.PRODUCTDESCRIPTION
		' </summary>
		Public Overridable Property Productdescription As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrderProductAPISMetadata.ColumnNames.Productdescription)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrderProductAPISMetadata.ColumnNames.Productdescription, value)
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
		
			Public Sub New(ByVal entity As esViewWorkOrderProductAPIS)
				Me.entity = entity
			End Sub				
		
	
			Public Property Workordernumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Workordernumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Workordernumber = Nothing
					Else
						entity.Workordernumber = Convert.ToInt32(Value)
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
		  	
			Public Property Qty As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Qty
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qty = Nothing
					Else
						entity.Qty = Convert.ToDecimal(Value)
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
		  	
			Public Property Workordernumberno As System.String 
				Get
					Dim data_ As System.String = entity.Workordernumberno
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Workordernumberno = Nothing
					Else
						entity.Workordernumberno = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Cusname As System.String 
				Get
					Dim data_ As System.String = entity.Cusname
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Cusname = Nothing
					Else
						entity.Cusname = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Productdescription As System.String 
				Get
					Dim data_ As System.String = entity.Productdescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Productdescription = Nothing
					Else
						entity.Productdescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewWorkOrderProductAPIS
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewWorkOrderProductAPISQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewWorkOrderProductAPIS can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewWorkOrderProductAPISQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewWorkOrderProductAPISMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Workordernumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderProductAPISMetadata.ColumnNames.Workordernumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Custid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderProductAPISMetadata.ColumnNames.Custid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Custname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderProductAPISMetadata.ColumnNames.Custname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Qty As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderProductAPISMetadata.ColumnNames.Qty, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderProductAPISMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderProductAPISMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderProductAPISMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Workordernumberno As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderProductAPISMetadata.ColumnNames.Workordernumberno, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Cusname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderProductAPISMetadata.ColumnNames.Cusname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Productdescription As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrderProductAPISMetadata.ColumnNames.Productdescription, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewWorkOrderProductAPISCollection")> _
	Partial Public Class ViewWorkOrderProductAPISCollection
		Inherits esViewWorkOrderProductAPISCollection
		Implements IEnumerable(Of ViewWorkOrderProductAPIS)
		
        Public Shared Widening Operator CType(ByVal coll As ViewWorkOrderProductAPISCollection) As List(Of ViewWorkOrderProductAPIS)
            Dim list As List(Of ViewWorkOrderProductAPIS) = New List(Of ViewWorkOrderProductAPIS)
            Dim emp As ViewWorkOrderProductAPIS

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewWorkOrderProductAPISMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewWorkOrderProductAPISQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewWorkOrderProductAPIS(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewWorkOrderProductAPIS()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewWorkOrderProductAPISQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewWorkOrderProductAPISQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewWorkOrderProductAPISQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewWorkOrderProductAPIS 
			Return CType(MyBase.AddNewEntity(), ViewWorkOrderProductAPIS)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewWorkOrderProductAPIS) Implements IEnumerable(Of ViewWorkOrderProductAPIS).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewWorkOrderProductAPIS)(Me)
        End Function
		
		Private _query As ViewWorkOrderProductAPISQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewWorkOrderProductAPIS' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewWorkOrderProductAPIS ()")> _
	<Serializable> _
	Partial Public Class ViewWorkOrderProductAPIS 
		Inherits esViewWorkOrderProductAPIS

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewWorkOrderProductAPISMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewWorkOrderProductAPISQuery

			If Me._query Is Nothing Then
				Me._query = New ViewWorkOrderProductAPISQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewWorkOrderProductAPISQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewWorkOrderProductAPISQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewWorkOrderProductAPISQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewWorkOrderProductAPISQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewWorkOrderProductAPISQuery
		inherits esViewWorkOrderProductAPISQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewWorkOrderProductAPISQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewWorkOrderProductAPISMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewWorkOrderProductAPISMetadata.ColumnNames.Workordernumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewWorkOrderProductAPISMetadata.PropertyNames.Workordernumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderProductAPISMetadata.ColumnNames.Custid, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewWorkOrderProductAPISMetadata.PropertyNames.Custid
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderProductAPISMetadata.ColumnNames.Custname, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderProductAPISMetadata.PropertyNames.Custname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderProductAPISMetadata.ColumnNames.Qty, 3, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewWorkOrderProductAPISMetadata.PropertyNames.Qty
			c.NumericPrecision = 38
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderProductAPISMetadata.ColumnNames.Container, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderProductAPISMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderProductAPISMetadata.ColumnNames.Productid, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewWorkOrderProductAPISMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderProductAPISMetadata.ColumnNames.Productdesc, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderProductAPISMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderProductAPISMetadata.ColumnNames.Workordernumberno, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderProductAPISMetadata.PropertyNames.Workordernumberno
			c.CharacterMaxLength = 1
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderProductAPISMetadata.ColumnNames.Cusname, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderProductAPISMetadata.PropertyNames.Cusname
			c.CharacterMaxLength = 1
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrderProductAPISMetadata.ColumnNames.Productdescription, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrderProductAPISMetadata.PropertyNames.Productdescription
			c.CharacterMaxLength = 1
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewWorkOrderProductAPISMetadata
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
			 Public Const Workordernumber As String = "WORKORDERNUMBER"
			 Public Const Custid As String = "CUSTID"
			 Public Const Custname As String = "CUSTNAME"
			 Public Const Qty As String = "QTY"
			 Public Const Container As String = "CONTAINER"
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Productdesc As String = "PRODUCTDESC"
			 Public Const Workordernumberno As String = "WORKORDERNUMBERNO"
			 Public Const Cusname As String = "CUSNAME"
			 Public Const Productdescription As String = "PRODUCTDESCRIPTION"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Workordernumber As String = "Workordernumber"
			 Public Const Custid As String = "Custid"
			 Public Const Custname As String = "Custname"
			 Public Const Qty As String = "Qty"
			 Public Const Container As String = "Container"
			 Public Const Productid As String = "Productid"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const Workordernumberno As String = "Workordernumberno"
			 Public Const Cusname As String = "Cusname"
			 Public Const Productdescription As String = "Productdescription"
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
            SyncLock GetType(ViewWorkOrderProductAPISMetadata)
			
				If ViewWorkOrderProductAPISMetadata.mapDelegates Is Nothing Then
					ViewWorkOrderProductAPISMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewWorkOrderProductAPISMetadata._meta Is Nothing Then
                    ViewWorkOrderProductAPISMetadata._meta = New ViewWorkOrderProductAPISMetadata()
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
				

				meta.AddTypeMap("Workordernumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Custid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Custname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Qty", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Productid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Workordernumberno", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Cusname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Productdescription", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewWorkOrderProductAPIS"
				meta.Destination = "viewWorkOrderProductAPIS"
				
				meta.spInsert = "proc_viewWorkOrderProductAPISInsert"
				meta.spUpdate = "proc_viewWorkOrderProductAPISUpdate"
				meta.spDelete = "proc_viewWorkOrderProductAPISDelete"
				meta.spLoadAll = "proc_viewWorkOrderProductAPISLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewWorkOrderProductAPISLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewWorkOrderProductAPISMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
