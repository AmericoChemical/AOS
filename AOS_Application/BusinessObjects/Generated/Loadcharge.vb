'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 3/11/2014 9:02:09 AM
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
	MustInherit Public Class esLoadchargeCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "LoadchargeCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esLoadchargeQuery)
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
            Me.InitQuery(CType(query, esLoadchargeQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Loadcharge) As Loadcharge
			Return CType(MyBase.DetachEntity(entity), Loadcharge)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Loadcharge) As Loadcharge
			Return CType(MyBase.AttachEntity(entity), Loadcharge)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As LoadchargeCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Loadcharge
            Get
                Return TryCast(MyBase.Item(index), Loadcharge)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Loadcharge)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esLoadcharge	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esLoadchargeQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal loadChargeID As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(loadChargeID)
			Else
				Return LoadByPrimaryKeyStoredProcedure(loadChargeID)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal loadChargeID As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(loadChargeID)
			Else
				Return LoadByPrimaryKeyStoredProcedure(loadChargeID)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal loadChargeID As System.Int32) As Boolean
		
			Dim query As esLoadchargeQuery = Me.GetDynamicQuery()
			query.Where(query.LoadChargeID.Equal(loadChargeID))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal loadChargeID As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("LoadChargeID", loadChargeID)
			
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
												
						Case "LoadChargeID"
							Me.str.LoadChargeID = CType(value, string)
												
						Case "LoadID"
							Me.str.LoadID = CType(value, string)
												
						Case "CarrierID"
							Me.str.CarrierID = CType(value, string)
												
						Case "LogisticsProviderID"
							Me.str.LogisticsProviderID = CType(value, string)
												
						Case "CarrierCharges"
							Me.str.CarrierCharges = CType(value, string)
												
						Case "ChargeType"
							Me.str.ChargeType = CType(value, string)
												
						Case "ChargeDate"
							Me.str.ChargeDate = CType(value, string)
												
						Case "CreatedBy"
							Me.str.CreatedBy = CType(value, string)
												
						Case "LoadChargeStatus"
							Me.str.LoadChargeStatus = CType(value, string)
												
						Case "ChargeNote"
							Me.str.ChargeNote = CType(value, string)
												
						Case "APBatchID"
							Me.str.APBatchID = CType(value, string)
												
						Case "FreightInvoiceNumber"
							Me.str.FreightInvoiceNumber = CType(value, string)
												
						Case "FreightInvoiceDate"
							Me.str.FreightInvoiceDate = CType(value, string)
												
						Case "FreightVendorID"
							Me.str.FreightVendorID = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "LoadChargeID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.LoadChargeID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "LoadID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.LoadID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "CarrierID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.CarrierID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "LogisticsProviderID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.LogisticsProviderID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "CarrierCharges"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.CarrierCharges = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "ChargeDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.ChargeDate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "APBatchID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.APBatchID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "FreightInvoiceDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.FreightInvoiceDate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "FreightVendorID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.FreightVendorID = CType(value, Nullable(Of System.Int32))
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
		' Maps to LOADCHARGE.LoadChargeID
		' </summary>
		Public Overridable Property LoadChargeID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(LoadchargeMetadata.ColumnNames.LoadChargeID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(LoadchargeMetadata.ColumnNames.LoadChargeID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADCHARGE.LoadID
		' </summary>
		Public Overridable Property LoadID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(LoadchargeMetadata.ColumnNames.LoadID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(LoadchargeMetadata.ColumnNames.LoadID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADCHARGE.CarrierID
		' </summary>
		Public Overridable Property CarrierID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(LoadchargeMetadata.ColumnNames.CarrierID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(LoadchargeMetadata.ColumnNames.CarrierID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADCHARGE.LogisticsProviderID
		' </summary>
		Public Overridable Property LogisticsProviderID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(LoadchargeMetadata.ColumnNames.LogisticsProviderID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(LoadchargeMetadata.ColumnNames.LogisticsProviderID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADCHARGE.CarrierCharges
		' </summary>
		Public Overridable Property CarrierCharges As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(LoadchargeMetadata.ColumnNames.CarrierCharges)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(LoadchargeMetadata.ColumnNames.CarrierCharges, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADCHARGE.ChargeType
		' </summary>
		Public Overridable Property ChargeType As System.String
			Get
				Return MyBase.GetSystemString(LoadchargeMetadata.ColumnNames.ChargeType)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LoadchargeMetadata.ColumnNames.ChargeType, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADCHARGE.ChargeDate
		' </summary>
		Public Overridable Property ChargeDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(LoadchargeMetadata.ColumnNames.ChargeDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(LoadchargeMetadata.ColumnNames.ChargeDate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADCHARGE.CreatedBy
		' </summary>
		Public Overridable Property CreatedBy As System.String
			Get
				Return MyBase.GetSystemString(LoadchargeMetadata.ColumnNames.CreatedBy)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LoadchargeMetadata.ColumnNames.CreatedBy, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADCHARGE.LoadChargeStatus
		' </summary>
		Public Overridable Property LoadChargeStatus As System.String
			Get
				Return MyBase.GetSystemString(LoadchargeMetadata.ColumnNames.LoadChargeStatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LoadchargeMetadata.ColumnNames.LoadChargeStatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADCHARGE.ChargeNote
		' </summary>
		Public Overridable Property ChargeNote As System.String
			Get
				Return MyBase.GetSystemString(LoadchargeMetadata.ColumnNames.ChargeNote)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LoadchargeMetadata.ColumnNames.ChargeNote, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADCHARGE.APBatchID
		' </summary>
		Public Overridable Property APBatchID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(LoadchargeMetadata.ColumnNames.APBatchID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(LoadchargeMetadata.ColumnNames.APBatchID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADCHARGE.FreightInvoiceNumber
		' </summary>
		Public Overridable Property FreightInvoiceNumber As System.String
			Get
				Return MyBase.GetSystemString(LoadchargeMetadata.ColumnNames.FreightInvoiceNumber)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(LoadchargeMetadata.ColumnNames.FreightInvoiceNumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADCHARGE.FreightInvoiceDate
		' </summary>
		Public Overridable Property FreightInvoiceDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(LoadchargeMetadata.ColumnNames.FreightInvoiceDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(LoadchargeMetadata.ColumnNames.FreightInvoiceDate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to LOADCHARGE.FreightVendorID
		' </summary>
		Public Overridable Property FreightVendorID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(LoadchargeMetadata.ColumnNames.FreightVendorID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(LoadchargeMetadata.ColumnNames.FreightVendorID, value)
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
		
			Public Sub New(ByVal entity As esLoadcharge)
				Me.entity = entity
			End Sub				
		
	
			Public Property LoadChargeID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.LoadChargeID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LoadChargeID = Nothing
					Else
						entity.LoadChargeID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property LoadID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.LoadID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LoadID = Nothing
					Else
						entity.LoadID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property CarrierID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.CarrierID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CarrierID = Nothing
					Else
						entity.CarrierID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property LogisticsProviderID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.LogisticsProviderID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LogisticsProviderID = Nothing
					Else
						entity.LogisticsProviderID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property CarrierCharges As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.CarrierCharges
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CarrierCharges = Nothing
					Else
						entity.CarrierCharges = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property ChargeType As System.String 
				Get
					Dim data_ As System.String = entity.ChargeType
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ChargeType = Nothing
					Else
						entity.ChargeType = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ChargeDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.ChargeDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ChargeDate = Nothing
					Else
						entity.ChargeDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property CreatedBy As System.String 
				Get
					Dim data_ As System.String = entity.CreatedBy
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CreatedBy = Nothing
					Else
						entity.CreatedBy = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property LoadChargeStatus As System.String 
				Get
					Dim data_ As System.String = entity.LoadChargeStatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.LoadChargeStatus = Nothing
					Else
						entity.LoadChargeStatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ChargeNote As System.String 
				Get
					Dim data_ As System.String = entity.ChargeNote
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ChargeNote = Nothing
					Else
						entity.ChargeNote = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property APBatchID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.APBatchID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.APBatchID = Nothing
					Else
						entity.APBatchID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property FreightInvoiceNumber As System.String 
				Get
					Dim data_ As System.String = entity.FreightInvoiceNumber
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FreightInvoiceNumber = Nothing
					Else
						entity.FreightInvoiceNumber = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property FreightInvoiceDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.FreightInvoiceDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FreightInvoiceDate = Nothing
					Else
						entity.FreightInvoiceDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property FreightVendorID As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.FreightVendorID
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.FreightVendorID = Nothing
					Else
						entity.FreightVendorID = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  

			Private entity As esLoadcharge
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esLoadchargeQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esLoadcharge can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Loadcharge 
		Inherits esLoadcharge
		
	
		
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
	MustInherit Public Class esLoadchargeQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return LoadchargeMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property LoadChargeID As esQueryItem
			Get
				Return New esQueryItem(Me, LoadchargeMetadata.ColumnNames.LoadChargeID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LoadID As esQueryItem
			Get
				Return New esQueryItem(Me, LoadchargeMetadata.ColumnNames.LoadID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property CarrierID As esQueryItem
			Get
				Return New esQueryItem(Me, LoadchargeMetadata.ColumnNames.CarrierID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property LogisticsProviderID As esQueryItem
			Get
				Return New esQueryItem(Me, LoadchargeMetadata.ColumnNames.LogisticsProviderID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property CarrierCharges As esQueryItem
			Get
				Return New esQueryItem(Me, LoadchargeMetadata.ColumnNames.CarrierCharges, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property ChargeType As esQueryItem
			Get
				Return New esQueryItem(Me, LoadchargeMetadata.ColumnNames.ChargeType, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ChargeDate As esQueryItem
			Get
				Return New esQueryItem(Me, LoadchargeMetadata.ColumnNames.ChargeDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property CreatedBy As esQueryItem
			Get
				Return New esQueryItem(Me, LoadchargeMetadata.ColumnNames.CreatedBy, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property LoadChargeStatus As esQueryItem
			Get
				Return New esQueryItem(Me, LoadchargeMetadata.ColumnNames.LoadChargeStatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ChargeNote As esQueryItem
			Get
				Return New esQueryItem(Me, LoadchargeMetadata.ColumnNames.ChargeNote, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property APBatchID As esQueryItem
			Get
				Return New esQueryItem(Me, LoadchargeMetadata.ColumnNames.APBatchID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property FreightInvoiceNumber As esQueryItem
			Get
				Return New esQueryItem(Me, LoadchargeMetadata.ColumnNames.FreightInvoiceNumber, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property FreightInvoiceDate As esQueryItem
			Get
				Return New esQueryItem(Me, LoadchargeMetadata.ColumnNames.FreightInvoiceDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property FreightVendorID As esQueryItem
			Get
				Return New esQueryItem(Me, LoadchargeMetadata.ColumnNames.FreightVendorID, esSystemType.Int32)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("LoadchargeCollection")> _
	Partial Public Class LoadchargeCollection
		Inherits esLoadchargeCollection
		Implements IEnumerable(Of Loadcharge)
		
        Public Shared Widening Operator CType(ByVal coll As LoadchargeCollection) As List(Of Loadcharge)
            Dim list As List(Of Loadcharge) = New List(Of Loadcharge)
            Dim emp As Loadcharge

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return LoadchargeMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New LoadchargeQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Loadcharge(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Loadcharge()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As LoadchargeQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New LoadchargeQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As LoadchargeQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Loadcharge 
			Return CType(MyBase.AddNewEntity(), Loadcharge)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal loadChargeID As System.Int32) As Loadcharge
			Return CType(MyBase.FindByPrimaryKey(loadChargeID), Loadcharge)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Loadcharge) Implements IEnumerable(Of Loadcharge).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Loadcharge)(Me)
        End Function
		
		Private _query As LoadchargeQuery

	End Class
	


	' <summary>
	' Encapsulates the 'LOADCHARGE' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Loadcharge ({LoadChargeID.Value})")> _
	<Serializable> _
	Partial Public Class Loadcharge 
		Inherits esLoadcharge

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return LoadchargeMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esLoadchargeQuery

			If Me._query Is Nothing Then
				Me._query = New LoadchargeQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As LoadchargeQuery
			Get

				If Me._query Is Nothing then
					Me._query = New LoadchargeQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As LoadchargeQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As LoadchargeQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class LoadchargeQuery
		inherits esLoadchargeQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "LoadchargeQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class LoadchargeMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(LoadchargeMetadata.ColumnNames.LoadChargeID, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = LoadchargeMetadata.PropertyNames.LoadChargeID
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(LoadchargeMetadata.ColumnNames.LoadID, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = LoadchargeMetadata.PropertyNames.LoadID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoadchargeMetadata.ColumnNames.CarrierID, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = LoadchargeMetadata.PropertyNames.CarrierID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoadchargeMetadata.ColumnNames.LogisticsProviderID, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = LoadchargeMetadata.PropertyNames.LogisticsProviderID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoadchargeMetadata.ColumnNames.CarrierCharges, 4, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = LoadchargeMetadata.PropertyNames.CarrierCharges
			c.NumericPrecision = 18
			c.NumericScale = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoadchargeMetadata.ColumnNames.ChargeType, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = LoadchargeMetadata.PropertyNames.ChargeType
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoadchargeMetadata.ColumnNames.ChargeDate, 6, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = LoadchargeMetadata.PropertyNames.ChargeDate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoadchargeMetadata.ColumnNames.CreatedBy, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = LoadchargeMetadata.PropertyNames.CreatedBy
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoadchargeMetadata.ColumnNames.LoadChargeStatus, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = LoadchargeMetadata.PropertyNames.LoadChargeStatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoadchargeMetadata.ColumnNames.ChargeNote, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = LoadchargeMetadata.PropertyNames.ChargeNote
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoadchargeMetadata.ColumnNames.APBatchID, 10, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = LoadchargeMetadata.PropertyNames.APBatchID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoadchargeMetadata.ColumnNames.FreightInvoiceNumber, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = LoadchargeMetadata.PropertyNames.FreightInvoiceNumber
			c.CharacterMaxLength = 30
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoadchargeMetadata.ColumnNames.FreightInvoiceDate, 12, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = LoadchargeMetadata.PropertyNames.FreightInvoiceDate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(LoadchargeMetadata.ColumnNames.FreightVendorID, 13, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = LoadchargeMetadata.PropertyNames.FreightVendorID
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As LoadchargeMetadata
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
			 Public Const LoadChargeID As String = "LoadChargeID"
			 Public Const LoadID As String = "LoadID"
			 Public Const CarrierID As String = "CarrierID"
			 Public Const LogisticsProviderID As String = "LogisticsProviderID"
			 Public Const CarrierCharges As String = "CarrierCharges"
			 Public Const ChargeType As String = "ChargeType"
			 Public Const ChargeDate As String = "ChargeDate"
			 Public Const CreatedBy As String = "CreatedBy"
			 Public Const LoadChargeStatus As String = "LoadChargeStatus"
			 Public Const ChargeNote As String = "ChargeNote"
			 Public Const APBatchID As String = "APBatchID"
			 Public Const FreightInvoiceNumber As String = "FreightInvoiceNumber"
			 Public Const FreightInvoiceDate As String = "FreightInvoiceDate"
			 Public Const FreightVendorID As String = "FreightVendorID"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const LoadChargeID As String = "LoadChargeID"
			 Public Const LoadID As String = "LoadID"
			 Public Const CarrierID As String = "CarrierID"
			 Public Const LogisticsProviderID As String = "LogisticsProviderID"
			 Public Const CarrierCharges As String = "CarrierCharges"
			 Public Const ChargeType As String = "ChargeType"
			 Public Const ChargeDate As String = "ChargeDate"
			 Public Const CreatedBy As String = "CreatedBy"
			 Public Const LoadChargeStatus As String = "LoadChargeStatus"
			 Public Const ChargeNote As String = "ChargeNote"
			 Public Const APBatchID As String = "APBatchID"
			 Public Const FreightInvoiceNumber As String = "FreightInvoiceNumber"
			 Public Const FreightInvoiceDate As String = "FreightInvoiceDate"
			 Public Const FreightVendorID As String = "FreightVendorID"
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
            SyncLock GetType(LoadchargeMetadata)
			
				If LoadchargeMetadata.mapDelegates Is Nothing Then
					LoadchargeMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If LoadchargeMetadata._meta Is Nothing Then
                    LoadchargeMetadata._meta = New LoadchargeMetadata()
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
				

				meta.AddTypeMap("LoadChargeID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("LoadID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("CarrierID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("LogisticsProviderID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("CarrierCharges", new esTypeMap("decimal", "System.Decimal"))
				meta.AddTypeMap("ChargeType", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ChargeDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("CreatedBy", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("LoadChargeStatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ChargeNote", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("APBatchID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("FreightInvoiceNumber", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("FreightInvoiceDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("FreightVendorID", new esTypeMap("int", "System.Int32"))			
				
				
				 
				meta.Source = "LOADCHARGE"
				meta.Destination = "LOADCHARGE"
				
				meta.spInsert = "proc_LOADCHARGEInsert"
				meta.spUpdate = "proc_LOADCHARGEUpdate"
				meta.spDelete = "proc_LOADCHARGEDelete"
				meta.spLoadAll = "proc_LOADCHARGELoadAll"
				meta.spLoadByPrimaryKey = "proc_LOADCHARGELoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As LoadchargeMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
