'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/11/2014 1:36:10 PM
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
	MustInherit Public Class esViewRptBillOfLadingWgtByClassCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewRptBillOfLadingWgtByClassCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewRptBillOfLadingWgtByClassQuery)
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
            Me.InitQuery(CType(query, esViewRptBillOfLadingWgtByClassQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewRptBillOfLadingWgtByClass) As ViewRptBillOfLadingWgtByClass
			Return CType(MyBase.DetachEntity(entity), ViewRptBillOfLadingWgtByClass)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewRptBillOfLadingWgtByClass) As ViewRptBillOfLadingWgtByClass
			Return CType(MyBase.AttachEntity(entity), ViewRptBillOfLadingWgtByClass)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewRptBillOfLadingWgtByClassCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewRptBillOfLadingWgtByClass
            Get
                Return TryCast(MyBase.Item(index), ViewRptBillOfLadingWgtByClass)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewRptBillOfLadingWgtByClass)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewRptBillOfLadingWgtByClass	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewRptBillOfLadingWgtByClassQuery
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
												
						Case "LoadID"
							Me.str.LoadID = CType(value, string)
												
						Case "ClassRate"
							Me.str.ClassRate = CType(value, string)
												
						Case "TotalWeight"
							Me.str.TotalWeight = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "LoadID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.LoadID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "TotalWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.TotalWeight = CType(value, Nullable(Of System.Int32))
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
		' Maps to viewRptBillOfLading_WgtByClass.LoadID
		' </summary>
		Public Overridable Property LoadID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLadingWgtByClassMetadata.ColumnNames.LoadID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLadingWgtByClassMetadata.ColumnNames.LoadID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading_WgtByClass.ClassRate
		' </summary>
		Public Overridable Property ClassRate As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLadingWgtByClassMetadata.ColumnNames.ClassRate)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLadingWgtByClassMetadata.ColumnNames.ClassRate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading_WgtByClass.TotalWeight
		' </summary>
		Public Overridable Property TotalWeight As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLadingWgtByClassMetadata.ColumnNames.TotalWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLadingWgtByClassMetadata.ColumnNames.TotalWeight, value)
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
		
			Public Sub New(ByVal entity As esViewRptBillOfLadingWgtByClass)
				Me.entity = entity
			End Sub				
		
	
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
		  	
			Public Property TotalWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.TotalWeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TotalWeight = Nothing
					Else
						entity.TotalWeight = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewRptBillOfLadingWgtByClass
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewRptBillOfLadingWgtByClassQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewRptBillOfLadingWgtByClass can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewRptBillOfLadingWgtByClassQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRptBillOfLadingWgtByClassMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property LoadID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingWgtByClassMetadata.ColumnNames.LoadID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ClassRate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingWgtByClassMetadata.ColumnNames.ClassRate, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TotalWeight As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingWgtByClassMetadata.ColumnNames.TotalWeight, esSystemType.Int32)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewRptBillOfLadingWgtByClassCollection")> _
	Partial Public Class ViewRptBillOfLadingWgtByClassCollection
		Inherits esViewRptBillOfLadingWgtByClassCollection
		Implements IEnumerable(Of ViewRptBillOfLadingWgtByClass)
		
        Public Shared Widening Operator CType(ByVal coll As ViewRptBillOfLadingWgtByClassCollection) As List(Of ViewRptBillOfLadingWgtByClass)
            Dim list As List(Of ViewRptBillOfLadingWgtByClass) = New List(Of ViewRptBillOfLadingWgtByClass)
            Dim emp As ViewRptBillOfLadingWgtByClass

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRptBillOfLadingWgtByClassMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewRptBillOfLadingWgtByClassQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewRptBillOfLadingWgtByClass(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewRptBillOfLadingWgtByClass()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewRptBillOfLadingWgtByClassQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewRptBillOfLadingWgtByClassQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRptBillOfLadingWgtByClassQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewRptBillOfLadingWgtByClass 
			Return CType(MyBase.AddNewEntity(), ViewRptBillOfLadingWgtByClass)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewRptBillOfLadingWgtByClass) Implements IEnumerable(Of ViewRptBillOfLadingWgtByClass).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewRptBillOfLadingWgtByClass)(Me)
        End Function
		
		Private _query As ViewRptBillOfLadingWgtByClassQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewRptBillOfLading_WgtByClass' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewRptBillOfLadingWgtByClass ()")> _
	<Serializable> _
	Partial Public Class ViewRptBillOfLadingWgtByClass 
		Inherits esViewRptBillOfLadingWgtByClass

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewRptBillOfLadingWgtByClassMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewRptBillOfLadingWgtByClassQuery

			If Me._query Is Nothing Then
				Me._query = New ViewRptBillOfLadingWgtByClassQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewRptBillOfLadingWgtByClassQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewRptBillOfLadingWgtByClassQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRptBillOfLadingWgtByClassQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewRptBillOfLadingWgtByClassQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewRptBillOfLadingWgtByClassQuery
		inherits esViewRptBillOfLadingWgtByClassQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewRptBillOfLadingWgtByClassQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewRptBillOfLadingWgtByClassMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewRptBillOfLadingWgtByClassMetadata.ColumnNames.LoadID, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLadingWgtByClassMetadata.PropertyNames.LoadID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingWgtByClassMetadata.ColumnNames.ClassRate, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLadingWgtByClassMetadata.PropertyNames.ClassRate
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingWgtByClassMetadata.ColumnNames.TotalWeight, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLadingWgtByClassMetadata.PropertyNames.TotalWeight
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewRptBillOfLadingWgtByClassMetadata
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
			 Public Const LoadID As String = "LoadID"
			 Public Const ClassRate As String = "ClassRate"
			 Public Const TotalWeight As String = "TotalWeight"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const LoadID As String = "LoadID"
			 Public Const ClassRate As String = "ClassRate"
			 Public Const TotalWeight As String = "TotalWeight"
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
            SyncLock GetType(ViewRptBillOfLadingWgtByClassMetadata)
			
				If ViewRptBillOfLadingWgtByClassMetadata.mapDelegates Is Nothing Then
					ViewRptBillOfLadingWgtByClassMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewRptBillOfLadingWgtByClassMetadata._meta Is Nothing Then
                    ViewRptBillOfLadingWgtByClassMetadata._meta = New ViewRptBillOfLadingWgtByClassMetadata()
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
				

				meta.AddTypeMap("LoadID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ClassRate", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("TotalWeight", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "viewRptBillOfLading_WgtByClass"
				meta.Destination = "viewRptBillOfLading_WgtByClass"
				
				meta.spInsert = "proc_viewRptBillOfLading_WgtByClassInsert"
				meta.spUpdate = "proc_viewRptBillOfLading_WgtByClassUpdate"
				meta.spDelete = "proc_viewRptBillOfLading_WgtByClassDelete"
				meta.spLoadAll = "proc_viewRptBillOfLading_WgtByClassLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewRptBillOfLading_WgtByClassLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewRptBillOfLadingWgtByClassMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
