'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 3/4/2016 8:09:03 AM
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
	MustInherit Public Class esViewInvItemListCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewInvItemListCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewInvItemListQuery)
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
            Me.InitQuery(CType(query, esViewInvItemListQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewInvItemList) As ViewInvItemList
			Return CType(MyBase.DetachEntity(entity), ViewInvItemList)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewInvItemList) As ViewInvItemList
			Return CType(MyBase.AttachEntity(entity), ViewInvItemList)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewInvItemListCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewInvItemList
            Get
                Return TryCast(MyBase.Item(index), ViewInvItemList)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewInvItemList)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewInvItemList	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewInvItemListQuery
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
												
						Case "Invitemnumber"
							Me.str.Invitemnumber = CType(value, string)
												
						Case "Sourcedocument"
							Me.str.Sourcedocument = CType(value, string)
												
						Case "Itemtype"
							Me.str.Itemtype = CType(value, string)
												
						Case "Itemid"
							Me.str.Itemid = CType(value, string)
												
						Case "Itemdescription"
							Me.str.Itemdescription = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "Lotnumber"
							Me.str.Lotnumber = CType(value, string)
												
						Case "Unitsremainingweight"
							Me.str.Unitsremainingweight = CType(value, string)
												
						Case "Rcvdweight"
							Me.str.Rcvdweight = CType(value, string)
												
						Case "Vendorweight"
							Me.str.Vendorweight = CType(value, string)
												
						Case "Unitsremaining"
							Me.str.Unitsremaining = CType(value, string)
												
						Case "Uom"
							Me.str.Uom = CType(value, string)
												
						Case "Itemstatus"
							Me.str.Itemstatus = CType(value, string)
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Purchasenumber"
							Me.str.Purchasenumber = CType(value, string)
												
						Case "CheckMark"
							Me.str.CheckMark = CType(value, string)
												
						Case "Sourcestatus"
							Me.str.Sourcestatus = CType(value, string)
												
						Case "LookupDesc"
							Me.str.LookupDesc = CType(value, string)
												
						Case "Purchaseitemstatus"
							Me.str.Purchaseitemstatus = CType(value, string)
												
						Case "Inventoryclass"
							Me.str.Inventoryclass = CType(value, string)
												
						Case "Sourcetype"
							Me.str.Sourcetype = CType(value, string)
												
						Case "Allocateddocument"
							Me.str.Allocateddocument = CType(value, string)
												
						Case "Allocatedtype"
							Me.str.Allocatedtype = CType(value, string)
												
						Case "Expectedindate"
							Me.str.Expectedindate = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Invitemnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Invitemnumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Sourcedocument"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Sourcedocument = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Itemid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Itemid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Unitsremainingweight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Unitsremainingweight = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Rcvdweight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Rcvdweight = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Vendorweight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Vendorweight = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Unitsremaining"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Unitsremaining = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Purchasenumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Purchasenumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "CheckMark"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.CheckMark = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Inventoryclass"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Inventoryclass = CType(value, Nullable(Of System.Int32))
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
		' Maps to viewInvItemList.INVITEMNUMBER
		' </summary>
		Public Overridable Property Invitemnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewInvItemListMetadata.ColumnNames.Invitemnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewInvItemListMetadata.ColumnNames.Invitemnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemList.SOURCEDOCUMENT
		' </summary>
		Public Overridable Property Sourcedocument As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewInvItemListMetadata.ColumnNames.Sourcedocument)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewInvItemListMetadata.ColumnNames.Sourcedocument, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemList.ITEMTYPE
		' </summary>
		Public Overridable Property Itemtype As System.String
			Get
				Return MyBase.GetSystemString(ViewInvItemListMetadata.ColumnNames.Itemtype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewInvItemListMetadata.ColumnNames.Itemtype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemList.ITEMID
		' </summary>
		Public Overridable Property Itemid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewInvItemListMetadata.ColumnNames.Itemid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewInvItemListMetadata.ColumnNames.Itemid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemList.ITEMDESCRIPTION
		' </summary>
		Public Overridable Property Itemdescription As System.String
			Get
				Return MyBase.GetSystemString(ViewInvItemListMetadata.ColumnNames.Itemdescription)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewInvItemListMetadata.ColumnNames.Itemdescription, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemList.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewInvItemListMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewInvItemListMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemList.LOTNUMBER
		' </summary>
		Public Overridable Property Lotnumber As System.String
			Get
				Return MyBase.GetSystemString(ViewInvItemListMetadata.ColumnNames.Lotnumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewInvItemListMetadata.ColumnNames.Lotnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemList.UNITSREMAININGWEIGHT
		' </summary>
		Public Overridable Property Unitsremainingweight As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewInvItemListMetadata.ColumnNames.Unitsremainingweight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewInvItemListMetadata.ColumnNames.Unitsremainingweight, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemList.RCVDWEIGHT
		' </summary>
		Public Overridable Property Rcvdweight As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewInvItemListMetadata.ColumnNames.Rcvdweight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewInvItemListMetadata.ColumnNames.Rcvdweight, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemList.VENDORWEIGHT
		' </summary>
		Public Overridable Property Vendorweight As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewInvItemListMetadata.ColumnNames.Vendorweight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewInvItemListMetadata.ColumnNames.Vendorweight, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemList.UNITSREMAINING
		' </summary>
		Public Overridable Property Unitsremaining As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewInvItemListMetadata.ColumnNames.Unitsremaining)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewInvItemListMetadata.ColumnNames.Unitsremaining, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemList.UOM
		' </summary>
		Public Overridable Property Uom As System.String
			Get
				Return MyBase.GetSystemString(ViewInvItemListMetadata.ColumnNames.Uom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewInvItemListMetadata.ColumnNames.Uom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemList.ITEMSTATUS
		' </summary>
		Public Overridable Property Itemstatus As System.String
			Get
				Return MyBase.GetSystemString(ViewInvItemListMetadata.ColumnNames.Itemstatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewInvItemListMetadata.ColumnNames.Itemstatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemList.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewInvItemListMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewInvItemListMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemList.PURCHASENUMBER
		' </summary>
		Public Overridable Property Purchasenumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewInvItemListMetadata.ColumnNames.Purchasenumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewInvItemListMetadata.ColumnNames.Purchasenumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemList.CheckMark
		' </summary>
		Public Overridable Property CheckMark As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewInvItemListMetadata.ColumnNames.CheckMark)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewInvItemListMetadata.ColumnNames.CheckMark, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemList.SOURCESTATUS
		' </summary>
		Public Overridable Property Sourcestatus As System.String
			Get
				Return MyBase.GetSystemString(ViewInvItemListMetadata.ColumnNames.Sourcestatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewInvItemListMetadata.ColumnNames.Sourcestatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemList.LookupDesc
		' </summary>
		Public Overridable Property LookupDesc As System.String
			Get
				Return MyBase.GetSystemString(ViewInvItemListMetadata.ColumnNames.LookupDesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewInvItemListMetadata.ColumnNames.LookupDesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemList.PURCHASEITEMSTATUS
		' </summary>
		Public Overridable Property Purchaseitemstatus As System.String
			Get
				Return MyBase.GetSystemString(ViewInvItemListMetadata.ColumnNames.Purchaseitemstatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewInvItemListMetadata.ColumnNames.Purchaseitemstatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemList.INVENTORYCLASS
		' </summary>
		Public Overridable Property Inventoryclass As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewInvItemListMetadata.ColumnNames.Inventoryclass)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewInvItemListMetadata.ColumnNames.Inventoryclass, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemList.SOURCETYPE
		' </summary>
		Public Overridable Property Sourcetype As System.String
			Get
				Return MyBase.GetSystemString(ViewInvItemListMetadata.ColumnNames.Sourcetype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewInvItemListMetadata.ColumnNames.Sourcetype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemList.ALLOCATEDDOCUMENT
		' </summary>
		Public Overridable Property Allocateddocument As System.String
			Get
				Return MyBase.GetSystemString(ViewInvItemListMetadata.ColumnNames.Allocateddocument)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewInvItemListMetadata.ColumnNames.Allocateddocument, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemList.ALLOCATEDTYPE
		' </summary>
		Public Overridable Property Allocatedtype As System.String
			Get
				Return MyBase.GetSystemString(ViewInvItemListMetadata.ColumnNames.Allocatedtype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewInvItemListMetadata.ColumnNames.Allocatedtype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemList.EXPECTEDINDATE
		' </summary>
		Public Overridable Property Expectedindate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewInvItemListMetadata.ColumnNames.Expectedindate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewInvItemListMetadata.ColumnNames.Expectedindate, value)
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
		
			Public Sub New(ByVal entity As esViewInvItemList)
				Me.entity = entity
			End Sub				
		
	
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
		  	
			Public Property Unitsremainingweight As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Unitsremainingweight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Unitsremainingweight = Nothing
					Else
						entity.Unitsremainingweight = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Rcvdweight As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Rcvdweight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Rcvdweight = Nothing
					Else
						entity.Rcvdweight = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Vendorweight As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Vendorweight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Vendorweight = Nothing
					Else
						entity.Vendorweight = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Unitsremaining As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Unitsremaining
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Unitsremaining = Nothing
					Else
						entity.Unitsremaining = Convert.ToDecimal(Value)
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
		  	
			Public Property Itemstatus As System.String 
				Get
					Dim data_ As System.String = entity.Itemstatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Itemstatus = Nothing
					Else
						entity.Itemstatus = Convert.ToString(Value)
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
		  	
			Public Property CheckMark As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.CheckMark
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CheckMark = Nothing
					Else
						entity.CheckMark = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property Sourcestatus As System.String 
				Get
					Dim data_ As System.String = entity.Sourcestatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Sourcestatus = Nothing
					Else
						entity.Sourcestatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property LookupDesc As System.String 
				Get
					Dim data_ As System.String = entity.LookupDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LookupDesc = Nothing
					Else
						entity.LookupDesc = Convert.ToString(Value)
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
		  	
			Public Property Allocateddocument As System.String 
				Get
					Dim data_ As System.String = entity.Allocateddocument
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Allocateddocument = Nothing
					Else
						entity.Allocateddocument = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Allocatedtype As System.String 
				Get
					Dim data_ As System.String = entity.Allocatedtype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Allocatedtype = Nothing
					Else
						entity.Allocatedtype = Convert.ToString(Value)
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
		  

			Private entity As esViewInvItemList
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewInvItemListQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewInvItemList can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewInvItemListQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewInvItemListMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Invitemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemListMetadata.ColumnNames.Invitemnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Sourcedocument As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemListMetadata.ColumnNames.Sourcedocument, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Itemtype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemListMetadata.ColumnNames.Itemtype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Itemid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemListMetadata.ColumnNames.Itemid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Itemdescription As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemListMetadata.ColumnNames.Itemdescription, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemListMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Lotnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemListMetadata.ColumnNames.Lotnumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Unitsremainingweight As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemListMetadata.ColumnNames.Unitsremainingweight, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Rcvdweight As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemListMetadata.ColumnNames.Rcvdweight, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Vendorweight As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemListMetadata.ColumnNames.Vendorweight, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Unitsremaining As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemListMetadata.ColumnNames.Unitsremaining, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Uom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemListMetadata.ColumnNames.Uom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Itemstatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemListMetadata.ColumnNames.Itemstatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemListMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Purchasenumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemListMetadata.ColumnNames.Purchasenumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property CheckMark As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemListMetadata.ColumnNames.CheckMark, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Sourcestatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemListMetadata.ColumnNames.Sourcestatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LookupDesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemListMetadata.ColumnNames.LookupDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Purchaseitemstatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemListMetadata.ColumnNames.Purchaseitemstatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Inventoryclass As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemListMetadata.ColumnNames.Inventoryclass, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Sourcetype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemListMetadata.ColumnNames.Sourcetype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Allocateddocument As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemListMetadata.ColumnNames.Allocateddocument, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Allocatedtype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemListMetadata.ColumnNames.Allocatedtype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Expectedindate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemListMetadata.ColumnNames.Expectedindate, esSystemType.DateTime)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewInvItemListCollection")> _
	Partial Public Class ViewInvItemListCollection
		Inherits esViewInvItemListCollection
		Implements IEnumerable(Of ViewInvItemList)
		
        Public Shared Widening Operator CType(ByVal coll As ViewInvItemListCollection) As List(Of ViewInvItemList)
            Dim list As List(Of ViewInvItemList) = New List(Of ViewInvItemList)
            Dim emp As ViewInvItemList

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewInvItemListMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewInvItemListQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewInvItemList(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewInvItemList()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewInvItemListQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewInvItemListQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewInvItemListQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewInvItemList 
			Return CType(MyBase.AddNewEntity(), ViewInvItemList)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewInvItemList) Implements IEnumerable(Of ViewInvItemList).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewInvItemList)(Me)
        End Function
		
		Private _query As ViewInvItemListQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewInvItemList' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewInvItemList ()")> _
	<Serializable> _
	Partial Public Class ViewInvItemList 
		Inherits esViewInvItemList

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewInvItemListMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewInvItemListQuery

			If Me._query Is Nothing Then
				Me._query = New ViewInvItemListQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewInvItemListQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewInvItemListQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewInvItemListQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewInvItemListQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewInvItemListQuery
		inherits esViewInvItemListQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewInvItemListQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewInvItemListMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewInvItemListMetadata.ColumnNames.Invitemnumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewInvItemListMetadata.PropertyNames.Invitemnumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemListMetadata.ColumnNames.Sourcedocument, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewInvItemListMetadata.PropertyNames.Sourcedocument
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemListMetadata.ColumnNames.Itemtype, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewInvItemListMetadata.PropertyNames.Itemtype
			c.CharacterMaxLength = 50
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemListMetadata.ColumnNames.Itemid, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewInvItemListMetadata.PropertyNames.Itemid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemListMetadata.ColumnNames.Itemdescription, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewInvItemListMetadata.PropertyNames.Itemdescription
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemListMetadata.ColumnNames.Container, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewInvItemListMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemListMetadata.ColumnNames.Lotnumber, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewInvItemListMetadata.PropertyNames.Lotnumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemListMetadata.ColumnNames.Unitsremainingweight, 7, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewInvItemListMetadata.PropertyNames.Unitsremainingweight
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemListMetadata.ColumnNames.Rcvdweight, 8, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewInvItemListMetadata.PropertyNames.Rcvdweight
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemListMetadata.ColumnNames.Vendorweight, 9, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewInvItemListMetadata.PropertyNames.Vendorweight
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemListMetadata.ColumnNames.Unitsremaining, 10, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewInvItemListMetadata.PropertyNames.Unitsremaining
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemListMetadata.ColumnNames.Uom, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewInvItemListMetadata.PropertyNames.Uom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemListMetadata.ColumnNames.Itemstatus, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewInvItemListMetadata.PropertyNames.Itemstatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemListMetadata.ColumnNames.Productid, 13, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewInvItemListMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemListMetadata.ColumnNames.Purchasenumber, 14, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewInvItemListMetadata.PropertyNames.Purchasenumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemListMetadata.ColumnNames.CheckMark, 15, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewInvItemListMetadata.PropertyNames.CheckMark
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemListMetadata.ColumnNames.Sourcestatus, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewInvItemListMetadata.PropertyNames.Sourcestatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemListMetadata.ColumnNames.LookupDesc, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewInvItemListMetadata.PropertyNames.LookupDesc
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemListMetadata.ColumnNames.Purchaseitemstatus, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewInvItemListMetadata.PropertyNames.Purchaseitemstatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemListMetadata.ColumnNames.Inventoryclass, 19, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewInvItemListMetadata.PropertyNames.Inventoryclass
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemListMetadata.ColumnNames.Sourcetype, 20, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewInvItemListMetadata.PropertyNames.Sourcetype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemListMetadata.ColumnNames.Allocateddocument, 21, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewInvItemListMetadata.PropertyNames.Allocateddocument
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemListMetadata.ColumnNames.Allocatedtype, 22, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewInvItemListMetadata.PropertyNames.Allocatedtype
			c.CharacterMaxLength = 15
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemListMetadata.ColumnNames.Expectedindate, 23, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewInvItemListMetadata.PropertyNames.Expectedindate
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewInvItemListMetadata
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
			 Public Const Invitemnumber As String = "INVITEMNUMBER"
			 Public Const Sourcedocument As String = "SOURCEDOCUMENT"
			 Public Const Itemtype As String = "ITEMTYPE"
			 Public Const Itemid As String = "ITEMID"
			 Public Const Itemdescription As String = "ITEMDESCRIPTION"
			 Public Const Container As String = "CONTAINER"
			 Public Const Lotnumber As String = "LOTNUMBER"
			 Public Const Unitsremainingweight As String = "UNITSREMAININGWEIGHT"
			 Public Const Rcvdweight As String = "RCVDWEIGHT"
			 Public Const Vendorweight As String = "VENDORWEIGHT"
			 Public Const Unitsremaining As String = "UNITSREMAINING"
			 Public Const Uom As String = "UOM"
			 Public Const Itemstatus As String = "ITEMSTATUS"
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Purchasenumber As String = "PURCHASENUMBER"
			 Public Const CheckMark As String = "CheckMark"
			 Public Const Sourcestatus As String = "SOURCESTATUS"
			 Public Const LookupDesc As String = "LookupDesc"
			 Public Const Purchaseitemstatus As String = "PURCHASEITEMSTATUS"
			 Public Const Inventoryclass As String = "INVENTORYCLASS"
			 Public Const Sourcetype As String = "SOURCETYPE"
			 Public Const Allocateddocument As String = "ALLOCATEDDOCUMENT"
			 Public Const Allocatedtype As String = "ALLOCATEDTYPE"
			 Public Const Expectedindate As String = "EXPECTEDINDATE"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Invitemnumber As String = "Invitemnumber"
			 Public Const Sourcedocument As String = "Sourcedocument"
			 Public Const Itemtype As String = "Itemtype"
			 Public Const Itemid As String = "Itemid"
			 Public Const Itemdescription As String = "Itemdescription"
			 Public Const Container As String = "Container"
			 Public Const Lotnumber As String = "Lotnumber"
			 Public Const Unitsremainingweight As String = "Unitsremainingweight"
			 Public Const Rcvdweight As String = "Rcvdweight"
			 Public Const Vendorweight As String = "Vendorweight"
			 Public Const Unitsremaining As String = "Unitsremaining"
			 Public Const Uom As String = "Uom"
			 Public Const Itemstatus As String = "Itemstatus"
			 Public Const Productid As String = "Productid"
			 Public Const Purchasenumber As String = "Purchasenumber"
			 Public Const CheckMark As String = "CheckMark"
			 Public Const Sourcestatus As String = "Sourcestatus"
			 Public Const LookupDesc As String = "LookupDesc"
			 Public Const Purchaseitemstatus As String = "Purchaseitemstatus"
			 Public Const Inventoryclass As String = "Inventoryclass"
			 Public Const Sourcetype As String = "Sourcetype"
			 Public Const Allocateddocument As String = "Allocateddocument"
			 Public Const Allocatedtype As String = "Allocatedtype"
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
            SyncLock GetType(ViewInvItemListMetadata)
			
				If ViewInvItemListMetadata.mapDelegates Is Nothing Then
					ViewInvItemListMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewInvItemListMetadata._meta Is Nothing Then
                    ViewInvItemListMetadata._meta = New ViewInvItemListMetadata()
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
				

				meta.AddTypeMap("Invitemnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Sourcedocument", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Itemtype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Itemid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Itemdescription", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Lotnumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Unitsremainingweight", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Rcvdweight", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Vendorweight", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Unitsremaining", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Uom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Itemstatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Productid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Purchasenumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("CheckMark", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Sourcestatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("LookupDesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Purchaseitemstatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Inventoryclass", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Sourcetype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Allocateddocument", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Allocatedtype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Expectedindate", new esTypeMap("datetime", "System.DateTime"))			
				
				
				 
				meta.Source = "viewInvItemList"
				meta.Destination = "viewInvItemList"
				
				meta.spInsert = "proc_viewInvItemListInsert"
				meta.spUpdate = "proc_viewInvItemListUpdate"
				meta.spDelete = "proc_viewInvItemListDelete"
				meta.spLoadAll = "proc_viewInvItemListLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewInvItemListLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewInvItemListMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
