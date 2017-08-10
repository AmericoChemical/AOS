'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 4/13/2015 10:10:57 PM
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
	MustInherit Public Class esViewPurchaseItems2Collection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewPurchaseItems2Collection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewPurchaseItems2Query)
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
            Me.InitQuery(CType(query, esViewPurchaseItems2Query))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewPurchaseItems2) As ViewPurchaseItems2
			Return CType(MyBase.DetachEntity(entity), ViewPurchaseItems2)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewPurchaseItems2) As ViewPurchaseItems2
			Return CType(MyBase.AttachEntity(entity), ViewPurchaseItems2)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewPurchaseItems2Collection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewPurchaseItems2
            Get
                Return TryCast(MyBase.Item(index), ViewPurchaseItems2)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewPurchaseItems2)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewPurchaseItems2	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewPurchaseItems2Query
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
												
						Case "Createdtime"
							Me.str.Createdtime = CType(value, string)
												
						Case "Itemtype"
							Me.str.Itemtype = CType(value, string)
												
						Case "Qty"
							Me.str.Qty = CType(value, string)
												
						Case "Unitorcontainer"
							Me.str.Unitorcontainer = CType(value, string)
												
						Case "Itemid"
							Me.str.Itemid = CType(value, string)
												
						Case "Itemdescription"
							Me.str.Itemdescription = CType(value, string)
												
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
												
						Case "Vendorname"
							Me.str.Vendorname = CType(value, string)
												
						Case "Sourcetype"
							Me.str.Sourcetype = CType(value, string)
												
						Case "Sourcedocument"
							Me.str.Sourcedocument = CType(value, string)
												
						Case "Custname"
							Me.str.Custname = CType(value, string)
												
						Case "Purchaseitemstatus"
							Me.str.Purchaseitemstatus = CType(value, string)
												
						Case "Purchaseitemtype"
							Me.str.Purchaseitemtype = CType(value, string)
												
						Case "Purchaseitemid"
							Me.str.Purchaseitemid = CType(value, string)
												
						Case "Purchasenumber"
							Me.str.Purchasenumber = CType(value, string)
												
						Case "Expectedindate"
							Me.str.Expectedindate = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Createdtime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Createdtime = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Qty"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Qty = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Itemid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Itemid = CType(value, Nullable(Of System.Int32))
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
						
						Case "Sourcedocument"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Sourcedocument = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Purchaseitemid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Purchaseitemid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Purchasenumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Purchasenumber = CType(value, Nullable(Of System.Int32))
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
		' Maps to viewPurchaseItems2.CREATEDTIME
		' </summary>
		Public Overridable Property Createdtime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewPurchaseItems2Metadata.ColumnNames.Createdtime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewPurchaseItems2Metadata.ColumnNames.Createdtime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseItems2.ITEMTYPE
		' </summary>
		Public Overridable Property Itemtype As System.String
			Get
				Return MyBase.GetSystemString(ViewPurchaseItems2Metadata.ColumnNames.Itemtype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPurchaseItems2Metadata.ColumnNames.Itemtype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseItems2.QTY
		' </summary>
		Public Overridable Property Qty As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewPurchaseItems2Metadata.ColumnNames.Qty)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewPurchaseItems2Metadata.ColumnNames.Qty, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseItems2.UNITORCONTAINER
		' </summary>
		Public Overridable Property Unitorcontainer As System.String
			Get
				Return MyBase.GetSystemString(ViewPurchaseItems2Metadata.ColumnNames.Unitorcontainer)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPurchaseItems2Metadata.ColumnNames.Unitorcontainer, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseItems2.ITEMID
		' </summary>
		Public Overridable Property Itemid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewPurchaseItems2Metadata.ColumnNames.Itemid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewPurchaseItems2Metadata.ColumnNames.Itemid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseItems2.ITEMDESCRIPTION
		' </summary>
		Public Overridable Property Itemdescription As System.String
			Get
				Return MyBase.GetSystemString(ViewPurchaseItems2Metadata.ColumnNames.Itemdescription)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPurchaseItems2Metadata.ColumnNames.Itemdescription, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseItems2.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewPurchaseItems2Metadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPurchaseItems2Metadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseItems2.UNITSINCONTAINER
		' </summary>
		Public Overridable Property Unitsincontainer As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewPurchaseItems2Metadata.ColumnNames.Unitsincontainer)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewPurchaseItems2Metadata.ColumnNames.Unitsincontainer, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseItems2.UOM
		' </summary>
		Public Overridable Property Uom As System.String
			Get
				Return MyBase.GetSystemString(ViewPurchaseItems2Metadata.ColumnNames.Uom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPurchaseItems2Metadata.ColumnNames.Uom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseItems2.UNITCOST
		' </summary>
		Public Overridable Property Unitcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewPurchaseItems2Metadata.ColumnNames.Unitcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewPurchaseItems2Metadata.ColumnNames.Unitcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseItems2.DATENEEDED
		' </summary>
		Public Overridable Property Dateneeded As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewPurchaseItems2Metadata.ColumnNames.Dateneeded)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewPurchaseItems2Metadata.ColumnNames.Dateneeded, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseItems2.VENDORNAME
		' </summary>
		Public Overridable Property Vendorname As System.String
			Get
				Return MyBase.GetSystemString(ViewPurchaseItems2Metadata.ColumnNames.Vendorname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPurchaseItems2Metadata.ColumnNames.Vendorname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseItems2.SOURCETYPE
		' </summary>
		Public Overridable Property Sourcetype As System.String
			Get
				Return MyBase.GetSystemString(ViewPurchaseItems2Metadata.ColumnNames.Sourcetype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPurchaseItems2Metadata.ColumnNames.Sourcetype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseItems2.SOURCEDOCUMENT
		' </summary>
		Public Overridable Property Sourcedocument As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewPurchaseItems2Metadata.ColumnNames.Sourcedocument)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewPurchaseItems2Metadata.ColumnNames.Sourcedocument, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseItems2.CUSTNAME
		' </summary>
		Public Overridable Property Custname As System.String
			Get
				Return MyBase.GetSystemString(ViewPurchaseItems2Metadata.ColumnNames.Custname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPurchaseItems2Metadata.ColumnNames.Custname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseItems2.PURCHASEITEMSTATUS
		' </summary>
		Public Overridable Property Purchaseitemstatus As System.String
			Get
				Return MyBase.GetSystemString(ViewPurchaseItems2Metadata.ColumnNames.Purchaseitemstatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPurchaseItems2Metadata.ColumnNames.Purchaseitemstatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseItems2.PURCHASEITEMTYPE
		' </summary>
		Public Overridable Property Purchaseitemtype As System.String
			Get
				Return MyBase.GetSystemString(ViewPurchaseItems2Metadata.ColumnNames.Purchaseitemtype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPurchaseItems2Metadata.ColumnNames.Purchaseitemtype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseItems2.PURCHASEITEMID
		' </summary>
		Public Overridable Property Purchaseitemid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewPurchaseItems2Metadata.ColumnNames.Purchaseitemid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewPurchaseItems2Metadata.ColumnNames.Purchaseitemid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseItems2.PURCHASENUMBER
		' </summary>
		Public Overridable Property Purchasenumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewPurchaseItems2Metadata.ColumnNames.Purchasenumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewPurchaseItems2Metadata.ColumnNames.Purchasenumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewPurchaseItems2.EXPECTEDINDATE
		' </summary>
		Public Overridable Property Expectedindate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewPurchaseItems2Metadata.ColumnNames.Expectedindate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewPurchaseItems2Metadata.ColumnNames.Expectedindate, value)
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
		
			Public Sub New(ByVal entity As esViewPurchaseItems2)
				Me.entity = entity
			End Sub				
		
	
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
		  

			Private entity As esViewPurchaseItems2
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewPurchaseItems2Query)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewPurchaseItems2 can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewPurchaseItems2Query 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewPurchaseItems2Metadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Createdtime As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseItems2Metadata.ColumnNames.Createdtime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Itemtype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseItems2Metadata.ColumnNames.Itemtype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Qty As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseItems2Metadata.ColumnNames.Qty, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Unitorcontainer As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseItems2Metadata.ColumnNames.Unitorcontainer, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Itemid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseItems2Metadata.ColumnNames.Itemid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Itemdescription As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseItems2Metadata.ColumnNames.Itemdescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseItems2Metadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Unitsincontainer As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseItems2Metadata.ColumnNames.Unitsincontainer, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Uom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseItems2Metadata.ColumnNames.Uom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Unitcost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseItems2Metadata.ColumnNames.Unitcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Dateneeded As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseItems2Metadata.ColumnNames.Dateneeded, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Vendorname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseItems2Metadata.ColumnNames.Vendorname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Sourcetype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseItems2Metadata.ColumnNames.Sourcetype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Sourcedocument As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseItems2Metadata.ColumnNames.Sourcedocument, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Custname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseItems2Metadata.ColumnNames.Custname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Purchaseitemstatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseItems2Metadata.ColumnNames.Purchaseitemstatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Purchaseitemtype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseItems2Metadata.ColumnNames.Purchaseitemtype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Purchaseitemid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseItems2Metadata.ColumnNames.Purchaseitemid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Purchasenumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseItems2Metadata.ColumnNames.Purchasenumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Expectedindate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPurchaseItems2Metadata.ColumnNames.Expectedindate, esSystemType.DateTime)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewPurchaseItems2Collection")> _
	Partial Public Class ViewPurchaseItems2Collection
		Inherits esViewPurchaseItems2Collection
		Implements IEnumerable(Of ViewPurchaseItems2)
		
        Public Shared Widening Operator CType(ByVal coll As ViewPurchaseItems2Collection) As List(Of ViewPurchaseItems2)
            Dim list As List(Of ViewPurchaseItems2) = New List(Of ViewPurchaseItems2)
            Dim emp As ViewPurchaseItems2

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewPurchaseItems2Metadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewPurchaseItems2Query()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewPurchaseItems2(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewPurchaseItems2()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewPurchaseItems2Query 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewPurchaseItems2Query()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewPurchaseItems2Query) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewPurchaseItems2 
			Return CType(MyBase.AddNewEntity(), ViewPurchaseItems2)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewPurchaseItems2) Implements IEnumerable(Of ViewPurchaseItems2).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewPurchaseItems2)(Me)
        End Function
		
		Private _query As ViewPurchaseItems2Query

	End Class
	


	' <summary>
	' Encapsulates the 'viewPurchaseItems2' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewPurchaseItems2 ()")> _
	<Serializable> _
	Partial Public Class ViewPurchaseItems2 
		Inherits esViewPurchaseItems2

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewPurchaseItems2Metadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewPurchaseItems2Query

			If Me._query Is Nothing Then
				Me._query = New ViewPurchaseItems2Query()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewPurchaseItems2Query
			Get

				If Me._query Is Nothing then
					Me._query = New ViewPurchaseItems2Query()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewPurchaseItems2Query) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewPurchaseItems2Query

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewPurchaseItems2Query
		inherits esViewPurchaseItems2Query
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewPurchaseItems2Query"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewPurchaseItems2Metadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewPurchaseItems2Metadata.ColumnNames.Createdtime, 0, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewPurchaseItems2Metadata.PropertyNames.Createdtime
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseItems2Metadata.ColumnNames.Itemtype, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPurchaseItems2Metadata.PropertyNames.Itemtype
			c.CharacterMaxLength = 50
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseItems2Metadata.ColumnNames.Qty, 2, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewPurchaseItems2Metadata.PropertyNames.Qty
			c.NumericPrecision = 18
			c.NumericScale = 4
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseItems2Metadata.ColumnNames.Unitorcontainer, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPurchaseItems2Metadata.PropertyNames.Unitorcontainer
			c.CharacterMaxLength = 1
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseItems2Metadata.ColumnNames.Itemid, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewPurchaseItems2Metadata.PropertyNames.Itemid
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseItems2Metadata.ColumnNames.Itemdescription, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPurchaseItems2Metadata.PropertyNames.Itemdescription
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseItems2Metadata.ColumnNames.Container, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPurchaseItems2Metadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseItems2Metadata.ColumnNames.Unitsincontainer, 7, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewPurchaseItems2Metadata.PropertyNames.Unitsincontainer
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseItems2Metadata.ColumnNames.Uom, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPurchaseItems2Metadata.PropertyNames.Uom
			c.CharacterMaxLength = 8
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseItems2Metadata.ColumnNames.Unitcost, 9, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewPurchaseItems2Metadata.PropertyNames.Unitcost
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseItems2Metadata.ColumnNames.Dateneeded, 10, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewPurchaseItems2Metadata.PropertyNames.Dateneeded
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseItems2Metadata.ColumnNames.Vendorname, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPurchaseItems2Metadata.PropertyNames.Vendorname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseItems2Metadata.ColumnNames.Sourcetype, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPurchaseItems2Metadata.PropertyNames.Sourcetype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseItems2Metadata.ColumnNames.Sourcedocument, 13, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewPurchaseItems2Metadata.PropertyNames.Sourcedocument
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseItems2Metadata.ColumnNames.Custname, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPurchaseItems2Metadata.PropertyNames.Custname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseItems2Metadata.ColumnNames.Purchaseitemstatus, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPurchaseItems2Metadata.PropertyNames.Purchaseitemstatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseItems2Metadata.ColumnNames.Purchaseitemtype, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPurchaseItems2Metadata.PropertyNames.Purchaseitemtype
			c.CharacterMaxLength = 20
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseItems2Metadata.ColumnNames.Purchaseitemid, 17, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewPurchaseItems2Metadata.PropertyNames.Purchaseitemid
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseItems2Metadata.ColumnNames.Purchasenumber, 18, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewPurchaseItems2Metadata.PropertyNames.Purchasenumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewPurchaseItems2Metadata.ColumnNames.Expectedindate, 19, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewPurchaseItems2Metadata.PropertyNames.Expectedindate
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewPurchaseItems2Metadata
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
			 Public Const Createdtime As String = "CREATEDTIME"
			 Public Const Itemtype As String = "ITEMTYPE"
			 Public Const Qty As String = "QTY"
			 Public Const Unitorcontainer As String = "UNITORCONTAINER"
			 Public Const Itemid As String = "ITEMID"
			 Public Const Itemdescription As String = "ITEMDESCRIPTION"
			 Public Const Container As String = "CONTAINER"
			 Public Const Unitsincontainer As String = "UNITSINCONTAINER"
			 Public Const Uom As String = "UOM"
			 Public Const Unitcost As String = "UNITCOST"
			 Public Const Dateneeded As String = "DATENEEDED"
			 Public Const Vendorname As String = "VENDORNAME"
			 Public Const Sourcetype As String = "SOURCETYPE"
			 Public Const Sourcedocument As String = "SOURCEDOCUMENT"
			 Public Const Custname As String = "CUSTNAME"
			 Public Const Purchaseitemstatus As String = "PURCHASEITEMSTATUS"
			 Public Const Purchaseitemtype As String = "PURCHASEITEMTYPE"
			 Public Const Purchaseitemid As String = "PURCHASEITEMID"
			 Public Const Purchasenumber As String = "PURCHASENUMBER"
			 Public Const Expectedindate As String = "EXPECTEDINDATE"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Createdtime As String = "Createdtime"
			 Public Const Itemtype As String = "Itemtype"
			 Public Const Qty As String = "Qty"
			 Public Const Unitorcontainer As String = "Unitorcontainer"
			 Public Const Itemid As String = "Itemid"
			 Public Const Itemdescription As String = "Itemdescription"
			 Public Const Container As String = "Container"
			 Public Const Unitsincontainer As String = "Unitsincontainer"
			 Public Const Uom As String = "Uom"
			 Public Const Unitcost As String = "Unitcost"
			 Public Const Dateneeded As String = "Dateneeded"
			 Public Const Vendorname As String = "Vendorname"
			 Public Const Sourcetype As String = "Sourcetype"
			 Public Const Sourcedocument As String = "Sourcedocument"
			 Public Const Custname As String = "Custname"
			 Public Const Purchaseitemstatus As String = "Purchaseitemstatus"
			 Public Const Purchaseitemtype As String = "Purchaseitemtype"
			 Public Const Purchaseitemid As String = "Purchaseitemid"
			 Public Const Purchasenumber As String = "Purchasenumber"
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
            SyncLock GetType(ViewPurchaseItems2Metadata)
			
				If ViewPurchaseItems2Metadata.mapDelegates Is Nothing Then
					ViewPurchaseItems2Metadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewPurchaseItems2Metadata._meta Is Nothing Then
                    ViewPurchaseItems2Metadata._meta = New ViewPurchaseItems2Metadata()
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
				

				meta.AddTypeMap("Createdtime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Itemtype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Qty", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Unitorcontainer", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Itemid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Itemdescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Unitsincontainer", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Uom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Unitcost", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Dateneeded", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Vendorname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Sourcetype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Sourcedocument", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Custname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Purchaseitemstatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Purchaseitemtype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Purchaseitemid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Purchasenumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Expectedindate", new esTypeMap("datetime", "System.DateTime"))			
				
				
				 
				meta.Source = "viewPurchaseItems2"
				meta.Destination = "viewPurchaseItems2"
				
				meta.spInsert = "proc_viewPurchaseItems2Insert"
				meta.spUpdate = "proc_viewPurchaseItems2Update"
				meta.spDelete = "proc_viewPurchaseItems2Delete"
				meta.spLoadAll = "proc_viewPurchaseItems2LoadAll"
				meta.spLoadByPrimaryKey = "proc_viewPurchaseItems2LoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewPurchaseItems2Metadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
