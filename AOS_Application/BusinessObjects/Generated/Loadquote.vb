'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 1/4/2019 1:46:26 PM
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
	MustInherit Public Class esLoadquoteCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "LoadquoteCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esLoadquoteQuery)
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
            Me.InitQuery(CType(query, esLoadquoteQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Loadquote) As Loadquote
			Return CType(MyBase.DetachEntity(entity), Loadquote)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Loadquote) As Loadquote
			Return CType(MyBase.AttachEntity(entity), Loadquote)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As LoadquoteCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Loadquote
            Get
                Return TryCast(MyBase.Item(index), Loadquote)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Loadquote)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esLoadquote	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esLoadquoteQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal loadQuoteID As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(loadQuoteID)
			Else
				Return LoadByPrimaryKeyStoredProcedure(loadQuoteID)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal loadQuoteID As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(loadQuoteID)
			Else
				Return LoadByPrimaryKeyStoredProcedure(loadQuoteID)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal loadQuoteID As System.Int32) As Boolean
		
			Dim query As esLoadquoteQuery = Me.GetDynamicQuery()
			query.Where(query.LoadQuoteID.Equal(loadQuoteID))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal loadQuoteID As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("LoadQuoteID", loadQuoteID)
			
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
												
						Case "LoadQuoteID"
							Me.str.LoadQuoteID = CType(value, string)
												
						Case "LoadID"
							Me.str.LoadID = CType(value, string)
												
						Case "CarrierID"
							Me.str.CarrierID = CType(value, string)
												
						Case "LogisticsProviderID"
							Me.str.LogisticsProviderID = CType(value, string)
												
						Case "QuoteAmount"
							Me.str.QuoteAmount = CType(value, string)
												
						Case "QuoteDate"
							Me.str.QuoteDate = CType(value, string)
												
						Case "CarrierQuoteNumber"
							Me.str.CarrierQuoteNumber = CType(value, string)
												
						Case "EmptyCost"
							Me.str.EmptyCost = CType(value, string)
												
						Case "EquipmentCost"
							Me.str.EquipmentCost = CType(value, string)
												
						Case "FreezeProtect"
							Me.str.FreezeProtect = CType(value, string)
					
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
						
						Case "EmptyCost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.EmptyCost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "EquipmentCost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.EquipmentCost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "FreezeProtect"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.FreezeProtect = CType(value, Nullable(Of System.Boolean))
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
		' Maps to LOADQUOTE.LoadQuoteID
		' </summary>
		Public Overridable Property LoadQuoteID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(LoadquoteMetadata.ColumnNames.LoadQuoteID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(LoadquoteMetadata.ColumnNames.LoadQuoteID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADQUOTE.LoadID
		' </summary>
		Public Overridable Property LoadID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(LoadquoteMetadata.ColumnNames.LoadID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(LoadquoteMetadata.ColumnNames.LoadID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADQUOTE.CarrierID
		' </summary>
		Public Overridable Property CarrierID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(LoadquoteMetadata.ColumnNames.CarrierID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(LoadquoteMetadata.ColumnNames.CarrierID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADQUOTE.LogisticsProviderID
		' </summary>
		Public Overridable Property LogisticsProviderID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(LoadquoteMetadata.ColumnNames.LogisticsProviderID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(LoadquoteMetadata.ColumnNames.LogisticsProviderID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADQUOTE.QuoteAmount
		' </summary>
		Public Overridable Property QuoteAmount As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(LoadquoteMetadata.ColumnNames.QuoteAmount)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(LoadquoteMetadata.ColumnNames.QuoteAmount, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADQUOTE.QuoteDate
		' </summary>
		Public Overridable Property QuoteDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(LoadquoteMetadata.ColumnNames.QuoteDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(LoadquoteMetadata.ColumnNames.QuoteDate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADQUOTE.CarrierQuoteNumber
		' </summary>
		Public Overridable Property CarrierQuoteNumber As System.String
			Get
				Return MyBase.GetSystemString(LoadquoteMetadata.ColumnNames.CarrierQuoteNumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LoadquoteMetadata.ColumnNames.CarrierQuoteNumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADQUOTE.EmptyCost
		' </summary>
		Public Overridable Property EmptyCost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(LoadquoteMetadata.ColumnNames.EmptyCost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(LoadquoteMetadata.ColumnNames.EmptyCost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADQUOTE.EquipmentCost
		' </summary>
		Public Overridable Property EquipmentCost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(LoadquoteMetadata.ColumnNames.EquipmentCost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(LoadquoteMetadata.ColumnNames.EquipmentCost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADQUOTE.FreezeProtect
		' </summary>
		Public Overridable Property FreezeProtect As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(LoadquoteMetadata.ColumnNames.FreezeProtect)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(LoadquoteMetadata.ColumnNames.FreezeProtect, value)
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
		
			Public Sub New(ByVal entity As esLoadquote)
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
		  	
			Public Property EmptyCost As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.EmptyCost
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EmptyCost = Nothing
					Else
						entity.EmptyCost = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property EquipmentCost As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.EquipmentCost
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EquipmentCost = Nothing
					Else
						entity.EquipmentCost = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property FreezeProtect As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.FreezeProtect
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FreezeProtect = Nothing
					Else
						entity.FreezeProtect = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  

			Private entity As esLoadquote
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esLoadquoteQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esLoadquote can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Loadquote 
		Inherits esLoadquote
		
	
		
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
	MustInherit Public Class esLoadquoteQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return LoadquoteMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property LoadQuoteID As esQueryItem
			Get
				Return New esQueryItem(Me, LoadquoteMetadata.ColumnNames.LoadQuoteID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LoadID As esQueryItem
			Get
				Return New esQueryItem(Me, LoadquoteMetadata.ColumnNames.LoadID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property CarrierID As esQueryItem
			Get
				Return New esQueryItem(Me, LoadquoteMetadata.ColumnNames.CarrierID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LogisticsProviderID As esQueryItem
			Get
				Return New esQueryItem(Me, LoadquoteMetadata.ColumnNames.LogisticsProviderID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property QuoteAmount As esQueryItem
			Get
				Return New esQueryItem(Me, LoadquoteMetadata.ColumnNames.QuoteAmount, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property QuoteDate As esQueryItem
			Get
				Return New esQueryItem(Me, LoadquoteMetadata.ColumnNames.QuoteDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property CarrierQuoteNumber As esQueryItem
			Get
				Return New esQueryItem(Me, LoadquoteMetadata.ColumnNames.CarrierQuoteNumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property EmptyCost As esQueryItem
			Get
				Return New esQueryItem(Me, LoadquoteMetadata.ColumnNames.EmptyCost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property EquipmentCost As esQueryItem
			Get
				Return New esQueryItem(Me, LoadquoteMetadata.ColumnNames.EquipmentCost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property FreezeProtect As esQueryItem
			Get
				Return New esQueryItem(Me, LoadquoteMetadata.ColumnNames.FreezeProtect, esSystemType.Boolean)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("LoadquoteCollection")> _
	Partial Public Class LoadquoteCollection
		Inherits esLoadquoteCollection
		Implements IEnumerable(Of Loadquote)
		
        Public Shared Widening Operator CType(ByVal coll As LoadquoteCollection) As List(Of Loadquote)
            Dim list As List(Of Loadquote) = New List(Of Loadquote)
            Dim emp As Loadquote

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return LoadquoteMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New LoadquoteQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Loadquote(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Loadquote()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As LoadquoteQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New LoadquoteQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As LoadquoteQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Loadquote 
			Return CType(MyBase.AddNewEntity(), Loadquote)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal loadQuoteID As System.Int32) As Loadquote
			Return CType(MyBase.FindByPrimaryKey(loadQuoteID), Loadquote)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Loadquote) Implements IEnumerable(Of Loadquote).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Loadquote)(Me)
        End Function
		
		Private _query As LoadquoteQuery

	End Class
	


	' <summary>
	' Encapsulates the 'LOADQUOTE' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Loadquote ({LoadQuoteID.Value})")> _
	<Serializable> _
	Partial Public Class Loadquote 
		Inherits esLoadquote

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return LoadquoteMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esLoadquoteQuery

			If Me._query Is Nothing Then
				Me._query = New LoadquoteQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As LoadquoteQuery
			Get

				If Me._query Is Nothing then
					Me._query = New LoadquoteQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As LoadquoteQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As LoadquoteQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class LoadquoteQuery
		inherits esLoadquoteQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "LoadquoteQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class LoadquoteMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(LoadquoteMetadata.ColumnNames.LoadQuoteID, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = LoadquoteMetadata.PropertyNames.LoadQuoteID
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(LoadquoteMetadata.ColumnNames.LoadID, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = LoadquoteMetadata.PropertyNames.LoadID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoadquoteMetadata.ColumnNames.CarrierID, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = LoadquoteMetadata.PropertyNames.CarrierID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoadquoteMetadata.ColumnNames.LogisticsProviderID, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = LoadquoteMetadata.PropertyNames.LogisticsProviderID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoadquoteMetadata.ColumnNames.QuoteAmount, 4, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = LoadquoteMetadata.PropertyNames.QuoteAmount
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoadquoteMetadata.ColumnNames.QuoteDate, 5, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = LoadquoteMetadata.PropertyNames.QuoteDate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoadquoteMetadata.ColumnNames.CarrierQuoteNumber, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = LoadquoteMetadata.PropertyNames.CarrierQuoteNumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoadquoteMetadata.ColumnNames.EmptyCost, 7, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = LoadquoteMetadata.PropertyNames.EmptyCost
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoadquoteMetadata.ColumnNames.EquipmentCost, 8, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = LoadquoteMetadata.PropertyNames.EquipmentCost
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoadquoteMetadata.ColumnNames.FreezeProtect, 9, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = LoadquoteMetadata.PropertyNames.FreezeProtect
			c.HasDefault = True
			c.Default = "((0))"
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As LoadquoteMetadata
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
			 Public Const LogisticsProviderID As String = "LogisticsProviderID"
			 Public Const QuoteAmount As String = "QuoteAmount"
			 Public Const QuoteDate As String = "QuoteDate"
			 Public Const CarrierQuoteNumber As String = "CarrierQuoteNumber"
			 Public Const EmptyCost As String = "EmptyCost"
			 Public Const EquipmentCost As String = "EquipmentCost"
			 Public Const FreezeProtect As String = "FreezeProtect"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const LoadQuoteID As String = "LoadQuoteID"
			 Public Const LoadID As String = "LoadID"
			 Public Const CarrierID As String = "CarrierID"
			 Public Const LogisticsProviderID As String = "LogisticsProviderID"
			 Public Const QuoteAmount As String = "QuoteAmount"
			 Public Const QuoteDate As String = "QuoteDate"
			 Public Const CarrierQuoteNumber As String = "CarrierQuoteNumber"
			 Public Const EmptyCost As String = "EmptyCost"
			 Public Const EquipmentCost As String = "EquipmentCost"
			 Public Const FreezeProtect As String = "FreezeProtect"
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
            SyncLock GetType(LoadquoteMetadata)
			
				If LoadquoteMetadata.mapDelegates Is Nothing Then
					LoadquoteMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If LoadquoteMetadata._meta Is Nothing Then
                    LoadquoteMetadata._meta = New LoadquoteMetadata()
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
				meta.AddTypeMap("LogisticsProviderID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("QuoteAmount", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("QuoteDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("CarrierQuoteNumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("EmptyCost", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("EquipmentCost", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("FreezeProtect", new esTypeMap("bit", "System.Boolean"))			
				
				
				 
				meta.Source = "LOADQUOTE"
				meta.Destination = "LOADQUOTE"
				
				meta.spInsert = "proc_LOADQUOTEInsert"
				meta.spUpdate = "proc_LOADQUOTEUpdate"
				meta.spDelete = "proc_LOADQUOTEDelete"
				meta.spLoadAll = "proc_LOADQUOTELoadAll"
				meta.spLoadByPrimaryKey = "proc_LOADQUOTELoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As LoadquoteMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
