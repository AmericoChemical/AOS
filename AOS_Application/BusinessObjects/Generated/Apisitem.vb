'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 4/11/2016 2:37:48 PM
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
	MustInherit Public Class esApisitemCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ApisitemCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esApisitemQuery)
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
            Me.InitQuery(CType(query, esApisitemQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Apisitem) As Apisitem
			Return CType(MyBase.DetachEntity(entity), Apisitem)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Apisitem) As Apisitem
			Return CType(MyBase.AttachEntity(entity), Apisitem)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ApisitemCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Apisitem
            Get
                Return TryCast(MyBase.Item(index), Apisitem)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Apisitem)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esApisitem	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esApisitemQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal apisitemnum As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(apisitemnum)
			Else
				Return LoadByPrimaryKeyStoredProcedure(apisitemnum)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal apisitemnum As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(apisitemnum)
			Else
				Return LoadByPrimaryKeyStoredProcedure(apisitemnum)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal apisitemnum As System.Int32) As Boolean
		
			Dim query As esApisitemQuery = Me.GetDynamicQuery()
			query.Where(query.Apisitemnum.Equal(apisitemnum))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal apisitemnum As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("APISITEMNUM", apisitemnum)
			
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
												
						Case "Sourceproductid"
							Me.str.Sourceproductid = CType(value, string)
												
						Case "Volumeqty"
							Me.str.Volumeqty = CType(value, string)
												
						Case "Volumeuom"
							Me.str.Volumeuom = CType(value, string)
												
						Case "Weightqty"
							Me.str.Weightqty = CType(value, string)
												
						Case "Weightuom"
							Me.str.Weightuom = CType(value, string)
					
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
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Qtyunits = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Sourceproductid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Sourceproductid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Volumeqty"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Volumeqty = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Weightqty"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Weightqty = CType(value, Nullable(Of System.Decimal))
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
		' Maps to APISITEM.APISITEMNUM
		' </summary>
		Public Overridable Property Apisitemnum As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ApisitemMetadata.ColumnNames.Apisitemnum)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ApisitemMetadata.ColumnNames.Apisitemnum, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APISITEM.APISNUM
		' </summary>
		Public Overridable Property Apisnum As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ApisitemMetadata.ColumnNames.Apisnum)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ApisitemMetadata.ColumnNames.Apisnum, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APISITEM.MATERIALID
		' </summary>
		Public Overridable Property Materialid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ApisitemMetadata.ColumnNames.Materialid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ApisitemMetadata.ColumnNames.Materialid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APISITEM.QTYUNITS
		' </summary>
		Public Overridable Property Qtyunits As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ApisitemMetadata.ColumnNames.Qtyunits)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ApisitemMetadata.ColumnNames.Qtyunits, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APISITEM.UOM
		' </summary>
		Public Overridable Property Uom As System.String
			Get
				Return MyBase.GetSystemString(ApisitemMetadata.ColumnNames.Uom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ApisitemMetadata.ColumnNames.Uom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APISITEM.APISITEMNOTE
		' </summary>
		Public Overridable Property Apisitemnote As System.String
			Get
				Return MyBase.GetSystemString(ApisitemMetadata.ColumnNames.Apisitemnote)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ApisitemMetadata.ColumnNames.Apisitemnote, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APISITEM.SOURCEPRODUCTID
		' </summary>
		Public Overridable Property Sourceproductid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ApisitemMetadata.ColumnNames.Sourceproductid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ApisitemMetadata.ColumnNames.Sourceproductid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APISITEM.VOLUMEQTY
		' </summary>
		Public Overridable Property Volumeqty As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ApisitemMetadata.ColumnNames.Volumeqty)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ApisitemMetadata.ColumnNames.Volumeqty, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APISITEM.VOLUMEUOM
		' </summary>
		Public Overridable Property Volumeuom As System.String
			Get
				Return MyBase.GetSystemString(ApisitemMetadata.ColumnNames.Volumeuom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ApisitemMetadata.ColumnNames.Volumeuom, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APISITEM.WEIGHTQTY
		' </summary>
		Public Overridable Property Weightqty As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ApisitemMetadata.ColumnNames.Weightqty)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ApisitemMetadata.ColumnNames.Weightqty, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to APISITEM.WEIGHTUOM
		' </summary>
		Public Overridable Property Weightuom As System.String
			Get
				Return MyBase.GetSystemString(ApisitemMetadata.ColumnNames.Weightuom)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ApisitemMetadata.ColumnNames.Weightuom, value)
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
		
			Public Sub New(ByVal entity As esApisitem)
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
					Dim data_ As Nullable(Of System.Decimal) = entity.Qtyunits
					
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
						entity.Qtyunits = Convert.ToDecimal(Value)
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
		  	
			Public Property Sourceproductid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Sourceproductid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Sourceproductid = Nothing
					Else
						entity.Sourceproductid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Volumeqty As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Volumeqty
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Volumeqty = Nothing
					Else
						entity.Volumeqty = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Volumeuom As System.String 
				Get
					Dim data_ As System.String = entity.Volumeuom
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Volumeuom = Nothing
					Else
						entity.Volumeuom = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Weightqty As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Weightqty
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Weightqty = Nothing
					Else
						entity.Weightqty = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Weightuom As System.String 
				Get
					Dim data_ As System.String = entity.Weightuom
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Weightuom = Nothing
					Else
						entity.Weightuom = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esApisitem
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esApisitemQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esApisitem can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Apisitem 
		Inherits esApisitem
		
	
		
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
	MustInherit Public Class esApisitemQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ApisitemMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Apisitemnum As esQueryItem
			Get
				Return New esQueryItem(Me, ApisitemMetadata.ColumnNames.Apisitemnum, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Apisnum As esQueryItem
			Get
				Return New esQueryItem(Me, ApisitemMetadata.ColumnNames.Apisnum, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Materialid As esQueryItem
			Get
				Return New esQueryItem(Me, ApisitemMetadata.ColumnNames.Materialid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Qtyunits As esQueryItem
			Get
				Return New esQueryItem(Me, ApisitemMetadata.ColumnNames.Qtyunits, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Uom As esQueryItem
			Get
				Return New esQueryItem(Me, ApisitemMetadata.ColumnNames.Uom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Apisitemnote As esQueryItem
			Get
				Return New esQueryItem(Me, ApisitemMetadata.ColumnNames.Apisitemnote, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Sourceproductid As esQueryItem
			Get
				Return New esQueryItem(Me, ApisitemMetadata.ColumnNames.Sourceproductid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Volumeqty As esQueryItem
			Get
				Return New esQueryItem(Me, ApisitemMetadata.ColumnNames.Volumeqty, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Volumeuom As esQueryItem
			Get
				Return New esQueryItem(Me, ApisitemMetadata.ColumnNames.Volumeuom, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Weightqty As esQueryItem
			Get
				Return New esQueryItem(Me, ApisitemMetadata.ColumnNames.Weightqty, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Weightuom As esQueryItem
			Get
				Return New esQueryItem(Me, ApisitemMetadata.ColumnNames.Weightuom, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ApisitemCollection")> _
	Partial Public Class ApisitemCollection
		Inherits esApisitemCollection
		Implements IEnumerable(Of Apisitem)
		
        Public Shared Widening Operator CType(ByVal coll As ApisitemCollection) As List(Of Apisitem)
            Dim list As List(Of Apisitem) = New List(Of Apisitem)
            Dim emp As Apisitem

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ApisitemMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ApisitemQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Apisitem(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Apisitem()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As ApisitemQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ApisitemQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ApisitemQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Apisitem 
			Return CType(MyBase.AddNewEntity(), Apisitem)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal apisitemnum As System.Int32) As Apisitem
			Return CType(MyBase.FindByPrimaryKey(apisitemnum), Apisitem)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Apisitem) Implements IEnumerable(Of Apisitem).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Apisitem)(Me)
        End Function
		
		Private _query As ApisitemQuery

	End Class
	


	' <summary>
	' Encapsulates the 'APISITEM' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Apisitem ({Apisitemnum.Value})")> _
	<Serializable> _
	Partial Public Class Apisitem 
		Inherits esApisitem

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ApisitemMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esApisitemQuery

			If Me._query Is Nothing Then
				Me._query = New ApisitemQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ApisitemQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ApisitemQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ApisitemQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ApisitemQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ApisitemQuery
		inherits esApisitemQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ApisitemQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ApisitemMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ApisitemMetadata.ColumnNames.Apisitemnum, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ApisitemMetadata.PropertyNames.Apisitemnum
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ApisitemMetadata.ColumnNames.Apisnum, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ApisitemMetadata.PropertyNames.Apisnum
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ApisitemMetadata.ColumnNames.Materialid, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ApisitemMetadata.PropertyNames.Materialid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ApisitemMetadata.ColumnNames.Qtyunits, 3, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ApisitemMetadata.PropertyNames.Qtyunits
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ApisitemMetadata.ColumnNames.Uom, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ApisitemMetadata.PropertyNames.Uom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ApisitemMetadata.ColumnNames.Apisitemnote, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ApisitemMetadata.PropertyNames.Apisitemnote
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ApisitemMetadata.ColumnNames.Sourceproductid, 6, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ApisitemMetadata.PropertyNames.Sourceproductid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ApisitemMetadata.ColumnNames.Volumeqty, 7, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ApisitemMetadata.PropertyNames.Volumeqty
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ApisitemMetadata.ColumnNames.Volumeuom, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = ApisitemMetadata.PropertyNames.Volumeuom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ApisitemMetadata.ColumnNames.Weightqty, 9, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ApisitemMetadata.PropertyNames.Weightqty
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ApisitemMetadata.ColumnNames.Weightuom, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ApisitemMetadata.PropertyNames.Weightuom
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ApisitemMetadata
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
			 Public Const Sourceproductid As String = "SOURCEPRODUCTID"
			 Public Const Volumeqty As String = "VOLUMEQTY"
			 Public Const Volumeuom As String = "VOLUMEUOM"
			 Public Const Weightqty As String = "WEIGHTQTY"
			 Public Const Weightuom As String = "WEIGHTUOM"
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
			 Public Const Sourceproductid As String = "Sourceproductid"
			 Public Const Volumeqty As String = "Volumeqty"
			 Public Const Volumeuom As String = "Volumeuom"
			 Public Const Weightqty As String = "Weightqty"
			 Public Const Weightuom As String = "Weightuom"
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
            SyncLock GetType(ApisitemMetadata)
			
				If ApisitemMetadata.mapDelegates Is Nothing Then
					ApisitemMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ApisitemMetadata._meta Is Nothing Then
                    ApisitemMetadata._meta = New ApisitemMetadata()
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
				meta.AddTypeMap("Qtyunits", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Uom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Apisitemnote", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Sourceproductid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Volumeqty", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Volumeuom", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Weightqty", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("Weightuom", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "APISITEM"
				meta.Destination = "APISITEM"
				
				meta.spInsert = "proc_APISITEMInsert"
				meta.spUpdate = "proc_APISITEMUpdate"
				meta.spDelete = "proc_APISITEMDelete"
				meta.spLoadAll = "proc_APISITEMLoadAll"
				meta.spLoadByPrimaryKey = "proc_APISITEMLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ApisitemMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
