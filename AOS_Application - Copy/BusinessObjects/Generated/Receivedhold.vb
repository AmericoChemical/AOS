'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/1/2016 3:59:18 PM
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
	MustInherit Public Class esReceivedholdCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ReceivedholdCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esReceivedholdQuery)
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
            Me.InitQuery(CType(query, esReceivedholdQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Receivedhold) As Receivedhold
			Return CType(MyBase.DetachEntity(entity), Receivedhold)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Receivedhold) As Receivedhold
			Return CType(MyBase.AttachEntity(entity), Receivedhold)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ReceivedholdCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Receivedhold
            Get
                Return TryCast(MyBase.Item(index), Receivedhold)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Receivedhold)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esReceivedhold	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esReceivedholdQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal recvholdid As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(recvholdid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(recvholdid)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal recvholdid As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(recvholdid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(recvholdid)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal recvholdid As System.Int32) As Boolean
		
			Dim query As esReceivedholdQuery = Me.GetDynamicQuery()
			query.Where(query.Recvholdid.Equal(recvholdid))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal recvholdid As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("RECVHOLDID", recvholdid)
			
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
												
						Case "Recvholdid"
							Me.str.Recvholdid = CType(value, string)
												
						Case "Invitemnumber"
							Me.str.Invitemnumber = CType(value, string)
												
						Case "Prioritemstatus"
							Me.str.Prioritemstatus = CType(value, string)
												
						Case "Reasoncode"
							Me.str.Reasoncode = CType(value, string)
												
						Case "Reasontext"
							Me.str.Reasontext = CType(value, string)
												
						Case "Resolutioncode"
							Me.str.Resolutioncode = CType(value, string)
												
						Case "Resolutiontext"
							Me.str.Resolutiontext = CType(value, string)
												
						Case "Holdtime"
							Me.str.Holdtime = CType(value, string)
												
						Case "Holdrelease"
							Me.str.Holdrelease = CType(value, string)
												
						Case "Whoreleased"
							Me.str.Whoreleased = CType(value, string)
												
						Case "Eventid"
							Me.str.Eventid = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Recvholdid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Recvholdid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Invitemnumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Invitemnumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Holdtime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Holdtime = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Holdrelease"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Holdrelease = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Eventid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Eventid = CType(value, Nullable(Of System.Int32))
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
		' Maps to RECEIVEDHOLD.RECVHOLDID
		' </summary>
		Public Overridable Property Recvholdid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ReceivedholdMetadata.ColumnNames.Recvholdid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ReceivedholdMetadata.ColumnNames.Recvholdid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RECEIVEDHOLD.INVITEMNUMBER
		' </summary>
		Public Overridable Property Invitemnumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ReceivedholdMetadata.ColumnNames.Invitemnumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ReceivedholdMetadata.ColumnNames.Invitemnumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RECEIVEDHOLD.PRIORITEMSTATUS
		' </summary>
		Public Overridable Property Prioritemstatus As System.String
			Get
				Return MyBase.GetSystemString(ReceivedholdMetadata.ColumnNames.Prioritemstatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ReceivedholdMetadata.ColumnNames.Prioritemstatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RECEIVEDHOLD.REASONCODE
		' </summary>
		Public Overridable Property Reasoncode As System.String
			Get
				Return MyBase.GetSystemString(ReceivedholdMetadata.ColumnNames.Reasoncode)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ReceivedholdMetadata.ColumnNames.Reasoncode, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RECEIVEDHOLD.REASONTEXT
		' </summary>
		Public Overridable Property Reasontext As System.String
			Get
				Return MyBase.GetSystemString(ReceivedholdMetadata.ColumnNames.Reasontext)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ReceivedholdMetadata.ColumnNames.Reasontext, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RECEIVEDHOLD.RESOLUTIONCODE
		' </summary>
		Public Overridable Property Resolutioncode As System.String
			Get
				Return MyBase.GetSystemString(ReceivedholdMetadata.ColumnNames.Resolutioncode)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ReceivedholdMetadata.ColumnNames.Resolutioncode, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RECEIVEDHOLD.RESOLUTIONTEXT
		' </summary>
		Public Overridable Property Resolutiontext As System.String
			Get
				Return MyBase.GetSystemString(ReceivedholdMetadata.ColumnNames.Resolutiontext)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ReceivedholdMetadata.ColumnNames.Resolutiontext, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RECEIVEDHOLD.HOLDTIME
		' </summary>
		Public Overridable Property Holdtime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ReceivedholdMetadata.ColumnNames.Holdtime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ReceivedholdMetadata.ColumnNames.Holdtime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RECEIVEDHOLD.HOLDRELEASE
		' </summary>
		Public Overridable Property Holdrelease As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ReceivedholdMetadata.ColumnNames.Holdrelease)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ReceivedholdMetadata.ColumnNames.Holdrelease, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RECEIVEDHOLD.WHORELEASED
		' </summary>
		Public Overridable Property Whoreleased As System.String
			Get
				Return MyBase.GetSystemString(ReceivedholdMetadata.ColumnNames.Whoreleased)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ReceivedholdMetadata.ColumnNames.Whoreleased, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RECEIVEDHOLD.EVENTID
		' </summary>
		Public Overridable Property Eventid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ReceivedholdMetadata.ColumnNames.Eventid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ReceivedholdMetadata.ColumnNames.Eventid, value)
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
		
			Public Sub New(ByVal entity As esReceivedhold)
				Me.entity = entity
			End Sub				
		
	
			Public Property Recvholdid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Recvholdid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Recvholdid = Nothing
					Else
						entity.Recvholdid = Convert.ToInt32(Value)
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
		  	
			Public Property Prioritemstatus As System.String 
				Get
					Dim data_ As System.String = entity.Prioritemstatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Prioritemstatus = Nothing
					Else
						entity.Prioritemstatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Reasoncode As System.String 
				Get
					Dim data_ As System.String = entity.Reasoncode
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Reasoncode = Nothing
					Else
						entity.Reasoncode = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Reasontext As System.String 
				Get
					Dim data_ As System.String = entity.Reasontext
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Reasontext = Nothing
					Else
						entity.Reasontext = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Resolutioncode As System.String 
				Get
					Dim data_ As System.String = entity.Resolutioncode
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Resolutioncode = Nothing
					Else
						entity.Resolutioncode = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Resolutiontext As System.String 
				Get
					Dim data_ As System.String = entity.Resolutiontext
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Resolutiontext = Nothing
					Else
						entity.Resolutiontext = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Holdtime As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Holdtime
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Holdtime = Nothing
					Else
						entity.Holdtime = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Holdrelease As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Holdrelease
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Holdrelease = Nothing
					Else
						entity.Holdrelease = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Whoreleased As System.String 
				Get
					Dim data_ As System.String = entity.Whoreleased
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Whoreleased = Nothing
					Else
						entity.Whoreleased = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Eventid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Eventid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Eventid = Nothing
					Else
						entity.Eventid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esReceivedhold
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esReceivedholdQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esReceivedhold can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Receivedhold 
		Inherits esReceivedhold
		
	
		
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
	MustInherit Public Class esReceivedholdQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ReceivedholdMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Recvholdid As esQueryItem
			Get
				Return New esQueryItem(Me, ReceivedholdMetadata.ColumnNames.Recvholdid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Invitemnumber As esQueryItem
			Get
				Return New esQueryItem(Me, ReceivedholdMetadata.ColumnNames.Invitemnumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Prioritemstatus As esQueryItem
			Get
				Return New esQueryItem(Me, ReceivedholdMetadata.ColumnNames.Prioritemstatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Reasoncode As esQueryItem
			Get
				Return New esQueryItem(Me, ReceivedholdMetadata.ColumnNames.Reasoncode, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Reasontext As esQueryItem
			Get
				Return New esQueryItem(Me, ReceivedholdMetadata.ColumnNames.Reasontext, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Resolutioncode As esQueryItem
			Get
				Return New esQueryItem(Me, ReceivedholdMetadata.ColumnNames.Resolutioncode, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Resolutiontext As esQueryItem
			Get
				Return New esQueryItem(Me, ReceivedholdMetadata.ColumnNames.Resolutiontext, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Holdtime As esQueryItem
			Get
				Return New esQueryItem(Me, ReceivedholdMetadata.ColumnNames.Holdtime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Holdrelease As esQueryItem
			Get
				Return New esQueryItem(Me, ReceivedholdMetadata.ColumnNames.Holdrelease, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Whoreleased As esQueryItem
			Get
				Return New esQueryItem(Me, ReceivedholdMetadata.ColumnNames.Whoreleased, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Eventid As esQueryItem
			Get
				Return New esQueryItem(Me, ReceivedholdMetadata.ColumnNames.Eventid, esSystemType.Int32)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ReceivedholdCollection")> _
	Partial Public Class ReceivedholdCollection
		Inherits esReceivedholdCollection
		Implements IEnumerable(Of Receivedhold)
		
        Public Shared Widening Operator CType(ByVal coll As ReceivedholdCollection) As List(Of Receivedhold)
            Dim list As List(Of Receivedhold) = New List(Of Receivedhold)
            Dim emp As Receivedhold

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ReceivedholdMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ReceivedholdQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Receivedhold(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Receivedhold()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As ReceivedholdQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ReceivedholdQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ReceivedholdQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Receivedhold 
			Return CType(MyBase.AddNewEntity(), Receivedhold)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal recvholdid As System.Int32) As Receivedhold
			Return CType(MyBase.FindByPrimaryKey(recvholdid), Receivedhold)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Receivedhold) Implements IEnumerable(Of Receivedhold).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Receivedhold)(Me)
        End Function
		
		Private _query As ReceivedholdQuery

	End Class
	


	' <summary>
	' Encapsulates the 'RECEIVEDHOLD' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Receivedhold ({Recvholdid.Value})")> _
	<Serializable> _
	Partial Public Class Receivedhold 
		Inherits esReceivedhold

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ReceivedholdMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esReceivedholdQuery

			If Me._query Is Nothing Then
				Me._query = New ReceivedholdQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ReceivedholdQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ReceivedholdQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ReceivedholdQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ReceivedholdQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ReceivedholdQuery
		inherits esReceivedholdQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ReceivedholdQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ReceivedholdMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ReceivedholdMetadata.ColumnNames.Recvholdid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ReceivedholdMetadata.PropertyNames.Recvholdid
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ReceivedholdMetadata.ColumnNames.Invitemnumber, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ReceivedholdMetadata.PropertyNames.Invitemnumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ReceivedholdMetadata.ColumnNames.Prioritemstatus, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ReceivedholdMetadata.PropertyNames.Prioritemstatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ReceivedholdMetadata.ColumnNames.Reasoncode, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ReceivedholdMetadata.PropertyNames.Reasoncode
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ReceivedholdMetadata.ColumnNames.Reasontext, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ReceivedholdMetadata.PropertyNames.Reasontext
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ReceivedholdMetadata.ColumnNames.Resolutioncode, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ReceivedholdMetadata.PropertyNames.Resolutioncode
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ReceivedholdMetadata.ColumnNames.Resolutiontext, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ReceivedholdMetadata.PropertyNames.Resolutiontext
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ReceivedholdMetadata.ColumnNames.Holdtime, 7, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ReceivedholdMetadata.PropertyNames.Holdtime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ReceivedholdMetadata.ColumnNames.Holdrelease, 8, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ReceivedholdMetadata.PropertyNames.Holdrelease
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ReceivedholdMetadata.ColumnNames.Whoreleased, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ReceivedholdMetadata.PropertyNames.Whoreleased
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ReceivedholdMetadata.ColumnNames.Eventid, 10, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ReceivedholdMetadata.PropertyNames.Eventid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ReceivedholdMetadata
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
			 Public Const Recvholdid As String = "RECVHOLDID"
			 Public Const Invitemnumber As String = "INVITEMNUMBER"
			 Public Const Prioritemstatus As String = "PRIORITEMSTATUS"
			 Public Const Reasoncode As String = "REASONCODE"
			 Public Const Reasontext As String = "REASONTEXT"
			 Public Const Resolutioncode As String = "RESOLUTIONCODE"
			 Public Const Resolutiontext As String = "RESOLUTIONTEXT"
			 Public Const Holdtime As String = "HOLDTIME"
			 Public Const Holdrelease As String = "HOLDRELEASE"
			 Public Const Whoreleased As String = "WHORELEASED"
			 Public Const Eventid As String = "EVENTID"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Recvholdid As String = "Recvholdid"
			 Public Const Invitemnumber As String = "Invitemnumber"
			 Public Const Prioritemstatus As String = "Prioritemstatus"
			 Public Const Reasoncode As String = "Reasoncode"
			 Public Const Reasontext As String = "Reasontext"
			 Public Const Resolutioncode As String = "Resolutioncode"
			 Public Const Resolutiontext As String = "Resolutiontext"
			 Public Const Holdtime As String = "Holdtime"
			 Public Const Holdrelease As String = "Holdrelease"
			 Public Const Whoreleased As String = "Whoreleased"
			 Public Const Eventid As String = "Eventid"
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
            SyncLock GetType(ReceivedholdMetadata)
			
				If ReceivedholdMetadata.mapDelegates Is Nothing Then
					ReceivedholdMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ReceivedholdMetadata._meta Is Nothing Then
                    ReceivedholdMetadata._meta = New ReceivedholdMetadata()
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
				

				meta.AddTypeMap("Recvholdid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Invitemnumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Prioritemstatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Reasoncode", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Reasontext", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Resolutioncode", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Resolutiontext", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Holdtime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Holdrelease", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Whoreleased", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Eventid", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "RECEIVEDHOLD"
				meta.Destination = "RECEIVEDHOLD"
				
				meta.spInsert = "proc_RECEIVEDHOLDInsert"
				meta.spUpdate = "proc_RECEIVEDHOLDUpdate"
				meta.spDelete = "proc_RECEIVEDHOLDDelete"
				meta.spLoadAll = "proc_RECEIVEDHOLDLoadAll"
				meta.spLoadByPrimaryKey = "proc_RECEIVEDHOLDLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ReceivedholdMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
