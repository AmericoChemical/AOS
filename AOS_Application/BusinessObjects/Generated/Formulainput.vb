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
	MustInherit Public Class esFormulainputCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "FormulainputCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esFormulainputQuery)
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
            Me.InitQuery(CType(query, esFormulainputQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Formulainput) As Formulainput
			Return CType(MyBase.DetachEntity(entity), Formulainput)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Formulainput) As Formulainput
			Return CType(MyBase.AttachEntity(entity), Formulainput)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As FormulainputCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Formulainput
            Get
                Return TryCast(MyBase.Item(index), Formulainput)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Formulainput)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esFormulainput	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esFormulainputQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal formulainputid As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(formulainputid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(formulainputid)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal formulainputid As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(formulainputid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(formulainputid)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal formulainputid As System.Int32) As Boolean
		
			Dim query As esFormulainputQuery = Me.GetDynamicQuery()
			query.Where(query.Formulainputid.Equal(formulainputid))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal formulainputid As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("FORMULAINPUTID", formulainputid)
			
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
												
						Case "Formulainputid"
							Me.str.Formulainputid = CType(value, string)
												
						Case "Formulaid"
							Me.str.Formulaid = CType(value, string)
												
						Case "Materialid"
							Me.str.Materialid = CType(value, string)
												
						Case "Qtyunits"
							Me.str.Qtyunits = CType(value, string)
												
						Case "Uom"
							Me.str.Uom = CType(value, string)
												
						Case "Materialnote"
							Me.str.Materialnote = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Formulainputid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Formulainputid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Formulaid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Formulaid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Materialid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Materialid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Qtyunits"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Qtyunits = CType(value, Nullable(Of System.Double))
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
		' Maps to FORMULAINPUT.FORMULAINPUTID
		' </summary>
		Public Overridable Property Formulainputid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(FormulainputMetadata.ColumnNames.Formulainputid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(FormulainputMetadata.ColumnNames.Formulainputid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to FORMULAINPUT.FORMULAID
		' </summary>
		Public Overridable Property Formulaid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(FormulainputMetadata.ColumnNames.Formulaid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(FormulainputMetadata.ColumnNames.Formulaid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to FORMULAINPUT.MATERIALID
		' </summary>
		Public Overridable Property Materialid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(FormulainputMetadata.ColumnNames.Materialid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(FormulainputMetadata.ColumnNames.Materialid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to FORMULAINPUT.QTYUNITS
		' </summary>
		Public Overridable Property Qtyunits As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(FormulainputMetadata.ColumnNames.Qtyunits)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(FormulainputMetadata.ColumnNames.Qtyunits, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to FORMULAINPUT.UOM
		' </summary>
		Public Overridable Property Uom As System.String
			Get
				Return MyBase.GetSystemString(FormulainputMetadata.ColumnNames.Uom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(FormulainputMetadata.ColumnNames.Uom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to FORMULAINPUT.MATERIALNOTE
		' </summary>
		Public Overridable Property Materialnote As System.String
			Get
				Return MyBase.GetSystemString(FormulainputMetadata.ColumnNames.Materialnote)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(FormulainputMetadata.ColumnNames.Materialnote, value)
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
		
			Public Sub New(ByVal entity As esFormulainput)
				Me.entity = entity
			End Sub				
		
	
			Public Property Formulainputid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Formulainputid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Formulainputid = Nothing
					Else
						entity.Formulainputid = Convert.ToInt32(Value)
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
		  	
			Public Property Materialid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Materialid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Materialid = Nothing
					Else
						entity.Materialid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Qtyunits As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Qtyunits
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qtyunits = Nothing
					Else
						entity.Qtyunits = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property Uom As System.String 
				Get
					Dim data_ As System.String = entity.Uom
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Uom = Nothing
					Else
						entity.Uom = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Materialnote As System.String 
				Get
					Dim data_ As System.String = entity.Materialnote
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Materialnote = Nothing
					Else
						entity.Materialnote = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esFormulainput
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esFormulainputQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esFormulainput can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esFormulainputQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return FormulainputMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Formulainputid As esQueryItem
			Get
				Return New esQueryItem(Me, FormulainputMetadata.ColumnNames.Formulainputid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Formulaid As esQueryItem
			Get
				Return New esQueryItem(Me, FormulainputMetadata.ColumnNames.Formulaid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Materialid As esQueryItem
			Get
				Return New esQueryItem(Me, FormulainputMetadata.ColumnNames.Materialid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Qtyunits As esQueryItem
			Get
				Return New esQueryItem(Me, FormulainputMetadata.ColumnNames.Qtyunits, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Uom As esQueryItem
			Get
				Return New esQueryItem(Me, FormulainputMetadata.ColumnNames.Uom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Materialnote As esQueryItem
			Get
				Return New esQueryItem(Me, FormulainputMetadata.ColumnNames.Materialnote, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("FormulainputCollection")> _
	Partial Public Class FormulainputCollection
		Inherits esFormulainputCollection
		Implements IEnumerable(Of Formulainput)
		
        Public Shared Widening Operator CType(ByVal coll As FormulainputCollection) As List(Of Formulainput)
            Dim list As List(Of Formulainput) = New List(Of Formulainput)
            Dim emp As Formulainput

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return FormulainputMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New FormulainputQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Formulainput(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Formulainput()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As FormulainputQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New FormulainputQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As FormulainputQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Formulainput 
			Return CType(MyBase.AddNewEntity(), Formulainput)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal formulainputid As System.Int32) As Formulainput
			Return CType(MyBase.FindByPrimaryKey(formulainputid), Formulainput)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Formulainput) Implements IEnumerable(Of Formulainput).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Formulainput)(Me)
        End Function
		
		Private _query As FormulainputQuery

	End Class
	


	' <summary>
	' Encapsulates the 'FORMULAINPUT' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Formulainput ({Formulainputid.Value})")> _
	<Serializable> _
	Partial Public Class Formulainput 
		Inherits esFormulainput

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return FormulainputMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esFormulainputQuery

			If Me._query Is Nothing Then
				Me._query = New FormulainputQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As FormulainputQuery
			Get

				If Me._query Is Nothing then
					Me._query = New FormulainputQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As FormulainputQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As FormulainputQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class FormulainputQuery
		inherits esFormulainputQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
				

	End Class




	<Serializable> _
	Partial Public Class FormulainputMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(FormulainputMetadata.ColumnNames.Formulainputid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = FormulainputMetadata.PropertyNames.Formulainputid
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c) 
				
				
			c = New esColumnMetadata(FormulainputMetadata.ColumnNames.Formulaid, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = FormulainputMetadata.PropertyNames.Formulaid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c) 
				
				
			c = New esColumnMetadata(FormulainputMetadata.ColumnNames.Materialid, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = FormulainputMetadata.PropertyNames.Materialid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c) 
				
				
			c = New esColumnMetadata(FormulainputMetadata.ColumnNames.Qtyunits, 3, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = FormulainputMetadata.PropertyNames.Qtyunits
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c) 
				
				
			c = New esColumnMetadata(FormulainputMetadata.ColumnNames.Uom, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = FormulainputMetadata.PropertyNames.Uom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c) 
				
				
			c = New esColumnMetadata(FormulainputMetadata.ColumnNames.Materialnote, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = FormulainputMetadata.PropertyNames.Materialnote
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c) 
				
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As FormulainputMetadata
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
			 Public Const Formulainputid As String = "FORMULAINPUTID"
			 Public Const Formulaid As String = "FORMULAID"
			 Public Const Materialid As String = "MATERIALID"
			 Public Const Qtyunits As String = "QTYUNITS"
			 Public Const Uom As String = "UOM"
			 Public Const Materialnote As String = "MATERIALNOTE"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Formulainputid As String = "Formulainputid"
			 Public Const Formulaid As String = "Formulaid"
			 Public Const Materialid As String = "Materialid"
			 Public Const Qtyunits As String = "Qtyunits"
			 Public Const Uom As String = "Uom"
			 Public Const Materialnote As String = "Materialnote"
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
            SyncLock GetType(FormulainputMetadata)
			
				If FormulainputMetadata.mapDelegates Is Nothing Then
					FormulainputMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If FormulainputMetadata._meta Is Nothing Then
                    FormulainputMetadata._meta = New FormulainputMetadata()
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
				

				meta.AddTypeMap("FORMULAINPUTID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("FORMULAID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("MATERIALID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("QTYUNITS", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("UOM", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("MATERIALNOTE", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "FORMULAINPUT"
				meta.Destination = "FORMULAINPUT"
				
				meta.spInsert = "proc_FORMULAINPUTInsert"
				meta.spUpdate = "proc_FORMULAINPUTUpdate"
				meta.spDelete = "proc_FORMULAINPUTDelete"
				meta.spLoadAll = "proc_FORMULAINPUTLoadAll"
				meta.spLoadByPrimaryKey = "proc_FORMULAINPUTLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As FormulainputMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
