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
	MustInherit Public Class esViewLoadDetailsCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewLoadDetailsCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewLoadDetailsQuery)
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
            Me.InitQuery(CType(query, esViewLoadDetailsQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewLoadDetails) As ViewLoadDetails
			Return CType(MyBase.DetachEntity(entity), ViewLoadDetails)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewLoadDetails) As ViewLoadDetails
			Return CType(MyBase.AttachEntity(entity), ViewLoadDetails)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewLoadDetailsCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewLoadDetails
            Get
                Return TryCast(MyBase.Item(index), ViewLoadDetails)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewLoadDetails)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewLoadDetails	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewLoadDetailsQuery
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
												
						Case "LoadID"
							Me.str.LoadID = CType(value, string)
												
						Case "LoadStatus"
							Me.str.LoadStatus = CType(value, string)
												
						Case "LoadType"
							Me.str.LoadType = CType(value, string)
												
						Case "PlannedDepartureDate"
							Me.str.PlannedDepartureDate = CType(value, string)
												
						Case "PlannedDeliveryDate"
							Me.str.PlannedDeliveryDate = CType(value, string)
												
						Case "OriginType"
							Me.str.OriginType = CType(value, string)
												
						Case "OriginCity"
							Me.str.OriginCity = CType(value, string)
												
						Case "OriginState"
							Me.str.OriginState = CType(value, string)
												
						Case "DestType"
							Me.str.DestType = CType(value, string)
												
						Case "DestCity"
							Me.str.DestCity = CType(value, string)
												
						Case "DestState"
							Me.str.DestState = CType(value, string)
												
						Case "Pallets"
							Me.str.Pallets = CType(value, string)
												
						Case "GrossWt"
							Me.str.GrossWt = CType(value, string)
												
						Case "OriginZip"
							Me.str.OriginZip = CType(value, string)
												
						Case "DestZip"
							Me.str.DestZip = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "LoadID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.LoadID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "PlannedDepartureDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.PlannedDepartureDate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "PlannedDeliveryDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.PlannedDeliveryDate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Pallets"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Pallets = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "GrossWt"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.GrossWt = CType(value, Nullable(Of System.Int32))
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
		' Maps to viewLoadDetails.LoadID
		' </summary>
		Public Overridable Property LoadID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadDetailsMetadata.ColumnNames.LoadID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadDetailsMetadata.ColumnNames.LoadID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadDetails.LoadStatus
		' </summary>
		Public Overridable Property LoadStatus As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadDetailsMetadata.ColumnNames.LoadStatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadDetailsMetadata.ColumnNames.LoadStatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadDetails.LoadType
		' </summary>
		Public Overridable Property LoadType As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadDetailsMetadata.ColumnNames.LoadType)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadDetailsMetadata.ColumnNames.LoadType, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadDetails.PlannedDepartureDate
		' </summary>
		Public Overridable Property PlannedDepartureDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewLoadDetailsMetadata.ColumnNames.PlannedDepartureDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewLoadDetailsMetadata.ColumnNames.PlannedDepartureDate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadDetails.PlannedDeliveryDate
		' </summary>
		Public Overridable Property PlannedDeliveryDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewLoadDetailsMetadata.ColumnNames.PlannedDeliveryDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewLoadDetailsMetadata.ColumnNames.PlannedDeliveryDate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadDetails.OriginType
		' </summary>
		Public Overridable Property OriginType As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadDetailsMetadata.ColumnNames.OriginType)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadDetailsMetadata.ColumnNames.OriginType, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadDetails.OriginCity
		' </summary>
		Public Overridable Property OriginCity As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadDetailsMetadata.ColumnNames.OriginCity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadDetailsMetadata.ColumnNames.OriginCity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadDetails.OriginState
		' </summary>
		Public Overridable Property OriginState As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadDetailsMetadata.ColumnNames.OriginState)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadDetailsMetadata.ColumnNames.OriginState, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadDetails.DestType
		' </summary>
		Public Overridable Property DestType As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadDetailsMetadata.ColumnNames.DestType)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadDetailsMetadata.ColumnNames.DestType, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadDetails.DestCity
		' </summary>
		Public Overridable Property DestCity As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadDetailsMetadata.ColumnNames.DestCity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadDetailsMetadata.ColumnNames.DestCity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadDetails.DestState
		' </summary>
		Public Overridable Property DestState As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadDetailsMetadata.ColumnNames.DestState)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadDetailsMetadata.ColumnNames.DestState, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadDetails.Pallets
		' </summary>
		Public Overridable Property Pallets As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadDetailsMetadata.ColumnNames.Pallets)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadDetailsMetadata.ColumnNames.Pallets, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadDetails.GrossWt
		' </summary>
		Public Overridable Property GrossWt As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadDetailsMetadata.ColumnNames.GrossWt)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadDetailsMetadata.ColumnNames.GrossWt, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadDetails.OriginZip
		' </summary>
		Public Overridable Property OriginZip As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadDetailsMetadata.ColumnNames.OriginZip)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadDetailsMetadata.ColumnNames.OriginZip, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadDetails.DestZip
		' </summary>
		Public Overridable Property DestZip As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadDetailsMetadata.ColumnNames.DestZip)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadDetailsMetadata.ColumnNames.DestZip, value)
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
		
			Public Sub New(ByVal entity As esViewLoadDetails)
				Me.entity = entity
			End Sub				
		
	
			Public Property LoadID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.LoadID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LoadID = Nothing
					Else
						entity.LoadID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property LoadStatus As System.String 
				Get
					Dim data_ As System.String = entity.LoadStatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LoadStatus = Nothing
					Else
						entity.LoadStatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property LoadType As System.String 
				Get
					Dim data_ As System.String = entity.LoadType
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LoadType = Nothing
					Else
						entity.LoadType = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property PlannedDepartureDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.PlannedDepartureDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PlannedDepartureDate = Nothing
					Else
						entity.PlannedDepartureDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property PlannedDeliveryDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.PlannedDeliveryDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PlannedDeliveryDate = Nothing
					Else
						entity.PlannedDeliveryDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property OriginType As System.String 
				Get
					Dim data_ As System.String = entity.OriginType
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OriginType = Nothing
					Else
						entity.OriginType = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property OriginCity As System.String 
				Get
					Dim data_ As System.String = entity.OriginCity
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OriginCity = Nothing
					Else
						entity.OriginCity = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property OriginState As System.String 
				Get
					Dim data_ As System.String = entity.OriginState
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OriginState = Nothing
					Else
						entity.OriginState = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property DestType As System.String 
				Get
					Dim data_ As System.String = entity.DestType
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DestType = Nothing
					Else
						entity.DestType = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property DestCity As System.String 
				Get
					Dim data_ As System.String = entity.DestCity
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DestCity = Nothing
					Else
						entity.DestCity = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property DestState As System.String 
				Get
					Dim data_ As System.String = entity.DestState
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DestState = Nothing
					Else
						entity.DestState = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Pallets As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Pallets
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Pallets = Nothing
					Else
						entity.Pallets = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property GrossWt As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.GrossWt
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.GrossWt = Nothing
					Else
						entity.GrossWt = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property OriginZip As System.String 
				Get
					Dim data_ As System.String = entity.OriginZip
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.OriginZip = Nothing
					Else
						entity.OriginZip = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property DestZip As System.String 
				Get
					Dim data_ As System.String = entity.DestZip
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DestZip = Nothing
					Else
						entity.DestZip = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewLoadDetails
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewLoadDetailsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewLoadDetails can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewLoadDetailsQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewLoadDetailsMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property LoadID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadDetailsMetadata.ColumnNames.LoadID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LoadStatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadDetailsMetadata.ColumnNames.LoadStatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LoadType As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadDetailsMetadata.ColumnNames.LoadType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property PlannedDepartureDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadDetailsMetadata.ColumnNames.PlannedDepartureDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property PlannedDeliveryDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadDetailsMetadata.ColumnNames.PlannedDeliveryDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property OriginType As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadDetailsMetadata.ColumnNames.OriginType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OriginCity As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadDetailsMetadata.ColumnNames.OriginCity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property OriginState As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadDetailsMetadata.ColumnNames.OriginState, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DestType As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadDetailsMetadata.ColumnNames.DestType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DestCity As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadDetailsMetadata.ColumnNames.DestCity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DestState As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadDetailsMetadata.ColumnNames.DestState, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Pallets As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadDetailsMetadata.ColumnNames.Pallets, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property GrossWt As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadDetailsMetadata.ColumnNames.GrossWt, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property OriginZip As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadDetailsMetadata.ColumnNames.OriginZip, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DestZip As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadDetailsMetadata.ColumnNames.DestZip, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewLoadDetailsCollection")> _
	Partial Public Class ViewLoadDetailsCollection
		Inherits esViewLoadDetailsCollection
		Implements IEnumerable(Of ViewLoadDetails)
		
        Public Shared Widening Operator CType(ByVal coll As ViewLoadDetailsCollection) As List(Of ViewLoadDetails)
            Dim list As List(Of ViewLoadDetails) = New List(Of ViewLoadDetails)
            Dim emp As ViewLoadDetails

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewLoadDetailsMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewLoadDetailsQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewLoadDetails(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewLoadDetails()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewLoadDetailsQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewLoadDetailsQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewLoadDetailsQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewLoadDetails 
			Return CType(MyBase.AddNewEntity(), ViewLoadDetails)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewLoadDetails) Implements IEnumerable(Of ViewLoadDetails).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewLoadDetails)(Me)
        End Function
		
		Private _query As ViewLoadDetailsQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewLoadDetails' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewLoadDetails ()")> _
	<Serializable> _
	Partial Public Class ViewLoadDetails 
		Inherits esViewLoadDetails

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewLoadDetailsMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewLoadDetailsQuery

			If Me._query Is Nothing Then
				Me._query = New ViewLoadDetailsQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewLoadDetailsQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewLoadDetailsQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewLoadDetailsQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewLoadDetailsQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewLoadDetailsQuery
		inherits esViewLoadDetailsQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewLoadDetailsQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewLoadDetailsMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewLoadDetailsMetadata.ColumnNames.LoadID, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadDetailsMetadata.PropertyNames.LoadID
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadDetailsMetadata.ColumnNames.LoadStatus, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadDetailsMetadata.PropertyNames.LoadStatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadDetailsMetadata.ColumnNames.LoadType, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadDetailsMetadata.PropertyNames.LoadType
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadDetailsMetadata.ColumnNames.PlannedDepartureDate, 3, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewLoadDetailsMetadata.PropertyNames.PlannedDepartureDate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadDetailsMetadata.ColumnNames.PlannedDeliveryDate, 4, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewLoadDetailsMetadata.PropertyNames.PlannedDeliveryDate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadDetailsMetadata.ColumnNames.OriginType, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadDetailsMetadata.PropertyNames.OriginType
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadDetailsMetadata.ColumnNames.OriginCity, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadDetailsMetadata.PropertyNames.OriginCity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadDetailsMetadata.ColumnNames.OriginState, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadDetailsMetadata.PropertyNames.OriginState
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadDetailsMetadata.ColumnNames.DestType, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadDetailsMetadata.PropertyNames.DestType
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadDetailsMetadata.ColumnNames.DestCity, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadDetailsMetadata.PropertyNames.DestCity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadDetailsMetadata.ColumnNames.DestState, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadDetailsMetadata.PropertyNames.DestState
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadDetailsMetadata.ColumnNames.Pallets, 11, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadDetailsMetadata.PropertyNames.Pallets
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadDetailsMetadata.ColumnNames.GrossWt, 12, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadDetailsMetadata.PropertyNames.GrossWt
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadDetailsMetadata.ColumnNames.OriginZip, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadDetailsMetadata.PropertyNames.OriginZip
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadDetailsMetadata.ColumnNames.DestZip, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadDetailsMetadata.PropertyNames.DestZip
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewLoadDetailsMetadata
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
			 Public Const LoadID As String = "LoadID"
			 Public Const LoadStatus As String = "LoadStatus"
			 Public Const LoadType As String = "LoadType"
			 Public Const PlannedDepartureDate As String = "PlannedDepartureDate"
			 Public Const PlannedDeliveryDate As String = "PlannedDeliveryDate"
			 Public Const OriginType As String = "OriginType"
			 Public Const OriginCity As String = "OriginCity"
			 Public Const OriginState As String = "OriginState"
			 Public Const DestType As String = "DestType"
			 Public Const DestCity As String = "DestCity"
			 Public Const DestState As String = "DestState"
			 Public Const Pallets As String = "Pallets"
			 Public Const GrossWt As String = "GrossWt"
			 Public Const OriginZip As String = "OriginZip"
			 Public Const DestZip As String = "DestZip"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const LoadID As String = "LoadID"
			 Public Const LoadStatus As String = "LoadStatus"
			 Public Const LoadType As String = "LoadType"
			 Public Const PlannedDepartureDate As String = "PlannedDepartureDate"
			 Public Const PlannedDeliveryDate As String = "PlannedDeliveryDate"
			 Public Const OriginType As String = "OriginType"
			 Public Const OriginCity As String = "OriginCity"
			 Public Const OriginState As String = "OriginState"
			 Public Const DestType As String = "DestType"
			 Public Const DestCity As String = "DestCity"
			 Public Const DestState As String = "DestState"
			 Public Const Pallets As String = "Pallets"
			 Public Const GrossWt As String = "GrossWt"
			 Public Const OriginZip As String = "OriginZip"
			 Public Const DestZip As String = "DestZip"
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
            SyncLock GetType(ViewLoadDetailsMetadata)
			
				If ViewLoadDetailsMetadata.mapDelegates Is Nothing Then
					ViewLoadDetailsMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewLoadDetailsMetadata._meta Is Nothing Then
                    ViewLoadDetailsMetadata._meta = New ViewLoadDetailsMetadata()
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
				

				meta.AddTypeMap("LoadID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("LoadStatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("LoadType", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("PlannedDepartureDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("PlannedDeliveryDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("OriginType", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("OriginCity", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("OriginState", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("DestType", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("DestCity", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("DestState", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Pallets", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("GrossWt", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("OriginZip", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("DestZip", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewLoadDetails"
				meta.Destination = "viewLoadDetails"
				
				meta.spInsert = "proc_viewLoadDetailsInsert"
				meta.spUpdate = "proc_viewLoadDetailsUpdate"
				meta.spDelete = "proc_viewLoadDetailsDelete"
				meta.spLoadAll = "proc_viewLoadDetailsLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewLoadDetailsLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewLoadDetailsMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
