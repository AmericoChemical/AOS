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
	MustInherit Public Class esFormulaprocessCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "FormulaprocessCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esFormulaprocessQuery)
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
            Me.InitQuery(CType(query, esFormulaprocessQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Formulaprocess) As Formulaprocess
			Return CType(MyBase.DetachEntity(entity), Formulaprocess)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Formulaprocess) As Formulaprocess
			Return CType(MyBase.AttachEntity(entity), Formulaprocess)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As FormulaprocessCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Formulaprocess
            Get
                Return TryCast(MyBase.Item(index), Formulaprocess)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Formulaprocess)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esFormulaprocess	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esFormulaprocessQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal formulaprocessid As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(formulaprocessid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(formulaprocessid)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal formulaprocessid As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(formulaprocessid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(formulaprocessid)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal formulaprocessid As System.Int32) As Boolean
		
			Dim query As esFormulaprocessQuery = Me.GetDynamicQuery()
			query.Where(query.Formulaprocessid.Equal(formulaprocessid))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal formulaprocessid As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("FORMULAPROCESSID", formulaprocessid)
			
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
												
						Case "Formulaprocessid"
							Me.str.Formulaprocessid = CType(value, string)
												
						Case "Formulaid"
							Me.str.Formulaid = CType(value, string)
												
						Case "Processseq"
							Me.str.Processseq = CType(value, string)
												
						Case "Processtext"
							Me.str.Processtext = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Formulaprocessid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Formulaprocessid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Formulaid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Formulaid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Processseq"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Processseq = CType(value, Nullable(Of System.Int32))
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
		' Maps to FORMULAPROCESS.FORMULAPROCESSID
		' </summary>
		Public Overridable Property Formulaprocessid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(FormulaprocessMetadata.ColumnNames.Formulaprocessid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(FormulaprocessMetadata.ColumnNames.Formulaprocessid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to FORMULAPROCESS.FORMULAID
		' </summary>
		Public Overridable Property Formulaid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(FormulaprocessMetadata.ColumnNames.Formulaid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(FormulaprocessMetadata.ColumnNames.Formulaid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to FORMULAPROCESS.PROCESSSEQ
		' </summary>
		Public Overridable Property Processseq As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(FormulaprocessMetadata.ColumnNames.Processseq)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(FormulaprocessMetadata.ColumnNames.Processseq, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to FORMULAPROCESS.PROCESSTEXT
		' </summary>
		Public Overridable Property Processtext As System.String
			Get
				Return MyBase.GetSystemString(FormulaprocessMetadata.ColumnNames.Processtext)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(FormulaprocessMetadata.ColumnNames.Processtext, value)
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
		
			Public Sub New(ByVal entity As esFormulaprocess)
				Me.entity = entity
			End Sub				
		
	
			Public Property Formulaprocessid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Formulaprocessid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Formulaprocessid = Nothing
					Else
						entity.Formulaprocessid = Convert.ToInt32(Value)
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
		  	
			Public Property Processseq As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Processseq
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Processseq = Nothing
					Else
						entity.Processseq = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Processtext As System.String 
				Get
					Dim data_ As System.String = entity.Processtext
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Processtext = Nothing
					Else
						entity.Processtext = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esFormulaprocess
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esFormulaprocessQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esFormulaprocess can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esFormulaprocessQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return FormulaprocessMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Formulaprocessid As esQueryItem
			Get
				Return New esQueryItem(Me, FormulaprocessMetadata.ColumnNames.Formulaprocessid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Formulaid As esQueryItem
			Get
				Return New esQueryItem(Me, FormulaprocessMetadata.ColumnNames.Formulaid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Processseq As esQueryItem
			Get
				Return New esQueryItem(Me, FormulaprocessMetadata.ColumnNames.Processseq, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Processtext As esQueryItem
			Get
				Return New esQueryItem(Me, FormulaprocessMetadata.ColumnNames.Processtext, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("FormulaprocessCollection")> _
	Partial Public Class FormulaprocessCollection
		Inherits esFormulaprocessCollection
		Implements IEnumerable(Of Formulaprocess)
		
        Public Shared Widening Operator CType(ByVal coll As FormulaprocessCollection) As List(Of Formulaprocess)
            Dim list As List(Of Formulaprocess) = New List(Of Formulaprocess)
            Dim emp As Formulaprocess

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return FormulaprocessMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New FormulaprocessQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Formulaprocess(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Formulaprocess()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As FormulaprocessQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New FormulaprocessQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As FormulaprocessQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Formulaprocess 
			Return CType(MyBase.AddNewEntity(), Formulaprocess)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal formulaprocessid As System.Int32) As Formulaprocess
			Return CType(MyBase.FindByPrimaryKey(formulaprocessid), Formulaprocess)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Formulaprocess) Implements IEnumerable(Of Formulaprocess).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Formulaprocess)(Me)
        End Function
		
		Private _query As FormulaprocessQuery

	End Class
	


	' <summary>
	' Encapsulates the 'FORMULAPROCESS' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Formulaprocess ({Formulaprocessid.Value})")> _
	<Serializable> _
	Partial Public Class Formulaprocess 
		Inherits esFormulaprocess

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return FormulaprocessMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esFormulaprocessQuery

			If Me._query Is Nothing Then
				Me._query = New FormulaprocessQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As FormulaprocessQuery
			Get

				If Me._query Is Nothing then
					Me._query = New FormulaprocessQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As FormulaprocessQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As FormulaprocessQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class FormulaprocessQuery
		inherits esFormulaprocessQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
				

	End Class




	<Serializable> _
	Partial Public Class FormulaprocessMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(FormulaprocessMetadata.ColumnNames.Formulaprocessid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = FormulaprocessMetadata.PropertyNames.Formulaprocessid
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c) 
				
				
			c = New esColumnMetadata(FormulaprocessMetadata.ColumnNames.Formulaid, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = FormulaprocessMetadata.PropertyNames.Formulaid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c) 
				
				
			c = New esColumnMetadata(FormulaprocessMetadata.ColumnNames.Processseq, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = FormulaprocessMetadata.PropertyNames.Processseq
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c) 
				
				
			c = New esColumnMetadata(FormulaprocessMetadata.ColumnNames.Processtext, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = FormulaprocessMetadata.PropertyNames.Processtext
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c) 
				
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As FormulaprocessMetadata
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
			 Public Const Formulaprocessid As String = "FORMULAPROCESSID"
			 Public Const Formulaid As String = "FORMULAID"
			 Public Const Processseq As String = "PROCESSSEQ"
			 Public Const Processtext As String = "PROCESSTEXT"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Formulaprocessid As String = "Formulaprocessid"
			 Public Const Formulaid As String = "Formulaid"
			 Public Const Processseq As String = "Processseq"
			 Public Const Processtext As String = "Processtext"
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
            SyncLock GetType(FormulaprocessMetadata)
			
				If FormulaprocessMetadata.mapDelegates Is Nothing Then
					FormulaprocessMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If FormulaprocessMetadata._meta Is Nothing Then
                    FormulaprocessMetadata._meta = New FormulaprocessMetadata()
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
				

				meta.AddTypeMap("FORMULAPROCESSID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("FORMULAID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("PROCESSSEQ", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("PROCESSTEXT", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "FORMULAPROCESS"
				meta.Destination = "FORMULAPROCESS"
				
				meta.spInsert = "proc_FORMULAPROCESSInsert"
				meta.spUpdate = "proc_FORMULAPROCESSUpdate"
				meta.spDelete = "proc_FORMULAPROCESSDelete"
				meta.spLoadAll = "proc_FORMULAPROCESSLoadAll"
				meta.spLoadByPrimaryKey = "proc_FORMULAPROCESSLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As FormulaprocessMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
