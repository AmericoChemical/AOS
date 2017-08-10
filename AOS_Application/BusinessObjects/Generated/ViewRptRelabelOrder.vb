'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 4/24/2015 1:34:02 PM
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
	MustInherit Public Class esViewRptRelabelOrderCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewRptRelabelOrderCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewRptRelabelOrderQuery)
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
            Me.InitQuery(CType(query, esViewRptRelabelOrderQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewRptRelabelOrder) As ViewRptRelabelOrder
			Return CType(MyBase.DetachEntity(entity), ViewRptRelabelOrder)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewRptRelabelOrder) As ViewRptRelabelOrder
			Return CType(MyBase.AttachEntity(entity), ViewRptRelabelOrder)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewRptRelabelOrderCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewRptRelabelOrder
            Get
                Return TryCast(MyBase.Item(index), ViewRptRelabelOrder)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewRptRelabelOrder)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewRptRelabelOrder	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewRptRelabelOrderQuery
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
												
						Case "Relabelordernumber"
							Me.str.Relabelordernumber = CType(value, string)
												
						Case "Relabelorderdate"
							Me.str.Relabelorderdate = CType(value, string)
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Qty"
							Me.str.Qty = CType(value, string)
												
						Case "Neededby"
							Me.str.Neededby = CType(value, string)
												
						Case "Itemid"
							Me.str.Itemid = CType(value, string)
												
						Case "Itemdesc"
							Me.str.Itemdesc = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "Workordernumber"
							Me.str.Workordernumber = CType(value, string)
												
						Case "Workorderitemnumber"
							Me.str.Workorderitemnumber = CType(value, string)
												
						Case "Relabelorderstatus"
							Me.str.Relabelorderstatus = CType(value, string)
												
						Case "Relabelorderitemnumber"
							Me.str.Relabelorderitemnumber = CType(value, string)
												
						Case "Custid"
							Me.str.Custid = CType(value, string)
												
						Case "Custname"
							Me.str.Custname = CType(value, string)
												
						Case "Relabelorderitemproductid"
							Me.str.Relabelorderitemproductid = CType(value, string)
												
						Case "Relabelorderitemproductdesc"
							Me.str.Relabelorderitemproductdesc = CType(value, string)
												
						Case "Relabelorderitemcontainer"
							Me.str.Relabelorderitemcontainer = CType(value, string)
												
						Case "Sourcetype"
							Me.str.Sourcetype = CType(value, string)
												
						Case "Sourcedoc"
							Me.str.Sourcedoc = CType(value, string)
												
						Case "Invitemnum"
							Me.str.Invitemnum = CType(value, string)
												
						Case "Itemstatus"
							Me.str.Itemstatus = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Relabelordernumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Relabelordernumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Relabelorderdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Relabelorderdate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Qty"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Qty = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Neededby"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Neededby = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Itemid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Itemid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Workordernumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Workordernumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Workorderitemnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Workorderitemnumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Relabelorderitemnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Relabelorderitemnumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Custid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Custid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Relabelorderitemproductid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Relabelorderitemproductid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Sourcedoc"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Sourcedoc = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Invitemnum"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Invitemnum = CType(value, Nullable(Of System.Int32))
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
		' Maps to viewRptRelabelOrder.RELABELORDERNUMBER
		' </summary>
		Public Overridable Property Relabelordernumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptRelabelOrderMetadata.ColumnNames.Relabelordernumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptRelabelOrderMetadata.ColumnNames.Relabelordernumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptRelabelOrder.RELABELORDERDATE
		' </summary>
		Public Overridable Property Relabelorderdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewRptRelabelOrderMetadata.ColumnNames.Relabelorderdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewRptRelabelOrderMetadata.ColumnNames.Relabelorderdate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptRelabelOrder.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptRelabelOrderMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptRelabelOrderMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptRelabelOrder.QTY
		' </summary>
		Public Overridable Property Qty As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptRelabelOrderMetadata.ColumnNames.Qty)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptRelabelOrderMetadata.ColumnNames.Qty, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptRelabelOrder.NEEDEDBY
		' </summary>
		Public Overridable Property Neededby As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewRptRelabelOrderMetadata.ColumnNames.Neededby)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewRptRelabelOrderMetadata.ColumnNames.Neededby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptRelabelOrder.ITEMID
		' </summary>
		Public Overridable Property Itemid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptRelabelOrderMetadata.ColumnNames.Itemid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptRelabelOrderMetadata.ColumnNames.Itemid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptRelabelOrder.ITEMDESC
		' </summary>
		Public Overridable Property Itemdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewRptRelabelOrderMetadata.ColumnNames.Itemdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptRelabelOrderMetadata.ColumnNames.Itemdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptRelabelOrder.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewRptRelabelOrderMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptRelabelOrderMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptRelabelOrder.WORKORDERNUMBER
		' </summary>
		Public Overridable Property Workordernumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptRelabelOrderMetadata.ColumnNames.Workordernumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptRelabelOrderMetadata.ColumnNames.Workordernumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptRelabelOrder.WORKORDERITEMNUMBER
		' </summary>
		Public Overridable Property Workorderitemnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptRelabelOrderMetadata.ColumnNames.Workorderitemnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptRelabelOrderMetadata.ColumnNames.Workorderitemnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptRelabelOrder.RELABELORDERSTATUS
		' </summary>
		Public Overridable Property Relabelorderstatus As System.String
			Get
				Return MyBase.GetSystemString(ViewRptRelabelOrderMetadata.ColumnNames.Relabelorderstatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptRelabelOrderMetadata.ColumnNames.Relabelorderstatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptRelabelOrder.RELABELORDERITEMNUMBER
		' </summary>
		Public Overridable Property Relabelorderitemnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptRelabelOrderMetadata.ColumnNames.Relabelorderitemnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptRelabelOrderMetadata.ColumnNames.Relabelorderitemnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptRelabelOrder.CUSTID
		' </summary>
		Public Overridable Property Custid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptRelabelOrderMetadata.ColumnNames.Custid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptRelabelOrderMetadata.ColumnNames.Custid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptRelabelOrder.CUSTNAME
		' </summary>
		Public Overridable Property Custname As System.String
			Get
				Return MyBase.GetSystemString(ViewRptRelabelOrderMetadata.ColumnNames.Custname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptRelabelOrderMetadata.ColumnNames.Custname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptRelabelOrder.RELABELORDERITEMPRODUCTID
		' </summary>
		Public Overridable Property Relabelorderitemproductid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptRelabelOrderMetadata.ColumnNames.Relabelorderitemproductid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptRelabelOrderMetadata.ColumnNames.Relabelorderitemproductid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptRelabelOrder.RELABELORDERITEMPRODUCTDESC
		' </summary>
		Public Overridable Property Relabelorderitemproductdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewRptRelabelOrderMetadata.ColumnNames.Relabelorderitemproductdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptRelabelOrderMetadata.ColumnNames.Relabelorderitemproductdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptRelabelOrder.RELABELORDERITEMCONTAINER
		' </summary>
		Public Overridable Property Relabelorderitemcontainer As System.String
			Get
				Return MyBase.GetSystemString(ViewRptRelabelOrderMetadata.ColumnNames.Relabelorderitemcontainer)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptRelabelOrderMetadata.ColumnNames.Relabelorderitemcontainer, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptRelabelOrder.SOURCETYPE
		' </summary>
		Public Overridable Property Sourcetype As System.String
			Get
				Return MyBase.GetSystemString(ViewRptRelabelOrderMetadata.ColumnNames.Sourcetype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptRelabelOrderMetadata.ColumnNames.Sourcetype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptRelabelOrder.SOURCEDOC
		' </summary>
		Public Overridable Property Sourcedoc As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptRelabelOrderMetadata.ColumnNames.Sourcedoc)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptRelabelOrderMetadata.ColumnNames.Sourcedoc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptRelabelOrder.INVITEMNUM
		' </summary>
		Public Overridable Property Invitemnum As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptRelabelOrderMetadata.ColumnNames.Invitemnum)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptRelabelOrderMetadata.ColumnNames.Invitemnum, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptRelabelOrder.ITEMSTATUS
		' </summary>
		Public Overridable Property Itemstatus As System.String
			Get
				Return MyBase.GetSystemString(ViewRptRelabelOrderMetadata.ColumnNames.Itemstatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptRelabelOrderMetadata.ColumnNames.Itemstatus, value)
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
		
			Public Sub New(ByVal entity As esViewRptRelabelOrder)
				Me.entity = entity
			End Sub				
		
	
			Public Property Relabelordernumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Relabelordernumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Relabelordernumber = Nothing
					Else
						entity.Relabelordernumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Relabelorderdate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Relabelorderdate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Relabelorderdate = Nothing
					Else
						entity.Relabelorderdate = Convert.ToDateTime(Value)
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
		  	
			Public Property Qty As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Qty
					
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
						entity.Qty = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Neededby As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Neededby
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Neededby = Nothing
					Else
						entity.Neededby = Convert.ToDateTime(Value)
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
		  	
			Public Property Itemdesc As System.String 
				Get
					Dim data_ As System.String = entity.Itemdesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Itemdesc = Nothing
					Else
						entity.Itemdesc = Convert.ToString(Value)
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
		  	
			Public Property Relabelorderstatus As System.String 
				Get
					Dim data_ As System.String = entity.Relabelorderstatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Relabelorderstatus = Nothing
					Else
						entity.Relabelorderstatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Relabelorderitemnumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Relabelorderitemnumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Relabelorderitemnumber = Nothing
					Else
						entity.Relabelorderitemnumber = Convert.ToInt32(Value)
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
		  	
			Public Property Relabelorderitemproductid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Relabelorderitemproductid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Relabelorderitemproductid = Nothing
					Else
						entity.Relabelorderitemproductid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Relabelorderitemproductdesc As System.String 
				Get
					Dim data_ As System.String = entity.Relabelorderitemproductdesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Relabelorderitemproductdesc = Nothing
					Else
						entity.Relabelorderitemproductdesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Relabelorderitemcontainer As System.String 
				Get
					Dim data_ As System.String = entity.Relabelorderitemcontainer
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Relabelorderitemcontainer = Nothing
					Else
						entity.Relabelorderitemcontainer = Convert.ToString(Value)
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
		  	
			Public Property Sourcedoc As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Sourcedoc
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Sourcedoc = Nothing
					Else
						entity.Sourcedoc = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Invitemnum As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Invitemnum
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Invitemnum = Nothing
					Else
						entity.Invitemnum = Convert.ToInt32(Value)
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
		  

			Private entity As esViewRptRelabelOrder
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewRptRelabelOrderQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewRptRelabelOrder can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewRptRelabelOrderQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRptRelabelOrderMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Relabelordernumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptRelabelOrderMetadata.ColumnNames.Relabelordernumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Relabelorderdate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptRelabelOrderMetadata.ColumnNames.Relabelorderdate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptRelabelOrderMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Qty As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptRelabelOrderMetadata.ColumnNames.Qty, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Neededby As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptRelabelOrderMetadata.ColumnNames.Neededby, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Itemid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptRelabelOrderMetadata.ColumnNames.Itemid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Itemdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptRelabelOrderMetadata.ColumnNames.Itemdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptRelabelOrderMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Workordernumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptRelabelOrderMetadata.ColumnNames.Workordernumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Workorderitemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptRelabelOrderMetadata.ColumnNames.Workorderitemnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Relabelorderstatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptRelabelOrderMetadata.ColumnNames.Relabelorderstatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Relabelorderitemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptRelabelOrderMetadata.ColumnNames.Relabelorderitemnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Custid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptRelabelOrderMetadata.ColumnNames.Custid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Custname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptRelabelOrderMetadata.ColumnNames.Custname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Relabelorderitemproductid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptRelabelOrderMetadata.ColumnNames.Relabelorderitemproductid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Relabelorderitemproductdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptRelabelOrderMetadata.ColumnNames.Relabelorderitemproductdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Relabelorderitemcontainer As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptRelabelOrderMetadata.ColumnNames.Relabelorderitemcontainer, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Sourcetype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptRelabelOrderMetadata.ColumnNames.Sourcetype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Sourcedoc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptRelabelOrderMetadata.ColumnNames.Sourcedoc, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Invitemnum As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptRelabelOrderMetadata.ColumnNames.Invitemnum, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Itemstatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptRelabelOrderMetadata.ColumnNames.Itemstatus, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewRptRelabelOrderCollection")> _
	Partial Public Class ViewRptRelabelOrderCollection
		Inherits esViewRptRelabelOrderCollection
		Implements IEnumerable(Of ViewRptRelabelOrder)
		
        Public Shared Widening Operator CType(ByVal coll As ViewRptRelabelOrderCollection) As List(Of ViewRptRelabelOrder)
            Dim list As List(Of ViewRptRelabelOrder) = New List(Of ViewRptRelabelOrder)
            Dim emp As ViewRptRelabelOrder

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRptRelabelOrderMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewRptRelabelOrderQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewRptRelabelOrder(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewRptRelabelOrder()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewRptRelabelOrderQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewRptRelabelOrderQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRptRelabelOrderQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewRptRelabelOrder 
			Return CType(MyBase.AddNewEntity(), ViewRptRelabelOrder)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewRptRelabelOrder) Implements IEnumerable(Of ViewRptRelabelOrder).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewRptRelabelOrder)(Me)
        End Function
		
		Private _query As ViewRptRelabelOrderQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewRptRelabelOrder' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewRptRelabelOrder ()")> _
	<Serializable> _
	Partial Public Class ViewRptRelabelOrder 
		Inherits esViewRptRelabelOrder

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewRptRelabelOrderMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewRptRelabelOrderQuery

			If Me._query Is Nothing Then
				Me._query = New ViewRptRelabelOrderQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewRptRelabelOrderQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewRptRelabelOrderQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRptRelabelOrderQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewRptRelabelOrderQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewRptRelabelOrderQuery
		inherits esViewRptRelabelOrderQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewRptRelabelOrderQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewRptRelabelOrderMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewRptRelabelOrderMetadata.ColumnNames.Relabelordernumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptRelabelOrderMetadata.PropertyNames.Relabelordernumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptRelabelOrderMetadata.ColumnNames.Relabelorderdate, 1, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewRptRelabelOrderMetadata.PropertyNames.Relabelorderdate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptRelabelOrderMetadata.ColumnNames.Productid, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptRelabelOrderMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptRelabelOrderMetadata.ColumnNames.Qty, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptRelabelOrderMetadata.PropertyNames.Qty
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptRelabelOrderMetadata.ColumnNames.Neededby, 4, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewRptRelabelOrderMetadata.PropertyNames.Neededby
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptRelabelOrderMetadata.ColumnNames.Itemid, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptRelabelOrderMetadata.PropertyNames.Itemid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptRelabelOrderMetadata.ColumnNames.Itemdesc, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptRelabelOrderMetadata.PropertyNames.Itemdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptRelabelOrderMetadata.ColumnNames.Container, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptRelabelOrderMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptRelabelOrderMetadata.ColumnNames.Workordernumber, 8, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptRelabelOrderMetadata.PropertyNames.Workordernumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptRelabelOrderMetadata.ColumnNames.Workorderitemnumber, 9, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptRelabelOrderMetadata.PropertyNames.Workorderitemnumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptRelabelOrderMetadata.ColumnNames.Relabelorderstatus, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptRelabelOrderMetadata.PropertyNames.Relabelorderstatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptRelabelOrderMetadata.ColumnNames.Relabelorderitemnumber, 11, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptRelabelOrderMetadata.PropertyNames.Relabelorderitemnumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptRelabelOrderMetadata.ColumnNames.Custid, 12, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptRelabelOrderMetadata.PropertyNames.Custid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptRelabelOrderMetadata.ColumnNames.Custname, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptRelabelOrderMetadata.PropertyNames.Custname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptRelabelOrderMetadata.ColumnNames.Relabelorderitemproductid, 14, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptRelabelOrderMetadata.PropertyNames.Relabelorderitemproductid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptRelabelOrderMetadata.ColumnNames.Relabelorderitemproductdesc, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptRelabelOrderMetadata.PropertyNames.Relabelorderitemproductdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptRelabelOrderMetadata.ColumnNames.Relabelorderitemcontainer, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptRelabelOrderMetadata.PropertyNames.Relabelorderitemcontainer
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptRelabelOrderMetadata.ColumnNames.Sourcetype, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptRelabelOrderMetadata.PropertyNames.Sourcetype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptRelabelOrderMetadata.ColumnNames.Sourcedoc, 18, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptRelabelOrderMetadata.PropertyNames.Sourcedoc
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptRelabelOrderMetadata.ColumnNames.Invitemnum, 19, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptRelabelOrderMetadata.PropertyNames.Invitemnum
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptRelabelOrderMetadata.ColumnNames.Itemstatus, 20, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptRelabelOrderMetadata.PropertyNames.Itemstatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewRptRelabelOrderMetadata
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
			 Public Const Relabelordernumber As String = "RELABELORDERNUMBER"
			 Public Const Relabelorderdate As String = "RELABELORDERDATE"
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Qty As String = "QTY"
			 Public Const Neededby As String = "NEEDEDBY"
			 Public Const Itemid As String = "ITEMID"
			 Public Const Itemdesc As String = "ITEMDESC"
			 Public Const Container As String = "CONTAINER"
			 Public Const Workordernumber As String = "WORKORDERNUMBER"
			 Public Const Workorderitemnumber As String = "WORKORDERITEMNUMBER"
			 Public Const Relabelorderstatus As String = "RELABELORDERSTATUS"
			 Public Const Relabelorderitemnumber As String = "RELABELORDERITEMNUMBER"
			 Public Const Custid As String = "CUSTID"
			 Public Const Custname As String = "CUSTNAME"
			 Public Const Relabelorderitemproductid As String = "RELABELORDERITEMPRODUCTID"
			 Public Const Relabelorderitemproductdesc As String = "RELABELORDERITEMPRODUCTDESC"
			 Public Const Relabelorderitemcontainer As String = "RELABELORDERITEMCONTAINER"
			 Public Const Sourcetype As String = "SOURCETYPE"
			 Public Const Sourcedoc As String = "SOURCEDOC"
			 Public Const Invitemnum As String = "INVITEMNUM"
			 Public Const Itemstatus As String = "ITEMSTATUS"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Relabelordernumber As String = "Relabelordernumber"
			 Public Const Relabelorderdate As String = "Relabelorderdate"
			 Public Const Productid As String = "Productid"
			 Public Const Qty As String = "Qty"
			 Public Const Neededby As String = "Neededby"
			 Public Const Itemid As String = "Itemid"
			 Public Const Itemdesc As String = "Itemdesc"
			 Public Const Container As String = "Container"
			 Public Const Workordernumber As String = "Workordernumber"
			 Public Const Workorderitemnumber As String = "Workorderitemnumber"
			 Public Const Relabelorderstatus As String = "Relabelorderstatus"
			 Public Const Relabelorderitemnumber As String = "Relabelorderitemnumber"
			 Public Const Custid As String = "Custid"
			 Public Const Custname As String = "Custname"
			 Public Const Relabelorderitemproductid As String = "Relabelorderitemproductid"
			 Public Const Relabelorderitemproductdesc As String = "Relabelorderitemproductdesc"
			 Public Const Relabelorderitemcontainer As String = "Relabelorderitemcontainer"
			 Public Const Sourcetype As String = "Sourcetype"
			 Public Const Sourcedoc As String = "Sourcedoc"
			 Public Const Invitemnum As String = "Invitemnum"
			 Public Const Itemstatus As String = "Itemstatus"
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
            SyncLock GetType(ViewRptRelabelOrderMetadata)
			
				If ViewRptRelabelOrderMetadata.mapDelegates Is Nothing Then
					ViewRptRelabelOrderMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewRptRelabelOrderMetadata._meta Is Nothing Then
                    ViewRptRelabelOrderMetadata._meta = New ViewRptRelabelOrderMetadata()
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
				

				meta.AddTypeMap("Relabelordernumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Relabelorderdate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Productid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Qty", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Neededby", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Itemid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Itemdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Workordernumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Workorderitemnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Relabelorderstatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Relabelorderitemnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Custid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Custname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Relabelorderitemproductid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Relabelorderitemproductdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Relabelorderitemcontainer", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Sourcetype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Sourcedoc", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Invitemnum", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Itemstatus", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewRptRelabelOrder"
				meta.Destination = "viewRptRelabelOrder"
				
				meta.spInsert = "proc_viewRptRelabelOrderInsert"
				meta.spUpdate = "proc_viewRptRelabelOrderUpdate"
				meta.spDelete = "proc_viewRptRelabelOrderDelete"
				meta.spLoadAll = "proc_viewRptRelabelOrderLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewRptRelabelOrderLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewRptRelabelOrderMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
