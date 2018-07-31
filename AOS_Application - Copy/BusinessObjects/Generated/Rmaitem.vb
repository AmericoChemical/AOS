'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/11/2014 1:43:57 PM
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
	MustInherit Public Class esRmaitemCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "RmaitemCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esRmaitemQuery)
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
            Me.InitQuery(CType(query, esRmaitemQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Rmaitem) As Rmaitem
			Return CType(MyBase.DetachEntity(entity), Rmaitem)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Rmaitem) As Rmaitem
			Return CType(MyBase.AttachEntity(entity), Rmaitem)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As RmaitemCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Rmaitem
            Get
                Return TryCast(MyBase.Item(index), Rmaitem)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Rmaitem)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esRmaitem	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esRmaitemQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal rmaitemid As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(rmaitemid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(rmaitemid)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal rmaitemid As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(rmaitemid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(rmaitemid)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal rmaitemid As System.Int32) As Boolean
		
			Dim query As esRmaitemQuery = Me.GetDynamicQuery()
			query.Where(query.Rmaitemid.Equal(rmaitemid))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal rmaitemid As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("RMAITEMID", rmaitemid)
			
			Return Me.Load(esQueryType.StoredProcedure, Me.es.spLoadByPrimaryKey, parms)
			
		End Function
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
												
						Case "Rmaitemid"
							Me.str.Rmaitemid = CType(value, string)
												
						Case "Rmaid"
							Me.str.Rmaid = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Rmaitemid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Rmaitemid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Rmaid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Rmaid = CType(value, Nullable(Of System.Int32))
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
		' Maps to RMAITEM.RMAITEMID
		' </summary>
		Public Overridable Property Rmaitemid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(RmaitemMetadata.ColumnNames.Rmaitemid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(RmaitemMetadata.ColumnNames.Rmaitemid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RMAITEM.RMAID
		' </summary>
		Public Overridable Property Rmaid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(RmaitemMetadata.ColumnNames.Rmaid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(RmaitemMetadata.ColumnNames.Rmaid, value)
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
		
			Public Sub New(ByVal entity As esRmaitem)
				Me.entity = entity
			End Sub				
		
	
			Public Property Rmaitemid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Rmaitemid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Rmaitemid = Nothing
					Else
						entity.Rmaitemid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Rmaid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Rmaid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Rmaid = Nothing
					Else
						entity.Rmaid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esRmaitem
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esRmaitemQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esRmaitem can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Rmaitem 
		Inherits esRmaitem
		
	
		
		''' <summary>
		''' Used internally by the entity's hierarchical properties.
		''' </summary>
        Protected Overrides Function GetHierarchicalProperties() As List(Of esPropertyDescriptor)
        
            Dim props As New List(Of esPropertyDescriptor)
			

            Return props
			
        End Function	
		
		''' <summary>
		''' Used internally for retrieving AutoIncrementing keys
		''' during hierarchical PreSave.
		''' </summary>
		Protected Overrides Sub ApplyPreSaveKeys()
		
		End Sub
		
		''' <summary>
		''' Used internally for retrieving AutoIncrementing keys
		''' during hierarchical PostSave.
		''' </summary>
		Protected Overrides Sub ApplyPostSaveKeys()
		
		End Sub
		
		''' <summary>
		''' Used internally for retrieving AutoIncrementing keys
		''' during hierarchical PostOneSave.
		''' </summary>
		Protected Overrides Sub ApplyPostOneSaveKeys()
		
		End Sub
	End Class
	


	<Serializable> _
	MustInherit Public Class esRmaitemQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return RmaitemMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Rmaitemid As esQueryItem
			Get
				Return New esQueryItem(Me, RmaitemMetadata.ColumnNames.Rmaitemid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Rmaid As esQueryItem
			Get
				Return New esQueryItem(Me, RmaitemMetadata.ColumnNames.Rmaid, esSystemType.Int32)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("RmaitemCollection")> _
	Partial Public Class RmaitemCollection
		Inherits esRmaitemCollection
		Implements IEnumerable(Of Rmaitem)
		
        Public Shared Widening Operator CType(ByVal coll As RmaitemCollection) As List(Of Rmaitem)
            Dim list As List(Of Rmaitem) = New List(Of Rmaitem)
            Dim emp As Rmaitem

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return RmaitemMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New RmaitemQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Rmaitem(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Rmaitem()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As RmaitemQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New RmaitemQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As RmaitemQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Rmaitem 
			Return CType(MyBase.AddNewEntity(), Rmaitem)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal rmaitemid As System.Int32) As Rmaitem
			Return CType(MyBase.FindByPrimaryKey(rmaitemid), Rmaitem)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Rmaitem) Implements IEnumerable(Of Rmaitem).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Rmaitem)(Me)
        End Function
		
		Private _query As RmaitemQuery

	End Class
	


	' <summary>
	' Encapsulates the 'RMAITEM' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Rmaitem ({Rmaitemid.Value})")> _
	<Serializable> _
	Partial Public Class Rmaitem 
		Inherits esRmaitem

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return RmaitemMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esRmaitemQuery

			If Me._query Is Nothing Then
				Me._query = New RmaitemQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As RmaitemQuery
			Get

				If Me._query Is Nothing then
					Me._query = New RmaitemQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As RmaitemQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As RmaitemQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class RmaitemQuery
		inherits esRmaitemQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "RmaitemQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class RmaitemMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(RmaitemMetadata.ColumnNames.Rmaitemid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = RmaitemMetadata.PropertyNames.Rmaitemid
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(RmaitemMetadata.ColumnNames.Rmaid, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = RmaitemMetadata.PropertyNames.Rmaid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As RmaitemMetadata
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
			 Public Const Rmaitemid As String = "RMAITEMID"
			 Public Const Rmaid As String = "RMAID"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Rmaitemid As String = "Rmaitemid"
			 Public Const Rmaid As String = "Rmaid"
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
            SyncLock GetType(RmaitemMetadata)
			
				If RmaitemMetadata.mapDelegates Is Nothing Then
					RmaitemMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If RmaitemMetadata._meta Is Nothing Then
                    RmaitemMetadata._meta = New RmaitemMetadata()
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
				

				meta.AddTypeMap("Rmaitemid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Rmaid", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "RMAITEM"
				meta.Destination = "RMAITEM"
				
				meta.spInsert = "proc_RMAITEMInsert"
				meta.spUpdate = "proc_RMAITEMUpdate"
				meta.spDelete = "proc_RMAITEMDelete"
				meta.spLoadAll = "proc_RMAITEMLoadAll"
				meta.spLoadByPrimaryKey = "proc_RMAITEMLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As RmaitemMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
