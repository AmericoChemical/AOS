'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 4/24/2015 3:58:12 PM
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
	MustInherit Public Class esViewRptRelabelFulfillmentPlanCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewRptRelabelFulfillmentPlanCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewRptRelabelFulfillmentPlanQuery)
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
            Me.InitQuery(CType(query, esViewRptRelabelFulfillmentPlanQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewRptRelabelFulfillmentPlan) As ViewRptRelabelFulfillmentPlan
			Return CType(MyBase.DetachEntity(entity), ViewRptRelabelFulfillmentPlan)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewRptRelabelFulfillmentPlan) As ViewRptRelabelFulfillmentPlan
			Return CType(MyBase.AttachEntity(entity), ViewRptRelabelFulfillmentPlan)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewRptRelabelFulfillmentPlanCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewRptRelabelFulfillmentPlan
            Get
                Return TryCast(MyBase.Item(index), ViewRptRelabelFulfillmentPlan)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewRptRelabelFulfillmentPlan)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewRptRelabelFulfillmentPlan	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewRptRelabelFulfillmentPlanQuery
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
												
						Case "Workordernumber"
							Me.str.Workordernumber = CType(value, string)
												
						Case "Rlblqty"
							Me.str.Rlblqty = CType(value, string)
												
						Case "Rlbluom"
							Me.str.Rlbluom = CType(value, string)
												
						Case "Rlbliitemid"
							Me.str.Rlbliitemid = CType(value, string)
												
						Case "Rlbliitemdesc"
							Me.str.Rlbliitemdesc = CType(value, string)
												
						Case "Rlblcontainer"
							Me.str.Rlblcontainer = CType(value, string)
												
						Case "Rlblstatus"
							Me.str.Rlblstatus = CType(value, string)
												
						Case "Rlbldateneeded"
							Me.str.Rlbldateneeded = CType(value, string)
												
						Case "Rlblorddetails"
							Me.str.Rlblorddetails = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Workordernumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Workordernumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Rlblqty"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Rlblqty = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Rlbliitemid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Rlbliitemid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Rlbldateneeded"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Rlbldateneeded = CType(value, Nullable(Of System.DateTime))
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
		' Maps to viewRptRelabelFulfillmentPlan.WORKORDERNUMBER
		' </summary>
		Public Overridable Property Workordernumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptRelabelFulfillmentPlanMetadata.ColumnNames.Workordernumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptRelabelFulfillmentPlanMetadata.ColumnNames.Workordernumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptRelabelFulfillmentPlan.RLBLQTY
		' </summary>
		Public Overridable Property Rlblqty As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptRelabelFulfillmentPlanMetadata.ColumnNames.Rlblqty)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptRelabelFulfillmentPlanMetadata.ColumnNames.Rlblqty, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptRelabelFulfillmentPlan.RLBLUOM
		' </summary>
		Public Overridable Property Rlbluom As System.String
			Get
				Return MyBase.GetSystemString(ViewRptRelabelFulfillmentPlanMetadata.ColumnNames.Rlbluom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptRelabelFulfillmentPlanMetadata.ColumnNames.Rlbluom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptRelabelFulfillmentPlan.RLBLIITEMID
		' </summary>
		Public Overridable Property Rlbliitemid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptRelabelFulfillmentPlanMetadata.ColumnNames.Rlbliitemid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptRelabelFulfillmentPlanMetadata.ColumnNames.Rlbliitemid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptRelabelFulfillmentPlan.RLBLIITEMDESC
		' </summary>
		Public Overridable Property Rlbliitemdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewRptRelabelFulfillmentPlanMetadata.ColumnNames.Rlbliitemdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptRelabelFulfillmentPlanMetadata.ColumnNames.Rlbliitemdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptRelabelFulfillmentPlan.RLBLCONTAINER
		' </summary>
		Public Overridable Property Rlblcontainer As System.String
			Get
				Return MyBase.GetSystemString(ViewRptRelabelFulfillmentPlanMetadata.ColumnNames.Rlblcontainer)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptRelabelFulfillmentPlanMetadata.ColumnNames.Rlblcontainer, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptRelabelFulfillmentPlan.RLBLSTATUS
		' </summary>
		Public Overridable Property Rlblstatus As System.String
			Get
				Return MyBase.GetSystemString(ViewRptRelabelFulfillmentPlanMetadata.ColumnNames.Rlblstatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptRelabelFulfillmentPlanMetadata.ColumnNames.Rlblstatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptRelabelFulfillmentPlan.RLBLDATENEEDED
		' </summary>
		Public Overridable Property Rlbldateneeded As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewRptRelabelFulfillmentPlanMetadata.ColumnNames.Rlbldateneeded)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewRptRelabelFulfillmentPlanMetadata.ColumnNames.Rlbldateneeded, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptRelabelFulfillmentPlan.RLBLORDDETAILS
		' </summary>
		Public Overridable Property Rlblorddetails As System.String
			Get
				Return MyBase.GetSystemString(ViewRptRelabelFulfillmentPlanMetadata.ColumnNames.Rlblorddetails)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptRelabelFulfillmentPlanMetadata.ColumnNames.Rlblorddetails, value)
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
		
			Public Sub New(ByVal entity As esViewRptRelabelFulfillmentPlan)
				Me.entity = entity
			End Sub				
		
	
			Public Property Workordernumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Workordernumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Workordernumber = Nothing
					Else
						entity.Workordernumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Rlblqty As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Rlblqty
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Rlblqty = Nothing
					Else
						entity.Rlblqty = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Rlbluom As System.String 
				Get
					Dim data_ As System.String = entity.Rlbluom
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Rlbluom = Nothing
					Else
						entity.Rlbluom = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Rlbliitemid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Rlbliitemid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Rlbliitemid = Nothing
					Else
						entity.Rlbliitemid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Rlbliitemdesc As System.String 
				Get
					Dim data_ As System.String = entity.Rlbliitemdesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Rlbliitemdesc = Nothing
					Else
						entity.Rlbliitemdesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Rlblcontainer As System.String 
				Get
					Dim data_ As System.String = entity.Rlblcontainer
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Rlblcontainer = Nothing
					Else
						entity.Rlblcontainer = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Rlblstatus As System.String 
				Get
					Dim data_ As System.String = entity.Rlblstatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Rlblstatus = Nothing
					Else
						entity.Rlblstatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Rlbldateneeded As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Rlbldateneeded
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Rlbldateneeded = Nothing
					Else
						entity.Rlbldateneeded = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Rlblorddetails As System.String 
				Get
					Dim data_ As System.String = entity.Rlblorddetails
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Rlblorddetails = Nothing
					Else
						entity.Rlblorddetails = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewRptRelabelFulfillmentPlan
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewRptRelabelFulfillmentPlanQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewRptRelabelFulfillmentPlan can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewRptRelabelFulfillmentPlanQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRptRelabelFulfillmentPlanMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Workordernumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptRelabelFulfillmentPlanMetadata.ColumnNames.Workordernumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Rlblqty As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptRelabelFulfillmentPlanMetadata.ColumnNames.Rlblqty, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Rlbluom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptRelabelFulfillmentPlanMetadata.ColumnNames.Rlbluom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Rlbliitemid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptRelabelFulfillmentPlanMetadata.ColumnNames.Rlbliitemid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Rlbliitemdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptRelabelFulfillmentPlanMetadata.ColumnNames.Rlbliitemdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Rlblcontainer As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptRelabelFulfillmentPlanMetadata.ColumnNames.Rlblcontainer, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Rlblstatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptRelabelFulfillmentPlanMetadata.ColumnNames.Rlblstatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Rlbldateneeded As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptRelabelFulfillmentPlanMetadata.ColumnNames.Rlbldateneeded, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Rlblorddetails As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptRelabelFulfillmentPlanMetadata.ColumnNames.Rlblorddetails, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewRptRelabelFulfillmentPlanCollection")> _
	Partial Public Class ViewRptRelabelFulfillmentPlanCollection
		Inherits esViewRptRelabelFulfillmentPlanCollection
		Implements IEnumerable(Of ViewRptRelabelFulfillmentPlan)
		
        Public Shared Widening Operator CType(ByVal coll As ViewRptRelabelFulfillmentPlanCollection) As List(Of ViewRptRelabelFulfillmentPlan)
            Dim list As List(Of ViewRptRelabelFulfillmentPlan) = New List(Of ViewRptRelabelFulfillmentPlan)
            Dim emp As ViewRptRelabelFulfillmentPlan

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRptRelabelFulfillmentPlanMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewRptRelabelFulfillmentPlanQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewRptRelabelFulfillmentPlan(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewRptRelabelFulfillmentPlan()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewRptRelabelFulfillmentPlanQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewRptRelabelFulfillmentPlanQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRptRelabelFulfillmentPlanQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewRptRelabelFulfillmentPlan 
			Return CType(MyBase.AddNewEntity(), ViewRptRelabelFulfillmentPlan)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewRptRelabelFulfillmentPlan) Implements IEnumerable(Of ViewRptRelabelFulfillmentPlan).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewRptRelabelFulfillmentPlan)(Me)
        End Function
		
		Private _query As ViewRptRelabelFulfillmentPlanQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewRptRelabelFulfillmentPlan' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewRptRelabelFulfillmentPlan ()")> _
	<Serializable> _
	Partial Public Class ViewRptRelabelFulfillmentPlan 
		Inherits esViewRptRelabelFulfillmentPlan

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewRptRelabelFulfillmentPlanMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewRptRelabelFulfillmentPlanQuery

			If Me._query Is Nothing Then
				Me._query = New ViewRptRelabelFulfillmentPlanQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewRptRelabelFulfillmentPlanQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewRptRelabelFulfillmentPlanQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRptRelabelFulfillmentPlanQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewRptRelabelFulfillmentPlanQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewRptRelabelFulfillmentPlanQuery
		inherits esViewRptRelabelFulfillmentPlanQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewRptRelabelFulfillmentPlanQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewRptRelabelFulfillmentPlanMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewRptRelabelFulfillmentPlanMetadata.ColumnNames.Workordernumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptRelabelFulfillmentPlanMetadata.PropertyNames.Workordernumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptRelabelFulfillmentPlanMetadata.ColumnNames.Rlblqty, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptRelabelFulfillmentPlanMetadata.PropertyNames.Rlblqty
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptRelabelFulfillmentPlanMetadata.ColumnNames.Rlbluom, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptRelabelFulfillmentPlanMetadata.PropertyNames.Rlbluom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptRelabelFulfillmentPlanMetadata.ColumnNames.Rlbliitemid, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptRelabelFulfillmentPlanMetadata.PropertyNames.Rlbliitemid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptRelabelFulfillmentPlanMetadata.ColumnNames.Rlbliitemdesc, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptRelabelFulfillmentPlanMetadata.PropertyNames.Rlbliitemdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptRelabelFulfillmentPlanMetadata.ColumnNames.Rlblcontainer, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptRelabelFulfillmentPlanMetadata.PropertyNames.Rlblcontainer
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptRelabelFulfillmentPlanMetadata.ColumnNames.Rlblstatus, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptRelabelFulfillmentPlanMetadata.PropertyNames.Rlblstatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptRelabelFulfillmentPlanMetadata.ColumnNames.Rlbldateneeded, 7, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewRptRelabelFulfillmentPlanMetadata.PropertyNames.Rlbldateneeded
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptRelabelFulfillmentPlanMetadata.ColumnNames.Rlblorddetails, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptRelabelFulfillmentPlanMetadata.PropertyNames.Rlblorddetails
			c.CharacterMaxLength = 96
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewRptRelabelFulfillmentPlanMetadata
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
			 Public Const Workordernumber As String = "WORKORDERNUMBER"
			 Public Const Rlblqty As String = "RLBLQTY"
			 Public Const Rlbluom As String = "RLBLUOM"
			 Public Const Rlbliitemid As String = "RLBLIITEMID"
			 Public Const Rlbliitemdesc As String = "RLBLIITEMDESC"
			 Public Const Rlblcontainer As String = "RLBLCONTAINER"
			 Public Const Rlblstatus As String = "RLBLSTATUS"
			 Public Const Rlbldateneeded As String = "RLBLDATENEEDED"
			 Public Const Rlblorddetails As String = "RLBLORDDETAILS"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Workordernumber As String = "Workordernumber"
			 Public Const Rlblqty As String = "Rlblqty"
			 Public Const Rlbluom As String = "Rlbluom"
			 Public Const Rlbliitemid As String = "Rlbliitemid"
			 Public Const Rlbliitemdesc As String = "Rlbliitemdesc"
			 Public Const Rlblcontainer As String = "Rlblcontainer"
			 Public Const Rlblstatus As String = "Rlblstatus"
			 Public Const Rlbldateneeded As String = "Rlbldateneeded"
			 Public Const Rlblorddetails As String = "Rlblorddetails"
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
            SyncLock GetType(ViewRptRelabelFulfillmentPlanMetadata)
			
				If ViewRptRelabelFulfillmentPlanMetadata.mapDelegates Is Nothing Then
					ViewRptRelabelFulfillmentPlanMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewRptRelabelFulfillmentPlanMetadata._meta Is Nothing Then
                    ViewRptRelabelFulfillmentPlanMetadata._meta = New ViewRptRelabelFulfillmentPlanMetadata()
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
				

				meta.AddTypeMap("Workordernumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Rlblqty", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Rlbluom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Rlbliitemid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Rlbliitemdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Rlblcontainer", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Rlblstatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Rlbldateneeded", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Rlblorddetails", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewRptRelabelFulfillmentPlan"
				meta.Destination = "viewRptRelabelFulfillmentPlan"
				
				meta.spInsert = "proc_viewRptRelabelFulfillmentPlanInsert"
				meta.spUpdate = "proc_viewRptRelabelFulfillmentPlanUpdate"
				meta.spDelete = "proc_viewRptRelabelFulfillmentPlanDelete"
				meta.spLoadAll = "proc_viewRptRelabelFulfillmentPlanLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewRptRelabelFulfillmentPlanLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewRptRelabelFulfillmentPlanMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
