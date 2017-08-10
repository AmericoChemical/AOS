'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 2/11/2014 1:43:55 PM
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
	MustInherit Public Class esCarrierCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "CarrierCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esCarrierQuery)
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
            Me.InitQuery(CType(query, esCarrierQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Carrier) As Carrier
			Return CType(MyBase.DetachEntity(entity), Carrier)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Carrier) As Carrier
			Return CType(MyBase.AttachEntity(entity), Carrier)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As CarrierCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Carrier
            Get
                Return TryCast(MyBase.Item(index), Carrier)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Carrier)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esCarrier	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esCarrierQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal carrierID As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(carrierID)
			Else
				Return LoadByPrimaryKeyStoredProcedure(carrierID)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal carrierID As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(carrierID)
			Else
				Return LoadByPrimaryKeyStoredProcedure(carrierID)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal carrierID As System.Int32) As Boolean
		
			Dim query As esCarrierQuery = Me.GetDynamicQuery()
			query.Where(query.CarrierID.Equal(carrierID))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal carrierID As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("CarrierID", carrierID)
			
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
												
						Case "CarrierID"
							Me.str.CarrierID = CType(value, string)
												
						Case "CarrierName"
							Me.str.CarrierName = CType(value, string)
												
						Case "CarrierAddress"
							Me.str.CarrierAddress = CType(value, string)
												
						Case "CarrierAddress2"
							Me.str.CarrierAddress2 = CType(value, string)
												
						Case "CarrierCity"
							Me.str.CarrierCity = CType(value, string)
												
						Case "CarrierState"
							Me.str.CarrierState = CType(value, string)
												
						Case "CarrierZipcode"
							Me.str.CarrierZipcode = CType(value, string)
												
						Case "CarrierPhone"
							Me.str.CarrierPhone = CType(value, string)
												
						Case "CarrierFax"
							Me.str.CarrierFax = CType(value, string)
												
						Case "TermsCarrier"
							Me.str.TermsCarrier = CType(value, string)
												
						Case "CarrierContactName"
							Me.str.CarrierContactName = CType(value, string)
												
						Case "CarrierContactEmail"
							Me.str.CarrierContactEmail = CType(value, string)
												
						Case "CarrierContactURL"
							Me.str.CarrierContactURL = CType(value, string)
												
						Case "Createdby"
							Me.str.Createdby = CType(value, string)
												
						Case "Createdtime"
							Me.str.Createdtime = CType(value, string)
												
						Case "Modifyby"
							Me.str.Modifyby = CType(value, string)
												
						Case "Modifytime"
							Me.str.Modifytime = CType(value, string)
												
						Case "Isactive"
							Me.str.Isactive = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "CarrierID"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.CarrierID = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Createdtime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Createdtime = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Modifytime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Modifytime = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Isactive"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Isactive = CType(value, Nullable(Of System.Boolean))
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
		' Maps to CARRIER.CarrierID
		' </summary>
		Public Overridable Property CarrierID As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(CarrierMetadata.ColumnNames.CarrierID)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(CarrierMetadata.ColumnNames.CarrierID, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CARRIER.CarrierName
		' </summary>
		Public Overridable Property CarrierName As System.String
			Get
				Return MyBase.GetSystemString(CarrierMetadata.ColumnNames.CarrierName)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CarrierMetadata.ColumnNames.CarrierName, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CARRIER.CarrierAddress
		' </summary>
		Public Overridable Property CarrierAddress As System.String
			Get
				Return MyBase.GetSystemString(CarrierMetadata.ColumnNames.CarrierAddress)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CarrierMetadata.ColumnNames.CarrierAddress, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CARRIER.CarrierAddress2
		' </summary>
		Public Overridable Property CarrierAddress2 As System.String
			Get
				Return MyBase.GetSystemString(CarrierMetadata.ColumnNames.CarrierAddress2)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CarrierMetadata.ColumnNames.CarrierAddress2, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CARRIER.CarrierCity
		' </summary>
		Public Overridable Property CarrierCity As System.String
			Get
				Return MyBase.GetSystemString(CarrierMetadata.ColumnNames.CarrierCity)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CarrierMetadata.ColumnNames.CarrierCity, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CARRIER.CarrierState
		' </summary>
		Public Overridable Property CarrierState As System.String
			Get
				Return MyBase.GetSystemString(CarrierMetadata.ColumnNames.CarrierState)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CarrierMetadata.ColumnNames.CarrierState, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CARRIER.CarrierZipcode
		' </summary>
		Public Overridable Property CarrierZipcode As System.String
			Get
				Return MyBase.GetSystemString(CarrierMetadata.ColumnNames.CarrierZipcode)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CarrierMetadata.ColumnNames.CarrierZipcode, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CARRIER.CarrierPhone
		' </summary>
		Public Overridable Property CarrierPhone As System.String
			Get
				Return MyBase.GetSystemString(CarrierMetadata.ColumnNames.CarrierPhone)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CarrierMetadata.ColumnNames.CarrierPhone, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CARRIER.CarrierFax
		' </summary>
		Public Overridable Property CarrierFax As System.String
			Get
				Return MyBase.GetSystemString(CarrierMetadata.ColumnNames.CarrierFax)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CarrierMetadata.ColumnNames.CarrierFax, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CARRIER.TermsCarrier
		' </summary>
		Public Overridable Property TermsCarrier As System.String
			Get
				Return MyBase.GetSystemString(CarrierMetadata.ColumnNames.TermsCarrier)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CarrierMetadata.ColumnNames.TermsCarrier, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CARRIER.CarrierContactName
		' </summary>
		Public Overridable Property CarrierContactName As System.String
			Get
				Return MyBase.GetSystemString(CarrierMetadata.ColumnNames.CarrierContactName)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CarrierMetadata.ColumnNames.CarrierContactName, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CARRIER.CarrierContactEmail
		' </summary>
		Public Overridable Property CarrierContactEmail As System.String
			Get
				Return MyBase.GetSystemString(CarrierMetadata.ColumnNames.CarrierContactEmail)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CarrierMetadata.ColumnNames.CarrierContactEmail, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CARRIER.CarrierContactURL
		' </summary>
		Public Overridable Property CarrierContactURL As System.String
			Get
				Return MyBase.GetSystemString(CarrierMetadata.ColumnNames.CarrierContactURL)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CarrierMetadata.ColumnNames.CarrierContactURL, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CARRIER.CREATEDBY
		' </summary>
		Public Overridable Property Createdby As System.String
			Get
				Return MyBase.GetSystemString(CarrierMetadata.ColumnNames.Createdby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CarrierMetadata.ColumnNames.Createdby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CARRIER.CREATEDTIME
		' </summary>
		Public Overridable Property Createdtime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(CarrierMetadata.ColumnNames.Createdtime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(CarrierMetadata.ColumnNames.Createdtime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CARRIER.MODIFYBY
		' </summary>
		Public Overridable Property Modifyby As System.String
			Get
				Return MyBase.GetSystemString(CarrierMetadata.ColumnNames.Modifyby)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CarrierMetadata.ColumnNames.Modifyby, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CARRIER.MODIFYTIME
		' </summary>
		Public Overridable Property Modifytime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(CarrierMetadata.ColumnNames.Modifytime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(CarrierMetadata.ColumnNames.Modifytime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to CARRIER.ISACTIVE
		' </summary>
		Public Overridable Property Isactive As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(CarrierMetadata.ColumnNames.Isactive)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(CarrierMetadata.ColumnNames.Isactive, value)
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
		
			Public Sub New(ByVal entity As esCarrier)
				Me.entity = entity
			End Sub				
		
	
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
		  	
			Public Property CarrierName As System.String 
				Get
					Dim data_ As System.String = entity.CarrierName
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CarrierName = Nothing
					Else
						entity.CarrierName = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CarrierAddress As System.String 
				Get
					Dim data_ As System.String = entity.CarrierAddress
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CarrierAddress = Nothing
					Else
						entity.CarrierAddress = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CarrierAddress2 As System.String 
				Get
					Dim data_ As System.String = entity.CarrierAddress2
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CarrierAddress2 = Nothing
					Else
						entity.CarrierAddress2 = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CarrierCity As System.String 
				Get
					Dim data_ As System.String = entity.CarrierCity
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CarrierCity = Nothing
					Else
						entity.CarrierCity = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CarrierState As System.String 
				Get
					Dim data_ As System.String = entity.CarrierState
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CarrierState = Nothing
					Else
						entity.CarrierState = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CarrierZipcode As System.String 
				Get
					Dim data_ As System.String = entity.CarrierZipcode
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CarrierZipcode = Nothing
					Else
						entity.CarrierZipcode = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CarrierPhone As System.String 
				Get
					Dim data_ As System.String = entity.CarrierPhone
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CarrierPhone = Nothing
					Else
						entity.CarrierPhone = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CarrierFax As System.String 
				Get
					Dim data_ As System.String = entity.CarrierFax
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CarrierFax = Nothing
					Else
						entity.CarrierFax = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property TermsCarrier As System.String 
				Get
					Dim data_ As System.String = entity.TermsCarrier
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.TermsCarrier = Nothing
					Else
						entity.TermsCarrier = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CarrierContactName As System.String 
				Get
					Dim data_ As System.String = entity.CarrierContactName
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CarrierContactName = Nothing
					Else
						entity.CarrierContactName = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CarrierContactEmail As System.String 
				Get
					Dim data_ As System.String = entity.CarrierContactEmail
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CarrierContactEmail = Nothing
					Else
						entity.CarrierContactEmail = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property CarrierContactURL As System.String 
				Get
					Dim data_ As System.String = entity.CarrierContactURL
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CarrierContactURL = Nothing
					Else
						entity.CarrierContactURL = Convert.ToString(Value)
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
		  	
			Public Property Isactive As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Isactive
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Isactive = Nothing
					Else
						entity.Isactive = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  

			Private entity As esCarrier
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esCarrierQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esCarrier can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Carrier 
		Inherits esCarrier
		
	
		
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
	MustInherit Public Class esCarrierQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return CarrierMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property CarrierID As esQueryItem
			Get
				Return New esQueryItem(Me, CarrierMetadata.ColumnNames.CarrierID, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property CarrierName As esQueryItem
			Get
				Return New esQueryItem(Me, CarrierMetadata.ColumnNames.CarrierName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CarrierAddress As esQueryItem
			Get
				Return New esQueryItem(Me, CarrierMetadata.ColumnNames.CarrierAddress, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CarrierAddress2 As esQueryItem
			Get
				Return New esQueryItem(Me, CarrierMetadata.ColumnNames.CarrierAddress2, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CarrierCity As esQueryItem
			Get
				Return New esQueryItem(Me, CarrierMetadata.ColumnNames.CarrierCity, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CarrierState As esQueryItem
			Get
				Return New esQueryItem(Me, CarrierMetadata.ColumnNames.CarrierState, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CarrierZipcode As esQueryItem
			Get
				Return New esQueryItem(Me, CarrierMetadata.ColumnNames.CarrierZipcode, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CarrierPhone As esQueryItem
			Get
				Return New esQueryItem(Me, CarrierMetadata.ColumnNames.CarrierPhone, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CarrierFax As esQueryItem
			Get
				Return New esQueryItem(Me, CarrierMetadata.ColumnNames.CarrierFax, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property TermsCarrier As esQueryItem
			Get
				Return New esQueryItem(Me, CarrierMetadata.ColumnNames.TermsCarrier, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CarrierContactName As esQueryItem
			Get
				Return New esQueryItem(Me, CarrierMetadata.ColumnNames.CarrierContactName, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CarrierContactEmail As esQueryItem
			Get
				Return New esQueryItem(Me, CarrierMetadata.ColumnNames.CarrierContactEmail, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CarrierContactURL As esQueryItem
			Get
				Return New esQueryItem(Me, CarrierMetadata.ColumnNames.CarrierContactURL, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Createdby As esQueryItem
			Get
				Return New esQueryItem(Me, CarrierMetadata.ColumnNames.Createdby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Createdtime As esQueryItem
			Get
				Return New esQueryItem(Me, CarrierMetadata.ColumnNames.Createdtime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Modifyby As esQueryItem
			Get
				Return New esQueryItem(Me, CarrierMetadata.ColumnNames.Modifyby, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Modifytime As esQueryItem
			Get
				Return New esQueryItem(Me, CarrierMetadata.ColumnNames.Modifytime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Isactive As esQueryItem
			Get
				Return New esQueryItem(Me, CarrierMetadata.ColumnNames.Isactive, esSystemType.Boolean)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("CarrierCollection")> _
	Partial Public Class CarrierCollection
		Inherits esCarrierCollection
		Implements IEnumerable(Of Carrier)
		
        Public Shared Widening Operator CType(ByVal coll As CarrierCollection) As List(Of Carrier)
            Dim list As List(Of Carrier) = New List(Of Carrier)
            Dim emp As Carrier

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return CarrierMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New CarrierQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Carrier(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Carrier()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As CarrierQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New CarrierQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As CarrierQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Carrier 
			Return CType(MyBase.AddNewEntity(), Carrier)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal carrierID As System.Int32) As Carrier
			Return CType(MyBase.FindByPrimaryKey(carrierID), Carrier)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Carrier) Implements IEnumerable(Of Carrier).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Carrier)(Me)
        End Function
		
		Private _query As CarrierQuery

	End Class
	


	' <summary>
	' Encapsulates the 'CARRIER' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Carrier ({CarrierID.Value})")> _
	<Serializable> _
	Partial Public Class Carrier 
		Inherits esCarrier

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return CarrierMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esCarrierQuery

			If Me._query Is Nothing Then
				Me._query = New CarrierQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As CarrierQuery
			Get

				If Me._query Is Nothing then
					Me._query = New CarrierQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As CarrierQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As CarrierQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class CarrierQuery
		inherits esCarrierQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "CarrierQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class CarrierMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(CarrierMetadata.ColumnNames.CarrierID, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = CarrierMetadata.PropertyNames.CarrierID
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(CarrierMetadata.ColumnNames.CarrierName, 1, GetType(System.String), esSystemType.String)	
			c.PropertyName = CarrierMetadata.PropertyNames.CarrierName
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CarrierMetadata.ColumnNames.CarrierAddress, 2, GetType(System.String), esSystemType.String)	
			c.PropertyName = CarrierMetadata.PropertyNames.CarrierAddress
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CarrierMetadata.ColumnNames.CarrierAddress2, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = CarrierMetadata.PropertyNames.CarrierAddress2
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CarrierMetadata.ColumnNames.CarrierCity, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = CarrierMetadata.PropertyNames.CarrierCity
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CarrierMetadata.ColumnNames.CarrierState, 5, GetType(System.String), esSystemType.String)	
			c.PropertyName = CarrierMetadata.PropertyNames.CarrierState
			c.CharacterMaxLength = 2
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CarrierMetadata.ColumnNames.CarrierZipcode, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = CarrierMetadata.PropertyNames.CarrierZipcode
			c.CharacterMaxLength = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CarrierMetadata.ColumnNames.CarrierPhone, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = CarrierMetadata.PropertyNames.CarrierPhone
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CarrierMetadata.ColumnNames.CarrierFax, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = CarrierMetadata.PropertyNames.CarrierFax
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CarrierMetadata.ColumnNames.TermsCarrier, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = CarrierMetadata.PropertyNames.TermsCarrier
			c.CharacterMaxLength = 24
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CarrierMetadata.ColumnNames.CarrierContactName, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = CarrierMetadata.PropertyNames.CarrierContactName
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CarrierMetadata.ColumnNames.CarrierContactEmail, 11, GetType(System.String), esSystemType.String)	
			c.PropertyName = CarrierMetadata.PropertyNames.CarrierContactEmail
			c.CharacterMaxLength = 100
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CarrierMetadata.ColumnNames.CarrierContactURL, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = CarrierMetadata.PropertyNames.CarrierContactURL
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CarrierMetadata.ColumnNames.Createdby, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = CarrierMetadata.PropertyNames.Createdby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CarrierMetadata.ColumnNames.Createdtime, 14, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = CarrierMetadata.PropertyNames.Createdtime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CarrierMetadata.ColumnNames.Modifyby, 15, GetType(System.String), esSystemType.String)	
			c.PropertyName = CarrierMetadata.PropertyNames.Modifyby
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CarrierMetadata.ColumnNames.Modifytime, 16, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = CarrierMetadata.PropertyNames.Modifytime
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CarrierMetadata.ColumnNames.Isactive, 17, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = CarrierMetadata.PropertyNames.Isactive
			c.HasDefault = True
			c.Default = "((1))"
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As CarrierMetadata
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
			 Public Const CarrierID As String = "CarrierID"
			 Public Const CarrierName As String = "CarrierName"
			 Public Const CarrierAddress As String = "CarrierAddress"
			 Public Const CarrierAddress2 As String = "CarrierAddress2"
			 Public Const CarrierCity As String = "CarrierCity"
			 Public Const CarrierState As String = "CarrierState"
			 Public Const CarrierZipcode As String = "CarrierZipcode"
			 Public Const CarrierPhone As String = "CarrierPhone"
			 Public Const CarrierFax As String = "CarrierFax"
			 Public Const TermsCarrier As String = "TermsCarrier"
			 Public Const CarrierContactName As String = "CarrierContactName"
			 Public Const CarrierContactEmail As String = "CarrierContactEmail"
			 Public Const CarrierContactURL As String = "CarrierContactURL"
			 Public Const Createdby As String = "CREATEDBY"
			 Public Const Createdtime As String = "CREATEDTIME"
			 Public Const Modifyby As String = "MODIFYBY"
			 Public Const Modifytime As String = "MODIFYTIME"
			 Public Const Isactive As String = "ISACTIVE"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const CarrierID As String = "CarrierID"
			 Public Const CarrierName As String = "CarrierName"
			 Public Const CarrierAddress As String = "CarrierAddress"
			 Public Const CarrierAddress2 As String = "CarrierAddress2"
			 Public Const CarrierCity As String = "CarrierCity"
			 Public Const CarrierState As String = "CarrierState"
			 Public Const CarrierZipcode As String = "CarrierZipcode"
			 Public Const CarrierPhone As String = "CarrierPhone"
			 Public Const CarrierFax As String = "CarrierFax"
			 Public Const TermsCarrier As String = "TermsCarrier"
			 Public Const CarrierContactName As String = "CarrierContactName"
			 Public Const CarrierContactEmail As String = "CarrierContactEmail"
			 Public Const CarrierContactURL As String = "CarrierContactURL"
			 Public Const Createdby As String = "Createdby"
			 Public Const Createdtime As String = "Createdtime"
			 Public Const Modifyby As String = "Modifyby"
			 Public Const Modifytime As String = "Modifytime"
			 Public Const Isactive As String = "Isactive"
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
            SyncLock GetType(CarrierMetadata)
			
				If CarrierMetadata.mapDelegates Is Nothing Then
					CarrierMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If CarrierMetadata._meta Is Nothing Then
                    CarrierMetadata._meta = New CarrierMetadata()
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
				

				meta.AddTypeMap("CarrierID", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("CarrierName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CarrierAddress", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CarrierAddress2", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CarrierCity", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CarrierState", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CarrierZipcode", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CarrierPhone", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CarrierFax", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("TermsCarrier", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CarrierContactName", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CarrierContactEmail", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CarrierContactURL", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Createdby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Createdtime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Modifyby", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Modifytime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Isactive", new esTypeMap("bit", "System.Boolean"))			
				
				
				 
				meta.Source = "CARRIER"
				meta.Destination = "CARRIER"
				
				meta.spInsert = "proc_CARRIERInsert"
				meta.spUpdate = "proc_CARRIERUpdate"
				meta.spDelete = "proc_CARRIERDelete"
				meta.spLoadAll = "proc_CARRIERLoadAll"
				meta.spLoadByPrimaryKey = "proc_CARRIERLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As CarrierMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
