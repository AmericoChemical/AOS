'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 7/31/2015 10:24:07 AM
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
	MustInherit Public Class esViewChemicalProductLinkCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewChemicalProductLinkCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewChemicalProductLinkQuery)
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
            Me.InitQuery(CType(query, esViewChemicalProductLinkQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewChemicalProductLink) As ViewChemicalProductLink
			Return CType(MyBase.DetachEntity(entity), ViewChemicalProductLink)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewChemicalProductLink) As ViewChemicalProductLink
			Return CType(MyBase.AttachEntity(entity), ViewChemicalProductLink)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewChemicalProductLinkCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewChemicalProductLink
            Get
                Return TryCast(MyBase.Item(index), ViewChemicalProductLink)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewChemicalProductLink)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewChemicalProductLink	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewChemicalProductLinkQuery
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
												
						Case "Desc2"
							Me.str.Desc2 = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "Chemicalid"
							Me.str.Chemicalid = CType(value, string)
												
						Case "Chemicalname"
							Me.str.Chemicalname = CType(value, string)
												
						Case "Productstatus"
							Me.str.Productstatus = CType(value, string)
												
						Case "Isactive"
							Me.str.Isactive = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Chemicalid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Chemicalid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Isactive"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Isactive = CType(value, Nullable(Of System.Boolean))
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
		' Maps to viewChemicalProductLink.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewChemicalProductLinkMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewChemicalProductLinkMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewChemicalProductLink.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewChemicalProductLinkMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewChemicalProductLinkMetadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewChemicalProductLink.DESC2
		' </summary>
		Public Overridable Property Desc2 As System.String
			Get
				Return MyBase.GetSystemString(ViewChemicalProductLinkMetadata.ColumnNames.Desc2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewChemicalProductLinkMetadata.ColumnNames.Desc2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewChemicalProductLink.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewChemicalProductLinkMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewChemicalProductLinkMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewChemicalProductLink.CHEMICALID
		' </summary>
		Public Overridable Property Chemicalid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewChemicalProductLinkMetadata.ColumnNames.Chemicalid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewChemicalProductLinkMetadata.ColumnNames.Chemicalid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewChemicalProductLink.CHEMICALNAME
		' </summary>
		Public Overridable Property Chemicalname As System.String
			Get
				Return MyBase.GetSystemString(ViewChemicalProductLinkMetadata.ColumnNames.Chemicalname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewChemicalProductLinkMetadata.ColumnNames.Chemicalname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewChemicalProductLink.PRODUCTSTATUS
		' </summary>
		Public Overridable Property Productstatus As System.String
			Get
				Return MyBase.GetSystemString(ViewChemicalProductLinkMetadata.ColumnNames.Productstatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewChemicalProductLinkMetadata.ColumnNames.Productstatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewChemicalProductLink.ISACTIVE
		' </summary>
		Public Overridable Property Isactive As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewChemicalProductLinkMetadata.ColumnNames.Isactive)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewChemicalProductLinkMetadata.ColumnNames.Isactive, value)
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
		
			Public Sub New(ByVal entity As esViewChemicalProductLink)
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
		  	
			Public Property Desc2 As System.String 
				Get
					Dim data_ As System.String = entity.Desc2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Desc2 = Nothing
					Else
						entity.Desc2 = Convert.ToString(Value)
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
		  	
			Public Property Chemicalid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Chemicalid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Chemicalid = Nothing
					Else
						entity.Chemicalid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Chemicalname As System.String 
				Get
					Dim data_ As System.String = entity.Chemicalname
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Chemicalname = Nothing
					Else
						entity.Chemicalname = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Productstatus As System.String 
				Get
					Dim data_ As System.String = entity.Productstatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Productstatus = Nothing
					Else
						entity.Productstatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Isactive As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Isactive
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Isactive = Nothing
					Else
						entity.Isactive = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewChemicalProductLink
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewChemicalProductLinkQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewChemicalProductLink can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewChemicalProductLinkQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewChemicalProductLinkMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewChemicalProductLinkMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewChemicalProductLinkMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Desc2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewChemicalProductLinkMetadata.ColumnNames.Desc2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewChemicalProductLinkMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Chemicalid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewChemicalProductLinkMetadata.ColumnNames.Chemicalid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Chemicalname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewChemicalProductLinkMetadata.ColumnNames.Chemicalname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Productstatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewChemicalProductLinkMetadata.ColumnNames.Productstatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Isactive As esQueryItem
			Get
				Return New esQueryItem(Me, ViewChemicalProductLinkMetadata.ColumnNames.Isactive, esSystemType.Boolean)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewChemicalProductLinkCollection")> _
	Partial Public Class ViewChemicalProductLinkCollection
		Inherits esViewChemicalProductLinkCollection
		Implements IEnumerable(Of ViewChemicalProductLink)
		
        Public Shared Widening Operator CType(ByVal coll As ViewChemicalProductLinkCollection) As List(Of ViewChemicalProductLink)
            Dim list As List(Of ViewChemicalProductLink) = New List(Of ViewChemicalProductLink)
            Dim emp As ViewChemicalProductLink

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewChemicalProductLinkMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewChemicalProductLinkQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewChemicalProductLink(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewChemicalProductLink()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewChemicalProductLinkQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewChemicalProductLinkQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewChemicalProductLinkQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewChemicalProductLink 
			Return CType(MyBase.AddNewEntity(), ViewChemicalProductLink)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewChemicalProductLink) Implements IEnumerable(Of ViewChemicalProductLink).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewChemicalProductLink)(Me)
        End Function
		
		Private _query As ViewChemicalProductLinkQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewChemicalProductLink' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewChemicalProductLink ()")> _
	<Serializable> _
	Partial Public Class ViewChemicalProductLink 
		Inherits esViewChemicalProductLink

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewChemicalProductLinkMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewChemicalProductLinkQuery

			If Me._query Is Nothing Then
				Me._query = New ViewChemicalProductLinkQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewChemicalProductLinkQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewChemicalProductLinkQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewChemicalProductLinkQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewChemicalProductLinkQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewChemicalProductLinkQuery
		inherits esViewChemicalProductLinkQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewChemicalProductLinkQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewChemicalProductLinkMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewChemicalProductLinkMetadata.ColumnNames.Productid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewChemicalProductLinkMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewChemicalProductLinkMetadata.ColumnNames.Productdesc, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewChemicalProductLinkMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewChemicalProductLinkMetadata.ColumnNames.Desc2, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewChemicalProductLinkMetadata.PropertyNames.Desc2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewChemicalProductLinkMetadata.ColumnNames.Container, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewChemicalProductLinkMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewChemicalProductLinkMetadata.ColumnNames.Chemicalid, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewChemicalProductLinkMetadata.PropertyNames.Chemicalid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewChemicalProductLinkMetadata.ColumnNames.Chemicalname, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewChemicalProductLinkMetadata.PropertyNames.Chemicalname
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewChemicalProductLinkMetadata.ColumnNames.Productstatus, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewChemicalProductLinkMetadata.PropertyNames.Productstatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewChemicalProductLinkMetadata.ColumnNames.Isactive, 7, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewChemicalProductLinkMetadata.PropertyNames.Isactive
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewChemicalProductLinkMetadata
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
			 Public Const Desc2 As String = "DESC2"
			 Public Const Container As String = "CONTAINER"
			 Public Const Chemicalid As String = "CHEMICALID"
			 Public Const Chemicalname As String = "CHEMICALNAME"
			 Public Const Productstatus As String = "PRODUCTSTATUS"
			 Public Const Isactive As String = "ISACTIVE"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Productid As String = "Productid"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const Desc2 As String = "Desc2"
			 Public Const Container As String = "Container"
			 Public Const Chemicalid As String = "Chemicalid"
			 Public Const Chemicalname As String = "Chemicalname"
			 Public Const Productstatus As String = "Productstatus"
			 Public Const Isactive As String = "Isactive"
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
            SyncLock GetType(ViewChemicalProductLinkMetadata)
			
				If ViewChemicalProductLinkMetadata.mapDelegates Is Nothing Then
					ViewChemicalProductLinkMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewChemicalProductLinkMetadata._meta Is Nothing Then
                    ViewChemicalProductLinkMetadata._meta = New ViewChemicalProductLinkMetadata()
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
				meta.AddTypeMap("Desc2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Chemicalid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Chemicalname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Productstatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Isactive", new esTypeMap("bit", "System.Boolean"))			
				
				
				 
				meta.Source = "viewChemicalProductLink"
				meta.Destination = "viewChemicalProductLink"
				
				meta.spInsert = "proc_viewChemicalProductLinkInsert"
				meta.spUpdate = "proc_viewChemicalProductLinkUpdate"
				meta.spDelete = "proc_viewChemicalProductLinkDelete"
				meta.spLoadAll = "proc_viewChemicalProductLinkLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewChemicalProductLinkLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewChemicalProductLinkMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
