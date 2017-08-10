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
	MustInherit Public Class esViewRptBillOfLadingWgtByIDNumberCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewRptBillOfLadingWgtByIDNumberCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewRptBillOfLadingWgtByIDNumberQuery)
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
            Me.InitQuery(CType(query, esViewRptBillOfLadingWgtByIDNumberQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewRptBillOfLadingWgtByIDNumber) As ViewRptBillOfLadingWgtByIDNumber
			Return CType(MyBase.DetachEntity(entity), ViewRptBillOfLadingWgtByIDNumber)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewRptBillOfLadingWgtByIDNumber) As ViewRptBillOfLadingWgtByIDNumber
			Return CType(MyBase.AttachEntity(entity), ViewRptBillOfLadingWgtByIDNumber)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewRptBillOfLadingWgtByIDNumberCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewRptBillOfLadingWgtByIDNumber
            Get
                Return TryCast(MyBase.Item(index), ViewRptBillOfLadingWgtByIDNumber)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewRptBillOfLadingWgtByIDNumber)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewRptBillOfLadingWgtByIDNumber	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewRptBillOfLadingWgtByIDNumberQuery
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
												
						Case "DOTIDNumber"
							Me.str.DOTIDNumber = CType(value, string)
												
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
		' Maps to viewRptBillOfLading_WgtByIDNumber.LoadID
		' </summary>
		Public Overridable Property LoadID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLadingWgtByIDNumberMetadata.ColumnNames.LoadID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLadingWgtByIDNumberMetadata.ColumnNames.LoadID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading_WgtByIDNumber.DOTIDNumber
		' </summary>
		Public Overridable Property DOTIDNumber As System.String
			Get
				Return MyBase.GetSystemString(ViewRptBillOfLadingWgtByIDNumberMetadata.ColumnNames.DOTIDNumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewRptBillOfLadingWgtByIDNumberMetadata.ColumnNames.DOTIDNumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewRptBillOfLading_WgtByIDNumber.TotalWeight
		' </summary>
		Public Overridable Property TotalWeight As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewRptBillOfLadingWgtByIDNumberMetadata.ColumnNames.TotalWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewRptBillOfLadingWgtByIDNumberMetadata.ColumnNames.TotalWeight, value)
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
		
			Public Sub New(ByVal entity As esViewRptBillOfLadingWgtByIDNumber)
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
		  	
			Public Property DOTIDNumber As System.String 
				Get
					Dim data_ As System.String = entity.DOTIDNumber
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DOTIDNumber = Nothing
					Else
						entity.DOTIDNumber = Convert.ToString(Value)
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
		  

			Private entity As esViewRptBillOfLadingWgtByIDNumber
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewRptBillOfLadingWgtByIDNumberQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewRptBillOfLadingWgtByIDNumber can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewRptBillOfLadingWgtByIDNumberQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRptBillOfLadingWgtByIDNumberMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property LoadID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingWgtByIDNumberMetadata.ColumnNames.LoadID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property DOTIDNumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingWgtByIDNumberMetadata.ColumnNames.DOTIDNumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TotalWeight As esQueryItem
			Get
				Return New esQueryItem(Me, ViewRptBillOfLadingWgtByIDNumberMetadata.ColumnNames.TotalWeight, esSystemType.Int32)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewRptBillOfLadingWgtByIDNumberCollection")> _
	Partial Public Class ViewRptBillOfLadingWgtByIDNumberCollection
		Inherits esViewRptBillOfLadingWgtByIDNumberCollection
		Implements IEnumerable(Of ViewRptBillOfLadingWgtByIDNumber)
		
        Public Shared Widening Operator CType(ByVal coll As ViewRptBillOfLadingWgtByIDNumberCollection) As List(Of ViewRptBillOfLadingWgtByIDNumber)
            Dim list As List(Of ViewRptBillOfLadingWgtByIDNumber) = New List(Of ViewRptBillOfLadingWgtByIDNumber)
            Dim emp As ViewRptBillOfLadingWgtByIDNumber

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewRptBillOfLadingWgtByIDNumberMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewRptBillOfLadingWgtByIDNumberQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewRptBillOfLadingWgtByIDNumber(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewRptBillOfLadingWgtByIDNumber()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewRptBillOfLadingWgtByIDNumberQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewRptBillOfLadingWgtByIDNumberQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRptBillOfLadingWgtByIDNumberQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewRptBillOfLadingWgtByIDNumber 
			Return CType(MyBase.AddNewEntity(), ViewRptBillOfLadingWgtByIDNumber)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewRptBillOfLadingWgtByIDNumber) Implements IEnumerable(Of ViewRptBillOfLadingWgtByIDNumber).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewRptBillOfLadingWgtByIDNumber)(Me)
        End Function
		
		Private _query As ViewRptBillOfLadingWgtByIDNumberQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewRptBillOfLading_WgtByIDNumber' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewRptBillOfLadingWgtByIDNumber ()")> _
	<Serializable> _
	Partial Public Class ViewRptBillOfLadingWgtByIDNumber 
		Inherits esViewRptBillOfLadingWgtByIDNumber

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewRptBillOfLadingWgtByIDNumberMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewRptBillOfLadingWgtByIDNumberQuery

			If Me._query Is Nothing Then
				Me._query = New ViewRptBillOfLadingWgtByIDNumberQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewRptBillOfLadingWgtByIDNumberQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewRptBillOfLadingWgtByIDNumberQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewRptBillOfLadingWgtByIDNumberQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewRptBillOfLadingWgtByIDNumberQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewRptBillOfLadingWgtByIDNumberQuery
		inherits esViewRptBillOfLadingWgtByIDNumberQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewRptBillOfLadingWgtByIDNumberQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewRptBillOfLadingWgtByIDNumberMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewRptBillOfLadingWgtByIDNumberMetadata.ColumnNames.LoadID, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLadingWgtByIDNumberMetadata.PropertyNames.LoadID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingWgtByIDNumberMetadata.ColumnNames.DOTIDNumber, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewRptBillOfLadingWgtByIDNumberMetadata.PropertyNames.DOTIDNumber
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewRptBillOfLadingWgtByIDNumberMetadata.ColumnNames.TotalWeight, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewRptBillOfLadingWgtByIDNumberMetadata.PropertyNames.TotalWeight
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewRptBillOfLadingWgtByIDNumberMetadata
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
			 Public Const DOTIDNumber As String = "DOTIDNumber"
			 Public Const TotalWeight As String = "TotalWeight"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const LoadID As String = "LoadID"
			 Public Const DOTIDNumber As String = "DOTIDNumber"
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
            SyncLock GetType(ViewRptBillOfLadingWgtByIDNumberMetadata)
			
				If ViewRptBillOfLadingWgtByIDNumberMetadata.mapDelegates Is Nothing Then
					ViewRptBillOfLadingWgtByIDNumberMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewRptBillOfLadingWgtByIDNumberMetadata._meta Is Nothing Then
                    ViewRptBillOfLadingWgtByIDNumberMetadata._meta = New ViewRptBillOfLadingWgtByIDNumberMetadata()
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
				meta.AddTypeMap("DOTIDNumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("TotalWeight", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "viewRptBillOfLading_WgtByIDNumber"
				meta.Destination = "viewRptBillOfLading_WgtByIDNumber"
				
				meta.spInsert = "proc_viewRptBillOfLading_WgtByIDNumberInsert"
				meta.spUpdate = "proc_viewRptBillOfLading_WgtByIDNumberUpdate"
				meta.spDelete = "proc_viewRptBillOfLading_WgtByIDNumberDelete"
				meta.spLoadAll = "proc_viewRptBillOfLading_WgtByIDNumberLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewRptBillOfLading_WgtByIDNumberLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewRptBillOfLadingWgtByIDNumberMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
