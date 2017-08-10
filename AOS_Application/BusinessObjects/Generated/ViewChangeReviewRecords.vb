'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 6/20/2016 12:56:17 PM
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
	MustInherit Public Class esViewChangeReviewRecordsCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ViewChangeReviewRecordsCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esViewChangeReviewRecordsQuery)
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
            Me.InitQuery(CType(query, esViewChangeReviewRecordsQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As ViewChangeReviewRecords) As ViewChangeReviewRecords
			Return CType(MyBase.DetachEntity(entity), ViewChangeReviewRecords)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As ViewChangeReviewRecords) As ViewChangeReviewRecords
			Return CType(MyBase.AttachEntity(entity), ViewChangeReviewRecords)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ViewChangeReviewRecordsCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As ViewChangeReviewRecords
            Get
                Return TryCast(MyBase.Item(index), ViewChangeReviewRecords)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(ViewChangeReviewRecords)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esViewChangeReviewRecords	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esViewChangeReviewRecordsQuery
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
												
						Case "Reviewrecid"
							Me.str.Reviewrecid = CType(value, string)
												
						Case "Changerecid"
							Me.str.Changerecid = CType(value, string)
												
						Case "Datatablename"
							Me.str.Datatablename = CType(value, string)
												
						Case "Datarecordid"
							Me.str.Datarecordid = CType(value, string)
												
						Case "Referencetype"
							Me.str.Referencetype = CType(value, string)
												
						Case "Referenceid"
							Me.str.Referenceid = CType(value, string)
												
						Case "Materialid"
							Me.str.Materialid = CType(value, string)
												
						Case "Reviewreason"
							Me.str.Reviewreason = CType(value, string)
												
						Case "Revieweddate"
							Me.str.Revieweddate = CType(value, string)
												
						Case "Reviewedby"
							Me.str.Reviewedby = CType(value, string)
												
						Case "Reviewstatus"
							Me.str.Reviewstatus = CType(value, string)
												
						Case "Productdesc"
							Me.str.Productdesc = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "Rawid"
							Me.str.Rawid = CType(value, string)
												
						Case "Rawdesc"
							Me.str.Rawdesc = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Reviewrecid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Reviewrecid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Changerecid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Changerecid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Datarecordid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Datarecordid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Referenceid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Referenceid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Materialid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Materialid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Revieweddate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Revieweddate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Rawid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Rawid = CType(value, Nullable(Of System.Int32))
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
		' Maps to viewChangeReviewRecords.REVIEWRECID
		' </summary>
		Public Overridable Property Reviewrecid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewChangeReviewRecordsMetadata.ColumnNames.Reviewrecid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewChangeReviewRecordsMetadata.ColumnNames.Reviewrecid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewChangeReviewRecords.CHANGERECID
		' </summary>
		Public Overridable Property Changerecid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewChangeReviewRecordsMetadata.ColumnNames.Changerecid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewChangeReviewRecordsMetadata.ColumnNames.Changerecid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewChangeReviewRecords.DATATABLENAME
		' </summary>
		Public Overridable Property Datatablename As System.String
			Get
				Return MyBase.GetSystemString(ViewChangeReviewRecordsMetadata.ColumnNames.Datatablename)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewChangeReviewRecordsMetadata.ColumnNames.Datatablename, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewChangeReviewRecords.DATARECORDID
		' </summary>
		Public Overridable Property Datarecordid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewChangeReviewRecordsMetadata.ColumnNames.Datarecordid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewChangeReviewRecordsMetadata.ColumnNames.Datarecordid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewChangeReviewRecords.REFERENCETYPE
		' </summary>
		Public Overridable Property Referencetype As System.String
			Get
				Return MyBase.GetSystemString(ViewChangeReviewRecordsMetadata.ColumnNames.Referencetype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewChangeReviewRecordsMetadata.ColumnNames.Referencetype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewChangeReviewRecords.REFERENCEID
		' </summary>
		Public Overridable Property Referenceid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewChangeReviewRecordsMetadata.ColumnNames.Referenceid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewChangeReviewRecordsMetadata.ColumnNames.Referenceid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewChangeReviewRecords.MATERIALID
		' </summary>
		Public Overridable Property Materialid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewChangeReviewRecordsMetadata.ColumnNames.Materialid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewChangeReviewRecordsMetadata.ColumnNames.Materialid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewChangeReviewRecords.REVIEWREASON
		' </summary>
		Public Overridable Property Reviewreason As System.String
			Get
				Return MyBase.GetSystemString(ViewChangeReviewRecordsMetadata.ColumnNames.Reviewreason)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewChangeReviewRecordsMetadata.ColumnNames.Reviewreason, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewChangeReviewRecords.REVIEWEDDATE
		' </summary>
		Public Overridable Property Revieweddate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ViewChangeReviewRecordsMetadata.ColumnNames.Revieweddate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ViewChangeReviewRecordsMetadata.ColumnNames.Revieweddate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewChangeReviewRecords.REVIEWEDBY
		' </summary>
		Public Overridable Property Reviewedby As System.String
			Get
				Return MyBase.GetSystemString(ViewChangeReviewRecordsMetadata.ColumnNames.Reviewedby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewChangeReviewRecordsMetadata.ColumnNames.Reviewedby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewChangeReviewRecords.REVIEWSTATUS
		' </summary>
		Public Overridable Property Reviewstatus As System.String
			Get
				Return MyBase.GetSystemString(ViewChangeReviewRecordsMetadata.ColumnNames.Reviewstatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewChangeReviewRecordsMetadata.ColumnNames.Reviewstatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewChangeReviewRecords.PRODUCTDESC
		' </summary>
		Public Overridable Property Productdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewChangeReviewRecordsMetadata.ColumnNames.Productdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewChangeReviewRecordsMetadata.ColumnNames.Productdesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewChangeReviewRecords.CONTAINER
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ViewChangeReviewRecordsMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewChangeReviewRecordsMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewChangeReviewRecords.RAWID
		' </summary>
		Public Overridable Property Rawid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ViewChangeReviewRecordsMetadata.ColumnNames.Rawid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ViewChangeReviewRecordsMetadata.ColumnNames.Rawid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to viewChangeReviewRecords.RAWDESC
		' </summary>
		Public Overridable Property Rawdesc As System.String
			Get
				Return MyBase.GetSystemString(ViewChangeReviewRecordsMetadata.ColumnNames.Rawdesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ViewChangeReviewRecordsMetadata.ColumnNames.Rawdesc, value)
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
		
			Public Sub New(ByVal entity As esViewChangeReviewRecords)
				Me.entity = entity
			End Sub				
		
	
			Public Property Reviewrecid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Reviewrecid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Reviewrecid = Nothing
					Else
						entity.Reviewrecid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
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
		  	
			Public Property Referencetype As System.String 
				Get
					Dim data_ As System.String = entity.Referencetype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Referencetype = Nothing
					Else
						entity.Referencetype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Referenceid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Referenceid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Referenceid = Nothing
					Else
						entity.Referenceid = Convert.ToInt32(Value)
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
		  	
			Public Property Reviewreason As System.String 
				Get
					Dim data_ As System.String = entity.Reviewreason
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Reviewreason = Nothing
					Else
						entity.Reviewreason = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Revieweddate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Revieweddate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Revieweddate = Nothing
					Else
						entity.Revieweddate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Reviewedby As System.String 
				Get
					Dim data_ As System.String = entity.Reviewedby
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Reviewedby = Nothing
					Else
						entity.Reviewedby = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Reviewstatus As System.String 
				Get
					Dim data_ As System.String = entity.Reviewstatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Reviewstatus = Nothing
					Else
						entity.Reviewstatus = Convert.ToString(Value)
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
		  	
			Public Property Rawid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Rawid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Rawid = Nothing
					Else
						entity.Rawid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Rawdesc As System.String 
				Get
					Dim data_ As System.String = entity.Rawdesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Rawdesc = Nothing
					Else
						entity.Rawdesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  

			Private entity As esViewChangeReviewRecords
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esViewChangeReviewRecordsQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esViewChangeReviewRecords can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class



	<Serializable> _
	MustInherit Public Class esViewChangeReviewRecordsQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewChangeReviewRecordsMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Reviewrecid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewChangeReviewRecordsMetadata.ColumnNames.Reviewrecid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Changerecid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewChangeReviewRecordsMetadata.ColumnNames.Changerecid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Datatablename As esQueryItem
			Get
				Return New esQueryItem(Me, ViewChangeReviewRecordsMetadata.ColumnNames.Datatablename, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Datarecordid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewChangeReviewRecordsMetadata.ColumnNames.Datarecordid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Referencetype As esQueryItem
			Get
				Return New esQueryItem(Me, ViewChangeReviewRecordsMetadata.ColumnNames.Referencetype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Referenceid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewChangeReviewRecordsMetadata.ColumnNames.Referenceid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Materialid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewChangeReviewRecordsMetadata.ColumnNames.Materialid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Reviewreason As esQueryItem
			Get
				Return New esQueryItem(Me, ViewChangeReviewRecordsMetadata.ColumnNames.Reviewreason, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Revieweddate As esQueryItem
			Get
				Return New esQueryItem(Me, ViewChangeReviewRecordsMetadata.ColumnNames.Revieweddate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Reviewedby As esQueryItem
			Get
				Return New esQueryItem(Me, ViewChangeReviewRecordsMetadata.ColumnNames.Reviewedby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Reviewstatus As esQueryItem
			Get
				Return New esQueryItem(Me, ViewChangeReviewRecordsMetadata.ColumnNames.Reviewstatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Productdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewChangeReviewRecordsMetadata.ColumnNames.Productdesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ViewChangeReviewRecordsMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Rawid As esQueryItem
			Get
				Return New esQueryItem(Me, ViewChangeReviewRecordsMetadata.ColumnNames.Rawid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Rawdesc As esQueryItem
			Get
				Return New esQueryItem(Me, ViewChangeReviewRecordsMetadata.ColumnNames.Rawdesc, esSystemType.String)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ViewChangeReviewRecordsCollection")> _
	Partial Public Class ViewChangeReviewRecordsCollection
		Inherits esViewChangeReviewRecordsCollection
		Implements IEnumerable(Of ViewChangeReviewRecords)
		
        Public Shared Widening Operator CType(ByVal coll As ViewChangeReviewRecordsCollection) As List(Of ViewChangeReviewRecords)
            Dim list As List(Of ViewChangeReviewRecords) = New List(Of ViewChangeReviewRecords)
            Dim emp As ViewChangeReviewRecords

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ViewChangeReviewRecordsMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ViewChangeReviewRecordsQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New ViewChangeReviewRecords(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New ViewChangeReviewRecords()
		End function
		
				
		Public Overrides Function LoadAll() As Boolean
			Return MyBase.LoadAll(esSqlAccessType.DynamicSQL)
		End function
				
		#End Region
		
		Public ReadOnly Property Query As ViewChangeReviewRecordsQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ViewChangeReviewRecordsQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewChangeReviewRecordsQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As ViewChangeReviewRecords 
			Return CType(MyBase.AddNewEntity(), ViewChangeReviewRecords)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of ViewChangeReviewRecords) Implements IEnumerable(Of ViewChangeReviewRecords).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of ViewChangeReviewRecords)(Me)
        End Function
		
		Private _query As ViewChangeReviewRecordsQuery

	End Class
	


	' <summary>
	' Encapsulates the 'viewChangeReviewRecords' view
	' </summary>

    <System.Diagnostics.DebuggerDisplay("ViewChangeReviewRecords ()")> _
	<Serializable> _
	Partial Public Class ViewChangeReviewRecords 
		Inherits esViewChangeReviewRecords

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ViewChangeReviewRecordsMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esViewChangeReviewRecordsQuery

			If Me._query Is Nothing Then
				Me._query = New ViewChangeReviewRecordsQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ViewChangeReviewRecordsQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ViewChangeReviewRecordsQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ViewChangeReviewRecordsQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ViewChangeReviewRecordsQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ViewChangeReviewRecordsQuery
		inherits esViewChangeReviewRecordsQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ViewChangeReviewRecordsQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ViewChangeReviewRecordsMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ViewChangeReviewRecordsMetadata.ColumnNames.Reviewrecid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewChangeReviewRecordsMetadata.PropertyNames.Reviewrecid
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewChangeReviewRecordsMetadata.ColumnNames.Changerecid, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewChangeReviewRecordsMetadata.PropertyNames.Changerecid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewChangeReviewRecordsMetadata.ColumnNames.Datatablename, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewChangeReviewRecordsMetadata.PropertyNames.Datatablename
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewChangeReviewRecordsMetadata.ColumnNames.Datarecordid, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewChangeReviewRecordsMetadata.PropertyNames.Datarecordid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewChangeReviewRecordsMetadata.ColumnNames.Referencetype, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewChangeReviewRecordsMetadata.PropertyNames.Referencetype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewChangeReviewRecordsMetadata.ColumnNames.Referenceid, 5, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewChangeReviewRecordsMetadata.PropertyNames.Referenceid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewChangeReviewRecordsMetadata.ColumnNames.Materialid, 6, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewChangeReviewRecordsMetadata.PropertyNames.Materialid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewChangeReviewRecordsMetadata.ColumnNames.Reviewreason, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewChangeReviewRecordsMetadata.PropertyNames.Reviewreason
			c.CharacterMaxLength = 100
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewChangeReviewRecordsMetadata.ColumnNames.Revieweddate, 8, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ViewChangeReviewRecordsMetadata.PropertyNames.Revieweddate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewChangeReviewRecordsMetadata.ColumnNames.Reviewedby, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewChangeReviewRecordsMetadata.PropertyNames.Reviewedby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewChangeReviewRecordsMetadata.ColumnNames.Reviewstatus, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewChangeReviewRecordsMetadata.PropertyNames.Reviewstatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewChangeReviewRecordsMetadata.ColumnNames.Productdesc, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewChangeReviewRecordsMetadata.PropertyNames.Productdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewChangeReviewRecordsMetadata.ColumnNames.Container, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewChangeReviewRecordsMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewChangeReviewRecordsMetadata.ColumnNames.Rawid, 13, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ViewChangeReviewRecordsMetadata.PropertyNames.Rawid
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ViewChangeReviewRecordsMetadata.ColumnNames.Rawdesc, 14, GetType(System.String), esSystemType.String)	
			c.PropertyName = ViewChangeReviewRecordsMetadata.PropertyNames.Rawdesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ViewChangeReviewRecordsMetadata
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
			 Public Const Reviewrecid As String = "REVIEWRECID"
			 Public Const Changerecid As String = "CHANGERECID"
			 Public Const Datatablename As String = "DATATABLENAME"
			 Public Const Datarecordid As String = "DATARECORDID"
			 Public Const Referencetype As String = "REFERENCETYPE"
			 Public Const Referenceid As String = "REFERENCEID"
			 Public Const Materialid As String = "MATERIALID"
			 Public Const Reviewreason As String = "REVIEWREASON"
			 Public Const Revieweddate As String = "REVIEWEDDATE"
			 Public Const Reviewedby As String = "REVIEWEDBY"
			 Public Const Reviewstatus As String = "REVIEWSTATUS"
			 Public Const Productdesc As String = "PRODUCTDESC"
			 Public Const Container As String = "CONTAINER"
			 Public Const Rawid As String = "RAWID"
			 Public Const Rawdesc As String = "RAWDESC"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Reviewrecid As String = "Reviewrecid"
			 Public Const Changerecid As String = "Changerecid"
			 Public Const Datatablename As String = "Datatablename"
			 Public Const Datarecordid As String = "Datarecordid"
			 Public Const Referencetype As String = "Referencetype"
			 Public Const Referenceid As String = "Referenceid"
			 Public Const Materialid As String = "Materialid"
			 Public Const Reviewreason As String = "Reviewreason"
			 Public Const Revieweddate As String = "Revieweddate"
			 Public Const Reviewedby As String = "Reviewedby"
			 Public Const Reviewstatus As String = "Reviewstatus"
			 Public Const Productdesc As String = "Productdesc"
			 Public Const Container As String = "Container"
			 Public Const Rawid As String = "Rawid"
			 Public Const Rawdesc As String = "Rawdesc"
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
            SyncLock GetType(ViewChangeReviewRecordsMetadata)
			
				If ViewChangeReviewRecordsMetadata.mapDelegates Is Nothing Then
					ViewChangeReviewRecordsMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ViewChangeReviewRecordsMetadata._meta Is Nothing Then
                    ViewChangeReviewRecordsMetadata._meta = New ViewChangeReviewRecordsMetadata()
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
				

				meta.AddTypeMap("Reviewrecid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Changerecid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Datatablename", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Datarecordid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Referencetype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Referenceid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Materialid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Reviewreason", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Revieweddate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Reviewedby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Reviewstatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Productdesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Rawid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Rawdesc", new esTypeMap("varchar", "System.String"))			
				
				
				 
				meta.Source = "viewChangeReviewRecords"
				meta.Destination = "viewChangeReviewRecords"
				
				meta.spInsert = "proc_viewChangeReviewRecordsInsert"
				meta.spUpdate = "proc_viewChangeReviewRecordsUpdate"
				meta.spDelete = "proc_viewChangeReviewRecordsDelete"
				meta.spLoadAll = "proc_viewChangeReviewRecordsLoadAll"
				meta.spLoadByPrimaryKey = "proc_viewChangeReviewRecordsLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ViewChangeReviewRecordsMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
