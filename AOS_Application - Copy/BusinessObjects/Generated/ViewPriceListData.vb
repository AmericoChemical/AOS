'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 9/17/2015 2:01:55 PM
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
	MustInherit Public Class esViewPriceListDataCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewPriceListDataCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewPriceListDataQuery)
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
            Me.InitQuery(CType(query, esViewPriceListDataQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewPriceListData) As ViewPriceListData
			Return CType(MyBase.DetachEntity(entity), ViewPriceListData)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewPriceListData) As ViewPriceListData
			Return CType(MyBase.AttachEntity(entity), ViewPriceListData)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewPriceListDataCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewPriceListData
            Get
                Return TryCast(MyBase.Item(index), ViewPriceListData)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewPriceListData)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewPriceListData	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewPriceListDataQuery
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
												
						Case "Pricelistid"
							Me.str.Pricelistid = CType(value, string)
												
						Case "Custid"
							Me.str.Custid = CType(value, string)
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Units"
							Me.str.Units = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "Unitprice"
							Me.str.Unitprice = CType(value, string)
												
						Case "Uom"
							Me.str.Uom = CType(value, string)
												
						Case "Unitorcontainer"
							Me.str.Unitorcontainer = CType(value, string)
												
						Case "Effectivedate"
							Me.str.Effectivedate = CType(value, string)
												
						Case "Taxable"
							Me.str.Taxable = CType(value, string)
												
						Case "Containerprice"
							Me.str.Containerprice = CType(value, string)
												
						Case "Customerproductcode"
							Me.str.Customerproductcode = CType(value, string)
												
						Case "Weightuom"
							Me.str.Weightuom = CType(value, string)
												
						Case "Weightunits"
							Me.str.Weightunits = CType(value, string)
												
						Case "Weightprice"
							Me.str.Weightprice = CType(value, string)
												
						Case "Volumeuom"
							Me.str.Volumeuom = CType(value, string)
												
						Case "Volumeunits"
							Me.str.Volumeunits = CType(value, string)
												
						Case "Volumeprice"
							Me.str.Volumeprice = CType(value, string)
												
						Case "Pricingmethod"
							Me.str.Pricingmethod = CType(value, string)
												
						Case "Priceliststatus"
							Me.str.Priceliststatus = CType(value, string)
												
						Case "Productdesc"
							Me.str.Productdesc = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Pricelistid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Pricelistid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Custid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Custid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Units"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Units = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Unitprice"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Unitprice = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Effectivedate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Effectivedate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Taxable"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Taxable = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Containerprice"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Containerprice = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Weightunits"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Weightunits = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Weightprice"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Weightprice = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Volumeunits"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Volumeunits = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Volumeprice"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Volumeprice = CType(value, Nullable(Of System.Decimal))
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
		' Maps to viewPriceListData.PRICELISTID
		' </summary>
		Public Overridable Property Pricelistid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewPriceListDataMetadata.ColumnNames.Pricelistid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewPriceListDataMetadata.ColumnNames.Pricelistid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPriceListData.CUSTID
		' </summary>
		Public Overridable Property Custid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewPriceListDataMetadata.ColumnNames.Custid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewPriceListDataMetadata.ColumnNames.Custid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPriceListData.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewPriceListDataMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewPriceListDataMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPriceListData.UNITS
		' </summary>
		Public Overridable Property Units As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewPriceListDataMetadata.ColumnNames.Units)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewPriceListDataMetadata.ColumnNames.Units, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPriceListData.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewPriceListDataMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPriceListDataMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPriceListData.UNITPRICE
		' </summary>
		Public Overridable Property Unitprice As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewPriceListDataMetadata.ColumnNames.Unitprice)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewPriceListDataMetadata.ColumnNames.Unitprice, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPriceListData.UOM
		' </summary>
		Public Overridable Property Uom As System.String
			Get
				Return MyBase.GetSystemString(ViewPriceListDataMetadata.ColumnNames.Uom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPriceListDataMetadata.ColumnNames.Uom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPriceListData.UNITORCONTAINER
		' </summary>
		Public Overridable Property Unitorcontainer As System.String
			Get
				Return MyBase.GetSystemString(ViewPriceListDataMetadata.ColumnNames.Unitorcontainer)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPriceListDataMetadata.ColumnNames.Unitorcontainer, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPriceListData.EFFECTIVEDATE
		' </summary>
		Public Overridable Property Effectivedate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewPriceListDataMetadata.ColumnNames.Effectivedate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewPriceListDataMetadata.ColumnNames.Effectivedate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPriceListData.TAXABLE
		' </summary>
		Public Overridable Property Taxable As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewPriceListDataMetadata.ColumnNames.Taxable)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewPriceListDataMetadata.ColumnNames.Taxable, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPriceListData.CONTAINERPRICE
		' </summary>
		Public Overridable Property Containerprice As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewPriceListDataMetadata.ColumnNames.Containerprice)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewPriceListDataMetadata.ColumnNames.Containerprice, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPriceListData.CUSTOMERPRODUCTCODE
		' </summary>
		Public Overridable Property Customerproductcode As System.String
			Get
				Return MyBase.GetSystemString(ViewPriceListDataMetadata.ColumnNames.Customerproductcode)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPriceListDataMetadata.ColumnNames.Customerproductcode, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPriceListData.WEIGHTUOM
		' </summary>
		Public Overridable Property Weightuom As System.String
			Get
				Return MyBase.GetSystemString(ViewPriceListDataMetadata.ColumnNames.Weightuom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPriceListDataMetadata.ColumnNames.Weightuom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPriceListData.WEIGHTUNITS
		' </summary>
		Public Overridable Property Weightunits As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewPriceListDataMetadata.ColumnNames.Weightunits)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewPriceListDataMetadata.ColumnNames.Weightunits, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPriceListData.WEIGHTPRICE
		' </summary>
		Public Overridable Property Weightprice As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewPriceListDataMetadata.ColumnNames.Weightprice)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewPriceListDataMetadata.ColumnNames.Weightprice, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPriceListData.VOLUMEUOM
		' </summary>
		Public Overridable Property Volumeuom As System.String
			Get
				Return MyBase.GetSystemString(ViewPriceListDataMetadata.ColumnNames.Volumeuom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPriceListDataMetadata.ColumnNames.Volumeuom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPriceListData.VOLUMEUNITS
		' </summary>
		Public Overridable Property Volumeunits As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewPriceListDataMetadata.ColumnNames.Volumeunits)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewPriceListDataMetadata.ColumnNames.Volumeunits, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPriceListData.VOLUMEPRICE
		' </summary>
		Public Overridable Property Volumeprice As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewPriceListDataMetadata.ColumnNames.Volumeprice)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewPriceListDataMetadata.ColumnNames.Volumeprice, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPriceListData.PRICINGMETHOD
		' </summary>
		Public Overridable Property Pricingmethod As System.String
			Get
				Return MyBase.GetSystemString(ViewPriceListDataMetadata.ColumnNames.Pricingmethod)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPriceListDataMetadata.ColumnNames.Pricingmethod, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPriceListData.PRICELISTSTATUS
		' </summary>
		Public Overridable Property Priceliststatus As System.String
			Get
				Return MyBase.GetSystemString(ViewPriceListDataMetadata.ColumnNames.Priceliststatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPriceListDataMetadata.ColumnNames.Priceliststatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPriceListData.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewPriceListDataMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPriceListDataMetadata.ColumnNames.Productdesc, value)
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
		
			Public Sub New(ByVal entity As esViewPriceListData)
				Me.entity = entity
			End Sub				
		
	
			Public Property Pricelistid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Pricelistid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Pricelistid = Nothing
					Else
						entity.Pricelistid = Convert.ToInt32(Value)
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
		  	
			Public Property Units As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Units
					
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
						entity.Units = Convert.ToDecimal(Value)
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
		  	
			Public Property Unitprice As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Unitprice
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Unitprice = Nothing
					Else
						entity.Unitprice = Convert.ToDecimal(Value)
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
		  	
			Public Property Unitorcontainer As System.String 
				Get
					Dim data_ As System.String = entity.Unitorcontainer
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Unitorcontainer = Nothing
					Else
						entity.Unitorcontainer = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Effectivedate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Effectivedate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Effectivedate = Nothing
					Else
						entity.Effectivedate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Taxable As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Taxable
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Taxable = Nothing
					Else
						entity.Taxable = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property Containerprice As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Containerprice
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Containerprice = Nothing
					Else
						entity.Containerprice = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Customerproductcode As System.String 
				Get
					Dim data_ As System.String = entity.Customerproductcode
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Customerproductcode = Nothing
					Else
						entity.Customerproductcode = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Weightuom As System.String 
				Get
					Dim data_ As System.String = entity.Weightuom
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Weightuom = Nothing
					Else
						entity.Weightuom = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Weightunits As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Weightunits
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Weightunits = Nothing
					Else
						entity.Weightunits = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Weightprice As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Weightprice
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Weightprice = Nothing
					Else
						entity.Weightprice = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Volumeuom As System.String 
				Get
					Dim data_ As System.String = entity.Volumeuom
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Volumeuom = Nothing
					Else
						entity.Volumeuom = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Volumeunits As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Volumeunits
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Volumeunits = Nothing
					Else
						entity.Volumeunits = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Volumeprice As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Volumeprice
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Volumeprice = Nothing
					Else
						entity.Volumeprice = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Pricingmethod As System.String 
				Get
					Dim data_ As System.String = entity.Pricingmethod
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Pricingmethod = Nothing
					Else
						entity.Pricingmethod = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Priceliststatus As System.String 
				Get
					Dim data_ As System.String = entity.Priceliststatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Priceliststatus = Nothing
					Else
						entity.Priceliststatus = Convert.ToString(Value)
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
		  

			Private entity As esViewPriceListData
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewPriceListDataQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewPriceListData can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewPriceListDataQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewPriceListDataMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Pricelistid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPriceListDataMetadata.ColumnNames.Pricelistid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Custid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPriceListDataMetadata.ColumnNames.Custid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPriceListDataMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Units As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPriceListDataMetadata.ColumnNames.Units, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPriceListDataMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Unitprice As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPriceListDataMetadata.ColumnNames.Unitprice, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Uom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPriceListDataMetadata.ColumnNames.Uom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Unitorcontainer As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPriceListDataMetadata.ColumnNames.Unitorcontainer, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Effectivedate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPriceListDataMetadata.ColumnNames.Effectivedate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Taxable As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPriceListDataMetadata.ColumnNames.Taxable, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Containerprice As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPriceListDataMetadata.ColumnNames.Containerprice, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Customerproductcode As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPriceListDataMetadata.ColumnNames.Customerproductcode, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Weightuom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPriceListDataMetadata.ColumnNames.Weightuom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Weightunits As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPriceListDataMetadata.ColumnNames.Weightunits, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Weightprice As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPriceListDataMetadata.ColumnNames.Weightprice, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Volumeuom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPriceListDataMetadata.ColumnNames.Volumeuom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Volumeunits As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPriceListDataMetadata.ColumnNames.Volumeunits, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Volumeprice As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPriceListDataMetadata.ColumnNames.Volumeprice, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Pricingmethod As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPriceListDataMetadata.ColumnNames.Pricingmethod, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Priceliststatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPriceListDataMetadata.ColumnNames.Priceliststatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPriceListDataMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewPriceListDataCollection")> _
	Partial Public Class ViewPriceListDataCollection
		Inherits esViewPriceListDataCollection
		Implements IEnumerable(Of ViewPriceListData)
		
        Public Shared Widening Operator CType(ByVal coll As ViewPriceListDataCollection) As List(Of ViewPriceListData)
            Dim list As List(Of ViewPriceListData) = New List(Of ViewPriceListData)
            Dim emp As ViewPriceListData

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewPriceListDataMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewPriceListDataQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewPriceListData(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewPriceListData()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewPriceListDataQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewPriceListDataQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewPriceListDataQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewPriceListData 
			Return CType(MyBase.AddNewEntity(), ViewPriceListData)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewPriceListData) Implements IEnumerable(Of ViewPriceListData).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewPriceListData)(Me)
        End Function
		
		Private _query As ViewPriceListDataQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewPriceListData' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewPriceListData ()")> _
	<Serializable> _
	Partial Public Class ViewPriceListData 
		Inherits esViewPriceListData

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewPriceListDataMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewPriceListDataQuery

			If Me._query Is Nothing Then
				Me._query = New ViewPriceListDataQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewPriceListDataQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewPriceListDataQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewPriceListDataQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewPriceListDataQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewPriceListDataQuery
		inherits esViewPriceListDataQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewPriceListDataQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewPriceListDataMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewPriceListDataMetadata.ColumnNames.Pricelistid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewPriceListDataMetadata.PropertyNames.Pricelistid
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPriceListDataMetadata.ColumnNames.Custid, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewPriceListDataMetadata.PropertyNames.Custid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPriceListDataMetadata.ColumnNames.Productid, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewPriceListDataMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPriceListDataMetadata.ColumnNames.Units, 3, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewPriceListDataMetadata.PropertyNames.Units
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPriceListDataMetadata.ColumnNames.Container, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPriceListDataMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPriceListDataMetadata.ColumnNames.Unitprice, 5, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewPriceListDataMetadata.PropertyNames.Unitprice
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPriceListDataMetadata.ColumnNames.Uom, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPriceListDataMetadata.PropertyNames.Uom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPriceListDataMetadata.ColumnNames.Unitorcontainer, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPriceListDataMetadata.PropertyNames.Unitorcontainer
			c.CharacterMaxLength = 1
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPriceListDataMetadata.ColumnNames.Effectivedate, 8, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewPriceListDataMetadata.PropertyNames.Effectivedate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPriceListDataMetadata.ColumnNames.Taxable, 9, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewPriceListDataMetadata.PropertyNames.Taxable
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPriceListDataMetadata.ColumnNames.Containerprice, 10, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewPriceListDataMetadata.PropertyNames.Containerprice
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPriceListDataMetadata.ColumnNames.Customerproductcode, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPriceListDataMetadata.PropertyNames.Customerproductcode
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPriceListDataMetadata.ColumnNames.Weightuom, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPriceListDataMetadata.PropertyNames.Weightuom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPriceListDataMetadata.ColumnNames.Weightunits, 13, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewPriceListDataMetadata.PropertyNames.Weightunits
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPriceListDataMetadata.ColumnNames.Weightprice, 14, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewPriceListDataMetadata.PropertyNames.Weightprice
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPriceListDataMetadata.ColumnNames.Volumeuom, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPriceListDataMetadata.PropertyNames.Volumeuom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPriceListDataMetadata.ColumnNames.Volumeunits, 16, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewPriceListDataMetadata.PropertyNames.Volumeunits
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPriceListDataMetadata.ColumnNames.Volumeprice, 17, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewPriceListDataMetadata.PropertyNames.Volumeprice
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPriceListDataMetadata.ColumnNames.Pricingmethod, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPriceListDataMetadata.PropertyNames.Pricingmethod
			c.CharacterMaxLength = 8
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPriceListDataMetadata.ColumnNames.Priceliststatus, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPriceListDataMetadata.PropertyNames.Priceliststatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPriceListDataMetadata.ColumnNames.Productdesc, 20, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPriceListDataMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewPriceListDataMetadata
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
			 Public Const Pricelistid As String = "PRICELISTID"
			 Public Const Custid As String = "CUSTID"
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Units As String = "UNITS"
			 Public Const Container As String = "CONTAINER"
			 Public Const Unitprice As String = "UNITPRICE"
			 Public Const Uom As String = "UOM"
			 Public Const Unitorcontainer As String = "UNITORCONTAINER"
			 Public Const Effectivedate As String = "EFFECTIVEDATE"
			 Public Const Taxable As String = "TAXABLE"
			 Public Const Containerprice As String = "CONTAINERPRICE"
			 Public Const Customerproductcode As String = "CUSTOMERPRODUCTCODE"
			 Public Const Weightuom As String = "WEIGHTUOM"
			 Public Const Weightunits As String = "WEIGHTUNITS"
			 Public Const Weightprice As String = "WEIGHTPRICE"
			 Public Const Volumeuom As String = "VOLUMEUOM"
			 Public Const Volumeunits As String = "VOLUMEUNITS"
			 Public Const Volumeprice As String = "VOLUMEPRICE"
			 Public Const Pricingmethod As String = "PRICINGMETHOD"
			 Public Const Priceliststatus As String = "PRICELISTSTATUS"
			 Public Const Productdesc As String = "PRODUCTDESC"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Pricelistid As String = "Pricelistid"
			 Public Const Custid As String = "Custid"
			 Public Const Productid As String = "Productid"
			 Public Const Units As String = "Units"
			 Public Const Container As String = "Container"
			 Public Const Unitprice As String = "Unitprice"
			 Public Const Uom As String = "Uom"
			 Public Const Unitorcontainer As String = "Unitorcontainer"
			 Public Const Effectivedate As String = "Effectivedate"
			 Public Const Taxable As String = "Taxable"
			 Public Const Containerprice As String = "Containerprice"
			 Public Const Customerproductcode As String = "Customerproductcode"
			 Public Const Weightuom As String = "Weightuom"
			 Public Const Weightunits As String = "Weightunits"
			 Public Const Weightprice As String = "Weightprice"
			 Public Const Volumeuom As String = "Volumeuom"
			 Public Const Volumeunits As String = "Volumeunits"
			 Public Const Volumeprice As String = "Volumeprice"
			 Public Const Pricingmethod As String = "Pricingmethod"
			 Public Const Priceliststatus As String = "Priceliststatus"
			 Public Const Productdesc As String = "Productdesc"
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
            SyncLock GetType(ViewPriceListDataMetadata)
			
				If ViewPriceListDataMetadata.mapDelegates Is Nothing Then
					ViewPriceListDataMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewPriceListDataMetadata._meta Is Nothing Then
                    ViewPriceListDataMetadata._meta = New ViewPriceListDataMetadata()
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
				

				meta.AddTypeMap("Pricelistid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Custid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Units", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Unitprice", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Uom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Unitorcontainer", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Effectivedate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Taxable", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Containerprice", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Customerproductcode", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Weightuom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Weightunits", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Weightprice", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Volumeuom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Volumeunits", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Volumeprice", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Pricingmethod", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Priceliststatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Productdesc", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewPriceListData"
				meta.Destination = "viewPriceListData"
				
				meta.spInsert = "proc_viewPriceListDataInsert"
				meta.spUpdate = "proc_viewPriceListDataUpdate"
				meta.spDelete = "proc_viewPriceListDataDelete"
				meta.spLoadAll = "proc_viewPriceListDataLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewPriceListDataLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewPriceListDataMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
