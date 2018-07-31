'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 4/23/2015 9:56:07 PM
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
	MustInherit Public Class esProductrelableinstructionCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ProductrelableinstructionCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esProductrelableinstructionQuery)
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
            Me.InitQuery(CType(query, esProductrelableinstructionQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Productrelableinstruction) As Productrelableinstruction
			Return CType(MyBase.DetachEntity(entity), Productrelableinstruction)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Productrelableinstruction) As Productrelableinstruction
			Return CType(MyBase.AttachEntity(entity), Productrelableinstruction)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ProductrelableinstructionCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Productrelableinstruction
            Get
                Return TryCast(MyBase.Item(index), Productrelableinstruction)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Productrelableinstruction)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esProductrelableinstruction	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esProductrelableinstructionQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal productrelabelinstructionnumber As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(productrelabelinstructionnumber)
			Else
				Return LoadByPrimaryKeyStoredProcedure(productrelabelinstructionnumber)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal productrelabelinstructionnumber As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(productrelabelinstructionnumber)
			Else
				Return LoadByPrimaryKeyStoredProcedure(productrelabelinstructionnumber)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal productrelabelinstructionnumber As System.Int32) As Boolean
		
			Dim query As esProductrelableinstructionQuery = Me.GetDynamicQuery()
			query.Where(query.Productrelabelinstructionnumber.Equal(productrelabelinstructionnumber))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal productrelabelinstructionnumber As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("PRODUCTRELABELINSTRUCTIONNUMBER", productrelabelinstructionnumber)
			
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
												
						Case "Productrelabelinstructionnumber"
							Me.str.Productrelabelinstructionnumber = CType(value, string)
												
						Case "Sequence"
							Me.str.Sequence = CType(value, string)
												
						Case "Relabelinstruction"
							Me.str.Relabelinstruction = CType(value, string)
												
						Case "Fulfillmentplanid"
							Me.str.Fulfillmentplanid = CType(value, string)
												
						Case "Createdby"
							Me.str.Createdby = CType(value, string)
												
						Case "Createdtime"
							Me.str.Createdtime = CType(value, string)
												
						Case "Modifyby"
							Me.str.Modifyby = CType(value, string)
												
						Case "Modifytime"
							Me.str.Modifytime = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Productrelabelinstructionnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productrelabelinstructionnumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Sequence"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Sequence = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Fulfillmentplanid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Fulfillmentplanid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Createdtime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Createdtime = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Modifytime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Modifytime = CType(value, Nullable(Of System.DateTime))
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
		' Maps to PRODUCTRELABLEINSTRUCTION.PRODUCTRELABELINSTRUCTIONNUMBER
		' </summary>
		Public Overridable Property Productrelabelinstructionnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ProductrelableinstructionMetadata.ColumnNames.Productrelabelinstructionnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ProductrelableinstructionMetadata.ColumnNames.Productrelabelinstructionnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCTRELABLEINSTRUCTION.SEQUENCE
		' </summary>
		Public Overridable Property Sequence As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ProductrelableinstructionMetadata.ColumnNames.Sequence)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ProductrelableinstructionMetadata.ColumnNames.Sequence, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCTRELABLEINSTRUCTION.RELABELINSTRUCTION
		' </summary>
		Public Overridable Property Relabelinstruction As System.String
			Get
				Return MyBase.GetSystemString(ProductrelableinstructionMetadata.ColumnNames.Relabelinstruction)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ProductrelableinstructionMetadata.ColumnNames.Relabelinstruction, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCTRELABLEINSTRUCTION.FULFILLMENTPLANID
		' </summary>
		Public Overridable Property Fulfillmentplanid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ProductrelableinstructionMetadata.ColumnNames.Fulfillmentplanid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ProductrelableinstructionMetadata.ColumnNames.Fulfillmentplanid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCTRELABLEINSTRUCTION.CREATEDBY
		' </summary>
		Public Overridable Property Createdby As System.String
			Get
				Return MyBase.GetSystemString(ProductrelableinstructionMetadata.ColumnNames.Createdby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ProductrelableinstructionMetadata.ColumnNames.Createdby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCTRELABLEINSTRUCTION.CREATEDTIME
		' </summary>
		Public Overridable Property Createdtime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ProductrelableinstructionMetadata.ColumnNames.Createdtime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ProductrelableinstructionMetadata.ColumnNames.Createdtime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCTRELABLEINSTRUCTION.MODIFYBY
		' </summary>
		Public Overridable Property Modifyby As System.String
			Get
				Return MyBase.GetSystemString(ProductrelableinstructionMetadata.ColumnNames.Modifyby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ProductrelableinstructionMetadata.ColumnNames.Modifyby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to PRODUCTRELABLEINSTRUCTION.MODIFYTIME
		' </summary>
		Public Overridable Property Modifytime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ProductrelableinstructionMetadata.ColumnNames.Modifytime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ProductrelableinstructionMetadata.ColumnNames.Modifytime, value)
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
		
			Public Sub New(ByVal entity As esProductrelableinstruction)
				Me.entity = entity
			End Sub				
		
	
			Public Property Productrelabelinstructionnumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Productrelabelinstructionnumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Productrelabelinstructionnumber = Nothing
					Else
						entity.Productrelabelinstructionnumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Sequence As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Sequence
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Sequence = Nothing
					Else
						entity.Sequence = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Relabelinstruction As System.String 
				Get
					Dim data_ As System.String = entity.Relabelinstruction
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Relabelinstruction = Nothing
					Else
						entity.Relabelinstruction = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Fulfillmentplanid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Fulfillmentplanid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Fulfillmentplanid = Nothing
					Else
						entity.Fulfillmentplanid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Createdby As System.String 
				Get
					Dim data_ As System.String = entity.Createdby
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Createdby = Nothing
					Else
						entity.Createdby = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Createdtime As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Createdtime
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Createdtime = Nothing
					Else
						entity.Createdtime = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Modifyby As System.String 
				Get
					Dim data_ As System.String = entity.Modifyby
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Modifyby = Nothing
					Else
						entity.Modifyby = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Modifytime As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Modifytime
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Modifytime = Nothing
					Else
						entity.Modifytime = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  

			Private entity As esProductrelableinstruction
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esProductrelableinstructionQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esProductrelableinstruction can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Productrelableinstruction 
		Inherits esProductrelableinstruction
		
	
		
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
	MustInherit Public Class esProductrelableinstructionQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ProductrelableinstructionMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Productrelabelinstructionnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ProductrelableinstructionMetadata.ColumnNames.Productrelabelinstructionnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Sequence As esQueryItem
			Get
				Return New esQueryItem(Me, ProductrelableinstructionMetadata.ColumnNames.Sequence, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Relabelinstruction As esQueryItem
			Get
				Return New esQueryItem(Me, ProductrelableinstructionMetadata.ColumnNames.Relabelinstruction, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Fulfillmentplanid As esQueryItem
			Get
				Return New esQueryItem(Me, ProductrelableinstructionMetadata.ColumnNames.Fulfillmentplanid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Createdby As esQueryItem
			Get
				Return New esQueryItem(Me, ProductrelableinstructionMetadata.ColumnNames.Createdby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Createdtime As esQueryItem
			Get
				Return New esQueryItem(Me, ProductrelableinstructionMetadata.ColumnNames.Createdtime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Modifyby As esQueryItem
			Get
				Return New esQueryItem(Me, ProductrelableinstructionMetadata.ColumnNames.Modifyby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Modifytime As esQueryItem
			Get
				Return New esQueryItem(Me, ProductrelableinstructionMetadata.ColumnNames.Modifytime, esSystemType.DateTime)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ProductrelableinstructionCollection")> _
	Partial Public Class ProductrelableinstructionCollection
		Inherits esProductrelableinstructionCollection
		Implements IEnumerable(Of Productrelableinstruction)
		
        Public Shared Widening Operator CType(ByVal coll As ProductrelableinstructionCollection) As List(Of Productrelableinstruction)
            Dim list As List(Of Productrelableinstruction) = New List(Of Productrelableinstruction)
            Dim emp As Productrelableinstruction

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ProductrelableinstructionMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ProductrelableinstructionQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Productrelableinstruction(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Productrelableinstruction()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As ProductrelableinstructionQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ProductrelableinstructionQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ProductrelableinstructionQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Productrelableinstruction 
			Return CType(MyBase.AddNewEntity(), Productrelableinstruction)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal productrelabelinstructionnumber As System.Int32) As Productrelableinstruction
			Return CType(MyBase.FindByPrimaryKey(productrelabelinstructionnumber), Productrelableinstruction)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Productrelableinstruction) Implements IEnumerable(Of Productrelableinstruction).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Productrelableinstruction)(Me)
        End Function
		
		Private _query As ProductrelableinstructionQuery

	End Class
	


	' <summary>
	' Encapsulates the 'PRODUCTRELABLEINSTRUCTION' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Productrelableinstruction ({Productrelabelinstructionnumber.Value})")> _
	<Serializable> _
	Partial Public Class Productrelableinstruction 
		Inherits esProductrelableinstruction

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ProductrelableinstructionMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esProductrelableinstructionQuery

			If Me._query Is Nothing Then
				Me._query = New ProductrelableinstructionQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ProductrelableinstructionQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ProductrelableinstructionQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ProductrelableinstructionQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ProductrelableinstructionQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ProductrelableinstructionQuery
		inherits esProductrelableinstructionQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ProductrelableinstructionQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ProductrelableinstructionMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ProductrelableinstructionMetadata.ColumnNames.Productrelabelinstructionnumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ProductrelableinstructionMetadata.PropertyNames.Productrelabelinstructionnumber
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductrelableinstructionMetadata.ColumnNames.Sequence, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ProductrelableinstructionMetadata.PropertyNames.Sequence
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductrelableinstructionMetadata.ColumnNames.Relabelinstruction, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ProductrelableinstructionMetadata.PropertyNames.Relabelinstruction
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductrelableinstructionMetadata.ColumnNames.Fulfillmentplanid, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ProductrelableinstructionMetadata.PropertyNames.Fulfillmentplanid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductrelableinstructionMetadata.ColumnNames.Createdby, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ProductrelableinstructionMetadata.PropertyNames.Createdby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductrelableinstructionMetadata.ColumnNames.Createdtime, 5, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ProductrelableinstructionMetadata.PropertyNames.Createdtime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductrelableinstructionMetadata.ColumnNames.Modifyby, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ProductrelableinstructionMetadata.PropertyNames.Modifyby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ProductrelableinstructionMetadata.ColumnNames.Modifytime, 7, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ProductrelableinstructionMetadata.PropertyNames.Modifytime
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ProductrelableinstructionMetadata
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
			 Public Const Productrelabelinstructionnumber As String = "PRODUCTRELABELINSTRUCTIONNUMBER"
			 Public Const Sequence As String = "SEQUENCE"
			 Public Const Relabelinstruction As String = "RELABELINSTRUCTION"
			 Public Const Fulfillmentplanid As String = "FULFILLMENTPLANID"
			 Public Const Createdby As String = "CREATEDBY"
			 Public Const Createdtime As String = "CREATEDTIME"
			 Public Const Modifyby As String = "MODIFYBY"
			 Public Const Modifytime As String = "MODIFYTIME"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Productrelabelinstructionnumber As String = "Productrelabelinstructionnumber"
			 Public Const Sequence As String = "Sequence"
			 Public Const Relabelinstruction As String = "Relabelinstruction"
			 Public Const Fulfillmentplanid As String = "Fulfillmentplanid"
			 Public Const Createdby As String = "Createdby"
			 Public Const Createdtime As String = "Createdtime"
			 Public Const Modifyby As String = "Modifyby"
			 Public Const Modifytime As String = "Modifytime"
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
            SyncLock GetType(ProductrelableinstructionMetadata)
			
				If ProductrelableinstructionMetadata.mapDelegates Is Nothing Then
					ProductrelableinstructionMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ProductrelableinstructionMetadata._meta Is Nothing Then
                    ProductrelableinstructionMetadata._meta = New ProductrelableinstructionMetadata()
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
				

				meta.AddTypeMap("Productrelabelinstructionnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Sequence", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Relabelinstruction", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Fulfillmentplanid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Createdby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Createdtime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Modifyby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Modifytime", new esTypeMap("datetime", "System.DateTime"))			
				
				
				 
				meta.Source = "PRODUCTRELABLEINSTRUCTION"
				meta.Destination = "PRODUCTRELABLEINSTRUCTION"
				
				meta.spInsert = "proc_PRODUCTRELABLEINSTRUCTIONInsert"
				meta.spUpdate = "proc_PRODUCTRELABLEINSTRUCTIONUpdate"
				meta.spDelete = "proc_PRODUCTRELABLEINSTRUCTIONDelete"
				meta.spLoadAll = "proc_PRODUCTRELABLEINSTRUCTIONLoadAll"
				meta.spLoadByPrimaryKey = "proc_PRODUCTRELABLEINSTRUCTIONLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ProductrelableinstructionMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
