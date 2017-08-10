'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/12/2015 1:27:21 PM
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
	MustInherit Public Class esViewShipmentInfoCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewShipmentInfoCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewShipmentInfoQuery)
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
            Me.InitQuery(CType(query, esViewShipmentInfoQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewShipmentInfo) As ViewShipmentInfo
			Return CType(MyBase.DetachEntity(entity), ViewShipmentInfo)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewShipmentInfo) As ViewShipmentInfo
			Return CType(MyBase.AttachEntity(entity), ViewShipmentInfo)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewShipmentInfoCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewShipmentInfo
            Get
                Return TryCast(MyBase.Item(index), ViewShipmentInfo)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewShipmentInfo)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewShipmentInfo	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewShipmentInfoQuery
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
												
						Case "Shipmentnumber"
							Me.str.Shipmentnumber = CType(value, string)
												
						Case "Shipmentdate"
							Me.str.Shipmentdate = CType(value, string)
												
						Case "Customername"
							Me.str.Customername = CType(value, string)
												
						Case "ShipperName"
							Me.str.ShipperName = CType(value, string)
												
						Case "ConsigneeName"
							Me.str.ConsigneeName = CType(value, string)
												
						Case "Freightcarrier"
							Me.str.Freightcarrier = CType(value, string)
												
						Case "Fob"
							Me.str.Fob = CType(value, string)
												
						Case "Containers"
							Me.str.Containers = CType(value, string)
												
						Case "Weight"
							Me.str.Weight = CType(value, string)
												
						Case "Shipmentstatus"
							Me.str.Shipmentstatus = CType(value, string)
												
						Case "Keepfromfreezing"
							Me.str.Keepfromfreezing = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Shipmentnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Shipmentnumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Shipmentdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Shipmentdate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Containers"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Containers = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Weight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Weight = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Keepfromfreezing"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Keepfromfreezing = CType(value, Nullable(Of System.Boolean))
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
		' Maps to viewShipmentInfo.SHIPMENTNUMBER
		' </summary>
		Public Overridable Property Shipmentnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewShipmentInfoMetadata.ColumnNames.Shipmentnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewShipmentInfoMetadata.ColumnNames.Shipmentnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewShipmentInfo.SHIPMENTDATE
		' </summary>
		Public Overridable Property Shipmentdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewShipmentInfoMetadata.ColumnNames.Shipmentdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewShipmentInfoMetadata.ColumnNames.Shipmentdate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewShipmentInfo.CUSTOMERNAME
		' </summary>
		Public Overridable Property Customername As System.String
			Get
				Return MyBase.GetSystemString(ViewShipmentInfoMetadata.ColumnNames.Customername)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewShipmentInfoMetadata.ColumnNames.Customername, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewShipmentInfo.ShipperName
		' </summary>
		Public Overridable Property ShipperName As System.String
			Get
				Return MyBase.GetSystemString(ViewShipmentInfoMetadata.ColumnNames.ShipperName)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewShipmentInfoMetadata.ColumnNames.ShipperName, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewShipmentInfo.ConsigneeName
		' </summary>
		Public Overridable Property ConsigneeName As System.String
			Get
				Return MyBase.GetSystemString(ViewShipmentInfoMetadata.ColumnNames.ConsigneeName)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewShipmentInfoMetadata.ColumnNames.ConsigneeName, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewShipmentInfo.FREIGHTCARRIER
		' </summary>
		Public Overridable Property Freightcarrier As System.String
			Get
				Return MyBase.GetSystemString(ViewShipmentInfoMetadata.ColumnNames.Freightcarrier)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewShipmentInfoMetadata.ColumnNames.Freightcarrier, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewShipmentInfo.FOB
		' </summary>
		Public Overridable Property Fob As System.String
			Get
				Return MyBase.GetSystemString(ViewShipmentInfoMetadata.ColumnNames.Fob)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewShipmentInfoMetadata.ColumnNames.Fob, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewShipmentInfo.Containers
		' </summary>
		Public Overridable Property Containers As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewShipmentInfoMetadata.ColumnNames.Containers)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewShipmentInfoMetadata.ColumnNames.Containers, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewShipmentInfo.Weight
		' </summary>
		Public Overridable Property Weight As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewShipmentInfoMetadata.ColumnNames.Weight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewShipmentInfoMetadata.ColumnNames.Weight, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewShipmentInfo.SHIPMENTSTATUS
		' </summary>
		Public Overridable Property Shipmentstatus As System.String
			Get
				Return MyBase.GetSystemString(ViewShipmentInfoMetadata.ColumnNames.Shipmentstatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewShipmentInfoMetadata.ColumnNames.Shipmentstatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewShipmentInfo.KEEPFROMFREEZING
		' </summary>
		Public Overridable Property Keepfromfreezing As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewShipmentInfoMetadata.ColumnNames.Keepfromfreezing)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewShipmentInfoMetadata.ColumnNames.Keepfromfreezing, value)
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
		
			Public Sub New(ByVal entity As esViewShipmentInfo)
				Me.entity = entity
			End Sub				
		
	
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
		  	
			Public Property Customername As System.String 
				Get
					Dim data_ As System.String = entity.Customername
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Customername = Nothing
					Else
						entity.Customername = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ShipperName As System.String 
				Get
					Dim data_ As System.String = entity.ShipperName
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ShipperName = Nothing
					Else
						entity.ShipperName = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ConsigneeName As System.String 
				Get
					Dim data_ As System.String = entity.ConsigneeName
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ConsigneeName = Nothing
					Else
						entity.ConsigneeName = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Freightcarrier As System.String 
				Get
					Dim data_ As System.String = entity.Freightcarrier
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Freightcarrier = Nothing
					Else
						entity.Freightcarrier = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Fob As System.String 
				Get
					Dim data_ As System.String = entity.Fob
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Fob = Nothing
					Else
						entity.Fob = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Containers As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Containers
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Containers = Nothing
					Else
						entity.Containers = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Weight As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Weight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Weight = Nothing
					Else
						entity.Weight = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Shipmentstatus As System.String 
				Get
					Dim data_ As System.String = entity.Shipmentstatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Shipmentstatus = Nothing
					Else
						entity.Shipmentstatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Keepfromfreezing As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Keepfromfreezing
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Keepfromfreezing = Nothing
					Else
						entity.Keepfromfreezing = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewShipmentInfo
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewShipmentInfoQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewShipmentInfo can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewShipmentInfoQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewShipmentInfoMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Shipmentnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewShipmentInfoMetadata.ColumnNames.Shipmentnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Shipmentdate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewShipmentInfoMetadata.ColumnNames.Shipmentdate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Customername As esQueryItem
			Get
				Return New esQueryItem(Me, ViewShipmentInfoMetadata.ColumnNames.Customername, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ShipperName As esQueryItem
			Get
				Return New esQueryItem(Me, ViewShipmentInfoMetadata.ColumnNames.ShipperName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ConsigneeName As esQueryItem
			Get
				Return New esQueryItem(Me, ViewShipmentInfoMetadata.ColumnNames.ConsigneeName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Freightcarrier As esQueryItem
			Get
				Return New esQueryItem(Me, ViewShipmentInfoMetadata.ColumnNames.Freightcarrier, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Fob As esQueryItem
			Get
				Return New esQueryItem(Me, ViewShipmentInfoMetadata.ColumnNames.Fob, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Containers As esQueryItem
			Get
				Return New esQueryItem(Me, ViewShipmentInfoMetadata.ColumnNames.Containers, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Weight As esQueryItem
			Get
				Return New esQueryItem(Me, ViewShipmentInfoMetadata.ColumnNames.Weight, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Shipmentstatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewShipmentInfoMetadata.ColumnNames.Shipmentstatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Keepfromfreezing As esQueryItem
			Get
				Return New esQueryItem(Me, ViewShipmentInfoMetadata.ColumnNames.Keepfromfreezing, esSystemType.Boolean)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewShipmentInfoCollection")> _
	Partial Public Class ViewShipmentInfoCollection
		Inherits esViewShipmentInfoCollection
		Implements IEnumerable(Of ViewShipmentInfo)
		
        Public Shared Widening Operator CType(ByVal coll As ViewShipmentInfoCollection) As List(Of ViewShipmentInfo)
            Dim list As List(Of ViewShipmentInfo) = New List(Of ViewShipmentInfo)
            Dim emp As ViewShipmentInfo

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewShipmentInfoMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewShipmentInfoQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewShipmentInfo(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewShipmentInfo()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewShipmentInfoQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewShipmentInfoQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewShipmentInfoQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewShipmentInfo 
			Return CType(MyBase.AddNewEntity(), ViewShipmentInfo)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewShipmentInfo) Implements IEnumerable(Of ViewShipmentInfo).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewShipmentInfo)(Me)
        End Function
		
		Private _query As ViewShipmentInfoQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewShipmentInfo' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewShipmentInfo ()")> _
	<Serializable> _
	Partial Public Class ViewShipmentInfo 
		Inherits esViewShipmentInfo

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewShipmentInfoMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewShipmentInfoQuery

			If Me._query Is Nothing Then
				Me._query = New ViewShipmentInfoQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewShipmentInfoQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewShipmentInfoQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewShipmentInfoQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewShipmentInfoQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewShipmentInfoQuery
		inherits esViewShipmentInfoQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewShipmentInfoQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewShipmentInfoMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewShipmentInfoMetadata.ColumnNames.Shipmentnumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewShipmentInfoMetadata.PropertyNames.Shipmentnumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewShipmentInfoMetadata.ColumnNames.Shipmentdate, 1, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewShipmentInfoMetadata.PropertyNames.Shipmentdate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewShipmentInfoMetadata.ColumnNames.Customername, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewShipmentInfoMetadata.PropertyNames.Customername
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewShipmentInfoMetadata.ColumnNames.ShipperName, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewShipmentInfoMetadata.PropertyNames.ShipperName
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewShipmentInfoMetadata.ColumnNames.ConsigneeName, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewShipmentInfoMetadata.PropertyNames.ConsigneeName
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewShipmentInfoMetadata.ColumnNames.Freightcarrier, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewShipmentInfoMetadata.PropertyNames.Freightcarrier
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewShipmentInfoMetadata.ColumnNames.Fob, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewShipmentInfoMetadata.PropertyNames.Fob
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewShipmentInfoMetadata.ColumnNames.Containers, 7, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewShipmentInfoMetadata.PropertyNames.Containers
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewShipmentInfoMetadata.ColumnNames.Weight, 8, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewShipmentInfoMetadata.PropertyNames.Weight
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewShipmentInfoMetadata.ColumnNames.Shipmentstatus, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewShipmentInfoMetadata.PropertyNames.Shipmentstatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewShipmentInfoMetadata.ColumnNames.Keepfromfreezing, 10, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewShipmentInfoMetadata.PropertyNames.Keepfromfreezing
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewShipmentInfoMetadata
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
			 Public Const Shipmentnumber As String = "SHIPMENTNUMBER"
			 Public Const Shipmentdate As String = "SHIPMENTDATE"
			 Public Const Customername As String = "CUSTOMERNAME"
			 Public Const ShipperName As String = "ShipperName"
			 Public Const ConsigneeName As String = "ConsigneeName"
			 Public Const Freightcarrier As String = "FREIGHTCARRIER"
			 Public Const Fob As String = "FOB"
			 Public Const Containers As String = "Containers"
			 Public Const Weight As String = "Weight"
			 Public Const Shipmentstatus As String = "SHIPMENTSTATUS"
			 Public Const Keepfromfreezing As String = "KEEPFROMFREEZING"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Shipmentnumber As String = "Shipmentnumber"
			 Public Const Shipmentdate As String = "Shipmentdate"
			 Public Const Customername As String = "Customername"
			 Public Const ShipperName As String = "ShipperName"
			 Public Const ConsigneeName As String = "ConsigneeName"
			 Public Const Freightcarrier As String = "Freightcarrier"
			 Public Const Fob As String = "Fob"
			 Public Const Containers As String = "Containers"
			 Public Const Weight As String = "Weight"
			 Public Const Shipmentstatus As String = "Shipmentstatus"
			 Public Const Keepfromfreezing As String = "Keepfromfreezing"
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
            SyncLock GetType(ViewShipmentInfoMetadata)
			
				If ViewShipmentInfoMetadata.mapDelegates Is Nothing Then
					ViewShipmentInfoMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewShipmentInfoMetadata._meta Is Nothing Then
                    ViewShipmentInfoMetadata._meta = New ViewShipmentInfoMetadata()
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
				

				meta.AddTypeMap("Shipmentnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Shipmentdate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Customername", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ShipperName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ConsigneeName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Freightcarrier", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Fob", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Containers", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Weight", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Shipmentstatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Keepfromfreezing", new esTypeMap("bit", "System.Boolean"))			
				
				
				 
				meta.Source = "viewShipmentInfo"
				meta.Destination = "viewShipmentInfo"
				
				meta.spInsert = "proc_viewShipmentInfoInsert"
				meta.spUpdate = "proc_viewShipmentInfoUpdate"
				meta.spDelete = "proc_viewShipmentInfoDelete"
				meta.spLoadAll = "proc_viewShipmentInfoLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewShipmentInfoLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewShipmentInfoMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
