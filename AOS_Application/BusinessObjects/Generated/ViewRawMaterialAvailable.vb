'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 12/25/2014 7:33:11 PM
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
	MustInherit Public Class esViewRawMaterialAvailableCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewRawMaterialAvailableCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewRawMaterialAvailableQuery)
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
            Me.InitQuery(CType(query, esViewRawMaterialAvailableQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewRawMaterialAvailable) As ViewRawMaterialAvailable
			Return CType(MyBase.DetachEntity(entity), ViewRawMaterialAvailable)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewRawMaterialAvailable) As ViewRawMaterialAvailable
			Return CType(MyBase.AttachEntity(entity), ViewRawMaterialAvailable)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewRawMaterialAvailableCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewRawMaterialAvailable
            Get
                Return TryCast(MyBase.Item(index), ViewRawMaterialAvailable)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewRawMaterialAvailable)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewRawMaterialAvailable	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewRawMaterialAvailableQuery
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
												
						Case "Rmonorder"
							Me.str.Rmonorder = CType(value, string)
												
						Case "Inpproduction"
							Me.str.Inpproduction = CType(value, string)
												
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
						
						Case "Rmonorder"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Rmonorder = CType(value, Nullable(Of System.Double))
							End If
						
						Case "Inpproduction"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Inpproduction = CType(value, Nullable(Of System.Double))
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
		' Maps to viewRawMaterialAvailable.MATERIALID
		' </summary>
		Public Overridable Property Materialid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRawMaterialAvailableMetadata.ColumnNames.Materialid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRawMaterialAvailableMetadata.ColumnNames.Materialid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRawMaterialAvailable.MATERIALDESC
		' </summary>
		Public Overridable Property Materialdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewRawMaterialAvailableMetadata.ColumnNames.Materialdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRawMaterialAvailableMetadata.ColumnNames.Materialdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRawMaterialAvailable.INVENTORY
		' </summary>
		Public Overridable Property Inventory As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewRawMaterialAvailableMetadata.ColumnNames.Inventory)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewRawMaterialAvailableMetadata.ColumnNames.Inventory, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRawMaterialAvailable.RMONORDER
		' </summary>
		Public Overridable Property Rmonorder As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewRawMaterialAvailableMetadata.ColumnNames.Rmonorder)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewRawMaterialAvailableMetadata.ColumnNames.Rmonorder, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRawMaterialAvailable.INPPRODUCTION
		' </summary>
		Public Overridable Property Inpproduction As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewRawMaterialAvailableMetadata.ColumnNames.Inpproduction)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewRawMaterialAvailableMetadata.ColumnNames.Inpproduction, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRawMaterialAvailable.AVAILABLE
		' </summary>
		Public Overridable Property Available As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewRawMaterialAvailableMetadata.ColumnNames.Available)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewRawMaterialAvailableMetadata.ColumnNames.Available, value)
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
		
			Public Sub New(ByVal entity As esViewRawMaterialAvailable)
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
		  	
			Public Property Rmonorder As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Rmonorder
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Rmonorder = Nothing
					Else
						entity.Rmonorder = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property Inpproduction As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Inpproduction
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Inpproduction = Nothing
					Else
						entity.Inpproduction = Convert.ToDouble(Value)
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
		  

			Private entity As esViewRawMaterialAvailable
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewRawMaterialAvailableQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewRawMaterialAvailable can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewRawMaterialAvailableQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRawMaterialAvailableMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Materialid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRawMaterialAvailableMetadata.ColumnNames.Materialid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Materialdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRawMaterialAvailableMetadata.ColumnNames.Materialdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Inventory As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRawMaterialAvailableMetadata.ColumnNames.Inventory, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Rmonorder As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRawMaterialAvailableMetadata.ColumnNames.Rmonorder, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Inpproduction As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRawMaterialAvailableMetadata.ColumnNames.Inpproduction, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Available As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRawMaterialAvailableMetadata.ColumnNames.Available, esSystemType.Double)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewRawMaterialAvailableCollection")> _
	Partial Public Class ViewRawMaterialAvailableCollection
		Inherits esViewRawMaterialAvailableCollection
		Implements IEnumerable(Of ViewRawMaterialAvailable)
		
        Public Shared Widening Operator CType(ByVal coll As ViewRawMaterialAvailableCollection) As List(Of ViewRawMaterialAvailable)
            Dim list As List(Of ViewRawMaterialAvailable) = New List(Of ViewRawMaterialAvailable)
            Dim emp As ViewRawMaterialAvailable

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRawMaterialAvailableMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewRawMaterialAvailableQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewRawMaterialAvailable(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewRawMaterialAvailable()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewRawMaterialAvailableQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewRawMaterialAvailableQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRawMaterialAvailableQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewRawMaterialAvailable 
			Return CType(MyBase.AddNewEntity(), ViewRawMaterialAvailable)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewRawMaterialAvailable) Implements IEnumerable(Of ViewRawMaterialAvailable).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewRawMaterialAvailable)(Me)
        End Function
		
		Private _query As ViewRawMaterialAvailableQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewRawMaterialAvailable' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewRawMaterialAvailable ()")> _
	<Serializable> _
	Partial Public Class ViewRawMaterialAvailable 
		Inherits esViewRawMaterialAvailable

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewRawMaterialAvailableMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewRawMaterialAvailableQuery

			If Me._query Is Nothing Then
				Me._query = New ViewRawMaterialAvailableQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewRawMaterialAvailableQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewRawMaterialAvailableQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRawMaterialAvailableQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewRawMaterialAvailableQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewRawMaterialAvailableQuery
		inherits esViewRawMaterialAvailableQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewRawMaterialAvailableQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewRawMaterialAvailableMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewRawMaterialAvailableMetadata.ColumnNames.Materialid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRawMaterialAvailableMetadata.PropertyNames.Materialid
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRawMaterialAvailableMetadata.ColumnNames.Materialdesc, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRawMaterialAvailableMetadata.PropertyNames.Materialdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRawMaterialAvailableMetadata.ColumnNames.Inventory, 2, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewRawMaterialAvailableMetadata.PropertyNames.Inventory
			c.NumericPrecision = 15
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRawMaterialAvailableMetadata.ColumnNames.Rmonorder, 3, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewRawMaterialAvailableMetadata.PropertyNames.Rmonorder
			c.NumericPrecision = 15
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRawMaterialAvailableMetadata.ColumnNames.Inpproduction, 4, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewRawMaterialAvailableMetadata.PropertyNames.Inpproduction
			c.NumericPrecision = 15
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRawMaterialAvailableMetadata.ColumnNames.Available, 5, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewRawMaterialAvailableMetadata.PropertyNames.Available
			c.NumericPrecision = 15
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewRawMaterialAvailableMetadata
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
			 Public Const Rmonorder As String = "RMONORDER"
			 Public Const Inpproduction As String = "INPPRODUCTION"
			 Public Const Available As String = "AVAILABLE"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Materialid As String = "Materialid"
			 Public Const Materialdesc As String = "Materialdesc"
			 Public Const Inventory As String = "Inventory"
			 Public Const Rmonorder As String = "Rmonorder"
			 Public Const Inpproduction As String = "Inpproduction"
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
            SyncLock GetType(ViewRawMaterialAvailableMetadata)
			
				If ViewRawMaterialAvailableMetadata.mapDelegates Is Nothing Then
					ViewRawMaterialAvailableMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewRawMaterialAvailableMetadata._meta Is Nothing Then
                    ViewRawMaterialAvailableMetadata._meta = New ViewRawMaterialAvailableMetadata()
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
				meta.AddTypeMap("Rmonorder", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Inpproduction", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Available", new esTypeMap("float", "System.Double"))			
				
				
				 
				meta.Source = "viewRawMaterialAvailable"
				meta.Destination = "viewRawMaterialAvailable"
				
				meta.spInsert = "proc_viewRawMaterialAvailableInsert"
				meta.spUpdate = "proc_viewRawMaterialAvailableUpdate"
				meta.spDelete = "proc_viewRawMaterialAvailableDelete"
				meta.spLoadAll = "proc_viewRawMaterialAvailableLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewRawMaterialAvailableLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewRawMaterialAvailableMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
