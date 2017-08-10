'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 9/11/2014 12:04:03 PM
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
	MustInherit Public Class esViewKitComponentCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewKitComponentCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewKitComponentQuery)
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
            Me.InitQuery(CType(query, esViewKitComponentQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewKitComponent) As ViewKitComponent
			Return CType(MyBase.DetachEntity(entity), ViewKitComponent)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewKitComponent) As ViewKitComponent
			Return CType(MyBase.AttachEntity(entity), ViewKitComponent)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewKitComponentCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewKitComponent
            Get
                Return TryCast(MyBase.Item(index), ViewKitComponent)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewKitComponent)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewKitComponent	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewKitComponentQuery
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
												
						Case "Kitid"
							Me.str.Kitid = CType(value, string)
												
						Case "KitComponentID"
							Me.str.KitComponentID = CType(value, string)
												
						Case "Componentid"
							Me.str.Componentid = CType(value, string)
												
						Case "Componentqty"
							Me.str.Componentqty = CType(value, string)
												
						Case "Componentdesc"
							Me.str.Componentdesc = CType(value, string)
												
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
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Kitid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Kitid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "KitComponentID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.KitComponentID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Componentid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Componentid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Componentqty"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Componentqty = CType(value, Nullable(Of System.Double))
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
		' Maps to viewKitComponent.KITID
		' </summary>
		Public Overridable Property Kitid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewKitComponentMetadata.ColumnNames.Kitid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewKitComponentMetadata.ColumnNames.Kitid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewKitComponent.KitComponentID
		' </summary>
		Public Overridable Property KitComponentID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewKitComponentMetadata.ColumnNames.KitComponentID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewKitComponentMetadata.ColumnNames.KitComponentID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewKitComponent.COMPONENTID
		' </summary>
		Public Overridable Property Componentid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewKitComponentMetadata.ColumnNames.Componentid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewKitComponentMetadata.ColumnNames.Componentid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewKitComponent.COMPONENTQTY
		' </summary>
		Public Overridable Property Componentqty As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewKitComponentMetadata.ColumnNames.Componentqty)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewKitComponentMetadata.ColumnNames.Componentqty, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewKitComponent.COMPONENTDESC
		' </summary>
		Public Overridable Property Componentdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewKitComponentMetadata.ColumnNames.Componentdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewKitComponentMetadata.ColumnNames.Componentdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewKitComponent.VENDORNAME
		' </summary>
		Public Overridable Property Vendorname As System.String
			Get
				Return MyBase.GetSystemString(ViewKitComponentMetadata.ColumnNames.Vendorname)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewKitComponentMetadata.ColumnNames.Vendorname, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewKitComponent.VENDORITEMID
		' </summary>
		Public Overridable Property Vendoritemid As System.String
			Get
				Return MyBase.GetSystemString(ViewKitComponentMetadata.ColumnNames.Vendoritemid)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewKitComponentMetadata.ColumnNames.Vendoritemid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewKitComponent.VENDORDESC
		' </summary>
		Public Overridable Property Vendordesc As System.String
			Get
				Return MyBase.GetSystemString(ViewKitComponentMetadata.ColumnNames.Vendordesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewKitComponentMetadata.ColumnNames.Vendordesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewKitComponent.UNITCOST
		' </summary>
		Public Overridable Property Unitcost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ViewKitComponentMetadata.ColumnNames.Unitcost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ViewKitComponentMetadata.ColumnNames.Unitcost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewKitComponent.QTY
		' </summary>
		Public Overridable Property Qty As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(ViewKitComponentMetadata.ColumnNames.Qty)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(ViewKitComponentMetadata.ColumnNames.Qty, value)
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
		
			Public Sub New(ByVal entity As esViewKitComponent)
				Me.entity = entity
			End Sub				
		
	
			Public Property Kitid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Kitid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Kitid = Nothing
					Else
						entity.Kitid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property KitComponentID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.KitComponentID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.KitComponentID = Nothing
					Else
						entity.KitComponentID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
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
		  	
			Public Property Componentqty As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Componentqty
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Componentqty = Nothing
					Else
						entity.Componentqty = Convert.ToDouble(Value)
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
		  

			Private entity As esViewKitComponent
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewKitComponentQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewKitComponent can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewKitComponentQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewKitComponentMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Kitid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewKitComponentMetadata.ColumnNames.Kitid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property KitComponentID As esQueryItem
			Get
				Return New esQueryItem(Me, ViewKitComponentMetadata.ColumnNames.KitComponentID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Componentid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewKitComponentMetadata.ColumnNames.Componentid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Componentqty As esQueryItem
			Get
				Return New esQueryItem(Me, ViewKitComponentMetadata.ColumnNames.Componentqty, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Componentdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewKitComponentMetadata.ColumnNames.Componentdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Vendorname As esQueryItem
			Get
				Return New esQueryItem(Me, ViewKitComponentMetadata.ColumnNames.Vendorname, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Vendoritemid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewKitComponentMetadata.ColumnNames.Vendoritemid, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Vendordesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewKitComponentMetadata.ColumnNames.Vendordesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Unitcost As esQueryItem
			Get
				Return New esQueryItem(Me, ViewKitComponentMetadata.ColumnNames.Unitcost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Qty As esQueryItem
			Get
				Return New esQueryItem(Me, ViewKitComponentMetadata.ColumnNames.Qty, esSystemType.Double)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewKitComponentCollection")> _
	Partial Public Class ViewKitComponentCollection
		Inherits esViewKitComponentCollection
		Implements IEnumerable(Of ViewKitComponent)
		
        Public Shared Widening Operator CType(ByVal coll As ViewKitComponentCollection) As List(Of ViewKitComponent)
            Dim list As List(Of ViewKitComponent) = New List(Of ViewKitComponent)
            Dim emp As ViewKitComponent

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewKitComponentMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewKitComponentQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewKitComponent(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewKitComponent()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewKitComponentQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewKitComponentQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewKitComponentQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewKitComponent 
			Return CType(MyBase.AddNewEntity(), ViewKitComponent)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewKitComponent) Implements IEnumerable(Of ViewKitComponent).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewKitComponent)(Me)
        End Function
		
		Private _query As ViewKitComponentQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewKitComponent' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewKitComponent ()")> _
	<Serializable> _
	Partial Public Class ViewKitComponent 
		Inherits esViewKitComponent

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewKitComponentMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewKitComponentQuery

			If Me._query Is Nothing Then
				Me._query = New ViewKitComponentQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewKitComponentQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewKitComponentQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewKitComponentQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewKitComponentQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewKitComponentQuery
		inherits esViewKitComponentQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewKitComponentQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewKitComponentMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewKitComponentMetadata.ColumnNames.Kitid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewKitComponentMetadata.PropertyNames.Kitid
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewKitComponentMetadata.ColumnNames.KitComponentID, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewKitComponentMetadata.PropertyNames.KitComponentID
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewKitComponentMetadata.ColumnNames.Componentid, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewKitComponentMetadata.PropertyNames.Componentid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewKitComponentMetadata.ColumnNames.Componentqty, 3, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewKitComponentMetadata.PropertyNames.Componentqty
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewKitComponentMetadata.ColumnNames.Componentdesc, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewKitComponentMetadata.PropertyNames.Componentdesc
			c.CharacterMaxLength = 255
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewKitComponentMetadata.ColumnNames.Vendorname, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewKitComponentMetadata.PropertyNames.Vendorname
			c.CharacterMaxLength = 255
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewKitComponentMetadata.ColumnNames.Vendoritemid, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewKitComponentMetadata.PropertyNames.Vendoritemid
			c.CharacterMaxLength = 255
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewKitComponentMetadata.ColumnNames.Vendordesc, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewKitComponentMetadata.PropertyNames.Vendordesc
			c.CharacterMaxLength = 255
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewKitComponentMetadata.ColumnNames.Unitcost, 8, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ViewKitComponentMetadata.PropertyNames.Unitcost
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewKitComponentMetadata.ColumnNames.Qty, 9, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = ViewKitComponentMetadata.PropertyNames.Qty
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewKitComponentMetadata
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
			 Public Const Kitid As String = "KITID"
			 Public Const KitComponentID As String = "KitComponentID"
			 Public Const Componentid As String = "COMPONENTID"
			 Public Const Componentqty As String = "COMPONENTQTY"
			 Public Const Componentdesc As String = "COMPONENTDESC"
			 Public Const Vendorname As String = "VENDORNAME"
			 Public Const Vendoritemid As String = "VENDORITEMID"
			 Public Const Vendordesc As String = "VENDORDESC"
			 Public Const Unitcost As String = "UNITCOST"
			 Public Const Qty As String = "QTY"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Kitid As String = "Kitid"
			 Public Const KitComponentID As String = "KitComponentID"
			 Public Const Componentid As String = "Componentid"
			 Public Const Componentqty As String = "Componentqty"
			 Public Const Componentdesc As String = "Componentdesc"
			 Public Const Vendorname As String = "Vendorname"
			 Public Const Vendoritemid As String = "Vendoritemid"
			 Public Const Vendordesc As String = "Vendordesc"
			 Public Const Unitcost As String = "Unitcost"
			 Public Const Qty As String = "Qty"
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
            SyncLock GetType(ViewKitComponentMetadata)
			
				If ViewKitComponentMetadata.mapDelegates Is Nothing Then
					ViewKitComponentMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewKitComponentMetadata._meta Is Nothing Then
                    ViewKitComponentMetadata._meta = New ViewKitComponentMetadata()
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
				

				meta.AddTypeMap("Kitid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("KitComponentID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Componentid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Componentqty", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Componentdesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Vendorname", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Vendoritemid", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Vendordesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("Unitcost", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Qty", new esTypeMap("float", "System.Double"))			
				
				
				 
				meta.Source = "viewKitComponent"
				meta.Destination = "viewKitComponent"
				
				meta.spInsert = "proc_viewKitComponentInsert"
				meta.spUpdate = "proc_viewKitComponentUpdate"
				meta.spDelete = "proc_viewKitComponentDelete"
				meta.spLoadAll = "proc_viewKitComponentLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewKitComponentLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewKitComponentMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
