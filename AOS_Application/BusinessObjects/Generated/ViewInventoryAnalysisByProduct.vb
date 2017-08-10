'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 9/10/2015 12:39:39 PM
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
	MustInherit Public Class esViewInventoryAnalysisByProductCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewInventoryAnalysisByProductCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewInventoryAnalysisByProductQuery)
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
            Me.InitQuery(CType(query, esViewInventoryAnalysisByProductQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewInventoryAnalysisByProduct) As ViewInventoryAnalysisByProduct
			Return CType(MyBase.DetachEntity(entity), ViewInventoryAnalysisByProduct)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewInventoryAnalysisByProduct) As ViewInventoryAnalysisByProduct
			Return CType(MyBase.AttachEntity(entity), ViewInventoryAnalysisByProduct)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewInventoryAnalysisByProductCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewInventoryAnalysisByProduct
            Get
                Return TryCast(MyBase.Item(index), ViewInventoryAnalysisByProduct)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewInventoryAnalysisByProduct)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewInventoryAnalysisByProduct	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewInventoryAnalysisByProductQuery
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
												
						Case "Inventorygrouping"
							Me.str.Inventorygrouping = CType(value, string)
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Productdesc"
							Me.str.Productdesc = CType(value, string)
												
						Case "Desc2"
							Me.str.Desc2 = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "Units"
							Me.str.Units = CType(value, string)
												
						Case "Uom"
							Me.str.Uom = CType(value, string)
												
						Case "FullAvailable"
							Me.str.FullAvailable = CType(value, string)
												
						Case "QtyRequested"
							Me.str.QtyRequested = CType(value, string)
												
						Case "FullAvailableContainers"
							Me.str.FullAvailableContainers = CType(value, string)
												
						Case "POContainers"
							Me.str.POContainers = CType(value, string)
												
						Case "Netcontainers"
							Me.str.Netcontainers = CType(value, string)
												
						Case "Purchasenumber"
							Me.str.Purchasenumber = CType(value, string)
												
						Case "Purchasedate"
							Me.str.Purchasedate = CType(value, string)
												
						Case "Expecteddelivery"
							Me.str.Expecteddelivery = CType(value, string)
												
						Case "Poitemnumber"
							Me.str.Poitemnumber = CType(value, string)
												
						Case "POContainer"
							Me.str.POContainer = CType(value, string)
												
						Case "QtyOnOrder"
							Me.str.QtyOnOrder = CType(value, string)
												
						Case "InProduction"
							Me.str.InProduction = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Inventorygrouping"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Inventorygrouping = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Units"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Units = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "FullAvailable"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.FullAvailable = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "QtyRequested"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.QtyRequested = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "FullAvailableContainers"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.FullAvailableContainers = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "POContainers"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.POContainers = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Netcontainers"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Netcontainers = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Purchasenumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Purchasenumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Purchasedate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Purchasedate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Expecteddelivery"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Expecteddelivery = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Poitemnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Poitemnumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "QtyOnOrder"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.QtyOnOrder = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "InProduction"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.InProduction = CType(value, Nullable(Of System.Decimal))
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
		' Maps to viewInventoryAnalysisByProduct.INVENTORYGROUPING
		' </summary>
		Public Overridable Property Inventorygrouping As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewInventoryAnalysisByProductMetadata.ColumnNames.Inventorygrouping)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewInventoryAnalysisByProductMetadata.ColumnNames.Inventorygrouping, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInventoryAnalysisByProduct.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewInventoryAnalysisByProductMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewInventoryAnalysisByProductMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInventoryAnalysisByProduct.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewInventoryAnalysisByProductMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewInventoryAnalysisByProductMetadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInventoryAnalysisByProduct.DESC2
		' </summary>
		Public Overridable Property Desc2 As System.String
			Get
				Return MyBase.GetSystemString(ViewInventoryAnalysisByProductMetadata.ColumnNames.Desc2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewInventoryAnalysisByProductMetadata.ColumnNames.Desc2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInventoryAnalysisByProduct.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewInventoryAnalysisByProductMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewInventoryAnalysisByProductMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInventoryAnalysisByProduct.UNITS
		' </summary>
		Public Overridable Property Units As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewInventoryAnalysisByProductMetadata.ColumnNames.Units)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewInventoryAnalysisByProductMetadata.ColumnNames.Units, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInventoryAnalysisByProduct.UOM
		' </summary>
		Public Overridable Property Uom As System.String
			Get
				Return MyBase.GetSystemString(ViewInventoryAnalysisByProductMetadata.ColumnNames.Uom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewInventoryAnalysisByProductMetadata.ColumnNames.Uom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInventoryAnalysisByProduct.FullAvailable
		' </summary>
		Public Overridable Property FullAvailable As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewInventoryAnalysisByProductMetadata.ColumnNames.FullAvailable)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewInventoryAnalysisByProductMetadata.ColumnNames.FullAvailable, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInventoryAnalysisByProduct.QtyRequested
		' </summary>
		Public Overridable Property QtyRequested As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewInventoryAnalysisByProductMetadata.ColumnNames.QtyRequested)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewInventoryAnalysisByProductMetadata.ColumnNames.QtyRequested, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInventoryAnalysisByProduct.FullAvailableContainers
		' </summary>
		Public Overridable Property FullAvailableContainers As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewInventoryAnalysisByProductMetadata.ColumnNames.FullAvailableContainers)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewInventoryAnalysisByProductMetadata.ColumnNames.FullAvailableContainers, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInventoryAnalysisByProduct.POContainers
		' </summary>
		Public Overridable Property POContainers As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewInventoryAnalysisByProductMetadata.ColumnNames.POContainers)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewInventoryAnalysisByProductMetadata.ColumnNames.POContainers, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInventoryAnalysisByProduct.NETCONTAINERS
		' </summary>
		Public Overridable Property Netcontainers As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewInventoryAnalysisByProductMetadata.ColumnNames.Netcontainers)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewInventoryAnalysisByProductMetadata.ColumnNames.Netcontainers, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInventoryAnalysisByProduct.PURCHASENUMBER
		' </summary>
		Public Overridable Property Purchasenumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewInventoryAnalysisByProductMetadata.ColumnNames.Purchasenumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewInventoryAnalysisByProductMetadata.ColumnNames.Purchasenumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInventoryAnalysisByProduct.PURCHASEDATE
		' </summary>
		Public Overridable Property Purchasedate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewInventoryAnalysisByProductMetadata.ColumnNames.Purchasedate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewInventoryAnalysisByProductMetadata.ColumnNames.Purchasedate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInventoryAnalysisByProduct.EXPECTEDDELIVERY
		' </summary>
		Public Overridable Property Expecteddelivery As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewInventoryAnalysisByProductMetadata.ColumnNames.Expecteddelivery)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewInventoryAnalysisByProductMetadata.ColumnNames.Expecteddelivery, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInventoryAnalysisByProduct.POITEMNUMBER
		' </summary>
		Public Overridable Property Poitemnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewInventoryAnalysisByProductMetadata.ColumnNames.Poitemnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewInventoryAnalysisByProductMetadata.ColumnNames.Poitemnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInventoryAnalysisByProduct.POContainer
		' </summary>
		Public Overridable Property POContainer As System.String
			Get
				Return MyBase.GetSystemString(ViewInventoryAnalysisByProductMetadata.ColumnNames.POContainer)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewInventoryAnalysisByProductMetadata.ColumnNames.POContainer, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInventoryAnalysisByProduct.QtyOnOrder
		' </summary>
		Public Overridable Property QtyOnOrder As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewInventoryAnalysisByProductMetadata.ColumnNames.QtyOnOrder)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewInventoryAnalysisByProductMetadata.ColumnNames.QtyOnOrder, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInventoryAnalysisByProduct.InProduction
		' </summary>
		Public Overridable Property InProduction As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewInventoryAnalysisByProductMetadata.ColumnNames.InProduction)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewInventoryAnalysisByProductMetadata.ColumnNames.InProduction, value)
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
		
			Public Sub New(ByVal entity As esViewInventoryAnalysisByProduct)
				Me.entity = entity
			End Sub				
		
	
			Public Property Inventorygrouping As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Inventorygrouping
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Inventorygrouping = Nothing
					Else
						entity.Inventorygrouping = Convert.ToInt32(Value)
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
		  	
			Public Property Desc2 As System.String 
				Get
					Dim data_ As System.String = entity.Desc2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Desc2 = Nothing
					Else
						entity.Desc2 = Convert.ToString(Value)
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
		  	
			Public Property Units As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Units
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Units = Nothing
					Else
						entity.Units = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Uom As System.String 
				Get
					Dim data_ As System.String = entity.Uom
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Uom = Nothing
					Else
						entity.Uom = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FullAvailable As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.FullAvailable
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FullAvailable = Nothing
					Else
						entity.FullAvailable = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property QtyRequested As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.QtyRequested
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.QtyRequested = Nothing
					Else
						entity.QtyRequested = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property FullAvailableContainers As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.FullAvailableContainers
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FullAvailableContainers = Nothing
					Else
						entity.FullAvailableContainers = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property POContainers As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.POContainers
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.POContainers = Nothing
					Else
						entity.POContainers = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Netcontainers As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Netcontainers
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Netcontainers = Nothing
					Else
						entity.Netcontainers = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Purchasenumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Purchasenumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Purchasenumber = Nothing
					Else
						entity.Purchasenumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Purchasedate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Purchasedate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Purchasedate = Nothing
					Else
						entity.Purchasedate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Expecteddelivery As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Expecteddelivery
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Expecteddelivery = Nothing
					Else
						entity.Expecteddelivery = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Poitemnumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Poitemnumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Poitemnumber = Nothing
					Else
						entity.Poitemnumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property POContainer As System.String 
				Get
					Dim data_ As System.String = entity.POContainer
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.POContainer = Nothing
					Else
						entity.POContainer = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property QtyOnOrder As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.QtyOnOrder
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.QtyOnOrder = Nothing
					Else
						entity.QtyOnOrder = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property InProduction As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.InProduction
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.InProduction = Nothing
					Else
						entity.InProduction = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewInventoryAnalysisByProduct
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewInventoryAnalysisByProductQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewInventoryAnalysisByProduct can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewInventoryAnalysisByProductQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewInventoryAnalysisByProductMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Inventorygrouping As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInventoryAnalysisByProductMetadata.ColumnNames.Inventorygrouping, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInventoryAnalysisByProductMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInventoryAnalysisByProductMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Desc2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInventoryAnalysisByProductMetadata.ColumnNames.Desc2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInventoryAnalysisByProductMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Units As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInventoryAnalysisByProductMetadata.ColumnNames.Units, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Uom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInventoryAnalysisByProductMetadata.ColumnNames.Uom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FullAvailable As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInventoryAnalysisByProductMetadata.ColumnNames.FullAvailable, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property QtyRequested As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInventoryAnalysisByProductMetadata.ColumnNames.QtyRequested, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property FullAvailableContainers As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInventoryAnalysisByProductMetadata.ColumnNames.FullAvailableContainers, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property POContainers As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInventoryAnalysisByProductMetadata.ColumnNames.POContainers, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Netcontainers As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInventoryAnalysisByProductMetadata.ColumnNames.Netcontainers, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Purchasenumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInventoryAnalysisByProductMetadata.ColumnNames.Purchasenumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Purchasedate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInventoryAnalysisByProductMetadata.ColumnNames.Purchasedate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Expecteddelivery As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInventoryAnalysisByProductMetadata.ColumnNames.Expecteddelivery, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Poitemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInventoryAnalysisByProductMetadata.ColumnNames.Poitemnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property POContainer As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInventoryAnalysisByProductMetadata.ColumnNames.POContainer, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property QtyOnOrder As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInventoryAnalysisByProductMetadata.ColumnNames.QtyOnOrder, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property InProduction As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInventoryAnalysisByProductMetadata.ColumnNames.InProduction, esSystemType.Decimal)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewInventoryAnalysisByProductCollection")> _
	Partial Public Class ViewInventoryAnalysisByProductCollection
		Inherits esViewInventoryAnalysisByProductCollection
		Implements IEnumerable(Of ViewInventoryAnalysisByProduct)
		
        Public Shared Widening Operator CType(ByVal coll As ViewInventoryAnalysisByProductCollection) As List(Of ViewInventoryAnalysisByProduct)
            Dim list As List(Of ViewInventoryAnalysisByProduct) = New List(Of ViewInventoryAnalysisByProduct)
            Dim emp As ViewInventoryAnalysisByProduct

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewInventoryAnalysisByProductMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewInventoryAnalysisByProductQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewInventoryAnalysisByProduct(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewInventoryAnalysisByProduct()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewInventoryAnalysisByProductQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewInventoryAnalysisByProductQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewInventoryAnalysisByProductQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewInventoryAnalysisByProduct 
			Return CType(MyBase.AddNewEntity(), ViewInventoryAnalysisByProduct)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewInventoryAnalysisByProduct) Implements IEnumerable(Of ViewInventoryAnalysisByProduct).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewInventoryAnalysisByProduct)(Me)
        End Function
		
		Private _query As ViewInventoryAnalysisByProductQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewInventoryAnalysisByProduct' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewInventoryAnalysisByProduct ()")> _
	<Serializable> _
	Partial Public Class ViewInventoryAnalysisByProduct 
		Inherits esViewInventoryAnalysisByProduct

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewInventoryAnalysisByProductMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewInventoryAnalysisByProductQuery

			If Me._query Is Nothing Then
				Me._query = New ViewInventoryAnalysisByProductQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewInventoryAnalysisByProductQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewInventoryAnalysisByProductQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewInventoryAnalysisByProductQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewInventoryAnalysisByProductQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewInventoryAnalysisByProductQuery
		inherits esViewInventoryAnalysisByProductQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewInventoryAnalysisByProductQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewInventoryAnalysisByProductMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewInventoryAnalysisByProductMetadata.ColumnNames.Inventorygrouping, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewInventoryAnalysisByProductMetadata.PropertyNames.Inventorygrouping
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInventoryAnalysisByProductMetadata.ColumnNames.Productid, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewInventoryAnalysisByProductMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInventoryAnalysisByProductMetadata.ColumnNames.Productdesc, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewInventoryAnalysisByProductMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInventoryAnalysisByProductMetadata.ColumnNames.Desc2, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewInventoryAnalysisByProductMetadata.PropertyNames.Desc2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInventoryAnalysisByProductMetadata.ColumnNames.Container, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewInventoryAnalysisByProductMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInventoryAnalysisByProductMetadata.ColumnNames.Units, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewInventoryAnalysisByProductMetadata.PropertyNames.Units
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInventoryAnalysisByProductMetadata.ColumnNames.Uom, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewInventoryAnalysisByProductMetadata.PropertyNames.Uom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInventoryAnalysisByProductMetadata.ColumnNames.FullAvailable, 7, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewInventoryAnalysisByProductMetadata.PropertyNames.FullAvailable
			c.NumericPrecision = 13
			c.NumericScale = 1
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInventoryAnalysisByProductMetadata.ColumnNames.QtyRequested, 8, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewInventoryAnalysisByProductMetadata.PropertyNames.QtyRequested
			c.NumericPrecision = 38
			c.NumericScale = 5
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInventoryAnalysisByProductMetadata.ColumnNames.FullAvailableContainers, 9, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewInventoryAnalysisByProductMetadata.PropertyNames.FullAvailableContainers
			c.NumericPrecision = 38
			c.NumericScale = 5
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInventoryAnalysisByProductMetadata.ColumnNames.POContainers, 10, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewInventoryAnalysisByProductMetadata.PropertyNames.POContainers
			c.NumericPrecision = 38
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInventoryAnalysisByProductMetadata.ColumnNames.Netcontainers, 11, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewInventoryAnalysisByProductMetadata.PropertyNames.Netcontainers
			c.NumericPrecision = 38
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInventoryAnalysisByProductMetadata.ColumnNames.Purchasenumber, 12, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewInventoryAnalysisByProductMetadata.PropertyNames.Purchasenumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInventoryAnalysisByProductMetadata.ColumnNames.Purchasedate, 13, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewInventoryAnalysisByProductMetadata.PropertyNames.Purchasedate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInventoryAnalysisByProductMetadata.ColumnNames.Expecteddelivery, 14, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewInventoryAnalysisByProductMetadata.PropertyNames.Expecteddelivery
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInventoryAnalysisByProductMetadata.ColumnNames.Poitemnumber, 15, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewInventoryAnalysisByProductMetadata.PropertyNames.Poitemnumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInventoryAnalysisByProductMetadata.ColumnNames.POContainer, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewInventoryAnalysisByProductMetadata.PropertyNames.POContainer
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInventoryAnalysisByProductMetadata.ColumnNames.QtyOnOrder, 17, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewInventoryAnalysisByProductMetadata.PropertyNames.QtyOnOrder
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInventoryAnalysisByProductMetadata.ColumnNames.InProduction, 18, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewInventoryAnalysisByProductMetadata.PropertyNames.InProduction
			c.NumericPrecision = 13
			c.NumericScale = 1
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewInventoryAnalysisByProductMetadata
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
			 Public Const Inventorygrouping As String = "INVENTORYGROUPING"
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Productdesc As String = "PRODUCTDESC"
			 Public Const Desc2 As String = "DESC2"
			 Public Const Container As String = "CONTAINER"
			 Public Const Units As String = "UNITS"
			 Public Const Uom As String = "UOM"
			 Public Const FullAvailable As String = "FullAvailable"
			 Public Const QtyRequested As String = "QtyRequested"
			 Public Const FullAvailableContainers As String = "FullAvailableContainers"
			 Public Const POContainers As String = "POContainers"
			 Public Const Netcontainers As String = "NETCONTAINERS"
			 Public Const Purchasenumber As String = "PURCHASENUMBER"
			 Public Const Purchasedate As String = "PURCHASEDATE"
			 Public Const Expecteddelivery As String = "EXPECTEDDELIVERY"
			 Public Const Poitemnumber As String = "POITEMNUMBER"
			 Public Const POContainer As String = "POContainer"
			 Public Const QtyOnOrder As String = "QtyOnOrder"
			 Public Const InProduction As String = "InProduction"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Inventorygrouping As String = "Inventorygrouping"
			 Public Const Productid As String = "Productid"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const Desc2 As String = "Desc2"
			 Public Const Container As String = "Container"
			 Public Const Units As String = "Units"
			 Public Const Uom As String = "Uom"
			 Public Const FullAvailable As String = "FullAvailable"
			 Public Const QtyRequested As String = "QtyRequested"
			 Public Const FullAvailableContainers As String = "FullAvailableContainers"
			 Public Const POContainers As String = "POContainers"
			 Public Const Netcontainers As String = "Netcontainers"
			 Public Const Purchasenumber As String = "Purchasenumber"
			 Public Const Purchasedate As String = "Purchasedate"
			 Public Const Expecteddelivery As String = "Expecteddelivery"
			 Public Const Poitemnumber As String = "Poitemnumber"
			 Public Const POContainer As String = "POContainer"
			 Public Const QtyOnOrder As String = "QtyOnOrder"
			 Public Const InProduction As String = "InProduction"
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
            SyncLock GetType(ViewInventoryAnalysisByProductMetadata)
			
				If ViewInventoryAnalysisByProductMetadata.mapDelegates Is Nothing Then
					ViewInventoryAnalysisByProductMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewInventoryAnalysisByProductMetadata._meta Is Nothing Then
                    ViewInventoryAnalysisByProductMetadata._meta = New ViewInventoryAnalysisByProductMetadata()
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
				

				meta.AddTypeMap("Inventorygrouping", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Desc2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Units", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Uom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("FullAvailable", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("QtyRequested", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("FullAvailableContainers", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("POContainers", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Netcontainers", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Purchasenumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Purchasedate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Expecteddelivery", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Poitemnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("POContainer", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("QtyOnOrder", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("InProduction", new esTypeMap("numeric", "System.Decimal"))			
				
				
				 
				meta.Source = "viewInventoryAnalysisByProduct"
				meta.Destination = "viewInventoryAnalysisByProduct"
				
				meta.spInsert = "proc_viewInventoryAnalysisByProductInsert"
				meta.spUpdate = "proc_viewInventoryAnalysisByProductUpdate"
				meta.spDelete = "proc_viewInventoryAnalysisByProductDelete"
				meta.spLoadAll = "proc_viewInventoryAnalysisByProductLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewInventoryAnalysisByProductLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewInventoryAnalysisByProductMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
