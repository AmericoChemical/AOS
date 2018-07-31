'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 11/11/2014 6:35:19 PM
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
	MustInherit Public Class esViewRawMaterialAvailabilityCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewRawMaterialAvailabilityCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewRawMaterialAvailabilityQuery)
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
            Me.InitQuery(CType(query, esViewRawMaterialAvailabilityQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewRawMaterialAvailability) As ViewRawMaterialAvailability
			Return CType(MyBase.DetachEntity(entity), ViewRawMaterialAvailability)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewRawMaterialAvailability) As ViewRawMaterialAvailability
			Return CType(MyBase.AttachEntity(entity), ViewRawMaterialAvailability)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewRawMaterialAvailabilityCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewRawMaterialAvailability
            Get
                Return TryCast(MyBase.Item(index), ViewRawMaterialAvailability)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewRawMaterialAvailability)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewRawMaterialAvailability	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewRawMaterialAvailabilityQuery
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
												
						Case "Inventory"
							Me.str.Inventory = CType(value, string)
												
						Case "Onorder"
							Me.str.Onorder = CType(value, string)
												
						Case "Inprocess"
							Me.str.Inprocess = CType(value, string)
												
						Case "Available"
							Me.str.Available = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Materialid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Materialid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Inventory"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Inventory = CType(value, Nullable(Of System.Double))
							End If
						
						Case "Onorder"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Onorder = CType(value, Nullable(Of System.Double))
							End If
						
						Case "Inprocess"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Inprocess = CType(value, Nullable(Of System.Double))
							End If
						
						Case "Available"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Available = CType(value, Nullable(Of System.Double))
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
		' Maps to viewRawMaterialAvailability.MATERIALID
		' </summary>
		Public Overridable Property Materialid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRawMaterialAvailabilityMetadata.ColumnNames.Materialid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRawMaterialAvailabilityMetadata.ColumnNames.Materialid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRawMaterialAvailability.MATERIALDESC
		' </summary>
		Public Overridable Property Materialdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewRawMaterialAvailabilityMetadata.ColumnNames.Materialdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRawMaterialAvailabilityMetadata.ColumnNames.Materialdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRawMaterialAvailability.INVENTORY
		' </summary>
		Public Overridable Property Inventory As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewRawMaterialAvailabilityMetadata.ColumnNames.Inventory)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewRawMaterialAvailabilityMetadata.ColumnNames.Inventory, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRawMaterialAvailability.ONORDER
		' </summary>
		Public Overridable Property Onorder As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewRawMaterialAvailabilityMetadata.ColumnNames.Onorder)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewRawMaterialAvailabilityMetadata.ColumnNames.Onorder, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRawMaterialAvailability.INPROCESS
		' </summary>
		Public Overridable Property Inprocess As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewRawMaterialAvailabilityMetadata.ColumnNames.Inprocess)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewRawMaterialAvailabilityMetadata.ColumnNames.Inprocess, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRawMaterialAvailability.AVAILABLE
		' </summary>
		Public Overridable Property Available As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewRawMaterialAvailabilityMetadata.ColumnNames.Available)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewRawMaterialAvailabilityMetadata.ColumnNames.Available, value)
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
		
			Public Sub New(ByVal entity As esViewRawMaterialAvailability)
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
		  	
			Public Property Inventory As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Inventory
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Inventory = Nothing
					Else
						entity.Inventory = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property Onorder As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Onorder
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Onorder = Nothing
					Else
						entity.Onorder = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property Inprocess As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Inprocess
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Inprocess = Nothing
					Else
						entity.Inprocess = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property Available As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Available
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Available = Nothing
					Else
						entity.Available = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewRawMaterialAvailability
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewRawMaterialAvailabilityQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewRawMaterialAvailability can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewRawMaterialAvailabilityQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRawMaterialAvailabilityMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Materialid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRawMaterialAvailabilityMetadata.ColumnNames.Materialid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Materialdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRawMaterialAvailabilityMetadata.ColumnNames.Materialdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Inventory As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRawMaterialAvailabilityMetadata.ColumnNames.Inventory, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Onorder As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRawMaterialAvailabilityMetadata.ColumnNames.Onorder, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Inprocess As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRawMaterialAvailabilityMetadata.ColumnNames.Inprocess, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Available As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRawMaterialAvailabilityMetadata.ColumnNames.Available, esSystemType.Double)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewRawMaterialAvailabilityCollection")> _
	Partial Public Class ViewRawMaterialAvailabilityCollection
		Inherits esViewRawMaterialAvailabilityCollection
		Implements IEnumerable(Of ViewRawMaterialAvailability)
		
        Public Shared Widening Operator CType(ByVal coll As ViewRawMaterialAvailabilityCollection) As List(Of ViewRawMaterialAvailability)
            Dim list As List(Of ViewRawMaterialAvailability) = New List(Of ViewRawMaterialAvailability)
            Dim emp As ViewRawMaterialAvailability

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRawMaterialAvailabilityMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewRawMaterialAvailabilityQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewRawMaterialAvailability(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewRawMaterialAvailability()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewRawMaterialAvailabilityQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewRawMaterialAvailabilityQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRawMaterialAvailabilityQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewRawMaterialAvailability 
			Return CType(MyBase.AddNewEntity(), ViewRawMaterialAvailability)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewRawMaterialAvailability) Implements IEnumerable(Of ViewRawMaterialAvailability).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewRawMaterialAvailability)(Me)
        End Function
		
		Private _query As ViewRawMaterialAvailabilityQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewRawMaterialAvailability' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewRawMaterialAvailability ()")> _
	<Serializable> _
	Partial Public Class ViewRawMaterialAvailability 
		Inherits esViewRawMaterialAvailability

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewRawMaterialAvailabilityMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewRawMaterialAvailabilityQuery

			If Me._query Is Nothing Then
				Me._query = New ViewRawMaterialAvailabilityQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewRawMaterialAvailabilityQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewRawMaterialAvailabilityQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRawMaterialAvailabilityQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewRawMaterialAvailabilityQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewRawMaterialAvailabilityQuery
		inherits esViewRawMaterialAvailabilityQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewRawMaterialAvailabilityQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewRawMaterialAvailabilityMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewRawMaterialAvailabilityMetadata.ColumnNames.Materialid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRawMaterialAvailabilityMetadata.PropertyNames.Materialid
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRawMaterialAvailabilityMetadata.ColumnNames.Materialdesc, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRawMaterialAvailabilityMetadata.PropertyNames.Materialdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRawMaterialAvailabilityMetadata.ColumnNames.Inventory, 2, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewRawMaterialAvailabilityMetadata.PropertyNames.Inventory
			c.NumericPrecision = 15
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRawMaterialAvailabilityMetadata.ColumnNames.Onorder, 3, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewRawMaterialAvailabilityMetadata.PropertyNames.Onorder
			c.NumericPrecision = 15
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRawMaterialAvailabilityMetadata.ColumnNames.Inprocess, 4, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewRawMaterialAvailabilityMetadata.PropertyNames.Inprocess
			c.NumericPrecision = 15
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRawMaterialAvailabilityMetadata.ColumnNames.Available, 5, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewRawMaterialAvailabilityMetadata.PropertyNames.Available
			c.NumericPrecision = 15
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewRawMaterialAvailabilityMetadata
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
			 Public Const Inventory As String = "INVENTORY"
			 Public Const Onorder As String = "ONORDER"
			 Public Const Inprocess As String = "INPROCESS"
			 Public Const Available As String = "AVAILABLE"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Materialid As String = "Materialid"
			 Public Const Materialdesc As String = "Materialdesc"
			 Public Const Inventory As String = "Inventory"
			 Public Const Onorder As String = "Onorder"
			 Public Const Inprocess As String = "Inprocess"
			 Public Const Available As String = "Available"
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
            SyncLock GetType(ViewRawMaterialAvailabilityMetadata)
			
				If ViewRawMaterialAvailabilityMetadata.mapDelegates Is Nothing Then
					ViewRawMaterialAvailabilityMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewRawMaterialAvailabilityMetadata._meta Is Nothing Then
                    ViewRawMaterialAvailabilityMetadata._meta = New ViewRawMaterialAvailabilityMetadata()
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
				meta.AddTypeMap("Inventory", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Onorder", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Inprocess", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Available", new esTypeMap("float", "System.Double"))			
				
				
				 
				meta.Source = "viewRawMaterialAvailability"
				meta.Destination = "viewRawMaterialAvailability"
				
				meta.spInsert = "proc_viewRawMaterialAvailabilityInsert"
				meta.spUpdate = "proc_viewRawMaterialAvailabilityUpdate"
				meta.spDelete = "proc_viewRawMaterialAvailabilityDelete"
				meta.spLoadAll = "proc_viewRawMaterialAvailabilityLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewRawMaterialAvailabilityLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewRawMaterialAvailabilityMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
