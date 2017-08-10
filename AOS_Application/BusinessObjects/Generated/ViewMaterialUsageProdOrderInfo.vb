'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 10/23/2015 1:17:58 PM
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
	MustInherit Public Class esViewMaterialUsageProdOrderInfoCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewMaterialUsageProdOrderInfoCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewMaterialUsageProdOrderInfoQuery)
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
            Me.InitQuery(CType(query, esViewMaterialUsageProdOrderInfoQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewMaterialUsageProdOrderInfo) As ViewMaterialUsageProdOrderInfo
			Return CType(MyBase.DetachEntity(entity), ViewMaterialUsageProdOrderInfo)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewMaterialUsageProdOrderInfo) As ViewMaterialUsageProdOrderInfo
			Return CType(MyBase.AttachEntity(entity), ViewMaterialUsageProdOrderInfo)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewMaterialUsageProdOrderInfoCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewMaterialUsageProdOrderInfo
            Get
                Return TryCast(MyBase.Item(index), ViewMaterialUsageProdOrderInfo)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewMaterialUsageProdOrderInfo)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewMaterialUsageProdOrderInfo	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewMaterialUsageProdOrderInfoQuery
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
												
						Case "Proditemnum"
							Me.str.Proditemnum = CType(value, string)
												
						Case "Prodordernum"
							Me.str.Prodordernum = CType(value, string)
												
						Case "Productqty"
							Me.str.Productqty = CType(value, string)
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Productdesc"
							Me.str.Productdesc = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "Orderstatus"
							Me.str.Orderstatus = CType(value, string)
												
						Case "Prodorderdate"
							Me.str.Prodorderdate = CType(value, string)
												
						Case "Neededby"
							Me.str.Neededby = CType(value, string)
												
						Case "Materialid"
							Me.str.Materialid = CType(value, string)
												
						Case "Materialdesc"
							Me.str.Materialdesc = CType(value, string)
												
						Case "Estimatedcompletiondate"
							Me.str.Estimatedcompletiondate = CType(value, string)
												
						Case "Uom"
							Me.str.Uom = CType(value, string)
												
						Case "Qty"
							Me.str.Qty = CType(value, string)
												
						Case "Iscomplete"
							Me.str.Iscomplete = CType(value, string)
												
						Case "Apisnum"
							Me.str.Apisnum = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Proditemnum"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Proditemnum = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Prodordernum"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Prodordernum = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Productqty"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productqty = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Prodorderdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Prodorderdate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Neededby"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Neededby = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Materialid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Materialid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Estimatedcompletiondate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Estimatedcompletiondate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Qty"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Qty = CType(value, Nullable(Of System.Double))
							End If
						
						Case "Iscomplete"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Iscomplete = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Apisnum"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Apisnum = CType(value, Nullable(Of System.Int32))
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
		' Maps to viewMaterialUsageProdOrderInfo.PRODITEMNUM
		' </summary>
		Public Overridable Property Proditemnum As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Proditemnum)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Proditemnum, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewMaterialUsageProdOrderInfo.PRODORDERNUM
		' </summary>
		Public Overridable Property Prodordernum As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Prodordernum)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Prodordernum, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewMaterialUsageProdOrderInfo.PRODUCTQTY
		' </summary>
		Public Overridable Property Productqty As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Productqty)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Productqty, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewMaterialUsageProdOrderInfo.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewMaterialUsageProdOrderInfo.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewMaterialUsageProdOrderInfo.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewMaterialUsageProdOrderInfo.ORDERSTATUS
		' </summary>
		Public Overridable Property Orderstatus As System.String
			Get
				Return MyBase.GetSystemString(ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Orderstatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Orderstatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewMaterialUsageProdOrderInfo.PRODORDERDATE
		' </summary>
		Public Overridable Property Prodorderdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Prodorderdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Prodorderdate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewMaterialUsageProdOrderInfo.NEEDEDBY
		' </summary>
		Public Overridable Property Neededby As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Neededby)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Neededby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewMaterialUsageProdOrderInfo.MATERIALID
		' </summary>
		Public Overridable Property Materialid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Materialid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Materialid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewMaterialUsageProdOrderInfo.MATERIALDESC
		' </summary>
		Public Overridable Property Materialdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Materialdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Materialdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewMaterialUsageProdOrderInfo.ESTIMATEDCOMPLETIONDATE
		' </summary>
		Public Overridable Property Estimatedcompletiondate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Estimatedcompletiondate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Estimatedcompletiondate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewMaterialUsageProdOrderInfo.UOM
		' </summary>
		Public Overridable Property Uom As System.String
			Get
				Return MyBase.GetSystemString(ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Uom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Uom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewMaterialUsageProdOrderInfo.QTY
		' </summary>
		Public Overridable Property Qty As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Qty)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Qty, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewMaterialUsageProdOrderInfo.ISCOMPLETE
		' </summary>
		Public Overridable Property Iscomplete As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Iscomplete)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Iscomplete, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewMaterialUsageProdOrderInfo.APISNUM
		' </summary>
		Public Overridable Property Apisnum As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Apisnum)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Apisnum, value)
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
		
			Public Sub New(ByVal entity As esViewMaterialUsageProdOrderInfo)
				Me.entity = entity
			End Sub				
		
	
			Public Property Proditemnum As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Proditemnum
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Proditemnum = Nothing
					Else
						entity.Proditemnum = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Prodordernum As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Prodordernum
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Prodordernum = Nothing
					Else
						entity.Prodordernum = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Productqty As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Productqty
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Productqty = Nothing
					Else
						entity.Productqty = Convert.ToInt32(Value)
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
		  	
			Public Property Orderstatus As System.String 
				Get
					Dim data_ As System.String = entity.Orderstatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Orderstatus = Nothing
					Else
						entity.Orderstatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Prodorderdate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Prodorderdate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Prodorderdate = Nothing
					Else
						entity.Prodorderdate = Convert.ToDateTime(Value)
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
		  	
			Public Property Materialid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Materialid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Materialid = Nothing
					Else
						entity.Materialid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Materialdesc As System.String 
				Get
					Dim data_ As System.String = entity.Materialdesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Materialdesc = Nothing
					Else
						entity.Materialdesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Estimatedcompletiondate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Estimatedcompletiondate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Estimatedcompletiondate = Nothing
					Else
						entity.Estimatedcompletiondate = Convert.ToDateTime(Value)
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
		  	
			Public Property Qty As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Qty
					
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
						entity.Qty = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property Iscomplete As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Iscomplete
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Iscomplete = Nothing
					Else
						entity.Iscomplete = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property Apisnum As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Apisnum
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Apisnum = Nothing
					Else
						entity.Apisnum = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewMaterialUsageProdOrderInfo
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewMaterialUsageProdOrderInfoQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewMaterialUsageProdOrderInfo can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewMaterialUsageProdOrderInfoQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewMaterialUsageProdOrderInfoMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Proditemnum As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Proditemnum, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Prodordernum As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Prodordernum, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productqty As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Productqty, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Orderstatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Orderstatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Prodorderdate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Prodorderdate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Neededby As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Neededby, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Materialid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Materialid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Materialdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Materialdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Estimatedcompletiondate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Estimatedcompletiondate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Uom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Uom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Qty As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Qty, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Iscomplete As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Iscomplete, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Apisnum As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Apisnum, esSystemType.Int32)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewMaterialUsageProdOrderInfoCollection")> _
	Partial Public Class ViewMaterialUsageProdOrderInfoCollection
		Inherits esViewMaterialUsageProdOrderInfoCollection
		Implements IEnumerable(Of ViewMaterialUsageProdOrderInfo)
		
        Public Shared Widening Operator CType(ByVal coll As ViewMaterialUsageProdOrderInfoCollection) As List(Of ViewMaterialUsageProdOrderInfo)
            Dim list As List(Of ViewMaterialUsageProdOrderInfo) = New List(Of ViewMaterialUsageProdOrderInfo)
            Dim emp As ViewMaterialUsageProdOrderInfo

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewMaterialUsageProdOrderInfoMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewMaterialUsageProdOrderInfoQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewMaterialUsageProdOrderInfo(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewMaterialUsageProdOrderInfo()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewMaterialUsageProdOrderInfoQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewMaterialUsageProdOrderInfoQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewMaterialUsageProdOrderInfoQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewMaterialUsageProdOrderInfo 
			Return CType(MyBase.AddNewEntity(), ViewMaterialUsageProdOrderInfo)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewMaterialUsageProdOrderInfo) Implements IEnumerable(Of ViewMaterialUsageProdOrderInfo).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewMaterialUsageProdOrderInfo)(Me)
        End Function
		
		Private _query As ViewMaterialUsageProdOrderInfoQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewMaterialUsageProdOrderInfo' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewMaterialUsageProdOrderInfo ()")> _
	<Serializable> _
	Partial Public Class ViewMaterialUsageProdOrderInfo 
		Inherits esViewMaterialUsageProdOrderInfo

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewMaterialUsageProdOrderInfoMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewMaterialUsageProdOrderInfoQuery

			If Me._query Is Nothing Then
				Me._query = New ViewMaterialUsageProdOrderInfoQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewMaterialUsageProdOrderInfoQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewMaterialUsageProdOrderInfoQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewMaterialUsageProdOrderInfoQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewMaterialUsageProdOrderInfoQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewMaterialUsageProdOrderInfoQuery
		inherits esViewMaterialUsageProdOrderInfoQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewMaterialUsageProdOrderInfoQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewMaterialUsageProdOrderInfoMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Proditemnum, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewMaterialUsageProdOrderInfoMetadata.PropertyNames.Proditemnum
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Prodordernum, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewMaterialUsageProdOrderInfoMetadata.PropertyNames.Prodordernum
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Productqty, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewMaterialUsageProdOrderInfoMetadata.PropertyNames.Productqty
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Productid, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewMaterialUsageProdOrderInfoMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Productdesc, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewMaterialUsageProdOrderInfoMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Container, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewMaterialUsageProdOrderInfoMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Orderstatus, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewMaterialUsageProdOrderInfoMetadata.PropertyNames.Orderstatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Prodorderdate, 7, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewMaterialUsageProdOrderInfoMetadata.PropertyNames.Prodorderdate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Neededby, 8, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewMaterialUsageProdOrderInfoMetadata.PropertyNames.Neededby
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Materialid, 9, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewMaterialUsageProdOrderInfoMetadata.PropertyNames.Materialid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Materialdesc, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewMaterialUsageProdOrderInfoMetadata.PropertyNames.Materialdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Estimatedcompletiondate, 11, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewMaterialUsageProdOrderInfoMetadata.PropertyNames.Estimatedcompletiondate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Uom, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewMaterialUsageProdOrderInfoMetadata.PropertyNames.Uom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Qty, 13, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewMaterialUsageProdOrderInfoMetadata.PropertyNames.Qty
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Iscomplete, 14, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewMaterialUsageProdOrderInfoMetadata.PropertyNames.Iscomplete
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewMaterialUsageProdOrderInfoMetadata.ColumnNames.Apisnum, 15, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewMaterialUsageProdOrderInfoMetadata.PropertyNames.Apisnum
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewMaterialUsageProdOrderInfoMetadata
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
			 Public Const Proditemnum As String = "PRODITEMNUM"
			 Public Const Prodordernum As String = "PRODORDERNUM"
			 Public Const Productqty As String = "PRODUCTQTY"
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Productdesc As String = "PRODUCTDESC"
			 Public Const Container As String = "CONTAINER"
			 Public Const Orderstatus As String = "ORDERSTATUS"
			 Public Const Prodorderdate As String = "PRODORDERDATE"
			 Public Const Neededby As String = "NEEDEDBY"
			 Public Const Materialid As String = "MATERIALID"
			 Public Const Materialdesc As String = "MATERIALDESC"
			 Public Const Estimatedcompletiondate As String = "ESTIMATEDCOMPLETIONDATE"
			 Public Const Uom As String = "UOM"
			 Public Const Qty As String = "QTY"
			 Public Const Iscomplete As String = "ISCOMPLETE"
			 Public Const Apisnum As String = "APISNUM"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Proditemnum As String = "Proditemnum"
			 Public Const Prodordernum As String = "Prodordernum"
			 Public Const Productqty As String = "Productqty"
			 Public Const Productid As String = "Productid"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const Container As String = "Container"
			 Public Const Orderstatus As String = "Orderstatus"
			 Public Const Prodorderdate As String = "Prodorderdate"
			 Public Const Neededby As String = "Neededby"
			 Public Const Materialid As String = "Materialid"
			 Public Const Materialdesc As String = "Materialdesc"
			 Public Const Estimatedcompletiondate As String = "Estimatedcompletiondate"
			 Public Const Uom As String = "Uom"
			 Public Const Qty As String = "Qty"
			 Public Const Iscomplete As String = "Iscomplete"
			 Public Const Apisnum As String = "Apisnum"
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
            SyncLock GetType(ViewMaterialUsageProdOrderInfoMetadata)
			
				If ViewMaterialUsageProdOrderInfoMetadata.mapDelegates Is Nothing Then
					ViewMaterialUsageProdOrderInfoMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewMaterialUsageProdOrderInfoMetadata._meta Is Nothing Then
                    ViewMaterialUsageProdOrderInfoMetadata._meta = New ViewMaterialUsageProdOrderInfoMetadata()
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
				

				meta.AddTypeMap("Proditemnum", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Prodordernum", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productqty", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Orderstatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Prodorderdate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Neededby", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Materialid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Materialdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Estimatedcompletiondate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Uom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Qty", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Iscomplete", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Apisnum", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "viewMaterialUsageProdOrderInfo"
				meta.Destination = "viewMaterialUsageProdOrderInfo"
				
				meta.spInsert = "proc_viewMaterialUsageProdOrderInfoInsert"
				meta.spUpdate = "proc_viewMaterialUsageProdOrderInfoUpdate"
				meta.spDelete = "proc_viewMaterialUsageProdOrderInfoDelete"
				meta.spLoadAll = "proc_viewMaterialUsageProdOrderInfoLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewMaterialUsageProdOrderInfoLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewMaterialUsageProdOrderInfoMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
