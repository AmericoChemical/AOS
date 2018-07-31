'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 8/6/2014 7:46:55 PM
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
	MustInherit Public Class esComponentCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ComponentCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esComponentQuery)
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
            Me.InitQuery(CType(query, esComponentQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Component) As Component
			Return CType(MyBase.DetachEntity(entity), Component)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Component) As Component
			Return CType(MyBase.AttachEntity(entity), Component)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ComponentCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Component
            Get
                Return TryCast(MyBase.Item(index), Component)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Component)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esComponent	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esComponentQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal componentid As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(componentid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(componentid)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal componentid As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(componentid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(componentid)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal componentid As System.Int32) As Boolean
		
			Dim query As esComponentQuery = Me.GetDynamicQuery()
			query.Where(query.Componentid.Equal(componentid))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal componentid As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("COMPONENTID", componentid)
			
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
												
						Case "Componentid"
							Me.str.Componentid = CType(value, string)
												
						Case "Componentdesc"
							Me.str.Componentdesc = CType(value, string)
												
						Case "Componenttype"
							Me.str.Componenttype = CType(value, string)
												
						Case "Vendorid"
							Me.str.Vendorid = CType(value, string)
												
						Case "Vendorname"
							Me.str.Vendorname = CType(value, string)
												
						Case "Vendoritemid"
							Me.str.Vendoritemid = CType(value, string)
												
						Case "Vendordesc"
							Me.str.Vendordesc = CType(value, string)
												
						Case "Unitcost"
							Me.str.Unitcost = CType(value, string)
												
						Case "Qty"
							Me.str.Qty = CType(value, string)
												
						Case "Oldid"
							Me.str.Oldid = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Componentid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Componentid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Vendorid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Vendorid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Unitcost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Unitcost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Qty"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Qty = CType(value, Nullable(Of System.Double))
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
		' Maps to COMPONENT.COMPONENTID
		' </summary>
		Public Overridable Property Componentid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ComponentMetadata.ColumnNames.Componentid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ComponentMetadata.ColumnNames.Componentid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to COMPONENT.COMPONENTDESC
		' </summary>
		Public Overridable Property Componentdesc As System.String
			Get
				Return MyBase.GetSystemString(ComponentMetadata.ColumnNames.Componentdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ComponentMetadata.ColumnNames.Componentdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to COMPONENT.COMPONENTTYPE
		' </summary>
		Public Overridable Property Componenttype As System.String
			Get
				Return MyBase.GetSystemString(ComponentMetadata.ColumnNames.Componenttype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ComponentMetadata.ColumnNames.Componenttype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to COMPONENT.VENDORID
		' </summary>
		Public Overridable Property Vendorid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ComponentMetadata.ColumnNames.Vendorid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ComponentMetadata.ColumnNames.Vendorid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to COMPONENT.VENDORNAME
		' </summary>
		Public Overridable Property Vendorname As System.String
			Get
				Return MyBase.GetSystemString(ComponentMetadata.ColumnNames.Vendorname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ComponentMetadata.ColumnNames.Vendorname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to COMPONENT.VENDORITEMID
		' </summary>
		Public Overridable Property Vendoritemid As System.String
			Get
				Return MyBase.GetSystemString(ComponentMetadata.ColumnNames.Vendoritemid)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ComponentMetadata.ColumnNames.Vendoritemid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to COMPONENT.VENDORDESC
		' </summary>
		Public Overridable Property Vendordesc As System.String
			Get
				Return MyBase.GetSystemString(ComponentMetadata.ColumnNames.Vendordesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ComponentMetadata.ColumnNames.Vendordesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to COMPONENT.UNITCOST
		' </summary>
		Public Overridable Property Unitcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ComponentMetadata.ColumnNames.Unitcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ComponentMetadata.ColumnNames.Unitcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to COMPONENT.QTY
		' </summary>
		Public Overridable Property Qty As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ComponentMetadata.ColumnNames.Qty)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ComponentMetadata.ColumnNames.Qty, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to COMPONENT.OLDID
		' </summary>
		Public Overridable Property Oldid As System.String
			Get
				Return MyBase.GetSystemString(ComponentMetadata.ColumnNames.Oldid)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ComponentMetadata.ColumnNames.Oldid, value)
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
		
			Public Sub New(ByVal entity As esComponent)
				Me.entity = entity
			End Sub				
		
	
			Public Property Componentid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Componentid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Componentid = Nothing
					Else
						entity.Componentid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Componentdesc As System.String 
				Get
					Dim data_ As System.String = entity.Componentdesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Componentdesc = Nothing
					Else
						entity.Componentdesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Componenttype As System.String 
				Get
					Dim data_ As System.String = entity.Componenttype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Componenttype = Nothing
					Else
						entity.Componenttype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Vendorid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Vendorid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Vendorid = Nothing
					Else
						entity.Vendorid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Vendorname As System.String 
				Get
					Dim data_ As System.String = entity.Vendorname
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Vendorname = Nothing
					Else
						entity.Vendorname = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Vendoritemid As System.String 
				Get
					Dim data_ As System.String = entity.Vendoritemid
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Vendoritemid = Nothing
					Else
						entity.Vendoritemid = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Vendordesc As System.String 
				Get
					Dim data_ As System.String = entity.Vendordesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Vendordesc = Nothing
					Else
						entity.Vendordesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Unitcost As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Unitcost
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Unitcost = Nothing
					Else
						entity.Unitcost = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Qty As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Qty
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Qty = Nothing
					Else
						entity.Qty = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property Oldid As System.String 
				Get
					Dim data_ As System.String = entity.Oldid
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Oldid = Nothing
					Else
						entity.Oldid = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esComponent
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esComponentQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esComponent can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Component 
		Inherits esComponent
		
	
		
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
	MustInherit Public Class esComponentQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ComponentMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Componentid As esQueryItem
			Get
				Return New esQueryItem(Me, ComponentMetadata.ColumnNames.Componentid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Componentdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ComponentMetadata.ColumnNames.Componentdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Componenttype As esQueryItem
			Get
				Return New esQueryItem(Me, ComponentMetadata.ColumnNames.Componenttype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Vendorid As esQueryItem
			Get
				Return New esQueryItem(Me, ComponentMetadata.ColumnNames.Vendorid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Vendorname As esQueryItem
			Get
				Return New esQueryItem(Me, ComponentMetadata.ColumnNames.Vendorname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Vendoritemid As esQueryItem
			Get
				Return New esQueryItem(Me, ComponentMetadata.ColumnNames.Vendoritemid, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Vendordesc As esQueryItem
			Get
				Return New esQueryItem(Me, ComponentMetadata.ColumnNames.Vendordesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Unitcost As esQueryItem
			Get
				Return New esQueryItem(Me, ComponentMetadata.ColumnNames.Unitcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Qty As esQueryItem
			Get
				Return New esQueryItem(Me, ComponentMetadata.ColumnNames.Qty, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Oldid As esQueryItem
			Get
				Return New esQueryItem(Me, ComponentMetadata.ColumnNames.Oldid, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ComponentCollection")> _
	Partial Public Class ComponentCollection
		Inherits esComponentCollection
		Implements IEnumerable(Of Component)
		
        Public Shared Widening Operator CType(ByVal coll As ComponentCollection) As List(Of Component)
            Dim list As List(Of Component) = New List(Of Component)
            Dim emp As Component

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ComponentMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ComponentQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Component(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Component()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As ComponentQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ComponentQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ComponentQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Component 
			Return CType(MyBase.AddNewEntity(), Component)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal componentid As System.Int32) As Component
			Return CType(MyBase.FindByPrimaryKey(componentid), Component)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Component) Implements IEnumerable(Of Component).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Component)(Me)
        End Function
		
		Private _query As ComponentQuery

	End Class
	


	' <summary>
	' Encapsulates the 'COMPONENT' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Component ({Componentid.Value})")> _
	<Serializable> _
	Partial Public Class Component 
		Inherits esComponent

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ComponentMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esComponentQuery

			If Me._query Is Nothing Then
				Me._query = New ComponentQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ComponentQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ComponentQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ComponentQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ComponentQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ComponentQuery
		inherits esComponentQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ComponentQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ComponentMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ComponentMetadata.ColumnNames.Componentid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ComponentMetadata.PropertyNames.Componentid
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ComponentMetadata.ColumnNames.Componentdesc, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ComponentMetadata.PropertyNames.Componentdesc
			c.CharacterMaxLength = 255
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ComponentMetadata.ColumnNames.Componenttype, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ComponentMetadata.PropertyNames.Componenttype
			c.CharacterMaxLength = 255
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ComponentMetadata.ColumnNames.Vendorid, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ComponentMetadata.PropertyNames.Vendorid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ComponentMetadata.ColumnNames.Vendorname, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ComponentMetadata.PropertyNames.Vendorname
			c.CharacterMaxLength = 255
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ComponentMetadata.ColumnNames.Vendoritemid, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ComponentMetadata.PropertyNames.Vendoritemid
			c.CharacterMaxLength = 255
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ComponentMetadata.ColumnNames.Vendordesc, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ComponentMetadata.PropertyNames.Vendordesc
			c.CharacterMaxLength = 255
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ComponentMetadata.ColumnNames.Unitcost, 7, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ComponentMetadata.PropertyNames.Unitcost
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ComponentMetadata.ColumnNames.Qty, 8, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ComponentMetadata.PropertyNames.Qty
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ComponentMetadata.ColumnNames.Oldid, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ComponentMetadata.PropertyNames.Oldid
			c.CharacterMaxLength = 255
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ComponentMetadata
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
			 Public Const Componentid As String = "COMPONENTID"
			 Public Const Componentdesc As String = "COMPONENTDESC"
			 Public Const Componenttype As String = "COMPONENTTYPE"
			 Public Const Vendorid As String = "VENDORID"
			 Public Const Vendorname As String = "VENDORNAME"
			 Public Const Vendoritemid As String = "VENDORITEMID"
			 Public Const Vendordesc As String = "VENDORDESC"
			 Public Const Unitcost As String = "UNITCOST"
			 Public Const Qty As String = "QTY"
			 Public Const Oldid As String = "OLDID"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Componentid As String = "Componentid"
			 Public Const Componentdesc As String = "Componentdesc"
			 Public Const Componenttype As String = "Componenttype"
			 Public Const Vendorid As String = "Vendorid"
			 Public Const Vendorname As String = "Vendorname"
			 Public Const Vendoritemid As String = "Vendoritemid"
			 Public Const Vendordesc As String = "Vendordesc"
			 Public Const Unitcost As String = "Unitcost"
			 Public Const Qty As String = "Qty"
			 Public Const Oldid As String = "Oldid"
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
            SyncLock GetType(ComponentMetadata)
			
				If ComponentMetadata.mapDelegates Is Nothing Then
					ComponentMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ComponentMetadata._meta Is Nothing Then
                    ComponentMetadata._meta = New ComponentMetadata()
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
				

				meta.AddTypeMap("Componentid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Componentdesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Componenttype", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Vendorid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Vendorname", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Vendoritemid", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Vendordesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Unitcost", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Qty", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Oldid", new esTypeMap("nvarchar", "System.String"))			
				
				
				 
				meta.Source = "COMPONENT"
				meta.Destination = "COMPONENT"
				
				meta.spInsert = "proc_COMPONENTInsert"
				meta.spUpdate = "proc_COMPONENTUpdate"
				meta.spDelete = "proc_COMPONENTDelete"
				meta.spLoadAll = "proc_COMPONENTLoadAll"
				meta.spLoadByPrimaryKey = "proc_COMPONENTLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ComponentMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
