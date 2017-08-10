'===============================================================================
'                   EntitySpaces 2009 by EntitySpaces, LLC
'            Persistence Layer and Business Objects for Microsoft .NET
'            EntitySpaces(TM) is a legal trademark of EntitySpaces, LLC
'                         http://www.entityspaces.net
'===============================================================================
' EntitySpaces Version : 2009.2.1214.0
' EntitySpaces Driver  : SQL
' Date Generated       : 10/14/2016 12:29:12 PM
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
	MustInherit Public Class esCommissionCollection		
		Inherits esEntityCollection 
	
        Public Sub New()
		
        End Sub
		
        Protected Overrides Function GetCollectionName() As String
			Return "CommissionCollection"
		End Function		
		
		#Region "Query Logic"	
		
		Protected Sub InitQuery(ByVal query As esCommissionQuery)
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
            Me.InitQuery(CType(query, esCommissionQuery))
        End Sub			
		
		#End Region
		
		Public Overloads Function DetachEntity(ByVal entity As Commission) As Commission
			Return CType(MyBase.DetachEntity(entity), Commission)
		End Function
		
		Public Overloads Function AttachEntity(ByVal entity As Commission) As Commission
			Return CType(MyBase.AttachEntity(entity), Commission)
		End Function		
	
		Public Overloads Sub Combine(ByVal collection As CommissionCollection)
			MyBase.Combine(collection)
		End Sub
		
        Default Public Overloads ReadOnly Property Item(ByVal index As Integer) As Commission
            Get
                Return TryCast(MyBase.Item(index), Commission)
            End Get
        End Property	

		Public Overrides Function GetEntityType() As Type
			Return GetType(Commission)
		End Function
		
	End Class



	<Serializable()> _
	MustInherit Public Class esCommission	
		Inherits esEntity
	
		Protected Overridable Function GetDynamicQuery() As esCommissionQuery
			return Nothing
		End Function
		
		Public Sub New()
		End Sub
	
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub		
		
