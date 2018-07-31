'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 12/31/2014 10:18:48 PM
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
	MustInherit Public Class esViewAppUserCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewAppUserCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewAppUserQuery)
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
            Me.InitQuery(CType(query, esViewAppUserQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewAppUser) As ViewAppUser
			Return CType(MyBase.DetachEntity(entity), ViewAppUser)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewAppUser) As ViewAppUser
			Return CType(MyBase.AttachEntity(entity), ViewAppUser)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewAppUserCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewAppUser
            Get
                Return TryCast(MyBase.Item(index), ViewAppUser)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewAppUser)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewAppUser	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewAppUserQuery
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
												
						Case "Appuserid"
							Me.str.Appuserid = CType(value, string)
												
						Case "Userlogin"
							Me.str.Userlogin = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Appuserid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Appuserid = CType(value, Nullable(Of System.Int32))
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
		' Maps to viewAppUser.APPUSERID
		' </summary>
		Public Overridable Property Appuserid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewAppUserMetadata.ColumnNames.Appuserid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewAppUserMetadata.ColumnNames.Appuserid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAppUser.USERLOGIN
		' </summary>
		Public Overridable Property Userlogin As System.String
			Get
				Return MyBase.GetSystemString(ViewAppUserMetadata.ColumnNames.Userlogin)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewAppUserMetadata.ColumnNames.Userlogin, value)
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
		
			Public Sub New(ByVal entity As esViewAppUser)
				Me.entity = entity
			End Sub				
		
	
			Public Property Appuserid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Appuserid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Appuserid = Nothing
					Else
						entity.Appuserid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Userlogin As System.String 
				Get
					Dim data_ As System.String = entity.Userlogin
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Userlogin = Nothing
					Else
						entity.Userlogin = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewAppUser
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewAppUserQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewAppUser can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewAppUserQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewAppUserMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Appuserid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAppUserMetadata.ColumnNames.Appuserid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Userlogin As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAppUserMetadata.ColumnNames.Userlogin, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewAppUserCollection")> _
	Partial Public Class ViewAppUserCollection
		Inherits esViewAppUserCollection
		Implements IEnumerable(Of ViewAppUser)
		
        Public Shared Widening Operator CType(ByVal coll As ViewAppUserCollection) As List(Of ViewAppUser)
            Dim list As List(Of ViewAppUser) = New List(Of ViewAppUser)
            Dim emp As ViewAppUser

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewAppUserMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewAppUserQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewAppUser(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewAppUser()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewAppUserQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewAppUserQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewAppUserQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewAppUser 
			Return CType(MyBase.AddNewEntity(), ViewAppUser)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewAppUser) Implements IEnumerable(Of ViewAppUser).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewAppUser)(Me)
        End Function
		
		Private _query As ViewAppUserQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewAppUser' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewAppUser ()")> _
	<Serializable> _
	Partial Public Class ViewAppUser 
		Inherits esViewAppUser

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewAppUserMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewAppUserQuery

			If Me._query Is Nothing Then
				Me._query = New ViewAppUserQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewAppUserQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewAppUserQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewAppUserQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewAppUserQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewAppUserQuery
		inherits esViewAppUserQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewAppUserQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewAppUserMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewAppUserMetadata.ColumnNames.Appuserid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewAppUserMetadata.PropertyNames.Appuserid
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAppUserMetadata.ColumnNames.Userlogin, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewAppUserMetadata.PropertyNames.Userlogin
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewAppUserMetadata
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
			 Public Const Appuserid As String = "APPUSERID"
			 Public Const Userlogin As String = "USERLOGIN"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Appuserid As String = "Appuserid"
			 Public Const Userlogin As String = "Userlogin"
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
            SyncLock GetType(ViewAppUserMetadata)
			
				If ViewAppUserMetadata.mapDelegates Is Nothing Then
					ViewAppUserMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewAppUserMetadata._meta Is Nothing Then
                    ViewAppUserMetadata._meta = New ViewAppUserMetadata()
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
				

				meta.AddTypeMap("Appuserid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Userlogin", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewAppUser"
				meta.Destination = "viewAppUser"
				
				meta.spInsert = "proc_viewAppUserInsert"
				meta.spUpdate = "proc_viewAppUserUpdate"
				meta.spDelete = "proc_viewAppUserDelete"
				meta.spLoadAll = "proc_viewAppUserLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewAppUserLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewAppUserMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
