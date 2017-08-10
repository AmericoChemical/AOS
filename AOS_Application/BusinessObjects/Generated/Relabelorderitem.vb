'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 4/16/2015 10:12:08 PM
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
	MustInherit Public Class esRelabelorderitemCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "RelabelorderitemCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esRelabelorderitemQuery)
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
            Me.InitQuery(CType(query, esRelabelorderitemQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Relabelorderitem) As Relabelorderitem
			Return CType(MyBase.DetachEntity(entity), Relabelorderitem)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Relabelorderitem) As Relabelorderitem
			Return CType(MyBase.AttachEntity(entity), Relabelorderitem)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As RelabelorderitemCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Relabelorderitem
            Get
                Return TryCast(MyBase.Item(index), Relabelorderitem)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Relabelorderitem)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esRelabelorderitem	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esRelabelorderitemQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal relabelorderitemnumber As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(relabelorderitemnumber)
			Else
				Return LoadByPrimaryKeyStoredProcedure(relabelorderitemnumber)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal relabelorderitemnumber As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(relabelorderitemnumber)
			Else
				Return LoadByPrimaryKeyStoredProcedure(relabelorderitemnumber)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal relabelorderitemnumber As System.Int32) As Boolean
		
			Dim query As esRelabelorderitemQuery = Me.GetDynamicQuery()
			query.Where(query.Relabelorderitemnumber.Equal(relabelorderitemnumber))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal relabelorderitemnumber As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("RELABELORDERITEMNUMBER", relabelorderitemnumber)
			
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
												
						Case "Relabelorderitemnumber"
							Me.str.Relabelorderitemnumber = CType(value, string)
												
						Case "Relabelordernumber"
							Me.str.Relabelordernumber = CType(value, string)
												
						Case "Itemid"
							Me.str.Itemid = CType(value, string)
												
						Case "Invitemnum"
							Me.str.Invitemnum = CType(value, string)
												
						Case "Workorderitemnumber"
							Me.str.Workorderitemnumber = CType(value, string)
												
						Case "Sourcetype"
							Me.str.Sourcetype = CType(value, string)
												
						Case "Sourcedoc"
							Me.str.Sourcedoc = CType(value, string)
												
						Case "Relabelorderitemstatus"
							Me.str.Relabelorderitemstatus = CType(value, string)
												
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
						
						Case "Relabelorderitemnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Relabelorderitemnumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Relabelordernumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Relabelordernumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Itemid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Itemid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Invitemnum"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Invitemnum = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Workorderitemnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Workorderitemnumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Sourcedoc"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Sourcedoc = CType(value, Nullable(Of System.Int32))
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
		' Maps to RELABELORDERITEM.RELABELORDERITEMNUMBER
		' </summary>
		Public Overridable Property Relabelorderitemnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(RelabelorderitemMetadata.ColumnNames.Relabelorderitemnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(RelabelorderitemMetadata.ColumnNames.Relabelorderitemnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RELABELORDERITEM.RELABELORDERNUMBER
		' </summary>
		Public Overridable Property Relabelordernumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(RelabelorderitemMetadata.ColumnNames.Relabelordernumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(RelabelorderitemMetadata.ColumnNames.Relabelordernumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RELABELORDERITEM.ITEMID
		' </summary>
		Public Overridable Property Itemid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(RelabelorderitemMetadata.ColumnNames.Itemid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(RelabelorderitemMetadata.ColumnNames.Itemid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RELABELORDERITEM.INVITEMNUM
		' </summary>
		Public Overridable Property Invitemnum As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(RelabelorderitemMetadata.ColumnNames.Invitemnum)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(RelabelorderitemMetadata.ColumnNames.Invitemnum, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RELABELORDERITEM.WORKORDERITEMNUMBER
		' </summary>
		Public Overridable Property Workorderitemnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(RelabelorderitemMetadata.ColumnNames.Workorderitemnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(RelabelorderitemMetadata.ColumnNames.Workorderitemnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RELABELORDERITEM.SOURCETYPE
		' </summary>
		Public Overridable Property Sourcetype As System.String
			Get
				Return MyBase.GetSystemString(RelabelorderitemMetadata.ColumnNames.Sourcetype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(RelabelorderitemMetadata.ColumnNames.Sourcetype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RELABELORDERITEM.SOURCEDOC
		' </summary>
		Public Overridable Property Sourcedoc As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(RelabelorderitemMetadata.ColumnNames.Sourcedoc)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(RelabelorderitemMetadata.ColumnNames.Sourcedoc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RELABELORDERITEM.RELABELORDERITEMSTATUS
		' </summary>
		Public Overridable Property Relabelorderitemstatus As System.String
			Get
				Return MyBase.GetSystemString(RelabelorderitemMetadata.ColumnNames.Relabelorderitemstatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(RelabelorderitemMetadata.ColumnNames.Relabelorderitemstatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RELABELORDERITEM.CREATEDBY
		' </summary>
		Public Overridable Property Createdby As System.String
			Get
				Return MyBase.GetSystemString(RelabelorderitemMetadata.ColumnNames.Createdby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(RelabelorderitemMetadata.ColumnNames.Createdby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RELABELORDERITEM.CREATEDTIME
		' </summary>
		Public Overridable Property Createdtime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(RelabelorderitemMetadata.ColumnNames.Createdtime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(RelabelorderitemMetadata.ColumnNames.Createdtime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RELABELORDERITEM.MODIFYBY
		' </summary>
		Public Overridable Property Modifyby As System.String
			Get
				Return MyBase.GetSystemString(RelabelorderitemMetadata.ColumnNames.Modifyby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(RelabelorderitemMetadata.ColumnNames.Modifyby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RELABELORDERITEM.MODIFYTIME
		' </summary>
		Public Overridable Property Modifytime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(RelabelorderitemMetadata.ColumnNames.Modifytime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(RelabelorderitemMetadata.ColumnNames.Modifytime, value)
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
		
			Public Sub New(ByVal entity As esRelabelorderitem)
				Me.entity = entity
			End Sub				
		
	
			Public Property Relabelorderitemnumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Relabelorderitemnumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Relabelorderitemnumber = Nothing
					Else
						entity.Relabelorderitemnumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Relabelordernumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Relabelordernumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Relabelordernumber = Nothing
					Else
						entity.Relabelordernumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Itemid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Itemid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Itemid = Nothing
					Else
						entity.Itemid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Invitemnum As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Invitemnum
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Invitemnum = Nothing
					Else
						entity.Invitemnum = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Workorderitemnumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Workorderitemnumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Workorderitemnumber = Nothing
					Else
						entity.Workorderitemnumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Sourcetype As System.String 
				Get
					Dim data_ As System.String = entity.Sourcetype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Sourcetype = Nothing
					Else
						entity.Sourcetype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Sourcedoc As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Sourcedoc
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Sourcedoc = Nothing
					Else
						entity.Sourcedoc = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Relabelorderitemstatus As System.String 
				Get
					Dim data_ As System.String = entity.Relabelorderitemstatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Relabelorderitemstatus = Nothing
					Else
						entity.Relabelorderitemstatus = Convert.ToString(Value)
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
		  

			Private entity As esRelabelorderitem
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esRelabelorderitemQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esRelabelorderitem can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Relabelorderitem 
		Inherits esRelabelorderitem
		
	
		
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
	MustInherit Public Class esRelabelorderitemQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return RelabelorderitemMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Relabelorderitemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, RelabelorderitemMetadata.ColumnNames.Relabelorderitemnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Relabelordernumber As esQueryItem
			Get
				Return New esQueryItem(Me, RelabelorderitemMetadata.ColumnNames.Relabelordernumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Itemid As esQueryItem
			Get
				Return New esQueryItem(Me, RelabelorderitemMetadata.ColumnNames.Itemid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Invitemnum As esQueryItem
			Get
				Return New esQueryItem(Me, RelabelorderitemMetadata.ColumnNames.Invitemnum, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Workorderitemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, RelabelorderitemMetadata.ColumnNames.Workorderitemnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Sourcetype As esQueryItem
			Get
				Return New esQueryItem(Me, RelabelorderitemMetadata.ColumnNames.Sourcetype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Sourcedoc As esQueryItem
			Get
				Return New esQueryItem(Me, RelabelorderitemMetadata.ColumnNames.Sourcedoc, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Relabelorderitemstatus As esQueryItem
			Get
				Return New esQueryItem(Me, RelabelorderitemMetadata.ColumnNames.Relabelorderitemstatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Createdby As esQueryItem
			Get
				Return New esQueryItem(Me, RelabelorderitemMetadata.ColumnNames.Createdby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Createdtime As esQueryItem
			Get
				Return New esQueryItem(Me, RelabelorderitemMetadata.ColumnNames.Createdtime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Modifyby As esQueryItem
			Get
				Return New esQueryItem(Me, RelabelorderitemMetadata.ColumnNames.Modifyby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Modifytime As esQueryItem
			Get
				Return New esQueryItem(Me, RelabelorderitemMetadata.ColumnNames.Modifytime, esSystemType.DateTime)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("RelabelorderitemCollection")> _
	Partial Public Class RelabelorderitemCollection
		Inherits esRelabelorderitemCollection
		Implements IEnumerable(Of Relabelorderitem)
		
        Public Shared Widening Operator CType(ByVal coll As RelabelorderitemCollection) As List(Of Relabelorderitem)
            Dim list As List(Of Relabelorderitem) = New List(Of Relabelorderitem)
            Dim emp As Relabelorderitem

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return RelabelorderitemMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New RelabelorderitemQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Relabelorderitem(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Relabelorderitem()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As RelabelorderitemQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New RelabelorderitemQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As RelabelorderitemQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Relabelorderitem 
			Return CType(MyBase.AddNewEntity(), Relabelorderitem)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal relabelorderitemnumber As System.Int32) As Relabelorderitem
			Return CType(MyBase.FindByPrimaryKey(relabelorderitemnumber), Relabelorderitem)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Relabelorderitem) Implements IEnumerable(Of Relabelorderitem).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Relabelorderitem)(Me)
        End Function
		
		Private _query As RelabelorderitemQuery

	End Class
	


	' <summary>
	' Encapsulates the 'RELABELORDERITEM' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Relabelorderitem ({Relabelorderitemnumber.Value})")> _
	<Serializable> _
	Partial Public Class Relabelorderitem 
		Inherits esRelabelorderitem

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return RelabelorderitemMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esRelabelorderitemQuery

			If Me._query Is Nothing Then
				Me._query = New RelabelorderitemQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As RelabelorderitemQuery
			Get

				If Me._query Is Nothing then
					Me._query = New RelabelorderitemQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As RelabelorderitemQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As RelabelorderitemQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class RelabelorderitemQuery
		inherits esRelabelorderitemQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "RelabelorderitemQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class RelabelorderitemMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(RelabelorderitemMetadata.ColumnNames.Relabelorderitemnumber, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = RelabelorderitemMetadata.PropertyNames.Relabelorderitemnumber
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(RelabelorderitemMetadata.ColumnNames.Relabelordernumber, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = RelabelorderitemMetadata.PropertyNames.Relabelordernumber
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(RelabelorderitemMetadata.ColumnNames.Itemid, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = RelabelorderitemMetadata.PropertyNames.Itemid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(RelabelorderitemMetadata.ColumnNames.Invitemnum, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = RelabelorderitemMetadata.PropertyNames.Invitemnum
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(RelabelorderitemMetadata.ColumnNames.Workorderitemnumber, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = RelabelorderitemMetadata.PropertyNames.Workorderitemnumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(RelabelorderitemMetadata.ColumnNames.Sourcetype, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = RelabelorderitemMetadata.PropertyNames.Sourcetype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(RelabelorderitemMetadata.ColumnNames.Sourcedoc, 6, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = RelabelorderitemMetadata.PropertyNames.Sourcedoc
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(RelabelorderitemMetadata.ColumnNames.Relabelorderitemstatus, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = RelabelorderitemMetadata.PropertyNames.Relabelorderitemstatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(RelabelorderitemMetadata.ColumnNames.Createdby, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = RelabelorderitemMetadata.PropertyNames.Createdby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(RelabelorderitemMetadata.ColumnNames.Createdtime, 9, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = RelabelorderitemMetadata.PropertyNames.Createdtime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(RelabelorderitemMetadata.ColumnNames.Modifyby, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = RelabelorderitemMetadata.PropertyNames.Modifyby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(RelabelorderitemMetadata.ColumnNames.Modifytime, 11, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = RelabelorderitemMetadata.PropertyNames.Modifytime
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As RelabelorderitemMetadata
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
			 Public Const Relabelorderitemnumber As String = "RELABELORDERITEMNUMBER"
			 Public Const Relabelordernumber As String = "RELABELORDERNUMBER"
			 Public Const Itemid As String = "ITEMID"
			 Public Const Invitemnum As String = "INVITEMNUM"
			 Public Const Workorderitemnumber As String = "WORKORDERITEMNUMBER"
			 Public Const Sourcetype As String = "SOURCETYPE"
			 Public Const Sourcedoc As String = "SOURCEDOC"
			 Public Const Relabelorderitemstatus As String = "RELABELORDERITEMSTATUS"
			 Public Const Createdby As String = "CREATEDBY"
			 Public Const Createdtime As String = "CREATEDTIME"
			 Public Const Modifyby As String = "MODIFYBY"
			 Public Const Modifytime As String = "MODIFYTIME"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Relabelorderitemnumber As String = "Relabelorderitemnumber"
			 Public Const Relabelordernumber As String = "Relabelordernumber"
			 Public Const Itemid As String = "Itemid"
			 Public Const Invitemnum As String = "Invitemnum"
			 Public Const Workorderitemnumber As String = "Workorderitemnumber"
			 Public Const Sourcetype As String = "Sourcetype"
			 Public Const Sourcedoc As String = "Sourcedoc"
			 Public Const Relabelorderitemstatus As String = "Relabelorderitemstatus"
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
            SyncLock GetType(RelabelorderitemMetadata)
			
				If RelabelorderitemMetadata.mapDelegates Is Nothing Then
					RelabelorderitemMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If RelabelorderitemMetadata._meta Is Nothing Then
                    RelabelorderitemMetadata._meta = New RelabelorderitemMetadata()
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
				

				meta.AddTypeMap("Relabelorderitemnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Relabelordernumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Itemid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Invitemnum", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Workorderitemnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Sourcetype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Sourcedoc", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Relabelorderitemstatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Createdby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Createdtime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Modifyby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Modifytime", new esTypeMap("datetime", "System.DateTime"))			
				
				
				 
				meta.Source = "RELABELORDERITEM"
				meta.Destination = "RELABELORDERITEM"
				
				meta.spInsert = "proc_RELABELORDERITEMInsert"
				meta.spUpdate = "proc_RELABELORDERITEMUpdate"
				meta.spDelete = "proc_RELABELORDERITEMDelete"
				meta.spLoadAll = "proc_RELABELORDERITEMLoadAll"
				meta.spLoadByPrimaryKey = "proc_RELABELORDERITEMLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As RelabelorderitemMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
