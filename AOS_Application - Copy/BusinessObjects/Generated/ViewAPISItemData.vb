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
	MustInherit Public Class esViewAPISItemDataCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewAPISItemDataCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewAPISItemDataQuery)
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
            Me.InitQuery(CType(query, esViewAPISItemDataQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewAPISItemData) As ViewAPISItemData
			Return CType(MyBase.DetachEntity(entity), ViewAPISItemData)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewAPISItemData) As ViewAPISItemData
			Return CType(MyBase.AttachEntity(entity), ViewAPISItemData)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewAPISItemDataCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewAPISItemData
            Get
                Return TryCast(MyBase.Item(index), ViewAPISItemData)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewAPISItemData)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewAPISItemData	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewAPISItemDataQuery
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
												
						Case "Apisitemnum"
							Me.str.Apisitemnum = CType(value, string)
												
						Case "Apisnum"
							Me.str.Apisnum = CType(value, string)
												
						Case "Materialid"
							Me.str.Materialid = CType(value, string)
												
						Case "Qtyunits"
							Me.str.Qtyunits = CType(value, string)
												
						Case "Uom"
							Me.str.Uom = CType(value, string)
												
						Case "Apisitemnote"
							Me.str.Apisitemnote = CType(value, string)
												
						Case "Materialdesc"
							Me.str.Materialdesc = CType(value, string)
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "SourceProductDesc"
							Me.str.SourceProductDesc = CType(value, string)
												
						Case "Mpnote"
							Me.str.Mpnote = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Apisitemnum"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Apisitemnum = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Apisnum"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Apisnum = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Materialid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Materialid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Qtyunits"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Qtyunits = CType(value, Nullable(Of System.Double))
							End If
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
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
		' Maps to viewAPISItemData.APISITEMNUM
		' </summary>
		Public Overridable Property Apisitemnum As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewAPISItemDataMetadata.ColumnNames.Apisitemnum)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewAPISItemDataMetadata.ColumnNames.Apisitemnum, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAPISItemData.APISNUM
		' </summary>
		Public Overridable Property Apisnum As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewAPISItemDataMetadata.ColumnNames.Apisnum)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewAPISItemDataMetadata.ColumnNames.Apisnum, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAPISItemData.MATERIALID
		' </summary>
		Public Overridable Property Materialid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewAPISItemDataMetadata.ColumnNames.Materialid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewAPISItemDataMetadata.ColumnNames.Materialid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAPISItemData.QTYUNITS
		' </summary>
		Public Overridable Property Qtyunits As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewAPISItemDataMetadata.ColumnNames.Qtyunits)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewAPISItemDataMetadata.ColumnNames.Qtyunits, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAPISItemData.UOM
		' </summary>
		Public Overridable Property Uom As System.String
			Get
				Return MyBase.GetSystemString(ViewAPISItemDataMetadata.ColumnNames.Uom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewAPISItemDataMetadata.ColumnNames.Uom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAPISItemData.APISITEMNOTE
		' </summary>
		Public Overridable Property Apisitemnote As System.String
			Get
				Return MyBase.GetSystemString(ViewAPISItemDataMetadata.ColumnNames.Apisitemnote)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewAPISItemDataMetadata.ColumnNames.Apisitemnote, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAPISItemData.MATERIALDESC
		' </summary>
		Public Overridable Property Materialdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewAPISItemDataMetadata.ColumnNames.Materialdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewAPISItemDataMetadata.ColumnNames.Materialdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAPISItemData.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewAPISItemDataMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewAPISItemDataMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAPISItemData.SourceProductDesc
		' </summary>
		Public Overridable Property SourceProductDesc As System.String
			Get
				Return MyBase.GetSystemString(ViewAPISItemDataMetadata.ColumnNames.SourceProductDesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewAPISItemDataMetadata.ColumnNames.SourceProductDesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAPISItemData.MPNOTE
		' </summary>
		Public Overridable Property Mpnote As System.String
			Get
				Return MyBase.GetSystemString(ViewAPISItemDataMetadata.ColumnNames.Mpnote)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewAPISItemDataMetadata.ColumnNames.Mpnote, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAPISItemData.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewAPISItemDataMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewAPISItemDataMetadata.ColumnNames.Container, value)
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
		
			Public Sub New(ByVal entity As esViewAPISItemData)
				Me.entity = entity
			End Sub				
		
	
			Public Property Apisitemnum As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Apisitemnum
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Apisitemnum = Nothing
					Else
						entity.Apisitemnum = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Apisnum As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Apisnum
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Apisnum = Nothing
					Else
						entity.Apisnum = Convert.ToInt32(Value)
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
		  	
			Public Property Apisitemnote As System.String 
				Get
					Dim data_ As System.String = entity.Apisitemnote
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Apisitemnote = Nothing
					Else
						entity.Apisitemnote = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Materialdesc As System.String 
				Get
					Dim data_ As System.String = entity.Materialdesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Materialdesc = Nothing
					Else
						entity.Materialdesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
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
		  	
			Public Property SourceProductDesc As System.String 
				Get
					Dim data_ As System.String = entity.SourceProductDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.SourceProductDesc = Nothing
					Else
						entity.SourceProductDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Mpnote As System.String 
				Get
					Dim data_ As System.String = entity.Mpnote
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Mpnote = Nothing
					Else
						entity.Mpnote = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Container As System.String 
				Get
					Dim data_ As System.String = entity.Container
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Container = Nothing
					Else
						entity.Container = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewAPISItemData
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewAPISItemDataQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewAPISItemData can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewAPISItemDataQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewAPISItemDataMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Apisitemnum As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAPISItemDataMetadata.ColumnNames.Apisitemnum, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Apisnum As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAPISItemDataMetadata.ColumnNames.Apisnum, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Materialid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAPISItemDataMetadata.ColumnNames.Materialid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Qtyunits As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAPISItemDataMetadata.ColumnNames.Qtyunits, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Uom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAPISItemDataMetadata.ColumnNames.Uom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Apisitemnote As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAPISItemDataMetadata.ColumnNames.Apisitemnote, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Materialdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAPISItemDataMetadata.ColumnNames.Materialdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAPISItemDataMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property SourceProductDesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAPISItemDataMetadata.ColumnNames.SourceProductDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Mpnote As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAPISItemDataMetadata.ColumnNames.Mpnote, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAPISItemDataMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewAPISItemDataCollection")> _
	Partial Public Class ViewAPISItemDataCollection
		Inherits esViewAPISItemDataCollection
		Implements IEnumerable(Of ViewAPISItemData)
		
        Public Shared Widening Operator CType(ByVal coll As ViewAPISItemDataCollection) As List(Of ViewAPISItemData)
            Dim list As List(Of ViewAPISItemData) = New List(Of ViewAPISItemData)
            Dim emp As ViewAPISItemData

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewAPISItemDataMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewAPISItemDataQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewAPISItemData(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewAPISItemData()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewAPISItemDataQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewAPISItemDataQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewAPISItemDataQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewAPISItemData 
			Return CType(MyBase.AddNewEntity(), ViewAPISItemData)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewAPISItemData) Implements IEnumerable(Of ViewAPISItemData).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewAPISItemData)(Me)
        End Function
		
		Private _query As ViewAPISItemDataQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewAPISItemData' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewAPISItemData ()")> _
	<Serializable> _
	Partial Public Class ViewAPISItemData 
		Inherits esViewAPISItemData

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewAPISItemDataMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewAPISItemDataQuery

			If Me._query Is Nothing Then
				Me._query = New ViewAPISItemDataQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewAPISItemDataQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewAPISItemDataQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewAPISItemDataQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewAPISItemDataQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewAPISItemDataQuery
		inherits esViewAPISItemDataQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewAPISItemDataQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewAPISItemDataMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewAPISItemDataMetadata.ColumnNames.Apisitemnum, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewAPISItemDataMetadata.PropertyNames.Apisitemnum
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAPISItemDataMetadata.ColumnNames.Apisnum, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewAPISItemDataMetadata.PropertyNames.Apisnum
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAPISItemDataMetadata.ColumnNames.Materialid, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewAPISItemDataMetadata.PropertyNames.Materialid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAPISItemDataMetadata.ColumnNames.Qtyunits, 3, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewAPISItemDataMetadata.PropertyNames.Qtyunits
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAPISItemDataMetadata.ColumnNames.Uom, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewAPISItemDataMetadata.PropertyNames.Uom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAPISItemDataMetadata.ColumnNames.Apisitemnote, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewAPISItemDataMetadata.PropertyNames.Apisitemnote
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAPISItemDataMetadata.ColumnNames.Materialdesc, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewAPISItemDataMetadata.PropertyNames.Materialdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAPISItemDataMetadata.ColumnNames.Productid, 7, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewAPISItemDataMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAPISItemDataMetadata.ColumnNames.SourceProductDesc, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewAPISItemDataMetadata.PropertyNames.SourceProductDesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAPISItemDataMetadata.ColumnNames.Mpnote, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewAPISItemDataMetadata.PropertyNames.Mpnote
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAPISItemDataMetadata.ColumnNames.Container, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewAPISItemDataMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewAPISItemDataMetadata
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
			 Public Const Apisitemnum As String = "APISITEMNUM"
			 Public Const Apisnum As String = "APISNUM"
			 Public Const Materialid As String = "MATERIALID"
			 Public Const Qtyunits As String = "QTYUNITS"
			 Public Const Uom As String = "UOM"
			 Public Const Apisitemnote As String = "APISITEMNOTE"
			 Public Const Materialdesc As String = "MATERIALDESC"
			 Public Const Productid As String = "PRODUCTID"
			 Public Const SourceProductDesc As String = "SourceProductDesc"
			 Public Const Mpnote As String = "MPNOTE"
			 Public Const Container As String = "CONTAINER"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Apisitemnum As String = "Apisitemnum"
			 Public Const Apisnum As String = "Apisnum"
			 Public Const Materialid As String = "Materialid"
			 Public Const Qtyunits As String = "Qtyunits"
			 Public Const Uom As String = "Uom"
			 Public Const Apisitemnote As String = "Apisitemnote"
			 Public Const Materialdesc As String = "Materialdesc"
			 Public Const Productid As String = "Productid"
			 Public Const SourceProductDesc As String = "SourceProductDesc"
			 Public Const Mpnote As String = "Mpnote"
			 Public Const Container As String = "Container"
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
            SyncLock GetType(ViewAPISItemDataMetadata)
			
				If ViewAPISItemDataMetadata.mapDelegates Is Nothing Then
					ViewAPISItemDataMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewAPISItemDataMetadata._meta Is Nothing Then
                    ViewAPISItemDataMetadata._meta = New ViewAPISItemDataMetadata()
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
				

				meta.AddTypeMap("Apisitemnum", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Apisnum", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Materialid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Qtyunits", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Uom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Apisitemnote", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Materialdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Productid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("SourceProductDesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Mpnote", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewAPISItemData"
				meta.Destination = "viewAPISItemData"
				
				meta.spInsert = "proc_viewAPISItemDataInsert"
				meta.spUpdate = "proc_viewAPISItemDataUpdate"
				meta.spDelete = "proc_viewAPISItemDataDelete"
				meta.spLoadAll = "proc_viewAPISItemDataLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewAPISItemDataLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewAPISItemDataMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
