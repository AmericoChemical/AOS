'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 11/27/2014 7:27:03 PM
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
	MustInherit Public Class esPurchaseitemhistoryCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "PurchaseitemhistoryCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esPurchaseitemhistoryQuery)
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
            Me.InitQuery(CType(query, esPurchaseitemhistoryQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Purchaseitemhistory) As Purchaseitemhistory
			Return CType(MyBase.DetachEntity(entity), Purchaseitemhistory)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Purchaseitemhistory) As Purchaseitemhistory
			Return CType(MyBase.AttachEntity(entity), Purchaseitemhistory)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As PurchaseitemhistoryCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Purchaseitemhistory
            Get
                Return TryCast(MyBase.Item(index), Purchaseitemhistory)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Purchaseitemhistory)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esPurchaseitemhistory	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esPurchaseitemhistoryQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal purchaseitemhistoryid As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(purchaseitemhistoryid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(purchaseitemhistoryid)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal purchaseitemhistoryid As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(purchaseitemhistoryid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(purchaseitemhistoryid)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal purchaseitemhistoryid As System.Int32) As Boolean
		
			Dim query As esPurchaseitemhistoryQuery = Me.GetDynamicQuery()
			query.Where(query.Purchaseitemhistoryid.Equal(purchaseitemhistoryid))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal purchaseitemhistoryid As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("PURCHASEITEMHISTORYID", purchaseitemhistoryid)
			
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
												
						Case "Purchaseitemhistoryid"
							Me.str.Purchaseitemhistoryid = CType(value, string)
												
						Case "Purchaseitemid"
							Me.str.Purchaseitemid = CType(value, string)
												
						Case "Purchasestatus"
							Me.str.Purchasestatus = CType(value, string)
												
						Case "Purchasetype"
							Me.str.Purchasetype = CType(value, string)
												
						Case "Itemid"
							Me.str.Itemid = CType(value, string)
												
						Case "Itemtype"
							Me.str.Itemtype = CType(value, string)
												
						Case "Itemdescription"
							Me.str.Itemdescription = CType(value, string)
												
						Case "Qty"
							Me.str.Qty = CType(value, string)
												
						Case "Unitorcontainer"
							Me.str.Unitorcontainer = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "Unitsincontainer"
							Me.str.Unitsincontainer = CType(value, string)
												
						Case "Uom"
							Me.str.Uom = CType(value, string)
												
						Case "Unitcost"
							Me.str.Unitcost = CType(value, string)
												
						Case "Dateneeded"
							Me.str.Dateneeded = CType(value, string)
												
						Case "Vendorid"
							Me.str.Vendorid = CType(value, string)
												
						Case "Customerid"
							Me.str.Customerid = CType(value, string)
												
						Case "Purchasenumber"
							Me.str.Purchasenumber = CType(value, string)
												
						Case "Createdby"
							Me.str.Createdby = CType(value, string)
												
						Case "Createdtime"
							Me.str.Createdtime = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Purchaseitemhistoryid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Purchaseitemhistoryid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Purchaseitemid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Purchaseitemid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Itemid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Itemid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Qty"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Qty = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Unitsincontainer"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Unitsincontainer = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Unitcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Unitcost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Dateneeded"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Dateneeded = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Vendorid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Vendorid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Customerid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Customerid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Purchasenumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Purchasenumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Createdtime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Createdtime = CType(value, Nullable(Of System.DateTime))
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
		' Maps to PURCHASEITEMHISTORY.PURCHASEITEMHISTORYID
		' </summary>
		Public Overridable Property Purchaseitemhistoryid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(PurchaseitemhistoryMetadata.ColumnNames.Purchaseitemhistoryid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(PurchaseitemhistoryMetadata.ColumnNames.Purchaseitemhistoryid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEITEMHISTORY.PURCHASEITEMID
		' </summary>
		Public Overridable Property Purchaseitemid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(PurchaseitemhistoryMetadata.ColumnNames.Purchaseitemid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(PurchaseitemhistoryMetadata.ColumnNames.Purchaseitemid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEITEMHISTORY.PURCHASESTATUS
		' </summary>
		Public Overridable Property Purchasestatus As System.String
			Get
				Return MyBase.GetSystemString(PurchaseitemhistoryMetadata.ColumnNames.Purchasestatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(PurchaseitemhistoryMetadata.ColumnNames.Purchasestatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEITEMHISTORY.PURCHASETYPE
		' </summary>
		Public Overridable Property Purchasetype As System.String
			Get
				Return MyBase.GetSystemString(PurchaseitemhistoryMetadata.ColumnNames.Purchasetype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(PurchaseitemhistoryMetadata.ColumnNames.Purchasetype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEITEMHISTORY.ITEMID
		' </summary>
		Public Overridable Property Itemid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(PurchaseitemhistoryMetadata.ColumnNames.Itemid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(PurchaseitemhistoryMetadata.ColumnNames.Itemid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEITEMHISTORY.ITEMTYPE
		' </summary>
		Public Overridable Property Itemtype As System.String
			Get
				Return MyBase.GetSystemString(PurchaseitemhistoryMetadata.ColumnNames.Itemtype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(PurchaseitemhistoryMetadata.ColumnNames.Itemtype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEITEMHISTORY.ITEMDESCRIPTION
		' </summary>
		Public Overridable Property Itemdescription As System.String
			Get
				Return MyBase.GetSystemString(PurchaseitemhistoryMetadata.ColumnNames.Itemdescription)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(PurchaseitemhistoryMetadata.ColumnNames.Itemdescription, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEITEMHISTORY.QTY
		' </summary>
		Public Overridable Property Qty As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(PurchaseitemhistoryMetadata.ColumnNames.Qty)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(PurchaseitemhistoryMetadata.ColumnNames.Qty, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEITEMHISTORY.UNITORCONTAINER
		' </summary>
		Public Overridable Property Unitorcontainer As System.String
			Get
				Return MyBase.GetSystemString(PurchaseitemhistoryMetadata.ColumnNames.Unitorcontainer)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(PurchaseitemhistoryMetadata.ColumnNames.Unitorcontainer, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEITEMHISTORY.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(PurchaseitemhistoryMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(PurchaseitemhistoryMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEITEMHISTORY.UNITSINCONTAINER
		' </summary>
		Public Overridable Property Unitsincontainer As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(PurchaseitemhistoryMetadata.ColumnNames.Unitsincontainer)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(PurchaseitemhistoryMetadata.ColumnNames.Unitsincontainer, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEITEMHISTORY.UOM
		' </summary>
		Public Overridable Property Uom As System.String
			Get
				Return MyBase.GetSystemString(PurchaseitemhistoryMetadata.ColumnNames.Uom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(PurchaseitemhistoryMetadata.ColumnNames.Uom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEITEMHISTORY.UNITCOST
		' </summary>
		Public Overridable Property Unitcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(PurchaseitemhistoryMetadata.ColumnNames.Unitcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(PurchaseitemhistoryMetadata.ColumnNames.Unitcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEITEMHISTORY.DATENEEDED
		' </summary>
		Public Overridable Property Dateneeded As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(PurchaseitemhistoryMetadata.ColumnNames.Dateneeded)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(PurchaseitemhistoryMetadata.ColumnNames.Dateneeded, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEITEMHISTORY.VENDORID
		' </summary>
		Public Overridable Property Vendorid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(PurchaseitemhistoryMetadata.ColumnNames.Vendorid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(PurchaseitemhistoryMetadata.ColumnNames.Vendorid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEITEMHISTORY.CUSTOMERID
		' </summary>
		Public Overridable Property Customerid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(PurchaseitemhistoryMetadata.ColumnNames.Customerid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(PurchaseitemhistoryMetadata.ColumnNames.Customerid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEITEMHISTORY.PURCHASENUMBER
		' </summary>
		Public Overridable Property Purchasenumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(PurchaseitemhistoryMetadata.ColumnNames.Purchasenumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(PurchaseitemhistoryMetadata.ColumnNames.Purchasenumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEITEMHISTORY.CREATEDBY
		' </summary>
		Public Overridable Property Createdby As System.String
			Get
				Return MyBase.GetSystemString(PurchaseitemhistoryMetadata.ColumnNames.Createdby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(PurchaseitemhistoryMetadata.ColumnNames.Createdby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEITEMHISTORY.CREATEDTIME
		' </summary>
		Public Overridable Property Createdtime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(PurchaseitemhistoryMetadata.ColumnNames.Createdtime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(PurchaseitemhistoryMetadata.ColumnNames.Createdtime, value)
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
		
			Public Sub New(ByVal entity As esPurchaseitemhistory)
				Me.entity = entity
			End Sub				
		
	
			Public Property Purchaseitemhistoryid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Purchaseitemhistoryid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Purchaseitemhistoryid = Nothing
					Else
						entity.Purchaseitemhistoryid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Purchaseitemid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Purchaseitemid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Purchaseitemid = Nothing
					Else
						entity.Purchaseitemid = Convert.ToInt32(Value)
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
		  	
			Public Property Itemdescription As System.String 
				Get
					Dim data_ As System.String = entity.Itemdescription
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Itemdescription = Nothing
					Else
						entity.Itemdescription = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Qty As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Qty
					
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
						entity.Qty = Convert.ToDecimal(Value)
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
		  	
			Public Property Unitsincontainer As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Unitsincontainer
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Unitsincontainer = Nothing
					Else
						entity.Unitsincontainer = Convert.ToInt32(Value)
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
		  	
			Public Property Dateneeded As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Dateneeded
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Dateneeded = Nothing
					Else
						entity.Dateneeded = Convert.ToDateTime(Value)
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
		  	
			Public Property Customerid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Customerid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Customerid = Nothing
					Else
						entity.Customerid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
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
		  

			Private entity As esPurchaseitemhistory
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esPurchaseitemhistoryQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esPurchaseitemhistory can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Purchaseitemhistory 
		Inherits esPurchaseitemhistory
		
	
		
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
	MustInherit Public Class esPurchaseitemhistoryQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return PurchaseitemhistoryMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Purchaseitemhistoryid As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaseitemhistoryMetadata.ColumnNames.Purchaseitemhistoryid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Purchaseitemid As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaseitemhistoryMetadata.ColumnNames.Purchaseitemid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Purchasestatus As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaseitemhistoryMetadata.ColumnNames.Purchasestatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Purchasetype As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaseitemhistoryMetadata.ColumnNames.Purchasetype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Itemid As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaseitemhistoryMetadata.ColumnNames.Itemid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Itemtype As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaseitemhistoryMetadata.ColumnNames.Itemtype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Itemdescription As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaseitemhistoryMetadata.ColumnNames.Itemdescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Qty As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaseitemhistoryMetadata.ColumnNames.Qty, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Unitorcontainer As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaseitemhistoryMetadata.ColumnNames.Unitorcontainer, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaseitemhistoryMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Unitsincontainer As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaseitemhistoryMetadata.ColumnNames.Unitsincontainer, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Uom As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaseitemhistoryMetadata.ColumnNames.Uom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Unitcost As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaseitemhistoryMetadata.ColumnNames.Unitcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Dateneeded As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaseitemhistoryMetadata.ColumnNames.Dateneeded, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Vendorid As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaseitemhistoryMetadata.ColumnNames.Vendorid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Customerid As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaseitemhistoryMetadata.ColumnNames.Customerid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Purchasenumber As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaseitemhistoryMetadata.ColumnNames.Purchasenumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Createdby As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaseitemhistoryMetadata.ColumnNames.Createdby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Createdtime As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaseitemhistoryMetadata.ColumnNames.Createdtime, esSystemType.DateTime)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("PurchaseitemhistoryCollection")> _
	Partial Public Class PurchaseitemhistoryCollection
		Inherits esPurchaseitemhistoryCollection
		Implements IEnumerable(Of Purchaseitemhistory)
		
        Public Shared Widening Operator CType(ByVal coll As PurchaseitemhistoryCollection) As List(Of Purchaseitemhistory)
            Dim list As List(Of Purchaseitemhistory) = New List(Of Purchaseitemhistory)
            Dim emp As Purchaseitemhistory

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return PurchaseitemhistoryMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New PurchaseitemhistoryQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Purchaseitemhistory(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Purchaseitemhistory()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As PurchaseitemhistoryQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New PurchaseitemhistoryQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As PurchaseitemhistoryQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Purchaseitemhistory 
			Return CType(MyBase.AddNewEntity(), Purchaseitemhistory)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal purchaseitemhistoryid As System.Int32) As Purchaseitemhistory
			Return CType(MyBase.FindByPrimaryKey(purchaseitemhistoryid), Purchaseitemhistory)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Purchaseitemhistory) Implements IEnumerable(Of Purchaseitemhistory).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Purchaseitemhistory)(Me)
        End Function
		
		Private _query As PurchaseitemhistoryQuery

	End Class
	


	' <summary>
	' Encapsulates the 'PURCHASEITEMHISTORY' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Purchaseitemhistory ({Purchaseitemhistoryid.Value})")> _
	<Serializable> _
	Partial Public Class Purchaseitemhistory 
		Inherits esPurchaseitemhistory

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return PurchaseitemhistoryMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esPurchaseitemhistoryQuery

			If Me._query Is Nothing Then
				Me._query = New PurchaseitemhistoryQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As PurchaseitemhistoryQuery
			Get

				If Me._query Is Nothing then
					Me._query = New PurchaseitemhistoryQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As PurchaseitemhistoryQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As PurchaseitemhistoryQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class PurchaseitemhistoryQuery
		inherits esPurchaseitemhistoryQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "PurchaseitemhistoryQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class PurchaseitemhistoryMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(PurchaseitemhistoryMetadata.ColumnNames.Purchaseitemhistoryid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = PurchaseitemhistoryMetadata.PropertyNames.Purchaseitemhistoryid
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaseitemhistoryMetadata.ColumnNames.Purchaseitemid, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = PurchaseitemhistoryMetadata.PropertyNames.Purchaseitemid
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaseitemhistoryMetadata.ColumnNames.Purchasestatus, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = PurchaseitemhistoryMetadata.PropertyNames.Purchasestatus
			c.CharacterMaxLength = 50
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaseitemhistoryMetadata.ColumnNames.Purchasetype, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = PurchaseitemhistoryMetadata.PropertyNames.Purchasetype
			c.CharacterMaxLength = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaseitemhistoryMetadata.ColumnNames.Itemid, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = PurchaseitemhistoryMetadata.PropertyNames.Itemid
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaseitemhistoryMetadata.ColumnNames.Itemtype, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = PurchaseitemhistoryMetadata.PropertyNames.Itemtype
			c.CharacterMaxLength = 50
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaseitemhistoryMetadata.ColumnNames.Itemdescription, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = PurchaseitemhistoryMetadata.PropertyNames.Itemdescription
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaseitemhistoryMetadata.ColumnNames.Qty, 7, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = PurchaseitemhistoryMetadata.PropertyNames.Qty
			c.NumericPrecision = 18
			c.NumericScale = 4
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaseitemhistoryMetadata.ColumnNames.Unitorcontainer, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = PurchaseitemhistoryMetadata.PropertyNames.Unitorcontainer
			c.CharacterMaxLength = 1
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaseitemhistoryMetadata.ColumnNames.Container, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = PurchaseitemhistoryMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaseitemhistoryMetadata.ColumnNames.Unitsincontainer, 10, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = PurchaseitemhistoryMetadata.PropertyNames.Unitsincontainer
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaseitemhistoryMetadata.ColumnNames.Uom, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = PurchaseitemhistoryMetadata.PropertyNames.Uom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaseitemhistoryMetadata.ColumnNames.Unitcost, 12, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = PurchaseitemhistoryMetadata.PropertyNames.Unitcost
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaseitemhistoryMetadata.ColumnNames.Dateneeded, 13, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = PurchaseitemhistoryMetadata.PropertyNames.Dateneeded
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaseitemhistoryMetadata.ColumnNames.Vendorid, 14, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = PurchaseitemhistoryMetadata.PropertyNames.Vendorid
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaseitemhistoryMetadata.ColumnNames.Customerid, 15, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = PurchaseitemhistoryMetadata.PropertyNames.Customerid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaseitemhistoryMetadata.ColumnNames.Purchasenumber, 16, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = PurchaseitemhistoryMetadata.PropertyNames.Purchasenumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaseitemhistoryMetadata.ColumnNames.Createdby, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = PurchaseitemhistoryMetadata.PropertyNames.Createdby
			c.CharacterMaxLength = 50
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaseitemhistoryMetadata.ColumnNames.Createdtime, 18, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = PurchaseitemhistoryMetadata.PropertyNames.Createdtime
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As PurchaseitemhistoryMetadata
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
			 Public Const Purchaseitemhistoryid As String = "PURCHASEITEMHISTORYID"
			 Public Const Purchaseitemid As String = "PURCHASEITEMID"
			 Public Const Purchasestatus As String = "PURCHASESTATUS"
			 Public Const Purchasetype As String = "PURCHASETYPE"
			 Public Const Itemid As String = "ITEMID"
			 Public Const Itemtype As String = "ITEMTYPE"
			 Public Const Itemdescription As String = "ITEMDESCRIPTION"
			 Public Const Qty As String = "QTY"
			 Public Const Unitorcontainer As String = "UNITORCONTAINER"
			 Public Const Container As String = "CONTAINER"
			 Public Const Unitsincontainer As String = "UNITSINCONTAINER"
			 Public Const Uom As String = "UOM"
			 Public Const Unitcost As String = "UNITCOST"
			 Public Const Dateneeded As String = "DATENEEDED"
			 Public Const Vendorid As String = "VENDORID"
			 Public Const Customerid As String = "CUSTOMERID"
			 Public Const Purchasenumber As String = "PURCHASENUMBER"
			 Public Const Createdby As String = "CREATEDBY"
			 Public Const Createdtime As String = "CREATEDTIME"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Purchaseitemhistoryid As String = "Purchaseitemhistoryid"
			 Public Const Purchaseitemid As String = "Purchaseitemid"
			 Public Const Purchasestatus As String = "Purchasestatus"
			 Public Const Purchasetype As String = "Purchasetype"
			 Public Const Itemid As String = "Itemid"
			 Public Const Itemtype As String = "Itemtype"
			 Public Const Itemdescription As String = "Itemdescription"
			 Public Const Qty As String = "Qty"
			 Public Const Unitorcontainer As String = "Unitorcontainer"
			 Public Const Container As String = "Container"
			 Public Const Unitsincontainer As String = "Unitsincontainer"
			 Public Const Uom As String = "Uom"
			 Public Const Unitcost As String = "Unitcost"
			 Public Const Dateneeded As String = "Dateneeded"
			 Public Const Vendorid As String = "Vendorid"
			 Public Const Customerid As String = "Customerid"
			 Public Const Purchasenumber As String = "Purchasenumber"
			 Public Const Createdby As String = "Createdby"
			 Public Const Createdtime As String = "Createdtime"
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
            SyncLock GetType(PurchaseitemhistoryMetadata)
			
				If PurchaseitemhistoryMetadata.mapDelegates Is Nothing Then
					PurchaseitemhistoryMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If PurchaseitemhistoryMetadata._meta Is Nothing Then
                    PurchaseitemhistoryMetadata._meta = New PurchaseitemhistoryMetadata()
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
				

				meta.AddTypeMap("Purchaseitemhistoryid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Purchaseitemid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Purchasestatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Purchasetype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Itemid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Itemtype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Itemdescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Qty", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Unitorcontainer", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Unitsincontainer", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Uom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Unitcost", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Dateneeded", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Vendorid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Customerid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Purchasenumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Createdby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Createdtime", new esTypeMap("datetime", "System.DateTime"))			
				
				
				 
				meta.Source = "PURCHASEITEMHISTORY"
				meta.Destination = "PURCHASEITEMHISTORY"
				
				meta.spInsert = "proc_PURCHASEITEMHISTORYInsert"
				meta.spUpdate = "proc_PURCHASEITEMHISTORYUpdate"
				meta.spDelete = "proc_PURCHASEITEMHISTORYDelete"
				meta.spLoadAll = "proc_PURCHASEITEMHISTORYLoadAll"
				meta.spLoadByPrimaryKey = "proc_PURCHASEITEMHISTORYLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As PurchaseitemhistoryMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
