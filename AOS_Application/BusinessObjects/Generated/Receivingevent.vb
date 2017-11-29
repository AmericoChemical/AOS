'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 11/28/2017 9:38:57 AM
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
	MustInherit Public Class esReceivingeventCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ReceivingeventCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esReceivingeventQuery)
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
            Me.InitQuery(CType(query, esReceivingeventQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Receivingevent) As Receivingevent
			Return CType(MyBase.DetachEntity(entity), Receivingevent)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Receivingevent) As Receivingevent
			Return CType(MyBase.AttachEntity(entity), Receivingevent)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ReceivingeventCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Receivingevent
            Get
                Return TryCast(MyBase.Item(index), Receivingevent)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Receivingevent)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esReceivingevent	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esReceivingeventQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal eventID As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(eventID)
			Else
				Return LoadByPrimaryKeyStoredProcedure(eventID)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal eventID As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(eventID)
			Else
				Return LoadByPrimaryKeyStoredProcedure(eventID)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal eventID As System.Int32) As Boolean
		
			Dim query As esReceivingeventQuery = Me.GetDynamicQuery()
			query.Where(query.EventID.Equal(eventID))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal eventID As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("EventID", eventID)
			
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
												
						Case "EventID"
							Me.str.EventID = CType(value, string)
												
						Case "EventTime"
							Me.str.EventTime = CType(value, string)
												
						Case "EventWho"
							Me.str.EventWho = CType(value, string)
												
						Case "EventType"
							Me.str.EventType = CType(value, string)
												
						Case "InvItemNumber"
							Me.str.InvItemNumber = CType(value, string)
												
						Case "DocumentType"
							Me.str.DocumentType = CType(value, string)
												
						Case "DocumentID"
							Me.str.DocumentID = CType(value, string)
												
						Case "LabelWeight"
							Me.str.LabelWeight = CType(value, string)
												
						Case "ScaleWeight"
							Me.str.ScaleWeight = CType(value, string)
												
						Case "LotNumber"
							Me.str.LotNumber = CType(value, string)
												
						Case "EventNotes"
							Me.str.EventNotes = CType(value, string)
												
						Case "Pallet"
							Me.str.Pallet = CType(value, string)
												
						Case "ProductID"
							Me.str.ProductID = CType(value, string)
												
						Case "Container"
							Me.str.Container = CType(value, string)
												
						Case "FailedLabelWeight"
							Me.str.FailedLabelWeight = CType(value, string)
												
						Case "FailedMaterialWeight"
							Me.str.FailedMaterialWeight = CType(value, string)
												
						Case "ItemStatus"
							Me.str.ItemStatus = CType(value, string)
												
						Case "Isautoflag"
							Me.str.Isautoflag = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "EventID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.EventID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "EventTime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.EventTime = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "InvItemNumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.InvItemNumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "DocumentID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.DocumentID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "LabelWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.LabelWeight = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "ScaleWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.ScaleWeight = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "ProductID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ProductID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "FailedLabelWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.FailedLabelWeight = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "FailedMaterialWeight"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.FailedMaterialWeight = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "Isautoflag"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Isautoflag = CType(value, Nullable(Of System.Boolean))
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
		' Maps to RECEIVINGEVENT.EventID
		' </summary>
		Public Overridable Property EventID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ReceivingeventMetadata.ColumnNames.EventID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ReceivingeventMetadata.ColumnNames.EventID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RECEIVINGEVENT.EventTime
		' </summary>
		Public Overridable Property EventTime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ReceivingeventMetadata.ColumnNames.EventTime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ReceivingeventMetadata.ColumnNames.EventTime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RECEIVINGEVENT.EventWho
		' </summary>
		Public Overridable Property EventWho As System.String
			Get
				Return MyBase.GetSystemString(ReceivingeventMetadata.ColumnNames.EventWho)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ReceivingeventMetadata.ColumnNames.EventWho, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RECEIVINGEVENT.EventType
		' </summary>
		Public Overridable Property EventType As System.String
			Get
				Return MyBase.GetSystemString(ReceivingeventMetadata.ColumnNames.EventType)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ReceivingeventMetadata.ColumnNames.EventType, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RECEIVINGEVENT.InvItemNumber
		' </summary>
		Public Overridable Property InvItemNumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ReceivingeventMetadata.ColumnNames.InvItemNumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ReceivingeventMetadata.ColumnNames.InvItemNumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RECEIVINGEVENT.DocumentType
		' </summary>
		Public Overridable Property DocumentType As System.String
			Get
				Return MyBase.GetSystemString(ReceivingeventMetadata.ColumnNames.DocumentType)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ReceivingeventMetadata.ColumnNames.DocumentType, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RECEIVINGEVENT.DocumentID
		' </summary>
		Public Overridable Property DocumentID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ReceivingeventMetadata.ColumnNames.DocumentID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ReceivingeventMetadata.ColumnNames.DocumentID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RECEIVINGEVENT.LabelWeight
		' </summary>
		Public Overridable Property LabelWeight As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ReceivingeventMetadata.ColumnNames.LabelWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ReceivingeventMetadata.ColumnNames.LabelWeight, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RECEIVINGEVENT.ScaleWeight
		' </summary>
		Public Overridable Property ScaleWeight As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ReceivingeventMetadata.ColumnNames.ScaleWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ReceivingeventMetadata.ColumnNames.ScaleWeight, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RECEIVINGEVENT.LotNumber
		' </summary>
		Public Overridable Property LotNumber As System.String
			Get
				Return MyBase.GetSystemString(ReceivingeventMetadata.ColumnNames.LotNumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ReceivingeventMetadata.ColumnNames.LotNumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RECEIVINGEVENT.EventNotes
		' </summary>
		Public Overridable Property EventNotes As System.String
			Get
				Return MyBase.GetSystemString(ReceivingeventMetadata.ColumnNames.EventNotes)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ReceivingeventMetadata.ColumnNames.EventNotes, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RECEIVINGEVENT.Pallet
		' </summary>
		Public Overridable Property Pallet As System.String
			Get
				Return MyBase.GetSystemString(ReceivingeventMetadata.ColumnNames.Pallet)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ReceivingeventMetadata.ColumnNames.Pallet, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RECEIVINGEVENT.ProductID
		' </summary>
		Public Overridable Property ProductID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ReceivingeventMetadata.ColumnNames.ProductID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ReceivingeventMetadata.ColumnNames.ProductID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RECEIVINGEVENT.Container
		' </summary>
		Public Overridable Property Container As System.String
			Get
				Return MyBase.GetSystemString(ReceivingeventMetadata.ColumnNames.Container)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ReceivingeventMetadata.ColumnNames.Container, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RECEIVINGEVENT.FailedLabelWeight
		' </summary>
		Public Overridable Property FailedLabelWeight As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ReceivingeventMetadata.ColumnNames.FailedLabelWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ReceivingeventMetadata.ColumnNames.FailedLabelWeight, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RECEIVINGEVENT.FailedMaterialWeight
		' </summary>
		Public Overridable Property FailedMaterialWeight As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ReceivingeventMetadata.ColumnNames.FailedMaterialWeight)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ReceivingeventMetadata.ColumnNames.FailedMaterialWeight, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RECEIVINGEVENT.ItemStatus
		' </summary>
		Public Overridable Property ItemStatus As System.String
			Get
				Return MyBase.GetSystemString(ReceivingeventMetadata.ColumnNames.ItemStatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ReceivingeventMetadata.ColumnNames.ItemStatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to RECEIVINGEVENT.ISAUTOFLAG
		' </summary>
		Public Overridable Property Isautoflag As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ReceivingeventMetadata.ColumnNames.Isautoflag)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ReceivingeventMetadata.ColumnNames.Isautoflag, value)
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
		
			Public Sub New(ByVal entity As esReceivingevent)
				Me.entity = entity
			End Sub				
		
	
			Public Property EventID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.EventID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EventID = Nothing
					Else
						entity.EventID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property EventTime As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.EventTime
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EventTime = Nothing
					Else
						entity.EventTime = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property EventWho As System.String 
				Get
					Dim data_ As System.String = entity.EventWho
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EventWho = Nothing
					Else
						entity.EventWho = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property EventType As System.String 
				Get
					Dim data_ As System.String = entity.EventType
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EventType = Nothing
					Else
						entity.EventType = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property InvItemNumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.InvItemNumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.InvItemNumber = Nothing
					Else
						entity.InvItemNumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property DocumentType As System.String 
				Get
					Dim data_ As System.String = entity.DocumentType
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DocumentType = Nothing
					Else
						entity.DocumentType = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property DocumentID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.DocumentID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.DocumentID = Nothing
					Else
						entity.DocumentID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property LabelWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.LabelWeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LabelWeight = Nothing
					Else
						entity.LabelWeight = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property ScaleWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.ScaleWeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ScaleWeight = Nothing
					Else
						entity.ScaleWeight = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property LotNumber As System.String 
				Get
					Dim data_ As System.String = entity.LotNumber
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LotNumber = Nothing
					Else
						entity.LotNumber = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property EventNotes As System.String 
				Get
					Dim data_ As System.String = entity.EventNotes
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EventNotes = Nothing
					Else
						entity.EventNotes = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Pallet As System.String 
				Get
					Dim data_ As System.String = entity.Pallet
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Pallet = Nothing
					Else
						entity.Pallet = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ProductID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.ProductID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ProductID = Nothing
					Else
						entity.ProductID = Convert.ToInt32(Value)
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
		  	
			Public Property FailedLabelWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.FailedLabelWeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FailedLabelWeight = Nothing
					Else
						entity.FailedLabelWeight = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property FailedMaterialWeight As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.FailedMaterialWeight
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FailedMaterialWeight = Nothing
					Else
						entity.FailedMaterialWeight = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property ItemStatus As System.String 
				Get
					Dim data_ As System.String = entity.ItemStatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ItemStatus = Nothing
					Else
						entity.ItemStatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Isautoflag As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Isautoflag
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Isautoflag = Nothing
					Else
						entity.Isautoflag = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  

			Private entity As esReceivingevent
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esReceivingeventQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esReceivingevent can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Receivingevent 
		Inherits esReceivingevent
		
	
		
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
	MustInherit Public Class esReceivingeventQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ReceivingeventMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property EventID As esQueryItem
			Get
				Return New esQueryItem(Me, ReceivingeventMetadata.ColumnNames.EventID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property EventTime As esQueryItem
			Get
				Return New esQueryItem(Me, ReceivingeventMetadata.ColumnNames.EventTime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property EventWho As esQueryItem
			Get
				Return New esQueryItem(Me, ReceivingeventMetadata.ColumnNames.EventWho, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property EventType As esQueryItem
			Get
				Return New esQueryItem(Me, ReceivingeventMetadata.ColumnNames.EventType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property InvItemNumber As esQueryItem
			Get
				Return New esQueryItem(Me, ReceivingeventMetadata.ColumnNames.InvItemNumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property DocumentType As esQueryItem
			Get
				Return New esQueryItem(Me, ReceivingeventMetadata.ColumnNames.DocumentType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property DocumentID As esQueryItem
			Get
				Return New esQueryItem(Me, ReceivingeventMetadata.ColumnNames.DocumentID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LabelWeight As esQueryItem
			Get
				Return New esQueryItem(Me, ReceivingeventMetadata.ColumnNames.LabelWeight, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property ScaleWeight As esQueryItem
			Get
				Return New esQueryItem(Me, ReceivingeventMetadata.ColumnNames.ScaleWeight, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property LotNumber As esQueryItem
			Get
				Return New esQueryItem(Me, ReceivingeventMetadata.ColumnNames.LotNumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property EventNotes As esQueryItem
			Get
				Return New esQueryItem(Me, ReceivingeventMetadata.ColumnNames.EventNotes, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Pallet As esQueryItem
			Get
				Return New esQueryItem(Me, ReceivingeventMetadata.ColumnNames.Pallet, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ProductID As esQueryItem
			Get
				Return New esQueryItem(Me, ReceivingeventMetadata.ColumnNames.ProductID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Container As esQueryItem
			Get
				Return New esQueryItem(Me, ReceivingeventMetadata.ColumnNames.Container, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FailedLabelWeight As esQueryItem
			Get
				Return New esQueryItem(Me, ReceivingeventMetadata.ColumnNames.FailedLabelWeight, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property FailedMaterialWeight As esQueryItem
			Get
				Return New esQueryItem(Me, ReceivingeventMetadata.ColumnNames.FailedMaterialWeight, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property ItemStatus As esQueryItem
			Get
				Return New esQueryItem(Me, ReceivingeventMetadata.ColumnNames.ItemStatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Isautoflag As esQueryItem
			Get
				Return New esQueryItem(Me, ReceivingeventMetadata.ColumnNames.Isautoflag, esSystemType.Boolean)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ReceivingeventCollection")> _
	Partial Public Class ReceivingeventCollection
		Inherits esReceivingeventCollection
		Implements IEnumerable(Of Receivingevent)
		
        Public Shared Widening Operator CType(ByVal coll As ReceivingeventCollection) As List(Of Receivingevent)
            Dim list As List(Of Receivingevent) = New List(Of Receivingevent)
            Dim emp As Receivingevent

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ReceivingeventMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ReceivingeventQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Receivingevent(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Receivingevent()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As ReceivingeventQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ReceivingeventQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ReceivingeventQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Receivingevent 
			Return CType(MyBase.AddNewEntity(), Receivingevent)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal eventID As System.Int32) As Receivingevent
			Return CType(MyBase.FindByPrimaryKey(eventID), Receivingevent)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Receivingevent) Implements IEnumerable(Of Receivingevent).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Receivingevent)(Me)
        End Function
		
		Private _query As ReceivingeventQuery

	End Class
	


	' <summary>
	' Encapsulates the 'RECEIVINGEVENT' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Receivingevent ({EventID.Value})")> _
	<Serializable> _
	Partial Public Class Receivingevent 
		Inherits esReceivingevent

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ReceivingeventMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esReceivingeventQuery

			If Me._query Is Nothing Then
				Me._query = New ReceivingeventQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ReceivingeventQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ReceivingeventQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ReceivingeventQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ReceivingeventQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ReceivingeventQuery
		inherits esReceivingeventQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ReceivingeventQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ReceivingeventMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ReceivingeventMetadata.ColumnNames.EventID, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ReceivingeventMetadata.PropertyNames.EventID
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ReceivingeventMetadata.ColumnNames.EventTime, 1, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ReceivingeventMetadata.PropertyNames.EventTime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ReceivingeventMetadata.ColumnNames.EventWho, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = ReceivingeventMetadata.PropertyNames.EventWho
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ReceivingeventMetadata.ColumnNames.EventType, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ReceivingeventMetadata.PropertyNames.EventType
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ReceivingeventMetadata.ColumnNames.InvItemNumber, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ReceivingeventMetadata.PropertyNames.InvItemNumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ReceivingeventMetadata.ColumnNames.DocumentType, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = ReceivingeventMetadata.PropertyNames.DocumentType
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ReceivingeventMetadata.ColumnNames.DocumentID, 6, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ReceivingeventMetadata.PropertyNames.DocumentID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ReceivingeventMetadata.ColumnNames.LabelWeight, 7, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ReceivingeventMetadata.PropertyNames.LabelWeight
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ReceivingeventMetadata.ColumnNames.ScaleWeight, 8, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ReceivingeventMetadata.PropertyNames.ScaleWeight
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ReceivingeventMetadata.ColumnNames.LotNumber, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ReceivingeventMetadata.PropertyNames.LotNumber
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ReceivingeventMetadata.ColumnNames.EventNotes, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ReceivingeventMetadata.PropertyNames.EventNotes
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ReceivingeventMetadata.ColumnNames.Pallet, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = ReceivingeventMetadata.PropertyNames.Pallet
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ReceivingeventMetadata.ColumnNames.ProductID, 12, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ReceivingeventMetadata.PropertyNames.ProductID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ReceivingeventMetadata.ColumnNames.Container, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = ReceivingeventMetadata.PropertyNames.Container
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ReceivingeventMetadata.ColumnNames.FailedLabelWeight, 14, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ReceivingeventMetadata.PropertyNames.FailedLabelWeight
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ReceivingeventMetadata.ColumnNames.FailedMaterialWeight, 15, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ReceivingeventMetadata.PropertyNames.FailedMaterialWeight
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ReceivingeventMetadata.ColumnNames.ItemStatus, 16, GetType(System.String), esSystemType.String)	
			c.PropertyName = ReceivingeventMetadata.PropertyNames.ItemStatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ReceivingeventMetadata.ColumnNames.Isautoflag, 17, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ReceivingeventMetadata.PropertyNames.Isautoflag
			c.HasDefault = True
			c.Default = "((0))"
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ReceivingeventMetadata
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
			 Public Const EventID As String = "EventID"
			 Public Const EventTime As String = "EventTime"
			 Public Const EventWho As String = "EventWho"
			 Public Const EventType As String = "EventType"
			 Public Const InvItemNumber As String = "InvItemNumber"
			 Public Const DocumentType As String = "DocumentType"
			 Public Const DocumentID As String = "DocumentID"
			 Public Const LabelWeight As String = "LabelWeight"
			 Public Const ScaleWeight As String = "ScaleWeight"
			 Public Const LotNumber As String = "LotNumber"
			 Public Const EventNotes As String = "EventNotes"
			 Public Const Pallet As String = "Pallet"
			 Public Const ProductID As String = "ProductID"
			 Public Const Container As String = "Container"
			 Public Const FailedLabelWeight As String = "FailedLabelWeight"
			 Public Const FailedMaterialWeight As String = "FailedMaterialWeight"
			 Public Const ItemStatus As String = "ItemStatus"
			 Public Const Isautoflag As String = "ISAUTOFLAG"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const EventID As String = "EventID"
			 Public Const EventTime As String = "EventTime"
			 Public Const EventWho As String = "EventWho"
			 Public Const EventType As String = "EventType"
			 Public Const InvItemNumber As String = "InvItemNumber"
			 Public Const DocumentType As String = "DocumentType"
			 Public Const DocumentID As String = "DocumentID"
			 Public Const LabelWeight As String = "LabelWeight"
			 Public Const ScaleWeight As String = "ScaleWeight"
			 Public Const LotNumber As String = "LotNumber"
			 Public Const EventNotes As String = "EventNotes"
			 Public Const Pallet As String = "Pallet"
			 Public Const ProductID As String = "ProductID"
			 Public Const Container As String = "Container"
			 Public Const FailedLabelWeight As String = "FailedLabelWeight"
			 Public Const FailedMaterialWeight As String = "FailedMaterialWeight"
			 Public Const ItemStatus As String = "ItemStatus"
			 Public Const Isautoflag As String = "Isautoflag"
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
            SyncLock GetType(ReceivingeventMetadata)
			
				If ReceivingeventMetadata.mapDelegates Is Nothing Then
					ReceivingeventMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ReceivingeventMetadata._meta Is Nothing Then
                    ReceivingeventMetadata._meta = New ReceivingeventMetadata()
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
				

				meta.AddTypeMap("EventID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("EventTime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("EventWho", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("EventType", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("InvItemNumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("DocumentType", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("DocumentID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("LabelWeight", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("ScaleWeight", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("LotNumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("EventNotes", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Pallet", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ProductID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Container", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("FailedLabelWeight", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("FailedMaterialWeight", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("ItemStatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Isautoflag", new esTypeMap("bit", "System.Boolean"))			
				
				
				 
				meta.Source = "RECEIVINGEVENT"
				meta.Destination = "RECEIVINGEVENT"
				
				meta.spInsert = "proc_RECEIVINGEVENTInsert"
				meta.spUpdate = "proc_RECEIVINGEVENTUpdate"
				meta.spDelete = "proc_RECEIVINGEVENTDelete"
				meta.spLoadAll = "proc_RECEIVINGEVENTLoadAll"
				meta.spLoadByPrimaryKey = "proc_RECEIVINGEVENTLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ReceivingeventMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
