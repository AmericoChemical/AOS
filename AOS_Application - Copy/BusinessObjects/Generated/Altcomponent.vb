'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 7/24/2014 9:38:18 PM
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
	MustInherit Public Class esAltcomponentCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "AltcomponentCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esAltcomponentQuery)
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
            Me.InitQuery(CType(query, esAltcomponentQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Altcomponent) As Altcomponent
			Return CType(MyBase.DetachEntity(entity), Altcomponent)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Altcomponent) As Altcomponent
			Return CType(MyBase.AttachEntity(entity), Altcomponent)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As AltcomponentCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Altcomponent
            Get
                Return TryCast(MyBase.Item(index), Altcomponent)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Altcomponent)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esAltcomponent	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esAltcomponentQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal recid As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(recid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(recid)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal recid As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(recid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(recid)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal recid As System.Int32) As Boolean
		
			Dim query As esAltcomponentQuery = Me.GetDynamicQuery()
			query.Where(query.Recid.Equal(recid))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal recid As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("RECID", recid)
			
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
												
						Case "Recid"
							Me.str.Recid = CType(value, string)
												
						Case "Componentid"
							Me.str.Componentid = CType(value, string)
												
						Case "Altcomponentid"
							Me.str.Altcomponentid = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Recid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Recid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Componentid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Componentid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Altcomponentid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Altcomponentid = CType(value, Nullable(Of System.Int32))
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
		' Maps to ALTCOMPONENT.RECID
		' </summary>
		Public Overridable Property Recid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(AltcomponentMetadata.ColumnNames.Recid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(AltcomponentMetadata.ColumnNames.Recid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to ALTCOMPONENT.COMPONENTID
		' </summary>
		Public Overridable Property Componentid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(AltcomponentMetadata.ColumnNames.Componentid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(AltcomponentMetadata.ColumnNames.Componentid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to ALTCOMPONENT.ALTCOMPONENTID
		' </summary>
		Public Overridable Property Altcomponentid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(AltcomponentMetadata.ColumnNames.Altcomponentid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(AltcomponentMetadata.ColumnNames.Altcomponentid, value)
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
		
			Public Sub New(ByVal entity As esAltcomponent)
				Me.entity = entity
			End Sub				
		
	
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
		  

			Private entity As esAltcomponent
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esAltcomponentQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esAltcomponent can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Altcomponent 
		Inherits esAltcomponent
		
	
		
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
	MustInherit Public Class esAltcomponentQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return AltcomponentMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Recid As esQueryItem
			Get
				Return New esQueryItem(Me, AltcomponentMetadata.ColumnNames.Recid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Componentid As esQueryItem
			Get
				Return New esQueryItem(Me, AltcomponentMetadata.ColumnNames.Componentid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Altcomponentid As esQueryItem
			Get
				Return New esQueryItem(Me, AltcomponentMetadata.ColumnNames.Altcomponentid, esSystemType.Int32)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("AltcomponentCollection")> _
	Partial Public Class AltcomponentCollection
		Inherits esAltcomponentCollection
		Implements IEnumerable(Of Altcomponent)
		
        Public Shared Widening Operator CType(ByVal coll As AltcomponentCollection) As List(Of Altcomponent)
            Dim list As List(Of Altcomponent) = New List(Of Altcomponent)
            Dim emp As Altcomponent

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return AltcomponentMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New AltcomponentQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Altcomponent(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Altcomponent()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As AltcomponentQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New AltcomponentQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As AltcomponentQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Altcomponent 
			Return CType(MyBase.AddNewEntity(), Altcomponent)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal recid As System.Int32) As Altcomponent
			Return CType(MyBase.FindByPrimaryKey(recid), Altcomponent)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Altcomponent) Implements IEnumerable(Of Altcomponent).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Altcomponent)(Me)
        End Function
		
		Private _query As AltcomponentQuery

	End Class
	


	' <summary>
	' Encapsulates the 'ALTCOMPONENT' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Altcomponent ({Recid.Value})")> _
	<Serializable> _
	Partial Public Class Altcomponent 
		Inherits esAltcomponent

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return AltcomponentMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esAltcomponentQuery

			If Me._query Is Nothing Then
				Me._query = New AltcomponentQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As AltcomponentQuery
			Get

				If Me._query Is Nothing then
					Me._query = New AltcomponentQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As AltcomponentQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As AltcomponentQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class AltcomponentQuery
		inherits esAltcomponentQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "AltcomponentQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class AltcomponentMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(AltcomponentMetadata.ColumnNames.Recid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = AltcomponentMetadata.PropertyNames.Recid
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(AltcomponentMetadata.ColumnNames.Componentid, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = AltcomponentMetadata.PropertyNames.Componentid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(AltcomponentMetadata.ColumnNames.Altcomponentid, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = AltcomponentMetadata.PropertyNames.Altcomponentid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As AltcomponentMetadata
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
			 Public Const Recid As String = "RECID"
			 Public Const Componentid As String = "COMPONENTID"
			 Public Const Altcomponentid As String = "ALTCOMPONENTID"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Recid As String = "Recid"
			 Public Const Componentid As String = "Componentid"
			 Public Const Altcomponentid As String = "Altcomponentid"
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
            SyncLock GetType(AltcomponentMetadata)
			
				If AltcomponentMetadata.mapDelegates Is Nothing Then
					AltcomponentMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If AltcomponentMetadata._meta Is Nothing Then
                    AltcomponentMetadata._meta = New AltcomponentMetadata()
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
				

				meta.AddTypeMap("Recid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Componentid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Altcomponentid", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "ALTCOMPONENT"
				meta.Destination = "ALTCOMPONENT"
				
				meta.spInsert = "proc_ALTCOMPONENTInsert"
				meta.spUpdate = "proc_ALTCOMPONENTUpdate"
				meta.spDelete = "proc_ALTCOMPONENTDelete"
				meta.spLoadAll = "proc_ALTCOMPONENTLoadAll"
				meta.spLoadByPrimaryKey = "proc_ALTCOMPONENTLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As AltcomponentMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
