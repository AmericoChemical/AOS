'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/11/2014 1:36:11 PM
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
	MustInherit Public Class esViewRptRawMaterialAvailableInventoryCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewRptRawMaterialAvailableInventoryCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewRptRawMaterialAvailableInventoryQuery)
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
            Me.InitQuery(CType(query, esViewRptRawMaterialAvailableInventoryQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewRptRawMaterialAvailableInventory) As ViewRptRawMaterialAvailableInventory
			Return CType(MyBase.DetachEntity(entity), ViewRptRawMaterialAvailableInventory)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewRptRawMaterialAvailableInventory) As ViewRptRawMaterialAvailableInventory
			Return CType(MyBase.AttachEntity(entity), ViewRptRawMaterialAvailableInventory)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewRptRawMaterialAvailableInventoryCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewRptRawMaterialAvailableInventory
            Get
                Return TryCast(MyBase.Item(index), ViewRptRawMaterialAvailableInventory)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewRptRawMaterialAvailableInventory)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewRptRawMaterialAvailableInventory	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewRptRawMaterialAvailableInventoryQuery
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
												
						Case "Invitemnumber"
							Me.str.Invitemnumber = CType(value, string)
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Productdesc"
							Me.str.Productdesc = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "Warehouselocation"
							Me.str.Warehouselocation = CType(value, string)
												
						Case "Itemstatus"
							Me.str.Itemstatus = CType(value, string)
												
						Case "Unitsremaining"
							Me.str.Unitsremaining = CType(value, string)
												
						Case "FGContainers"
							Me.str.FGContainers = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Invitemnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Invitemnumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Unitsremaining"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Unitsremaining = CType(value, Nullable(Of System.Double))
							End If
						
						Case "FGContainers"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.FGContainers = CType(value, Nullable(Of System.Int32))
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
		' Maps to viewRptRawMaterialAvailableInventory.INVITEMNUMBER
		' </summary>
		Public Overridable Property Invitemnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptRawMaterialAvailableInventoryMetadata.ColumnNames.Invitemnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptRawMaterialAvailableInventoryMetadata.ColumnNames.Invitemnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptRawMaterialAvailableInventory.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptRawMaterialAvailableInventoryMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptRawMaterialAvailableInventoryMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptRawMaterialAvailableInventory.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewRptRawMaterialAvailableInventoryMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptRawMaterialAvailableInventoryMetadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptRawMaterialAvailableInventory.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewRptRawMaterialAvailableInventoryMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptRawMaterialAvailableInventoryMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptRawMaterialAvailableInventory.WAREHOUSELOCATION
		' </summary>
		Public Overridable Property Warehouselocation As System.String
			Get
				Return MyBase.GetSystemString(ViewRptRawMaterialAvailableInventoryMetadata.ColumnNames.Warehouselocation)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptRawMaterialAvailableInventoryMetadata.ColumnNames.Warehouselocation, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptRawMaterialAvailableInventory.ITEMSTATUS
		' </summary>
		Public Overridable Property Itemstatus As System.String
			Get
				Return MyBase.GetSystemString(ViewRptRawMaterialAvailableInventoryMetadata.ColumnNames.Itemstatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptRawMaterialAvailableInventoryMetadata.ColumnNames.Itemstatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptRawMaterialAvailableInventory.UNITSREMAINING
		' </summary>
		Public Overridable Property Unitsremaining As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewRptRawMaterialAvailableInventoryMetadata.ColumnNames.Unitsremaining)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewRptRawMaterialAvailableInventoryMetadata.ColumnNames.Unitsremaining, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptRawMaterialAvailableInventory.FGContainers
		' </summary>
		Public Overridable Property FGContainers As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptRawMaterialAvailableInventoryMetadata.ColumnNames.FGContainers)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptRawMaterialAvailableInventoryMetadata.ColumnNames.FGContainers, value)
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
		
			Public Sub New(ByVal entity As esViewRptRawMaterialAvailableInventory)
				Me.entity = entity
			End Sub				
		
	
			Public Property Invitemnumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Invitemnumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Invitemnumber = Nothing
					Else
						entity.Invitemnumber = Convert.ToInt32(Value)
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
		  	
			Public Property Warehouselocation As System.String 
				Get
					Dim data_ As System.String = entity.Warehouselocation
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Warehouselocation = Nothing
					Else
						entity.Warehouselocation = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Itemstatus As System.String 
				Get
					Dim data_ As System.String = entity.Itemstatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Itemstatus = Nothing
					Else
						entity.Itemstatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Unitsremaining As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Unitsremaining
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Unitsremaining = Nothing
					Else
						entity.Unitsremaining = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property FGContainers As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.FGContainers
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FGContainers = Nothing
					Else
						entity.FGContainers = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewRptRawMaterialAvailableInventory
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewRptRawMaterialAvailableInventoryQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewRptRawMaterialAvailableInventory can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewRptRawMaterialAvailableInventoryQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRptRawMaterialAvailableInventoryMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Invitemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptRawMaterialAvailableInventoryMetadata.ColumnNames.Invitemnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptRawMaterialAvailableInventoryMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptRawMaterialAvailableInventoryMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptRawMaterialAvailableInventoryMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Warehouselocation As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptRawMaterialAvailableInventoryMetadata.ColumnNames.Warehouselocation, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Itemstatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptRawMaterialAvailableInventoryMetadata.ColumnNames.Itemstatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Unitsremaining As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptRawMaterialAvailableInventoryMetadata.ColumnNames.Unitsremaining, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property FGContainers As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptRawMaterialAvailableInventoryMetadata.ColumnNames.FGContainers, esSystemType.Int32)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewRptRawMaterialAvailableInventoryCollection")> _
	Partial Public Class ViewRptRawMaterialAvailableInventoryCollection
		Inherits esViewRptRawMaterialAvailableInventoryCollection
		Implements IEnumerable(Of ViewRptRawMaterialAvailableInventory)
		
        Public Shared Widening Operator CType(ByVal coll As ViewRptRawMaterialAvailableInventoryCollection) As List(Of ViewRptRawMaterialAvailableInventory)
            Dim list As List(Of ViewRptRawMaterialAvailableInventory) = New List(Of ViewRptRawMaterialAvailableInventory)
            Dim emp As ViewRptRawMaterialAvailableInventory

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRptRawMaterialAvailableInventoryMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewRptRawMaterialAvailableInventoryQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewRptRawMaterialAvailableInventory(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewRptRawMaterialAvailableInventory()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewRptRawMaterialAvailableInventoryQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewRptRawMaterialAvailableInventoryQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRptRawMaterialAvailableInventoryQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewRptRawMaterialAvailableInventory 
			Return CType(MyBase.AddNewEntity(), ViewRptRawMaterialAvailableInventory)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewRptRawMaterialAvailableInventory) Implements IEnumerable(Of ViewRptRawMaterialAvailableInventory).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewRptRawMaterialAvailableInventory)(Me)
        End Function
		
		Private _query As ViewRptRawMaterialAvailableInventoryQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewRptRawMaterialAvailableInventory' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewRptRawMaterialAvailableInventory ()")> _
	<Serializable> _
	Partial Public Class ViewRptRawMaterialAvailableInventory 
		Inherits esViewRptRawMaterialAvailableInventory

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewRptRawMaterialAvailableInventoryMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewRptRawMaterialAvailableInventoryQuery

			If Me._query Is Nothing Then
				Me._query = New ViewRptRawMaterialAvailableInventoryQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewRptRawMaterialAvailableInventoryQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewRptRawMaterialAvailableInventoryQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRptRawMaterialAvailableInventoryQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewRptRawMaterialAvailableInventoryQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewRptRawMaterialAvailableInventoryQuery
		inherits esViewRptRawMaterialAvailableInventoryQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewRptRawMaterialAvailableInventoryQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewRptRawMaterialAvailableInventoryMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewRptRawMaterialAvailableInventoryMetadata.ColumnNames.Invitemnumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptRawMaterialAvailableInventoryMetadata.PropertyNames.Invitemnumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptRawMaterialAvailableInventoryMetadata.ColumnNames.Productid, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptRawMaterialAvailableInventoryMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptRawMaterialAvailableInventoryMetadata.ColumnNames.Productdesc, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptRawMaterialAvailableInventoryMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptRawMaterialAvailableInventoryMetadata.ColumnNames.Container, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptRawMaterialAvailableInventoryMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptRawMaterialAvailableInventoryMetadata.ColumnNames.Warehouselocation, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptRawMaterialAvailableInventoryMetadata.PropertyNames.Warehouselocation
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptRawMaterialAvailableInventoryMetadata.ColumnNames.Itemstatus, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptRawMaterialAvailableInventoryMetadata.PropertyNames.Itemstatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptRawMaterialAvailableInventoryMetadata.ColumnNames.Unitsremaining, 6, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewRptRawMaterialAvailableInventoryMetadata.PropertyNames.Unitsremaining
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptRawMaterialAvailableInventoryMetadata.ColumnNames.FGContainers, 7, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptRawMaterialAvailableInventoryMetadata.PropertyNames.FGContainers
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewRptRawMaterialAvailableInventoryMetadata
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
			 Public Const Invitemnumber As String = "INVITEMNUMBER"
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Productdesc As String = "PRODUCTDESC"
			 Public Const Container As String = "CONTAINER"
			 Public Const Warehouselocation As String = "WAREHOUSELOCATION"
			 Public Const Itemstatus As String = "ITEMSTATUS"
			 Public Const Unitsremaining As String = "UNITSREMAINING"
			 Public Const FGContainers As String = "FGContainers"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Invitemnumber As String = "Invitemnumber"
			 Public Const Productid As String = "Productid"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const Container As String = "Container"
			 Public Const Warehouselocation As String = "Warehouselocation"
			 Public Const Itemstatus As String = "Itemstatus"
			 Public Const Unitsremaining As String = "Unitsremaining"
			 Public Const FGContainers As String = "FGContainers"
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
            SyncLock GetType(ViewRptRawMaterialAvailableInventoryMetadata)
			
				If ViewRptRawMaterialAvailableInventoryMetadata.mapDelegates Is Nothing Then
					ViewRptRawMaterialAvailableInventoryMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewRptRawMaterialAvailableInventoryMetadata._meta Is Nothing Then
                    ViewRptRawMaterialAvailableInventoryMetadata._meta = New ViewRptRawMaterialAvailableInventoryMetadata()
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
				

				meta.AddTypeMap("Invitemnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Warehouselocation", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Itemstatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Unitsremaining", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("FGContainers", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "viewRptRawMaterialAvailableInventory"
				meta.Destination = "viewRptRawMaterialAvailableInventory"
				
				meta.spInsert = "proc_viewRptRawMaterialAvailableInventoryInsert"
				meta.spUpdate = "proc_viewRptRawMaterialAvailableInventoryUpdate"
				meta.spDelete = "proc_viewRptRawMaterialAvailableInventoryDelete"
				meta.spLoadAll = "proc_viewRptRawMaterialAvailableInventoryLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewRptRawMaterialAvailableInventoryLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewRptRawMaterialAvailableInventoryMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
