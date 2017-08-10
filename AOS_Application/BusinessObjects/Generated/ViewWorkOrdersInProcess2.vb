'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 3/8/2016 1:57:34 PM
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
	MustInherit Public Class esViewWorkOrdersInProcess2Collection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewWorkOrdersInProcess2Collection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewWorkOrdersInProcess2Query)
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
            Me.InitQuery(CType(query, esViewWorkOrdersInProcess2Query))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewWorkOrdersInProcess2) As ViewWorkOrdersInProcess2
			Return CType(MyBase.DetachEntity(entity), ViewWorkOrdersInProcess2)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewWorkOrdersInProcess2) As ViewWorkOrdersInProcess2
			Return CType(MyBase.AttachEntity(entity), ViewWorkOrdersInProcess2)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewWorkOrdersInProcess2Collection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewWorkOrdersInProcess2
            Get
                Return TryCast(MyBase.Item(index), ViewWorkOrdersInProcess2)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewWorkOrdersInProcess2)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewWorkOrdersInProcess2	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewWorkOrdersInProcess2Query
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
												
						Case "Custid"
							Me.str.Custid = CType(value, string)
												
						Case "Custname"
							Me.str.Custname = CType(value, string)
												
						Case "Customerpo"
							Me.str.Customerpo = CType(value, string)
												
						Case "Plannedshipdate"
							Me.str.Plannedshipdate = CType(value, string)
												
						Case "Deliverydate"
							Me.str.Deliverydate = CType(value, string)
												
						Case "Ordernotes"
							Me.str.Ordernotes = CType(value, string)
												
						Case "Workordertype"
							Me.str.Workordertype = CType(value, string)
												
						Case "Orderstatus"
							Me.str.Orderstatus = CType(value, string)
												
						Case "OnHold"
							Me.str.OnHold = CType(value, string)
												
						Case "ContainerQty"
							Me.str.ContainerQty = CType(value, string)
												
						Case "UnAllocatedQty"
							Me.str.UnAllocatedQty = CType(value, string)
												
						Case "OpenProdOrderQty"
							Me.str.OpenProdOrderQty = CType(value, string)
												
						Case "OpenReqQty"
							Me.str.OpenReqQty = CType(value, string)
												
						Case "OpenPurchPendingQty"
							Me.str.OpenPurchPendingQty = CType(value, string)
												
						Case "Billingtype"
							Me.str.Billingtype = CType(value, string)
												
						Case "Transporttype"
							Me.str.Transporttype = CType(value, string)
												
						Case "Ordertype"
							Me.str.Ordertype = CType(value, string)
												
						Case "Itemsexpectedafterdateneeded"
							Me.str.Itemsexpectedafterdateneeded = CType(value, string)
					
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
						
						Case "Custid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Custid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Plannedshipdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Plannedshipdate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Deliverydate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Deliverydate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "ContainerQty"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ContainerQty = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "UnAllocatedQty"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.UnAllocatedQty = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "OpenProdOrderQty"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.OpenProdOrderQty = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "OpenReqQty"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.OpenReqQty = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "OpenPurchPendingQty"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.OpenPurchPendingQty = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Itemsexpectedafterdateneeded"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Itemsexpectedafterdateneeded = CType(value, Nullable(Of System.Int32))
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
		' Maps to viewWorkOrdersInProcess2.WORKORDERNUMBER
		' </summary>
		Public Overridable Property Workordernumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewWorkOrdersInProcess2Metadata.ColumnNames.Workordernumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewWorkOrdersInProcess2Metadata.ColumnNames.Workordernumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrdersInProcess2.WORKORDERDATE
		' </summary>
		Public Overridable Property Workorderdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewWorkOrdersInProcess2Metadata.ColumnNames.Workorderdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewWorkOrdersInProcess2Metadata.ColumnNames.Workorderdate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrdersInProcess2.CUSTID
		' </summary>
		Public Overridable Property Custid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewWorkOrdersInProcess2Metadata.ColumnNames.Custid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewWorkOrdersInProcess2Metadata.ColumnNames.Custid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrdersInProcess2.CUSTNAME
		' </summary>
		Public Overridable Property Custname As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrdersInProcess2Metadata.ColumnNames.Custname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrdersInProcess2Metadata.ColumnNames.Custname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrdersInProcess2.CUSTOMERPO
		' </summary>
		Public Overridable Property Customerpo As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrdersInProcess2Metadata.ColumnNames.Customerpo)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrdersInProcess2Metadata.ColumnNames.Customerpo, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrdersInProcess2.PLANNEDSHIPDATE
		' </summary>
		Public Overridable Property Plannedshipdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewWorkOrdersInProcess2Metadata.ColumnNames.Plannedshipdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewWorkOrdersInProcess2Metadata.ColumnNames.Plannedshipdate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrdersInProcess2.DELIVERYDATE
		' </summary>
		Public Overridable Property Deliverydate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewWorkOrdersInProcess2Metadata.ColumnNames.Deliverydate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewWorkOrdersInProcess2Metadata.ColumnNames.Deliverydate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrdersInProcess2.ORDERNOTES
		' </summary>
		Public Overridable Property Ordernotes As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrdersInProcess2Metadata.ColumnNames.Ordernotes)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrdersInProcess2Metadata.ColumnNames.Ordernotes, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrdersInProcess2.WORKORDERTYPE
		' </summary>
		Public Overridable Property Workordertype As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrdersInProcess2Metadata.ColumnNames.Workordertype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrdersInProcess2Metadata.ColumnNames.Workordertype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrdersInProcess2.ORDERSTATUS
		' </summary>
		Public Overridable Property Orderstatus As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrdersInProcess2Metadata.ColumnNames.Orderstatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrdersInProcess2Metadata.ColumnNames.Orderstatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrdersInProcess2.OnHold
		' </summary>
		Public Overridable Property OnHold As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrdersInProcess2Metadata.ColumnNames.OnHold)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrdersInProcess2Metadata.ColumnNames.OnHold, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrdersInProcess2.ContainerQty
		' </summary>
		Public Overridable Property ContainerQty As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewWorkOrdersInProcess2Metadata.ColumnNames.ContainerQty)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewWorkOrdersInProcess2Metadata.ColumnNames.ContainerQty, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrdersInProcess2.UnAllocatedQty
		' </summary>
		Public Overridable Property UnAllocatedQty As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewWorkOrdersInProcess2Metadata.ColumnNames.UnAllocatedQty)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewWorkOrdersInProcess2Metadata.ColumnNames.UnAllocatedQty, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrdersInProcess2.OpenProdOrderQty
		' </summary>
		Public Overridable Property OpenProdOrderQty As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewWorkOrdersInProcess2Metadata.ColumnNames.OpenProdOrderQty)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewWorkOrdersInProcess2Metadata.ColumnNames.OpenProdOrderQty, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrdersInProcess2.OpenReqQty
		' </summary>
		Public Overridable Property OpenReqQty As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewWorkOrdersInProcess2Metadata.ColumnNames.OpenReqQty)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewWorkOrdersInProcess2Metadata.ColumnNames.OpenReqQty, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrdersInProcess2.OpenPurchPendingQty
		' </summary>
		Public Overridable Property OpenPurchPendingQty As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewWorkOrdersInProcess2Metadata.ColumnNames.OpenPurchPendingQty)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewWorkOrdersInProcess2Metadata.ColumnNames.OpenPurchPendingQty, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrdersInProcess2.BILLINGTYPE
		' </summary>
		Public Overridable Property Billingtype As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrdersInProcess2Metadata.ColumnNames.Billingtype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrdersInProcess2Metadata.ColumnNames.Billingtype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrdersInProcess2.TRANSPORTTYPE
		' </summary>
		Public Overridable Property Transporttype As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrdersInProcess2Metadata.ColumnNames.Transporttype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrdersInProcess2Metadata.ColumnNames.Transporttype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrdersInProcess2.ORDERTYPE
		' </summary>
		Public Overridable Property Ordertype As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrdersInProcess2Metadata.ColumnNames.Ordertype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrdersInProcess2Metadata.ColumnNames.Ordertype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrdersInProcess2.ITEMSEXPECTEDAFTERDATENEEDED
		' </summary>
		Public Overridable Property Itemsexpectedafterdateneeded As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewWorkOrdersInProcess2Metadata.ColumnNames.Itemsexpectedafterdateneeded)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewWorkOrdersInProcess2Metadata.ColumnNames.Itemsexpectedafterdateneeded, value)
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
		
			Public Sub New(ByVal entity As esViewWorkOrdersInProcess2)
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
		  	
			Public Property Customerpo As System.String 
				Get
					Dim data_ As System.String = entity.Customerpo
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Customerpo = Nothing
					Else
						entity.Customerpo = Convert.ToString(Value)
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
		  	
			Public Property Ordernotes As System.String 
				Get
					Dim data_ As System.String = entity.Ordernotes
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Ordernotes = Nothing
					Else
						entity.Ordernotes = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Workordertype As System.String 
				Get
					Dim data_ As System.String = entity.Workordertype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Workordertype = Nothing
					Else
						entity.Workordertype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Orderstatus As System.String 
				Get
					Dim data_ As System.String = entity.Orderstatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Orderstatus = Nothing
					Else
						entity.Orderstatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property OnHold As System.String 
				Get
					Dim data_ As System.String = entity.OnHold
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OnHold = Nothing
					Else
						entity.OnHold = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ContainerQty As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.ContainerQty
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ContainerQty = Nothing
					Else
						entity.ContainerQty = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property UnAllocatedQty As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.UnAllocatedQty
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.UnAllocatedQty = Nothing
					Else
						entity.UnAllocatedQty = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property OpenProdOrderQty As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.OpenProdOrderQty
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OpenProdOrderQty = Nothing
					Else
						entity.OpenProdOrderQty = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property OpenReqQty As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.OpenReqQty
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OpenReqQty = Nothing
					Else
						entity.OpenReqQty = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property OpenPurchPendingQty As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.OpenPurchPendingQty
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OpenPurchPendingQty = Nothing
					Else
						entity.OpenPurchPendingQty = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Billingtype As System.String 
				Get
					Dim data_ As System.String = entity.Billingtype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Billingtype = Nothing
					Else
						entity.Billingtype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Transporttype As System.String 
				Get
					Dim data_ As System.String = entity.Transporttype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Transporttype = Nothing
					Else
						entity.Transporttype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Ordertype As System.String 
				Get
					Dim data_ As System.String = entity.Ordertype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Ordertype = Nothing
					Else
						entity.Ordertype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Itemsexpectedafterdateneeded As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Itemsexpectedafterdateneeded
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Itemsexpectedafterdateneeded = Nothing
					Else
						entity.Itemsexpectedafterdateneeded = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewWorkOrdersInProcess2
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewWorkOrdersInProcess2Query)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewWorkOrdersInProcess2 can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewWorkOrdersInProcess2Query 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewWorkOrdersInProcess2Metadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Workordernumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrdersInProcess2Metadata.ColumnNames.Workordernumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Workorderdate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrdersInProcess2Metadata.ColumnNames.Workorderdate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Custid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrdersInProcess2Metadata.ColumnNames.Custid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Custname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrdersInProcess2Metadata.ColumnNames.Custname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Customerpo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrdersInProcess2Metadata.ColumnNames.Customerpo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Plannedshipdate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrdersInProcess2Metadata.ColumnNames.Plannedshipdate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Deliverydate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrdersInProcess2Metadata.ColumnNames.Deliverydate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Ordernotes As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrdersInProcess2Metadata.ColumnNames.Ordernotes, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Workordertype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrdersInProcess2Metadata.ColumnNames.Workordertype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Orderstatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrdersInProcess2Metadata.ColumnNames.Orderstatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OnHold As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrdersInProcess2Metadata.ColumnNames.OnHold, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ContainerQty As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrdersInProcess2Metadata.ColumnNames.ContainerQty, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property UnAllocatedQty As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrdersInProcess2Metadata.ColumnNames.UnAllocatedQty, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property OpenProdOrderQty As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrdersInProcess2Metadata.ColumnNames.OpenProdOrderQty, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property OpenReqQty As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrdersInProcess2Metadata.ColumnNames.OpenReqQty, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property OpenPurchPendingQty As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrdersInProcess2Metadata.ColumnNames.OpenPurchPendingQty, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Billingtype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrdersInProcess2Metadata.ColumnNames.Billingtype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Transporttype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrdersInProcess2Metadata.ColumnNames.Transporttype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Ordertype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrdersInProcess2Metadata.ColumnNames.Ordertype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Itemsexpectedafterdateneeded As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrdersInProcess2Metadata.ColumnNames.Itemsexpectedafterdateneeded, esSystemType.Int32)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewWorkOrdersInProcess2Collection")> _
	Partial Public Class ViewWorkOrdersInProcess2Collection
		Inherits esViewWorkOrdersInProcess2Collection
		Implements IEnumerable(Of ViewWorkOrdersInProcess2)
		
        Public Shared Widening Operator CType(ByVal coll As ViewWorkOrdersInProcess2Collection) As List(Of ViewWorkOrdersInProcess2)
            Dim list As List(Of ViewWorkOrdersInProcess2) = New List(Of ViewWorkOrdersInProcess2)
            Dim emp As ViewWorkOrdersInProcess2

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewWorkOrdersInProcess2Metadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewWorkOrdersInProcess2Query()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewWorkOrdersInProcess2(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewWorkOrdersInProcess2()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewWorkOrdersInProcess2Query 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewWorkOrdersInProcess2Query()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewWorkOrdersInProcess2Query) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewWorkOrdersInProcess2 
			Return CType(MyBase.AddNewEntity(), ViewWorkOrdersInProcess2)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewWorkOrdersInProcess2) Implements IEnumerable(Of ViewWorkOrdersInProcess2).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewWorkOrdersInProcess2)(Me)
        End Function
		
		Private _query As ViewWorkOrdersInProcess2Query

	End Class
	


	' <summary>
	' Encapsulates the 'viewWorkOrdersInProcess2' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewWorkOrdersInProcess2 ()")> _
	<Serializable> _
	Partial Public Class ViewWorkOrdersInProcess2 
		Inherits esViewWorkOrdersInProcess2

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewWorkOrdersInProcess2Metadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewWorkOrdersInProcess2Query

			If Me._query Is Nothing Then
				Me._query = New ViewWorkOrdersInProcess2Query()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewWorkOrdersInProcess2Query
			Get

				If Me._query Is Nothing then
					Me._query = New ViewWorkOrdersInProcess2Query()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewWorkOrdersInProcess2Query) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewWorkOrdersInProcess2Query

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewWorkOrdersInProcess2Query
		inherits esViewWorkOrdersInProcess2Query
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewWorkOrdersInProcess2Query"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewWorkOrdersInProcess2Metadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewWorkOrdersInProcess2Metadata.ColumnNames.Workordernumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewWorkOrdersInProcess2Metadata.PropertyNames.Workordernumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrdersInProcess2Metadata.ColumnNames.Workorderdate, 1, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewWorkOrdersInProcess2Metadata.PropertyNames.Workorderdate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrdersInProcess2Metadata.ColumnNames.Custid, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewWorkOrdersInProcess2Metadata.PropertyNames.Custid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrdersInProcess2Metadata.ColumnNames.Custname, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrdersInProcess2Metadata.PropertyNames.Custname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrdersInProcess2Metadata.ColumnNames.Customerpo, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrdersInProcess2Metadata.PropertyNames.Customerpo
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrdersInProcess2Metadata.ColumnNames.Plannedshipdate, 5, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewWorkOrdersInProcess2Metadata.PropertyNames.Plannedshipdate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrdersInProcess2Metadata.ColumnNames.Deliverydate, 6, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewWorkOrdersInProcess2Metadata.PropertyNames.Deliverydate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrdersInProcess2Metadata.ColumnNames.Ordernotes, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrdersInProcess2Metadata.PropertyNames.Ordernotes
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrdersInProcess2Metadata.ColumnNames.Workordertype, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrdersInProcess2Metadata.PropertyNames.Workordertype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrdersInProcess2Metadata.ColumnNames.Orderstatus, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrdersInProcess2Metadata.PropertyNames.Orderstatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrdersInProcess2Metadata.ColumnNames.OnHold, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrdersInProcess2Metadata.PropertyNames.OnHold
			c.CharacterMaxLength = 1
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrdersInProcess2Metadata.ColumnNames.ContainerQty, 11, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewWorkOrdersInProcess2Metadata.PropertyNames.ContainerQty
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrdersInProcess2Metadata.ColumnNames.UnAllocatedQty, 12, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewWorkOrdersInProcess2Metadata.PropertyNames.UnAllocatedQty
			c.NumericPrecision = 38
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrdersInProcess2Metadata.ColumnNames.OpenProdOrderQty, 13, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewWorkOrdersInProcess2Metadata.PropertyNames.OpenProdOrderQty
			c.NumericPrecision = 38
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrdersInProcess2Metadata.ColumnNames.OpenReqQty, 14, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewWorkOrdersInProcess2Metadata.PropertyNames.OpenReqQty
			c.NumericPrecision = 38
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrdersInProcess2Metadata.ColumnNames.OpenPurchPendingQty, 15, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewWorkOrdersInProcess2Metadata.PropertyNames.OpenPurchPendingQty
			c.NumericPrecision = 38
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrdersInProcess2Metadata.ColumnNames.Billingtype, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrdersInProcess2Metadata.PropertyNames.Billingtype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrdersInProcess2Metadata.ColumnNames.Transporttype, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrdersInProcess2Metadata.PropertyNames.Transporttype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrdersInProcess2Metadata.ColumnNames.Ordertype, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrdersInProcess2Metadata.PropertyNames.Ordertype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrdersInProcess2Metadata.ColumnNames.Itemsexpectedafterdateneeded, 19, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewWorkOrdersInProcess2Metadata.PropertyNames.Itemsexpectedafterdateneeded
			c.NumericPrecision = 10
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewWorkOrdersInProcess2Metadata
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
			 Public Const Custid As String = "CUSTID"
			 Public Const Custname As String = "CUSTNAME"
			 Public Const Customerpo As String = "CUSTOMERPO"
			 Public Const Plannedshipdate As String = "PLANNEDSHIPDATE"
			 Public Const Deliverydate As String = "DELIVERYDATE"
			 Public Const Ordernotes As String = "ORDERNOTES"
			 Public Const Workordertype As String = "WORKORDERTYPE"
			 Public Const Orderstatus As String = "ORDERSTATUS"
			 Public Const OnHold As String = "OnHold"
			 Public Const ContainerQty As String = "ContainerQty"
			 Public Const UnAllocatedQty As String = "UnAllocatedQty"
			 Public Const OpenProdOrderQty As String = "OpenProdOrderQty"
			 Public Const OpenReqQty As String = "OpenReqQty"
			 Public Const OpenPurchPendingQty As String = "OpenPurchPendingQty"
			 Public Const Billingtype As String = "BILLINGTYPE"
			 Public Const Transporttype As String = "TRANSPORTTYPE"
			 Public Const Ordertype As String = "ORDERTYPE"
			 Public Const Itemsexpectedafterdateneeded As String = "ITEMSEXPECTEDAFTERDATENEEDED"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Workordernumber As String = "Workordernumber"
			 Public Const Workorderdate As String = "Workorderdate"
			 Public Const Custid As String = "Custid"
			 Public Const Custname As String = "Custname"
			 Public Const Customerpo As String = "Customerpo"
			 Public Const Plannedshipdate As String = "Plannedshipdate"
			 Public Const Deliverydate As String = "Deliverydate"
			 Public Const Ordernotes As String = "Ordernotes"
			 Public Const Workordertype As String = "Workordertype"
			 Public Const Orderstatus As String = "Orderstatus"
			 Public Const OnHold As String = "OnHold"
			 Public Const ContainerQty As String = "ContainerQty"
			 Public Const UnAllocatedQty As String = "UnAllocatedQty"
			 Public Const OpenProdOrderQty As String = "OpenProdOrderQty"
			 Public Const OpenReqQty As String = "OpenReqQty"
			 Public Const OpenPurchPendingQty As String = "OpenPurchPendingQty"
			 Public Const Billingtype As String = "Billingtype"
			 Public Const Transporttype As String = "Transporttype"
			 Public Const Ordertype As String = "Ordertype"
			 Public Const Itemsexpectedafterdateneeded As String = "Itemsexpectedafterdateneeded"
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
            SyncLock GetType(ViewWorkOrdersInProcess2Metadata)
			
				If ViewWorkOrdersInProcess2Metadata.mapDelegates Is Nothing Then
					ViewWorkOrdersInProcess2Metadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewWorkOrdersInProcess2Metadata._meta Is Nothing Then
                    ViewWorkOrdersInProcess2Metadata._meta = New ViewWorkOrdersInProcess2Metadata()
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
				meta.AddTypeMap("Custid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Custname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Customerpo", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Plannedshipdate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Deliverydate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Ordernotes", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Workordertype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Orderstatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("OnHold", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ContainerQty", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("UnAllocatedQty", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("OpenProdOrderQty", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("OpenReqQty", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("OpenPurchPendingQty", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Billingtype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Transporttype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Ordertype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Itemsexpectedafterdateneeded", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "viewWorkOrdersInProcess2"
				meta.Destination = "viewWorkOrdersInProcess2"
				
				meta.spInsert = "proc_viewWorkOrdersInProcess2Insert"
				meta.spUpdate = "proc_viewWorkOrdersInProcess2Update"
				meta.spDelete = "proc_viewWorkOrdersInProcess2Delete"
				meta.spLoadAll = "proc_viewWorkOrdersInProcess2LoadAll"
				meta.spLoadByPrimaryKey = "proc_viewWorkOrdersInProcess2LoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewWorkOrdersInProcess2Metadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
