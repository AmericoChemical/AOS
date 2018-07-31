'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 3/8/2016 10:35:52 AM
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
	MustInherit Public Class esViewWorkOrdersInProcessCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewWorkOrdersInProcessCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewWorkOrdersInProcessQuery)
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
            Me.InitQuery(CType(query, esViewWorkOrdersInProcessQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewWorkOrdersInProcess) As ViewWorkOrdersInProcess
			Return CType(MyBase.DetachEntity(entity), ViewWorkOrdersInProcess)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewWorkOrdersInProcess) As ViewWorkOrdersInProcess
			Return CType(MyBase.AttachEntity(entity), ViewWorkOrdersInProcess)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewWorkOrdersInProcessCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewWorkOrdersInProcess
            Get
                Return TryCast(MyBase.Item(index), ViewWorkOrdersInProcess)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewWorkOrdersInProcess)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewWorkOrdersInProcess	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewWorkOrdersInProcessQuery
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
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.ContainerQty = CType(value, Nullable(Of System.Decimal))
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
		' Maps to viewWorkOrdersInProcess.WORKORDERNUMBER
		' </summary>
		Public Overridable Property Workordernumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewWorkOrdersInProcessMetadata.ColumnNames.Workordernumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewWorkOrdersInProcessMetadata.ColumnNames.Workordernumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrdersInProcess.WORKORDERDATE
		' </summary>
		Public Overridable Property Workorderdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewWorkOrdersInProcessMetadata.ColumnNames.Workorderdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewWorkOrdersInProcessMetadata.ColumnNames.Workorderdate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrdersInProcess.CUSTID
		' </summary>
		Public Overridable Property Custid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewWorkOrdersInProcessMetadata.ColumnNames.Custid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewWorkOrdersInProcessMetadata.ColumnNames.Custid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrdersInProcess.CUSTNAME
		' </summary>
		Public Overridable Property Custname As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrdersInProcessMetadata.ColumnNames.Custname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrdersInProcessMetadata.ColumnNames.Custname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrdersInProcess.CUSTOMERPO
		' </summary>
		Public Overridable Property Customerpo As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrdersInProcessMetadata.ColumnNames.Customerpo)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrdersInProcessMetadata.ColumnNames.Customerpo, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrdersInProcess.PLANNEDSHIPDATE
		' </summary>
		Public Overridable Property Plannedshipdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewWorkOrdersInProcessMetadata.ColumnNames.Plannedshipdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewWorkOrdersInProcessMetadata.ColumnNames.Plannedshipdate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrdersInProcess.DELIVERYDATE
		' </summary>
		Public Overridable Property Deliverydate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewWorkOrdersInProcessMetadata.ColumnNames.Deliverydate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewWorkOrdersInProcessMetadata.ColumnNames.Deliverydate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrdersInProcess.ORDERNOTES
		' </summary>
		Public Overridable Property Ordernotes As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrdersInProcessMetadata.ColumnNames.Ordernotes)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrdersInProcessMetadata.ColumnNames.Ordernotes, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrdersInProcess.WORKORDERTYPE
		' </summary>
		Public Overridable Property Workordertype As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrdersInProcessMetadata.ColumnNames.Workordertype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrdersInProcessMetadata.ColumnNames.Workordertype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrdersInProcess.ORDERSTATUS
		' </summary>
		Public Overridable Property Orderstatus As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrdersInProcessMetadata.ColumnNames.Orderstatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrdersInProcessMetadata.ColumnNames.Orderstatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrdersInProcess.OnHold
		' </summary>
		Public Overridable Property OnHold As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrdersInProcessMetadata.ColumnNames.OnHold)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrdersInProcessMetadata.ColumnNames.OnHold, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrdersInProcess.ContainerQty
		' </summary>
		Public Overridable Property ContainerQty As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewWorkOrdersInProcessMetadata.ColumnNames.ContainerQty)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewWorkOrdersInProcessMetadata.ColumnNames.ContainerQty, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrdersInProcess.UnAllocatedQty
		' </summary>
		Public Overridable Property UnAllocatedQty As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewWorkOrdersInProcessMetadata.ColumnNames.UnAllocatedQty)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewWorkOrdersInProcessMetadata.ColumnNames.UnAllocatedQty, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrdersInProcess.OpenProdOrderQty
		' </summary>
		Public Overridable Property OpenProdOrderQty As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewWorkOrdersInProcessMetadata.ColumnNames.OpenProdOrderQty)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewWorkOrdersInProcessMetadata.ColumnNames.OpenProdOrderQty, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrdersInProcess.OpenReqQty
		' </summary>
		Public Overridable Property OpenReqQty As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewWorkOrdersInProcessMetadata.ColumnNames.OpenReqQty)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewWorkOrdersInProcessMetadata.ColumnNames.OpenReqQty, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrdersInProcess.OpenPurchPendingQty
		' </summary>
		Public Overridable Property OpenPurchPendingQty As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewWorkOrdersInProcessMetadata.ColumnNames.OpenPurchPendingQty)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewWorkOrdersInProcessMetadata.ColumnNames.OpenPurchPendingQty, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrdersInProcess.BILLINGTYPE
		' </summary>
		Public Overridable Property Billingtype As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrdersInProcessMetadata.ColumnNames.Billingtype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrdersInProcessMetadata.ColumnNames.Billingtype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrdersInProcess.TRANSPORTTYPE
		' </summary>
		Public Overridable Property Transporttype As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrdersInProcessMetadata.ColumnNames.Transporttype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrdersInProcessMetadata.ColumnNames.Transporttype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrdersInProcess.ORDERTYPE
		' </summary>
		Public Overridable Property Ordertype As System.String
			Get
				Return MyBase.GetSystemString(ViewWorkOrdersInProcessMetadata.ColumnNames.Ordertype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewWorkOrdersInProcessMetadata.ColumnNames.Ordertype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewWorkOrdersInProcess.ITEMSEXPECTEDAFTERDATENEEDED
		' </summary>
		Public Overridable Property Itemsexpectedafterdateneeded As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewWorkOrdersInProcessMetadata.ColumnNames.Itemsexpectedafterdateneeded)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewWorkOrdersInProcessMetadata.ColumnNames.Itemsexpectedafterdateneeded, value)
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
		
			Public Sub New(ByVal entity As esViewWorkOrdersInProcess)
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
					Dim data_ As Nullable(Of System.Decimal) = entity.ContainerQty
					
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
						entity.ContainerQty = Convert.ToDecimal(Value)
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
		  

			Private entity As esViewWorkOrdersInProcess
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewWorkOrdersInProcessQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewWorkOrdersInProcess can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewWorkOrdersInProcessQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewWorkOrdersInProcessMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Workordernumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrdersInProcessMetadata.ColumnNames.Workordernumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Workorderdate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrdersInProcessMetadata.ColumnNames.Workorderdate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Custid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrdersInProcessMetadata.ColumnNames.Custid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Custname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrdersInProcessMetadata.ColumnNames.Custname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Customerpo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrdersInProcessMetadata.ColumnNames.Customerpo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Plannedshipdate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrdersInProcessMetadata.ColumnNames.Plannedshipdate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Deliverydate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrdersInProcessMetadata.ColumnNames.Deliverydate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Ordernotes As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrdersInProcessMetadata.ColumnNames.Ordernotes, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Workordertype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrdersInProcessMetadata.ColumnNames.Workordertype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Orderstatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrdersInProcessMetadata.ColumnNames.Orderstatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OnHold As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrdersInProcessMetadata.ColumnNames.OnHold, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ContainerQty As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrdersInProcessMetadata.ColumnNames.ContainerQty, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property UnAllocatedQty As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrdersInProcessMetadata.ColumnNames.UnAllocatedQty, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property OpenProdOrderQty As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrdersInProcessMetadata.ColumnNames.OpenProdOrderQty, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property OpenReqQty As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrdersInProcessMetadata.ColumnNames.OpenReqQty, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property OpenPurchPendingQty As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrdersInProcessMetadata.ColumnNames.OpenPurchPendingQty, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Billingtype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrdersInProcessMetadata.ColumnNames.Billingtype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Transporttype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrdersInProcessMetadata.ColumnNames.Transporttype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Ordertype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrdersInProcessMetadata.ColumnNames.Ordertype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Itemsexpectedafterdateneeded As esQueryItem
			Get
				Return New esQueryItem(Me, ViewWorkOrdersInProcessMetadata.ColumnNames.Itemsexpectedafterdateneeded, esSystemType.Int32)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewWorkOrdersInProcessCollection")> _
	Partial Public Class ViewWorkOrdersInProcessCollection
		Inherits esViewWorkOrdersInProcessCollection
		Implements IEnumerable(Of ViewWorkOrdersInProcess)
		
        Public Shared Widening Operator CType(ByVal coll As ViewWorkOrdersInProcessCollection) As List(Of ViewWorkOrdersInProcess)
            Dim list As List(Of ViewWorkOrdersInProcess) = New List(Of ViewWorkOrdersInProcess)
            Dim emp As ViewWorkOrdersInProcess

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewWorkOrdersInProcessMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewWorkOrdersInProcessQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewWorkOrdersInProcess(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewWorkOrdersInProcess()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewWorkOrdersInProcessQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewWorkOrdersInProcessQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewWorkOrdersInProcessQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewWorkOrdersInProcess 
			Return CType(MyBase.AddNewEntity(), ViewWorkOrdersInProcess)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewWorkOrdersInProcess) Implements IEnumerable(Of ViewWorkOrdersInProcess).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewWorkOrdersInProcess)(Me)
        End Function
		
		Private _query As ViewWorkOrdersInProcessQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewWorkOrdersInProcess' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewWorkOrdersInProcess ()")> _
	<Serializable> _
	Partial Public Class ViewWorkOrdersInProcess 
		Inherits esViewWorkOrdersInProcess

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewWorkOrdersInProcessMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewWorkOrdersInProcessQuery

			If Me._query Is Nothing Then
				Me._query = New ViewWorkOrdersInProcessQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewWorkOrdersInProcessQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewWorkOrdersInProcessQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewWorkOrdersInProcessQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewWorkOrdersInProcessQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewWorkOrdersInProcessQuery
		inherits esViewWorkOrdersInProcessQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewWorkOrdersInProcessQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewWorkOrdersInProcessMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewWorkOrdersInProcessMetadata.ColumnNames.Workordernumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewWorkOrdersInProcessMetadata.PropertyNames.Workordernumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrdersInProcessMetadata.ColumnNames.Workorderdate, 1, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewWorkOrdersInProcessMetadata.PropertyNames.Workorderdate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrdersInProcessMetadata.ColumnNames.Custid, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewWorkOrdersInProcessMetadata.PropertyNames.Custid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrdersInProcessMetadata.ColumnNames.Custname, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrdersInProcessMetadata.PropertyNames.Custname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrdersInProcessMetadata.ColumnNames.Customerpo, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrdersInProcessMetadata.PropertyNames.Customerpo
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrdersInProcessMetadata.ColumnNames.Plannedshipdate, 5, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewWorkOrdersInProcessMetadata.PropertyNames.Plannedshipdate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrdersInProcessMetadata.ColumnNames.Deliverydate, 6, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewWorkOrdersInProcessMetadata.PropertyNames.Deliverydate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrdersInProcessMetadata.ColumnNames.Ordernotes, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrdersInProcessMetadata.PropertyNames.Ordernotes
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrdersInProcessMetadata.ColumnNames.Workordertype, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrdersInProcessMetadata.PropertyNames.Workordertype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrdersInProcessMetadata.ColumnNames.Orderstatus, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrdersInProcessMetadata.PropertyNames.Orderstatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrdersInProcessMetadata.ColumnNames.OnHold, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrdersInProcessMetadata.PropertyNames.OnHold
			c.CharacterMaxLength = 1
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrdersInProcessMetadata.ColumnNames.ContainerQty, 11, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewWorkOrdersInProcessMetadata.PropertyNames.ContainerQty
			c.NumericPrecision = 38
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrdersInProcessMetadata.ColumnNames.UnAllocatedQty, 12, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewWorkOrdersInProcessMetadata.PropertyNames.UnAllocatedQty
			c.NumericPrecision = 38
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrdersInProcessMetadata.ColumnNames.OpenProdOrderQty, 13, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewWorkOrdersInProcessMetadata.PropertyNames.OpenProdOrderQty
			c.NumericPrecision = 38
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrdersInProcessMetadata.ColumnNames.OpenReqQty, 14, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewWorkOrdersInProcessMetadata.PropertyNames.OpenReqQty
			c.NumericPrecision = 38
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrdersInProcessMetadata.ColumnNames.OpenPurchPendingQty, 15, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewWorkOrdersInProcessMetadata.PropertyNames.OpenPurchPendingQty
			c.NumericPrecision = 38
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrdersInProcessMetadata.ColumnNames.Billingtype, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrdersInProcessMetadata.PropertyNames.Billingtype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrdersInProcessMetadata.ColumnNames.Transporttype, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrdersInProcessMetadata.PropertyNames.Transporttype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrdersInProcessMetadata.ColumnNames.Ordertype, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewWorkOrdersInProcessMetadata.PropertyNames.Ordertype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewWorkOrdersInProcessMetadata.ColumnNames.Itemsexpectedafterdateneeded, 19, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewWorkOrdersInProcessMetadata.PropertyNames.Itemsexpectedafterdateneeded
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewWorkOrdersInProcessMetadata
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
            SyncLock GetType(ViewWorkOrdersInProcessMetadata)
			
				If ViewWorkOrdersInProcessMetadata.mapDelegates Is Nothing Then
					ViewWorkOrdersInProcessMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewWorkOrdersInProcessMetadata._meta Is Nothing Then
                    ViewWorkOrdersInProcessMetadata._meta = New ViewWorkOrdersInProcessMetadata()
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
				meta.AddTypeMap("ContainerQty", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("UnAllocatedQty", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("OpenProdOrderQty", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("OpenReqQty", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("OpenPurchPendingQty", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Billingtype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Transporttype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Ordertype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Itemsexpectedafterdateneeded", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "viewWorkOrdersInProcess"
				meta.Destination = "viewWorkOrdersInProcess"
				
				meta.spInsert = "proc_viewWorkOrdersInProcessInsert"
				meta.spUpdate = "proc_viewWorkOrdersInProcessUpdate"
				meta.spDelete = "proc_viewWorkOrdersInProcessDelete"
				meta.spLoadAll = "proc_viewWorkOrdersInProcessLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewWorkOrdersInProcessLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewWorkOrdersInProcessMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
