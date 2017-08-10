'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.1.0209.0
' EntitySpaces Driver  : SQL
' Date Generated       : 10/2/2011 1:56:49 PM
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
 
Namespace BusinessObjects


	<Serializable> _
	MustInherit Public Class esFormulachangehistoryCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "FormulachangehistoryCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esFormulachangehistoryQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es.Connection = CType(Me, IEntityCollection).Connection
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
            Me.InitQuery(CType(query, esFormulachangehistoryQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Formulachangehistory) As Formulachangehistory
			Return CType(MyBase.DetachEntity(entity), Formulachangehistory)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Formulachangehistory) As Formulachangehistory
			Return CType(MyBase.AttachEntity(entity), Formulachangehistory)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As FormulachangehistoryCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Formulachangehistory
            Get
                Return TryCast(MyBase.Item(index), Formulachangehistory)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Formulachangehistory)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esFormulachangehistory	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esFormulachangehistoryQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal formulachangeid As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(formulachangeid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(formulachangeid)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal formulachangeid As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(formulachangeid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(formulachangeid)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal formulachangeid As System.Int32) As Boolean
		
			Dim query As esFormulachangehistoryQuery = Me.GetDynamicQuery()
			query.Where(query.Formulachangeid.Equal(formulachangeid))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal formulachangeid As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("FORMULACHANGEID", formulachangeid)
			
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
												
						Case "Formulachangeid"
							Me.str.Formulachangeid = CType(value, string)
												
						Case "Formulaid"
							Me.str.Formulaid = CType(value, string)
												
						Case "Changedate"
							Me.str.Changedate = CType(value, string)
												
						Case "Whochanged"
							Me.str.Whochanged = CType(value, string)
												
						Case "Reasonforchange"
							Me.str.Reasonforchange = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Formulachangeid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Formulachangeid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Formulaid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Formulaid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Changedate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Changedate = CType(value, Nullable(Of System.DateTime))
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
		' Maps to FORMULACHANGEHISTORY.FORMULACHANGEID
		' </summary>
		Public Overridable Property Formulachangeid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(FormulachangehistoryMetadata.ColumnNames.Formulachangeid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(FormulachangehistoryMetadata.ColumnNames.Formulachangeid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to FORMULACHANGEHISTORY.FORMULAID
		' </summary>
		Public Overridable Property Formulaid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(FormulachangehistoryMetadata.ColumnNames.Formulaid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(FormulachangehistoryMetadata.ColumnNames.Formulaid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to FORMULACHANGEHISTORY.CHANGEDATE
		' </summary>
		Public Overridable Property Changedate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(FormulachangehistoryMetadata.ColumnNames.Changedate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(FormulachangehistoryMetadata.ColumnNames.Changedate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to FORMULACHANGEHISTORY.WHOCHANGED
		' </summary>
		Public Overridable Property Whochanged As System.String
			Get
				Return MyBase.GetSystemString(FormulachangehistoryMetadata.ColumnNames.Whochanged)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(FormulachangehistoryMetadata.ColumnNames.Whochanged, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to FORMULACHANGEHISTORY.REASONFORCHANGE
		' </summary>
		Public Overridable Property Reasonforchange As System.String
			Get
				Return MyBase.GetSystemString(FormulachangehistoryMetadata.ColumnNames.Reasonforchange)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(FormulachangehistoryMetadata.ColumnNames.Reasonforchange, value)
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
		
			Public Sub New(ByVal entity As esFormulachangehistory)
				Me.entity = entity
			End Sub				
		
	
			Public Property Formulachangeid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Formulachangeid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Formulachangeid = Nothing
					Else
						entity.Formulachangeid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Formulaid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Formulaid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Formulaid = Nothing
					Else
						entity.Formulaid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Changedate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Changedate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Changedate = Nothing
					Else
						entity.Changedate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Whochanged As System.String 
				Get
					Dim data_ As System.String = entity.Whochanged
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Whochanged = Nothing
					Else
						entity.Whochanged = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Reasonforchange As System.String 
				Get
					Dim data_ As System.String = entity.Reasonforchange
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Reasonforchange = Nothing
					Else
						entity.Reasonforchange = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esFormulachangehistory
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esFormulachangehistoryQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esFormulachangehistory can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esFormulachangehistoryQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return FormulachangehistoryMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Formulachangeid As esQueryItem
			Get
				Return New esQueryItem(Me, FormulachangehistoryMetadata.ColumnNames.Formulachangeid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Formulaid As esQueryItem
			Get
				Return New esQueryItem(Me, FormulachangehistoryMetadata.ColumnNames.Formulaid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Changedate As esQueryItem
			Get
				Return New esQueryItem(Me, FormulachangehistoryMetadata.ColumnNames.Changedate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Whochanged As esQueryItem
			Get
				Return New esQueryItem(Me, FormulachangehistoryMetadata.ColumnNames.Whochanged, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Reasonforchange As esQueryItem
			Get
				Return New esQueryItem(Me, FormulachangehistoryMetadata.ColumnNames.Reasonforchange, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("FormulachangehistoryCollection")> _
	Partial Public Class FormulachangehistoryCollection
		Inherits esFormulachangehistoryCollection
		Implements IEnumerable(Of Formulachangehistory)
		
        Public Shared Widening Operator CType(ByVal coll As FormulachangehistoryCollection) As List(Of Formulachangehistory)
            Dim list As List(Of Formulachangehistory) = New List(Of Formulachangehistory)
            Dim emp As Formulachangehistory

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return FormulachangehistoryMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New FormulachangehistoryQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Formulachangehistory(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Formulachangehistory()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As FormulachangehistoryQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New FormulachangehistoryQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As FormulachangehistoryQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Formulachangehistory 
			Return CType(MyBase.AddNewEntity(), Formulachangehistory)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal formulachangeid As System.Int32) As Formulachangehistory
			Return CType(MyBase.FindByPrimaryKey(formulachangeid), Formulachangehistory)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Formulachangehistory) Implements IEnumerable(Of Formulachangehistory).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Formulachangehistory)(Me)
        End Function
		
		Private _query As FormulachangehistoryQuery

	End Class
	


	' <summary>
	' Encapsulates the 'FORMULACHANGEHISTORY' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Formulachangehistory ({Formulachangeid.Value})")> _
	<Serializable> _
	Partial Public Class Formulachangehistory 
		Inherits esFormulachangehistory

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return FormulachangehistoryMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esFormulachangehistoryQuery

			If Me._query Is Nothing Then
				Me._query = New FormulachangehistoryQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As FormulachangehistoryQuery
			Get

				If Me._query Is Nothing then
					Me._query = New FormulachangehistoryQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As FormulachangehistoryQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As FormulachangehistoryQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class FormulachangehistoryQuery
		inherits esFormulachangehistoryQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
				

	End Class




	<Serializable> _
	Partial Public Class FormulachangehistoryMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(FormulachangehistoryMetadata.ColumnNames.Formulachangeid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = FormulachangehistoryMetadata.PropertyNames.Formulachangeid
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c) 
				
				
			c = New esColumnMetadata(FormulachangehistoryMetadata.ColumnNames.Formulaid, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = FormulachangehistoryMetadata.PropertyNames.Formulaid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c) 
				
				
			c = New esColumnMetadata(FormulachangehistoryMetadata.ColumnNames.Changedate, 2, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = FormulachangehistoryMetadata.PropertyNames.Changedate
			c.IsNullable = True
			_columns.Add(c) 
				
				
			c = New esColumnMetadata(FormulachangehistoryMetadata.ColumnNames.Whochanged, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = FormulachangehistoryMetadata.PropertyNames.Whochanged
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c) 
				
				
			c = New esColumnMetadata(FormulachangehistoryMetadata.ColumnNames.Reasonforchange, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = FormulachangehistoryMetadata.PropertyNames.Reasonforchange
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c) 
				
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As FormulachangehistoryMetadata
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
			 Public Const Formulachangeid As String = "FORMULACHANGEID"
			 Public Const Formulaid As String = "FORMULAID"
			 Public Const Changedate As String = "CHANGEDATE"
			 Public Const Whochanged As String = "WHOCHANGED"
			 Public Const Reasonforchange As String = "REASONFORCHANGE"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Formulachangeid As String = "Formulachangeid"
			 Public Const Formulaid As String = "Formulaid"
			 Public Const Changedate As String = "Changedate"
			 Public Const Whochanged As String = "Whochanged"
			 Public Const Reasonforchange As String = "Reasonforchange"
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
            SyncLock GetType(FormulachangehistoryMetadata)
			
				If FormulachangehistoryMetadata.mapDelegates Is Nothing Then
					FormulachangehistoryMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If FormulachangehistoryMetadata._meta Is Nothing Then
                    FormulachangehistoryMetadata._meta = New FormulachangehistoryMetadata()
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
				

				meta.AddTypeMap("FORMULACHANGEID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("FORMULAID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("CHANGEDATE", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("WHOCHANGED", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("REASONFORCHANGE", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "FORMULACHANGEHISTORY"
				meta.Destination = "FORMULACHANGEHISTORY"
				
				meta.spInsert = "proc_FORMULACHANGEHISTORYInsert"
				meta.spUpdate = "proc_FORMULACHANGEHISTORYUpdate"
				meta.spDelete = "proc_FORMULACHANGEHISTORYDelete"
				meta.spLoadAll = "proc_FORMULACHANGEHISTORYLoadAll"
				meta.spLoadByPrimaryKey = "proc_FORMULACHANGEHISTORYLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As FormulachangehistoryMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
