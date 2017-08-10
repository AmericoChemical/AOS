'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/11/2014 1:36:08 PM
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
	MustInherit Public Class esViewInvItemReceiverInfoCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewInvItemReceiverInfoCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewInvItemReceiverInfoQuery)
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
            Me.InitQuery(CType(query, esViewInvItemReceiverInfoQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewInvItemReceiverInfo) As ViewInvItemReceiverInfo
			Return CType(MyBase.DetachEntity(entity), ViewInvItemReceiverInfo)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewInvItemReceiverInfo) As ViewInvItemReceiverInfo
			Return CType(MyBase.AttachEntity(entity), ViewInvItemReceiverInfo)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewInvItemReceiverInfoCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewInvItemReceiverInfo
            Get
                Return TryCast(MyBase.Item(index), ViewInvItemReceiverInfo)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewInvItemReceiverInfo)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewInvItemReceiverInfo	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewInvItemReceiverInfoQuery
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
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Productdesc"
							Me.str.Productdesc = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "Unitcost"
							Me.str.Unitcost = CType(value, string)
												
						Case "Receiveddate"
							Me.str.Receiveddate = CType(value, string)
												
						Case "Lotnumber"
							Me.str.Lotnumber = CType(value, string)
												
						Case "Itemstatus"
							Me.str.Itemstatus = CType(value, string)
												
						Case "Inventoryclass"
							Me.str.Inventoryclass = CType(value, string)
												
						Case "QtyReceived"
							Me.str.QtyReceived = CType(value, string)
												
						Case "Receiverdocument"
							Me.str.Receiverdocument = CType(value, string)
												
						Case "Receivernumber"
							Me.str.Receivernumber = CType(value, string)
												
						Case "Vendorid"
							Me.str.Vendorid = CType(value, string)
												
						Case "Ponumber"
							Me.str.Ponumber = CType(value, string)
												
						Case "Vendorname"
							Me.str.Vendorname = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Invitemnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Invitemnumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Unitcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Unitcost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Receiveddate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Receiveddate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Inventoryclass"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Inventoryclass = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "QtyReceived"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.QtyReceived = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Receivernumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Receivernumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Vendorid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Vendorid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Ponumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Ponumber = CType(value, Nullable(Of System.Int32))
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
		' Maps to viewInvItemReceiverInfo.INVITEMNUMBER
		' </summary>
		Public Overridable Property Invitemnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewInvItemReceiverInfoMetadata.ColumnNames.Invitemnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewInvItemReceiverInfoMetadata.ColumnNames.Invitemnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemReceiverInfo.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewInvItemReceiverInfoMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewInvItemReceiverInfoMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemReceiverInfo.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewInvItemReceiverInfoMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewInvItemReceiverInfoMetadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemReceiverInfo.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewInvItemReceiverInfoMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewInvItemReceiverInfoMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemReceiverInfo.UNITCOST
		' </summary>
		Public Overridable Property Unitcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewInvItemReceiverInfoMetadata.ColumnNames.Unitcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewInvItemReceiverInfoMetadata.ColumnNames.Unitcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemReceiverInfo.RECEIVEDDATE
		' </summary>
		Public Overridable Property Receiveddate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewInvItemReceiverInfoMetadata.ColumnNames.Receiveddate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewInvItemReceiverInfoMetadata.ColumnNames.Receiveddate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemReceiverInfo.LOTNUMBER
		' </summary>
		Public Overridable Property Lotnumber As System.String
			Get
				Return MyBase.GetSystemString(ViewInvItemReceiverInfoMetadata.ColumnNames.Lotnumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewInvItemReceiverInfoMetadata.ColumnNames.Lotnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemReceiverInfo.ITEMSTATUS
		' </summary>
		Public Overridable Property Itemstatus As System.String
			Get
				Return MyBase.GetSystemString(ViewInvItemReceiverInfoMetadata.ColumnNames.Itemstatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewInvItemReceiverInfoMetadata.ColumnNames.Itemstatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemReceiverInfo.INVENTORYCLASS
		' </summary>
		Public Overridable Property Inventoryclass As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewInvItemReceiverInfoMetadata.ColumnNames.Inventoryclass)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewInvItemReceiverInfoMetadata.ColumnNames.Inventoryclass, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemReceiverInfo.QtyReceived
		' </summary>
		Public Overridable Property QtyReceived As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewInvItemReceiverInfoMetadata.ColumnNames.QtyReceived)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewInvItemReceiverInfoMetadata.ColumnNames.QtyReceived, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemReceiverInfo.RECEIVERDOCUMENT
		' </summary>
		Public Overridable Property Receiverdocument As System.String
			Get
				Return MyBase.GetSystemString(ViewInvItemReceiverInfoMetadata.ColumnNames.Receiverdocument)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewInvItemReceiverInfoMetadata.ColumnNames.Receiverdocument, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemReceiverInfo.RECEIVERNUMBER
		' </summary>
		Public Overridable Property Receivernumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewInvItemReceiverInfoMetadata.ColumnNames.Receivernumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewInvItemReceiverInfoMetadata.ColumnNames.Receivernumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemReceiverInfo.VENDORID
		' </summary>
		Public Overridable Property Vendorid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewInvItemReceiverInfoMetadata.ColumnNames.Vendorid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewInvItemReceiverInfoMetadata.ColumnNames.Vendorid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemReceiverInfo.PONUMBER
		' </summary>
		Public Overridable Property Ponumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewInvItemReceiverInfoMetadata.ColumnNames.Ponumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewInvItemReceiverInfoMetadata.ColumnNames.Ponumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemReceiverInfo.VENDORNAME
		' </summary>
		Public Overridable Property Vendorname As System.String
			Get
				Return MyBase.GetSystemString(ViewInvItemReceiverInfoMetadata.ColumnNames.Vendorname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewInvItemReceiverInfoMetadata.ColumnNames.Vendorname, value)
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
		
			Public Sub New(ByVal entity As esViewInvItemReceiverInfo)
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
		  	
			Public Property Receiveddate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Receiveddate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Receiveddate = Nothing
					Else
						entity.Receiveddate = Convert.ToDateTime(Value)
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
		  	
			Public Property QtyReceived As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.QtyReceived
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.QtyReceived = Nothing
					Else
						entity.QtyReceived = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Receiverdocument As System.String 
				Get
					Dim data_ As System.String = entity.Receiverdocument
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Receiverdocument = Nothing
					Else
						entity.Receiverdocument = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Receivernumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Receivernumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Receivernumber = Nothing
					Else
						entity.Receivernumber = Convert.ToInt32(Value)
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
		  	
			Public Property Ponumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Ponumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Ponumber = Nothing
					Else
						entity.Ponumber = Convert.ToInt32(Value)
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
		  

			Private entity As esViewInvItemReceiverInfo
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewInvItemReceiverInfoQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewInvItemReceiverInfo can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewInvItemReceiverInfoQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewInvItemReceiverInfoMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Invitemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemReceiverInfoMetadata.ColumnNames.Invitemnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemReceiverInfoMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemReceiverInfoMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemReceiverInfoMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Unitcost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemReceiverInfoMetadata.ColumnNames.Unitcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Receiveddate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemReceiverInfoMetadata.ColumnNames.Receiveddate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Lotnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemReceiverInfoMetadata.ColumnNames.Lotnumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Itemstatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemReceiverInfoMetadata.ColumnNames.Itemstatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Inventoryclass As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemReceiverInfoMetadata.ColumnNames.Inventoryclass, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property QtyReceived As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemReceiverInfoMetadata.ColumnNames.QtyReceived, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Receiverdocument As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemReceiverInfoMetadata.ColumnNames.Receiverdocument, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Receivernumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemReceiverInfoMetadata.ColumnNames.Receivernumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Vendorid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemReceiverInfoMetadata.ColumnNames.Vendorid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Ponumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemReceiverInfoMetadata.ColumnNames.Ponumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Vendorname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemReceiverInfoMetadata.ColumnNames.Vendorname, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewInvItemReceiverInfoCollection")> _
	Partial Public Class ViewInvItemReceiverInfoCollection
		Inherits esViewInvItemReceiverInfoCollection
		Implements IEnumerable(Of ViewInvItemReceiverInfo)
		
        Public Shared Widening Operator CType(ByVal coll As ViewInvItemReceiverInfoCollection) As List(Of ViewInvItemReceiverInfo)
            Dim list As List(Of ViewInvItemReceiverInfo) = New List(Of ViewInvItemReceiverInfo)
            Dim emp As ViewInvItemReceiverInfo

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewInvItemReceiverInfoMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewInvItemReceiverInfoQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewInvItemReceiverInfo(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewInvItemReceiverInfo()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewInvItemReceiverInfoQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewInvItemReceiverInfoQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewInvItemReceiverInfoQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewInvItemReceiverInfo 
			Return CType(MyBase.AddNewEntity(), ViewInvItemReceiverInfo)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewInvItemReceiverInfo) Implements IEnumerable(Of ViewInvItemReceiverInfo).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewInvItemReceiverInfo)(Me)
        End Function
		
		Private _query As ViewInvItemReceiverInfoQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewInvItemReceiverInfo' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewInvItemReceiverInfo ()")> _
	<Serializable> _
	Partial Public Class ViewInvItemReceiverInfo 
		Inherits esViewInvItemReceiverInfo

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewInvItemReceiverInfoMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewInvItemReceiverInfoQuery

			If Me._query Is Nothing Then
				Me._query = New ViewInvItemReceiverInfoQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewInvItemReceiverInfoQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewInvItemReceiverInfoQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewInvItemReceiverInfoQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewInvItemReceiverInfoQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewInvItemReceiverInfoQuery
		inherits esViewInvItemReceiverInfoQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewInvItemReceiverInfoQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewInvItemReceiverInfoMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewInvItemReceiverInfoMetadata.ColumnNames.Invitemnumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewInvItemReceiverInfoMetadata.PropertyNames.Invitemnumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemReceiverInfoMetadata.ColumnNames.Productid, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewInvItemReceiverInfoMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemReceiverInfoMetadata.ColumnNames.Productdesc, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewInvItemReceiverInfoMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemReceiverInfoMetadata.ColumnNames.Container, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewInvItemReceiverInfoMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemReceiverInfoMetadata.ColumnNames.Unitcost, 4, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewInvItemReceiverInfoMetadata.PropertyNames.Unitcost
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemReceiverInfoMetadata.ColumnNames.Receiveddate, 5, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewInvItemReceiverInfoMetadata.PropertyNames.Receiveddate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemReceiverInfoMetadata.ColumnNames.Lotnumber, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewInvItemReceiverInfoMetadata.PropertyNames.Lotnumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemReceiverInfoMetadata.ColumnNames.Itemstatus, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewInvItemReceiverInfoMetadata.PropertyNames.Itemstatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemReceiverInfoMetadata.ColumnNames.Inventoryclass, 8, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewInvItemReceiverInfoMetadata.PropertyNames.Inventoryclass
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemReceiverInfoMetadata.ColumnNames.QtyReceived, 9, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewInvItemReceiverInfoMetadata.PropertyNames.QtyReceived
			c.NumericPrecision = 38
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemReceiverInfoMetadata.ColumnNames.Receiverdocument, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewInvItemReceiverInfoMetadata.PropertyNames.Receiverdocument
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemReceiverInfoMetadata.ColumnNames.Receivernumber, 11, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewInvItemReceiverInfoMetadata.PropertyNames.Receivernumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemReceiverInfoMetadata.ColumnNames.Vendorid, 12, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewInvItemReceiverInfoMetadata.PropertyNames.Vendorid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemReceiverInfoMetadata.ColumnNames.Ponumber, 13, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewInvItemReceiverInfoMetadata.PropertyNames.Ponumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemReceiverInfoMetadata.ColumnNames.Vendorname, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewInvItemReceiverInfoMetadata.PropertyNames.Vendorname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewInvItemReceiverInfoMetadata
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
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Productdesc As String = "PRODUCTDESC"
			 Public Const Container As String = "CONTAINER"
			 Public Const Unitcost As String = "UNITCOST"
			 Public Const Receiveddate As String = "RECEIVEDDATE"
			 Public Const Lotnumber As String = "LOTNUMBER"
			 Public Const Itemstatus As String = "ITEMSTATUS"
			 Public Const Inventoryclass As String = "INVENTORYCLASS"
			 Public Const QtyReceived As String = "QtyReceived"
			 Public Const Receiverdocument As String = "RECEIVERDOCUMENT"
			 Public Const Receivernumber As String = "RECEIVERNUMBER"
			 Public Const Vendorid As String = "VENDORID"
			 Public Const Ponumber As String = "PONUMBER"
			 Public Const Vendorname As String = "VENDORNAME"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Invitemnumber As String = "Invitemnumber"
			 Public Const Productid As String = "Productid"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const Container As String = "Container"
			 Public Const Unitcost As String = "Unitcost"
			 Public Const Receiveddate As String = "Receiveddate"
			 Public Const Lotnumber As String = "Lotnumber"
			 Public Const Itemstatus As String = "Itemstatus"
			 Public Const Inventoryclass As String = "Inventoryclass"
			 Public Const QtyReceived As String = "QtyReceived"
			 Public Const Receiverdocument As String = "Receiverdocument"
			 Public Const Receivernumber As String = "Receivernumber"
			 Public Const Vendorid As String = "Vendorid"
			 Public Const Ponumber As String = "Ponumber"
			 Public Const Vendorname As String = "Vendorname"
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
            SyncLock GetType(ViewInvItemReceiverInfoMetadata)
			
				If ViewInvItemReceiverInfoMetadata.mapDelegates Is Nothing Then
					ViewInvItemReceiverInfoMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewInvItemReceiverInfoMetadata._meta Is Nothing Then
                    ViewInvItemReceiverInfoMetadata._meta = New ViewInvItemReceiverInfoMetadata()
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
				meta.AddTypeMap("Productid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Unitcost", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Receiveddate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Lotnumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Itemstatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Inventoryclass", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("QtyReceived", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Receiverdocument", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Receivernumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Vendorid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Ponumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Vendorname", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewInvItemReceiverInfo"
				meta.Destination = "viewInvItemReceiverInfo"
				
				meta.spInsert = "proc_viewInvItemReceiverInfoInsert"
				meta.spUpdate = "proc_viewInvItemReceiverInfoUpdate"
				meta.spDelete = "proc_viewInvItemReceiverInfoDelete"
				meta.spLoadAll = "proc_viewInvItemReceiverInfoLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewInvItemReceiverInfoLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewInvItemReceiverInfoMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
