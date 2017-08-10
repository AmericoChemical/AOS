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
	MustInherit Public Class esChemwork1Collection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "Chemwork1Collection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esChemwork1Query)
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
            Me.InitQuery(CType(query, esChemwork1Query))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Chemwork1) As Chemwork1
			Return CType(MyBase.DetachEntity(entity), Chemwork1)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Chemwork1) As Chemwork1
			Return CType(MyBase.AttachEntity(entity), Chemwork1)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As Chemwork1Collection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Chemwork1
            Get
                Return TryCast(MyBase.Item(index), Chemwork1)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Chemwork1)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esChemwork1	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esChemwork1Query
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey() As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic()
			Else
				Return LoadByPrimaryKeyStoredProcedure()
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic()
			Else
				Return LoadByPrimaryKeyStoredProcedure()
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic() As Boolean
		
			Dim query As esChemwork1Query = Me.GetDynamicQuery()
			query.Where()
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure() As Boolean
		
			Dim parms As esParameters = New esParameters()

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
												
						Case "ChemicalDesc"
							Me.str.ChemicalDesc = CType(value, string)
												
						Case "NewName"
							Me.str.NewName = CType(value, string)
												
						Case "MatchingName"
							Me.str.MatchingName = CType(value, string)
												
						Case "ChemID"
							Me.str.ChemID = CType(value, string)
												
						Case "Sglow"
							Me.str.Sglow = CType(value, string)
												
						Case "Sghigh"
							Me.str.Sghigh = CType(value, string)
												
						Case "Phlow"
							Me.str.Phlow = CType(value, string)
												
						Case "Phhigh"
							Me.str.Phhigh = CType(value, string)
												
						Case "CASNumber"
							Me.str.CASNumber = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "ChemID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ChemID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Sglow"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Sglow = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Sghigh"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Sghigh = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Phlow"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Phlow = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Phhigh"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Phhigh = CType(value, Nullable(Of System.Decimal))
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
		' Maps to CHEMWORK1.ChemicalDesc
		' </summary>
		Public Overridable Property ChemicalDesc As System.String
			Get
				Return MyBase.GetSystemString(Chemwork1Metadata.ColumnNames.ChemicalDesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(Chemwork1Metadata.ColumnNames.ChemicalDesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHEMWORK1.NewName
		' </summary>
		Public Overridable Property NewName As System.String
			Get
				Return MyBase.GetSystemString(Chemwork1Metadata.ColumnNames.NewName)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(Chemwork1Metadata.ColumnNames.NewName, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHEMWORK1.MatchingName
		' </summary>
		Public Overridable Property MatchingName As System.String
			Get
				Return MyBase.GetSystemString(Chemwork1Metadata.ColumnNames.MatchingName)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(Chemwork1Metadata.ColumnNames.MatchingName, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHEMWORK1.ChemID
		' </summary>
		Public Overridable Property ChemID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(Chemwork1Metadata.ColumnNames.ChemID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(Chemwork1Metadata.ColumnNames.ChemID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHEMWORK1.SGLOW
		' </summary>
		Public Overridable Property Sglow As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(Chemwork1Metadata.ColumnNames.Sglow)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(Chemwork1Metadata.ColumnNames.Sglow, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHEMWORK1.SGHIGH
		' </summary>
		Public Overridable Property Sghigh As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(Chemwork1Metadata.ColumnNames.Sghigh)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(Chemwork1Metadata.ColumnNames.Sghigh, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHEMWORK1.PHLOW
		' </summary>
		Public Overridable Property Phlow As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(Chemwork1Metadata.ColumnNames.Phlow)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(Chemwork1Metadata.ColumnNames.Phlow, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHEMWORK1.PHHIGH
		' </summary>
		Public Overridable Property Phhigh As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(Chemwork1Metadata.ColumnNames.Phhigh)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(Chemwork1Metadata.ColumnNames.Phhigh, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHEMWORK1.CASNumber
		' </summary>
		Public Overridable Property CASNumber As System.String
			Get
				Return MyBase.GetSystemString(Chemwork1Metadata.ColumnNames.CASNumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(Chemwork1Metadata.ColumnNames.CASNumber, value)
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
		
			Public Sub New(ByVal entity As esChemwork1)
				Me.entity = entity
			End Sub				
		
	
			Public Property ChemicalDesc As System.String 
				Get
					Dim data_ As System.String = entity.ChemicalDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ChemicalDesc = Nothing
					Else
						entity.ChemicalDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property NewName As System.String 
				Get
					Dim data_ As System.String = entity.NewName
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.NewName = Nothing
					Else
						entity.NewName = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property MatchingName As System.String 
				Get
					Dim data_ As System.String = entity.MatchingName
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.MatchingName = Nothing
					Else
						entity.MatchingName = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ChemID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.ChemID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ChemID = Nothing
					Else
						entity.ChemID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Sglow As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Sglow
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Sglow = Nothing
					Else
						entity.Sglow = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Sghigh As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Sghigh
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Sghigh = Nothing
					Else
						entity.Sghigh = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Phlow As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Phlow
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Phlow = Nothing
					Else
						entity.Phlow = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Phhigh As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Phhigh
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Phhigh = Nothing
					Else
						entity.Phhigh = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property CASNumber As System.String 
				Get
					Dim data_ As System.String = entity.CASNumber
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CASNumber = Nothing
					Else
						entity.CASNumber = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esChemwork1
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esChemwork1Query)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esChemwork1 can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Chemwork1 
		Inherits esChemwork1
		
	
		
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
	MustInherit Public Class esChemwork1Query 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return Chemwork1Metadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property ChemicalDesc As esQueryItem
			Get
				Return New esQueryItem(Me, Chemwork1Metadata.ColumnNames.ChemicalDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property NewName As esQueryItem
			Get
				Return New esQueryItem(Me, Chemwork1Metadata.ColumnNames.NewName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property MatchingName As esQueryItem
			Get
				Return New esQueryItem(Me, Chemwork1Metadata.ColumnNames.MatchingName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ChemID As esQueryItem
			Get
				Return New esQueryItem(Me, Chemwork1Metadata.ColumnNames.ChemID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Sglow As esQueryItem
			Get
				Return New esQueryItem(Me, Chemwork1Metadata.ColumnNames.Sglow, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Sghigh As esQueryItem
			Get
				Return New esQueryItem(Me, Chemwork1Metadata.ColumnNames.Sghigh, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Phlow As esQueryItem
			Get
				Return New esQueryItem(Me, Chemwork1Metadata.ColumnNames.Phlow, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Phhigh As esQueryItem
			Get
				Return New esQueryItem(Me, Chemwork1Metadata.ColumnNames.Phhigh, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property CASNumber As esQueryItem
			Get
				Return New esQueryItem(Me, Chemwork1Metadata.ColumnNames.CASNumber, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("Chemwork1Collection")> _
	Partial Public Class Chemwork1Collection
		Inherits esChemwork1Collection
		Implements IEnumerable(Of Chemwork1)
		
        Public Shared Widening Operator CType(ByVal coll As Chemwork1Collection) As List(Of Chemwork1)
            Dim list As List(Of Chemwork1) = New List(Of Chemwork1)
            Dim emp As Chemwork1

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return Chemwork1Metadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New Chemwork1Query()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Chemwork1(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Chemwork1()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As Chemwork1Query 
			Get
				If Me._query Is Nothing Then
					Me._query = New Chemwork1Query()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As Chemwork1Query) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Chemwork1 
			Return CType(MyBase.AddNewEntity(), Chemwork1)
		End Function

		Public Overloads Function FindByPrimaryKey() As Chemwork1
			Return CType(MyBase.FindByPrimaryKey(), Chemwork1)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Chemwork1) Implements IEnumerable(Of Chemwork1).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Chemwork1)(Me)
        End Function
		
		Private _query As Chemwork1Query

	End Class
	


	' <summary>
	' Encapsulates the 'CHEMWORK1' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Chemwork1 ()")> _
	<Serializable> _
	Partial Public Class Chemwork1 
		Inherits esChemwork1

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return Chemwork1Metadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esChemwork1Query

			If Me._query Is Nothing Then
				Me._query = New Chemwork1Query()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As Chemwork1Query
			Get

				If Me._query Is Nothing then
					Me._query = New Chemwork1Query()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As Chemwork1Query) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As Chemwork1Query

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class Chemwork1Query
		inherits esChemwork1Query
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "Chemwork1Query"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class Chemwork1Metadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(Chemwork1Metadata.ColumnNames.ChemicalDesc, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = Chemwork1Metadata.PropertyNames.ChemicalDesc
			c.CharacterMaxLength = 255
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(Chemwork1Metadata.ColumnNames.NewName, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = Chemwork1Metadata.PropertyNames.NewName
			c.CharacterMaxLength = 255
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(Chemwork1Metadata.ColumnNames.MatchingName, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = Chemwork1Metadata.PropertyNames.MatchingName
			c.CharacterMaxLength = 255
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(Chemwork1Metadata.ColumnNames.ChemID, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = Chemwork1Metadata.PropertyNames.ChemID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(Chemwork1Metadata.ColumnNames.Sglow, 4, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = Chemwork1Metadata.PropertyNames.Sglow
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(Chemwork1Metadata.ColumnNames.Sghigh, 5, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = Chemwork1Metadata.PropertyNames.Sghigh
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(Chemwork1Metadata.ColumnNames.Phlow, 6, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = Chemwork1Metadata.PropertyNames.Phlow
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(Chemwork1Metadata.ColumnNames.Phhigh, 7, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = Chemwork1Metadata.PropertyNames.Phhigh
			c.NumericPrecision = 18
			c.NumericScale = 4
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(Chemwork1Metadata.ColumnNames.CASNumber, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = Chemwork1Metadata.PropertyNames.CASNumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As Chemwork1Metadata
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
			 Public Const ChemicalDesc As String = "ChemicalDesc"
			 Public Const NewName As String = "NewName"
			 Public Const MatchingName As String = "MatchingName"
			 Public Const ChemID As String = "ChemID"
			 Public Const Sglow As String = "SGLOW"
			 Public Const Sghigh As String = "SGHIGH"
			 Public Const Phlow As String = "PHLOW"
			 Public Const Phhigh As String = "PHHIGH"
			 Public Const CASNumber As String = "CASNumber"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const ChemicalDesc As String = "ChemicalDesc"
			 Public Const NewName As String = "NewName"
			 Public Const MatchingName As String = "MatchingName"
			 Public Const ChemID As String = "ChemID"
			 Public Const Sglow As String = "Sglow"
			 Public Const Sghigh As String = "Sghigh"
			 Public Const Phlow As String = "Phlow"
			 Public Const Phhigh As String = "Phhigh"
			 Public Const CASNumber As String = "CASNumber"
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
            SyncLock GetType(Chemwork1Metadata)
			
				If Chemwork1Metadata.mapDelegates Is Nothing Then
					Chemwork1Metadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If Chemwork1Metadata._meta Is Nothing Then
                    Chemwork1Metadata._meta = New Chemwork1Metadata()
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
				

				meta.AddTypeMap("ChemicalDesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("NewName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("MatchingName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ChemID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Sglow", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Sghigh", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Phlow", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Phhigh", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("CASNumber", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "CHEMWORK1"
				meta.Destination = "CHEMWORK1"
				
				meta.spInsert = "proc_CHEMWORK1Insert"
				meta.spUpdate = "proc_CHEMWORK1Update"
				meta.spDelete = "proc_CHEMWORK1Delete"
				meta.spLoadAll = "proc_CHEMWORK1LoadAll"
				meta.spLoadByPrimaryKey = "proc_CHEMWORK1LoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As Chemwork1Metadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
