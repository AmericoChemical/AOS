'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/11/2014 1:36:08 PM
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
	MustInherit Public Class esViewChemicalBOMDataCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewChemicalBOMDataCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewChemicalBOMDataQuery)
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
            Me.InitQuery(CType(query, esViewChemicalBOMDataQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewChemicalBOMData) As ViewChemicalBOMData
			Return CType(MyBase.DetachEntity(entity), ViewChemicalBOMData)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewChemicalBOMData) As ViewChemicalBOMData
			Return CType(MyBase.AttachEntity(entity), ViewChemicalBOMData)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewChemicalBOMDataCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewChemicalBOMData
            Get
                Return TryCast(MyBase.Item(index), ViewChemicalBOMData)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewChemicalBOMData)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewChemicalBOMData	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewChemicalBOMDataQuery
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
												
						Case "PrimaryChemicalID"
							Me.str.PrimaryChemicalID = CType(value, string)
												
						Case "ChemicalID"
							Me.str.ChemicalID = CType(value, string)
												
						Case "Chemicalname"
							Me.str.Chemicalname = CType(value, string)
												
						Case "Casnumber"
							Me.str.Casnumber = CType(value, string)
												
						Case "Percbywgt"
							Me.str.Percbywgt = CType(value, string)
												
						Case "Chembomid"
							Me.str.Chembomid = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "PrimaryChemicalID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.PrimaryChemicalID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "ChemicalID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ChemicalID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Percbywgt"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Percbywgt = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Chembomid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Chembomid = CType(value, Nullable(Of System.Int32))
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
		' Maps to viewChemicalBOMData.PrimaryChemicalID
		' </summary>
		Public Overridable Property PrimaryChemicalID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewChemicalBOMDataMetadata.ColumnNames.PrimaryChemicalID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewChemicalBOMDataMetadata.ColumnNames.PrimaryChemicalID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewChemicalBOMData.ChemicalID
		' </summary>
		Public Overridable Property ChemicalID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewChemicalBOMDataMetadata.ColumnNames.ChemicalID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewChemicalBOMDataMetadata.ColumnNames.ChemicalID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewChemicalBOMData.CHEMICALNAME
		' </summary>
		Public Overridable Property Chemicalname As System.String
			Get
				Return MyBase.GetSystemString(ViewChemicalBOMDataMetadata.ColumnNames.Chemicalname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewChemicalBOMDataMetadata.ColumnNames.Chemicalname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewChemicalBOMData.CASNUMBER
		' </summary>
		Public Overridable Property Casnumber As System.String
			Get
				Return MyBase.GetSystemString(ViewChemicalBOMDataMetadata.ColumnNames.Casnumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewChemicalBOMDataMetadata.ColumnNames.Casnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewChemicalBOMData.PERCBYWGT
		' </summary>
		Public Overridable Property Percbywgt As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewChemicalBOMDataMetadata.ColumnNames.Percbywgt)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewChemicalBOMDataMetadata.ColumnNames.Percbywgt, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewChemicalBOMData.CHEMBOMID
		' </summary>
		Public Overridable Property Chembomid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewChemicalBOMDataMetadata.ColumnNames.Chembomid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewChemicalBOMDataMetadata.ColumnNames.Chembomid, value)
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
		
			Public Sub New(ByVal entity As esViewChemicalBOMData)
				Me.entity = entity
			End Sub				
		
	
			Public Property PrimaryChemicalID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.PrimaryChemicalID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PrimaryChemicalID = Nothing
					Else
						entity.PrimaryChemicalID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property ChemicalID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.ChemicalID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ChemicalID = Nothing
					Else
						entity.ChemicalID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Chemicalname As System.String 
				Get
					Dim data_ As System.String = entity.Chemicalname
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Chemicalname = Nothing
					Else
						entity.Chemicalname = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Casnumber As System.String 
				Get
					Dim data_ As System.String = entity.Casnumber
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Casnumber = Nothing
					Else
						entity.Casnumber = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Percbywgt As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Percbywgt
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Percbywgt = Nothing
					Else
						entity.Percbywgt = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Chembomid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Chembomid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Chembomid = Nothing
					Else
						entity.Chembomid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewChemicalBOMData
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewChemicalBOMDataQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewChemicalBOMData can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewChemicalBOMDataQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewChemicalBOMDataMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property PrimaryChemicalID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewChemicalBOMDataMetadata.ColumnNames.PrimaryChemicalID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ChemicalID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewChemicalBOMDataMetadata.ColumnNames.ChemicalID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Chemicalname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewChemicalBOMDataMetadata.ColumnNames.Chemicalname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Casnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewChemicalBOMDataMetadata.ColumnNames.Casnumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Percbywgt As esQueryItem
			Get
				Return New esQueryItem(Me, ViewChemicalBOMDataMetadata.ColumnNames.Percbywgt, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Chembomid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewChemicalBOMDataMetadata.ColumnNames.Chembomid, esSystemType.Int32)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewChemicalBOMDataCollection")> _
	Partial Public Class ViewChemicalBOMDataCollection
		Inherits esViewChemicalBOMDataCollection
		Implements IEnumerable(Of ViewChemicalBOMData)
		
        Public Shared Widening Operator CType(ByVal coll As ViewChemicalBOMDataCollection) As List(Of ViewChemicalBOMData)
            Dim list As List(Of ViewChemicalBOMData) = New List(Of ViewChemicalBOMData)
            Dim emp As ViewChemicalBOMData

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewChemicalBOMDataMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewChemicalBOMDataQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewChemicalBOMData(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewChemicalBOMData()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewChemicalBOMDataQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewChemicalBOMDataQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewChemicalBOMDataQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewChemicalBOMData 
			Return CType(MyBase.AddNewEntity(), ViewChemicalBOMData)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewChemicalBOMData) Implements IEnumerable(Of ViewChemicalBOMData).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewChemicalBOMData)(Me)
        End Function
		
		Private _query As ViewChemicalBOMDataQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewChemicalBOMData' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewChemicalBOMData ()")> _
	<Serializable> _
	Partial Public Class ViewChemicalBOMData 
		Inherits esViewChemicalBOMData

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewChemicalBOMDataMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewChemicalBOMDataQuery

			If Me._query Is Nothing Then
				Me._query = New ViewChemicalBOMDataQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewChemicalBOMDataQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewChemicalBOMDataQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewChemicalBOMDataQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewChemicalBOMDataQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewChemicalBOMDataQuery
		inherits esViewChemicalBOMDataQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewChemicalBOMDataQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewChemicalBOMDataMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewChemicalBOMDataMetadata.ColumnNames.PrimaryChemicalID, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewChemicalBOMDataMetadata.PropertyNames.PrimaryChemicalID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewChemicalBOMDataMetadata.ColumnNames.ChemicalID, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewChemicalBOMDataMetadata.PropertyNames.ChemicalID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewChemicalBOMDataMetadata.ColumnNames.Chemicalname, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewChemicalBOMDataMetadata.PropertyNames.Chemicalname
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewChemicalBOMDataMetadata.ColumnNames.Casnumber, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewChemicalBOMDataMetadata.PropertyNames.Casnumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewChemicalBOMDataMetadata.ColumnNames.Percbywgt, 4, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewChemicalBOMDataMetadata.PropertyNames.Percbywgt
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewChemicalBOMDataMetadata.ColumnNames.Chembomid, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewChemicalBOMDataMetadata.PropertyNames.Chembomid
			c.NumericPrecision = 10
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewChemicalBOMDataMetadata
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
			 Public Const PrimaryChemicalID As String = "PrimaryChemicalID"
			 Public Const ChemicalID As String = "ChemicalID"
			 Public Const Chemicalname As String = "CHEMICALNAME"
			 Public Const Casnumber As String = "CASNUMBER"
			 Public Const Percbywgt As String = "PERCBYWGT"
			 Public Const Chembomid As String = "CHEMBOMID"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const PrimaryChemicalID As String = "PrimaryChemicalID"
			 Public Const ChemicalID As String = "ChemicalID"
			 Public Const Chemicalname As String = "Chemicalname"
			 Public Const Casnumber As String = "Casnumber"
			 Public Const Percbywgt As String = "Percbywgt"
			 Public Const Chembomid As String = "Chembomid"
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
            SyncLock GetType(ViewChemicalBOMDataMetadata)
			
				If ViewChemicalBOMDataMetadata.mapDelegates Is Nothing Then
					ViewChemicalBOMDataMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewChemicalBOMDataMetadata._meta Is Nothing Then
                    ViewChemicalBOMDataMetadata._meta = New ViewChemicalBOMDataMetadata()
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
				

				meta.AddTypeMap("PrimaryChemicalID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ChemicalID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Chemicalname", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Casnumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Percbywgt", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Chembomid", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "viewChemicalBOMData"
				meta.Destination = "viewChemicalBOMData"
				
				meta.spInsert = "proc_viewChemicalBOMDataInsert"
				meta.spUpdate = "proc_viewChemicalBOMDataUpdate"
				meta.spDelete = "proc_viewChemicalBOMDataDelete"
				meta.spLoadAll = "proc_viewChemicalBOMDataLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewChemicalBOMDataLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewChemicalBOMDataMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
