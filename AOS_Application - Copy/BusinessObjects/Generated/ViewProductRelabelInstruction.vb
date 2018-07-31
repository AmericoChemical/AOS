'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 4/24/2015 1:34:01 PM
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
	MustInherit Public Class esViewProductRelabelInstructionCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewProductRelabelInstructionCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewProductRelabelInstructionQuery)
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
            Me.InitQuery(CType(query, esViewProductRelabelInstructionQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewProductRelabelInstruction) As ViewProductRelabelInstruction
			Return CType(MyBase.DetachEntity(entity), ViewProductRelabelInstruction)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewProductRelabelInstruction) As ViewProductRelabelInstruction
			Return CType(MyBase.AttachEntity(entity), ViewProductRelabelInstruction)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewProductRelabelInstructionCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewProductRelabelInstruction
            Get
                Return TryCast(MyBase.Item(index), ViewProductRelabelInstruction)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewProductRelabelInstruction)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewProductRelabelInstruction	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewProductRelabelInstructionQuery
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
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Associatedproductid"
							Me.str.Associatedproductid = CType(value, string)
												
						Case "Sequence"
							Me.str.Sequence = CType(value, string)
												
						Case "Relabelinstruction"
							Me.str.Relabelinstruction = CType(value, string)
												
						Case "Fulfillmentplanid"
							Me.str.Fulfillmentplanid = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Associatedproductid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Associatedproductid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Sequence"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Sequence = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Fulfillmentplanid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Fulfillmentplanid = CType(value, Nullable(Of System.Int32))
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
		' Maps to viewProductRelabelInstruction.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductRelabelInstructionMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductRelabelInstructionMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductRelabelInstruction.ASSOCIATEDPRODUCTID
		' </summary>
		Public Overridable Property Associatedproductid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductRelabelInstructionMetadata.ColumnNames.Associatedproductid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductRelabelInstructionMetadata.ColumnNames.Associatedproductid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductRelabelInstruction.SEQUENCE
		' </summary>
		Public Overridable Property Sequence As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductRelabelInstructionMetadata.ColumnNames.Sequence)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductRelabelInstructionMetadata.ColumnNames.Sequence, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductRelabelInstruction.RELABELINSTRUCTION
		' </summary>
		Public Overridable Property Relabelinstruction As System.String
			Get
				Return MyBase.GetSystemString(ViewProductRelabelInstructionMetadata.ColumnNames.Relabelinstruction)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductRelabelInstructionMetadata.ColumnNames.Relabelinstruction, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductRelabelInstruction.FULFILLMENTPLANID
		' </summary>
		Public Overridable Property Fulfillmentplanid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductRelabelInstructionMetadata.ColumnNames.Fulfillmentplanid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductRelabelInstructionMetadata.ColumnNames.Fulfillmentplanid, value)
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
		
			Public Sub New(ByVal entity As esViewProductRelabelInstruction)
				Me.entity = entity
			End Sub				
		
	
			Public Property Productid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Productid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Productid = Nothing
					Else
						entity.Productid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Associatedproductid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Associatedproductid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Associatedproductid = Nothing
					Else
						entity.Associatedproductid = Convert.ToInt32(Value)
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
		  

			Private entity As esViewProductRelabelInstruction
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewProductRelabelInstructionQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewProductRelabelInstruction can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewProductRelabelInstructionQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewProductRelabelInstructionMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductRelabelInstructionMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Associatedproductid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductRelabelInstructionMetadata.ColumnNames.Associatedproductid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Sequence As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductRelabelInstructionMetadata.ColumnNames.Sequence, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Relabelinstruction As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductRelabelInstructionMetadata.ColumnNames.Relabelinstruction, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Fulfillmentplanid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductRelabelInstructionMetadata.ColumnNames.Fulfillmentplanid, esSystemType.Int32)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewProductRelabelInstructionCollection")> _
	Partial Public Class ViewProductRelabelInstructionCollection
		Inherits esViewProductRelabelInstructionCollection
		Implements IEnumerable(Of ViewProductRelabelInstruction)
		
        Public Shared Widening Operator CType(ByVal coll As ViewProductRelabelInstructionCollection) As List(Of ViewProductRelabelInstruction)
            Dim list As List(Of ViewProductRelabelInstruction) = New List(Of ViewProductRelabelInstruction)
            Dim emp As ViewProductRelabelInstruction

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewProductRelabelInstructionMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewProductRelabelInstructionQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewProductRelabelInstruction(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewProductRelabelInstruction()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewProductRelabelInstructionQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewProductRelabelInstructionQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewProductRelabelInstructionQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewProductRelabelInstruction 
			Return CType(MyBase.AddNewEntity(), ViewProductRelabelInstruction)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewProductRelabelInstruction) Implements IEnumerable(Of ViewProductRelabelInstruction).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewProductRelabelInstruction)(Me)
        End Function
		
		Private _query As ViewProductRelabelInstructionQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewProductRelabelInstruction' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewProductRelabelInstruction ()")> _
	<Serializable> _
	Partial Public Class ViewProductRelabelInstruction 
		Inherits esViewProductRelabelInstruction

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewProductRelabelInstructionMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewProductRelabelInstructionQuery

			If Me._query Is Nothing Then
				Me._query = New ViewProductRelabelInstructionQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewProductRelabelInstructionQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewProductRelabelInstructionQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewProductRelabelInstructionQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewProductRelabelInstructionQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewProductRelabelInstructionQuery
		inherits esViewProductRelabelInstructionQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewProductRelabelInstructionQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewProductRelabelInstructionMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewProductRelabelInstructionMetadata.ColumnNames.Productid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductRelabelInstructionMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductRelabelInstructionMetadata.ColumnNames.Associatedproductid, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductRelabelInstructionMetadata.PropertyNames.Associatedproductid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductRelabelInstructionMetadata.ColumnNames.Sequence, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductRelabelInstructionMetadata.PropertyNames.Sequence
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductRelabelInstructionMetadata.ColumnNames.Relabelinstruction, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductRelabelInstructionMetadata.PropertyNames.Relabelinstruction
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductRelabelInstructionMetadata.ColumnNames.Fulfillmentplanid, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductRelabelInstructionMetadata.PropertyNames.Fulfillmentplanid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewProductRelabelInstructionMetadata
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
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Associatedproductid As String = "ASSOCIATEDPRODUCTID"
			 Public Const Sequence As String = "SEQUENCE"
			 Public Const Relabelinstruction As String = "RELABELINSTRUCTION"
			 Public Const Fulfillmentplanid As String = "FULFILLMENTPLANID"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Productid As String = "Productid"
			 Public Const Associatedproductid As String = "Associatedproductid"
			 Public Const Sequence As String = "Sequence"
			 Public Const Relabelinstruction As String = "Relabelinstruction"
			 Public Const Fulfillmentplanid As String = "Fulfillmentplanid"
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
            SyncLock GetType(ViewProductRelabelInstructionMetadata)
			
				If ViewProductRelabelInstructionMetadata.mapDelegates Is Nothing Then
					ViewProductRelabelInstructionMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewProductRelabelInstructionMetadata._meta Is Nothing Then
                    ViewProductRelabelInstructionMetadata._meta = New ViewProductRelabelInstructionMetadata()
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
				

				meta.AddTypeMap("Productid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Associatedproductid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Sequence", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Relabelinstruction", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Fulfillmentplanid", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "viewProductRelabelInstruction"
				meta.Destination = "viewProductRelabelInstruction"
				
				meta.spInsert = "proc_viewProductRelabelInstructionInsert"
				meta.spUpdate = "proc_viewProductRelabelInstructionUpdate"
				meta.spDelete = "proc_viewProductRelabelInstructionDelete"
				meta.spLoadAll = "proc_viewProductRelabelInstructionLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewProductRelabelInstructionLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewProductRelabelInstructionMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
