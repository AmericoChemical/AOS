'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/11/2014 1:36:09 PM
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
	MustInherit Public Class esViewLoadWeightByItemClassCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewLoadWeightByItemClassCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewLoadWeightByItemClassQuery)
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
            Me.InitQuery(CType(query, esViewLoadWeightByItemClassQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewLoadWeightByItemClass) As ViewLoadWeightByItemClass
			Return CType(MyBase.DetachEntity(entity), ViewLoadWeightByItemClass)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewLoadWeightByItemClass) As ViewLoadWeightByItemClass
			Return CType(MyBase.AttachEntity(entity), ViewLoadWeightByItemClass)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewLoadWeightByItemClassCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewLoadWeightByItemClass
            Get
                Return TryCast(MyBase.Item(index), ViewLoadWeightByItemClass)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewLoadWeightByItemClass)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewLoadWeightByItemClass	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewLoadWeightByItemClassQuery
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
												
						Case "ClassRate"
							Me.str.ClassRate = CType(value, string)
												
						Case "GrossWgt"
							Me.str.GrossWgt = CType(value, string)
												
						Case "LoadID"
							Me.str.LoadID = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "GrossWgt"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.GrossWgt = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "LoadID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.LoadID = CType(value, Nullable(Of System.Int32))
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
		' Maps to viewLoadWeightByItemClass.ClassRate
		' </summary>
		Public Overridable Property ClassRate As System.String
			Get
				Return MyBase.GetSystemString(ViewLoadWeightByItemClassMetadata.ColumnNames.ClassRate)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewLoadWeightByItemClassMetadata.ColumnNames.ClassRate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadWeightByItemClass.GrossWgt
		' </summary>
		Public Overridable Property GrossWgt As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadWeightByItemClassMetadata.ColumnNames.GrossWgt)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadWeightByItemClassMetadata.ColumnNames.GrossWgt, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewLoadWeightByItemClass.LoadID
		' </summary>
		Public Overridable Property LoadID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewLoadWeightByItemClassMetadata.ColumnNames.LoadID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewLoadWeightByItemClassMetadata.ColumnNames.LoadID, value)
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
		
			Public Sub New(ByVal entity As esViewLoadWeightByItemClass)
				Me.entity = entity
			End Sub				
		
	
			Public Property ClassRate As System.String 
				Get
					Dim data_ As System.String = entity.ClassRate
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ClassRate = Nothing
					Else
						entity.ClassRate = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property GrossWgt As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.GrossWgt
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.GrossWgt = Nothing
					Else
						entity.GrossWgt = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property LoadID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.LoadID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LoadID = Nothing
					Else
						entity.LoadID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewLoadWeightByItemClass
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewLoadWeightByItemClassQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewLoadWeightByItemClass can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewLoadWeightByItemClassQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewLoadWeightByItemClassMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property ClassRate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadWeightByItemClassMetadata.ColumnNames.ClassRate, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property GrossWgt As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadWeightByItemClassMetadata.ColumnNames.GrossWgt, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LoadID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewLoadWeightByItemClassMetadata.ColumnNames.LoadID, esSystemType.Int32)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewLoadWeightByItemClassCollection")> _
	Partial Public Class ViewLoadWeightByItemClassCollection
		Inherits esViewLoadWeightByItemClassCollection
		Implements IEnumerable(Of ViewLoadWeightByItemClass)
		
        Public Shared Widening Operator CType(ByVal coll As ViewLoadWeightByItemClassCollection) As List(Of ViewLoadWeightByItemClass)
            Dim list As List(Of ViewLoadWeightByItemClass) = New List(Of ViewLoadWeightByItemClass)
            Dim emp As ViewLoadWeightByItemClass

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewLoadWeightByItemClassMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewLoadWeightByItemClassQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewLoadWeightByItemClass(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewLoadWeightByItemClass()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewLoadWeightByItemClassQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewLoadWeightByItemClassQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewLoadWeightByItemClassQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewLoadWeightByItemClass 
			Return CType(MyBase.AddNewEntity(), ViewLoadWeightByItemClass)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewLoadWeightByItemClass) Implements IEnumerable(Of ViewLoadWeightByItemClass).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewLoadWeightByItemClass)(Me)
        End Function
		
		Private _query As ViewLoadWeightByItemClassQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewLoadWeightByItemClass' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewLoadWeightByItemClass ()")> _
	<Serializable> _
	Partial Public Class ViewLoadWeightByItemClass 
		Inherits esViewLoadWeightByItemClass

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewLoadWeightByItemClassMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewLoadWeightByItemClassQuery

			If Me._query Is Nothing Then
				Me._query = New ViewLoadWeightByItemClassQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewLoadWeightByItemClassQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewLoadWeightByItemClassQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewLoadWeightByItemClassQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewLoadWeightByItemClassQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewLoadWeightByItemClassQuery
		inherits esViewLoadWeightByItemClassQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewLoadWeightByItemClassQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewLoadWeightByItemClassMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewLoadWeightByItemClassMetadata.ColumnNames.ClassRate, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewLoadWeightByItemClassMetadata.PropertyNames.ClassRate
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadWeightByItemClassMetadata.ColumnNames.GrossWgt, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadWeightByItemClassMetadata.PropertyNames.GrossWgt
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewLoadWeightByItemClassMetadata.ColumnNames.LoadID, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewLoadWeightByItemClassMetadata.PropertyNames.LoadID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewLoadWeightByItemClassMetadata
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
			 Public Const ClassRate As String = "ClassRate"
			 Public Const GrossWgt As String = "GrossWgt"
			 Public Const LoadID As String = "LoadID"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const ClassRate As String = "ClassRate"
			 Public Const GrossWgt As String = "GrossWgt"
			 Public Const LoadID As String = "LoadID"
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
            SyncLock GetType(ViewLoadWeightByItemClassMetadata)
			
				If ViewLoadWeightByItemClassMetadata.mapDelegates Is Nothing Then
					ViewLoadWeightByItemClassMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewLoadWeightByItemClassMetadata._meta Is Nothing Then
                    ViewLoadWeightByItemClassMetadata._meta = New ViewLoadWeightByItemClassMetadata()
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
				

				meta.AddTypeMap("ClassRate", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("GrossWgt", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("LoadID", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "viewLoadWeightByItemClass"
				meta.Destination = "viewLoadWeightByItemClass"
				
				meta.spInsert = "proc_viewLoadWeightByItemClassInsert"
				meta.spUpdate = "proc_viewLoadWeightByItemClassUpdate"
				meta.spDelete = "proc_viewLoadWeightByItemClassDelete"
				meta.spLoadAll = "proc_viewLoadWeightByItemClassLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewLoadWeightByItemClassLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewLoadWeightByItemClassMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
