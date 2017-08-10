'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 5/11/2015 3:42:13 PM
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
	MustInherit Public Class esViewPurchaseOrderListCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewPurchaseOrderListCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewPurchaseOrderListQuery)
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
            Me.InitQuery(CType(query, esViewPurchaseOrderListQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewPurchaseOrderList) As ViewPurchaseOrderList
			Return CType(MyBase.DetachEntity(entity), ViewPurchaseOrderList)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewPurchaseOrderList) As ViewPurchaseOrderList
			Return CType(MyBase.AttachEntity(entity), ViewPurchaseOrderList)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewPurchaseOrderListCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewPurchaseOrderList
            Get
                Return TryCast(MyBase.Item(index), ViewPurchaseOrderList)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewPurchaseOrderList)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewPurchaseOrderList	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewPurchaseOrderListQuery
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
												
						Case "Purchasenumber"
							Me.str.Purchasenumber = CType(value, string)
												
						Case "Vendorid"
							Me.str.Vendorid = CType(value, string)
												
						Case "Vendorname"
							Me.str.Vendorname = CType(value, string)
												
						Case "Purchasedate"
							Me.str.Purchasedate = CType(value, string)
												
						Case "Purchasetype"
							Me.str.Purchasetype = CType(value, string)
												
						Case "Terms"
							Me.str.Terms = CType(value, string)
												
						Case "Purchasestatus"
							Me.str.Purchasestatus = CType(value, string)
												
						Case "Customerpo"
							Me.str.Customerpo = CType(value, string)
												
						Case "Shipname"
							Me.str.Shipname = CType(value, string)
												
						Case "Shipaddress1"
							Me.str.Shipaddress1 = CType(value, string)
												
						Case "Shipaddress2"
							Me.str.Shipaddress2 = CType(value, string)
												
						Case "Shipcity"
							Me.str.Shipcity = CType(value, string)
												
						Case "Shipstate"
							Me.str.Shipstate = CType(value, string)
												
						Case "Shipzip"
							Me.str.Shipzip = CType(value, string)
												
						Case "Shipcontact"
							Me.str.Shipcontact = CType(value, string)
												
						Case "Shipphone"
							Me.str.Shipphone = CType(value, string)
												
						Case "Subtotal"
							Me.str.Subtotal = CType(value, string)
												
						Case "Salestax"
							Me.str.Salestax = CType(value, string)
												
						Case "Freightin"
							Me.str.Freightin = CType(value, string)
												
						Case "Total"
							Me.str.Total = CType(value, string)
												
						Case "Instructions"
							Me.str.Instructions = CType(value, string)
												
						Case "Custid"
							Me.str.Custid = CType(value, string)
												
						Case "Expectedindate"
							Me.str.Expectedindate = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Purchasenumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Purchasenumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Vendorid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Vendorid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Purchasedate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Purchasedate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Subtotal"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Subtotal = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Salestax"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Salestax = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Freightin"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Freightin = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Total"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Total = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Custid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Custid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Expectedindate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Expectedindate = CType(value, Nullable(Of System.DateTime))
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
		' Maps to viewPurchaseOrderList.PURCHASENUMBER
		' </summary>
		Public Overridable Property Purchasenumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewPurchaseOrderListMetadata.ColumnNames.Purchasenumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewPurchaseOrderListMetadata.ColumnNames.Purchasenumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseOrderList.VENDORID
		' </summary>
		Public Overridable Property Vendorid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewPurchaseOrderListMetadata.ColumnNames.Vendorid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewPurchaseOrderListMetadata.ColumnNames.Vendorid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseOrderList.VENDORNAME
		' </summary>
		Public Overridable Property Vendorname As System.String
			Get
				Return MyBase.GetSystemString(ViewPurchaseOrderListMetadata.ColumnNames.Vendorname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPurchaseOrderListMetadata.ColumnNames.Vendorname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseOrderList.PURCHASEDATE
		' </summary>
		Public Overridable Property Purchasedate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewPurchaseOrderListMetadata.ColumnNames.Purchasedate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewPurchaseOrderListMetadata.ColumnNames.Purchasedate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseOrderList.PURCHASETYPE
		' </summary>
		Public Overridable Property Purchasetype As System.String
			Get
				Return MyBase.GetSystemString(ViewPurchaseOrderListMetadata.ColumnNames.Purchasetype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPurchaseOrderListMetadata.ColumnNames.Purchasetype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseOrderList.TERMS
		' </summary>
		Public Overridable Property Terms As System.String
			Get
				Return MyBase.GetSystemString(ViewPurchaseOrderListMetadata.ColumnNames.Terms)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPurchaseOrderListMetadata.ColumnNames.Terms, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseOrderList.PURCHASESTATUS
		' </summary>
		Public Overridable Property Purchasestatus As System.String
			Get
				Return MyBase.GetSystemString(ViewPurchaseOrderListMetadata.ColumnNames.Purchasestatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPurchaseOrderListMetadata.ColumnNames.Purchasestatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseOrderList.CUSTOMERPO
		' </summary>
		Public Overridable Property Customerpo As System.String
			Get
				Return MyBase.GetSystemString(ViewPurchaseOrderListMetadata.ColumnNames.Customerpo)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPurchaseOrderListMetadata.ColumnNames.Customerpo, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseOrderList.SHIPNAME
		' </summary>
		Public Overridable Property Shipname As System.String
			Get
				Return MyBase.GetSystemString(ViewPurchaseOrderListMetadata.ColumnNames.Shipname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPurchaseOrderListMetadata.ColumnNames.Shipname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseOrderList.SHIPADDRESS1
		' </summary>
		Public Overridable Property Shipaddress1 As System.String
			Get
				Return MyBase.GetSystemString(ViewPurchaseOrderListMetadata.ColumnNames.Shipaddress1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPurchaseOrderListMetadata.ColumnNames.Shipaddress1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseOrderList.SHIPADDRESS2
		' </summary>
		Public Overridable Property Shipaddress2 As System.String
			Get
				Return MyBase.GetSystemString(ViewPurchaseOrderListMetadata.ColumnNames.Shipaddress2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPurchaseOrderListMetadata.ColumnNames.Shipaddress2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseOrderList.SHIPCITY
		' </summary>
		Public Overridable Property Shipcity As System.String
			Get
				Return MyBase.GetSystemString(ViewPurchaseOrderListMetadata.ColumnNames.Shipcity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPurchaseOrderListMetadata.ColumnNames.Shipcity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseOrderList.SHIPSTATE
		' </summary>
		Public Overridable Property Shipstate As System.String
			Get
				Return MyBase.GetSystemString(ViewPurchaseOrderListMetadata.ColumnNames.Shipstate)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPurchaseOrderListMetadata.ColumnNames.Shipstate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseOrderList.SHIPZIP
		' </summary>
		Public Overridable Property Shipzip As System.String
			Get
				Return MyBase.GetSystemString(ViewPurchaseOrderListMetadata.ColumnNames.Shipzip)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPurchaseOrderListMetadata.ColumnNames.Shipzip, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseOrderList.SHIPCONTACT
		' </summary>
		Public Overridable Property Shipcontact As System.String
			Get
				Return MyBase.GetSystemString(ViewPurchaseOrderListMetadata.ColumnNames.Shipcontact)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPurchaseOrderListMetadata.ColumnNames.Shipcontact, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseOrderList.SHIPPHONE
		' </summary>
		Public Overridable Property Shipphone As System.String
			Get
				Return MyBase.GetSystemString(ViewPurchaseOrderListMetadata.ColumnNames.Shipphone)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPurchaseOrderListMetadata.ColumnNames.Shipphone, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseOrderList.SUBTOTAL
		' </summary>
		Public Overridable Property Subtotal As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewPurchaseOrderListMetadata.ColumnNames.Subtotal)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewPurchaseOrderListMetadata.ColumnNames.Subtotal, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseOrderList.SALESTAX
		' </summary>
		Public Overridable Property Salestax As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewPurchaseOrderListMetadata.ColumnNames.Salestax)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewPurchaseOrderListMetadata.ColumnNames.Salestax, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseOrderList.FREIGHTIN
		' </summary>
		Public Overridable Property Freightin As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewPurchaseOrderListMetadata.ColumnNames.Freightin)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewPurchaseOrderListMetadata.ColumnNames.Freightin, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseOrderList.TOTAL
		' </summary>
		Public Overridable Property Total As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewPurchaseOrderListMetadata.ColumnNames.Total)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewPurchaseOrderListMetadata.ColumnNames.Total, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseOrderList.INSTRUCTIONS
		' </summary>
		Public Overridable Property Instructions As System.String
			Get
				Return MyBase.GetSystemString(ViewPurchaseOrderListMetadata.ColumnNames.Instructions)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPurchaseOrderListMetadata.ColumnNames.Instructions, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseOrderList.CUSTID
		' </summary>
		Public Overridable Property Custid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewPurchaseOrderListMetadata.ColumnNames.Custid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewPurchaseOrderListMetadata.ColumnNames.Custid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseOrderList.EXPECTEDINDATE
		' </summary>
		Public Overridable Property Expectedindate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewPurchaseOrderListMetadata.ColumnNames.Expectedindate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewPurchaseOrderListMetadata.ColumnNames.Expectedindate, value)
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
		
			Public Sub New(ByVal entity As esViewPurchaseOrderList)
				Me.entity = entity
			End Sub				
		
	
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
		  	
			Public Property Vendorid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Vendorid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Vendorid = Nothing
					Else
						entity.Vendorid = Convert.ToInt32(Value)
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
		  	
			Public Property Purchasetype As System.String 
				Get
					Dim data_ As System.String = entity.Purchasetype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Purchasetype = Nothing
					Else
						entity.Purchasetype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Terms As System.String 
				Get
					Dim data_ As System.String = entity.Terms
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Terms = Nothing
					Else
						entity.Terms = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Purchasestatus As System.String 
				Get
					Dim data_ As System.String = entity.Purchasestatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Purchasestatus = Nothing
					Else
						entity.Purchasestatus = Convert.ToString(Value)
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
		  	
			Public Property Shipname As System.String 
				Get
					Dim data_ As System.String = entity.Shipname
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipname = Nothing
					Else
						entity.Shipname = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shipaddress1 As System.String 
				Get
					Dim data_ As System.String = entity.Shipaddress1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipaddress1 = Nothing
					Else
						entity.Shipaddress1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shipaddress2 As System.String 
				Get
					Dim data_ As System.String = entity.Shipaddress2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipaddress2 = Nothing
					Else
						entity.Shipaddress2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shipcity As System.String 
				Get
					Dim data_ As System.String = entity.Shipcity
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipcity = Nothing
					Else
						entity.Shipcity = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shipstate As System.String 
				Get
					Dim data_ As System.String = entity.Shipstate
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipstate = Nothing
					Else
						entity.Shipstate = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shipzip As System.String 
				Get
					Dim data_ As System.String = entity.Shipzip
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipzip = Nothing
					Else
						entity.Shipzip = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shipcontact As System.String 
				Get
					Dim data_ As System.String = entity.Shipcontact
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipcontact = Nothing
					Else
						entity.Shipcontact = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shipphone As System.String 
				Get
					Dim data_ As System.String = entity.Shipphone
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipphone = Nothing
					Else
						entity.Shipphone = Convert.ToString(Value)
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
		  	
			Public Property Salestax As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Salestax
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Salestax = Nothing
					Else
						entity.Salestax = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Freightin As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Freightin
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Freightin = Nothing
					Else
						entity.Freightin = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Total As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Total
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Total = Nothing
					Else
						entity.Total = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Instructions As System.String 
				Get
					Dim data_ As System.String = entity.Instructions
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Instructions = Nothing
					Else
						entity.Instructions = Convert.ToString(Value)
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
		  	
			Public Property Expectedindate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Expectedindate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Expectedindate = Nothing
					Else
						entity.Expectedindate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewPurchaseOrderList
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewPurchaseOrderListQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewPurchaseOrderList can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewPurchaseOrderListQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewPurchaseOrderListMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Purchasenumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseOrderListMetadata.ColumnNames.Purchasenumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Vendorid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseOrderListMetadata.ColumnNames.Vendorid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Vendorname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseOrderListMetadata.ColumnNames.Vendorname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Purchasedate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseOrderListMetadata.ColumnNames.Purchasedate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Purchasetype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseOrderListMetadata.ColumnNames.Purchasetype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Terms As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseOrderListMetadata.ColumnNames.Terms, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Purchasestatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseOrderListMetadata.ColumnNames.Purchasestatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Customerpo As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseOrderListMetadata.ColumnNames.Customerpo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseOrderListMetadata.ColumnNames.Shipname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipaddress1 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseOrderListMetadata.ColumnNames.Shipaddress1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipaddress2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseOrderListMetadata.ColumnNames.Shipaddress2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipcity As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseOrderListMetadata.ColumnNames.Shipcity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipstate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseOrderListMetadata.ColumnNames.Shipstate, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipzip As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseOrderListMetadata.ColumnNames.Shipzip, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipcontact As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseOrderListMetadata.ColumnNames.Shipcontact, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipphone As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseOrderListMetadata.ColumnNames.Shipphone, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Subtotal As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseOrderListMetadata.ColumnNames.Subtotal, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Salestax As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseOrderListMetadata.ColumnNames.Salestax, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Freightin As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseOrderListMetadata.ColumnNames.Freightin, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Total As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseOrderListMetadata.ColumnNames.Total, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Instructions As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseOrderListMetadata.ColumnNames.Instructions, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Custid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseOrderListMetadata.ColumnNames.Custid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Expectedindate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseOrderListMetadata.ColumnNames.Expectedindate, esSystemType.DateTime)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewPurchaseOrderListCollection")> _
	Partial Public Class ViewPurchaseOrderListCollection
		Inherits esViewPurchaseOrderListCollection
		Implements IEnumerable(Of ViewPurchaseOrderList)
		
        Public Shared Widening Operator CType(ByVal coll As ViewPurchaseOrderListCollection) As List(Of ViewPurchaseOrderList)
            Dim list As List(Of ViewPurchaseOrderList) = New List(Of ViewPurchaseOrderList)
            Dim emp As ViewPurchaseOrderList

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewPurchaseOrderListMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewPurchaseOrderListQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewPurchaseOrderList(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewPurchaseOrderList()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewPurchaseOrderListQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewPurchaseOrderListQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewPurchaseOrderListQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewPurchaseOrderList 
			Return CType(MyBase.AddNewEntity(), ViewPurchaseOrderList)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewPurchaseOrderList) Implements IEnumerable(Of ViewPurchaseOrderList).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewPurchaseOrderList)(Me)
        End Function
		
		Private _query As ViewPurchaseOrderListQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewPurchaseOrderList' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewPurchaseOrderList ()")> _
	<Serializable> _
	Partial Public Class ViewPurchaseOrderList 
		Inherits esViewPurchaseOrderList

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewPurchaseOrderListMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewPurchaseOrderListQuery

			If Me._query Is Nothing Then
				Me._query = New ViewPurchaseOrderListQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewPurchaseOrderListQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewPurchaseOrderListQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewPurchaseOrderListQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewPurchaseOrderListQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewPurchaseOrderListQuery
		inherits esViewPurchaseOrderListQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewPurchaseOrderListQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewPurchaseOrderListMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewPurchaseOrderListMetadata.ColumnNames.Purchasenumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewPurchaseOrderListMetadata.PropertyNames.Purchasenumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseOrderListMetadata.ColumnNames.Vendorid, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewPurchaseOrderListMetadata.PropertyNames.Vendorid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseOrderListMetadata.ColumnNames.Vendorname, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPurchaseOrderListMetadata.PropertyNames.Vendorname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseOrderListMetadata.ColumnNames.Purchasedate, 3, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewPurchaseOrderListMetadata.PropertyNames.Purchasedate
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseOrderListMetadata.ColumnNames.Purchasetype, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPurchaseOrderListMetadata.PropertyNames.Purchasetype
			c.CharacterMaxLength = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseOrderListMetadata.ColumnNames.Terms, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPurchaseOrderListMetadata.PropertyNames.Terms
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseOrderListMetadata.ColumnNames.Purchasestatus, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPurchaseOrderListMetadata.PropertyNames.Purchasestatus
			c.CharacterMaxLength = 50
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseOrderListMetadata.ColumnNames.Customerpo, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPurchaseOrderListMetadata.PropertyNames.Customerpo
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseOrderListMetadata.ColumnNames.Shipname, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPurchaseOrderListMetadata.PropertyNames.Shipname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseOrderListMetadata.ColumnNames.Shipaddress1, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPurchaseOrderListMetadata.PropertyNames.Shipaddress1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseOrderListMetadata.ColumnNames.Shipaddress2, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPurchaseOrderListMetadata.PropertyNames.Shipaddress2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseOrderListMetadata.ColumnNames.Shipcity, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPurchaseOrderListMetadata.PropertyNames.Shipcity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseOrderListMetadata.ColumnNames.Shipstate, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPurchaseOrderListMetadata.PropertyNames.Shipstate
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseOrderListMetadata.ColumnNames.Shipzip, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPurchaseOrderListMetadata.PropertyNames.Shipzip
			c.CharacterMaxLength = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseOrderListMetadata.ColumnNames.Shipcontact, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPurchaseOrderListMetadata.PropertyNames.Shipcontact
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseOrderListMetadata.ColumnNames.Shipphone, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPurchaseOrderListMetadata.PropertyNames.Shipphone
			c.CharacterMaxLength = 20
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseOrderListMetadata.ColumnNames.Subtotal, 16, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewPurchaseOrderListMetadata.PropertyNames.Subtotal
			c.NumericPrecision = 18
			c.NumericScale = 4
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseOrderListMetadata.ColumnNames.Salestax, 17, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewPurchaseOrderListMetadata.PropertyNames.Salestax
			c.NumericPrecision = 18
			c.NumericScale = 4
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseOrderListMetadata.ColumnNames.Freightin, 18, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewPurchaseOrderListMetadata.PropertyNames.Freightin
			c.NumericPrecision = 18
			c.NumericScale = 4
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseOrderListMetadata.ColumnNames.Total, 19, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewPurchaseOrderListMetadata.PropertyNames.Total
			c.NumericPrecision = 18
			c.NumericScale = 4
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseOrderListMetadata.ColumnNames.Instructions, 20, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPurchaseOrderListMetadata.PropertyNames.Instructions
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseOrderListMetadata.ColumnNames.Custid, 21, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewPurchaseOrderListMetadata.PropertyNames.Custid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseOrderListMetadata.ColumnNames.Expectedindate, 22, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewPurchaseOrderListMetadata.PropertyNames.Expectedindate
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewPurchaseOrderListMetadata
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
			 Public Const Purchasenumber As String = "PURCHASENUMBER"
			 Public Const Vendorid As String = "VENDORID"
			 Public Const Vendorname As String = "VENDORNAME"
			 Public Const Purchasedate As String = "PURCHASEDATE"
			 Public Const Purchasetype As String = "PURCHASETYPE"
			 Public Const Terms As String = "TERMS"
			 Public Const Purchasestatus As String = "PURCHASESTATUS"
			 Public Const Customerpo As String = "CUSTOMERPO"
			 Public Const Shipname As String = "SHIPNAME"
			 Public Const Shipaddress1 As String = "SHIPADDRESS1"
			 Public Const Shipaddress2 As String = "SHIPADDRESS2"
			 Public Const Shipcity As String = "SHIPCITY"
			 Public Const Shipstate As String = "SHIPSTATE"
			 Public Const Shipzip As String = "SHIPZIP"
			 Public Const Shipcontact As String = "SHIPCONTACT"
			 Public Const Shipphone As String = "SHIPPHONE"
			 Public Const Subtotal As String = "SUBTOTAL"
			 Public Const Salestax As String = "SALESTAX"
			 Public Const Freightin As String = "FREIGHTIN"
			 Public Const Total As String = "TOTAL"
			 Public Const Instructions As String = "INSTRUCTIONS"
			 Public Const Custid As String = "CUSTID"
			 Public Const Expectedindate As String = "EXPECTEDINDATE"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Purchasenumber As String = "Purchasenumber"
			 Public Const Vendorid As String = "Vendorid"
			 Public Const Vendorname As String = "Vendorname"
			 Public Const Purchasedate As String = "Purchasedate"
			 Public Const Purchasetype As String = "Purchasetype"
			 Public Const Terms As String = "Terms"
			 Public Const Purchasestatus As String = "Purchasestatus"
			 Public Const Customerpo As String = "Customerpo"
			 Public Const Shipname As String = "Shipname"
			 Public Const Shipaddress1 As String = "Shipaddress1"
			 Public Const Shipaddress2 As String = "Shipaddress2"
			 Public Const Shipcity As String = "Shipcity"
			 Public Const Shipstate As String = "Shipstate"
			 Public Const Shipzip As String = "Shipzip"
			 Public Const Shipcontact As String = "Shipcontact"
			 Public Const Shipphone As String = "Shipphone"
			 Public Const Subtotal As String = "Subtotal"
			 Public Const Salestax As String = "Salestax"
			 Public Const Freightin As String = "Freightin"
			 Public Const Total As String = "Total"
			 Public Const Instructions As String = "Instructions"
			 Public Const Custid As String = "Custid"
			 Public Const Expectedindate As String = "Expectedindate"
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
            SyncLock GetType(ViewPurchaseOrderListMetadata)
			
				If ViewPurchaseOrderListMetadata.mapDelegates Is Nothing Then
					ViewPurchaseOrderListMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewPurchaseOrderListMetadata._meta Is Nothing Then
                    ViewPurchaseOrderListMetadata._meta = New ViewPurchaseOrderListMetadata()
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
				

				meta.AddTypeMap("Purchasenumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Vendorid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Vendorname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Purchasedate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Purchasetype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Terms", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Purchasestatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Customerpo", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipaddress1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipaddress2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipcity", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipstate", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipzip", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipcontact", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shipphone", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Subtotal", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Salestax", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Freightin", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Total", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Instructions", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Custid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Expectedindate", new esTypeMap("datetime", "System.DateTime"))			
				
				
				 
				meta.Source = "viewPurchaseOrderList"
				meta.Destination = "viewPurchaseOrderList"
				
				meta.spInsert = "proc_viewPurchaseOrderListInsert"
				meta.spUpdate = "proc_viewPurchaseOrderListUpdate"
				meta.spDelete = "proc_viewPurchaseOrderListDelete"
				meta.spLoadAll = "proc_viewPurchaseOrderListLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewPurchaseOrderListLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewPurchaseOrderListMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
