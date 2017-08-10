'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/11/2014 1:43:57 PM
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
	MustInherit Public Class esPurchaserequestCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "PurchaserequestCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esPurchaserequestQuery)
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
            Me.InitQuery(CType(query, esPurchaserequestQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Purchaserequest) As Purchaserequest
			Return CType(MyBase.DetachEntity(entity), Purchaserequest)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Purchaserequest) As Purchaserequest
			Return CType(MyBase.AttachEntity(entity), Purchaserequest)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As PurchaserequestCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Purchaserequest
            Get
                Return TryCast(MyBase.Item(index), Purchaserequest)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Purchaserequest)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esPurchaserequest	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esPurchaserequestQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal purchReqID As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(purchReqID)
			Else
				Return LoadByPrimaryKeyStoredProcedure(purchReqID)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal purchReqID As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(purchReqID)
			Else
				Return LoadByPrimaryKeyStoredProcedure(purchReqID)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal purchReqID As System.Int32) As Boolean
		
			Dim query As esPurchaserequestQuery = Me.GetDynamicQuery()
			query.Where(query.PurchReqID.Equal(purchReqID))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal purchReqID As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("PurchReqID", purchReqID)
			
			Return Me.Load(esQueryType.StoredProcedure, Me.es.spLoadByPrimaryKey, parms)
			
		End Function
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
												
						Case "PONumber"
							Me.str.PONumber = CType(value, string)
												
						Case "IsOrdered"
							Me.str.IsOrdered = CType(value, string)
												
						Case "CustID"
							Me.str.CustID = CType(value, string)
												
						Case "VendorID"
							Me.str.VendorID = CType(value, string)
												
						Case "WorkOrderNumber"
							Me.str.WorkOrderNumber = CType(value, string)
												
						Case "WorkOrderItemNumber"
							Me.str.WorkOrderItemNumber = CType(value, string)
												
						Case "DateReceived"
							Me.str.DateReceived = CType(value, string)
												
						Case "ReceiverItemNumber"
							Me.str.ReceiverItemNumber = CType(value, string)
												
						Case "ProdOrderNum"
							Me.str.ProdOrderNum = CType(value, string)
												
						Case "Createdby"
							Me.str.Createdby = CType(value, string)
												
						Case "Createdtime"
							Me.str.Createdtime = CType(value, string)
												
						Case "Modifyby"
							Me.str.Modifyby = CType(value, string)
												
						Case "Modifytime"
							Me.str.Modifytime = CType(value, string)
					
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
						
						Case "PONumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.PONumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "IsOrdered"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.IsOrdered = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "CustID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.CustID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "VendorID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.VendorID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "WorkOrderNumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.WorkOrderNumber = CType(value, Nullable(Of System.Int32))
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
						
						Case "Createdtime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Createdtime = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Modifytime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Modifytime = CType(value, Nullable(Of System.DateTime))
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
		' Maps to PURCHASEREQUEST.PurchReqID
		' </summary>
		Public Overridable Property PurchReqID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(PurchaserequestMetadata.ColumnNames.PurchReqID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(PurchaserequestMetadata.ColumnNames.PurchReqID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEREQUEST.PurchReqDate
		' </summary>
		Public Overridable Property PurchReqDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(PurchaserequestMetadata.ColumnNames.PurchReqDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(PurchaserequestMetadata.ColumnNames.PurchReqDate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEREQUEST.ProductID
		' </summary>
		Public Overridable Property ProductID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(PurchaserequestMetadata.ColumnNames.ProductID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(PurchaserequestMetadata.ColumnNames.ProductID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEREQUEST.QtyContainers
		' </summary>
		Public Overridable Property QtyContainers As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(PurchaserequestMetadata.ColumnNames.QtyContainers)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(PurchaserequestMetadata.ColumnNames.QtyContainers, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEREQUEST.DateNeeded
		' </summary>
		Public Overridable Property DateNeeded As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(PurchaserequestMetadata.ColumnNames.DateNeeded)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(PurchaserequestMetadata.ColumnNames.DateNeeded, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEREQUEST.PONumber
		' </summary>
		Public Overridable Property PONumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(PurchaserequestMetadata.ColumnNames.PONumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(PurchaserequestMetadata.ColumnNames.PONumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEREQUEST.IsOrdered
		' </summary>
		Public Overridable Property IsOrdered As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(PurchaserequestMetadata.ColumnNames.IsOrdered)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(PurchaserequestMetadata.ColumnNames.IsOrdered, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEREQUEST.CustID
		' </summary>
		Public Overridable Property CustID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(PurchaserequestMetadata.ColumnNames.CustID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(PurchaserequestMetadata.ColumnNames.CustID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEREQUEST.VendorID
		' </summary>
		Public Overridable Property VendorID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(PurchaserequestMetadata.ColumnNames.VendorID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(PurchaserequestMetadata.ColumnNames.VendorID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEREQUEST.WorkOrderNumber
		' </summary>
		Public Overridable Property WorkOrderNumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(PurchaserequestMetadata.ColumnNames.WorkOrderNumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(PurchaserequestMetadata.ColumnNames.WorkOrderNumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEREQUEST.WorkOrderItemNumber
		' </summary>
		Public Overridable Property WorkOrderItemNumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(PurchaserequestMetadata.ColumnNames.WorkOrderItemNumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(PurchaserequestMetadata.ColumnNames.WorkOrderItemNumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEREQUEST.DateReceived
		' </summary>
		Public Overridable Property DateReceived As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(PurchaserequestMetadata.ColumnNames.DateReceived)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(PurchaserequestMetadata.ColumnNames.DateReceived, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEREQUEST.ReceiverItemNumber
		' </summary>
		Public Overridable Property ReceiverItemNumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(PurchaserequestMetadata.ColumnNames.ReceiverItemNumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(PurchaserequestMetadata.ColumnNames.ReceiverItemNumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEREQUEST.ProdOrderNum
		' </summary>
		Public Overridable Property ProdOrderNum As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(PurchaserequestMetadata.ColumnNames.ProdOrderNum)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(PurchaserequestMetadata.ColumnNames.ProdOrderNum, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEREQUEST.CREATEDBY
		' </summary>
		Public Overridable Property Createdby As System.String
			Get
				Return MyBase.GetSystemString(PurchaserequestMetadata.ColumnNames.Createdby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(PurchaserequestMetadata.ColumnNames.Createdby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEREQUEST.CREATEDTIME
		' </summary>
		Public Overridable Property Createdtime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(PurchaserequestMetadata.ColumnNames.Createdtime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(PurchaserequestMetadata.ColumnNames.Createdtime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEREQUEST.MODIFYBY
		' </summary>
		Public Overridable Property Modifyby As System.String
			Get
				Return MyBase.GetSystemString(PurchaserequestMetadata.ColumnNames.Modifyby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(PurchaserequestMetadata.ColumnNames.Modifyby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEREQUEST.MODIFYTIME
		' </summary>
		Public Overridable Property Modifytime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(PurchaserequestMetadata.ColumnNames.Modifytime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(PurchaserequestMetadata.ColumnNames.Modifytime, value)
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
		
			Public Sub New(ByVal entity As esPurchaserequest)
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
		  	
			Public Property Createdby As System.String 
				Get
					Dim data_ As System.String = entity.Createdby
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Createdby = Nothing
					Else
						entity.Createdby = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Createdtime As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Createdtime
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Createdtime = Nothing
					Else
						entity.Createdtime = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Modifyby As System.String 
				Get
					Dim data_ As System.String = entity.Modifyby
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Modifyby = Nothing
					Else
						entity.Modifyby = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Modifytime As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Modifytime
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Modifytime = Nothing
					Else
						entity.Modifytime = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  

			Private entity As esPurchaserequest
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esPurchaserequestQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esPurchaserequest can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Purchaserequest 
		Inherits esPurchaserequest
		
	
		
		''' <summary>
		''' Used internally by the entity's hierarchical properties.
		''' </summary>
        Protected Overrides Function GetHierarchicalProperties() As List(Of esPropertyDescriptor)
        
            Dim props As New List(Of esPropertyDescriptor)
			

            Return props
			
        End Function	
		
		''' <summary>
		''' Used internally for retrieving AutoIncrementing keys
		''' during hierarchical PreSave.
		''' </summary>
		Protected Overrides Sub ApplyPreSaveKeys()
		
		End Sub
		
		''' <summary>
		''' Used internally for retrieving AutoIncrementing keys
		''' during hierarchical PostSave.
		''' </summary>
		Protected Overrides Sub ApplyPostSaveKeys()
		
		End Sub
		
		''' <summary>
		''' Used internally for retrieving AutoIncrementing keys
		''' during hierarchical PostOneSave.
		''' </summary>
		Protected Overrides Sub ApplyPostOneSaveKeys()
		
		End Sub
	End Class
	


	<Serializable> _
	MustInherit Public Class esPurchaserequestQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return PurchaserequestMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property PurchReqID As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaserequestMetadata.ColumnNames.PurchReqID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property PurchReqDate As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaserequestMetadata.ColumnNames.PurchReqDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ProductID As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaserequestMetadata.ColumnNames.ProductID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property QtyContainers As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaserequestMetadata.ColumnNames.QtyContainers, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property DateNeeded As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaserequestMetadata.ColumnNames.DateNeeded, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property PONumber As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaserequestMetadata.ColumnNames.PONumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property IsOrdered As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaserequestMetadata.ColumnNames.IsOrdered, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property CustID As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaserequestMetadata.ColumnNames.CustID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property VendorID As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaserequestMetadata.ColumnNames.VendorID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property WorkOrderNumber As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaserequestMetadata.ColumnNames.WorkOrderNumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property WorkOrderItemNumber As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaserequestMetadata.ColumnNames.WorkOrderItemNumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property DateReceived As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaserequestMetadata.ColumnNames.DateReceived, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ReceiverItemNumber As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaserequestMetadata.ColumnNames.ReceiverItemNumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ProdOrderNum As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaserequestMetadata.ColumnNames.ProdOrderNum, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Createdby As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaserequestMetadata.ColumnNames.Createdby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Createdtime As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaserequestMetadata.ColumnNames.Createdtime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Modifyby As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaserequestMetadata.ColumnNames.Modifyby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Modifytime As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaserequestMetadata.ColumnNames.Modifytime, esSystemType.DateTime)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("PurchaserequestCollection")> _
	Partial Public Class PurchaserequestCollection
		Inherits esPurchaserequestCollection
		Implements IEnumerable(Of Purchaserequest)
		
        Public Shared Widening Operator CType(ByVal coll As PurchaserequestCollection) As List(Of Purchaserequest)
            Dim list As List(Of Purchaserequest) = New List(Of Purchaserequest)
            Dim emp As Purchaserequest

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return PurchaserequestMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New PurchaserequestQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Purchaserequest(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Purchaserequest()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As PurchaserequestQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New PurchaserequestQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As PurchaserequestQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Purchaserequest 
			Return CType(MyBase.AddNewEntity(), Purchaserequest)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal purchReqID As System.Int32) As Purchaserequest
			Return CType(MyBase.FindByPrimaryKey(purchReqID), Purchaserequest)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Purchaserequest) Implements IEnumerable(Of Purchaserequest).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Purchaserequest)(Me)
        End Function
		
		Private _query As PurchaserequestQuery

	End Class
	


	' <summary>
	' Encapsulates the 'PURCHASEREQUEST' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Purchaserequest ({PurchReqID.Value})")> _
	<Serializable> _
	Partial Public Class Purchaserequest 
		Inherits esPurchaserequest

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return PurchaserequestMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esPurchaserequestQuery

			If Me._query Is Nothing Then
				Me._query = New PurchaserequestQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As PurchaserequestQuery
			Get

				If Me._query Is Nothing then
					Me._query = New PurchaserequestQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As PurchaserequestQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As PurchaserequestQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class PurchaserequestQuery
		inherits esPurchaserequestQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "PurchaserequestQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class PurchaserequestMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(PurchaserequestMetadata.ColumnNames.PurchReqID, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = PurchaserequestMetadata.PropertyNames.PurchReqID
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaserequestMetadata.ColumnNames.PurchReqDate, 1, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = PurchaserequestMetadata.PropertyNames.PurchReqDate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaserequestMetadata.ColumnNames.ProductID, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = PurchaserequestMetadata.PropertyNames.ProductID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaserequestMetadata.ColumnNames.QtyContainers, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = PurchaserequestMetadata.PropertyNames.QtyContainers
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaserequestMetadata.ColumnNames.DateNeeded, 4, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = PurchaserequestMetadata.PropertyNames.DateNeeded
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaserequestMetadata.ColumnNames.PONumber, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = PurchaserequestMetadata.PropertyNames.PONumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaserequestMetadata.ColumnNames.IsOrdered, 6, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = PurchaserequestMetadata.PropertyNames.IsOrdered
			c.NumericPrecision = 10
			c.HasDefault = True
			c.Default = "((0))"
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaserequestMetadata.ColumnNames.CustID, 7, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = PurchaserequestMetadata.PropertyNames.CustID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaserequestMetadata.ColumnNames.VendorID, 8, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = PurchaserequestMetadata.PropertyNames.VendorID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaserequestMetadata.ColumnNames.WorkOrderNumber, 9, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = PurchaserequestMetadata.PropertyNames.WorkOrderNumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaserequestMetadata.ColumnNames.WorkOrderItemNumber, 10, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = PurchaserequestMetadata.PropertyNames.WorkOrderItemNumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaserequestMetadata.ColumnNames.DateReceived, 11, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = PurchaserequestMetadata.PropertyNames.DateReceived
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaserequestMetadata.ColumnNames.ReceiverItemNumber, 12, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = PurchaserequestMetadata.PropertyNames.ReceiverItemNumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaserequestMetadata.ColumnNames.ProdOrderNum, 13, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = PurchaserequestMetadata.PropertyNames.ProdOrderNum
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaserequestMetadata.ColumnNames.Createdby, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = PurchaserequestMetadata.PropertyNames.Createdby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaserequestMetadata.ColumnNames.Createdtime, 15, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = PurchaserequestMetadata.PropertyNames.Createdtime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaserequestMetadata.ColumnNames.Modifyby, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = PurchaserequestMetadata.PropertyNames.Modifyby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaserequestMetadata.ColumnNames.Modifytime, 17, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = PurchaserequestMetadata.PropertyNames.Modifytime
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As PurchaserequestMetadata
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
			 Public Const PONumber As String = "PONumber"
			 Public Const IsOrdered As String = "IsOrdered"
			 Public Const CustID As String = "CustID"
			 Public Const VendorID As String = "VendorID"
			 Public Const WorkOrderNumber As String = "WorkOrderNumber"
			 Public Const WorkOrderItemNumber As String = "WorkOrderItemNumber"
			 Public Const DateReceived As String = "DateReceived"
			 Public Const ReceiverItemNumber As String = "ReceiverItemNumber"
			 Public Const ProdOrderNum As String = "ProdOrderNum"
			 Public Const Createdby As String = "CREATEDBY"
			 Public Const Createdtime As String = "CREATEDTIME"
			 Public Const Modifyby As String = "MODIFYBY"
			 Public Const Modifytime As String = "MODIFYTIME"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const PurchReqID As String = "PurchReqID"
			 Public Const PurchReqDate As String = "PurchReqDate"
			 Public Const ProductID As String = "ProductID"
			 Public Const QtyContainers As String = "QtyContainers"
			 Public Const DateNeeded As String = "DateNeeded"
			 Public Const PONumber As String = "PONumber"
			 Public Const IsOrdered As String = "IsOrdered"
			 Public Const CustID As String = "CustID"
			 Public Const VendorID As String = "VendorID"
			 Public Const WorkOrderNumber As String = "WorkOrderNumber"
			 Public Const WorkOrderItemNumber As String = "WorkOrderItemNumber"
			 Public Const DateReceived As String = "DateReceived"
			 Public Const ReceiverItemNumber As String = "ReceiverItemNumber"
			 Public Const ProdOrderNum As String = "ProdOrderNum"
			 Public Const Createdby As String = "Createdby"
			 Public Const Createdtime As String = "Createdtime"
			 Public Const Modifyby As String = "Modifyby"
			 Public Const Modifytime As String = "Modifytime"
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
            SyncLock GetType(PurchaserequestMetadata)
			
				If PurchaserequestMetadata.mapDelegates Is Nothing Then
					PurchaserequestMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If PurchaserequestMetadata._meta Is Nothing Then
                    PurchaserequestMetadata._meta = New PurchaserequestMetadata()
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
				meta.AddTypeMap("PONumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("IsOrdered", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("CustID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("VendorID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("WorkOrderNumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("WorkOrderItemNumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("DateReceived", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("ReceiverItemNumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ProdOrderNum", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Createdby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Createdtime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Modifyby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Modifytime", new esTypeMap("datetime", "System.DateTime"))			
				
				
				 
				meta.Source = "PURCHASEREQUEST"
				meta.Destination = "PURCHASEREQUEST"
				
				meta.spInsert = "proc_PURCHASEREQUESTInsert"
				meta.spUpdate = "proc_PURCHASEREQUESTUpdate"
				meta.spDelete = "proc_PURCHASEREQUESTDelete"
				meta.spLoadAll = "proc_PURCHASEREQUESTLoadAll"
				meta.spLoadByPrimaryKey = "proc_PURCHASEREQUESTLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As PurchaserequestMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
