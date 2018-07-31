'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 10/14/2016 12:29:58 PM
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
	MustInherit Public Class esViewCommissionAuditCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewCommissionAuditCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewCommissionAuditQuery)
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
            Me.InitQuery(CType(query, esViewCommissionAuditQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewCommissionAudit) As ViewCommissionAudit
			Return CType(MyBase.DetachEntity(entity), ViewCommissionAudit)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewCommissionAudit) As ViewCommissionAudit
			Return CType(MyBase.AttachEntity(entity), ViewCommissionAudit)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewCommissionAuditCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewCommissionAudit
            Get
                Return TryCast(MyBase.Item(index), ViewCommissionAudit)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewCommissionAudit)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewCommissionAudit	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewCommissionAuditQuery
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
												
						Case "Invoicenumber"
							Me.str.Invoicenumber = CType(value, string)
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Productdesc"
							Me.str.Productdesc = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "Quantity"
							Me.str.Quantity = CType(value, string)
												
						Case "Itemprice"
							Me.str.Itemprice = CType(value, string)
												
						Case "Units"
							Me.str.Units = CType(value, string)
												
						Case "Extprice"
							Me.str.Extprice = CType(value, string)
												
						Case "Extcost"
							Me.str.Extcost = CType(value, string)
												
						Case "Grossprofit"
							Me.str.Grossprofit = CType(value, string)
												
						Case "CustID"
							Me.str.CustID = CType(value, string)
												
						Case "SalespersonID"
							Me.str.SalespersonID = CType(value, string)
												
						Case "Salespersonfullname"
							Me.str.Salespersonfullname = CType(value, string)
												
						Case "CommissionRate"
							Me.str.CommissionRate = CType(value, string)
												
						Case "ExcRate"
							Me.str.ExcRate = CType(value, string)
												
						Case "CommRate"
							Me.str.CommRate = CType(value, string)
												
						Case "CommissionType"
							Me.str.CommissionType = CType(value, string)
												
						Case "CommissionAmt"
							Me.str.CommissionAmt = CType(value, string)
												
						Case "Invoiceitemnumber"
							Me.str.Invoiceitemnumber = CType(value, string)
												
						Case "Workorderitemnumber"
							Me.str.Workorderitemnumber = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Invoicenumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Invoicenumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Quantity"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Quantity = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Itemprice"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Itemprice = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Units"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Units = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Extprice"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Extprice = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Extcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Extcost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Grossprofit"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Grossprofit = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "CustID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.CustID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "SalespersonID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.SalespersonID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "CommissionRate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.CommissionRate = CType(value, Nullable(Of System.Double))
							End If
						
						Case "ExcRate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.ExcRate = CType(value, Nullable(Of System.Double))
							End If
						
						Case "CommRate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.CommRate = CType(value, Nullable(Of System.Double))
							End If
						
						Case "CommissionAmt"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.CommissionAmt = CType(value, Nullable(Of System.Double))
							End If
						
						Case "Invoiceitemnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Invoiceitemnumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Workorderitemnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Workorderitemnumber = CType(value, Nullable(Of System.Int32))
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
		' Maps to viewCommissionAudit.INVOICENUMBER
		' </summary>
		Public Overridable Property Invoicenumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCommissionAuditMetadata.ColumnNames.Invoicenumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCommissionAuditMetadata.ColumnNames.Invoicenumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAudit.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCommissionAuditMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCommissionAuditMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAudit.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewCommissionAuditMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCommissionAuditMetadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAudit.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewCommissionAuditMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCommissionAuditMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAudit.QUANTITY
		' </summary>
		Public Overridable Property Quantity As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCommissionAuditMetadata.ColumnNames.Quantity)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCommissionAuditMetadata.ColumnNames.Quantity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAudit.ITEMPRICE
		' </summary>
		Public Overridable Property Itemprice As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCommissionAuditMetadata.ColumnNames.Itemprice)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCommissionAuditMetadata.ColumnNames.Itemprice, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAudit.UNITS
		' </summary>
		Public Overridable Property Units As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCommissionAuditMetadata.ColumnNames.Units)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCommissionAuditMetadata.ColumnNames.Units, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAudit.EXTPRICE
		' </summary>
		Public Overridable Property Extprice As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCommissionAuditMetadata.ColumnNames.Extprice)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCommissionAuditMetadata.ColumnNames.Extprice, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAudit.EXTCOST
		' </summary>
		Public Overridable Property Extcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCommissionAuditMetadata.ColumnNames.Extcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCommissionAuditMetadata.ColumnNames.Extcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAudit.GROSSPROFIT
		' </summary>
		Public Overridable Property Grossprofit As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewCommissionAuditMetadata.ColumnNames.Grossprofit)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewCommissionAuditMetadata.ColumnNames.Grossprofit, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAudit.CustID
		' </summary>
		Public Overridable Property CustID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCommissionAuditMetadata.ColumnNames.CustID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCommissionAuditMetadata.ColumnNames.CustID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAudit.SalespersonID
		' </summary>
		Public Overridable Property SalespersonID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCommissionAuditMetadata.ColumnNames.SalespersonID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCommissionAuditMetadata.ColumnNames.SalespersonID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAudit.SALESPERSONFULLNAME
		' </summary>
		Public Overridable Property Salespersonfullname As System.String
			Get
				Return MyBase.GetSystemString(ViewCommissionAuditMetadata.ColumnNames.Salespersonfullname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCommissionAuditMetadata.ColumnNames.Salespersonfullname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAudit.CommissionRate
		' </summary>
		Public Overridable Property CommissionRate As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCommissionAuditMetadata.ColumnNames.CommissionRate)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewCommissionAuditMetadata.ColumnNames.CommissionRate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAudit.ExcRate
		' </summary>
		Public Overridable Property ExcRate As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCommissionAuditMetadata.ColumnNames.ExcRate)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewCommissionAuditMetadata.ColumnNames.ExcRate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAudit.CommRate
		' </summary>
		Public Overridable Property CommRate As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCommissionAuditMetadata.ColumnNames.CommRate)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewCommissionAuditMetadata.ColumnNames.CommRate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAudit.CommissionType
		' </summary>
		Public Overridable Property CommissionType As System.String
			Get
				Return MyBase.GetSystemString(ViewCommissionAuditMetadata.ColumnNames.CommissionType)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCommissionAuditMetadata.ColumnNames.CommissionType, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAudit.CommissionAmt
		' </summary>
		Public Overridable Property CommissionAmt As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewCommissionAuditMetadata.ColumnNames.CommissionAmt)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewCommissionAuditMetadata.ColumnNames.CommissionAmt, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAudit.INVOICEITEMNUMBER
		' </summary>
		Public Overridable Property Invoiceitemnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCommissionAuditMetadata.ColumnNames.Invoiceitemnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCommissionAuditMetadata.ColumnNames.Invoiceitemnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCommissionAudit.WORKORDERITEMNUMBER
		' </summary>
		Public Overridable Property Workorderitemnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCommissionAuditMetadata.ColumnNames.Workorderitemnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCommissionAuditMetadata.ColumnNames.Workorderitemnumber, value)
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
		
			Public Sub New(ByVal entity As esViewCommissionAudit)
				Me.entity = entity
			End Sub				
		
	
			Public Property Invoicenumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Invoicenumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Invoicenumber = Nothing
					Else
						entity.Invoicenumber = Convert.ToInt32(Value)
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
		  	
			Public Property Quantity As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Quantity
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Quantity = Nothing
					Else
						entity.Quantity = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Itemprice As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Itemprice
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Itemprice = Nothing
					Else
						entity.Itemprice = Convert.ToDecimal(Value)
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
		  	
			Public Property Extcost As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Extcost
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Extcost = Nothing
					Else
						entity.Extcost = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Grossprofit As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Grossprofit
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Grossprofit = Nothing
					Else
						entity.Grossprofit = Convert.ToDecimal(Value)
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
		  	
			Public Property SalespersonID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.SalespersonID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SalespersonID = Nothing
					Else
						entity.SalespersonID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Salespersonfullname As System.String 
				Get
					Dim data_ As System.String = entity.Salespersonfullname
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Salespersonfullname = Nothing
					Else
						entity.Salespersonfullname = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CommissionRate As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.CommissionRate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CommissionRate = Nothing
					Else
						entity.CommissionRate = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property ExcRate As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.ExcRate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ExcRate = Nothing
					Else
						entity.ExcRate = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property CommRate As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.CommRate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CommRate = Nothing
					Else
						entity.CommRate = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property CommissionType As System.String 
				Get
					Dim data_ As System.String = entity.CommissionType
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CommissionType = Nothing
					Else
						entity.CommissionType = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CommissionAmt As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.CommissionAmt
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CommissionAmt = Nothing
					Else
						entity.CommissionAmt = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property Invoiceitemnumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Invoiceitemnumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Invoiceitemnumber = Nothing
					Else
						entity.Invoiceitemnumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Workorderitemnumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Workorderitemnumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Workorderitemnumber = Nothing
					Else
						entity.Workorderitemnumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewCommissionAudit
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewCommissionAuditQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewCommissionAudit can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewCommissionAuditQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCommissionAuditMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Invoicenumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditMetadata.ColumnNames.Invoicenumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Quantity As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditMetadata.ColumnNames.Quantity, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Itemprice As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditMetadata.ColumnNames.Itemprice, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Units As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditMetadata.ColumnNames.Units, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Extprice As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditMetadata.ColumnNames.Extprice, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Extcost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditMetadata.ColumnNames.Extcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Grossprofit As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditMetadata.ColumnNames.Grossprofit, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property CustID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditMetadata.ColumnNames.CustID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property SalespersonID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditMetadata.ColumnNames.SalespersonID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Salespersonfullname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditMetadata.ColumnNames.Salespersonfullname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CommissionRate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditMetadata.ColumnNames.CommissionRate, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property ExcRate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditMetadata.ColumnNames.ExcRate, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property CommRate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditMetadata.ColumnNames.CommRate, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property CommissionType As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditMetadata.ColumnNames.CommissionType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CommissionAmt As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditMetadata.ColumnNames.CommissionAmt, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Invoiceitemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditMetadata.ColumnNames.Invoiceitemnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Workorderitemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCommissionAuditMetadata.ColumnNames.Workorderitemnumber, esSystemType.Int32)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewCommissionAuditCollection")> _
	Partial Public Class ViewCommissionAuditCollection
		Inherits esViewCommissionAuditCollection
		Implements IEnumerable(Of ViewCommissionAudit)
		
        Public Shared Widening Operator CType(ByVal coll As ViewCommissionAuditCollection) As List(Of ViewCommissionAudit)
            Dim list As List(Of ViewCommissionAudit) = New List(Of ViewCommissionAudit)
            Dim emp As ViewCommissionAudit

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCommissionAuditMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewCommissionAuditQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewCommissionAudit(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewCommissionAudit()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewCommissionAuditQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewCommissionAuditQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewCommissionAuditQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewCommissionAudit 
			Return CType(MyBase.AddNewEntity(), ViewCommissionAudit)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewCommissionAudit) Implements IEnumerable(Of ViewCommissionAudit).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewCommissionAudit)(Me)
        End Function
		
		Private _query As ViewCommissionAuditQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewCommissionAudit' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewCommissionAudit ()")> _
	<Serializable> _
	Partial Public Class ViewCommissionAudit 
		Inherits esViewCommissionAudit

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewCommissionAuditMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewCommissionAuditQuery

			If Me._query Is Nothing Then
				Me._query = New ViewCommissionAuditQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewCommissionAuditQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewCommissionAuditQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewCommissionAuditQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewCommissionAuditQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewCommissionAuditQuery
		inherits esViewCommissionAuditQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewCommissionAuditQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewCommissionAuditMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCommissionAuditMetadata.ColumnNames.Invoicenumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCommissionAuditMetadata.PropertyNames.Invoicenumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditMetadata.ColumnNames.Productid, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCommissionAuditMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditMetadata.ColumnNames.Productdesc, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCommissionAuditMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditMetadata.ColumnNames.Container, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCommissionAuditMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditMetadata.ColumnNames.Quantity, 4, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCommissionAuditMetadata.PropertyNames.Quantity
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditMetadata.ColumnNames.Itemprice, 5, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCommissionAuditMetadata.PropertyNames.Itemprice
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditMetadata.ColumnNames.Units, 6, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCommissionAuditMetadata.PropertyNames.Units
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditMetadata.ColumnNames.Extprice, 7, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCommissionAuditMetadata.PropertyNames.Extprice
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditMetadata.ColumnNames.Extcost, 8, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCommissionAuditMetadata.PropertyNames.Extcost
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditMetadata.ColumnNames.Grossprofit, 9, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewCommissionAuditMetadata.PropertyNames.Grossprofit
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditMetadata.ColumnNames.CustID, 10, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCommissionAuditMetadata.PropertyNames.CustID
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditMetadata.ColumnNames.SalespersonID, 11, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCommissionAuditMetadata.PropertyNames.SalespersonID
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditMetadata.ColumnNames.Salespersonfullname, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCommissionAuditMetadata.PropertyNames.Salespersonfullname
			c.CharacterMaxLength = 101
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditMetadata.ColumnNames.CommissionRate, 13, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCommissionAuditMetadata.PropertyNames.CommissionRate
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditMetadata.ColumnNames.ExcRate, 14, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCommissionAuditMetadata.PropertyNames.ExcRate
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditMetadata.ColumnNames.CommRate, 15, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCommissionAuditMetadata.PropertyNames.CommRate
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditMetadata.ColumnNames.CommissionType, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCommissionAuditMetadata.PropertyNames.CommissionType
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditMetadata.ColumnNames.CommissionAmt, 17, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewCommissionAuditMetadata.PropertyNames.CommissionAmt
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditMetadata.ColumnNames.Invoiceitemnumber, 18, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCommissionAuditMetadata.PropertyNames.Invoiceitemnumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCommissionAuditMetadata.ColumnNames.Workorderitemnumber, 19, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCommissionAuditMetadata.PropertyNames.Workorderitemnumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewCommissionAuditMetadata
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
			 Public Const Invoicenumber As String = "INVOICENUMBER"
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Productdesc As String = "PRODUCTDESC"
			 Public Const Container As String = "CONTAINER"
			 Public Const Quantity As String = "QUANTITY"
			 Public Const Itemprice As String = "ITEMPRICE"
			 Public Const Units As String = "UNITS"
			 Public Const Extprice As String = "EXTPRICE"
			 Public Const Extcost As String = "EXTCOST"
			 Public Const Grossprofit As String = "GROSSPROFIT"
			 Public Const CustID As String = "CustID"
			 Public Const SalespersonID As String = "SalespersonID"
			 Public Const Salespersonfullname As String = "SALESPERSONFULLNAME"
			 Public Const CommissionRate As String = "CommissionRate"
			 Public Const ExcRate As String = "ExcRate"
			 Public Const CommRate As String = "CommRate"
			 Public Const CommissionType As String = "CommissionType"
			 Public Const CommissionAmt As String = "CommissionAmt"
			 Public Const Invoiceitemnumber As String = "INVOICEITEMNUMBER"
			 Public Const Workorderitemnumber As String = "WORKORDERITEMNUMBER"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Invoicenumber As String = "Invoicenumber"
			 Public Const Productid As String = "Productid"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const Container As String = "Container"
			 Public Const Quantity As String = "Quantity"
			 Public Const Itemprice As String = "Itemprice"
			 Public Const Units As String = "Units"
			 Public Const Extprice As String = "Extprice"
			 Public Const Extcost As String = "Extcost"
			 Public Const Grossprofit As String = "Grossprofit"
			 Public Const CustID As String = "CustID"
			 Public Const SalespersonID As String = "SalespersonID"
			 Public Const Salespersonfullname As String = "Salespersonfullname"
			 Public Const CommissionRate As String = "CommissionRate"
			 Public Const ExcRate As String = "ExcRate"
			 Public Const CommRate As String = "CommRate"
			 Public Const CommissionType As String = "CommissionType"
			 Public Const CommissionAmt As String = "CommissionAmt"
			 Public Const Invoiceitemnumber As String = "Invoiceitemnumber"
			 Public Const Workorderitemnumber As String = "Workorderitemnumber"
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
            SyncLock GetType(ViewCommissionAuditMetadata)
			
				If ViewCommissionAuditMetadata.mapDelegates Is Nothing Then
					ViewCommissionAuditMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewCommissionAuditMetadata._meta Is Nothing Then
                    ViewCommissionAuditMetadata._meta = New ViewCommissionAuditMetadata()
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
				

				meta.AddTypeMap("Invoicenumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Quantity", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Itemprice", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Units", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Extprice", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Extcost", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Grossprofit", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("CustID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("SalespersonID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Salespersonfullname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CommissionRate", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("ExcRate", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("CommRate", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("CommissionType", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CommissionAmt", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Invoiceitemnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Workorderitemnumber", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "viewCommissionAudit"
				meta.Destination = "viewCommissionAudit"
				
				meta.spInsert = "proc_viewCommissionAuditInsert"
				meta.spUpdate = "proc_viewCommissionAuditUpdate"
				meta.spDelete = "proc_viewCommissionAuditDelete"
				meta.spLoadAll = "proc_viewCommissionAuditLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCommissionAuditLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewCommissionAuditMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
