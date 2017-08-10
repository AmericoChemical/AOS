'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 4/13/2015 10:32:08 PM
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
	MustInherit Public Class esViewInvItemDetailsCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewInvItemDetailsCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewInvItemDetailsQuery)
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
            Me.InitQuery(CType(query, esViewInvItemDetailsQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewInvItemDetails) As ViewInvItemDetails
			Return CType(MyBase.DetachEntity(entity), ViewInvItemDetails)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewInvItemDetails) As ViewInvItemDetails
			Return CType(MyBase.AttachEntity(entity), ViewInvItemDetails)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewInvItemDetailsCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewInvItemDetails
            Get
                Return TryCast(MyBase.Item(index), ViewInvItemDetails)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewInvItemDetails)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewInvItemDetails	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewInvItemDetailsQuery
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
												
						Case "Shipmentnumber"
							Me.str.Shipmentnumber = CType(value, string)
												
						Case "Shipmentdate"
							Me.str.Shipmentdate = CType(value, string)
												
						Case "Shippeddate"
							Me.str.Shippeddate = CType(value, string)
												
						Case "Receiveddate"
							Me.str.Receiveddate = CType(value, string)
												
						Case "Lotnumber"
							Me.str.Lotnumber = CType(value, string)
												
						Case "Warehouselocation"
							Me.str.Warehouselocation = CType(value, string)
												
						Case "Warehousenumber"
							Me.str.Warehousenumber = CType(value, string)
												
						Case "Allocateddate"
							Me.str.Allocateddate = CType(value, string)
												
						Case "Receivernumber"
							Me.str.Receivernumber = CType(value, string)
												
						Case "Itemstatus"
							Me.str.Itemstatus = CType(value, string)
												
						Case "Inventoryclass"
							Me.str.Inventoryclass = CType(value, string)
												
						Case "Classdesc"
							Me.str.Classdesc = CType(value, string)
												
						Case "Unitsremaining"
							Me.str.Unitsremaining = CType(value, string)
												
						Case "Receiverdocument"
							Me.str.Receiverdocument = CType(value, string)
												
						Case "Receiverdocumenttype"
							Me.str.Receiverdocumenttype = CType(value, string)
												
						Case "Ponumber"
							Me.str.Ponumber = CType(value, string)
												
						Case "Purchasereleasenumber"
							Me.str.Purchasereleasenumber = CType(value, string)
												
						Case "Vendorname"
							Me.str.Vendorname = CType(value, string)
												
						Case "Podate"
							Me.str.Podate = CType(value, string)
												
						Case "Changeableponumber"
							Me.str.Changeableponumber = CType(value, string)
												
						Case "Allocateddocument"
							Me.str.Allocateddocument = CType(value, string)
												
						Case "Allocatedtype"
							Me.str.Allocatedtype = CType(value, string)
												
						Case "Workordernumber"
							Me.str.Workordernumber = CType(value, string)
												
						Case "Workordercustomer"
							Me.str.Workordercustomer = CType(value, string)
												
						Case "Shiptocustomer"
							Me.str.Shiptocustomer = CType(value, string)
												
						Case "Plannedshipdate"
							Me.str.Plannedshipdate = CType(value, string)
												
						Case "AvailableDate"
							Me.str.AvailableDate = CType(value, string)
												
						Case "Sourcedocument"
							Me.str.Sourcedocument = CType(value, string)
												
						Case "Sourcetype"
							Me.str.Sourcetype = CType(value, string)
												
						Case "Sourcestatus"
							Me.str.Sourcestatus = CType(value, string)
					
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
						
						Case "Shipmentnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Shipmentnumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Shipmentdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Shipmentdate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Shippeddate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Shippeddate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Receiveddate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Receiveddate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Warehousenumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Warehousenumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Allocateddate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Allocateddate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Receivernumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Receivernumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Inventoryclass"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Inventoryclass = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Unitsremaining"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Unitsremaining = CType(value, Nullable(Of System.Double))
							End If
						
						Case "Ponumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Ponumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Purchasereleasenumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Purchasereleasenumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Podate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Podate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Workordernumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Workordernumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Plannedshipdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Plannedshipdate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "AvailableDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.AvailableDate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Sourcedocument"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Sourcedocument = CType(value, Nullable(Of System.Int32))
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
		' Maps to viewInvItemDetails.INVITEMNUMBER
		' </summary>
		Public Overridable Property Invitemnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewInvItemDetailsMetadata.ColumnNames.Invitemnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewInvItemDetailsMetadata.ColumnNames.Invitemnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemDetails.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewInvItemDetailsMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewInvItemDetailsMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemDetails.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewInvItemDetailsMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewInvItemDetailsMetadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemDetails.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewInvItemDetailsMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewInvItemDetailsMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemDetails.SHIPMENTNUMBER
		' </summary>
		Public Overridable Property Shipmentnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewInvItemDetailsMetadata.ColumnNames.Shipmentnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewInvItemDetailsMetadata.ColumnNames.Shipmentnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemDetails.SHIPMENTDATE
		' </summary>
		Public Overridable Property Shipmentdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewInvItemDetailsMetadata.ColumnNames.Shipmentdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewInvItemDetailsMetadata.ColumnNames.Shipmentdate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemDetails.SHIPPEDDATE
		' </summary>
		Public Overridable Property Shippeddate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewInvItemDetailsMetadata.ColumnNames.Shippeddate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewInvItemDetailsMetadata.ColumnNames.Shippeddate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemDetails.RECEIVEDDATE
		' </summary>
		Public Overridable Property Receiveddate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewInvItemDetailsMetadata.ColumnNames.Receiveddate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewInvItemDetailsMetadata.ColumnNames.Receiveddate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemDetails.LOTNUMBER
		' </summary>
		Public Overridable Property Lotnumber As System.String
			Get
				Return MyBase.GetSystemString(ViewInvItemDetailsMetadata.ColumnNames.Lotnumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewInvItemDetailsMetadata.ColumnNames.Lotnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemDetails.WAREHOUSELOCATION
		' </summary>
		Public Overridable Property Warehouselocation As System.String
			Get
				Return MyBase.GetSystemString(ViewInvItemDetailsMetadata.ColumnNames.Warehouselocation)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewInvItemDetailsMetadata.ColumnNames.Warehouselocation, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemDetails.WAREHOUSENUMBER
		' </summary>
		Public Overridable Property Warehousenumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewInvItemDetailsMetadata.ColumnNames.Warehousenumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewInvItemDetailsMetadata.ColumnNames.Warehousenumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemDetails.ALLOCATEDDATE
		' </summary>
		Public Overridable Property Allocateddate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewInvItemDetailsMetadata.ColumnNames.Allocateddate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewInvItemDetailsMetadata.ColumnNames.Allocateddate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemDetails.RECEIVERNUMBER
		' </summary>
		Public Overridable Property Receivernumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewInvItemDetailsMetadata.ColumnNames.Receivernumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewInvItemDetailsMetadata.ColumnNames.Receivernumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemDetails.ITEMSTATUS
		' </summary>
		Public Overridable Property Itemstatus As System.String
			Get
				Return MyBase.GetSystemString(ViewInvItemDetailsMetadata.ColumnNames.Itemstatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewInvItemDetailsMetadata.ColumnNames.Itemstatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemDetails.INVENTORYCLASS
		' </summary>
		Public Overridable Property Inventoryclass As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewInvItemDetailsMetadata.ColumnNames.Inventoryclass)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewInvItemDetailsMetadata.ColumnNames.Inventoryclass, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemDetails.CLASSDESC
		' </summary>
		Public Overridable Property Classdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewInvItemDetailsMetadata.ColumnNames.Classdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewInvItemDetailsMetadata.ColumnNames.Classdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemDetails.UNITSREMAINING
		' </summary>
		Public Overridable Property Unitsremaining As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewInvItemDetailsMetadata.ColumnNames.Unitsremaining)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewInvItemDetailsMetadata.ColumnNames.Unitsremaining, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemDetails.RECEIVERDOCUMENT
		' </summary>
		Public Overridable Property Receiverdocument As System.String
			Get
				Return MyBase.GetSystemString(ViewInvItemDetailsMetadata.ColumnNames.Receiverdocument)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewInvItemDetailsMetadata.ColumnNames.Receiverdocument, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemDetails.RECEIVERDOCUMENTTYPE
		' </summary>
		Public Overridable Property Receiverdocumenttype As System.String
			Get
				Return MyBase.GetSystemString(ViewInvItemDetailsMetadata.ColumnNames.Receiverdocumenttype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewInvItemDetailsMetadata.ColumnNames.Receiverdocumenttype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemDetails.PONUMBER
		' </summary>
		Public Overridable Property Ponumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewInvItemDetailsMetadata.ColumnNames.Ponumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewInvItemDetailsMetadata.ColumnNames.Ponumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemDetails.PURCHASERELEASENUMBER
		' </summary>
		Public Overridable Property Purchasereleasenumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewInvItemDetailsMetadata.ColumnNames.Purchasereleasenumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewInvItemDetailsMetadata.ColumnNames.Purchasereleasenumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemDetails.VENDORNAME
		' </summary>
		Public Overridable Property Vendorname As System.String
			Get
				Return MyBase.GetSystemString(ViewInvItemDetailsMetadata.ColumnNames.Vendorname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewInvItemDetailsMetadata.ColumnNames.Vendorname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemDetails.PODATE
		' </summary>
		Public Overridable Property Podate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewInvItemDetailsMetadata.ColumnNames.Podate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewInvItemDetailsMetadata.ColumnNames.Podate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemDetails.CHANGEABLEPONUMBER
		' </summary>
		Public Overridable Property Changeableponumber As System.String
			Get
				Return MyBase.GetSystemString(ViewInvItemDetailsMetadata.ColumnNames.Changeableponumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewInvItemDetailsMetadata.ColumnNames.Changeableponumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemDetails.ALLOCATEDDOCUMENT
		' </summary>
		Public Overridable Property Allocateddocument As System.String
			Get
				Return MyBase.GetSystemString(ViewInvItemDetailsMetadata.ColumnNames.Allocateddocument)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewInvItemDetailsMetadata.ColumnNames.Allocateddocument, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemDetails.ALLOCATEDTYPE
		' </summary>
		Public Overridable Property Allocatedtype As System.String
			Get
				Return MyBase.GetSystemString(ViewInvItemDetailsMetadata.ColumnNames.Allocatedtype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewInvItemDetailsMetadata.ColumnNames.Allocatedtype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemDetails.WORKORDERNUMBER
		' </summary>
		Public Overridable Property Workordernumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewInvItemDetailsMetadata.ColumnNames.Workordernumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewInvItemDetailsMetadata.ColumnNames.Workordernumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemDetails.WORKORDERCUSTOMER
		' </summary>
		Public Overridable Property Workordercustomer As System.String
			Get
				Return MyBase.GetSystemString(ViewInvItemDetailsMetadata.ColumnNames.Workordercustomer)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewInvItemDetailsMetadata.ColumnNames.Workordercustomer, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemDetails.SHIPTOCUSTOMER
		' </summary>
		Public Overridable Property Shiptocustomer As System.String
			Get
				Return MyBase.GetSystemString(ViewInvItemDetailsMetadata.ColumnNames.Shiptocustomer)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewInvItemDetailsMetadata.ColumnNames.Shiptocustomer, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemDetails.PLANNEDSHIPDATE
		' </summary>
		Public Overridable Property Plannedshipdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewInvItemDetailsMetadata.ColumnNames.Plannedshipdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewInvItemDetailsMetadata.ColumnNames.Plannedshipdate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemDetails.AvailableDate
		' </summary>
		Public Overridable Property AvailableDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewInvItemDetailsMetadata.ColumnNames.AvailableDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewInvItemDetailsMetadata.ColumnNames.AvailableDate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemDetails.SOURCEDOCUMENT
		' </summary>
		Public Overridable Property Sourcedocument As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewInvItemDetailsMetadata.ColumnNames.Sourcedocument)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewInvItemDetailsMetadata.ColumnNames.Sourcedocument, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemDetails.SOURCETYPE
		' </summary>
		Public Overridable Property Sourcetype As System.String
			Get
				Return MyBase.GetSystemString(ViewInvItemDetailsMetadata.ColumnNames.Sourcetype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewInvItemDetailsMetadata.ColumnNames.Sourcetype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewInvItemDetails.SOURCESTATUS
		' </summary>
		Public Overridable Property Sourcestatus As System.String
			Get
				Return MyBase.GetSystemString(ViewInvItemDetailsMetadata.ColumnNames.Sourcestatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewInvItemDetailsMetadata.ColumnNames.Sourcestatus, value)
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
		
			Public Sub New(ByVal entity As esViewInvItemDetails)
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
		  	
			Public Property Shipmentdate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Shipmentdate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipmentdate = Nothing
					Else
						entity.Shipmentdate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shippeddate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Shippeddate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shippeddate = Nothing
					Else
						entity.Shippeddate = Convert.ToDateTime(Value)
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
		  	
			Public Property Warehouselocation As System.String 
				Get
					Dim data_ As System.String = entity.Warehouselocation
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Warehouselocation = Nothing
					Else
						entity.Warehouselocation = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Warehousenumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Warehousenumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Warehousenumber = Nothing
					Else
						entity.Warehousenumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Allocateddate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Allocateddate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Allocateddate = Nothing
					Else
						entity.Allocateddate = Convert.ToDateTime(Value)
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
		  	
			Public Property Classdesc As System.String 
				Get
					Dim data_ As System.String = entity.Classdesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Classdesc = Nothing
					Else
						entity.Classdesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Unitsremaining As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Unitsremaining
					
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
						entity.Unitsremaining = Convert.ToDouble(Value)
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
		  	
			Public Property Receiverdocumenttype As System.String 
				Get
					Dim data_ As System.String = entity.Receiverdocumenttype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Receiverdocumenttype = Nothing
					Else
						entity.Receiverdocumenttype = Convert.ToString(Value)
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
		  	
			Public Property Purchasereleasenumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Purchasereleasenumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Purchasereleasenumber = Nothing
					Else
						entity.Purchasereleasenumber = Convert.ToInt32(Value)
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
		  	
			Public Property Podate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Podate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Podate = Nothing
					Else
						entity.Podate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Changeableponumber As System.String 
				Get
					Dim data_ As System.String = entity.Changeableponumber
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Changeableponumber = Nothing
					Else
						entity.Changeableponumber = Convert.ToString(Value)
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
		  	
			Public Property Workordercustomer As System.String 
				Get
					Dim data_ As System.String = entity.Workordercustomer
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Workordercustomer = Nothing
					Else
						entity.Workordercustomer = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shiptocustomer As System.String 
				Get
					Dim data_ As System.String = entity.Shiptocustomer
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shiptocustomer = Nothing
					Else
						entity.Shiptocustomer = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Plannedshipdate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Plannedshipdate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Plannedshipdate = Nothing
					Else
						entity.Plannedshipdate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property AvailableDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.AvailableDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.AvailableDate = Nothing
					Else
						entity.AvailableDate = Convert.ToDateTime(Value)
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
		  

			Private entity As esViewInvItemDetails
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewInvItemDetailsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewInvItemDetails can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewInvItemDetailsQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewInvItemDetailsMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Invitemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemDetailsMetadata.ColumnNames.Invitemnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemDetailsMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemDetailsMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemDetailsMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shipmentnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemDetailsMetadata.ColumnNames.Shipmentnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Shipmentdate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemDetailsMetadata.ColumnNames.Shipmentdate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Shippeddate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemDetailsMetadata.ColumnNames.Shippeddate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Receiveddate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemDetailsMetadata.ColumnNames.Receiveddate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Lotnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemDetailsMetadata.ColumnNames.Lotnumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Warehouselocation As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemDetailsMetadata.ColumnNames.Warehouselocation, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Warehousenumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemDetailsMetadata.ColumnNames.Warehousenumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Allocateddate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemDetailsMetadata.ColumnNames.Allocateddate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Receivernumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemDetailsMetadata.ColumnNames.Receivernumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Itemstatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemDetailsMetadata.ColumnNames.Itemstatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Inventoryclass As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemDetailsMetadata.ColumnNames.Inventoryclass, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Classdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemDetailsMetadata.ColumnNames.Classdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Unitsremaining As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemDetailsMetadata.ColumnNames.Unitsremaining, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Receiverdocument As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemDetailsMetadata.ColumnNames.Receiverdocument, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Receiverdocumenttype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemDetailsMetadata.ColumnNames.Receiverdocumenttype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Ponumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemDetailsMetadata.ColumnNames.Ponumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Purchasereleasenumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemDetailsMetadata.ColumnNames.Purchasereleasenumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Vendorname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemDetailsMetadata.ColumnNames.Vendorname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Podate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemDetailsMetadata.ColumnNames.Podate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Changeableponumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemDetailsMetadata.ColumnNames.Changeableponumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Allocateddocument As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemDetailsMetadata.ColumnNames.Allocateddocument, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Allocatedtype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemDetailsMetadata.ColumnNames.Allocatedtype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Workordernumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemDetailsMetadata.ColumnNames.Workordernumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Workordercustomer As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemDetailsMetadata.ColumnNames.Workordercustomer, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Shiptocustomer As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemDetailsMetadata.ColumnNames.Shiptocustomer, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Plannedshipdate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemDetailsMetadata.ColumnNames.Plannedshipdate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property AvailableDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemDetailsMetadata.ColumnNames.AvailableDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Sourcedocument As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemDetailsMetadata.ColumnNames.Sourcedocument, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Sourcetype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemDetailsMetadata.ColumnNames.Sourcetype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Sourcestatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewInvItemDetailsMetadata.ColumnNames.Sourcestatus, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewInvItemDetailsCollection")> _
	Partial Public Class ViewInvItemDetailsCollection
		Inherits esViewInvItemDetailsCollection
		Implements IEnumerable(Of ViewInvItemDetails)
		
        Public Shared Widening Operator CType(ByVal coll As ViewInvItemDetailsCollection) As List(Of ViewInvItemDetails)
            Dim list As List(Of ViewInvItemDetails) = New List(Of ViewInvItemDetails)
            Dim emp As ViewInvItemDetails

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewInvItemDetailsMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewInvItemDetailsQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewInvItemDetails(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewInvItemDetails()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewInvItemDetailsQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewInvItemDetailsQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewInvItemDetailsQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewInvItemDetails 
			Return CType(MyBase.AddNewEntity(), ViewInvItemDetails)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewInvItemDetails) Implements IEnumerable(Of ViewInvItemDetails).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewInvItemDetails)(Me)
        End Function
		
		Private _query As ViewInvItemDetailsQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewInvItemDetails' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewInvItemDetails ()")> _
	<Serializable> _
	Partial Public Class ViewInvItemDetails 
		Inherits esViewInvItemDetails

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewInvItemDetailsMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewInvItemDetailsQuery

			If Me._query Is Nothing Then
				Me._query = New ViewInvItemDetailsQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewInvItemDetailsQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewInvItemDetailsQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewInvItemDetailsQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewInvItemDetailsQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewInvItemDetailsQuery
		inherits esViewInvItemDetailsQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewInvItemDetailsQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewInvItemDetailsMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewInvItemDetailsMetadata.ColumnNames.Invitemnumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewInvItemDetailsMetadata.PropertyNames.Invitemnumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemDetailsMetadata.ColumnNames.Productid, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewInvItemDetailsMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemDetailsMetadata.ColumnNames.Productdesc, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewInvItemDetailsMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemDetailsMetadata.ColumnNames.Container, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewInvItemDetailsMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemDetailsMetadata.ColumnNames.Shipmentnumber, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewInvItemDetailsMetadata.PropertyNames.Shipmentnumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemDetailsMetadata.ColumnNames.Shipmentdate, 5, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewInvItemDetailsMetadata.PropertyNames.Shipmentdate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemDetailsMetadata.ColumnNames.Shippeddate, 6, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewInvItemDetailsMetadata.PropertyNames.Shippeddate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemDetailsMetadata.ColumnNames.Receiveddate, 7, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewInvItemDetailsMetadata.PropertyNames.Receiveddate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemDetailsMetadata.ColumnNames.Lotnumber, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewInvItemDetailsMetadata.PropertyNames.Lotnumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemDetailsMetadata.ColumnNames.Warehouselocation, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewInvItemDetailsMetadata.PropertyNames.Warehouselocation
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemDetailsMetadata.ColumnNames.Warehousenumber, 10, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewInvItemDetailsMetadata.PropertyNames.Warehousenumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemDetailsMetadata.ColumnNames.Allocateddate, 11, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewInvItemDetailsMetadata.PropertyNames.Allocateddate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemDetailsMetadata.ColumnNames.Receivernumber, 12, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewInvItemDetailsMetadata.PropertyNames.Receivernumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemDetailsMetadata.ColumnNames.Itemstatus, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewInvItemDetailsMetadata.PropertyNames.Itemstatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemDetailsMetadata.ColumnNames.Inventoryclass, 14, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewInvItemDetailsMetadata.PropertyNames.Inventoryclass
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemDetailsMetadata.ColumnNames.Classdesc, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewInvItemDetailsMetadata.PropertyNames.Classdesc
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemDetailsMetadata.ColumnNames.Unitsremaining, 16, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewInvItemDetailsMetadata.PropertyNames.Unitsremaining
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemDetailsMetadata.ColumnNames.Receiverdocument, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewInvItemDetailsMetadata.PropertyNames.Receiverdocument
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemDetailsMetadata.ColumnNames.Receiverdocumenttype, 18, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewInvItemDetailsMetadata.PropertyNames.Receiverdocumenttype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemDetailsMetadata.ColumnNames.Ponumber, 19, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewInvItemDetailsMetadata.PropertyNames.Ponumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemDetailsMetadata.ColumnNames.Purchasereleasenumber, 20, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewInvItemDetailsMetadata.PropertyNames.Purchasereleasenumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemDetailsMetadata.ColumnNames.Vendorname, 21, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewInvItemDetailsMetadata.PropertyNames.Vendorname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemDetailsMetadata.ColumnNames.Podate, 22, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewInvItemDetailsMetadata.PropertyNames.Podate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemDetailsMetadata.ColumnNames.Changeableponumber, 23, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewInvItemDetailsMetadata.PropertyNames.Changeableponumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemDetailsMetadata.ColumnNames.Allocateddocument, 24, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewInvItemDetailsMetadata.PropertyNames.Allocateddocument
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemDetailsMetadata.ColumnNames.Allocatedtype, 25, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewInvItemDetailsMetadata.PropertyNames.Allocatedtype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemDetailsMetadata.ColumnNames.Workordernumber, 26, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewInvItemDetailsMetadata.PropertyNames.Workordernumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemDetailsMetadata.ColumnNames.Workordercustomer, 27, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewInvItemDetailsMetadata.PropertyNames.Workordercustomer
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemDetailsMetadata.ColumnNames.Shiptocustomer, 28, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewInvItemDetailsMetadata.PropertyNames.Shiptocustomer
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemDetailsMetadata.ColumnNames.Plannedshipdate, 29, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewInvItemDetailsMetadata.PropertyNames.Plannedshipdate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemDetailsMetadata.ColumnNames.AvailableDate, 30, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewInvItemDetailsMetadata.PropertyNames.AvailableDate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemDetailsMetadata.ColumnNames.Sourcedocument, 31, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewInvItemDetailsMetadata.PropertyNames.Sourcedocument
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemDetailsMetadata.ColumnNames.Sourcetype, 32, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewInvItemDetailsMetadata.PropertyNames.Sourcetype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewInvItemDetailsMetadata.ColumnNames.Sourcestatus, 33, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewInvItemDetailsMetadata.PropertyNames.Sourcestatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewInvItemDetailsMetadata
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
			 Public Const Shipmentnumber As String = "SHIPMENTNUMBER"
			 Public Const Shipmentdate As String = "SHIPMENTDATE"
			 Public Const Shippeddate As String = "SHIPPEDDATE"
			 Public Const Receiveddate As String = "RECEIVEDDATE"
			 Public Const Lotnumber As String = "LOTNUMBER"
			 Public Const Warehouselocation As String = "WAREHOUSELOCATION"
			 Public Const Warehousenumber As String = "WAREHOUSENUMBER"
			 Public Const Allocateddate As String = "ALLOCATEDDATE"
			 Public Const Receivernumber As String = "RECEIVERNUMBER"
			 Public Const Itemstatus As String = "ITEMSTATUS"
			 Public Const Inventoryclass As String = "INVENTORYCLASS"
			 Public Const Classdesc As String = "CLASSDESC"
			 Public Const Unitsremaining As String = "UNITSREMAINING"
			 Public Const Receiverdocument As String = "RECEIVERDOCUMENT"
			 Public Const Receiverdocumenttype As String = "RECEIVERDOCUMENTTYPE"
			 Public Const Ponumber As String = "PONUMBER"
			 Public Const Purchasereleasenumber As String = "PURCHASERELEASENUMBER"
			 Public Const Vendorname As String = "VENDORNAME"
			 Public Const Podate As String = "PODATE"
			 Public Const Changeableponumber As String = "CHANGEABLEPONUMBER"
			 Public Const Allocateddocument As String = "ALLOCATEDDOCUMENT"
			 Public Const Allocatedtype As String = "ALLOCATEDTYPE"
			 Public Const Workordernumber As String = "WORKORDERNUMBER"
			 Public Const Workordercustomer As String = "WORKORDERCUSTOMER"
			 Public Const Shiptocustomer As String = "SHIPTOCUSTOMER"
			 Public Const Plannedshipdate As String = "PLANNEDSHIPDATE"
			 Public Const AvailableDate As String = "AvailableDate"
			 Public Const Sourcedocument As String = "SOURCEDOCUMENT"
			 Public Const Sourcetype As String = "SOURCETYPE"
			 Public Const Sourcestatus As String = "SOURCESTATUS"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Invitemnumber As String = "Invitemnumber"
			 Public Const Productid As String = "Productid"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const Container As String = "Container"
			 Public Const Shipmentnumber As String = "Shipmentnumber"
			 Public Const Shipmentdate As String = "Shipmentdate"
			 Public Const Shippeddate As String = "Shippeddate"
			 Public Const Receiveddate As String = "Receiveddate"
			 Public Const Lotnumber As String = "Lotnumber"
			 Public Const Warehouselocation As String = "Warehouselocation"
			 Public Const Warehousenumber As String = "Warehousenumber"
			 Public Const Allocateddate As String = "Allocateddate"
			 Public Const Receivernumber As String = "Receivernumber"
			 Public Const Itemstatus As String = "Itemstatus"
			 Public Const Inventoryclass As String = "Inventoryclass"
			 Public Const Classdesc As String = "Classdesc"
			 Public Const Unitsremaining As String = "Unitsremaining"
			 Public Const Receiverdocument As String = "Receiverdocument"
			 Public Const Receiverdocumenttype As String = "Receiverdocumenttype"
			 Public Const Ponumber As String = "Ponumber"
			 Public Const Purchasereleasenumber As String = "Purchasereleasenumber"
			 Public Const Vendorname As String = "Vendorname"
			 Public Const Podate As String = "Podate"
			 Public Const Changeableponumber As String = "Changeableponumber"
			 Public Const Allocateddocument As String = "Allocateddocument"
			 Public Const Allocatedtype As String = "Allocatedtype"
			 Public Const Workordernumber As String = "Workordernumber"
			 Public Const Workordercustomer As String = "Workordercustomer"
			 Public Const Shiptocustomer As String = "Shiptocustomer"
			 Public Const Plannedshipdate As String = "Plannedshipdate"
			 Public Const AvailableDate As String = "AvailableDate"
			 Public Const Sourcedocument As String = "Sourcedocument"
			 Public Const Sourcetype As String = "Sourcetype"
			 Public Const Sourcestatus As String = "Sourcestatus"
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
            SyncLock GetType(ViewInvItemDetailsMetadata)
			
				If ViewInvItemDetailsMetadata.mapDelegates Is Nothing Then
					ViewInvItemDetailsMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewInvItemDetailsMetadata._meta Is Nothing Then
                    ViewInvItemDetailsMetadata._meta = New ViewInvItemDetailsMetadata()
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
				meta.AddTypeMap("Shipmentnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Shipmentdate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Shippeddate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Receiveddate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Lotnumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Warehouselocation", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Warehousenumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Allocateddate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Receivernumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Itemstatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Inventoryclass", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Classdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Unitsremaining", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Receiverdocument", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Receiverdocumenttype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Ponumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Purchasereleasenumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Vendorname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Podate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Changeableponumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Allocateddocument", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Allocatedtype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Workordernumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Workordercustomer", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Shiptocustomer", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Plannedshipdate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("AvailableDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Sourcedocument", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Sourcetype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Sourcestatus", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewInvItemDetails"
				meta.Destination = "viewInvItemDetails"
				
				meta.spInsert = "proc_viewInvItemDetailsInsert"
				meta.spUpdate = "proc_viewInvItemDetailsUpdate"
				meta.spDelete = "proc_viewInvItemDetailsDelete"
				meta.spLoadAll = "proc_viewInvItemDetailsLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewInvItemDetailsLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewInvItemDetailsMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
