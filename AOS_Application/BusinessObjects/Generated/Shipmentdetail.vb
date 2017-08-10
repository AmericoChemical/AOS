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
	MustInherit Public Class esShipmentdetailCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ShipmentdetailCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esShipmentdetailQuery)
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
            Me.InitQuery(CType(query, esShipmentdetailQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Shipmentdetail) As Shipmentdetail
			Return CType(MyBase.DetachEntity(entity), Shipmentdetail)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Shipmentdetail) As Shipmentdetail
			Return CType(MyBase.AttachEntity(entity), Shipmentdetail)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ShipmentdetailCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Shipmentdetail
            Get
                Return TryCast(MyBase.Item(index), Shipmentdetail)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Shipmentdetail)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esShipmentdetail	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esShipmentdetailQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal shipmentdetailid As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(shipmentdetailid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(shipmentdetailid)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal shipmentdetailid As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(shipmentdetailid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(shipmentdetailid)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal shipmentdetailid As System.Int32) As Boolean
		
			Dim query As esShipmentdetailQuery = Me.GetDynamicQuery()
			query.Where(query.Shipmentdetailid.Equal(shipmentdetailid))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal shipmentdetailid As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("SHIPMENTDETAILID", shipmentdetailid)
			
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
												
						Case "Shipmentdetailid"
							Me.str.Shipmentdetailid = CType(value, string)
												
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
												
						Case "Batchnumber"
							Me.str.Batchnumber = CType(value, string)
												
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
												
						Case "Workorderitemnumber"
							Me.str.Workorderitemnumber = CType(value, string)
												
						Case "Itemtype"
							Me.str.Itemtype = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Shipmentdetailid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Shipmentdetailid = CType(value, Nullable(Of System.Int32))
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
		' Maps to SHIPMENTDETAIL.SHIPMENTDETAILID
		' </summary>
		Public Overridable Property Shipmentdetailid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ShipmentdetailMetadata.ColumnNames.Shipmentdetailid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ShipmentdetailMetadata.ColumnNames.Shipmentdetailid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENTDETAIL.SHIPMENTNUMBER
		' </summary>
		Public Overridable Property Shipmentnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ShipmentdetailMetadata.ColumnNames.Shipmentnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ShipmentdetailMetadata.ColumnNames.Shipmentnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENTDETAIL.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ShipmentdetailMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ShipmentdetailMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENTDETAIL.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ShipmentdetailMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ShipmentdetailMetadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENTDETAIL.QTYCONTAINERS
		' </summary>
		Public Overridable Property Qtycontainers As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ShipmentdetailMetadata.ColumnNames.Qtycontainers)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ShipmentdetailMetadata.ColumnNames.Qtycontainers, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENTDETAIL.TOTALWEIGHT
		' </summary>
		Public Overridable Property Totalweight As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ShipmentdetailMetadata.ColumnNames.Totalweight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ShipmentdetailMetadata.ColumnNames.Totalweight, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENTDETAIL.BATCHNUMBER
		' </summary>
		Public Overridable Property Batchnumber As System.String
			Get
				Return MyBase.GetSystemString(ShipmentdetailMetadata.ColumnNames.Batchnumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ShipmentdetailMetadata.ColumnNames.Batchnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENTDETAIL.STDWEIGHT
		' </summary>
		Public Overridable Property Stdweight As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ShipmentdetailMetadata.ColumnNames.Stdweight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ShipmentdetailMetadata.ColumnNames.Stdweight, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENTDETAIL.STDGALLONS
		' </summary>
		Public Overridable Property Stdgallons As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ShipmentdetailMetadata.ColumnNames.Stdgallons)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ShipmentdetailMetadata.ColumnNames.Stdgallons, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENTDETAIL.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ShipmentdetailMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ShipmentdetailMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENTDETAIL.DOTDESC
		' </summary>
		Public Overridable Property Dotdesc As System.String
			Get
				Return MyBase.GetSystemString(ShipmentdetailMetadata.ColumnNames.Dotdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ShipmentdetailMetadata.ColumnNames.Dotdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENTDETAIL.HAZMATDESC
		' </summary>
		Public Overridable Property Hazmatdesc As System.String
			Get
				Return MyBase.GetSystemString(ShipmentdetailMetadata.ColumnNames.Hazmatdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ShipmentdetailMetadata.ColumnNames.Hazmatdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENTDETAIL.UNLINE
		' </summary>
		Public Overridable Property Unline As System.String
			Get
				Return MyBase.GetSystemString(ShipmentdetailMetadata.ColumnNames.Unline)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ShipmentdetailMetadata.ColumnNames.Unline, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENTDETAIL.CLASSRATE
		' </summary>
		Public Overridable Property Classrate As System.String
			Get
				Return MyBase.GetSystemString(ShipmentdetailMetadata.ColumnNames.Classrate)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ShipmentdetailMetadata.ColumnNames.Classrate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENTDETAIL.LD1
		' </summary>
		Public Overridable Property Ld1 As System.String
			Get
				Return MyBase.GetSystemString(ShipmentdetailMetadata.ColumnNames.Ld1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ShipmentdetailMetadata.ColumnNames.Ld1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENTDETAIL.LD2
		' </summary>
		Public Overridable Property Ld2 As System.String
			Get
				Return MyBase.GetSystemString(ShipmentdetailMetadata.ColumnNames.Ld2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ShipmentdetailMetadata.ColumnNames.Ld2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENTDETAIL.LD3
		' </summary>
		Public Overridable Property Ld3 As System.String
			Get
				Return MyBase.GetSystemString(ShipmentdetailMetadata.ColumnNames.Ld3)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ShipmentdetailMetadata.ColumnNames.Ld3, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENTDETAIL.BILLABLE
		' </summary>
		Public Overridable Property Billable As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ShipmentdetailMetadata.ColumnNames.Billable)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ShipmentdetailMetadata.ColumnNames.Billable, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENTDETAIL.WORKORDERITEMNUMBER
		' </summary>
		Public Overridable Property Workorderitemnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ShipmentdetailMetadata.ColumnNames.Workorderitemnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ShipmentdetailMetadata.ColumnNames.Workorderitemnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to SHIPMENTDETAIL.ITEMTYPE
		' </summary>
		Public Overridable Property Itemtype As System.String
			Get
				Return MyBase.GetSystemString(ShipmentdetailMetadata.ColumnNames.Itemtype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ShipmentdetailMetadata.ColumnNames.Itemtype, value)
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
		
			Public Sub New(ByVal entity As esShipmentdetail)
				Me.entity = entity
			End Sub				
		
	
			Public Property Shipmentdetailid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Shipmentdetailid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipmentdetailid = Nothing
					Else
						entity.Shipmentdetailid = Convert.ToInt32(Value)
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
		  	
			Public Property Batchnumber As System.String 
				Get
					Dim data_ As System.String = entity.Batchnumber
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Batchnumber = Nothing
					Else
						entity.Batchnumber = Convert.ToString(Value)
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
		  	
			Public Property Itemtype As System.String 
				Get
					Dim data_ As System.String = entity.Itemtype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Itemtype = Nothing
					Else
						entity.Itemtype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esShipmentdetail
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esShipmentdetailQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esShipmentdetail can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Shipmentdetail 
		Inherits esShipmentdetail
		
	
		
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
	MustInherit Public Class esShipmentdetailQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ShipmentdetailMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Shipmentdetailid As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentdetailMetadata.ColumnNames.Shipmentdetailid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Shipmentnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentdetailMetadata.ColumnNames.Shipmentnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentdetailMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentdetailMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Qtycontainers As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentdetailMetadata.ColumnNames.Qtycontainers, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Totalweight As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentdetailMetadata.ColumnNames.Totalweight, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Batchnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentdetailMetadata.ColumnNames.Batchnumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Stdweight As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentdetailMetadata.ColumnNames.Stdweight, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Stdgallons As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentdetailMetadata.ColumnNames.Stdgallons, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentdetailMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Dotdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentdetailMetadata.ColumnNames.Dotdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Hazmatdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentdetailMetadata.ColumnNames.Hazmatdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Unline As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentdetailMetadata.ColumnNames.Unline, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Classrate As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentdetailMetadata.ColumnNames.Classrate, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Ld1 As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentdetailMetadata.ColumnNames.Ld1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Ld2 As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentdetailMetadata.ColumnNames.Ld2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Ld3 As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentdetailMetadata.ColumnNames.Ld3, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Billable As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentdetailMetadata.ColumnNames.Billable, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Workorderitemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentdetailMetadata.ColumnNames.Workorderitemnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Itemtype As esQueryItem
			Get
				Return New esQueryItem(Me, ShipmentdetailMetadata.ColumnNames.Itemtype, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ShipmentdetailCollection")> _
	Partial Public Class ShipmentdetailCollection
		Inherits esShipmentdetailCollection
		Implements IEnumerable(Of Shipmentdetail)
		
        Public Shared Widening Operator CType(ByVal coll As ShipmentdetailCollection) As List(Of Shipmentdetail)
            Dim list As List(Of Shipmentdetail) = New List(Of Shipmentdetail)
            Dim emp As Shipmentdetail

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ShipmentdetailMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ShipmentdetailQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Shipmentdetail(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Shipmentdetail()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As ShipmentdetailQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ShipmentdetailQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ShipmentdetailQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Shipmentdetail 
			Return CType(MyBase.AddNewEntity(), Shipmentdetail)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal shipmentdetailid As System.Int32) As Shipmentdetail
			Return CType(MyBase.FindByPrimaryKey(shipmentdetailid), Shipmentdetail)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Shipmentdetail) Implements IEnumerable(Of Shipmentdetail).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Shipmentdetail)(Me)
        End Function
		
		Private _query As ShipmentdetailQuery

	End Class
	


	' <summary>
	' Encapsulates the 'SHIPMENTDETAIL' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Shipmentdetail ({Shipmentdetailid.Value})")> _
	<Serializable> _
	Partial Public Class Shipmentdetail 
		Inherits esShipmentdetail

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ShipmentdetailMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esShipmentdetailQuery

			If Me._query Is Nothing Then
				Me._query = New ShipmentdetailQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ShipmentdetailQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ShipmentdetailQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ShipmentdetailQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ShipmentdetailQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ShipmentdetailQuery
		inherits esShipmentdetailQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ShipmentdetailQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ShipmentdetailMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ShipmentdetailMetadata.ColumnNames.Shipmentdetailid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ShipmentdetailMetadata.PropertyNames.Shipmentdetailid
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentdetailMetadata.ColumnNames.Shipmentnumber, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ShipmentdetailMetadata.PropertyNames.Shipmentnumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentdetailMetadata.ColumnNames.Productid, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ShipmentdetailMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentdetailMetadata.ColumnNames.Productdesc, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ShipmentdetailMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentdetailMetadata.ColumnNames.Qtycontainers, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ShipmentdetailMetadata.PropertyNames.Qtycontainers
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentdetailMetadata.ColumnNames.Totalweight, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ShipmentdetailMetadata.PropertyNames.Totalweight
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentdetailMetadata.ColumnNames.Batchnumber, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ShipmentdetailMetadata.PropertyNames.Batchnumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentdetailMetadata.ColumnNames.Stdweight, 7, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ShipmentdetailMetadata.PropertyNames.Stdweight
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentdetailMetadata.ColumnNames.Stdgallons, 8, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ShipmentdetailMetadata.PropertyNames.Stdgallons
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentdetailMetadata.ColumnNames.Container, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ShipmentdetailMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentdetailMetadata.ColumnNames.Dotdesc, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ShipmentdetailMetadata.PropertyNames.Dotdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentdetailMetadata.ColumnNames.Hazmatdesc, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = ShipmentdetailMetadata.PropertyNames.Hazmatdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentdetailMetadata.ColumnNames.Unline, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = ShipmentdetailMetadata.PropertyNames.Unline
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentdetailMetadata.ColumnNames.Classrate, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = ShipmentdetailMetadata.PropertyNames.Classrate
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentdetailMetadata.ColumnNames.Ld1, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = ShipmentdetailMetadata.PropertyNames.Ld1
			c.CharacterMaxLength = 500
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentdetailMetadata.ColumnNames.Ld2, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = ShipmentdetailMetadata.PropertyNames.Ld2
			c.CharacterMaxLength = 500
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentdetailMetadata.ColumnNames.Ld3, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = ShipmentdetailMetadata.PropertyNames.Ld3
			c.CharacterMaxLength = 500
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentdetailMetadata.ColumnNames.Billable, 17, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ShipmentdetailMetadata.PropertyNames.Billable
			c.HasDefault = True
			c.Default = "((1))"
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentdetailMetadata.ColumnNames.Workorderitemnumber, 18, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ShipmentdetailMetadata.PropertyNames.Workorderitemnumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ShipmentdetailMetadata.ColumnNames.Itemtype, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = ShipmentdetailMetadata.PropertyNames.Itemtype
			c.CharacterMaxLength = 1
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ShipmentdetailMetadata
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
			 Public Const Shipmentdetailid As String = "SHIPMENTDETAILID"
			 Public Const Shipmentnumber As String = "SHIPMENTNUMBER"
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Productdesc As String = "PRODUCTDESC"
			 Public Const Qtycontainers As String = "QTYCONTAINERS"
			 Public Const Totalweight As String = "TOTALWEIGHT"
			 Public Const Batchnumber As String = "BATCHNUMBER"
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
			 Public Const Workorderitemnumber As String = "WORKORDERITEMNUMBER"
			 Public Const Itemtype As String = "ITEMTYPE"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Shipmentdetailid As String = "Shipmentdetailid"
			 Public Const Shipmentnumber As String = "Shipmentnumber"
			 Public Const Productid As String = "Productid"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const Qtycontainers As String = "Qtycontainers"
			 Public Const Totalweight As String = "Totalweight"
			 Public Const Batchnumber As String = "Batchnumber"
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
			 Public Const Workorderitemnumber As String = "Workorderitemnumber"
			 Public Const Itemtype As String = "Itemtype"
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
            SyncLock GetType(ShipmentdetailMetadata)
			
				If ShipmentdetailMetadata.mapDelegates Is Nothing Then
					ShipmentdetailMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ShipmentdetailMetadata._meta Is Nothing Then
                    ShipmentdetailMetadata._meta = New ShipmentdetailMetadata()
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
				

				meta.AddTypeMap("Shipmentdetailid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Shipmentnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Qtycontainers", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Totalweight", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Batchnumber", new esTypeMap("varchar", "System.String"))
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
				meta.AddTypeMap("Workorderitemnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Itemtype", new esTypeMap("nchar", "System.String"))			
				
				
				 
				meta.Source = "SHIPMENTDETAIL"
				meta.Destination = "SHIPMENTDETAIL"
				
				meta.spInsert = "proc_SHIPMENTDETAILInsert"
				meta.spUpdate = "proc_SHIPMENTDETAILUpdate"
				meta.spDelete = "proc_SHIPMENTDETAILDelete"
				meta.spLoadAll = "proc_SHIPMENTDETAILLoadAll"
				meta.spLoadByPrimaryKey = "proc_SHIPMENTDETAILLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ShipmentdetailMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
