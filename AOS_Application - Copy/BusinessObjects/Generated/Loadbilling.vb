'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/11/2014 1:43:56 PM
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
	MustInherit Public Class esLoadbillingCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "LoadbillingCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esLoadbillingQuery)
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
            Me.InitQuery(CType(query, esLoadbillingQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Loadbilling) As Loadbilling
			Return CType(MyBase.DetachEntity(entity), Loadbilling)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Loadbilling) As Loadbilling
			Return CType(MyBase.AttachEntity(entity), Loadbilling)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As LoadbillingCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Loadbilling
            Get
                Return TryCast(MyBase.Item(index), Loadbilling)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Loadbilling)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esLoadbilling	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esLoadbillingQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal loadbillingid As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(loadbillingid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(loadbillingid)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal loadbillingid As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(loadbillingid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(loadbillingid)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal loadbillingid As System.Int32) As Boolean
		
			Dim query As esLoadbillingQuery = Me.GetDynamicQuery()
			query.Where(query.Loadbillingid.Equal(loadbillingid))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal loadbillingid As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("LOADBILLINGID", loadbillingid)
			
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
												
						Case "Loadbillingid"
							Me.str.Loadbillingid = CType(value, string)
												
						Case "Loadid"
							Me.str.Loadid = CType(value, string)
												
						Case "CustomerID"
							Me.str.CustomerID = CType(value, string)
												
						Case "CustomerPO"
							Me.str.CustomerPO = CType(value, string)
												
						Case "BilledAmount"
							Me.str.BilledAmount = CType(value, string)
												
						Case "BillingDate"
							Me.str.BillingDate = CType(value, string)
												
						Case "CreatedBy"
							Me.str.CreatedBy = CType(value, string)
												
						Case "BillingEntity"
							Me.str.BillingEntity = CType(value, string)
												
						Case "InvoiceNumber"
							Me.str.InvoiceNumber = CType(value, string)
												
						Case "Status"
							Me.str.Status = CType(value, string)
												
						Case "BillingNote"
							Me.str.BillingNote = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Loadbillingid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Loadbillingid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Loadid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Loadid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "CustomerID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.CustomerID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "BilledAmount"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.BilledAmount = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "BillingDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.BillingDate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "InvoiceNumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.InvoiceNumber = CType(value, Nullable(Of System.Int32))
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
		' Maps to LOADBILLING.LOADBILLINGID
		' </summary>
		Public Overridable Property Loadbillingid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(LoadbillingMetadata.ColumnNames.Loadbillingid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(LoadbillingMetadata.ColumnNames.Loadbillingid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADBILLING.LOADID
		' </summary>
		Public Overridable Property Loadid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(LoadbillingMetadata.ColumnNames.Loadid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(LoadbillingMetadata.ColumnNames.Loadid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADBILLING.CustomerID
		' </summary>
		Public Overridable Property CustomerID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(LoadbillingMetadata.ColumnNames.CustomerID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(LoadbillingMetadata.ColumnNames.CustomerID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADBILLING.CustomerPO
		' </summary>
		Public Overridable Property CustomerPO As System.String
			Get
				Return MyBase.GetSystemString(LoadbillingMetadata.ColumnNames.CustomerPO)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LoadbillingMetadata.ColumnNames.CustomerPO, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADBILLING.BilledAmount
		' </summary>
		Public Overridable Property BilledAmount As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(LoadbillingMetadata.ColumnNames.BilledAmount)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(LoadbillingMetadata.ColumnNames.BilledAmount, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADBILLING.BillingDate
		' </summary>
		Public Overridable Property BillingDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(LoadbillingMetadata.ColumnNames.BillingDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(LoadbillingMetadata.ColumnNames.BillingDate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADBILLING.CreatedBy
		' </summary>
		Public Overridable Property CreatedBy As System.String
			Get
				Return MyBase.GetSystemString(LoadbillingMetadata.ColumnNames.CreatedBy)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LoadbillingMetadata.ColumnNames.CreatedBy, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADBILLING.BillingEntity
		' </summary>
		Public Overridable Property BillingEntity As System.String
			Get
				Return MyBase.GetSystemString(LoadbillingMetadata.ColumnNames.BillingEntity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LoadbillingMetadata.ColumnNames.BillingEntity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADBILLING.InvoiceNumber
		' </summary>
		Public Overridable Property InvoiceNumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(LoadbillingMetadata.ColumnNames.InvoiceNumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(LoadbillingMetadata.ColumnNames.InvoiceNumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADBILLING.Status
		' </summary>
		Public Overridable Property Status As System.String
			Get
				Return MyBase.GetSystemString(LoadbillingMetadata.ColumnNames.Status)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LoadbillingMetadata.ColumnNames.Status, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADBILLING.BillingNote
		' </summary>
		Public Overridable Property BillingNote As System.String
			Get
				Return MyBase.GetSystemString(LoadbillingMetadata.ColumnNames.BillingNote)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LoadbillingMetadata.ColumnNames.BillingNote, value)
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
		
			Public Sub New(ByVal entity As esLoadbilling)
				Me.entity = entity
			End Sub				
		
	
			Public Property Loadbillingid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Loadbillingid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Loadbillingid = Nothing
					Else
						entity.Loadbillingid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Loadid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Loadid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Loadid = Nothing
					Else
						entity.Loadid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property CustomerID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.CustomerID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CustomerID = Nothing
					Else
						entity.CustomerID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property CustomerPO As System.String 
				Get
					Dim data_ As System.String = entity.CustomerPO
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CustomerPO = Nothing
					Else
						entity.CustomerPO = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BilledAmount As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.BilledAmount
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BilledAmount = Nothing
					Else
						entity.BilledAmount = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property BillingDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.BillingDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BillingDate = Nothing
					Else
						entity.BillingDate = Convert.ToDateTime(Value)
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
		  	
			Public Property BillingEntity As System.String 
				Get
					Dim data_ As System.String = entity.BillingEntity
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BillingEntity = Nothing
					Else
						entity.BillingEntity = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property InvoiceNumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.InvoiceNumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.InvoiceNumber = Nothing
					Else
						entity.InvoiceNumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Status As System.String 
				Get
					Dim data_ As System.String = entity.Status
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Status = Nothing
					Else
						entity.Status = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property BillingNote As System.String 
				Get
					Dim data_ As System.String = entity.BillingNote
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.BillingNote = Nothing
					Else
						entity.BillingNote = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esLoadbilling
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esLoadbillingQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esLoadbilling can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Loadbilling 
		Inherits esLoadbilling
		
	
		
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
	MustInherit Public Class esLoadbillingQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return LoadbillingMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Loadbillingid As esQueryItem
			Get
				Return New esQueryItem(Me, LoadbillingMetadata.ColumnNames.Loadbillingid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Loadid As esQueryItem
			Get
				Return New esQueryItem(Me, LoadbillingMetadata.ColumnNames.Loadid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property CustomerID As esQueryItem
			Get
				Return New esQueryItem(Me, LoadbillingMetadata.ColumnNames.CustomerID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property CustomerPO As esQueryItem
			Get
				Return New esQueryItem(Me, LoadbillingMetadata.ColumnNames.CustomerPO, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BilledAmount As esQueryItem
			Get
				Return New esQueryItem(Me, LoadbillingMetadata.ColumnNames.BilledAmount, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property BillingDate As esQueryItem
			Get
				Return New esQueryItem(Me, LoadbillingMetadata.ColumnNames.BillingDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property CreatedBy As esQueryItem
			Get
				Return New esQueryItem(Me, LoadbillingMetadata.ColumnNames.CreatedBy, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BillingEntity As esQueryItem
			Get
				Return New esQueryItem(Me, LoadbillingMetadata.ColumnNames.BillingEntity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property InvoiceNumber As esQueryItem
			Get
				Return New esQueryItem(Me, LoadbillingMetadata.ColumnNames.InvoiceNumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Status As esQueryItem
			Get
				Return New esQueryItem(Me, LoadbillingMetadata.ColumnNames.Status, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property BillingNote As esQueryItem
			Get
				Return New esQueryItem(Me, LoadbillingMetadata.ColumnNames.BillingNote, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("LoadbillingCollection")> _
	Partial Public Class LoadbillingCollection
		Inherits esLoadbillingCollection
		Implements IEnumerable(Of Loadbilling)
		
        Public Shared Widening Operator CType(ByVal coll As LoadbillingCollection) As List(Of Loadbilling)
            Dim list As List(Of Loadbilling) = New List(Of Loadbilling)
            Dim emp As Loadbilling

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return LoadbillingMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New LoadbillingQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Loadbilling(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Loadbilling()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As LoadbillingQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New LoadbillingQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As LoadbillingQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Loadbilling 
			Return CType(MyBase.AddNewEntity(), Loadbilling)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal loadbillingid As System.Int32) As Loadbilling
			Return CType(MyBase.FindByPrimaryKey(loadbillingid), Loadbilling)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Loadbilling) Implements IEnumerable(Of Loadbilling).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Loadbilling)(Me)
        End Function
		
		Private _query As LoadbillingQuery

	End Class
	


	' <summary>
	' Encapsulates the 'LOADBILLING' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Loadbilling ({Loadbillingid.Value})")> _
	<Serializable> _
	Partial Public Class Loadbilling 
		Inherits esLoadbilling

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return LoadbillingMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esLoadbillingQuery

			If Me._query Is Nothing Then
				Me._query = New LoadbillingQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As LoadbillingQuery
			Get

				If Me._query Is Nothing then
					Me._query = New LoadbillingQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As LoadbillingQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As LoadbillingQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class LoadbillingQuery
		inherits esLoadbillingQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "LoadbillingQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class LoadbillingMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(LoadbillingMetadata.ColumnNames.Loadbillingid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = LoadbillingMetadata.PropertyNames.Loadbillingid
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(LoadbillingMetadata.ColumnNames.Loadid, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = LoadbillingMetadata.PropertyNames.Loadid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoadbillingMetadata.ColumnNames.CustomerID, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = LoadbillingMetadata.PropertyNames.CustomerID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoadbillingMetadata.ColumnNames.CustomerPO, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = LoadbillingMetadata.PropertyNames.CustomerPO
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoadbillingMetadata.ColumnNames.BilledAmount, 4, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = LoadbillingMetadata.PropertyNames.BilledAmount
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoadbillingMetadata.ColumnNames.BillingDate, 5, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = LoadbillingMetadata.PropertyNames.BillingDate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoadbillingMetadata.ColumnNames.CreatedBy, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = LoadbillingMetadata.PropertyNames.CreatedBy
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoadbillingMetadata.ColumnNames.BillingEntity, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = LoadbillingMetadata.PropertyNames.BillingEntity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoadbillingMetadata.ColumnNames.InvoiceNumber, 8, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = LoadbillingMetadata.PropertyNames.InvoiceNumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoadbillingMetadata.ColumnNames.Status, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = LoadbillingMetadata.PropertyNames.Status
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoadbillingMetadata.ColumnNames.BillingNote, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = LoadbillingMetadata.PropertyNames.BillingNote
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As LoadbillingMetadata
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
			 Public Const Loadbillingid As String = "LOADBILLINGID"
			 Public Const Loadid As String = "LOADID"
			 Public Const CustomerID As String = "CustomerID"
			 Public Const CustomerPO As String = "CustomerPO"
			 Public Const BilledAmount As String = "BilledAmount"
			 Public Const BillingDate As String = "BillingDate"
			 Public Const CreatedBy As String = "CreatedBy"
			 Public Const BillingEntity As String = "BillingEntity"
			 Public Const InvoiceNumber As String = "InvoiceNumber"
			 Public Const Status As String = "Status"
			 Public Const BillingNote As String = "BillingNote"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Loadbillingid As String = "Loadbillingid"
			 Public Const Loadid As String = "Loadid"
			 Public Const CustomerID As String = "CustomerID"
			 Public Const CustomerPO As String = "CustomerPO"
			 Public Const BilledAmount As String = "BilledAmount"
			 Public Const BillingDate As String = "BillingDate"
			 Public Const CreatedBy As String = "CreatedBy"
			 Public Const BillingEntity As String = "BillingEntity"
			 Public Const InvoiceNumber As String = "InvoiceNumber"
			 Public Const Status As String = "Status"
			 Public Const BillingNote As String = "BillingNote"
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
            SyncLock GetType(LoadbillingMetadata)
			
				If LoadbillingMetadata.mapDelegates Is Nothing Then
					LoadbillingMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If LoadbillingMetadata._meta Is Nothing Then
                    LoadbillingMetadata._meta = New LoadbillingMetadata()
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
				

				meta.AddTypeMap("Loadbillingid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Loadid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("CustomerID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("CustomerPO", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("BilledAmount", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("BillingDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("CreatedBy", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("BillingEntity", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("InvoiceNumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Status", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("BillingNote", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "LOADBILLING"
				meta.Destination = "LOADBILLING"
				
				meta.spInsert = "proc_LOADBILLINGInsert"
				meta.spUpdate = "proc_LOADBILLINGUpdate"
				meta.spDelete = "proc_LOADBILLINGDelete"
				meta.spLoadAll = "proc_LOADBILLINGLoadAll"
				meta.spLoadByPrimaryKey = "proc_LOADBILLINGLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As LoadbillingMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
