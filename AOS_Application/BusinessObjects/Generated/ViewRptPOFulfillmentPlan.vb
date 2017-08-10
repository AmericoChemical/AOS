'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 4/2/2015 4:03:30 PM
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
	MustInherit Public Class esViewRptPOFulfillmentPlanCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewRptPOFulfillmentPlanCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewRptPOFulfillmentPlanQuery)
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
            Me.InitQuery(CType(query, esViewRptPOFulfillmentPlanQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewRptPOFulfillmentPlan) As ViewRptPOFulfillmentPlan
			Return CType(MyBase.DetachEntity(entity), ViewRptPOFulfillmentPlan)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewRptPOFulfillmentPlan) As ViewRptPOFulfillmentPlan
			Return CType(MyBase.AttachEntity(entity), ViewRptPOFulfillmentPlan)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewRptPOFulfillmentPlanCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewRptPOFulfillmentPlan
            Get
                Return TryCast(MyBase.Item(index), ViewRptPOFulfillmentPlan)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewRptPOFulfillmentPlan)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewRptPOFulfillmentPlan	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewRptPOFulfillmentPlanQuery
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
												
						Case "Itemid"
							Me.str.Itemid = CType(value, string)
												
						Case "Prodordernum"
							Me.str.Prodordernum = CType(value, string)
												
						Case "Qty"
							Me.str.Qty = CType(value, string)
												
						Case "Uom"
							Me.str.Uom = CType(value, string)
												
						Case "Materialid"
							Me.str.Materialid = CType(value, string)
												
						Case "Materialdesc"
							Me.str.Materialdesc = CType(value, string)
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Productdesc"
							Me.str.Productdesc = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "Productqty"
							Me.str.Productqty = CType(value, string)
												
						Case "ProductionOrderDetails"
							Me.str.ProductionOrderDetails = CType(value, string)
												
						Case "Rminventory"
							Me.str.Rminventory = CType(value, string)
												
						Case "Rmonorder"
							Me.str.Rmonorder = CType(value, string)
												
						Case "Inpproduction"
							Me.str.Inpproduction = CType(value, string)
												
						Case "Available"
							Me.str.Available = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Workordernumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Workordernumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Itemid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Itemid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Prodordernum"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Prodordernum = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Qty"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Qty = CType(value, Nullable(Of System.Double))
							End If
						
						Case "Materialid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Materialid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Productqty"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productqty = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Rminventory"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Rminventory = CType(value, Nullable(Of System.Double))
							End If
						
						Case "Rmonorder"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Rmonorder = CType(value, Nullable(Of System.Double))
							End If
						
						Case "Inpproduction"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Inpproduction = CType(value, Nullable(Of System.Double))
							End If
						
						Case "Available"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Available = CType(value, Nullable(Of System.Double))
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
		' Maps to viewRptPOFulfillmentPlan.WORKORDERNUMBER
		' </summary>
		Public Overridable Property Workordernumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptPOFulfillmentPlanMetadata.ColumnNames.Workordernumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptPOFulfillmentPlanMetadata.ColumnNames.Workordernumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOFulfillmentPlan.ITEMID
		' </summary>
		Public Overridable Property Itemid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptPOFulfillmentPlanMetadata.ColumnNames.Itemid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptPOFulfillmentPlanMetadata.ColumnNames.Itemid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOFulfillmentPlan.PRODORDERNUM
		' </summary>
		Public Overridable Property Prodordernum As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptPOFulfillmentPlanMetadata.ColumnNames.Prodordernum)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptPOFulfillmentPlanMetadata.ColumnNames.Prodordernum, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOFulfillmentPlan.QTY
		' </summary>
		Public Overridable Property Qty As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewRptPOFulfillmentPlanMetadata.ColumnNames.Qty)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewRptPOFulfillmentPlanMetadata.ColumnNames.Qty, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOFulfillmentPlan.UOM
		' </summary>
		Public Overridable Property Uom As System.String
			Get
				Return MyBase.GetSystemString(ViewRptPOFulfillmentPlanMetadata.ColumnNames.Uom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptPOFulfillmentPlanMetadata.ColumnNames.Uom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOFulfillmentPlan.MATERIALID
		' </summary>
		Public Overridable Property Materialid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptPOFulfillmentPlanMetadata.ColumnNames.Materialid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptPOFulfillmentPlanMetadata.ColumnNames.Materialid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOFulfillmentPlan.MATERIALDESC
		' </summary>
		Public Overridable Property Materialdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewRptPOFulfillmentPlanMetadata.ColumnNames.Materialdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptPOFulfillmentPlanMetadata.ColumnNames.Materialdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOFulfillmentPlan.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptPOFulfillmentPlanMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptPOFulfillmentPlanMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOFulfillmentPlan.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewRptPOFulfillmentPlanMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptPOFulfillmentPlanMetadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOFulfillmentPlan.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewRptPOFulfillmentPlanMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptPOFulfillmentPlanMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOFulfillmentPlan.PRODUCTQTY
		' </summary>
		Public Overridable Property Productqty As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptPOFulfillmentPlanMetadata.ColumnNames.Productqty)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptPOFulfillmentPlanMetadata.ColumnNames.Productqty, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOFulfillmentPlan.ProductionOrderDetails
		' </summary>
		Public Overridable Property ProductionOrderDetails As System.String
			Get
				Return MyBase.GetSystemString(ViewRptPOFulfillmentPlanMetadata.ColumnNames.ProductionOrderDetails)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptPOFulfillmentPlanMetadata.ColumnNames.ProductionOrderDetails, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOFulfillmentPlan.RMINVENTORY
		' </summary>
		Public Overridable Property Rminventory As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewRptPOFulfillmentPlanMetadata.ColumnNames.Rminventory)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewRptPOFulfillmentPlanMetadata.ColumnNames.Rminventory, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOFulfillmentPlan.RMONORDER
		' </summary>
		Public Overridable Property Rmonorder As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewRptPOFulfillmentPlanMetadata.ColumnNames.Rmonorder)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewRptPOFulfillmentPlanMetadata.ColumnNames.Rmonorder, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOFulfillmentPlan.INPPRODUCTION
		' </summary>
		Public Overridable Property Inpproduction As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewRptPOFulfillmentPlanMetadata.ColumnNames.Inpproduction)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewRptPOFulfillmentPlanMetadata.ColumnNames.Inpproduction, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptPOFulfillmentPlan.AVAILABLE
		' </summary>
		Public Overridable Property Available As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewRptPOFulfillmentPlanMetadata.ColumnNames.Available)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewRptPOFulfillmentPlanMetadata.ColumnNames.Available, value)
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
		
			Public Sub New(ByVal entity As esViewRptPOFulfillmentPlan)
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
		  	
			Public Property Itemid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Itemid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Itemid = Nothing
					Else
						entity.Itemid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Prodordernum As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Prodordernum
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Prodordernum = Nothing
					Else
						entity.Prodordernum = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Qty As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Qty
					
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
						entity.Qty = Convert.ToDouble(Value)
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
		  	
			Public Property Materialid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Materialid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Materialid = Nothing
					Else
						entity.Materialid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Materialdesc As System.String 
				Get
					Dim data_ As System.String = entity.Materialdesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Materialdesc = Nothing
					Else
						entity.Materialdesc = Convert.ToString(Value)
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
		  	
			Public Property Productqty As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Productqty
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Productqty = Nothing
					Else
						entity.Productqty = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property ProductionOrderDetails As System.String 
				Get
					Dim data_ As System.String = entity.ProductionOrderDetails
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ProductionOrderDetails = Nothing
					Else
						entity.ProductionOrderDetails = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Rminventory As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Rminventory
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Rminventory = Nothing
					Else
						entity.Rminventory = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property Rmonorder As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Rmonorder
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Rmonorder = Nothing
					Else
						entity.Rmonorder = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property Inpproduction As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Inpproduction
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Inpproduction = Nothing
					Else
						entity.Inpproduction = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property Available As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Available
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Available = Nothing
					Else
						entity.Available = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewRptPOFulfillmentPlan
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewRptPOFulfillmentPlanQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewRptPOFulfillmentPlan can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewRptPOFulfillmentPlanQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRptPOFulfillmentPlanMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Workordernumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOFulfillmentPlanMetadata.ColumnNames.Workordernumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Itemid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOFulfillmentPlanMetadata.ColumnNames.Itemid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Prodordernum As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOFulfillmentPlanMetadata.ColumnNames.Prodordernum, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Qty As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOFulfillmentPlanMetadata.ColumnNames.Qty, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Uom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOFulfillmentPlanMetadata.ColumnNames.Uom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Materialid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOFulfillmentPlanMetadata.ColumnNames.Materialid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Materialdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOFulfillmentPlanMetadata.ColumnNames.Materialdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOFulfillmentPlanMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOFulfillmentPlanMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOFulfillmentPlanMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Productqty As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOFulfillmentPlanMetadata.ColumnNames.Productqty, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ProductionOrderDetails As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOFulfillmentPlanMetadata.ColumnNames.ProductionOrderDetails, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Rminventory As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOFulfillmentPlanMetadata.ColumnNames.Rminventory, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Rmonorder As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOFulfillmentPlanMetadata.ColumnNames.Rmonorder, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Inpproduction As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOFulfillmentPlanMetadata.ColumnNames.Inpproduction, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Available As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptPOFulfillmentPlanMetadata.ColumnNames.Available, esSystemType.Double)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewRptPOFulfillmentPlanCollection")> _
	Partial Public Class ViewRptPOFulfillmentPlanCollection
		Inherits esViewRptPOFulfillmentPlanCollection
		Implements IEnumerable(Of ViewRptPOFulfillmentPlan)
		
        Public Shared Widening Operator CType(ByVal coll As ViewRptPOFulfillmentPlanCollection) As List(Of ViewRptPOFulfillmentPlan)
            Dim list As List(Of ViewRptPOFulfillmentPlan) = New List(Of ViewRptPOFulfillmentPlan)
            Dim emp As ViewRptPOFulfillmentPlan

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRptPOFulfillmentPlanMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewRptPOFulfillmentPlanQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewRptPOFulfillmentPlan(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewRptPOFulfillmentPlan()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewRptPOFulfillmentPlanQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewRptPOFulfillmentPlanQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRptPOFulfillmentPlanQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewRptPOFulfillmentPlan 
			Return CType(MyBase.AddNewEntity(), ViewRptPOFulfillmentPlan)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewRptPOFulfillmentPlan) Implements IEnumerable(Of ViewRptPOFulfillmentPlan).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewRptPOFulfillmentPlan)(Me)
        End Function
		
		Private _query As ViewRptPOFulfillmentPlanQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewRptPOFulfillmentPlan' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewRptPOFulfillmentPlan ()")> _
	<Serializable> _
	Partial Public Class ViewRptPOFulfillmentPlan 
		Inherits esViewRptPOFulfillmentPlan

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewRptPOFulfillmentPlanMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewRptPOFulfillmentPlanQuery

			If Me._query Is Nothing Then
				Me._query = New ViewRptPOFulfillmentPlanQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewRptPOFulfillmentPlanQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewRptPOFulfillmentPlanQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRptPOFulfillmentPlanQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewRptPOFulfillmentPlanQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewRptPOFulfillmentPlanQuery
		inherits esViewRptPOFulfillmentPlanQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewRptPOFulfillmentPlanQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewRptPOFulfillmentPlanMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewRptPOFulfillmentPlanMetadata.ColumnNames.Workordernumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptPOFulfillmentPlanMetadata.PropertyNames.Workordernumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOFulfillmentPlanMetadata.ColumnNames.Itemid, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptPOFulfillmentPlanMetadata.PropertyNames.Itemid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOFulfillmentPlanMetadata.ColumnNames.Prodordernum, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptPOFulfillmentPlanMetadata.PropertyNames.Prodordernum
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOFulfillmentPlanMetadata.ColumnNames.Qty, 3, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewRptPOFulfillmentPlanMetadata.PropertyNames.Qty
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOFulfillmentPlanMetadata.ColumnNames.Uom, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptPOFulfillmentPlanMetadata.PropertyNames.Uom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOFulfillmentPlanMetadata.ColumnNames.Materialid, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptPOFulfillmentPlanMetadata.PropertyNames.Materialid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOFulfillmentPlanMetadata.ColumnNames.Materialdesc, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptPOFulfillmentPlanMetadata.PropertyNames.Materialdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOFulfillmentPlanMetadata.ColumnNames.Productid, 7, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptPOFulfillmentPlanMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOFulfillmentPlanMetadata.ColumnNames.Productdesc, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptPOFulfillmentPlanMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOFulfillmentPlanMetadata.ColumnNames.Container, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptPOFulfillmentPlanMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOFulfillmentPlanMetadata.ColumnNames.Productqty, 10, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptPOFulfillmentPlanMetadata.PropertyNames.Productqty
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOFulfillmentPlanMetadata.ColumnNames.ProductionOrderDetails, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptPOFulfillmentPlanMetadata.PropertyNames.ProductionOrderDetails
			c.CharacterMaxLength = 352
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOFulfillmentPlanMetadata.ColumnNames.Rminventory, 12, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewRptPOFulfillmentPlanMetadata.PropertyNames.Rminventory
			c.NumericPrecision = 15
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOFulfillmentPlanMetadata.ColumnNames.Rmonorder, 13, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewRptPOFulfillmentPlanMetadata.PropertyNames.Rmonorder
			c.NumericPrecision = 15
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOFulfillmentPlanMetadata.ColumnNames.Inpproduction, 14, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewRptPOFulfillmentPlanMetadata.PropertyNames.Inpproduction
			c.NumericPrecision = 15
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptPOFulfillmentPlanMetadata.ColumnNames.Available, 15, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewRptPOFulfillmentPlanMetadata.PropertyNames.Available
			c.NumericPrecision = 15
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewRptPOFulfillmentPlanMetadata
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
			 Public Const Itemid As String = "ITEMID"
			 Public Const Prodordernum As String = "PRODORDERNUM"
			 Public Const Qty As String = "QTY"
			 Public Const Uom As String = "UOM"
			 Public Const Materialid As String = "MATERIALID"
			 Public Const Materialdesc As String = "MATERIALDESC"
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Productdesc As String = "PRODUCTDESC"
			 Public Const Container As String = "CONTAINER"
			 Public Const Productqty As String = "PRODUCTQTY"
			 Public Const ProductionOrderDetails As String = "ProductionOrderDetails"
			 Public Const Rminventory As String = "RMINVENTORY"
			 Public Const Rmonorder As String = "RMONORDER"
			 Public Const Inpproduction As String = "INPPRODUCTION"
			 Public Const Available As String = "AVAILABLE"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Workordernumber As String = "Workordernumber"
			 Public Const Itemid As String = "Itemid"
			 Public Const Prodordernum As String = "Prodordernum"
			 Public Const Qty As String = "Qty"
			 Public Const Uom As String = "Uom"
			 Public Const Materialid As String = "Materialid"
			 Public Const Materialdesc As String = "Materialdesc"
			 Public Const Productid As String = "Productid"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const Container As String = "Container"
			 Public Const Productqty As String = "Productqty"
			 Public Const ProductionOrderDetails As String = "ProductionOrderDetails"
			 Public Const Rminventory As String = "Rminventory"
			 Public Const Rmonorder As String = "Rmonorder"
			 Public Const Inpproduction As String = "Inpproduction"
			 Public Const Available As String = "Available"
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
            SyncLock GetType(ViewRptPOFulfillmentPlanMetadata)
			
				If ViewRptPOFulfillmentPlanMetadata.mapDelegates Is Nothing Then
					ViewRptPOFulfillmentPlanMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewRptPOFulfillmentPlanMetadata._meta Is Nothing Then
                    ViewRptPOFulfillmentPlanMetadata._meta = New ViewRptPOFulfillmentPlanMetadata()
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
				meta.AddTypeMap("Itemid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Prodordernum", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Qty", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Uom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Materialid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Materialdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Productid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Productqty", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ProductionOrderDetails", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Rminventory", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Rmonorder", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Inpproduction", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Available", new esTypeMap("float", "System.Double"))			
				
				
				 
				meta.Source = "viewRptPOFulfillmentPlan"
				meta.Destination = "viewRptPOFulfillmentPlan"
				
				meta.spInsert = "proc_viewRptPOFulfillmentPlanInsert"
				meta.spUpdate = "proc_viewRptPOFulfillmentPlanUpdate"
				meta.spDelete = "proc_viewRptPOFulfillmentPlanDelete"
				meta.spLoadAll = "proc_viewRptPOFulfillmentPlanLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewRptPOFulfillmentPlanLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewRptPOFulfillmentPlanMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
