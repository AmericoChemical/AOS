'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/3/2015 6:57:57 PM
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
	MustInherit Public Class esInvphysCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "InvphysCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esInvphysQuery)
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
            Me.InitQuery(CType(query, esInvphysQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Invphys) As Invphys
			Return CType(MyBase.DetachEntity(entity), Invphys)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Invphys) As Invphys
			Return CType(MyBase.AttachEntity(entity), Invphys)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As InvphysCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Invphys
            Get
                Return TryCast(MyBase.Item(index), Invphys)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Invphys)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esInvphys	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esInvphysQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal pHYSINVKey As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(pHYSINVKey)
			Else
				Return LoadByPrimaryKeyStoredProcedure(pHYSINVKey)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal pHYSINVKey As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(pHYSINVKey)
			Else
				Return LoadByPrimaryKeyStoredProcedure(pHYSINVKey)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal pHYSINVKey As System.Int32) As Boolean
		
			Dim query As esInvphysQuery = Me.GetDynamicQuery()
			query.Where(query.PHYSINVKey.Equal(pHYSINVKey))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal pHYSINVKey As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("PHYSINVKey", pHYSINVKey)
			
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
												
						Case "PHYSINVKey"
							Me.str.PHYSINVKey = CType(value, string)
												
						Case "Txtime"
							Me.str.Txtime = CType(value, string)
												
						Case "Txwho"
							Me.str.Txwho = CType(value, string)
												
						Case "Invitemnumber"
							Me.str.Invitemnumber = CType(value, string)
												
						Case "Unitsentered"
							Me.str.Unitsentered = CType(value, string)
												
						Case "Unitsoriginal"
							Me.str.Unitsoriginal = CType(value, string)
												
						Case "Txtype"
							Me.str.Txtype = CType(value, string)
												
						Case "Txreason"
							Me.str.Txreason = CType(value, string)
												
						Case "Itemstatus"
							Me.str.Itemstatus = CType(value, string)
												
						Case "Sourcedocument"
							Me.str.Sourcedocument = CType(value, string)
												
						Case "Sourcetype"
							Me.str.Sourcetype = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "PHYSINVKey"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.PHYSINVKey = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Txtime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Txtime = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Invitemnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Invitemnumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Unitsentered"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Unitsentered = CType(value, Nullable(Of System.Double))
							End If
						
						Case "Unitsoriginal"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Double" Then
								Me.Unitsoriginal = CType(value, Nullable(Of System.Double))
							End If
						
						Case "Sourcedocument"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Sourcedocument = CType(value, Nullable(Of System.Int32))
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
		' Maps to INVPHYS.PHYSINVKey
		' </summary>
		Public Overridable Property PHYSINVKey As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(InvphysMetadata.ColumnNames.PHYSINVKey)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(InvphysMetadata.ColumnNames.PHYSINVKey, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVPHYS.TXTIME
		' </summary>
		Public Overridable Property Txtime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(InvphysMetadata.ColumnNames.Txtime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(InvphysMetadata.ColumnNames.Txtime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVPHYS.TXWHO
		' </summary>
		Public Overridable Property Txwho As System.String
			Get
				Return MyBase.GetSystemString(InvphysMetadata.ColumnNames.Txwho)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(InvphysMetadata.ColumnNames.Txwho, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVPHYS.INVITEMNUMBER
		' </summary>
		Public Overridable Property Invitemnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(InvphysMetadata.ColumnNames.Invitemnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(InvphysMetadata.ColumnNames.Invitemnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVPHYS.UNITSENTERED
		' </summary>
		Public Overridable Property Unitsentered As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(InvphysMetadata.ColumnNames.Unitsentered)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(InvphysMetadata.ColumnNames.Unitsentered, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVPHYS.UNITSORIGINAL
		' </summary>
		Public Overridable Property Unitsoriginal As Nullable(Of System.Double)
			Get
				Return MyBase.GetSystemDouble(InvphysMetadata.ColumnNames.Unitsoriginal)
			End Get
			
			Set(ByVal value As Nullable(Of System.Double))
				MyBase.SetSystemDouble(InvphysMetadata.ColumnNames.Unitsoriginal, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVPHYS.TXTYPE
		' </summary>
		Public Overridable Property Txtype As System.String
			Get
				Return MyBase.GetSystemString(InvphysMetadata.ColumnNames.Txtype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(InvphysMetadata.ColumnNames.Txtype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVPHYS.TXREASON
		' </summary>
		Public Overridable Property Txreason As System.String
			Get
				Return MyBase.GetSystemString(InvphysMetadata.ColumnNames.Txreason)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(InvphysMetadata.ColumnNames.Txreason, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVPHYS.ITEMSTATUS
		' </summary>
		Public Overridable Property Itemstatus As System.String
			Get
				Return MyBase.GetSystemString(InvphysMetadata.ColumnNames.Itemstatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(InvphysMetadata.ColumnNames.Itemstatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVPHYS.SOURCEDOCUMENT
		' </summary>
		Public Overridable Property Sourcedocument As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(InvphysMetadata.ColumnNames.Sourcedocument)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(InvphysMetadata.ColumnNames.Sourcedocument, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to INVPHYS.SOURCETYPE
		' </summary>
		Public Overridable Property Sourcetype As System.String
			Get
				Return MyBase.GetSystemString(InvphysMetadata.ColumnNames.Sourcetype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(InvphysMetadata.ColumnNames.Sourcetype, value)
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
		
			Public Sub New(ByVal entity As esInvphys)
				Me.entity = entity
			End Sub				
		
	
			Public Property PHYSINVKey As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.PHYSINVKey
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.PHYSINVKey = Nothing
					Else
						entity.PHYSINVKey = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Txtime As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Txtime
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Txtime = Nothing
					Else
						entity.Txtime = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Txwho As System.String 
				Get
					Dim data_ As System.String = entity.Txwho
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Txwho = Nothing
					Else
						entity.Txwho = Convert.ToString(Value)
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
		  	
			Public Property Unitsentered As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Unitsentered
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Unitsentered = Nothing
					Else
						entity.Unitsentered = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property Unitsoriginal As System.String 
				Get
					Dim data_ As Nullable(Of System.Double) = entity.Unitsoriginal
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Unitsoriginal = Nothing
					Else
						entity.Unitsoriginal = Convert.ToDouble(Value)
					End If
				End Set
			End Property
		  	
			Public Property Txtype As System.String 
				Get
					Dim data_ As System.String = entity.Txtype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Txtype = Nothing
					Else
						entity.Txtype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Txreason As System.String 
				Get
					Dim data_ As System.String = entity.Txreason
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Txreason = Nothing
					Else
						entity.Txreason = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Itemstatus As System.String 
				Get
					Dim data_ As System.String = entity.Itemstatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Itemstatus = Nothing
					Else
						entity.Itemstatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Sourcedocument As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Sourcedocument
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Sourcedocument = Nothing
					Else
						entity.Sourcedocument = Convert.ToInt32(Value)
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
		  

			Private entity As esInvphys
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esInvphysQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esInvphys can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Invphys 
		Inherits esInvphys
		
	
		
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
	MustInherit Public Class esInvphysQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return InvphysMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property PHYSINVKey As esQueryItem
			Get
				Return New esQueryItem(Me, InvphysMetadata.ColumnNames.PHYSINVKey, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Txtime As esQueryItem
			Get
				Return New esQueryItem(Me, InvphysMetadata.ColumnNames.Txtime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Txwho As esQueryItem
			Get
				Return New esQueryItem(Me, InvphysMetadata.ColumnNames.Txwho, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Invitemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, InvphysMetadata.ColumnNames.Invitemnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Unitsentered As esQueryItem
			Get
				Return New esQueryItem(Me, InvphysMetadata.ColumnNames.Unitsentered, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Unitsoriginal As esQueryItem
			Get
				Return New esQueryItem(Me, InvphysMetadata.ColumnNames.Unitsoriginal, esSystemType.Double)
			End Get
		End Property 
		
		Public ReadOnly Property Txtype As esQueryItem
			Get
				Return New esQueryItem(Me, InvphysMetadata.ColumnNames.Txtype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Txreason As esQueryItem
			Get
				Return New esQueryItem(Me, InvphysMetadata.ColumnNames.Txreason, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Itemstatus As esQueryItem
			Get
				Return New esQueryItem(Me, InvphysMetadata.ColumnNames.Itemstatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Sourcedocument As esQueryItem
			Get
				Return New esQueryItem(Me, InvphysMetadata.ColumnNames.Sourcedocument, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Sourcetype As esQueryItem
			Get
				Return New esQueryItem(Me, InvphysMetadata.ColumnNames.Sourcetype, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("InvphysCollection")> _
	Partial Public Class InvphysCollection
		Inherits esInvphysCollection
		Implements IEnumerable(Of Invphys)
		
        Public Shared Widening Operator CType(ByVal coll As InvphysCollection) As List(Of Invphys)
            Dim list As List(Of Invphys) = New List(Of Invphys)
            Dim emp As Invphys

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return InvphysMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New InvphysQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Invphys(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Invphys()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As InvphysQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New InvphysQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As InvphysQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Invphys 
			Return CType(MyBase.AddNewEntity(), Invphys)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal pHYSINVKey As System.Int32) As Invphys
			Return CType(MyBase.FindByPrimaryKey(pHYSINVKey), Invphys)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Invphys) Implements IEnumerable(Of Invphys).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Invphys)(Me)
        End Function
		
		Private _query As InvphysQuery

	End Class
	


	' <summary>
	' Encapsulates the 'INVPHYS' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Invphys ({PHYSINVKey.Value})")> _
	<Serializable> _
	Partial Public Class Invphys 
		Inherits esInvphys

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return InvphysMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esInvphysQuery

			If Me._query Is Nothing Then
				Me._query = New InvphysQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As InvphysQuery
			Get

				If Me._query Is Nothing then
					Me._query = New InvphysQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As InvphysQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As InvphysQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class InvphysQuery
		inherits esInvphysQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "InvphysQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class InvphysMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(InvphysMetadata.ColumnNames.PHYSINVKey, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = InvphysMetadata.PropertyNames.PHYSINVKey
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(InvphysMetadata.ColumnNames.Txtime, 1, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = InvphysMetadata.PropertyNames.Txtime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvphysMetadata.ColumnNames.Txwho, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = InvphysMetadata.PropertyNames.Txwho
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvphysMetadata.ColumnNames.Invitemnumber, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = InvphysMetadata.PropertyNames.Invitemnumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvphysMetadata.ColumnNames.Unitsentered, 4, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = InvphysMetadata.PropertyNames.Unitsentered
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvphysMetadata.ColumnNames.Unitsoriginal, 5, GetType(System.Double), esSystemType.Double)	
			c.PropertyName = InvphysMetadata.PropertyNames.Unitsoriginal
			c.NumericPrecision = 15
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvphysMetadata.ColumnNames.Txtype, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = InvphysMetadata.PropertyNames.Txtype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvphysMetadata.ColumnNames.Txreason, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = InvphysMetadata.PropertyNames.Txreason
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvphysMetadata.ColumnNames.Itemstatus, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = InvphysMetadata.PropertyNames.Itemstatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvphysMetadata.ColumnNames.Sourcedocument, 9, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = InvphysMetadata.PropertyNames.Sourcedocument
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(InvphysMetadata.ColumnNames.Sourcetype, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = InvphysMetadata.PropertyNames.Sourcetype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As InvphysMetadata
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
			 Public Const PHYSINVKey As String = "PHYSINVKey"
			 Public Const Txtime As String = "TXTIME"
			 Public Const Txwho As String = "TXWHO"
			 Public Const Invitemnumber As String = "INVITEMNUMBER"
			 Public Const Unitsentered As String = "UNITSENTERED"
			 Public Const Unitsoriginal As String = "UNITSORIGINAL"
			 Public Const Txtype As String = "TXTYPE"
			 Public Const Txreason As String = "TXREASON"
			 Public Const Itemstatus As String = "ITEMSTATUS"
			 Public Const Sourcedocument As String = "SOURCEDOCUMENT"
			 Public Const Sourcetype As String = "SOURCETYPE"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const PHYSINVKey As String = "PHYSINVKey"
			 Public Const Txtime As String = "Txtime"
			 Public Const Txwho As String = "Txwho"
			 Public Const Invitemnumber As String = "Invitemnumber"
			 Public Const Unitsentered As String = "Unitsentered"
			 Public Const Unitsoriginal As String = "Unitsoriginal"
			 Public Const Txtype As String = "Txtype"
			 Public Const Txreason As String = "Txreason"
			 Public Const Itemstatus As String = "Itemstatus"
			 Public Const Sourcedocument As String = "Sourcedocument"
			 Public Const Sourcetype As String = "Sourcetype"
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
            SyncLock GetType(InvphysMetadata)
			
				If InvphysMetadata.mapDelegates Is Nothing Then
					InvphysMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If InvphysMetadata._meta Is Nothing Then
                    InvphysMetadata._meta = New InvphysMetadata()
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
				

				meta.AddTypeMap("PHYSINVKey", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Txtime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Txwho", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Invitemnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Unitsentered", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Unitsoriginal", new esTypeMap("float", "System.Double"))
				meta.AddTypeMap("Txtype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Txreason", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Itemstatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Sourcedocument", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Sourcetype", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "INVPHYS"
				meta.Destination = "INVPHYS"
				
				meta.spInsert = "proc_INVPHYSInsert"
				meta.spUpdate = "proc_INVPHYSUpdate"
				meta.spDelete = "proc_INVPHYSDelete"
				meta.spLoadAll = "proc_INVPHYSLoadAll"
				meta.spLoadByPrimaryKey = "proc_INVPHYSLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As InvphysMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
