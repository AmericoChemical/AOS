'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 9/11/2014 12:04:16 PM
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
	MustInherit Public Class esViewAltComponentCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewAltComponentCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewAltComponentQuery)
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
            Me.InitQuery(CType(query, esViewAltComponentQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewAltComponent) As ViewAltComponent
			Return CType(MyBase.DetachEntity(entity), ViewAltComponent)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewAltComponent) As ViewAltComponent
			Return CType(MyBase.AttachEntity(entity), ViewAltComponent)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewAltComponentCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewAltComponent
            Get
                Return TryCast(MyBase.Item(index), ViewAltComponent)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewAltComponent)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewAltComponent	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewAltComponentQuery
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
												
						Case "Componentid"
							Me.str.Componentid = CType(value, string)
												
						Case "Altcomponentid"
							Me.str.Altcomponentid = CType(value, string)
												
						Case "Recid"
							Me.str.Recid = CType(value, string)
												
						Case "Componentdesc"
							Me.str.Componentdesc = CType(value, string)
												
						Case "Vendordesc"
							Me.str.Vendordesc = CType(value, string)
												
						Case "Vendorname"
							Me.str.Vendorname = CType(value, string)
												
						Case "Vendoritemid"
							Me.str.Vendoritemid = CType(value, string)
												
						Case "Unitcost"
							Me.str.Unitcost = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Componentid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Componentid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Altcomponentid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Altcomponentid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Recid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Recid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Unitcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Unitcost = CType(value, Nullable(Of System.Decimal))
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
		' Maps to viewAltComponent.COMPONENTID
		' </summary>
		Public Overridable Property Componentid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewAltComponentMetadata.ColumnNames.Componentid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewAltComponentMetadata.ColumnNames.Componentid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAltComponent.ALTCOMPONENTID
		' </summary>
		Public Overridable Property Altcomponentid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewAltComponentMetadata.ColumnNames.Altcomponentid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewAltComponentMetadata.ColumnNames.Altcomponentid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAltComponent.RECID
		' </summary>
		Public Overridable Property Recid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewAltComponentMetadata.ColumnNames.Recid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewAltComponentMetadata.ColumnNames.Recid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAltComponent.COMPONENTDESC
		' </summary>
		Public Overridable Property Componentdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewAltComponentMetadata.ColumnNames.Componentdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewAltComponentMetadata.ColumnNames.Componentdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAltComponent.VENDORDESC
		' </summary>
		Public Overridable Property Vendordesc As System.String
			Get
				Return MyBase.GetSystemString(ViewAltComponentMetadata.ColumnNames.Vendordesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewAltComponentMetadata.ColumnNames.Vendordesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAltComponent.VENDORNAME
		' </summary>
		Public Overridable Property Vendorname As System.String
			Get
				Return MyBase.GetSystemString(ViewAltComponentMetadata.ColumnNames.Vendorname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewAltComponentMetadata.ColumnNames.Vendorname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAltComponent.VENDORITEMID
		' </summary>
		Public Overridable Property Vendoritemid As System.String
			Get
				Return MyBase.GetSystemString(ViewAltComponentMetadata.ColumnNames.Vendoritemid)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewAltComponentMetadata.ColumnNames.Vendoritemid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAltComponent.UNITCOST
		' </summary>
		Public Overridable Property Unitcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewAltComponentMetadata.ColumnNames.Unitcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewAltComponentMetadata.ColumnNames.Unitcost, value)
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
		
			Public Sub New(ByVal entity As esViewAltComponent)
				Me.entity = entity
			End Sub				
		
	
			Public Property Componentid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Componentid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Componentid = Nothing
					Else
						entity.Componentid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Altcomponentid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Altcomponentid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Altcomponentid = Nothing
					Else
						entity.Altcomponentid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Recid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Recid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Recid = Nothing
					Else
						entity.Recid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Componentdesc As System.String 
				Get
					Dim data_ As System.String = entity.Componentdesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Componentdesc = Nothing
					Else
						entity.Componentdesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Vendordesc As System.String 
				Get
					Dim data_ As System.String = entity.Vendordesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Vendordesc = Nothing
					Else
						entity.Vendordesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Vendorname As System.String 
				Get
					Dim data_ As System.String = entity.Vendorname
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Vendorname = Nothing
					Else
						entity.Vendorname = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Vendoritemid As System.String 
				Get
					Dim data_ As System.String = entity.Vendoritemid
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Vendoritemid = Nothing
					Else
						entity.Vendoritemid = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Unitcost As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Unitcost
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Unitcost = Nothing
					Else
						entity.Unitcost = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewAltComponent
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewAltComponentQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewAltComponent can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewAltComponentQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewAltComponentMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Componentid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAltComponentMetadata.ColumnNames.Componentid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Altcomponentid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAltComponentMetadata.ColumnNames.Altcomponentid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Recid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAltComponentMetadata.ColumnNames.Recid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Componentdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAltComponentMetadata.ColumnNames.Componentdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Vendordesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAltComponentMetadata.ColumnNames.Vendordesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Vendorname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAltComponentMetadata.ColumnNames.Vendorname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Vendoritemid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAltComponentMetadata.ColumnNames.Vendoritemid, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Unitcost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAltComponentMetadata.ColumnNames.Unitcost, esSystemType.Decimal)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewAltComponentCollection")> _
	Partial Public Class ViewAltComponentCollection
		Inherits esViewAltComponentCollection
		Implements IEnumerable(Of ViewAltComponent)
		
        Public Shared Widening Operator CType(ByVal coll As ViewAltComponentCollection) As List(Of ViewAltComponent)
            Dim list As List(Of ViewAltComponent) = New List(Of ViewAltComponent)
            Dim emp As ViewAltComponent

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewAltComponentMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewAltComponentQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewAltComponent(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewAltComponent()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewAltComponentQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewAltComponentQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewAltComponentQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewAltComponent 
			Return CType(MyBase.AddNewEntity(), ViewAltComponent)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewAltComponent) Implements IEnumerable(Of ViewAltComponent).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewAltComponent)(Me)
        End Function
		
		Private _query As ViewAltComponentQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewAltComponent' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewAltComponent ()")> _
	<Serializable> _
	Partial Public Class ViewAltComponent 
		Inherits esViewAltComponent

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewAltComponentMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewAltComponentQuery

			If Me._query Is Nothing Then
				Me._query = New ViewAltComponentQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewAltComponentQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewAltComponentQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewAltComponentQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewAltComponentQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewAltComponentQuery
		inherits esViewAltComponentQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewAltComponentQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewAltComponentMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewAltComponentMetadata.ColumnNames.Componentid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewAltComponentMetadata.PropertyNames.Componentid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAltComponentMetadata.ColumnNames.Altcomponentid, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewAltComponentMetadata.PropertyNames.Altcomponentid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAltComponentMetadata.ColumnNames.Recid, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewAltComponentMetadata.PropertyNames.Recid
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAltComponentMetadata.ColumnNames.Componentdesc, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewAltComponentMetadata.PropertyNames.Componentdesc
			c.CharacterMaxLength = 255
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAltComponentMetadata.ColumnNames.Vendordesc, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewAltComponentMetadata.PropertyNames.Vendordesc
			c.CharacterMaxLength = 255
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAltComponentMetadata.ColumnNames.Vendorname, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewAltComponentMetadata.PropertyNames.Vendorname
			c.CharacterMaxLength = 255
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAltComponentMetadata.ColumnNames.Vendoritemid, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewAltComponentMetadata.PropertyNames.Vendoritemid
			c.CharacterMaxLength = 255
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAltComponentMetadata.ColumnNames.Unitcost, 7, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewAltComponentMetadata.PropertyNames.Unitcost
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewAltComponentMetadata
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
			 Public Const Componentid As String = "COMPONENTID"
			 Public Const Altcomponentid As String = "ALTCOMPONENTID"
			 Public Const Recid As String = "RECID"
			 Public Const Componentdesc As String = "COMPONENTDESC"
			 Public Const Vendordesc As String = "VENDORDESC"
			 Public Const Vendorname As String = "VENDORNAME"
			 Public Const Vendoritemid As String = "VENDORITEMID"
			 Public Const Unitcost As String = "UNITCOST"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Componentid As String = "Componentid"
			 Public Const Altcomponentid As String = "Altcomponentid"
			 Public Const Recid As String = "Recid"
			 Public Const Componentdesc As String = "Componentdesc"
			 Public Const Vendordesc As String = "Vendordesc"
			 Public Const Vendorname As String = "Vendorname"
			 Public Const Vendoritemid As String = "Vendoritemid"
			 Public Const Unitcost As String = "Unitcost"
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
            SyncLock GetType(ViewAltComponentMetadata)
			
				If ViewAltComponentMetadata.mapDelegates Is Nothing Then
					ViewAltComponentMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewAltComponentMetadata._meta Is Nothing Then
                    ViewAltComponentMetadata._meta = New ViewAltComponentMetadata()
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
				

				meta.AddTypeMap("Componentid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Altcomponentid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Recid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Componentdesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Vendordesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Vendorname", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Vendoritemid", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Unitcost", new esTypeMap("money", "System.Decimal"))			
				
				
				 
				meta.Source = "viewAltComponent"
				meta.Destination = "viewAltComponent"
				
				meta.spInsert = "proc_viewAltComponentInsert"
				meta.spUpdate = "proc_viewAltComponentUpdate"
				meta.spDelete = "proc_viewAltComponentDelete"
				meta.spLoadAll = "proc_viewAltComponentLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewAltComponentLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewAltComponentMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
