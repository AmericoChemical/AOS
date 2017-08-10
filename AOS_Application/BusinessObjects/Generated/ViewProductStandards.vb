'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/11/2014 1:36:09 PM
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
	MustInherit Public Class esViewProductStandardsCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewProductStandardsCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewProductStandardsQuery)
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
            Me.InitQuery(CType(query, esViewProductStandardsQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewProductStandards) As ViewProductStandards
			Return CType(MyBase.DetachEntity(entity), ViewProductStandards)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewProductStandards) As ViewProductStandards
			Return CType(MyBase.AttachEntity(entity), ViewProductStandards)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewProductStandardsCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewProductStandards
            Get
                Return TryCast(MyBase.Item(index), ViewProductStandards)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewProductStandards)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewProductStandards	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewProductStandardsQuery
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
												
						Case "Productdesc"
							Me.str.Productdesc = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "Phrangelow"
							Me.str.Phrangelow = CType(value, string)
												
						Case "Phrangehigh"
							Me.str.Phrangehigh = CType(value, string)
												
						Case "Sgrangelow"
							Me.str.Sgrangelow = CType(value, string)
												
						Case "Sgrangehigh"
							Me.str.Sgrangehigh = CType(value, string)
												
						Case "Needstesting"
							Me.str.Needstesting = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Phrangelow"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Phrangelow = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Phrangehigh"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Phrangehigh = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Sgrangelow"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Sgrangelow = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Sgrangehigh"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Sgrangehigh = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Needstesting"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Needstesting = CType(value, Nullable(Of System.Boolean))
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
		' Maps to viewProductStandards.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewProductStandardsMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewProductStandardsMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductStandards.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewProductStandardsMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductStandardsMetadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductStandards.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewProductStandardsMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewProductStandardsMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductStandards.PHRANGELOW
		' </summary>
		Public Overridable Property Phrangelow As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewProductStandardsMetadata.ColumnNames.Phrangelow)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewProductStandardsMetadata.ColumnNames.Phrangelow, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductStandards.PHRANGEHIGH
		' </summary>
		Public Overridable Property Phrangehigh As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewProductStandardsMetadata.ColumnNames.Phrangehigh)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewProductStandardsMetadata.ColumnNames.Phrangehigh, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductStandards.SGRANGELOW
		' </summary>
		Public Overridable Property Sgrangelow As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewProductStandardsMetadata.ColumnNames.Sgrangelow)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewProductStandardsMetadata.ColumnNames.Sgrangelow, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductStandards.SGRANGEHIGH
		' </summary>
		Public Overridable Property Sgrangehigh As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewProductStandardsMetadata.ColumnNames.Sgrangehigh)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewProductStandardsMetadata.ColumnNames.Sgrangehigh, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewProductStandards.NEEDSTESTING
		' </summary>
		Public Overridable Property Needstesting As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ViewProductStandardsMetadata.ColumnNames.Needstesting)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ViewProductStandardsMetadata.ColumnNames.Needstesting, value)
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
		
			Public Sub New(ByVal entity As esViewProductStandards)
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
		  	
			Public Property Productdesc As System.String 
				Get
					Dim data_ As System.String = entity.Productdesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Productdesc = Nothing
					Else
						entity.Productdesc = Convert.ToString(Value)
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
		  	
			Public Property Phrangelow As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Phrangelow
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Phrangelow = Nothing
					Else
						entity.Phrangelow = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Phrangehigh As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Phrangehigh
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Phrangehigh = Nothing
					Else
						entity.Phrangehigh = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Sgrangelow As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Sgrangelow
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Sgrangelow = Nothing
					Else
						entity.Sgrangelow = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Sgrangehigh As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Sgrangehigh
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Sgrangehigh = Nothing
					Else
						entity.Sgrangehigh = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Needstesting As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Needstesting
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Needstesting = Nothing
					Else
						entity.Needstesting = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewProductStandards
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewProductStandardsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewProductStandards can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewProductStandardsQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewProductStandardsMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductStandardsMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductStandardsMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductStandardsMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Phrangelow As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductStandardsMetadata.ColumnNames.Phrangelow, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Phrangehigh As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductStandardsMetadata.ColumnNames.Phrangehigh, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Sgrangelow As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductStandardsMetadata.ColumnNames.Sgrangelow, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Sgrangehigh As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductStandardsMetadata.ColumnNames.Sgrangehigh, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Needstesting As esQueryItem
			Get
				Return New esQueryItem(Me, ViewProductStandardsMetadata.ColumnNames.Needstesting, esSystemType.Boolean)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewProductStandardsCollection")> _
	Partial Public Class ViewProductStandardsCollection
		Inherits esViewProductStandardsCollection
		Implements IEnumerable(Of ViewProductStandards)
		
        Public Shared Widening Operator CType(ByVal coll As ViewProductStandardsCollection) As List(Of ViewProductStandards)
            Dim list As List(Of ViewProductStandards) = New List(Of ViewProductStandards)
            Dim emp As ViewProductStandards

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewProductStandardsMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewProductStandardsQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewProductStandards(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewProductStandards()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewProductStandardsQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewProductStandardsQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewProductStandardsQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewProductStandards 
			Return CType(MyBase.AddNewEntity(), ViewProductStandards)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewProductStandards) Implements IEnumerable(Of ViewProductStandards).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewProductStandards)(Me)
        End Function
		
		Private _query As ViewProductStandardsQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewProductStandards' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewProductStandards ()")> _
	<Serializable> _
	Partial Public Class ViewProductStandards 
		Inherits esViewProductStandards

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewProductStandardsMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewProductStandardsQuery

			If Me._query Is Nothing Then
				Me._query = New ViewProductStandardsQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewProductStandardsQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewProductStandardsQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewProductStandardsQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewProductStandardsQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewProductStandardsQuery
		inherits esViewProductStandardsQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewProductStandardsQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewProductStandardsMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewProductStandardsMetadata.ColumnNames.Productid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewProductStandardsMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductStandardsMetadata.ColumnNames.Productdesc, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductStandardsMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductStandardsMetadata.ColumnNames.Container, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewProductStandardsMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductStandardsMetadata.ColumnNames.Phrangelow, 3, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewProductStandardsMetadata.PropertyNames.Phrangelow
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductStandardsMetadata.ColumnNames.Phrangehigh, 4, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewProductStandardsMetadata.PropertyNames.Phrangehigh
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductStandardsMetadata.ColumnNames.Sgrangelow, 5, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewProductStandardsMetadata.PropertyNames.Sgrangelow
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductStandardsMetadata.ColumnNames.Sgrangehigh, 6, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewProductStandardsMetadata.PropertyNames.Sgrangehigh
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewProductStandardsMetadata.ColumnNames.Needstesting, 7, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ViewProductStandardsMetadata.PropertyNames.Needstesting
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewProductStandardsMetadata
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
			 Public Const Productdesc As String = "PRODUCTDESC"
			 Public Const Container As String = "CONTAINER"
			 Public Const Phrangelow As String = "PHRANGELOW"
			 Public Const Phrangehigh As String = "PHRANGEHIGH"
			 Public Const Sgrangelow As String = "SGRANGELOW"
			 Public Const Sgrangehigh As String = "SGRANGEHIGH"
			 Public Const Needstesting As String = "NEEDSTESTING"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Productid As String = "Productid"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const Container As String = "Container"
			 Public Const Phrangelow As String = "Phrangelow"
			 Public Const Phrangehigh As String = "Phrangehigh"
			 Public Const Sgrangelow As String = "Sgrangelow"
			 Public Const Sgrangehigh As String = "Sgrangehigh"
			 Public Const Needstesting As String = "Needstesting"
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
            SyncLock GetType(ViewProductStandardsMetadata)
			
				If ViewProductStandardsMetadata.mapDelegates Is Nothing Then
					ViewProductStandardsMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewProductStandardsMetadata._meta Is Nothing Then
                    ViewProductStandardsMetadata._meta = New ViewProductStandardsMetadata()
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
				meta.AddTypeMap("Productdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Phrangelow", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Phrangehigh", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Sgrangelow", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Sgrangehigh", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Needstesting", new esTypeMap("bit", "System.Boolean"))			
				
				
				 
				meta.Source = "viewProductStandards"
				meta.Destination = "viewProductStandards"
				
				meta.spInsert = "proc_viewProductStandardsInsert"
				meta.spUpdate = "proc_viewProductStandardsUpdate"
				meta.spDelete = "proc_viewProductStandardsDelete"
				meta.spLoadAll = "proc_viewProductStandardsLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewProductStandardsLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewProductStandardsMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
