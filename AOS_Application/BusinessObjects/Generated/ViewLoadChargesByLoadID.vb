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
	MustInherit Public Class esViewLoadChargesByLoadIDCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewLoadChargesByLoadIDCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewLoadChargesByLoadIDQuery)
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
            Me.InitQuery(CType(query, esViewLoadChargesByLoadIDQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewLoadChargesByLoadID) As ViewLoadChargesByLoadID
			Return CType(MyBase.DetachEntity(entity), ViewLoadChargesByLoadID)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewLoadChargesByLoadID) As ViewLoadChargesByLoadID
			Return CType(MyBase.AttachEntity(entity), ViewLoadChargesByLoadID)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewLoadChargesByLoadIDCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewLoadChargesByLoadID
            Get
                Return TryCast(MyBase.Item(index), ViewLoadChargesByLoadID)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewLoadChargesByLoadID)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewLoadChargesByLoadID	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewLoadChargesByLoadIDQuery
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
												
						Case "LoadChargeID"
							Me.str.LoadChargeID = CType(value, string)
												
						Case "LoadID"
							Me.str.LoadID = CType(value, string)
												
						Case "CarrierID"
							Me.str.CarrierID = CType(value, string)
												
						Case "CarrierName"
							Me.str.CarrierName = CType(value, string)
												
						Case "LogisticsProviderID"
							Me.str.LogisticsProviderID = CType(value, string)
												
						Case "Logisticsname"
							Me.str.Logisticsname = CType(value, string)
												
						Case "CarrierCharges"
							Me.str.CarrierCharges = CType(value, string)
												
						Case "ChargeType"
							Me.str.ChargeType = CType(value, string)
												
						Case "ChargeDate"
							Me.str.ChargeDate = CType(value, string)
												
						Case "CreatedBy"
							Me.str.CreatedBy = CType(value, string)
												
						Case "LoadChargeStatus"
							Me.str.LoadChargeStatus = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "LoadChargeID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.LoadChargeID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "LoadID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.LoadID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "CarrierID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.CarrierID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "LogisticsProviderID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.LogisticsProviderID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "CarrierCharges"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.CarrierCharges = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "ChargeDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.ChargeDate = CType(value, Nullable(Of System.DateTime))
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
		' Maps to viewLoadChargesByLoadID.LoadChargeID
		' </summary>
		Public Overridable Property LoadChargeID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadChargesByLoadIDMetadata.ColumnNames.LoadChargeID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadChargesByLoadIDMetadata.ColumnNames.LoadChargeID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesByLoadID.LoadID
		' </summary>
		Public Overridable Property LoadID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadChargesByLoadIDMetadata.ColumnNames.LoadID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadChargesByLoadIDMetadata.ColumnNames.LoadID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesByLoadID.CarrierID
		' </summary>
		Public Overridable Property CarrierID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadChargesByLoadIDMetadata.ColumnNames.CarrierID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadChargesByLoadIDMetadata.ColumnNames.CarrierID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesByLoadID.CarrierName
		' </summary>
		Public Overridable Property CarrierName As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadChargesByLoadIDMetadata.ColumnNames.CarrierName)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadChargesByLoadIDMetadata.ColumnNames.CarrierName, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesByLoadID.LogisticsProviderID
		' </summary>
		Public Overridable Property LogisticsProviderID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadChargesByLoadIDMetadata.ColumnNames.LogisticsProviderID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadChargesByLoadIDMetadata.ColumnNames.LogisticsProviderID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesByLoadID.LOGISTICSNAME
		' </summary>
		Public Overridable Property Logisticsname As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadChargesByLoadIDMetadata.ColumnNames.Logisticsname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadChargesByLoadIDMetadata.ColumnNames.Logisticsname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesByLoadID.CarrierCharges
		' </summary>
		Public Overridable Property CarrierCharges As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewLoadChargesByLoadIDMetadata.ColumnNames.CarrierCharges)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewLoadChargesByLoadIDMetadata.ColumnNames.CarrierCharges, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesByLoadID.ChargeType
		' </summary>
		Public Overridable Property ChargeType As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadChargesByLoadIDMetadata.ColumnNames.ChargeType)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadChargesByLoadIDMetadata.ColumnNames.ChargeType, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesByLoadID.ChargeDate
		' </summary>
		Public Overridable Property ChargeDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewLoadChargesByLoadIDMetadata.ColumnNames.ChargeDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewLoadChargesByLoadIDMetadata.ColumnNames.ChargeDate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesByLoadID.CreatedBy
		' </summary>
		Public Overridable Property CreatedBy As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadChargesByLoadIDMetadata.ColumnNames.CreatedBy)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadChargesByLoadIDMetadata.ColumnNames.CreatedBy, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadChargesByLoadID.LoadChargeStatus
		' </summary>
		Public Overridable Property LoadChargeStatus As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadChargesByLoadIDMetadata.ColumnNames.LoadChargeStatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadChargesByLoadIDMetadata.ColumnNames.LoadChargeStatus, value)
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
		
			Public Sub New(ByVal entity As esViewLoadChargesByLoadID)
				Me.entity = entity
			End Sub				
		
	
			Public Property LoadChargeID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.LoadChargeID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LoadChargeID = Nothing
					Else
						entity.LoadChargeID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
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
		  	
			Public Property CarrierID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.CarrierID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CarrierID = Nothing
					Else
						entity.CarrierID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property CarrierName As System.String 
				Get
					Dim data_ As System.String = entity.CarrierName
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CarrierName = Nothing
					Else
						entity.CarrierName = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property LogisticsProviderID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.LogisticsProviderID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LogisticsProviderID = Nothing
					Else
						entity.LogisticsProviderID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Logisticsname As System.String 
				Get
					Dim data_ As System.String = entity.Logisticsname
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Logisticsname = Nothing
					Else
						entity.Logisticsname = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CarrierCharges As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.CarrierCharges
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CarrierCharges = Nothing
					Else
						entity.CarrierCharges = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property ChargeType As System.String 
				Get
					Dim data_ As System.String = entity.ChargeType
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ChargeType = Nothing
					Else
						entity.ChargeType = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ChargeDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.ChargeDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ChargeDate = Nothing
					Else
						entity.ChargeDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property CreatedBy As System.String 
				Get
					Dim data_ As System.String = entity.CreatedBy
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CreatedBy = Nothing
					Else
						entity.CreatedBy = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property LoadChargeStatus As System.String 
				Get
					Dim data_ As System.String = entity.LoadChargeStatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LoadChargeStatus = Nothing
					Else
						entity.LoadChargeStatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewLoadChargesByLoadID
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewLoadChargesByLoadIDQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewLoadChargesByLoadID can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewLoadChargesByLoadIDQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewLoadChargesByLoadIDMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property LoadChargeID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesByLoadIDMetadata.ColumnNames.LoadChargeID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LoadID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesByLoadIDMetadata.ColumnNames.LoadID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property CarrierID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesByLoadIDMetadata.ColumnNames.CarrierID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property CarrierName As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesByLoadIDMetadata.ColumnNames.CarrierName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LogisticsProviderID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesByLoadIDMetadata.ColumnNames.LogisticsProviderID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Logisticsname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesByLoadIDMetadata.ColumnNames.Logisticsname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CarrierCharges As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesByLoadIDMetadata.ColumnNames.CarrierCharges, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property ChargeType As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesByLoadIDMetadata.ColumnNames.ChargeType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ChargeDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesByLoadIDMetadata.ColumnNames.ChargeDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property CreatedBy As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesByLoadIDMetadata.ColumnNames.CreatedBy, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LoadChargeStatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadChargesByLoadIDMetadata.ColumnNames.LoadChargeStatus, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewLoadChargesByLoadIDCollection")> _
	Partial Public Class ViewLoadChargesByLoadIDCollection
		Inherits esViewLoadChargesByLoadIDCollection
		Implements IEnumerable(Of ViewLoadChargesByLoadID)
		
        Public Shared Widening Operator CType(ByVal coll As ViewLoadChargesByLoadIDCollection) As List(Of ViewLoadChargesByLoadID)
            Dim list As List(Of ViewLoadChargesByLoadID) = New List(Of ViewLoadChargesByLoadID)
            Dim emp As ViewLoadChargesByLoadID

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewLoadChargesByLoadIDMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewLoadChargesByLoadIDQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewLoadChargesByLoadID(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewLoadChargesByLoadID()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewLoadChargesByLoadIDQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewLoadChargesByLoadIDQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewLoadChargesByLoadIDQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewLoadChargesByLoadID 
			Return CType(MyBase.AddNewEntity(), ViewLoadChargesByLoadID)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewLoadChargesByLoadID) Implements IEnumerable(Of ViewLoadChargesByLoadID).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewLoadChargesByLoadID)(Me)
        End Function
		
		Private _query As ViewLoadChargesByLoadIDQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewLoadChargesByLoadID' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewLoadChargesByLoadID ()")> _
	<Serializable> _
	Partial Public Class ViewLoadChargesByLoadID 
		Inherits esViewLoadChargesByLoadID

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewLoadChargesByLoadIDMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewLoadChargesByLoadIDQuery

			If Me._query Is Nothing Then
				Me._query = New ViewLoadChargesByLoadIDQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewLoadChargesByLoadIDQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewLoadChargesByLoadIDQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewLoadChargesByLoadIDQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewLoadChargesByLoadIDQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewLoadChargesByLoadIDQuery
		inherits esViewLoadChargesByLoadIDQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewLoadChargesByLoadIDQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewLoadChargesByLoadIDMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewLoadChargesByLoadIDMetadata.ColumnNames.LoadChargeID, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadChargesByLoadIDMetadata.PropertyNames.LoadChargeID
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesByLoadIDMetadata.ColumnNames.LoadID, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadChargesByLoadIDMetadata.PropertyNames.LoadID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesByLoadIDMetadata.ColumnNames.CarrierID, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadChargesByLoadIDMetadata.PropertyNames.CarrierID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesByLoadIDMetadata.ColumnNames.CarrierName, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadChargesByLoadIDMetadata.PropertyNames.CarrierName
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesByLoadIDMetadata.ColumnNames.LogisticsProviderID, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadChargesByLoadIDMetadata.PropertyNames.LogisticsProviderID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesByLoadIDMetadata.ColumnNames.Logisticsname, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadChargesByLoadIDMetadata.PropertyNames.Logisticsname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesByLoadIDMetadata.ColumnNames.CarrierCharges, 6, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewLoadChargesByLoadIDMetadata.PropertyNames.CarrierCharges
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesByLoadIDMetadata.ColumnNames.ChargeType, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadChargesByLoadIDMetadata.PropertyNames.ChargeType
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesByLoadIDMetadata.ColumnNames.ChargeDate, 8, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewLoadChargesByLoadIDMetadata.PropertyNames.ChargeDate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesByLoadIDMetadata.ColumnNames.CreatedBy, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadChargesByLoadIDMetadata.PropertyNames.CreatedBy
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadChargesByLoadIDMetadata.ColumnNames.LoadChargeStatus, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadChargesByLoadIDMetadata.PropertyNames.LoadChargeStatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewLoadChargesByLoadIDMetadata
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
			 Public Const LoadChargeID As String = "LoadChargeID"
			 Public Const LoadID As String = "LoadID"
			 Public Const CarrierID As String = "CarrierID"
			 Public Const CarrierName As String = "CarrierName"
			 Public Const LogisticsProviderID As String = "LogisticsProviderID"
			 Public Const Logisticsname As String = "LOGISTICSNAME"
			 Public Const CarrierCharges As String = "CarrierCharges"
			 Public Const ChargeType As String = "ChargeType"
			 Public Const ChargeDate As String = "ChargeDate"
			 Public Const CreatedBy As String = "CreatedBy"
			 Public Const LoadChargeStatus As String = "LoadChargeStatus"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const LoadChargeID As String = "LoadChargeID"
			 Public Const LoadID As String = "LoadID"
			 Public Const CarrierID As String = "CarrierID"
			 Public Const CarrierName As String = "CarrierName"
			 Public Const LogisticsProviderID As String = "LogisticsProviderID"
			 Public Const Logisticsname As String = "Logisticsname"
			 Public Const CarrierCharges As String = "CarrierCharges"
			 Public Const ChargeType As String = "ChargeType"
			 Public Const ChargeDate As String = "ChargeDate"
			 Public Const CreatedBy As String = "CreatedBy"
			 Public Const LoadChargeStatus As String = "LoadChargeStatus"
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
            SyncLock GetType(ViewLoadChargesByLoadIDMetadata)
			
				If ViewLoadChargesByLoadIDMetadata.mapDelegates Is Nothing Then
					ViewLoadChargesByLoadIDMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewLoadChargesByLoadIDMetadata._meta Is Nothing Then
                    ViewLoadChargesByLoadIDMetadata._meta = New ViewLoadChargesByLoadIDMetadata()
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
				

				meta.AddTypeMap("LoadChargeID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("LoadID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("CarrierID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("CarrierName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("LogisticsProviderID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Logisticsname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CarrierCharges", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("ChargeType", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ChargeDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("CreatedBy", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("LoadChargeStatus", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewLoadChargesByLoadID"
				meta.Destination = "viewLoadChargesByLoadID"
				
				meta.spInsert = "proc_viewLoadChargesByLoadIDInsert"
				meta.spUpdate = "proc_viewLoadChargesByLoadIDUpdate"
				meta.spDelete = "proc_viewLoadChargesByLoadIDDelete"
				meta.spLoadAll = "proc_viewLoadChargesByLoadIDLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewLoadChargesByLoadIDLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewLoadChargesByLoadIDMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
