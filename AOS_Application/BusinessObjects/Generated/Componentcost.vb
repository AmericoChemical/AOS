'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 9/6/2018 11:41:24 AM
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
	MustInherit Public Class esComponentcostCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "ComponentcostCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esComponentcostQuery)
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
            Me.InitQuery(CType(query, esComponentcostQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Componentcost) As Componentcost
			Return CType(MyBase.DetachEntity(entity), Componentcost)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Componentcost) As Componentcost
			Return CType(MyBase.AttachEntity(entity), Componentcost)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As ComponentcostCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Componentcost
            Get
                Return TryCast(MyBase.Item(index), Componentcost)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Componentcost)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esComponentcost	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esComponentcostQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal componentCostId As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(componentCostId)
			Else
				Return LoadByPrimaryKeyStoredProcedure(componentCostId)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal componentCostId As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(componentCostId)
			Else
				Return LoadByPrimaryKeyStoredProcedure(componentCostId)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal componentCostId As System.Int32) As Boolean
		
			Dim query As esComponentcostQuery = Me.GetDynamicQuery()
			query.Where(query.ComponentCostId.Equal(componentCostId))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal componentCostId As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("ComponentCostId", componentCostId)
			
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
												
						Case "ComponentCostId"
							Me.str.ComponentCostId = CType(value, string)
												
						Case "ComponentId"
							Me.str.ComponentId = CType(value, string)
												
						Case "VendorId"
							Me.str.VendorId = CType(value, string)
												
						Case "VendorItemId"
							Me.str.VendorItemId = CType(value, string)
												
						Case "VendorItemDesc"
							Me.str.VendorItemDesc = CType(value, string)
												
						Case "EffectiveDate"
							Me.str.EffectiveDate = CType(value, string)
												
						Case "UnitCost"
							Me.str.UnitCost = CType(value, string)
												
						Case "IsDefault"
							Me.str.IsDefault = CType(value, string)
												
						Case "IsActive"
							Me.str.IsActive = CType(value, string)
												
						Case "Notes"
							Me.str.Notes = CType(value, string)
												
						Case "CreatedBy"
							Me.str.CreatedBy = CType(value, string)
												
						Case "CreatedDateTime"
							Me.str.CreatedDateTime = CType(value, string)
												
						Case "ModifiedBy"
							Me.str.ModifiedBy = CType(value, string)
												
						Case "ModifiedDateTime"
							Me.str.ModifiedDateTime = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "ComponentCostId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ComponentCostId = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "ComponentId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.ComponentId = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "VendorId"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.VendorId = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "EffectiveDate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.EffectiveDate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "UnitCost"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.UnitCost = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "IsDefault"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.IsDefault = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "IsActive"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.IsActive = CType(value, Nullable(Of System.Boolean))
							End If
						
						Case "CreatedDateTime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.CreatedDateTime = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "ModifiedDateTime"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.ModifiedDateTime = CType(value, Nullable(Of System.DateTime))
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
		' Maps to COMPONENTCOST.ComponentCostId
		' </summary>
		Public Overridable Property ComponentCostId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ComponentcostMetadata.ColumnNames.ComponentCostId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ComponentcostMetadata.ColumnNames.ComponentCostId, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to COMPONENTCOST.ComponentId
		' </summary>
		Public Overridable Property ComponentId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ComponentcostMetadata.ColumnNames.ComponentId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(ComponentcostMetadata.ColumnNames.ComponentId, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to COMPONENTCOST.VendorId
		' </summary>
		Public Overridable Property VendorId As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(ComponentcostMetadata.ColumnNames.VendorId)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				If MyBase.SetSystemInt32(ComponentcostMetadata.ColumnNames.VendorId, value) Then
					Me._UpToVendorByVendorId = Nothing
				End If
			End Set
		End Property		
			
		' <summary>
		' Maps to COMPONENTCOST.VendorItemId
		' </summary>
		Public Overridable Property VendorItemId As System.String
			Get
				Return MyBase.GetSystemString(ComponentcostMetadata.ColumnNames.VendorItemId)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ComponentcostMetadata.ColumnNames.VendorItemId, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to COMPONENTCOST.VendorItemDesc
		' </summary>
		Public Overridable Property VendorItemDesc As System.String
			Get
				Return MyBase.GetSystemString(ComponentcostMetadata.ColumnNames.VendorItemDesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ComponentcostMetadata.ColumnNames.VendorItemDesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to COMPONENTCOST.EffectiveDate
		' </summary>
		Public Overridable Property EffectiveDate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ComponentcostMetadata.ColumnNames.EffectiveDate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ComponentcostMetadata.ColumnNames.EffectiveDate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to COMPONENTCOST.UnitCost
		' </summary>
		Public Overridable Property UnitCost As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(ComponentcostMetadata.ColumnNames.UnitCost)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(ComponentcostMetadata.ColumnNames.UnitCost, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to COMPONENTCOST.IsDefault
		' </summary>
		Public Overridable Property IsDefault As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ComponentcostMetadata.ColumnNames.IsDefault)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ComponentcostMetadata.ColumnNames.IsDefault, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to COMPONENTCOST.IsActive
		' </summary>
		Public Overridable Property IsActive As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(ComponentcostMetadata.ColumnNames.IsActive)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(ComponentcostMetadata.ColumnNames.IsActive, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to COMPONENTCOST.Notes
		' </summary>
		Public Overridable Property Notes As System.String
			Get
				Return MyBase.GetSystemString(ComponentcostMetadata.ColumnNames.Notes)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ComponentcostMetadata.ColumnNames.Notes, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to COMPONENTCOST.CreatedBy
		' </summary>
		Public Overridable Property CreatedBy As System.String
			Get
				Return MyBase.GetSystemString(ComponentcostMetadata.ColumnNames.CreatedBy)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ComponentcostMetadata.ColumnNames.CreatedBy, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to COMPONENTCOST.CreatedDateTime
		' </summary>
		Public Overridable Property CreatedDateTime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ComponentcostMetadata.ColumnNames.CreatedDateTime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ComponentcostMetadata.ColumnNames.CreatedDateTime, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to COMPONENTCOST.ModifiedBy
		' </summary>
		Public Overridable Property ModifiedBy As System.String
			Get
				Return MyBase.GetSystemString(ComponentcostMetadata.ColumnNames.ModifiedBy)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(ComponentcostMetadata.ColumnNames.ModifiedBy, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to COMPONENTCOST.ModifiedDateTime
		' </summary>
		Public Overridable Property ModifiedDateTime As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(ComponentcostMetadata.ColumnNames.ModifiedDateTime)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(ComponentcostMetadata.ColumnNames.ModifiedDateTime, value)
			End Set
		End Property		
		
		<CLSCompliant(false)> _
		Dim Friend Protected _UpToVendorByVendorId As Vendor
		
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
		
			Public Sub New(ByVal entity As esComponentcost)
				Me.entity = entity
			End Sub				
		
	
			Public Property ComponentCostId As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.ComponentCostId
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ComponentCostId = Nothing
					Else
						entity.ComponentCostId = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property ComponentId As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.ComponentId
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ComponentId = Nothing
					Else
						entity.ComponentId = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property VendorId As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.VendorId
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.VendorId = Nothing
					Else
						entity.VendorId = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property VendorItemId As System.String 
				Get
					Dim data_ As System.String = entity.VendorItemId
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.VendorItemId = Nothing
					Else
						entity.VendorItemId = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property VendorItemDesc As System.String 
				Get
					Dim data_ As System.String = entity.VendorItemDesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.VendorItemDesc = Nothing
					Else
						entity.VendorItemDesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property EffectiveDate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.EffectiveDate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.EffectiveDate = Nothing
					Else
						entity.EffectiveDate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property UnitCost As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.UnitCost
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.UnitCost = Nothing
					Else
						entity.UnitCost = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property IsDefault As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.IsDefault
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.IsDefault = Nothing
					Else
						entity.IsDefault = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property IsActive As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.IsActive
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.IsActive = Nothing
					Else
						entity.IsActive = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  	
			Public Property Notes As System.String 
				Get
					Dim data_ As System.String = entity.Notes
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Notes = Nothing
					Else
						entity.Notes = Convert.ToString(Value)
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
		  	
			Public Property CreatedDateTime As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.CreatedDateTime
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.CreatedDateTime = Nothing
					Else
						entity.CreatedDateTime = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property ModifiedBy As System.String 
				Get
					Dim data_ As System.String = entity.ModifiedBy
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ModifiedBy = Nothing
					Else
						entity.ModifiedBy = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property ModifiedDateTime As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.ModifiedDateTime
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.ModifiedDateTime = Nothing
					Else
						entity.ModifiedDateTime = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  

			Private entity As esComponentcost
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esComponentcostQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esComponentcost can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Componentcost 
		Inherits esComponentcost
		
	
		#Region "UpToVendorByVendorId - Many To One"
		''' <summary>
		''' Many to One
		''' Foreign Key Name - FK_COMPONENTCOST_VENDOR
		''' </summary>

		<XmlIgnore()> _
		Public Property UpToVendorByVendorId As Vendor
		
			Get
				If Me._UpToVendorByVendorId Is Nothing _
						 AndAlso Not VendorId.Equals(Nothing)  Then
						
					Me._UpToVendorByVendorId = New Vendor()
					Me._UpToVendorByVendorId.es.Connection.Name = Me.es.Connection.Name
					Me.SetPreSave("UpToVendorByVendorId", Me._UpToVendorByVendorId)
					Me._UpToVendorByVendorId.Query.Where(Me._UpToVendorByVendorId.Query.Vendorid.Equal(Me.VendorId))
					Me._UpToVendorByVendorId.Query.Load()
				End If

				Return Me._UpToVendorByVendorId
			End Get
			
            Set(ByVal value As Vendor)
				Me.RemovePreSave("UpToVendorByVendorId")
				

				If value Is Nothing Then
				
					Me.VendorId = Nothing
				
					Me._UpToVendorByVendorId = Nothing
				Else
				
					Me.VendorId = value.Vendorid
					
					Me._UpToVendorByVendorId = value
					Me.SetPreSave("UpToVendorByVendorId", Me._UpToVendorByVendorId)
				End If
				
            End Set				

		End Property
		#End Region

		
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
		
			If Not Me.es.IsDeleted And Not Me._UpToVendorByVendorId Is Nothing Then
				Me.VendorId = Me._UpToVendorByVendorId.Vendorid
			End If
			
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
	MustInherit Public Class esComponentcostQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ComponentcostMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property ComponentCostId As esQueryItem
			Get
				Return New esQueryItem(Me, ComponentcostMetadata.ColumnNames.ComponentCostId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property ComponentId As esQueryItem
			Get
				Return New esQueryItem(Me, ComponentcostMetadata.ColumnNames.ComponentId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property VendorId As esQueryItem
			Get
				Return New esQueryItem(Me, ComponentcostMetadata.ColumnNames.VendorId, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property VendorItemId As esQueryItem
			Get
				Return New esQueryItem(Me, ComponentcostMetadata.ColumnNames.VendorItemId, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property VendorItemDesc As esQueryItem
			Get
				Return New esQueryItem(Me, ComponentcostMetadata.ColumnNames.VendorItemDesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property EffectiveDate As esQueryItem
			Get
				Return New esQueryItem(Me, ComponentcostMetadata.ColumnNames.EffectiveDate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property UnitCost As esQueryItem
			Get
				Return New esQueryItem(Me, ComponentcostMetadata.ColumnNames.UnitCost, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property IsDefault As esQueryItem
			Get
				Return New esQueryItem(Me, ComponentcostMetadata.ColumnNames.IsDefault, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property IsActive As esQueryItem
			Get
				Return New esQueryItem(Me, ComponentcostMetadata.ColumnNames.IsActive, esSystemType.Boolean)
			End Get
		End Property 
		
		Public ReadOnly Property Notes As esQueryItem
			Get
				Return New esQueryItem(Me, ComponentcostMetadata.ColumnNames.Notes, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CreatedBy As esQueryItem
			Get
				Return New esQueryItem(Me, ComponentcostMetadata.ColumnNames.CreatedBy, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property CreatedDateTime As esQueryItem
			Get
				Return New esQueryItem(Me, ComponentcostMetadata.ColumnNames.CreatedDateTime, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property ModifiedBy As esQueryItem
			Get
				Return New esQueryItem(Me, ComponentcostMetadata.ColumnNames.ModifiedBy, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property ModifiedDateTime As esQueryItem
			Get
				Return New esQueryItem(Me, ComponentcostMetadata.ColumnNames.ModifiedDateTime, esSystemType.DateTime)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("ComponentcostCollection")> _
	Partial Public Class ComponentcostCollection
		Inherits esComponentcostCollection
		Implements IEnumerable(Of Componentcost)
		
        Public Shared Widening Operator CType(ByVal coll As ComponentcostCollection) As List(Of Componentcost)
            Dim list As List(Of Componentcost) = New List(Of Componentcost)
            Dim emp As Componentcost

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return ComponentcostMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New ComponentcostQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Componentcost(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Componentcost()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As ComponentcostQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New ComponentcostQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ComponentcostQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Componentcost 
			Return CType(MyBase.AddNewEntity(), Componentcost)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal componentCostId As System.Int32) As Componentcost
			Return CType(MyBase.FindByPrimaryKey(componentCostId), Componentcost)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Componentcost) Implements IEnumerable(Of Componentcost).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Componentcost)(Me)
        End Function
		
		Private _query As ComponentcostQuery

	End Class
	


	' <summary>
	' Encapsulates the 'COMPONENTCOST' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Componentcost ({ComponentCostId.Value})")> _
	<Serializable> _
	Partial Public Class Componentcost 
		Inherits esComponentcost

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return ComponentcostMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esComponentcostQuery

			If Me._query Is Nothing Then
				Me._query = New ComponentcostQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As ComponentcostQuery
			Get

				If Me._query Is Nothing then
					Me._query = New ComponentcostQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As ComponentcostQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As ComponentcostQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class ComponentcostQuery
		inherits esComponentcostQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "ComponentcostQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class ComponentcostMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(ComponentcostMetadata.ColumnNames.ComponentCostId, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ComponentcostMetadata.PropertyNames.ComponentCostId
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ComponentcostMetadata.ColumnNames.ComponentId, 1, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ComponentcostMetadata.PropertyNames.ComponentId
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(ComponentcostMetadata.ColumnNames.VendorId, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = ComponentcostMetadata.PropertyNames.VendorId
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ComponentcostMetadata.ColumnNames.VendorItemId, 3, GetType(System.String), esSystemType.String)	
			c.PropertyName = ComponentcostMetadata.PropertyNames.VendorItemId
			c.CharacterMaxLength = 255
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ComponentcostMetadata.ColumnNames.VendorItemDesc, 4, GetType(System.String), esSystemType.String)	
			c.PropertyName = ComponentcostMetadata.PropertyNames.VendorItemDesc
			c.CharacterMaxLength = 255
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ComponentcostMetadata.ColumnNames.EffectiveDate, 5, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ComponentcostMetadata.PropertyNames.EffectiveDate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ComponentcostMetadata.ColumnNames.UnitCost, 6, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = ComponentcostMetadata.PropertyNames.UnitCost
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ComponentcostMetadata.ColumnNames.IsDefault, 7, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ComponentcostMetadata.PropertyNames.IsDefault
			c.HasDefault = True
			c.Default = "((0))"
			_columns.Add(c)
				
			c = New esColumnMetadata(ComponentcostMetadata.ColumnNames.IsActive, 8, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = ComponentcostMetadata.PropertyNames.IsActive
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ComponentcostMetadata.ColumnNames.Notes, 9, GetType(System.String), esSystemType.String)	
			c.PropertyName = ComponentcostMetadata.PropertyNames.Notes
			c.CharacterMaxLength = 2147483647
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ComponentcostMetadata.ColumnNames.CreatedBy, 10, GetType(System.String), esSystemType.String)	
			c.PropertyName = ComponentcostMetadata.PropertyNames.CreatedBy
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ComponentcostMetadata.ColumnNames.CreatedDateTime, 11, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ComponentcostMetadata.PropertyNames.CreatedDateTime
			c.HasDefault = True
			c.Default = "(getdate())"
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ComponentcostMetadata.ColumnNames.ModifiedBy, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = ComponentcostMetadata.PropertyNames.ModifiedBy
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(ComponentcostMetadata.ColumnNames.ModifiedDateTime, 13, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = ComponentcostMetadata.PropertyNames.ModifiedDateTime
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As ComponentcostMetadata
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
			 Public Const ComponentCostId As String = "ComponentCostId"
			 Public Const ComponentId As String = "ComponentId"
			 Public Const VendorId As String = "VendorId"
			 Public Const VendorItemId As String = "VendorItemId"
			 Public Const VendorItemDesc As String = "VendorItemDesc"
			 Public Const EffectiveDate As String = "EffectiveDate"
			 Public Const UnitCost As String = "UnitCost"
			 Public Const IsDefault As String = "IsDefault"
			 Public Const IsActive As String = "IsActive"
			 Public Const Notes As String = "Notes"
			 Public Const CreatedBy As String = "CreatedBy"
			 Public Const CreatedDateTime As String = "CreatedDateTime"
			 Public Const ModifiedBy As String = "ModifiedBy"
			 Public Const ModifiedDateTime As String = "ModifiedDateTime"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const ComponentCostId As String = "ComponentCostId"
			 Public Const ComponentId As String = "ComponentId"
			 Public Const VendorId As String = "VendorId"
			 Public Const VendorItemId As String = "VendorItemId"
			 Public Const VendorItemDesc As String = "VendorItemDesc"
			 Public Const EffectiveDate As String = "EffectiveDate"
			 Public Const UnitCost As String = "UnitCost"
			 Public Const IsDefault As String = "IsDefault"
			 Public Const IsActive As String = "IsActive"
			 Public Const Notes As String = "Notes"
			 Public Const CreatedBy As String = "CreatedBy"
			 Public Const CreatedDateTime As String = "CreatedDateTime"
			 Public Const ModifiedBy As String = "ModifiedBy"
			 Public Const ModifiedDateTime As String = "ModifiedDateTime"
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
            SyncLock GetType(ComponentcostMetadata)
			
				If ComponentcostMetadata.mapDelegates Is Nothing Then
					ComponentcostMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If ComponentcostMetadata._meta Is Nothing Then
                    ComponentcostMetadata._meta = New ComponentcostMetadata()
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
				

				meta.AddTypeMap("ComponentCostId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("ComponentId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("VendorId", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("VendorItemId", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("VendorItemDesc", new esTypeMap("nvarchar", "System.String"))
				meta.AddTypeMap("EffectiveDate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("UnitCost", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("IsDefault", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("IsActive", new esTypeMap("bit", "System.Boolean"))
				meta.AddTypeMap("Notes", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CreatedBy", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("CreatedDateTime", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("ModifiedBy", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("ModifiedDateTime", new esTypeMap("datetime", "System.DateTime"))			
				
				
				 
				meta.Source = "COMPONENTCOST"
				meta.Destination = "COMPONENTCOST"
				
				meta.spInsert = "proc_COMPONENTCOSTInsert"
				meta.spUpdate = "proc_COMPONENTCOSTUpdate"
				meta.spDelete = "proc_COMPONENTCOSTDelete"
				meta.spLoadAll = "proc_COMPONENTCOSTLoadAll"
				meta.spLoadByPrimaryKey = "proc_COMPONENTCOSTLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As ComponentcostMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
