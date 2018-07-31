'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/11/2014 1:43:55 PM
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
	MustInherit Public Class esChemicalbomCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ChemicalbomCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esChemicalbomQuery)
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
            Me.InitQuery(CType(query, esChemicalbomQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Chemicalbom) As Chemicalbom
			Return CType(MyBase.DetachEntity(entity), Chemicalbom)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Chemicalbom) As Chemicalbom
			Return CType(MyBase.AttachEntity(entity), Chemicalbom)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ChemicalbomCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Chemicalbom
            Get
                Return TryCast(MyBase.Item(index), Chemicalbom)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Chemicalbom)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esChemicalbom	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esChemicalbomQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal chembomid As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(chembomid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(chembomid)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal chembomid As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(chembomid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(chembomid)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal chembomid As System.Int32) As Boolean
		
			Dim query As esChemicalbomQuery = Me.GetDynamicQuery()
			query.Where(query.Chembomid.Equal(chembomid))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal chembomid As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("CHEMBOMID", chembomid)
			
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
												
						Case "Chembomid"
							Me.str.Chembomid = CType(value, string)
												
						Case "Chemicalid1"
							Me.str.Chemicalid1 = CType(value, string)
												
						Case "Chemicalid2"
							Me.str.Chemicalid2 = CType(value, string)
												
						Case "Units"
							Me.str.Units = CType(value, string)
												
						Case "Uom"
							Me.str.Uom = CType(value, string)
												
						Case "Percbywgt"
							Me.str.Percbywgt = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Chembomid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Chembomid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Chemicalid1"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Chemicalid1 = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Chemicalid2"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Chemicalid2 = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Units"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Units = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Percbywgt"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Percbywgt = CType(value, Nullable(Of System.Decimal))
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
		' Maps to CHEMICALBOM.CHEMBOMID
		' </summary>
		Public Overridable Property Chembomid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ChemicalbomMetadata.ColumnNames.Chembomid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ChemicalbomMetadata.ColumnNames.Chembomid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHEMICALBOM.CHEMICALID1
		' </summary>
		Public Overridable Property Chemicalid1 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ChemicalbomMetadata.ColumnNames.Chemicalid1)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ChemicalbomMetadata.ColumnNames.Chemicalid1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHEMICALBOM.CHEMICALID2
		' </summary>
		Public Overridable Property Chemicalid2 As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ChemicalbomMetadata.ColumnNames.Chemicalid2)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ChemicalbomMetadata.ColumnNames.Chemicalid2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHEMICALBOM.UNITS
		' </summary>
		Public Overridable Property Units As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ChemicalbomMetadata.ColumnNames.Units)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ChemicalbomMetadata.ColumnNames.Units, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHEMICALBOM.UOM
		' </summary>
		Public Overridable Property Uom As System.String
			Get
				Return MyBase.GetSystemString(ChemicalbomMetadata.ColumnNames.Uom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ChemicalbomMetadata.ColumnNames.Uom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHEMICALBOM.PERCBYWGT
		' </summary>
		Public Overridable Property Percbywgt As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ChemicalbomMetadata.ColumnNames.Percbywgt)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ChemicalbomMetadata.ColumnNames.Percbywgt, value)
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
		
			Public Sub New(ByVal entity As esChemicalbom)
				Me.entity = entity
			End Sub				
		
	
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
		  	
			Public Property Chemicalid1 As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Chemicalid1
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Chemicalid1 = Nothing
					Else
						entity.Chemicalid1 = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Chemicalid2 As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Chemicalid2
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Chemicalid2 = Nothing
					Else
						entity.Chemicalid2 = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Units As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Units
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Units = Nothing
					Else
						entity.Units = Convert.ToDecimal(Value)
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
		  

			Private entity As esChemicalbom
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esChemicalbomQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esChemicalbom can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Chemicalbom 
		Inherits esChemicalbom
		
	
		
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
	MustInherit Public Class esChemicalbomQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ChemicalbomMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Chembomid As esQueryItem
			Get
				Return New esQueryItem(Me, ChemicalbomMetadata.ColumnNames.Chembomid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Chemicalid1 As esQueryItem
			Get
				Return New esQueryItem(Me, ChemicalbomMetadata.ColumnNames.Chemicalid1, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Chemicalid2 As esQueryItem
			Get
				Return New esQueryItem(Me, ChemicalbomMetadata.ColumnNames.Chemicalid2, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Units As esQueryItem
			Get
				Return New esQueryItem(Me, ChemicalbomMetadata.ColumnNames.Units, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Uom As esQueryItem
			Get
				Return New esQueryItem(Me, ChemicalbomMetadata.ColumnNames.Uom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Percbywgt As esQueryItem
			Get
				Return New esQueryItem(Me, ChemicalbomMetadata.ColumnNames.Percbywgt, esSystemType.Decimal)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ChemicalbomCollection")> _
	Partial Public Class ChemicalbomCollection
		Inherits esChemicalbomCollection
		Implements IEnumerable(Of Chemicalbom)
		
        Public Shared Widening Operator CType(ByVal coll As ChemicalbomCollection) As List(Of Chemicalbom)
            Dim list As List(Of Chemicalbom) = New List(Of Chemicalbom)
            Dim emp As Chemicalbom

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ChemicalbomMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ChemicalbomQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Chemicalbom(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Chemicalbom()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As ChemicalbomQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ChemicalbomQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ChemicalbomQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Chemicalbom 
			Return CType(MyBase.AddNewEntity(), Chemicalbom)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal chembomid As System.Int32) As Chemicalbom
			Return CType(MyBase.FindByPrimaryKey(chembomid), Chemicalbom)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Chemicalbom) Implements IEnumerable(Of Chemicalbom).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Chemicalbom)(Me)
        End Function
		
		Private _query As ChemicalbomQuery

	End Class
	


	' <summary>
	' Encapsulates the 'CHEMICALBOM' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Chemicalbom ({Chembomid.Value})")> _
	<Serializable> _
	Partial Public Class Chemicalbom 
		Inherits esChemicalbom

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ChemicalbomMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esChemicalbomQuery

			If Me._query Is Nothing Then
				Me._query = New ChemicalbomQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ChemicalbomQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ChemicalbomQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ChemicalbomQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ChemicalbomQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ChemicalbomQuery
		inherits esChemicalbomQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ChemicalbomQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ChemicalbomMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ChemicalbomMetadata.ColumnNames.Chembomid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ChemicalbomMetadata.PropertyNames.Chembomid
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ChemicalbomMetadata.ColumnNames.Chemicalid1, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ChemicalbomMetadata.PropertyNames.Chemicalid1
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ChemicalbomMetadata.ColumnNames.Chemicalid2, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ChemicalbomMetadata.PropertyNames.Chemicalid2
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ChemicalbomMetadata.ColumnNames.Units, 3, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ChemicalbomMetadata.PropertyNames.Units
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ChemicalbomMetadata.ColumnNames.Uom, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ChemicalbomMetadata.PropertyNames.Uom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ChemicalbomMetadata.ColumnNames.Percbywgt, 5, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ChemicalbomMetadata.PropertyNames.Percbywgt
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ChemicalbomMetadata
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
			 Public Const Chembomid As String = "CHEMBOMID"
			 Public Const Chemicalid1 As String = "CHEMICALID1"
			 Public Const Chemicalid2 As String = "CHEMICALID2"
			 Public Const Units As String = "UNITS"
			 Public Const Uom As String = "UOM"
			 Public Const Percbywgt As String = "PERCBYWGT"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Chembomid As String = "Chembomid"
			 Public Const Chemicalid1 As String = "Chemicalid1"
			 Public Const Chemicalid2 As String = "Chemicalid2"
			 Public Const Units As String = "Units"
			 Public Const Uom As String = "Uom"
			 Public Const Percbywgt As String = "Percbywgt"
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
            SyncLock GetType(ChemicalbomMetadata)
			
				If ChemicalbomMetadata.mapDelegates Is Nothing Then
					ChemicalbomMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ChemicalbomMetadata._meta Is Nothing Then
                    ChemicalbomMetadata._meta = New ChemicalbomMetadata()
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
				

				meta.AddTypeMap("Chembomid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Chemicalid1", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Chemicalid2", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Units", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Uom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Percbywgt", new esTypeMap("decimal", "System.Decimal"))			
				
				
				 
				meta.Source = "CHEMICALBOM"
				meta.Destination = "CHEMICALBOM"
				
				meta.spInsert = "proc_CHEMICALBOMInsert"
				meta.spUpdate = "proc_CHEMICALBOMUpdate"
				meta.spDelete = "proc_CHEMICALBOMDelete"
				meta.spLoadAll = "proc_CHEMICALBOMLoadAll"
				meta.spLoadByPrimaryKey = "proc_CHEMICALBOMLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ChemicalbomMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
