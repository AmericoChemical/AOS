'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 11/13/2014 4:11:58 PM
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
	MustInherit Public Class esViewMaterialProductInfoCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewMaterialProductInfoCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewMaterialProductInfoQuery)
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
            Me.InitQuery(CType(query, esViewMaterialProductInfoQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewMaterialProductInfo) As ViewMaterialProductInfo
			Return CType(MyBase.DetachEntity(entity), ViewMaterialProductInfo)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewMaterialProductInfo) As ViewMaterialProductInfo
			Return CType(MyBase.AttachEntity(entity), ViewMaterialProductInfo)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewMaterialProductInfoCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewMaterialProductInfo
            Get
                Return TryCast(MyBase.Item(index), ViewMaterialProductInfo)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewMaterialProductInfo)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewMaterialProductInfo	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewMaterialProductInfoQuery
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
												
						Case "Materialid"
							Me.str.Materialid = CType(value, string)
												
						Case "Productid"
							Me.str.Productid = CType(value, string)
												
						Case "Productdesc"
							Me.str.Productdesc = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "Units"
							Me.str.Units = CType(value, string)
												
						Case "Uom"
							Me.str.Uom = CType(value, string)
												
						Case "Priority"
							Me.str.Priority = CType(value, string)
												
						Case "Desc2"
							Me.str.Desc2 = CType(value, string)
												
						Case "Mpid"
							Me.str.Mpid = CType(value, string)
												
						Case "Mpnote"
							Me.str.Mpnote = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Materialid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Materialid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Productid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Productid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Units"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Units = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Priority"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Priority = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Mpid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Mpid = CType(value, Nullable(Of System.Int32))
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
		' Maps to viewMaterialProductInfo.MATERIALID
		' </summary>
		Public Overridable Property Materialid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewMaterialProductInfoMetadata.ColumnNames.Materialid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewMaterialProductInfoMetadata.ColumnNames.Materialid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewMaterialProductInfo.PRODUCTID
		' </summary>
		Public Overridable Property Productid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewMaterialProductInfoMetadata.ColumnNames.Productid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewMaterialProductInfoMetadata.ColumnNames.Productid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewMaterialProductInfo.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewMaterialProductInfoMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewMaterialProductInfoMetadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewMaterialProductInfo.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewMaterialProductInfoMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewMaterialProductInfoMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewMaterialProductInfo.UNITS
		' </summary>
		Public Overridable Property Units As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewMaterialProductInfoMetadata.ColumnNames.Units)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewMaterialProductInfoMetadata.ColumnNames.Units, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewMaterialProductInfo.UOM
		' </summary>
		Public Overridable Property Uom As System.String
			Get
				Return MyBase.GetSystemString(ViewMaterialProductInfoMetadata.ColumnNames.Uom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewMaterialProductInfoMetadata.ColumnNames.Uom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewMaterialProductInfo.PRIORITY
		' </summary>
		Public Overridable Property Priority As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewMaterialProductInfoMetadata.ColumnNames.Priority)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewMaterialProductInfoMetadata.ColumnNames.Priority, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewMaterialProductInfo.DESC2
		' </summary>
		Public Overridable Property Desc2 As System.String
			Get
				Return MyBase.GetSystemString(ViewMaterialProductInfoMetadata.ColumnNames.Desc2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewMaterialProductInfoMetadata.ColumnNames.Desc2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewMaterialProductInfo.MPID
		' </summary>
		Public Overridable Property Mpid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewMaterialProductInfoMetadata.ColumnNames.Mpid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewMaterialProductInfoMetadata.ColumnNames.Mpid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewMaterialProductInfo.MPNOTE
		' </summary>
		Public Overridable Property Mpnote As System.String
			Get
				Return MyBase.GetSystemString(ViewMaterialProductInfoMetadata.ColumnNames.Mpnote)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewMaterialProductInfoMetadata.ColumnNames.Mpnote, value)
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
		
			Public Sub New(ByVal entity As esViewMaterialProductInfo)
				Me.entity = entity
			End Sub				
		
	
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
		  	
			Public Property Units As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Units
					
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
						entity.Units = Convert.ToInt32(Value)
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
		  	
			Public Property Priority As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Priority
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Priority = Nothing
					Else
						entity.Priority = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Desc2 As System.String 
				Get
					Dim data_ As System.String = entity.Desc2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Desc2 = Nothing
					Else
						entity.Desc2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Mpid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Mpid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Mpid = Nothing
					Else
						entity.Mpid = Convert.ToInt32(Value)
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
		  

			Private entity As esViewMaterialProductInfo
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewMaterialProductInfoQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewMaterialProductInfo can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewMaterialProductInfoQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewMaterialProductInfoMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Materialid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialProductInfoMetadata.ColumnNames.Materialid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialProductInfoMetadata.ColumnNames.Productid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialProductInfoMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialProductInfoMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Units As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialProductInfoMetadata.ColumnNames.Units, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Uom As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialProductInfoMetadata.ColumnNames.Uom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Priority As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialProductInfoMetadata.ColumnNames.Priority, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Desc2 As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialProductInfoMetadata.ColumnNames.Desc2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Mpid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialProductInfoMetadata.ColumnNames.Mpid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Mpnote As esQueryItem
			Get
				Return New esQueryItem(Me, ViewMaterialProductInfoMetadata.ColumnNames.Mpnote, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewMaterialProductInfoCollection")> _
	Partial Public Class ViewMaterialProductInfoCollection
		Inherits esViewMaterialProductInfoCollection
		Implements IEnumerable(Of ViewMaterialProductInfo)
		
        Public Shared Widening Operator CType(ByVal coll As ViewMaterialProductInfoCollection) As List(Of ViewMaterialProductInfo)
            Dim list As List(Of ViewMaterialProductInfo) = New List(Of ViewMaterialProductInfo)
            Dim emp As ViewMaterialProductInfo

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewMaterialProductInfoMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewMaterialProductInfoQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewMaterialProductInfo(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewMaterialProductInfo()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewMaterialProductInfoQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewMaterialProductInfoQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewMaterialProductInfoQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewMaterialProductInfo 
			Return CType(MyBase.AddNewEntity(), ViewMaterialProductInfo)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewMaterialProductInfo) Implements IEnumerable(Of ViewMaterialProductInfo).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewMaterialProductInfo)(Me)
        End Function
		
		Private _query As ViewMaterialProductInfoQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewMaterialProductInfo' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewMaterialProductInfo ()")> _
	<Serializable> _
	Partial Public Class ViewMaterialProductInfo 
		Inherits esViewMaterialProductInfo

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewMaterialProductInfoMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewMaterialProductInfoQuery

			If Me._query Is Nothing Then
				Me._query = New ViewMaterialProductInfoQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewMaterialProductInfoQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewMaterialProductInfoQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewMaterialProductInfoQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewMaterialProductInfoQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewMaterialProductInfoQuery
		inherits esViewMaterialProductInfoQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewMaterialProductInfoQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewMaterialProductInfoMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewMaterialProductInfoMetadata.ColumnNames.Materialid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewMaterialProductInfoMetadata.PropertyNames.Materialid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewMaterialProductInfoMetadata.ColumnNames.Productid, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewMaterialProductInfoMetadata.PropertyNames.Productid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewMaterialProductInfoMetadata.ColumnNames.Productdesc, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewMaterialProductInfoMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewMaterialProductInfoMetadata.ColumnNames.Container, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewMaterialProductInfoMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewMaterialProductInfoMetadata.ColumnNames.Units, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewMaterialProductInfoMetadata.PropertyNames.Units
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewMaterialProductInfoMetadata.ColumnNames.Uom, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewMaterialProductInfoMetadata.PropertyNames.Uom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewMaterialProductInfoMetadata.ColumnNames.Priority, 6, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewMaterialProductInfoMetadata.PropertyNames.Priority
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewMaterialProductInfoMetadata.ColumnNames.Desc2, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewMaterialProductInfoMetadata.PropertyNames.Desc2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewMaterialProductInfoMetadata.ColumnNames.Mpid, 8, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewMaterialProductInfoMetadata.PropertyNames.Mpid
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewMaterialProductInfoMetadata.ColumnNames.Mpnote, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewMaterialProductInfoMetadata.PropertyNames.Mpnote
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewMaterialProductInfoMetadata
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
			 Public Const Materialid As String = "MATERIALID"
			 Public Const Productid As String = "PRODUCTID"
			 Public Const Productdesc As String = "PRODUCTDESC"
			 Public Const Container As String = "CONTAINER"
			 Public Const Units As String = "UNITS"
			 Public Const Uom As String = "UOM"
			 Public Const Priority As String = "PRIORITY"
			 Public Const Desc2 As String = "DESC2"
			 Public Const Mpid As String = "MPID"
			 Public Const Mpnote As String = "MPNOTE"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Materialid As String = "Materialid"
			 Public Const Productid As String = "Productid"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const Container As String = "Container"
			 Public Const Units As String = "Units"
			 Public Const Uom As String = "Uom"
			 Public Const Priority As String = "Priority"
			 Public Const Desc2 As String = "Desc2"
			 Public Const Mpid As String = "Mpid"
			 Public Const Mpnote As String = "Mpnote"
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
            SyncLock GetType(ViewMaterialProductInfoMetadata)
			
				If ViewMaterialProductInfoMetadata.mapDelegates Is Nothing Then
					ViewMaterialProductInfoMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewMaterialProductInfoMetadata._meta Is Nothing Then
                    ViewMaterialProductInfoMetadata._meta = New ViewMaterialProductInfoMetadata()
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
				

				meta.AddTypeMap("Materialid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Productdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Units", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Uom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Priority", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Desc2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Mpid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Mpnote", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewMaterialProductInfo"
				meta.Destination = "viewMaterialProductInfo"
				
				meta.spInsert = "proc_viewMaterialProductInfoInsert"
				meta.spUpdate = "proc_viewMaterialProductInfoUpdate"
				meta.spDelete = "proc_viewMaterialProductInfoDelete"
				meta.spLoadAll = "proc_viewMaterialProductInfoLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewMaterialProductInfoLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewMaterialProductInfoMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
