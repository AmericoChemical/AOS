'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 5/28/2014 12:22:23 PM
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
	MustInherit Public Class esViewRptInventoryProfitAndLossCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewRptInventoryProfitAndLossCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewRptInventoryProfitAndLossQuery)
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
            Me.InitQuery(CType(query, esViewRptInventoryProfitAndLossQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewRptInventoryProfitAndLoss) As ViewRptInventoryProfitAndLoss
			Return CType(MyBase.DetachEntity(entity), ViewRptInventoryProfitAndLoss)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewRptInventoryProfitAndLoss) As ViewRptInventoryProfitAndLoss
			Return CType(MyBase.AttachEntity(entity), ViewRptInventoryProfitAndLoss)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewRptInventoryProfitAndLossCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewRptInventoryProfitAndLoss
            Get
                Return TryCast(MyBase.Item(index), ViewRptInventoryProfitAndLoss)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewRptInventoryProfitAndLoss)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewRptInventoryProfitAndLoss	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewRptInventoryProfitAndLossQuery
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
												
						Case "Workorderdate"
							Me.str.Workorderdate = CType(value, string)
												
						Case "Subtotal"
							Me.str.Subtotal = CType(value, string)
												
						Case "Cost"
							Me.str.Cost = CType(value, string)
												
						Case "Price"
							Me.str.Price = CType(value, string)
												
						Case "Profit"
							Me.str.Profit = CType(value, string)
												
						Case "Custname"
							Me.str.Custname = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Workordernumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Workordernumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Workorderdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Workorderdate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Subtotal"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Subtotal = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Cost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Cost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Price"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Price = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Profit"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Profit = CType(value, Nullable(Of System.Decimal))
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
		' Maps to viewRptInventoryProfitAndLoss.WORKORDERNUMBER
		' </summary>
		Public Overridable Property Workordernumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptInventoryProfitAndLossMetadata.ColumnNames.Workordernumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptInventoryProfitAndLossMetadata.ColumnNames.Workordernumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInventoryProfitAndLoss.WORKORDERDATE
		' </summary>
		Public Overridable Property Workorderdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewRptInventoryProfitAndLossMetadata.ColumnNames.Workorderdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewRptInventoryProfitAndLossMetadata.ColumnNames.Workorderdate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInventoryProfitAndLoss.SUBTOTAL
		' </summary>
		Public Overridable Property Subtotal As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptInventoryProfitAndLossMetadata.ColumnNames.Subtotal)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptInventoryProfitAndLossMetadata.ColumnNames.Subtotal, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInventoryProfitAndLoss.Cost
		' </summary>
		Public Overridable Property Cost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptInventoryProfitAndLossMetadata.ColumnNames.Cost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptInventoryProfitAndLossMetadata.ColumnNames.Cost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInventoryProfitAndLoss.Price
		' </summary>
		Public Overridable Property Price As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptInventoryProfitAndLossMetadata.ColumnNames.Price)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptInventoryProfitAndLossMetadata.ColumnNames.Price, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInventoryProfitAndLoss.Profit
		' </summary>
		Public Overridable Property Profit As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptInventoryProfitAndLossMetadata.ColumnNames.Profit)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptInventoryProfitAndLossMetadata.ColumnNames.Profit, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInventoryProfitAndLoss.CUSTNAME
		' </summary>
		Public Overridable Property Custname As System.String
			Get
				Return MyBase.GetSystemString(ViewRptInventoryProfitAndLossMetadata.ColumnNames.Custname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptInventoryProfitAndLossMetadata.ColumnNames.Custname, value)
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
		
			Public Sub New(ByVal entity As esViewRptInventoryProfitAndLoss)
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
		  	
			Public Property Workorderdate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Workorderdate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Workorderdate = Nothing
					Else
						entity.Workorderdate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Subtotal As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Subtotal
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Subtotal = Nothing
					Else
						entity.Subtotal = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Cost As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Cost
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Cost = Nothing
					Else
						entity.Cost = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Price As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Price
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Price = Nothing
					Else
						entity.Price = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Profit As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Profit
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Profit = Nothing
					Else
						entity.Profit = Convert.ToDecimal(Value)
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
		  

			Private entity As esViewRptInventoryProfitAndLoss
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewRptInventoryProfitAndLossQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewRptInventoryProfitAndLoss can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewRptInventoryProfitAndLossQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRptInventoryProfitAndLossMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Workordernumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInventoryProfitAndLossMetadata.ColumnNames.Workordernumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Workorderdate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInventoryProfitAndLossMetadata.ColumnNames.Workorderdate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Subtotal As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInventoryProfitAndLossMetadata.ColumnNames.Subtotal, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Cost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInventoryProfitAndLossMetadata.ColumnNames.Cost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Price As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInventoryProfitAndLossMetadata.ColumnNames.Price, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Profit As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInventoryProfitAndLossMetadata.ColumnNames.Profit, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Custname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInventoryProfitAndLossMetadata.ColumnNames.Custname, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewRptInventoryProfitAndLossCollection")> _
	Partial Public Class ViewRptInventoryProfitAndLossCollection
		Inherits esViewRptInventoryProfitAndLossCollection
		Implements IEnumerable(Of ViewRptInventoryProfitAndLoss)
		
        Public Shared Widening Operator CType(ByVal coll As ViewRptInventoryProfitAndLossCollection) As List(Of ViewRptInventoryProfitAndLoss)
            Dim list As List(Of ViewRptInventoryProfitAndLoss) = New List(Of ViewRptInventoryProfitAndLoss)
            Dim emp As ViewRptInventoryProfitAndLoss

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRptInventoryProfitAndLossMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewRptInventoryProfitAndLossQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewRptInventoryProfitAndLoss(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewRptInventoryProfitAndLoss()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewRptInventoryProfitAndLossQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewRptInventoryProfitAndLossQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRptInventoryProfitAndLossQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewRptInventoryProfitAndLoss 
			Return CType(MyBase.AddNewEntity(), ViewRptInventoryProfitAndLoss)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewRptInventoryProfitAndLoss) Implements IEnumerable(Of ViewRptInventoryProfitAndLoss).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewRptInventoryProfitAndLoss)(Me)
        End Function
		
		Private _query As ViewRptInventoryProfitAndLossQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewRptInventoryProfitAndLoss' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewRptInventoryProfitAndLoss ()")> _
	<Serializable> _
	Partial Public Class ViewRptInventoryProfitAndLoss 
		Inherits esViewRptInventoryProfitAndLoss

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewRptInventoryProfitAndLossMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewRptInventoryProfitAndLossQuery

			If Me._query Is Nothing Then
				Me._query = New ViewRptInventoryProfitAndLossQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewRptInventoryProfitAndLossQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewRptInventoryProfitAndLossQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRptInventoryProfitAndLossQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewRptInventoryProfitAndLossQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewRptInventoryProfitAndLossQuery
		inherits esViewRptInventoryProfitAndLossQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewRptInventoryProfitAndLossQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewRptInventoryProfitAndLossMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewRptInventoryProfitAndLossMetadata.ColumnNames.Workordernumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptInventoryProfitAndLossMetadata.PropertyNames.Workordernumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInventoryProfitAndLossMetadata.ColumnNames.Workorderdate, 1, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewRptInventoryProfitAndLossMetadata.PropertyNames.Workorderdate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInventoryProfitAndLossMetadata.ColumnNames.Subtotal, 2, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptInventoryProfitAndLossMetadata.PropertyNames.Subtotal
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInventoryProfitAndLossMetadata.ColumnNames.Cost, 3, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptInventoryProfitAndLossMetadata.PropertyNames.Cost
			c.NumericPrecision = 38
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInventoryProfitAndLossMetadata.ColumnNames.Price, 4, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptInventoryProfitAndLossMetadata.PropertyNames.Price
			c.NumericPrecision = 38
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInventoryProfitAndLossMetadata.ColumnNames.Profit, 5, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptInventoryProfitAndLossMetadata.PropertyNames.Profit
			c.NumericPrecision = 38
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInventoryProfitAndLossMetadata.ColumnNames.Custname, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptInventoryProfitAndLossMetadata.PropertyNames.Custname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewRptInventoryProfitAndLossMetadata
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
			 Public Const Workorderdate As String = "WORKORDERDATE"
			 Public Const Subtotal As String = "SUBTOTAL"
			 Public Const Cost As String = "Cost"
			 Public Const Price As String = "Price"
			 Public Const Profit As String = "Profit"
			 Public Const Custname As String = "CUSTNAME"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Workordernumber As String = "Workordernumber"
			 Public Const Workorderdate As String = "Workorderdate"
			 Public Const Subtotal As String = "Subtotal"
			 Public Const Cost As String = "Cost"
			 Public Const Price As String = "Price"
			 Public Const Profit As String = "Profit"
			 Public Const Custname As String = "Custname"
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
            SyncLock GetType(ViewRptInventoryProfitAndLossMetadata)
			
				If ViewRptInventoryProfitAndLossMetadata.mapDelegates Is Nothing Then
					ViewRptInventoryProfitAndLossMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewRptInventoryProfitAndLossMetadata._meta Is Nothing Then
                    ViewRptInventoryProfitAndLossMetadata._meta = New ViewRptInventoryProfitAndLossMetadata()
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
				meta.AddTypeMap("Workorderdate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Subtotal", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Cost", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Price", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Profit", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Custname", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewRptInventoryProfitAndLoss"
				meta.Destination = "viewRptInventoryProfitAndLoss"
				
				meta.spInsert = "proc_viewRptInventoryProfitAndLossInsert"
				meta.spUpdate = "proc_viewRptInventoryProfitAndLossUpdate"
				meta.spDelete = "proc_viewRptInventoryProfitAndLossDelete"
				meta.spLoadAll = "proc_viewRptInventoryProfitAndLossLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewRptInventoryProfitAndLossLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewRptInventoryProfitAndLossMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
