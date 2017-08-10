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
	MustInherit Public Class esShipmentitemCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ShipmentitemCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esShipmentitemQuery)
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
            Me.InitQuery(CType(query, esShipmentitemQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Shipmentitem) As Shipmentitem
			Return CType(MyBase.DetachEntity(entity), Shipmentitem)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Shipmentitem) As Shipmentitem
			Return CType(MyBase.AttachEntity(entity), Shipmentitem)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ShipmentitemCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Shipmentitem
            Get
                Return TryCast(MyBase.Item(index), Shipmentitem)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Shipmentitem)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esShipmentitem	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esShipmentitemQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal shipmentitemnumber As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(shipmentitemnumber)
			Else
				Return LoadByPrimaryKeyStoredProcedure(shipmentitemnumber)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal shipmentitemnumber As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(shipmentitemnumber)
			Else
				Return LoadByPrimaryKeyStoredProcedure(shipmentitemnumber)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal shipmentitemnumber As System.Int32) As Boolean
		
			Dim query As esShipmentitemQuery = Me.GetDynamicQuery()
			query.Where(query.Shipmentitemnumber.Equal(shipmentitemnumber))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal shipmentitemnumber As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("SHIPMENTITEMNUMBER", shipmentitemnumber)
			
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
												
						Case "Shipmentitemnumber"
							Me.str.Shipmentitemnumber = CType(value, string)
												
						Case "Shipmentnumber"
							Me.str.Shipmentnumber = CType(value, string)
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Productdesc"
							Me.str.Productdesc = CType(value, string)
												
						Case "Qtycontainers"
							Me.str.Qtycontainers = CType(value, string)
												
						Case "Totalweight"
							Me.str.Totalweight = CType(value, string)
												
						Case "Lotnumber"
							Me.str.Lotnumber = CType(value, string)
												
						Case "Stdweight"
							Me.str.Stdweight = CType(value, string)
												
						Case "Stdgallons"
							Me.str.Stdgallons = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "Dotdesc"
							Me.str.Dotdesc = CType(value, string)
												
						Case "Hazmatdesc"
							Me.str.Hazmatdesc = CType(value, string)
												
						Case "Unline"
							Me.str.Unline = CType(value, string)
												
						Case "Classrate"
							Me.str.Classrate = CType(value, string)
												
						Case "Ld1"
							Me.str.Ld1 = CType(value, string)
												
						Case "Ld2"
							Me.str.Ld2 = CType(value, string)
												
						Case "Ld3"
							Me.str.Ld3 = CType(value, string)
												
						Case "Billable"
							Me.str.Billable = CType(value, string)
												
						Case "Workordernumber"
							Me.str.Workordernumber = CType(value, string)
												
						Case "Workorderitemnumber"
							Me.str.Workorderitemnumber = CType(value, string)
												
						Case "Invitemnumber"
							Me.str.Invitemnumber = CType(value, string)
												
						Case "Units"
							Me.str.Units = CType(value, string)
												
						Case "Uom"
							Me.str.Uom = CType(value, string)
												
						Case "Unitcost"
							Me.str.Unitcost = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Shipmentitemnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Shipmentitemnumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Shipmentnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Shipmentnumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Qtycontainers"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Qtycontainers = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Totalweight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Totalweight = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Stdweight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Stdweight = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Stdgallons"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Stdgallons = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Billable"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Billable = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Workordernumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Workordernumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Workorderitemnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Workorderitemnumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Invitemnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Invitemnumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Units"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Units = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Unitcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Unitcost = CType(value, Nullable(Of System.Decimal))
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
		' Maps to SHIPMENTITEM.SHIPMENTITEMNUMBER
		' </summary>
		Public Overridable Property Shipmentitemnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ShipmentitemMetadata.ColumnNames.Shipmentitemnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ShipmentitemMetadata.ColumnNames.Shipmentitemnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENTITEM.SHIPMENTNUMBER
		' </summary>
		Public Overridable Property Shipmentnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ShipmentitemMetadata.ColumnNames.Shipmentnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ShipmentitemMetadata.ColumnNames.Shipmentnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENTITEM.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ShipmentitemMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ShipmentitemMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENTITEM.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ShipmentitemMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ShipmentitemMetadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENTITEM.QTYCONTAINERS
		' </summary>
		Public Overridable Property Qtycontainers As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ShipmentitemMetadata.ColumnNames.Qtycontainers)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ShipmentitemMetadata.ColumnNames.Qtycontainers, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENTITEM.TOTALWEIGHT
		' </summary>
		Public Overridable Property Totalweight As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ShipmentitemMetadata.ColumnNames.Totalweight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ShipmentitemMetadata.ColumnNames.Totalweight, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENTITEM.LOTNUMBER
		' </summary>
		Public Overridable Property Lotnumber As System.String
			Get
				Return MyBase.GetSystemString(ShipmentitemMetadata.ColumnNames.Lotnumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ShipmentitemMetadata.ColumnNames.Lotnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENTITEM.STDWEIGHT
		' </summary>
		Public Overridable Property Stdweight As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ShipmentitemMetadata.ColumnNames.Stdweight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ShipmentitemMetadata.ColumnNames.Stdweight, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENTITEM.STDGALLONS
		' </summary>
		Public Overridable Property Stdgallons As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ShipmentitemMetadata.ColumnNames.Stdgallons)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ShipmentitemMetadata.ColumnNames.Stdgallons, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENTITEM.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ShipmentitemMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ShipmentitemMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENTITEM.DOTDESC
		' </summary>
		Public Overridable Property Dotdesc As System.String
			Get
				Return MyBase.GetSystemString(ShipmentitemMetadata.ColumnNames.Dotdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ShipmentitemMetadata.ColumnNames.Dotdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENTITEM.HAZMATDESC
		' </summary>
		Public Overridable Property Hazmatdesc As System.String
			Get
				Return MyBase.GetSystemString(ShipmentitemMetadata.ColumnNames.Hazmatdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ShipmentitemMetadata.ColumnNames.Hazmatdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENTITEM.UNLINE
		' </summary>
		Public Overridable Property Unline As System.String
			Get
				Return MyBase.GetSystemString(ShipmentitemMetadata.ColumnNames.Unline)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ShipmentitemMetadata.ColumnNames.Unline, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENTITEM.CLASSRATE
		' </summary>
		Public Overridable Property Classrate As System.String
			Get
				Return MyBase.GetSystemString(ShipmentitemMetadata.ColumnNames.Classrate)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ShipmentitemMetadata.ColumnNames.Classrate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENTITEM.LD1
		' </summary>
		Public Overridable Property Ld1 As System.String
			Get
				Return MyBase.GetSystemString(ShipmentitemMetadata.ColumnNames.Ld1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ShipmentitemMetadata.ColumnNames.Ld1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENTITEM.LD2
		' </summary>
		Public Overridable Property Ld2 As System.String
			Get
				Return MyBase.GetSystemString(ShipmentitemMetadata.ColumnNames.Ld2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ShipmentitemMetadata.ColumnNames.Ld2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENTITEM.LD3
		' </summary>
		Public Overridable Property Ld3 As System.String
			Get
				Return MyBase.GetSystemString(ShipmentitemMetadata.ColumnNames.Ld3)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ShipmentitemMetadata.ColumnNames.Ld3, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENTITEM.BILLABLE
		' </summary>
		Public Overridable Property Billable As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ShipmentitemMetadata.ColumnNames.Billable)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ShipmentitemMetadata.ColumnNames.Billable, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENTITEM.WORKORDERNUMBER
		' </summary>
		Public Overridable Property Workordernumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ShipmentitemMetadata.ColumnNames.Workordernumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ShipmentitemMetadata.ColumnNames.Workordernumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENTITEM.WORKORDERITEMNUMBER
		' </summary>
		Public Overridable Property Workorderitemnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ShipmentitemMetadata.ColumnNames.Workorderitemnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ShipmentitemMetadata.ColumnNames.Workorderitemnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENTITEM.INVITEMNUMBER
		' </summary>
		Public Overridable Property Invitemnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ShipmentitemMetadata.ColumnNames.Invitemnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ShipmentitemMetadata.ColumnNames.Invitemnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENTITEM.UNITS
		' </summary>
		Public Overridable Property Units As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ShipmentitemMetadata.ColumnNames.Units)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ShipmentitemMetadata.ColumnNames.Units, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENTITEM.UOM
		' </summary>
		Public Overridable Property Uom As System.String
			Get
				Return MyBase.GetSystemString(ShipmentitemMetadata.ColumnNames.Uom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ShipmentitemMetadata.ColumnNames.Uom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENTITEM.UNITCOST
		' </summary>
		Public Overridable Property Unitcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ShipmentitemMetadata.ColumnNames.Unitcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ShipmentitemMetadata.ColumnNames.Unitcost, value)
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
		
			Public Sub New(ByVal entity As esShipmentitem)
				Me.entity = entity
			End Sub				
		
	
			Public Property Shipmentitemnumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Shipmentitemnumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipmentitemnumber = Nothing
					Else
						entity.Shipmentitemnumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shipmentnumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Shipmentnumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipmentnumber = Nothing
					Else
						entity.Shipmentnumber = Convert.ToInt32(Value)
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
		  	
			Public Property Qtycontainers As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Qtycontainers
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qtycontainers = Nothing
					Else
						entity.Qtycontainers = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Totalweight As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Totalweight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Totalweight = Nothing
					Else
						entity.Totalweight = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Lotnumber As System.String 
				Get
					Dim data_ As System.String = entity.Lotnumber
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Lotnumber = Nothing
					Else
						entity.Lotnumber = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Stdweight As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Stdweight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Stdweight = Nothing
					Else
						entity.Stdweight = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Stdgallons As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Stdgallons
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Stdgallons = Nothing
					Else
						entity.Stdgallons = Convert.ToInt32(Value)
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
		  	
			Public Property Dotdesc As System.String 
				Get
					Dim data_ As System.String = entity.Dotdesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Dotdesc = Nothing
					Else
						entity.Dotdesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Hazmatdesc As System.String 
				Get
					Dim data_ As System.String = entity.Hazmatdesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Hazmatdesc = Nothing
					Else
						entity.Hazmatdesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Unline As System.String 
				Get
					Dim data_ As System.String = entity.Unline
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Unline = Nothing
					Else
						entity.Unline = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Classrate As System.String 
				Get
					Dim data_ As System.String = entity.Classrate
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Classrate = Nothing
					Else
						entity.Classrate = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Ld1 As System.String 
				Get
					Dim data_ As System.String = entity.Ld1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Ld1 = Nothing
					Else
						entity.Ld1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Ld2 As System.String 
				Get
					Dim data_ As System.String = entity.Ld2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Ld2 = Nothing
					Else
						entity.Ld2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Ld3 As System.String 
				Get
					Dim data_ As System.String = entity.Ld3
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Ld3 = Nothing
					Else
						entity.Ld3 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Billable As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Billable
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Billable = Nothing
					Else
						entity.Billable = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
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
		  	
			Public Property Invitemnumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Invitemnumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Invitemnumber = Nothing
					Else
						entity.Invitemnumber = Convert.ToInt32(Value)
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
		  	
			Public Property Unitcost As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Unitcost
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Unitcost = Nothing
					Else
						entity.Unitcost = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  

			Private entity As esShipmentitem
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esShipmentitemQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esShipmentitem can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Shipmentitem 
		Inherits esShipmentitem
		
	
		
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
	MustInherit Public Class esShipmentitemQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ShipmentitemMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Shipmentitemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentitemMetadata.ColumnNames.Shipmentitemnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Shipmentnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentitemMetadata.ColumnNames.Shipmentnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentitemMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentitemMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Qtycontainers As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentitemMetadata.ColumnNames.Qtycontainers, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Totalweight As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentitemMetadata.ColumnNames.Totalweight, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Lotnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentitemMetadata.ColumnNames.Lotnumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Stdweight As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentitemMetadata.ColumnNames.Stdweight, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Stdgallons As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentitemMetadata.ColumnNames.Stdgallons, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentitemMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Dotdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentitemMetadata.ColumnNames.Dotdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Hazmatdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentitemMetadata.ColumnNames.Hazmatdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Unline As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentitemMetadata.ColumnNames.Unline, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Classrate As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentitemMetadata.ColumnNames.Classrate, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Ld1 As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentitemMetadata.ColumnNames.Ld1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Ld2 As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentitemMetadata.ColumnNames.Ld2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Ld3 As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentitemMetadata.ColumnNames.Ld3, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Billable As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentitemMetadata.ColumnNames.Billable, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Workordernumber As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentitemMetadata.ColumnNames.Workordernumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Workorderitemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentitemMetadata.ColumnNames.Workorderitemnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Invitemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentitemMetadata.ColumnNames.Invitemnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Units As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentitemMetadata.ColumnNames.Units, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Uom As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentitemMetadata.ColumnNames.Uom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Unitcost As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentitemMetadata.ColumnNames.Unitcost, esSystemType.Decimal)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ShipmentitemCollection")> _
	Partial Public Class ShipmentitemCollection
		Inherits esShipmentitemCollection
		Implements IEnumerable(Of Shipmentitem)
		
        Public Shared Widening Operator CType(ByVal coll As ShipmentitemCollection) As List(Of Shipmentitem)
            Dim list As List(Of Shipmentitem) = New List(Of Shipmentitem)
            Dim emp As Shipmentitem

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ShipmentitemMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ShipmentitemQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Shipmentitem(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Shipmentitem()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As ShipmentitemQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ShipmentitemQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ShipmentitemQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Shipmentitem 
			Return CType(MyBase.AddNewEntity(), Shipmentitem)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal shipmentitemnumber As System.Int32) As Shipmentitem
			Return CType(MyBase.FindByPrimaryKey(shipmentitemnumber), Shipmentitem)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Shipmentitem) Implements IEnumerable(Of Shipmentitem).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Shipmentitem)(Me)
        End Function
		
		Private _query As ShipmentitemQuery

	End Class
	


	' <summary>
	' Encapsulates the 'SHIPMENTITEM' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Shipmentitem ({Shipmentitemnumber.Value})")> _
	<Serializable> _
	Partial Public Class Shipmentitem 
		Inherits esShipmentitem

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ShipmentitemMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esShipmentitemQuery

			If Me._query Is Nothing Then
				Me._query = New ShipmentitemQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ShipmentitemQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ShipmentitemQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ShipmentitemQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ShipmentitemQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ShipmentitemQuery
		inherits esShipmentitemQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ShipmentitemQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ShipmentitemMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ShipmentitemMetadata.ColumnNames.Shipmentitemnumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ShipmentitemMetadata.PropertyNames.Shipmentitemnumber
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentitemMetadata.ColumnNames.Shipmentnumber, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ShipmentitemMetadata.PropertyNames.Shipmentnumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentitemMetadata.ColumnNames.Productid, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ShipmentitemMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentitemMetadata.ColumnNames.Productdesc, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ShipmentitemMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentitemMetadata.ColumnNames.Qtycontainers, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ShipmentitemMetadata.PropertyNames.Qtycontainers
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentitemMetadata.ColumnNames.Totalweight, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ShipmentitemMetadata.PropertyNames.Totalweight
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentitemMetadata.ColumnNames.Lotnumber, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ShipmentitemMetadata.PropertyNames.Lotnumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentitemMetadata.ColumnNames.Stdweight, 7, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ShipmentitemMetadata.PropertyNames.Stdweight
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentitemMetadata.ColumnNames.Stdgallons, 8, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ShipmentitemMetadata.PropertyNames.Stdgallons
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentitemMetadata.ColumnNames.Container, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ShipmentitemMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentitemMetadata.ColumnNames.Dotdesc, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ShipmentitemMetadata.PropertyNames.Dotdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentitemMetadata.ColumnNames.Hazmatdesc, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = ShipmentitemMetadata.PropertyNames.Hazmatdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentitemMetadata.ColumnNames.Unline, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = ShipmentitemMetadata.PropertyNames.Unline
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentitemMetadata.ColumnNames.Classrate, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = ShipmentitemMetadata.PropertyNames.Classrate
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentitemMetadata.ColumnNames.Ld1, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = ShipmentitemMetadata.PropertyNames.Ld1
			c.CharacterMaxLength = 500
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentitemMetadata.ColumnNames.Ld2, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = ShipmentitemMetadata.PropertyNames.Ld2
			c.CharacterMaxLength = 500
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentitemMetadata.ColumnNames.Ld3, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = ShipmentitemMetadata.PropertyNames.Ld3
			c.CharacterMaxLength = 500
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentitemMetadata.ColumnNames.Billable, 17, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ShipmentitemMetadata.PropertyNames.Billable
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentitemMetadata.ColumnNames.Workordernumber, 18, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ShipmentitemMetadata.PropertyNames.Workordernumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentitemMetadata.ColumnNames.Workorderitemnumber, 19, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ShipmentitemMetadata.PropertyNames.Workorderitemnumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentitemMetadata.ColumnNames.Invitemnumber, 20, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ShipmentitemMetadata.PropertyNames.Invitemnumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentitemMetadata.ColumnNames.Units, 21, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ShipmentitemMetadata.PropertyNames.Units
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentitemMetadata.ColumnNames.Uom, 22, GetType(System.String), esSystemType.String)	
			c.PropertyName = ShipmentitemMetadata.PropertyNames.Uom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentitemMetadata.ColumnNames.Unitcost, 23, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ShipmentitemMetadata.PropertyNames.Unitcost
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ShipmentitemMetadata
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
			 Public Const Shipmentitemnumber As String = "SHIPMENTITEMNUMBER"
			 Public Const Shipmentnumber As String = "SHIPMENTNUMBER"
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Productdesc As String = "PRODUCTDESC"
			 Public Const Qtycontainers As String = "QTYCONTAINERS"
			 Public Const Totalweight As String = "TOTALWEIGHT"
			 Public Const Lotnumber As String = "LOTNUMBER"
			 Public Const Stdweight As String = "STDWEIGHT"
			 Public Const Stdgallons As String = "STDGALLONS"
			 Public Const Container As String = "CONTAINER"
			 Public Const Dotdesc As String = "DOTDESC"
			 Public Const Hazmatdesc As String = "HAZMATDESC"
			 Public Const Unline As String = "UNLINE"
			 Public Const Classrate As String = "CLASSRATE"
			 Public Const Ld1 As String = "LD1"
			 Public Const Ld2 As String = "LD2"
			 Public Const Ld3 As String = "LD3"
			 Public Const Billable As String = "BILLABLE"
			 Public Const Workordernumber As String = "WORKORDERNUMBER"
			 Public Const Workorderitemnumber As String = "WORKORDERITEMNUMBER"
			 Public Const Invitemnumber As String = "INVITEMNUMBER"
			 Public Const Units As String = "UNITS"
			 Public Const Uom As String = "UOM"
			 Public Const Unitcost As String = "UNITCOST"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Shipmentitemnumber As String = "Shipmentitemnumber"
			 Public Const Shipmentnumber As String = "Shipmentnumber"
			 Public Const Productid As String = "Productid"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const Qtycontainers As String = "Qtycontainers"
			 Public Const Totalweight As String = "Totalweight"
			 Public Const Lotnumber As String = "Lotnumber"
			 Public Const Stdweight As String = "Stdweight"
			 Public Const Stdgallons As String = "Stdgallons"
			 Public Const Container As String = "Container"
			 Public Const Dotdesc As String = "Dotdesc"
			 Public Const Hazmatdesc As String = "Hazmatdesc"
			 Public Const Unline As String = "Unline"
			 Public Const Classrate As String = "Classrate"
			 Public Const Ld1 As String = "Ld1"
			 Public Const Ld2 As String = "Ld2"
			 Public Const Ld3 As String = "Ld3"
			 Public Const Billable As String = "Billable"
			 Public Const Workordernumber As String = "Workordernumber"
			 Public Const Workorderitemnumber As String = "Workorderitemnumber"
			 Public Const Invitemnumber As String = "Invitemnumber"
			 Public Const Units As String = "Units"
			 Public Const Uom As String = "Uom"
			 Public Const Unitcost As String = "Unitcost"
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
            SyncLock GetType(ShipmentitemMetadata)
			
				If ShipmentitemMetadata.mapDelegates Is Nothing Then
					ShipmentitemMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ShipmentitemMetadata._meta Is Nothing Then
                    ShipmentitemMetadata._meta = New ShipmentitemMetadata()
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
				

				meta.AddTypeMap("Shipmentitemnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Shipmentnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Qtycontainers", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Totalweight", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Lotnumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Stdweight", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Stdgallons", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Dotdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Hazmatdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Unline", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Classrate", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Ld1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Ld2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Ld3", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Billable", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Workordernumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Workorderitemnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Invitemnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Units", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Uom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Unitcost", new esTypeMap("decimal", "System.Decimal"))			
				
				
				 
				meta.Source = "SHIPMENTITEM"
				meta.Destination = "SHIPMENTITEM"
				
				meta.spInsert = "proc_SHIPMENTITEMInsert"
				meta.spUpdate = "proc_SHIPMENTITEMUpdate"
				meta.spDelete = "proc_SHIPMENTITEMDelete"
				meta.spLoadAll = "proc_SHIPMENTITEMLoadAll"
				meta.spLoadByPrimaryKey = "proc_SHIPMENTITEMLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ShipmentitemMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
