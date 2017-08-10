'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/11/2014 1:36:11 PM
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
	MustInherit Public Class esViewRptProductionOrderSummaryCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewRptProductionOrderSummaryCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewRptProductionOrderSummaryQuery)
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
            Me.InitQuery(CType(query, esViewRptProductionOrderSummaryQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewRptProductionOrderSummary) As ViewRptProductionOrderSummary
			Return CType(MyBase.DetachEntity(entity), ViewRptProductionOrderSummary)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewRptProductionOrderSummary) As ViewRptProductionOrderSummary
			Return CType(MyBase.AttachEntity(entity), ViewRptProductionOrderSummary)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewRptProductionOrderSummaryCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewRptProductionOrderSummary
            Get
                Return TryCast(MyBase.Item(index), ViewRptProductionOrderSummary)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewRptProductionOrderSummary)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewRptProductionOrderSummary	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewRptProductionOrderSummaryQuery
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
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Productdesc"
							Me.str.Productdesc = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "Productqty"
							Me.str.Productqty = CType(value, string)
												
						Case "Receiveddate"
							Me.str.Receiveddate = CType(value, string)
												
						Case "Prodordernum"
							Me.str.Prodordernum = CType(value, string)
												
						Case "Prodorderdate"
							Me.str.Prodorderdate = CType(value, string)
												
						Case "Custname"
							Me.str.Custname = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Productqty"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productqty = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Receiveddate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Receiveddate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Prodordernum"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Prodordernum = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Prodorderdate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Prodorderdate = CType(value, Nullable(Of System.DateTime))
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
		' Maps to viewRptProductionOrderSummary.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptProductionOrderSummaryMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptProductionOrderSummaryMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptProductionOrderSummary.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewRptProductionOrderSummaryMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptProductionOrderSummaryMetadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptProductionOrderSummary.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewRptProductionOrderSummaryMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptProductionOrderSummaryMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptProductionOrderSummary.PRODUCTQTY
		' </summary>
		Public Overridable Property Productqty As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptProductionOrderSummaryMetadata.ColumnNames.Productqty)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptProductionOrderSummaryMetadata.ColumnNames.Productqty, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptProductionOrderSummary.RECEIVEDDATE
		' </summary>
		Public Overridable Property Receiveddate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewRptProductionOrderSummaryMetadata.ColumnNames.Receiveddate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewRptProductionOrderSummaryMetadata.ColumnNames.Receiveddate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptProductionOrderSummary.PRODORDERNUM
		' </summary>
		Public Overridable Property Prodordernum As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptProductionOrderSummaryMetadata.ColumnNames.Prodordernum)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptProductionOrderSummaryMetadata.ColumnNames.Prodordernum, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptProductionOrderSummary.PRODORDERDATE
		' </summary>
		Public Overridable Property Prodorderdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewRptProductionOrderSummaryMetadata.ColumnNames.Prodorderdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewRptProductionOrderSummaryMetadata.ColumnNames.Prodorderdate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptProductionOrderSummary.CUSTNAME
		' </summary>
		Public Overridable Property Custname As System.String
			Get
				Return MyBase.GetSystemString(ViewRptProductionOrderSummaryMetadata.ColumnNames.Custname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptProductionOrderSummaryMetadata.ColumnNames.Custname, value)
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
		
			Public Sub New(ByVal entity As esViewRptProductionOrderSummary)
				Me.entity = entity
			End Sub				
		
	
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
		  	
			Public Property Productqty As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Productqty
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Productqty = Nothing
					Else
						entity.Productqty = Convert.ToInt32(Value)
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
		  	
			Public Property Prodordernum As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Prodordernum
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Prodordernum = Nothing
					Else
						entity.Prodordernum = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Prodorderdate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Prodorderdate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Prodorderdate = Nothing
					Else
						entity.Prodorderdate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Custname As System.String 
				Get
					Dim data_ As System.String = entity.Custname
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Custname = Nothing
					Else
						entity.Custname = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewRptProductionOrderSummary
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewRptProductionOrderSummaryQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewRptProductionOrderSummary can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewRptProductionOrderSummaryQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRptProductionOrderSummaryMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptProductionOrderSummaryMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptProductionOrderSummaryMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptProductionOrderSummaryMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Productqty As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptProductionOrderSummaryMetadata.ColumnNames.Productqty, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Receiveddate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptProductionOrderSummaryMetadata.ColumnNames.Receiveddate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Prodordernum As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptProductionOrderSummaryMetadata.ColumnNames.Prodordernum, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Prodorderdate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptProductionOrderSummaryMetadata.ColumnNames.Prodorderdate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Custname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptProductionOrderSummaryMetadata.ColumnNames.Custname, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewRptProductionOrderSummaryCollection")> _
	Partial Public Class ViewRptProductionOrderSummaryCollection
		Inherits esViewRptProductionOrderSummaryCollection
		Implements IEnumerable(Of ViewRptProductionOrderSummary)
		
        Public Shared Widening Operator CType(ByVal coll As ViewRptProductionOrderSummaryCollection) As List(Of ViewRptProductionOrderSummary)
            Dim list As List(Of ViewRptProductionOrderSummary) = New List(Of ViewRptProductionOrderSummary)
            Dim emp As ViewRptProductionOrderSummary

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRptProductionOrderSummaryMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewRptProductionOrderSummaryQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewRptProductionOrderSummary(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewRptProductionOrderSummary()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewRptProductionOrderSummaryQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewRptProductionOrderSummaryQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRptProductionOrderSummaryQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewRptProductionOrderSummary 
			Return CType(MyBase.AddNewEntity(), ViewRptProductionOrderSummary)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewRptProductionOrderSummary) Implements IEnumerable(Of ViewRptProductionOrderSummary).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewRptProductionOrderSummary)(Me)
        End Function
		
		Private _query As ViewRptProductionOrderSummaryQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewRptProductionOrderSummary' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewRptProductionOrderSummary ()")> _
	<Serializable> _
	Partial Public Class ViewRptProductionOrderSummary 
		Inherits esViewRptProductionOrderSummary

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewRptProductionOrderSummaryMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewRptProductionOrderSummaryQuery

			If Me._query Is Nothing Then
				Me._query = New ViewRptProductionOrderSummaryQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewRptProductionOrderSummaryQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewRptProductionOrderSummaryQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRptProductionOrderSummaryQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewRptProductionOrderSummaryQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewRptProductionOrderSummaryQuery
		inherits esViewRptProductionOrderSummaryQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewRptProductionOrderSummaryQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewRptProductionOrderSummaryMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewRptProductionOrderSummaryMetadata.ColumnNames.Productid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptProductionOrderSummaryMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptProductionOrderSummaryMetadata.ColumnNames.Productdesc, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptProductionOrderSummaryMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptProductionOrderSummaryMetadata.ColumnNames.Container, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptProductionOrderSummaryMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptProductionOrderSummaryMetadata.ColumnNames.Productqty, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptProductionOrderSummaryMetadata.PropertyNames.Productqty
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptProductionOrderSummaryMetadata.ColumnNames.Receiveddate, 4, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewRptProductionOrderSummaryMetadata.PropertyNames.Receiveddate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptProductionOrderSummaryMetadata.ColumnNames.Prodordernum, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptProductionOrderSummaryMetadata.PropertyNames.Prodordernum
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptProductionOrderSummaryMetadata.ColumnNames.Prodorderdate, 6, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewRptProductionOrderSummaryMetadata.PropertyNames.Prodorderdate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptProductionOrderSummaryMetadata.ColumnNames.Custname, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptProductionOrderSummaryMetadata.PropertyNames.Custname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewRptProductionOrderSummaryMetadata
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
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Productdesc As String = "PRODUCTDESC"
			 Public Const Container As String = "CONTAINER"
			 Public Const Productqty As String = "PRODUCTQTY"
			 Public Const Receiveddate As String = "RECEIVEDDATE"
			 Public Const Prodordernum As String = "PRODORDERNUM"
			 Public Const Prodorderdate As String = "PRODORDERDATE"
			 Public Const Custname As String = "CUSTNAME"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Productid As String = "Productid"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const Container As String = "Container"
			 Public Const Productqty As String = "Productqty"
			 Public Const Receiveddate As String = "Receiveddate"
			 Public Const Prodordernum As String = "Prodordernum"
			 Public Const Prodorderdate As String = "Prodorderdate"
			 Public Const Custname As String = "Custname"
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
            SyncLock GetType(ViewRptProductionOrderSummaryMetadata)
			
				If ViewRptProductionOrderSummaryMetadata.mapDelegates Is Nothing Then
					ViewRptProductionOrderSummaryMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewRptProductionOrderSummaryMetadata._meta Is Nothing Then
                    ViewRptProductionOrderSummaryMetadata._meta = New ViewRptProductionOrderSummaryMetadata()
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
				

				meta.AddTypeMap("Productid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Productqty", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Receiveddate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Prodordernum", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Prodorderdate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Custname", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewRptProductionOrderSummary"
				meta.Destination = "viewRptProductionOrderSummary"
				
				meta.spInsert = "proc_viewRptProductionOrderSummaryInsert"
				meta.spUpdate = "proc_viewRptProductionOrderSummaryUpdate"
				meta.spDelete = "proc_viewRptProductionOrderSummaryDelete"
				meta.spLoadAll = "proc_viewRptProductionOrderSummaryLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewRptProductionOrderSummaryLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewRptProductionOrderSummaryMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
