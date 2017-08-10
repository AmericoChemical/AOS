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
	MustInherit Public Class esViewShipmentBasicCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewShipmentBasicCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewShipmentBasicQuery)
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
            Me.InitQuery(CType(query, esViewShipmentBasicQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewShipmentBasic) As ViewShipmentBasic
			Return CType(MyBase.DetachEntity(entity), ViewShipmentBasic)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewShipmentBasic) As ViewShipmentBasic
			Return CType(MyBase.AttachEntity(entity), ViewShipmentBasic)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewShipmentBasicCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewShipmentBasic
            Get
                Return TryCast(MyBase.Item(index), ViewShipmentBasic)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewShipmentBasic)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewShipmentBasic	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewShipmentBasicQuery
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
		' Maps to viewShipmentBasic.SHIPMENTNUMBER
		' </summary>
		Public Overridable Property Shipmentnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewShipmentBasicMetadata.ColumnNames.Shipmentnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewShipmentBasicMetadata.ColumnNames.Shipmentnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewShipmentBasic.SHIPMENTDATE
		' </summary>
		Public Overridable Property Shipmentdate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewShipmentBasicMetadata.ColumnNames.Shipmentdate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewShipmentBasicMetadata.ColumnNames.Shipmentdate, value)
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
		
			Public Sub New(ByVal entity As esViewShipmentBasic)
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
		  

			Private entity As esViewShipmentBasic
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewShipmentBasicQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewShipmentBasic can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewShipmentBasicQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewShipmentBasicMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Shipmentnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewShipmentBasicMetadata.ColumnNames.Shipmentnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Shipmentdate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewShipmentBasicMetadata.ColumnNames.Shipmentdate, esSystemType.DateTime)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewShipmentBasicCollection")> _
	Partial Public Class ViewShipmentBasicCollection
		Inherits esViewShipmentBasicCollection
		Implements IEnumerable(Of ViewShipmentBasic)
		
        Public Shared Widening Operator CType(ByVal coll As ViewShipmentBasicCollection) As List(Of ViewShipmentBasic)
            Dim list As List(Of ViewShipmentBasic) = New List(Of ViewShipmentBasic)
            Dim emp As ViewShipmentBasic

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewShipmentBasicMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewShipmentBasicQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewShipmentBasic(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewShipmentBasic()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewShipmentBasicQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewShipmentBasicQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewShipmentBasicQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewShipmentBasic 
			Return CType(MyBase.AddNewEntity(), ViewShipmentBasic)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewShipmentBasic) Implements IEnumerable(Of ViewShipmentBasic).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewShipmentBasic)(Me)
        End Function
		
		Private _query As ViewShipmentBasicQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewShipmentBasic' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewShipmentBasic ()")> _
	<Serializable> _
	Partial Public Class ViewShipmentBasic 
		Inherits esViewShipmentBasic

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewShipmentBasicMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewShipmentBasicQuery

			If Me._query Is Nothing Then
				Me._query = New ViewShipmentBasicQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewShipmentBasicQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewShipmentBasicQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewShipmentBasicQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewShipmentBasicQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewShipmentBasicQuery
		inherits esViewShipmentBasicQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewShipmentBasicQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewShipmentBasicMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewShipmentBasicMetadata.ColumnNames.Shipmentnumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewShipmentBasicMetadata.PropertyNames.Shipmentnumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewShipmentBasicMetadata.ColumnNames.Shipmentdate, 1, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewShipmentBasicMetadata.PropertyNames.Shipmentdate
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewShipmentBasicMetadata
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
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Shipmentnumber As String = "Shipmentnumber"
			 Public Const Shipmentdate As String = "Shipmentdate"
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
            SyncLock GetType(ViewShipmentBasicMetadata)
			
				If ViewShipmentBasicMetadata.mapDelegates Is Nothing Then
					ViewShipmentBasicMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewShipmentBasicMetadata._meta Is Nothing Then
                    ViewShipmentBasicMetadata._meta = New ViewShipmentBasicMetadata()
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
				
				
				 
				meta.Source = "viewShipmentBasic"
				meta.Destination = "viewShipmentBasic"
				
				meta.spInsert = "proc_viewShipmentBasicInsert"
				meta.spUpdate = "proc_viewShipmentBasicUpdate"
				meta.spDelete = "proc_viewShipmentBasicDelete"
				meta.spLoadAll = "proc_viewShipmentBasicLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewShipmentBasicLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewShipmentBasicMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
