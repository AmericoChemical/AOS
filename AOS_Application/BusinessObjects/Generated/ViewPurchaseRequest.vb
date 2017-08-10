'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/11/2014 1:36:09 PM
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
	MustInherit Public Class esViewPurchaseRequestCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewPurchaseRequestCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewPurchaseRequestQuery)
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
            Me.InitQuery(CType(query, esViewPurchaseRequestQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewPurchaseRequest) As ViewPurchaseRequest
			Return CType(MyBase.DetachEntity(entity), ViewPurchaseRequest)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewPurchaseRequest) As ViewPurchaseRequest
			Return CType(MyBase.AttachEntity(entity), ViewPurchaseRequest)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewPurchaseRequestCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewPurchaseRequest
            Get
                Return TryCast(MyBase.Item(index), ViewPurchaseRequest)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewPurchaseRequest)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewPurchaseRequest	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewPurchaseRequestQuery
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
												
						Case "PurchReqID"
							Me.str.PurchReqID = CType(value, string)
												
						Case "PurchReqDate"
							Me.str.PurchReqDate = CType(value, string)
												
						Case "ProductID"
							Me.str.ProductID = CType(value, string)
												
						Case "QtyContainers"
							Me.str.QtyContainers = CType(value, string)
												
						Case "DateNeeded"
							Me.str.DateNeeded = CType(value, string)
												
						Case "IsOrdered"
							Me.str.IsOrdered = CType(value, string)
												
						Case "Productdesc"
							Me.str.Productdesc = CType(value, string)
												
						Case "Units"
							Me.str.Units = CType(value, string)
												
						Case "Uom"
							Me.str.Uom = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "PONumber"
							Me.str.PONumber = CType(value, string)
												
						Case "WorkOrderNumber"
							Me.str.WorkOrderNumber = CType(value, string)
												
						Case "CustID"
							Me.str.CustID = CType(value, string)
												
						Case "VendorID"
							Me.str.VendorID = CType(value, string)
												
						Case "Vendorname"
							Me.str.Vendorname = CType(value, string)
												
						Case "Plannedshipdate"
							Me.str.Plannedshipdate = CType(value, string)
												
						Case "Deliverydate"
							Me.str.Deliverydate = CType(value, string)
												
						Case "Workorderdate"
							Me.str.Workorderdate = CType(value, string)
												
						Case "Custname"
							Me.str.Custname = CType(value, string)
												
						Case "Custshipcity"
							Me.str.Custshipcity = CType(value, string)
												
						Case "Custshipstateprov"
							Me.str.Custshipstateprov = CType(value, string)
												
						Case "Custshippostalcode"
							Me.str.Custshippostalcode = CType(value, string)
												
						Case "WorkOrderItemNumber"
							Me.str.WorkOrderItemNumber = CType(value, string)
												
						Case "DateReceived"
							Me.str.DateReceived = CType(value, string)
												
						Case "ReceiverItemNumber"
							Me.str.ReceiverItemNumber = CType(value, string)
												
						Case "ProdOrderNum"
							Me.str.ProdOrderNum = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "PurchReqID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.PurchReqID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "PurchReqDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.PurchReqDate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "ProductID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ProductID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "QtyContainers"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.QtyContainers = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "DateNeeded"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.DateNeeded = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "IsOrdered"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.IsOrdered = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Units"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Units = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "PONumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.PONumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "WorkOrderNumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.WorkOrderNumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "CustID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.CustID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "VendorID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.VendorID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Plannedshipdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Plannedshipdate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Deliverydate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Deliverydate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Workorderdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Workorderdate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "WorkOrderItemNumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.WorkOrderItemNumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "DateReceived"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.DateReceived = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "ReceiverItemNumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ReceiverItemNumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "ProdOrderNum"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ProdOrderNum = CType(value, Nullable(Of System.Int32))
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
		' Maps to viewPurchaseRequest.PurchReqID
		' </summary>
		Public Overridable Property PurchReqID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewPurchaseRequestMetadata.ColumnNames.PurchReqID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewPurchaseRequestMetadata.ColumnNames.PurchReqID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseRequest.PurchReqDate
		' </summary>
		Public Overridable Property PurchReqDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewPurchaseRequestMetadata.ColumnNames.PurchReqDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewPurchaseRequestMetadata.ColumnNames.PurchReqDate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseRequest.ProductID
		' </summary>
		Public Overridable Property ProductID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewPurchaseRequestMetadata.ColumnNames.ProductID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewPurchaseRequestMetadata.ColumnNames.ProductID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseRequest.QtyContainers
		' </summary>
		Public Overridable Property QtyContainers As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewPurchaseRequestMetadata.ColumnNames.QtyContainers)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewPurchaseRequestMetadata.ColumnNames.QtyContainers, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseRequest.DateNeeded
		' </summary>
		Public Overridable Property DateNeeded As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewPurchaseRequestMetadata.ColumnNames.DateNeeded)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewPurchaseRequestMetadata.ColumnNames.DateNeeded, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseRequest.IsOrdered
		' </summary>
		Public Overridable Property IsOrdered As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewPurchaseRequestMetadata.ColumnNames.IsOrdered)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewPurchaseRequestMetadata.ColumnNames.IsOrdered, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseRequest.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewPurchaseRequestMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPurchaseRequestMetadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseRequest.UNITS
		' </summary>
		Public Overridable Property Units As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewPurchaseRequestMetadata.ColumnNames.Units)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewPurchaseRequestMetadata.ColumnNames.Units, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseRequest.UOM
		' </summary>
		Public Overridable Property Uom As System.String
			Get
				Return MyBase.GetSystemString(ViewPurchaseRequestMetadata.ColumnNames.Uom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPurchaseRequestMetadata.ColumnNames.Uom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseRequest.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewPurchaseRequestMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPurchaseRequestMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseRequest.PONumber
		' </summary>
		Public Overridable Property PONumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewPurchaseRequestMetadata.ColumnNames.PONumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewPurchaseRequestMetadata.ColumnNames.PONumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseRequest.WorkOrderNumber
		' </summary>
		Public Overridable Property WorkOrderNumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewPurchaseRequestMetadata.ColumnNames.WorkOrderNumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewPurchaseRequestMetadata.ColumnNames.WorkOrderNumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseRequest.CustID
		' </summary>
		Public Overridable Property CustID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewPurchaseRequestMetadata.ColumnNames.CustID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewPurchaseRequestMetadata.ColumnNames.CustID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseRequest.VendorID
		' </summary>
		Public Overridable Property VendorID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewPurchaseRequestMetadata.ColumnNames.VendorID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewPurchaseRequestMetadata.ColumnNames.VendorID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseRequest.VENDORNAME
		' </summary>
		Public Overridable Property Vendorname As System.String
			Get
				Return MyBase.GetSystemString(ViewPurchaseRequestMetadata.ColumnNames.Vendorname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPurchaseRequestMetadata.ColumnNames.Vendorname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseRequest.PLANNEDSHIPDATE
		' </summary>
		Public Overridable Property Plannedshipdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewPurchaseRequestMetadata.ColumnNames.Plannedshipdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewPurchaseRequestMetadata.ColumnNames.Plannedshipdate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseRequest.DELIVERYDATE
		' </summary>
		Public Overridable Property Deliverydate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewPurchaseRequestMetadata.ColumnNames.Deliverydate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewPurchaseRequestMetadata.ColumnNames.Deliverydate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseRequest.WORKORDERDATE
		' </summary>
		Public Overridable Property Workorderdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewPurchaseRequestMetadata.ColumnNames.Workorderdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewPurchaseRequestMetadata.ColumnNames.Workorderdate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseRequest.CUSTNAME
		' </summary>
		Public Overridable Property Custname As System.String
			Get
				Return MyBase.GetSystemString(ViewPurchaseRequestMetadata.ColumnNames.Custname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPurchaseRequestMetadata.ColumnNames.Custname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseRequest.CUSTSHIPCITY
		' </summary>
		Public Overridable Property Custshipcity As System.String
			Get
				Return MyBase.GetSystemString(ViewPurchaseRequestMetadata.ColumnNames.Custshipcity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPurchaseRequestMetadata.ColumnNames.Custshipcity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseRequest.CUSTSHIPSTATEPROV
		' </summary>
		Public Overridable Property Custshipstateprov As System.String
			Get
				Return MyBase.GetSystemString(ViewPurchaseRequestMetadata.ColumnNames.Custshipstateprov)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPurchaseRequestMetadata.ColumnNames.Custshipstateprov, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseRequest.CUSTSHIPPOSTALCODE
		' </summary>
		Public Overridable Property Custshippostalcode As System.String
			Get
				Return MyBase.GetSystemString(ViewPurchaseRequestMetadata.ColumnNames.Custshippostalcode)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPurchaseRequestMetadata.ColumnNames.Custshippostalcode, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseRequest.WorkOrderItemNumber
		' </summary>
		Public Overridable Property WorkOrderItemNumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewPurchaseRequestMetadata.ColumnNames.WorkOrderItemNumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewPurchaseRequestMetadata.ColumnNames.WorkOrderItemNumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseRequest.DateReceived
		' </summary>
		Public Overridable Property DateReceived As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewPurchaseRequestMetadata.ColumnNames.DateReceived)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewPurchaseRequestMetadata.ColumnNames.DateReceived, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseRequest.ReceiverItemNumber
		' </summary>
		Public Overridable Property ReceiverItemNumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewPurchaseRequestMetadata.ColumnNames.ReceiverItemNumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewPurchaseRequestMetadata.ColumnNames.ReceiverItemNumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseRequest.ProdOrderNum
		' </summary>
		Public Overridable Property ProdOrderNum As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewPurchaseRequestMetadata.ColumnNames.ProdOrderNum)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewPurchaseRequestMetadata.ColumnNames.ProdOrderNum, value)
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
		
			Public Sub New(ByVal entity As esViewPurchaseRequest)
				Me.entity = entity
			End Sub				
		
	
			Public Property PurchReqID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.PurchReqID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PurchReqID = Nothing
					Else
						entity.PurchReqID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property PurchReqDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.PurchReqDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PurchReqDate = Nothing
					Else
						entity.PurchReqDate = Convert.ToDateTime(Value)
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
		  	
			Public Property QtyContainers As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.QtyContainers
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.QtyContainers = Nothing
					Else
						entity.QtyContainers = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property DateNeeded As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.DateNeeded
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DateNeeded = Nothing
					Else
						entity.DateNeeded = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property IsOrdered As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.IsOrdered
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.IsOrdered = Nothing
					Else
						entity.IsOrdered = Convert.ToInt32(Value)
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
		  	
			Public Property PONumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.PONumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PONumber = Nothing
					Else
						entity.PONumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property WorkOrderNumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.WorkOrderNumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.WorkOrderNumber = Nothing
					Else
						entity.WorkOrderNumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
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
		  	
			Public Property VendorID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.VendorID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.VendorID = Nothing
					Else
						entity.VendorID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Vendorname As System.String 
				Get
					Dim data_ As System.String = entity.Vendorname
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Vendorname = Nothing
					Else
						entity.Vendorname = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Plannedshipdate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Plannedshipdate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Plannedshipdate = Nothing
					Else
						entity.Plannedshipdate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Deliverydate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Deliverydate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Deliverydate = Nothing
					Else
						entity.Deliverydate = Convert.ToDateTime(Value)
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
		  	
			Public Property Custshipcity As System.String 
				Get
					Dim data_ As System.String = entity.Custshipcity
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Custshipcity = Nothing
					Else
						entity.Custshipcity = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Custshipstateprov As System.String 
				Get
					Dim data_ As System.String = entity.Custshipstateprov
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Custshipstateprov = Nothing
					Else
						entity.Custshipstateprov = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Custshippostalcode As System.String 
				Get
					Dim data_ As System.String = entity.Custshippostalcode
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Custshippostalcode = Nothing
					Else
						entity.Custshippostalcode = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property WorkOrderItemNumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.WorkOrderItemNumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.WorkOrderItemNumber = Nothing
					Else
						entity.WorkOrderItemNumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property DateReceived As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.DateReceived
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DateReceived = Nothing
					Else
						entity.DateReceived = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property ReceiverItemNumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.ReceiverItemNumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ReceiverItemNumber = Nothing
					Else
						entity.ReceiverItemNumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property ProdOrderNum As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.ProdOrderNum
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ProdOrderNum = Nothing
					Else
						entity.ProdOrderNum = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewPurchaseRequest
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewPurchaseRequestQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewPurchaseRequest can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewPurchaseRequestQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewPurchaseRequestMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property PurchReqID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseRequestMetadata.ColumnNames.PurchReqID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property PurchReqDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseRequestMetadata.ColumnNames.PurchReqDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ProductID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseRequestMetadata.ColumnNames.ProductID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property QtyContainers As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseRequestMetadata.ColumnNames.QtyContainers, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property DateNeeded As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseRequestMetadata.ColumnNames.DateNeeded, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property IsOrdered As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseRequestMetadata.ColumnNames.IsOrdered, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseRequestMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Units As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseRequestMetadata.ColumnNames.Units, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Uom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseRequestMetadata.ColumnNames.Uom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseRequestMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PONumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseRequestMetadata.ColumnNames.PONumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property WorkOrderNumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseRequestMetadata.ColumnNames.WorkOrderNumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property CustID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseRequestMetadata.ColumnNames.CustID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property VendorID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseRequestMetadata.ColumnNames.VendorID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Vendorname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseRequestMetadata.ColumnNames.Vendorname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Plannedshipdate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseRequestMetadata.ColumnNames.Plannedshipdate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Deliverydate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseRequestMetadata.ColumnNames.Deliverydate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Workorderdate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseRequestMetadata.ColumnNames.Workorderdate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Custname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseRequestMetadata.ColumnNames.Custname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Custshipcity As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseRequestMetadata.ColumnNames.Custshipcity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Custshipstateprov As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseRequestMetadata.ColumnNames.Custshipstateprov, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Custshippostalcode As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseRequestMetadata.ColumnNames.Custshippostalcode, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property WorkOrderItemNumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseRequestMetadata.ColumnNames.WorkOrderItemNumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property DateReceived As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseRequestMetadata.ColumnNames.DateReceived, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ReceiverItemNumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseRequestMetadata.ColumnNames.ReceiverItemNumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ProdOrderNum As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseRequestMetadata.ColumnNames.ProdOrderNum, esSystemType.Int32)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewPurchaseRequestCollection")> _
	Partial Public Class ViewPurchaseRequestCollection
		Inherits esViewPurchaseRequestCollection
		Implements IEnumerable(Of ViewPurchaseRequest)
		
        Public Shared Widening Operator CType(ByVal coll As ViewPurchaseRequestCollection) As List(Of ViewPurchaseRequest)
            Dim list As List(Of ViewPurchaseRequest) = New List(Of ViewPurchaseRequest)
            Dim emp As ViewPurchaseRequest

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewPurchaseRequestMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewPurchaseRequestQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewPurchaseRequest(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewPurchaseRequest()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewPurchaseRequestQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewPurchaseRequestQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewPurchaseRequestQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewPurchaseRequest 
			Return CType(MyBase.AddNewEntity(), ViewPurchaseRequest)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewPurchaseRequest) Implements IEnumerable(Of ViewPurchaseRequest).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewPurchaseRequest)(Me)
        End Function
		
		Private _query As ViewPurchaseRequestQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewPurchaseRequest' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewPurchaseRequest ()")> _
	<Serializable> _
	Partial Public Class ViewPurchaseRequest 
		Inherits esViewPurchaseRequest

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewPurchaseRequestMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewPurchaseRequestQuery

			If Me._query Is Nothing Then
				Me._query = New ViewPurchaseRequestQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewPurchaseRequestQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewPurchaseRequestQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewPurchaseRequestQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewPurchaseRequestQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewPurchaseRequestQuery
		inherits esViewPurchaseRequestQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewPurchaseRequestQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewPurchaseRequestMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewPurchaseRequestMetadata.ColumnNames.PurchReqID, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewPurchaseRequestMetadata.PropertyNames.PurchReqID
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseRequestMetadata.ColumnNames.PurchReqDate, 1, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewPurchaseRequestMetadata.PropertyNames.PurchReqDate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseRequestMetadata.ColumnNames.ProductID, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewPurchaseRequestMetadata.PropertyNames.ProductID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseRequestMetadata.ColumnNames.QtyContainers, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewPurchaseRequestMetadata.PropertyNames.QtyContainers
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseRequestMetadata.ColumnNames.DateNeeded, 4, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewPurchaseRequestMetadata.PropertyNames.DateNeeded
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseRequestMetadata.ColumnNames.IsOrdered, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewPurchaseRequestMetadata.PropertyNames.IsOrdered
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseRequestMetadata.ColumnNames.Productdesc, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPurchaseRequestMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseRequestMetadata.ColumnNames.Units, 7, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewPurchaseRequestMetadata.PropertyNames.Units
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseRequestMetadata.ColumnNames.Uom, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPurchaseRequestMetadata.PropertyNames.Uom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseRequestMetadata.ColumnNames.Container, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPurchaseRequestMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseRequestMetadata.ColumnNames.PONumber, 10, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewPurchaseRequestMetadata.PropertyNames.PONumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseRequestMetadata.ColumnNames.WorkOrderNumber, 11, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewPurchaseRequestMetadata.PropertyNames.WorkOrderNumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseRequestMetadata.ColumnNames.CustID, 12, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewPurchaseRequestMetadata.PropertyNames.CustID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseRequestMetadata.ColumnNames.VendorID, 13, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewPurchaseRequestMetadata.PropertyNames.VendorID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseRequestMetadata.ColumnNames.Vendorname, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPurchaseRequestMetadata.PropertyNames.Vendorname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseRequestMetadata.ColumnNames.Plannedshipdate, 15, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewPurchaseRequestMetadata.PropertyNames.Plannedshipdate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseRequestMetadata.ColumnNames.Deliverydate, 16, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewPurchaseRequestMetadata.PropertyNames.Deliverydate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseRequestMetadata.ColumnNames.Workorderdate, 17, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewPurchaseRequestMetadata.PropertyNames.Workorderdate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseRequestMetadata.ColumnNames.Custname, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPurchaseRequestMetadata.PropertyNames.Custname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseRequestMetadata.ColumnNames.Custshipcity, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPurchaseRequestMetadata.PropertyNames.Custshipcity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseRequestMetadata.ColumnNames.Custshipstateprov, 20, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPurchaseRequestMetadata.PropertyNames.Custshipstateprov
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseRequestMetadata.ColumnNames.Custshippostalcode, 21, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPurchaseRequestMetadata.PropertyNames.Custshippostalcode
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseRequestMetadata.ColumnNames.WorkOrderItemNumber, 22, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewPurchaseRequestMetadata.PropertyNames.WorkOrderItemNumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseRequestMetadata.ColumnNames.DateReceived, 23, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewPurchaseRequestMetadata.PropertyNames.DateReceived
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseRequestMetadata.ColumnNames.ReceiverItemNumber, 24, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewPurchaseRequestMetadata.PropertyNames.ReceiverItemNumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseRequestMetadata.ColumnNames.ProdOrderNum, 25, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewPurchaseRequestMetadata.PropertyNames.ProdOrderNum
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewPurchaseRequestMetadata
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
			 Public Const PurchReqID As String = "PurchReqID"
			 Public Const PurchReqDate As String = "PurchReqDate"
			 Public Const ProductID As String = "ProductID"
			 Public Const QtyContainers As String = "QtyContainers"
			 Public Const DateNeeded As String = "DateNeeded"
			 Public Const IsOrdered As String = "IsOrdered"
			 Public Const Productdesc As String = "PRODUCTDESC"
			 Public Const Units As String = "UNITS"
			 Public Const Uom As String = "UOM"
			 Public Const Container As String = "CONTAINER"
			 Public Const PONumber As String = "PONumber"
			 Public Const WorkOrderNumber As String = "WorkOrderNumber"
			 Public Const CustID As String = "CustID"
			 Public Const VendorID As String = "VendorID"
			 Public Const Vendorname As String = "VENDORNAME"
			 Public Const Plannedshipdate As String = "PLANNEDSHIPDATE"
			 Public Const Deliverydate As String = "DELIVERYDATE"
			 Public Const Workorderdate As String = "WORKORDERDATE"
			 Public Const Custname As String = "CUSTNAME"
			 Public Const Custshipcity As String = "CUSTSHIPCITY"
			 Public Const Custshipstateprov As String = "CUSTSHIPSTATEPROV"
			 Public Const Custshippostalcode As String = "CUSTSHIPPOSTALCODE"
			 Public Const WorkOrderItemNumber As String = "WorkOrderItemNumber"
			 Public Const DateReceived As String = "DateReceived"
			 Public Const ReceiverItemNumber As String = "ReceiverItemNumber"
			 Public Const ProdOrderNum As String = "ProdOrderNum"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const PurchReqID As String = "PurchReqID"
			 Public Const PurchReqDate As String = "PurchReqDate"
			 Public Const ProductID As String = "ProductID"
			 Public Const QtyContainers As String = "QtyContainers"
			 Public Const DateNeeded As String = "DateNeeded"
			 Public Const IsOrdered As String = "IsOrdered"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const Units As String = "Units"
			 Public Const Uom As String = "Uom"
			 Public Const Container As String = "Container"
			 Public Const PONumber As String = "PONumber"
			 Public Const WorkOrderNumber As String = "WorkOrderNumber"
			 Public Const CustID As String = "CustID"
			 Public Const VendorID As String = "VendorID"
			 Public Const Vendorname As String = "Vendorname"
			 Public Const Plannedshipdate As String = "Plannedshipdate"
			 Public Const Deliverydate As String = "Deliverydate"
			 Public Const Workorderdate As String = "Workorderdate"
			 Public Const Custname As String = "Custname"
			 Public Const Custshipcity As String = "Custshipcity"
			 Public Const Custshipstateprov As String = "Custshipstateprov"
			 Public Const Custshippostalcode As String = "Custshippostalcode"
			 Public Const WorkOrderItemNumber As String = "WorkOrderItemNumber"
			 Public Const DateReceived As String = "DateReceived"
			 Public Const ReceiverItemNumber As String = "ReceiverItemNumber"
			 Public Const ProdOrderNum As String = "ProdOrderNum"
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
            SyncLock GetType(ViewPurchaseRequestMetadata)
			
				If ViewPurchaseRequestMetadata.mapDelegates Is Nothing Then
					ViewPurchaseRequestMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewPurchaseRequestMetadata._meta Is Nothing Then
                    ViewPurchaseRequestMetadata._meta = New ViewPurchaseRequestMetadata()
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
				

				meta.AddTypeMap("PurchReqID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("PurchReqDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("ProductID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("QtyContainers", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("DateNeeded", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("IsOrdered", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Units", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Uom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("PONumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("WorkOrderNumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("CustID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("VendorID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Vendorname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Plannedshipdate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Deliverydate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Workorderdate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Custname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Custshipcity", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Custshipstateprov", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Custshippostalcode", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("WorkOrderItemNumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("DateReceived", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("ReceiverItemNumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ProdOrderNum", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "viewPurchaseRequest"
				meta.Destination = "viewPurchaseRequest"
				
				meta.spInsert = "proc_viewPurchaseRequestInsert"
				meta.spUpdate = "proc_viewPurchaseRequestUpdate"
				meta.spDelete = "proc_viewPurchaseRequestDelete"
				meta.spLoadAll = "proc_viewPurchaseRequestLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewPurchaseRequestLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewPurchaseRequestMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