#Region "LoadByPrimaryKey"		
		Public Overridable Function LoadByPrimaryKey(ByVal commissionid As System.Int32) As Boolean
		
			If Me.es.Connection.SqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(commissionid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(commissionid)
			End If
			
		End Function
	
		Public Overridable Function LoadByPrimaryKey(ByVal sqlAccessType As esSqlAccessType, ByVal commissionid As System.Int32) As Boolean
		
			If sqlAccessType = esSqlAccessType.DynamicSQL
				Return LoadByPrimaryKeyDynamic(commissionid)
			Else
				Return LoadByPrimaryKeyStoredProcedure(commissionid)
			End If
			
		End Function
	
		Private Function LoadByPrimaryKeyDynamic(ByVal commissionid As System.Int32) As Boolean
		
			Dim query As esCommissionQuery = Me.GetDynamicQuery()
			query.Where(query.Commissionid.Equal(commissionid))
			return query.Load()
			
		End Function
	
		Private Function LoadByPrimaryKeyStoredProcedure(ByVal commissionid As System.Int32) As Boolean
		
			Dim parms As esParameters = New esParameters()
			parms.Add("COMMISSIONID", commissionid)
			
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
												
						Case "Commissionid"
							Me.str.Commissionid = CType(value, string)
												
						Case "Commissiondate"
							Me.str.Commissiondate = CType(value, string)
												
						Case "Salespersonid"
							Me.str.Salespersonid = CType(value, string)
												
						Case "Custid"
							Me.str.Custid = CType(value, string)
												
						Case "Invoicenumber"
							Me.str.Invoicenumber = CType(value, string)
												
						Case "Commissionamount"
							Me.str.Commissionamount = CType(value, string)
												
						Case "Commissionstatus"
							Me.str.Commissionstatus = CType(value, string)
												
						Case "Commissiondesc"
							Me.str.Commissiondesc = CType(value, string)
												
						Case "Commissiontype"
							Me.str.Commissiontype = CType(value, string)
												
						Case "Datecustomerpaid"
							Me.str.Datecustomerpaid = CType(value, string)
												
						Case "Datecommissionpaid"
							Me.str.Datecommissionpaid = CType(value, string)
												
						Case "Commissionpmtid"
							Me.str.Commissionpmtid = CType(value, string)
												
						Case "Commissionnote"
							Me.str.Commissionnote = CType(value, string)
												
						Case "Commissioncategory"
							Me.str.Commissioncategory = CType(value, string)
												
						Case "Audited"
							Me.str.Audited = CType(value, string)
					
					End Select
					
				Else
				
					Select Case name
						
						Case "Commissionid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Commissionid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Commissiondate"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Commissiondate = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Salespersonid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Salespersonid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Custid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Custid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Invoicenumber"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Invoicenumber = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Commissionamount"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Decimal" Then
								Me.Commissionamount = CType(value, Nullable(Of System.Decimal))
							End If
						
						Case "Datecustomerpaid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Datecustomerpaid = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Datecommissionpaid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.DateTime" Then
								Me.Datecommissionpaid = CType(value, Nullable(Of System.DateTime))
							End If
						
						Case "Commissionpmtid"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Int32" Then
								Me.Commissionpmtid = CType(value, Nullable(Of System.Int32))
							End If
						
						Case "Audited"
						
							If value Is Nothing Or value.GetType().ToString() = "System.Boolean" Then
								Me.Audited = CType(value, Nullable(Of System.Boolean))
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
		' Maps to COMMISSION.COMMISSIONID
		' </summary>
		Public Overridable Property Commissionid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(CommissionMetadata.ColumnNames.Commissionid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(CommissionMetadata.ColumnNames.Commissionid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to COMMISSION.COMMISSIONDATE
		' </summary>
		Public Overridable Property Commissiondate As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(CommissionMetadata.ColumnNames.Commissiondate)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(CommissionMetadata.ColumnNames.Commissiondate, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to COMMISSION.SALESPERSONID
		' </summary>
		Public Overridable Property Salespersonid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(CommissionMetadata.ColumnNames.Salespersonid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(CommissionMetadata.ColumnNames.Salespersonid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to COMMISSION.CUSTID
		' </summary>
		Public Overridable Property Custid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(CommissionMetadata.ColumnNames.Custid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(CommissionMetadata.ColumnNames.Custid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to COMMISSION.INVOICENUMBER
		' </summary>
		Public Overridable Property Invoicenumber As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(CommissionMetadata.ColumnNames.Invoicenumber)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(CommissionMetadata.ColumnNames.Invoicenumber, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to COMMISSION.COMMISSIONAMOUNT
		' </summary>
		Public Overridable Property Commissionamount As Nullable(Of System.Decimal)
			Get
				Return MyBase.GetSystemDecimal(CommissionMetadata.ColumnNames.Commissionamount)
			End Get
			
			Set(ByVal value As Nullable(Of System.Decimal))
				MyBase.SetSystemDecimal(CommissionMetadata.ColumnNames.Commissionamount, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to COMMISSION.COMMISSIONSTATUS
		' </summary>
		Public Overridable Property Commissionstatus As System.String
			Get
				Return MyBase.GetSystemString(CommissionMetadata.ColumnNames.Commissionstatus)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CommissionMetadata.ColumnNames.Commissionstatus, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to COMMISSION.COMMISSIONDESC
		' </summary>
		Public Overridable Property Commissiondesc As System.String
			Get
				Return MyBase.GetSystemString(CommissionMetadata.ColumnNames.Commissiondesc)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CommissionMetadata.ColumnNames.Commissiondesc, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to COMMISSION.COMMISSIONTYPE
		' </summary>
		Public Overridable Property Commissiontype As System.String
			Get
				Return MyBase.GetSystemString(CommissionMetadata.ColumnNames.Commissiontype)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CommissionMetadata.ColumnNames.Commissiontype, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to COMMISSION.DATECUSTOMERPAID
		' </summary>
		Public Overridable Property Datecustomerpaid As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(CommissionMetadata.ColumnNames.Datecustomerpaid)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(CommissionMetadata.ColumnNames.Datecustomerpaid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to COMMISSION.DATECOMMISSIONPAID
		' </summary>
		Public Overridable Property Datecommissionpaid As Nullable(Of System.DateTime)
			Get
				Return MyBase.GetSystemDateTime(CommissionMetadata.ColumnNames.Datecommissionpaid)
			End Get
			
			Set(ByVal value As Nullable(Of System.DateTime))
				MyBase.SetSystemDateTime(CommissionMetadata.ColumnNames.Datecommissionpaid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to COMMISSION.COMMISSIONPMTID
		' </summary>
		Public Overridable Property Commissionpmtid As Nullable(Of System.Int32)
			Get
				Return MyBase.GetSystemInt32(CommissionMetadata.ColumnNames.Commissionpmtid)
			End Get
			
			Set(ByVal value As Nullable(Of System.Int32))
				MyBase.SetSystemInt32(CommissionMetadata.ColumnNames.Commissionpmtid, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to COMMISSION.COMMISSIONNOTE
		' </summary>
		Public Overridable Property Commissionnote As System.String
			Get
				Return MyBase.GetSystemString(CommissionMetadata.ColumnNames.Commissionnote)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CommissionMetadata.ColumnNames.Commissionnote, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to COMMISSION.COMMISSIONCATEGORY
		' </summary>
		Public Overridable Property Commissioncategory As System.String
			Get
				Return MyBase.GetSystemString(CommissionMetadata.ColumnNames.Commissioncategory)
			End Get
			
			Set(ByVal value As System.String)
				MyBase.SetSystemString(CommissionMetadata.ColumnNames.Commissioncategory, value)
			End Set
		End Property		
			
		' <summary>
		' Maps to COMMISSION.AUDITED
		' </summary>
		Public Overridable Property Audited As Nullable(Of System.Boolean)
			Get
				Return MyBase.GetSystemBoolean(CommissionMetadata.ColumnNames.Audited)
			End Get
			
			Set(ByVal value As Nullable(Of System.Boolean))
				MyBase.SetSystemBoolean(CommissionMetadata.ColumnNames.Audited, value)
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
		
			Public Sub New(ByVal entity As esCommission)
				Me.entity = entity
			End Sub				
		
	
			Public Property Commissionid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Commissionid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Commissionid = Nothing
					Else
						entity.Commissionid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Commissiondate As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Commissiondate
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Commissiondate = Nothing
					Else
						entity.Commissiondate = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Salespersonid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Salespersonid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Salespersonid = Nothing
					Else
						entity.Salespersonid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Custid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Custid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Custid = Nothing
					Else
						entity.Custid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Invoicenumber As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Invoicenumber
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Invoicenumber = Nothing
					Else
						entity.Invoicenumber = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Commissionamount As System.String 
				Get
					Dim data_ As Nullable(Of System.Decimal) = entity.Commissionamount
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Commissionamount = Nothing
					Else
						entity.Commissionamount = Convert.ToDecimal(Value)
					End If
				End Set
			End Property
		  	
			Public Property Commissionstatus As System.String 
				Get
					Dim data_ As System.String = entity.Commissionstatus
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Commissionstatus = Nothing
					Else
						entity.Commissionstatus = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Commissiondesc As System.String 
				Get
					Dim data_ As System.String = entity.Commissiondesc
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Commissiondesc = Nothing
					Else
						entity.Commissiondesc = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Commissiontype As System.String 
				Get
					Dim data_ As System.String = entity.Commissiontype
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Commissiontype = Nothing
					Else
						entity.Commissiontype = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Datecustomerpaid As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Datecustomerpaid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Datecustomerpaid = Nothing
					Else
						entity.Datecustomerpaid = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Datecommissionpaid As System.String 
				Get
					Dim data_ As Nullable(Of System.DateTime) = entity.Datecommissionpaid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Datecommissionpaid = Nothing
					Else
						entity.Datecommissionpaid = Convert.ToDateTime(Value)
					End If
				End Set
			End Property
		  	
			Public Property Commissionpmtid As System.String 
				Get
					Dim data_ As Nullable(Of System.Int32) = entity.Commissionpmtid
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Commissionpmtid = Nothing
					Else
						entity.Commissionpmtid = Convert.ToInt32(Value)
					End If
				End Set
			End Property
		  	
			Public Property Commissionnote As System.String 
				Get
					Dim data_ As System.String = entity.Commissionnote
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Commissionnote = Nothing
					Else
						entity.Commissionnote = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Commissioncategory As System.String 
				Get
					Dim data_ As System.String = entity.Commissioncategory
					
					if data_ Is Nothing Then
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Commissioncategory = Nothing
					Else
						entity.Commissioncategory = Convert.ToString(Value)
					End If
				End Set
			End Property
		  	
			Public Property Audited As System.String 
				Get
					Dim data_ As Nullable(Of System.Boolean) = entity.Audited
					
					If Not data_.HasValue Then
					
						Return String.Empty
					Else
						Return Convert.ToString(data_)
					End If
				End Get

				Set(ByVal Value as System.String)
					If String.IsNullOrEmpty(value) Then
						entity.Audited = Nothing
					Else
						entity.Audited = Convert.ToBoolean(Value)
					End If
				End Set
			End Property
		  

			Private entity As esCommission
		End Class
#End Region

#Region "Query Logic"
		
		Protected Sub InitQuery(ByVal query As esCommissionQuery)
			query.OnLoadDelegate = AddressOf OnQueryLoaded
			query.es2.Connection = CType(Me, IEntity).Connection
		End Sub
		
		<System.Diagnostics.DebuggerNonUserCode> _
		Protected Function OnQueryLoaded(ByVal table As DataTable) As Boolean
			Dim dataFound as Boolean = Me.PopulateEntity(table)

			If Me.RowCount > 1 Then
				throw New Exception("esCommission can only hold one record of data")
			End If
			
			Return dataFound
        End Function		

#End Region
		

		<NonSerialized()> _		
		Private _esstrings As esStrings
	End Class


	
	Partial Public Class Commission 
		Inherits esCommission
		
	
		
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
	MustInherit Public Class esCommissionQuery 
		Inherits esDynamicQuery 
	
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return CommissionMetadata.Meta()
			End Get
		End Property
		

		Public ReadOnly Property Commissionid As esQueryItem
			Get
				Return New esQueryItem(Me, CommissionMetadata.ColumnNames.Commissionid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Commissiondate As esQueryItem
			Get
				Return New esQueryItem(Me, CommissionMetadata.ColumnNames.Commissiondate, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Salespersonid As esQueryItem
			Get
				Return New esQueryItem(Me, CommissionMetadata.ColumnNames.Salespersonid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Custid As esQueryItem
			Get
				Return New esQueryItem(Me, CommissionMetadata.ColumnNames.Custid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Invoicenumber As esQueryItem
			Get
				Return New esQueryItem(Me, CommissionMetadata.ColumnNames.Invoicenumber, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Commissionamount As esQueryItem
			Get
				Return New esQueryItem(Me, CommissionMetadata.ColumnNames.Commissionamount, esSystemType.Decimal)
			End Get
		End Property 
		
		Public ReadOnly Property Commissionstatus As esQueryItem
			Get
				Return New esQueryItem(Me, CommissionMetadata.ColumnNames.Commissionstatus, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Commissiondesc As esQueryItem
			Get
				Return New esQueryItem(Me, CommissionMetadata.ColumnNames.Commissiondesc, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Commissiontype As esQueryItem
			Get
				Return New esQueryItem(Me, CommissionMetadata.ColumnNames.Commissiontype, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Datecustomerpaid As esQueryItem
			Get
				Return New esQueryItem(Me, CommissionMetadata.ColumnNames.Datecustomerpaid, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Datecommissionpaid As esQueryItem
			Get
				Return New esQueryItem(Me, CommissionMetadata.ColumnNames.Datecommissionpaid, esSystemType.DateTime)
			End Get
		End Property 
		
		Public ReadOnly Property Commissionpmtid As esQueryItem
			Get
				Return New esQueryItem(Me, CommissionMetadata.ColumnNames.Commissionpmtid, esSystemType.Int32)
			End Get
		End Property 
		
		Public ReadOnly Property Commissionnote As esQueryItem
			Get
				Return New esQueryItem(Me, CommissionMetadata.ColumnNames.Commissionnote, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Commissioncategory As esQueryItem
			Get
				Return New esQueryItem(Me, CommissionMetadata.ColumnNames.Commissioncategory, esSystemType.String)
			End Get
		End Property 
		
		Public ReadOnly Property Audited As esQueryItem
			Get
				Return New esQueryItem(Me, CommissionMetadata.ColumnNames.Audited, esSystemType.Boolean)
			End Get
		End Property 
		
	End Class



    <System.Diagnostics.DebuggerDisplay("Count = {Count}")> _
	<Serializable> _
	<XmlType("CommissionCollection")> _
	Partial Public Class CommissionCollection
		Inherits esCommissionCollection
		Implements IEnumerable(Of Commission)
		
        Public Shared Widening Operator CType(ByVal coll As CommissionCollection) As List(Of Commission)
            Dim list As List(Of Commission) = New List(Of Commission)
            Dim emp As Commission

            For Each emp In coll
                list.Add(emp)
            Next

            Return list
        End Operator		
				
		#Region "Housekeeping methods"
		Protected ReadOnly Overrides Property Meta() As IMetadata
			Get
				Return CommissionMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esDynamicQuery 

			If Me._query Is Nothing Then
				Me._query = New CommissionQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		
		Protected Overrides Function CreateEntityForCollection(ByVal row As DataRow) As esEntity
			return New Commission(row)
		End function

		Protected Overrides Function CreateEntity() As esEntity
			Return New Commission()
		End function
		
				
		#End Region
		
		Public ReadOnly Property Query As CommissionQuery 
			Get
				If Me._query Is Nothing Then
					Me._query = New CommissionQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As CommissionQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function		

		Public Function AddNew() As Commission 
			Return CType(MyBase.AddNewEntity(), Commission)
		End Function

		Public Overloads Function FindByPrimaryKey(ByVal commissionid As System.Int32) As Commission
			Return CType(MyBase.FindByPrimaryKey(commissionid), Commission)
		End Function
		
        Function GetEnumerator() As IEnumerator(Of Commission) Implements IEnumerable(Of Commission).GetEnumerator
            Return New esEntityCollectionEnumeratorGeneric(Of Commission)(Me)
        End Function
		
		Private _query As CommissionQuery

	End Class
	


	' <summary>
	' Encapsulates the 'COMMISSION' table
	' </summary>

    <System.Diagnostics.DebuggerDisplay("Commission ({Commissionid.Value})")> _
	<Serializable> _
	Partial Public Class Commission 
		Inherits esCommission

        Public Sub New()
            MyBase.New()
        End Sub
		
		Public Sub New(ByVal row As DataRow)
			MyBase.New(row)
		End Sub
		
		#Region "Housekeeping methods"
		Protected Readonly Overrides Property Meta As IMetadata 
			Get
				Return CommissionMetadata.Meta()
			End Get
		End Property
		
				

		Protected Overrides Function GetDynamicQuery() As esCommissionQuery

			If Me._query Is Nothing Then
				Me._query = New CommissionQuery()
				Me.InitQuery(_query)
			End If

			Return Me._query
		End Function
		#End Region
		
		


		<BrowsableAttribute(False)> _
		Public ReadOnly Property Query As CommissionQuery
			Get

				If Me._query Is Nothing then
					Me._query = New CommissionQuery()
					Me.InitQuery(_query)
				End If

				Return Me._query
			End Get
		End Property

		Public Sub QueryReset()
			Me._query = Nothing
		End Sub
		
		Public Shadows Function Load(ByVal query As CommissionQuery) As Boolean
            Me._query = query
            Me.InitQuery(_query)
            Return Me.Query.Load()
		End Function

		Private _query As CommissionQuery

   End Class
   




    <System.Diagnostics.DebuggerDisplay("LastQuery = {es.LastQuery}")> _
	<Serializable> _
	Partial Public Class CommissionQuery
		inherits esCommissionQuery
		
        Public Sub New(ByVal joinAlias As String)
			Me.es.JoinAlias = joinAlias
        End Sub		
		
        Protected Overrides Function GetQueryName() As String
			Return "CommissionQuery"
		End Function	
		
				

	End Class



	<Serializable> _
	Partial Public Class CommissionMetadata 
		Inherits esMetadata
		Implements IMetadata
		
#Region "Protected Constructor"
		Protected Sub New()
			_columns = New esColumnMetadataCollection()
			Dim c as esColumnMetadata

			c = New esColumnMetadata(CommissionMetadata.ColumnNames.Commissionid, 0, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = CommissionMetadata.PropertyNames.Commissionid
			c.IsInPrimaryKey = True
			c.IsAutoIncrement = True
			c.NumericPrecision = 10
			_columns.Add(c)
				
			c = New esColumnMetadata(CommissionMetadata.ColumnNames.Commissiondate, 1, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = CommissionMetadata.PropertyNames.Commissiondate
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CommissionMetadata.ColumnNames.Salespersonid, 2, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = CommissionMetadata.PropertyNames.Salespersonid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CommissionMetadata.ColumnNames.Custid, 3, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = CommissionMetadata.PropertyNames.Custid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CommissionMetadata.ColumnNames.Invoicenumber, 4, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = CommissionMetadata.PropertyNames.Invoicenumber
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CommissionMetadata.ColumnNames.Commissionamount, 5, GetType(System.Decimal), esSystemType.Decimal)	
			c.PropertyName = CommissionMetadata.PropertyNames.Commissionamount
			c.NumericPrecision = 19
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CommissionMetadata.ColumnNames.Commissionstatus, 6, GetType(System.String), esSystemType.String)	
			c.PropertyName = CommissionMetadata.PropertyNames.Commissionstatus
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CommissionMetadata.ColumnNames.Commissiondesc, 7, GetType(System.String), esSystemType.String)	
			c.PropertyName = CommissionMetadata.PropertyNames.Commissiondesc
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CommissionMetadata.ColumnNames.Commissiontype, 8, GetType(System.String), esSystemType.String)	
			c.PropertyName = CommissionMetadata.PropertyNames.Commissiontype
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CommissionMetadata.ColumnNames.Datecustomerpaid, 9, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = CommissionMetadata.PropertyNames.Datecustomerpaid
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CommissionMetadata.ColumnNames.Datecommissionpaid, 10, GetType(System.DateTime), esSystemType.DateTime)	
			c.PropertyName = CommissionMetadata.PropertyNames.Datecommissionpaid
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CommissionMetadata.ColumnNames.Commissionpmtid, 11, GetType(System.Int32), esSystemType.Int32)	
			c.PropertyName = CommissionMetadata.PropertyNames.Commissionpmtid
			c.NumericPrecision = 10
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CommissionMetadata.ColumnNames.Commissionnote, 12, GetType(System.String), esSystemType.String)	
			c.PropertyName = CommissionMetadata.PropertyNames.Commissionnote
			c.CharacterMaxLength = 200
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CommissionMetadata.ColumnNames.Commissioncategory, 13, GetType(System.String), esSystemType.String)	
			c.PropertyName = CommissionMetadata.PropertyNames.Commissioncategory
			c.CharacterMaxLength = 50
			c.IsNullable = True
			_columns.Add(c)
				
			c = New esColumnMetadata(CommissionMetadata.ColumnNames.Audited, 14, GetType(System.Boolean), esSystemType.Boolean)	
			c.PropertyName = CommissionMetadata.PropertyNames.Audited
			c.HasDefault = True
			c.Default = "((0))"
			c.IsNullable = True
			_columns.Add(c)
				
		End Sub
#End Region		
	
		Shared Public Function Meta() As CommissionMetadata
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
			 Public Const Commissionid As String = "COMMISSIONID"
			 Public Const Commissiondate As String = "COMMISSIONDATE"
			 Public Const Salespersonid As String = "SALESPERSONID"
			 Public Const Custid As String = "CUSTID"
			 Public Const Invoicenumber As String = "INVOICENUMBER"
			 Public Const Commissionamount As String = "COMMISSIONAMOUNT"
			 Public Const Commissionstatus As String = "COMMISSIONSTATUS"
			 Public Const Commissiondesc As String = "COMMISSIONDESC"
			 Public Const Commissiontype As String = "COMMISSIONTYPE"
			 Public Const Datecustomerpaid As String = "DATECUSTOMERPAID"
			 Public Const Datecommissionpaid As String = "DATECOMMISSIONPAID"
			 Public Const Commissionpmtid As String = "COMMISSIONPMTID"
			 Public Const Commissionnote As String = "COMMISSIONNOTE"
			 Public Const Commissioncategory As String = "COMMISSIONCATEGORY"
			 Public Const Audited As String = "AUDITED"
		End Class
#End Region	
		
#Region "PropertyNames"
		Public Class  PropertyNames
			 Public Const Commissionid As String = "Commissionid"
			 Public Const Commissiondate As String = "Commissiondate"
			 Public Const Salespersonid As String = "Salespersonid"
			 Public Const Custid As String = "Custid"
			 Public Const Invoicenumber As String = "Invoicenumber"
			 Public Const Commissionamount As String = "Commissionamount"
			 Public Const Commissionstatus As String = "Commissionstatus"
			 Public Const Commissiondesc As String = "Commissiondesc"
			 Public Const Commissiontype As String = "Commissiontype"
			 Public Const Datecustomerpaid As String = "Datecustomerpaid"
			 Public Const Datecommissionpaid As String = "Datecommissionpaid"
			 Public Const Commissionpmtid As String = "Commissionpmtid"
			 Public Const Commissionnote As String = "Commissionnote"
			 Public Const Commissioncategory As String = "Commissioncategory"
			 Public Const Audited As String = "Audited"
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
            SyncLock GetType(CommissionMetadata)
			
				If CommissionMetadata.mapDelegates Is Nothing Then
					CommissionMetadata.mapDelegates = New Dictionary(Of String, MapToMeta)
				End If			

                If CommissionMetadata._meta Is Nothing Then
                    CommissionMetadata._meta = New CommissionMetadata()
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
				

				meta.AddTypeMap("Commissionid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Commissiondate", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Salespersonid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Custid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Invoicenumber", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Commissionamount", new esTypeMap("money", "System.Decimal"))
				meta.AddTypeMap("Commissionstatus", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Commissiondesc", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Commissiontype", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Datecustomerpaid", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Datecommissionpaid", new esTypeMap("datetime", "System.DateTime"))
				meta.AddTypeMap("Commissionpmtid", new esTypeMap("int", "System.Int32"))
				meta.AddTypeMap("Commissionnote", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Commissioncategory", new esTypeMap("varchar", "System.String"))
				meta.AddTypeMap("Audited", new esTypeMap("bit", "System.Boolean"))			
				
				
				 
				meta.Source = "COMMISSION"
				meta.Destination = "COMMISSION"
				
				meta.spInsert = "proc_COMMISSIONInsert"
				meta.spUpdate = "proc_COMMISSIONUpdate"
				meta.spDelete = "proc_COMMISSIONDelete"
				meta.spLoadAll = "proc_COMMISSIONLoadAll"
				meta.spLoadByPrimaryKey = "proc_COMMISSIONLoadByPrimaryKey"
				
                Me._providerMetadataMaps.Add("esDefault", meta)

            End If

            Return Me._providerMetadataMaps("esDefault")

        End Function
		
#End Region		
		
        Private Shared _meta As CommissionMetadata
        Protected Shared mapDelegates As Dictionary(Of String, MapToMeta)
		Private Shared _esDefault As Integer = RegisterDelegateesDefault()	
		
	End Class
	
End Namespace
