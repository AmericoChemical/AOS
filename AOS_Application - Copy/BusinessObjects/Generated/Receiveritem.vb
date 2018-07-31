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
	MustInherit Public Class esReceiveritemCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ReceiveritemCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esReceiveritemQuery)
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
            Me.InitQuery(CType(query, esReceiveritemQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Receiveritem) As Receiveritem
			Return CType(MyBase.DetachEntity(entity), Receiveritem)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Receiveritem) As Receiveritem
			Return CType(MyBase.AttachEntity(entity), Receiveritem)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ReceiveritemCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Receiveritem
            Get
                Return TryCast(MyBase.Item(index), Receiveritem)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Receiveritem)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esReceiveritem	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esReceiveritemQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal receiveritemnumber As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(receiveritemnumber)
			Else
				Return LoadByPrimaryKeyStoredProcedure(receiveritemnumber)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal receiveritemnumber As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(receiveritemnumber)
			Else
				Return LoadByPrimaryKeyStoredProcedure(receiveritemnumber)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal receiveritemnumber As System.Int32) As Boolean
		
			Dim query As esReceiveritemQuery = Me.GetDynamicQuery()
			query.Where(query.Receiveritemnumber.Equal(receiveritemnumber))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal receiveritemnumber As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("RECEIVERITEMNUMBER", receiveritemnumber)
			
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
												
						Case "Receiveritemnumber"
							Me.str.Receiveritemnumber = CType(value, string)
												
						Case "Receivernumber"
							Me.str.Receivernumber = CType(value, string)
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Productdesc"
							Me.str.Productdesc = CType(value, string)
												
						Case "Qtyreceived"
							Me.str.Qtyreceived = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "Lotnumber"
							Me.str.Lotnumber = CType(value, string)
												
						Case "Warehousenumber"
							Me.str.Warehousenumber = CType(value, string)
												
						Case "Warehouselocation"
							Me.str.Warehouselocation = CType(value, string)
												
						Case "Posted"
							Me.str.Posted = CType(value, string)
												
						Case "Unitcost"
							Me.str.Unitcost = CType(value, string)
												
						Case "Unitorcontainer"
							Me.str.Unitorcontainer = CType(value, string)
												
						Case "Units"
							Me.str.Units = CType(value, string)
												
						Case "Uom"
							Me.str.Uom = CType(value, string)
												
						Case "Inventoryclass"
							Me.str.Inventoryclass = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Receiveritemnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Receiveritemnumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Receivernumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Receivernumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Qtyreceived"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Qtyreceived = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Warehousenumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Warehousenumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Unitcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Unitcost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Units"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Units = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Inventoryclass"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Inventoryclass = CType(value, Nullable(Of System.Int32))
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
		' Maps to RECEIVERITEM.RECEIVERITEMNUMBER
		' </summary>
		Public Overridable Property Receiveritemnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ReceiveritemMetadata.ColumnNames.Receiveritemnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ReceiveritemMetadata.ColumnNames.Receiveritemnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RECEIVERITEM.RECEIVERNUMBER
		' </summary>
		Public Overridable Property Receivernumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ReceiveritemMetadata.ColumnNames.Receivernumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ReceiveritemMetadata.ColumnNames.Receivernumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RECEIVERITEM.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ReceiveritemMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ReceiveritemMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RECEIVERITEM.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ReceiveritemMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ReceiveritemMetadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RECEIVERITEM.QTYRECEIVED
		' </summary>
		Public Overridable Property Qtyreceived As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ReceiveritemMetadata.ColumnNames.Qtyreceived)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ReceiveritemMetadata.ColumnNames.Qtyreceived, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RECEIVERITEM.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ReceiveritemMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ReceiveritemMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RECEIVERITEM.LOTNUMBER
		' </summary>
		Public Overridable Property Lotnumber As System.String
			Get
				Return MyBase.GetSystemString(ReceiveritemMetadata.ColumnNames.Lotnumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ReceiveritemMetadata.ColumnNames.Lotnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RECEIVERITEM.WAREHOUSENUMBER
		' </summary>
		Public Overridable Property Warehousenumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ReceiveritemMetadata.ColumnNames.Warehousenumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ReceiveritemMetadata.ColumnNames.Warehousenumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RECEIVERITEM.WAREHOUSELOCATION
		' </summary>
		Public Overridable Property Warehouselocation As System.String
			Get
				Return MyBase.GetSystemString(ReceiveritemMetadata.ColumnNames.Warehouselocation)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ReceiveritemMetadata.ColumnNames.Warehouselocation, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RECEIVERITEM.POSTED
		' </summary>
		Public Overridable Property Posted As System.String
			Get
				Return MyBase.GetSystemString(ReceiveritemMetadata.ColumnNames.Posted)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ReceiveritemMetadata.ColumnNames.Posted, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RECEIVERITEM.UNITCOST
		' </summary>
		Public Overridable Property Unitcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ReceiveritemMetadata.ColumnNames.Unitcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ReceiveritemMetadata.ColumnNames.Unitcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RECEIVERITEM.UNITORCONTAINER
		' </summary>
		Public Overridable Property Unitorcontainer As System.String
			Get
				Return MyBase.GetSystemString(ReceiveritemMetadata.ColumnNames.Unitorcontainer)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ReceiveritemMetadata.ColumnNames.Unitorcontainer, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RECEIVERITEM.UNITS
		' </summary>
		Public Overridable Property Units As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ReceiveritemMetadata.ColumnNames.Units)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ReceiveritemMetadata.ColumnNames.Units, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RECEIVERITEM.UOM
		' </summary>
		Public Overridable Property Uom As System.String
			Get
				Return MyBase.GetSystemString(ReceiveritemMetadata.ColumnNames.Uom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ReceiveritemMetadata.ColumnNames.Uom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RECEIVERITEM.INVENTORYCLASS
		' </summary>
		Public Overridable Property Inventoryclass As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ReceiveritemMetadata.ColumnNames.Inventoryclass)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ReceiveritemMetadata.ColumnNames.Inventoryclass, value)
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
		
			Public Sub New(ByVal entity As esReceiveritem)
				Me.entity = entity
			End Sub				
		
	
			Public Property Receiveritemnumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Receiveritemnumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Receiveritemnumber = Nothing
					Else
						entity.Receiveritemnumber = Convert.ToInt32(Value)
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
		  	
			Public Property Qtyreceived As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Qtyreceived
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qtyreceived = Nothing
					Else
						entity.Qtyreceived = Convert.ToDecimal(Value)
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
		  	
			Public Property Posted As System.String 
				Get
					Dim data_ As System.String = entity.Posted
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Posted = Nothing
					Else
						entity.Posted = Convert.ToString(Value)
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
		  	
			Public Property Units As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Units
					
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
						entity.Units = Convert.ToInt32(Value)
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
		  

			Private entity As esReceiveritem
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esReceiveritemQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esReceiveritem can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Receiveritem 
		Inherits esReceiveritem
		
	
		
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
	MustInherit Public Class esReceiveritemQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ReceiveritemMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Receiveritemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ReceiveritemMetadata.ColumnNames.Receiveritemnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Receivernumber As esQueryItem
			Get
				Return New esQueryItem(Me, ReceiveritemMetadata.ColumnNames.Receivernumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ReceiveritemMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ReceiveritemMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Qtyreceived As esQueryItem
			Get
				Return New esQueryItem(Me, ReceiveritemMetadata.ColumnNames.Qtyreceived, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ReceiveritemMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Lotnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ReceiveritemMetadata.ColumnNames.Lotnumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Warehousenumber As esQueryItem
			Get
				Return New esQueryItem(Me, ReceiveritemMetadata.ColumnNames.Warehousenumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Warehouselocation As esQueryItem
			Get
				Return New esQueryItem(Me, ReceiveritemMetadata.ColumnNames.Warehouselocation, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Posted As esQueryItem
			Get
				Return New esQueryItem(Me, ReceiveritemMetadata.ColumnNames.Posted, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Unitcost As esQueryItem
			Get
				Return New esQueryItem(Me, ReceiveritemMetadata.ColumnNames.Unitcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Unitorcontainer As esQueryItem
			Get
				Return New esQueryItem(Me, ReceiveritemMetadata.ColumnNames.Unitorcontainer, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Units As esQueryItem
			Get
				Return New esQueryItem(Me, ReceiveritemMetadata.ColumnNames.Units, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Uom As esQueryItem
			Get
				Return New esQueryItem(Me, ReceiveritemMetadata.ColumnNames.Uom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Inventoryclass As esQueryItem
			Get
				Return New esQueryItem(Me, ReceiveritemMetadata.ColumnNames.Inventoryclass, esSystemType.Int32)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ReceiveritemCollection")> _
	Partial Public Class ReceiveritemCollection
		Inherits esReceiveritemCollection
		Implements IEnumerable(Of Receiveritem)
		
        Public Shared Widening Operator CType(ByVal coll As ReceiveritemCollection) As List(Of Receiveritem)
            Dim list As List(Of Receiveritem) = New List(Of Receiveritem)
            Dim emp As Receiveritem

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ReceiveritemMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ReceiveritemQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Receiveritem(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Receiveritem()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As ReceiveritemQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ReceiveritemQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ReceiveritemQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Receiveritem 
			Return CType(MyBase.AddNewEntity(), Receiveritem)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal receiveritemnumber As System.Int32) As Receiveritem
			Return CType(MyBase.FindByPrimaryKey(receiveritemnumber), Receiveritem)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Receiveritem) Implements IEnumerable(Of Receiveritem).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Receiveritem)(Me)
        End Function
		
		Private _query As ReceiveritemQuery

	End Class
	


	' <summary>
	' Encapsulates the 'RECEIVERITEM' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Receiveritem ({Receiveritemnumber.Value})")> _
	<Serializable> _
	Partial Public Class Receiveritem 
		Inherits esReceiveritem

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ReceiveritemMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esReceiveritemQuery

			If Me._query Is Nothing Then
				Me._query = New ReceiveritemQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ReceiveritemQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ReceiveritemQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ReceiveritemQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ReceiveritemQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ReceiveritemQuery
		inherits esReceiveritemQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ReceiveritemQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ReceiveritemMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ReceiveritemMetadata.ColumnNames.Receiveritemnumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ReceiveritemMetadata.PropertyNames.Receiveritemnumber
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ReceiveritemMetadata.ColumnNames.Receivernumber, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ReceiveritemMetadata.PropertyNames.Receivernumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ReceiveritemMetadata.ColumnNames.Productid, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ReceiveritemMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ReceiveritemMetadata.ColumnNames.Productdesc, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ReceiveritemMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ReceiveritemMetadata.ColumnNames.Qtyreceived, 4, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ReceiveritemMetadata.PropertyNames.Qtyreceived
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ReceiveritemMetadata.ColumnNames.Container, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ReceiveritemMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ReceiveritemMetadata.ColumnNames.Lotnumber, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ReceiveritemMetadata.PropertyNames.Lotnumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ReceiveritemMetadata.ColumnNames.Warehousenumber, 7, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ReceiveritemMetadata.PropertyNames.Warehousenumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ReceiveritemMetadata.ColumnNames.Warehouselocation, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ReceiveritemMetadata.PropertyNames.Warehouselocation
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ReceiveritemMetadata.ColumnNames.Posted, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ReceiveritemMetadata.PropertyNames.Posted
			c.CharacterMaxLength = 1
			c.HasDefault = True
			c.Default = "('N')"
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ReceiveritemMetadata.ColumnNames.Unitcost, 10, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ReceiveritemMetadata.PropertyNames.Unitcost
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ReceiveritemMetadata.ColumnNames.Unitorcontainer, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = ReceiveritemMetadata.PropertyNames.Unitorcontainer
			c.CharacterMaxLength = 1
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ReceiveritemMetadata.ColumnNames.Units, 12, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ReceiveritemMetadata.PropertyNames.Units
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ReceiveritemMetadata.ColumnNames.Uom, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = ReceiveritemMetadata.PropertyNames.Uom
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ReceiveritemMetadata.ColumnNames.Inventoryclass, 14, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ReceiveritemMetadata.PropertyNames.Inventoryclass
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ReceiveritemMetadata
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
			 Public Const Receiveritemnumber As String = "RECEIVERITEMNUMBER"
			 Public Const Receivernumber As String = "RECEIVERNUMBER"
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Productdesc As String = "PRODUCTDESC"
			 Public Const Qtyreceived As String = "QTYRECEIVED"
			 Public Const Container As String = "CONTAINER"
			 Public Const Lotnumber As String = "LOTNUMBER"
			 Public Const Warehousenumber As String = "WAREHOUSENUMBER"
			 Public Const Warehouselocation As String = "WAREHOUSELOCATION"
			 Public Const Posted As String = "POSTED"
			 Public Const Unitcost As String = "UNITCOST"
			 Public Const Unitorcontainer As String = "UNITORCONTAINER"
			 Public Const Units As String = "UNITS"
			 Public Const Uom As String = "UOM"
			 Public Const Inventoryclass As String = "INVENTORYCLASS"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Receiveritemnumber As String = "Receiveritemnumber"
			 Public Const Receivernumber As String = "Receivernumber"
			 Public Const Productid As String = "Productid"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const Qtyreceived As String = "Qtyreceived"
			 Public Const Container As String = "Container"
			 Public Const Lotnumber As String = "Lotnumber"
			 Public Const Warehousenumber As String = "Warehousenumber"
			 Public Const Warehouselocation As String = "Warehouselocation"
			 Public Const Posted As String = "Posted"
			 Public Const Unitcost As String = "Unitcost"
			 Public Const Unitorcontainer As String = "Unitorcontainer"
			 Public Const Units As String = "Units"
			 Public Const Uom As String = "Uom"
			 Public Const Inventoryclass As String = "Inventoryclass"
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
            SyncLock GetType(ReceiveritemMetadata)
			
				If ReceiveritemMetadata.mapDelegates Is Nothing Then
					ReceiveritemMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ReceiveritemMetadata._meta Is Nothing Then
                    ReceiveritemMetadata._meta = New ReceiveritemMetadata()
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
				

				meta.AddTypeMap("Receiveritemnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Receivernumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Qtyreceived", new esTypeMap("numeric", "System.Decimal"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Lotnumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Warehousenumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Warehouselocation", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Posted", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Unitcost", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Unitorcontainer", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Units", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Uom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Inventoryclass", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "RECEIVERITEM"
				meta.Destination = "RECEIVERITEM"
				
				meta.spInsert = "proc_RECEIVERITEMInsert"
				meta.spUpdate = "proc_RECEIVERITEMUpdate"
				meta.spDelete = "proc_RECEIVERITEMDelete"
				meta.spLoadAll = "proc_RECEIVERITEMLoadAll"
				meta.spLoadByPrimaryKey = "proc_RECEIVERITEMLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ReceiveritemMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
