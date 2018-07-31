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
	MustInherit Public Class esHazmatsymbolCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "HazmatsymbolCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esHazmatsymbolQuery)
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
            Me.InitQuery(CType(query, esHazmatsymbolQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Hazmatsymbol) As Hazmatsymbol
			Return CType(MyBase.DetachEntity(entity), Hazmatsymbol)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Hazmatsymbol) As Hazmatsymbol
			Return CType(MyBase.AttachEntity(entity), Hazmatsymbol)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As HazmatsymbolCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Hazmatsymbol
            Get
                Return TryCast(MyBase.Item(index), Hazmatsymbol)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Hazmatsymbol)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esHazmatsymbol	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esHazmatsymbolQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal hazMatID As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(hazMatID)
			Else
				Return LoadByPrimaryKeyStoredProcedure(hazMatID)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal hazMatID As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(hazMatID)
			Else
				Return LoadByPrimaryKeyStoredProcedure(hazMatID)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal hazMatID As System.Int32) As Boolean
		
			Dim query As esHazmatsymbolQuery = Me.GetDynamicQuery()
			query.Where(query.HazMatID.Equal(hazMatID))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal hazMatID As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("HazMatID", hazMatID)
			
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
												
						Case "HazMatID"
							Me.str.HazMatID = CType(value, string)
												
						Case "SymbolDesc"
							Me.str.SymbolDesc = CType(value, string)
												
						Case "ProductLabel"
							Me.str.ProductLabel = CType(value, string)
												
						Case "ImageFileName"
							Me.str.ImageFileName = CType(value, string)
												
						Case "Precautions"
							Me.str.Precautions = CType(value, string)
												
						Case "Warning"
							Me.str.Warning = CType(value, string)
												
						Case "Handling"
							Me.str.Handling = CType(value, string)
												
						Case "HazoxSymbolFileName"
							Me.str.HazoxSymbolFileName = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "HazMatID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.HazMatID = CType(value, Nullable(Of System.Int32))
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
		' Maps to HAZMATSYMBOL.HazMatID
		' </summary>
		Public Overridable Property HazMatID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(HazmatsymbolMetadata.ColumnNames.HazMatID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(HazmatsymbolMetadata.ColumnNames.HazMatID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to HAZMATSYMBOL.SymbolDesc
		' </summary>
		Public Overridable Property SymbolDesc As System.String
			Get
				Return MyBase.GetSystemString(HazmatsymbolMetadata.ColumnNames.SymbolDesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(HazmatsymbolMetadata.ColumnNames.SymbolDesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to HAZMATSYMBOL.ProductLabel
		' </summary>
		Public Overridable Property ProductLabel As System.String
			Get
				Return MyBase.GetSystemString(HazmatsymbolMetadata.ColumnNames.ProductLabel)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(HazmatsymbolMetadata.ColumnNames.ProductLabel, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to HAZMATSYMBOL.ImageFileName
		' </summary>
		Public Overridable Property ImageFileName As System.String
			Get
				Return MyBase.GetSystemString(HazmatsymbolMetadata.ColumnNames.ImageFileName)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(HazmatsymbolMetadata.ColumnNames.ImageFileName, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to HAZMATSYMBOL.Precautions
		' </summary>
		Public Overridable Property Precautions As System.String
			Get
				Return MyBase.GetSystemString(HazmatsymbolMetadata.ColumnNames.Precautions)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(HazmatsymbolMetadata.ColumnNames.Precautions, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to HAZMATSYMBOL.Warning
		' </summary>
		Public Overridable Property Warning As System.String
			Get
				Return MyBase.GetSystemString(HazmatsymbolMetadata.ColumnNames.Warning)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(HazmatsymbolMetadata.ColumnNames.Warning, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to HAZMATSYMBOL.Handling
		' </summary>
		Public Overridable Property Handling As System.String
			Get
				Return MyBase.GetSystemString(HazmatsymbolMetadata.ColumnNames.Handling)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(HazmatsymbolMetadata.ColumnNames.Handling, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to HAZMATSYMBOL.HazoxSymbolFileName
		' </summary>
		Public Overridable Property HazoxSymbolFileName As System.String
			Get
				Return MyBase.GetSystemString(HazmatsymbolMetadata.ColumnNames.HazoxSymbolFileName)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(HazmatsymbolMetadata.ColumnNames.HazoxSymbolFileName, value)
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
		
			Public Sub New(ByVal entity As esHazmatsymbol)
				Me.entity = entity
			End Sub				
		
	
			Public Property HazMatID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.HazMatID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HazMatID = Nothing
					Else
						entity.HazMatID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property SymbolDesc As System.String 
				Get
					Dim data_ As System.String = entity.SymbolDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SymbolDesc = Nothing
					Else
						entity.SymbolDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ProductLabel As System.String 
				Get
					Dim data_ As System.String = entity.ProductLabel
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ProductLabel = Nothing
					Else
						entity.ProductLabel = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ImageFileName As System.String 
				Get
					Dim data_ As System.String = entity.ImageFileName
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ImageFileName = Nothing
					Else
						entity.ImageFileName = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Precautions As System.String 
				Get
					Dim data_ As System.String = entity.Precautions
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Precautions = Nothing
					Else
						entity.Precautions = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Warning As System.String 
				Get
					Dim data_ As System.String = entity.Warning
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Warning = Nothing
					Else
						entity.Warning = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Handling As System.String 
				Get
					Dim data_ As System.String = entity.Handling
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Handling = Nothing
					Else
						entity.Handling = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property HazoxSymbolFileName As System.String 
				Get
					Dim data_ As System.String = entity.HazoxSymbolFileName
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.HazoxSymbolFileName = Nothing
					Else
						entity.HazoxSymbolFileName = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esHazmatsymbol
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esHazmatsymbolQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esHazmatsymbol can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Hazmatsymbol 
		Inherits esHazmatsymbol
		
	
		
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
	MustInherit Public Class esHazmatsymbolQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return HazmatsymbolMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property HazMatID As esQueryItem
			Get
				Return New esQueryItem(Me, HazmatsymbolMetadata.ColumnNames.HazMatID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property SymbolDesc As esQueryItem
			Get
				Return New esQueryItem(Me, HazmatsymbolMetadata.ColumnNames.SymbolDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ProductLabel As esQueryItem
			Get
				Return New esQueryItem(Me, HazmatsymbolMetadata.ColumnNames.ProductLabel, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ImageFileName As esQueryItem
			Get
				Return New esQueryItem(Me, HazmatsymbolMetadata.ColumnNames.ImageFileName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Precautions As esQueryItem
			Get
				Return New esQueryItem(Me, HazmatsymbolMetadata.ColumnNames.Precautions, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Warning As esQueryItem
			Get
				Return New esQueryItem(Me, HazmatsymbolMetadata.ColumnNames.Warning, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Handling As esQueryItem
			Get
				Return New esQueryItem(Me, HazmatsymbolMetadata.ColumnNames.Handling, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property HazoxSymbolFileName As esQueryItem
			Get
				Return New esQueryItem(Me, HazmatsymbolMetadata.ColumnNames.HazoxSymbolFileName, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("HazmatsymbolCollection")> _
	Partial Public Class HazmatsymbolCollection
		Inherits esHazmatsymbolCollection
		Implements IEnumerable(Of Hazmatsymbol)
		
        Public Shared Widening Operator CType(ByVal coll As HazmatsymbolCollection) As List(Of Hazmatsymbol)
            Dim list As List(Of Hazmatsymbol) = New List(Of Hazmatsymbol)
            Dim emp As Hazmatsymbol

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return HazmatsymbolMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New HazmatsymbolQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Hazmatsymbol(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Hazmatsymbol()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As HazmatsymbolQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New HazmatsymbolQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As HazmatsymbolQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Hazmatsymbol 
			Return CType(MyBase.AddNewEntity(), Hazmatsymbol)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal hazMatID As System.Int32) As Hazmatsymbol
			Return CType(MyBase.FindByPrimaryKey(hazMatID), Hazmatsymbol)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Hazmatsymbol) Implements IEnumerable(Of Hazmatsymbol).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Hazmatsymbol)(Me)
        End Function
		
		Private _query As HazmatsymbolQuery

	End Class
	


	' <summary>
	' Encapsulates the 'HAZMATSYMBOL' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Hazmatsymbol ({HazMatID.Value})")> _
	<Serializable> _
	Partial Public Class Hazmatsymbol 
		Inherits esHazmatsymbol

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return HazmatsymbolMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esHazmatsymbolQuery

			If Me._query Is Nothing Then
				Me._query = New HazmatsymbolQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As HazmatsymbolQuery
			Get

				If Me._query Is Nothing then
					Me._query = New HazmatsymbolQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As HazmatsymbolQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As HazmatsymbolQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class HazmatsymbolQuery
		inherits esHazmatsymbolQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "HazmatsymbolQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class HazmatsymbolMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(HazmatsymbolMetadata.ColumnNames.HazMatID, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = HazmatsymbolMetadata.PropertyNames.HazMatID
			c.IsInPrimaryKey = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(HazmatsymbolMetadata.ColumnNames.SymbolDesc, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = HazmatsymbolMetadata.PropertyNames.SymbolDesc
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(HazmatsymbolMetadata.ColumnNames.ProductLabel, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = HazmatsymbolMetadata.PropertyNames.ProductLabel
			c.CharacterMaxLength = 100
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(HazmatsymbolMetadata.ColumnNames.ImageFileName, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = HazmatsymbolMetadata.PropertyNames.ImageFileName
			c.CharacterMaxLength = 100
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(HazmatsymbolMetadata.ColumnNames.Precautions, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = HazmatsymbolMetadata.PropertyNames.Precautions
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(HazmatsymbolMetadata.ColumnNames.Warning, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = HazmatsymbolMetadata.PropertyNames.Warning
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(HazmatsymbolMetadata.ColumnNames.Handling, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = HazmatsymbolMetadata.PropertyNames.Handling
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(HazmatsymbolMetadata.ColumnNames.HazoxSymbolFileName, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = HazmatsymbolMetadata.PropertyNames.HazoxSymbolFileName
			c.CharacterMaxLength = 255
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As HazmatsymbolMetadata
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
			 Public Const HazMatID As String = "HazMatID"
			 Public Const SymbolDesc As String = "SymbolDesc"
			 Public Const ProductLabel As String = "ProductLabel"
			 Public Const ImageFileName As String = "ImageFileName"
			 Public Const Precautions As String = "Precautions"
			 Public Const Warning As String = "Warning"
			 Public Const Handling As String = "Handling"
			 Public Const HazoxSymbolFileName As String = "HazoxSymbolFileName"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const HazMatID As String = "HazMatID"
			 Public Const SymbolDesc As String = "SymbolDesc"
			 Public Const ProductLabel As String = "ProductLabel"
			 Public Const ImageFileName As String = "ImageFileName"
			 Public Const Precautions As String = "Precautions"
			 Public Const Warning As String = "Warning"
			 Public Const Handling As String = "Handling"
			 Public Const HazoxSymbolFileName As String = "HazoxSymbolFileName"
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
            SyncLock GetType(HazmatsymbolMetadata)
			
				If HazmatsymbolMetadata.mapDelegates Is Nothing Then
					HazmatsymbolMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If HazmatsymbolMetadata._meta Is Nothing Then
                    HazmatsymbolMetadata._meta = New HazmatsymbolMetadata()
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
				

				meta.AddTypeMap("HazMatID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("SymbolDesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ProductLabel", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ImageFileName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Precautions", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Warning", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Handling", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("HazoxSymbolFileName", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "HAZMATSYMBOL"
				meta.Destination = "HAZMATSYMBOL"
				
				meta.spInsert = "proc_HAZMATSYMBOLInsert"
				meta.spUpdate = "proc_HAZMATSYMBOLUpdate"
				meta.spDelete = "proc_HAZMATSYMBOLDelete"
				meta.spLoadAll = "proc_HAZMATSYMBOLLoadAll"
				meta.spLoadByPrimaryKey = "proc_HAZMATSYMBOLLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As HazmatsymbolMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
