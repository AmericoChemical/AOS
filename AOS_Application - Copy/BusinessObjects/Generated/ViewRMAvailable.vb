'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 7/16/2015 1:26:07 PM
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
	MustInherit Public Class esViewRMAvailableCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewRMAvailableCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewRMAvailableQuery)
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
            Me.InitQuery(CType(query, esViewRMAvailableQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewRMAvailable) As ViewRMAvailable
			Return CType(MyBase.DetachEntity(entity), ViewRMAvailable)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewRMAvailable) As ViewRMAvailable
			Return CType(MyBase.AttachEntity(entity), ViewRMAvailable)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewRMAvailableCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewRMAvailable
            Get
                Return TryCast(MyBase.Item(index), ViewRMAvailable)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewRMAvailable)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewRMAvailable	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewRMAvailableQuery
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
												
						Case "Materialid"
							Me.str.Materialid = CType(value, string)
												
						Case "Materialdesc"
							Me.str.Materialdesc = CType(value, string)
												
						Case "RmInventory"
							Me.str.RmInventory = CType(value, string)
												
						Case "RmInproduction"
							Me.str.RmInproduction = CType(value, string)
												
						Case "RmOnorder"
							Me.str.RmOnorder = CType(value, string)
												
						Case "RmRequested"
							Me.str.RmRequested = CType(value, string)
												
						Case "RmInprocess"
							Me.str.RmInprocess = CType(value, string)
												
						Case "RmAvailable"
							Me.str.RmAvailable = CType(value, string)
												
						Case "Materialstatus"
							Me.str.Materialstatus = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Materialid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Materialid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "RmInventory"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.RmInventory = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "RmInproduction"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.RmInproduction = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "RmOnorder"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.RmOnorder = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "RmRequested"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.RmRequested = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "RmInprocess"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.RmInprocess = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "RmAvailable"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.RmAvailable = CType(value, Nullable(Of System.Decimal))
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
		' Maps to viewRMAvailable.MATERIALID
		' </summary>
		Public Overridable Property Materialid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRMAvailableMetadata.ColumnNames.Materialid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRMAvailableMetadata.ColumnNames.Materialid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRMAvailable.MATERIALDESC
		' </summary>
		Public Overridable Property Materialdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewRMAvailableMetadata.ColumnNames.Materialdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRMAvailableMetadata.ColumnNames.Materialdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRMAvailable.RM_INVENTORY
		' </summary>
		Public Overridable Property RmInventory As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRMAvailableMetadata.ColumnNames.RmInventory)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRMAvailableMetadata.ColumnNames.RmInventory, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRMAvailable.RM_INPRODUCTION
		' </summary>
		Public Overridable Property RmInproduction As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRMAvailableMetadata.ColumnNames.RmInproduction)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRMAvailableMetadata.ColumnNames.RmInproduction, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRMAvailable.RM_ONORDER
		' </summary>
		Public Overridable Property RmOnorder As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRMAvailableMetadata.ColumnNames.RmOnorder)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRMAvailableMetadata.ColumnNames.RmOnorder, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRMAvailable.RM_REQUESTED
		' </summary>
		Public Overridable Property RmRequested As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRMAvailableMetadata.ColumnNames.RmRequested)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRMAvailableMetadata.ColumnNames.RmRequested, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRMAvailable.RM_INPROCESS
		' </summary>
		Public Overridable Property RmInprocess As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRMAvailableMetadata.ColumnNames.RmInprocess)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRMAvailableMetadata.ColumnNames.RmInprocess, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRMAvailable.RM_AVAILABLE
		' </summary>
		Public Overridable Property RmAvailable As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewRMAvailableMetadata.ColumnNames.RmAvailable)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewRMAvailableMetadata.ColumnNames.RmAvailable, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRMAvailable.MATERIALSTATUS
		' </summary>
		Public Overridable Property Materialstatus As System.String
			Get
				Return MyBase.GetSystemString(ViewRMAvailableMetadata.ColumnNames.Materialstatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRMAvailableMetadata.ColumnNames.Materialstatus, value)
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
		
			Public Sub New(ByVal entity As esViewRMAvailable)
				Me.entity = entity
			End Sub				
		
	
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
		  	
			Public Property RmInventory As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.RmInventory
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RmInventory = Nothing
					Else
						entity.RmInventory = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property RmInproduction As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.RmInproduction
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RmInproduction = Nothing
					Else
						entity.RmInproduction = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property RmOnorder As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.RmOnorder
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RmOnorder = Nothing
					Else
						entity.RmOnorder = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property RmRequested As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.RmRequested
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RmRequested = Nothing
					Else
						entity.RmRequested = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property RmInprocess As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.RmInprocess
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RmInprocess = Nothing
					Else
						entity.RmInprocess = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property RmAvailable As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.RmAvailable
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.RmAvailable = Nothing
					Else
						entity.RmAvailable = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Materialstatus As System.String 
				Get
					Dim data_ As System.String = entity.Materialstatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Materialstatus = Nothing
					Else
						entity.Materialstatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewRMAvailable
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewRMAvailableQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewRMAvailable can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewRMAvailableQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRMAvailableMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Materialid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRMAvailableMetadata.ColumnNames.Materialid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Materialdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRMAvailableMetadata.ColumnNames.Materialdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property RmInventory As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRMAvailableMetadata.ColumnNames.RmInventory, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property RmInproduction As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRMAvailableMetadata.ColumnNames.RmInproduction, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property RmOnorder As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRMAvailableMetadata.ColumnNames.RmOnorder, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property RmRequested As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRMAvailableMetadata.ColumnNames.RmRequested, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property RmInprocess As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRMAvailableMetadata.ColumnNames.RmInprocess, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property RmAvailable As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRMAvailableMetadata.ColumnNames.RmAvailable, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Materialstatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRMAvailableMetadata.ColumnNames.Materialstatus, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewRMAvailableCollection")> _
	Partial Public Class ViewRMAvailableCollection
		Inherits esViewRMAvailableCollection
		Implements IEnumerable(Of ViewRMAvailable)
		
        Public Shared Widening Operator CType(ByVal coll As ViewRMAvailableCollection) As List(Of ViewRMAvailable)
            Dim list As List(Of ViewRMAvailable) = New List(Of ViewRMAvailable)
            Dim emp As ViewRMAvailable

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRMAvailableMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewRMAvailableQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewRMAvailable(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewRMAvailable()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewRMAvailableQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewRMAvailableQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRMAvailableQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewRMAvailable 
			Return CType(MyBase.AddNewEntity(), ViewRMAvailable)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewRMAvailable) Implements IEnumerable(Of ViewRMAvailable).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewRMAvailable)(Me)
        End Function
		
		Private _query As ViewRMAvailableQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewRMAvailable' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewRMAvailable ()")> _
	<Serializable> _
	Partial Public Class ViewRMAvailable 
		Inherits esViewRMAvailable

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewRMAvailableMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewRMAvailableQuery

			If Me._query Is Nothing Then
				Me._query = New ViewRMAvailableQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewRMAvailableQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewRMAvailableQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRMAvailableQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewRMAvailableQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewRMAvailableQuery
		inherits esViewRMAvailableQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewRMAvailableQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewRMAvailableMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewRMAvailableMetadata.ColumnNames.Materialid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRMAvailableMetadata.PropertyNames.Materialid
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRMAvailableMetadata.ColumnNames.Materialdesc, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRMAvailableMetadata.PropertyNames.Materialdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRMAvailableMetadata.ColumnNames.RmInventory, 2, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRMAvailableMetadata.PropertyNames.RmInventory
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRMAvailableMetadata.ColumnNames.RmInproduction, 3, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRMAvailableMetadata.PropertyNames.RmInproduction
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRMAvailableMetadata.ColumnNames.RmOnorder, 4, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRMAvailableMetadata.PropertyNames.RmOnorder
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRMAvailableMetadata.ColumnNames.RmRequested, 5, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRMAvailableMetadata.PropertyNames.RmRequested
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRMAvailableMetadata.ColumnNames.RmInprocess, 6, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRMAvailableMetadata.PropertyNames.RmInprocess
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRMAvailableMetadata.ColumnNames.RmAvailable, 7, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewRMAvailableMetadata.PropertyNames.RmAvailable
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRMAvailableMetadata.ColumnNames.Materialstatus, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRMAvailableMetadata.PropertyNames.Materialstatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewRMAvailableMetadata
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
			 Public Const Materialid As String = "MATERIALID"
			 Public Const Materialdesc As String = "MATERIALDESC"
			 Public Const RmInventory As String = "RM_INVENTORY"
			 Public Const RmInproduction As String = "RM_INPRODUCTION"
			 Public Const RmOnorder As String = "RM_ONORDER"
			 Public Const RmRequested As String = "RM_REQUESTED"
			 Public Const RmInprocess As String = "RM_INPROCESS"
			 Public Const RmAvailable As String = "RM_AVAILABLE"
			 Public Const Materialstatus As String = "MATERIALSTATUS"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Materialid As String = "Materialid"
			 Public Const Materialdesc As String = "Materialdesc"
			 Public Const RmInventory As String = "RmInventory"
			 Public Const RmInproduction As String = "RmInproduction"
			 Public Const RmOnorder As String = "RmOnorder"
			 Public Const RmRequested As String = "RmRequested"
			 Public Const RmInprocess As String = "RmInprocess"
			 Public Const RmAvailable As String = "RmAvailable"
			 Public Const Materialstatus As String = "Materialstatus"
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
            SyncLock GetType(ViewRMAvailableMetadata)
			
				If ViewRMAvailableMetadata.mapDelegates Is Nothing Then
					ViewRMAvailableMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewRMAvailableMetadata._meta Is Nothing Then
                    ViewRMAvailableMetadata._meta = New ViewRMAvailableMetadata()
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
				

				meta.AddTypeMap("Materialid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Materialdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("RmInventory", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("RmInproduction", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("RmOnorder", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("RmRequested", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("RmInprocess", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("RmAvailable", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Materialstatus", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewRMAvailable"
				meta.Destination = "viewRMAvailable"
				
				meta.spInsert = "proc_viewRMAvailableInsert"
				meta.spUpdate = "proc_viewRMAvailableUpdate"
				meta.spDelete = "proc_viewRMAvailableDelete"
				meta.spLoadAll = "proc_viewRMAvailableLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewRMAvailableLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewRMAvailableMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
