'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/27/2016 9:22:58 PM
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
	MustInherit Public Class esPurchaseitemCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "PurchaseitemCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esPurchaseitemQuery)
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
            Me.InitQuery(CType(query, esPurchaseitemQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Purchaseitem) As Purchaseitem
			Return CType(MyBase.DetachEntity(entity), Purchaseitem)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Purchaseitem) As Purchaseitem
			Return CType(MyBase.AttachEntity(entity), Purchaseitem)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As PurchaseitemCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Purchaseitem
            Get
                Return TryCast(MyBase.Item(index), Purchaseitem)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Purchaseitem)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esPurchaseitem	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esPurchaseitemQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal purchaseitemid As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(purchaseitemid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(purchaseitemid)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal purchaseitemid As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(purchaseitemid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(purchaseitemid)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal purchaseitemid As System.Int32) As Boolean
		
			Dim query As esPurchaseitemQuery = Me.GetDynamicQuery()
			query.Where(query.Purchaseitemid.Equal(purchaseitemid))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal purchaseitemid As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("PURCHASEITEMID", purchaseitemid)
			
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
												
						Case "Purchaseitemid"
							Me.str.Purchaseitemid = CType(value, string)
												
						Case "Purchaseitemtype"
							Me.str.Purchaseitemtype = CType(value, string)
												
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
												
						Case "Purchaseitemstatus"
							Me.str.Purchaseitemstatus = CType(value, string)
												
						Case "Sourcetype"
							Me.str.Sourcetype = CType(value, string)
												
						Case "Sourcedocument"
							Me.str.Sourcedocument = CType(value, string)
												
						Case "Expectedindate"
							Me.str.Expectedindate = CType(value, string)
												
						Case "Notes"
							Me.str.Notes = CType(value, string)
												
						Case "Inventoryclass"
							Me.str.Inventoryclass = CType(value, string)
												
						Case "Vendoritemnumber"
							Me.str.Vendoritemnumber = CType(value, string)
												
						Case "Customerpo"
							Me.str.Customerpo = CType(value, string)
												
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
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Unitsincontainer = CType(value, Nullable(Of System.Decimal))
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
						
						Case "Sourcedocument"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Sourcedocument = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Expectedindate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Expectedindate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Inventoryclass"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Inventoryclass = CType(value, Nullable(Of System.Int32))
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
		' Maps to PURCHASEITEM.PURCHASEITEMID
		' </summary>
		Public Overridable Property Purchaseitemid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(PurchaseitemMetadata.ColumnNames.Purchaseitemid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(PurchaseitemMetadata.ColumnNames.Purchaseitemid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEITEM.PURCHASEITEMTYPE
		' </summary>
		Public Overridable Property Purchaseitemtype As System.String
			Get
				Return MyBase.GetSystemString(PurchaseitemMetadata.ColumnNames.Purchaseitemtype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(PurchaseitemMetadata.ColumnNames.Purchaseitemtype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEITEM.ITEMID
		' </summary>
		Public Overridable Property Itemid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(PurchaseitemMetadata.ColumnNames.Itemid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(PurchaseitemMetadata.ColumnNames.Itemid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEITEM.ITEMTYPE
		' </summary>
		Public Overridable Property Itemtype As System.String
			Get
				Return MyBase.GetSystemString(PurchaseitemMetadata.ColumnNames.Itemtype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(PurchaseitemMetadata.ColumnNames.Itemtype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEITEM.ITEMDESCRIPTION
		' </summary>
		Public Overridable Property Itemdescription As System.String
			Get
				Return MyBase.GetSystemString(PurchaseitemMetadata.ColumnNames.Itemdescription)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(PurchaseitemMetadata.ColumnNames.Itemdescription, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEITEM.QTY
		' </summary>
		Public Overridable Property Qty As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(PurchaseitemMetadata.ColumnNames.Qty)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(PurchaseitemMetadata.ColumnNames.Qty, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEITEM.UNITORCONTAINER
		' </summary>
		Public Overridable Property Unitorcontainer As System.String
			Get
				Return MyBase.GetSystemString(PurchaseitemMetadata.ColumnNames.Unitorcontainer)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(PurchaseitemMetadata.ColumnNames.Unitorcontainer, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEITEM.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(PurchaseitemMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(PurchaseitemMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEITEM.UNITSINCONTAINER
		' </summary>
		Public Overridable Property Unitsincontainer As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(PurchaseitemMetadata.ColumnNames.Unitsincontainer)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(PurchaseitemMetadata.ColumnNames.Unitsincontainer, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEITEM.UOM
		' </summary>
		Public Overridable Property Uom As System.String
			Get
				Return MyBase.GetSystemString(PurchaseitemMetadata.ColumnNames.Uom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(PurchaseitemMetadata.ColumnNames.Uom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEITEM.UNITCOST
		' </summary>
		Public Overridable Property Unitcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(PurchaseitemMetadata.ColumnNames.Unitcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(PurchaseitemMetadata.ColumnNames.Unitcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEITEM.DATENEEDED
		' </summary>
		Public Overridable Property Dateneeded As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(PurchaseitemMetadata.ColumnNames.Dateneeded)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(PurchaseitemMetadata.ColumnNames.Dateneeded, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEITEM.VENDORID
		' </summary>
		Public Overridable Property Vendorid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(PurchaseitemMetadata.ColumnNames.Vendorid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(PurchaseitemMetadata.ColumnNames.Vendorid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEITEM.CUSTOMERID
		' </summary>
		Public Overridable Property Customerid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(PurchaseitemMetadata.ColumnNames.Customerid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(PurchaseitemMetadata.ColumnNames.Customerid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEITEM.PURCHASENUMBER
		' </summary>
		Public Overridable Property Purchasenumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(PurchaseitemMetadata.ColumnNames.Purchasenumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(PurchaseitemMetadata.ColumnNames.Purchasenumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEITEM.PURCHASEITEMSTATUS
		' </summary>
		Public Overridable Property Purchaseitemstatus As System.String
			Get
				Return MyBase.GetSystemString(PurchaseitemMetadata.ColumnNames.Purchaseitemstatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(PurchaseitemMetadata.ColumnNames.Purchaseitemstatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEITEM.SOURCETYPE
		' </summary>
		Public Overridable Property Sourcetype As System.String
			Get
				Return MyBase.GetSystemString(PurchaseitemMetadata.ColumnNames.Sourcetype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(PurchaseitemMetadata.ColumnNames.Sourcetype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEITEM.SOURCEDOCUMENT
		' </summary>
		Public Overridable Property Sourcedocument As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(PurchaseitemMetadata.ColumnNames.Sourcedocument)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(PurchaseitemMetadata.ColumnNames.Sourcedocument, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEITEM.EXPECTEDINDATE
		' </summary>
		Public Overridable Property Expectedindate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(PurchaseitemMetadata.ColumnNames.Expectedindate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(PurchaseitemMetadata.ColumnNames.Expectedindate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEITEM.NOTES
		' </summary>
		Public Overridable Property Notes As System.String
			Get
				Return MyBase.GetSystemString(PurchaseitemMetadata.ColumnNames.Notes)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(PurchaseitemMetadata.ColumnNames.Notes, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEITEM.INVENTORYCLASS
		' </summary>
		Public Overridable Property Inventoryclass As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(PurchaseitemMetadata.ColumnNames.Inventoryclass)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(PurchaseitemMetadata.ColumnNames.Inventoryclass, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEITEM.VENDORITEMNUMBER
		' </summary>
		Public Overridable Property Vendoritemnumber As System.String
			Get
				Return MyBase.GetSystemString(PurchaseitemMetadata.ColumnNames.Vendoritemnumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(PurchaseitemMetadata.ColumnNames.Vendoritemnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEITEM.CUSTOMERPO
		' </summary>
		Public Overridable Property Customerpo As System.String
			Get
				Return MyBase.GetSystemString(PurchaseitemMetadata.ColumnNames.Customerpo)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(PurchaseitemMetadata.ColumnNames.Customerpo, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEITEM.CREATEDBY
		' </summary>
		Public Overridable Property Createdby As System.String
			Get
				Return MyBase.GetSystemString(PurchaseitemMetadata.ColumnNames.Createdby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(PurchaseitemMetadata.ColumnNames.Createdby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEITEM.CREATEDTIME
		' </summary>
		Public Overridable Property Createdtime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(PurchaseitemMetadata.ColumnNames.Createdtime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(PurchaseitemMetadata.ColumnNames.Createdtime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEITEM.MODIFYBY
		' </summary>
		Public Overridable Property Modifyby As System.String
			Get
				Return MyBase.GetSystemString(PurchaseitemMetadata.ColumnNames.Modifyby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(PurchaseitemMetadata.ColumnNames.Modifyby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PURCHASEITEM.MODIFYTIME
		' </summary>
		Public Overridable Property Modifytime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(PurchaseitemMetadata.ColumnNames.Modifytime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(PurchaseitemMetadata.ColumnNames.Modifytime, value)
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
		
			Public Sub New(ByVal entity As esPurchaseitem)
				Me.entity = entity
			End Sub				
		
	
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
		  	
			Public Property Purchaseitemtype As System.String 
				Get
					Dim data_ As System.String = entity.Purchaseitemtype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Purchaseitemtype = Nothing
					Else
						entity.Purchaseitemtype = Convert.ToString(Value)
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
					Dim data_ As Nullable(Of System.Decimal) = entity.Unitsincontainer
					
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
						entity.Unitsincontainer = Convert.ToDecimal(Value)
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
		  	
			Public Property Purchaseitemstatus As System.String 
				Get
					Dim data_ As System.String = entity.Purchaseitemstatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Purchaseitemstatus = Nothing
					Else
						entity.Purchaseitemstatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Sourcetype As System.String 
				Get
					Dim data_ As System.String = entity.Sourcetype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Sourcetype = Nothing
					Else
						entity.Sourcetype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Sourcedocument As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Sourcedocument
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Sourcedocument = Nothing
					Else
						entity.Sourcedocument = Convert.ToInt32(Value)
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
		  	
			Public Property Notes As System.String 
				Get
					Dim data_ As System.String = entity.Notes
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Notes = Nothing
					Else
						entity.Notes = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Inventoryclass As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Inventoryclass
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Inventoryclass = Nothing
					Else
						entity.Inventoryclass = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Vendoritemnumber As System.String 
				Get
					Dim data_ As System.String = entity.Vendoritemnumber
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Vendoritemnumber = Nothing
					Else
						entity.Vendoritemnumber = Convert.ToString(Value)
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
		  

			Private entity As esPurchaseitem
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esPurchaseitemQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esPurchaseitem can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Purchaseitem 
		Inherits esPurchaseitem
		
	
		
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
	MustInherit Public Class esPurchaseitemQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return PurchaseitemMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Purchaseitemid As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaseitemMetadata.ColumnNames.Purchaseitemid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Purchaseitemtype As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaseitemMetadata.ColumnNames.Purchaseitemtype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Itemid As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaseitemMetadata.ColumnNames.Itemid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Itemtype As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaseitemMetadata.ColumnNames.Itemtype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Itemdescription As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaseitemMetadata.ColumnNames.Itemdescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Qty As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaseitemMetadata.ColumnNames.Qty, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Unitorcontainer As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaseitemMetadata.ColumnNames.Unitorcontainer, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaseitemMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Unitsincontainer As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaseitemMetadata.ColumnNames.Unitsincontainer, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Uom As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaseitemMetadata.ColumnNames.Uom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Unitcost As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaseitemMetadata.ColumnNames.Unitcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Dateneeded As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaseitemMetadata.ColumnNames.Dateneeded, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Vendorid As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaseitemMetadata.ColumnNames.Vendorid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Customerid As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaseitemMetadata.ColumnNames.Customerid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Purchasenumber As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaseitemMetadata.ColumnNames.Purchasenumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Purchaseitemstatus As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaseitemMetadata.ColumnNames.Purchaseitemstatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Sourcetype As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaseitemMetadata.ColumnNames.Sourcetype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Sourcedocument As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaseitemMetadata.ColumnNames.Sourcedocument, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Expectedindate As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaseitemMetadata.ColumnNames.Expectedindate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Notes As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaseitemMetadata.ColumnNames.Notes, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Inventoryclass As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaseitemMetadata.ColumnNames.Inventoryclass, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Vendoritemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaseitemMetadata.ColumnNames.Vendoritemnumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Customerpo As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaseitemMetadata.ColumnNames.Customerpo, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Createdby As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaseitemMetadata.ColumnNames.Createdby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Createdtime As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaseitemMetadata.ColumnNames.Createdtime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Modifyby As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaseitemMetadata.ColumnNames.Modifyby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Modifytime As esQueryItem
			Get
				Return New esQueryItem(Me, PurchaseitemMetadata.ColumnNames.Modifytime, esSystemType.DateTime)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("PurchaseitemCollection")> _
	Partial Public Class PurchaseitemCollection
		Inherits esPurchaseitemCollection
		Implements IEnumerable(Of Purchaseitem)
		
        Public Shared Widening Operator CType(ByVal coll As PurchaseitemCollection) As List(Of Purchaseitem)
            Dim list As List(Of Purchaseitem) = New List(Of Purchaseitem)
            Dim emp As Purchaseitem

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return PurchaseitemMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New PurchaseitemQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Purchaseitem(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Purchaseitem()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As PurchaseitemQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New PurchaseitemQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As PurchaseitemQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Purchaseitem 
			Return CType(MyBase.AddNewEntity(), Purchaseitem)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal purchaseitemid As System.Int32) As Purchaseitem
			Return CType(MyBase.FindByPrimaryKey(purchaseitemid), Purchaseitem)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Purchaseitem) Implements IEnumerable(Of Purchaseitem).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Purchaseitem)(Me)
        End Function
		
		Private _query As PurchaseitemQuery

	End Class
	


	' <summary>
	' Encapsulates the 'PURCHASEITEM' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Purchaseitem ({Purchaseitemid.Value})")> _
	<Serializable> _
	Partial Public Class Purchaseitem 
		Inherits esPurchaseitem

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return PurchaseitemMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esPurchaseitemQuery

			If Me._query Is Nothing Then
				Me._query = New PurchaseitemQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As PurchaseitemQuery
			Get

				If Me._query Is Nothing then
					Me._query = New PurchaseitemQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As PurchaseitemQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As PurchaseitemQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class PurchaseitemQuery
		inherits esPurchaseitemQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "PurchaseitemQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class PurchaseitemMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(PurchaseitemMetadata.ColumnNames.Purchaseitemid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = PurchaseitemMetadata.PropertyNames.Purchaseitemid
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaseitemMetadata.ColumnNames.Purchaseitemtype, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = PurchaseitemMetadata.PropertyNames.Purchaseitemtype
			c.CharacterMaxLength = 20
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaseitemMetadata.ColumnNames.Itemid, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = PurchaseitemMetadata.PropertyNames.Itemid
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaseitemMetadata.ColumnNames.Itemtype, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = PurchaseitemMetadata.PropertyNames.Itemtype
			c.CharacterMaxLength = 50
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaseitemMetadata.ColumnNames.Itemdescription, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = PurchaseitemMetadata.PropertyNames.Itemdescription
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaseitemMetadata.ColumnNames.Qty, 5, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = PurchaseitemMetadata.PropertyNames.Qty
			c.NumericPrecision = 18
			c.NumericScale = 4
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaseitemMetadata.ColumnNames.Unitorcontainer, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = PurchaseitemMetadata.PropertyNames.Unitorcontainer
			c.CharacterMaxLength = 1
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaseitemMetadata.ColumnNames.Container, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = PurchaseitemMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaseitemMetadata.ColumnNames.Unitsincontainer, 8, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = PurchaseitemMetadata.PropertyNames.Unitsincontainer
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaseitemMetadata.ColumnNames.Uom, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = PurchaseitemMetadata.PropertyNames.Uom
			c.CharacterMaxLength = 8
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaseitemMetadata.ColumnNames.Unitcost, 10, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = PurchaseitemMetadata.PropertyNames.Unitcost
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaseitemMetadata.ColumnNames.Dateneeded, 11, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = PurchaseitemMetadata.PropertyNames.Dateneeded
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaseitemMetadata.ColumnNames.Vendorid, 12, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = PurchaseitemMetadata.PropertyNames.Vendorid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaseitemMetadata.ColumnNames.Customerid, 13, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = PurchaseitemMetadata.PropertyNames.Customerid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaseitemMetadata.ColumnNames.Purchasenumber, 14, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = PurchaseitemMetadata.PropertyNames.Purchasenumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaseitemMetadata.ColumnNames.Purchaseitemstatus, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = PurchaseitemMetadata.PropertyNames.Purchaseitemstatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaseitemMetadata.ColumnNames.Sourcetype, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = PurchaseitemMetadata.PropertyNames.Sourcetype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaseitemMetadata.ColumnNames.Sourcedocument, 17, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = PurchaseitemMetadata.PropertyNames.Sourcedocument
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaseitemMetadata.ColumnNames.Expectedindate, 18, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = PurchaseitemMetadata.PropertyNames.Expectedindate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaseitemMetadata.ColumnNames.Notes, 19, GetType(System.String), esSystemType.String)	
			c.PropertyName = PurchaseitemMetadata.PropertyNames.Notes
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaseitemMetadata.ColumnNames.Inventoryclass, 20, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = PurchaseitemMetadata.PropertyNames.Inventoryclass
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaseitemMetadata.ColumnNames.Vendoritemnumber, 21, GetType(System.String), esSystemType.String)	
			c.PropertyName = PurchaseitemMetadata.PropertyNames.Vendoritemnumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaseitemMetadata.ColumnNames.Customerpo, 22, GetType(System.String), esSystemType.String)	
			c.PropertyName = PurchaseitemMetadata.PropertyNames.Customerpo
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaseitemMetadata.ColumnNames.Createdby, 23, GetType(System.String), esSystemType.String)	
			c.PropertyName = PurchaseitemMetadata.PropertyNames.Createdby
			c.CharacterMaxLength = 50
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaseitemMetadata.ColumnNames.Createdtime, 24, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = PurchaseitemMetadata.PropertyNames.Createdtime
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaseitemMetadata.ColumnNames.Modifyby, 25, GetType(System.String), esSystemType.String)	
			c.PropertyName = PurchaseitemMetadata.PropertyNames.Modifyby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(PurchaseitemMetadata.ColumnNames.Modifytime, 26, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = PurchaseitemMetadata.PropertyNames.Modifytime
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As PurchaseitemMetadata
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
			 Public Const Purchaseitemid As String = "PURCHASEITEMID"
			 Public Const Purchaseitemtype As String = "PURCHASEITEMTYPE"
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
			 Public Const Purchaseitemstatus As String = "PURCHASEITEMSTATUS"
			 Public Const Sourcetype As String = "SOURCETYPE"
			 Public Const Sourcedocument As String = "SOURCEDOCUMENT"
			 Public Const Expectedindate As String = "EXPECTEDINDATE"
			 Public Const Notes As String = "NOTES"
			 Public Const Inventoryclass As String = "INVENTORYCLASS"
			 Public Const Vendoritemnumber As String = "VENDORITEMNUMBER"
			 Public Const Customerpo As String = "CUSTOMERPO"
			 Public Const Createdby As String = "CREATEDBY"
			 Public Const Createdtime As String = "CREATEDTIME"
			 Public Const Modifyby As String = "MODIFYBY"
			 Public Const Modifytime As String = "MODIFYTIME"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Purchaseitemid As String = "Purchaseitemid"
			 Public Const Purchaseitemtype As String = "Purchaseitemtype"
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
			 Public Const Purchaseitemstatus As String = "Purchaseitemstatus"
			 Public Const Sourcetype As String = "Sourcetype"
			 Public Const Sourcedocument As String = "Sourcedocument"
			 Public Const Expectedindate As String = "Expectedindate"
			 Public Const Notes As String = "Notes"
			 Public Const Inventoryclass As String = "Inventoryclass"
			 Public Const Vendoritemnumber As String = "Vendoritemnumber"
			 Public Const Customerpo As String = "Customerpo"
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
            SyncLock GetType(PurchaseitemMetadata)
			
				If PurchaseitemMetadata.mapDelegates Is Nothing Then
					PurchaseitemMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If PurchaseitemMetadata._meta Is Nothing Then
                    PurchaseitemMetadata._meta = New PurchaseitemMetadata()
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
				

				meta.AddTypeMap("Purchaseitemid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Purchaseitemtype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Itemid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Itemtype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Itemdescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Qty", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Unitorcontainer", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Unitsincontainer", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Uom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Unitcost", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Dateneeded", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Vendorid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Customerid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Purchasenumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Purchaseitemstatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Sourcetype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Sourcedocument", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Expectedindate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Notes", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Inventoryclass", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Vendoritemnumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Customerpo", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Createdby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Createdtime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Modifyby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Modifytime", new esTypeMap("datetime", "System.DateTime"))			
				
				
				 
				meta.Source = "PURCHASEITEM"
				meta.Destination = "PURCHASEITEM"
				
				meta.spInsert = "proc_PURCHASEITEMInsert"
				meta.spUpdate = "proc_PURCHASEITEMUpdate"
				meta.spDelete = "proc_PURCHASEITEMDelete"
				meta.spLoadAll = "proc_PURCHASEITEMLoadAll"
				meta.spLoadByPrimaryKey = "proc_PURCHASEITEMLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As PurchaseitemMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
