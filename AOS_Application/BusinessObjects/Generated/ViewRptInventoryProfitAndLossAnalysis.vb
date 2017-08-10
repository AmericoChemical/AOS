'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 7/28/2014 8:06:36 PM
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
	MustInherit Public Class esViewRptInventoryProfitAndLossAnalysisCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewRptInventoryProfitAndLossAnalysisCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewRptInventoryProfitAndLossAnalysisQuery)
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
            Me.InitQuery(CType(query, esViewRptInventoryProfitAndLossAnalysisQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewRptInventoryProfitAndLossAnalysis) As ViewRptInventoryProfitAndLossAnalysis
			Return CType(MyBase.DetachEntity(entity), ViewRptInventoryProfitAndLossAnalysis)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewRptInventoryProfitAndLossAnalysis) As ViewRptInventoryProfitAndLossAnalysis
			Return CType(MyBase.AttachEntity(entity), ViewRptInventoryProfitAndLossAnalysis)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewRptInventoryProfitAndLossAnalysisCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewRptInventoryProfitAndLossAnalysis
            Get
                Return TryCast(MyBase.Item(index), ViewRptInventoryProfitAndLossAnalysis)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewRptInventoryProfitAndLossAnalysis)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewRptInventoryProfitAndLossAnalysis	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewRptInventoryProfitAndLossAnalysisQuery
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
												
						Case "Custname"
							Me.str.Custname = CType(value, string)
												
						Case "Cost"
							Me.str.Cost = CType(value, string)
												
						Case "Price"
							Me.str.Price = CType(value, string)
												
						Case "Profit"
							Me.str.Profit = CType(value, string)
												
						Case "Extprice"
							Me.str.Extprice = CType(value, string)
												
						Case "Standardcost"
							Me.str.Standardcost = CType(value, string)
												
						Case "Actualunitcost"
							Me.str.Actualunitcost = CType(value, string)
												
						Case "Stdprofit"
							Me.str.Stdprofit = CType(value, string)
												
						Case "Actprofit"
							Me.str.Actprofit = CType(value, string)
					
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
						
						Case "Extprice"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Extprice = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Standardcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Standardcost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Actualunitcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Actualunitcost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Stdprofit"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Stdprofit = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Actprofit"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Actprofit = CType(value, Nullable(Of System.Decimal))
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
		' Maps to viewRptInventoryProfitAndLossAnalysis.WORKORDERNUMBER
		' </summary>
		Public Overridable Property Workordernumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptInventoryProfitAndLossAnalysisMetadata.ColumnNames.Workordernumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptInventoryProfitAndLossAnalysisMetadata.ColumnNames.Workordernumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInventoryProfitAndLossAnalysis.WORKORDERDATE
		' </summary>
		Public Overridable Property Workorderdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewRptInventoryProfitAndLossAnalysisMetadata.ColumnNames.Workorderdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewRptInventoryProfitAndLossAnalysisMetadata.ColumnNames.Workorderdate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInventoryProfitAndLossAnalysis.SUBTOTAL
		' </summary>
		Public Overridable Property Subtotal As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptInventoryProfitAndLossAnalysisMetadata.ColumnNames.Subtotal)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptInventoryProfitAndLossAnalysisMetadata.ColumnNames.Subtotal, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInventoryProfitAndLossAnalysis.CUSTNAME
		' </summary>
		Public Overridable Property Custname As System.String
			Get
				Return MyBase.GetSystemString(ViewRptInventoryProfitAndLossAnalysisMetadata.ColumnNames.Custname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptInventoryProfitAndLossAnalysisMetadata.ColumnNames.Custname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInventoryProfitAndLossAnalysis.Cost
		' </summary>
		Public Overridable Property Cost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptInventoryProfitAndLossAnalysisMetadata.ColumnNames.Cost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptInventoryProfitAndLossAnalysisMetadata.ColumnNames.Cost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInventoryProfitAndLossAnalysis.Price
		' </summary>
		Public Overridable Property Price As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptInventoryProfitAndLossAnalysisMetadata.ColumnNames.Price)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptInventoryProfitAndLossAnalysisMetadata.ColumnNames.Price, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInventoryProfitAndLossAnalysis.Profit
		' </summary>
		Public Overridable Property Profit As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptInventoryProfitAndLossAnalysisMetadata.ColumnNames.Profit)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptInventoryProfitAndLossAnalysisMetadata.ColumnNames.Profit, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInventoryProfitAndLossAnalysis.EXTPRICE
		' </summary>
		Public Overridable Property Extprice As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptInventoryProfitAndLossAnalysisMetadata.ColumnNames.Extprice)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptInventoryProfitAndLossAnalysisMetadata.ColumnNames.Extprice, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInventoryProfitAndLossAnalysis.STANDARDCOST
		' </summary>
		Public Overridable Property Standardcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptInventoryProfitAndLossAnalysisMetadata.ColumnNames.Standardcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptInventoryProfitAndLossAnalysisMetadata.ColumnNames.Standardcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInventoryProfitAndLossAnalysis.ACTUALUNITCOST
		' </summary>
		Public Overridable Property Actualunitcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptInventoryProfitAndLossAnalysisMetadata.ColumnNames.Actualunitcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptInventoryProfitAndLossAnalysisMetadata.ColumnNames.Actualunitcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInventoryProfitAndLossAnalysis.STDPROFIT
		' </summary>
		Public Overridable Property Stdprofit As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptInventoryProfitAndLossAnalysisMetadata.ColumnNames.Stdprofit)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptInventoryProfitAndLossAnalysisMetadata.ColumnNames.Stdprofit, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptInventoryProfitAndLossAnalysis.ACTPROFIT
		' </summary>
		Public Overridable Property Actprofit As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRptInventoryProfitAndLossAnalysisMetadata.ColumnNames.Actprofit)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRptInventoryProfitAndLossAnalysisMetadata.ColumnNames.Actprofit, value)
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
		
			Public Sub New(ByVal entity As esViewRptInventoryProfitAndLossAnalysis)
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
		  	
			Public Property Extprice As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Extprice
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Extprice = Nothing
					Else
						entity.Extprice = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Standardcost As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Standardcost
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Standardcost = Nothing
					Else
						entity.Standardcost = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Actualunitcost As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Actualunitcost
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Actualunitcost = Nothing
					Else
						entity.Actualunitcost = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Stdprofit As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Stdprofit
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Stdprofit = Nothing
					Else
						entity.Stdprofit = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Actprofit As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Actprofit
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Actprofit = Nothing
					Else
						entity.Actprofit = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewRptInventoryProfitAndLossAnalysis
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewRptInventoryProfitAndLossAnalysisQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewRptInventoryProfitAndLossAnalysis can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewRptInventoryProfitAndLossAnalysisQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRptInventoryProfitAndLossAnalysisMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Workordernumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInventoryProfitAndLossAnalysisMetadata.ColumnNames.Workordernumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Workorderdate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInventoryProfitAndLossAnalysisMetadata.ColumnNames.Workorderdate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Subtotal As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInventoryProfitAndLossAnalysisMetadata.ColumnNames.Subtotal, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Custname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInventoryProfitAndLossAnalysisMetadata.ColumnNames.Custname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Cost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInventoryProfitAndLossAnalysisMetadata.ColumnNames.Cost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Price As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInventoryProfitAndLossAnalysisMetadata.ColumnNames.Price, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Profit As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInventoryProfitAndLossAnalysisMetadata.ColumnNames.Profit, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Extprice As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInventoryProfitAndLossAnalysisMetadata.ColumnNames.Extprice, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Standardcost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInventoryProfitAndLossAnalysisMetadata.ColumnNames.Standardcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Actualunitcost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInventoryProfitAndLossAnalysisMetadata.ColumnNames.Actualunitcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Stdprofit As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInventoryProfitAndLossAnalysisMetadata.ColumnNames.Stdprofit, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Actprofit As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptInventoryProfitAndLossAnalysisMetadata.ColumnNames.Actprofit, esSystemType.Decimal)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewRptInventoryProfitAndLossAnalysisCollection")> _
	Partial Public Class ViewRptInventoryProfitAndLossAnalysisCollection
		Inherits esViewRptInventoryProfitAndLossAnalysisCollection
		Implements IEnumerable(Of ViewRptInventoryProfitAndLossAnalysis)
		
        Public Shared Widening Operator CType(ByVal coll As ViewRptInventoryProfitAndLossAnalysisCollection) As List(Of ViewRptInventoryProfitAndLossAnalysis)
            Dim list As List(Of ViewRptInventoryProfitAndLossAnalysis) = New List(Of ViewRptInventoryProfitAndLossAnalysis)
            Dim emp As ViewRptInventoryProfitAndLossAnalysis

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRptInventoryProfitAndLossAnalysisMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewRptInventoryProfitAndLossAnalysisQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewRptInventoryProfitAndLossAnalysis(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewRptInventoryProfitAndLossAnalysis()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewRptInventoryProfitAndLossAnalysisQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewRptInventoryProfitAndLossAnalysisQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRptInventoryProfitAndLossAnalysisQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewRptInventoryProfitAndLossAnalysis 
			Return CType(MyBase.AddNewEntity(), ViewRptInventoryProfitAndLossAnalysis)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewRptInventoryProfitAndLossAnalysis) Implements IEnumerable(Of ViewRptInventoryProfitAndLossAnalysis).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewRptInventoryProfitAndLossAnalysis)(Me)
        End Function
		
		Private _query As ViewRptInventoryProfitAndLossAnalysisQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewRptInventoryProfitAndLossAnalysis' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewRptInventoryProfitAndLossAnalysis ()")> _
	<Serializable> _
	Partial Public Class ViewRptInventoryProfitAndLossAnalysis 
		Inherits esViewRptInventoryProfitAndLossAnalysis

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewRptInventoryProfitAndLossAnalysisMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewRptInventoryProfitAndLossAnalysisQuery

			If Me._query Is Nothing Then
				Me._query = New ViewRptInventoryProfitAndLossAnalysisQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewRptInventoryProfitAndLossAnalysisQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewRptInventoryProfitAndLossAnalysisQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRptInventoryProfitAndLossAnalysisQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewRptInventoryProfitAndLossAnalysisQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewRptInventoryProfitAndLossAnalysisQuery
		inherits esViewRptInventoryProfitAndLossAnalysisQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewRptInventoryProfitAndLossAnalysisQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewRptInventoryProfitAndLossAnalysisMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewRptInventoryProfitAndLossAnalysisMetadata.ColumnNames.Workordernumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptInventoryProfitAndLossAnalysisMetadata.PropertyNames.Workordernumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInventoryProfitAndLossAnalysisMetadata.ColumnNames.Workorderdate, 1, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewRptInventoryProfitAndLossAnalysisMetadata.PropertyNames.Workorderdate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInventoryProfitAndLossAnalysisMetadata.ColumnNames.Subtotal, 2, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptInventoryProfitAndLossAnalysisMetadata.PropertyNames.Subtotal
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInventoryProfitAndLossAnalysisMetadata.ColumnNames.Custname, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptInventoryProfitAndLossAnalysisMetadata.PropertyNames.Custname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInventoryProfitAndLossAnalysisMetadata.ColumnNames.Cost, 4, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptInventoryProfitAndLossAnalysisMetadata.PropertyNames.Cost
			c.NumericPrecision = 38
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInventoryProfitAndLossAnalysisMetadata.ColumnNames.Price, 5, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptInventoryProfitAndLossAnalysisMetadata.PropertyNames.Price
			c.NumericPrecision = 38
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInventoryProfitAndLossAnalysisMetadata.ColumnNames.Profit, 6, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptInventoryProfitAndLossAnalysisMetadata.PropertyNames.Profit
			c.NumericPrecision = 38
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInventoryProfitAndLossAnalysisMetadata.ColumnNames.Extprice, 7, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptInventoryProfitAndLossAnalysisMetadata.PropertyNames.Extprice
			c.NumericPrecision = 38
			c.NumericScale = 6
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInventoryProfitAndLossAnalysisMetadata.ColumnNames.Standardcost, 8, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptInventoryProfitAndLossAnalysisMetadata.PropertyNames.Standardcost
			c.NumericPrecision = 38
			c.NumericScale = 6
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInventoryProfitAndLossAnalysisMetadata.ColumnNames.Actualunitcost, 9, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptInventoryProfitAndLossAnalysisMetadata.PropertyNames.Actualunitcost
			c.NumericPrecision = 38
			c.NumericScale = 6
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInventoryProfitAndLossAnalysisMetadata.ColumnNames.Stdprofit, 10, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptInventoryProfitAndLossAnalysisMetadata.PropertyNames.Stdprofit
			c.NumericPrecision = 38
			c.NumericScale = 6
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptInventoryProfitAndLossAnalysisMetadata.ColumnNames.Actprofit, 11, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRptInventoryProfitAndLossAnalysisMetadata.PropertyNames.Actprofit
			c.NumericPrecision = 38
			c.NumericScale = 6
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewRptInventoryProfitAndLossAnalysisMetadata
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
			 Public Const Custname As String = "CUSTNAME"
			 Public Const Cost As String = "Cost"
			 Public Const Price As String = "Price"
			 Public Const Profit As String = "Profit"
			 Public Const Extprice As String = "EXTPRICE"
			 Public Const Standardcost As String = "STANDARDCOST"
			 Public Const Actualunitcost As String = "ACTUALUNITCOST"
			 Public Const Stdprofit As String = "STDPROFIT"
			 Public Const Actprofit As String = "ACTPROFIT"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Workordernumber As String = "Workordernumber"
			 Public Const Workorderdate As String = "Workorderdate"
			 Public Const Subtotal As String = "Subtotal"
			 Public Const Custname As String = "Custname"
			 Public Const Cost As String = "Cost"
			 Public Const Price As String = "Price"
			 Public Const Profit As String = "Profit"
			 Public Const Extprice As String = "Extprice"
			 Public Const Standardcost As String = "Standardcost"
			 Public Const Actualunitcost As String = "Actualunitcost"
			 Public Const Stdprofit As String = "Stdprofit"
			 Public Const Actprofit As String = "Actprofit"
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
            SyncLock GetType(ViewRptInventoryProfitAndLossAnalysisMetadata)
			
				If ViewRptInventoryProfitAndLossAnalysisMetadata.mapDelegates Is Nothing Then
					ViewRptInventoryProfitAndLossAnalysisMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewRptInventoryProfitAndLossAnalysisMetadata._meta Is Nothing Then
                    ViewRptInventoryProfitAndLossAnalysisMetadata._meta = New ViewRptInventoryProfitAndLossAnalysisMetadata()
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
				meta.AddTypeMap("Custname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Cost", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Price", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Profit", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Extprice", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Standardcost", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Actualunitcost", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Stdprofit", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Actprofit", new esTypeMap("numeric", "System.Decimal"))			
				
				
				 
				meta.Source = "viewRptInventoryProfitAndLossAnalysis"
				meta.Destination = "viewRptInventoryProfitAndLossAnalysis"
				
				meta.spInsert = "proc_viewRptInventoryProfitAndLossAnalysisInsert"
				meta.spUpdate = "proc_viewRptInventoryProfitAndLossAnalysisUpdate"
				meta.spDelete = "proc_viewRptInventoryProfitAndLossAnalysisDelete"
				meta.spLoadAll = "proc_viewRptInventoryProfitAndLossAnalysisLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewRptInventoryProfitAndLossAnalysisLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewRptInventoryProfitAndLossAnalysisMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
