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
	MustInherit Public Class esViewAvailableInventoryItemsByBinCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewAvailableInventoryItemsByBinCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewAvailableInventoryItemsByBinQuery)
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
            Me.InitQuery(CType(query, esViewAvailableInventoryItemsByBinQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewAvailableInventoryItemsByBin) As ViewAvailableInventoryItemsByBin
			Return CType(MyBase.DetachEntity(entity), ViewAvailableInventoryItemsByBin)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewAvailableInventoryItemsByBin) As ViewAvailableInventoryItemsByBin
			Return CType(MyBase.AttachEntity(entity), ViewAvailableInventoryItemsByBin)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewAvailableInventoryItemsByBinCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewAvailableInventoryItemsByBin
            Get
                Return TryCast(MyBase.Item(index), ViewAvailableInventoryItemsByBin)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewAvailableInventoryItemsByBin)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewAvailableInventoryItemsByBin	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewAvailableInventoryItemsByBinQuery
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
												
						Case "Bin"
							Me.str.Bin = CType(value, string)
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Productdesc"
							Me.str.Productdesc = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "Invitemnumber"
							Me.str.Invitemnumber = CType(value, string)
												
						Case "Receiveddate"
							Me.str.Receiveddate = CType(value, string)
												
						Case "Lotnumber"
							Me.str.Lotnumber = CType(value, string)
												
						Case "LookupDesc"
							Me.str.LookupDesc = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Invitemnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Invitemnumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Receiveddate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Receiveddate = CType(value, Nullable(Of System.DateTime))
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
		' Maps to viewAvailableInventoryItemsByBin.bin
		' </summary>
		Public Overridable Property Bin As System.String
			Get
				Return MyBase.GetSystemString(ViewAvailableInventoryItemsByBinMetadata.ColumnNames.Bin)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewAvailableInventoryItemsByBinMetadata.ColumnNames.Bin, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAvailableInventoryItemsByBin.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewAvailableInventoryItemsByBinMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewAvailableInventoryItemsByBinMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAvailableInventoryItemsByBin.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewAvailableInventoryItemsByBinMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewAvailableInventoryItemsByBinMetadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAvailableInventoryItemsByBin.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewAvailableInventoryItemsByBinMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewAvailableInventoryItemsByBinMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAvailableInventoryItemsByBin.INVITEMNUMBER
		' </summary>
		Public Overridable Property Invitemnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewAvailableInventoryItemsByBinMetadata.ColumnNames.Invitemnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewAvailableInventoryItemsByBinMetadata.ColumnNames.Invitemnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAvailableInventoryItemsByBin.RECEIVEDDATE
		' </summary>
		Public Overridable Property Receiveddate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewAvailableInventoryItemsByBinMetadata.ColumnNames.Receiveddate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewAvailableInventoryItemsByBinMetadata.ColumnNames.Receiveddate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAvailableInventoryItemsByBin.LOTNUMBER
		' </summary>
		Public Overridable Property Lotnumber As System.String
			Get
				Return MyBase.GetSystemString(ViewAvailableInventoryItemsByBinMetadata.ColumnNames.Lotnumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewAvailableInventoryItemsByBinMetadata.ColumnNames.Lotnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewAvailableInventoryItemsByBin.LookupDesc
		' </summary>
		Public Overridable Property LookupDesc As System.String
			Get
				Return MyBase.GetSystemString(ViewAvailableInventoryItemsByBinMetadata.ColumnNames.LookupDesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewAvailableInventoryItemsByBinMetadata.ColumnNames.LookupDesc, value)
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
		
			Public Sub New(ByVal entity As esViewAvailableInventoryItemsByBin)
				Me.entity = entity
			End Sub				
		
	
			Public Property Bin As System.String 
				Get
					Dim data_ As System.String = entity.Bin
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Bin = Nothing
					Else
						entity.Bin = Convert.ToString(Value)
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
		  	
			Public Property Invitemnumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Invitemnumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Invitemnumber = Nothing
					Else
						entity.Invitemnumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Receiveddate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Receiveddate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Receiveddate = Nothing
					Else
						entity.Receiveddate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Lotnumber As System.String 
				Get
					Dim data_ As System.String = entity.Lotnumber
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Lotnumber = Nothing
					Else
						entity.Lotnumber = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property LookupDesc As System.String 
				Get
					Dim data_ As System.String = entity.LookupDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LookupDesc = Nothing
					Else
						entity.LookupDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewAvailableInventoryItemsByBin
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewAvailableInventoryItemsByBinQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewAvailableInventoryItemsByBin can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewAvailableInventoryItemsByBinQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewAvailableInventoryItemsByBinMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Bin As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAvailableInventoryItemsByBinMetadata.ColumnNames.Bin, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAvailableInventoryItemsByBinMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAvailableInventoryItemsByBinMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAvailableInventoryItemsByBinMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Invitemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAvailableInventoryItemsByBinMetadata.ColumnNames.Invitemnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Receiveddate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAvailableInventoryItemsByBinMetadata.ColumnNames.Receiveddate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Lotnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAvailableInventoryItemsByBinMetadata.ColumnNames.Lotnumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LookupDesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewAvailableInventoryItemsByBinMetadata.ColumnNames.LookupDesc, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewAvailableInventoryItemsByBinCollection")> _
	Partial Public Class ViewAvailableInventoryItemsByBinCollection
		Inherits esViewAvailableInventoryItemsByBinCollection
		Implements IEnumerable(Of ViewAvailableInventoryItemsByBin)
		
        Public Shared Widening Operator CType(ByVal coll As ViewAvailableInventoryItemsByBinCollection) As List(Of ViewAvailableInventoryItemsByBin)
            Dim list As List(Of ViewAvailableInventoryItemsByBin) = New List(Of ViewAvailableInventoryItemsByBin)
            Dim emp As ViewAvailableInventoryItemsByBin

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewAvailableInventoryItemsByBinMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewAvailableInventoryItemsByBinQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewAvailableInventoryItemsByBin(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewAvailableInventoryItemsByBin()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewAvailableInventoryItemsByBinQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewAvailableInventoryItemsByBinQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewAvailableInventoryItemsByBinQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewAvailableInventoryItemsByBin 
			Return CType(MyBase.AddNewEntity(), ViewAvailableInventoryItemsByBin)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewAvailableInventoryItemsByBin) Implements IEnumerable(Of ViewAvailableInventoryItemsByBin).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewAvailableInventoryItemsByBin)(Me)
        End Function
		
		Private _query As ViewAvailableInventoryItemsByBinQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewAvailableInventoryItemsByBin' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewAvailableInventoryItemsByBin ()")> _
	<Serializable> _
	Partial Public Class ViewAvailableInventoryItemsByBin 
		Inherits esViewAvailableInventoryItemsByBin

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewAvailableInventoryItemsByBinMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewAvailableInventoryItemsByBinQuery

			If Me._query Is Nothing Then
				Me._query = New ViewAvailableInventoryItemsByBinQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewAvailableInventoryItemsByBinQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewAvailableInventoryItemsByBinQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewAvailableInventoryItemsByBinQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewAvailableInventoryItemsByBinQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewAvailableInventoryItemsByBinQuery
		inherits esViewAvailableInventoryItemsByBinQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewAvailableInventoryItemsByBinQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewAvailableInventoryItemsByBinMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewAvailableInventoryItemsByBinMetadata.ColumnNames.Bin, 0, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewAvailableInventoryItemsByBinMetadata.PropertyNames.Bin
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAvailableInventoryItemsByBinMetadata.ColumnNames.Productid, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewAvailableInventoryItemsByBinMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAvailableInventoryItemsByBinMetadata.ColumnNames.Productdesc, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewAvailableInventoryItemsByBinMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAvailableInventoryItemsByBinMetadata.ColumnNames.Container, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewAvailableInventoryItemsByBinMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAvailableInventoryItemsByBinMetadata.ColumnNames.Invitemnumber, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewAvailableInventoryItemsByBinMetadata.PropertyNames.Invitemnumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAvailableInventoryItemsByBinMetadata.ColumnNames.Receiveddate, 5, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewAvailableInventoryItemsByBinMetadata.PropertyNames.Receiveddate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAvailableInventoryItemsByBinMetadata.ColumnNames.Lotnumber, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewAvailableInventoryItemsByBinMetadata.PropertyNames.Lotnumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewAvailableInventoryItemsByBinMetadata.ColumnNames.LookupDesc, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewAvailableInventoryItemsByBinMetadata.PropertyNames.LookupDesc
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewAvailableInventoryItemsByBinMetadata
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
			 Public Const Bin As String = "bin"
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Productdesc As String = "PRODUCTDESC"
			 Public Const Container As String = "CONTAINER"
			 Public Const Invitemnumber As String = "INVITEMNUMBER"
			 Public Const Receiveddate As String = "RECEIVEDDATE"
			 Public Const Lotnumber As String = "LOTNUMBER"
			 Public Const LookupDesc As String = "LookupDesc"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Bin As String = "Bin"
			 Public Const Productid As String = "Productid"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const Container As String = "Container"
			 Public Const Invitemnumber As String = "Invitemnumber"
			 Public Const Receiveddate As String = "Receiveddate"
			 Public Const Lotnumber As String = "Lotnumber"
			 Public Const LookupDesc As String = "LookupDesc"
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
            SyncLock GetType(ViewAvailableInventoryItemsByBinMetadata)
			
				If ViewAvailableInventoryItemsByBinMetadata.mapDelegates Is Nothing Then
					ViewAvailableInventoryItemsByBinMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewAvailableInventoryItemsByBinMetadata._meta Is Nothing Then
                    ViewAvailableInventoryItemsByBinMetadata._meta = New ViewAvailableInventoryItemsByBinMetadata()
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
				

				meta.AddTypeMap("Bin", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Productid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Invitemnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Receiveddate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Lotnumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("LookupDesc", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewAvailableInventoryItemsByBin"
				meta.Destination = "viewAvailableInventoryItemsByBin"
				
				meta.spInsert = "proc_viewAvailableInventoryItemsByBinInsert"
				meta.spUpdate = "proc_viewAvailableInventoryItemsByBinUpdate"
				meta.spDelete = "proc_viewAvailableInventoryItemsByBinDelete"
				meta.spLoadAll = "proc_viewAvailableInventoryItemsByBinLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewAvailableInventoryItemsByBinLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewAvailableInventoryItemsByBinMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
