'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 3/27/2014 10:22:09 AM
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
	MustInherit Public Class esViewCustomerLookupCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewCustomerLookupCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewCustomerLookupQuery)
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
            Me.InitQuery(CType(query, esViewCustomerLookupQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewCustomerLookup) As ViewCustomerLookup
			Return CType(MyBase.DetachEntity(entity), ViewCustomerLookup)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewCustomerLookup) As ViewCustomerLookup
			Return CType(MyBase.AttachEntity(entity), ViewCustomerLookup)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewCustomerLookupCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewCustomerLookup
            Get
                Return TryCast(MyBase.Item(index), ViewCustomerLookup)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewCustomerLookup)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewCustomerLookup	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewCustomerLookupQuery
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
												
						Case "Custid"
							Me.str.Custid = CType(value, string)
												
						Case "Custname"
							Me.str.Custname = CType(value, string)
												
						Case "Custshipcity"
							Me.str.Custshipcity = CType(value, string)
												
						Case "Custshipstateprov"
							Me.str.Custshipstateprov = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Custid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Custid = CType(value, Nullable(Of System.Int32))
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
		' Maps to viewCustomerLookup.CUSTID
		' </summary>
		Public Overridable Property Custid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewCustomerLookupMetadata.ColumnNames.Custid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewCustomerLookupMetadata.ColumnNames.Custid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerLookup.CUSTNAME
		' </summary>
		Public Overridable Property Custname As System.String
			Get
				Return MyBase.GetSystemString(ViewCustomerLookupMetadata.ColumnNames.Custname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCustomerLookupMetadata.ColumnNames.Custname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerLookup.CUSTSHIPCITY
		' </summary>
		Public Overridable Property Custshipcity As System.String
			Get
				Return MyBase.GetSystemString(ViewCustomerLookupMetadata.ColumnNames.Custshipcity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCustomerLookupMetadata.ColumnNames.Custshipcity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewCustomerLookup.CUSTSHIPSTATEPROV
		' </summary>
		Public Overridable Property Custshipstateprov As System.String
			Get
				Return MyBase.GetSystemString(ViewCustomerLookupMetadata.ColumnNames.Custshipstateprov)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewCustomerLookupMetadata.ColumnNames.Custshipstateprov, value)
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
		
			Public Sub New(ByVal entity As esViewCustomerLookup)
				Me.entity = entity
			End Sub				
		
	
			Public Property Custid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Custid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Custid = Nothing
					Else
						entity.Custid = Convert.ToInt32(Value)
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
		  	
			Public Property Custshipcity As System.String 
				Get
					Dim data_ As System.String = entity.Custshipcity
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Custshipcity = Nothing
					Else
						entity.Custshipcity = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Custshipstateprov As System.String 
				Get
					Dim data_ As System.String = entity.Custshipstateprov
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Custshipstateprov = Nothing
					Else
						entity.Custshipstateprov = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewCustomerLookup
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewCustomerLookupQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewCustomerLookup can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewCustomerLookupQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCustomerLookupMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Custid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerLookupMetadata.ColumnNames.Custid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Custname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerLookupMetadata.ColumnNames.Custname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Custshipcity As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerLookupMetadata.ColumnNames.Custshipcity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Custshipstateprov As esQueryItem
			Get
				Return New esQueryItem(Me, ViewCustomerLookupMetadata.ColumnNames.Custshipstateprov, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewCustomerLookupCollection")> _
	Partial Public Class ViewCustomerLookupCollection
		Inherits esViewCustomerLookupCollection
		Implements IEnumerable(Of ViewCustomerLookup)
		
        Public Shared Widening Operator CType(ByVal coll As ViewCustomerLookupCollection) As List(Of ViewCustomerLookup)
            Dim list As List(Of ViewCustomerLookup) = New List(Of ViewCustomerLookup)
            Dim emp As ViewCustomerLookup

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewCustomerLookupMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewCustomerLookupQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewCustomerLookup(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewCustomerLookup()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewCustomerLookupQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewCustomerLookupQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewCustomerLookupQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewCustomerLookup 
			Return CType(MyBase.AddNewEntity(), ViewCustomerLookup)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewCustomerLookup) Implements IEnumerable(Of ViewCustomerLookup).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewCustomerLookup)(Me)
        End Function
		
		Private _query As ViewCustomerLookupQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewCustomerLookup' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewCustomerLookup ()")> _
	<Serializable> _
	Partial Public Class ViewCustomerLookup 
		Inherits esViewCustomerLookup

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewCustomerLookupMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewCustomerLookupQuery

			If Me._query Is Nothing Then
				Me._query = New ViewCustomerLookupQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewCustomerLookupQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewCustomerLookupQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewCustomerLookupQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewCustomerLookupQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewCustomerLookupQuery
		inherits esViewCustomerLookupQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewCustomerLookupQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewCustomerLookupMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewCustomerLookupMetadata.ColumnNames.Custid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewCustomerLookupMetadata.PropertyNames.Custid
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerLookupMetadata.ColumnNames.Custname, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCustomerLookupMetadata.PropertyNames.Custname
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerLookupMetadata.ColumnNames.Custshipcity, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCustomerLookupMetadata.PropertyNames.Custshipcity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewCustomerLookupMetadata.ColumnNames.Custshipstateprov, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewCustomerLookupMetadata.PropertyNames.Custshipstateprov
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewCustomerLookupMetadata
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
			 Public Const Custid As String = "CUSTID"
			 Public Const Custname As String = "CUSTNAME"
			 Public Const Custshipcity As String = "CUSTSHIPCITY"
			 Public Const Custshipstateprov As String = "CUSTSHIPSTATEPROV"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Custid As String = "Custid"
			 Public Const Custname As String = "Custname"
			 Public Const Custshipcity As String = "Custshipcity"
			 Public Const Custshipstateprov As String = "Custshipstateprov"
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
            SyncLock GetType(ViewCustomerLookupMetadata)
			
				If ViewCustomerLookupMetadata.mapDelegates Is Nothing Then
					ViewCustomerLookupMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewCustomerLookupMetadata._meta Is Nothing Then
                    ViewCustomerLookupMetadata._meta = New ViewCustomerLookupMetadata()
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
				

				meta.AddTypeMap("Custid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Custname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Custshipcity", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Custshipstateprov", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewCustomerLookup"
				meta.Destination = "viewCustomerLookup"
				
				meta.spInsert = "proc_viewCustomerLookupInsert"
				meta.spUpdate = "proc_viewCustomerLookupUpdate"
				meta.spDelete = "proc_viewCustomerLookupDelete"
				meta.spLoadAll = "proc_viewCustomerLookupLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewCustomerLookupLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewCustomerLookupMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
