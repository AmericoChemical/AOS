'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 7/2/2014 11:11:19 PM
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
	MustInherit Public Class esViewPricingMethodCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewPricingMethodCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewPricingMethodQuery)
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
            Me.InitQuery(CType(query, esViewPricingMethodQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewPricingMethod) As ViewPricingMethod
			Return CType(MyBase.DetachEntity(entity), ViewPricingMethod)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewPricingMethod) As ViewPricingMethod
			Return CType(MyBase.AttachEntity(entity), ViewPricingMethod)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewPricingMethodCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewPricingMethod
            Get
                Return TryCast(MyBase.Item(index), ViewPricingMethod)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewPricingMethod)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewPricingMethod	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewPricingMethodQuery
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
												
						Case "PricingMethod"
							Me.str.PricingMethod = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
					
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
		' Maps to viewPricingMethod.PricingMethod
		' </summary>
		Public Overridable Property PricingMethod As System.String
			Get
				Return MyBase.GetSystemString(ViewPricingMethodMetadata.ColumnNames.PricingMethod)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewPricingMethodMetadata.ColumnNames.PricingMethod, value)
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
		
			Public Sub New(ByVal entity As esViewPricingMethod)
				Me.entity = entity
			End Sub				
		
	
			Public Property PricingMethod As System.String 
				Get
					Dim data_ As System.String = entity.PricingMethod
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PricingMethod = Nothing
					Else
						entity.PricingMethod = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewPricingMethod
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewPricingMethodQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewPricingMethod can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewPricingMethodQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewPricingMethodMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property PricingMethod As esQueryItem
			Get
				Return New esQueryItem(Me, ViewPricingMethodMetadata.ColumnNames.PricingMethod, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewPricingMethodCollection")> _
	Partial Public Class ViewPricingMethodCollection
		Inherits esViewPricingMethodCollection
		Implements IEnumerable(Of ViewPricingMethod)
		
        Public Shared Widening Operator CType(ByVal coll As ViewPricingMethodCollection) As List(Of ViewPricingMethod)
            Dim list As List(Of ViewPricingMethod) = New List(Of ViewPricingMethod)
            Dim emp As ViewPricingMethod

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewPricingMethodMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewPricingMethodQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewPricingMethod(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewPricingMethod()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewPricingMethodQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewPricingMethodQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewPricingMethodQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewPricingMethod 
			Return CType(MyBase.AddNewEntity(), ViewPricingMethod)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewPricingMethod) Implements IEnumerable(Of ViewPricingMethod).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewPricingMethod)(Me)
        End Function
		
		Private _query As ViewPricingMethodQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewPricingMethod' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewPricingMethod ()")> _
	<Serializable> _
	Partial Public Class ViewPricingMethod 
		Inherits esViewPricingMethod

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewPricingMethodMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewPricingMethodQuery

			If Me._query Is Nothing Then
				Me._query = New ViewPricingMethodQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewPricingMethodQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewPricingMethodQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewPricingMethodQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewPricingMethodQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewPricingMethodQuery
		inherits esViewPricingMethodQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewPricingMethodQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewPricingMethodMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewPricingMethodMetadata.ColumnNames.PricingMethod, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewPricingMethodMetadata.PropertyNames.PricingMethod
			c.CharacterMaxLength = 10
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewPricingMethodMetadata
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
			 Public Const PricingMethod As String = "PricingMethod"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const PricingMethod As String = "PricingMethod"
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
            SyncLock GetType(ViewPricingMethodMetadata)
			
				If ViewPricingMethodMetadata.mapDelegates Is Nothing Then
					ViewPricingMethodMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewPricingMethodMetadata._meta Is Nothing Then
                    ViewPricingMethodMetadata._meta = New ViewPricingMethodMetadata()
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
				

				meta.AddTypeMap("PricingMethod", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewPricingMethod"
				meta.Destination = "viewPricingMethod"
				
				meta.spInsert = "proc_viewPricingMethodInsert"
				meta.spUpdate = "proc_viewPricingMethodUpdate"
				meta.spDelete = "proc_viewPricingMethodDelete"
				meta.spLoadAll = "proc_viewPricingMethodLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewPricingMethodLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewPricingMethodMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
