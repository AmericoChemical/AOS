'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 7/25/2017 8:28:39 AM
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
	MustInherit Public Class esChangerecordCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ChangerecordCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esChangerecordQuery)
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
            Me.InitQuery(CType(query, esChangerecordQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Changerecord) As Changerecord
			Return CType(MyBase.DetachEntity(entity), Changerecord)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Changerecord) As Changerecord
			Return CType(MyBase.AttachEntity(entity), Changerecord)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ChangerecordCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Changerecord
            Get
                Return TryCast(MyBase.Item(index), Changerecord)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Changerecord)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esChangerecord	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esChangerecordQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal changerecid As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(changerecid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(changerecid)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal changerecid As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(changerecid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(changerecid)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal changerecid As System.Int32) As Boolean
		
			Dim query As esChangerecordQuery = Me.GetDynamicQuery()
			query.Where(query.Changerecid.Equal(changerecid))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal changerecid As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("CHANGERECID", changerecid)
			
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
												
						Case "Changerecid"
							Me.str.Changerecid = CType(value, string)
												
						Case "Whatchanged"
							Me.str.Whatchanged = CType(value, string)
												
						Case "Whochanged"
							Me.str.Whochanged = CType(value, string)
												
						Case "Whenchanged"
							Me.str.Whenchanged = CType(value, string)
												
						Case "Whychanged"
							Me.str.Whychanged = CType(value, string)
												
						Case "Priorvalue1"
							Me.str.Priorvalue1 = CType(value, string)
												
						Case "Changetype"
							Me.str.Changetype = CType(value, string)
												
						Case "Datatablename"
							Me.str.Datatablename = CType(value, string)
												
						Case "Datarecordid"
							Me.str.Datarecordid = CType(value, string)
												
						Case "Priorvalue1name"
							Me.str.Priorvalue1name = CType(value, string)
												
						Case "Priorvalue2"
							Me.str.Priorvalue2 = CType(value, string)
												
						Case "Priorvalue2name"
							Me.str.Priorvalue2name = CType(value, string)
												
						Case "Priorvalue3"
							Me.str.Priorvalue3 = CType(value, string)
												
						Case "Priorvalue3name"
							Me.str.Priorvalue3name = CType(value, string)
												
						Case "Newvalue1"
							Me.str.Newvalue1 = CType(value, string)
												
						Case "Newvalue2"
							Me.str.Newvalue2 = CType(value, string)
												
						Case "Newvalue3"
							Me.str.Newvalue3 = CType(value, string)
												
						Case "Recordstatus"
							Me.str.Recordstatus = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Changerecid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Changerecid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Whenchanged"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Whenchanged = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Datarecordid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Datarecordid = CType(value, Nullable(Of System.Int32))
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
		' Maps to CHANGERECORD.CHANGERECID
		' </summary>
		Public Overridable Property Changerecid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ChangerecordMetadata.ColumnNames.Changerecid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ChangerecordMetadata.ColumnNames.Changerecid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHANGERECORD.WHATCHANGED
		' </summary>
		Public Overridable Property Whatchanged As System.String
			Get
				Return MyBase.GetSystemString(ChangerecordMetadata.ColumnNames.Whatchanged)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ChangerecordMetadata.ColumnNames.Whatchanged, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHANGERECORD.WHOCHANGED
		' </summary>
		Public Overridable Property Whochanged As System.String
			Get
				Return MyBase.GetSystemString(ChangerecordMetadata.ColumnNames.Whochanged)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ChangerecordMetadata.ColumnNames.Whochanged, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHANGERECORD.WHENCHANGED
		' </summary>
		Public Overridable Property Whenchanged As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ChangerecordMetadata.ColumnNames.Whenchanged)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ChangerecordMetadata.ColumnNames.Whenchanged, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHANGERECORD.WHYCHANGED
		' </summary>
		Public Overridable Property Whychanged As System.String
			Get
				Return MyBase.GetSystemString(ChangerecordMetadata.ColumnNames.Whychanged)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ChangerecordMetadata.ColumnNames.Whychanged, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHANGERECORD.PRIORVALUE1
		' </summary>
		Public Overridable Property Priorvalue1 As System.String
			Get
				Return MyBase.GetSystemString(ChangerecordMetadata.ColumnNames.Priorvalue1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ChangerecordMetadata.ColumnNames.Priorvalue1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHANGERECORD.CHANGETYPE
		' </summary>
		Public Overridable Property Changetype As System.String
			Get
				Return MyBase.GetSystemString(ChangerecordMetadata.ColumnNames.Changetype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ChangerecordMetadata.ColumnNames.Changetype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHANGERECORD.DATATABLENAME
		' </summary>
		Public Overridable Property Datatablename As System.String
			Get
				Return MyBase.GetSystemString(ChangerecordMetadata.ColumnNames.Datatablename)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ChangerecordMetadata.ColumnNames.Datatablename, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHANGERECORD.DATARECORDID
		' </summary>
		Public Overridable Property Datarecordid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ChangerecordMetadata.ColumnNames.Datarecordid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ChangerecordMetadata.ColumnNames.Datarecordid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHANGERECORD.PRIORVALUE1NAME
		' </summary>
		Public Overridable Property Priorvalue1name As System.String
			Get
				Return MyBase.GetSystemString(ChangerecordMetadata.ColumnNames.Priorvalue1name)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ChangerecordMetadata.ColumnNames.Priorvalue1name, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHANGERECORD.PRIORVALUE2
		' </summary>
		Public Overridable Property Priorvalue2 As System.String
			Get
				Return MyBase.GetSystemString(ChangerecordMetadata.ColumnNames.Priorvalue2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ChangerecordMetadata.ColumnNames.Priorvalue2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHANGERECORD.PRIORVALUE2NAME
		' </summary>
		Public Overridable Property Priorvalue2name As System.String
			Get
				Return MyBase.GetSystemString(ChangerecordMetadata.ColumnNames.Priorvalue2name)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ChangerecordMetadata.ColumnNames.Priorvalue2name, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHANGERECORD.PRIORVALUE3
		' </summary>
		Public Overridable Property Priorvalue3 As System.String
			Get
				Return MyBase.GetSystemString(ChangerecordMetadata.ColumnNames.Priorvalue3)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ChangerecordMetadata.ColumnNames.Priorvalue3, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHANGERECORD.PRIORVALUE3NAME
		' </summary>
		Public Overridable Property Priorvalue3name As System.String
			Get
				Return MyBase.GetSystemString(ChangerecordMetadata.ColumnNames.Priorvalue3name)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ChangerecordMetadata.ColumnNames.Priorvalue3name, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHANGERECORD.NEWVALUE1
		' </summary>
		Public Overridable Property Newvalue1 As System.String
			Get
				Return MyBase.GetSystemString(ChangerecordMetadata.ColumnNames.Newvalue1)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ChangerecordMetadata.ColumnNames.Newvalue1, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHANGERECORD.NEWVALUE2
		' </summary>
		Public Overridable Property Newvalue2 As System.String
			Get
				Return MyBase.GetSystemString(ChangerecordMetadata.ColumnNames.Newvalue2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ChangerecordMetadata.ColumnNames.Newvalue2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHANGERECORD.NEWVALUE3
		' </summary>
		Public Overridable Property Newvalue3 As System.String
			Get
				Return MyBase.GetSystemString(ChangerecordMetadata.ColumnNames.Newvalue3)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ChangerecordMetadata.ColumnNames.Newvalue3, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CHANGERECORD.RECORDSTATUS
		' </summary>
		Public Overridable Property Recordstatus As System.String
			Get
				Return MyBase.GetSystemString(ChangerecordMetadata.ColumnNames.Recordstatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ChangerecordMetadata.ColumnNames.Recordstatus, value)
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
		
			Public Sub New(ByVal entity As esChangerecord)
				Me.entity = entity
			End Sub				
		
	
			Public Property Changerecid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Changerecid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Changerecid = Nothing
					Else
						entity.Changerecid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Whatchanged As System.String 
				Get
					Dim data_ As System.String = entity.Whatchanged
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Whatchanged = Nothing
					Else
						entity.Whatchanged = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Whochanged As System.String 
				Get
					Dim data_ As System.String = entity.Whochanged
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Whochanged = Nothing
					Else
						entity.Whochanged = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Whenchanged As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Whenchanged
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Whenchanged = Nothing
					Else
						entity.Whenchanged = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Whychanged As System.String 
				Get
					Dim data_ As System.String = entity.Whychanged
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Whychanged = Nothing
					Else
						entity.Whychanged = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Priorvalue1 As System.String 
				Get
					Dim data_ As System.String = entity.Priorvalue1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Priorvalue1 = Nothing
					Else
						entity.Priorvalue1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Changetype As System.String 
				Get
					Dim data_ As System.String = entity.Changetype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Changetype = Nothing
					Else
						entity.Changetype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Datatablename As System.String 
				Get
					Dim data_ As System.String = entity.Datatablename
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Datatablename = Nothing
					Else
						entity.Datatablename = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Datarecordid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Datarecordid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Datarecordid = Nothing
					Else
						entity.Datarecordid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Priorvalue1name As System.String 
				Get
					Dim data_ As System.String = entity.Priorvalue1name
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Priorvalue1name = Nothing
					Else
						entity.Priorvalue1name = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Priorvalue2 As System.String 
				Get
					Dim data_ As System.String = entity.Priorvalue2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Priorvalue2 = Nothing
					Else
						entity.Priorvalue2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Priorvalue2name As System.String 
				Get
					Dim data_ As System.String = entity.Priorvalue2name
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Priorvalue2name = Nothing
					Else
						entity.Priorvalue2name = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Priorvalue3 As System.String 
				Get
					Dim data_ As System.String = entity.Priorvalue3
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Priorvalue3 = Nothing
					Else
						entity.Priorvalue3 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Priorvalue3name As System.String 
				Get
					Dim data_ As System.String = entity.Priorvalue3name
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Priorvalue3name = Nothing
					Else
						entity.Priorvalue3name = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Newvalue1 As System.String 
				Get
					Dim data_ As System.String = entity.Newvalue1
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Newvalue1 = Nothing
					Else
						entity.Newvalue1 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Newvalue2 As System.String 
				Get
					Dim data_ As System.String = entity.Newvalue2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Newvalue2 = Nothing
					Else
						entity.Newvalue2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Newvalue3 As System.String 
				Get
					Dim data_ As System.String = entity.Newvalue3
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Newvalue3 = Nothing
					Else
						entity.Newvalue3 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Recordstatus As System.String 
				Get
					Dim data_ As System.String = entity.Recordstatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Recordstatus = Nothing
					Else
						entity.Recordstatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esChangerecord
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esChangerecordQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esChangerecord can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Changerecord 
		Inherits esChangerecord
		
	
		
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
	MustInherit Public Class esChangerecordQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ChangerecordMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Changerecid As esQueryItem
			Get
				Return New esQueryItem(Me, ChangerecordMetadata.ColumnNames.Changerecid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Whatchanged As esQueryItem
			Get
				Return New esQueryItem(Me, ChangerecordMetadata.ColumnNames.Whatchanged, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Whochanged As esQueryItem
			Get
				Return New esQueryItem(Me, ChangerecordMetadata.ColumnNames.Whochanged, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Whenchanged As esQueryItem
			Get
				Return New esQueryItem(Me, ChangerecordMetadata.ColumnNames.Whenchanged, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Whychanged As esQueryItem
			Get
				Return New esQueryItem(Me, ChangerecordMetadata.ColumnNames.Whychanged, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Priorvalue1 As esQueryItem
			Get
				Return New esQueryItem(Me, ChangerecordMetadata.ColumnNames.Priorvalue1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Changetype As esQueryItem
			Get
				Return New esQueryItem(Me, ChangerecordMetadata.ColumnNames.Changetype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Datatablename As esQueryItem
			Get
				Return New esQueryItem(Me, ChangerecordMetadata.ColumnNames.Datatablename, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Datarecordid As esQueryItem
			Get
				Return New esQueryItem(Me, ChangerecordMetadata.ColumnNames.Datarecordid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Priorvalue1name As esQueryItem
			Get
				Return New esQueryItem(Me, ChangerecordMetadata.ColumnNames.Priorvalue1name, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Priorvalue2 As esQueryItem
			Get
				Return New esQueryItem(Me, ChangerecordMetadata.ColumnNames.Priorvalue2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Priorvalue2name As esQueryItem
			Get
				Return New esQueryItem(Me, ChangerecordMetadata.ColumnNames.Priorvalue2name, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Priorvalue3 As esQueryItem
			Get
				Return New esQueryItem(Me, ChangerecordMetadata.ColumnNames.Priorvalue3, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Priorvalue3name As esQueryItem
			Get
				Return New esQueryItem(Me, ChangerecordMetadata.ColumnNames.Priorvalue3name, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Newvalue1 As esQueryItem
			Get
				Return New esQueryItem(Me, ChangerecordMetadata.ColumnNames.Newvalue1, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Newvalue2 As esQueryItem
			Get
				Return New esQueryItem(Me, ChangerecordMetadata.ColumnNames.Newvalue2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Newvalue3 As esQueryItem
			Get
				Return New esQueryItem(Me, ChangerecordMetadata.ColumnNames.Newvalue3, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Recordstatus As esQueryItem
			Get
				Return New esQueryItem(Me, ChangerecordMetadata.ColumnNames.Recordstatus, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ChangerecordCollection")> _
	Partial Public Class ChangerecordCollection
		Inherits esChangerecordCollection
		Implements IEnumerable(Of Changerecord)
		
        Public Shared Widening Operator CType(ByVal coll As ChangerecordCollection) As List(Of Changerecord)
            Dim list As List(Of Changerecord) = New List(Of Changerecord)
            Dim emp As Changerecord

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ChangerecordMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ChangerecordQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Changerecord(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Changerecord()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As ChangerecordQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ChangerecordQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ChangerecordQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Changerecord 
			Return CType(MyBase.AddNewEntity(), Changerecord)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal changerecid As System.Int32) As Changerecord
			Return CType(MyBase.FindByPrimaryKey(changerecid), Changerecord)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Changerecord) Implements IEnumerable(Of Changerecord).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Changerecord)(Me)
        End Function
		
		Private _query As ChangerecordQuery

	End Class
	


	' <summary>
	' Encapsulates the 'CHANGERECORD' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Changerecord ({Changerecid.Value})")> _
	<Serializable> _
	Partial Public Class Changerecord 
		Inherits esChangerecord

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ChangerecordMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esChangerecordQuery

			If Me._query Is Nothing Then
				Me._query = New ChangerecordQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ChangerecordQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ChangerecordQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ChangerecordQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ChangerecordQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ChangerecordQuery
		inherits esChangerecordQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ChangerecordQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ChangerecordMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ChangerecordMetadata.ColumnNames.Changerecid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ChangerecordMetadata.PropertyNames.Changerecid
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ChangerecordMetadata.ColumnNames.Whatchanged, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = ChangerecordMetadata.PropertyNames.Whatchanged
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ChangerecordMetadata.ColumnNames.Whochanged, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ChangerecordMetadata.PropertyNames.Whochanged
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ChangerecordMetadata.ColumnNames.Whenchanged, 3, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ChangerecordMetadata.PropertyNames.Whenchanged
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ChangerecordMetadata.ColumnNames.Whychanged, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ChangerecordMetadata.PropertyNames.Whychanged
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ChangerecordMetadata.ColumnNames.Priorvalue1, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ChangerecordMetadata.PropertyNames.Priorvalue1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ChangerecordMetadata.ColumnNames.Changetype, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = ChangerecordMetadata.PropertyNames.Changetype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ChangerecordMetadata.ColumnNames.Datatablename, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ChangerecordMetadata.PropertyNames.Datatablename
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ChangerecordMetadata.ColumnNames.Datarecordid, 8, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ChangerecordMetadata.PropertyNames.Datarecordid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ChangerecordMetadata.ColumnNames.Priorvalue1name, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ChangerecordMetadata.PropertyNames.Priorvalue1name
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ChangerecordMetadata.ColumnNames.Priorvalue2, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ChangerecordMetadata.PropertyNames.Priorvalue2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ChangerecordMetadata.ColumnNames.Priorvalue2name, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = ChangerecordMetadata.PropertyNames.Priorvalue2name
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ChangerecordMetadata.ColumnNames.Priorvalue3, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = ChangerecordMetadata.PropertyNames.Priorvalue3
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ChangerecordMetadata.ColumnNames.Priorvalue3name, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = ChangerecordMetadata.PropertyNames.Priorvalue3name
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ChangerecordMetadata.ColumnNames.Newvalue1, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = ChangerecordMetadata.PropertyNames.Newvalue1
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ChangerecordMetadata.ColumnNames.Newvalue2, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = ChangerecordMetadata.PropertyNames.Newvalue2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ChangerecordMetadata.ColumnNames.Newvalue3, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = ChangerecordMetadata.PropertyNames.Newvalue3
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ChangerecordMetadata.ColumnNames.Recordstatus, 17, GetType(System.String), esSystemType.String)	
			c.PropertyName = ChangerecordMetadata.PropertyNames.Recordstatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ChangerecordMetadata
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
			 Public Const Changerecid As String = "CHANGERECID"
			 Public Const Whatchanged As String = "WHATCHANGED"
			 Public Const Whochanged As String = "WHOCHANGED"
			 Public Const Whenchanged As String = "WHENCHANGED"
			 Public Const Whychanged As String = "WHYCHANGED"
			 Public Const Priorvalue1 As String = "PRIORVALUE1"
			 Public Const Changetype As String = "CHANGETYPE"
			 Public Const Datatablename As String = "DATATABLENAME"
			 Public Const Datarecordid As String = "DATARECORDID"
			 Public Const Priorvalue1name As String = "PRIORVALUE1NAME"
			 Public Const Priorvalue2 As String = "PRIORVALUE2"
			 Public Const Priorvalue2name As String = "PRIORVALUE2NAME"
			 Public Const Priorvalue3 As String = "PRIORVALUE3"
			 Public Const Priorvalue3name As String = "PRIORVALUE3NAME"
			 Public Const Newvalue1 As String = "NEWVALUE1"
			 Public Const Newvalue2 As String = "NEWVALUE2"
			 Public Const Newvalue3 As String = "NEWVALUE3"
			 Public Const Recordstatus As String = "RECORDSTATUS"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Changerecid As String = "Changerecid"
			 Public Const Whatchanged As String = "Whatchanged"
			 Public Const Whochanged As String = "Whochanged"
			 Public Const Whenchanged As String = "Whenchanged"
			 Public Const Whychanged As String = "Whychanged"
			 Public Const Priorvalue1 As String = "Priorvalue1"
			 Public Const Changetype As String = "Changetype"
			 Public Const Datatablename As String = "Datatablename"
			 Public Const Datarecordid As String = "Datarecordid"
			 Public Const Priorvalue1name As String = "Priorvalue1name"
			 Public Const Priorvalue2 As String = "Priorvalue2"
			 Public Const Priorvalue2name As String = "Priorvalue2name"
			 Public Const Priorvalue3 As String = "Priorvalue3"
			 Public Const Priorvalue3name As String = "Priorvalue3name"
			 Public Const Newvalue1 As String = "Newvalue1"
			 Public Const Newvalue2 As String = "Newvalue2"
			 Public Const Newvalue3 As String = "Newvalue3"
			 Public Const Recordstatus As String = "Recordstatus"
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
            SyncLock GetType(ChangerecordMetadata)
			
				If ChangerecordMetadata.mapDelegates Is Nothing Then
					ChangerecordMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ChangerecordMetadata._meta Is Nothing Then
                    ChangerecordMetadata._meta = New ChangerecordMetadata()
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
				

				meta.AddTypeMap("Changerecid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Whatchanged", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Whochanged", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Whenchanged", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Whychanged", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Priorvalue1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Changetype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Datatablename", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Datarecordid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Priorvalue1name", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Priorvalue2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Priorvalue2name", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Priorvalue3", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Priorvalue3name", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Newvalue1", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Newvalue2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Newvalue3", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Recordstatus", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "CHANGERECORD"
				meta.Destination = "CHANGERECORD"
				
				meta.spInsert = "proc_CHANGERECORDInsert"
				meta.spUpdate = "proc_CHANGERECORDUpdate"
				meta.spDelete = "proc_CHANGERECORDDelete"
				meta.spLoadAll = "proc_CHANGERECORDLoadAll"
				meta.spLoadByPrimaryKey = "proc_CHANGERECORDLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ChangerecordMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
