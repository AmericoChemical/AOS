'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/11/2014 1:36:09 PM
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
	MustInherit Public Class esViewLoadQuotesByLoadIDCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewLoadQuotesByLoadIDCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewLoadQuotesByLoadIDQuery)
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
            Me.InitQuery(CType(query, esViewLoadQuotesByLoadIDQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewLoadQuotesByLoadID) As ViewLoadQuotesByLoadID
			Return CType(MyBase.DetachEntity(entity), ViewLoadQuotesByLoadID)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewLoadQuotesByLoadID) As ViewLoadQuotesByLoadID
			Return CType(MyBase.AttachEntity(entity), ViewLoadQuotesByLoadID)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewLoadQuotesByLoadIDCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewLoadQuotesByLoadID
            Get
                Return TryCast(MyBase.Item(index), ViewLoadQuotesByLoadID)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewLoadQuotesByLoadID)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewLoadQuotesByLoadID	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewLoadQuotesByLoadIDQuery
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
												
						Case "LoadQuoteID"
							Me.str.LoadQuoteID = CType(value, string)
												
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
												
						Case "QuoteAmount"
							Me.str.QuoteAmount = CType(value, string)
												
						Case "QuoteDate"
							Me.str.QuoteDate = CType(value, string)
												
						Case "CarrierQuoteNumber"
							Me.str.CarrierQuoteNumber = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "LoadQuoteID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.LoadQuoteID = CType(value, Nullable(Of System.Int32))
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
						
						Case "QuoteAmount"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.QuoteAmount = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "QuoteDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.QuoteDate = CType(value, Nullable(Of System.DateTime))
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
		' Maps to viewLoadQuotesByLoadID.LoadQuoteID
		' </summary>
		Public Overridable Property LoadQuoteID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadQuotesByLoadIDMetadata.ColumnNames.LoadQuoteID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadQuotesByLoadIDMetadata.ColumnNames.LoadQuoteID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadQuotesByLoadID.LoadID
		' </summary>
		Public Overridable Property LoadID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadQuotesByLoadIDMetadata.ColumnNames.LoadID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadQuotesByLoadIDMetadata.ColumnNames.LoadID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadQuotesByLoadID.CarrierID
		' </summary>
		Public Overridable Property CarrierID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadQuotesByLoadIDMetadata.ColumnNames.CarrierID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadQuotesByLoadIDMetadata.ColumnNames.CarrierID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadQuotesByLoadID.CarrierName
		' </summary>
		Public Overridable Property CarrierName As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadQuotesByLoadIDMetadata.ColumnNames.CarrierName)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadQuotesByLoadIDMetadata.ColumnNames.CarrierName, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadQuotesByLoadID.LogisticsProviderID
		' </summary>
		Public Overridable Property LogisticsProviderID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadQuotesByLoadIDMetadata.ColumnNames.LogisticsProviderID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadQuotesByLoadIDMetadata.ColumnNames.LogisticsProviderID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadQuotesByLoadID.LOGISTICSNAME
		' </summary>
		Public Overridable Property Logisticsname As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadQuotesByLoadIDMetadata.ColumnNames.Logisticsname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadQuotesByLoadIDMetadata.ColumnNames.Logisticsname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadQuotesByLoadID.QuoteAmount
		' </summary>
		Public Overridable Property QuoteAmount As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewLoadQuotesByLoadIDMetadata.ColumnNames.QuoteAmount)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewLoadQuotesByLoadIDMetadata.ColumnNames.QuoteAmount, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadQuotesByLoadID.QuoteDate
		' </summary>
		Public Overridable Property QuoteDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewLoadQuotesByLoadIDMetadata.ColumnNames.QuoteDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewLoadQuotesByLoadIDMetadata.ColumnNames.QuoteDate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadQuotesByLoadID.CarrierQuoteNumber
		' </summary>
		Public Overridable Property CarrierQuoteNumber As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadQuotesByLoadIDMetadata.ColumnNames.CarrierQuoteNumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadQuotesByLoadIDMetadata.ColumnNames.CarrierQuoteNumber, value)
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
		
			Public Sub New(ByVal entity As esViewLoadQuotesByLoadID)
				Me.entity = entity
			End Sub				
		
	
			Public Property LoadQuoteID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.LoadQuoteID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LoadQuoteID = Nothing
					Else
						entity.LoadQuoteID = Convert.ToInt32(Value)
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
		  	
			Public Property QuoteAmount As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.QuoteAmount
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.QuoteAmount = Nothing
					Else
						entity.QuoteAmount = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property QuoteDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.QuoteDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.QuoteDate = Nothing
					Else
						entity.QuoteDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property CarrierQuoteNumber As System.String 
				Get
					Dim data_ As System.String = entity.CarrierQuoteNumber
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CarrierQuoteNumber = Nothing
					Else
						entity.CarrierQuoteNumber = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewLoadQuotesByLoadID
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewLoadQuotesByLoadIDQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewLoadQuotesByLoadID can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewLoadQuotesByLoadIDQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewLoadQuotesByLoadIDMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property LoadQuoteID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadQuotesByLoadIDMetadata.ColumnNames.LoadQuoteID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LoadID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadQuotesByLoadIDMetadata.ColumnNames.LoadID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property CarrierID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadQuotesByLoadIDMetadata.ColumnNames.CarrierID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property CarrierName As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadQuotesByLoadIDMetadata.ColumnNames.CarrierName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LogisticsProviderID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadQuotesByLoadIDMetadata.ColumnNames.LogisticsProviderID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Logisticsname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadQuotesByLoadIDMetadata.ColumnNames.Logisticsname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property QuoteAmount As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadQuotesByLoadIDMetadata.ColumnNames.QuoteAmount, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property QuoteDate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadQuotesByLoadIDMetadata.ColumnNames.QuoteDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property CarrierQuoteNumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadQuotesByLoadIDMetadata.ColumnNames.CarrierQuoteNumber, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewLoadQuotesByLoadIDCollection")> _
	Partial Public Class ViewLoadQuotesByLoadIDCollection
		Inherits esViewLoadQuotesByLoadIDCollection
		Implements IEnumerable(Of ViewLoadQuotesByLoadID)
		
        Public Shared Widening Operator CType(ByVal coll As ViewLoadQuotesByLoadIDCollection) As List(Of ViewLoadQuotesByLoadID)
            Dim list As List(Of ViewLoadQuotesByLoadID) = New List(Of ViewLoadQuotesByLoadID)
            Dim emp As ViewLoadQuotesByLoadID

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewLoadQuotesByLoadIDMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewLoadQuotesByLoadIDQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewLoadQuotesByLoadID(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewLoadQuotesByLoadID()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewLoadQuotesByLoadIDQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewLoadQuotesByLoadIDQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewLoadQuotesByLoadIDQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewLoadQuotesByLoadID 
			Return CType(MyBase.AddNewEntity(), ViewLoadQuotesByLoadID)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewLoadQuotesByLoadID) Implements IEnumerable(Of ViewLoadQuotesByLoadID).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewLoadQuotesByLoadID)(Me)
        End Function
		
		Private _query As ViewLoadQuotesByLoadIDQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewLoadQuotesByLoadID' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewLoadQuotesByLoadID ()")> _
	<Serializable> _
	Partial Public Class ViewLoadQuotesByLoadID 
		Inherits esViewLoadQuotesByLoadID

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewLoadQuotesByLoadIDMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewLoadQuotesByLoadIDQuery

			If Me._query Is Nothing Then
				Me._query = New ViewLoadQuotesByLoadIDQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewLoadQuotesByLoadIDQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewLoadQuotesByLoadIDQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewLoadQuotesByLoadIDQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewLoadQuotesByLoadIDQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewLoadQuotesByLoadIDQuery
		inherits esViewLoadQuotesByLoadIDQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewLoadQuotesByLoadIDQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewLoadQuotesByLoadIDMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewLoadQuotesByLoadIDMetadata.ColumnNames.LoadQuoteID, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadQuotesByLoadIDMetadata.PropertyNames.LoadQuoteID
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadQuotesByLoadIDMetadata.ColumnNames.LoadID, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadQuotesByLoadIDMetadata.PropertyNames.LoadID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadQuotesByLoadIDMetadata.ColumnNames.CarrierID, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadQuotesByLoadIDMetadata.PropertyNames.CarrierID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadQuotesByLoadIDMetadata.ColumnNames.CarrierName, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadQuotesByLoadIDMetadata.PropertyNames.CarrierName
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadQuotesByLoadIDMetadata.ColumnNames.LogisticsProviderID, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadQuotesByLoadIDMetadata.PropertyNames.LogisticsProviderID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadQuotesByLoadIDMetadata.ColumnNames.Logisticsname, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadQuotesByLoadIDMetadata.PropertyNames.Logisticsname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadQuotesByLoadIDMetadata.ColumnNames.QuoteAmount, 6, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewLoadQuotesByLoadIDMetadata.PropertyNames.QuoteAmount
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadQuotesByLoadIDMetadata.ColumnNames.QuoteDate, 7, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewLoadQuotesByLoadIDMetadata.PropertyNames.QuoteDate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadQuotesByLoadIDMetadata.ColumnNames.CarrierQuoteNumber, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadQuotesByLoadIDMetadata.PropertyNames.CarrierQuoteNumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewLoadQuotesByLoadIDMetadata
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
			 Public Const LoadQuoteID As String = "LoadQuoteID"
			 Public Const LoadID As String = "LoadID"
			 Public Const CarrierID As String = "CarrierID"
			 Public Const CarrierName As String = "CarrierName"
			 Public Const LogisticsProviderID As String = "LogisticsProviderID"
			 Public Const Logisticsname As String = "LOGISTICSNAME"
			 Public Const QuoteAmount As String = "QuoteAmount"
			 Public Const QuoteDate As String = "QuoteDate"
			 Public Const CarrierQuoteNumber As String = "CarrierQuoteNumber"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const LoadQuoteID As String = "LoadQuoteID"
			 Public Const LoadID As String = "LoadID"
			 Public Const CarrierID As String = "CarrierID"
			 Public Const CarrierName As String = "CarrierName"
			 Public Const LogisticsProviderID As String = "LogisticsProviderID"
			 Public Const Logisticsname As String = "Logisticsname"
			 Public Const QuoteAmount As String = "QuoteAmount"
			 Public Const QuoteDate As String = "QuoteDate"
			 Public Const CarrierQuoteNumber As String = "CarrierQuoteNumber"
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
            SyncLock GetType(ViewLoadQuotesByLoadIDMetadata)
			
				If ViewLoadQuotesByLoadIDMetadata.mapDelegates Is Nothing Then
					ViewLoadQuotesByLoadIDMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewLoadQuotesByLoadIDMetadata._meta Is Nothing Then
                    ViewLoadQuotesByLoadIDMetadata._meta = New ViewLoadQuotesByLoadIDMetadata()
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
				

				meta.AddTypeMap("LoadQuoteID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("LoadID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("CarrierID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("CarrierName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("LogisticsProviderID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Logisticsname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("QuoteAmount", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("QuoteDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("CarrierQuoteNumber", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewLoadQuotesByLoadID"
				meta.Destination = "viewLoadQuotesByLoadID"
				
				meta.spInsert = "proc_viewLoadQuotesByLoadIDInsert"
				meta.spUpdate = "proc_viewLoadQuotesByLoadIDUpdate"
				meta.spDelete = "proc_viewLoadQuotesByLoadIDDelete"
				meta.spLoadAll = "proc_viewLoadQuotesByLoadIDLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewLoadQuotesByLoadIDLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewLoadQuotesByLoadIDMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
