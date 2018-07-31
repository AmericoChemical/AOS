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
	MustInherit Public Class esReceiverCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ReceiverCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esReceiverQuery)
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
            Me.InitQuery(CType(query, esReceiverQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Receiver) As Receiver
			Return CType(MyBase.DetachEntity(entity), Receiver)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Receiver) As Receiver
			Return CType(MyBase.AttachEntity(entity), Receiver)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ReceiverCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Receiver
            Get
                Return TryCast(MyBase.Item(index), Receiver)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Receiver)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esReceiver	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esReceiverQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal receivernumber As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(receivernumber)
			Else
				Return LoadByPrimaryKeyStoredProcedure(receivernumber)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal receivernumber As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(receivernumber)
			Else
				Return LoadByPrimaryKeyStoredProcedure(receivernumber)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal receivernumber As System.Int32) As Boolean
		
			Dim query As esReceiverQuery = Me.GetDynamicQuery()
			query.Where(query.Receivernumber.Equal(receivernumber))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal receivernumber As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("RECEIVERNUMBER", receivernumber)
			
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
												
						Case "Receivernumber"
							Me.str.Receivernumber = CType(value, string)
												
						Case "Receiveddate"
							Me.str.Receiveddate = CType(value, string)
												
						Case "Receiverdocument"
							Me.str.Receiverdocument = CType(value, string)
												
						Case "Receiverdocumenttype"
							Me.str.Receiverdocumenttype = CType(value, string)
												
						Case "Inboundwarehouse"
							Me.str.Inboundwarehouse = CType(value, string)
												
						Case "Posted"
							Me.str.Posted = CType(value, string)
												
						Case "Vendorid"
							Me.str.Vendorid = CType(value, string)
												
						Case "Ponumber"
							Me.str.Ponumber = CType(value, string)
												
						Case "Purchasereleasenumber"
							Me.str.Purchasereleasenumber = CType(value, string)
												
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
						
						Case "Receivernumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Receivernumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Receiveddate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Receiveddate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Inboundwarehouse"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Inboundwarehouse = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Posted"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Posted = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Vendorid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Vendorid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Ponumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Ponumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Purchasereleasenumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Purchasereleasenumber = CType(value, Nullable(Of System.Int32))
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
		' Maps to RECEIVER.RECEIVERNUMBER
		' </summary>
		Public Overridable Property Receivernumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ReceiverMetadata.ColumnNames.Receivernumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ReceiverMetadata.ColumnNames.Receivernumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RECEIVER.RECEIVEDDATE
		' </summary>
		Public Overridable Property Receiveddate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ReceiverMetadata.ColumnNames.Receiveddate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ReceiverMetadata.ColumnNames.Receiveddate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RECEIVER.RECEIVERDOCUMENT
		' </summary>
		Public Overridable Property Receiverdocument As System.String
			Get
				Return MyBase.GetSystemString(ReceiverMetadata.ColumnNames.Receiverdocument)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ReceiverMetadata.ColumnNames.Receiverdocument, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RECEIVER.RECEIVERDOCUMENTTYPE
		' </summary>
		Public Overridable Property Receiverdocumenttype As System.String
			Get
				Return MyBase.GetSystemString(ReceiverMetadata.ColumnNames.Receiverdocumenttype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ReceiverMetadata.ColumnNames.Receiverdocumenttype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RECEIVER.INBOUNDWAREHOUSE
		' </summary>
		Public Overridable Property Inboundwarehouse As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ReceiverMetadata.ColumnNames.Inboundwarehouse)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ReceiverMetadata.ColumnNames.Inboundwarehouse, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RECEIVER.POSTED
		' </summary>
		Public Overridable Property Posted As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ReceiverMetadata.ColumnNames.Posted)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ReceiverMetadata.ColumnNames.Posted, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RECEIVER.VENDORID
		' </summary>
		Public Overridable Property Vendorid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ReceiverMetadata.ColumnNames.Vendorid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ReceiverMetadata.ColumnNames.Vendorid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RECEIVER.PONUMBER
		' </summary>
		Public Overridable Property Ponumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ReceiverMetadata.ColumnNames.Ponumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ReceiverMetadata.ColumnNames.Ponumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RECEIVER.PURCHASERELEASENUMBER
		' </summary>
		Public Overridable Property Purchasereleasenumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ReceiverMetadata.ColumnNames.Purchasereleasenumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ReceiverMetadata.ColumnNames.Purchasereleasenumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RECEIVER.CREATEDBY
		' </summary>
		Public Overridable Property Createdby As System.String
			Get
				Return MyBase.GetSystemString(ReceiverMetadata.ColumnNames.Createdby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ReceiverMetadata.ColumnNames.Createdby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RECEIVER.CREATEDTIME
		' </summary>
		Public Overridable Property Createdtime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ReceiverMetadata.ColumnNames.Createdtime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ReceiverMetadata.ColumnNames.Createdtime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RECEIVER.MODIFYBY
		' </summary>
		Public Overridable Property Modifyby As System.String
			Get
				Return MyBase.GetSystemString(ReceiverMetadata.ColumnNames.Modifyby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ReceiverMetadata.ColumnNames.Modifyby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RECEIVER.MODIFYTIME
		' </summary>
		Public Overridable Property Modifytime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ReceiverMetadata.ColumnNames.Modifytime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ReceiverMetadata.ColumnNames.Modifytime, value)
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
		
			Public Sub New(ByVal entity As esReceiver)
				Me.entity = entity
			End Sub				
		
	
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
		  	
			Public Property Inboundwarehouse As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Inboundwarehouse
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Inboundwarehouse = Nothing
					Else
						entity.Inboundwarehouse = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Posted As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Posted
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Posted = Nothing
					Else
						entity.Posted = Convert.ToDateTime(Value)
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
		  

			Private entity As esReceiver
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esReceiverQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esReceiver can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Receiver 
		Inherits esReceiver
		
	
		
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
	MustInherit Public Class esReceiverQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ReceiverMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Receivernumber As esQueryItem
			Get
				Return New esQueryItem(Me, ReceiverMetadata.ColumnNames.Receivernumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Receiveddate As esQueryItem
			Get
				Return New esQueryItem(Me, ReceiverMetadata.ColumnNames.Receiveddate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Receiverdocument As esQueryItem
			Get
				Return New esQueryItem(Me, ReceiverMetadata.ColumnNames.Receiverdocument, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Receiverdocumenttype As esQueryItem
			Get
				Return New esQueryItem(Me, ReceiverMetadata.ColumnNames.Receiverdocumenttype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Inboundwarehouse As esQueryItem
			Get
				Return New esQueryItem(Me, ReceiverMetadata.ColumnNames.Inboundwarehouse, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Posted As esQueryItem
			Get
				Return New esQueryItem(Me, ReceiverMetadata.ColumnNames.Posted, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Vendorid As esQueryItem
			Get
				Return New esQueryItem(Me, ReceiverMetadata.ColumnNames.Vendorid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Ponumber As esQueryItem
			Get
				Return New esQueryItem(Me, ReceiverMetadata.ColumnNames.Ponumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Purchasereleasenumber As esQueryItem
			Get
				Return New esQueryItem(Me, ReceiverMetadata.ColumnNames.Purchasereleasenumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Createdby As esQueryItem
			Get
				Return New esQueryItem(Me, ReceiverMetadata.ColumnNames.Createdby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Createdtime As esQueryItem
			Get
				Return New esQueryItem(Me, ReceiverMetadata.ColumnNames.Createdtime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Modifyby As esQueryItem
			Get
				Return New esQueryItem(Me, ReceiverMetadata.ColumnNames.Modifyby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Modifytime As esQueryItem
			Get
				Return New esQueryItem(Me, ReceiverMetadata.ColumnNames.Modifytime, esSystemType.DateTime)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ReceiverCollection")> _
	Partial Public Class ReceiverCollection
		Inherits esReceiverCollection
		Implements IEnumerable(Of Receiver)
		
        Public Shared Widening Operator CType(ByVal coll As ReceiverCollection) As List(Of Receiver)
            Dim list As List(Of Receiver) = New List(Of Receiver)
            Dim emp As Receiver

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ReceiverMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ReceiverQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Receiver(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Receiver()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As ReceiverQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ReceiverQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ReceiverQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Receiver 
			Return CType(MyBase.AddNewEntity(), Receiver)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal receivernumber As System.Int32) As Receiver
			Return CType(MyBase.FindByPrimaryKey(receivernumber), Receiver)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Receiver) Implements IEnumerable(Of Receiver).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Receiver)(Me)
        End Function
		
		Private _query As ReceiverQuery

	End Class
	


	' <summary>
	' Encapsulates the 'RECEIVER' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Receiver ({Receivernumber.Value})")> _
	<Serializable> _
	Partial Public Class Receiver 
		Inherits esReceiver

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ReceiverMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esReceiverQuery

			If Me._query Is Nothing Then
				Me._query = New ReceiverQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ReceiverQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ReceiverQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ReceiverQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ReceiverQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ReceiverQuery
		inherits esReceiverQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ReceiverQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ReceiverMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ReceiverMetadata.ColumnNames.Receivernumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ReceiverMetadata.PropertyNames.Receivernumber
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ReceiverMetadata.ColumnNames.Receiveddate, 1, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ReceiverMetadata.PropertyNames.Receiveddate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ReceiverMetadata.ColumnNames.Receiverdocument, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ReceiverMetadata.PropertyNames.Receiverdocument
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ReceiverMetadata.ColumnNames.Receiverdocumenttype, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ReceiverMetadata.PropertyNames.Receiverdocumenttype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ReceiverMetadata.ColumnNames.Inboundwarehouse, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ReceiverMetadata.PropertyNames.Inboundwarehouse
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ReceiverMetadata.ColumnNames.Posted, 5, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ReceiverMetadata.PropertyNames.Posted
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ReceiverMetadata.ColumnNames.Vendorid, 6, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ReceiverMetadata.PropertyNames.Vendorid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ReceiverMetadata.ColumnNames.Ponumber, 7, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ReceiverMetadata.PropertyNames.Ponumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ReceiverMetadata.ColumnNames.Purchasereleasenumber, 8, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ReceiverMetadata.PropertyNames.Purchasereleasenumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ReceiverMetadata.ColumnNames.Createdby, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ReceiverMetadata.PropertyNames.Createdby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ReceiverMetadata.ColumnNames.Createdtime, 10, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ReceiverMetadata.PropertyNames.Createdtime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ReceiverMetadata.ColumnNames.Modifyby, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = ReceiverMetadata.PropertyNames.Modifyby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ReceiverMetadata.ColumnNames.Modifytime, 12, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ReceiverMetadata.PropertyNames.Modifytime
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ReceiverMetadata
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
			 Public Const Receivernumber As String = "RECEIVERNUMBER"
			 Public Const Receiveddate As String = "RECEIVEDDATE"
			 Public Const Receiverdocument As String = "RECEIVERDOCUMENT"
			 Public Const Receiverdocumenttype As String = "RECEIVERDOCUMENTTYPE"
			 Public Const Inboundwarehouse As String = "INBOUNDWAREHOUSE"
			 Public Const Posted As String = "POSTED"
			 Public Const Vendorid As String = "VENDORID"
			 Public Const Ponumber As String = "PONUMBER"
			 Public Const Purchasereleasenumber As String = "PURCHASERELEASENUMBER"
			 Public Const Createdby As String = "CREATEDBY"
			 Public Const Createdtime As String = "CREATEDTIME"
			 Public Const Modifyby As String = "MODIFYBY"
			 Public Const Modifytime As String = "MODIFYTIME"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Receivernumber As String = "Receivernumber"
			 Public Const Receiveddate As String = "Receiveddate"
			 Public Const Receiverdocument As String = "Receiverdocument"
			 Public Const Receiverdocumenttype As String = "Receiverdocumenttype"
			 Public Const Inboundwarehouse As String = "Inboundwarehouse"
			 Public Const Posted As String = "Posted"
			 Public Const Vendorid As String = "Vendorid"
			 Public Const Ponumber As String = "Ponumber"
			 Public Const Purchasereleasenumber As String = "Purchasereleasenumber"
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
            SyncLock GetType(ReceiverMetadata)
			
				If ReceiverMetadata.mapDelegates Is Nothing Then
					ReceiverMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ReceiverMetadata._meta Is Nothing Then
                    ReceiverMetadata._meta = New ReceiverMetadata()
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
				

				meta.AddTypeMap("Receivernumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Receiveddate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Receiverdocument", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Receiverdocumenttype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Inboundwarehouse", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Posted", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Vendorid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Ponumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Purchasereleasenumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Createdby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Createdtime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Modifyby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Modifytime", new esTypeMap("datetime", "System.DateTime"))			
				
				
				 
				meta.Source = "RECEIVER"
				meta.Destination = "RECEIVER"
				
				meta.spInsert = "proc_RECEIVERInsert"
				meta.spUpdate = "proc_RECEIVERUpdate"
				meta.spDelete = "proc_RECEIVERDelete"
				meta.spLoadAll = "proc_RECEIVERLoadAll"
				meta.spLoadByPrimaryKey = "proc_RECEIVERLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ReceiverMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
