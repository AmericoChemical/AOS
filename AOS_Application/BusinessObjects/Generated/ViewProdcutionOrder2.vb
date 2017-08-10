'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 12/3/2014 12:54:21 AM
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
	MustInherit Public Class esViewProdcutionOrder2Collection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewProdcutionOrder2Collection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewProdcutionOrder2Query)
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
            Me.InitQuery(CType(query, esViewProdcutionOrder2Query))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewProdcutionOrder2) As ViewProdcutionOrder2
			Return CType(MyBase.DetachEntity(entity), ViewProdcutionOrder2)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewProdcutionOrder2) As ViewProdcutionOrder2
			Return CType(MyBase.AttachEntity(entity), ViewProdcutionOrder2)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewProdcutionOrder2Collection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewProdcutionOrder2
            Get
                Return TryCast(MyBase.Item(index), ViewProdcutionOrder2)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewProdcutionOrder2)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewProdcutionOrder2	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewProdcutionOrder2Query
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
												
						Case "Qty"
							Me.str.Qty = CType(value, string)
												
						Case "Uom"
							Me.str.Uom = CType(value, string)
												
						Case "Prodordernum"
							Me.str.Prodordernum = CType(value, string)
												
						Case "Workordernumber"
							Me.str.Workordernumber = CType(value, string)
												
						Case "Custname"
							Me.str.Custname = CType(value, string)
												
						Case "Neededby"
							Me.str.Neededby = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Materialid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Materialid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Qty"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Qty = CType(value, Nullable(Of System.Double))
							End If
						
						Case "Prodordernum"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Prodordernum = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Workordernumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Workordernumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Neededby"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Neededby = CType(value, Nullable(Of System.DateTime))
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
		' Maps to viewProdcutionOrder2.MATERIALID
		' </summary>
		Public Overridable Property Materialid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProdcutionOrder2Metadata.ColumnNames.Materialid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProdcutionOrder2Metadata.ColumnNames.Materialid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProdcutionOrder2.QTY
		' </summary>
		Public Overridable Property Qty As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewProdcutionOrder2Metadata.ColumnNames.Qty)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewProdcutionOrder2Metadata.ColumnNames.Qty, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProdcutionOrder2.UOM
		' </summary>
		Public Overridable Property Uom As System.String
			Get
				Return MyBase.GetSystemString(ViewProdcutionOrder2Metadata.ColumnNames.Uom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProdcutionOrder2Metadata.ColumnNames.Uom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProdcutionOrder2.PRODORDERNUM
		' </summary>
		Public Overridable Property Prodordernum As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProdcutionOrder2Metadata.ColumnNames.Prodordernum)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProdcutionOrder2Metadata.ColumnNames.Prodordernum, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProdcutionOrder2.WORKORDERNUMBER
		' </summary>
		Public Overridable Property Workordernumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProdcutionOrder2Metadata.ColumnNames.Workordernumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProdcutionOrder2Metadata.ColumnNames.Workordernumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProdcutionOrder2.CUSTNAME
		' </summary>
		Public Overridable Property Custname As System.String
			Get
				Return MyBase.GetSystemString(ViewProdcutionOrder2Metadata.ColumnNames.Custname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProdcutionOrder2Metadata.ColumnNames.Custname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProdcutionOrder2.NEEDEDBY
		' </summary>
		Public Overridable Property Neededby As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewProdcutionOrder2Metadata.ColumnNames.Neededby)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewProdcutionOrder2Metadata.ColumnNames.Neededby, value)
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
		
			Public Sub New(ByVal entity As esViewProdcutionOrder2)
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
		  	
			Public Property Qty As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Qty
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qty = Nothing
					Else
						entity.Qty = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property Uom As System.String 
				Get
					Dim data_ As System.String = entity.Uom
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Uom = Nothing
					Else
						entity.Uom = Convert.ToString(Value)
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
		  	
			Public Property Neededby As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Neededby
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Neededby = Nothing
					Else
						entity.Neededby = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewProdcutionOrder2
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewProdcutionOrder2Query)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewProdcutionOrder2 can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewProdcutionOrder2Query 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewProdcutionOrder2Metadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Materialid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProdcutionOrder2Metadata.ColumnNames.Materialid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Qty As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProdcutionOrder2Metadata.ColumnNames.Qty, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Uom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProdcutionOrder2Metadata.ColumnNames.Uom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Prodordernum As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProdcutionOrder2Metadata.ColumnNames.Prodordernum, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Workordernumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProdcutionOrder2Metadata.ColumnNames.Workordernumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Custname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProdcutionOrder2Metadata.ColumnNames.Custname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Neededby As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProdcutionOrder2Metadata.ColumnNames.Neededby, esSystemType.DateTime)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewProdcutionOrder2Collection")> _
	Partial Public Class ViewProdcutionOrder2Collection
		Inherits esViewProdcutionOrder2Collection
		Implements IEnumerable(Of ViewProdcutionOrder2)
		
        Public Shared Widening Operator CType(ByVal coll As ViewProdcutionOrder2Collection) As List(Of ViewProdcutionOrder2)
            Dim list As List(Of ViewProdcutionOrder2) = New List(Of ViewProdcutionOrder2)
            Dim emp As ViewProdcutionOrder2

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewProdcutionOrder2Metadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewProdcutionOrder2Query()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewProdcutionOrder2(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewProdcutionOrder2()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewProdcutionOrder2Query 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewProdcutionOrder2Query()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewProdcutionOrder2Query) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewProdcutionOrder2 
			Return CType(MyBase.AddNewEntity(), ViewProdcutionOrder2)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewProdcutionOrder2) Implements IEnumerable(Of ViewProdcutionOrder2).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewProdcutionOrder2)(Me)
        End Function
		
		Private _query As ViewProdcutionOrder2Query

	End Class
	


	' <summary>
	' Encapsulates the 'viewProdcutionOrder2' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewProdcutionOrder2 ()")> _
	<Serializable> _
	Partial Public Class ViewProdcutionOrder2 
		Inherits esViewProdcutionOrder2

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewProdcutionOrder2Metadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewProdcutionOrder2Query

			If Me._query Is Nothing Then
				Me._query = New ViewProdcutionOrder2Query()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewProdcutionOrder2Query
			Get

				If Me._query Is Nothing then
					Me._query = New ViewProdcutionOrder2Query()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewProdcutionOrder2Query) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewProdcutionOrder2Query

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewProdcutionOrder2Query
		inherits esViewProdcutionOrder2Query
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewProdcutionOrder2Query"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewProdcutionOrder2Metadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewProdcutionOrder2Metadata.ColumnNames.Materialid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProdcutionOrder2Metadata.PropertyNames.Materialid
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProdcutionOrder2Metadata.ColumnNames.Qty, 1, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewProdcutionOrder2Metadata.PropertyNames.Qty
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProdcutionOrder2Metadata.ColumnNames.Uom, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProdcutionOrder2Metadata.PropertyNames.Uom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProdcutionOrder2Metadata.ColumnNames.Prodordernum, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProdcutionOrder2Metadata.PropertyNames.Prodordernum
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProdcutionOrder2Metadata.ColumnNames.Workordernumber, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProdcutionOrder2Metadata.PropertyNames.Workordernumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProdcutionOrder2Metadata.ColumnNames.Custname, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProdcutionOrder2Metadata.PropertyNames.Custname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProdcutionOrder2Metadata.ColumnNames.Neededby, 6, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewProdcutionOrder2Metadata.PropertyNames.Neededby
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewProdcutionOrder2Metadata
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
			 Public Const Qty As String = "QTY"
			 Public Const Uom As String = "UOM"
			 Public Const Prodordernum As String = "PRODORDERNUM"
			 Public Const Workordernumber As String = "WORKORDERNUMBER"
			 Public Const Custname As String = "CUSTNAME"
			 Public Const Neededby As String = "NEEDEDBY"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Materialid As String = "Materialid"
			 Public Const Qty As String = "Qty"
			 Public Const Uom As String = "Uom"
			 Public Const Prodordernum As String = "Prodordernum"
			 Public Const Workordernumber As String = "Workordernumber"
			 Public Const Custname As String = "Custname"
			 Public Const Neededby As String = "Neededby"
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
            SyncLock GetType(ViewProdcutionOrder2Metadata)
			
				If ViewProdcutionOrder2Metadata.mapDelegates Is Nothing Then
					ViewProdcutionOrder2Metadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewProdcutionOrder2Metadata._meta Is Nothing Then
                    ViewProdcutionOrder2Metadata._meta = New ViewProdcutionOrder2Metadata()
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
				meta.AddTypeMap("Qty", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Uom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Prodordernum", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Workordernumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Custname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Neededby", new esTypeMap("datetime", "System.DateTime"))			
				
				
				 
				meta.Source = "viewProdcutionOrder2"
				meta.Destination = "viewProdcutionOrder2"
				
				meta.spInsert = "proc_viewProdcutionOrder2Insert"
				meta.spUpdate = "proc_viewProdcutionOrder2Update"
				meta.spDelete = "proc_viewProdcutionOrder2Delete"
				meta.spLoadAll = "proc_viewProdcutionOrder2LoadAll"
				meta.spLoadByPrimaryKey = "proc_viewProdcutionOrder2LoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewProdcutionOrder2Metadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
